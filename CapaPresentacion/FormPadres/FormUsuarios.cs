using APP__Agenda;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FormHijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormPadres
{
    public partial class FormUsuarios : Form
    {
        readonly CD_Usuario ObjUsuarios = new CD_Usuario();
        readonly CN_Usuario ObjUsuario = new CN_Usuario();

        private static Usuarios UsuarioActual { get; set; }
        public FormUsuarios()
        {
            InitializeComponent();
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            try
            {
                if (ObjUsuarios.Listar())
                {
                    GridViewUsuarios.DataSource = ObjUsuarios.Datos;
                    GridViewUsuarios.Columns["Editar"].DisplayIndex = 12;
                    GridViewUsuarios.Columns["Eliminar"].DisplayIndex = 12;
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

        private void BtnCrearNuevo_Click(object sender, EventArgs e)
        {
            using (var Usuario = new CrearUsuario())
            {
                var result = Usuario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = ObjUsuario.RegistrarUsuario(Usuario.ObjUsuario, out string mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Usuario Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GridViewUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Editar2.Width;
                var h = Properties.Resources.Editar2.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Editar2, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Eliminar2.Width;
                var h = Properties.Resources.Eliminar2.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Eliminar2, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void GridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    using (var Usuario = new CrearUsuario())
                    {
                        DataGridViewRow row = GridViewUsuarios.Rows[indice];
                        Usuario.TxtIdUsuario.Text = row.Cells["id"].Value.ToString();
                        Usuario.TxtUsuarioCreador.Text = row.Cells["idUsuario"].Value.ToString();
                        Usuario.TxtPrimerNombre.Text = row.Cells["nombre1"].Value.ToString();
                        Usuario.TxtSegundoNombre.Text = row.Cells["nombre2"].Value.ToString();
                        Usuario.TxtApellidoPaterno.Text = row.Cells["apellido1"].Value.ToString();
                        Usuario.TxtApellidoMaterno.Text = row.Cells["apellido2"].Value.ToString();
                        Usuario.TxtSexo.Text = row.Cells["sexo"].Value.ToString();
                        Usuario.TxtDireccion.Text = row.Cells["direccion"].Value.ToString();
                        Usuario.TxtCedula.Text = row.Cells["cedula"].Value.ToString();
                        Usuario.TxtTelefono.Text = row.Cells["telefono"].Value.ToString();
                        Usuario.TxtEmail.Text = row.Cells["correo"].Value.ToString();

                        var result = Usuario.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CN_Usuario().EditarUsuario(Usuario.ObjUsuario, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Usuario Actualizado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el Usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = GridViewUsuarios.Rows[indice];

                        Usuarios Usuario = new Usuarios()
                        {
                            IdUsuario = Convert.ToInt32(row.Cells["id"].Value),
                        };
                        bool Respuesta = new CN_Usuario().EliminarUsuario(Usuario, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Usuario Eliminado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
