using APP__Agenda;
using CapaEntidad;
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
    public class CD_EquipoUsuarios
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdaptador;
        private SqlDataReader daReader;
        private EquiposUsuarios equipo;
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
                    CommandText = string.Format("select id, tipo, IdUsuario, id_usuario, id_equipo from equipos_de_ususarios")
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
        public bool RegistrarEquipoUsuarios(EquiposUsuarios EU, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearEquipoUsuarios", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Tpo", EU.Tipo);
                cmd.Parameters.AddWithValue("idusuariocreador", EU.IdUsuario);
                cmd.Parameters.AddWithValue("idusuarioperteneciente", EU.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("idequipo", EU.oEquipos.IdEquipo);
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
        public bool EditarEquiposUsuarios(EquiposUsuarios EU, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarEquiposDeUsuarios", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Id", EU.IdEquipoUsuario);
                cmd.Parameters.AddWithValue("tipo", EU.Tipo);
                cmd.Parameters.AddWithValue("id_usuario", EU.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("idusuario", EU.IdUsuario);
                cmd.Parameters.AddWithValue("idequipo", EU.oEquipos.IdEquipo);
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
        public bool EliminarEquiposUsuarios(EquiposUsuarios EU, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlCommand cmd = new SqlCommand("EliminarEquipoUsuario", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("idEquipoUsuario", EU.IdEquipoUsuario);
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
        public EquiposUsuarios Consultar(int idEquipo)
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmdComando = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("select id, tipo , IdUsuario, id_usuario, id_equipo, from equipos_de_ususarios where id = '" + idEquipo + "';")
                };
                daReader = cmdComando.ExecuteReader();

                if (daReader.Read())
                {
                    equipo = new EquiposUsuarios()
                    {
                        IdEquipoUsuario = Convert.ToInt32(daReader["id"].ToString()),
                        Tipo = Convert.ToInt32(daReader["nombre"].ToString()),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(daReader["idUsuario"].ToString()) },
                        IdUsuario = Convert.ToInt32(daReader["id_usuario"].ToString()),
                        oEquipos = new Equipos { IdEquipo = Convert.ToInt32(daReader["id_equipo"].ToString()) },
                    };
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
            return equipo;
        }

    }
}
