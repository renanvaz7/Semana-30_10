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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Button_calcular_Click(object sender, EventArgs e)
        {
            double cfabrica, pdistribuidora, imposto, vfinal;
                      
            cfabrica = double.Parse(textBox_custofab.Text);

            pdistribuidora = (cfabrica * 28 / 100);
            imposto = (cfabrica * 45 / 100);

            vfinal = (cfabrica + pdistribuidora + imposto);

            textBox_custof.Text = Convert.ToString(vfinal);
        }

        private void Button_prox_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
