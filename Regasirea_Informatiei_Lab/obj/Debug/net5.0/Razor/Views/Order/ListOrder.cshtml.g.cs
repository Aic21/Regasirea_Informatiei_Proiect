#pragma checksum "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b4f54e90c6620663567640051e1820ff4eff032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ListOrder), @"mvc.1.0.view", @"/Views/Order/ListOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b4f54e90c6620663567640051e1820ff4eff032", @"/Views/Order/ListOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be019ff7c5b0e9045a761d396af5d28d1b8c5fd6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_ListOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    var x = ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""height:200px;"">

</div>
<div style=""container"">
<table  id=""myTable"" class=""table table-striped table-dark"">
    <thead>
        <tr>
            <th scope=""col"">Nr.Comanda</th>
            <th scope=""col"">Produs</th>

            <th scope=""col"">Informatii</th>
            <th scope=""col"">Status comanda</th>



        </tr>
    </thead>
");
#nullable restore
#line 24 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td style=\"color:white;font-weight:bold;\">");
#nullable restore
#line 28 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                                     Write(product.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color:white;font-weight:bold;\">");
#nullable restore
#line 29 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                                     Write(product.Nume_Produs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                <button type=\"button\" class=\"btn btn-info\" data-toggle=\"modal\" data-target=\"#exampleModal-");
#nullable restore
#line 32 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                                                                                     Write(product.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" > Informatii </button>\r\n                </td>\r\n");
#nullable restore
#line 34 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                 if(@product.Status_Comanda == "In asteptare")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-warning\" style=\"font-weight:bold;\">");
#nullable restore
#line 37 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                                                      Write(product.Status_Comanda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 38 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td  class=\"text-success\" style=\"font-weight:bold;\">");
#nullable restore
#line 42 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                                                       Write(product.Status_Comanda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n\r\n                \r\n               <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1397, "\"", 1431, 2);
            WriteAttributeValue("", 1402, "exampleModal-", 1402, 13, true);
#nullable restore
#line 47 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
WriteAttributeValue("", 1415, product.OrderId, 1415, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Informatii comanda numar ");
#nullable restore
#line 51 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                                                           Write(product.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">

           
                    <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Nume</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 64 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 64 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                                              Write(product.Order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
              </div>
            </div>
            <hr>

            <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Adresa</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 74 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
              </div>
            </div>
            <hr>
            <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Oras</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 83 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Order.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
              </div>
            </div>
            <hr>
            <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Telefon</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 92 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Order.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
              </div>
            </div>
            <hr>
           <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Produs</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 101 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Nume_Produs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
              </div>
            </div>
            <hr>
           <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Cantitate</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 110 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
              </div>
            </div>
            <hr>
            <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Valoare</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 119 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Order.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
              </div>
            </div>
            <hr>
           <div class=""row"">
              <div class=""col-sm-3"">
                <p class=""mb-0"">Metoda de plata</p>
              </div>
              <div class=""col-sm-9"">
                <p class=""text-muted mb-0"">");
#nullable restore
#line 128 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
                                      Write(product.Metoda_Plata);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
              </div>
            </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
      </div>
    </div>
  </div>
</div>

            </tr>
        </tbody>
");
#nullable restore
#line 141 "D:\Licenta\Regasirea_Informatiei_Lab\Views\Order\ListOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
