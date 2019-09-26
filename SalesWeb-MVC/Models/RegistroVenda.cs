using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SalesWeb_MVC.Models.Enums;
namespace SalesWeb_MVC.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Valor { get; set; }
        public VendaStatus Status{ get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {
        }

        public RegistroVenda(int id, DateTime data, double valor, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }

}