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
        DataTable datosUsuarios = new DataTable();
        DataTable datosMascotas = new DataTable();

       
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
            if (Chip.Text.Length > 0 && Especie.Text.Length > 0 && Sexo.Text.Length > 0 && Edad.Text.Length > 0 && ProblemaMascota.Text.Length > 0 && Calendario.Text.Length > 0){


                Conexion miConexion = new Conexion();
                Boolean resultado = miConexion.insertaCita(Chip.Text,Especie.Text, Sexo.Text, Edad.Text, ProblemaMascota.Text, Calendario.Text);
                if (resultado)
                {
                    MessageBox.Show("Insertado Correctamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado, vuelve a intentarlo mas tarde");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getUsuarios_Click(object sender, EventArgs e)
        {
            datosUsuarios = miConexion.getUsuarios(getDNI.Text);
            dataGridView1.DataSource = datosUsuarios;

        }

        private void getMascotas_Click(object sender, EventArgs e)
        {
            datosMascotas = miConexion.getMascotas(getChip.Text);
            dataGridView1.DataSource = datosMascotas;

        }
    }
}