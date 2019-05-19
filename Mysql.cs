using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs
{
    class Mysql
    {
        public static string Mysql_host = "localhost";
        public static string Mysql_user = "root";
        public static string Mysql_pass = "fanxing123";
        public static string Mysql_name = "s1";
        public static string Mysql_port = "3306";
        public static MySqlConnection comy;
        public static MySqlConnection conn;
        public static MySqlConnection link()
        {
            try
            {
                String connetStr = "server=" + Mysql_host + ";port=" + Mysql_port + ";user=" + Mysql_user + ";password=" + Mysql_pass + "; database=" + Mysql_name + ";";
                conn = new MySqlConnection(connetStr);
                return conn;

            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString(),"数据库连接出错");
                return null;
            }
            return null;

        }
    }
}
