using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        static frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem(); 


        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

            Cashier cashier = new Cashier("Clarissa Castro", "Finance", usernameBox.Text, passwordBox.Text);

            if (cashier.validateLogin(usernameBox.Text, passwordBox.Text)) {
                MessageBox.Show($"Welcome  {cashier.getFullName()}  of  {cashier.getDepartment()}" );
                frmPurchaseDiscountedItem.Show();
                this.Hide();
        } else
            {
                MessageBox.Show("Credentials Invalid");
            }
            }
    }
}
