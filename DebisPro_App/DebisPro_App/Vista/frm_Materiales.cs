using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DebisPro_App.Vista
{
    public partial class frm_Materiales : Form
    {
        //Modelo.Conexion conexion = new Modelo.Conexion();
        Modelo.list_Materiales lista_materiales = new Modelo.list_Materiales();
        
        public frm_Materiales()
        {
            InitializeComponent();
        }

        
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frm_Materiales_Load(object sender, EventArgs e)
        {
            lista_materiales.List_Materiales(dgv_materiales);
        }
    }
}
