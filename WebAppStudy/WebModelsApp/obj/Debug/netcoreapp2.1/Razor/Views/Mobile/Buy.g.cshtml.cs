#pragma checksum "D:\job\GitHub\.netCore\WebAppStudy\WebModelsApp\Views\Mobile\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caeae69838c2f7516f43e5fda4b7fe59e7aa1101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_Buy), @"mvc.1.0.view", @"/Views/Mobile/Buy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mobile/Buy.cshtml", typeof(AspNetCore.Views_Mobile_Buy))]
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
#line 1 "D:\job\GitHub\.netCore\WebAppStudy\WebModelsApp\Views\_ViewImports.cshtml"
using WebModelsApp;

#line default
#line hidden
#line 2 "D:\job\GitHub\.netCore\WebAppStudy\WebModelsApp\Views\_ViewImports.cshtml"
using WebModelsApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caeae69838c2f7516f43e5fda4b7fe59e7aa1101", @"/Views/Mobile/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b0db91ff21a584a6020c604e6f901b8d147a2c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Mobile_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\job\GitHub\.netCore\WebAppStudy\WebModelsApp\Views\Mobile\Buy.cshtml"
  
    ViewData["Title"] = "Buy";

#line default
#line hidden
            BeginContext(41, 113, true);
            WriteLiteral("\r\n<div>\r\n    <h3>Форма оформления покупки</h3>\r\n    <p>Для оформления покупки заполните следующие поля:</p>\r\n    ");
            EndContext();
            BeginContext(154, 626, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32ea18b67a64d9cb9fbb76b5719aafe", async() => {
                BeginContext(174, 30, true);
                WriteLiteral("\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 204, "\"", 228, 1);
#line 10 "D:\job\GitHub\.netCore\WebAppStudy\WebModelsApp\Views\Mobile\Buy.cshtml"
WriteAttributeValue("", 212, ViewBag.PhoneId, 212, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(229, 544, true);
                WriteLiteral(@" name=""PhoneId"" />
        <table>
            <tr>
                <td>Имя:</td>
                <td><input type=""text"" name=""User"" /> </td>
            </tr>
            <tr>
                <td>Адрес:</td>
                <td><input type=""text"" name=""Address"" /></td>
            </tr>
            <tr>
                <td>Телефон:</td>
                <td><input type=""text"" name=""ContactPhone"" /></td>
            </tr>
            <tr><td><input type=""submit"" value=""Отправить"" /> </td><td></td></tr>
        </table>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(780, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            DefineSection("MySection", async() => {
                BeginContext(809, 69, true);
                WriteLiteral("\r\n    Все права защищены from BUY PHONE. Site Vadim Bratskyi. 2019.\r\n");
                EndContext();
            }
            );
            BeginContext(881, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
