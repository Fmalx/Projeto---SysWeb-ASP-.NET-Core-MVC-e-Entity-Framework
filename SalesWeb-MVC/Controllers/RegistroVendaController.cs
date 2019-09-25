using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace SalesWeb_MVC.Controllers
{
    public class RegistroVendaController : Controller
    {
        private readonly RegistroVendaService _registroVenda;

        public RegistroVendaController(RegistroVendaService registroVenda)
        {
            _registroVenda = registroVenda;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateTime(2018,1,1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _registroVenda.FindbyDateAsync(minDate, maxDate);
            return View(result);
        }

        public IActionResult BuscaGrupo()
        {
            return View();
        }


    }
}