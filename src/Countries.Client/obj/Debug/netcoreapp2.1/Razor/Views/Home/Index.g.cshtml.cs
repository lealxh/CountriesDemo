#pragma checksum "C:\Users\lealx\source\repos\CountriesDemo\src\Countries.Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afaff5646df970788873cfea2e972f36cda06648"
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
#line 1 "C:\Users\lealx\source\repos\CountriesDemo\src\Countries.Client\Views\_ViewImports.cshtml"
using Countries.Client.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afaff5646df970788873cfea2e972f36cda06648", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1466d77261fb1080decb788958b78823a2d6f858", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountriesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(33, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(38, 11, false);
#line 3 "C:\Users\lealx\source\repos\CountriesDemo\src\Countries.Client\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(49, 17, true);
            WriteLiteral("</h2>\r\n\r\n<ul>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\lealx\source\repos\CountriesDemo\src\Countries.Client\Views\Home\Index.cshtml"
     foreach (var item in Model.Countries)

    {

#line default
#line hidden
            BeginContext(119, 15, true);
            WriteLiteral("          <li> ");
            EndContext();
            BeginContext(135, 9, false);
#line 10 "C:\Users\lealx\source\repos\CountriesDemo\src\Countries.Client\Views\Home\Index.cshtml"
          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(144, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\lealx\source\repos\CountriesDemo\src\Countries.Client\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(158, 13, true);
            WriteLiteral("</ul>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountriesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
