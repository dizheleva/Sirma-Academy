namespace CompanyDbEFCore.Data.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("InvoiceId")]
        public int InvoiceId { get; set; }

        public DateTime PaymentDate { get; set; }

        [Required]
        [Precision(12, 2)]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be a positive value.")]
        public decimal Amount { get; set; }

        [StringLength(20)]
        public string PaymentMethod { get; set; }

        [StringLength(255)]
        public string BankName { get; set; }

        [ForeignKey("TransactionId")]
        [StringLength(50)]
        public string TransactionId { get; set; }
    }
}
