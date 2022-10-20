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
    public partial class Frm5 : Form
    {
        public Frm5()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
           int sexo =Convert.ToInt32(txtSexo.Text);
            string usuario = txtUsuario.Text;

            switch (sexo)
            {
                case 1:
                    MessageBox.Show("Nombre: "+nombre + "\nSexo: Femenino "+sexo + "\nUsuario: "+usuario);

                    break;

                case 2:
                    MessageBox.Show("Nombre: "+nombre + "\nSexo: Masculino "+sexo + "\nUsuario: "+usuario);

                    break;
            }
              
        }
    }
}
