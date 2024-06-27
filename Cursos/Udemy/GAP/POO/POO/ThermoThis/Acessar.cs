using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoThis
{
    public  class Acessar
    {
        
        string senha = "abc123";

        public bool Login(string senha)
        {
            // o this faz referencia a classe que está sendo instanciado, por terem o mesmo nome, não conseguiria dizer 
            // que estamos querendo utilizar a variável lá em cima
            return this.senha == senha;
        }
        
    }
   
}
