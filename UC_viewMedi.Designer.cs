namespace pharmacay_managemnent_system.Pharmasist_Uc
{
	partial class UC_viewMedi
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_viewMedi));
			this.label1 = new System.Windows.Forms.Label();
			this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gunaDataGridView2 = new Guna.UI.WinForms.GunaDataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
			((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(401, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Username";
			// 
			// gunaTextBox2
			// 
			this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
			this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
			this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
			this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
			this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gunaTextBox2.ForeColor = System.Drawing.Color.Silver;
			this.gunaTextBox2.Location = new System.Drawing.Point(405, 178);
			this.gunaTextBox2.Name = "gunaTextBox2";
			this.gunaTextBox2.PasswordChar = '\0';
			this.gunaTextBox2.SelectedText = "";
			this.gunaTextBox2.Size = new System.Drawing.Size(340, 36);
			this.gunaTextBox2.TabIndex = 5;
			this.gunaTextBox2.Text = "Search...........................";
			this.gunaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.gunaTextBox2.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
			this.gunaTextBox2.Enter += new System.EventHandler(this.gunaTextBox2_Enter);
			this.gunaTextBox2.Leave += new System.EventHandler(this.gunaTextBox2_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(42, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(208, 34);
			this.label3.TabIndex = 8;
			this.label3.Text = "View Medicine";
			// 
			// gunaDataGridView2
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gunaDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gunaDataGridView2.BackgroundColor = System.Drawing.Color.White;
			this.gunaDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gunaDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gunaDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gunaDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gunaDataGridView2.ColumnHeadersHeight = 4;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gunaDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
			this.gunaDataGridView2.EnableHeadersVisualStyles = false;
			this.gunaDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gunaDataGridView2.Location = new System.Drawing.Point(49, 232);
			this.gunaDataGridView2.Name = "gunaDataGridView2";
			this.gunaDataGridView2.RowHeadersVisible = false;
			this.gunaDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gunaDataGridView2.Size = new System.Drawing.Size(1016, 434);
			this.gunaDataGridView2.TabIndex = 11;
			this.gunaDataGridView2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gunaDataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gunaDataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gunaDataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gunaDataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.gunaDataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gunaDataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gunaDataGridView2.ThemeStyle.HeaderStyle.Height = 4;
			this.gunaDataGridView2.ThemeStyle.ReadOnly = false;
			this.gunaDataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.gunaDataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gunaDataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.gunaDataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gunaDataGridView2.ThemeStyle.RowsStyle.Height = 22;
			this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
			this.panel1.Location = new System.Drawing.Point(49, 232);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 6);
			this.panel1.TabIndex = 23;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// gunaAdvenceButton1
			// 
			this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
			this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
			this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
			this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
			this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Transparent;
			this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
			this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
			this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
			this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
			this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
			this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
			this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
			this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(35, 35);
			this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.gunaAdvenceButton1.Location = new System.Drawing.Point(266, 49);
			this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
			this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
			this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
			this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
			this.gunaAdvenceButton1.OnHoverImage = null;
			this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
			this.gunaAdvenceButton1.Size = new System.Drawing.Size(34, 35);
			this.gunaAdvenceButton1.TabIndex = 10;
			this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(249, 33);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(66, 66);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// gunaButton1
			// 
			this.gunaButton1.AnimationHoverSpeed = 0.07F;
			this.gunaButton1.AnimationSpeed = 0.03F;
			this.gunaButton1.BaseColor = System.Drawing.Color.LightCoral;
			this.gunaButton1.BorderColor = System.Drawing.Color.Black;
			this.gunaButton1.BorderSize = 1;
			this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
			this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gunaButton1.ForeColor = System.Drawing.Color.Black;
			this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
			this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
			this.gunaButton1.Location = new System.Drawing.Point(905, 688);
			this.gunaButton1.Name = "gunaButton1";
			this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
			this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
			this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
			this.gunaButton1.OnHoverImage = null;
			this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
			this.gunaButton1.Size = new System.Drawing.Size(160, 36);
			this.gunaButton1.TabIndex = 24;
			this.gunaButton1.Text = "Delete";
			this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// UC_viewMedi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.gunaButton1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gunaDataGridView2);
			this.Controls.Add(this.gunaAdvenceButton1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gunaTextBox2);
			this.Controls.Add(this.label1);
			this.Name = "UC_viewMedi";
			this.Size = new System.Drawing.Size(1104, 770);
			((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
		private Guna.UI.WinForms.GunaDataGridView gunaDataGridView2;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaElipse gunaElipse1;
		private Guna.UI.WinForms.GunaButton gunaButton1;
	}
}
