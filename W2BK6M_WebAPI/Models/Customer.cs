using System;
using System.Collections.Generic;

namespace W2BK6M_WebAPI.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
