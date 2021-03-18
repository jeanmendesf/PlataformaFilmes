using Microsoft.AspNetCore.Mvc;
using PlataformaFilmes.Data.DAL;
using PlataformaFilmes.Model.Model;
using PlataformaFilmes.Model.Validacao;
using System.Collections.Generic;

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
        [Route("adicionar")]
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


        [HttpPut]
        [Route("atualizar/{id}")]
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


        [HttpDelete]
        [Route("deletar/{id}")]
        public ActionResult DeletarDiretor(int id)
        {
            _diretorDAL.DeletarDiretor(id);
            return Ok();
        }


        
    }
}
