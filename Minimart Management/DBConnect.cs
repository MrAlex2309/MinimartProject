using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Minimart_Management
{
    class DBConnect
    {
        private static SqlConnection conn;
        private static object locker = new object();
        static DBConnect instance;
        protected DBConnect()
        {
            conn = new SqlConnection("Data Source=DESKTOP-Q3L9KAK;Initial Catalog=MiniMart;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public static DBConnect getInstance()
        {
            if(instance == null)
            {
                lock (locker)
                {
                    if(instance == null)
                    {
                        instance = new DBConnect();
                    }
                }
            }
            return instance;
        }
        public SqlConnection Getcon()
        {
            return conn;
        }
        public void Opencon()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Closecon()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
