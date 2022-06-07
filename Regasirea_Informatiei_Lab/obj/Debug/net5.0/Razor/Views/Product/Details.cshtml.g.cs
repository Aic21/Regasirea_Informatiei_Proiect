#pragma checksum "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad588ef60447a9617eb442cfc8d8a7184d7d90c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "D:\Licenta\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using Regasirea_Informatiei_Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Licenta\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using Regasirea_Informatiei_Lab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Licenta\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Licenta\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad588ef60447a9617eb442cfc8d8a7184d7d90c4", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be019ff7c5b0e9045a761d396af5d28d1b8c5fd6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/productdetails.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-amount", "test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var photoPath = "/images/" + (Model.ProductPicture ?? "img.png");
    var photoPath2 = "/images/" + (Model.ProductPicture2 ?? "img.png");
    var photoPath3 = "/images/" + (Model.ProductPicture3 ?? "img.png");
    var videoPath = "/video/" + (Model.ProductVideo ?? "img.png");
     var doc = "/images/" + (Model.DocumentPath ?? "img.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad588ef60447a9617eb442cfc8d8a7184d7d90c46628", async() => {
                WriteLiteral("\r\n    <title></title>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad588ef60447a9617eb442cfc8d8a7184d7d90c47029", async() => {
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
                WriteLiteral("\r\n\r\n  \r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad588ef60447a9617eb442cfc8d8a7184d7d90c48925", async() => {
                WriteLiteral(@"



    <div class=""container"" style=""margin-top:100px;"">
    <div class=""col-lg-8 border p-3 main-section bg-white"">
        <div class=""row hedding m-0 pl-3 pt-0 pb-3"">
        </div>
        <div class=""row m-0"">
            <div class=""col-lg-4 left-side-product-box pb-3"">
                <img");
                BeginWriteAttribute("src", " src=\"", 1044, "\"", 1060, 1);
#nullable restore
#line 39 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
WriteAttributeValue("", 1050, photoPath, 1050, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"border p-3\" id=\"first_image\">\r\n                <span class=\"sub-img\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1164, "\"", 1180, 1);
#nullable restore
#line 41 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
WriteAttributeValue("", 1170, photoPath, 1170, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"border p-2\"onclick=\"myFunction(this);\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1254, "\"", 1271, 1);
#nullable restore
#line 42 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
WriteAttributeValue("", 1260, photoPath2, 1260, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"border p-2\"onclick=\"myFunction(this);\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1345, "\"", 1362, 1);
#nullable restore
#line 43 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
WriteAttributeValue("", 1351, photoPath3, 1351, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""border p-2""onclick=""myFunction(this);"">
                </span>
            </div>
            <div class=""col-lg-8"">
                <div class=""right-side-pro-detail border p-3 m-0"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <span></span>
                            <p class=""m-0 p-0"">");
#nullable restore
#line 51 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                                          Write(Model.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <p class=\"m-0 p-0 price-pro\">");
#nullable restore
#line 54 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                                                    Write(Model.Pret);

#line default
#line hidden
#nullable disable
                WriteLiteral(" RON</p>\r\n                            <hr class=\"p-0 m-0\">\r\n                        </div>\r\n                        <div class=\"col-lg-12 pt-2\">\r\n                            <h5>Culoare:</h5>\r\n                            <span>");
#nullable restore
#line 59 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                             Write(Model.ProductColor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <hr class=\"m-0 pt-2 mt-2\">\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <p class=\"tag-section\"><strong>Categorie : </strong>");
#nullable restore
#line 63 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                                                                           Write(Model.Subcategorie.Categories.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 63 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                                                                                                                         Write(Model.Subcategorie.Nume);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
     
                        <div class=""col-lg-12"">
                            <h6>Cantitate :</h6>
                            <input name=""amount"" id=""test"" type=""number"" class=""form-control text-center w-100"" placeholder=""1"">
                        </div>
                        <div class=""col-lg-12 mt-3"">
                            <div class=""row"">
                                <div class=""col-lg-6 pb-2"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad588ef60447a9617eb442cfc8d8a7184d7d90c414142", async() => {
                    WriteLiteral("Add To Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                                                                                                             WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-amount", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["amount"] = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <div class=""col-lg-6"">
                                    <a href=""#"" class=""btn btn-success w-100"">Add to wishlist</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 text-center pt-3"">
                <h4>Descriere</h4>
            </div>
            <div class=""col-lg-12 text-center pt-3"">
                <table>");
#nullable restore
#line 89 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                  Write(Html.Raw(@WebUtility.HtmlDecode(@Model.ProductDescription)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</table>\r\n                \r\n            </div>\r\n            \r\n            <div class=\"col-lg-12 text-center pt-3\">\r\n");
#nullable restore
#line 94 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                 foreach(string text in ViewBag.Data)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h4> ");
#nullable restore
#line 96 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                        Write(text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 97 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Product\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
        </div>
        
    </div>
</div>


    <script>
        var $content = $('.menu-content');

        function showContent(type) {
            $content.hide().filter('.' + type).show();
        }

        $('.menu').on('click', '.menu-btn', function (e) {
            showContent(e.currentTarget.hash.slice(1));
            e.preventDefault();
        });

        // show 'about' content only on page load (if you want)
        showContent('about');
    </script>
    <script>
function myFunction(imgs) {
  var expandImg = document.getElementById(""first_image"");
  expandImg.src = imgs.src;
  expandImg.parentElement.style.display = ""block"";
}
</script>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
