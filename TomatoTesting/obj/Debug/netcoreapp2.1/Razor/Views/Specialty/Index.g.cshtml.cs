#pragma checksum "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "836cf1104a38d26f4ae2734aedc3227601219dff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialty_Index), @"mvc.1.0.view", @"/Views/Specialty/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Specialty/Index.cshtml", typeof(AspNetCore.Views_Specialty_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836cf1104a38d26f4ae2734aedc3227601219dff", @"/Views/Specialty/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_Specialty_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TomatoPizzaCafe.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(104, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(141, 1225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eebc1c40963499e9fd7a0a87c620887", async() => {
                BeginContext(147, 115, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>");
                EndContext();
                BeginContext(263, 17, false);
#line 11 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(280, 1079, true);
                WriteLiteral(@" - Menu</title>
    <style>
        .menu-body {
            max-width: 680px;
            margin: 0 auto;
            display: block;
            color: rgb(92, 92, 92);
        }

        .menu-section {
            margin-bottom: 80px;
        }

        .menu-section-title {
            font-family: georgia;
            font-size: 50px;
            display: block;
            font-weight: normal;
            margin: 20px 0;
            text-align: Center;
        }

        .menu-item {
            margin: 35px 0;
            font-size: 18px;
        }

        .menu-item-name {
            font-family: helvetica;
            font-weight: bold;
            border-bottom: 2px dotted rgb(213, 213, 213);
        }

        .menu-item-description {
            font-style: italic;
            font-size: .9em;
            line-height: 1.5em;
        }

        .menu-item-price {
            float: right;
            font-weight: bold;
            font-family: arial;
  ");
                WriteLiteral("          margin-top: -22px;\r\n        }\r\n    </style>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1366, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1368, 8262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8641bc7186924a2dbe6f76fe1f698273", async() => {
                BeginContext(1374, 218, true);
                WriteLiteral("\r\n    <div class=\"menu-body\">\r\n        <!-- Section starts: Appetizers -->\r\n        <div class=\"menu-section\">\r\n            <h2 class=\"menu-section-title\">TOMATO PIZZA CAFE MENU</h2>\r\n            <!-- Item starts -->\r\n");
                EndContext();
#line 64 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1649, 183, true);
                WriteLiteral("            <table class=\"table\">\r\n                <tr>\r\n                    <td class=\"menu-item\">\r\n                        <div class=\"menu-item-name\">\r\n                            ");
                EndContext();
                BeginContext(1833, 39, false);
#line 70 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
                EndContext();
                BeginContext(1872, 118, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"menu-item-price\">\r\n                            $");
                EndContext();
                BeginContext(1991, 49, false);
#line 73 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.EightInchPrice));

#line default
#line hidden
                EndContext();
                BeginContext(2040, 124, true);
                WriteLiteral("+\r\n                        </div>\r\n                        <div class=\"menu-item-description\">\r\n                            ");
                EndContext();
                BeginContext(2165, 46, false);
#line 76 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(2211, 93, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(2304, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84a3a7f4e2b9497b81d72b021f095f28", async() => {
                    BeginContext(2355, 5, true);
                    WriteLiteral("Order");
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
#line 79 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
                                                    WriteLiteral(item.PizzaID);

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
                BeginContext(2364, 84, true);
                WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
                BeginContext(3460, 62, true);
                WriteLiteral("            </table>\r\n                    <!-- Item ends -->\r\n");
                EndContext();
#line 105 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Specialty\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3545, 6078, true);
                WriteLiteral(@"

                    <!-- Item starts -->
                    <div class=""menu-item"">
                        <div class=""menu-item-name"">
                            Four Cheese Pizza
                        </div>
                        <div class=""menu-item-price"">
                            $12.00+
                        </div>
                        <div class=""menu-item-description"">
                            Mozzarella, cheddar, provolone and parmesan.
                        </div>
                    </div>
                    <!-- Item ends -->
                    <!-- Item starts -->
                    <div class=""menu-item"">
                        <div class=""menu-item-name"">
                            BBQ Chicken Pizza
                        </div>
                        <div class=""menu-item-price"">
                            $10.95+
                        </div>
                        <div class=""menu-item-description"">
                            Chicken ");
                WriteLiteral(@"strips in BBQ sauce with mozzarella cheese.
                        </div>
                    </div>
                    <!-- Item ends -->
                    <!-- Item starts -->
                    <div class=""menu-item"">
                        <div class=""menu-item-name"">
                            Mexican Pizza (Gluten Free)
                        </div>
                        <div class=""menu-item-price"">
                            $16.75
                        </div>
                        <div class=""menu-item-description"">
                            10"" size. Pizza sauce, mozzarella cheese, ground beef,
                            bacon, lettuce, tomatoes, black olives and cheddar cheese.
                        </div>
                    </div>
                    <!-- Item ends -->
                    <!-- Item starts -->
                    <div class=""menu-item"">
                        <div class=""menu-item-name"">
                            Supreme Pizza
         ");
                WriteLiteral(@"               </div>
                        <div class=""menu-item-price"">
                            $12.95
                        </div>
                        <div class=""menu-item-description"">
                            Pizza sauce, sausage, pepperoni, onions, green and red peppers, mushrooms.
                        </div>
                    </div>
                    <div class=""menu-item"">
                        <div class=""menu-item-name"">
                            Shrimp Parmigiana Pizza (Gluten Free)
                        </div>
                        <div class=""menu-item-price"">
                            $18.95
                        </div>
                        <div class=""menu-item-description"">
                            10"" size. Pizza sauce, breaded shrimp and mozzarella cheese.
                        </div>
                    </div>
                    <div class=""menu-item"">
                        <div class=""menu-item-name"">
                      ");
                WriteLiteral(@"      Classic Calzones
                        </div>
                        <div class=""menu-item-price"">
                            $7.95+
                        </div>
                        <div class=""menu-item-description"">
                            Mozzarella and ricotta cheese. Includes small marinara
                            sauce (3.25 oz) on the side. Extra marinara sauce $1.00.
                        </div>
                    </div>
                    <!-- Item ends -->
            </div>
            <!-- Section ends: Appetizers -->
            <!-- Section starts: Drinks -->
            <div class=""menu-section"">
                <h2 class=""menu-section-title"">CYBER BEVERAGES</h2>
                <!-- Item starts -->
                <div class=""menu-item"">
                    <div class=""menu-item-name"">
                        Tasty Drink
                    </div>
                    <div class=""menu-item-price"">
                        $30
                   ");
                WriteLiteral(@" </div>
                    <div class=""menu-item-description"">
                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy.
                    </div>
                </div>
                <!-- Item ends -->
                <!-- Item starts -->
                <div class=""menu-item"">
                    <div class=""menu-item-name"">
                        Tasty Drink
                    </div>
                    <div class=""menu-item-price"">
                        $30
                    </div>
                    <div class=""menu-item-description"">
                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy.
                    </div>
                </div>
                <!-- Item ends -->
                <!-- Item starts -->
                <div class=""menu-item"">
                    <div class=""menu-item-name"">
                        Tasty Drink
                    </div>
                    <div cl");
                WriteLiteral(@"ass=""menu-item-price"">
                        $30
                    </div>
                    <div class=""menu-item-description"">
                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy.
                    </div>
                </div>
                <!-- Item ends -->
                <!-- Item starts -->
                <div class=""menu-item"">
                    <div class=""menu-item-name"">
                        Tasty Drink
                    </div>
                    <div class=""menu-item-price"">
                        $30
                    </div>
                    <div class=""menu-item-description"">
                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy.
                    </div>
                </div>
                <!-- Item ends -->
            </div>
            <!-- Section ends: Drinks -->
        </div>
    ");
                EndContext();
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
            EndContext();
            BeginContext(9630, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TomatoPizzaCafe.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
