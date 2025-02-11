﻿namespace CompanyDbEFCore.Data.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters.")]
        [RegularExpression(@"^\+[1-9]\d{1,13}$", ErrorMessage = "Phone number must be in a valid format, e.g., +123456789012.")]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
