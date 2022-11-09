using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace APP__Agenda
{
    public class Equipos
    {
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public string Promotor { get; set; }
    }
}
