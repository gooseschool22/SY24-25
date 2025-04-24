using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        private DateTime starttime;
        public StopWatch()
        {
            InitializeComponent();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            starttime = DateTime.Now;

            formTimer.Start();
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            watchLabel.Text = "00:00.00";
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - starttime;
            watchLabel.Text = span.ToString(@"mm\:ss\.ff");
        }
    }
}
