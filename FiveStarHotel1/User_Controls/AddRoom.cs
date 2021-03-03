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
        string roomToDelete;


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

                if (!CheckIfRoomIsAlreadyAdded(roomNo)) // Checking if the employee has already been added.
                {

                    query = String.Format("insert into rooms (roomNo, roomType, bed, price) values ('{0}', '{1}', '{2}', '{3}')",
                roomNo, roomType, bed, price);

                    functions.setData(query, String.Format("Room Number {0} Has Been Added!", roomNo));

                    UpdateRoomData();
                }
                else
                {
                    MessageBox.Show("This room has already been added!");
                    tbRoomNo.Text = null; 
                }

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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (roomToDelete.Trim() != "" && roomToDelete != null) //Checking if the user has selected a row.
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete room {roomToDelete}?", "Delete user?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = $"delete from dbo.rooms where roomNo = '{roomToDelete}'";
                   
                    functions.setData(query, $"Room {roomToDelete} has succesfully been removed!");
                    roomToDelete = "";
                   
                    UpdateRoomData();
                }
            }
            else
            {
                MessageBox.Show("You must select a room to be removed!"); // If user hasn't selected a row.
            }
        }

        private bool CheckIfRoomIsAlreadyAdded(string roomNo)
        {
            string currentRoomNo;
            for (int i = 0; i < dataRooms.RowCount; i++)
            {
                DataGridViewRow row = dataRooms.Rows[i]; //Going through all the rows.
                currentRoomNo = row.Cells[1].Value.ToString(); //Getting username of current row.
                if (roomNo == currentRoomNo)
                {
                    return true;
                }
            }
            return false;
        }
        

        private void dataRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewRow row = dataRooms.Rows[e.RowIndex];
                    roomToDelete = row.Cells[1].Value.ToString();
                }
            }
        }
    }
}