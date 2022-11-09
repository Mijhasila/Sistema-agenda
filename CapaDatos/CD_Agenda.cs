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
    public class CD_Agenda
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmd;
        private SqlDataAdapter daAdaptador;
        public Agenda Agenda;
        public string cadenaOpcion { get; set; }
        public string dError { get; set; }
        public bool oError { get; set; }
        public DataTable Datos { get; set; }

        public bool Listar()
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("SELECT a.id as id,a.idUsuario as idUsuario,CONCAT(u.nombre1,' ',u.nombre2,' ',u.apellido1,' ',u.apellido2) as Usuario from dbo.Agenda a inner join dbo.Usuarios u on a.idUsuario=u.id")
                };
                daAdaptador = new SqlDataAdapter();
                daAdaptador.SelectCommand = cmd;
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
        public bool RegistrarAgenda(Agenda Agendas, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearAgenda", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdUsuario", Agendas.oUsuarios.IdUsuario);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + ex.Message);
                return respuesta;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return respuesta;
        }
        public bool EditarAgenda(Agenda Agendas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarAgenda", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdAgenda", Agendas.IdAgenda);
                cmd.Parameters.AddWithValue("IdUsuario", Agendas.oUsuarios.IdUsuario);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + ex.Message);
                return Respuesta;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Respuesta;

        }
        public bool EliminarAgenda(Agenda Agendas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarAgenda", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdAgenda", Agendas.IdAgenda);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + ex.Message);
                return Respuesta;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Respuesta;
        }
    }
}
