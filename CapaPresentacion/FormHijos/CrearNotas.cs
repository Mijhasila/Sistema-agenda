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
    public partial class CrearNotas : Form
    {
        public Notas ObjNotas { get; set; }
        public CrearNotas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtIdUsuario.Clear();
            TxtIdEntrada.Clear();
            TxtIdCategoria.Clear();
            TxtUsuario.Clear();
            TxtCategoria.Clear();
            TxtEntrada.Clear();
            TxtTitulo.Clear();
            TxtDescripcion.Clear();
        }

        private void CrearNotas_Load(object sender, EventArgs e)
        {
            TxtIdUsuario.Select();
            Entradas entradas = new CD_Entrada().Consultar(TxtIdEntrada.Text);

            if (entradas != null)
            {
                TxtIdEntrada.Text = entradas.IdEntrada.ToString();
                TxtEntrada.Text = entradas.Titulo.ToString();
                TxtIdCategoria.Select();
            }
            Usuarios usuario = new CD_Usuario().Consultar(TxtIdUsuario.Text);
            if (usuario != null)
            {
                TxtIdUsuario.Text = usuario.IdUsuario.ToString();
                TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
                TxtIdEntrada.Select();
            }
            Categoria categoria = new CD_Categoria().Consultar(TxtIdCategoria.Text);
            if (categoria != null)
            {
                TxtCategoria.Text = categoria.Nombre.ToString();
                TxtTitulo.Select();
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

        private void TxtIdEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Entradas entradas = new CD_Entrada().Consultar(TxtIdEntrada.Text);

                if (entradas != null)
                {
                    TxtIdEntrada.Text = entradas.IdEntrada.ToString();
                    TxtEntrada.Text = entradas.Titulo.ToString();
                    TxtIdCategoria.Select();
                }
                else
                {
                    MessageBox.Show("No se encontro la entrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                    TxtIdEntrada.Select();
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void TxtIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtIdCategoria.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void TxtIdCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Categoria categoria = new CD_Categoria().Consultar(TxtIdCategoria.Text);

                if (categoria != null)
                {
                    TxtCategoria.Text = categoria.Nombre.ToString();
                    TxtTitulo.Select();
                }
                else
                {
                    MessageBox.Show("No se encontro la categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtIdUsuario.Text == "" || TxtIdEntrada.Text == "" || TxtIdCategoria.Text == "")
            {
                MessageBox.Show("Por Favor llene todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TxtIdNota.Text == "")
                {
                    ObjNotas = new Notas
                    {
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        oEntrada = new Entradas { IdEntrada = Convert.ToInt32(TxtIdEntrada.Text) },
                        oCategoria = new Categoria { IdCategoria = Convert.ToInt32(TxtIdCategoria.Text) },
                        Titulo = TxtTitulo.Text,
                        Descripcion = TxtDescripcion.Text,  
                    };
                }
                else
                {
                    ObjNotas = new Notas
                    {
                        IdNotas = Convert.ToInt32(TxtIdNota.Text),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                        oEntrada = new Entradas { IdEntrada = Convert.ToInt32(TxtIdEntrada.Text) },
                        oCategoria = new Categoria { IdCategoria = Convert.ToInt32(TxtIdCategoria.Text) },
                        Titulo = TxtTitulo.Text,
                        Descripcion = TxtDescripcion.Text,
                    };
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                Limpiar();
            }
        }
    }
}
