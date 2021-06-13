using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using Interfaces;
using System.Data;


namespace Acciones
{
    public class Acccion_Cliente : Interfaces.ICRUD<Cliente>
    {
        public bool Create(Cliente Entidad)
        {
            
        }

        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public Cliente Read(object ID)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
