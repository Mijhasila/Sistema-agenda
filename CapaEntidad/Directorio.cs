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
    public class Directorio
    {


        public int IdDirectorio { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Alias { get; set; }
        public string NotasAdicionales { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Usuarios oUsuarios { get; set; }

        public Entradas oEntrada { get; set; }



       

    }
}
