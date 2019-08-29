using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb_MVC.Models
{
    public class SalesWeb_MVCContext : DbContext
    {
        public SalesWeb_MVCContext (DbContextOptions<SalesWeb_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWeb_MVC.Models.Departamento> Departamento { get; set; }
    }
}
