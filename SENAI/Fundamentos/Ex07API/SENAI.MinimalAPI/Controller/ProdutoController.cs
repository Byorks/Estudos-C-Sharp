using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SENAI.MinimalAPI.Model;

namespace SENAI.MinimalAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly List<Produto> produtos = new List<Produto>();

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> ListarProdutos()
        {
            return produtos;
        }

        [HttpPost]
        public ActionResult<Produto> CriarProduto(Produto produto)
        {
            produtos.Add(produto);
            return CreatedAtAction(nameof(ListarProdutoPorId), new { id = produto.Id }, produto);
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> ListarProdutoPorId(Guid id)
        {
            var product = produtos.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(Guid id, Produto produtoAtualizado)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            produto.Nome = produtoAtualizado.Nome;
            produto.Categoria = produtoAtualizado.Categoria;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarProduto(Guid id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            produtos.Remove(produto);
            return NoContent();
        }
    }
}
