#pragma checksum "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe214b25b8d67e0d0fa4aa320bc05a9fc9676c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Details), @"mvc.1.0.view", @"/Views/Carrinho/Details.cshtml")]
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
#line 1 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\_ViewImports.cshtml"
using EcommerceSW.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\_ViewImports.cshtml"
using EcommerceSW.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe214b25b8d67e0d0fa4aa320bc05a9fc9676c04", @"/Views/Carrinho/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823073a4351d3f3f68a96c5796815ce599cd30c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EcommerceSW.Web.Model.CarrinhoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
  
    ViewData["Title"] = "Details";
    decimal valorTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Carrinho</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 12 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantidadeProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PromocaoProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
     foreach (var item in Model)
    {
        valorTotal += item.ValorTotal;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantidadeProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.PromocaoProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<p>\r\n    ");
#nullable restore
#line 50 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
Write(Html.DisplayNameFor(model => model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 51 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Carrinho\Details.cshtml"
Write(Html.Label("Valor", "R$ " + valorTotal.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EcommerceSW.Web.Model.CarrinhoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
