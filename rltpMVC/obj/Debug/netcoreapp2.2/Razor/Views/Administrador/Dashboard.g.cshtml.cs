#pragma checksum "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "974c14d4332648a4c288d54ec183eed52db2044d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"974c14d4332648a4c288d54ec183eed52db2044d", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f35467213ce6a92f921449c8dfadf3f4bb5fcd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<rltpMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 159, true);
            WriteLiteral(" <main>\r\n\r\n        <div id=\"cabec\">\r\n        <h1>Bem-Vindo</h1>\r\n        <p>Aqui está a lista de eventos</p>\r\n        </div>\r\n\r\n        <h2>Eventos Pendentes (");
            EndContext();
            BeginContext(206, 22, false);
#line 9 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                          Write(Model.PedidosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(228, 310, true);
            WriteLiteral(@")</h2>
        <table id=""pedidosp"">
                    <tr>
                      <th>Nome</th>
                      <th>Tipo de Evento</th>
                      <th>Data do Evento</th>
                      <th>Q. de Pessoas</th>
                      <th>Veredito</th>
                    </tr>
");
            EndContext();
#line 18 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var pedido in Model.Agendamentos )
                    {

#line default
#line hidden
            BeginContext(626, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 690, "\'", 763, 1);
#line 21 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 697, Url.Action("DadosPedidos","Administrador", new {id = @pedido.Id}), 697, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(764, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(766, 19, false);
#line 21 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                                                                                                        Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(785, 46, true);
            WriteLiteral("</a></td>\r\n                            <a><td>");
            EndContext();
            BeginContext(832, 24, false);
#line 22 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                              Write(pedido.Evento.tipoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(856, 46, true);
            WriteLiteral("</td></a>\r\n                            <a><td>");
            EndContext();
            BeginContext(903, 24, false);
#line 23 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                              Write(pedido.Evento.dataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(927, 46, true);
            WriteLiteral("</td></a>\r\n                            <a><td>");
            EndContext();
            BeginContext(974, 24, false);
#line 24 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                              Write(pedido.Evento.numPessoas);

#line default
#line hidden
            EndContext();
            BeginContext(998, 45, true);
            WriteLiteral("</td></a>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1043, "\'", 1110, 1);
#line 25 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 1050, Url.Action("Aprovar", "Agendamento", new {id = @pedido.Id}), 1050, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1111, 47, true);
            WriteLiteral("><i class=\"fas fa-check\">Aprovar</i></a> / / <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1158, "\'", 1226, 1);
#line 25 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 1165, Url.Action("Reprovar", "Agendamento", new {id = @pedido.Id}), 1165, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1227, 79, true);
            WriteLiteral("><i class=\"fas fa-times\">Reprovar</i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 27 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(1329, 97, true);
            WriteLiteral("\r\n                  </table>\r\n\r\n                  \r\n        \r\n          <h2>Histórico de Eventos(");
            EndContext();
#line 33 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                                    foreach(var item in Model.PedidosTotais)
            {
              

#line default
#line hidden
            BeginContext(1499, 4, false);
#line 35 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
         Write(item);

#line default
#line hidden
            EndContext();
#line 35 "C:\Users\45626490892\Documents\Ex\rltpMVC\Views\Administrador\Dashboard.cshtml"
                   ;
              break;
            }

#line default
#line hidden
            BeginContext(1541, 752, true);
            WriteLiteral(@")
          </h2>
              <table id=""pedidos"">
                      <tr>
                        <th>Nome</th>
                        <th>Tipo de Evento</th>
                        <th>Data do Evento</th>
                        <th>Q. de Pessoas</th>
                        <th>Situação</th>
                      </tr>
                      <tr>
                        <td>Alfreds Futterkiste</td>
                        <td>Festa</td>
                        <td>15/11/2020</td>
                        <td>15</td>
                        <td>Aprovado!</td>
                      </tr>
              </table>

    <div id=""bcon"">
        <a href=""rltp.html"" class=""confirmar"">Sair</a>
    </div>
    
    </main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<rltpMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
