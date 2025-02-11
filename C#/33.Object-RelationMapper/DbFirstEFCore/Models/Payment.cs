namespace DbFirstEFCore.Models;
using System;

public partial class Payment
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Transaction Transaction { get; set; } = null!;
}
