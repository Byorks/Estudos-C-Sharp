using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    internal class PessoaJuridica : Clientes
    {
        public string Cnpj {  get; set; }
        public string Ie { get; set; }

        // Sobrescrita estou sobrescrevendo o método da casa base
        public override void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 10 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
        // Sobrecarga altera o parametro do método
    }
}
