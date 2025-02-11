namespace CompanyDbEFCore.Data.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    public class Transaction
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Precision(12, 2)]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be a positive value.")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(10)]
        public string TransactionType { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
