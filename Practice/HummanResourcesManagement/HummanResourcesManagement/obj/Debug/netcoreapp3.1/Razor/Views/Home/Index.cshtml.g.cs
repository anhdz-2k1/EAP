#pragma checksum "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cdd22cf81db97bdee6bc37dbf437619179a01d0"
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
#line 1 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\_ViewImports.cshtml"
using HummanResourcesManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\_ViewImports.cshtml"
using HummanResourcesManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdd22cf81db97bdee6bc37dbf437619179a01d0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8715b4220c5d5705850bff30ccae6a8de7872235", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\Home\Index.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\" style=\"margin-top: 30px\">\r\n        <div class=\"col-md-3\" style=\"float: left\">\r\n            <h3>");
#nullable restore
#line 7 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\Home\Index.cshtml"
           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 8 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\Home\Index.cshtml"
          Write(p.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 9 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\Home\Index.cshtml"
          Write(p.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 272, "\"", 284, 1);
#nullable restore
#line 10 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\Home\Index.cshtml"
WriteAttributeValue("", 278, p.Img, 278, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 200px; height:200px;\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\Anh\source\repos\HummanResourcesManagement\HummanResourcesManagement\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
