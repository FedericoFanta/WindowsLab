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
    public partial class Frm6 : Form
    {
        public Frm6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, apellido;
            int fecha;
            imprimir(out nombre, out apellido, out fecha);

            int edad;
            edad=2022-fecha;
            MessageBox.Show("Nombre completo "+nombre +apellido +  "edad: " + edad);


        }

        private void imprimir(out string nombre, out string apellido, out int fecha)
        {
            nombre =txtNombre.Text;
            apellido =txtApellido.Text;
            fecha =Convert.ToInt32(txtFecha.Text);
            MessageBox.Show("Nombre completo "+nombre +apellido);
        }
    }
}
