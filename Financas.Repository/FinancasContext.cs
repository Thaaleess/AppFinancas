using System;
using Financas.Domain;
using Microsoft.EntityFrameworkCore;

namespace Financas.Repository
{
    public class FinancasContext : DbContext
    {
        public FinancasContext(DbContextOptions<FinancasContext> options) :base(options)
        {
            
        }

        public DbSet<Financa> Financas { get; set; }
    }
}