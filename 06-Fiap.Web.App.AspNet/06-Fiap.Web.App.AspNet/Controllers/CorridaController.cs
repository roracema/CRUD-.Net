using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.App.AspNet.Models;
using _06_Fiap.Web.App.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.App.AspNet.Controllers
{
    public class CorridaController : Controller
    {
        private AllCorridaContext _Context;

        public CorridaController(AllCorridaContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Corrida corrida)
        {
            _Context.Corridas.Add(corrida);
            _Context.SaveChanges();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_Context.Corridas.ToList());
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            var Corrida = _Context.Corridas.Find(id);
            _Context.Corridas.Remove(Corrida);
            _Context.SaveChanges();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var Corrida = _Context.Corridas.Find(id);
            return View("Cadastrar");

        }

        [HttpPost]
        public IActionResult Editar(Corrida corrida)
        {
            var Corrida = _Context.Corridas.Find(id);
            return View("Cadastrar");

        }
    }
}