using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public List<Departamento> FindALL()// metodo para ordenar o nome dos departamentos
        {
            return _MVCContext.Departamento.OrderBy(x => x.Nome).ToList();
        }

    }
}
