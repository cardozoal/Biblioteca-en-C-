using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Biblioteca
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraConf.Text)
            {
                if(Usuarios.CrearCuentas(txtNombre.Text, txtApellido.Text, txtFechaNac.Text, txtDNI.Text, txtEmail.Text, txtNombreUsu.Text, txtContraseña.Text, txtContraConf.Text) > 0)
                {
                    MessageBox.Show("Cuenta creada con Exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
