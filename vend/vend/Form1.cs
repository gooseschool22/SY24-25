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
        products prods = new products();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            prods.addproduct("Funyuns", 10);
            prods.addproduct("Fritos", 10);
            prods.addproduct("Pop Corners", 10);
            prods.addproduct("Cheetos", 10);
            prods.addproduct("Doritos", 10);
            prods.addproduct("Lays", 10);
            prods.addproduct("Pepsi", 10);
            prods.addproduct("Dr. Pepper", 10);
            prods.addproduct("Coca-Cola", 10);
            prods.addproduct("Prime", 10);
            prods.addproduct("Sprite", 10);
            prods.addproduct("Mug Root Beer", 10);
        }
    }
}
