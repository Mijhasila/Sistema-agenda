using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Equipo
    {
        private CD_Equipo ObjEquipo = new CD_Equipo();

        public bool RegistrarEquipo(Equipos Equipo, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (Equipo.Nombre == "")
            {
                Mensaje += "Por favor llene el campo nombre\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjEquipo.RegistrarEquipo(Equipo, out Mensaje);
            }
        }
        public bool EditarEquipo(Equipos Equipo, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (Equipo.Nombre == "")
            {
                Mensaje += "Por favor llene el campo nombre\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjEquipo.EditarEquipo(Equipo, out Mensaje);
            }
        }
        public bool EliminarEquipo(Equipos Equipo, out string Mensaje)
        {
            return ObjEquipo.EliminarEquipo(Equipo, out Mensaje);
        }
    }
}
