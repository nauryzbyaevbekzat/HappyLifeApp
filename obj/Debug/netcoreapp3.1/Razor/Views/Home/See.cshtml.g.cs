#pragma checksum "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a00292e3ec67aeabc74f0e6008e56d779b93cf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_See), @"mvc.1.0.view", @"/Views/Home/See.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a00292e3ec67aeabc74f0e6008e56d779b93cf5", @"/Views/Home/See.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95a263559078be4885c0f4d5027b228d1372bda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_See : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HappyLife.Models.Record>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>

<h3>Uncompleted work</h3>
<br>
<table class=""table table-striped"">
    <thead>
        <tr class=""table-primary"">
          
            <td>Label</td>
            <td></td>
           
            <td>IN</td>
            <td></td>
            <td>OUT</td>
            <td></td>
           

        </tr>
    </thead>

");
#nullable restore
#line 25 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
     foreach (var item in Model.Where(p => p.InWork == false))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr class=\"table-primary\">\r\n               \r\n                <td>");
#nullable restore
#line 30 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n                \r\n                <td>");
#nullable restore
#line 33 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
               Write(item.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
               Write(item.End);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n                \r\n     \r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 41 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>
<br>
<h3>Сompleted work</h3>
<br>
<table class=""table table-striped"">
<thead>
    <tr class=""table-primary"">
       
        <td>Label</td>
        <td></td>
        
        <td>IN</td>
        <td></td>
        <td>OUT</td>
        
        <td></td>
        <td></td>

    </tr>
</thead>

");
#nullable restore
#line 63 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
 foreach (var item in Model.Where(p => p.InWork == true))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tbody>\r\n        <tr class=\"table-primary\">\r\n           \r\n            <td>");
#nullable restore
#line 68 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          \r\n            <td></td>\r\n            <td>");
#nullable restore
#line 71 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
           Write(item.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 73 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
           Write(item.End);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td></td>\r\n            <td></td>\r\n\r\n        </tr>\r\n    </tbody>\r\n");
#nullable restore
#line 80 "C:\Users\USER\source\repos\HappyLife\Views\Home\See.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HappyLife.Models.Record>> Html { get; private set; }
    }
}
#pragma warning restore 1591