#pragma checksum "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "204a0bdc15e014255c1712c126146bf26cd09231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204a0bdc15e014255c1712c126146bf26cd09231", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private global::AspNetCore.Views_Shared__Layout.__Generated__MonthlySpecialsViewComponentTagHelper __MonthlySpecialsViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/jquery-3.1.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "204a0bdc15e014255c1712c126146bf26cd092314800", async() => {
                WriteLiteral(@"
<meta charset=""utf-8"">
<title>Welcome to Explore California</title>
<meta name=""description"" content=""A lynda.com example of HTML5 and CSS3"">
<meta name=""keywords"" content=""html5, css3, lynda, local storage, canvas, forms, semantics, web apps"">
<!--make sure mobile devices display the page at the proper scale	-->
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<!--[if lt IE 9]>
<script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script>
<![endif]-->

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "204a0bdc15e014255c1712c126146bf26cd092315580", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "204a0bdc15e014255c1712c126146bf26cd092316766", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<link href=\"/css/main.css\" rel=\"stylesheet\" type=\"text/css\" media=\"screen, projection\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "204a0bdc15e014255c1712c126146bf26cd092318755", async() => {
                WriteLiteral(@"
<div id=""wrapper"">
  <header id=""mainHeader""> <a href=""/"" title=""home"" class=""logo"">
   <!-- I need this div because IE is an affront to mankind-->
    <div>
    <h1>Explore California</h1>
    </div>
    </a>
    <nav id=""siteNav"">
      <h1>Where do you want to go?</h1>
      <ul>
       <li><a href=""/tours.htm"" title=""Our tours"">Tours <br /><span class=""tagline"">follow our bliss</span></a>
          <ul>
            <li><a href=""/tours.htm"" title=""Our tours"">All Tours</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Activity</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Region</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tour Finder</a></li>
          </ul>
        </li>
        <li><a href=""mission.htm"" title=""What we believe"">Mission <br /><span class=""tagline"">what makes us different?</span></a></li>
        <li><a href=""resources.htm"" title=""planning resources"">Resources <br /><span class=""tagline"">plan your t");
                WriteLiteral(@"rip</span></a>
          <ul>
            <li><a href=""resources/faq.htm"" title=""Got questions?"">Tour FAQs</a></li>
            <li><a href=""resources/additional_resources.htm"" title=""additional resources"">Tour Information</a></li>
            <li><a href=""resources/terms.htm"" title=""terms and conditions"">Site Terms</a></li>
          </ul>
        </li>
        <li><a href=""explorers.htm"" title=""Our community"">Explorers <br /><span class=""tagline"">join our community</span></a>
          <ul>
            <li><a href=""explorers/join.htm"" title=""join our community"">Join the Explorers</a></li>
            <li><a");
                BeginWriteAttribute("href", " href=\"", 2512, "\"", 2547, 1);
#nullable restore
#line 49 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2519, Url.Action("Index", "Blog"), 2519, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" title=""read our blog!"">Read our Blog</a></li>
            <li><a href=""explorers/gallery.htm"" title=""contributor photos"">Tour Photos</a></li>
            <li><a href=""_video/EC_podcast_full version.mov"" title=""check out our podcast"">Video podcast</a></li>
          </ul>
        </li>
        <li><a href=""contact.htm"" title=""contact us"" class=""last"">Contact <br /><span class=""tagline"">we're listening</span></a>
          <ul>
            <li><a href=""support.htm"" title=""need help?"">Support</a></li>
          </ul>
        </li>
      </ul>
    </nav>
  </header>
  <section id=""actionCall"">
");
#nullable restore
#line 63 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml"
       if(IsSectionDefined("header")) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml"
   Write(RenderSection("header", false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml"
                                       
      } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h1>Explore our world your way</h1>\r\n");
#nullable restore
#line 67 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("  </section>\r\n  <div id=\"contentWrapper\">\r\n  <section id=\"mainContent\">\r\n      ");
#nullable restore
#line 71 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml"
 Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  </section>\r\n    <aside id=\"secondaryContent\">\r\n        <div id=\"specials\" class=\"callOut\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:monthly-specials", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "204a0bdc15e014255c1712c126146bf26cd0923113119", async() => {
                }
                );
                __MonthlySpecialsViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Shared__Layout.__Generated__MonthlySpecialsViewComponentTagHelper>();
                __tagHelperExecutionContext.Add(__MonthlySpecialsViewComponentTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <div id=""trivia"" class=""callOut"">
            <h1>Did You Know?</h1>
            <p>California produces over 17 million gallons of wine each year!</p>
        </div>
    </aside>
  </div>
  <footer id=""pageFooter"">
  <section id=""quickLinks"">
  <h1>Quick Nav</h1>
    <ul id=""quickNav"">
      <li><a href=""/"" title=""Our home page"">Home</a></li>
      <li><a href=""/tours.htm"" title=""Explore our tours"">Tours</a></li>
      <li><a href=""mission.htm"" title=""What we think"">Mission</a></li>
      <li><a href=""resources.htm"" title=""Guidance and planning"">Resources</a></li>
      <li><a href=""explorers.htm"" title=""Join our community"">Explorers</a></li>
      <li><a href=""contact.htm"" title=""Contact and support"">Contact</a></li>
    </ul>
  </section>
  <section id=""footerResources"">
  <h1>Resources</h1>
    <ul id=""quickNav"">
      <li><a href=""resources/faq.htm"" title=""Our home page"">FAQ</a></li>
      <li><a href=""support.htm"" title=""Need help?"">Support</a></li>
      ");
                WriteLiteral("<li><a href=\"resources/legal.htm\" title=\"The fine print\">Legal</a></li><li><a href=\"login.htm\">Login</a></li>\r\n    </ul>\r\n\r\n      <p>\r\n          Copyright Jess Chadwick ");
#nullable restore
#line 104 "F:\PROJECTS\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Layout.cshtml"
                             Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
      </p>
  </section>
  <section id=""companyInfo"">
  <h1>Contact</h1>
  <h2>Explore California</h2>
      <p>5605 Nota Street<br />
        Ventura, CA 93003</p>
      <p>866.555.4310<br />866.555.4315 <em>(24 hour support)</em></p>
  </section>
  </footer>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:monthly-specials")]
        public class __Generated__MonthlySpecialsViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__MonthlySpecialsViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("MonthlySpecials", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
