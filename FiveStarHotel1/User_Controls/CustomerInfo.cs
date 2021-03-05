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
    public partial class CustomerInfo : UserControl
    {
        Functions function = new Functions();
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            loadData();
        }

        string query;
        private void loadData()
        {
            query = "Select customer.cname, " +
              "customer.mobile, customer.nationality, customer.gender, customer.dob, rooms.roomNo" +
              " from customer inner join rooms on customer.roomid = rooms.roomid where checkout = 'No'";
            DataSet dataset = function.getData(query);

            dataCustomers.DataSource = dataset.Tables[0];
        }

        private void CustomerInfo_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
