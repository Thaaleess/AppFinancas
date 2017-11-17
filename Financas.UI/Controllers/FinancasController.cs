using Financas.Domain;
using Financas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Financas.UI.Controllers
{
    public class FinancasController : Controller
    {
        private IFinancaRepository iRepositorio;

        public FinancasController(IFinancaRepository repositorio)
        {
            iRepositorio = repositorio;
        }
        public IActionResult Index(){
            var financas = iRepositorio.GetAll();
            return View(financas);
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Financa financa){
            iRepositorio.Create(financa);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id){
            return View(iRepositorio.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Financa financa){
            iRepositorio.Update(financa);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            iRepositorio.Delete(id);
            return RedirectToAction("Index");
        }
    }
}