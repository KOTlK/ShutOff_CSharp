using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutOff_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timer = userText.Text;
            int timetilloff = Convert.ToInt32(timer);
            if (timer == "")
            {
                timetilloff = Convert.ToInt32(timer);
            }
            if (Hours.Checked)
            {
                timetilloff = Convert.ToInt32(timer) * 3600;
            } else if (Minutes.Checked)
            {
                timetilloff = Convert.ToInt32(timer) * 60;
            } else if (Seconds.Checked)
            {
                timetilloff = Convert.ToInt32(timer);
            }
            Process.Start("cmd", "/c shutdown -s -f -t " + timetilloff);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c shutdown /a");
        }
    }
}
