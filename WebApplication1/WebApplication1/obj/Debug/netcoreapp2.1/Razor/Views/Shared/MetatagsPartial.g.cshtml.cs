#pragma checksum "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb90d56395527be2885fbf8cc7ab33d1ef1ac10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MetatagsPartial.cshtml", typeof(AspNetCore.Views_Shared_MetatagsPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb90d56395527be2885fbf8cc7ab33d1ef1ac10", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 118, true);
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n\r\n");
            EndContext();
#line 4 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
            BeginContext(150, 11, true);
            WriteLiteral("    <title>");
            EndContext();
            BeginContext(162, 13, false);
#line 6 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(175, 10, true);
            WriteLiteral("</title>\r\n");
            EndContext();
#line 7 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(197, 34, true);
            WriteLiteral("    <title>Мой кинотеатр</title>\r\n");
            EndContext();
#line 11 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
            BeginContext(234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
            BeginContext(274, 28, true);
            WriteLiteral("    <meta name=\"description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 302, "\"", 332, 1);
#line 15 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 312, ViewBag.Description, 312, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(333, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 16 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
            BeginContext(341, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 19 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
            BeginContext(380, 25, true);
            WriteLiteral("    <meta name=\"keywords\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 405, "\"", 432, 1);
#line 21 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 415, ViewBag.Keywords, 415, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(433, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 22 "C:\Users\LENOVO\Desktop\kino\WebApplication1\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
