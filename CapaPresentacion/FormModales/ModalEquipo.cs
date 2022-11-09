using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormModales
{
    public partial class ModalEquipo : Form
    {
        readonly CD_Equipo ObjEquipo = new CD_Equipo();
        readonly Conexion Obj_conexion = new Conexion();
        public int IdEquipo { get; private set; }
        public string Equipo { get; private set; }
        public ModalEquipo()
        {
            InitializeComponent();
        }
        private void ModalEquipo_Load(object sender, EventArgs e)
        {
            TxtEquipo.Select();
            try
            {
                if (ObjEquipo.Listar())
                {
                    GridViewEquipo.DataSource = ObjEquipo.Datos;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void TxtEquipo_TextChanged(object sender, EventArgs e)
        {
            string query = "select id, nombre from Equipos where (nombre LIKE'%" + TxtEquipo.Text + "%' or id LIKE'%" + TxtEquipo.Text + "%')";

            SqlDataAdapter ada = new SqlDataAdapter(query, Obj_conexion.AbrirConexion());
            DataSet data = new DataSet();
            ada.Fill(data, "equipos_de_ususarios");
            GridViewEquipo.DataSource = data;
            GridViewEquipo.DataMember = "equipos_de_ususarios";
            Obj_conexion.CerrarConexion();
        }

        private void GridViewEquipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdEquipo = Convert.ToInt32(GridViewEquipo.CurrentRow.Cells["id"].Value);
            Equipo = GridViewEquipo.CurrentRow.Cells["nombre"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
