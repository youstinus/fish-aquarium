#pragma checksum "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432e5401c8164371c772777973e90342ff4a961c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FishAquariumWebApp.Pages.Fishes.Pages_Fishes_Index), @"mvc.1.0.razor-page", @"/Pages/Fishes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Fishes/Index.cshtml", typeof(FishAquariumWebApp.Pages.Fishes.Pages_Fishes_Index), null)]
namespace FishAquariumWebApp.Pages.Fishes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432e5401c8164371c772777973e90342ff4a961c", @"/Pages/Fishes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed21058faf97ea2753f70f8edecf5973d910236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Fishes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(130, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281f89792ed44521a3365a96c0bd88c1", async() => {
                BeginContext(151, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(165, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 53, false);
#line 17 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].Species));

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 50, false);
#line 20 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].Mass));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 50, false);
#line 23 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].Size));

#line default
#line hidden
            EndContext();
            BeginContext(523, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(579, 52, false);
#line 26 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].Origin));

#line default
#line hidden
            EndContext();
            BeginContext(631, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(687, 57, false);
#line 29 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].ArrivalDate));

#line default
#line hidden
            EndContext();
            BeginContext(744, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(800, 60, false);
#line 32 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].LifeExpectancy));

#line default
#line hidden
            EndContext();
            BeginContext(860, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(916, 57, false);
#line 35 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1029, 52, false);
#line 38 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1137, 56, false);
#line 41 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fishes[0].FkAquarium));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
 foreach (var item in Model.Fishes) {

#line default
#line hidden
            BeginContext(1318, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1367, 42, false);
#line 50 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Species));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1465, 39, false);
#line 53 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mass));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1560, 39, false);
#line 56 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1655, 41, false);
#line 59 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1752, 46, false);
#line 62 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArrivalDate));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1854, 49, false);
#line 65 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LifeExpectancy));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1959, 46, false);
#line 68 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2061, 41, false);
#line 71 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2102, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2158, 45, false);
#line 74 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkAquarium));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2258, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad2a7c653ef4d639dedbb0d64cdbcfb", async() => {
                BeginContext(2303, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2311, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2331, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9efbf9038ca4904a5eba425ab878b13", async() => {
                BeginContext(2379, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2390, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2410, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b55df0d319e4a2e8d0d9131f1025f82", async() => {
                BeginContext(2457, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2467, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 82 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Fishes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2506, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FishAquariumWebApp.Pages.Fishes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.Fishes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.Fishes.IndexModel>)PageContext?.ViewData;
        public FishAquariumWebApp.Pages.Fishes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
