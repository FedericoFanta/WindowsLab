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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            metodoArea();
        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDiametro_Click(object sender, EventArgs e)
        {
            metodoDiametro();

        }

        private void metodoDiametro()
        {
            decimal pi = 3;
            decimal radio = Convert.ToDecimal(txtDiametro.Text);

            decimal areaC = (pi * (radio * radio));

            MessageBox.Show("El area del circulo es "+ areaC);
        }

        private void metodoArea()
        {
            int baser = Convert.ToInt32(txtBase.Text);
            int altura = Convert.ToInt32(txtAltura.Text);

            int area = (baser*altura);

            MessageBox.Show("Tu area es "+area);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            int altura1;
        }
    }
}
