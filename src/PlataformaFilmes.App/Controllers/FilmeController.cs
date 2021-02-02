using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlataformaFilmes.Data.DAL;
using PlataformaFilmes.Model.Model;

namespace PlataformaFilmes.App.Controllers
{
    [Route("Filme")]
    public class FilmeController : Controller
    {
        readonly FilmeDAL _filmeDAL;
        readonly DiretorDAL _diretorDAL;

        public FilmeController()
        {
            _filmeDAL = new FilmeDAL();
            _diretorDAL = new DiretorDAL();
        }


        [HttpGet]
        [Route("obter")]
        public async Task<IActionResult> ObterTodosFilmes()
        {
            IEnumerable<Filme> filmes;
            filmes = _filmeDAL.ObterTodosFilmes();

            return View(filmes);
        }


        [HttpGet]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarFilme()
        {
            Filme filme = new Filme();
            return View(filme);
        }
        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarFilme(Filme filme)
        {
            filme.Diretor = _diretorDAL.ObterDiretorPorNome(filme.Diretor.Nome);
            filme.DiretorId = filme.Diretor.Id;
            _filmeDAL.AdicionarFilme(filme);
            return RedirectToAction("obter", "Filme");
        }


        [HttpGet]
        [Route("atualizar/{id:int}")]
        public async Task<IActionResult> AtualizarFilme(int id)
        {
            Filme filme = _filmeDAL.ObterFilmePorId(id);
            return View(filme);
        }
        [HttpPost]
        [Route("atualizar/{id:int}")]
        public async Task<IActionResult> AtualizarFilme(Filme filme)
        {
            filme.Diretor = _diretorDAL.ObterDiretorPorNome(filme.Diretor.Nome);
            filme.DiretorId = filme.Diretor.Id;
            _filmeDAL.AtualizarFilme(filme);
            return RedirectToAction("obter", "Filme");
        }


        [HttpGet]
        [Route("deletar/{id:int}")]
        public async Task<IActionResult> DeletarFilme(int id)
        {
            Filme filme = _filmeDAL.ObterFilmePorId(id);
            return View(filme);
        }
        [HttpPost]
        [Route("deletar/{id:int}")]
        public async Task<IActionResult> DeletarFilme(Filme filme)
        {
            _filmeDAL.DeletarFilme(filme.Id);
            return RedirectToAction("obter", "Filme");
        }
    }
}
