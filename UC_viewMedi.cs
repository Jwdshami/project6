using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pharmacay_managemnent_system.Pharmasist_Uc
{
	public partial class UC_viewMedi : UserControl
	{
		public UC_viewMedi()
		{
			InitializeComponent();
		}

		private void gunaAdvenceButton1_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gunaTextBox2_Leave(object sender, EventArgs e)
		{
			if (gunaTextBox2.Text == "")
			{
				gunaTextBox2.Text = "Search...........................";
				gunaTextBox2.ForeColor = Color.Silver;
			}
		}

		private void gunaTextBox2_Enter(object sender, EventArgs e)
		{
			if (gunaTextBox2.Text == "Search...........................")
			{
				gunaTextBox2.Text = "";
				gunaTextBox2.ForeColor = Color.Black;
			}
		}

		private void gunaTextBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
