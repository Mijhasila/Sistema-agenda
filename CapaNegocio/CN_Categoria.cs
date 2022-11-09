using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using APP__Agenda;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria ObjCategoria = new CD_Categoria();
        public bool Listar()
        {
            return ObjCategoria.Listar();
        }
        public bool RegistrarCategoria(Categoria categoria, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (categoria.Nombre == "")
            {
                Mensaje += "Por favor llene el campo nombre\n";
            }
            if (categoria.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un IdUsuario menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjCategoria.RegistrarCategoria(categoria, out Mensaje);
            }
        }
        public bool EditarCategoria(Categoria categoria, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (categoria.Nombre == "")
            {
                Mensaje += "Por favor llene el campo nombre\n";
            }
            if (categoria.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un IdUsuario menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjCategoria.EditarCategoria(categoria, out Mensaje);
            }
        }
        public bool EliminarCategoria(Categoria categoria, out string Mensaje)
        {
            return ObjCategoria.EliminarCategoria(categoria, out Mensaje);
        }



        /*public bool CrearCategoria(Categoria categoria)
        {
            bool Respuesta = false;

            /*string cadena = @"Data Source = SQL8001.site4now.net;Initial Catalog = db_a8dd6e_agenda;User Id = db_a8dd6e_agenda_admin;Password=farem2023";
            SqlConnection sqlConnection = new SqlConnection(@cadena);
            //SqlConnection connection = sqlConnection;
            string query = "INSERT INTO Categoria (nombre, idUsuario) VALUES(@Categoria, @Id)";
            //SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", IdUsuario);
            command.Parameters.AddWithValue("@Categoria", nombre);

            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("INSERT INTO categoria (Descripcion, IdUsuario) VALUES(@Categoria, @Id) {0}", cadenaOpcion)
                };
                cmd.Parameters.AddWithValue("@Categoria", categoria.nombre);
                cmd.Parameters.AddWithValue("@Id", categoria.oUsuarios.Idusuario);
                cmd.ExecuteNonQuery();

                oError = false;
                Respuesta = true;
            }
            catch (SqlException error)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + error.Message);
                return Respuesta;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Respuesta;
        }
        public bool ActualizarCategoria(Categoria categoria)
        {
            bool Respuesta = false;
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("update categoria set nombre = @Categoria, idUsuario = @Id where id = '" + categoria.IdCategoria + "';{0}", cadenaOpcion)
                };
                cmd.Parameters.AddWithValue("@Categoria", categoria.nombre);
                cmd.Parameters.AddWithValue("@Id", categoria.oUsuarios.Idusuario);
                cmd.ExecuteNonQuery();
                oError = false;
                Respuesta = true;
            }
            catch (SqlException error)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + error.Message);
                return Respuesta;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Respuesta;
        }
        public bool EliminarCategoria(int idcategoria)
        {
            bool Respuesta = false;
            try
            {
                Obj_conexion.AbrirConexion();
                cmd = new SqlCommand
                {
                    Connection = Obj_conexion.conexion,
                    CommandType = CommandType.Text,
                    CommandText = string.Format("delete from categoria where id = '" + idcategoria + "';{0}", cadenaOpcion)
                };
                cmd.ExecuteNonQuery();
                oError = false;
                Respuesta = true;

            }
            catch (SqlException error)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + error.Message);
                return Respuesta;
            }
            finally
            {
                Obj_conexion.CerrarConexion();
            }
            return Respuesta;
        }*/
    }
}
