#pragma checksum "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8acf1861ab35f68596362307b146d68f5eed7c93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drug_GetAllDrugs), @"mvc.1.0.view", @"/Views/Drug/GetAllDrugs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8acf1861ab35f68596362307b146d68f5eed7c93", @"/Views/Drug/GetAllDrugs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7216ac1859b9bf8d04551214c524c26eb9c89140", @"/Views/_ViewImports.cshtml")]
    public class Views_Drug_GetAllDrugs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MemberPortal.Models.Drug>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
  
    ViewData["Title"] = "GetAllDrugs";
    Layout = "";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8acf1861ab35f68596362307b146d68f5eed7c935423", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8acf1861ab35f68596362307b146d68f5eed7c935803", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8acf1861ab35f68596362307b146d68f5eed7c936981", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8acf1861ab35f68596362307b146d68f5eed7c938863", async() => {
                WriteLiteral("\r\n    <div class=\"drugheader\">\r\n        ");
#nullable restore
#line 18 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
   Write(Html.Partial("_partialHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"drugcontents\" style=\"margin-top:20px;\">\r\n        <div class=\"row\" style=\"margin-left:20px;\">\r\n            <div class=\"col-md-5\">\r\n");
#nullable restore
#line 24 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                 using (Html.BeginForm("GetById", "Drug", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8acf1861ab35f68596362307b146d68f5eed7c939910", async() => {
                    WriteLiteral(@"
                        <div class=""col-auto"" style=""display: inline-block; margin-left:90px; width:250px"">
                            <input type=""number"" class=""form-control"" name=""Id"" placeholder=""Enter Drug Id"">
                        </div>
                        <div class=""col-auto"" style=""float: right; margin:0 130px 0 10px;"">
                            <button type=""submit"" class=""btn btn-primary mb-3"">Search</button>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n               \r\n            <div class=\"col-md-2 text-center\">\r\n                <span>|</span>\r\n            </div>\r\n\r\n            <div class=\"col-md-5\">\r\n");
#nullable restore
#line 43 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                 using (Html.BeginForm("GetByName", "Drug", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8acf1861ab35f68596362307b146d68f5eed7c9312542", async() => {
                    WriteLiteral(@"
                        <div class=""col-auto"" style=""display: inline-block; margin-left:90px; width:250px"">
                            <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Enter Drug Name"">
                        </div>
                        <div class=""col-auto"" style=""float: right; margin:0 130px 0 10px;"">
                            <button type=""submit"" class=""btn btn-primary mb-3"">Search</button>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>

        </div>       

        <hr />

        <h2 style=""text-align:center"" class=""active"">Listed All Drugs</h2>
        <table class=""table"">

            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 66 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 72 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                   Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 75 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                   Write(Html.DisplayNameFor(model => model.ManufacturedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 78 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                   Write(Html.DisplayNameFor(model => model.ExpiryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 81 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                   Write(Html.DisplayNameFor(model => model.QtyLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 87 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td style=\"padding-top:95px;\">\r\n                            ");
#nullable restore
#line 91 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"padding-top:95px;\">\r\n                            ");
#nullable restore
#line 94 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"padding-top:95px;\">\r\n                            ");
#nullable restore
#line 97 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Manufacturer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"padding-top:95px;\">\r\n                            ");
#nullable restore
#line 100 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ManufacturedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td style=\"padding-top:95px;\">\r\n                            ");
#nullable restore
#line 103 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ExpiryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 106 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                             foreach (var locqty in item.QtyLocation)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>");
#nullable restore
#line 108 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                              Write(Html.DisplayFor(modelItem => locqty.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("---");
#nullable restore
#line 108 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => locqty.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 109 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 114 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"drugfooter\">\r\n        ");
#nullable restore
#line 120 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
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
#line 125 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
    Write(ViewBag.MessageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'!=\'\')\r\n        alert(\'");
#nullable restore
#line 126 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
          Write(ViewBag.MessageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n    if (\'");
#nullable restore
#line 127 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
    Write(ViewBag.MessageStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'!=\'\')\r\n        alert(\'");
#nullable restore
#line 128 "C:\Users\Razj\Desktop\Project\MemberPortal\MemberPortal\Views\Drug\GetAllDrugs.cshtml"
          Write(ViewBag.MessageStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n</script>\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MemberPortal.Models.Drug>> Html { get; private set; }
    }
}
#pragma warning restore 1591
