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
    public class CD_Entrada
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdaptador;
        private SqlDataReader daReader;
        private Entradas Entrada;
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
                    CommandText = string.Format("select id, idUsuario , Titulo, Fecha, Hora, Tipo, Observaciones from Entradas {0}", cadenaOpcion),
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
                return false;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
        }
        public bool RegistrarEntrada(Entradas entradas, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearEntrada", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdUsuarioCreador", entradas.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("Titulo", entradas.Titulo);
                cmd.Parameters.AddWithValue("fecha", entradas.Fecha);
                cmd.Parameters.AddWithValue("hora", entradas.Hora);
                cmd.Parameters.AddWithValue("tipo", entradas.Tipo);
                cmd.Parameters.AddWithValue("Observaciones", entradas.Observaciones);
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
        public bool EditarEntrada(Entradas Entradas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarEntradas", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Id", Entradas.IdEntrada);
                cmd.Parameters.AddWithValue("IDUSUARIO", Entradas.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("Titulo", Entradas.Titulo);
                cmd.Parameters.AddWithValue("Fecha", Entradas.Fecha);
                cmd.Parameters.AddWithValue("Hora", Entradas.Hora);
                cmd.Parameters.AddWithValue("Tipo", Entradas.Tipo);
                cmd.Parameters.AddWithValue("Observaciones", Entradas.Observaciones);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

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
        public Entradas Consultar(string idEntrada)
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmdComando = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("select id, Titulo from Entradas where id = '" + idEntrada + "';")
                };
                daReader = cmdComando.ExecuteReader();

                if (daReader.Read())
                {
                    Entrada = new Entradas()
                    {
                        IdEntrada = Convert.ToInt32(daReader["id"].ToString()),
                        Titulo = daReader["Titulo"].ToString(),
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
            return Entrada;
        }
        
    }
}
