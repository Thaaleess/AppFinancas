using System.Collections.Generic;
using Financas.Domain;

namespace Financas.Repository
{
    public interface IFinancaRepository
    {
        void Create(Financa financa);
        void Delete(int id);
        void Update(Financa financas);
        List<Financa>GetAll();
        Financa GetById(int id);
    }
}