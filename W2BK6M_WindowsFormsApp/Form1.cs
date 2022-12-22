namespace W2BK6M_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CustomerUC uc = new CustomerUC();
            panel1.Controls.Add(uc);
            uc.Dock= DockStyle.Fill;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OrderUC uc = new OrderUC();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddOrderUC uc = new AddOrderUC();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}