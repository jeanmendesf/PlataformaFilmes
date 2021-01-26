using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaFilmes.Model.Model
{
    public class Diretor
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public List<Filme> Filmes { get; set; }
    }
}
