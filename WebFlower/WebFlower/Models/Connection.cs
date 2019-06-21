using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _14130046_DoManhHung.Models
{
    public class Connection
    {
        public static MySqlConnection conn =
            new MySqlConnection("Database=test;Data Source=127.0.0.1;User Id=root;Password=");
        public static bool isOpen()
        {
            return conn.State == ConnectionState.Open;
        }
        public static void openConnect()
        {
            conn.Open();
        }
        public static void closeConnect()
        {
            conn.Close();
        }
    }
}