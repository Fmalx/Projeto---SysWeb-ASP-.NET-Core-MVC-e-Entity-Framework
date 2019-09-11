using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb_MVC.Models;
using SalesWeb_MVC.Services;
using SalesWeb_MVC.Models.ViewModels;

namespace SalesWeb_MVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedorService vendedor, DepartamentoService departamentoService)
        {
            _vendedorService = vendedor;
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);// vai gerar a lista na index 
        }

        public IActionResult Create()// metodo para criar novo Vendedor
        {
            var departamentoss = _departamentoService.FindALL();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentoss };
            return View(viewModel);
        }

        [HttpPost]//notação para dizer que o metodo é post
        [ValidateAntiForgeryToken]// notacao para evitar ataques maliciosos
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorService.Inserir(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)// int opcional  
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _vendedorService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _vendedorService.Remove(id);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Detalhes(int? id)// int opcional  
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _vendedorService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}