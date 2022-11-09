using APP__Agenda;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEntidad
{
    public class EquiposUsuarios
    {
        public int IdEquipoUsuario { get; set; }
        public bool Tipo { get; set; }
        public Usuarios oUsuarios { get; set; }
        public int IdUsuario { get; set; }
        public Equipos oEquipos{ get; set; }
    }
}
