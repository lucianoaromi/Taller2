using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        // "objcd_usuario" es una instancia de la clase CD_Usuario
        private CD_Usuario objcd_usuario = new CD_Usuario();


        //Retorna la lista que posee la clase "CD_Usuario" que se encuentra en la capa de datos
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();

        }

        //Puente de comunicacion con la "Capa de Presentacion"
        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }


            if(Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }
            

        }

        //Puente de comunicacion con la "Capa de Presentacion"
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }


            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }

        }


        //Puente de comunicacion con la "Capa de Presentacion"
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);

        }
    }
}