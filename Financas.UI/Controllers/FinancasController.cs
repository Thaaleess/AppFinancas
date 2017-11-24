using Financas.Domain;
using Financas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Financas.UI.Controllers
{
    public class FinancasController : Controller
    {
        private IFinancaRepository iRepositorio;
        private IDespesaRepository iRepositorioDespesa;

        public FinancasController(IFinancaRepository repositorio, IDespesaRepository repositorioDespesa)
        {
            iRepositorio = repositorio;
            iRepositorioDespesa = repositorioDespesa;
        }
        public IActionResult Index(){
            var financas = iRepositorio.GetAll();
            return View(financas);
        }

        [HttpGet]
        public IActionResult Create(){
            ViewBag.Despesa = iRepositorioDespesa.GetAll();
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