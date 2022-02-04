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
	public partial class UC_ValidityCheck : UserControl
	{
		public UC_ValidityCheck()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void gunaTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void gunaTextBox1_Leave(object sender, EventArgs e)
		{
			if (gunaTextBox1.Text == "")
			{
				gunaTextBox1.Text = "Search...........................";
				gunaTextBox1.ForeColor = Color.Silver;
			}
		}

		private void gunaTextBox1_Enter(object sender, EventArgs e)
		{
			if (gunaTextBox1.Text == "Search...........................")
			{
				gunaTextBox1.Text = "";
				gunaTextBox1.ForeColor = Color.Black;
			}
		}
	}
}
