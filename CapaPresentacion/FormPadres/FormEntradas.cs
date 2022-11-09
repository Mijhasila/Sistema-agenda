using APP__Agenda;
using CapaDatos;
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
    public partial class FormEntradas : Form
    {
        readonly CapaDatos.CD_Calendario ObjCalendario = new CapaDatos.CD_Calendario();
        private static Usuarios UsuarioActual;

        public FormEntradas(Usuarios usuarios)
        {
            InitializeComponent();
            UsuarioActual = usuarios;
        }
        public void Listar()
        {
            try
            {
                if (ObjCalendario.Listar())
                {
                    GridViewEntradas.DataSource = ObjCalendario.Datos;
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

        private void GridViewEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
