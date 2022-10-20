using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDeMetodos
{
    public partial class FrmMultiplicar : Form
    {
        public FrmMultiplicar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            metodoMultiplicar();
        }

        private void metodoMultiplicar()
        {
            int numero = Convert.ToInt32(txtMultiplicar.Text);

            for (int i = 0; i <= 12; i++)
            {

                MessageBox.Show(numero + " x " + i + " = " + numero * i);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
