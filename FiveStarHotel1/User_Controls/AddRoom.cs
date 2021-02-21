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
            
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            query = "Select * from rooms";
            DataSet ds = fn.getData(query);
            dataRooms.DataSource = ds.Tables[0];
        }
    }
}
