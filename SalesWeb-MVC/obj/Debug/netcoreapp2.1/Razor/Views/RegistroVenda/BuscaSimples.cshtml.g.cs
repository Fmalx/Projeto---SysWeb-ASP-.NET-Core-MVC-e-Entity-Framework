#pragma checksum "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c70c11a10e0e27995543e76cc50626597766c7cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroVenda_BuscaSimples), @"mvc.1.0.view", @"/Views/RegistroVenda/BuscaSimples.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroVenda/BuscaSimples.cshtml", typeof(AspNetCore.Views_RegistroVenda_BuscaSimples))]
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
#line 1 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\_ViewImports.cshtml"
using SalesWeb_MVC;

#line default
#line hidden
#line 2 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\_ViewImports.cshtml"
using SalesWeb_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70c11a10e0e27995543e76cc50626597766c7cb", @"/Views/RegistroVenda/BuscaSimples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339f0f3be5ddd986ff95d82d3b0fdfa7b6b9b6d7", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroVenda_BuscaSimples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWeb_MVC.Models.RegistroVenda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
  
    ViewData["Title"] = "Busca Simples";

#line default
#line hidden
            BeginContext(104, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(111, 17, false);
#line 6 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(128, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(217, 666, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869f27ad7b574edc8a7f880d048e3eb7", async() => {
                BeginContext(269, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Min</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 484, "\"", 512, 1);
#line 14 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
WriteAttributeValue("", 492, ViewData["minDate"], 492, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(513, 203, true);
                WriteLiteral("/>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Max</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 716, "\"", 744, 1);
#line 18 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
WriteAttributeValue("", 724, ViewData["maxDate"], 724, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(745, 131, true);
                WriteLiteral("/>\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filtro</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(883, 135, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Venda Total =");
            EndContext();
            BeginContext(1019, 40, false);
#line 27 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                                        Write(Model.Sum(obj=>obj.Valor).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1275, 38, false);
#line 34 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1393, 40, false);
#line 37 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1513, 44, false);
#line 40 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1637, 57, false);
#line 43 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1774, 41, false);
#line 46 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1895, 42, false);
#line 49 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1937, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 54 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2097, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2182, 37, false);
#line 58 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2311, 39, false);
#line 61 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(2350, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2442, 48, false);
#line 64 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2582, 61, false);
#line 67 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendedor.Departamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2643, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2735, 40, false);
#line 70 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(2775, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2867, 41, false);
#line 73 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2908, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 76 "C:\Users\felip_000\OneDrive\Cursos\C#\C#COMPLETO\Exercicios\SalesWeb-MVC\SalesWeb-MVC\Views\RegistroVenda\BuscaSimples.cshtml"

                }

#line default
#line hidden
            BeginContext(2989, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWeb_MVC.Models.RegistroVenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591