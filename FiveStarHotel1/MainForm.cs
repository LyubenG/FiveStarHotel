﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiveStarHotel1;

namespace FiveStarHotel1
{
    public partial class MainForm : Form
    {
        bool darkMode = true;
        bool admin = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public MainForm()
        {
            InitializeComponent();
        }
        private void btnNav_Clicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //Checking which button was clicked.
            MoveArrow(clickedButton); //Moving arrow showing which page is shown.
            SwitchScene(clickedButton); //Switching scene.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exiting application.
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimazing application.
        }

        private void lblNameOfProgram_MouseDown_1(object sender, MouseEventArgs e)
        {
            MoveProgram(e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None; //Removing default top menu.
            homePage1.BringToFront();
            checkOut1.Visible = false;

            if (HasAdminRights())
            {
                btnAddRoom.Visible = true;
                btnEmployees.Visible = true;
            }

            else
            {
                btnAddRoom.Visible = false;
                btnEmployees.Visible = false;
                btnReserve.Location = new Point(0, 149);
                btnCheckOut.Location = new Point(0, 211);
            }
        }

        public void SwitchScene(Button clickedButton) //Switching which user control is shown.
        {
            switch (clickedButton.Text)
            {
                case "Add Room":
                    addRoom1.BringToFront();
                    addRoom1.Visible = true;
                    customerInfo1.Visible = false;
                    checkOut1.Visible = false;
                    homePage1.Visible = false;

                    break;
                case "Home":
                    homePage1.BringToFront();
                    homePage1.Visible = true;
                    customerInfo1.Visible = false;
                    checkOut1.Visible = false;
                    addRoom1.Visible = false;
                    break;
                case "Reserve Room":
                    reserveRoom1.BringToFront();
                    checkOut1.Visible = false;
                    customerInfo1.Visible = false;
                    homePage1.Visible = false;
                    break;
                case "Check Out":
                    checkOut1.BringToFront();
                    customerInfo1.Visible = false;
                    checkOut1.Visible = true;
                    addRoom1.Visible = false;
                    break;
                case "Employee":
                    employee1.BringToFront();
                    customerInfo1.Visible = false;
                    employee1.Visible = true;
                    checkOut1.Visible = false;
                    homePage1.Visible = false;
                    addRoom1.Visible = false;
                    break;
                case "Customers Info":
                    customerInfo1.BringToFront();
                    customerInfo1.Visible = true;
                    employee1.Visible = false;
                    checkOut1.Visible = false;
                    homePage1.Visible = false;
                    addRoom1.Visible = false;
                    break;

            }
        }
        private void cbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDarkMode.Checked == true) // Checking if light mode is enabled
            {
                cbDarkMode.BackgroundImage = Properties.Resources.switchLightMode2;
                darkMode = false;
                ActivateMode();

            }

            else
            {
                cbDarkMode.BackgroundImage = Properties.Resources.swtichDarkMode;
                darkMode = true;
                ActivateMode();
            }
        }

        private void ActivateMode()
        {
            if (darkMode)
            {
                ChangeColours(Color.White); // Method used for changing all the label's colours.

                this.BackColor = Color.FromArgb(42, 46, 55);               //Changing colours and icons.
                panelSideNav.BackColor = Color.FromArgb(26, 26, 26);
                pnlTopNav.BackColor = Color.FromArgb(26, 26, 26);
                pbLogo.BackgroundImage = Properties.Resources.Logo;
                lblNameOfProgram.ForeColor = Color.White;
                btnHome.Image = Properties.Resources.HomeIcon21;
                btnAddRoom.Image = Properties.Resources.ReserveIcon1;
                btnCheckOut.Image = Properties.Resources.CheckOut;
                btnCustomerInfo.Image = Properties.Resources.CustomerInfo;
                btnReserve.Image = Properties.Resources.RingIcon2;
                btnEmployees.Image = Properties.Resources.EmployeesIcon;
                pbArrow.BackgroundImage = Properties.Resources.Arrow;
                cbDarkMode.BackColor = Color.FromArgb(26, 26, 26);

            }

            else
            {
                ChangeColours(Color.Black); // Method used for changing all the label's colours.

                BackColor = Color.FromArgb(214, 214, 214);                  //Changing colours and icons.
                panelSideNav.BackColor = Color.White;
                pnlTopNav.BackColor = Color.White;
                pbLogo.BackgroundImage = Properties.Resources.LogoLightMode;
                lblNameOfProgram.ForeColor = Color.Black;
                btnHome.Image = Properties.Resources.DarkHome;
                btnAddRoom.Image = Properties.Resources.DarkReserve;
                btnCheckOut.Image = Properties.Resources.DarkCheckOut2;
                btnCustomerInfo.Image = Properties.Resources.DarkCustomer;
                btnReserve.Image = Properties.Resources.DarkRing;
                pbArrow.BackgroundImage = Properties.Resources.DarkArrow;
                btnEmployees.Image = Properties.Resources.DarkEmployee;
                cbDarkMode.BackColor = Color.FromArgb(231, 231, 231);
            }
        }

        public void MoveArrow(Button button)
        {
            Point btnLocation = button.Location;
            pbArrow.Location = new Point(161, btnLocation.Y);
        }

        private void MoveProgram(MouseEventArgs e)  //Addition to the moving function
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void ChangeColours(Color colour)
        {
            foreach (Control control in panelSideNav.Controls)
            {
                if (control is Button)
                {
                    control.ForeColor = colour;
                }
            }
        }

        public bool GetMode()
        {
            if (darkMode)
            {
                return true;
            }
            return false;
        }

        public void AdminRights(bool isadmin)
        {
            if (isadmin)
            {
                admin = true;
            }
        }
        public bool HasAdminRights()
        {
            return admin;
        }
    }
}
