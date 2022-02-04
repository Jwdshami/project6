using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacay_managemnent_system
{
	public partial class Aminstrator : Form
	{
		public Aminstrator()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
		}

		private void btndashboard_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Aminstrator_Load(object sender, EventArgs e)
		{
			uc_dashboard1.Visible = false;
			uc_Adduser1.Visible = false;
			uC_viewuser1.Visible = false;
			uC_Profile1.Visible = false;
			btndashboard.PerformClick();
		}

		private void btndashboard_Click_1(object sender, EventArgs e)
		{
			uc_dashboard1.Visible = true;
			uc_dashboard1.BringToFront();
		}

		private void btnlogout_Click(object sender, EventArgs e)
		{
			Form1 fm = new Form1();
			fm.Show();
			this.Hide();
		}

		private void btnViewUser_Click(object sender, EventArgs e)
		{
			uC_viewuser1.Visible = true;
			uC_viewuser1.BringToFront();

		}

		private void BtnAdduser_Click(object sender, EventArgs e)
		{
			uc_Adduser1.Visible = true;
			uc_Adduser1.BringToFront();
		}

		private void uc_Adduser1_Load(object sender, EventArgs e)
		{

		}

		private void uC_viewuser1_Load(object sender, EventArgs e)
		{

		}

		private void btnprofile_Click(object sender, EventArgs e)
		{
			//uC_Profile1.Visible = true;
			//uC_Profile1.BringToFront();

		}

		private void btnprofile_Click_1(object sender, EventArgs e)
		{
			uC_Profile1.Visible = true;
			uC_Profile1.BringToFront();

		}
	}
}