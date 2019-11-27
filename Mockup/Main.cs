using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mockup
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BunifuFlatButton11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hasta Luego!",
                            "CERRANDO SESIÓN");
            Application.Exit();
        }

        private void opcionMenu_Click(object sender, EventArgs e)
        {
            if (MenuSide.Width == 225)
            {
                MenuSide.Visible = false;
                MenuSide.Width = 68;
                panelSide.Width = 90;
                line.Width = 46;
                transicionMenu.Show(MenuSide);
            }
            else
            {
                MenuSide.Visible = false;
                MenuSide.Width = 225;
                panelSide.Width = 252;
                line.Width = 197;
                transicionMenu2.Show(MenuSide);
            }
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Paciente p = new Paciente();
            p.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Medico m = new Medico();
            m.Show();
        }
        private void BtnInventario_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Inventario i = new Inventario();
            i.Show();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Corte c = new Corte();
            c.Show();
        }


    }
}
