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
    public partial class FormAgendaPersonal : Form
    {
        readonly CD_Agenda ObjAgenda = new CD_Agenda();
        public FormAgendaPersonal()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                if (ObjAgenda.Listar())
                {
                    GridViewAgenda.DataSource = ObjAgenda.Datos;
                    GridViewAgenda.Columns["Editar"].DisplayIndex = 4;
                    GridViewAgenda.Columns["Eliminar"].DisplayIndex = 4;
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
        private void FormAgendaPersonal_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void BtnCrearNuevo_Click(object sender, EventArgs e)
        {
            string mensaje;
            using (var Agenda = new CrearAgendaPersonal())
            {
                var result = Agenda.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool respuesta = new CN_Agenda().RegistrarAgenda(Agenda.ObjAgendaPersonal, out mensaje);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Agenda Agregada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        
        private void GridViewAgenda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void GridViewAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje;

            if (GridViewAgenda.Columns[e.ColumnIndex].Name == "Editar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    using (var Agenda = new CrearAgendaPersonal())
                    {
                        DataGridViewRow row = GridViewAgenda.Rows[indice];
                        Agenda.TxtIdAgenda.Text = row.Cells["id"].Value.ToString();
                        Agenda.TxtIdUsuario.Text = row.Cells["idUsuario"].Value.ToString();

                        var result = Agenda.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            bool Resultado = new CN_Agenda().EditarAgenda(Agenda.ObjAgendaPersonal, out mensaje);
                            if (Resultado)
                            {
                                Listar();
                                MessageBox.Show("Agenda Actualizada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if (GridViewAgenda.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    if (MessageBox.Show("¿Desea eliminar la Agenda?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = GridViewAgenda.Rows[indice];

                        Agenda Agenda = new Agenda()
                        {
                            IdAgenda = Convert.ToInt32(row.Cells["id"].Value),
                        };
                        bool Respuesta = new CN_Agenda().EliminarAgenda(Agenda, out mensaje);
                        if (Respuesta)
                        {
                            Listar();
                            MessageBox.Show("Agenda Eliminada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
