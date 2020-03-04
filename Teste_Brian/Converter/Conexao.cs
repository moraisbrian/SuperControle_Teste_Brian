using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Teste_Brian.Converter
{
    class Conexao
    {
        SqlConnection con;

        public Conexao()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlDB"].ConnectionString);
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
