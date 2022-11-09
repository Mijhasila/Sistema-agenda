using APP__Agenda;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Calendario
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdaptador;
        private SqlDataReader daReader;
        private Calendario calendario;
        public string cadenaOpcion { get; set; }
        public string dError { get; set; }
        public bool oError { get; set; }
        public DataTable Datos { get; set; }

        public bool Listar()
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmdComando = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("SELECT dbo.calendario.id as IdCalendario, dbo.Entradas.id AS IdEntrada, dbo.Entradas.idUsuario as IdUsuario, dbo.Entradas.Titulo, dbo.Entradas.Fecha, dbo.Entradas.Hora, dbo.Entradas.Tipo, dbo.Entradas.Observaciones FROM dbo.calendario INNER JOIN dbo.Entradas ON dbo.calendario.id_Entrada = dbo.Entradas.id")
                };
                daAdaptador = new SqlDataAdapter();
                daAdaptador.SelectCommand = cmdComando;
                dtDatos = new DataTable();
                daAdaptador.Fill(dtDatos);
                Datos = dtDatos.Copy();
                oError = false;
                return true;
            }
            catch (Exception e)
            {
                oError = true;
                dError = e.Message;
                return false;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
        }
        public Calendario Consultar(int idcalendario)
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmdComando = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("select * from calendario where id = '" + idcalendario + "';")
                };
                daReader = cmdComando.ExecuteReader();

                if (daReader.Read())
                {
                    calendario = new Calendario()
                    {
                        IdCalendario = Convert.ToInt32(daReader["id"].ToString()),
                        oUsuarios = new Usuarios {IdUsuario = Convert.ToInt32(daReader["idUsuario"].ToString()) } ,
                        IdEntrada = Convert.ToInt32(daReader["id_Entrada"].ToString()),
                    };
                    oError = false;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + error.Message);
                return null;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return calendario;
        }
    }
}
