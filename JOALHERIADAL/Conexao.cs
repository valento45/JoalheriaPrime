﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace JOALHERIADAL
{
    public class Conexao
    {
        string a = "x00";
        string b = "d";
        
        //SQL SERVER
        SqlConnection con = new SqlConnection(@"Data Source=MX15733\DEVELOPER;Initial Catalog=BDJOALHERIA;Integrated Security=true;");
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
                con.Close();
        }
    }
}
