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
    public partial class CrearEquipoUsuario : Form
    {
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
