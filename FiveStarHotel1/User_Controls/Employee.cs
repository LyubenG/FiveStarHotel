using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveStarHotel1.User_Controls
{
    public partial class Employee : UserControl
    {
        Functions functions = new Functions();

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            UpdateEmployeeData();
        }

        private void Employee_VisibleChanged(object sender, EventArgs e)
        {
            UpdateEmployeeData();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string employeeType = cbEmployeeType.Text;


                string query = $"insert into employees (username, password, employeeType) values ('{username}', '{password}', '{employeeType}')";


                functions.setData(query, $"User {username} Has Been Added!");

                UpdateEmployeeData();
            }

            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }

        private bool ValidateInput()
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || cbEmployeeType.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void UpdateEmployeeData()
        {
            string query = "Select * from employees";
            DataSet ds = functions.getData(query);
            dataEmployees.DataSource = ds.Tables[0];
            


        }


    }
}
