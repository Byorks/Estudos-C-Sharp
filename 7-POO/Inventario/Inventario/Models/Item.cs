using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public abstract class Item
    {
        // Você não instancia objetos a partir dela
        // Serve como modelo para outras classes

        // Propriedades / Atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Método Abstrato, deve ser implementado em todos as sub-classes
        public abstract void MostrarDetalhes();
        public abstract void Atualizar();
    }
}
