#pragma checksum "C:\Users\Claudia Silva\MvcMovie\Controllers\Views\HelloWorld\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eab16a1a07df2b43057097140f6b608544457e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Views_HelloWorld_Welcome), @"mvc.1.0.view", @"/Controllers/Views/HelloWorld/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Controllers/Views/HelloWorld/Welcome.cshtml", typeof(AspNetCore.Controllers_Views_HelloWorld_Welcome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eab16a1a07df2b43057097140f6b608544457e8", @"/Controllers/Views/HelloWorld/Welcome.cshtml")]
    public class Controllers_Views_HelloWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Claudia Silva\MvcMovie\Controllers\Views\HelloWorld\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(43, 28, true);
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 8 "C:\Users\Claudia Silva\MvcMovie\Controllers\Views\HelloWorld\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(136, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(149, 19, false);
#line 10 "C:\Users\Claudia Silva\MvcMovie\Controllers\Views\HelloWorld\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(168, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\Claudia Silva\MvcMovie\Controllers\Views\HelloWorld\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(182, 7, true);
            WriteLiteral("</ul>\r\n");
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
