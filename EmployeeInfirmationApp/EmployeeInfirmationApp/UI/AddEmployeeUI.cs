using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeInfirmationApp.BLL;

namespace EmployeeInfirmationApp.UI
{
    public partial class AddEmployeeUi : Form
    {
        public AddEmployeeUi()
        {
            InitializeComponent();
        }

        private Designation aDesignation;
        private void AddEmployeeUI_Load(object sender, EventArgs e)
        {
            aDesignation = new Designation();
            DesignationManager aDesignationManager = new DesignationManager();
            List<Designation> aDesignationsList = new List<Designation>();
            aDesignationsList = aDesignationManager.GetTitle();
            designationComboBox.Items.Clear();
            foreach (Designation designations in aDesignationsList)
            {
                designationComboBox.Items.Add(designations);
            }
            designationComboBox.DisplayMember = "Title";
            designationComboBox.ValueMember = "Code";
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee();  
            DesignationManager aDesignationManager = new DesignationManager();
            aEmployee.EmployeeName = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.Address = addressTextBox.Text;
            Designation aDesignation = (Designation) designationComboBox.SelectedItem;
            aEmployee.Code = aDesignation.Code;
            string alert = aDesignationManager.AddEmployee(aEmployee);
            
            MessageBox.Show(alert);
        }

        
    }
}
