using System;
using System.Collections.Generic;

namespace W2BK6M_WindowsFormsApp.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerIdFk { get; set; }

    public int? ItemIdFk { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Customer? CustomerIdFkNavigation { get; set; }

    public virtual Item? ItemIdFkNavigation { get; set; }
}
