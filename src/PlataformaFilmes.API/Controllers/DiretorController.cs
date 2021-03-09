using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlataformaFilmes.Data.DAL;
using PlataformaFilmes.Model.Model;
using PlataformaFilmes.Model.Validacao;

namespace PlataformaFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiretorController : ControllerBase
    {
        readonly DiretorDAL _diretorDAL;
        private DiretorValidacao _diretorValidacao;

        public DiretorController()
        {
            _diretorDAL = new DiretorDAL();
            _diretorValidacao = new DiretorValidacao();
        }
        

        [HttpGet]
        [Route("")]
        public ActionResult ObterTodosDiretores()
        {
            IEnumerable<Diretor> diretores;
            diretores = _diretorDAL.ObterTodosDiretores();
            return Ok(diretores);
        }


        [HttpGet]
        [Route("{id:int}")]
        public ActionResult ObterDiretorPorId(int id)
        {
            Diretor diretor = new Diretor();
            diretor = _diretorDAL.ObterDiretorPorId(id);
            return Ok(diretor);
        }


        [HttpPost]
        [Route("Adicionar")]
        public ActionResult AdicionarDiretor(Diretor diretor)
        {
            if (_diretorValidacao.Validar(diretor) == true)
            {
                _diretorDAL.AdicionarDiretor(diretor);
                return Ok(diretor);
            }
            else
            {
                return BadRequest(new { message = _diretorValidacao.MostrarNotificacoes() }) ;
            }
            
        }


        [HttpDelete]
        [Route("Deletar/{id:int}")]
        public ActionResult DeletarDiretor(int id)
        {
            _diretorDAL.DeletarDiretor(id);
            return Ok(RedirectToAction("ObterTodosDiretores"));
        }


        [HttpPut]
        [Route("Atualizar/{id:int}")]
        public ActionResult AtualizarDiretor(Diretor diretor)
        {
            if (_diretorValidacao.Validar(diretor) == true)
            {
                _diretorDAL.AtualizarDiretor(diretor);
                return Ok(diretor);
            }
            else
            {
                return BadRequest(new { message = _diretorValidacao.MostrarNotificacoes() });
            }
        }
    }
}
