using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfirmationApp
{

    class Designation
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        

        internal void AddNewDesignation(Designation aDesignation)
        {
            string ConnectionString = @"Data Source = (local)\sqlexpress; Database= employeeinformationDB; Integrated Security = true";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            string sqlQuery = "insert into t_disignation values('"+aDesignation.Code+"', '"+aDesignation.Title+"')";
            SqlCommand command = new SqlCommand(sqlQuery, Connection);
            command.ExecuteNonQuery();
        }
    }

   
}
