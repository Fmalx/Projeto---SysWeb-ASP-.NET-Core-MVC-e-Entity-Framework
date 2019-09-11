using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb_MVC.Data;
using SalesWeb_MVC.Models;
using Microsoft.EntityFrameworkCore;

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

        public Vendedor FindById(int id)// encontra por Id caso nao tiver retorna nullo
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

    }
}
