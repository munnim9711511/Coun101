#pragma checksum "/home/munnim/Desktop/count1/Views/Admin/UpdateNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206472adf9fba406ecb14faecfc14a0e6f293162"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateNews), @"mvc.1.0.view", @"/Views/Admin/UpdateNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateNews.cshtml", typeof(AspNetCore.Views_Admin_UpdateNews))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206472adf9fba406ecb14faecfc14a0e6f293162", @"/Views/Admin/UpdateNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/munnim/Desktop/count1/Views/Admin/UpdateNews.cshtml"
  
    Layout="~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(54, 73, true);
            WriteLiteral("\n<div ng-controller = \"updateNews\">\n     \n<ul style=\"font-size: large;\">\n");
            EndContext();
#line 8 "/home/munnim/Desktop/count1/Views/Admin/UpdateNews.cshtml"
     foreach (var item in ViewBag.news )
{

#line default
#line hidden
            BeginContext(170, 26, true);
            WriteLiteral("  <li class=\"dh\">\n      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 196, "\"", 252, 1);
#line 11 "/home/munnim/Desktop/count1/Views/Admin/UpdateNews.cshtml"
WriteAttributeValue("", 203, Url.Action("UpdateNew","Admin",new{id=@item.Id}), 203, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(253, 90, true);
            WriteLiteral(">\n           <span>\n <strong>\n          Title:\n\n      </strong>\n      </span>\n     \n      ");
            EndContext();
            BeginContext(344, 10, false);
#line 19 "/home/munnim/Desktop/count1/Views/Admin/UpdateNews.cshtml"
 Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(354, 94, true);
            WriteLiteral("\n\n\n           <span>\n <strong>\n          Date:\n          \n      </strong>\n      </span>\n      ");
            EndContext();
            BeginContext(449, 9, false);
#line 28 "/home/munnim/Desktop/count1/Views/Admin/UpdateNews.cshtml"
 Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(458, 26, true);
            WriteLiteral("\n      </a>\n     \n  </li>\n");
            EndContext();
#line 32 "/home/munnim/Desktop/count1/Views/Admin/UpdateNews.cshtml"
}

#line default
#line hidden
            BeginContext(486, 14, true);
            WriteLiteral("</ul>\n\n\n</div>");
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
