#pragma checksum "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99bc50f8f745340ebaea47a64e1213e7a6a6b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Exchange), @"mvc.1.0.view", @"/Views/Home/Exchange.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99bc50f8f745340ebaea47a64e1213e7a6a6b49", @"/Views/Home/Exchange.cshtml")]
    public class Views_Home_Exchange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Promotions.Web.UI.Models.Exchange>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
  
    ViewData["Title"] = "Exchange";
    Layout = "~/Pages/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Exchange</h1>\r\n");
#nullable restore
#line 10 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Exchange"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 30 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 33 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\omart\source\repos\Promotions.Web\Promotions.Web\Views\Home\Exchange.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Promotions.Web.UI.Models.Exchange> Html { get; private set; }
    }
}
#pragma warning restore 1591
