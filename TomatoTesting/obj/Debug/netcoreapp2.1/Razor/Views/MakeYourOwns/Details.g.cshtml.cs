#pragma checksum "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409c76b39abc66149f8d2acc907f92c9c8c21a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MakeYourOwns_Details), @"mvc.1.0.view", @"/Views/MakeYourOwns/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MakeYourOwns/Details.cshtml", typeof(AspNetCore.Views_MakeYourOwns_Details))]
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
#line 1 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe;

#line default
#line hidden
#line 2 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"409c76b39abc66149f8d2acc907f92c9c8c21a70", @"/Views/MakeYourOwns/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_MakeYourOwns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TomatoPizzaCafe.Models.MakeYourOwn>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 85, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <style>\r\n\r\n    html {\r\n        background-image: url(\'");
            EndContext();
            BeginContext(221, 38, false);
#line 12 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
                          Write(Url.Content("~/images/tomatocafe.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(259, 432, true);
            WriteLiteral(@"');
        background-position: center;
        background-repeat: no-repeat;
        background-size: auto;
        height: 50%;
    }

    footer {
        position: fixed;
        bottom: 0;
    }
    </style>
</div>

<h1 style=""font-family: 'Brush Script MT'; font-size: 40px; text-align:center; color: brown"">Make Your Own Pizza</h1>

<div>
    <h4>Details</h4>
    <hr />

    <dl class=""dl-horizontal"">
");
            EndContext();
            BeginContext(703, 34, true);
            WriteLiteral("            <dt>\r\n                ");
            EndContext();
            BeginContext(738, 41, false);
#line 35 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(779, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(835, 37, false);
#line 38 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(872, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(928, 41, false);
#line 41 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Sauce));

#line default
#line hidden
            EndContext();
            BeginContext(969, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1025, 37, false);
#line 44 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayFor(model => model.Sauce));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 46 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"

            if (Model.Topping1 != null)
            {

#line default
#line hidden
            BeginContext(1141, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(1184, 48, false);
#line 50 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1300, 44, false);
#line 53 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 55 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping2 != null)
            {

#line default
#line hidden
            BeginContext(1440, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(1483, 48, false);
#line 59 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1599, 44, false);
#line 62 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 64 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping3 != null)
            {

#line default
#line hidden
            BeginContext(1739, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(1782, 48, false);
#line 68 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1898, 44, false);
#line 71 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 73 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping4 != null)
            {

#line default
#line hidden
            BeginContext(2038, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(2081, 48, false);
#line 77 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(2129, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2197, 44, false);
#line 80 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 82 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping5 != null)
            {

#line default
#line hidden
            BeginContext(2337, 38, true);
            WriteLiteral("                <dt>\r\n                ");
            EndContext();
            BeginContext(2376, 48, false);
#line 86 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayNameFor(modelItem => Model.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 63, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                ");
            EndContext();
            BeginContext(2488, 44, false);
#line 89 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(2532, 26, true);
            WriteLiteral("\r\n                 </dd>\r\n");
            EndContext();
#line 91 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping6 != null)
            {

#line default
#line hidden
            BeginContext(2629, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(2672, 48, false);
#line 95 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping6));

#line default
#line hidden
            EndContext();
            BeginContext(2720, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2788, 44, false);
#line 98 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping6));

#line default
#line hidden
            EndContext();
            BeginContext(2832, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 100 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
        

#line default
#line hidden
            BeginContext(2883, 15, true);
            WriteLiteral("    </dl>\r\n    ");
            EndContext();
            BeginContext(2898, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc0d502f0d0b4f8093e5655ecebf7765", async() => {
                BeginContext(2955, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
                           WriteLiteral(Model.MakeYourOwnID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2963, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2971, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a33a8d1aea4676baab0da84f2bf4b5", async() => {
                BeginContext(2993, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3009, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TomatoPizzaCafe.Models.MakeYourOwn> Html { get; private set; }
    }
}
#pragma warning restore 1591
