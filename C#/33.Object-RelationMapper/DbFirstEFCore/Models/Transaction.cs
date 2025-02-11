namespace DbFirstEFCore.Models;
using System;
using System.Collections.Generic;

public partial class Transaction
{
    public string Id { get; set; } = null!;

    public int SupplierId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime TransactionDate { get; set; }

    public decimal Amount { get; set; }

    public string TransactionType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Supplier Supplier { get; set; } = null!;
}
