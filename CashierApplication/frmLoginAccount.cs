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
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        public frmLoginAccount()
        {
            InitializeComponent();
            cashier = new Cashier("John Benedict Pacheco", "Finance", "admin", "Jb0925416301");
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (cashier.validateLogin(txtLogin.Text, txtPassword.Text))
            {

                string name = cashier.getFullname();
                string dept = cashier.getDepartment();
                MessageBox.Show("Welcome John Benedict Pacheco of Finance!", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

           frmPurchaseDiscountedItem frm = new frmPurchaseDiscountedItem();
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Invalid username/password.");
            }
        }
    }
}
