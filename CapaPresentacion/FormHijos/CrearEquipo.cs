using APP__Agenda;
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
    public partial class CrearEquipo : Form
    {
        public Equipos ObjEquipo { get; set; }
        public CrearEquipo()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            TxtNombreEquipo.Clear();
        }
        private void CrearEquipo_Load(object sender, EventArgs e)
        {
            TxtNombreEquipo.Select();
        }

        private void BtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtIdEquipo.Text == "")
            {
                ObjEquipo = new Equipos
                {
                    Nombre = TxtNombreEquipo.Text,
                };
            }
            else
            {
                ObjEquipo = new Equipos
                {
                    IdEquipo = Convert.ToInt32(TxtIdEquipo.Text),
                    Nombre = TxtNombreEquipo.Text,
                };
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            Limpiar();
        }
    }
}
