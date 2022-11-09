using APP__Agenda;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FormHijos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.FormPadres
{
    public partial class FormNotas : Form
    {
        readonly CD_Nota ObjNotas = new CD_Nota();
        readonly CN_Nota ObjNota = new CN_Nota();

        public FormNotas()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            try
            {
                if (ObjNotas.Listar())
                {
                    GridViewNotas.DataSource = ObjNotas.Datos;
                    GridViewNotas.Columns["Editar"].DisplayIndex = 7;
                    GridViewNotas.Columns["Eliminar"].DisplayIndex = 7;
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
        private void FormNotas_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void BtnCrearNuevo_Click(object sender, EventArgs e)
        {
            using (var Nota = new CrearNotas())
            {
                var result = Nota.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = ObjNota.RegistrarNota(Nota.ObjNotas, out string mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Nota Agregada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GridViewNotas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridViewNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;
            if (GridViewNotas.Columns[e.ColumnIndex].Name == "Editar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    using (var Notas = new CrearNotas())
                    {
                        DataGridViewRow row = GridViewNotas.Rows[indice];
                        Notas.TxtIdNota.Text = row.Cells["id"].Value.ToString();
                        Notas.TxtIdUsuario.Text = row.Cells["idUsuario"].Value.ToString();
                        Notas.TxtIdEntrada.Text = row.Cells["id_Entrada"].Value.ToString();
                        Notas.TxtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                        Notas.TxtTitulo.Text = row.Cells["titulo"].Value.ToString();
                        Notas.TxtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                        var result = Notas.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CN_Nota().EditarNota(Notas.ObjNotas, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Notas Actualizada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewNotas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    if (MessageBox.Show("¿Desea eliminar la Notas?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = GridViewNotas.Rows[indice];

                        Notas Notas = new Notas()
                        {
                            IdNotas = Convert.ToInt32(row.Cells["id"].Value),
                        };
                        bool Respuesta = new CN_Nota().EliminarNota(Notas, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Notas Eliminada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
