using System;
using System.Data;
using System.Windows.Forms;

namespace FiveStarHotel1.User_Controls
{
    public partial class CustomerInfo : UserControl
    {
        Functions function = new Functions();

        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CustomerInfo_VisibleChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "Select customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, rooms.roomNo" +
               " from customer inner join rooms on customer.roomid = rooms.roomid where checkout = 'No'";

            DataSet dataset = function.GetData(query);

            dataCustomers.DataSource = dataset.Tables[0];
        }
    }
}
