#pragma checksum "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8b226c920180006453a08645e3d8fcf2488da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Index), @"mvc.1.0.view", @"/Views/Reservation/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\_ViewImports.cshtml"
using kolokwium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\_ViewImports.cshtml"
using kolokwium.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8b226c920180006453a08645e3d8fcf2488da9", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18eb3e3df572a3ef264b769e640e465993ac4cca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<kolokwium.Models.Reservation>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f8b226c920180006453a08645e3d8fcf2488da93766", async() => {
                WriteLiteral("\r\n        <div class=\"float-left\" style=\"padding-bottom: 5px;\">\r\n            <input type=\"button\" class=\"btn btn-primary\" value=\"Dodaj nową rezerwację\" />\r\n        </div>\r\n    ");
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
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>   
            <th>
                Imię
            </th>
            <th>
                Nazwisko
            </th>
            <th>
                Adres
            </th>
            <th>
                Liczba osób
            </th>
            <th>
                Liczba osób
            </th>
            <th>
                Czy są osoby poniżej 12 roku
            </th>
            <th>
                Data od rezerwacji
            </th>
            <th>
                Data do rezerwacji
            </th>
            <th>
                Typ pokoju
            </th>
            <th>
                Liczba osób poniżej 12 roku życia
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 53 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 1194, "\"", 1257, 2);
            WriteAttributeValue("", 1202, "element", 1202, 7, true);
#nullable restore
#line 54 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
WriteAttributeValue(" ", 1209, item.EndDate < DateTime.Now ? "expired" : "", 1210, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">              \r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HasKids));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StarDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RoomType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KidsUnderAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>     \r\n                    <td>\r\n                        <div class=\"float-right\" style=\"padding: 5px\">\r\n                        <button class=\"btn btn-danger comeback-btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2675, "\"", 2768, 3);
            WriteAttributeValue("", 2685, "location.href=\'", 2685, 15, true);
#nullable restore
#line 87 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
WriteAttributeValue("", 2700, Url.Action("Delete", "Reservation", new { reservationId=item.Id }), 2700, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2767, "\'", 2767, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fa-solid\">Usuń</i>\r\n                        </button>\r\n                    </div>\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Admin\Desktop\Kolokwium_64182\kolokwium\kolokwium\Views\Reservation\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<style>\r\n    .expired {\r\n        color: gray;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<kolokwium.Models.Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591