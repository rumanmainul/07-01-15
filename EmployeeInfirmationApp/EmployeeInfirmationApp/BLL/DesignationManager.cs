using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfirmationApp.DAL.DBGateway;
using System.Text.RegularExpressions;
using System.Data;
using EmployeeInfirmationApp.DAL.DAO;
namespace EmployeeInfirmationApp.BLL
{
    class DesignationManager
    {
        const int MIN_LENGTH_OF_CODE = 3;
        private DesignationDbGateway aDbGateway;
        public string Save(Designation aDesignation)
        {
            aDbGateway = new DesignationDbGateway();
            
            if (aDesignation.Code.Length >= MIN_LENGTH_OF_CODE)
            {
                Designation designationFound = aDbGateway.Find(aDesignation.Code);
                if (designationFound == null)
                {
                    aDbGateway.Save(aDesignation);
                    return "Saved";
                }
                else
                {
                    return "This code already exists";
                }
            }
            else
            {
                return "Code must be " + MIN_LENGTH_OF_CODE + " char long";
            }
        }

        internal List<Designation> GetTitle()
        {
            aDbGateway = new DesignationDbGateway();
            List<Designation> aDesignationsList = new List<Designation>();
            aDesignationsList = aDbGateway.GetTitleFromDB();
            return aDesignationsList;
        }

        public bool IsValidMailCheke(string email)
        {
            string emailString = email;
            bool isEmail = Regex.IsMatch(emailString, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }

        internal string AddEmployee(Employee aEmployee)
        {
            aDbGateway = new DesignationDbGateway();
            bool IsEmailvalid = IsValidMailCheke(aEmployee.Email);
            if (IsEmailvalid == true)
            {
                bool IsEmailNotDuplicate = aDbGateway.CheckDuplicateEmail(aEmployee.Email);
                if(IsEmailNotDuplicate)
                {                   
                    bool alert = aDbGateway.AddEmployeeToDB(aEmployee);
                    if (alert == true)
                    {
                        return "Add Employee";
                    }
                    else
                    {
                        return "Please check database connection or other problems occure";
                    }
                    
                }
                else
                {
                    return "This Email is already used";
                }
          
            }
            else
            {
                return "This is not valid email";
            }
        }

        internal List<EmployeeInfirmationApp.DAL.DAO.DataView> ShowAllEmployee(string name)
        {
                aDbGateway = new DesignationDbGateway();
                List<EmployeeInfirmationApp.DAL.DAO.DataView> aListOfData = new List<EmployeeInfirmationApp.DAL.DAO.DataView>();
                aListOfData = aDbGateway.GetDataFromDatabase(name);
                return aListOfData;
        }
    }
}
