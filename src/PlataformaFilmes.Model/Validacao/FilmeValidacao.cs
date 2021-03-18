using PlataformaFilmes.Model.Model;
using PlataformaFilmes.Model.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaFilmes.Model.Validacao
{
    public class FilmeValidacao : ValidacaoBase<Filme>
    {
        public FilmeValidacao()
        {

        }

        public void ValidarFilme(Filme filme)
        {
            TemDiretor(filme);
            Validar(filme);
        }

        public void TemDiretor(Filme filme)
        {
            if (filme.DiretorId == 0)
            {
                var notificacao = new Notificacao("O filme deve ter um diretor");
                notificacoes.Add(notificacao);
            }

        }


    }
}
