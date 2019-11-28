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
    public partial class Pago : Form
    {
        public Pago()
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


            string query = "SELECT * FROM pago;";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
            dataGridMedico.Rows.Clear();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridMedico.Rows.Add();
                dataGridMedico.Rows[renglon].Cells["IdPago"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridMedico.Rows[renglon].Cells["metodopago"].Value = reader.GetString(reader.GetOrdinal("metodopago"));
                dataGridMedico.Rows[renglon].Cells["totalfactura"].Value = reader.GetFloat(reader.GetOrdinal("totalfactura")).ToString();
                dataGridMedico.Rows[renglon].Cells["abono"].Value = reader.GetDouble(reader.GetOrdinal("abono")).ToString();
                dataGridMedico.Rows[renglon].Cells["deuda"].Value = reader.GetDouble(reader.GetOrdinal("deuda")).ToString();
                dataGridMedico.Rows[renglon].Cells["fechapago"].Value = reader.GetDate(reader.GetOrdinal("fechapago")).ToString();
                dataGridMedico.Rows[renglon].Cells["pagolab"].Value = reader.GetDouble(reader.GetOrdinal("pagolaboratorio")).ToString();
                dataGridMedico.Rows[renglon].Cells["Idpacientepago"].Value = reader.GetInt32(reader.GetOrdinal("idpaciente")).ToString();
                dataGridMedico.Rows[renglon].Cells["idmedicopago"].Value = reader.GetInt32(reader.GetOrdinal("idmedico")).ToString();
            }

            conexion.Close();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxIdPaciente.Text == "") 
            return;
            double total = 0;
            double totalabono = 0;
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string query = "SELECT * FROM tratamiento WHERE idpaciente = '"+ textBoxIdPaciente.Text +"';";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
           

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
             total+= reader.GetDouble(reader.GetOrdinal("precio")); ;
            }

            textBoxTotal.Text = total.ToString();

            conexion.Close();
            conexion.Open();

            NpgsqlDataReader lector;

            query = "SELECT * FROM pago WHERE idpaciente = '" + textBoxIdPaciente.Text + "';";

            NpgsqlCommand comand = new NpgsqlCommand(query, conexion);

            lector = comand.ExecuteReader();

            while (lector.Read())
            {
                totalabono += lector.GetDouble(lector.GetOrdinal("abono")); ;
            }

            textBoxDeuda.Text =( -1*(totalabono-total)).ToString();

            conexion.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            int indice = comboBoxSexo.SelectedIndex;
            string metodo = comboBoxSexo.Items[indice].ToString();

            string query = "INSERT INTO pago(metodopago,totalfactura,abono,deuda,fechapago,pagolaboratorio,idpaciente,idmedico)" +
                "VALUES('" + metodo + "','" + textBoxTotal.Text + "','" + textBoxAbono.Text + "'," +
                " '" + textBoxDeuda.Text + "','" + textBoxFecha.Text + "','" + textBoxPagoLab.Text + "','" + textBoxIdPaciente.Text + "', " +
                " '" + textBoxIdMedico.Text + "');";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Pago Agregado con Exito!!");

            textBoxTotal.Clear();
            textBoxAbono.Clear();
            textBoxDeuda.Clear();
            textBoxFecha.Clear();
            textBoxPagoLab.Clear();
            textBoxIdPaciente.Clear();
            textBoxIdMedico.Clear();

            comboBoxSexo.SelectedIndex = -1;

            cargardatagridview();

            conexion.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            cargardatagridview();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (textBoxBuscarPago.Text == "")
                return;



            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string nombre = "idpaciente";

            string query = "SELECT * FROM pago WHERE " + nombre + "='" + textBoxBuscarPago.Text + "';";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
            dataGridMedico.Rows.Clear();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridMedico.Rows.Add();
                dataGridMedico.Rows[renglon].Cells["IdPago"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridMedico.Rows[renglon].Cells["metodopago"].Value = reader.GetString(reader.GetOrdinal("metodopago"));
                dataGridMedico.Rows[renglon].Cells["totalfactura"].Value = reader.GetFloat(reader.GetOrdinal("totalfactura")).ToString();
                dataGridMedico.Rows[renglon].Cells["abono"].Value = reader.GetDouble(reader.GetOrdinal("abono")).ToString();
                dataGridMedico.Rows[renglon].Cells["deuda"].Value = reader.GetDouble(reader.GetOrdinal("deuda")).ToString();
                dataGridMedico.Rows[renglon].Cells["fechapago"].Value = reader.GetDate(reader.GetOrdinal("fechapago")).ToString();
                dataGridMedico.Rows[renglon].Cells["pagolab"].Value = reader.GetDouble(reader.GetOrdinal("pagolaboratorio")).ToString();
                dataGridMedico.Rows[renglon].Cells["Idpacientepago"].Value = reader.GetInt32(reader.GetOrdinal("idpaciente")).ToString();
                dataGridMedico.Rows[renglon].Cells["idmedicopago"].Value = reader.GetInt32(reader.GetOrdinal("idmedico")).ToString();
            }

            conexion.Close();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
