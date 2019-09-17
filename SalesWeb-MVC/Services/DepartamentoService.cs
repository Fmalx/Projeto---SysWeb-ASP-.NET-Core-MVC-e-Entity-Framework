using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb_MVC.Data;
using SalesWeb_MVC.Models;

namespace SalesWeb_MVC.Services
{
    public class DepartamentoService
    {
        private readonly SalesWeb_MVCContext _MVCContext;

        public DepartamentoService(SalesWeb_MVCContext context)
        {
            _MVCContext = context;
        }

        public async Task<List<Departamento>> FindALLAsync()// metodo para ordenar o nome dos departamentos
        {
            return await _MVCContext.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }

    }
}
