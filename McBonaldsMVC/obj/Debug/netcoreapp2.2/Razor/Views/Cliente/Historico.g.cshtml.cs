#pragma checksum "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8b82b6c6dc2a68dbdcd446ac9d968ca93fbb67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8b82b6c6dc2a68dbdcd446ac9d968ca93fbb67", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - McBonald's";
    ViewData["H2"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(153, 97, true);
            WriteLiteral("<header>\r\n    <hgroup>\r\n        <h1>McBonald\'s</h1>\r\n    </hgroup>\r\n</header>\r\n\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(251, 14, false);
#line 13 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(265, 241, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Data</th>\r\n                <th>Hamburguer</th>\r\n                <th>Shake</th>\r\n                <th>Preço</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(561, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(608, 19, false);
#line 26 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.DataDoPedido);

#line default
#line hidden
            EndContext();
            BeginContext(627, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(659, 22, false);
#line 27 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(681, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(713, 17, false);
#line 28 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(730, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(762, 17, false);
#line 29 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(779, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Davi Alencar\Documents\DEV\C#\Ex\McBonaldsMVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(824, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
