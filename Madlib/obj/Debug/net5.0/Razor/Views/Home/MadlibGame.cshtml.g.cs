#pragma checksum "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea518b535b5f2a9ccacceb802495756f18d1ed2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MadlibGame), @"mvc.1.0.view", @"/Views/Home/MadlibGame.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea518b535b5f2a9ccacceb802495756f18d1ed2b", @"/Views/Home/MadlibGame.cshtml")]
    #nullable restore
    public class Views_Home_MadlibGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea518b535b5f2a9ccacceb802495756f18d1ed2b3963", async() => {
                WriteLiteral(@"
    <meta charset='utf-8'>
    <title>Madlib Game</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ea518b535b5f2a9ccacceb802495756f18d1ed2b4503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n  ");
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
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea518b535b5f2a9ccacceb802495756f18d1ed2b6445", async() => {
                WriteLiteral("\n    <h1>Here is your Game</h1>\n    <p>\n      The majestic ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
              Write(Model.Noun);

#line default
#line hidden
#nullable disable
                WriteLiteral(" has roamed the forest of Denmark for thousands of years. Today it ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
                                                                                            Write(Model.Verb);

#line default
#line hidden
#nullable disable
                WriteLiteral(" across the land until it came upon a large object. \"");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
                                                                                                                                                            Write(Model.Exclamation);

#line default
#line hidden
#nullable disable
                WriteLiteral(", that thing is huge!\" said the ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
                                                                                                                                                                                                              Write(Model.Noun);

#line default
#line hidden
#nullable disable
                WriteLiteral(". The ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
                                                                                                                                                                                                                               Write(Model.Noun);

#line default
#line hidden
#nullable disable
                WriteLiteral(" kicks the object and it begins to vibrate with immense frequency. After a few moments the object becomes ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
                                                                                                                                                                                                                                                                                                                                                    Write(Model.Adjective);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
                                                                                                                                                                                                                                                                                                                                                                      Write(Model.Noun);

#line default
#line hidden
#nullable disable
                WriteLiteral(" quickly ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-two/Madlib.Solutions/Madlib/Views/Home/MadlibGame.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.Verb);

#line default
#line hidden
#nullable disable
                WriteLiteral(" away.\n    </p>\n    <p>The end</p>\n\n    <a href=\"/\">do another story</a>\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
