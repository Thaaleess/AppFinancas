using System.Collections.Generic;
using Financas.Domain;

namespace Financas.Repository
{
    public interface IDespesaRepository
    {
        List<Despesa>GetAll();
        Despesa GetById(int id);
    }
}