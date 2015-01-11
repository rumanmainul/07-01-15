using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInfirmationApp.UI;

namespace EmployeeInfirmationApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeUi addEmployeeUI = new AddEmployeeUi();
            addEmployeeUI.Show();
        }

        private void addDesignationButton_Click(object sender, EventArgs e)
        {
            AddDesignationUI aDesignationUI = new AddDesignationUI();
            aDesignationUI.Show();
        }

        private void findAndEditButton_Click(object sender, EventArgs e)
        {
            SearchUI aSearchUi = new SearchUI();
            aSearchUi.Show();
        }

    }
}
