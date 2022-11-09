using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP__Agenda;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Filtros
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmd;
        private SqlDataAdapter daAdaptador;
        private SqlDataReader daReader;
        private Categoria categoria;
        public DataTable Datos { get; set; }
        public DataTable FiltroRango(string fechainicio, string fechafinal)
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("SELECT dbo.calendario.id as IdCalendario, dbo.Entradas.id as IdEntrada, dbo.Entradas.idUsuario, dbo.Entradas.Titulo, dbo.Entradas.Fecha, dbo.Entradas.Hora, dbo.Entradas.Tipo, dbo.Entradas.Observaciones FROM dbo.calendario INNER JOIN dbo.Entradas ON dbo.calendario.id_Entrada = dbo.Entradas.id where dbo.Entradas.Fecha between '" + fechainicio + "'and'" + fechafinal + "';"),
                };
                daAdaptador = new SqlDataAdapter();
                daAdaptador.SelectCommand = cmd;
                dtDatos = new DataTable();
                daAdaptador.Fill(dtDatos);
                Datos = dtDatos.Copy();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + e.Message);
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Datos;
        }
        public DataTable FiltroDesde(string fechainicio)
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("SELECT dbo.calendario.id as IdCalendario, dbo.Entradas.id as IdEntrada, dbo.Entradas.idUsuario, dbo.Entradas.Titulo, dbo.Entradas.Fecha, dbo.Entradas.Hora, dbo.Entradas.Tipo, dbo.Entradas.Observaciones FROM dbo.calendario INNER JOIN dbo.Entradas ON dbo.calendario.id_Entrada = dbo.Entradas.id where dbo.Entradas.Fecha >= '" + fechainicio + "';"),
                };
                daAdaptador = new SqlDataAdapter();
                daAdaptador.SelectCommand = cmd;
                dtDatos = new DataTable();
                daAdaptador.Fill(dtDatos);
                Datos = dtDatos.Copy();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + e.Message);
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Datos;
        }
    }
}
