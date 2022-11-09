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
    public partial class ModalUsuario : Form
    {
        readonly CD_Usuario ObjUsuarios = new CD_Usuario();
        readonly Conexion Obj_conexion = new Conexion();
        public int IdUsuario { get; private set; }
        public string Usuario { get; private set; }

        public ModalUsuario()
        {
            InitializeComponent();
        }

        private void ModalUsuario_Load(object sender, EventArgs e)
        {
            TxtUsuario.Select();
            try
            {
                if (ObjUsuarios.Listar())
                {
                    GridViewUsuarios.DataSource = ObjUsuarios.Datos;
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
        private void GridViewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuario = Convert.ToInt32(GridViewUsuarios.CurrentRow.Cells["id"].Value);
            Usuario = GridViewUsuarios.CurrentRow.Cells["nombre1"].Value.ToString() +" "+ GridViewUsuarios.CurrentRow.Cells["nombre2"].Value.ToString() + " " + GridViewUsuarios.CurrentRow.Cells["apellido1"].Value.ToString() + " " + GridViewUsuarios.CurrentRow.Cells["apellido2"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            string query = "select id, nombre1, nombre2, apellido1, apellido2, sexo, direccion, cedula, telefono," +
                " correo, idUsuario from Usuarios where (nombre1 LIKE'%" + TxtUsuario.Text + "%' or apellido1 LIKE'%" + TxtUsuario.Text + "%')";

            SqlDataAdapter ada = new SqlDataAdapter(query, Obj_conexion.AbrirConexion());
            DataSet data = new DataSet();
            ada.Fill(data, "Usuarios");
            GridViewUsuarios.DataSource = data;
            GridViewUsuarios.DataMember = "Usuarios";
            Obj_conexion.CerrarConexion();
        }

        private void GridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void GridViewUsuarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuario = Convert.ToInt32(GridViewUsuarios.CurrentRow.Cells["id"].Value);
            Usuario = GridViewUsuarios.CurrentRow.Cells["nombre1"].Value.ToString() + " " + GridViewUsuarios.CurrentRow.Cells["nombre2"].Value.ToString() + " " + GridViewUsuarios.CurrentRow.Cells["apellido1"].Value.ToString() + " " + GridViewUsuarios.CurrentRow.Cells["apellido2"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
