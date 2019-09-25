using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb_MVC.Data;
using SalesWeb_MVC.Models;
using Microsoft.EntityFrameworkCore;


namespace SalesWeb_MVC.Services
{
    public class RegistroVendaService
    {
        private readonly SalesWeb_MVCContext _MVCContext;

        public RegistroVendaService(SalesWeb_MVCContext context)
        {
            _MVCContext = context;
        }

        public async Task<List<RegistroVenda>> FindbyDateAsync(DateTime? minDate, DateTime? maxDate) // busca o registro por data
        {
            var result = from obj in _MVCContext.RegistroVenda select obj;  
            if(minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }

            return await result
                .Include(x=>x.Vendedor)
                .Include(x=>x.Vendedor.Departamento)
                .OrderByDescending(x=>x.Data)
                .ToListAsync();
        }
    }
}
