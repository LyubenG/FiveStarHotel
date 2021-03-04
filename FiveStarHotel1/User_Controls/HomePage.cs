using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveStarHotel1.User_Controls
{
    public partial class HomePage : UserControl
    {
        Functions functions = new Functions();
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnReserve_MouseHover(object sender, EventArgs e)
        {
            btnReserve.BackgroundImage = Properties.Resources.ReserveButtonHover; //Hover effect for the reservation button.
        }

        private void btnReserve_MouseLeave(object sender, EventArgs e)
        {
            btnReserve.BackgroundImage = Properties.Resources.ReserveButton;
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            //Loading data whenever the page is shown or loaded.
            LoadData();
        }

        private void HomePage_VisibleChanged(object sender, EventArgs e)
        {
            //Loading data whenever the page is shown or loaded.

            LoadData();
        }

        private void LoadData()
        {
            //Checking how many rooms are taken and how many are free.
            int freerooms = functions.countData("No");
            lblCountRooms.Text = freerooms.ToString();
            int takenrooms = functions.countData("Yes");
            lblCountGuests.Text = takenrooms.ToString();
            lblCurrentDate.Text = DateTime.Today.ToLongDateString();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)FindForm();
            form.SwitchScene(form.btnReserve);
            form.MoveArrow(form.btnReserve);
        }
    }
}
