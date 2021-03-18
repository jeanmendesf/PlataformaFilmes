using PlataformaFilmes.Model.Model;
using PlataformaFilmes.Model.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlataformaFilmes.Model.Validacao
{
    public class DiretorValidacao : ValidacaoBase<Diretor>
    {
        public void ValidarDiretor(Diretor diretor)
        {
            Validar(diretor);
        }

    }
}
