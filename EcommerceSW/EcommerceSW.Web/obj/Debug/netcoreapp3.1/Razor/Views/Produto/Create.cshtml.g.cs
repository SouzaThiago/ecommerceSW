#pragma checksum "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eeb0c76403f69084dabbf2db65aacb9fe7589bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Create), @"mvc.1.0.view", @"/Views/Produto/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eeb0c76403f69084dabbf2db65aacb9fe7589bd", @"/Views/Produto/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823073a4351d3f3f68a96c5796815ce599cd30c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceSW.Web.Model.ProdutoViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eeb0c76403f69084dabbf2db65aacb9fe7589bd3343", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"" />
        <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"" />
        <script src=""https://code.jquery.com/jquery-3.3.0.js""
                integrity=""sha256-TFWSuDJt6kS+huV+vVlyV1jM3dwGdeNWqezhTxXB/X8=""
                crossorigin=""anonymous""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js""></script>
        <script>
            $(function() {
                $(""#criar"").click(function () {
                    toastr.options = {
                        ""timeout"": 50000,
                        ""positionClass"": ""toast-top-center""
                    };
                    toastr.success(""Produto salvo com sucesso"");
                });
            });
        </script>
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
            WriteLiteral("\r\n<h2>Criar Produto</h2>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 32 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 36 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
       Write(Html.LabelFor(model => model.Preco, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 44 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
           Write(Html.EditorFor(model => model.Preco, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Preco, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
       Write(Html.LabelFor(model => model.Promocao, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Promocao, (List<SelectListItem>)ViewData["ListaPromocoes"], new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 53 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Promocao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <button type=""submit"" id=""criar"" name=""criar"" class=""btn-info"">Criar produto</button>
            </div>
        </div>
    </div>
");
#nullable restore
#line 63 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 65 "C:\Users\Thiago\source\repos\EcommerceSW\EcommerceSW.Web\Views\Produto\Create.cshtml"
Write(Html.ActionLink("Voltar para a Lista", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommerceSW.Web.Model.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
