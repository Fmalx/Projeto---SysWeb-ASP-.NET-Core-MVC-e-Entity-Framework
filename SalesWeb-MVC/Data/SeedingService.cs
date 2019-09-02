using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb_MVC.Models;
using SalesWeb_MVC.Models.Enums;
namespace SalesWeb_MVC.Data
{
    public class SeedingService
    {
        private SalesWeb_MVCContext _context;

        public SeedingService(SalesWeb_MVCContext context)
        {
            _context = context;
        }

        public void Seed()//popula o banco de dados
        {
            if (_context.Departamento.Any() ||
                _context.Vendedor.Any()||
                _context.RegistroVenda.Any())
            {
                return; //DB ja foi populado
            }

            Departamento d1 = new Departamento(1, "Computers");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@gmail.com",new DateTime(1998,04,21),1000.0,d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988,01,15),2200.0,d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993,11,30),3000.0,d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000,01,9),4000.0,d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997,03,4),3000.0,d2);

            RegistroVenda Rv1 = new RegistroVenda(1, new DateTime(2018, 09,25), 11000.0, VendaStatus.Faturado, s1);
            RegistroVenda Rv2 = new RegistroVenda(2, new DateTime(2018, 09,4), 7000.0, VendaStatus.Faturado, s5);
            RegistroVenda Rv3 = new RegistroVenda(3, new DateTime(2018, 09, 13), 4000.0, VendaStatus.Cancelado, s4); ;
            RegistroVenda Rv4 = new RegistroVenda(4, new DateTime(2018, 09,1), 8000.0, VendaStatus.Faturado,s1);
            RegistroVenda Rv5 = new RegistroVenda(5, new DateTime(2018, 09,21), 3000.0, VendaStatus.Faturado,s3);
            RegistroVenda Rv6 = new RegistroVenda(6, new DateTime(2018, 09,15), 2000.0, VendaStatus.Faturado,s1);
            RegistroVenda Rv7 = new RegistroVenda(7, new DateTime(2018, 09,28), 13000.0, VendaStatus.Faturado,s2);
            RegistroVenda Rv8 = new RegistroVenda(8, new DateTime(2018, 09,11), 4000.0, VendaStatus.Faturado,s4);
            RegistroVenda Rv9 = new RegistroVenda(9, new DateTime(2018, 09, 14), 11000.0, VendaStatus.Pendente, s6); ;
            RegistroVenda Rv10 = new RegistroVenda(10, new DateTime(2018, 09,7), 9000.0, VendaStatus.Faturado,s6);
            RegistroVenda Rv11 = new RegistroVenda(11, new DateTime(2018, 09,13), 6000.0, VendaStatus.Faturado,s2);
            RegistroVenda Rv12 = new RegistroVenda(12, new DateTime(2018, 09,25), 7000.0, VendaStatus.Pendente,s3);
            RegistroVenda Rv13 = new RegistroVenda(13, new DateTime(2018, 09,29), 10000.0, VendaStatus.Faturado, s4);
            RegistroVenda Rv14 = new RegistroVenda(14, new DateTime(2018, 09,4), 3000.0, VendaStatus.Faturado, s5);
            RegistroVenda Rv15 = new RegistroVenda(15, new DateTime(2018, 10,12), 4000.0, VendaStatus.Faturado, s1);
            RegistroVenda Rv16 = new RegistroVenda(16, new DateTime(2018, 10,5), 2000.0, VendaStatus.Faturado, s4);
            RegistroVenda Rv17 = new RegistroVenda(17, new DateTime(2018, 10,1), 12000.0, VendaStatus.Faturado, s1);
            RegistroVenda Rv18 = new RegistroVenda(18, new DateTime(2018, 10,24), 6000.0, VendaStatus.Faturado, s3);
            RegistroVenda Rv19 = new RegistroVenda(19, new DateTime(2018, 10,22), 8000.0, VendaStatus.Faturado, s5);
            RegistroVenda Rv20 = new RegistroVenda(20, new DateTime(2018, 10,15), 8000.0, VendaStatus.Faturado, s6);
            RegistroVenda Rv21 = new RegistroVenda(21, new DateTime(2018, 10,17), 9000.0,  VendaStatus.Faturado, s2);
            RegistroVenda Rv22 = new RegistroVenda(22, new DateTime(2018, 10,24), 4000.0, VendaStatus.Faturado,s4);
            RegistroVenda Rv23 = new RegistroVenda(23, new DateTime(2018, 10,19), 11000.0, VendaStatus.Cancelado,s2);
            RegistroVenda Rv24 = new RegistroVenda(24, new DateTime(2018, 10,12), 8000.0, VendaStatus.Faturado,s5);
            RegistroVenda Rv25 = new RegistroVenda(25, new DateTime(2018, 10,31), 7000.0, VendaStatus.Faturado,s3);
            RegistroVenda Rv26 = new RegistroVenda(26, new DateTime(2018, 10,6), 5000.0, VendaStatus.Faturado,s4);
            RegistroVenda Rv27 = new RegistroVenda(27, new DateTime(2018, 10,13), 9000.0, VendaStatus.Pendente,s1);
            RegistroVenda Rv28 = new RegistroVenda(28, new DateTime(2018, 10,7), 4000.0, VendaStatus.Faturado,s3);
            RegistroVenda Rv29 = new RegistroVenda(29, new DateTime(2018, 10,23), 12000.0, VendaStatus.Faturado,s5);
            RegistroVenda Rv30 = new RegistroVenda(30, new DateTime(2018, 10,12), 5000.0, VendaStatus.Faturado,s2);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);
            _context.RegistroVenda.AddRange(Rv1, Rv2, Rv3, Rv4, Rv5, Rv6, Rv7, Rv8, Rv9, Rv10, Rv11, Rv12, Rv13, Rv14, Rv15, Rv16, Rv17, Rv18, Rv19, Rv20, Rv21, Rv22, Rv23, Rv24, Rv25, Rv26, Rv27, Rv27, Rv28, Rv29, Rv30);

            _context.SaveChanges();
        }


    }
}
