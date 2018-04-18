using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DebisPro_App.Modelo
{
    public class list_Materiales
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public string unidad { get; set; }
        public decimal p_unitario { get; set; }

        public list_Materiales()
        {

        }

        public list_Materiales(int list_codigo, string list_descripcion, string list_unidad, decimal list_punitario)
        {
            this.codigo = list_codigo;
            this.descripcion = list_descripcion;
            this.unidad = list_unidad;
            this.p_unitario = list_punitario;
        }

        public static IList<list_Materiales> Buscar(MySqlConnection conexion, int list_codigo, string list_descripcion)
        {
            List<list_Materiales> lista = new List<list_Materiales>();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT cod,nobre,unidad,precio FROM devispro WHERE cod LIKE ('%0%') AND nombre ('%1%')",list_codigo,list_descripcion));
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                list_Materiales l_materiales = new list_Materiales();
                l_materiales.codigo = reader.GetInt32(0);
                l_materiales.descripcion = reader.GetString(1);
                l_materiales.unidad = reader.GetString(2);
                l_materiales.p_unitario = reader.GetDecimal(3);

                lista.Add(l_materiales);
            }
            return lista;
        }
    }
}
