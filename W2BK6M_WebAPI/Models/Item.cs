using System;
using System.Collections.Generic;

namespace W2BK6M_WebAPI.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
