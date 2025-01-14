using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindSweeper
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        public Form1()
        {
            InitializeComponent();

            Reset();

        }
        private Button getButton(int r, int c)
        {
            int idx = (r - 1) * 10 + (c - 1);
            return btnGrid[idx];
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        private void getRC(Button b, out int r, out int c)
        {
            int i = getIndex(b);
            r = i / 10 + 1;
            c = i % 10 + 1;
        }

        private void SetCount()
        {
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    getButton(r, c).BackColor = Color.Yellow;
                }
            }
        }
        private void CreateMines(int numMines)
        {
            int mineCount = 0;
            while (mineCount < numMines)
            {
                int rNum = random.Next(0, 100);
                if (tileGrid[rNum].GetMine() == false)
                {
                    mineCount++;
                    tileGrid[rNum].SetMine(true);
                }
            }
        }
        private int CountAdjacent(int r, int c)
        {
            int count = 0;
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c - 1))].GetMine()) count++;
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c))].GetMine()) count++;
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r - 1, c + 1))].GetMine()) count++;
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(getButton(r, c - 1))].GetMine()) count++;
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(getButton(r, c + 1))].GetMine()) count++;
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r + 1, c - 1))].GetMine()) count++;
            }
            if (r < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c))].GetMine()) count++;
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c + 1))].GetMine()) count++;
            }
            return count;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Right)
                t.SetFlag();
            if (e.Button == MouseButtons.Left)
            {
                t.SetDug(true);
                int r = 0;
                int c = 0;
                getRC(b, out r, out c);
                t.SetNearby(CountAdjacent(r, c));
                if (tileGrid[getIndex(b)].GetMine())
                {
                    label1.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox1.Visible = false;
                }
            }
            if (e.Button == MouseButtons.Middle)
            {
                int r = 0;
                int c = 0;
                getRC(b, out r, out c);
                CountAdjacent(r, c);
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                tileGrid[i].SetFlagImage(flagpicture.Image);
                tileGrid[i].SetMineImage(minepicture.Image);
            }
            CreateMines(5);
        }
    }
}
