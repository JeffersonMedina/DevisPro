using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebisPro_App.Vista
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void icon_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icon_restaurar.Visible = true;
            icon_maximizar.Visible = false;
        }

        private void icon_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icon_restaurar.Visible = false;
            icon_maximizar.Visible = true;
        }

        private void icon_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void abrir_Formulario(object form_Hijo)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = form_Hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrir_Formulario(new frm_Registro());
        }

        private void btn_materiales_Click(object sender, EventArgs e)
        {
            abrir_Formulario(new frm_Materiales());
        }
    }
}
