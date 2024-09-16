using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_of_chance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Random random = new Random();
            int num = random.Next(1, 100);
            if (num < 72)
            {
                r1d1.Visible = false;
                r1d2.Visible = false;
                r1d3.Visible = false;
                r1d4.Visible = false;
                r1d5.Visible = false;
                r1d6.Visible = false;
                r1d7.Visible = false;
                r2d1.Visible = true;
                r2d2.Visible = true;
                r2d3.Visible = true;
                r2d4.Visible = true;
                r2d5.Visible = true;
                r2d6.Visible = true;
                r2d7.Visible = true;
                row1.Visible = false;
                label1.Visible = true;
            }
            else
            {
                button.Enabled = false;
            }


        }

        private void r2d1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Random random = new Random();
            int num = random.Next(1, 100);
            if (num < 51)
            {
                r2d1.Visible = false;
                r2d2.Visible = false;
                r2d3.Visible = false;
                r2d4.Visible = false;
                r2d5.Visible = false;
                r2d6.Visible = false;
                r2d7.Visible = false;
                r3d1.Visible = true;
                r3d2.Visible = true;
                r3d3.Visible = true;
                r3d4.Visible = true;
                r3d5.Visible = true;
                r3d6.Visible = true;
                r3d7.Visible = true;
                label1.Visible = false;
                label2.Visible = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        private void r3d1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Random random = new Random();
            int num = random.Next(1, 100);
            if (num < 41)
            {
                r3d1.Visible = false;
                r3d2.Visible = false;
                r3d3.Visible = false;
                r3d4.Visible = false;
                r3d5.Visible = false;
                r3d6.Visible = false;
                r3d7.Visible = false;
                r4d1.Visible = true;
                r4d2.Visible = true;
                r4d3.Visible = true;
                r4d4.Visible = true;
                r4d5.Visible = true;
                r4d6.Visible = true;
                r4d7.Visible = true;
                label2.Visible = false;
                label3.Visible = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        private void r4d1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Random random = new Random();
            int num = random.Next(1, 100);
            if (num < 31)
            {
                r4d1.Visible = false;
                r4d2.Visible = false;
                r4d3.Visible = false;
                r4d4.Visible = false;
                r4d5.Visible = false;
                r4d6.Visible = false;
                r4d7.Visible = false;
                label4.Visible = true;
                pictureBox1.Visible = true;
                                label3.Visible = false;
                label5.Visible = false;
            }
            else
            {
                button.Enabled = false;
            }
        }
    }
}
