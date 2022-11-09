using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace APP__Agenda
{
    public class Categoria
    {

        //propiedades

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public Usuarios oUsuarios { get; set; }

        
    }
}
