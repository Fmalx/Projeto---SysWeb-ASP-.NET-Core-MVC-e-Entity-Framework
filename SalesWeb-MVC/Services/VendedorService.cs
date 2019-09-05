using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb_MVC.Data;
using SalesWeb_MVC.Models;

namespace SalesWeb_MVC.Services
{
    public class VendedorService
    {
        private readonly SalesWeb_MVCContext _context;

        public VendedorService(SalesWeb_MVCContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Inserir(Vendedor obj)//insere os vendedores no bando apartir do formulario vendedor
        {
            obj.Departamento = _context.Departamento.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
