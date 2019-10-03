using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess
{
    public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection("data source =. ; database = HiTechDB ; Integrated Security = SSPI");
            connDB.Open();
            return connDB;
        }
    }
}
