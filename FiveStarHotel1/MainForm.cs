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

        private void checkOut1_Load(object sender, EventArgs e)
        {

        }
    }
}
