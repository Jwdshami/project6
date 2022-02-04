namespace pharmacay_managemnent_system
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnsignin = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(438, 770);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::pharmacay_managemnent_system.Properties.Resources.vippng_com_cross_graphic_png_2872282;
			this.pictureBox1.Location = new System.Drawing.Point(81, 384);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(263, 222);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(71, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(293, 177);
			this.label1.TabIndex = 0;
			this.label1.Text = "  Pharmacay \r\nManagement\r\n      system";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Navy;
			this.panel2.Location = new System.Drawing.Point(613, 131);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(4, 500);
			this.panel2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(680, 258);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "User Name:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtusername
			// 
			this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusername.ForeColor = System.Drawing.Color.Black;
			this.txtusername.Location = new System.Drawing.Point(683, 279);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(344, 29);
			this.txtusername.TabIndex = 5;
			this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
			// 
			// txtpassword
			// 
			this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpassword.ForeColor = System.Drawing.Color.Black;
			this.txtpassword.Location = new System.Drawing.Point(683, 373);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.Size = new System.Drawing.Size(344, 29);
			this.txtpassword.TabIndex = 7;
			this.txtpassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(680, 352);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// btnsignin
			// 
			this.btnsignin.BackColor = System.Drawing.Color.Navy;
			this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnsignin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsignin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnsignin.Location = new System.Drawing.Point(683, 448);
			this.btnsignin.Name = "btnsignin";
			this.btnsignin.Size = new System.Drawing.Size(150, 45);
			this.btnsignin.TabIndex = 8;
			this.btnsignin.Text = "Sign In";
			this.btnsignin.UseVisualStyleBackColor = false;
			this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
			this.btnsignin.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
			this.btnsignin.MouseHover += new System.EventHandler(this.button2_Mousehover);
			// 
			// btnreset
			// 
			this.btnreset.BackColor = System.Drawing.Color.Navy;
			this.btnreset.FlatAppearance.BorderSize = 16;
			this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnreset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnreset.Location = new System.Drawing.Point(869, 448);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(158, 45);
			this.btnreset.TabIndex = 9;
			this.btnreset.Text = "Reset";
			this.btnreset.UseVisualStyleBackColor = false;
			this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
			this.btnreset.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
			this.btnreset.MouseHover += new System.EventHandler(this.button3_MouseHover);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(825, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 25);
			this.label4.TabIndex = 10;
			this.label4.Text = "Sign In";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(928, 408);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(99, 17);
			this.checkBox1.TabIndex = 11;
			this.checkBox1.Text = "ShowPassword";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::pharmacay_managemnent_system.Properties.Resources.vector_medical_book_icon;
			this.pictureBox2.Location = new System.Drawing.Point(808, 63);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(119, 115);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(1311, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 43);
			this.button1.TabIndex = 2;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.ClientSizeChanged += new System.EventHandler(this.label2_Click);
			this.button1.Click += new System.EventHandler(this.button1_ClientSizeChanged);
			this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1380, 768);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnreset);
			this.Controls.Add(this.btnsignin);
			this.Controls.Add(this.txtpassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtusername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsignin;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
	}
}

