#pragma checksum "/home/munnim/Desktop/count1/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df434350e2bd219e69d56be945f78e5b4f28286f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/munnim/Desktop/count1/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/munnim/Desktop/count1/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df434350e2bd219e69d56be945f78e5b4f28286f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/red-circle-with-pdf-icon-png-20.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25px;padding-left: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 85%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 85, true);
            WriteLiteral("\r\n<div class=\"\">\r\n\r\n\r\n    \r\n\r\n    <div class=\"slider\">\r\n        <ul class=\"slides\">\r\n");
            EndContext();
#line 12 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
             foreach (var item in ViewBag.slider)
            {

#line default
#line hidden
            BeginContext(196, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(238, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "755e316f21f54aee88fae5b72117137e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 248, "~/slideImage/", 248, 13, true);
#line 15 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 261, item.ImgUrl, 261, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(275, 297, true);
            WriteLiteral(@" <!-- random image -->
                    <!-- <div class=""caption center-align"">
                        <h3>This is our big Tagline!</h3>
                        <h5 class=""light grey-text text-lighten-3"">Here's our small slogan.</h5>
                    </div> -->
                </li>
");
            EndContext();
#line 21 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(587, 294, true);
            WriteLiteral(@"



        </ul>
    </div>
    <div class="""">
            <div class=""row"">
        <div class=""col m4 s12"">
            <div class=""row"">
   <h5 class=""dh center-align"" style=""font-size: 25px;"" ><strong>    ގެލަރީ   </strong></h5>
            
<hr>
 </div>
 <div class=""row"">
");
            EndContext();
#line 37 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
         foreach (var item in ViewBag.gallery)
     {

#line default
#line hidden
            BeginContext(937, 5, true);
            WriteLiteral("     ");
            EndContext();
            BeginContext(942, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1795987942c45bfac1e9ef6daf20251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 952, "~/gallery/", 952, 10, true);
#line 39 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 962, item.ImgUrl, 962, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(997, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
         
     }

#line default
#line hidden
            BeginContext(1018, 447, true);
            WriteLiteral(@" </div>
           
        <div class=""row"">
   <h5 class=""dh center-align"" style=""font-size: 25px;"" ><strong>    އިސްތިހާރު   </strong></h5>
            
<hr>
 </div>
 <div class=""row"">
 
     
    
 </div> 
           
 


        </div>
        
        <div class=""col m4 s12"">
            
              <h5 class=""dh center-align"" style=""font-size: 25px;"" ><strong>   ފަހުގެ އެންގުންތައް   </strong></h5>
        <hr>
");
            EndContext();
#line 64 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
        foreach (var item in ViewBag.anouncements)
       {

#line default
#line hidden
            BeginContext(1527, 141, true);
            WriteLiteral("          <ul class=\"right-align\">\r\n              <li style=\"font-family: Faruma;direction: rtl;font-size: 20px;\">\r\n              <a href=\"\">");
            EndContext();
            BeginContext(1668, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eb40c73ce7014686b0c85c95545a5ae1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(1768, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1770, 10, false);
#line 68 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
                                                                                                                         Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 43, true);
            WriteLiteral("</a>\r\n             </li>\r\n          </ul>\r\n");
            EndContext();
#line 71 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
           
              
           
       }

#line default
#line hidden
            BeginContext(1875, 204, true);
            WriteLiteral("         \r\n        </div>\r\n        <div class=\"col m4 s12 right\">\r\n           \r\n             <h5 class=\"dh center-align\" style=\"font-size: 25px;\" ><strong>   ފަހުގެ ޙަބަރު   </strong></h5>\r\n        <hr>\r\n");
            EndContext();
#line 81 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
        foreach (var item in ViewBag.news)
       {

#line default
#line hidden
            BeginContext(2133, 74, true);
            WriteLiteral("           <div class=\"row\">\r\n       \r\n               <div class=\"col s4\">");
            EndContext();
            BeginContext(2207, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fa7bde08ddf14951b69fec6028a22a67", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2217, "~/newsImage/", 2217, 12, true);
#line 85 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 2229, item.ImgUrl, 2229, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2286, 106, true);
            WriteLiteral("</div>\r\n                <div class=\"col s8 right-align\"><a class=\"dh right-align\" style=\"font-size: 19px;\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2392, "\"", 2444, 1);
#line 86 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
WriteAttributeValue("", 2399, Url.Action("Index","News",new{id =@item.Id}), 2399, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2445, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2447, 10, false);
#line 86 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
                                                                                                                                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2457, 48, true);
            WriteLiteral("</a></div>\r\n           </div>\r\n           <hr>\r\n");
            EndContext();
#line 89 "/home/munnim/Desktop/count1/Views/Home/Index.cshtml"
           
              
           
       }

#line default
#line hidden
            BeginContext(2557, 69, true);
            WriteLiteral("         \r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n    </div>\r\n\r\n    ");
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
