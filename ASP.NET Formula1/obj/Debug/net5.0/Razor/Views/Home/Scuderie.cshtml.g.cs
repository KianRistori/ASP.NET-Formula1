#pragma checksum "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/Home/Scuderie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "859575050493a00907e89921d6dd058d6e2768b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Scuderie), @"mvc.1.0.view", @"/Views/Home/Scuderie.cshtml")]
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
#line 1 "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/_ViewImports.cshtml"
using ASP.NET_Formula1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/_ViewImports.cshtml"
using ASP.NET_Formula1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859575050493a00907e89921d6dd058d6e2768b6", @"/Views/Home/Scuderie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc157638515596dce59d5e3d3e9f47b0cd5f991", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Scuderie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/Home/Scuderie.cshtml"
  
    ViewData["Title"] = "Scuderie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"text-primary mb-3\">SCUDERIE</h1>\r\n    <a href=\"/home/NuovaScuderia\">Nuova Scuderia</a>\r\n    <br /><br />\r\n");
#nullable restore
#line 10 "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/Home/Scuderie.cshtml"
     foreach (var team in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"mb-2 text-secondary\"");
            BeginWriteAttribute("href", " href=\"", 299, "\"", 342, 2);
            WriteAttributeValue("", 306, "/home/pilotiperscuderia/", 306, 24, true);
#nullable restore
#line 12 "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/Home/Scuderie.cshtml"
WriteAttributeValue("", 330, team.TeamId, 330, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/Home/Scuderie.cshtml"
                                                                              Write(team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n");
#nullable restore
#line 13 "/Users/kianristori/Documents/USB/5INF/INFORMATICA/LABORATORIO/ESERCIZI/ASP.NET Formula1/ASP.NET Formula1/Views/Home/Scuderie.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
