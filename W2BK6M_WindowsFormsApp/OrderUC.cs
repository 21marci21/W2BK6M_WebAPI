using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W2BK6M_WindowsFormsApp.Models;

namespace W2BK6M_WindowsFormsApp
{
    public partial class OrderUC : UserControl
    {

        CustomerContext context = new CustomerContext();

        public OrderUC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szűrés();
        }

        private void Szűrés()
        {
            var szűrés = from x in context.Customers
                         where x.Name.Contains(textBox1.Text)
                         select x;

            listBox1.DataSource = szűrés.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listázás();
        }

        private void Listázás()
        {
            var aktuális = (Customer)listBox1.SelectedItem;

            var listázás = from x in context.Orders
                           where (x.CustomerIdFk == aktuális.CustomerId) && (x.OrderDate <= dateTimePicker1.Value)
                           select new Rendelés
                           {
                               CustomerId = x.CustomerIdFk,
                               CustomerName = x.CustomerIdFkNavigation.Name,
                               OrderId = x.OrderId,
                               OrderDate = x.OrderDate,
                               ItemId = x.ItemIdFk,
                               ItemName = x.ItemIdFkNavigation.Name,
                               Price = x.ItemIdFkNavigation.Price,
                           };

            rendelésBindingSource.DataSource = listázás.ToList();
        }

        private void OrderUC_Load(object sender, EventArgs e)
        {
            Szűrés();
            Listázás();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Listázás();
        }
    }
}
