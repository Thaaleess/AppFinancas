using Financas.Domain;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }

        public DbSet<Financa> Financas { get; set; }

        public DbSet<Despesa> Despesas { get; set; }
    }
}