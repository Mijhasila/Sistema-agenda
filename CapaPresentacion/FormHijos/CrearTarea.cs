using APP__Agenda;
using CapaDatos;
using CapaPresentacion.FormModales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormHijos
{
    public partial class CrearTarea : Form
    {
        public Tareas ObjTarea = new Tareas();
        public CrearTarea()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtEntrada.Clear();
            TxtCategoria.Clear();
            TxtDescripcion.Clear();
            TxtIndicador.Clear();
            TxtIdUsuario.Clear();
            TxtEstado.Clear();
            TxtIdEntrada.Clear();
            TxtIdCategoria.Clear();
        }
        private void CrearTarea_Load(object sender, EventArgs e)
        {
            TxtIdUsuario.Select();
            Usuarios usuario = new CD_Usuario().Consultar(TxtIdUsuario.Text);

            if (usuario != null)
            {
                TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
            }
            Entradas entradas = new CD_Entrada().Consultar(TxtIdEntrada.Text);

            if (entradas != null)
            {
                TxtEntrada.Text = entradas.Titulo.ToString();
            }
            Categoria categorias = new CD_Categoria().Consultar(TxtIdEntrada.Text);

            if (entradas != null)
            {
                TxtCategoria.Text = entradas.Titulo.ToString();
            }
        }
        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtIdUsuario.Text == "" || TxtCategoria.Text == "" || TxtEntrada.Text == "")
            {
                MessageBox.Show("Por Favor llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TxtIdTarea.Text == "")
                {
                    ObjTarea = new Tareas
                    {
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        oEntradas = new Entradas { IdEntrada = Convert.ToInt32(TxtIdEntrada.Text) },
                        oCategoria = new Categoria { IdCategoria = Convert.ToInt32(TxtIdCategoria.Text) },
                        Descripcion = TxtDescripcion.Text,
                        Estado = Convert.ToInt32(TxtEstado.Text),
                        Prioridad = TxtPrioridad.Text,
                        FechaTerminacion = TxtFecha.Value,
                        IndicadorCumplimiento = Convert.ToInt32(TxtIndicador.Text),
                    };
                }
                else
                {
                    ObjTarea = new Tareas
                    {
                        IdTarea = Convert.ToInt32(TxtIdTarea.Text),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        oEntradas = new Entradas { IdEntrada = Convert.ToInt32(TxtIdEntrada.Text) },
                        oCategoria = new Categoria { IdCategoria = Convert.ToInt32(TxtIdCategoria.Text) },
                        Descripcion = TxtDescripcion.Text,
                        Estado = Convert.ToInt32(TxtEstado.Text),
                        Prioridad = TxtPrioridad.Text,
                        FechaTerminacion = TxtFecha.Value,
                        IndicadorCumplimiento = Convert.ToInt32(TxtIndicador.Text),
                    };
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                Limpiar();
            }
        }

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            using (var frm = new ModalUsuario())
            {
                var result = frm.ShowDialog();

                if(result == DialogResult.OK)
                {
                    TxtIdUsuario.Text = frm.IdUsuario.ToString();
                    TxtUsuario.Text = frm.Usuario.ToString();
                }
                else
                {
                    TxtIdUsuario.Select();
                }
            }
        }
        private void TxtBuscarEntrada_Click(object sender, EventArgs e)
        {
            using (var frm = new ModalEntrada())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdEntrada.Text = frm.IdEntrada.ToString();
                    TxtEntrada.Text = frm.Entrada.ToString();
                }
                else
                {
                    TxtIdUsuario.Select();
                }
                
            }
        }
        private void BtnBuscarCategoria_Click(object sender, EventArgs e)
        {
            using (var frm = new ModalCategoria())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdCategoria.Text = frm.IdCategoria.ToString();
                    TxtCategoria.Text = frm.Categoria.ToString();
                }
                else
                {
                    TxtIdUsuario.Select();
                }
            }
        }
    }
}
