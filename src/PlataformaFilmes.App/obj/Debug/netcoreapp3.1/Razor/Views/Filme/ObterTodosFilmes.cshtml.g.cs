#pragma checksum "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a15b07516b040e13ffd2db51e249508af5738f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filme_ObterTodosFilmes), @"mvc.1.0.view", @"/Views/Filme/ObterTodosFilmes.cshtml")]
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
#line 1 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\_ViewImports.cshtml"
using PlataformaFilmes.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\_ViewImports.cshtml"
using PlataformaFilmes.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a15b07516b040e13ffd2db51e249508af5738f6", @"/Views/Filme/ObterTodosFilmes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"105955c7bed7a0d12f0894eb67954273f1bed44f", @"/Views/_ViewImports.cshtml")]
    public class Views_Filme_ObterTodosFilmes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlataformaFilmes.Model.Model.Filme>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Filme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "adicionar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a15b07516b040e13ffd2db51e249508af5738f64510", async() => {
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a15b07516b040e13ffd2db51e249508af5738f65480", async() => {
                WriteLiteral("\r\n    <h2>Lista de filmes</h2>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a15b07516b040e13ffd2db51e249508af5738f65774", async() => {
                    WriteLiteral("Adicionar filme");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <hr />\r\n\r\n    <div>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 17 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 18 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 19 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 20 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Diretor));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 21 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayNameFor(model => model.Categorias));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n");
#nullable restore
#line 24 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayFor(model => item.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayFor(model => item.Descricao));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.DisplayFor(model => item.Diretor.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><button class=\"btn btn-primary\">Categorias</button></td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.ActionLink("Editar", "AtualizarFilme", "Filme", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 34 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
                   Write(Html.ActionLink("Excluir", "DeletarFilme", "Filme", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Dev\CSharp\PlataformaFilmes\PlataformaFilmes\src\PlataformaFilmes.App\Views\Filme\ObterTodosFilmes.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n\r\n   \r\n\r\n     \r\n        \r\n\r\n\r\n\r\n");
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlataformaFilmes.Model.Model.Filme>> Html { get; private set; }
    }
}
#pragma warning restore 1591
