#pragma checksum "D:\job\GitHub\.netCore\WebAppStudy\WebIdentity\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa634606f6fc942d5a63b63c05d6320cddbccf31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Create.cshtml", typeof(AspNetCore.Views_User_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa634606f6fc942d5a63b63c05d6320cddbccf31", @"/Views/User/Create.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebIdentity.ViewModels.CreateUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\job\GitHub\.netCore\WebAppStudy\WebIdentity\Views\User\Create.cshtml"
  
  ViewBag.Title = "Добавление пользователя";

#line default
#line hidden
            BeginContext(104, 679, true);
            WriteLiteral(@"<form action=""Create"" method=""post"">
  <div class=""form-group"">
    <label for=""Email"" class=""control-label"">Email</label>
    <input type=""text"" id=""Email"" name=""Email"" class=""form-control"" />
  </div>
  <div class=""form-group"">
    <label for=""Password"" class=""control-label"">Пароль</label>
    <input type=""text"" id=""Password"" name=""Password"" class=""form-control"" />
  </div>
  <div class=""form-group"">
    <label for=""Year"" class=""control-label"">Год рождения</label>
    <input type=""number"" id=""Year"" name=""Year"" class=""form-control"" />
  </div>
  <div class=""form-group"">
    <input type=""submit"" value=""Добавить"" class=""btn btn-default"" />
  </div>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebIdentity.ViewModels.CreateUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
