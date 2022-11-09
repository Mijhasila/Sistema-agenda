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
    public partial class CrearAgendaPersonal : Form
    {
        public Agenda ObjAgendaPersonal { get; set; }
        public CrearAgendaPersonal()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtIdUsuario.Clear();
        }
        private void CrearAgendaPersonal_Load(object sender, EventArgs e)
        {
            TxtIdUsuario.Select();
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

        private void TxtIdUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Usuarios usuario = new CD_Usuario().Consultar(TxtIdUsuario.Text);

                if (usuario != null)
                {
                    TxtIdUsuario.Text = usuario.IdUsuario.ToString();
                    TxtUsuario.Text = usuario.Nombre1.ToString() + " " + usuario.Nombre2.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
                }
                else
                {
                    //TxtIdUsuario.BackColor = Color.MistyRose;
                    MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtIdUsuario.Text == "")
            {
                MessageBox.Show("Ingrese el id del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(TxtIdAgenda.Text == "")
                {
                    ObjAgendaPersonal = new Agenda()
                    {
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                    };
                }
                else
                {
                    ObjAgendaPersonal = new Agenda()
                    {
                        IdAgenda = Convert.ToInt32(TxtIdAgenda.Text),
                        oUsuarios = new Usuarios { IdUsuario = Convert.ToInt32(TxtIdUsuario.Text) },
                    };
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            Limpiar();
        }
    }
}
