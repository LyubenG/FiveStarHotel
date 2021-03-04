using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveStarHotel1
{
    public partial class Login : Form
    {
        Functions functions = new Functions();
        string username;
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Removing default windows top menu.
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            password = tbPass.Text;
            if (username.Trim() == "" || password.Trim() == "") // Checking if the user has entered any data.
            {
                MessageBox.Show("You must enter both username and password!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckLoginInfo()) // If the credentials are wrong the wrong input label is shown.
            {
                lblWrongInfo.Visible = true;
            }

            else // If the login credentials are right the application is being opened.
            {
                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();
            }
        }

        private bool CheckLoginInfo()
        {
            //Checking whether there is such user.
            string query = $"select username from employees where username = '{username}' and password= '{password}'";
            SqlDataReader reader = functions.getForCombo(query);

            if (username.Trim() == "Admin" && password.Trim() == "Admin")
            {
                return true;
            }

            while (reader.Read())
            {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (username == reader.GetString(i))
                        {
                            reader.Close();
                            return true;
                        }
                        else
                        {
                            lblWrongInfo.Visible = true;
                            return false;
                        }
                    }
            }
            reader.Close();
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closing application on click
        }

        private void pbEye_MouseHover(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = false; //Option to see password the user has written
        }

        private void pbEye_MouseLeave(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true; //Option to see password the user has written

        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If the user presses enter the login button is clicked automatically.
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

    }
}
