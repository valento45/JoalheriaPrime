using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOALHERIADAL
{
    public class BackupDAL
    {
        public static bool GerarBackup(string filename)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE BDJOALHERIA TO DISK = '" + filename + "'");
                Acces.ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gerar o backup ! \n\r\n\r\n\r " + ex.Message, "OPS!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NetworkLog.Insert(ex, "Method GerarBackup in BackupDAL.cs");
                return false;
            }
        }

        public static void RestaurarBackup(string filename)
        {
            SqlCommand cmd = new SqlCommand("USE MASTER; RESTORE DATABASE BDJOALHERIA FROM DISK = '" + filename + "' WITH REPLACE");
            if (Acces.ExecuteNonQuery(cmd)) { MessageBox.Show("Backup restaurado com sucesso!"); }
        }
    }
}
