#pragma checksum "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc771d5a845298fd0598b00ce8f0b00acf7fb21a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Acces), @"mvc.1.0.view", @"/Views/Home/Acces.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\HappyLife\Views\_ViewImports.cshtml"
using HappyLife;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\HappyLife\Views\_ViewImports.cshtml"
using HappyLife.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc771d5a845298fd0598b00ce8f0b00acf7fb21a", @"/Views/Home/Acces.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95a263559078be4885c0f4d5027b228d1372bda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Acces : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HappyLife.Models.User>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
  
    ViewData["Title"] = "Acces";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
<h3>Give acces </h3>
<br>
<table class=""table table-striped"">
<thead>
    <tr class=""table-primary"">
        <td>UserId</td>
        <td></td>
        <td>Name</td>
        <td></td>

        <td>Surname</td>
        <td></td>
        <td>Email</td>
        <td></td>
        <td>Give Acces</td>
      

    </tr>
</thead>

");
#nullable restore
#line 26 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
 foreach (var item in Model.Where(p=> p.Email != User.Identity.Name))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tbody>\r\n        <tr class=\"table-primary\">\r\n            <td>");
#nullable restore
#line 30 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
           Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n\r\n            <td>");
#nullable restore
#line 35 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            \r\n             <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc771d5a845298fd0598b00ce8f0b00acf7fb21a4948", async() => {
                WriteLiteral("Give Access");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 829, "~/Home/Give/", 829, 12, true);
#nullable restore
#line 40 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
AddHtmlAttributeValue("", 841, item.UserId, 841, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n    </tbody>\r\n");
#nullable restore
#line 44 "C:\Users\USER\source\repos\HappyLife\Views\Home\Acces.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HappyLife.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
