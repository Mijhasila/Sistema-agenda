using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP__Agenda
{
    public class Entradas
    {
        public int IdEntrada { get; set; }
        public Usuarios oUsuarios { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Tipo { get; set; }
        public string Observaciones { get; set; }


    }
}
