#pragma checksum "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9931f176ad7273c1e7fdcb8e25ebda8fee8feda3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProductSalesPoint.Pages.SaleList.Pages_SaleList_Index), @"mvc.1.0.razor-page", @"/Pages/SaleList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SaleList/Index.cshtml", typeof(ProductSalesPoint.Pages.SaleList.Pages_SaleList_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9931f176ad7273c1e7fdcb8e25ebda8fee8feda3", @"/Pages/SaleList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89db821315466f16f387e9f79d90b3b545c8c2e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SaleList_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 144, true);
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"container row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Sales Historic List</h2>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 15 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
 if(Model.Message != null)
{

#line default
#line hidden
            BeginContext(275, 233, true);
            WriteLiteral("    <div class=\"alert-info alert alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aira-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n        ");
            EndContext();
            BeginContext(509, 13, false);
#line 21 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(522, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 23 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
}

#line default
#line hidden
            BeginContext(539, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(541, 1564, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9931f176ad7273c1e7fdcb8e25ebda8fee8feda34983", async() => {
                BeginContext(561, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
     if (Model.Sales.Count() > 0)
    {

#line default
#line hidden
                BeginContext(605, 22, true);
                WriteLiteral("        <br /><br />\r\n");
                EndContext();
                BeginContext(629, 136, true);
                WriteLiteral("        <table class=\"table table-striped border\">\r\n            <tr class=\"table-secondary\">\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(766, 53, false);
#line 33 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Sales.FirstOrDefault().Id));

#line default
#line hidden
                EndContext();
                BeginContext(819, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(887, 32, false);
#line 36 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
               Write(Html.DisplayName("Product List"));

#line default
#line hidden
                EndContext();
                BeginContext(919, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(987, 34, false);
#line 39 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
               Write(Html.DisplayName("Total Quantity"));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1089, 31, false);
#line 42 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
               Write(Html.DisplayName("Total Price"));

#line default
#line hidden
                EndContext();
                BeginContext(1120, 44, true);
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
                EndContext();
#line 45 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
             foreach (var item in Model.Sales)
            {

#line default
#line hidden
                BeginContext(1227, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1276, 29, false);
#line 49 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
           Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1305, 39, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
                EndContext();
#line 52 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
                  
                    String parameterValueName = item.ProductList();
                

#line default
#line hidden
                BeginContext(1452, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1469, 48, false);
#line 55 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
           Write(Html.DisplayFor(modelItem => parameterValueName));

#line default
#line hidden
                EndContext();
                BeginContext(1517, 39, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
                EndContext();
#line 58 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
                  
                    int parameterValueQunatity = item.ProductQuantity();
                

#line default
#line hidden
                BeginContext(1669, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1686, 52, false);
#line 61 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
           Write(Html.DisplayFor(modelItem => parameterValueQunatity));

#line default
#line hidden
                EndContext();
                BeginContext(1738, 39, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
                EndContext();
#line 64 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
                  
                    double parameterValue = item.TotalPrice();
                

#line default
#line hidden
                BeginContext(1880, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1897, 44, false);
#line 67 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
           Write(Html.DisplayFor(modelItem => parameterValue));

#line default
#line hidden
                EndContext();
                BeginContext(1941, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 70 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1992, 18, true);
                WriteLiteral("        </table>\r\n");
                EndContext();
#line 72 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(2034, 57, true);
                WriteLiteral("        <br /><br />\r\n        <p>No Sale registered</p>\r\n");
                EndContext();
#line 77 "D:\workspace_new\ProductSalesPoint\ProductSalesPoint\Pages\SaleList\Index.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2105, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductSalesPoint.Pages.SaleList.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductSalesPoint.Pages.SaleList.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductSalesPoint.Pages.SaleList.IndexModel>)PageContext?.ViewData;
        public ProductSalesPoint.Pages.SaleList.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
