using EmployeeInfirmationApp.BLL;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace EmployeeInfirmationApp
{
    class Employee
    {
        public string EmployeeName { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Code { set; get; }

    }
}