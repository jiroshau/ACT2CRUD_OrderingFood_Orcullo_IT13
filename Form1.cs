using System;
using System.Windows.Forms;

namespace OrderingFood_Orcullo_IT13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order();
            orderForm.Show();
        }
    }
}
