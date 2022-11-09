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
using CapaEntidad;
namespace CapaPresentacion.FormHijos
{
    public partial class CrearEquipoUsuario : Form
    {
        public EquiposUsuarios ObjEU = new EquiposUsuarios();
        public CrearEquipoUsuario()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtIdUsuario.Clear();
            TxtUsuarioCreador.Clear();
            TxtIdUsuarioPerteneciente.Clear();
            TxtUsuarioPertenciente.Clear();
            TxtIdEquipo.Clear();
            TxtEquipo.Clear();
            TxtTipo.Clear();
        }
        private void CrearEquipoUsuario_Load(object sender, EventArgs e)
        {
            TxtIdUsuario.Select();
            Usuarios usuario = new CD_Usuario().Consultar(TxtIdUsuario.Text);
            if (usuario != null)
            {
                TxtUsuarioCreador.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
            }
            Usuarios usuario1 = new CD_Usuario().Consultar(TxtIdUsuarioPerteneciente.Text);
            if (usuario != null)
            {
                TxtUsuarioPertenciente.Text = usuario1.Nombre1.ToString() + " " + usuario1.Nombre2.ToString() + " " + usuario1.Apellido1.ToString() + " " + usuario1.Apellido2.ToString();
            }
            Equipos Equipo = new CD_Equipo().Consultar(TxtIdEquipo.Text);
            if (Equipo != null)
            {
                TxtEquipo.Text = Equipo.Nombre;
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
                    TxtUsuarioCreador.Text = frm.Usuario.ToString();
                }
                else
                {
                    TxtIdUsuario.Select();
                }
            }
        }
        private void TxtBuscarUsuarioPerteneciente_Click(object sender, EventArgs e)
        {
            using (var frm = new ModalUsuario())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdUsuarioPerteneciente.Text = frm.IdUsuario.ToString();
                    TxtUsuarioPertenciente.Text = frm.Usuario.ToString();
                }
                else
                {
                    TxtIdUsuario.Select();
                }
            }
        }
        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtIdUsuario.Text == "" || TxtIdEquipo.Text == "" || TxtIdUsuarioPerteneciente.Text == "")
            {
                MessageBox.Show("Por Favor llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TxtIdEquipoUsuario.Text == "")
                {
                    ObjEU = new EquiposUsuarios
                    {
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        oEquipos = new Equipos { IdEquipo = Convert.ToInt32(TxtIdEquipo.Text) },
                        IdUsuario = Convert.ToInt32(TxtIdUsuarioPerteneciente.Text),
                        Tipo = Convert.ToInt32(TxtTipo.Text),
                    };
                }
                else
                {
                    ObjEU = new EquiposUsuarios
                    {
                        IdEquipoUsuario = Convert.ToInt32(TxtIdEquipoUsuario.Text),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        oEquipos = new Equipos { IdEquipo = Convert.ToInt32(TxtIdEquipo.Text) },
                        IdUsuario = Convert.ToInt32(TxtIdUsuarioPerteneciente.Text),
                        Tipo = Convert.ToInt32(TxtTipo.Text),
                    };
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                Limpiar();
            }
        }

        private void BtnBuscarEquipo_Click(object sender, EventArgs e)
        {
            using (var frm = new ModalEquipo())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdEquipo.Text = frm.IdEquipo.ToString();
                    TxtEquipo.Text = frm.Equipo.ToString();
                }
                else
                {
                    TxtIdUsuario.Select();
                }
            }
        }
    }
}
