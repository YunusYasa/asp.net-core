#pragma checksum "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6beb13a0d988134909c7035b30a44d647aeb4fc12ee660ee4ed897093803ae89"
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
#line 1 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\_ViewImports.cshtml"
using PartialViews.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6beb13a0d988134909c7035b30a44d647aeb4fc12ee660ee4ed897093803ae89", @"/Views/Shared/_movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2a57b3c3373d8eff73dd695e7b03c7a0debe7c44e03ed23357d3527287f1b1af", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"row mb-2\">\r\n        <div class=\"col-md-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 94, "\"", 118, 2);
            WriteAttributeValue("", 100, "/img/", 100, 5, true);
#nullable restore
#line 6 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
WriteAttributeValue("", 105, Model.ImgUrl, 105, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 119, "\"", 137, 1);
#nullable restore
#line 6 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
WriteAttributeValue("", 125, Model.Title, 125, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
                                Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">\r\n                    <ul>\r\n");
#nullable restore
#line 15 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
                         foreach (var player in Model.Players)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 17 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
                           Write(player);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\yunus\source\repos\13-PartialViewe Veri Gönderme\Views\Shared\_movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </p>                         \r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
