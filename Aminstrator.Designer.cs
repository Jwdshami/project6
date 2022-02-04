namespace pharmacay_managemnent_system
{
    partial class Aminstrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aminstrator));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnlogout = new Guna.UI.WinForms.GunaButton();
			this.btnprofile = new Guna.UI.WinForms.GunaButton();
			this.btnViewUser = new Guna.UI.WinForms.GunaButton();
			this.BtnAdduser = new Guna.UI.WinForms.GunaButton();
			this.btndashboard = new Guna.UI.WinForms.GunaButton();
			this.UserNamelabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.uC_Profile1 = new pharmacay_managemnent_system.Administrator_uc.UC_Profile();
			this.uC_viewuser1 = new pharmacay_managemnent_system.Administrator_uc.UC_viewuser();
			this.uc_Adduser1 = new pharmacay_managemnent_system.Administrator_uc.Uc_Adduser();
			this.uc_dashboard1 = new pharmacay_managemnent_system.Administrator_uc.uc_dashboard();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.btnlogout);
			this.panel1.Controls.Add(this.btnprofile);
			this.panel1.Controls.Add(this.btnViewUser);
			this.panel1.Controls.Add(this.BtnAdduser);
			this.panel1.Controls.Add(this.btndashboard);
			this.panel1.Controls.Add(this.UserNamelabel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(275, 779);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnlogout
			// 
			this.btnlogout.AnimationHoverSpeed = 0.07F;
			this.btnlogout.AnimationSpeed = 0.03F;
			this.btnlogout.BackColor = System.Drawing.Color.White;
			this.btnlogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnlogout.BorderColor = System.Drawing.Color.Black;
			this.btnlogout.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnlogout.FocusedColor = System.Drawing.Color.White;
			this.btnlogout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogout.ForeColor = System.Drawing.Color.White;
			this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
			this.btnlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnlogout.ImageSize = new System.Drawing.Size(20, 20);
			this.btnlogout.Location = new System.Drawing.Point(53, 496);
			this.btnlogout.Name = "btnlogout";
			this.btnlogout.OnHoverBaseColor = System.Drawing.Color.White;
			this.btnlogout.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnlogout.OnHoverForeColor = System.Drawing.Color.Black;
			this.btnlogout.OnHoverImage = null;
			this.btnlogout.OnPressedColor = System.Drawing.Color.White;
			this.btnlogout.Size = new System.Drawing.Size(160, 44);
			this.btnlogout.TabIndex = 18;
			this.btnlogout.Text = "Logout";
			this.btnlogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
			// 
			// btnprofile
			// 
			this.btnprofile.AnimationHoverSpeed = 0.07F;
			this.btnprofile.AnimationSpeed = 0.03F;
			this.btnprofile.BackColor = System.Drawing.Color.White;
			this.btnprofile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnprofile.BorderColor = System.Drawing.Color.Black;
			this.btnprofile.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnprofile.FocusedColor = System.Drawing.Color.White;
			this.btnprofile.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnprofile.ForeColor = System.Drawing.Color.White;
			this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
			this.btnprofile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnprofile.ImageSize = new System.Drawing.Size(20, 20);
			this.btnprofile.Location = new System.Drawing.Point(53, 446);
			this.btnprofile.Name = "btnprofile";
			this.btnprofile.OnHoverBaseColor = System.Drawing.Color.White;
			this.btnprofile.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnprofile.OnHoverForeColor = System.Drawing.Color.Black;
			this.btnprofile.OnHoverImage = null;
			this.btnprofile.OnPressedColor = System.Drawing.Color.White;
			this.btnprofile.Size = new System.Drawing.Size(160, 44);
			this.btnprofile.TabIndex = 17;
			this.btnprofile.Text = "Profile";
			this.btnprofile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click_1);
			// 
			// btnViewUser
			// 
			this.btnViewUser.AnimationHoverSpeed = 0.07F;
			this.btnViewUser.AnimationSpeed = 0.03F;
			this.btnViewUser.BackColor = System.Drawing.Color.White;
			this.btnViewUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnViewUser.BorderColor = System.Drawing.Color.Black;
			this.btnViewUser.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnViewUser.FocusedColor = System.Drawing.Color.White;
			this.btnViewUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewUser.ForeColor = System.Drawing.Color.White;
			this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
			this.btnViewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnViewUser.ImageSize = new System.Drawing.Size(20, 20);
			this.btnViewUser.Location = new System.Drawing.Point(62, 379);
			this.btnViewUser.Name = "btnViewUser";
			this.btnViewUser.OnHoverBaseColor = System.Drawing.Color.White;
			this.btnViewUser.OnHoverBorderColor = System.Drawing.Color.Black;
			this.btnViewUser.OnHoverForeColor = System.Drawing.Color.Black;
			this.btnViewUser.OnHoverImage = null;
			this.btnViewUser.OnPressedColor = System.Drawing.Color.White;
			this.btnViewUser.Size = new System.Drawing.Size(160, 44);
			this.btnViewUser.TabIndex = 16;
			this.btnViewUser.Text = "View User";
			this.btnViewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
			// 
			// BtnAdduser
			// 
			this.BtnAdduser.AnimationHoverSpeed = 0.07F;
			this.BtnAdduser.AnimationSpeed = 0.03F;
			this.BtnAdduser.BackColor = System.Drawing.Color.White;
			this.BtnAdduser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnAdduser.BorderColor = System.Drawing.Color.Black;
			this.BtnAdduser.DialogResult = System.Windows.Forms.DialogResult.None;
			this.BtnAdduser.FocusedColor = System.Drawing.Color.White;
			this.BtnAdduser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAdduser.ForeColor = System.Drawing.Color.White;
			this.BtnAdduser.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdduser.Image")));
			this.BtnAdduser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.BtnAdduser.ImageSize = new System.Drawing.Size(20, 20);
			this.BtnAdduser.Location = new System.Drawing.Point(62, 316);
			this.BtnAdduser.Name = "BtnAdduser";
			this.BtnAdduser.OnHoverBaseColor = System.Drawing.Color.White;
			this.BtnAdduser.OnHoverBorderColor = System.Drawing.Color.Black;
			this.BtnAdduser.OnHoverForeColor = System.Drawing.Color.Black;
			this.BtnAdduser.OnHoverImage = null;
			this.BtnAdduser.OnPressedColor = System.Drawing.Color.White;
			this.BtnAdduser.Size = new System.Drawing.Size(160, 44);
			this.BtnAdduser.TabIndex = 15;
			this.BtnAdduser.Text = "Add User";
			this.BtnAdduser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.BtnAdduser.Click += new System.EventHandler(this.BtnAdduser_Click);
			// 
			// btndashboard
			// 
			this.btndashboard.AnimationHoverSpeed = 0.07F;
			this.btndashboard.AnimationSpeed = 0.03F;
			this.btndashboard.BackColor = System.Drawing.Color.White;
			this.btndashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btndashboard.BorderColor = System.Drawing.Color.Black;
			this.btndashboard.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btndashboard.FocusedColor = System.Drawing.Color.White;
			this.btndashboard.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndashboard.ForeColor = System.Drawing.Color.White;
			this.btndashboard.Image = ((System.Drawing.Image)(resources.GetObject("btndashboard.Image")));
			this.btndashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btndashboard.ImageSize = new System.Drawing.Size(20, 20);
			this.btndashboard.Location = new System.Drawing.Point(62, 252);
			this.btndashboard.Name = "btndashboard";
			this.btndashboard.OnHoverBaseColor = System.Drawing.Color.White;
			this.btndashboard.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.btndashboard.OnHoverForeColor = System.Drawing.Color.Black;
			this.btndashboard.OnHoverImage = null;
			this.btndashboard.OnPressedColor = System.Drawing.Color.White;
			this.btndashboard.Size = new System.Drawing.Size(160, 44);
			this.btndashboard.TabIndex = 14;
			this.btndashboard.Text = "Dashbord";
			this.btndashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click_1);
			// 
			// UserNamelabel
			// 
			this.UserNamelabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserNamelabel.ForeColor = System.Drawing.Color.Gold;
			this.UserNamelabel.Location = new System.Drawing.Point(80, 697);
			this.UserNamelabel.Name = "UserNamelabel";
			this.UserNamelabel.Size = new System.Drawing.Size(105, 20);
			this.UserNamelabel.TabIndex = 13;
			this.UserNamelabel.Text = "Pharma centre";
			this.UserNamelabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(46, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Administrator";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = global::pharmacay_managemnent_system.Properties.Resources.acx;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(48, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(183, 173);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.uC_Profile1);
			this.panel2.Controls.Add(this.uC_viewuser1);
			this.panel2.Controls.Add(this.uc_Adduser1);
			this.panel2.Controls.Add(this.uc_dashboard1);
			this.panel2.Location = new System.Drawing.Point(274, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1107, 770);
			this.panel2.TabIndex = 0;
			// 
			// uC_Profile1
			// 
			this.uC_Profile1.BackColor = System.Drawing.Color.White;
			this.uC_Profile1.Location = new System.Drawing.Point(0, 0);
			this.uC_Profile1.Name = "uC_Profile1";
			this.uC_Profile1.Size = new System.Drawing.Size(1104, 795);
			this.uC_Profile1.TabIndex = 3;
			// 
			// uC_viewuser1
			// 
			this.uC_viewuser1.BackColor = System.Drawing.Color.White;
			this.uC_viewuser1.Location = new System.Drawing.Point(0, 0);
			this.uC_viewuser1.Name = "uC_viewuser1";
			this.uC_viewuser1.Size = new System.Drawing.Size(1107, 770);
			this.uC_viewuser1.TabIndex = 2;
			this.uC_viewuser1.Load += new System.EventHandler(this.uC_viewuser1_Load);
			// 
			// uc_Adduser1
			// 
			this.uc_Adduser1.BackColor = System.Drawing.Color.White;
			this.uc_Adduser1.Location = new System.Drawing.Point(0, 0);
			this.uc_Adduser1.Name = "uc_Adduser1";
			this.uc_Adduser1.Size = new System.Drawing.Size(1107, 770);
			this.uc_Adduser1.TabIndex = 1;
			this.uc_Adduser1.Load += new System.EventHandler(this.uc_Adduser1_Load);
			// 
			// uc_dashboard1
			// 
			this.uc_dashboard1.BackColor = System.Drawing.Color.White;
			this.uc_dashboard1.Location = new System.Drawing.Point(3, 0);
			this.uc_dashboard1.Name = "uc_dashboard1";
			this.uc_dashboard1.Size = new System.Drawing.Size(1104, 767);
			this.uc_dashboard1.TabIndex = 0;
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// gunaElipse2
			// 
			this.gunaElipse2.TargetControl = this.panel2;
			// 
			// gunaElipse3
			// 
			this.gunaElipse3.TargetControl = this.panel2;
			// 
			// gunaElipse4
			// 
			this.gunaElipse4.TargetControl = this.panel2;
			// 
			// Aminstrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1380, 780);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Aminstrator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Aminstrator";
			this.Load += new System.EventHandler(this.Aminstrator_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label UserNamelabel;
		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Administrator_uc.uc_dashboard uc_dashboard1;
		private Guna.UI.WinForms.GunaButton btnlogout;
		private Guna.UI.WinForms.GunaButton btnprofile;
		private Guna.UI.WinForms.GunaButton btnViewUser;
		private Guna.UI.WinForms.GunaButton BtnAdduser;
		private Guna.UI.WinForms.GunaButton btndashboard;
		private Guna.UI.WinForms.GunaElipse gunaElipse2;
		private Administrator_uc.Uc_Adduser uc_Adduser1;
		private Guna.UI.WinForms.GunaElipse gunaElipse3;
		private Administrator_uc.UC_viewuser uC_viewuser1;
		private Guna.UI.WinForms.GunaElipse gunaElipse4;
		private Administrator_uc.UC_Profile uC_Profile1;
	}
}