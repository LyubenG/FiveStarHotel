using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FiveStarHotel1.User_Controls
{
    public partial class Employee : UserControl
    {
        Functions functions = new Functions();
        List<string> employeeToEdit = new List<string>();
        string employeeToDelete = "";

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

                if (!CheckIfEmployeeIsAlreadyAdded(username)) // Checking if the employee has already been added.
                {
                    string query = $"insert into employees (username, password, employeeType) values ('{username}', '{password}', '{employeeType}')";
                    string message = $"User {username} Has Been Added!";

                    functions.SetData(query, message); // Sending query to the SQL DB.

                    UpdateEmployeeData(); // Updating the Table.
                    ClearInputData(); // Clearing textboxes.
                }

                else
                {
                    MessageBox.Show("This employee has already been added!");
                    ClearInputData();
                }
            }

            else
            {
                MessageBox.Show("Please fill in all the fields!"); // If the textboxes are empty.
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (employeeToDelete.Trim() != "") //Checking if the user has selected a row.
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete user \"{employeeToDelete}\"?", "Delete user?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = $"delete from dbo.employees where username = '{employeeToDelete}'";
                    string message = $"User {employeeToDelete} has succesfully been removed!";

                    functions.SetData(query, message);
                    employeeToDelete = "";

                    UpdateEmployeeData();
                }
            }

            else
            {
                MessageBox.Show("You must select a employee to be removed!"); // If user hasn't selected a row.
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string employeeType = cbEmployeeType.Text;

                if (username == employeeToEdit[0])
                {
                    string query = $"update employees set username = '{employeeToEdit[1]}', password = '{password}', employeeType ='{employeeType}' where username='{employeeToEdit[1]}'";
                    string message = $"Employee {username} Has Been Changed!";

                    functions.SetData(query, message);

                    UpdateEmployeeData();
                    ClearInputData();
                }

                else
                {
                    MessageBox.Show("Please do not change the Username, create new Employee instead!", "Invalid input!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool CheckIfEmployeeIsAlreadyAdded(string username)
        {
            string currentUsername;

            for (int i = 0; i < dataEmployees.RowCount; i++)
            {
                DataGridViewRow row = dataEmployees.Rows[i]; //Going through all the rows.
                currentUsername = row.Cells[1].Value.ToString(); //Getting username of current row.

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
                    employeeToDelete = row.Cells[1].Value.ToString();

                    employeeToEdit.Clear();

                    for (int p = 0; p < dataEmployees.ColumnCount; p++)
                    {

                        employeeToEdit.Add(row.Cells[p].Value.ToString()); //Getting username of current row.
                    }

                    tbUsername.Text = employeeToEdit[0];
                    tbPassword.Text = employeeToEdit[1];
                    cbEmployeeType.Text = employeeToEdit[2];

                }
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
            DataSet ds = functions.GetData(query);
            dataEmployees.DataSource = ds.Tables[0];
        }

        private void ClearInputData()
        {
            tbPassword.Clear();
            tbUsername.Clear();
            cbEmployeeType.SelectedIndex = -1;
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
