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
    public partial class Form_Cal : Form
    {
        private Calculator cal = new Calculator();
        public Form_Cal()
        {
            InitializeComponent();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            string input = textBox_input.Text;
            string result = cal.calculate(input);
            textBox_result.Text = result;
        }
    }
}
