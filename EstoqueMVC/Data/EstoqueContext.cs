using Microsoft.EntityFrameworkCore;
using EstoqueMVC.Models;

namespace EstoqueMVC.Data
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(DbContextOptions<EstoqueContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }

    }
}
