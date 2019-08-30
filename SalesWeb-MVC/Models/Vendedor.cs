using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWeb_MVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVenda> Venda { get; set; } = new List<RegistroVenda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVenda sr)
        {
            Venda.Add(sr);
        }

        public void RemoverVenda(RegistroVenda sr)
        {
            Venda.Add(sr);
        }

        public double TotalVenda(DateTime Inicial, DateTime Final)
        {
            return Venda.Where(sr => sr.Data >= Inicial && sr.Data <= Final).Sum(sr => sr.Valor);
        }
    }
}
