#pragma checksum "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ce5f686f9fc88da8f870271f7df9aa34e954e75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factory_Index), @"mvc.1.0.view", @"/Views/Factory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Factory/Index.cshtml", typeof(AspNetCore.Views_Factory_Index))]
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
#line 1 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
using FactoryPatern.Models.Car1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce5f686f9fc88da8f870271f7df9aa34e954e75", @"/Views/Factory/Index.cshtml")]
    public class Views_Factory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Factory.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("  ");
            EndContext();
#line 3 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
    
    ViewData["Title"] = "Factory";
  

#line default
#line hidden
            BeginContext(93, 98, true);
            WriteLiteral("\r\n<h2>Factory</h2>\r\n<table>\r\n  <tr>\r\n    <td style=\"background-color: greenyellow; color: red;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 191, "\"", 228, 1);
#line 10 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
WriteAttributeValue("", 198, Url.Action("Index","Factory"), 198, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(229, 26, true);
            WriteLiteral(">Car1</a></td>\r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 255, "\"", 293, 1);
#line 11 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
WriteAttributeValue("", 262, Url.Action("Index2","Factory"), 262, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(294, 110, true);
            WriteLiteral(">Car2</a></td>\r\n  </tr>\r\n</table>\r\n  <table>\r\n    <tr>\r\n      <td>\r\n        <div>\r\n          <p>\r\n            ");
            EndContext();
            BeginContext(405, 17, false);
#line 19 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
       Write(Model.Configure());

#line default
#line hidden
            EndContext();
            BeginContext(422, 20, true);
            WriteLiteral("<br />\r\n            ");
            EndContext();
            BeginContext(443, 20, false);
#line 20 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
       Write(Model.AssembleBody());

#line default
#line hidden
            EndContext();
            BeginContext(463, 20, true);
            WriteLiteral("<br />\r\n            ");
            EndContext();
            BeginContext(484, 21, false);
#line 21 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
       Write(Model.InstallEngine());

#line default
#line hidden
            EndContext();
            BeginContext(505, 20, true);
            WriteLiteral("<br />\r\n            ");
            EndContext();
            BeginContext(526, 13, false);
#line 22 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
       Write(Model.Paint());

#line default
#line hidden
            EndContext();
            BeginContext(539, 20, true);
            WriteLiteral("<br />\r\n            ");
            EndContext();
            BeginContext(560, 21, false);
#line 23 "D:\VadimB\Projects\.netCore\WebAppPaterns\WebAppPaterns\Views\Factory\Index.cshtml"
       Write(Model.InstallWheels());

#line default
#line hidden
            EndContext();
            BeginContext(581, 73, true);
            WriteLiteral("<br />\r\n          </p>\r\n        </div>\r\n      </td>\r\n      <td>\r\n        ");
            EndContext();
            BeginContext(654, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5de631fce8d244d080c8573d1d2bb620", async() => {
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
            BeginContext(695, 41, true);
            WriteLiteral("\r\n      </td>\r\n    </tr>\r\n  </table>\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
