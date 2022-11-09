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
    public partial class CrearEntrada : Form
    {
        public Entradas ObjEntradas = new Entradas();
        readonly CD_Entrada entradas = new CD_Entrada();
        public CrearEntrada()
        {
            InitializeComponent();
        }

        private void CrearEntrada_Load(object sender, EventArgs e)
        {
            TxtIdUsuario.Select();
            Usuarios usuario = new CD_Usuario().Consultar(TxtIdUsuario.Text);

            if (usuario != null)
            {
                TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
            }
        }
        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            using (var frm = new ModalUsuario())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
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
        private void Limpiar()
        {
            TxtIdUsuario.Clear();
            TxtUsuario.Clear();
            TxtTitulo.Clear();
            TxtTitulo.Clear();
            TxtObservaciones.Clear();
            TxtFecha.ResetText();
        }

        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtIdUsuario.Text == "" || TxtObservaciones.Text == "" || TxtTitulo.Text == "")
            {
                MessageBox.Show("Por Favor llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(TxtIdEntrada.Text == "")
                {
                    ObjEntradas = new Entradas()
                    {
                        Observaciones = TxtObservaciones.Text,
                        Tipo = TxtTipo.Text,
                        Titulo = TxtTitulo.Text,
                        Fecha = Convert.ToDateTime(TxtFecha.Value.ToString("yyy/MM/d")),
                        Hora = DateTime.Now.ToString("hh:mm:ss"),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                    };
                }
                else
                {
                    ObjEntradas = new Entradas()
                    {
                        IdEntrada = Convert.ToInt32(TxtIdEntrada.Text),
                        Observaciones = TxtObservaciones.Text,
                        Tipo = TxtTipo.Text,
                        Titulo = TxtTitulo.Text,
                        Fecha = Convert.ToDateTime(TxtFecha.Value.ToString("yyy/MM/d")),
                        Hora = DateTime.Now.ToString("hh:mm:ss"),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                    };
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                Limpiar();
            }
        }
    }
}
