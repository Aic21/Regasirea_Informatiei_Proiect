#pragma checksum "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120fb19975be7b2127f0f45d2b4f63d3952f9a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListUsers), @"mvc.1.0.view", @"/Views/Administration/ListUsers.cshtml")]
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
#line 1 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using Regasirea_Informatiei_Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using Regasirea_Informatiei_Lab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120fb19975be7b2127f0f45d2b4f63d3952f9a0b", @"/Views/Administration/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be019ff7c5b0e9045a761d396af5d28d1b8c5fd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edituser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deleteuser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Createuser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
  
    ViewBag.Title = "- Users List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
 if (Model.Any())
{
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"content container-fluid\">\r\n        <div class=\"container-fluid text-center container-content\">\r\n            <h2");
            BeginWriteAttribute("class", " class=\"", 315, "\"", 323, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                <br>
                Administreaza Utilizatori
            </h2>
        </div>
        <div class=""container-fluid text-center container-content"">
            <hr>
            <div class=""card mb-3"">
                <div class=""card-header bg-custom text-white"">
                    <i class=""fas fa-sign-in-alt""></i> Lista utilizatori
                </div>
                <div class=""card-body mx-auto"">
                    <h5 class=""card-title""></h5>
                    <p class=""card-text"">
                        Selecteaza utillizatorul pe care doresti sa il editezi folosind butonul Edit sau sterge folosind Delete
                    </p>
                    <table class=""table table-striped table-dark"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">User Id</th>
                                <th scope=""col"">User Name</th>
                   ");
            WriteLiteral("             <th scope=\"col\">User Email</th>\r\n                                <th scope=\"col\">Action</th>\r\n                            </tr>\r\n                        </thead>\r\n");
#nullable restore
#line 40 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                         foreach (var user in Model)
                        {
                            string r;
                            var roles = await userManager.GetRolesAsync(user);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>\r\n                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 46 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                                   Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120fb19975be7b2127f0f45d2b4f63d3952f9a0b9853", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-edit\"></i>\r\n                                            Edit\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                                                                                                                           WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120fb19975be7b2127f0f45d2b4f63d3952f9a0b12621", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-delete\"></i>\r\n                                            Delete\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                                                                                                                             WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                            </tbody>\r\n");
#nullable restore
#line 62 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
                            i++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>
            </div>
            <div class=""card mb-3"">
                <div class=""card-header bg-custom text-white"">
                    <i class=""far fa-question-circle""></i> Creare rol nou
                </div>
                <div class=""card-body"">
                    <h5 class=""card-title""></h5>
                    <p class=""card-text"">
                        Un rol de utilizator defineste permisiunile pentru utilizatori de a efectua un grup de sarcini.
                        <br>

                        <br>
                        Folositi butonul de mai jos pentru a crea un rol nou.
                    </p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120fb19975be7b2127f0f45d2b4f63d3952f9a0b16503", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-user-plus\"></i>\r\n                        Creaza rol nou\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <hr>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 89 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""content container-fluid"">
        <div class=""container-fluid text-center container-content"">
            <hr>
            <div class=""card mb-3"">
                <div class=""card-header bg-custom text-white"">
                    <i class=""fas fa-sign-in-alt""></i> Lista roluri
                </div>
                <div class=""card-body mx-auto"">
                    <h5 class=""card-title""></h5>
                    <p class=""card-text"">
                        In prezent nu exista roluri definite
                    </p>
                    <table class=""table table-striped table-dark"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">user Id</th>
                                <th scope=""col"">user Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                 ");
            WriteLiteral(@"               <th scope=""row"">1</th>
                                <td></td>
                                <td></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""card mb-3"">
                <div class=""card-header bg-custom text-white"">
                    <i class=""far fa-question-circle""></i> Creare rol nou
                </div>
                <div class=""card-body"">
                    <h5 class=""card-title""></h5>
                    <p class=""card-text"">
                        Un rol de utilizator defineste permisiunile pentru utilizatori de a efectua un grup de sarcini.
                        <br>

                        <br>
                        Folositi butonul de mai jos pentru a crea un rol nou.
                    </p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120fb19975be7b2127f0f45d2b4f63d3952f9a0b20418", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-user-plus\"></i>\r\n                        Creaza rol nou\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <hr>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 144 "C:\Users\Andrei\source\repos\Regasirea_Informatiei_Lab\Regasirea_Informatiei_Lab\Views\Administration\ListUsers.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
