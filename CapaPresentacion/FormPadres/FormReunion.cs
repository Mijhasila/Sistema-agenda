using APP__Agenda;
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
    public partial class FormReunion : Form
    {
        readonly Reunion ObjReunion = new Reunion();
        public FormReunion()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            /*try
            {
                if (ObjReunion.Listado())
                {
                    GridViewReunion.DataSource = ObjReunion.Datos;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }*/
        }
        private void BtnCrearNuevo_Click(object sender, EventArgs e)
        {
            /*using (var Categoria = new CrearCalendario())
            {
                var result = Categoria.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //bool respuesta = ObjCalendario.CrearCalendario(Categoria.ObjCalendario);
                    if (respuesta)
                    {
                        Listar();
                        MessageBox.Show("Categoria Agregada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se agregao la Categoria", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }*/
        }
    }
}
