#pragma checksum "D:\desk\count1\Views\Admin\UpdateNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6ddf5b8e4a18766639218ac2637e700189e15d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateNew), @"mvc.1.0.view", @"/Views/Admin/UpdateNew.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateNew.cshtml", typeof(AspNetCore.Views_Admin_UpdateNew))]
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
#line 1 "D:\desk\count1\Views\_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "D:\desk\count1\Views\_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6ddf5b8e4a18766639218ac2637e700189e15d", @"/Views/Admin/UpdateNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\desk\count1\Views\Admin\UpdateNew.cshtml"
  
    Layout="~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(57, 31, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(88, 1294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb184de8c9bc46b9970ef5a3cbbf95f2", async() => {
                BeginContext(181, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\desk\count1\Views\Admin\UpdateNew.cshtml"
     foreach (var item in    ViewBag.news)
    {

#line default
#line hidden
                BeginContext(234, 121, true);
                WriteLiteral("         <div class=\"row\">\r\n            <div class=\"col m8 input-field\">\r\n                <input type=\"text\" name=\"Title\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 355, "\"", 374, 1);
#line 11 "D:\desk\count1\Views\Admin\UpdateNew.cshtml"
WriteAttributeValue("", 363, item.Title, 363, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(375, 254, true);
                WriteLiteral(" style=\"font-family: Faruma;direction: rtl;\">\r\n                <label for=\"\">Title</label>\r\n            </div>\r\n        </div> \r\n          <div class=\"row hide\">\r\n            <div class=\"col m8 input-field\">\r\n                <input type=\"Id\" name=\"Title\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 629, "\"", 645, 1);
#line 17 "D:\desk\count1\Views\Admin\UpdateNew.cshtml"
WriteAttributeValue("", 637, item.Id, 637, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(646, 553, true);
                WriteLiteral(@" style=""font-family: Faruma;direction: rtl;"">
                <label for="""">Id</label>
            </div>
        </div>
         <!-- <div class=""row"">
            <div class=""col m8"">
                <label for="""">Image</label>
                <br>

                <input type=""file"" name=""""  value="""">
            </div>
        </div> -->
        <div class=""row"">
            <div class=""col m8 input-field"">
          <textarea id=""textarea1"" class=""materialize-textarea dh "" name=""Text"" style=""direction: rtl;text-align: justify;"">");
                EndContext();
                BeginContext(1200, 9, false);
#line 31 "D:\desk\count1\Views\Admin\UpdateNew.cshtml"
                                                                                                                       Write(item.Text);

#line default
#line hidden
                EndContext();
                BeginContext(1209, 95, true);
                WriteLiteral("</textarea>\r\n                <label for=\"\">News</label>\r\n            </div>\r\n        </div>  \r\n");
                EndContext();
#line 35 "D:\desk\count1\Views\Admin\UpdateNew.cshtml"


    }

#line default
#line hidden
                BeginContext(1315, 60, true);
                WriteLiteral("      <input type=\"submit\" value=\"update\" class=\"btn\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\desk\count1\Views\Admin\UpdateNew.cshtml"
AddHtmlAttributeValue("", 102, Url.Action("UpdateNews","Admin"), 102, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1382, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
