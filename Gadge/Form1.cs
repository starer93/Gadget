﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gadge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_note_Click(object sender, EventArgs e)
        {
            Form_Note noteForm = new Form_Note();
            noteForm.Location = this.Location;
            noteForm.Show();
        }

        private void button_cal_Click(object sender, EventArgs e)
        {
            Form_Cal calForm = new Form_Cal();
            calForm.Show();
        }

        private void button_timer_Click(object sender, EventArgs e)
        {
            Form_timer timerForm = new Form_timer();
            timerForm.Show();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
