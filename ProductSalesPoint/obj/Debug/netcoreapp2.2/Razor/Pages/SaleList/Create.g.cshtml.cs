#pragma checksum "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b53926808d10bc58a21027163e0f28c34da7b28a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProductSalesPoint.Pages.SaleList.Pages_SaleList_Create), @"mvc.1.0.razor-page", @"/Pages/SaleList/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SaleList/Create.cshtml", typeof(ProductSalesPoint.Pages.SaleList.Pages_SaleList_Create), null)]
namespace ProductSalesPoint.Pages.SaleList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\_ViewImports.cshtml"
using ProductSalesPoint;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53926808d10bc58a21027163e0f28c34da7b28a", @"/Pages/SaleList/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89db821315466f16f387e9f79d90b3b545c8c2e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SaleList_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../SaleItemList/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(102, 92, true);
            WriteLiteral("\r\n<br />\r\n<h2 class=\"text-info\">Register New Sale</h2>\r\n<br />\r\n\r\n<div class=\"border\">\r\n    ");
            EndContext();
            BeginContext(194, 5005, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53926808d10bc58a21027163e0f28c34da7b28a5303", async() => {
                BeginContext(214, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(224, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53926808d10bc58a21027163e0f28c34da7b28a5693", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 13 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(290, 309, true);
                WriteLiteral(@"
        <div class=""container"" style=""padding: 30px;"">
            <div class=""row"">
                <div class=""form-group col-sm-5"">
                    <div class=""col-sm"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                ");
                EndContext();
                BeginContext(600, 33, false);
#line 20 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                           Write(Html.DisplayName("Total Amount:"));

#line default
#line hidden
                EndContext();
                BeginContext(633, 103, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-sm-6 form-control\">\r\n");
                EndContext();
#line 23 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                  
                                    double paramTotalValue = ViewBag.TotalValue;
                                

#line default
#line hidden
                BeginContext(889, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(922, 37, false);
#line 26 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                           Write(Html.DisplayFor(m => paramTotalValue));

#line default
#line hidden
                EndContext();
                BeginContext(959, 575, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm"" style=""padding-top: 10px;"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                <p>Payment Method:</p>
                            </div>
                            <select class=""col-sm-6 form-control"" data-val=""true"" data-val-required=""The Payment Method field is required.""
                                    id=""Sale_PaymentId"" name=""Sale.PaymentId"">
");
                EndContext();
#line 37 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                 foreach (var item in ViewBag.PaymentMethods)
                                {

#line default
#line hidden
                BeginContext(1648, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1684, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53926808d10bc58a21027163e0f28c34da7b28a10092", async() => {
                    BeginContext(1712, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                    BeginContext(1755, 9, false);
#line 40 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                   Write(item.Text);

#line default
#line hidden
                    EndContext();
                    BeginContext(1764, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 39 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                       WriteLiteral(item.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1811, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                }

#line default
#line hidden
                BeginContext(1848, 517, true);
                WriteLiteral(@"                            </select>
                        </div>
                    </div>
                    <br /><br />
                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-sm-4 offset-sm-1"">
                                <input type=""submit"" value=""Register"" class=""btn btn-primary form-control"" />
                            </div>
                            <div class=""col-sm-4"">
                                ");
                EndContext();
                BeginContext(2365, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53926808d10bc58a21027163e0f28c34da7b28a13272", async() => {
                    BeginContext(2438, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2454, 195, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-sm-7\">\r\n                    \r\n");
                EndContext();
#line 60 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                     if (ViewBag.SaleItens != null)
                    {

#line default
#line hidden
                BeginContext(2725, 200, true);
                WriteLiteral("                        <table class=\"table table-striped border\">\r\n                            <tr class=\"table-secondary\">\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(2926, 71, false);
#line 65 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                               Write(Html.DisplayNameFor(m => m.Sale.Products.FirstOrDefault().Product.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2997, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(3113, 72, false);
#line 68 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                               Write(Html.DisplayNameFor(m => m.Sale.Products.FirstOrDefault().Product.Price));

#line default
#line hidden
                EndContext();
                BeginContext(3185, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(3301, 33, false);
#line 71 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                               Write(Html.DisplayName("Item Quantity"));

#line default
#line hidden
                EndContext();
                BeginContext(3334, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(3450, 36, false);
#line 74 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                               Write(Html.DisplayName("Item Total Price"));

#line default
#line hidden
                EndContext();
                BeginContext(3486, 76, true);
                WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n");
                EndContext();
#line 77 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                             foreach (var item in ViewBag.SaleItens)
                            {

#line default
#line hidden
                BeginContext(3663, 64, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n");
                EndContext();
#line 81 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                  
                                    string paramValueName = item.Product.Name;
                                

#line default
#line hidden
                BeginContext(3878, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(3911, 36, false);
#line 84 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                           Write(Html.DisplayFor(m => paramValueName));

#line default
#line hidden
                EndContext();
                BeginContext(3947, 71, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
                EndContext();
#line 87 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                  
                                    double paramValuePrice = item.Product.Price;
                                

#line default
#line hidden
                BeginContext(4171, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(4204, 37, false);
#line 90 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                           Write(Html.DisplayFor(m => paramValuePrice));

#line default
#line hidden
                EndContext();
                BeginContext(4241, 71, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
                EndContext();
#line 93 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                  
                                    int paramValueQuantity = item.Quantity;
                                

#line default
#line hidden
                BeginContext(4460, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(4493, 40, false);
#line 96 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                           Write(Html.DisplayFor(m => paramValueQuantity));

#line default
#line hidden
                EndContext();
                BeginContext(4533, 71, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
                EndContext();
#line 99 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                                  
                                    double parameterValue = item.TotalPrice();
                                

#line default
#line hidden
                BeginContext(4755, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(4788, 36, false);
#line 102 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                           Write(Html.DisplayFor(m => parameterValue));

#line default
#line hidden
                EndContext();
                BeginContext(4824, 68, true);
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 105 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                            }

#line default
#line hidden
                BeginContext(4923, 34, true);
                WriteLiteral("                        </table>\r\n");
                EndContext();
#line 107 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(5029, 92, true);
                WriteLiteral("                        <br /><br />\r\n                        <p>No Product registered</p>\r\n");
                EndContext();
#line 112 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
                    }

#line default
#line hidden
                BeginContext(5144, 48, true);
                WriteLiteral("                </div>\r\n            </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5199, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5228, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 119 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Create.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductSalesPoint.Pages.SaleList.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductSalesPoint.Pages.SaleList.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductSalesPoint.Pages.SaleList.CreateModel>)PageContext?.ViewData;
        public ProductSalesPoint.Pages.SaleList.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
