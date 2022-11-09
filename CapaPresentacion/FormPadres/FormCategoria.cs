using APP__Agenda;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FormHijos;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion.FormPadres
{
    public partial class FormCategoria : Form
    {

        readonly CD_Categoria Objcategorias = new CD_Categoria();
        public FormCategoria()
        {
            InitializeComponent();
        }
        private void FormCategoria_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            try
            {
                if (Objcategorias.Listar())
                {
                    GridViewCategoria.DataSource = Objcategorias.Datos;
                    GridViewCategoria.Columns["id"].DisplayIndex = 0;
                    GridViewCategoria.Columns["nombre"].DisplayIndex = 1;
                    GridViewCategoria.Columns["idUsuario"].DisplayIndex = 2;
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
            string mensaje;
            using (var Categoria = new CrearCategoria())
            {
                var result = Categoria.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = new CN_Categoria().RegistrarCategoria(Categoria.Objcategorias, out mensaje); //Objcategorias.RegistrarCategoria(Categoria.Objcategorias, out mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Categoria Agregada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void GridViewCategoria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewCategoria.Columns[e.ColumnIndex].Name == "Editar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    using (var Categoria = new CrearCategoria())
                    {
                        DataGridViewRow row = GridViewCategoria.Rows[indice];
                        Categoria.TxtIdCategoria.Text = row.Cells["id"].Value.ToString();
                        Categoria.TxtIdUsuario.Text = row.Cells["idUsuario"].Value.ToString();
                        Categoria.TxtNombreCategoria.Text = row.Cells["nombre"].Value.ToString();

                        var result = Categoria.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CN_Categoria().EditarCategoria(Categoria.Objcategorias, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Categoria Actualizada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewCategoria.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    if (MessageBox.Show("¿Desea eliminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = GridViewCategoria.Rows[indice];

                        Categoria categoria = new Categoria()
                        {
                            IdCategoria = Convert.ToInt32(row.Cells["id"].Value),
                        };
                        bool Respuesta = new CN_Categoria().EliminarCategoria(categoria, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Categoria Eliminada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void TxtExportar_Click(object sender, EventArgs e)
        {
            var inicio = 2;
            GridViewCategoria.SelectAll();
            DataObject copydata = GridViewCategoria.GetClipboardContent();
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
            xlsheet.Cells[inicio - 1, 2] = "nombre";
            xlsheet.Cells[inicio - 1, 3] = "idUsuario";


            xlapp.Visible = true;

            /*if (GridViewCategoria.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable DataTable = new DataTable();

                foreach (DataGridViewColumn columnas in GridViewCategoria.Columns)
                {
                    if (columnas.HeaderText != "" && columnas.Visible == true)
                    {
                        DataTable.Columns.Add(columnas.HeaderText, typeof(string));
                    }
                }
                foreach (DataGridViewRow filas in GridViewCategoria.Rows)
                {
                    if (filas.Visible == true)
                    {
                        DataTable.Rows.Add(new object[]
                        {
                           filas.Cells[0].Value,
                           filas.Cells[1].Value,
                           filas.Cells[2].Value,
                        });
                    }
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = string.Format("Reportes de Categorias_{0}.xlsx", DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss"));
                saveFileDialog.Filter = "Excel files | *.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook xLWorkbook = xnew XLWorkbook();
                        var hoja = xLWorkbook.Worksheets.Add(DataTable, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        xLWorkbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    catch
                    {
                        MessageBox.Show("Error al general el reporte ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }*/
        }
    }
}
