namespace pharmacay_managemnent_system.Pharmasist_Uc
{
	partial class UC_phDAshboard
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_phDAshboard));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Heading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dashboard";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.panel1.Controls.Add(this.gunaButton1);
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(43, 78);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1026, 654);
			this.panel1.TabIndex = 2;
			// 
			// gunaButton1
			// 
			this.gunaButton1.AnimationHoverSpeed = 0.07F;
			this.gunaButton1.AnimationSpeed = 0.03F;
			this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gunaButton1.BorderColor = System.Drawing.Color.Black;
			this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
			this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gunaButton1.ForeColor = System.Drawing.Color.White;
			this.gunaButton1.Image = null;
			this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
			this.gunaButton1.Location = new System.Drawing.Point(881, 531);
			this.gunaButton1.Name = "gunaButton1";
			this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
			this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
			this.gunaButton1.OnHoverImage = null;
			this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
			this.gunaButton1.Size = new System.Drawing.Size(113, 37);
			this.gunaButton1.TabIndex = 5;
			this.gunaButton1.Text = "Reload";
			this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(561, 97);
			this.chart1.Name = "chart1";
			series3.ChartArea = "ChartArea1";
			series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			series3.Legend = "Legend1";
			series3.Name = "Expired Medicine ";
			series4.ChartArea = "ChartArea1";
			series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			series4.Legend = "Legend1";
			series4.Name = "Valid Medicine ";
			this.chart1.Series.Add(series3);
			this.chart1.Series.Add(series4);
			this.chart1.Size = new System.Drawing.Size(439, 487);
			this.chart1.TabIndex = 4;
			this.chart1.Text = "chart1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(60, 97);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(495, 487);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// gunaElipse1
			// 
			this.gunaElipse1.TargetControl = this;
			// 
			// UC_phDAshboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "UC_phDAshboard";
			this.Size = new System.Drawing.Size(1104, 770);
			this.Load += new System.EventHandler(this.UC_phDAshboard_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI.WinForms.GunaButton gunaButton1;
		private Guna.UI.WinForms.GunaElipse gunaElipse1;
	}
}
