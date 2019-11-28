using FishAquariumWebApp.Models;
using FishAquariumWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FishAquariumWebApp.Services
{
    public class RoleService : IRoleService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RoleService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool IsAdmin()
        {
            return _httpContextAccessor.HttpContext.Session.GetString("role") == UserTypes.Admin.ToString();
        }
    }
}
