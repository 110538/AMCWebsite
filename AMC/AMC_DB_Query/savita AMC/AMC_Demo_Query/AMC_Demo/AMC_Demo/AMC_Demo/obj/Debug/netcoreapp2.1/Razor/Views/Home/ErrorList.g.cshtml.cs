#pragma checksum "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302414a7f7148f1a67782f85f439a8f51c9c83c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorList), @"mvc.1.0.view", @"/Views/Home/ErrorList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ErrorList.cshtml", typeof(AspNetCore.Views_Home_ErrorList))]
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
#line 1 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\_ViewImports.cshtml"
using AMC_Demo;

#line default
#line hidden
#line 2 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\_ViewImports.cshtml"
using AMC_Demo.Models;

#line default
#line hidden
#line 1 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302414a7f7148f1a67782f85f439a8f51c9c83c6", @"/Views/Home/ErrorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6936685771197677fa935254aad053ccda5d3d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ErrorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataSet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/ErrorList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
  
    ViewData["Title"] = "ErrorList";


#line default
#line hidden
            BeginContext(84, 20, false);
#line 7 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(104, 32, true);
            WriteLiteral("\r\n<h3>Search Error List</h3>\r\n\r\n");
            EndContext();
            BeginContext(136, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37774eae4a2749e2a5c6d931431c3e55", async() => {
                BeginContext(180, 157, true);
                WriteLiteral("\r\n    <input id=\"Bid\" name=\"Bid\" type=\"text\" value=\"\" />\r\n    <input id=\"Biddate\" name=\"Biddate\" type=\"date\" />\r\n    <input type=\"submit\" value=\"search\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(344, 317, true);
            WriteLiteral(@"


   <div><h4>Search History</h4></div>
   
        <table id=""tbldataSearchHistory"" border=""1"" class=""display"" cellpadding=""0"" cellspacing=""0"" table-layout=""fixed"">
            <tr>
                <th>Bid</th>
                <th>Recorded On</th>
                <th>Search Again</th>
            </tr>
");
            EndContext();
#line 25 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
             foreach (DataRow row in Model.Tables[0].Rows)

            {

#line default
#line hidden
            BeginContext(738, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(785, 6, false);
#line 29 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
                   Write(row[0]);

#line default
#line hidden
            EndContext();
            BeginContext(791, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(823, 6, false);
#line 30 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
                   Write(row[1]);

#line default
#line hidden
            EndContext();
            BeginContext(829, 126, true);
            WriteLiteral("</td>                \r\n                                    \r\n                    <td align=\"center\">\r\n                        ");
            EndContext();
            BeginContext(955, 331, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d1116399c7341ea8a6ae83c1b445bf5", async() => {
                BeginContext(999, 70, true);
                WriteLiteral("\r\n                            <input id=\"Bid\" name=\"Bid\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1069, "\"", 1084, 1);
#line 34 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
WriteAttributeValue("", 1077, row[0], 1077, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1085, 81, true);
                WriteLiteral(" />\r\n                            <input id=\"Biddate\" name=\"Biddate\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1166, "\"", 1181, 1);
#line 35 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
WriteAttributeValue("", 1174, row[1], 1174, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1182, 97, true);
                WriteLiteral(" />\r\n                            <input type=\"submit\" value=\"search\" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1286, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 41 "D:\Savita\Projects\AMC_Demo_Query\AMC_Demo\AMC_Demo\AMC_Demo\Views\Home\ErrorList.cshtml"
            }

#line default
#line hidden
            BeginContext(1355, 31, true);
            WriteLiteral("        </table>\r\n   \r\n\r\n\r\n\r\n\r\n");
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