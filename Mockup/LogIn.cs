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

namespace Mockup
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            string query = "SELECT * FROM admin WHERE usuario = '" + textBoxUser.Text + "' AND " +
                "password = '" + textBoxPassword.Text + "';";

            conexion.ConnectionString = "Host=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            try
            {
                conexion.Open(); //Abrir la Conexión
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR!!: " + error.Message);
            }

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            NpgsqlDataReader reader;
            
            reader = comando.ExecuteReader();

            string user;

            if (reader.Read())
            {
                user = reader.GetString(0);
                MessageBox.Show("Bienvenido " + user + "");

                this.Hide();
                Main serv = new Main();
                serv.Show();

            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrectos!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }
    }
}
