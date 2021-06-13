using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient
using Datos.Helper;

namespace Datos
{
    class DAO_Cliente : Interfaces.ICRUD<Cliente>
    {
        public bool Create(Cliente Entidad)
        {
            SqlConnection conn = DataHelper.Conectar(true);
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "sp_AgregarCliente";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;


            SqlParameter paramDNI = new SqlParameter("@dni", SqlDbType.NVarChar, 50);

            //asi con todos los parámetros

            //despues asignar los valores

            paramDNI.Value=Entidad.

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
