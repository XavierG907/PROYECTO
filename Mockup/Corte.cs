using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Mockup
{
    public partial class Corte : Form
    {
        public Corte()
        {
            InitializeComponent();

            textBoxFecha.Text = DateTime.Now.ToShortDateString();
            cargardatagridview();
        }

        public void cargardatagridview()
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string query = "SELECT * FROM corte;";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
            dataGridView1.Rows.Clear();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["idc"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridView1.Rows[renglon].Cells["fechac"].Value = reader.GetDate(reader.GetOrdinal("fechacorte")).ToString();
                dataGridView1.Rows[renglon].Cells["Gasto"].Value = reader.GetString(reader.GetOrdinal("gastosmes"));
                dataGridView1.Rows[renglon].Cells["Ingreso"].Value = reader.GetString(reader.GetOrdinal("entradames"));
            }

            conexion.Close();


        }
            private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (textBoxEntradas.Text == "")
            {
                MessageBox.Show("Aun no ingresas todo");
                return;
            }
            if (textBoxGastos.Text == "")
            {
                MessageBox.Show("Aun no ingresas todo");
                return;
            }
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string query = "INSERT INTO corte(fechacorte,entradames,gastosmes)" +
                "VALUES('" + textBoxFecha.Text + "','" + textBoxEntradas.Text + "','" + textBoxGastos.Text + "');";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            textBoxEntradas.Clear();
            textBoxGastos.Clear();
            MessageBox.Show("Corte Agregado con Exito!!");
            cargardatagridview();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MesBusqueda.Text == "")
                return;
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            string nombre = "fechacorte";

            string query = "SELECT * FROM corte WHERE " + nombre + "='" + MesBusqueda.Text + "';";

            
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
            dataGridView1.Rows.Clear();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["idc"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridView1.Rows[renglon].Cells["fechac"].Value = reader.GetDate(reader.GetOrdinal("fechacorte")).ToString();
                dataGridView1.Rows[renglon].Cells["Gasto"].Value = reader.GetString(reader.GetOrdinal("gastosmes"));
                dataGridView1.Rows[renglon].Cells["Ingreso"].Value = reader.GetString(reader.GetOrdinal("entradames"));
            }

            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            cargardatagridview();
        }
    }
}
