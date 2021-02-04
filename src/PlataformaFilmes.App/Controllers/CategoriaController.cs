using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlataformaFilmes.Data.DAL;
using PlataformaFilmes.Model.Model;

namespace PlataformaFilmes.App.Controllers
{
    [Route("Categoria")]
    public class CategoriaController : Controller
    {
        readonly CategoriaDAL _categoriaDAL;
        readonly FilmeDAL _filmeDAL;

        public CategoriaController()
        {
            _categoriaDAL = new CategoriaDAL();
            _filmeDAL = new FilmeDAL();
        }
        
        
        [HttpGet]
        [Route("obter")]
        public async Task<IActionResult> ObterTodasCategorias()
        {
            IEnumerable<Categoria> categorias;
            categorias = _categoriaDAL.ObterTodasCategorias();

            return View(categorias);
        }


        [HttpGet]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarCategoria()
        {
            Categoria categoria = new Categoria();
            return View(categoria);
        }
        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarCategoria(Categoria categoria)
        {
            _categoriaDAL.AdicionarCategoria(categoria);
            return RedirectToAction("obter", "categoria");
        }





    }
}
