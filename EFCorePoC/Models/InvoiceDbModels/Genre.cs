using System.ComponentModel.DataAnnotations;

namespace EFCorePoC.Models.InvoiceDbModels
{
    public class Genre
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}