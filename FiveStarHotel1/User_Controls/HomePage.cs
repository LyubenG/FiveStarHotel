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
        Functions fn = new Functions();
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnReserve_MouseHover(object sender, EventArgs e)
        {
            btnReserve.BackgroundImage = Properties.Resources.ReserveButtonHover;
        }

        private void btnReserve_MouseLeave(object sender, EventArgs e)
        {
            btnReserve.BackgroundImage = Properties.Resources.ReserveButton;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void HomePage_VisibleChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            int freerooms = fn.countData("No");
            lblCountRooms.Text = freerooms.ToString();
            int takenrooms = fn.countData("Yes");
            lblCountGuests.Text = takenrooms.ToString();
            lblCurrentDate.Text = DateTime.Today.ToLongDateString();
        }
    }
}
