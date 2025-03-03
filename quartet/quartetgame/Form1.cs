using quartet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quartetgame
{
    public partial class Form1 : Form
    {
        carcard A1 = new carcard("A1", "BMW Z8", 250, 4.7, 400, 4941, 8, 6600);
        carcard A2 = new carcard("A2", "MG Xpower SV Club Sport", 230, 4.2, 465, 4997, 8, 6450);
        carcard A3 = new carcard("A3", "Ferrari F430 F1", 315, 4.0, 490, 4308, 8, 8500);
        carcard A4 = new carcard("A4", "Viper GTS", 285, 4.6, 411, 7990, 10, 5100);
        carcard B1 = new carcard("B1", "Ford GT", 325, 3.3, 550, 5403, 8, 5250);
        carcard B2 = new carcard("B2", "TVR Sagaris", 300, 3.9, 3966, 400, 8, 7000);
        carcard B3 = new carcard("B3", "Range Rover Sport", 225, 7.6, 390, 4197, 8, 5750);
        carcard B4 = new carcard("B4", "Rindspeed Chopster", 290, 4.4, 600, 4511, 8, 6700);
        carcard C1 = new carcard("C1", "Maserati Spyder", 283, 5.0, 390, 4244, 8, 7000);
        carcard C2 = new carcard("C2", "Toyota Celia", 205, 8.7, 143, 1794, 4, 6400);
        carcard C3 = new carcard("C3", "Porsche 911 Targa", 285, 5.2, 320, 3596, 6, 6800);
        carcard C4 = new carcard("C4", "Corvette Coupe", 281, 5.2, 344, 5665, 8, 5400);
        carcard D1 = new carcard("D1", "Audi RS4", 250, 4.8, 420, 4163, 8, 7800);
        carcard D2 = new carcard("D2", "Audi RS 6 Plus", 280, 4.6, 480, 4172, 8, 6400);
        carcard D3 = new carcard("D3", "Nissan 350 Z", 250, 5.9, 280, 3498, 6, 6200);
        carcard D4 = new carcard("D4", "Mercedes CLK DTM AMG", 320, 4.0, 582, 5439, 8, 6100);
        carcard E1 = new carcard("E1", "Aston Martin V8 Vantage", 280, 5.0, 4282, 385, 8, 7000);
        carcard E2 = new carcard("E2", "Ferrari F50", 325, 3.9, 521, 4700, 12, 8500);
        carcard E3 = new carcard("E3", "BMW 645 Ci", 250, 5.6, 333, 4398, 7, 6100);
        carcard E4 = new carcard("E4", "Bentley Azure", 241, 6.7, 6750, 388, 8, 4000);
        carcard F1 = new carcard("F1", "Opel Astra Coupe 2.0", 245, 7.5, 192, 1998, 4, 5400);
        carcard F2 = new carcard("F2", "VW Golf R32", 248, 6.2, 250, 3189, 6, 6300);
        carcard F3 = new carcard("F3", "Chrysler Crossfire", 250, 6.9, 218, 3199, 6, 5700);
        carcard F4 = new carcard("F4", "Fisker Tramonto", 325, 3.6, 610, 5439, 8, 6100);
        carcard G1 = new carcard("G1", "Marcos Mantara", 225, 5.4, 190, 3998, 8, 4750);
        carcard G2 = new carcard("G2", "Mercedes-Benz SL 500", 250, 6.3, 4966, 306, 8, 5600);
        carcard G3 = new carcard("G3", "Alfa Romeo Brera", 248, 6.3, 260, 3195, 6, 6200);
        carcard G4 = new carcard("G4", "Porsche Cayman S", 275, 5.4, 295, 3387, 6, 6250);
        carcard H1 = new carcard("H1", "BMW Z4", 250, 5.9, 2979, 231, 6, 5900);
        carcard H2 = new carcard("H2", "Alfa Romeo GT", 243, 6.7, 240, 3179, 6, 6400);
        carcard H3 = new carcard("H3", "Pontiac GTO", 280, 5.7, 5970, 400, 8, 5200);
        carcard H4 = new carcard("H4", "BMW M5", 250, 4.7, 4999, 507, 10, 7750);

        List<carcard> list = new List<carcard>();

        deck d;
        hand h1 = new hand();
        hand h2 = new hand();
        hand h3 = new hand();
        hand h4 = new hand();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(A1);
            list.Add(A2);
            list.Add(A3);
            list.Add(A4);
            list.Add(B1);
            list.Add(B2);
            list.Add(B3);
            list.Add(B4);
            list.Add(C1);
            list.Add(C2);
            list.Add(C3);
            list.Add(C4);
            list.Add(D1);
            list.Add(D2);
            list.Add(D3);
            list.Add(D4);
            list.Add(E1);
            list.Add(E2);
            list.Add(E3);
            list.Add(E4);
            list.Add(F1);
            list.Add(F2);
            list.Add(F3);
            list.Add(F4);
            list.Add(G1);
            list.Add(G2);
            list.Add(G3);
            list.Add(G4);
            list.Add(H1);
            list.Add(H2);
            list.Add(H3);
            list.Add(H4);
            d = new deck(list);
            d.shuffle();
        }
        private void showcard(carcard c) 
        {
            if (c == null)
            {
                carpic1.Image = null;
                nameT.Text = string.Empty;
                maxspeedT.Text = string.Empty;
                zerotosixtyT.Text = string.Empty;
                hpT.Text = string.Empty;
                ccT.Text = string.Empty;
                cylindersT.Text = string.Empty;
                rpmT.Text = string.Empty;
                return;
            }
            carpic1.Load(c.id + ".png");
            nameT.Text = c.name;
            maxspeedT.Text = c.maxspeed.ToString();
            zerotosixtyT.Text = c.zerotosixty.ToString();
            hpT.Text = c.hp.ToString();
            ccT.Text = c.cc.ToString();
            cylindersT.Text = c.cylinders.ToString();
            rpmT.Text = c.RPM.ToString();
        }
        private void showcard2(carcard c)
        {
            carpic2.Load(c.id + ".png");
            nameT2.Text = c.name;
            maxspeedT2.Text = c.maxspeed.ToString();
            zerotosixtyT2.Text = c.zerotosixty.ToString();
            hpT2.Text = c.hp.ToString();
            ccT2.Text = c.cc.ToString();
            cylindersT2.Text = c.cylinders.ToString();
            rpmT2.Text = c.RPM.ToString();
        }
        private void showcard3(carcard c)
        {
            carpic3.Load(c.id + ".png");
            nameT3.Text = c.name;
            maxspeedT3.Text = c.maxspeed.ToString();
            zerotosixtyT3.Text = c.zerotosixty.ToString();
            hpT3.Text = c.hp.ToString();
            ccT3.Text = c.cc.ToString();
            cylindersT3.Text = c.cylinders.ToString();
            rpmT3.Text = c.RPM.ToString();
        }
        private void showcard4(carcard c)
        {
            carpic4.Load(c.id + ".png");
            nameT4.Text = c.name;
            maxspeedT4.Text = c.maxspeed.ToString();
            zerotosixtyT4.Text = c.zerotosixty.ToString();
            hpT4.Text = c.hp.ToString();
            ccT4.Text = c.cc.ToString();
            cylindersT4.Text = c.cylinders.ToString();
            rpmT4.Text = c.RPM.ToString();
        }

        private void card1B_Click(object sender, EventArgs e)
        {
            //list of ones that dont work
            showcard(h1.topcard());
        }

        private void card2B_click(object sender, EventArgs e)
        {
            showcard2(h2.topcard());
        }

        private void card3B_Click(object sender, EventArgs e)
        {
            showcard3(h3.topcard());
        }

        private void card4B_Click(object sender, EventArgs e)
        {
            showcard4(h4.topcard());
        }

        private void dealB_Click(object sender, EventArgs e)
        {
            //shuffle deck
            d.shuffle();

            //deal cards
            while(!d.IsEmpty())
            {
            h1.add(d.getcard(0));
            h2.add(d.getcard(0));
            h3.add(d.getcard(0));
            h4.add(d.getcard(0));
            }
        }
    }
}
