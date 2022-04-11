using SistemaLocacao.Models;
using SistemaLocacao.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SistemaLocacao.Controllers
{
    public class LocacaoController : Controller
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;

        public LocacaoController(ILocacaoRepositorio locacaoRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
        }
        public IActionResult Index()
        {
            List<LocacaoModel> locacoes = _locacaoRepositorio.BucarTodos();
            return View(locacoes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            LocacaoModel locacao = _locacaoRepositorio.ListarPorId(id);
            return View(locacao);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            LocacaoModel locacao = _locacaoRepositorio.ListarPorId(id);
            return View(locacao);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _locacaoRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Locação apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemSucesso"] = "Ops, não conseguimos apagar seu locação!";
                }

                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu locacao, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        public ActionResult MyImage()
        {
            return File(@"C:\Users\Pichau\Desktop\e-Auditoria\SistemaLocacao\images\", "editar.png/jpg");
        }

        [HttpPost]
        public IActionResult Criar(LocacaoModel locacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _locacaoRepositorio.Adicionar(locacao);
                    TempData["MensagemSucesso"] = "Locação cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(locacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu locacao, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(LocacaoModel locacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _locacaoRepositorio.Atualizar(locacao);
                    TempData["MensagemSucesso"] = "Locação alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", locacao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu locacao, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
