using System.Collections.Generic;
using System.Linq;
using Financas.Domain;

namespace Financas.Repository
{
    public class DespesaRepository : IDespesaRepository
    {
        private readonly DataContext context;
        public Despesa GetById(int id)
        {
            return context.Despesas.Find(id);
        }

        public List<Despesa> GetAll()
        {
            return context.Despesas.ToList();
        }
    }
}