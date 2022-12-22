using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2BK6M_WindowsFormsApp
{
    public class Rendelés
    {
        public int? CustomerId { get; set; }

        public string? CustomerName { get; set; }

        public int OrderId { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? ItemId { get; set; }

        public string? ItemName { get; set; }

        public int? Price { get; set; }
    }
}
