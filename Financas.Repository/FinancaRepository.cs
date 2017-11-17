using Financas.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Financas.Repository
{
    public class FinancaRepository : IFinancaRepository
    {
        private FinancasContext context;
        public FinancaRepository(FinancasContext context){
            this.context = context;
        }

        public void Create(Financa financa)
        {
            context.Financas.Add(financa);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.Financas.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Financa financa){
            Delete(financa.id);
            Create(financa);
        }

        public Financa GetById(int id)
        {
            return context.Financas.SingleOrDefault(x=>x.id == id);
        }

        public List<Financa> GetAll()
        {
            return context.Financas.ToList();
        }
    }
}