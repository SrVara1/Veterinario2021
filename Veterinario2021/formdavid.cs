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
    public partial class formdavid : Form
    {
        Conexion miConexion = new Conexion();
        public formdavid()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormJaime ventana = new
        FormJaime();
            ventana.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion miConexion = new Conexion();
            Boolean resultado = miConexion.insertaCita(DNI.Text, Telefono.Text, Chip.Text, ProblemaMascota.Text, Calendario.Text);
            if (resultado)
            {
                MessageBox.Show("Insertado Corecctamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado, vuelve a intentarlo mas tarde");
            }
        }
    }
}