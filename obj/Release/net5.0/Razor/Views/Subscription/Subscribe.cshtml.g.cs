#pragma checksum "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdbcc0f39191788519dc55ee9c42695127644c84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_Subscribe), @"mvc.1.0.view", @"/Views/Subscription/Subscribe.cshtml")]
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
#line 1 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\_ViewImports.cshtml"
using MemberPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\_ViewImports.cshtml"
using MemberPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbcc0f39191788519dc55ee9c42695127644c84", @"/Views/Subscription/Subscribe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7216ac1859b9bf8d04551214c524c26eb9c89140", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscription_Subscribe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubscriptionService.Models.MemberSubscription>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subscription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllPrescription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdbcc0f39191788519dc55ee9c42695127644c846229", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Subscribe</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bdbcc0f39191788519dc55ee9c42695127644c846588", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bdbcc0f39191788519dc55ee9c42695127644c847766", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdbcc0f39191788519dc55ee9c42695127644c849648", async() => {
                WriteLiteral("\r\n    <div class=\"drugheader\">\r\n        ");
#nullable restore
#line 18 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
   Write(Html.Partial("_partialHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"container\">\r\n        <h4>MemberSubscription</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 25 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayNameFor(model => model.SubscriptionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayFor(model => model.SubscriptionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 31 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayNameFor(model => model.MemberId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayFor(model => model.MemberId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayNameFor(model => model.SubscriptionDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayFor(model => model.SubscriptionDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayNameFor(model => model.PrescriptionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayFor(model => model.PrescriptionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 49 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayNameFor(model => model.RefillOccurrence));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayFor(model => model.RefillOccurrence));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 55 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayNameFor(model => model.MemberLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 58 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayFor(model => model.MemberLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 61 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayNameFor(model => model.SubscriptionStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 64 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
           Write(Html.DisplayFor(model => model.SubscriptionStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <br>\r\n            <br>\r\n            <br>\r\n            <dt class=\"col-sm-2\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdbcc0f39191788519dc55ee9c42695127644c8415461", async() => {
                    WriteLiteral("Back To List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </dt>\r\n\r\n        </dl>\r\n    </div>\r\n    <div class=\"drugfooter\">\r\n        ");
#nullable restore
#line 76 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
   Write(Html.Partial("_partialFooter"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n    if (\'");
#nullable restore
#line 81 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
    Write(ViewBag.MessageSubscribe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'!=\'\')\r\n        alert(\'");
#nullable restore
#line 82 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
          Write(ViewBag.MessageSubscribe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n    if (\'");
#nullable restore
#line 83 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
    Write(ViewBag.MessageUnsubscribe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'!=\'\')\r\n        alert(\'");
#nullable restore
#line 84 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Subscription\Subscribe.cshtml"
          Write(ViewBag.MessageUnsubscribe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n</script>\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubscriptionService.Models.MemberSubscription> Html { get; private set; }
    }
}
#pragma warning restore 1591
