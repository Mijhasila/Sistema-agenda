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
    public class CD_Usuario
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmd;
        private SqlDataAdapter daAdaptador;
        private SqlDataReader daReader;
        private Usuarios usuarios;

        public string cadenaOpcion { get; set; }
        public DataTable Datos { get; set; }


       /* public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();

            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("Select U.IdUsuario, U.NumeroDocumento, U.Clave, U.Nombres, U.ApellidoPaterno, U.ApellidoMaterno, U.Sexo, U.Direccion, U.Cedula, U.Telefono, U.Correo, r.IdRol, r.Descripcion from Usuario U inner join Rol r on U.IdRol = r.IdRol {0}", cadenaOpcion)
                };
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Usuarios()
                        {
                            IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                            NumeroDocumento = dr["NumeroDocumento"].ToString(),
                            Clave = dr["Clave"].ToString(),
                            Nombres = dr["Nombres"].ToString(),
                            ApellidoPaterno = dr["ApellidoPaterno"].ToString(),
                            ApellidoMaterno = dr["ApellidoMaterno"].ToString(),
                            Sexo = dr["Sexo"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Cedula = dr["Cedula"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString(),
                        });
                    }
                }
            }
            catch (Exception e)
            {
                string Mensaje = e.Message;
                lista = new List<Usuarios>();
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return lista;
        }*/

        public bool Listar()
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("select id, nombre1, nombre2, apellido1, apellido2, sexo, direccion, cedula, telefono, correo, idUsuario from Usuarios {0}", cadenaOpcion)
                };
                daAdaptador = new SqlDataAdapter();
                daAdaptador.SelectCommand = cmd;
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
        public Usuarios Consultar(string idusuario)
        {
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("select id, nombre1, nombre2, apellido1, apellido2 from Usuarios where id = '" + idusuario + "';")
                };
                daReader = cmd.ExecuteReader();

                if (daReader.Read())
                {
                    usuarios = new Usuarios()
                    {
                        IdUsuario = Convert.ToInt32(daReader["id"].ToString()),
                        Nombre1 = daReader["nombre1"].ToString(),
                        Nombre2 = daReader["nombre2"].ToString(),
                        Apellido1 = daReader["apellido1"].ToString(),
                        Apellido2 = daReader["apellido2"].ToString(),
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
            return usuarios;
        }
        public bool RegistrarUsuarios(Usuarios Usuarioss, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearUsuario", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Nombre1", Usuarioss.Nombre1);
                cmd.Parameters.AddWithValue("Nombre2", Usuarioss.Nombre2);
                cmd.Parameters.AddWithValue("ApellidoPaterno", Usuarioss.Apellido1);
                cmd.Parameters.AddWithValue("ApellidoMaterno", Usuarioss.Apellido2);
                cmd.Parameters.AddWithValue("Sexo", Usuarioss.Sexo);
                cmd.Parameters.AddWithValue("Direccion", Usuarioss.Direccion);
                cmd.Parameters.AddWithValue("Cedula", Usuarioss.Cedula);
                cmd.Parameters.AddWithValue("Telefono", Usuarioss.Telefono);
                cmd.Parameters.AddWithValue("Email", Usuarioss.Correo);
                cmd.Parameters.AddWithValue("IdUsuarioCreador", Usuarioss.IdUsuarioCreador);
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
        public bool EditarUsuarios(Usuarios Usuarioss, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarUsuario", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Id", Usuarioss.IdUsuario);
                cmd.Parameters.AddWithValue("Nombre1", Usuarioss.Nombre1);
                cmd.Parameters.AddWithValue("Nombre2", Usuarioss.Nombre2);
                cmd.Parameters.AddWithValue("Apellido1", Usuarioss.Apellido1);
                cmd.Parameters.AddWithValue("Apellido2", Usuarioss.Apellido2);
                cmd.Parameters.AddWithValue("Sexo", Usuarioss.Sexo);
                cmd.Parameters.AddWithValue("Direccion", Usuarioss.Direccion);
                cmd.Parameters.AddWithValue("Cedula", Usuarioss.Cedula);
                cmd.Parameters.AddWithValue("Telefono", Usuarioss.Telefono);
                cmd.Parameters.AddWithValue("Correo", Usuarioss.Correo);
                cmd.Parameters.AddWithValue("Id_Usuario", Usuarioss.IdUsuarioCreador);

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
                Respuesta = false;
                MessageBox.Show("Ocurrio el siguiente error: " + ex.Message);
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Respuesta;
        }
        public bool EliminarUsuarios(Usuarios Usuarioss, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlCommand cmd = new SqlCommand("EliminarUsuario", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdUsuario", Usuarioss.IdUsuario);
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
            return Respuesta;
        }
    }
}
