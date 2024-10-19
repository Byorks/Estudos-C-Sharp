using SENAI.MinimalAPI.Context;
using SENAI.MinimalAPI.Model;

namespace SENAI.MinimalAPI.Repository
{
    public class ProdutoRepository
    {
        ProdutoContext contexto = new ProdutoContext();
        
        // Pode ser apagado porque já foi criado um banco de dados para armazenar esse produtos.
        List<Produto> listaProdutos = new()
        {
            new Produto()
            {
                Nome = "Produto 1",
                Categoria = "Categoria 1"
            },
            new Produto()
            {
                Nome = "Produto 2",
                Categoria = "Categoria 2"
            },
            new Produto()
            {
                Nome = "Produto 3",
                Categoria = "Categoria 3"
            }
        };

        public List<Produto> ListarProdutos()
        {   
            // Vai no BD pega a lista de produtos e transforma em lista
            return contexto.Produtos.ToList();
        }
        
        public void CadastrarProduto(Produto prod)
        {   
            contexto.Produtos.Add(prod);
            // Precisa que salve as mudanças para serem efetivas
            contexto.SaveChanges();
        }
    }
}
