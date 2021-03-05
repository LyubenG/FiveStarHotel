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
    public partial class CheckOut : UserControl
    {
        Functions functions = new Functions();
        string query;
        int id;

        public CheckOut()
        {
            InitializeComponent();
        }
        private void pnlBackground_VisibleChanged(object sender, EventArgs e)
        {
            CheckOutLoad();
        }
        private void CheckOut_Load(object sender, EventArgs e)
        {
            CheckOutLoad();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            query = "Select customer.cid, customer.cname, customer.checkin, " +
                "rooms.roomNo, rooms.roomType, rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid" +
                " where cname like '" + tbSearch.Text + "%' and checkout = 'No'";

            DataSet dataset = functions.GetData(query);

            dataCustomers.DataSource = dataset.Tables[0];
            dataCustomers.Columns[0].Visible = false;
        }
        public void CheckOutLoad()
        {
            query = "Select customer.cid, customer.cname," +
                "customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price" +
                " from customer inner join rooms on customer.roomid = rooms.roomid where checkout = 'No'";

            DataSet dataset = functions.GetData(query);

            dataCustomers.DataSource = dataset.Tables[0];
            dataCustomers.Columns[0].Visible = false;
        }

        private void dataCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id = int.Parse(dataCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());

                    tbName.Text = dataCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbRoomNo.Text = dataCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Action", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string checkOutDate = dpCheckOutDate.Text;

                    query = String.Format("update customer set checkout = 'Yes' where cid = '{1}' update rooms set booked = 'No' where roomNo = '{2}'" +
                        " delete from customer where cname = '{3}'", checkOutDate, id, tbRoomNo.Text, tbName.Text);

                    functions.SetData(query, String.Format("Customer {0} Has Successfuly Checked Out!", tbName.Text));

                    CheckOutLoad();
                }
            }
        }
    }
}
