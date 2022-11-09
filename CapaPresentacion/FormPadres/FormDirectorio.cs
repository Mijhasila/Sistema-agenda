using APP__Agenda;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FormHijos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.FormPadres
{
    public partial class FormDirectorio : Form
    {
        readonly CD_Directorio Objdirectorio = new CD_Directorio();
        readonly CN_Directorio ObjDirectorio = new CN_Directorio();
        public FormDirectorio()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                if (Objdirectorio.Listar())
                {
                    GridViewDirectorio.DataSource = Objdirectorio.Datos;
                    GridViewDirectorio.Columns["Editar"].DisplayIndex = 13;
                    GridViewDirectorio.Columns["Eliminar"].DisplayIndex = 13;
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
        private void FormDirectorio_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnCrearNuevo_Click(object sender, EventArgs e)
        {
            using (var Directorio = new CrearDirectorio())
            {
                var result = Directorio.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = ObjDirectorio.RegistrarDirectorio(Directorio.ObjDirectorio, out string mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Directorio Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GridViewDirectorio_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridViewDirectorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewDirectorio.Columns[e.ColumnIndex].Name == "Editar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    using (var Directorio = new CrearDirectorio())
                    {
                        DataGridViewRow row = GridViewDirectorio.Rows[indice];
                        Directorio.TxtIdDirectorio.Text = row.Cells["id"].Value.ToString();
                        Directorio.TxtIdUsuario.Text = row.Cells["idUsuario"].Value.ToString();
                        Directorio.TxtIdEntrada.Text = row.Cells["iD_Entrada"].Value.ToString();
                        Directorio.TxtPrimerNombre.Text = row.Cells["nombre1"].Value.ToString();
                        Directorio.TxtSegundoNombre.Text = row.Cells["nombre2"].Value.ToString();
                        Directorio.TxtApellidoPaterno.Text = row.Cells["apellidoPaterno"].Value.ToString();
                        Directorio.TxtApellidoMaterno.Text = row.Cells["apellidoMaterno"].Value.ToString();
                        Directorio.TxtAlias.Text = row.Cells["alias"].Value.ToString();
                        Directorio.TxtDireccion.Text = row.Cells["direccion"].Value.ToString();
                        Directorio.TxtEmail.Text = row.Cells["email"].Value.ToString();
                        Directorio.TxtTelefono.Text = row.Cells["telefono"].Value.ToString();
                        Directorio.TxtNotasAdicionales.Text = row.Cells["notasAdicionales"].Value.ToString();

                        var result = Directorio.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CN_Directorio().EditarDirectorio(Directorio.ObjDirectorio, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Directorio Actualizado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewDirectorio.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el directorio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = GridViewDirectorio.Rows[indice];

                        Directorio directorio = new Directorio()
                        {
                            IdDirectorio = Convert.ToInt32(row.Cells["id"].Value),
                        };
                        bool Respuesta = new CN_Directorio().EliminarDirectorio(directorio, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Directorio Eliminado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
