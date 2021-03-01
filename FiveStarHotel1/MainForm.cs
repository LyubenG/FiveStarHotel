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

        }
        private void btnNav_Clicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //Checking which button was clicked.
            moveArrow(clickedButton); //Moving arrow showing which page is shown.
            switchScene(clickedButton); //Switching scene.
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
            moveProgram(e);
        }

        private void switchScene(Button clickedButton)
        {
            switch (clickedButton.Text)
            {
                case "Add Room": addRoom1.BringToFront(); homePage1.Visible = false; break;
                case "Home": homePage1.BringToFront(); homePage1.Visible = true; break;
                case "Reserve Room": reserveRoom1.BringToFront(); homePage1.Visible = false; break;
                case "Check Out": checkOut1.BringToFront(); break;
            }
        }

        private void moveArrow(Button button)
        {
            Point btnLocation = button.Location;
            pbArrow.Location = new Point(161, btnLocation.Y);
        }

        private void moveProgram(MouseEventArgs e)
        {
            //Addition to the moving function
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
