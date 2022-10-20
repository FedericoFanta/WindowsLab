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
    public partial class FrmEdad : Form
    {
        public FrmEdad()
        {
            InitializeComponent();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            metodoEdad();
        }

        private void metodoEdad()
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            if (edad == 0)
            {
                MessageBox.Show("ERROR!");
            }
            else if (edad < 18)
            {
                MessageBox.Show("Usted es menor de edad!");
            }
            else if (edad >=18 && edad < 60)
            {
                MessageBox.Show("Usted es mayor de edad!");
            }
            else
            {
                MessageBox.Show("Usted es adulto mayor!");
            }
        }
    }
}
