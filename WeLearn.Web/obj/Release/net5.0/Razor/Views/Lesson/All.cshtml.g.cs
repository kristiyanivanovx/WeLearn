#pragma checksum "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\Lesson\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dbdf14b17af671ab0b56b0f0df3a46d6d058af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_All), @"mvc.1.0.view", @"/Views/Lesson/All.cshtml")]
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
#line 1 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\_ViewImports.cshtml"
using WeLearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\_ViewImports.cshtml"
using WeLearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\_ViewImports.cshtml"
using WeLearn.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\_ViewImports.cshtml"
using WeLearn.Data.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\_ViewImports.cshtml"
using WeLearn.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\_ViewImports.cshtml"
using WeLearn.Web.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dbdf14b17af671ab0b56b0f0df3a46d6d058af1", @"/Views/Lesson/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0938f227a24054e166b7baa43ea1ffac755a39d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Lesson_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MultipleLessonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\Lesson\All.cshtml"
  
    ViewData["Title"] = "All lessons";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dbdf14b17af671ab0b56b0f0df3a46d6d058af14293", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\Lesson\All.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"display-4 text-center\">We don\'t have any posts yet.</h1>\r\n    <hr />\r\n");
#nullable restore
#line 11 "D:\Projects\GitHub repos\WeLearn\WeLearn.Web\Views\Lesson\All.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.polyfill.io/v2/polyfill.min.js?features=es6,Array.prototype.includes,CustomEvent,Object.entries,Object.values,URL""></script>
    <script src=""https://unpkg.com/plyr@3""></script>

    <script>
        const players = Array.from(document.querySelectorAll('.js-player')).map(p => new Plyr(p));
        window.player = player;
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591