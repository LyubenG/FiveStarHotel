﻿using System;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace FiveStarHotel1
{
    class Functions
    {
        bool connectionOpened = false;

        SqlConnection con = new SqlConnection("Data Source=SQL5054.site4now.net;Initial Catalog=DB_A701F5_fivestarhotel;User Id=DB_A701F5_fivestarhotel_admin;Password=FiveStarHotel00");

        public DataSet GetData(String query)  //Method used for getting data from DB.
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public void SetData(String query, String message) //Method used for setting data in the DB.
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show($"{message}", "Success");
        }

        public int CountData(String dataInfo) //Method used for getting amount of taken rooms & free rooms.
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = $"SELECT COUNT(*) from rooms WHERE booked = '{dataInfo}'";
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;

        }

        public SqlDataReader GetForCombo(String query)
        {
            if (connectionOpened)
            {
                con.Close();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            connectionOpened = true;
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
