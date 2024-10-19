using ApiCSharp.Models;

namespace ApiCSharp.Repository
{
    public class ProdutoRepository
    {
        // Iniciando uma lista já com produtos
        List<Produto> listaProdutos = new()
        {
            new Produto()
            {
                Nome = "Produto Teste",
                Categoria = "Categoria Teste"
            }
        };

        public List<Produto> ListarProdutos()
        {
            return listaProdutos;
        }

        public Produto CadastrarProduto(Produto produto)
        {
            listaProdutos.Add(produto);
            return produto;
        }
    }
}
