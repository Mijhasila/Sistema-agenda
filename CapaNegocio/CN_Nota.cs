using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Nota
    {
        private CD_Nota ObjNota = new CD_Nota();
        public bool Listar()
        {
            return ObjNota.Listar();
        }
        public bool RegistrarNota(Notas Nota, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (Nota.Titulo == "" || Nota.Descripcion == "" || Nota.oCategoria.Nombre == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Nota.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un Id Nota menor o igual a 0\n";
            }
            if (Nota.oEntrada.IdEntrada <= 0)
            {
                Mensaje += "No es permitido un id entrada menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjNota.RegistrarNota(Nota, out Mensaje);
            }
        }
        public bool EditarNota(Notas Nota, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (Nota.Titulo == "" || Nota.Descripcion == "" || Nota.oCategoria.Nombre == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Nota.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un Id Nota menor o igual a 0\n";
            }
            if (Nota.oEntrada.IdEntrada <= 0)
            {
                Mensaje += "No es permitido un id entrada menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjNota.EditarNota(Nota, out Mensaje);
            }
        }
        public bool EliminarNota(Notas Nota, out string Mensaje)
        {
            return ObjNota.EliminarNota(Nota, out Mensaje);
        }
    }
}
