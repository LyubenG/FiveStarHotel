using System;
using System.Data.SqlClient;
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
            FormBorderStyle = FormBorderStyle.None;  //Removing default windows top menu.
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
            if (e.KeyChar == (char)Keys.Enter)  //If the user presses enter the login button is clicked automatically.
            {
                btnLogin.PerformClick();
            }
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

            if (!CheckLoginExists()) // If the credentials are wrong the wrong input label is shown.
            {
                lblWrongInfo.Visible = true;
            }

            else // If the login credentials are right the application is being opened.
            {
                GetAdminRights();
                this.Hide();
            }
        }

        public void GetAdminRights() //if login is admin, gets access to all of the app's features 
        {
            if (CheckLoginExists())
            {
                string query = $"select employeeType from employees where username = '{username}' and password= '{password}'";
                SqlDataReader reader = functions.GetForCombo(query);

                MainForm logininfo = new MainForm();

                while (reader.Read())
                {
                    if (reader.GetString(0) == "Admin")
                    {
                        logininfo.AdminRights(true);
                    }
                    else
                    {
                        logininfo.AdminRights(false);
                    }
                }
                reader.Close();
                logininfo.Show();
            }
        }

        private bool CheckLoginExists() //Checking whether there is such user.
        {
            string query = $"select username from employees where username = '{username}' and password = '{password}'";
            SqlDataReader reader = functions.GetForCombo(query);

            while (reader.Read())
            {
                if (username == reader.GetString(0))
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
          
            reader.Close();
            return false;
        }
    }
}
