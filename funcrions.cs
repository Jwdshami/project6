﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pharmacay_managemnent_system
{
	class function
	{
		/*protected SqlConnection GetConnection()
		{
			/*SqlConnection con = new SqlConnection();
			con.ConnectionString = @"Data Source=DESKTOP-BG472OT\MSQLSERVER;Initial Catalog=pharmacyconnectiondb;integrated security=True";
			return con;
		}*/
		/*public DataSet GetData(string query)
		{
			SqlConnection con = GetConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			cmd.CommandText = query;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			da.Fill(ds);
			return ds;
		}*/
		public void setData(string query,string msg)
		{
			/*SqlConnection con = GetConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandText = query;
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show(msg,"information",MessageBoxButtons.OK,MessageBoxIcon.Information);*/

		}

	}
}
