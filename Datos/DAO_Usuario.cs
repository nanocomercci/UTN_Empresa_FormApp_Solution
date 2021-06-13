using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Acciones
{
    
    class DAO_Usuario
    {
        List<Usuario> Usuarios = new List<Usuario>();

        public bool Alta (Usuario _usuario)
        {
            try
            {
            Usuarios.Add(_usuario);
            return true;
            }
            catch
            {
                return false;
            }

        }
        public bool BuscarUsuario(Usuario _usuario)
        {
            try
            {
                foreach(Usuario u in Usuarios)
                {
                    if(u.NombreUsuario==_usuario.NombreUsuario && u.Password == _usuario.Password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
