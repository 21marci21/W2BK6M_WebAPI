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
    public partial class AddOrderUC : UserControl
    {

        CustomerContext context = new CustomerContext();

        public AddOrderUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Are you sure?", "Save changes", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                var aktuálisCustomer = (Customer)comboBox1.SelectedItem;
                var aktuálisItem = (Item)comboBox2.SelectedItem;
                var aktuáélisDate = dateTimePicker1.Value;
                var aktuálisOrder = (from x in context.Orders
                                     orderby x.OrderId
                                     select x.OrderId).Last() + 1;

                Order új = new Order();
                új.OrderId = aktuálisOrder;
                új.CustomerIdFk = aktuálisCustomer.CustomerId;
                új.ItemIdFk = aktuálisItem.ItemId;
                új.OrderDate = aktuáélisDate;

                context.Orders.Add(új);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Saving process was interupted.");
            }
        }

        private void AddOrderUC_Load(object sender, EventArgs e)
        {
            var listázás1 = from x in context.Customers
                            select x;

            comboBox1.DataSource = listázás1.ToList();
            comboBox1.DisplayMember = "Name";

            var listázás2 = from x in context.Items
                            select x;

            comboBox2.DataSource = listázás2.ToList();
            comboBox2.DisplayMember = "Name";
        }
    }
}
