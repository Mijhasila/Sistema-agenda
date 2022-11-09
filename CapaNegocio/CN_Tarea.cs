using APP__Agenda;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Tarea
    {
        private CD_Tarea ObjTarea = new CD_Tarea();
        public bool Listar()
        {
            return ObjTarea.Listar();
        }
        public bool RegistrarTarea(Tareas Tarea, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (Tarea.Prioridad == "" || Tarea.Descripcion == "" || Tarea.Estado == 0)
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Tarea.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un Id Usuario menor o igual a 0\n";
            }
            if (Tarea.oCategoria.IdCategoria <= 0)
            {
                Mensaje += "No es permitido un Id Categoria menor o igual a 0\n";
            }
            if (Tarea.oEntradas.IdEntrada <= 0)
            {
                Mensaje += "No es permitido un Id Entrada menor o igual a 0\n";
            }   
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjTarea.RegistrarTarea(Tarea, out Mensaje);
            }
        }
        public bool EditarTarea(Tareas Tarea, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (Tarea.Prioridad == "" || Tarea.Descripcion == "" || Tarea.Estado == 0)
            {
                Mensaje += "Por favor llene Todos los campos\n";
            }
            if (Tarea.oUsuarios.IdUsuario <= 0)
            {
                Mensaje += "No es permitido un Id Usuario menor o igual a 0\n";
            }
            if (Tarea.oCategoria.IdCategoria <= 0)
            {
                Mensaje += "No es permitido un Id Categoria menor o igual a 0\n";
            }
            if (Tarea.oEntradas.IdEntrada <= 0)
            {
                Mensaje += "No es permitido un Id Entrada menor o igual a 0\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return ObjTarea.EditarTarea(Tarea, out Mensaje);
            }
        }
        public bool EliminarTarea(Tareas Tarea, out string Mensaje)
        {
            return ObjTarea.EliminarTarea(Tarea, out Mensaje);
        }
    }
}
