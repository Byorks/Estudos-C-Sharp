namespace ApiCSharp.Models
{
    public class Produto
    {   // Atalho ctor
        public Produto()
        {   
            // Cria um novo id quando criamos um produto
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
    }
}
