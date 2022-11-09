using APP__Agenda;
using CapaDatos;
using CapaEntidad;
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
    public partial class FormEquipoUsuarios : Form
    {
        readonly CD_EquipoUsuarios ObjEquiposUsuarios = new CD_EquipoUsuarios();
        readonly Equipos EquiposUsuarios = new Equipos();

        public FormEquipoUsuarios()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                if (ObjEquiposUsuarios.Listar())
                {
                    GridViewEquipoUsuario.DataSource = ObjEquiposUsuarios.Datos;
                    GridViewEquipoUsuario.Columns["Editar"].DisplayIndex = 6;
                    GridViewEquipoUsuario.Columns["Eliminar"].DisplayIndex = 6;
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
        private void FormEquipoUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnCrearNuevo_Click(object sender, EventArgs e)
        {
            using (var Equipo = new CrearEquipoUsuario())
            {
                var result = Equipo.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = new CN_EquipoUsuarios().RegistrarEquipoUsuario(Equipo.ObjEquipo, out string mensaje);
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

        private void GridViewEquipoUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GridViewEquipoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void FormEquipoUsuarios_Load_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void GridViewEquipoUsuario_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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
    }
}
