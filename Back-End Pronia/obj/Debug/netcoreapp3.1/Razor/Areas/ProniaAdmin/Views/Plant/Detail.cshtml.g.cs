#pragma checksum "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb503421c9e27ff79e8ffb3af399d4eea7027cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProniaAdmin_Views_Plant_Detail), @"mvc.1.0.view", @"/Areas/ProniaAdmin/Views/Plant/Detail.cshtml")]
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
#line 1 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using Back_End_Pronia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using Back_End_Pronia.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb503421c9e27ff79e8ffb3af399d4eea7027cf9", @"/Areas/ProniaAdmin/Views/Plant/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b16fbb72ce087fed62ca2ff6c88ebbf8ef036f23", @"/Areas/ProniaAdmin/Views/_ViewImports.cshtml")]
    public class Areas_ProniaAdmin_Views_Plant_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; height:90px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height:90px; color: gold;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<div>\r\n    <div>\r\n        <h4>Id: </h4>\r\n        <p>");
#nullable restore
#line 11 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <h4>Name:</h4>\r\n        <p>");
#nullable restore
#line 15 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <h4>Price:</h4>\r\n        <p>");
#nullable restore
#line 19 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <h4>Plant SKU:</h4>\r\n        <p>");
#nullable restore
#line 23 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
      Write(Model.SKU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <h4>Plant Request:</h4>\r\n        <p>");
#nullable restore
#line 27 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
      Write(Model.Request);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <h4>Plant Guarantee:</h4>\r\n        <p>");
#nullable restore
#line 31 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
      Write(Model.Guarantee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <h4>Plant Image:</h4>\r\n        <div>\r\n            <span class=\"mb-3\">Plant image:</span><br />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb503421c9e27ff79e8ffb3af399d4eea7027cf96178", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 736, "~/assets/images/website-images/", 736, 31, true);
#nullable restore
#line 37 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
AddHtmlAttributeValue("", 767, Model.PlantImage.FirstOrDefault(p => p.IsMain == true).ImagePath, 767, 65, false);

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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <span class=\"mb-3\">Plant another image:</span><br />\r\n        <div class=\"d-flex\">\r\n");
#nullable restore
#line 43 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
             foreach (var image in Model.PlantImage.Where(p => p.IsMain == false))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb503421c9e27ff79e8ffb3af399d4eea7027cf98331", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1185, "~/assets/images/website-images/", 1185, 31, true);
#nullable restore
#line 46 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
AddHtmlAttributeValue("", 1216, image.ImagePath, 1216, 16, false);

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
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 48 "D:\Code Yeşil\BackEndGetData\Back-End Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plant> Html { get; private set; }
    }
}
#pragma warning restore 1591
