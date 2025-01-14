using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=HARRISONNGUYEN\MSSQLSERVER2K2;Initial Catalog=QLBanHang#;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //static string strConnection = System.Configuration.ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
        //protected  SqlConnection _conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLBanHang1.mdf;Integrated Security=True"); //OK
        //protected SqlConnection _conn = new SqlConnection(strConnection);        
    } 
}
