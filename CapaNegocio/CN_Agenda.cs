using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Agenda
    {
        private CD_Agenda ObjAgenda = new CD_Agenda();
        public bool Listar()
        {
            return ObjAgenda.Listar();
        }
        public bool RegistrarAgenda(Agenda Agenda, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (Agenda.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un IdUsuario menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjAgenda.RegistrarAgenda(Agenda, out Mensaje);
            }
        }
        public bool EditarAgenda(Agenda Agenda, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (Agenda.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un IdUsuario menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjAgenda.EditarAgenda(Agenda, out Mensaje);
            }
        }
        public bool EliminarAgenda(Agenda Agenda, out string Mensaje)
        {
            return ObjAgenda.EliminarAgenda(Agenda, out Mensaje);
        }
    }
}
