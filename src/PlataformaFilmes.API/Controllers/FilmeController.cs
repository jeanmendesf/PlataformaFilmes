using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaFilmes.Data.DAL;

namespace PlataformaFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        readonly FilmeDAL _filmeDAL;
        //private FilmeValidacao _filmeValidacao;


    }
}
