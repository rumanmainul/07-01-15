using System;
using System.Windows.Forms;
using EmployeeInfirmationApp.BLL;

namespace EmployeeInfirmationApp.UI
{
    public partial class AddDesignationUI : Form
    {
        public AddDesignationUI()
        {
            InitializeComponent();
        }

        private Designation aDesignation;
        private void Save_designaitonButton_Click(object sender, EventArgs e)
        {
            aDesignation = new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;
            DesignationManager aDesignationManager = new DesignationManager();
            string alert = aDesignationManager.Save(aDesignation);
            MessageBox.Show(alert);
        }
    }
}
