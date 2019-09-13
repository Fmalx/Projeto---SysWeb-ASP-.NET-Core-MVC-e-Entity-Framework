using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb_MVC.Models;
using SalesWeb_MVC.Services;
using SalesWeb_MVC.Models.ViewModels;
using SalesWeb_MVC.Services.Exceptions;
using System.Diagnostics;

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
            if (!ModelState.IsValid)// teste de validação form
            {
                var departamento = _departamentoService.FindALL();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamento };
                return View(viewModel);
            }
            _vendedorService.Inserir(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)// int opcional  
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não foi fornecido" });
            }

            var obj = _vendedorService.FindById(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Existe" });
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
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não fornecido" });
            }

            var obj = _vendedorService.FindById(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Existe" });
            }

            return View(obj);
        }

        public IActionResult Editar(int? id)
        {
            if(id ==null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Fornecido"});
            }

            var obj = _vendedorService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Existe" });
            }

            List<Departamento> departamento = _departamentoService.FindALL();
            VendedorFormViewModel viewModel = new VendedorFormViewModel {Vendedor = obj, Departamentos = departamento };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Vendedor vendedor)
        {
            if (!ModelState.IsValid)// teste de validação form
            {
                var departamento = _departamentoService.FindALL();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamento };
                return View(viewModel);
            }
            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não conresponde" });
            }

            try
            {
                _vendedorService.Atualizar(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = e.Message });
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = e.Message });
            }

        }

        public IActionResult Error(string mensagem)
        {
            var viewModel = new ErrorViewModel
            {
                Mensagem = mensagem,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}