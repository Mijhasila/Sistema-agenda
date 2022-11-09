using APP__Agenda;
using CapaDatos;
using CapaNegocio;
using CapaPresentacion.FormHijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormPadres
{
    public partial class FormCalendario : Form
    {
        readonly CD_Calendario ObjCalendario = new CD_Calendario();

        public FormCalendario()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {
                if (ObjCalendario.Listar())
                {
                    GridViewCalendario.DataSource = ObjCalendario.Datos;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void FormCalendario_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable datos = new CD_Filtros().FiltroRango(TxtFechaInicio.Value.ToString("yyy/MM/d"), TxtFechaFinal.Value.ToString("yyy/MM/d"));

            if (datos != null)
            {
                GridViewCalendario.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No hay datos para su filtro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnQuitarFiltro_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void BtnFiltrarDesde_Click(object sender, EventArgs e)
        {
            DataTable datos = new CD_Filtros().FiltroDesde(TxtFechaInicio2.Value.ToString("yyy/MM/d"));

            if (datos != null)
            {
                GridViewCalendario.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No hay datos para su filtro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnQuitarFiltro2_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
