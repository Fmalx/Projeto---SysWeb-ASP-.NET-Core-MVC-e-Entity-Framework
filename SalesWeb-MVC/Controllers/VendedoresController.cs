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

        public async Task<IActionResult> Index()
        {
            var list = await _vendedorService.FindAllAsync();
            return View(list);// vai gerar a lista na index 
        }

        public async Task<IActionResult> Create()// metodo para criar novo Vendedor
        {
            var departamentos = await _departamentoService.FindALLAsync();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]//notação para dizer que o metodo é post
        [ValidateAntiForgeryToken]// notacao para evitar ataques maliciosos
        public async Task<IActionResult> Create(Vendedor vendedor)
        {
            if (!ModelState.IsValid)// teste de validação form
            {
                var departamento = await _departamentoService.FindALLAsync();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamento };
                return View(viewModel);
            }
            await _vendedorService.InserirAsync(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public async  Task<IActionResult> Delete(int? id)// int opcional  
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não foi fornecido" });
            }

            var obj = await _vendedorService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Existe" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _vendedorService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Detalhes(int? id)// int opcional  
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não fornecido" });
            }

            var obj = await _vendedorService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Existe" });
            }

            return View(obj);
        }

        public async  Task<IActionResult> Editar(int? id)
        {
            if(id ==null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Fornecido"});
            }

            var obj = await _vendedorService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não Existe" });
            }

            List<Departamento> departamento = await _departamentoService.FindALLAsync();
            VendedorFormViewModel viewModel = new VendedorFormViewModel {Vendedor = obj, Departamentos = departamento };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, Vendedor vendedor)
        {
            if (!ModelState.IsValid)// teste de validação form
            {
                var departamento = await _departamentoService.FindALLAsync();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamento };
                return View(viewModel);
            }
            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { Mensagem = "Id não conresponde" });
            }

            try
            {
                await _vendedorService.AtualizarAsync(vendedor);
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