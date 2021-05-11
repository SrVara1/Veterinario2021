using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario2021
{
    public partial class FormGustavo : Form
    {
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label7;
        private Label label9;
        private Label label11;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label29;
        private Label label30;
        private Label label31;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label5;

        Conexion miConexion = new Conexion();
        
        public FormGustavo()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        //empezamos a encryptar
        

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            String passHasheada = BCrypt.Net.BCrypt.HashPassword(textContraseña.Text, BCrypt.Net.BCrypt.GenerateSalt());
            //MessageBox.Show(textContraseña.Text + " " + passHasheada);

            Conexion miConexion = new Conexion();
           
            Boolean resultado = miConexion.insertaUsuarios(textDNI.Text, textNombre.Text, textApellido.Text, passHasheada, textEmail.Text, textTeléfono.Text, textLocalidad.Text);
            Boolean resultado2 = miConexion.insertaMascota(textChip.Text,textNombreMascota.Text, textRaza.Text, textDNI.Text);

         
            if (resultado)  
            {
                MessageBox.Show("Usuario creado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
     
        }

        private void textDNI_TextChanged(object sender, EventArgs e)

        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormJaime ventana = new FormJaime();
            ventana.Show();
        }
    }
}
