using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP__Agenda
{
    public class Tareas
    {
        public int IdTarea { get; set; }
        public Usuarios oUsuarios { get; set; }
        public string Prioridad { get; set; }
        public Categoria oCategoria { get; set; }
        public DateTime FechaTerminacion { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public int IndicadorCumplimiento { get; set; }
        public Entradas oEntradas { get; set; }

    }
}
