using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP__Agenda
{
    public class Notas
    {
        public Usuarios oUsuarios { get; set; }
        public int IdNotas { get; set; }
        public Categoria oCategoria { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Entradas oEntrada { get; set; }
    }
}
