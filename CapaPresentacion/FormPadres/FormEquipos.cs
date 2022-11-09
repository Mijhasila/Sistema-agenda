using APP__Agenda;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FormHijos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.FormPadres
{
    public partial class FormEquipos : Form
    {
        readonly CD_Equipo ObjEquipos = new CD_Equipo();
        readonly CN_Equipo ObjEquipo = new CN_Equipo();
        public FormEquipos()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                if (ObjEquipos.Listar())
                {
                    GridViewEquipos.DataSource = ObjEquipos.Datos;
                    GridViewEquipos.Columns["Editar"].DisplayIndex = 3;
                    GridViewEquipos.Columns["Eliminar"].DisplayIndex = 3;
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
        private void FormEquipos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void BtnCrearNuevo_Click(object sender, EventArgs e)
        {
            using (var Equipo = new CrearEquipo())
            {
                var result = Equipo.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = new CN_Equipo().RegistrarEquipo(Equipo.ObjEquipo, out string mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Equipo Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GridViewEquipos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridViewEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewEquipos.Columns[e.ColumnIndex].Name == "Editar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    using (var Equipo = new CrearEquipo())
                    {
                        DataGridViewRow row = GridViewEquipos.Rows[indice];
                        Equipo.TxtIdEquipo.Text = row.Cells["id"].Value.ToString();
                        Equipo.TxtNombreEquipo.Text = row.Cells["nombre"].Value.ToString();

                        var result = Equipo.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CN_Equipo().EditarEquipo(Equipo.ObjEquipo, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Equipo Actualizado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewEquipos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el Equipo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = GridViewEquipos.Rows[indice];

                        Equipos Equipo = new Equipos()
                        {
                            IdEquipo = Convert.ToInt32(row.Cells["id"].Value),
                        };
                        bool Respuesta = new CN_Equipo().EliminarEquipo(Equipo, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Equipo Eliminada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
