#pragma checksum "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b924ac62a4ddb4d6ffddbcc1ab13d8a102c2a44f7e0250dc46b62590f917dd70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Delete), @"mvc.1.0.view", @"/Views/Product/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b924ac62a4ddb4d6ffddbcc1ab13d8a102c2a44f7e0250dc46b62590f917dd70", @"/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"075db933fc649c671183c6525454b3de5089adf20bc2cfdf2d13f36fa43cb60d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
  
    ViewData["Title"] = "Delete Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h3>Are you sure you want to delete this product?</h3>\n\n");
#nullable restore
#line 11 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
 if (ViewBag.Error != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger\">\n        ");
#nullable restore
#line 14 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b924ac62a4ddb4d6ffddbcc1ab13d8a102c2a44f7e0250dc46b62590f917dd705484", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 19 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <hr />\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 26 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 29 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 33 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 36 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 39 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 42 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 45 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 48 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 51 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 54 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 57 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 60 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n\n        </dl>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b924ac62a4ddb4d6ffddbcc1ab13d8a102c2a44f7e0250dc46b62590f917dd7011075", async() => {
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b924ac62a4ddb4d6ffddbcc1ab13d8a102c2a44f7e0250dc46b62590f917dd7011368", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 66 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b924ac62a4ddb4d6ffddbcc1ab13d8a102c2a44f7e0250dc46b62590f917dd7013200", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 71 "D:\source_code\SC_PRN211\prn211-asm-main\Asm3_Solution\eStore\Views\Product\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessObject.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
