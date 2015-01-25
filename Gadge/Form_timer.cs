using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadge
{
    public partial class Form_timer : Form
    {
        private System.Windows.Forms.Timer timer;
        private int counter;

        public Form_timer()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            int minute, second;
            Boolean n = Int32.TryParse(textBox_min.Text, out minute);
            n = Int32.TryParse(textBox_second.Text, out second);
            counter = minute * 60 + second;

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; // 1 second
            timer.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer.Stop();
                this.Close();
            }

        }
    }
}
