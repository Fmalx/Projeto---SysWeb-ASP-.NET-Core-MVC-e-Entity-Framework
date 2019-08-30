using System.Collections.Generic;
using System;
using System.Linq;
namespace SalesWeb_MVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor sr)
        {
            Vendedores.Add(sr);
        }

        public double TotalVenda(DateTime Inicial, DateTime Final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVenda(Inicial,Final));
        }
    }
}
