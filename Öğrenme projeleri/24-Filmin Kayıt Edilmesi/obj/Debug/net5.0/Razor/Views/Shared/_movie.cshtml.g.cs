#pragma checksum "C:\Users\yunus\Desktop\24-Filmin Kayıt Edilmesi\Views\Shared\_movie.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "225e9ae7365ce7fc59fe9b9801aca3563653edc7bd4b99d7ab56b2f9d9e443ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__movie), @"mvc.1.0.view", @"/Views/Shared/_movie.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\yunus\Desktop\24-Filmin Kayıt Edilmesi\Views\_ViewImports.cshtml"
using View_Models.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"225e9ae7365ce7fc59fe9b9801aca3563653edc7bd4b99d7ab56b2f9d9e443ec", @"/Views/Shared/_movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"17acfe03c956bfcfd9c35861ede61bc9ce61b05a051d36658008b9d7bbea59e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"card mb-3\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 128, "\"", 152, 2);
            WriteAttributeValue("", 134, "/img/", 134, 5, true);
#nullable restore
#line 6 "C:\Users\yunus\Desktop\24-Filmin Kayıt Edilmesi\Views\Shared\_movie.cshtml"
WriteAttributeValue("", 139, Model.ImgUrl, 139, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 153, "\"", 171, 1);
#nullable restore
#line 6 "C:\Users\yunus\Desktop\24-Filmin Kayıt Edilmesi\Views\Shared\_movie.cshtml"
WriteAttributeValue("", 159, Model.Title, 159, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\yunus\Desktop\24-Filmin Kayıt Edilmesi\Views\Shared\_movie.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 409, "\"", 446, 2);
            WriteAttributeValue("", 416, "/movies/details/", 416, 16, true);
#nullable restore
#line 12 "C:\Users\yunus\Desktop\24-Filmin Kayıt Edilmesi\Views\Shared\_movie.cshtml"
WriteAttributeValue("", 432, Model.MovieId, 432, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">details</a>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
