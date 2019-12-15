using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishAquariumWebApp.Enums;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace FishAquariumWebApp.Middlewares
{
    public class AdminMiddleware
    {
        private readonly RequestDelegate _next;

        public AdminMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;
            if (path.HasValue && LetGoAdmin(path.Value))
            {
                if (httpContext.Session.GetString("role") != UserTypes.Admin.ToString())
                {
                    httpContext.Response.Redirect("/PermissionError");
                }
            } 
            else if (path.HasValue && LetGo(path.Value))
            {
                if (httpContext.Session.GetString("role") != UserTypes.User.ToString())
                {
                    httpContext.Response.Redirect("/PermissionError");
                }
            }
            return _next(httpContext);
        }

        private bool LetGoAdmin(string path)
        {
            if (!path.ToLower().StartsWith("/login".ToLower()) &&(
                path.ToLower().StartsWith("/AquariumUsers".ToLower()) ||
                path.ToLower().EndsWith("/Create".ToLower()) ||
                path.ToLower().Contains("/Edit".ToLower()) ||
                path.ToLower().Contains("/Delete".ToLower()) ||
                LetGo(path)
                ))
                return true;
            return false;
        }

        private bool LetGo(string path)
        {
            if (!path.ToLower().StartsWith("/login".ToLower()) && (
                path.ToLower().StartsWith("/Foods/Create".ToLower()) ||
                path.ToLower().StartsWith("/Portions/Create".ToLower()) ||
                path.ToLower().StartsWith("/Foods/Create".ToLower() )||
                path.ToLower().StartsWith("/Foods/Delete".ToLower()) ||
                path.ToLower().StartsWith("/Portions/Delete".ToLower()) ||
                path.ToLower().StartsWith("/AquariumTasks/Edit".ToLower()) ||
                path.ToLower().StartsWith("/ItemParameters/Edit".ToLower() )
                //View tasks with filters

                ))
                return true;
            return false;
        }
    }

    public static class AdminMiddlewareExtensions
    {
        public static IApplicationBuilder UseAdminMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AdminMiddleware>();
        }
    }
}
