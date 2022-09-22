using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1LAB2_2
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void rbIsla1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIsla1.Checked)
            {
                nudGatos.Enabled = false;
            }
        }

        private void rbIsla2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIsla2.Checked)
            {
                nudGatos.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void nudAncho_ValueChanged(object sender, EventArgs e)
        {
            int maximo = Convert.ToInt32(nudAncho.Value * nudLargo.Value);
            nudQuesos.Maximum = maximo;
            nudRatones.Maximum = maximo;
            nudGatos.Maximum = maximo;
        }
    }
}
