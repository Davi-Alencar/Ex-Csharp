#pragma checksum "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8e520ae49d18836587208687e37f61487397b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8e520ae49d18836587208687e37f61487397b3d", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f35467213ce6a92f921449c8dfadf3f4bb5fcd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agendamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Formulario1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("confirmar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 154, true);
            WriteLiteral("    <main>\r\n        \r\n        <div id=\"corfor\">\r\n\r\n            <h2>Dados do Usuário</h2>\r\n\r\n                <div id=\"botoesfor\">\r\n                        ");
            EndContext();
            BeginContext(154, 1734, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e520ae49d18836587208687e37f61487397b3d4543", async() => {
                BeginContext(197, 139, true);
                WriteLiteral("\r\n                            <label for=\"nome\">Nome Completo</label>\r\n                            <input type=\"text\" id=\"nome\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 336, "\"", 363, 1);
#line 10 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Menu\Index.cshtml"
WriteAttributeValue("", 344, Model.Cliente.Nome, 344, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(364, 204, true);
                WriteLiteral(" placeholder=\"Nome do Usuário\">\r\n                            \r\n                            <label for=\"cpfcnpj\">CPF/CNPJ</label>\r\n                            <input type=\"text\" id=\"cpfcnpj\" name=\"cpfcnpj\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 568, "\"", 598, 1);
#line 13 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Menu\Index.cshtml"
WriteAttributeValue("", 576, Model.Cliente.Cpfcnpj, 576, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(599, 212, true);
                WriteLiteral(" placeholder=\"Documento do Usuário\">\r\n                            \r\n                            <label for=\"telefone\">Telefone</label>\r\n                            <input type=\"text\" id=\"telefone\" name=\"telefone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 811, "\"", 842, 1);
#line 16 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Menu\Index.cshtml"
WriteAttributeValue("", 819, Model.Cliente.Telefone, 819, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(843, 172, true);
                WriteLiteral(" placeholder=\"Contato do Usuário\")>\r\n\r\n                            <label for=\"email\">Email</label>\r\n                            <input type=\"email\" id=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1015, "\"", 1043, 1);
#line 19 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Menu\Index.cshtml"
WriteAttributeValue("", 1023, Model.Cliente.Email, 1023, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1044, 186, true);
                WriteLiteral(" placeholder=\"Email do Usuário\")>\r\n\r\n                            <!-- <label for=\"senha\">Senha</label>\r\n                            <input type=\"password\" id=\"senha\" name=\"senha\" value=\"");
                EndContext();
                BeginContext(1231, 19, false);
#line 22 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Menu\Index.cshtml"
                                                                             Write(Model.Cliente.Senha);

#line default
#line hidden
                EndContext();
                BeginContext(1250, 307, true);
                WriteLiteral(@""" placeholder=""Senha do Usuário"")> -->
                            

                        <div id=""bneg"">
                            <a href=""rltp.html"" class=""confirmar"">Excluir Minha Conta</a>
                        </div>

                        <div id=""bneg"">
                            ");
                EndContext();
                BeginContext(1557, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e520ae49d18836587208687e37f61487397b3d8277", async() => {
                    BeginContext(1632, 17, true);
                    WriteLiteral("Agendar um Evento");
                    EndContext();
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
                EndContext();
                BeginContext(1653, 228, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        <div id=\"bneg\">\r\n                            <a href=\"formulário.html\" class=\"confirmar\">Cancelar Meu Evento</a>\r\n                        </div>\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 8 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Menu\Index.cshtml"
AddHtmlAttributeValue("", 168, Url.Action("Index","Menu"), 168, 27, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1888, 101, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
