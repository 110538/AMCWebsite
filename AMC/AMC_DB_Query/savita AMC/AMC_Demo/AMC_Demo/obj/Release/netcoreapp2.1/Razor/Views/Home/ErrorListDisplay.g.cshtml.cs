#pragma checksum "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4865515539fe61356e3f376b092fc267f3b50c9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorListDisplay), @"mvc.1.0.view", @"/Views/Home/ErrorListDisplay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ErrorListDisplay.cshtml", typeof(AspNetCore.Views_Home_ErrorListDisplay))]
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
#line 1 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\_ViewImports.cshtml"
using AMC_Demo;

#line default
#line hidden
#line 2 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\_ViewImports.cshtml"
using AMC_Demo.Models;

#line default
#line hidden
#line 1 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4865515539fe61356e3f376b092fc267f3b50c9f", @"/Views/Home/ErrorListDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6936685771197677fa935254aad053ccda5d3d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ErrorListDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.11.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
  
    ViewData["Title"] = "ErrorListDisplay";

#line default
#line hidden
            BeginContext(90, 31, true);
            WriteLiteral("\r\n<h2>Error List Display</h2>\r\n");
            EndContext();
            BeginContext(122, 47, false);
#line 9 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
Write(Html.ActionLink("Go Back", "ErrorList", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(169, 12, true);
            WriteLiteral("\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(181, 1066, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c16870d1f03413eb70053e133bbadc8", async() => {
                BeginContext(187, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(193, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a26832cc37643348e08ecee752b435e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(242, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(248, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2172a6f97b74d98aacfe8e8c5b71f43", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(293, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(299, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb797d0b25894d14b7f6a6f3385afa3b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(351, 889, true);
                WriteLiteral(@"
  
    <script>
        $.noConflict();
        jQuery(document).ready(function ($) {
            $(function () {
                $('a.dialog').click(function () {
                    var url = $(this).attr('href');
                    var dialog = $('<div style=""display:none""></div>').appendTo('body');
                    dialog.load(url, {},
                        function (responseText, textStatus, XMLHttpRequest) {
                            dialog.dialog({
                                close: function (event, ui) {
                                    dialog.remove();
                                },
                                width: 1000,
                                height: 500,
                            });
                        });
                    return false;
                });
            });
        });
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(1247, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1249, 3011, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f2a14b09a64c309fe851f7de84f65d", async() => {
                BeginContext(1272, 817, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">


            <table id=""tbldata"" border=""1"" style=""border-color:#ddd; border-collapse:collapse;"" class=""table table-striped display"" cellpadding=""0"" cellspacing=""0"" table-layout=""fixed"" align=""center"">
                <thead>
                    <tr>
                        <th>Status</th>
                        <th>Error Message</th>
                        <th>Recorded On</th>
                        <th>Bid</th>
                        <th>Message</th>
                        <th>Event</th>
                        <th>Source System</th>
                        <th>EventId</th>
                        <th>RequestId</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 61 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                     if (Model.Tables.Count == 0) {

#line default
#line hidden
                BeginContext(2140, 46, true);
                WriteLiteral("<tr><td><h3>No Records Found !</h3></td></tr> ");
                EndContext();
#line 61 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                                                                                                 }
                    else
                    {
                            

#line default
#line hidden
#line 64 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                             foreach (DataRow row in Model.Tables[0].Rows)

                            {

#line default
#line hidden
                BeginContext(2347, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(2410, 6, false);
#line 68 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                           Write(row[0]);

#line default
#line hidden
                EndContext();
                BeginContext(2416, 133, true);
                WriteLiteral("</td>\r\n                            <td class=\"text-break\"><div style=\"max-width:150px; min-width:150px;width:150px;overflow:hidden;\">");
                EndContext();
                BeginContext(2550, 6, false);
#line 69 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                                                                                                                         Write(row[1]);

#line default
#line hidden
                EndContext();
                BeginContext(2556, 45, true);
                WriteLiteral("</div></td>\r\n                            <td>");
                EndContext();
                BeginContext(2602, 6, false);
#line 70 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                           Write(row[2]);

#line default
#line hidden
                EndContext();
                BeginContext(2608, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2648, 6, false);
#line 71 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                           Write(row[3]);

#line default
#line hidden
                EndContext();
                BeginContext(2654, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
                BeginContext(2837, 174, true);
                WriteLiteral("                            <td class=\"text-break\"><div style=\"max-width:100px; min-width:100px; max-height:50px; min-height:50px; width:100px; height:50px;overflow:hidden;\">");
                EndContext();
                BeginContext(3012, 142, false);
#line 73 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                                                                                                                                                                         Write(Html.ActionLink(@row[4].ToString(), "MessageDetail", "Home", new { filterName = "Message", filterValue = @row[9] }, new { @class = "dialog" }));

#line default
#line hidden
                EndContext();
                BeginContext(3154, 121, true);
                WriteLiteral(" </div></td>\r\n                            <td class=\"text-break\">\r\n                                <div id=\"targetDiv\">\r\n");
                EndContext();
                BeginContext(3803, 111, true);
                WriteLiteral("\r\n\r\n                                </div>\r\n                            </td>\r\n                            <td>");
                EndContext();
                BeginContext(3915, 6, false);
#line 88 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                           Write(row[5]);

#line default
#line hidden
                EndContext();
                BeginContext(3921, 58, true);
                WriteLiteral("</td>\r\n                            <td class=\"text-break\">");
                EndContext();
                BeginContext(3980, 6, false);
#line 89 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                                              Write(row[6]);

#line default
#line hidden
                EndContext();
                BeginContext(3986, 58, true);
                WriteLiteral("</td>\r\n                            <td class=\"text-break\">");
                EndContext();
                BeginContext(4045, 6, false);
#line 90 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                                              Write(row[7]);

#line default
#line hidden
                EndContext();
                BeginContext(4051, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(4091, 6, false);
#line 91 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                           Write(row[8]);

#line default
#line hidden
                EndContext();
                BeginContext(4097, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 93 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                            }

#line default
#line hidden
#line 93 "D:\Backup\AMC_30_04_2018\AMC\AMC_DB_Query\savita AMC\AMC_Demo\AMC_Demo\Views\Home\ErrorListDisplay.cshtml"
                             
                    }

#line default
#line hidden
                BeginContext(4189, 64, true);
                WriteLiteral("                </tbody>\r\n</table>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4260, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataSet> Html { get; private set; }
    }
}
#pragma warning restore 1591
