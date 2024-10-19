using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Criar método e depois alterar para o que preciso, que é especificar se é cliente ou funcionário
        // Adicionar Pessoa
        //public abstract Pessoa AdicionarPessoa();
        //// Remover Pessoa
        //public abstract void RemoverPessoa();

        //// Atualizar Pessoa 
        public abstract void Atualizar();

        //// Listar Pessoa
        //public abstract void ListarPessoa();


    }
}
