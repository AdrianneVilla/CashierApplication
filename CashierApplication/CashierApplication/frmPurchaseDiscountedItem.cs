using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;
namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        static DiscountItems Item;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            Item = new DiscountItems(itemName.Text, Convert.ToDouble(priceTextb.Text), Convert.ToInt32(quantityBox.Text), Convert.ToDouble(discountTxt.Text));
            totalAmount.Text = Item.getTotalPrice().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item.setPayment (Convert.ToDouble(textBox6.Text));
            label2.Text = Item.getChange().ToString();
        }
    }
}
