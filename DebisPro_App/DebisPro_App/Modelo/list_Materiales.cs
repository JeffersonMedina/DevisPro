using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DebisPro_App.Modelo
{
    class list_Materiales
    {
        Modelo.Conexion conexion = new Modelo.Conexion();

        public void List_Materiales(DataGridView grid_materiales)
        {
            if (conexion.Abrir_Conexion()==true)
            {
                MySqlCommand consulta_materiales = new MySqlCommand("SELECT * FROM devispro.materiales;",conexion.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta_materiales);

                DataTable tabla_materiales = new DataTable();
                da.Fill(tabla_materiales);

                grid_materiales.DataSource = tabla_materiales;
            }
        }

    }
}
