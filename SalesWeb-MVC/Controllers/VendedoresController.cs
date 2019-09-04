using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb_MVC.Services;

namespace SalesWeb_MVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedor)
        {
            _vendedorService = vendedor;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);// vai gerar a lista na index 
        }
    }
}