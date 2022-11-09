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
    public class CD_Tarea
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdaptador;
        public string cadenaOpcion { get; set; }
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
                    CommandText = string.Format("select id, idUsuario, prioridad, id_categoria, fecha_Terminacion, descripcion, estado, indicador_Cumplimiento, id_Entrada from Lista_Tareas {0}", cadenaOpcion)
                };
                daAdaptador = new SqlDataAdapter
                {
                    SelectCommand = cmdComando
                };
                dtDatos = new DataTable();
                daAdaptador.Fill(dtDatos);
                Datos = dtDatos.Copy();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + e.Message);
                return false;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
        }
        public bool RegistrarTarea(Tareas Tareas, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearTarea", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdUsuarioCreador", Tareas.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("Prioridad", Tareas.Prioridad);
                cmd.Parameters.AddWithValue("IdCategoria", Tareas.oCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("FechaTerminacion", Tareas.FechaTerminacion);
                cmd.Parameters.AddWithValue("Descripcion", Tareas.Descripcion);
                cmd.Parameters.AddWithValue("Estado", Tareas.Estado);
                cmd.Parameters.AddWithValue("IndicadorCumplimiento", Tareas.IndicadorCumplimiento);
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
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return respuesta;
        }
        public bool EditarTarea(Tareas Tareas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarListaTareas", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Id", Tareas.IdTarea);
                cmd.Parameters.AddWithValue("IDUSUARIO", Tareas.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("Prioridad", Tareas.Prioridad);
                cmd.Parameters.AddWithValue("IdCategoria", Tareas.oCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("FECHA_TERMINACION", Tareas.FechaTerminacion);
                cmd.Parameters.AddWithValue("Descripcion", Tareas.Descripcion);
                cmd.Parameters.AddWithValue("Estado", Tareas.Estado);
                cmd.Parameters.AddWithValue("INDICADOR_CUMPLIMIENTO", Tareas.IndicadorCumplimiento);
                cmd.Parameters.AddWithValue("identrada", Tareas.oEntradas.IdEntrada);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                /*cmd.Parameters.Add("IdAutorResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();*/
                Respuesta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + ex.Message);
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Respuesta;
        }
        public bool EliminarTarea(Tareas Tareas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlCommand cmd = new SqlCommand("EliminarTarea", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdTarea", Tareas.IdTarea);
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
            }
            return Respuesta;
        }
    }
}