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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
            cargardatagridview();
        }

        /*private void btnAgregar_Click(object sender, EventArgs e)
        {

        }*/

        public void cargardatagridview()
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string query = "SELECT * FROM medico;";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
            dataGridMedico.Rows.Clear();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridMedico.Rows.Add();
                dataGridMedico.Rows[renglon].Cells["IdP"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridMedico.Rows[renglon].Cells["nombrep"].Value = reader.GetString(reader.GetOrdinal("nombre"));
                dataGridMedico.Rows[renglon].Cells["apaternoP"].Value = reader.GetString(reader.GetOrdinal("apaterno"));
                dataGridMedico.Rows[renglon].Cells["amaternoP"].Value = reader.GetString(reader.GetOrdinal("amaterno"));
                dataGridMedico.Rows[renglon].Cells["profesionP"].Value = reader.GetString(reader.GetOrdinal("especialidad"));
                dataGridMedico.Rows[renglon].Cells["sexoP"].Value = reader.GetString(reader.GetOrdinal("sexo"));
                //dataGridMedico.Rows[renglon].Cells["edadP"].Value = reader.GetInt32(reader.GetOrdinal("edad")).ToString();
                dataGridMedico.Rows[renglon].Cells["nocasaP"].Value = reader.GetInt32(reader.GetOrdinal("nocasa")).ToString();
                dataGridMedico.Rows[renglon].Cells["calleP"].Value = reader.GetString(reader.GetOrdinal("calle"));
                dataGridMedico.Rows[renglon].Cells["coloniaP"].Value = reader.GetString(reader.GetOrdinal("colonia"));
                dataGridMedico.Rows[renglon].Cells["municipioP"].Value = reader.GetString(reader.GetOrdinal("municipio"));
                dataGridMedico.Rows[renglon].Cells["estadoP"].Value = reader.GetString(reader.GetOrdinal("estado"));
                dataGridMedico.Rows[renglon].Cells["telefonoP"].Value = reader.GetString(reader.GetOrdinal("telefono"));
                dataGridMedico.Rows[renglon].Cells["Comision"].Value = reader.GetDouble(reader.GetOrdinal("comision")).ToString();
            }

            conexion.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            int indice = comboBoxSexo.SelectedIndex;
            string sexo = comboBoxSexo.Items[indice].ToString();

            string query = "INSERT INTO medico(nombre,Apaterno,Amaterno,Especialidad,Sexo,Foto,NoCasa,Calle,Colonia,Municipio,Estado,Telefono,Comision)" +
                "VALUES('" + textBoxNombre.Text + "','" + textBoxPaterno.Text + "','" + textBoxMaterno.Text + "'," +
                " '" + textBoxEspecialidad.Text + "','" + sexo + "'," + "@img"+",'" + textBoxNo.Text + "', " +
                " '" + textBoxCalle.Text + "','" + textBoxColonia.Text + "','" + textBoxMunicipio.Text + "','" + textBoxEstado.Text + "','" + textBoxTelefono.Text + "','"+ textBoxCom.Text+"');";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.Parameters.Add("@img", NpgsqlDbType.Bytea);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(); //img a buffer

            //pictureBoxFirma.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            pictureBoxMedico.Image.Save(ms, pictureBoxMedico.Image.RawFormat);

            //Extrae los bytes del buffer

            comando.Parameters["@img"].Value = ms.GetBuffer();

            comando.ExecuteNonQuery();

            MessageBox.Show("Medico Agregado con Exito!!");

            textBoxNombre.Clear();
            textBoxPaterno.Clear();
            textBoxMaterno.Clear();
            textBoxEspecialidad.Clear();
            textBoxCom.Clear();
            textBoxNo.Clear();
            textBoxCalle.Clear();
            textBoxColonia.Clear();
            textBoxMunicipio.Clear();
            textBoxEstado.Clear();
            textBoxTelefono.Clear();
            comboBoxSexo.SelectedIndex = -1;

            cargardatagridview();

            conexion.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.InitialDirectory = "C:\\";

            img.Filter = "Archivos de Imagen (*.png)|*.png|JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg";

            if (img.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMedico.ImageLocation = img.FileName;
            }
            else
            {
                MessageBox.Show("No Se Seleccionó Ninguna Imagen", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                NpgsqlConnection conexion = new NpgsqlConnection();
                conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
                conexion.Open(); //Abrir la Conexión

                string query = "SELECT * FROM medico WHERE id = @ID;";
                NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

                int id = System.Convert.ToInt32(textBoxBuscar.Text);

                comando.Parameters.AddWithValue("@ID", id);

                NpgsqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    textBoxId1.Text = reader["id"].ToString();
                    textBoxNombre1.Text = reader["nombre"].ToString();
                    textBoxPaterno1.Text = reader["apaterno"].ToString();
                    textBoxMaterno1.Text = reader["amaterno"].ToString();
                    textBoxEdad1.Text = reader["comision"].ToString();
                    textBoxProfesion1.Text = reader["especialidad"].ToString();
                    textBoxNo1.Text = reader["nocasa"].ToString();
                    textBoxCalle1.Text = reader["calle"].ToString();
                    textBoxColonia1.Text = reader["colonia"].ToString();
                    textBoxMunicipio1.Text = reader["municipio"].ToString();
                    textBoxEstado1.Text = reader["estado"].ToString();
                    textBoxTelefono1.Text = reader["telefono"].ToString();

                    int indice = comboBoxSexo.SelectedIndex;
                    string sexo = reader["sexo"].ToString();

                    if (sexo == "Hombre")
                        comboBoxSexo1.SelectedIndex = 0;
                    else if (sexo == "Mujer")
                        comboBoxSexo1.SelectedIndex = 1;
                    else
                        comboBoxSexo1.SelectedIndex = 2;
                }
                else
                {
                    MessageBox.Show("ID No Encontrado", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion1 = new NpgsqlConnection();
            conexion1.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion1.Open(); //Abrir la Conexión


            int indice1 = comboBoxSexo1.SelectedIndex;
            string sexo1 = comboBoxSexo1.Items[indice1].ToString();

            string query1 = "UPDATE medico SET nombre = '" + textBoxNombre1.Text + "'," +
                "apaterno = '" + textBoxPaterno1.Text + "'," +
                "amaterno = '" + textBoxMaterno1.Text + "'," +
                "especialidad = '" + textBoxProfesion1.Text + "'," +
                "sexo = '" + sexo1 + "'," +
                "comision = '" + textBoxEdad1.Text + "'," +
                "nocasa = '" + textBoxNo1.Text + "'," +
                "calle = '" + textBoxCalle1.Text + "'," +
                "colonia = '" + textBoxColonia1.Text + "'," +
                "municipio = '" + textBoxMunicipio1.Text + "'," +
                "estado = '" + textBoxEstado1.Text + "'," +
                "telefono = '" + textBoxTelefono1.Text + "' " +
                "WHERE id = '" + textBoxId1.Text + "';";

            NpgsqlCommand comando1 = new NpgsqlCommand(query1, conexion1);

            comando1.ExecuteNonQuery();

            MessageBox.Show("El Paciente Ha Sido Modificado con Exito!!");

            textBoxBuscar.Clear();
            textBoxId1.Clear();
            textBoxNombre1.Clear();
            textBoxPaterno1.Clear();
            textBoxMaterno1.Clear();
            textBoxProfesion1.Clear();
            textBoxEdad1.Clear();
            textBoxNo1.Clear();
            textBoxCalle1.Clear();
            textBoxColonia1.Clear();
            textBoxMunicipio1.Clear();
            textBoxEstado1.Clear();
            textBoxTelefono1.Clear();
            comboBoxSexo1.SelectedIndex = -1;

            cargardatagridview();

            conexion1.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            btnSalir3.Enabled = false;
            this.Close();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            btnSalir2.Enabled = false;
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if(textBoxBuscarMedico.Text == "")
            {
                MessageBox.Show("No ha ingresado criterios de busqueda");
                return;
            }
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            string nombre = "nombre";

            string query = "SELECT * FROM medico WHERE "+nombre+"='"+ textBoxBuscarMedico.Text+"';";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            NpgsqlDataReader reader;
            dataGridMedico.Rows.Clear();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int renglon = dataGridMedico.Rows.Add();
                dataGridMedico.Rows[renglon].Cells["IdP"].Value = reader.GetInt32(reader.GetOrdinal("id")).ToString();
                dataGridMedico.Rows[renglon].Cells["nombrep"].Value = reader.GetString(reader.GetOrdinal("nombre"));
                dataGridMedico.Rows[renglon].Cells["apaternoP"].Value = reader.GetString(reader.GetOrdinal("apaterno"));
                dataGridMedico.Rows[renglon].Cells["amaternoP"].Value = reader.GetString(reader.GetOrdinal("amaterno"));
                dataGridMedico.Rows[renglon].Cells["profesionP"].Value = reader.GetString(reader.GetOrdinal("especialidad"));
                dataGridMedico.Rows[renglon].Cells["sexoP"].Value = reader.GetString(reader.GetOrdinal("sexo"));
                //dataGridMedico.Rows[renglon].Cells["edadP"].Value = reader.GetInt32(reader.GetOrdinal("edad")).ToString();
                dataGridMedico.Rows[renglon].Cells["nocasaP"].Value = reader.GetInt32(reader.GetOrdinal("nocasa")).ToString();
                dataGridMedico.Rows[renglon].Cells["calleP"].Value = reader.GetString(reader.GetOrdinal("calle"));
                dataGridMedico.Rows[renglon].Cells["coloniaP"].Value = reader.GetString(reader.GetOrdinal("colonia"));
                dataGridMedico.Rows[renglon].Cells["municipioP"].Value = reader.GetString(reader.GetOrdinal("municipio"));
                dataGridMedico.Rows[renglon].Cells["estadoP"].Value = reader.GetString(reader.GetOrdinal("estado"));
                dataGridMedico.Rows[renglon].Cells["telefonoP"].Value = reader.GetString(reader.GetOrdinal("telefono"));
                dataGridMedico.Rows[renglon].Cells["Comision"].Value = reader.GetDouble(reader.GetOrdinal("comision")).ToString();
            }

            conexion.Close();
        }
    }
}
