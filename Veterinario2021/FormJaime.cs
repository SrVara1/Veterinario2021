using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario2021
{

    public partial class FormJaime : Form
    {
        Conexion miConexion = new Conexion();
        public FormJaime()
        {
            InitializeComponent();
            char c = '\u1F43';

            password.PasswordChar = '\u2664';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void texto_Click(object sender, EventArgs e)
        {

        }

        private void CreaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGustavo ventana = new FormGustavo();
            ventana.Show();
        }

        private void IniciaSesion_Click(object sender, EventArgs e)
        {
            String DNI = Usuario.Text;
            String Contraseña = password.Text;
            if (miConexion.inicioSesion(DNI, Contraseña)) {
                this.Hide();
                formdavid ventana = new formdavid();
                ventana.Show();
            }
            else {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
