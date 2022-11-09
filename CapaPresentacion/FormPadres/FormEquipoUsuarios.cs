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
                    bool respuesta = new CD_EquipoUsuarios().RegistrarEquipoUsuarios(Equipo.ObjEU, out string mensaje);
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

        private void BtnCrearNuevo_Click_1(object sender, EventArgs e)
        {
            using (var EU = new CrearEquipoUsuario())
            {
                var result = EU.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = ObjEquiposUsuarios.RegistrarEquipoUsuarios(EU.ObjEU, out string mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Equipo Usuario Agregado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se agrego el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GridViewEquipoUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewEquipoUsuario.Columns[e.ColumnIndex].Name == "Editar")
            {

                if (e.ColumnIndex >= 0)
                {
                    using (var EU = new CrearEquipoUsuario())
                    {
                        EU.TxtIdEquipoUsuario.Text = GridViewEquipoUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
                        EU.TxtTipo.Text = GridViewEquipoUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
                        EU.TxtIdUsuario.Text = GridViewEquipoUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
                        EU.TxtIdUsuarioPerteneciente.Text = GridViewEquipoUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
                        EU.TxtIdEquipo.Text = GridViewEquipoUsuario.Rows[e.RowIndex].Cells[6].Value.ToString();
                        var result = EU.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CD_EquipoUsuarios().EditarEquiposUsuarios(EU.ObjEU, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Registro Actualizado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewEquipoUsuario.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("¿Desea eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        EquiposUsuarios EU = new EquiposUsuarios()
                        {
                            IdEquipoUsuario = (int)GridViewEquipoUsuario.Rows[e.RowIndex].Cells[2].Value,
                        };
                        bool Respuesta = new CD_EquipoUsuarios().EliminarEquiposUsuarios(EU, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Registro Eliminado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnExportar_Click_1(object sender, EventArgs e)
        {
            var inicio = 2;
            GridViewEquipoUsuario.SelectAll();
            DataObject copydata = GridViewEquipoUsuario.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[inicio, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            xlsheet.Cells[inicio - 1, 1] = "ID";
            xlsheet.Cells[inicio - 1, 2] = "Tipo";
            xlsheet.Cells[inicio - 1, 3] = "IdUsuario";
            xlsheet.Cells[inicio - 1, 4] = "Id_Usuario";
            xlsheet.Cells[inicio - 1, 5] = "id_equipo";
            xlapp.Visible = true;
        }
    }
}
