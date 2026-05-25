using System;
using System.Collections.Generic;

namespace SafeBite_VNJP.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int? CategoryId { get; set; }

    public decimal Price { get; set; }

    public int? StockQuantity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
