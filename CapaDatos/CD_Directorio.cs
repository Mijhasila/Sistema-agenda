using APP__Agenda;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Directorio
    {
        readonly Conexion Obj_conexion = new Conexion();
        private DataTable dtDatos;
        private SqlCommand cmdComando;
        private SqlDataAdapter daAdaptador;
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
                    CommandText = string.Format("select id, nombre1, nombre2, apellidoPaterno, apellidoMaterno, alias, direccion, telefono, email, notasAdicionales, idUsuario, id_Entrada from Directorio")
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
        public bool RegistrarDirectorio(Directorio Directorios, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("CrearDirectorio", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Nombre1", Directorios.Nombre1);
                cmd.Parameters.AddWithValue("Nombre2", Directorios.Nombre2);
                cmd.Parameters.AddWithValue("ApellidoPaterno", Directorios.Apellido1);
                cmd.Parameters.AddWithValue("ApellidoMaterno", Directorios.Apellido2);
                cmd.Parameters.AddWithValue("Alias", Directorios.Alias);
                cmd.Parameters.AddWithValue("Direccion", Directorios.Direccion);
                cmd.Parameters.AddWithValue("Telefono", Directorios.Telefono);
                cmd.Parameters.AddWithValue("Email", Directorios.Correo);
                cmd.Parameters.AddWithValue("NotasAdicionales", Directorios.NotasAdicionales);
                cmd.Parameters.AddWithValue("IdUsuarioCreador", Directorios.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("IdEntrada", Directorios.oEntrada.IdEntrada);
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
        public bool EditarDirectorio(Directorio Directorios, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("EditarDirectorio", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("Id", Directorios.IdDirectorio);
                cmd.Parameters.AddWithValue("Nombre1", Directorios.Nombre1);
                cmd.Parameters.AddWithValue("Nombre2", Directorios.Nombre2);
                cmd.Parameters.AddWithValue("ApellidoPaterno", Directorios.Apellido1);
                cmd.Parameters.AddWithValue("ApellidoMaterno", Directorios.Apellido2);
                cmd.Parameters.AddWithValue("Alias", Directorios.Alias);
                cmd.Parameters.AddWithValue("Direccion", Directorios.Direccion);
                cmd.Parameters.AddWithValue("Telefono", Directorios.Telefono);
                cmd.Parameters.AddWithValue("Email", Directorios.Correo);
                cmd.Parameters.AddWithValue("NotasAdicionales", Directorios.NotasAdicionales);
                cmd.Parameters.AddWithValue("Id_Usuario", Directorios.oUsuarios.IdUsuario);
                cmd.Parameters.AddWithValue("Id_Entrada", Directorios.oEntrada.IdEntrada);

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
        public bool EliminarDirectorio(Directorio Directorios, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlCommand cmd = new SqlCommand("EliminarDirectorio", Obj_conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("IdDirectorio", Directorios.IdDirectorio);
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
