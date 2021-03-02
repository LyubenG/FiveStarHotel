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
                //Getting username, password and type.
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string employeeType = cbEmployeeType.Text;

                if (!checkIfEmployeeIsAlreadyAdded(username)) // Checking if the employee has already been added.
                {
                    string query = $"insert into employees (username, password, employeeType) " +
                        $"values ('{username}', '{password}', '{employeeType}')"; // Sending query to the SQL DB.
                    functions.setData(query, $"User {username} Has Been Added!");

                    UpdateEmployeeData(); // Updating the Table.
                    clearAllData(); // Clearing textboxes.
                } else
                {
                    MessageBox.Show("This employee has already been added!");
                    clearAllData();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!"); // If the textboxes are empty.
            }
        }

        string usernameToDelete = "";
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (usernameToDelete.Trim() != "" && usernameToDelete != null) //Checking if the user has selected a row.
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete user {usernameToDelete}?", "Delete user?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = $"delete from dbo.employees where username = '{usernameToDelete}'";
                    functions.setData(query, $"User {usernameToDelete} has succesfully been removed!");
                    usernameToDelete = "";
                    UpdateEmployeeData();
                }
            }
            else
            {
                MessageBox.Show("You must select a employee to be removed!"); // If user hasn't selected a row.
            }

        }

        private bool checkIfEmployeeIsAlreadyAdded(string username)
        {
            string currentUsername;
            
            for (int i = 0; i < dataEmployees.RowCount; i++)
            {
                DataGridViewRow row = dataEmployees.Rows[i]; //Going through all the rows.
                currentUsername = row.Cells[i].Value.ToString(); //Getting username of current row.
                if (username == currentUsername)
                {
                    return true;
                }
            }
            return false;

        }

        private void dataEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewRow row = dataEmployees.Rows[e.RowIndex];
                    usernameToDelete = row.Cells[1].Value.ToString();
                }
            }
        }

        private void clearAllData()
        {
            tbPassword.Clear();
            tbUsername.Clear();
            cbEmployeeType.SelectedIndex = -1;
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

        private void pbEye_MouseHover(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void pbEye_MouseLeave(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;

        }
    }
}
