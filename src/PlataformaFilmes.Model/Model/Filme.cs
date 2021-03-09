using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaFilmes.Model.Model
{
    public class Filme : BaseModel
    {        
        public string Descricao { get; set; }



        public List<Categoria> Categorias { get; set; }
        public Diretor Diretor { get; set; }
        public int DiretorId { get; set; }


        //Uso temporario.
        public IEnumerable<Diretor> Diretores { get; set; }
    }
}
