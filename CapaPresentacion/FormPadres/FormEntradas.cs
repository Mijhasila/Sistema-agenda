using APP__Agenda;
using CapaDatos;
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
    public partial class FormEntradas : Form
    {
        readonly CD_Entrada ObjEntradas = new CD_Entrada();

        public FormEntradas()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                if (ObjEntradas.Listar())
                {
                    GridViewEntradas.DataSource = ObjEntradas.Datos;
                    GridViewEntradas.Columns["Editar"].DisplayIndex = 8;
                    GridViewEntradas.Columns["Eliminar"].DisplayIndex = 8;
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
            /*using (var Categoria = new CrearCalendario())
            {
                var result = Categoria.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //bool respuesta = ObjCalendario.CrearCalendario(Categoria.ObjCalendario);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Categoria Agregada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se agregao la Categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }*/
        }

        private void FormEntradas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void GridViewEntradas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            using (var entrada = new CrearEntrada())
            {
                var result = entrada.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = ObjEntradas.RegistrarEntrada(entrada.ObjEntradas, out string mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Tarea Agregada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se agregao la Tarea", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TxtExportar_Click(object sender, EventArgs e)
        {
            var inicio = 2;
            GridViewEntradas.SelectAll();
            DataObject copydata = GridViewEntradas.GetClipboardContent();
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
            xlsheet.Cells[inicio - 1, 2] = "Id_Usuario";
            xlsheet.Cells[inicio - 1, 3] = "Titulo";
            xlsheet.Cells[inicio - 1, 4] = "Fecha";
            xlsheet.Cells[inicio - 1, 5] = "Hora";
            xlsheet.Cells[inicio - 1, 6] = "Tipo";
            xlsheet.Cells[inicio - 1, 7] = "Observaciones";
            xlapp.Visible = true;
        }

        private void GridViewEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewEntradas.Columns[e.ColumnIndex].Name == "Editar")
            {

                if (e.ColumnIndex >= 0)
                {
                    using (var Entrada = new CrearEntrada())
                    {
                        Entrada.TxtIdEntrada.Text = GridViewEntradas.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Entrada.TxtIdUsuario.Text = GridViewEntradas.Rows[e.RowIndex].Cells[3].Value.ToString();
                        Entrada.TxtTitulo.Text = GridViewEntradas.Rows[e.RowIndex].Cells[4].Value.ToString();
                        DateTime fecha = (DateTime)GridViewEntradas.Rows[e.RowIndex].Cells[5].Value;
                        Entrada.TxtFecha.Value = fecha;
                        Entrada.TxtTipo.Text = GridViewEntradas.Rows[e.RowIndex].Cells[7].Value.ToString();
                        Entrada.TxtObservaciones.Text = GridViewEntradas.Rows[e.RowIndex].Cells[8].Value.ToString();
                        var result = Entrada.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CD_Entrada().EditarEntrada(Entrada.ObjEntradas, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Entrada Actualizada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
