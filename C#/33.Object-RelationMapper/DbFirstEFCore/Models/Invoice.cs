namespace DbFirstEFCore.Models;
using System;
using System.Collections.Generic;

public partial class Invoice
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime DueDate { get; set; }

    public decimal Amount { get; set; }

    public decimal TaxRate { get; set; }

    public decimal Vat { get; set; }

    public decimal Discount { get; set; }

    public string Currency { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
