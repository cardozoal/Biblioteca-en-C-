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
    public partial class Form2 : Form
    {
        private int conteo;
        public Form2()
        {
            InitializeComponent();
            conteo = 99;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pbrinicio_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tmrcarga.Start(); //Empieza el conteo del timer
            conteo++;
            lblcarga.Text = conteo.ToString();
            pbrinicio.Value = 100;
        }

        private void tmrcarga_Tick(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); //Llama al formulario 4
            f4.Show(); //Muestra el formulario 4
            this.Hide(); //Oculta el formulario 3
            tmrcarga.Stop(); //Se detiene el conteo del timer
        }

        private void lblcarga_Click(object sender, EventArgs e)
        {
            lblcarga.Text = conteo.ToString();
        }
    }
}
