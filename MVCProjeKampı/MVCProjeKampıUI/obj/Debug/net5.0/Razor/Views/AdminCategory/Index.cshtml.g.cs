#pragma checksum "F:\github\myProject_Mikail_Ayan\MVCProjeKampı\MVCProjeKampıUI\Views\AdminCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9493264af8cb3eaab062d6eb3317dc83ae1b802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminCategory_Index), @"mvc.1.0.view", @"/Views/AdminCategory/Index.cshtml")]
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
#line 1 "F:\github\myProject_Mikail_Ayan\MVCProjeKampı\MVCProjeKampıUI\Views\_ViewImports.cshtml"
using MVCProjeKampıUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\github\myProject_Mikail_Ayan\MVCProjeKampı\MVCProjeKampıUI\Views\_ViewImports.cshtml"
using MVCProjeKampıUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9493264af8cb3eaab062d6eb3317dc83ae1b802", @"/Views/AdminCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a32e81574489a2a861f5faf8890de9815e893e6", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\github\myProject_Mikail_Ayan\MVCProjeKampı\MVCProjeKampıUI\Views\AdminCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Kategori</th>
        <th>Durum</th>
    </tr>
    <tr>
        <td>1</td>
        <td>spor</td>
        <td>aktif</td>
    </tr>
    <tr>
        <td>2</td>
        <td>yazılım</td>
        <td>aktif</td>
    </tr>
</table>

");
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
