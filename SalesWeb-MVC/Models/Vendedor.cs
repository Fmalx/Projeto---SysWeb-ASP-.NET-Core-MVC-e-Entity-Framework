using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWeb_MVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome é Obrigatorio")]//obrigatorio
        [StringLength(60,MinimumLength =3,ErrorMessage ="Tamanho do {0} deve ser entre {2} e {1}")]//Customiza o tamanho das strings no campo
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é Obrigatorio")]
        [EmailAddress(ErrorMessage ="Entre com um email valido")]
        [DataType(DataType.EmailAddress)]// faz o tipo email ser um link que ao clicar redireciona direto para sua conta de email para enviar um email para a pessoa
        public string Email { get; set; }

        [Required(ErrorMessage = "Data é Obrigatoria")]
        [Display(Name = "Data de Aniversario")] // customiza o nome da classe que aparece no site
        [DataType(DataType.Date)] // customiza o campo, no caso tira hora e mantem somente a data
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]// altera o tipo da data para dia mes e ano
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Salario é Obrigatorio")]
        [Range(100.0,50000.0,ErrorMessage ="{0} deve ser de {1} ate {2}")]
        [Display(Name ="Salario Base")] // customiza o display da classe no site
        [DisplayFormat(DataFormatString ="{0:F2}")]//aplica duas casas decimais
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
