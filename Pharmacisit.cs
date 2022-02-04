using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pharmacay_managemnent_system
{
	public partial class Pharmacisit : Form
	{
		public Pharmacisit()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnlogout_Click(object sender, EventArgs e)
		{
			Form1 fm = new Form1();
			fm.Show();
			this.Hide();
		}

		private void gunaAdvenceButton1_Click(object sender, EventArgs e)
		{

		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			uC_phDAshboard1.Visible = true;
			uC_phDAshboard1.BringToFront();
		}

		private void gunaPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Pharmacisit_Load(object sender, EventArgs e)
		{
			uC_phDAshboard1.Visible = false;
			uC_Addmedi1.Visible = false;
			uC_viewMedi1.Visible = false;
			uC_Modifymedi1.Visible = false;
			uC_ValidityCheck1.Visible = false;
			uC_sellmedicne1.Visible = false;
			btnDashboard.PerformClick();
		}

		private void gunaAdvenceButton2_Click(object sender, EventArgs e)
		{
			uC_Addmedi1.Visible = true;
			uC_Addmedi1.BringToFront();
		}

		private void uC_viewMedi1_Load(object sender, EventArgs e)
		{

		}

		private void gunaAdvenceButton3_Click(object sender, EventArgs e)
		{
			uC_viewMedi1.Visible = true;
			uC_viewMedi1.BringToFront();
		}

		private void gunaAdvenceButton4_Click(object sender, EventArgs e)
		{
			uC_Modifymedi1.Visible = true;
			uC_Modifymedi1.BringToFront();
		}

		private void gunaAdvenceButton5_Click(object sender, EventArgs e)
		{
			uC_ValidityCheck1.Visible = true;
			uC_ValidityCheck1.BringToFront();
		}

		private void gunaAdvenceButton6_Click(object sender, EventArgs e)
		{
			uC_sellmedicne1.Visible = true;
			uC_sellmedicne1.BringToFront();

		}
	}
}
