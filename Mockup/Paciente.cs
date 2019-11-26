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
    public partial class Paciente : Form
    {
        

        public Paciente()
        {
            InitializeComponent();
        }

        private void Paciente_Load_1(object sender, EventArgs e)
        {
            cargardatagridview();
        }

        public void cargardatagridview()
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string query = "SELECT * FROM paciente;";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
            dataGridPaciente.Rows.Clear();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridPaciente.Rows.Add();
                dataGridPaciente.Rows[renglon].Cells["IdP"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridPaciente.Rows[renglon].Cells["nombrep"].Value = reader.GetString(reader.GetOrdinal("nombre"));
                dataGridPaciente.Rows[renglon].Cells["apaternoP"].Value = reader.GetString(reader.GetOrdinal("apaterno"));
                dataGridPaciente.Rows[renglon].Cells["amaternoP"].Value = reader.GetString(reader.GetOrdinal("amaterno"));
                dataGridPaciente.Rows[renglon].Cells["profesionP"].Value = reader.GetString(reader.GetOrdinal("profesion"));
                dataGridPaciente.Rows[renglon].Cells["sexoP"].Value = reader.GetString(reader.GetOrdinal("sexo"));
                dataGridPaciente.Rows[renglon].Cells["edadP"].Value = reader.GetInt32(reader.GetOrdinal("edad")).ToString();
                dataGridPaciente.Rows[renglon].Cells["nocasaP"].Value = reader.GetInt32(reader.GetOrdinal("nocasa")).ToString();
                dataGridPaciente.Rows[renglon].Cells["calleP"].Value = reader.GetString(reader.GetOrdinal("calle"));
                dataGridPaciente.Rows[renglon].Cells["coloniaP"].Value = reader.GetString(reader.GetOrdinal("colonia"));
                dataGridPaciente.Rows[renglon].Cells["municipioP"].Value = reader.GetString(reader.GetOrdinal("municipio"));
                dataGridPaciente.Rows[renglon].Cells["estadoP"].Value = reader.GetString(reader.GetOrdinal("estado"));
                dataGridPaciente.Rows[renglon].Cells["telefonoP"].Value = reader.GetString(reader.GetOrdinal("telefono"));
            }

            conexion.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            string query = "SELECT * FROM paciente;";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridPaciente.Rows.Add();
                dataGridPaciente.Rows[renglon].Cells["IdP"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridPaciente.Rows[renglon].Cells["nombrep"].Value = reader.GetString(reader.GetOrdinal("nombre"));
                dataGridPaciente.Rows[renglon].Cells["apaternoP"].Value = reader.GetString(reader.GetOrdinal("apaterno"));
                dataGridPaciente.Rows[renglon].Cells["amaternoP"].Value = reader.GetString(reader.GetOrdinal("amaterno"));
                dataGridPaciente.Rows[renglon].Cells["profesionP"].Value = reader.GetString(reader.GetOrdinal("profesion"));
                dataGridPaciente.Rows[renglon].Cells["sexoP"].Value = reader.GetString(reader.GetOrdinal("sexo"));
                dataGridPaciente.Rows[renglon].Cells["edadP"].Value = reader.GetInt32(reader.GetOrdinal("edad")).ToString();
                dataGridPaciente.Rows[renglon].Cells["nocasaP"].Value = reader.GetInt32(reader.GetOrdinal("nocasa")).ToString();
                dataGridPaciente.Rows[renglon].Cells["calleP"].Value = reader.GetString(reader.GetOrdinal("calle"));
                dataGridPaciente.Rows[renglon].Cells["coloniaP"].Value = reader.GetString(reader.GetOrdinal("colonia"));
                dataGridPaciente.Rows[renglon].Cells["municipioP"].Value = reader.GetString(reader.GetOrdinal("municipio"));
                dataGridPaciente.Rows[renglon].Cells["estadoP"].Value = reader.GetString(reader.GetOrdinal("estado"));
                dataGridPaciente.Rows[renglon].Cells["telefonoP"].Value = reader.GetString(reader.GetOrdinal("telefono"));
            }


            int indice = comboBoxSexo.SelectedIndex;
            string sexo = comboBoxSexo.Items[indice].ToString();


            string query = "INSERT INTO paciente(nombre,Apaterno,Amaterno,Profesion,Sexo,Edad,NoCasa,Calle,Colonia,Municipio,Estado,Telefono)" +
                "VALUES('" + textBoxNombre.Text + "','" + textBoxPaterno.Text + "','" + textBoxMaterno.Text + "'," +
                " '" + textBoxProfesion.Text + "','" + sexo + "','" + textBoxEdad.Text + "','" + textBoxNo.Text + "', " +
                " '" + textBoxCalle.Text + "','" + textBoxColonia.Text + "','" + textBoxMunicipio.Text + "','" + textBoxEstado.Text + "','" + textBoxTelefono.Text + "');";



            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Paciente Agregado con Exito!!");

            textBoxNombre.Clear();
            textBoxPaterno.Clear();
            textBoxMaterno.Clear();
            textBoxProfesion.Clear();
            textBoxEdad.Clear();
            textBoxNo.Clear();
            textBoxCalle.Clear();
            textBoxColonia.Clear();
            textBoxMunicipio.Clear();
            textBoxEstado.Clear();
            textBoxTelefono.Clear();

            cargardatagridview();

            conexion.Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            int indice = comboBoxSexo.SelectedIndex;
            string sexo = comboBoxSexo.Items[indice].ToString();


            string query = "INSERT INTO paciente(nombre,Apaterno,Amaterno,Profesion,Sexo,Edad,NoCasa,Calle,Colonia,Municipio,Estado,Telefono)" +
                "VALUES('" + textBoxNombre.Text + "','" + textBoxPaterno.Text + "','" + textBoxMaterno.Text + "'," +
                " '" + textBoxProfesion.Text + "','" + sexo + "','" + textBoxEdad.Text + "','" + textBoxNo.Text + "', " +
                " '" + textBoxCalle.Text + "','" + textBoxColonia.Text + "','" + textBoxMunicipio.Text + "','" + textBoxEstado.Text + "','" + textBoxTelefono.Text + "');";



            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Paciente Agregado con Exito!!");
        }
    }
}
