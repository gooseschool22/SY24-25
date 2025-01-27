using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary_thingy_mabob
{
    public partial class Form1 : Form
    {
        int total = 0;
        int[] bits = new int[8];
        int[] bitsB = new int[8];
        int[] bitsC = new int[8];
        public Form1()
        {
            InitializeComponent();
            update();
        }

        private void calc()
        {
            total = 0;
            for (int i = 0; i < bits.Length; i++) { if (bits[i] != 0) total += (int)Math.Pow(2,i); }
            totallabel.Text = total.ToString();
        }
        private void bit1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void calc2()
        {
            total = 0;
            for (int i = 0; i < bitsB.Length; i++) { if (bitsB[i] != 0) total += (int)Math.Pow(2, i); }
            totallabel2.Text = total.ToString();
        }
        private void bitb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1") {((TextBox)sender).Text = "0";}
            else {((TextBox)sender).Text = "1";}
            if (bit1.Text == "1") { bits[0] = 1; } else { bits[0] = 0; }
            if (bit2.Text == "1") { bits[1] = 1; } else { bits[1] = 0; }
            if (bit3.Text == "1") { bits[2] = 1; } else { bits[2] = 0; }
            if (bit4.Text == "1") { bits[3] = 1; } else { bits[3] = 0; }
            if (bit5.Text == "1") { bits[4] = 1; } else { bits[4] = 0; }
            if (bit6.Text == "1") { bits[5] = 1; } else { bits[5] = 0; }
            if (bit7.Text == "1") { bits[6] = 1; } else { bits[6] = 0; }
            if (bit8.Text == "1") { bits[7] = 1; } else { bits[7] = 0; }
            calc();
            if (bitb1.Text == "1") { bitsB[0] = 1; } else { bitsB[0] = 0; }
            if (bitb2.Text == "1") { bitsB[1] = 1; } else { bitsB[1] = 0; }
            if (bitb3.Text == "1") { bitsB[2] = 1; } else { bitsB[2] = 0; }
            if (bitb4.Text == "1") { bitsB[3] = 1; } else { bitsB[3] = 0; }
            if (bitb5.Text == "1") { bitsB[4] = 1; } else { bitsB[4] = 0; }
            if (bitb6.Text == "1") { bitsB[5] = 1; } else { bitsB[5] = 0; }
            if (bitb7.Text == "1") { bitsB[6] = 1; } else { bitsB[6] = 0; }
            if (bitb8.Text == "1") { bitsB[7] = 1; } else { bitsB[7] = 0; }
            calc2();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++) 
            {
                bits[i] = 0;
                bitsB[i] = 0;
            }
            update();

        }
        private void update()
        {
            bit1.Text = (bits[0] == 1 ? "1" : "0");
            bit2.Text = (bits[1] == 1 ? "1" : "0");
            bit3.Text = (bits[2] == 1 ? "1" : "0");
            bit4.Text = (bits[3] == 1 ? "1" : "0");
            bit5.Text = (bits[4] == 1 ? "1" : "0");
            bit6.Text = (bits[5] == 1 ? "1" : "0");
            bit7.Text = (bits[6] == 1 ? "1" : "0");
            bit8.Text = (bits[7] == 1 ? "1" : "0");
            bitb1.Text = (bitsB[0] == 1 ? "1" : "0");
            bitb2.Text = (bitsB[1] == 1 ? "1" : "0");
            bitb3.Text = (bitsB[2] == 1 ? "1" : "0");
            bitb4.Text = (bitsB[3] == 1 ? "1" : "0");
            bitb5.Text = (bitsB[4] == 1 ? "1" : "0");
            bitb6.Text = (bitsB[5] == 1 ? "1" : "0");
            bitb7.Text = (bitsB[6] == 1 ? "1" : "0");
            bitb8.Text = (bitsB[7] == 1 ? "1" : "0");
            bitc1.Text = (bitsC[0] == 1 ? "1" : "0");
            bitc2.Text = (bitsC[1] == 1 ? "1" : "0");
            bitc3.Text = (bitsC[2] == 1 ? "1" : "0");
            bitc4.Text = (bitsC[3] == 1 ? "1" : "0");
            bitc5.Text = (bitsC[4] == 1 ? "1" : "0");
            bitc6.Text = (bitsC[5] == 1 ? "1" : "0");
            bitc7.Text = (bitsC[6] == 1 ? "1" : "0");
            bitc8.Text = (bitsC[7] == 1 ? "1" : "0");
            calc();
            calc2();

        }

        private void shiftLB_Click(object sender, EventArgs e)
        {
            bits[0] = 0;
            for (int i = bits.Length-1; i > 0; i--)
            {
                bits[i] = bits[i - 1];
            }
            calc();
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1) { count++; }
            }
            totallabel.Text = count.ToString();
        }

        private void ShiftRB_Click(object sender, EventArgs e)
        {
            bits[bits.Length - 1] = 0;
            for (int i = 0;i < bits.Length-1; i++)
            {
                bits[i] = bits[i+1];
            }
            calc();
            update();
        }

        private void andB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                    if (bits[i] == 1 && bitsB[i] == 1) { bitsC[i] = 1; }
            }
            calc();
            update();
        }

        private void orB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 0 && bitsB[i] == 0) { bitsC[i] = 0; }
                else { bitsC[i] = 1; }
            }
            calc();
            update();
        }

        private void xorB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 0 && bitsB[i] == 0) { bitsC[i] = 0; }
                else if (bits[i] == 1 && bitsB[i] == 1) { bitsC[i] = 0; }
                else { bitsC[i] = 1; }
            }
            calc();
            update();
        }
    }
}
