using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        //internal SqlConnection conexion = new SqlConnection("Data Source=JESSERHERNANDEZ\\SQLEXPRESS;Initial Catalog=SistemaAgenda;Integrated Security=True");

        public SqlConnection conexion = new SqlConnection("Data Source = SQL8001.site4now.net;Initial Catalog = db_a8dd6e_agenda;User Id = db_a8dd6e_agenda_admin;Password=farem2023");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
