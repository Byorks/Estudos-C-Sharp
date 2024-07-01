using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Models;

namespace Projeto_Final.Services
{   public class TransacaoService
    {
        private List<Transacao> _transacoes;
        public TransacaoService()
        {
            _transacoes = new List<Transacao>();
        }

        int qtd = 0;
        public void AdicionarTransacao(Transacao transacao)
        {
            transacao.Id = qtd++;
            _transacoes.Add(transacao);
        }

        public List<Transacao> ListarTransacoes()
        {
            return _transacoes;
        }

        public void RemoverTransacao(Transacao transacao)
        {
            _transacoes.Remove(transacao);
        }

        public Transacao BuscarTransacaoPorId(int id)
        {
            return _transacoes.FirstOrDefault(i => i.Id == id);
        }
    }


}
