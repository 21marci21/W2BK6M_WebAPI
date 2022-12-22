using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using W2BK6M_WindowsFormsApp.Models;

namespace W2BK6M_WindowsFormsApp
{
    public partial class CustomerUC : UserControl
    {
        CustomerContext context = new CustomerContext();

        public CustomerUC()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            szűrés();
        }

        private void szűrés()
        {
            var szűrés = from x in context.Customers
                         where x.Name.Contains(szűrésTextBox.Text)
                         select new Vásárló
                         {
                             CustomerId = x.CustomerId,
                             Name = x.Name,
                             Email = x.Email,
                             City = x.City,
                             Address = x.Address
                         };

            listBox1.DataSource = szűrés.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void CustomerUC_Load(object sender, EventArgs e)
        {
            szűrés();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Are you sure", "Save", MessageBoxButtons.YesNo);
            if (this.ValidateChildren())
            {
                if (save == DialogResult.Yes)
                {
                    var aktuálisId = (from x in context.Customers
                                     orderby x.CustomerId
                                     select x.CustomerId).Last() + 1;

                    Customer új = new Customer();
                    új.CustomerId = aktuálisId;
                    új.Name = nameTextBox.Text;
                    új.Email = emailTextBox.Text;
                    új.City = cityTextBox.Text;
                    új.Address = addressTextBox.Text;

                    context.Customers.Add(új);
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
            szűrés();
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(nameTextBox,"Nem lehet üres");
            }
        }

        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextBox, "");
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(".+@.+");
            if ((string.IsNullOrEmpty(emailTextBox.Text)) || (!regex.IsMatch(emailTextBox.Text)))
            {
                e.Cancel = true;
                errorProvider1.SetError(emailTextBox, "Nem lehet üres és email formátum!");
            }
        }

        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(emailTextBox, "");
        }

        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cityTextBox, "Nem lehet üres");
            }
        }

        private void cityTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTextBox, "");
        }

        private void addressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(addressTextBox, "Nem lehet üres");
            }
        }

        private void addressTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addressTextBox, "");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Are you sure?", "Save", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {
                var aktuális = (Vásárló)listBox1.SelectedItem;

                var törlés = (from x in context.Customers
                              orderby x.CustomerId
                              where x.CustomerId == aktuális.CustomerId
                              select x).LastOrDefault();

                context.Customers.Remove(törlés);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                szűrés();
            }
            else
            {
                MessageBox.Show("The saving of the removal was interupted.");
            }
        }
    }
}
