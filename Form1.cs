using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace pharmacay_managemnent_system
{
    public partial class Form1 : Form
    {
		/*Function fn = new Function();
		String query;
		DataSet ds;*/


		public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnreset.BackColor =Color.Gray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnreset.BackColor = Color.Navy;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnsignin.BackColor = Color.Navy;
        }

        private void button2_Mousehover(object sender, EventArgs e)
        {
            btnsignin.BackColor = Color.Gray;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
			txtusername.Clear();
			txtpassword.Clear();
		}

        private void btnsignin_Click(object sender, EventArgs e)
        {
			//if(txtusername.Text=="root" && txtpassword.Text=="root")
			//{
			//	Aminstrator am = new Aminstrator();
			//	am.Show();
			//	this.Hide();
			//}
			//else if (txtusername.Text == "abc" && txtpassword.Text == "abc")
			//{
			//	Pharmacisit am = new Pharmacisit();
			//	am.Show();
			//	this.Hide();
			//}
			//else
			//{
			//	MessageBox.Show("Incorrect User Name or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
			//SQLConnection con = new SQLConnection(@"Data Source=DESKTOP-BG472OT\SQLEXPRESS;Initial Catalog=chalja_pen_nu_lun;Integrated Security=True");
			//string query = "select * from Add_user where Username = '" + txtusername.Text.Trim() + "' and Password = '" + txtpassword.Text.Trim() + "'";
			//SqlDataAdapter sqlda = new SqlDataAdapter(query,con);
			//DataTable dtbl = new DataTable();
			//sqlda.Fill(dtbl);
			//if(dtbl.Rows.Count == 1)
			//{
			//	Pharmacisit ph = new Pharmacisit();
			//	this.Hide();
			//	ph.Show();
			//}
			//else
			//{
			//	MessageBox.Show("Your Username or Password is incorrect ");
			//}
			Aminstrator ph = new Aminstrator();
			this.Hide();
			ph.Show();




			/*(txtusername.Text=="Jawad" && txtpassword.Text=="123")
            {
                Aminstrator am = new Aminstrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
		}

		private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_ClientSizeChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
           
        }

		private void txtusername_TextChanged(object sender, EventArgs e)
		{

		}

		private void licensing1_Load(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				txtpassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtpassword.UseSystemPasswordChar = true;
			}
					
		}
	}
}
