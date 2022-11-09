using APP__Agenda;
using CapaDatos;
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
    public partial class CrearUsuario : Form
    {
        public Usuarios ObjUsuario { get; set; }
        public CrearUsuario()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtPrimerNombre.Clear();
            TxtSegundoNombre.Clear();
            TxtApellidoPaterno.Clear();
            TxtApellidoMaterno.Clear();
            TxtSexo.Clear();
            TxtDireccion.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtIdUsuario.Clear();
        }
        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            TxtUsuarioCreador.Select();
            Usuarios usuario = new CD_Usuario().Consultar(TxtUsuarioCreador.Text);

            if (usuario != null)
            {
                TxtUsuarioCreador.Text = usuario.IdUsuario.ToString();
                TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
            }
        }
        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TxtUsuarioCreador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtUsuarioCreador.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtTelefono.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtUsuarioCreador.Text == "")
            {
                MessageBox.Show("Por favor llene el campo Id", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (TxtIdUsuario.Text == "")
                {
                    ObjUsuario = new Usuarios
                    {
                        Nombre1 = TxtPrimerNombre.Text,
                        Nombre2 = TxtSegundoNombre.Text,
                        Apellido1 = TxtApellidoPaterno.Text,
                        Apellido2 = TxtApellidoMaterno.Text,
                        Sexo = TxtSexo.Text,
                        Direccion = TxtDireccion.Text,
                        Correo = TxtEmail.Text,
                        Telefono = TxtTelefono.Text,
                        Cedula = TxtCedula.Text,
                        IdUsuarioCreador = Convert.ToInt32(TxtUsuarioCreador.Text),
                    };
                }
                else
                {
                    ObjUsuario = new Usuarios
                    {
                        IdUsuario = Convert.ToInt32(TxtIdUsuario.Text),
                        Nombre1 = TxtPrimerNombre.Text,
                        Nombre2 = TxtSegundoNombre.Text,
                        Apellido1 = TxtApellidoPaterno.Text,
                        Apellido2 = TxtApellidoMaterno.Text,
                        Sexo = TxtSexo.Text,
                        Direccion = TxtDireccion.Text,
                        Correo = TxtEmail.Text,
                        Telefono = TxtTelefono.Text,
                        Cedula = TxtCedula.Text,
                        IdUsuarioCreador = Convert.ToInt32(TxtUsuarioCreador.Text),
                    };
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                Limpiar();
            }
        }
        private void TxtUsuarioCreador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Usuarios usuario = new CD_Usuario().Consultar(TxtUsuarioCreador.Text);

                if (usuario != null)
                {
                    TxtUsuarioCreador.Text = usuario.IdUsuario.ToString();
                    TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
