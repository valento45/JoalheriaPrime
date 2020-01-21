using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
//using Npgsql;

namespace JOALHERIADAL
{
    public class Conexao
    {

        //SQL SERVER
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PLV91ND\SQLEXPRESS;Initial Catalog=BDJOALHERIA;Integrated Security=true;");

        public SqlConnection Conectar()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }



        //POSTGREE SQL




    }
}
