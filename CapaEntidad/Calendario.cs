using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP__Agenda
{
    public class Calendario
    {
        public int IdCalendario { get; set; }
        public Entradas oEntrada{ get; set; }
        public string Semanas { get; set; }
        public string Meses { get; set; }
        public string Años { get; set; }
        public Usuarios oUsuarios { get; set; }

        public int IdEntrada { get; set; }
        //private List<Entradas> entradas;
    }
}
