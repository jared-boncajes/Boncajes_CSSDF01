using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boncajes_EMS.CRUD
{
    class connection //Same lang dun sa last project cinoconnect nito yung forms app sa database pero di pa to tapos ni sir.
    {  //>>> Insert Constring here!

        static string dbPath = @"C:\LOCALDB\EMS.mdb";
        public static string conString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbPath};";
        //private static string conString = " Data Source = tcp:127.2.3.4; Initial Catalog = TestDB; User ID = saa; Password= Password=P@ssw0rd;";


        public static OleDbConnection mysqldb() //If red ang OleDB [Show Potential Fixes tapos using System.Data.OleDb]
        {
            return new OleDbConnection(conString);

        }
        public static OleDbConnection con = mysqldb();
    }
}
