using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveStarHotel1
{
    public partial class MainForm : Form
    {
        bool darkMode = true;
        // Making the Top menu moveable.
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Removing default top menu.
            FormBorderStyle = FormBorderStyle.None;
            homePage1.BringToFront();
            checkOut1.Visible = false;
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

        private void SwitchScene(Button clickedButton)
        {
            switch (clickedButton.Text)
            {
                case "Add Room":
                    addRoom1.BringToFront();
                    addRoom1.Visible = true;
                    checkOut1.Visible = false;
                    homePage1.Visible = false;

                    break;
                case "Home":
                    homePage1.BringToFront();
                    homePage1.Visible = true;
                    checkOut1.Visible = false;
                    addRoom1.Visible = false;
                    break;
                case "Reserve Room":
                    reserveRoom1.BringToFront();
                    checkOut1.Visible = false;
                    homePage1.Visible = false;
                    break;
                case "Check Out":
                    checkOut1.BringToFront();
                    checkOut1.Visible = true;
                    addRoom1.Visible = false;
                    break;
                case "Employee":
                    employee1.BringToFront();
                    employee1.Visible = true;
                    checkOut1.Visible = false;
                    homePage1.Visible = false;
                    addRoom1.Visible = false;
                    break;

            }
        }

        private void MoveArrow(Button button)
        {
            Point btnLocation = button.Location;
            pbArrow.Location = new Point(161, btnLocation.Y);
        }

        private void MoveProgram(MouseEventArgs e)
        {
            //Addition to the moving function
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void cbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDarkMode.Checked == true)
            {
                cbDarkMode.BackgroundImage = Properties.Resources.switchLightMode2;
                darkMode = false;
                activateMode();
                
            }
            else
            {
                cbDarkMode.BackgroundImage = Properties.Resources.swtichDarkMode;
                darkMode = true;
                activateMode();
            }
        }

        private void activateMode()
        {
            if (darkMode)
            {
                this.BackColor = Color.FromArgb(42, 46, 55);
                panelSideNav.BackColor = Color.FromArgb(26, 26, 26);
                pnlTopNav.BackColor = Color.FromArgb(26, 26, 26);
                pbLogo.BackgroundImage = Properties.Resources.Logo;
                lblNameOfProgram.ForeColor = Color.White;
                btnHome.ForeColor = Color.White;
                btnHome.Image = Properties.Resources.HomeIcon21;
                btnAddRoom.ForeColor = Color.White;
                btnAddRoom.Image = Properties.Resources.ReserveIcon1;

                btnCheckOut.ForeColor = Color.White;
                btnCheckOut.Image = Properties.Resources.CheckOut;
                btnCustomerInfo.ForeColor = Color.White;
                btnCustomerInfo.Image = Properties.Resources.CustomerInfo;
                btnReserve.ForeColor = Color.White;
                btnReserve.Image = Properties.Resources.RingIcon2;
                btnEmployees.ForeColor = Color.White;
                btnEmployees.Image = Properties.Resources.EmployeesIcon;
                pbArrow.BackgroundImage = Properties.Resources.Arrow;
                cbDarkMode.BackColor = Color.FromArgb(26, 26, 26);

            }
            else
            {
                this.BackColor = Color.FromArgb(214, 214, 214);
                panelSideNav.BackColor = Color.White;
                pnlTopNav.BackColor = Color.White;
                pbLogo.BackgroundImage = Properties.Resources.LogoLightMode;
                lblNameOfProgram.ForeColor = Color.Black;

                btnHome.ForeColor = Color.Black;
                btnHome.Image = Properties.Resources.DarkHome;
                btnAddRoom.ForeColor = Color.Black;
                btnAddRoom.Image = Properties.Resources.DarkReserve;

                btnCheckOut.ForeColor = Color.Black;
                btnCheckOut.Image = Properties.Resources.DarkCheckOut2;
                btnCustomerInfo.ForeColor = Color.Black;
                btnCustomerInfo.Image = Properties.Resources.DarkCustomer;
                btnReserve.ForeColor = Color.Black;
                btnReserve.Image = Properties.Resources.DarkRing;
                btnEmployees.ForeColor = Color.Black;
                pbArrow.BackgroundImage = Properties.Resources.DarkArrow;
                btnEmployees.Image = Properties.Resources.DarkEmployee;
                cbDarkMode.BackColor = Color.FromArgb(241, 241, 241);

            }
        }

        private void cbDarkMode_MouseHover(object sender, EventArgs e)
        {
            if (darkMode)
            {
                cbDarkMode.BackColor = Color.FromArgb(26, 26, 26);
            } else
            {
                cbDarkMode.BackColor = Color.FromArgb(241, 241, 241);
            }
        }
    }
}
