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
    public partial class ModalEntrada : Form
    {
        readonly CD_Entrada ObjEntradas = new CD_Entrada();
        readonly Conexion Obj_conexion = new Conexion();
        public int IdEntrada { get; private set; }
        public string Entrada { get; private set; }
        public ModalEntrada()
        {
            InitializeComponent();
        }

        private void ModalEntrada_Load(object sender, EventArgs e)
        {
            TxtEntrada.Select();
            try
            {
                if (ObjEntradas.Listar())
                {
                    GridViewEntradas.DataSource = ObjEntradas.Datos;
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
        private void TxtEntrada_TextChanged(object sender, EventArgs e)
        {
            string query = "select id, idUsuario , Titulo, Fecha, Hora, Tipo, Observaciones from Entradas " +
                " where (Titulo LIKE'%" + TxtEntrada.Text + "%' or idUsuario LIKE'%" + TxtEntrada.Text + "%')";

            SqlDataAdapter ada = new SqlDataAdapter(query, Obj_conexion.AbrirConexion());
            DataSet data = new DataSet();
            ada.Fill(data, "Entradas");
            GridViewEntradas.DataSource = data;
            GridViewEntradas.DataMember = "Entradas";
            Obj_conexion.CerrarConexion();
        }
        private void GridViewEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdEntrada = Convert.ToInt32(GridViewEntradas.CurrentRow.Cells["id"].Value);
            Entrada = GridViewEntradas.CurrentRow.Cells["Titulo"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GridViewEntradas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IdEntrada = Convert.ToInt32(GridViewEntradas.CurrentRow.Cells["id"].Value);
            Entrada = GridViewEntradas.CurrentRow.Cells["Titulo"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
