using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Entrada
    {
        private CD_Entrada ObjEntrada = new CD_Entrada();

        /*public bool RegistrarEntrada(Entradas Entrada, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (Entrada.Titulo == "" || Entrada.Tipo == "" || Entrada.Observaciones == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Entrada.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un IdUsuario menor o igual a 0\n";
            }
            if (Entrada.Hora != DateTime.Now.ToString("hh:mm.ss"))
            {
                Mensaje += "El formato de hora es incorrecto\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjEntrada.RegistrarEntrada(Entrada, out Mensaje);
            }
        }
        public bool EditarEntrada(Entradas Entrada, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (Entrada.Titulo == "" || Entrada.Tipo == "" || Entrada.Observaciones == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Entrada.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un Id Usuario menor o igual a 0\n";
            }
            if (Entrada.Hora != DateTime.Now.ToString("hh:mm.ss"))
            {
                Mensaje += "El formato de hora es incorrecto\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjEntrada.EditarEntrada(Entrada, out Mensaje);
            }
        }
        public bool EliminarEntrada(Entradas Entrada, out string Mensaje)
        {
            return ObjEntrada.EliminarEntrada(Entrada, out Mensaje);
        }*/
    }
}
