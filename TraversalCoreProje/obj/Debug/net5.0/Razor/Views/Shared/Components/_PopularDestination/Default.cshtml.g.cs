#pragma checksum "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bea6bfb2a90913ce3f37e7f4adf3e40f51ccc88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PopularDestination_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PopularDestination/Default.cshtml")]
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
#line 1 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bea6bfb2a90913ce3f37e7f4adf3e40f51ccc88", @"/Views/Shared/Components/_PopularDestination/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6150063022276d5631f48840275e961238c7ed5d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__PopularDestination_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">Visit</h6>
            <h3 class=""hny-title"">Popular Destinations</h3>
        </div>
        <div class=""row bottom-ab-grids"">
            <!--/row-grids-->
");
#nullable restore
#line 12 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
             foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                <div class=""subject-card-header p-4"">
                    <a href=""#"" class=""card_title p-lg-4d-block"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-5 subject-img"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 775, "\"", 792, 1);
#nullable restore
#line 18 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
WriteAttributeValue("", 781, item.Image, 781, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 811, "\"", 817, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-sm-7 subject-content mt-sm-0 mt-4\">\r\n                                <h4>");
#nullable restore
#line 21 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
                               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 22 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
                              Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"dst-btm\">\r\n                                    <h6");
            BeginWriteAttribute("class", " class=\"", 1140, "\"", 1148, 0);
            EndWriteAttribute();
            WriteLiteral("> Start From </h6>\r\n                                    <span>");
#nullable restore
#line 25 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</span>\r\n                                </div>\r\n                                <p class=\"sub-para\">");
#nullable restore
#line 27 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\BİLAL\Desktop\IfasTurk\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopularDestination\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
