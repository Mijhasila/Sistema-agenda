using APP__Agenda;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CapaDatos
{
    public class CD_Categoria
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmd;
        private SqlDataAdapter daAdaptador;
        private SqlDataReader daReader;
        private Categoria categoria;
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
                    CommandText = string.Format("select id, nombre, idUsuario from categoria {0}", cadenaOpcion),
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

        public Categoria Consultar(string idcategoria)
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("select id, nombre from categoria where id = '" + idcategoria + "';")
                };
                daReader = cmd.ExecuteReader();

                if (daReader.Read())
                {
                    categoria = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(daReader["id"].ToString()),
                        Nombre = daReader["nombre"].ToString(),
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
            return categoria;
        }
        public bool RegistrarCategoria(Categoria Categorias, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearCategoria", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Nombre", Categorias.Nombre);
                cmd.Parameters.AddWithValue("IdUsuarioCreador", Categorias.oUsuarios.IdUsuario);
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
        public bool EditarCategoria(Categoria Categorias, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarCategoria", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("ID", Categorias.IdCategoria);
                cmd.Parameters.AddWithValue("NOMBRE", Categorias.Nombre);
                cmd.Parameters.AddWithValue("ID_USUARIO", Categorias.oUsuarios.IdUsuario);
                /*cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;*/
               
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                //Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                //Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                Respuesta = true;
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
        public bool EliminarCategoria(Categoria Categorias, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje=string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarCategoria", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdCategoria", Categorias.IdCategoria);
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
