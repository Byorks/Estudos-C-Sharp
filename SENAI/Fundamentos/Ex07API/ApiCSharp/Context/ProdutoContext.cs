
using ApiCSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCSharp.Context
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public string DbPath { get; }

        public ProdutoContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "produto.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        // Método que configura a conexão com o BD
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        // Ctrl + i + ' => Abre o PowerShell
    }
}
