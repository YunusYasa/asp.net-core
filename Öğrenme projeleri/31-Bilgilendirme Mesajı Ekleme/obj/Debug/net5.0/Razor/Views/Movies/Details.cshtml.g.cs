#pragma checksum "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bd73f667974b171d88aeef8d2f78e7496311a7d299826274b918af01f3fa4604"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\_ViewImports.cshtml"
using View_Models.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bd73f667974b171d88aeef8d2f78e7496311a7d299826274b918af01f3fa4604", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e2ee91563b81e8553191a35b2bba77e1240c51cd154c1ebc35599560f539d608", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
 if (Model != null)

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 149, "\"", 173, 2);
            WriteAttributeValue("", 155, "/img/", 155, 5, true);
#nullable restore
#line 9 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
WriteAttributeValue("", 160, Model.ImgUrl, 160, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" />\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                                    Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                     if (Model.Players != null)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        <ul>\r\n");
#nullable restore
#line 22 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                             foreach (var player in Model.Players)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 24 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                               Write(player);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 25 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </p>\r\n");
#nullable restore
#line 28 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Movie model is null.</p>\r\n");
#nullable restore
#line 37 "C:\Users\yunus\Desktop\31-Bilgilendirme Mesajı Ekleme\Views\Movies\Details.cshtml"
}

#line default
#line hidden
#nullable disable
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
