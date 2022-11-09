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
    public partial class FormTareas : Form
    {
        readonly CD_Tarea ObjTareas = new CD_Tarea();
        readonly CN_Tarea ObjTarea = new CN_Tarea();


        public FormTareas()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                if (ObjTareas.Listar())
                {
                    GridViewTareas.DataSource = ObjTareas.Datos;
                    GridViewTareas.Columns["Editar"].DisplayIndex = 10;
                    GridViewTareas.Columns["Eliminar"].DisplayIndex = 10;
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
            using (var Tarea = new CrearTarea())
            {
                var result = Tarea.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = ObjTarea.RegistrarTarea(Tarea.ObjTarea, out string mensaje);
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

        private void FormTareas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void GridViewTareas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void GridViewTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewTareas.Columns[e.ColumnIndex].Name == "Editar")
            {

                if (e.ColumnIndex >= 0)
                {
                    using (var Tarea = new CrearTarea())
                    {
                        Tarea.TxtIdTarea.Text = GridViewTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Tarea.TxtIdUsuario.Text = GridViewTareas.Rows[e.RowIndex].Cells[3].Value.ToString();
                        Tarea.TxtIdEntrada.Text = GridViewTareas.Rows[e.RowIndex].Cells[10].Value.ToString();
                        Tarea.TxtPrioridad.Text = GridViewTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                        DateTime fecha = (DateTime)GridViewTareas.Rows[e.RowIndex].Cells[6].Value;
                        Tarea.TxtFecha.Value = fecha;
                        bool indicador = (bool)GridViewTareas.Rows[e.RowIndex].Cells[9].Value;
                        if (indicador)
                        {
                            Tarea.TxtIndicador.Text = 1.ToString();
                        }
                        else
                        {
                            Tarea.TxtIndicador.Text = 0.ToString();
                        }
                        Tarea.TxtIdCategoria.Text = GridViewTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
                        Tarea.TxtDescripcion.Text = GridViewTareas.Rows[e.RowIndex].Cells[7].Value.ToString();
                        Tarea.TxtEstado.Text = GridViewTareas.Rows[e.RowIndex].Cells[8].Value.ToString();
                        var result = Tarea.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CD_Tarea().EditarTarea(Tarea.ObjTarea, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Tarea Actualizada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewTareas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (e.ColumnIndex == 10)
                {
                    if (MessageBox.Show("¿Desea eliminar la Tarea?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tareas Tarea = new Tareas()
                        {
                            IdTarea = (int)GridViewTareas.Rows[e.RowIndex].Cells[2].Value,
                        };
                        bool Respuesta = new CN_Tarea().EliminarTarea(Tarea, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Tarea Eliminada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
