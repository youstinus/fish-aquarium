#pragma checksum "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf219116f304f4c2465804f3912cad82505ee42a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FishAquariumWebApp.Pages.Aquariums.Pages_Aquariums_Details), @"mvc.1.0.razor-page", @"/Pages/Aquariums/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Aquariums/Details.cshtml", typeof(FishAquariumWebApp.Pages.Aquariums.Pages_Aquariums_Details), null)]
namespace FishAquariumWebApp.Pages.Aquariums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf219116f304f4c2465804f3912cad82505ee42a", @"/Pages/Aquariums/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed21058faf97ea2753f70f8edecf5973d910236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Aquariums_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(108, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Aquarium</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 53, false);
#line 15 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aquarium.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(328, 49, false);
#line 18 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aquarium.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(377, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(421, 49, false);
#line 21 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aquarium.Mass));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 45, false);
#line 24 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aquarium.Mass));

#line default
#line hidden
            EndContext();
            BeginContext(559, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(603, 51, false);
#line 27 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aquarium.Length));

#line default
#line hidden
            EndContext();
            BeginContext(654, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(698, 47, false);
#line 30 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aquarium.Length));

#line default
#line hidden
            EndContext();
            BeginContext(745, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(789, 50, false);
#line 33 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aquarium.Width));

#line default
#line hidden
            EndContext();
            BeginContext(839, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(883, 46, false);
#line 36 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aquarium.Width));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(973, 51, false);
#line 39 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aquarium.Heigth));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1068, 47, false);
#line 42 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aquarium.Heigth));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1159, 59, false);
#line 45 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aquarium.GlassThickness));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1262, 55, false);
#line 48 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aquarium.GlassThickness));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1361, 54, false);
#line 51 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aquarium.FkPortion));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1459, 50, false);
#line 54 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aquarium.FkPortion));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1556, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "023cead0210e466c9405eca1e630dc0a", async() => {
                BeginContext(1611, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\repo\projects\PseudoZuvytes\Zuvytes\src\server-core\FishAquariumWebApp\Pages\Aquariums\Details.cshtml"
                           WriteLiteral(Model.Aquarium.Id);

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
            BeginContext(1619, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1627, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a41b5e9c8f4aa68cb2cbb602567bba", async() => {
                BeginContext(1649, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FishAquariumWebApp.Pages.Aquariums.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.Aquariums.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FishAquariumWebApp.Pages.Aquariums.DetailsModel>)PageContext?.ViewData;
        public FishAquariumWebApp.Pages.Aquariums.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591