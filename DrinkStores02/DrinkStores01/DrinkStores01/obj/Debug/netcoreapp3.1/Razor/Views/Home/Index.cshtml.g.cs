#pragma checksum "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4d0f36dc75378b52b91a12bd98d7bd2249b66d"
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
#line 1 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\_ViewImports.cshtml"
using DrinkStores01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\_ViewImports.cshtml"
using DrinkStores01.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\_ViewImports.cshtml"
using DrinkStores01.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4d0f36dc75378b52b91a12bd98d7bd2249b66d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0310e302b94a193230f9a57bae35c40fe778ede", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::DrinkStores01.Infastructute.PageLinkTagHelper __DrinkStores01_Infastructute_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
 foreach (var p in Model.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div class=\"col-md-3\" style=\"float: left\">\r\n        <h3>");
#nullable restore
#line 7 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
       Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 8 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
      Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 243, "\"", 255, 1);
#nullable restore
#line 9 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
WriteAttributeValue("", 249, p.Img, 249, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 200px; height:200px;\" />\r\n        <p>");
#nullable restore
#line 10 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
      Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 11 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
      Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4d0f36dc75378b52b91a12bd98d7bd2249b66d5373", async() => {
            }
            );
            __DrinkStores01_Infastructute_PageLinkTagHelper = CreateTagHelper<global::DrinkStores01.Infastructute.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__DrinkStores01_Infastructute_PageLinkTagHelper);
#nullable restore
#line 15 "C:\Users\Anh\source\repos\DrinkStores01\DrinkStores01\Views\Home\Index.cshtml"
__DrinkStores01_Infastructute_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __DrinkStores01_Infastructute_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __DrinkStores01_Infastructute_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
