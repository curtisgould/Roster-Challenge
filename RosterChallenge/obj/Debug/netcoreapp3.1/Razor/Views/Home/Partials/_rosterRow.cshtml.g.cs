#pragma checksum "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efcf0df9f8bd03f2b5e9cfc87a4f60917ffe4102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partials__rosterRow), @"mvc.1.0.view", @"/Views/Home/Partials/_rosterRow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efcf0df9f8bd03f2b5e9cfc87a4f60917ffe4102", @"/Views/Home/Partials/_rosterRow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a6eac8b18439814ba4c849db7260f74a30a006", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partials__rosterRow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Artist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tr data-id=\"");
#nullable restore
#line 3 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml"
        Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <td>\r\n        <div class=\"mx-4 mb-2 mt-2\">\r\n            ");
#nullable restore
#line 6 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml"
       Write(Html.CheckBoxFor(m => m.paid, new { @class = "ml-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </td>\r\n    <td class=\"mx-3 mb-2 mt-2 artist\">\r\n        <div class=\"float-right mx-3 mb-2 mt-2\">");
#nullable restore
#line 10 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml"
                                           Write(Model.artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </td>\r\n    <td>\r\n        <div class=\"mx-3 mb-2 mt-2\">$");
#nullable restore
#line 13 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml"
                                Write(Model.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </td>\r\n    <td>\r\n        <div class=\"float-right mx-3 mb-2 mt-2\">");
#nullable restore
#line 16 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml"
                                           Write(Model.streams.ToString("N").Replace(".00", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </td>\r\n    <td>\r\n        <div class=\"float-right mx-3 mb-2 mt-2\">");
#nullable restore
#line 19 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml"
                                           Write(Model.getTotalPayout().ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </td>\r\n    <td>\r\n        <div class=\"float-right mx-3 mb-2 mt-2\">");
#nullable restore
#line 22 "C:\Users\Curtis\source\repos\Roster-Challenge\RosterChallenge\Views\Home\Partials\_rosterRow.cshtml"
                                           Write(Model.getAverageMonthlyPayout().ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    </td>
    <td>
        <div class=""float-right mx-4 mb-2 mt-2"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil"" viewBox=""0 0 16 16"">
                <path d=""M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5 13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"" />
            </svg>
        </div>
    </td>
    <td>
        <div class=""float-right mx-4 mb-2 mt-2"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash"" viewBox=""0 0 16 16"">
                <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.");
            WriteLiteral(@"5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"" />
                <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"" />
            </svg>
        </div>
    </td>
</tr>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
