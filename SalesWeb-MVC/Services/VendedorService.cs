using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb_MVC.Data;
using SalesWeb_MVC.Models;
using Microsoft.EntityFrameworkCore;
using SalesWeb_MVC.Services.Exceptions;

namespace SalesWeb_MVC.Services
{
    public class VendedorService
    {
        private readonly SalesWeb_MVCContext _context;

        public VendedorService(SalesWeb_MVCContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InserirAsync(Vendedor obj)//insere os vendedores no bando apartir do formulario vendedor
        {
           
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int id)// encontra por Id caso nao tiver retorna nullo
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async  Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Vendedor.FindAsync(id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegrityException("Não pode deletar o vendedor, pois o mesmo possui vendas");
            }
        }

        public async  Task AtualizarAsync(Vendedor obj)
        {
            bool Temalgum = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!Temalgum)
            {
                throw new KeyNotFoundException("Id não exite");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
