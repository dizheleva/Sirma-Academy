namespace CompanyDbEFCore.Data.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime DueDate { get; set; }

        [Required]
        [Precision(12, 2)]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be a positive value.")]
        public decimal Amount { get; set; }

        [Required]
        [Precision(5, 2)]
        [Range(0, double.MaxValue, ErrorMessage = "TaxRate must be a positive value.")]
        public decimal TaxRate { get; set; }

        [Required]
        [Precision(10, 2)]
        [Range(0, double.MaxValue, ErrorMessage = "VAT must be a positive value.")]
        public decimal Vat { get; set; }

        [Required]
        [Precision(10, 2)]
        [Range(0, double.MaxValue, ErrorMessage = "Discount must be a positive value.")]
        public decimal Discount { get; set; }

        [Required]
        [StringLength(10)]
        public string Currency { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
