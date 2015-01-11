using System.Security.Cryptography;
using EmployeeInformationSystem.DAL.DAO;
using EmployeeInformationSystem.DAL.DBGateway;

namespace EmployeeInformationSystem.BLL
{
    class DesignationManager
    {
        const int MIN_LENGTH_OF_CODE = 3;
        public string Save(Designation aDesignation)
        {
            DesignationDBGateway aDesignationDBGateway = new DesignationDBGateway();
            if (aDesignation.Code.Length >= MIN_LENGTH_OF_CODE)
            {
                Designation designationFound = aDesignationDBGateway.Find(aDesignation.Code);
                if (designationFound == null)
                {
                    aDesignationDBGateway.Save(aDesignation);
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
    }
}
