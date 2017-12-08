using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Financas.Domain;

namespace AppFinancas.WebApi
{
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        private readonly FinancaRepository repository;
        public ApiController(IFinancaRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Financa> Get()
        {
           return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Financa Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Financa financa)
        {
            if (financa == null)
                return BadRequest();

            repository.Create(financa);

            return CreatedAtRoute("Get", new { id = financa.Id }, financa);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Financa financa)
        {
            if (financa == null)
                return BadRequest();

            repository.Update(financa);

            return CreatedAtRoute("Get", new { id = financa.Id }, financa);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);

            return Ok{
                new{
                retorno = "Deletado com sucesso!";
                }
            };
        }
    }
}