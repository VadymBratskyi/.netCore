#pragma checksum "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8c5d2780d4c79a0980b1c74ff4f8f7efa4995d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factory_Index2), @"mvc.1.0.view", @"/Views/Factory/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Factory/Index2.cshtml", typeof(AspNetCore.Views_Factory_Index2))]
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
#line 1 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
using FactoryPatern.Models.Car2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c5d2780d4c79a0980b1c74ff4f8f7efa4995d7", @"/Views/Factory/Index2.cshtml")]
    public class Views_Factory_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car2>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Factory2.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
  
  ViewData["Title"] = "Factory";

#line default
#line hidden
            BeginContext(88, 47, true);
            WriteLiteral("\r\n<h2>Factory</h2>\r\n<table>\r\n  <tr>\r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 135, "\"", 172, 1);
#line 10 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
WriteAttributeValue("", 142, Url.Action("Index","Factory"), 142, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(173, 77, true);
            WriteLiteral(">Car1</a></td>\r\n    <td style=\"background-color: greenyellow; color: red;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 250, "\"", 288, 1);
#line 11 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
WriteAttributeValue("", 257, Url.Action("Index2","Factory"), 257, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(289, 98, true);
            WriteLiteral(">Car2</a></td>\r\n  </tr>\r\n</table>\r\n<table>\r\n  <tr>\r\n    <td>\r\n      <div>\r\n        <p>\r\n          ");
            EndContext();
            BeginContext(388, 17, false);
#line 19 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
     Write(Model.Configure());

#line default
#line hidden
            EndContext();
            BeginContext(405, 18, true);
            WriteLiteral("<br />\r\n          ");
            EndContext();
            BeginContext(424, 20, false);
#line 20 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
     Write(Model.AssembleBody());

#line default
#line hidden
            EndContext();
            BeginContext(444, 18, true);
            WriteLiteral("<br />\r\n          ");
            EndContext();
            BeginContext(463, 21, false);
#line 21 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
     Write(Model.InstallEngine());

#line default
#line hidden
            EndContext();
            BeginContext(484, 18, true);
            WriteLiteral("<br />\r\n          ");
            EndContext();
            BeginContext(503, 13, false);
#line 22 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
     Write(Model.Paint());

#line default
#line hidden
            EndContext();
            BeginContext(516, 18, true);
            WriteLiteral("<br />\r\n          ");
            EndContext();
            BeginContext(535, 21, false);
#line 23 "C:\Users\Vadim-PC\source\repos\WebAppPaterns\WebAppPaterns\Views\Factory\Index2.cshtml"
     Write(Model.InstallWheels());

#line default
#line hidden
            EndContext();
            BeginContext(556, 63, true);
            WriteLiteral("<br />\r\n        </p>\r\n      </div>\r\n    </td>\r\n    <td>\r\n      ");
            EndContext();
            BeginContext(619, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bf9bc7d68c14d50a1e2b340258e774b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(661, 35, true);
            WriteLiteral("\r\n    </td>\r\n  </tr>\r\n</table>\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car2> Html { get; private set; }
    }
}
#pragma warning restore 1591
