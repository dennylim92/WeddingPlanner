#pragma checksum "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c38fa87d54a319d9cf4176f4bcb57059020c65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeddingInfo), @"mvc.1.0.view", @"/Views/Home/WeddingInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WeddingInfo.cshtml", typeof(AspNetCore.Views_Home_WeddingInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c38fa87d54a319d9cf4176f4bcb57059020c65", @"/Views/Home/WeddingInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeddingInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 268, true);
            WriteLiteral(@"<style>
    .container{
        height: 550px;
        width: 1200px;
    }

    .main{
        height: 600px;
        width: 500px;
        display: inline-block;
        vertical-align: top;
    }
</style>

<div class=""container"">
    <div class=""main"">
        <h1>");
            EndContext();
            BeginContext(284, 15, false);
#line 18 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
       Write(Model.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(299, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(305, 15, false);
#line 18 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
                            Write(Model.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(320, 24, true);
            WriteLiteral("\'s Wedding</h1>\n        ");
            EndContext();
            BeginContext(344, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8feb95e01139438d92c13f6d3e68ee41", async() => {
                BeginContext(370, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(383, 57, true);
            WriteLiteral("\n        <a href=\"logout\">Log Out</a>\n\n        <h3>Date: ");
            EndContext();
            BeginContext(441, 36, false);
#line 22 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
             Write(Model.Date.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(477, 32, true);
            WriteLiteral("</h3>\n\n        <h3>Guests:</h3>\n");
            EndContext();
#line 25 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
         foreach(var guest in Model.Guests)
        {

#line default
#line hidden
            BeginContext(563, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(579, 22, false);
#line 27 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
          Write(guest.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(601, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(603, 21, false);
#line 27 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
                                  Write(guest.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(624, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 28 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(639, 144, true);
            WriteLiteral("    </div>\n\n    <div class=\"main\">\n        <iframe\n            width=\"450\"\n            height=\"450\"\n            frameborder=\"0\" style=\"border:0\"");
            EndContext();
            BeginWriteAttribute("src", "\n            src=\"", 783, "\"", 935, 3);
            WriteAttributeValue("", 801, "https://www.google.com/maps/embed/v1/place?key=AIzaSyDvxBbe3nbNCcnqecuaaZ5yCQtt5CEnNPU", 801, 86, true);
            WriteAttributeValue("\n            ", 887, "&q=", 900, 16, true);
#line 37 "/Users/dennylim/Desktop/CodingDojo/C#_Stack/ORM/WeddingPlanner/Views/Home/WeddingInfo.cshtml"
WriteAttributeValue("", 903, Model.Location.Replace(' ','+'), 903, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(936, 53, true);
            WriteLiteral(" allowfullscreen>\n        </iframe>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591