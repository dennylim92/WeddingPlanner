#pragma checksum "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a2c750d32a5a19aab35bc198cbb85b3e26d5a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2c750d32a5a19aab35bc198cbb85b3e26d5a2a", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(21, 458, true);
            WriteLiteral(@"
<style>
    table {
    border-collapse: collapse;
}
th {
    background-color: #ccc;
    padding: 2px;
}
table, th, td {
    border: 1px solid black;
}

tr:nth-child(even) {background-color: #f2f2f2;}

td {
    padding: 5px;
    text-align: left;
}
</style>


<h1>Welcome to the Wedding Planner</h1>
<a href=""logout"">Log Out</a>
<hr>
<table>
    <tr>
        <th>Wedding</th>
        <th>Date</th>
        <th>Guest</th>
        <th>Action</th>
    </tr>

");
            EndContext();
#line 35 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
 foreach (Wedding wedding in Model)
{

#line default
#line hidden
            BeginContext(517, 23, true);
            WriteLiteral("    <tr>\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 540, "\"", 571, 2);
            WriteAttributeValue("", 547, "/info/", 547, 6, true);
#line 38 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 553, wedding.WeddingId, 553, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(572, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(574, 17, false);
#line 38 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                          Write(wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(591, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(595, 17, false);
#line 38 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                               Write(wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(612, 22, true);
            WriteLiteral("</a></td>\n        <td>");
            EndContext();
            BeginContext(635, 37, false);
#line 39 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
       Write(wedding.Date.ToString("MMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(672, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(691, 20, false);
#line 40 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
       Write(wedding.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(711, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 41 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
         if (wedding.UserId == @ViewBag.idUser)
        {

#line default
#line hidden
            BeginContext(775, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 793, "\"", 826, 2);
            WriteAttributeValue("", 800, "/delete/", 800, 8, true);
#line 43 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 808, wedding.WeddingId, 808, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(827, 17, true);
            WriteLiteral(">Delete</a></td>\n");
            EndContext();
#line 44 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
        }
        else if(wedding.Guests.Any(g => g.UserId == @ViewBag.idUser))
        {

#line default
#line hidden
            BeginContext(934, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 952, "\"", 985, 2);
            WriteAttributeValue("", 959, "/unrsvp/", 959, 8, true);
#line 47 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 967, wedding.WeddingId, 967, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(986, 18, true);
            WriteLiteral(">Un-RSVP</a></td>\n");
            EndContext();
#line 48 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1037, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1055, "\"", 1086, 2);
            WriteAttributeValue("", 1062, "/rsvp/", 1062, 6, true);
#line 51 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1068, wedding.WeddingId, 1068, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1087, 15, true);
            WriteLiteral(">RSVP</a></td>\n");
            EndContext();
#line 52 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(1112, 10, true);
            WriteLiteral("    </tr>\n");
            EndContext();
#line 54 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/Dashboard.cshtml"
}

#line default
#line hidden
            BeginContext(1124, 14, true);
            WriteLiteral("</table>\n<br>\n");
            EndContext();
            BeginContext(1138, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1181a70aba00497f9fcf95fa147decca", async() => {
                BeginContext(1160, 47, true);
                WriteLiteral("\n    <input type=\"submit\" value=\"New Wedding\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591