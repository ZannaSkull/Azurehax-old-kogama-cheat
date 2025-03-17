namespace AzureHAXX
{
	// Token: 0x0200000D RID: 13
	public partial class Loader : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000154A8 File Offset: 0x000136A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000154E0 File Offset: 0x000136E0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.siticonePanel1 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneTextBox1 = new global::Siticone.UI.WinForms.SiticoneTextBox();
			this.siticoneButton10 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneDragControl2 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.siticonePanel1.SuspendLayout();
			base.SuspendLayout();
			this.siticonePanel1.BackColor = global::System.Drawing.Color.FromArgb(54, 57, 63);
			this.siticonePanel1.Controls.Add(this.label1);
			this.siticonePanel1.Controls.Add(this.siticoneTextBox1);
			this.siticonePanel1.Controls.Add(this.siticoneButton10);
			this.siticonePanel1.Location = new global::System.Drawing.Point(2, 2);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new global::System.Drawing.Size(378, 129);
			this.siticonePanel1.TabIndex = 0;
			this.siticonePanel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("MS Gothic", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(76, 13);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(226, 21);
			this.label1.TabIndex = 53;
			this.label1.Text = "WELCOM TO AZUREHAX";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.siticoneTextBox1.Animated = false;
			this.siticoneTextBox1.BorderColor = global::System.Drawing.Color.White;
			this.siticoneTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTextBox1.DefaultText = "";
			this.siticoneTextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.siticoneTextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.siticoneTextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneTextBox1.FillColor = global::System.Drawing.Color.FromArgb(54, 57, 63);
			this.siticoneTextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.siticoneTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneTextBox1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Location = new global::System.Drawing.Point(8, 44);
			this.siticoneTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.siticoneTextBox1.Name = "siticoneTextBox1";
			this.siticoneTextBox1.PasswordChar = '•';
			this.siticoneTextBox1.PlaceholderText = "ENTER THE KEY...";
			this.siticoneTextBox1.SelectedText = "";
			this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Size = new global::System.Drawing.Size(360, 34);
			this.siticoneTextBox1.TabIndex = 51;
			this.siticoneTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.siticoneTextBox1.TextChanged += new global::System.EventHandler(this.siticoneTextBox1_TextChanged);
			this.siticoneButton10.BorderRadius = 5;
			this.siticoneButton10.CheckedState.Parent = this.siticoneButton10;
			this.siticoneButton10.CustomImages.Parent = this.siticoneButton10;
			this.siticoneButton10.Enabled = false;
			this.siticoneButton10.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton10.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton10.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton10.HoveredState.Parent = this.siticoneButton10;
			this.siticoneButton10.Location = new global::System.Drawing.Point(8, 86);
			this.siticoneButton10.Name = "siticoneButton10";
			this.siticoneButton10.ShadowDecoration.Parent = this.siticoneButton10;
			this.siticoneButton10.Size = new global::System.Drawing.Size(360, 34);
			this.siticoneButton10.TabIndex = 50;
			this.siticoneButton10.Text = "Enter ";
			this.siticoneButton10.Click += new global::System.EventHandler(this.siticoneButton10_Click);
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneDragControl2.TargetControl = this.siticonePanel1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			base.ClientSize = new global::System.Drawing.Size(382, 133);
			base.ControlBox = false;
			base.Controls.Add(this.siticonePanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Loader";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			base.Load += new global::System.EventHandler(this.Loader_Load);
			this.siticonePanel1.ResumeLayout(false);
			this.siticonePanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000165 RID: 357
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000166 RID: 358
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel1;

		// Token: 0x04000167 RID: 359
		private global::Siticone.UI.WinForms.SiticoneTextBox siticoneTextBox1;

		// Token: 0x04000168 RID: 360
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton10;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400016A RID: 362
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400016B RID: 363
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.Timer timer1;
	}
}
