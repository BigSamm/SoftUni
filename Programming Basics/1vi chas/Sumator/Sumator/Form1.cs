using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var a = decimal.Parse(this.textBox1.Text);
                var b = decimal.Parse(this.textBox2.Text);
                var c = a + b;
                textBoxSum.Text = c.ToString();
            }

            catch (Exception)
            {
                textBoxSum.Text = "error";
            }
                
        }
    }
}
