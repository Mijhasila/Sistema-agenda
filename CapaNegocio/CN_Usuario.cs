using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario ObjUsuario = new CD_Usuario();
        public bool Listar()
        {
            return ObjUsuario.Listar();
        }
        public bool RegistrarUsuario(Usuarios Usuario, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (Usuario.Nombre1 == "" || Usuario.Nombre2 == "" || Usuario.Apellido1 == "" || Usuario.Apellido2 == "" || Usuario.Cedula == ""
                || Usuario.Sexo == "" || Usuario.Direccion == "" || Usuario.Telefono == "" || Usuario.Correo == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Usuario.IdUsuarioCreador<= 0)
            {
                Mensaje += "No es permitido un idUsuario menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjUsuario.RegistrarUsuarios(Usuario, out Mensaje);
            }
        }
        public bool EditarUsuario(Usuarios Usuario, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (Usuario.Nombre1 == "" || Usuario.Nombre2 == "" || Usuario.Apellido1 == "" || Usuario.Apellido2 == "" || Usuario.Cedula == ""
                || Usuario.Sexo == "" || Usuario.Direccion == "" || Usuario.Telefono == "" || Usuario.Correo == "")
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Usuario.IdUsuarioCreador <= 0)
            {
                Mensaje += "No es permitido un idUsuario menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjUsuario.EditarUsuarios(Usuario, out Mensaje);
            }
        }
        public bool EliminarUsuario(Usuarios Usuario, out string Mensaje)
        {
            return ObjUsuario.EliminarUsuarios(Usuario, out Mensaje);
        }
    }
}
