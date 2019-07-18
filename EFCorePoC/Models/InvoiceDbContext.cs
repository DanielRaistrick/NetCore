using EFCorePoC.Models.InvoiceDbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Models
{
    public class InvoiceDbContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Gig>  Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=10.228.114.115;initial catalog=PoC-FinancialsTeam;persist security info=True;user id=Financialsteam;password=5tur0cks19;");
            optionsBuilder.UseSqlServer("Data Source=SAGE019153;initial catalog=Invoice;persist security info=True;user id=dan;password=dan;");
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
    }
}
