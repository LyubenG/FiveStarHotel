using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FiveStarHotel1.User_Controls
{
    public partial class AddRoom : UserControl
    {
        Functions functions = new Functions();
        string query;

        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string roomNo = tbRoomNo.Text;
                string roomType = cbRoomType.Text;
                string bed = cbBedType.Text;
                int price = int.Parse(tbPrice.Text);

                query = String.Format("insert into rooms (roomNo, roomType, bed, price) values ('{0}', '{1}', '{2}', '{3}')",
                    roomNo, roomType, bed, price);

                functions.setData(query, String.Format("Room Number {0} Has Been Added!", roomNo));

                UpdateRoomData();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields with correct data!", "Invalid input!",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private bool ValidateInput()
        {
            Regex reg = new Regex(@"[^0-9]"); //Regex that detects only numbers from 0 - 9.
            if (tbRoomNo.Text == "" || cbRoomType.Text == "" || cbBedType.Text == "" || tbPrice.Text == "" || reg.IsMatch(tbPrice.Text))
            {
                return false;
            }
            return true;
        }

        private void UpdateRoomData()
        {
            query = "Select * from rooms";
            DataSet ds = functions.getData(query);
            dataRooms.DataSource = ds.Tables[0];
            dataRooms.Columns[0].Visible = false;
        }

        private void AddRoom_VisibleChanged(object sender, EventArgs e)
        {
            UpdateRoomData();
        }
    }
}