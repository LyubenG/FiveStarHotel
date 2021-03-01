using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveStarHotel1
{
    class Functions
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=(LocalDb)\v15.0; Database=fiveStarHotel;Trusted_Connection=True";
            //con.ConnectionString = "data source = DESKTOP-G2GHH45; Database = fiveStarHotel;integrated security = True";
            con.ConnectionString = "Data Source=SQL5054.site4now.net;Initial Catalog=DB_A701F5_fivestarhotel;User Id=DB_A701F5_fivestarhotel_admin;Password=FiveStarHotel00";
            
            return con;
        }
            
        public DataSet getData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(String.Format("{0}", message), "Success");
        }

        public int countData(String dataInfo)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = String.Format("select COUNT(*) from rooms where booked = '{0}'", dataInfo);
            int count = (int)cmd.ExecuteScalar();
            return count;

        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
