#pragma checksum "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Shared\Dialogs\_confirmModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b46d43b76336918104301a1abe957288a6d11ce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Dialogs__confirmModal), @"mvc.1.0.view", @"/Views/Shared/Dialogs/_confirmModal.cshtml")]
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
#line 1 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\_ViewImports.cshtml"
using RosterChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\_ViewImports.cshtml"
using RosterChallenge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b46d43b76336918104301a1abe957288a6d11ce4", @"/Views/Shared/Dialogs/_confirmModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a6eac8b18439814ba4c849db7260f74a30a006", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Dialogs__confirmModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""confirmBackdrop"" class=""modal-backdrop"" style=""display: none;""></div>
<div id=""confirmModal"" class=""modal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header fw-bold""></div>
            <div class=""modal-body"">
                
            </div>
            <div class=""modal-footer"">
                <button id=""ConfirmNoButton"">No</button>
                <button id=""ConfirmYesButton"">Yes</button>
            </div>
        </div>
    </div>
</div>");
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
