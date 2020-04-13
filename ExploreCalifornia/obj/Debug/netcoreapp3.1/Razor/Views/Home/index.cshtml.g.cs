#pragma checksum "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "339a7004421f0a9a37de4705edcb6f8d690d153e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339a7004421f0a9a37de4705edcb6f8d690d153e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <h1>Explore our world your way</h1>\r\n    <a href=\"/tours.htm\" title=\"Find your tour!\"><h2>Find your tour</h2></a>\r\n");
            }
            );
            WriteLiteral(@"
<article id=""mainArticle"">
    <h1>Tour Spotlight</h1>
    <p class=""spotlight"">This month's spotlight package is Cycle California. Whether you are looking for some serious downhill thrills to a relaxing ride along the coast, you'll find something to love in Cycle California.<br /> <span class=""accent""><a href=""/tours_cycle.htm"" title=""Cycle California"">tour details</a></span></p>
    <h1>Explorer's Podcast</h1>
    <video controls poster=""/images/podcast_poster.jpg"" width=""512"" height=""288"" preload=""none"">
        <source src=""_video/podcast_teaser.mp4"" type=""video/mp4"" />
        <source src=""_video/podcast_teaser.webm"" type=""video/webm"" />
        <source src=""_video/podcast_teaser.theora.ogv"" type=""video/ogg"" />
    </video>
    <p class=""videoText"">Join us each month as we publish a new Explore California video podcast, with featured tours, customer photos, and some exctiing new features!<span class=""accent""><a href=""explorers/video.htm"" title=""Video Podcast"">Watch the full video</a></span></p");
            WriteLiteral(">\r\n</article>\r\n");
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
