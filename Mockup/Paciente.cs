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

            //DateTime dt = new DateTime.;
            textBoxFecha1E.Text = DateTime.Now.ToShortDateString();
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
            comboBoxSexo.SelectedIndex = -1;

            cargardatagridview();

            conexion.Close();
        }
        
        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text != "")
            {
                NpgsqlConnection conexion = new NpgsqlConnection();
                conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
                conexion.Open(); //Abrir la Conexión

                string query = "SELECT * FROM paciente WHERE id = @ID;";
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
                    textBoxEdad1.Text = reader["edad"].ToString();
                    textBoxProfesion1.Text = reader["profesion"].ToString();
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

            string query1 = "UPDATE paciente SET nombre = '" + textBoxNombre1.Text + "'," +
                "apaterno = '" + textBoxPaterno1.Text + "'," +
                "amaterno = '" + textBoxMaterno1.Text + "'," +
                "profesion = '" + textBoxProfesion1.Text + "'," +
                "sexo = '" + sexo1 + "'," +
                "edad = '" + textBoxEdad1.Text + "'," +
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

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            btnSalir2.Enabled = false;
            this.Close();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            btnSalir3.Enabled = false;
            this.Close();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.InitialDirectory = "C:\\";

            img.Filter = "Archivos de Imagen (*.png)|*.png|JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg";

            if (img.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFirma.ImageLocation = img.FileName; 
            }
            else
            {
                MessageBox.Show("No Se Seleccionó Ninguna Imagen", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string query = "INSERT INTO evolucion(descripcion,comentarios,fechacita,fechaproxcita,firma,idpaciente)" +
                "VALUES('" + textBoxDE.Text + "','" + textBoxCE.Text + "','" + textBoxFecha1E.Text + "'," +
                " '" + textBoxFecha2E.Text + "',"+"@img"+",'" + textBoxIdE.Text + "');";

          
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.Parameters.Add("@img", NpgsqlDbType.Bytea);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(); //img a buffer

            //pictureBoxFirma.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            pictureBoxFirma.Image.Save(ms, pictureBoxFirma.Image.RawFormat);

            //Extrae los bytes del buffer

            comando.Parameters["@img"].Value = ms.GetBuffer();

            comando.ExecuteNonQuery();
            MessageBox.Show("Evolución del Paciente Actualizado con Exito!!");

            textBoxDE.Clear();
            textBoxCE.Clear();
            textBoxFecha2E.Clear();
            textBoxIdE.Clear();

            conexion.Close();
        }

        private void btnAgregarT_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión


            string query = "INSERT INTO tratamiento(nombre,descripcion,precio,costo,idpaciente,idmedico)" +
                "VALUES('" + textBoxNombreT.Text + "','" + textBoxDT.Text + "','" + textBoxPrecioT.Text + "'," +
                " '" + textBoxCostoT.Text + "','" + textBoxIdT.Text + "','" + textBoxIdMT.Text + "');";


            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Tratamiento Para El Paciente Actualizado con Exito!!");

            textBoxNombreT.Clear();
            textBoxDT.Clear();
            textBoxPrecioT.Clear();
            textBoxCostoT.Clear();
            textBoxIdT.Clear();
            textBoxIdMT.Clear();

            conexion.Close();
        }

        private void btnSalirT_Click(object sender, EventArgs e)
        {
            btnSalirT.Enabled = false;
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                MessageBox.Show("No Se Ingresó Ningun Nombre", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            string query = "SELECT * FROM paciente WHERE nombre ='" + textBox11.Text + "';";

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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButtonVER_Click(object sender, EventArgs e)
        {
            cargardatagridview();
        }

        private void btnAgregarH_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            conexion.ConnectionString = "Server=localhost; Port=5432; Username=postgres; Password=9693; Database= nucleo;";
            conexion.Open(); //Abrir la Conexión

            int indice1 = comboBoxA.SelectedIndex;
            string hipertension=comboBoxA.Items[indice1].ToString();

            int indice2 = comboBoxB.SelectedIndex;
            string asma = comboBoxB.Items[indice2].ToString();

            int indice3 = comboBoxC.SelectedIndex;
            string diabetes = comboBoxC.Items[indice3].ToString();

            int indice4 = comboBoxD.SelectedIndex;
            string cancer = comboBoxD.Items[indice4].ToString();

            int indice5 = comboBoxE.SelectedIndex;
            string ansiedad = comboBoxE.Items[indice5].ToString();

            int indice6 = comboBoxF.SelectedIndex;
            string depresion = comboBoxF.Items[indice6].ToString();

            int indice7 = comboBoxG.SelectedIndex;
            string anemia = comboBoxG.Items[indice7].ToString();

            int indice8 = comboBoxH.SelectedIndex;
            string vih = comboBoxH.Items[indice8].ToString();

            int indice9 = comboBoxI.SelectedIndex;
            string tabaco = comboBoxI.Items[indice9].ToString();

            int indice10 = comboBoxJ.SelectedIndex;
            string alcohol = comboBoxJ.Items[indice10].ToString();

            int indice11 = comboBoxK.SelectedIndex;
            string drogas = comboBoxK.Items[indice11].ToString();

            string query = "INSERT INTO historial_c(hipertension ,asma ,diabetes ,cancer ,ansiedad ,depresion ,anemia ,vih ,tabaco ,alcohol ,drogas ,idPaciente)" +
                "VALUES('" + hipertension + "','" + asma + "','" + diabetes + "'," +
                " '" + cancer + "','" + ansiedad + "','" + depresion + "','" + anemia + "', " +
                " '" + vih + "','" + tabaco + "','" + alcohol + "','" + drogas + "','" + textBoxIdPH.Text + "');";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Los Antecedes del Paciente Han Sido Agregados con Exito!!");

            comboBoxA.SelectedIndex = -1;
            comboBoxB.SelectedIndex = -1;
            comboBoxC.SelectedIndex = -1;
            comboBoxD.SelectedIndex = -1;
            comboBoxE.SelectedIndex = -1;
            comboBoxF.SelectedIndex = -1;
            comboBoxG.SelectedIndex = -1;
            comboBoxH.SelectedIndex = -1;
            comboBoxI.SelectedIndex = -1;
            comboBoxJ.SelectedIndex = -1;
            comboBoxK.SelectedIndex = -1;
            textBoxIdPH.Clear();

            cargardatagridview();

            conexion.Close();
        }

        private void btnSalirH_Click(object sender, EventArgs e)
        {
            btnSalirH.Enabled = false;
            this.Close();
        }

        private void btnSalir4_Click(object sender, EventArgs e)
        {
            btnSalir4.Enabled = false;
            this.Close();
        }
    }
}
