#pragma checksum "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c93cbbd7773f29d98eb17ecff6e5c5ddb16a3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
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
#line 1 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\_ViewImports.cshtml"
using StreetPizza;

#line default
#line hidden
#line 2 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\_ViewImports.cshtml"
using StreetPizza.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c93cbbd7773f29d98eb17ecff6e5c5ddb16a3d", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1e0bc06302ec032045cbfb6a8d8e6dfbdb9e9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Tours";

#line default
#line hidden
            BeginContext(65, 162, true);
            WriteLiteral("\r\n<div class=\"menu-page\">\r\n    <h1 class=\"menu-title\">Menu</h1>\r\n    <div class=\"menu-body\">\r\n        <div class=\"container\">\r\n            <div id=\"menu-items\">\r\n");
            EndContext();
#line 12 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
                  
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(319, 77, true);
            WriteLiteral("                        <div class=\"menu-item\">\r\n                            ");
            EndContext();
            BeginContext(396, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39c93cbbd7773f29d98eb17ecff6e5c5ddb16a3d4507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 425, "~/img/pizza/", 425, 12, true);
#line 16 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
AddHtmlAttributeValue("", 437, item.Img, 437, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
AddHtmlAttributeValue("", 453, item.Name, 453, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 109, true);
            WriteLiteral("\r\n                            <div class=\"item-body\">\r\n                                <h2 class=\"item-name\">");
            EndContext();
            BeginContext(577, 9, false);
#line 18 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(586, 81, true);
            WriteLiteral("</h2>\r\n                                <p class=\"item-description border-bottom\">");
            EndContext();
            BeginContext(668, 16, false);
#line 19 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
                                                                     Write(item.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(684, 129, true);
            WriteLiteral("</p>\r\n                                <div class=\"item-order-info\">\r\n                                    <div class=\"item-price\">");
            EndContext();
            BeginContext(814, 15, false);
#line 21 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
                                                       Write(item.PriceLarge);

#line default
#line hidden
            EndContext();
            BeginContext(829, 196, true);
            WriteLiteral("</div>\r\n                                    <button class=\"btn-order\">В кошик</button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 26 "C:\Users\admin\Documents\Visual Studio 2017\Projects\StreetPizza\StreetPizza\Views\Menu\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1067, 93, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
