using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP__Agenda
{
    public class Agenda
    {
        //relacion de composicion
        public int IdAgenda { get; set; }
        public Usuarios oUsuarios { get; set; }
    }
}
