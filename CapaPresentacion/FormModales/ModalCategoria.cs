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
    public partial class ModalCategoria : Form
    {
        readonly CD_Categoria ObjCategorias = new CD_Categoria();
        readonly Conexion Obj_conexion = new Conexion();
        public int IdCategoria { get; private set; }
        public string Categoria { get; private set; }

        public ModalCategoria()
        {
            InitializeComponent();
        }

        private void ModalCategoria_Load(object sender, EventArgs e)
        {
            TxtCategoria.Select();
            try
            {
                if (ObjCategorias.Listar())
                {
                    GridViewCategorias.DataSource = ObjCategorias.Datos;
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

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {
            string query = "select id, nombre, idUsuario from categoria where (nombre LIKE'%" + TxtCategoria.Text + "%')";

            SqlDataAdapter ada = new SqlDataAdapter(query, Obj_conexion.AbrirConexion());
            DataSet data = new DataSet();
            ada.Fill(data, "categoria");
            GridViewCategorias.DataSource = data;
            GridViewCategorias.DataMember = "categoria";
            Obj_conexion.CerrarConexion();
        }
        private void GridViewCategorias_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IdCategoria = Convert.ToInt32(GridViewCategorias.CurrentRow.Cells["id"].Value);
            Categoria = GridViewCategorias.CurrentRow.Cells["nombre"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GridViewCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCategoria = Convert.ToInt32(GridViewCategorias.CurrentRow.Cells["id"].Value);
            Categoria = GridViewCategorias.CurrentRow.Cells["nombre"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
