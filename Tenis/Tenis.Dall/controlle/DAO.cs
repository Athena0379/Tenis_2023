using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Configuration;

namespace Tenis.Dall.controlle
{
    public class DAO
    {
        public SqlParameter par;
        public SqlCommand cmd;
        public SqlDataReader reader;

        public static SqlConnection conectar()
        {
            try
            {
                string conexao = ConfigurationManager.ConnectionStrings["Banco"].ConnectionString;
               SqlConnection conn = new SqlConnection(conexao);
                conn.Open();
                return conn;
            }
            catch (Exception Ex)
            {
               
            }
            return null;
        }
    }
}