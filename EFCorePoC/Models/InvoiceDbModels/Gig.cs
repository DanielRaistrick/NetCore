using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EFCorePoC.Models.InvoiceDbModels
{
    public class Gig
    {
        public int Id { get; set; }
        [Required]
        public string  User { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }

    }
}
