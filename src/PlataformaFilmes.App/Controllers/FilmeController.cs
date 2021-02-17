using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlataformaFilmes.Data.DAL;
using PlataformaFilmes.Model.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlataformaFilmes.App.Controllers
{
    [Route("Filme")]
    public class FilmeController : Controller
    {
        readonly FilmeDAL _filmeDAL;
        readonly DiretorDAL _diretorDAL;
        readonly CategoriaDAL _categoriaDAL;
        public FilmeController()
        {
            _filmeDAL = new FilmeDAL();
            _diretorDAL = new DiretorDAL();
            _categoriaDAL = new CategoriaDAL();
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
            filme.Diretores = _diretorDAL.ObterTodosDiretores();

            List<Categoria> TodasCategorias = _categoriaDAL.ObterTodasCategorias();
            ViewBag.CategoriaId = new MultiSelectList
                (
                    TodasCategorias, "Id", "Nome"
                );

            return View(filme);
        }
        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarFilme(Filme filme, List<int> CategoriaId)
        {
            

            filme.Categorias = _categoriaDAL.ObterListaCategoriaPorId(CategoriaId);
            filme.Diretores = _diretorDAL.ObterTodosDiretores();
            _filmeDAL.AdicionarFilme(filme);

            return RedirectToAction("obter", "Filme");
        }


        [HttpGet]
        [Route("atualizar/{id:int}")]
        public async Task<IActionResult> AtualizarFilme(int id)
        {
            Filme filme = _filmeDAL.ObterFilmePorId(id);
            filme.Categorias = _categoriaDAL.ObterCategoriaPorFilme(id);

            List<Categoria> TodasCategorias = _categoriaDAL.ObterTodasCategorias();
            int[] lstIdCategorias = new int[filme.Categorias.Count];
            int i = 0;

            foreach (Categoria categoria in filme.Categorias)
            {
                lstIdCategorias[i] = categoria.Id;
                i++;
            }

            ViewBag.CategoriaId = new MultiSelectList
                (
                    TodasCategorias, "Id", "Nome", lstIdCategorias
                ) ;

            
            filme.Diretores = _diretorDAL.ObterTodosDiretores();

            return View(filme);
        }
        [HttpPost]
        [Route("atualizar/{id:int}")]
        public async Task<IActionResult> AtualizarFilme(Filme filme, List<int> CategoriaId)
        {
            filme.Diretores = _diretorDAL.ObterTodosDiretores();
            filme.Categorias = _categoriaDAL.ObterListaCategoriaPorId(CategoriaId);

            List<Categoria> TodasCategorias = _categoriaDAL.ObterTodasCategorias();
            ViewBag.CategoriaId = new MultiSelectList
                (
                    TodasCategorias, "Id", "Nome", filme.Categorias
                );

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
