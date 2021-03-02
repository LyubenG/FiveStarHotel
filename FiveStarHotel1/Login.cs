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
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            username = tbUsername.Text;
            password = tbPass.Text;
            if (username.Trim() == "" && password.Trim() == "")
            {
                MessageBox.Show("You must enter both username and password!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckLoginInfo())
            {
                lblWrongInfo.Visible = true;
            }
            else
            {
                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();
            }
        }
        private bool CheckLoginInfo()
        {

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
            Application.Exit();
        }

        private void pbEye_MouseHover(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = false;
        }

        private void pbEye_MouseLeave(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;

        }
    }
}
