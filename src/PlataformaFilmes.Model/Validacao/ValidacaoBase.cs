using PlataformaFilmes.Model.Model;
using PlataformaFilmes.Model.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlataformaFilmes.Model.Validacao
{
    public class ValidacaoBase<T>
        where T : BaseModel
    {
        public List<Notificacao> notificacoes;

        public ValidacaoBase()
        {
            notificacoes = new List<Notificacao>();
        }


        public bool Validar(T diretor)
        {
            ValidarNome(diretor);
            return DiretorValido();
        }


        public void ValidarNome(T diretor)
        {
            if (diretor.Nome.Length < 3)
            {
                var notificacao = new Notificacao("O nome deve ter 3 ou mais caracteres.");
                notificacoes.Add(notificacao);
            }
            else if (diretor.Nome.Length > 100)
            {
                var notificacao = new Notificacao("O nome deve ter 100 ou menos caracteres.");
                notificacoes.Add(notificacao);
            }
        }
        

        public bool DiretorValido()
        {
            bool valido = !notificacoes.Any();
            return valido;
        }


        public List<Notificacao> MostrarNotificacoes()
        {
            return notificacoes;
        }
    }
}
