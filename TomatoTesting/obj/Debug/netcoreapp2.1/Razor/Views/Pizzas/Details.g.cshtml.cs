#pragma checksum "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "449caa8620259a9c4096e8204fd57b0093201734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizzas_Details), @"mvc.1.0.view", @"/Views/Pizzas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizzas/Details.cshtml", typeof(AspNetCore.Views_Pizzas_Details))]
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
#line 1 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe;

#line default
#line hidden
#line 2 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449caa8620259a9c4096e8204fd57b0093201734", @"/Views/Pizzas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizzas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TomatoPizzaCafe.Models.Pizza>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 85, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <style>\r\n\r\n    html {\r\n        background-image: url(\'");
            EndContext();
            BeginContext(215, 38, false);
#line 12 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
                          Write(Url.Content("~/images/tomatocafe.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(253, 453, true);
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

<h1 style=""font-family: 'Brush Script MT'; font-size: 40px; text-align:center; color: brown"">Create Pizza</h1>


<div>
    <h4>Details</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(707, 40, false);
#line 35 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(747, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(791, 36, false);
#line 38 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(827, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(871, 47, false);
#line 41 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(918, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(962, 43, false);
#line 44 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1049, 50, false);
#line 47 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EightInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1143, 46, false);
#line 50 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayFor(model => model.EightInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1233, 51, false);
#line 53 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TwelveInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1328, 47, false);
#line 56 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TwelveInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1419, 48, false);
#line 59 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1511, 44, false);
#line 62 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1599, 53, false);
#line 65 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FourteenInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1696, 49, false);
#line 68 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayFor(model => model.FourteenInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1789, 53, false);
#line 71 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EighteenInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1842, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1886, 49, false);
#line 74 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
       Write(Html.DisplayFor(model => model.EighteenInchPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1982, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27818bdcfa1b4141af502368d1d73cd8", async() => {
                BeginContext(2033, 4, true);
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
#line 79 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\Pizzas\Details.cshtml"
                           WriteLiteral(Model.PizzaID);

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
            BeginContext(2041, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2049, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22f39844cbe40c89e5d28626427f0dc", async() => {
                BeginContext(2071, 12, true);
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
            BeginContext(2087, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TomatoPizzaCafe.Models.Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
