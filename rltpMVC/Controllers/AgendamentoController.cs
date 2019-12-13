using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rltpMVC.Enumeradores;
using rltpMVC.Models;
using rltpMVC.Repositorio;
using rltpMVC.ViewModels;

namespace rltpMVC.Controllers
{
    public class AgendamentoController : AbstractController
    {
        AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
        ClienteRepositorio clienterepositorio = new ClienteRepositorio();
        AgendamentoRepositorio agendamentoRepositorio = new AgendamentoRepositorio();

        public IActionResult Formulario1()
        {
            ViewData["NomeView"] = "Formulario1";
            ViewData["navView"] = "Nav";

            AgendamentoViewModel avm = new AgendamentoViewModel();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.NomeCliente = nomeUsuarioLogado;
            }
            
            var clienteLogado = clienterepositorio.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                avm.Cliente = clienteLogado;
            }

            
            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                avm.Cliente = clienterepositorio.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                avm.NomeCliente = nomeUsuario;
            }

            avm.NomeView = "Agendamento";
            avm.UsuarioEmail = ObterUsuarioSession();
            avm.UsuarioNome = ObterNomeSession();

            return View(avm);
        }

        public IActionResult Formulario2()
        {
            ViewData["NomeView"] = "Formulario2";
            ViewData["navView"] = "Nav";

            return View(new AgendamentoViewModel()
            {
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeSession()
            });
        }

        public IActionResult Registrar1(IFormCollection form)
        {
            ViewData["nomeView"] = "Formulario1";
            Agendamento agendamento = new Agendamento();

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Cpfcnpj = form["cpfcnpj"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            Evento evento = new Evento()
            {
                tipoEvento = form["tipoEvento"],
                dataEvento = DateTime.Parse(form["dataEvento"]),
                inicioEvento = form["inicioEvento"],
                terminoEvento = form["terminoEvento"],
                numPessoas = form["numPessoas"],
                descricaoEvento = form["descricaoEvento"]
            }; 

            agendamento.Cliente = cliente;
            agendamento.Evento = evento;
            agendamento.Pagamento = new Pagamento();
            agendamento.DataDoPedido = DateTime.Now;
            agendamento.PrecoTotal= 0.0;

            var linha = agendamentoRepositorio.PrepararPedidoCSV(agendamento);
            
            HttpContext.Session.SetString("agendamento",linha);

            return RedirectToAction("Formulario2");
        }
        
        public IActionResult Registrar2(IFormCollection form)
        {
            var linha = HttpContext.Session.GetString("agendamento");
            
            ViewData["nomeView"] = "Formulario2";
            Agendamento agendamento = new Agendamento();
            agendamento.Evento = new Evento();

            agendamento.Cliente.Nome = agendamentoRepositorio.ExtrairValorDoCampo("cliente_nome", linha);
            agendamento.Cliente.Cpfcnpj = agendamentoRepositorio.ExtrairValorDoCampo("cliente_cpfcnpj", linha);
            agendamento.Cliente.Telefone = agendamentoRepositorio.ExtrairValorDoCampo("cliente_telefone", linha);
            agendamento.Cliente.Email = agendamentoRepositorio.ExtrairValorDoCampo("cliente_email", linha);
            agendamento.Evento.tipoEvento = agendamentoRepositorio.ExtrairValorDoCampo("evento_tipoEvento", linha);
            agendamento.Evento.dataEvento = DateTime.Parse(agendamentoRepositorio.ExtrairValorDoCampo("evento_dataEvento", linha));
            agendamento.Evento.inicioEvento = agendamentoRepositorio.ExtrairValorDoCampo("evento_inicioEvento", linha);
            agendamento.Evento.terminoEvento = agendamentoRepositorio.ExtrairValorDoCampo("evento_terminoEvento", linha);
            agendamento.Evento.numPessoas = agendamentoRepositorio.ExtrairValorDoCampo("evento_numPessoas", linha);
            agendamento.Evento.descricaoEvento = agendamentoRepositorio.ExtrairValorDoCampo("evento_descricaoEvento", linha);

            Pagamento pagamento = new Pagamento()
            {
                metodoPagamento = form["metodoPagamento"],
                Bandeira = form["Bandeira"],
                numCartao = form["numCartao"],
                nomeTitular = form["nomeTitular"],
                Validade = form["Validade"],
                CVV = form["CVV"],
                Som = form["Som"],
                Luz = form["Luz"]
            };

            agendamento.Pagamento = pagamento;
            agendamento.DataDoPedido = DateTime.Now;
            agendamento.PrecoTotal= 0.0;

            if(agendamentoRepositorio.Inserir(agendamento))
            {
                ViewData["navView"] = "Sucesso";
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Formulario2",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterNomeSession()
                });

            } else {
                ViewData["navView"] = "Erro";
                return View ("Erro", new RespostaViewModel("Mensagem")
                {
                    NomeView = "Formulario2",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterNomeSession()
                });
            }
        }
        public IActionResult Aprovar(ulong id)
        {
            var pedido = agendamentoRepositorio.ObterPor(id);
            pedido.Status = (uint) StatusPedido.APROVADO;

            if(agendamentoRepositorio.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard","Administrador");
            }
            else {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterNomeSession()
                });
            }
        }

        public IActionResult Reprovar(ulong id)
        {
            var pedido = agendamentoRepositorio.ObterPor(id);
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if(agendamentoRepositorio.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard","Administrador");
            }
            else {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterNomeSession()
                });
            }
        }
    }
}