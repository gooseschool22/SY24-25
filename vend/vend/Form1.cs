using System;
using System.Drawing;
using System.Windows.Forms;

namespace vend
{
    public partial class Form1 : Form
    {
        int[] products = new int[12];
        double total = 0;
        slot coinslot = new slot();
        public Form1()
        {
            InitializeComponent();
            moneyLabel.Text = total.ToString();
        }
        private void showProduct(string name, object price, Image image)
        {
            nameLabel.Text = name;
            priceLabel.Text = price.ToString();
            productImage.BackgroundImage = image;
        }
        private void product_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            showProduct(b.Text, b.Tag, b.BackgroundImage);
        }

        private void coin_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            coinslot.insertcoin(b.Tag);
            moneyLabel.Text = coinslot.total.ToString();
        }
        private void purchaseB_Click(object sender, EventArgs e)
        {

        }
    }
}
