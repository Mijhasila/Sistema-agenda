using CapaPresentacion.FormPadres;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static readonly Button MenuAtivo = null;
        private static Form formularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(Form formulario)
        {
            if (MenuAtivo != null)
            {
                MenuAtivo.BackColor = Color.White;
            }
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.White;
            AbrirFormulario(new FormCalendario());
        }
        private void BtnDirectorio_Click(object sender, EventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.White;
            AbrirFormulario(new FormDirectorio());
        }
        private void BtnTareas_Click(object sender, EventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.White;
            AbrirFormulario(new FormTareas());
        }
        private void BtnNotas_Click(object sender, EventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.White;
            AbrirFormulario(new FormNotas());
        }
        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            BtnControlPersonal.ForeColor = Color.White;
            AbrirFormulario(new FormUsuarios());
        }
        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.White;
            AbrirFormulario(new FormCategoria());
        }
        private void BtnReunion_Click(object sender, EventArgs e)
        {
            BtnReunion.ForeColor = Color.White;
            AbrirFormulario(new FormReunion());
        }
        private void BtnEquipo_Click(object sender, EventArgs e)
        {
            BtnEquipos.ForeColor = Color.White;
            AbrirFormulario(new FormEquipos());
        }
        private void BtnEquipoUsuarios_Click(object sender, EventArgs e)
        {
            BtnEquipos.ForeColor = Color.White;
            AbrirFormulario(new FormEquipoUsuarios());
        }
        private void BtnAgendaPersonal_Click(object sender, EventArgs e)
        {
            BtnAgendaPersonal.ForeColor = Color.White;
            AbrirFormulario(new FormAgendaPersonal());
        }
        private void BtnAgenda_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.Black;
            BtnControlPersonal.ForeColor = Color.White;
            BtnEquipos.ForeColor = Color.White;
            BtnReunion.ForeColor = Color.White;
        }
        private void BtnControlPersonal_MouseMove(object sender, MouseEventArgs e)
        {
            BtnControlPersonal.ForeColor = Color.Black;
            BtnGestionAgenda.ForeColor = Color.White;
            BtnEquipos.ForeColor = Color.White;
            BtnReunion.ForeColor = Color.White;
        }
        private void BtnReunion_MouseMove(object sender, MouseEventArgs e)
        {
            BtnReunion.ForeColor = Color.Black;
            BtnControlPersonal.ForeColor = Color.White;
            BtnGestionAgenda.ForeColor = Color.White;
            BtnEquipos.ForeColor = Color.White;
        }
        private void BtnEquipos_MouseMove(object sender, MouseEventArgs e)
        {
            BtnEquipos.ForeColor = Color.Black;
            BtnControlPersonal.ForeColor = Color.White;
            BtnGestionAgenda.ForeColor = Color.White;
            BtnReunion.ForeColor = Color.White;
        }
        private void BtnCalendario_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.Black;
        }
        private void BtnDirectorio_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.Black;
        }
        private void BtnTareas_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.Black;
        }
        private void BtnNotas_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.Black;
        }
        private void BtnCategoria_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.Black;
        }
        private void BtnRegistrarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            BtnControlPersonal.ForeColor = Color.Black;
        }
        private void BtnAgenda_MouseLeave(object sender, EventArgs e)
        {
            BtnGestionAgenda.ForeColor = Color.White;
        }
        private void BtnControlPersonal_MouseLeave(object sender, EventArgs e)
        {
            BtnControlPersonal.ForeColor = Color.White;
        }
        private void BtnReunion_MouseLeave(object sender, EventArgs e)
        {
            BtnReunion.ForeColor = Color.White;
        }
        private void BtnEquipos_MouseLeave(object sender, EventArgs e)
        {
            BtnEquipos.ForeColor = Color.White;
        }

        private void BtnCrearEntrada_Click(object sender, EventArgs e)
        {

        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntradas());

        }

        private void equiposUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
