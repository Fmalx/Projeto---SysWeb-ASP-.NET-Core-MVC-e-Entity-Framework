using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWeb_MVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data de Aniversario")] // customiza o nome da classe que aparece no site
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        
        public DateTime DataNascimento { get; set; }

        [Display(Name ="Salario Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
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
