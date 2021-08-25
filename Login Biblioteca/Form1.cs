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
    public partial class Form1 : Form
    {
        Form2 logeo;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            { //Asignamos variables
                string usuario, contraseña;
                usuario = txtusuario.Text.TrimEnd(); //lee los datos de las variables
                contraseña = txtcontra.Text.TrimEnd();
                if (txtusuario.Text == "" && txtcontra.Text == "") //utilizamos 2 if. Modo incorrecto de inicio de sesión, si no pone ningún dato
                {
                    MessageBox.Show("Ingrese nombre de usuario y contraseña por favor"); //Se mostrara esta ventana en caso de que no haya ingresado ningún dato
                }
                {
                    if (txtusuario.Text == "Alan" && txtcontra.Text == "Cardozo") //Modo correcto de inicio de sesión, si pone bien los datos
                    {
                        MessageBox.Show("Sesión Correcta"); //Se mostrara esta ventana en caso de que haya ingresado bien los datos
                        logeo = new Form2(); //Llama al formulario 2
                        logeo.Show(); //Se muestra el formulario solo si los datos fueron ingresados correctamente
                        this.Hide(); //Oculta el formulario 1
                    }
                    else //Caso contrario, modo incorrecto si ha puesto mal los datos
                    {
                        MessageBox.Show("Sesión incorrecta"); //Se mostrara esta ventana en caso de que haya ingresado mal los datos
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
