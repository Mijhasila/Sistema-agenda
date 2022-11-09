using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Directorio
    {
        private CD_Directorio ObjDirectorio = new CD_Directorio();
        public bool Listar()
        {
            return ObjDirectorio.Listar();
        }
        public bool RegistrarDirectorio(Directorio directorio, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (directorio.Nombre1 == "" || directorio.Nombre2 == "" || directorio.Apellido1 == "" || directorio.Apellido2 == "" 
                || directorio.Alias == "" || directorio.Direccion == "" || directorio.Telefono == "" || directorio.Correo == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (directorio.oUsuarios.IdUsuario <= 0 )
            {
                Mensaje += "No es permitido un IdUsuario menor o igual a 0\n";
            }
            if (directorio.oEntrada.IdEntrada <= 0)
            {
                Mensaje += "No es permitido un IdEntrada menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjDirectorio.RegistrarDirectorio(directorio, out Mensaje);
            }
        }
        public bool EditarDirectorio(Directorio directorio, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (directorio.Nombre1 == "" || directorio.Nombre2 == "" || directorio.Apellido1 == "" || directorio.Apellido2 == ""
                || directorio.Alias == "" || directorio.Direccion == "" || directorio.Telefono == "" || directorio.Correo == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (directorio.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un IdUsuario menor o igual a 0\n";
            }
            if (directorio.oEntrada.IdEntrada <= 0)
            {
                Mensaje += "No es permitido un IdEntrada menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjDirectorio.EditarDirectorio(directorio, out Mensaje);
            }
        }
        public bool EliminarDirectorio(Directorio Directorio, out string Mensaje)
        {
            return ObjDirectorio.EliminarDirectorio(Directorio, out Mensaje);
        }
    }
}
