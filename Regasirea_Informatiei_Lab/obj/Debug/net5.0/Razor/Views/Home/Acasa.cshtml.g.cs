#pragma checksum "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93727b37e7315f2c5c24972000ae104715007f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Acasa), @"mvc.1.0.view", @"/Views/Home/Acasa.cshtml")]
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
#line 5 "D:\Licenta\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93727b37e7315f2c5c24972000ae104715007f1", @"/Views/Home/Acasa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be019ff7c5b0e9045a761d396af5d28d1b8c5fd6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Acasa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link py-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93727b37e7315f2c5c24972000ae104715007f15278", async() => {
                WriteLiteral(@"
            <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <link href=""https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700,800,900"" rel=""stylesheet"">

<link rel=""stylesheet"" href=""path/to/font-awesome/css/font-awesome.min.css"">
<link rel=""stylesheet"" href=""css/acasa.css"" />
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93727b37e7315f2c5c24972000ae104715007f16639", async() => {
                WriteLiteral(@"
<div class=""container-fluid h-100"" style=""margin-top:100px;"" >
    <div class=""row h-100"" >

       


        <div class=""col-2 collapse d-md-flex bg-dark pt-1 h-100 w-auto"" id=""sidebar"">
            <ul class=""nav nav-pills flex-column w-auto"">
                <li class=""nav-item"">
");
#nullable restore
#line 38 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                     foreach(var category in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"nav-link collapsed\" href=\"#submenu1\" data-toggle=\"collapse\" >");
#nullable restore
#line 40 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                                                                                      Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    <div class=\"collapse\" id=\"submenu1\" aria-expanded=\"false\">\r\n                        <ul class=\"flex-column pl-2 nav\">\r\n");
#nullable restore
#line 43 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                             foreach(var subcategoru in category.Subcategories)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"nav-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93727b37e7315f2c5c24972000ae104715007f18347", async() => {
#nullable restore
#line 45 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                                                                                                                                                                 Write(subcategoru.Nume);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-subcategory", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                                                                                                                                       WriteLiteral(subcategoru.Nume);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["subcategory"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-subcategory", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["subcategory"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n");
#nullable restore
#line 46 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 49 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </li>
            </ul>
        </div>
        <div class=""col pt-1"">
            <!--Carousel Wrapper-->
<div id=""carousel-example-2"" class=""carousel slide carousel-fade z-depth-1-half"" data-ride=""carousel"">
  <!--Indicators-->
  <ol class=""carousel-indicators"">
    <li data-target=""#carousel-example-2"" data-slide-to=""0"" class=""active""></li>
    <li data-target=""#carousel-example-2"" data-slide-to=""1""></li>
  </ol>
  <!--/.Indicators-->
  <!--Slides-->
  <div class=""carousel-inner"" role=""listbox"">
    <div class=""carousel-item active"">
      <div class=""view"">
        <img class=""d-block w-100 img-responsive"" src=""/css/img_website/car-amd.webp""  style=""object-fit:contain;"" alt=""First slide"">
        <div class=""mask rgba-black-light""></div>
      </div>

    </div>
    <div class=""carousel-item"">
      <!--Mask color-->
      <div class=""view"">
        <img class=""d-block w-100 img-responsive"" src=""https://s1.cel.ro/images/bner/car-gp-games-bundle-banner-multiformat-ro.");
                WriteLiteral(@"jpg""  style=""object-fit:cover; alt=""Second slide"">
        <div class=""mask rgba-black-light""></div>
      </div>

    </div>
  </div>
  <!--/.Slides-->
  <!--Controls-->
  <a class=""carousel-control-prev"" href=""#carousel-example-2"" role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Previous</span>
  </a>
  <a class=""carousel-control-next"" href=""#carousel-example-2"" role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Next</span>
  </a>
  <!--/.Controls-->
</div>
<!--/.Carousel Wrapper-->
        </div>
    </div>
</div>
            <section style=""background-color: #fff;"">
 <div class=""text-center container py-5"">
     <h4 class=""mt-4 mb-5""><strong><i class=""fa fa-star""></i>Produse promovate<i class=""fa fa-star""></i></strong></h4>
     <div class=""row"">
");
#nullable restore
#line 100 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
 foreach(var product in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
         foreach(var sub in product.Subcategories)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
             foreach(var prod in sub.Products)
            {
                 var photoPath = "/images/" + (prod.ProductPicture ?? "img.png");

                 if(prod.IsPromoted == true)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("      <div class=\"col-lg-4 col-md-12 mb-4\">\r\n        <div class=\"card\">\r\n          <div class=\"bg-image hover-zoom ripple ripple-surface ripple-surface-light\"\r\n            data-mdb-ripple-color=\"light\">\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 4398, "\"", 4414, 1);
#nullable restore
#line 116 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
WriteAttributeValue("", 4404, photoPath, 4404, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
              class=""w-100"" />
            <a href=""#!"">
              <div class=""mask"">
                <div class=""d-flex justify-content-start align-items-end h-100"">
                  <h5><span class=""badge bg-primary ms-2"">Nou</span></h5>
                </div>
              </div>
              <div class=""hover-overlay"">
                <div class=""mask"" style=""background-color: rgba(251, 251, 251, 0.15);""></div>
              </div>
            </a>
          </div>
          <div class=""card-body"">
            <a");
                BeginWriteAttribute("href", " href=\"", 4958, "\"", 4965, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"text-reset\">\r\n              <h5 class=\"card-title mb-3\">");
#nullable restore
#line 131 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                                     Write(prod.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<h5>\r\n            </a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 5085, "\"", 5092, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"text-reset\">\r\n              <p>");
#nullable restore
#line 134 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
            Write(prod.Subcategorie.Nume);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </a>\r\n            <h6 class=\"mb-3\">");
#nullable restore
#line 136 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
                        Write(prod.Pret);

#line default
#line hidden
#nullable disable
                WriteLiteral(" RON</h6>\r\n          </div>\r\n        </div>\r\n      </div>\r\n");
#nullable restore
#line 140 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"

                }

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Home\Acasa.cshtml"
         

    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"     </div>

    </section>

  <!-- Footer -->
<footer class=""text-center text-lg-start bg-light text-muted"">
  <!-- Section: Social media -->
  <section
    class=""d-flex justify-content-center justify-content-lg-between p-4 border-bottom""
  >
    <!-- Left -->
    <div class=""me-5 d-none d-lg-block"">
      <span>Unde ne poti gasi:</span>
    </div>
    <!-- Left -->

    <!-- Right -->
    <div>
      <a");
                BeginWriteAttribute("href", " href=\"", 5754, "\"", 5761, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n        <i class=\"fa fa-facebook-f\"></i>\r\n      </a>\r\n      <a");
                BeginWriteAttribute("href", " href=\"", 5851, "\"", 5858, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n        <i class=\"fa fa-twitter\"></i>\r\n      </a>\r\n      <a");
                BeginWriteAttribute("href", " href=\"", 5945, "\"", 5952, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n        <i class=\"fa fa-google\"></i>\r\n      </a>\r\n      <a");
                BeginWriteAttribute("href", " href=\"", 6038, "\"", 6045, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n        <i class=\"fa fa-instagram\"></i>\r\n      </a>\r\n      <a");
                BeginWriteAttribute("href", " href=\"", 6134, "\"", 6141, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n        <i class=\"fa fa-linkedin\"></i>\r\n      </a>\r\n      <a");
                BeginWriteAttribute("href", " href=\"", 6229, "\"", 6236, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"me-4 text-reset\">\r\n        <i class=\"fa fa-github\"></i>\r\n      </a>\r\n    </div>\r\n    <!-- Right -->\r\n  </section>\r\n  <!-- Section: Social media -->\r\n\r\n  <!-- Section: Links  -->\r\n  <section");
                BeginWriteAttribute("class", " class=\"", 6434, "\"", 6442, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <div class=""container text-center text-md-start mt-5"">
      <!-- Grid row -->
      <div class=""row mt-3"">
        <!-- Grid column -->
        <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">
          <!-- Content -->
          <h6 class=""text-uppercase fw-bold mb-4"">
            <i class=""fas fa-gem me-3""></i>OnlineShop
          </h6>
          <p>
            Tehnologia reprezinta evolutia omenirii.
          </p>
        </div>
        <!-- Grid column -->

        <!-- Grid column -->
        <!-- Grid column -->

        <!-- Grid column -->
        <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">
          <!-- Links -->
          <h6 class=""text-uppercase fw-bold mb-4"">
            Link-uri utile
          </h6>
          <p>
            <a href=""#!"" class=""text-reset"">Produse</a>
          </p>
          <p>
            <a href=""#!"" class=""text-reset"">Contact</a>
          </p>
          <p>
            <a href=""#!"" class=""text-reset"">Despre noi</a>");
                WriteLiteral(@"
          </p>
          <p>
            <a href=""#!"" class=""text-reset"">Contul meu</a>
          </p>
        </div>
        <!-- Grid column -->

        <!-- Grid column -->
        <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">
          <!-- Links -->
          <h6 class=""text-uppercase fw-bold mb-4"">
            Contact
          </h6>
          <p><i class=""fas fa-home me-3""></i> Craiova, DJ 200552, RO</p>
          <p>
            <i class=""fas fa-envelope me-3""></i>
            info@onlineshop.ro
          </p>
          <p><i class=""fas fa-phone me-3""></i> + 40 786 378 799 </p>
          <p><i class=""fas fa-print me-3""></i> + 40 786 378 799</p>
        </div>
        <!-- Grid column -->
      </div>
      <!-- Grid row -->
    </div>
  </section>
  <!-- Section: Links  -->

  <!-- Copyright -->
  <div class=""text-center p-4"" style=""background-color: rgba(0, 0, 0, 0.05);"">
    © 2022 Copyright:
    <a class=""text-reset fw-bold""");
                BeginWriteAttribute("href", " href=\"", 8465, "\"", 8472, 0);
                EndWriteAttribute();
                WriteLiteral(">OnlineShop.ro</a>\r\n  </div>\r\n  <!-- Copyright -->\r\n</footer>\r\n<!-- Footer -->  \r\n");
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
