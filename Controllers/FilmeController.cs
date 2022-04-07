using SistemaLocacao.Models;
using SistemaLocacao.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaLocacao.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeRepositorio _filmeRepositorio;

        public FilmeController(IFilmeRepositorio filmeRepositorio)
        {
            _filmeRepositorio = filmeRepositorio;
        }
        public IActionResult Index()
        {
            List<FilmeModel> filmes = _filmeRepositorio.BucarTodos();
            return View(filmes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            FilmeModel filme = _filmeRepositorio.ListarPorId(id);
            return View(filme);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            FilmeModel filme = _filmeRepositorio.ListarPorId(id);
            return View(filme);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _filmeRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Filme apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemSucesso"] = "Ops, não conseguimos apagar seu filme!";
                }

                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu filme, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Criar(FilmeModel filme)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _filmeRepositorio.Adicionar(filme);
                    TempData["MensagemSucesso"] = "filme cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(filme);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu filme, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(FilmeModel filme)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _filmeRepositorio.Atualizar(filme);
                    TempData["MensagemSucesso"] = "Filme alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", filme);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu filme, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
