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
    public partial class AddRoom : UserControl
    {
        Functions fn = new Functions();
        string query;
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                string roomNo = tbRoomNo.Text;
                string roomType = cbRoomType.Text;
                string bed = cbBedType.Text;
                int price = int.Parse(tbPrice.Text);
                query = String.Format("insert into rooms (roomNo, roomType, bed, price) values ('{0}', '{1}', '{2}', '{3}')", roomNo, roomType, bed, price);
                fn.setData(query, String.Format("Room Number {0} Has Been Added!", roomNo));
            }
            else
            {
                MessageBox.Show("You must fill in all data!");
            }

            updateRoomData();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            updateRoomData();
        }

        private bool validateInput()
        {
            if (tbRoomNo.Text == "" && tbPrice.Text == "" && cbBedType.Text == "" && cbRoomType.Text == "")
            {
                return false;
            }
            return true;
        }

        private void updateRoomData()
        {
            query = "Select * from rooms";
            DataSet ds = fn.getData(query);
            dataRooms.DataSource = ds.Tables[0];
            dataRooms.Columns[0].Visible = false;
        }


 
    }
}
