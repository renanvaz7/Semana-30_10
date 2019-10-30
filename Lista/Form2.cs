using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Label_custofab_Click(object sender, EventArgs e)
        {

        }

        private void Button_result_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Int32.Parse(textBox_valor1.Text);
            b = Int32.Parse(textBox_valor2.Text);
            c = Int32.Parse(textBox_valor3.Text);

            if (a > b)
            {
                textBox_result.Text = Convert.ToString(a); 
            }
            else if (b > c)
            {
                textBox_result.Text = Convert.ToString(b);
            }
            else
            {
                textBox_result.Text = Convert.ToString(c);
            }           
        }
    }
}
