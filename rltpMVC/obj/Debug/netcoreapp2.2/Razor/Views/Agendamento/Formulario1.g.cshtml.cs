#pragma checksum "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Agendamento\Formulario1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad69821826a2d8e9875d50efab2656b9ba95b352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agendamento_Formulario1), @"mvc.1.0.view", @"/Views/Agendamento/Formulario1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agendamento/Formulario1.cshtml", typeof(AspNetCore.Views_Agendamento_Formulario1))]
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
#line 1 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\_ViewImports.cshtml"
using rltpMVC;

#line default
#line hidden
#line 2 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\_ViewImports.cshtml"
using rltpMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad69821826a2d8e9875d50efab2656b9ba95b352", @"/Views/Agendamento/Formulario1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f35467213ce6a92f921449c8dfadf3f4bb5fcd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Agendamento_Formulario1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<rltpMVC.ViewModels.AgendamentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 165, true);
            WriteLiteral("\r\n        <div id=\"corfor\">\r\n            \r\n            \r\n            <section id=\"for\">\r\n                \r\n                <div id=\"botoesfor\">\r\n                    ");
            EndContext();
            BeginContext(217, 2692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad69821826a2d8e9875d50efab2656b9ba95b3523878", async() => {
                BeginContext(286, 131, true);
                WriteLiteral("\r\n                        <label for=\"nome\">Nome Completo</label>\r\n                        <input type=\"text\" id=\"nome\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 417, "\"", 444, 1);
#line 11 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Agendamento\Formulario1.cshtml"
WriteAttributeValue("", 425, Model.Cliente.Nome, 425, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(445, 202, true);
                WriteLiteral(" placeholder=\"Seu nome aqui...\" required>\r\n                        \r\n                        <label for=\"cpfcnpj\">CPF/CNPJ</label>\r\n                        <input type=\"text\" id=\"cpfcnpj\" name=\"cpfcnpj\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 647, "\"", 677, 1);
#line 14 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Agendamento\Formulario1.cshtml"
WriteAttributeValue("", 655, Model.Cliente.Cpfcnpj, 655, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(678, 225, true);
                WriteLiteral(" placeholder=\"000.000.000-00 ou 00.000.000/0000-00\" required>\r\n                        \r\n                        <label for=\"telefone\">Telefone</label>\r\n                        <input type=\"text\" id=\"telefone\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 903, "\"", 934, 1);
#line 17 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Agendamento\Formulario1.cshtml"
WriteAttributeValue("", 911, Model.Cliente.Telefone, 911, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(935, 171, true);
                WriteLiteral(" placeholder=\"(11) 0000-0000\" required>\r\n\r\n                        <label for=\"telefone\">Email</label>\r\n                        <input type=\"email\" id=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1106, "\"", 1134, 1);
#line 20 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Agendamento\Formulario1.cshtml"
WriteAttributeValue("", 1114, Model.Cliente.Email, 1114, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1135, 1767, true);
                WriteLiteral(@" placeholder=""Email para contato"" required>
                        
                        <label for=""tipoEvento"">Tipo de Evento</label>
                        <input type=""text"" id=""tipoEvento"" name=""tipoEvento"" placeholder=""Ex: Casamento"" required>
                        
                        <label for=""dataEvento"">Data do Evento</label>
                        <input type=""date"" id=""dataEvento"" name=""dataEvento"" min=""2019-12-01"" max=""2022-12-31"" required>
                        
                        <label for=""inicioEvento"">Horário de Início do Evento</label>
                        <input type=""time"" id=""inicioEvento"" name=""inicioEvento"" placeholder=""Seu nome aqui..."" required>
                        
                        <label for=""terminoEvento"">Horário de Término do Evento</label>
                        <input type=""time"" id=""terminoEvento"" name=""terminoEvento"" placeholder=""Seu nome aqui..."" required>
                        
                        <label for=""numPess");
                WriteLiteral(@"oas"">Número de Pessoas</label>
                        <input type=""number"" id=""numPessoas"" name=""numPessoas"" min=""0"" max=""250"" step=""5"" placeholder=""Quantidade de convidados..."" required>
                        
                        <label for=""descricaoEvento"">Descrição do Evento</label>
                        <textarea type=""text"" id=""descricaoEvento"" name=""descricaoEvento"" cols=""20"" rows=""7"" placeholder=""Uma breve descrição com suas pretenções para este evento..."" required></textarea>
                        
                        <div id=""bcon"">
                            <button type=""submit"" class=""confirmar"" placeholder=""Confirmar""><p>Confirmar</p> </button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 9 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Agendamento\Formulario1.cshtml"
AddHtmlAttributeValue("", 231, Url.Action("Registrar1","Agendamento"), 231, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2909, 101, true);
            WriteLiteral("\r\n                </div>\r\n            </section>\r\n            \r\n        </div>\r\n        \r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<rltpMVC.ViewModels.AgendamentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
