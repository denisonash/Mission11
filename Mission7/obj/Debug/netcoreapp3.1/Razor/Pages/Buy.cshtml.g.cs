#pragma checksum "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421a0db1251a10c3d5d204fdf9e932d026cac01b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mission7.Pages.Pages_Buy), @"mvc.1.0.razor-page", @"/Pages/Buy.cshtml")]
namespace Mission7.Pages
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
#line 3 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/_ViewImports.cshtml"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421a0db1251a10c3d5d204fdf9e932d026cac01b", @"/Pages/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42cc7c3599c3dbbc8dcbc03f431f4cae1c208a4d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:Chivo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your Basket</h2>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Item</th>
            <th>Quantity</th>
            <th>Price Per Book</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 19 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
         foreach (var i in Model.cart.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td style=\"font-family:Crimson Pro\">");
#nullable restore
#line 22 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
                                               Write(i.Books.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"font-family:Crimson Pro\">");
#nullable restore
#line 23 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
                                               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"font-family:Crimson Pro\">");
#nullable restore
#line 24 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
                                               Write(i.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"font-family:Crimson Pro\">");
#nullable restore
#line 25 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
                                                Write((i.Quantity * i.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td class=\"text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421a0db1251a10c3d5d204fdf9e932d026cac01b6847", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 860, "\"", 883, 1);
#nullable restore
#line 29 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
WriteAttributeValue("", 868, i.Books.BookID, 868, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 949, "\"", 973, 1);
#nullable restore
#line 30 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
WriteAttributeValue("", 957, Model.ReturnUrl, 957, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\" style=\"font-family:Chivo\">Delete</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 35 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n    <tfoot>\n        <tr>\n            <td colspan=\"3\" style=\"font-family:Crimson Pro\">Total:</td>\n");
            WriteLiteral("            <td style=\"font-family:Crimson Pro\">");
#nullable restore
#line 42 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
                                           Write(Model.cart.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n</table>\n\n<div>\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1520, 1);
#nullable restore
#line 48 "/Users/ashleydenison/Documents/GitHub/Mission11/Mission7/Pages/Buy.cshtml"
WriteAttributeValue("", 1504, Model.ReturnUrl, 1504, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-family:Chivo\">Continue Shopping</a>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421a0db1251a10c3d5d204fdf9e932d026cac01b10659", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission7.Pages.BuyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission7.Pages.BuyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission7.Pages.BuyModel>)PageContext?.ViewData;
        public Mission7.Pages.BuyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
