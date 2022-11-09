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
    public partial class CrearCategoria : Form
    {
        public Categoria Objcategorias { get; set; }
        public CrearCategoria()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtIdUsuario.Clear();
            TxtNombreCategoria.Clear();
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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtIdUsuario.Text == "" || TxtNombreCategoria.Text == "")
            {
                MessageBox.Show("Por Favor llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TxtIdCategoria.Text == "")
                {
                    Objcategorias = new Categoria
                    {
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        Nombre = TxtNombreCategoria.Text
                    };
                }
                else
                {
                    Objcategorias = new Categoria
                    {
                        IdCategoria = Convert.ToInt32(TxtIdCategoria.Text),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        Nombre = TxtNombreCategoria.Text
                    };
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                Limpiar();
            }
        }

        private void CrearCategoria_Load(object sender, EventArgs e)
        {
            TxtIdUsuario.Select();
            Usuarios usuario = new CD_Usuario().Consultar(TxtIdUsuario.Text);

            if (usuario != null)
            {
                TxtIdUsuario.Text = usuario.IdUsuario.ToString();
                TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
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
                    TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
                    TxtNombreCategoria.Select();
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
