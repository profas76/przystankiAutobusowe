#pragma checksum "C:\Users\Renata\Desktop\PolaczeniaAutobusowe\PolaczeniaAutobusowe\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6789c0dfa0311bc5325d90b1d8143b2bfee29e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PolaczeniaAutobusowe.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Logout.cshtml", typeof(PolaczeniaAutobusowe.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Logout), null)]
namespace PolaczeniaAutobusowe.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Renata\Desktop\PolaczeniaAutobusowe\PolaczeniaAutobusowe\Areas\Identity\Pages\_ViewImports.cshtml"
using PolaczeniaAutobusowe.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Renata\Desktop\PolaczeniaAutobusowe\PolaczeniaAutobusowe\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Renata\Desktop\PolaczeniaAutobusowe\PolaczeniaAutobusowe\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PolaczeniaAutobusowe.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6789c0dfa0311bc5325d90b1d8143b2bfee29e7e", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1917f4ce333ded1f7938bdd6bc6161703d7b8104", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7975ccbbff5244725f8ea77ac872c15fc2bd69b1", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Renata\Desktop\PolaczeniaAutobusowe\PolaczeniaAutobusowe\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Wyloguj";

#line default
#line hidden
            BeginContext(70, 20, true);
            WriteLiteral("\r\n<header>\r\n    <h1>");
            EndContext();
            BeginContext(91, 17, false);
#line 8 "C:\Users\Renata\Desktop\PolaczeniaAutobusowe\PolaczeniaAutobusowe\Areas\Identity\Pages\Account\Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 67, true);
            WriteLiteral("</h1>\r\n    <p>Pomyślnie wylogowałeś się z aplikacji.</p>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591