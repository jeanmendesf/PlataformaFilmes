using Microsoft.AspNetCore.Mvc;
using PlataformaFilmes.Data.DAL;
using PlataformaFilmes.Model.Model;
using PlataformaFilmes.Model.Validacao;
using System.Collections.Generic;

namespace PlataformaFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        readonly FilmeDAL _filmeDAL;
        private FilmeValidacao _filmeValidacao;

        public FilmeController()
        {
            _filmeDAL = new FilmeDAL();
            _filmeValidacao = new FilmeValidacao();
        }


        [HttpGet]
        [Route("")]
        public ActionResult ObterTodosFilmes()
        {
            IEnumerable<Filme> filmes;
            filmes = _filmeDAL.ObterTodosFilmes(); 
            return Ok(filmes);
        }


        [HttpGet]
        [Route("{id:int}")]
        public ActionResult ObterFilmePorId(int id)
        {
            Filme filme;
            filme = _filmeDAL.ObterFilmePorId(id);

            return Ok(filme);
        }




    }
}
