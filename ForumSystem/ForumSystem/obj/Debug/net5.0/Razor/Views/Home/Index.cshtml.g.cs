#pragma checksum "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "591215cde8ee662e5987049abf09fc49e5469d7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\_ViewImports.cshtml"
using ForumSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\_ViewImports.cshtml"
using ForumSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\_ViewImports.cshtml"
using ForumSystem.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\_ViewImports.cshtml"
using ForumSystem.Models.Posts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"591215cde8ee662e5987049abf09fc49e5469d7b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ae1f789b57315a6537d7b3cad148d84b9938a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListCategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("vary-by-query", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllPosts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h3 class=\"display-4\">");
#nullable restore
#line 12 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
                     Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591215cde8ee662e5987049abf09fc49e5469d7b5502", async() => {
                WriteLiteral("\r\n        <h4 class=\"display-3\">");
#nullable restore
#line 14 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
                         Write(DateTime.UtcNow);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
#nullable restore
#line 13 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter = TimeSpan.FromDays(10);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("expires-after", __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.VaryByQuery = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <!--<a asp-controller=\"Posts\" asp-action=\"Create\" class=\"btn btn-primary btn-lg\">Create new forum post</a>-->\r\n</div>\r\n<hr />\r\n<hr />\r\n\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
     foreach (var category in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\" media>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 579, "\"", 603, 1);
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 585, category.ImageUrl, 585, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" class=\"mr-3\"");
            BeginWriteAttribute("alt", " alt=\"", 629, "\"", 649, 1);
#nullable restore
#line 26 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 635, category.Name, 635, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591215cde8ee662e5987049abf09fc49e5469d7b9065", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 30 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
                   Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 30 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
                                   Write(category.PostsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
                                                                              WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </h5>             \r\n            </div>\r\n        </div>\r\n        <h5></h5>\r\n");
#nullable restore
#line 36 "C:\Users\HP\Documents\Kurs_SoftUni\AA_C#_ASP_NET_Core_may_2021_my\5000_ForumSystem\14ForumSystemApi\ForumSystem\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
