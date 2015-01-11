using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeInfirmationApp.BLL;
using EmployeeInfirmationApp.DAL.DAO;

namespace EmployeeInfirmationApp.UI
{
    public partial class SearchUI : Form
    {
        public SearchUI()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DesignationManager aDesignationManager = new DesignationManager();
            DataView aView = new DataView();
            string name = searchTextBox.Text;
            List<DataView> aDataViewList = new List<DataView>();
            aDataViewList = aDesignationManager.ShowAllEmployee(name);
            showListView.Items.Clear();
            ListViewItem aListViewItem = new ListViewItem();
            foreach (DataView aDataView in aDataViewList)
            {
                aListViewItem = new ListViewItem();
                aListViewItem.Text = aDataView.EmployeeId;
                aListViewItem.SubItems.Add(aDataView.Name);
                aListViewItem.SubItems.Add(aDataView.Email);
                aListViewItem.SubItems.Add(aDataView.Designation);
                showListView.Items.Add(aListViewItem);
            }
            
            
        }
    }
}
