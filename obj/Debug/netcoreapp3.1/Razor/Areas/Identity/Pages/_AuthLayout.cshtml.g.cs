#pragma checksum "E:\dotnet\Admin Sample\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "829a988ed5ac48126e867334ef1c6d17c201252f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "E:\dotnet\Admin Sample\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\dotnet\Admin Sample\Areas\Identity\Pages\_ViewImports.cshtml"
using iPOS.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\dotnet\Admin Sample\Areas\Identity\Pages\_ViewImports.cshtml"
using iPOS.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\dotnet\Admin Sample\Areas\Identity\Pages\_ViewImports.cshtml"
using iPOS.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829a988ed5ac48126e867334ef1c6d17c201252f", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0ad85fb2f1e7ddcac13da47d04e2eb72137e6cb", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\dotnet\Admin Sample\Areas\Identity\Pages\_AuthLayout.cshtml"
  
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 6 "E:\dotnet\Admin Sample\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "E:\dotnet\Admin Sample\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<script>
    $(function () {
        var current = location.pathname;
        $('.nav-tabs li a').each(function(){
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');
            }
        })
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
