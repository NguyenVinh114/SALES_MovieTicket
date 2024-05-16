using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Movie_ticket_sales_management_app.DAL
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=PC\SQLEXPRESS;Initial Catalog=QL_Banvexemphim;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
