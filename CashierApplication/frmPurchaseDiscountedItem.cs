using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            double price = Convert.ToDouble(textBox3.Text);
            double discount = Convert.ToDouble(textBox2.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            DiscountedItem item = new DiscountedItem(itemName, price, quantity, discount);
            double total = item.getTotalPrice();
            textBox6.Text = total.ToString("0.00");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(textBox6.Text);
            double payment = Convert.ToDouble(textBox5.Text);
            double change = payment - total;
            textBox7.Text = change.ToString("0.00");
        }
    }
}