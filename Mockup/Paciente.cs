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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión
            
            int indice = comboBoxSexo.SelectedIndex;
            string sexo = comboBoxSexo.Items[indice].ToString();


            string query = "INSERT INTO paciente(nombre,Apaterno,Amaterno,Profesion,Sexo,Edad,NoCasa,Calle,Colonia,Municipio,Estado,Telefono)" +
                "VALUES('" + textBoxNombre.Text + "','" + textBoxPaterno.Text + "','" + textBoxMaterno.Text + "'," +
                " '" + textBoxProfesion.Text + "','" + sexo + "','"+ textBoxEdad.Text + "','"+ textBoxNo.Text + "', " +
                " '" + textBoxCalle.Text + "','" + textBoxColonia.Text + "','" + textBoxMunicipio.Text + "','" + textBoxEstado.Text + "','" + textBoxTelefono.Text + "');";

                              //string nom = "ALDO";
                              ////string query = "INSERT INTO paciente (nombre, apaterno, amaterno, profesion, calle, colonia, municipio, estado) VALUES('"+ textBoxNombre.Text + "','" + textBoxPaterno.Text + "','" + textBoxMaterno.Text + "','" + textBoxProfesion.Text + "','" + textBoxCalle.Text + "','" + textBoxColonia.Text +"','" + textBoxMunicipio.Text + "','" + textBoxEstado.Text + "');";
                              //string query = "INSERT INTO paciente (nombre) VALUES('"+nom+"');";


            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Paciente Agregado con Exito!!");

            textBoxNombre.Clear();
            textBoxPaterno.Clear();
            textBoxMaterno.Clear();
            textBoxProfesion.Clear();
            textBoxCalle.Clear();
            textBoxColonia.Clear();
            textBoxMunicipio.Clear();
            textBoxEstado.Clear();

            conexion.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
