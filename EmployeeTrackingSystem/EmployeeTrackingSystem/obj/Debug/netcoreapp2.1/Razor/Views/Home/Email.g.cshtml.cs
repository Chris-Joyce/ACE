#pragma checksum "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2595edd1a2f312102cea333ba5802f3a6aa9f265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Email), @"mvc.1.0.view", @"/Views/Home/Email.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Email.cshtml", typeof(AspNetCore.Views_Home_Email))]
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
#line 1 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\_ViewImports.cshtml"
using EmployeeTrackingSystem;

#line default
#line hidden
#line 2 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\_ViewImports.cshtml"
using EmployeeTrackingSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2595edd1a2f312102cea333ba5802f3a6aa9f265", @"/Views/Home/Email.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1875d9bf724df3fb0ed12bca02f94f5233b02d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Email : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeTrackingSystem.Models.EmailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ACElogo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ACE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
  
    ViewBag.Title = "Email";

#line default
#line hidden
            BeginContext(86, 56, true);
            WriteLiteral("\r\n<table style=\"width:250%\">\r\n    <tr>\r\n        <th><h2>");
            EndContext();
            BeginContext(142, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbf8e27f286e499788ad3f95135b866f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 17, false);
#line 8 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
                                                                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(216, 22, true);
            WriteLiteral("</h2></th>\r\n</table>\r\n");
            EndContext();
#line 10 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
 using (Html.BeginForm("Send", "Email", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(356, 23, false);
#line 12 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(381, 40, true);
            WriteLiteral("    <h4>Send an Email</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(426, 58, false);
#line 15 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 15 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
                                                               

    if (ViewBag.Success != null && (bool)ViewBag.Success)
    {

#line default
#line hidden
            BeginContext(554, 50, true);
            WriteLiteral("        <h2 class=\"text-danger\">Email sent.</h2>\r\n");
            EndContext();
#line 20 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
    }
    else if (ViewBag.Success != null && !(bool)ViewBag.Success)
    {

#line default
#line hidden
            BeginContext(683, 58, true);
            WriteLiteral("        <h2 class=\"text-danger\">retry sending email</h2>\r\n");
            EndContext();
#line 24 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
    }



#line default
#line hidden
            BeginContext(752, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(791, 69, false);
#line 28 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
   Write(Html.LabelFor(m => m.From, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(860, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(908, 61, false);
#line 30 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
       Write(Html.TextBoxFor(m => m.From, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(969, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1038, 67, false);
#line 34 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
   Write(Html.LabelFor(m => m.To, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1153, 59, false);
#line 36 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
       Write(Html.TextBoxFor(m => m.To, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1281, 67, false);
#line 40 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
   Write(Html.LabelFor(m => m.Cc, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1396, 59, false);
#line 42 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
       Write(Html.TextBoxFor(m => m.Cc, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1524, 72, false);
#line 46 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
   Write(Html.LabelFor(m => m.Subject, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1644, 64, false);
#line 48 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
       Write(Html.TextBoxFor(m => m.Subject, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1777, 69, false);
#line 52 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
   Write(Html.LabelFor(m => m.Body, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1894, 62, false);
#line 54 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
       Write(Html.TextAreaFor(m => m.Body, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 249, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Send\" />\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2206, 69, false);
#line 63 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
   Write(Html.LabelFor(m => m.Sent, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 103, true);
            WriteLiteral("\r\n        <textarea id=\"viewEmails\" readonly rows=\"10\" cols=\"30\" float=\"left\"></textarea>\r\n    </div>\r\n");
            EndContext();
#line 66 "D:\Desktop\ace\EmployeeTrackingSystem\EmployeeTrackingSystem\Views\Home\Email.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeTrackingSystem.Models.EmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
