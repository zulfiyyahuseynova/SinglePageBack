#pragma checksum "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b08e22a09e830bcb51be6f3811e8410f367583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\_ViewImports.cshtml"
using SinglePage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\_ViewImports.cshtml"
using SinglePage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\_ViewImports.cshtml"
using SinglePage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b08e22a09e830bcb51be6f3811e8410f367583", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab90552b0155a5834854bf91f694aa486096a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- About-->\r\n<section class=\"resume-section\" id=\"about\">\r\n    <div class=\"resume-section-content\">\r\n");
#nullable restore
#line 9 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
         foreach (About item in Model.Abouts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"mb-0\">\r\n                ");
#nullable restore
#line 12 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"text-primary\">");
#nullable restore
#line 13 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </h1>\r\n            <div class=\"subheading mb-5\">\r\n                ");
#nullable restore
#line 16 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
           Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" · ");
#nullable restore
#line 16 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                          Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ·\r\n                <a href=\"mailto:name@email.com\">");
#nullable restore
#line 17 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <p class=\"lead mb-5\">");
#nullable restore
#line 19 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""social-icons"">
            <a class=""social-icon"" href=""#!""><i class=""fab fa-linkedin-in""></i></a>
            <a class=""social-icon"" href=""#!""><i class=""fab fa-github""></i></a>
            <a class=""social-icon"" href=""#!""><i class=""fab fa-twitter""></i></a>
            <a class=""social-icon"" href=""#!""><i class=""fab fa-facebook-f""></i></a>
        </div>
    </div>
</section>
<hr class=""m-0"" />
<!-- Experience-->
<section class=""resume-section"" id=""experience"">
    <div class=""resume-section-content"">
        <h2 class=""mb-5"">Experience</h2>
");
#nullable restore
#line 35 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
         foreach (Experience item in Model.Experiences)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                <div class=\"flex-grow-1\">\r\n                    <h3 class=\"mb-0\">");
#nullable restore
#line 39 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                Write(item.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"subheading mb-3\">");
#nullable restore
#line 40 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                            Write(item.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p>");
#nullable restore
#line 41 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"flex-shrink-0\"><span class=\"text-primary\">");
#nullable restore
#line 43 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                                                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<hr class=\"m-0\" />\r\n<!-- Education-->\r\n<section class=\"resume-section\" id=\"education\">\r\n    <div class=\"resume-section-content\">\r\n        <h2 class=\"mb-5\">Education</h2>\r\n");
#nullable restore
#line 53 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
         foreach (Education item in Model.Educations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                <div class=\"flex-grow-1\">\r\n                    <h3 class=\"mb-0\">");
#nullable restore
#line 57 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                Write(item.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"subheading mb-3\">");
#nullable restore
#line 58 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                            Write(item.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>");
#nullable restore
#line 59 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p>");
#nullable restore
#line 60 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                  Write(item.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"flex-shrink-0\"><span class=\"text-primary\">");
#nullable restore
#line 62 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
                                                                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n");
#nullable restore
#line 64 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</section>
<hr class=""m-0"" />
<!-- Skills-->
<section class=""resume-section"" id=""skills"">
    <div class=""resume-section-content"">
        <h2 class=""mb-5"">Skills</h2>
        <div class=""subheading mb-3"">Programming Languages & Tools</div>
        <ul class=""list-inline dev-icons"">
");
#nullable restore
#line 74 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
             foreach (ProgLangs item in Model.ProgLangs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-inline-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04b08e22a09e830bcb51be6f3811e8410f36758312252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2899, "~/assets/img/", 2899, 13, true);
#nullable restore
#line 76 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2912, item.Image, 2912, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 77 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <div class=\"subheading mb-3\">Workflow</div>\r\n        <ul class=\"fa-ul mb-0\">\r\n");
#nullable restore
#line 81 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
             foreach (Workflow item in Model.Workflows)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <span class=\"fa-li\"><i class=\"fas fa-check\"></i></span>\r\n                    ");
#nullable restore
#line 85 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 87 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </ul>\r\n    </div>\r\n</section>\r\n<hr class=\"m-0\" />\r\n<!-- Interests-->\r\n<section class=\"resume-section\" id=\"interests\">\r\n    <div class=\"resume-section-content\">\r\n        <h2 class=\"mb-5\">Interests</h2>\r\n");
#nullable restore
#line 97 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
         foreach (Interest item in Model.Interests)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 99 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 100 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
        }      

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<hr class=\"m-0\" />\r\n<!-- Awards-->\r\n<section class=\"resume-section\" id=\"awards\">\r\n    <div class=\"resume-section-content\">\r\n        <h2 class=\"mb-5\">Awards & Certifications</h2>\r\n        <ul class=\"fa-ul mb-0\">\r\n");
#nullable restore
#line 109 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
             foreach (Award item in Model.Awards)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <span class=\"fa-li\"><i class=\"fas fa-trophy text-warning\"></i></span>\r\n                    ");
#nullable restore
#line 113 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
               Write(item.Awards);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 115 "C:\Users\tu7kswf4d\Desktop\SinglePageBack\SinglePage\SinglePage\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
