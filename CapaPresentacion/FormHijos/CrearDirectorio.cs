using APP__Agenda;
using CapaDatos;
using CapaNegocio;
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
    public partial class CrearDirectorio : Form
    {
        public Directorio ObjDirectorio { get; set; }
        public CrearDirectorio()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtSegundoNombre.Clear();
            TxtApellidoPaterno.Clear();
            TxtApellidoMaterno.Clear();
            TxtAlias.Clear();
            TxtDireccion.Clear();
            TxtAlias.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtIdUsuario.Clear();
            TxtNotasAdicionales.Clear();
        }
        private void CrearDirectorio_Load(object sender, EventArgs e)
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


        }
        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void TxtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtIdUsuario.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
        private void TxtIdEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtIdEntrada.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
            if(TxtIdUsuario.Text == "" || TxtIdEntrada.Text == "")
            {
                MessageBox.Show("Por favor llene los campos Id", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (TxtIdDirectorio.Text == "")
                {
                    ObjDirectorio = new Directorio
                    {
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        Nombre1 = TxtPrimerNombre.Text,
                        Nombre2 = TxtSegundoNombre.Text,
                        Apellido1 = TxtApellidoPaterno.Text,
                        Apellido2 = TxtApellidoMaterno.Text,
                        Alias = TxtAlias.Text,
                        Direccion = TxtDireccion.Text,
                        Correo = TxtEmail.Text,
                        Telefono = TxtTelefono.Text,
                        NotasAdicionales = TxtNotasAdicionales.Text,
                        oEntrada = new Entradas { IdEntrada = Convert.ToInt32(TxtIdEntrada.Text) },
                    };
                }
                else
                {
                    ObjDirectorio = new Directorio
                    {
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        IdDirectorio = Convert.ToInt32(TxtIdDirectorio.Text),
                        Nombre1 = TxtPrimerNombre.Text,
                        Nombre2 = TxtSegundoNombre.Text,
                        Apellido1 = TxtApellidoPaterno.Text,
                        Apellido2 = TxtApellidoMaterno.Text,
                        Alias = TxtAlias.Text,
                        Direccion = TxtDireccion.Text,
                        Correo = TxtEmail.Text,
                        Telefono = TxtTelefono.Text,
                        NotasAdicionales = TxtNotasAdicionales.Text,
                        oEntrada = new Entradas { IdEntrada = Convert.ToInt32(TxtIdEntrada.Text) },
                    };
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                Limpiar();
            }
        }

        private void TxtIdUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Usuarios usuario = new CD_Usuario().Consultar(TxtIdUsuario.Text);

                if (usuario != null)
                {
                    TxtIdUsuario.Text = usuario.IdUsuario.ToString();
                    TxtUsuario.Text = usuario.Nombre1.ToString() +" "+ usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
                    //TxtIdUsuario.BackColor = Color.Green;
                }
                else
                {
                    //TxtIdUsuario.BackColor = Color.MistyRose;
                    MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TxtIdEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Entradas entradas = new CD_Entrada().Consultar(TxtIdEntrada.Text);

                if (entradas != null)
                {
                    TxtIdEntrada.Text = entradas.IdEntrada.ToString();
                    TxtEntrada.Text = entradas.Titulo.ToString();
                }
                else
                {
                    TxtIdEntrada.BackColor = Color.MistyRose;
                    MessageBox.Show("No se encontro la entrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
