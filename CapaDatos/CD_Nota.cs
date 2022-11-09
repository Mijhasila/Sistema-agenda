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
    public class CD_Nota
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
                    CommandText = string.Format("select id, idUsuario, id_categoria, titulo, descripcion, id_Entrada from Notas {0}", cadenaOpcion)
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
        public bool RegistrarNota(Notas Notas, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearNota", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdUsuarioCreador", Notas.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("IdCategoria", Notas.oCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("Titulo", Notas.Titulo);
                cmd.Parameters.AddWithValue("Descripcion", Notas.Descripcion);
                cmd.Parameters.AddWithValue("IdEntrada", Notas.oEntrada.IdEntrada);
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
        public bool EditarNota(Notas Notas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarNotas", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Id", Notas.IdNotas);
                cmd.Parameters.AddWithValue("Titulo", Notas.Titulo);
                cmd.Parameters.AddWithValue("Id_Categoria", Notas.oCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("Descripcion", Notas.Descripcion);
                cmd.Parameters.AddWithValue("Id_Entrada", Notas.oEntrada.IdEntrada);
                cmd.Parameters.AddWithValue("Id_Usuario", Notas.oUsuarios.IdUsuario);

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
        public bool EliminarNota(Notas Notas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlCommand cmd = new SqlCommand("EliminarNota", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdNota", Notas.IdNotas);
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
