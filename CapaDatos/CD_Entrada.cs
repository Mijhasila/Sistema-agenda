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
