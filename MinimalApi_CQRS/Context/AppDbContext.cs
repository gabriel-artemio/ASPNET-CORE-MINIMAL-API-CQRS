using Microsoft.EntityFrameworkCore;
using MinimalApi_CQRS.Models;

namespace MinimalApi_CQRS.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
                 options.UseSqlite("DataSource=produtosdb.db;Cache=Shared");
    }
}
