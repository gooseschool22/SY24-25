using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweep
{
    public partial class Form1 : Form
    {
        Button[] btngrid = new Button[100];
        tile[] tilegrid = new tile[100];
        public Form1()
        {
            InitializeComponent();
            Reset();
        }
        bool flag = false;

        private Button GetButton(int r, int c)
        {
            return (Button)GetButton(r, c);
        }
        private int getindex(Button b)
        {
            string tmp = b.Name.Substring(1);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal;
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            if (e.Button == MouseButtons.Right)
            {
                if (!flag)
                    button.Image = pictureBox2.Image;
                else
                    button.Image = null;
                flag = !flag;

            }
            if (e.Button == MouseButtons.Left)
            {
                button.Image = pictureBox1.Image;
            }

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btngrid[i] = (Button)Controls["b" + (i + 1)];
                tilegrid[i] = new tile(btngrid[i]);
                btngrid[i].BackColor = Color.Green;
            }
        }
    }
}
