using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Datos.Helper
{
    class DataHelper
    {
        public static SqlConnection Conectar(bool _estado)
        {
            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConectarString();

                if (_estado)
                {
                    conn.Open();
                }
                return conn;
            }
            catch
            {
                return null;
            }
        }

        private static string ConectarString()
        {
            StreamReader leer = new StreamReader("");
            return leer.ReadToEnd();

        }


    }
}
