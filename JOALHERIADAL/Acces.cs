using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace JOALHERIADAL
{
    public class Acces
    {
        Conexao con = new Conexao();

        //CONHECIMENTO ABSORVIDO
        public static DataSet ExecuteReader(IDbCommand cmd)
        {
            DataSet ds = null;
            IDbDataAdapter da = new SqlDataAdapter((SqlCommand)cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
