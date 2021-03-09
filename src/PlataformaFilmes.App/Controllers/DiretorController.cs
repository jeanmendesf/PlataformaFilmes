using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlataformaFilmes.Model.Model;
using PlataformaFilmes.Data.DAL;

namespace PlataformaFilmes.App.Controllers
{
    [Route("Diretor")]
    public class DiretorController : Controller
    {
        readonly DiretorDAL _diretorDAL;

        public DiretorController()
        {
            _diretorDAL = new DiretorDAL();
        }

        
        [HttpGet]
        [Route("obter")]
        public async Task<IActionResult> ObterTodosDiretores()
        {
            IEnumerable<Diretor> diretores;
            diretores =  _diretorDAL.ObterTodosDiretores();

            return View(diretores);
        }


        [HttpGet]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarDiretor()
        {
            var diretor = new Diretor();
            return View(diretor);
        }
        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarDiretor(Diretor diretor)
        {
            _diretorDAL.AdicionarDiretor(diretor);
            return RedirectToAction("obter", "Diretor");
        }


        [HttpGet]
        [Route("atualizar/{id:int}")]
        public async Task<IActionResult> AtualizarDiretor(int id)
        {
            Diretor diretor = _diretorDAL.ObterDiretorPorId(id);
            return View(diretor);
        }
        [HttpPost]
        [Route("atualizar/{id:int}")]
        public async Task<IActionResult> AtualizarDiretor(Diretor diretor)
        {
            _diretorDAL.AtualizarDiretor(diretor);
            return RedirectToAction("obter", "Diretor");
        }


        [HttpGet]
        [Route("deletar/{id:int}")]
        public async Task<IActionResult> DeletarDiretor(int id)
        {
            Diretor diretor = _diretorDAL.ObterDiretorPorId(id);

            return View(diretor);
        }
        [HttpPost]
        [Route("deletar/{id:int}")]
        public async Task<IActionResult> DeletarDiretor(Diretor diretor)
        {
            if (diretor == null) return View("Fornecedor não encontrado!.");

            _diretorDAL.DeletarDiretor(diretor.Id);
            return RedirectToAction("obter", "Diretor");
        }
    }
}
