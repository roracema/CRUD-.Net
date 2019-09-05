using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class ZooController : Controller
    {

        private AllZooContext _context;

        public ZooController(AllZooContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Zoos.ToList()) ;
        }

        [HttpPost]
        public IActionResult Cadastrar(Zoo zoo)
        {
            _context.Zoos.Add(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Zoo zoo)
        {
            _context.Zoos.Update(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Editado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var zoo = _context.Zoos.Find(id);
            return View(zoo);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var zoo = _context.Zoos.Find(id);
            _context.Zoos.Remove(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Removido!";
            return RedirectToAction("Listar");
        }

    }
}