using EmployeeInfirmationApp.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EmployeeInfirmationApp.DAL.DBGateway
{
    class DesignationDbGateway
    {
       string connectionStr = @"Data Source = (local)\sqlexpress; Database= employeeinformationDB; Integrated Security = true";
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;
        public DesignationDbGateway()
        {
            aSqlConnection = new SqlConnection(connectionStr);
        }

        public void Save(Designation aDesignation)
        {
            string query = "INSERT INTO t_disignation VALUES ('" + aDesignation.Code + "','" + aDesignation.Title 
                + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Designation Find(string code)
        {
            string query = "SELECT * FROM t_disignation WHERE Code = '" + code + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            Designation aDesignation;

            if (aDataReader.HasRows)
            {
                aDesignation = new Designation();
                aDataReader.Read();
                aDesignation.Id = Convert.ToInt32(aDataReader["Id"]);
                aDesignation.Code = aDataReader["Code"].ToString();
                aDesignation.Title = aDataReader["Title"].ToString();
                aDataReader.Close();
                aSqlConnection.Close();
                return aDesignation;
            }
            else
            {
                aSqlConnection.Close();
                return null;
            }
        }

        internal List<Designation> GetTitleFromDB()
        {
            List<Designation> designationList = new List<Designation>();
            SqlConnection Connection = new SqlConnection(connectionStr);
            Connection.Open();
            string sqlQuery = "SELECT * FROM t_disignation";
            SqlCommand command = new SqlCommand(sqlQuery, Connection);
            SqlDataReader aReader = command.ExecuteReader();
            while (aReader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.Code = aReader["Code"].ToString();
                aDesignation.Title = aReader["Title"].ToString();
                designationList.Add(aDesignation);
            }
            Connection.Close();
            return designationList;
        }

        public bool AddEmployeeToDB(Employee aEmployee)
        {
            aSqlConnection = new SqlConnection(connectionStr);
            aSqlConnection.Open();
            string sqlQuery = "insert into employee_info values('" + aEmployee.EmployeeName + "', '" +
                                  aEmployee.Email + "', '" + aEmployee.Address + "', '" + aEmployee.Code + "')";
            SqlCommand command = new SqlCommand(sqlQuery, aSqlConnection);
            int effectedRow = command.ExecuteNonQuery();
            aSqlConnection.Close();
            if(effectedRow>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool CheckDuplicateEmail(string Email)
        {
            aSqlConnection= new SqlConnection(connectionStr);
            aSqlConnection.Open();
            
            string sqlQuery = "SELECT * FROM employee_info WHERE email = '"+Email+"'";
            SqlCommand command = new SqlCommand(sqlQuery, aSqlConnection);
            SqlDataReader aReader = command.ExecuteReader();
            
            bool hasData = aReader.HasRows;
            aSqlConnection.Close();
            if(hasData)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        internal List<EmployeeInfirmationApp.DAL.DAO.DataView> GetDataFromDatabase(string name)
        {
            EmployeeInfirmationApp.DAL.DAO.DataView aDataView;
            List<EmployeeInfirmationApp.DAL.DAO.DataView> aDataList = new List<EmployeeInfirmationApp.DAL.DAO.DataView>(); 
            aSqlConnection = new SqlConnection(connectionStr);
            aSqlConnection.Open();

            string sqlQuery = "SELECT  em.id, em.name, em.email, dg.Title from employee_info em JOIN t_disignation dg ON em.designation = dg.Code where em.name = '"+name+"'";
            SqlCommand command = new SqlCommand(sqlQuery, aSqlConnection);
            SqlDataReader aReader = command.ExecuteReader();
            while (aReader.Read())
            {
                aDataView = new EmployeeInfirmationApp.DAL.DAO.DataView();
                aDataView.EmployeeId = aReader["id"].ToString();
                aDataView.Name = aReader["name"].ToString();
                aDataView.Email = aReader["email"].ToString();
                aDataView.Designation = aReader["Title"].ToString();
                aDataList.Add(aDataView);
            }
            return aDataList;
        }
    }
}
