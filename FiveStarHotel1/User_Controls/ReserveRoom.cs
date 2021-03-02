using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FiveStarHotel1.User_Controls
{
    public partial class ReserveRoom : UserControl
    {
        Functions functions = new Functions();
        string query;
        int roomId;


        public ReserveRoom()
        {
            InitializeComponent();
        }

        private void setComboBox(String query, ComboBox combobox)
        {
            combobox.Items.Clear(); // Clearing if there are any items from previous uses.
            SqlDataReader reader = functions.getForCombo(query);

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (!combobox.Items.Contains(reader.GetString(i)))
                    {
                        combobox.Items.Add(reader.GetString(i)); // Adding rooms that match the search.
                    }
                }
            }
            reader.Close();
        }

        private void cbBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = String.Format("select roomNo from rooms where bed = '{0}' and roomType = '{1}' and booked = 'No'",
                cbBedType.Text, cbRoomType.Text);
            setComboBox(query, cbRoomAvailable);
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBedType.SelectedIndex = -1;
        }

        
        private void cbRoomAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "Select price, roomid from rooms where roomNo = '" + cbRoomAvailable.Text + "'";
            DataSet dataset = functions.getData(query);

            tbPrice.Text = dataset.Tables[0].Rows[0][0] + "$";
            roomId = int.Parse(dataset.Tables[0].Rows[0][1].ToString());
        }

        private void btnReserveRoom_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string name = tbName.Text;
                int mobilePhone = int.Parse(tbPhoneNo.Text);
                string nationality = tbNationality.Text;
                string gender = cbGender.Text;
                string dateOfBirth = dpDOB.Text;
                string checkInDate = dpCheckIn.Text;

                query = String.Format("insert into customer (cname, mobile, nationality, gender, dob, checkin, roomid)" +
                    " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}') update rooms set booked = 'Yes' where roomNo = '{7}'",
                    name, mobilePhone, nationality, gender, dateOfBirth, checkInDate, roomId, cbRoomAvailable.Text);

                functions.setData(query, String.Format("Room Number {0} Has Been Succesfully Reserved By {1}!", cbRoomAvailable.Text, name));
                ClearSelectedData();
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
            if (tbName.Text == "" || tbNationality.Text == "" || tbPhoneNo.Text == ""
                || cbGender.Text == "" || cbRoomAvailable.Text == ""
                || cbBedType.Text == "" || cbRoomType.Text == "" 
                || reg.IsMatch(tbPhoneNo.Text)) // Checking if any of the textfields are empty or if the phone number is invalid.
            {
                return false;
            }
            return true;
        }

        private void ClearSelectedData()
        {
            //Clearing all the data once a room is reserved.
            tbName.Clear();
            tbNationality.Clear();
            tbPhoneNo.Clear();
            cbBedType.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            cbRoomType.SelectedIndex = -1;
            tbPrice.Clear();
            cbRoomAvailable.SelectedIndex = -1;
        }
    }
}
