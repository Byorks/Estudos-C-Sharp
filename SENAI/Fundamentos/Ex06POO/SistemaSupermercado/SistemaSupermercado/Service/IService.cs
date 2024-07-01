using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercado.Service
{
    // Genericos 
    public interface IService
    {
        void Adicionar( T item );
    }
}
