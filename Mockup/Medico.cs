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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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

            //cargardatagridview();

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
    }
}
