#pragma checksum "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc5966fe3c9931c98b487302c249cb5d3e0379f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc5966fe3c9931c98b487302c249cb5d3e0379f", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 17, true);
            WriteLiteral("\r\n<main>\r\n   <h2>");
            EndContext();
            BeginContext(66, 17, false);
#line 4 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
  Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(83, 11, true);
            WriteLiteral("!</h2>\r\n   ");
            EndContext();
            BeginContext(94, 1955, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc5966fe3c9931c98b487302c249cb5d3e0379f4407", async() => {
                BeginContext(158, 155, true);
                WriteLiteral("\r\n       <div>\r\n           <label for=\"nome\">Nome Completo</label>\r\n           <br />\r\n           <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 313, "\"", 340, 1);
#line 9 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 321, Model.Cliente.Nome, 321, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(341, 187, true);
                WriteLiteral(" name=\"nome\"/>\r\n       </div>\r\n       <div>\r\n           <label for=\"endereco\">Endereço</label>\r\n           <br />\r\n           <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 528, "\"", 559, 1);
#line 14 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 536, Model.Cliente.Endereco, 536, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(560, 203, true);
                WriteLiteral(" name=\"endereco\"/>\r\n       </div>\r\n       <div>\r\n           <label for=\"telefone\">Telefone para contato</label>\r\n           <br />\r\n           <input id=\"telefone\" type=\"text\" placeholder=\"11 12345 6789\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 763, "\"", 794, 1);
#line 19 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 771, Model.Cliente.Telefone, 771, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(795, 155, true);
                WriteLiteral(" name=\"telefone\"/>\r\n       </div>\r\n       <div>\r\n           <label for=\"email\">E-mail</label>\r\n           <br />\r\n           <input id=\"email\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 950, "\"", 978, 1);
#line 24 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 958, Model.Cliente.Email, 958, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(979, 231, true);
                WriteLiteral(" name=\"email\"/>\r\n       </div>\r\n       <div class=\"double-field\">\r\n           <div>\r\n               <label for=\"hamburguer\">Hamburguer</label>\r\n               <select id=\"hamburguer\" name=\"hamburguer\" required>\r\n                   ");
                EndContext();
                BeginContext(1210, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc5966fe3c9931c98b487302c249cb5d3e0379f7478", async() => {
                    BeginContext(1245, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1263, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                    foreach (var hamburguer in Model.Hamburgueres)
                    {

#line default
#line hidden
                BeginContext(1356, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1380, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc5966fe3c9931c98b487302c249cb5d3e0379f9935", async() => {
                    BeginContext(1412, 15, false);
#line 33 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                  Write(hamburguer.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1427, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1433, 16, false);
#line 33 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                                       Write(hamburguer.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1449, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                          WriteLiteral(hamburguer.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1459, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1484, 189, true);
                WriteLiteral("               </select>\r\n           </div>\r\n           <div>\r\n               <label for=\"shake\">Shake</label>\r\n               <select id=\"shake\" name=\"shake\" required>\r\n                   ");
                EndContext();
                BeginContext(1673, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc5966fe3c9931c98b487302c249cb5d3e0379f12982", async() => {
                    BeginContext(1708, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1726, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                    foreach (var shake in Model.Shakes)
                    {

#line default
#line hidden
                BeginContext(1808, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1832, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc5966fe3c9931c98b487302c249cb5d3e0379f15429", async() => {
                    BeginContext(1859, 10, false);
#line 43 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                             Write(shake.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1869, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1875, 11, false);
#line 43 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                             Write(shake.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1886, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 43 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                          WriteLiteral(shake.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1896, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1921, 121, true);
                WriteLiteral("               </select>\r\n           </div>\r\n       </div>\r\n       <input type=\"submit\" value=\"Finalizar pedido!\" />\r\n   ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 5 "C:\Users\45626490892\Documents\Ex\McBonaldsMVC\Views\Pedido\Index.cshtml"
AddHtmlAttributeValue("", 122, Url.Action("Registrar", "Pedido"), 122, 34, false);

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
            BeginContext(2049, 9, true);
            WriteLiteral("\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
