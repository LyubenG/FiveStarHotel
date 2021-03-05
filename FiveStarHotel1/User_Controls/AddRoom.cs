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
        List<string> roomToEdit = new List<string>();
        string roomToDelete;


        public AddRoom()
        {
            InitializeComponent();
        }
        private void AddRoom_VisibleChanged(object sender, EventArgs e)
        {
            UpdateRoomData();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string roomNo = tbRoomNo.Text;
                string roomType = cbRoomType.Text;
                string bed = cbBedType.Text;
                int price = int.Parse(tbPrice.Text);

                if (!CheckIfRoomIsAlreadyAdded(roomNo)) // Checking if the employee has already been added
                {
                    string query = String.Format("insert into rooms (roomNo, roomType, bed, price) values ('{0}', '{1}', '{2}', '{3}')", roomNo, roomType, bed, price);
                    string message = String.Format("Room Number {0} Has Been Added!", roomNo);

                    functions.setData(query, message);
                    UpdateRoomData();
                    ClearInputData();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (roomToDelete != null  && roomToDelete.Trim() != "") //Checking if the user has selected a row.
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete room {roomToDelete}?", "Delete user?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = $"delete from dbo.rooms where roomNo = '{roomToDelete}'";

                    functions.setData(query, $"Room {roomToDelete} has succesfully been removed!");
                    roomToDelete = "";

                    UpdateRoomData();
                    ClearInputData();
                }
            }
            else
            {
                MessageBox.Show("You must select a room to be removed!"); // If user hasn't selected a row.
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                string roomNo = tbRoomNo.Text;
                string roomType = cbRoomType.Text;
                string bed = cbBedType.Text;
                int price = int.Parse(tbPrice.Text);

               
                if (roomNo == roomToEdit[1])
                {
                    string query = $"update rooms set roomNo = '{roomToEdit[1]}', roomType ='{roomType}', bed = '{bed}', price ='{price}' where roomNo='{roomToEdit[1]}'";
                    string message = $"Room Number {roomNo} Has Been Changed!";

                    functions.setData(query, message);
                    UpdateRoomData();
                    ClearInputData();
                }
                else
                {
                    MessageBox.Show("Please do not change the Room Number, create new Room instead!", "Invalid input!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            string query = "Select * from rooms";
            DataSet ds = functions.getData(query);
            dataRooms.DataSource = ds.Tables[0];
            dataRooms.Columns[0].Visible = false;
        }

        private void ClearInputData()
        {
            tbRoomNo.Clear();
            cbRoomType.SelectedIndex = -1;
            cbBedType.SelectedIndex = -1;
            tbPrice.Clear();
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

                    roomToEdit.Clear();

                    for (int p = 0; p < dataRooms.ColumnCount; p++)
                    {

                        roomToEdit.Add(row.Cells[p].Value.ToString()); //Getting username of current row.
                    }


                    tbRoomNo.Text = roomToEdit[1];
                    cbRoomType.Text = roomToEdit[2];
                    cbBedType.Text = roomToEdit[3];
                    tbPrice.Text = roomToEdit[4];
                }

            }
        }


    }
}

