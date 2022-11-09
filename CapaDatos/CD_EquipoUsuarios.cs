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
                        Tipo = Convert.ToBoolean(daReader["nombre"].ToString()),
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
