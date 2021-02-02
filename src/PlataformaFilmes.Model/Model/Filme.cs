using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaFilmes.Model.Model
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }



        public List<Categoria> Categorias { get; set; }
        public Diretor Diretor { get; set; }
        public int DiretorId { get; set; }
    }
}
