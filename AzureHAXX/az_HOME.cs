using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x02000007 RID: 7
	public class az_HOME : UserControl
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00006DAF File Offset: 0x00004FAF
		public az_HOME()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006DC8 File Offset: 0x00004FC8
		private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.siticoneTextBox1.Text = this.siticoneTrackBar1.Value.ToString();
			Form.ActiveForm.Opacity = (double)this.siticoneTrackBar1.Value / 100.0;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006E16 File Offset: 0x00005016
		private void az_HOME_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006E1C File Offset: 0x0000501C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006E54 File Offset: 0x00005054
		private void InitializeComponent()
		{
			this.components = new Container();
			this.label1 = new Label();
			this.siticonePanel1 = new SiticonePanel();
			this.timerProcess = new Timer(this.components);
			this.timer1 = new Timer(this.components);
			this.siticoneTrackBar1 = new SiticoneTrackBar();
			this.label7 = new Label();
			this.siticoneTextBox1 = new SiticoneTextBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(178, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(82, 21);
			this.label1.TabIndex = 54;
			this.label1.Text = "•HOME•";
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 55;
			this.timerProcess.Enabled = true;
			this.siticoneTrackBar1.FillColor = Color.FromArgb(193, 200, 207);
			this.siticoneTrackBar1.HoveredState.Parent = this.siticoneTrackBar1;
			this.siticoneTrackBar1.IndicateFocus = false;
			this.siticoneTrackBar1.Location = new Point(10, 242);
			this.siticoneTrackBar1.Minimum = 50;
			this.siticoneTrackBar1.Name = "siticoneTrackBar1";
			this.siticoneTrackBar1.Size = new Size(210, 20);
			this.siticoneTrackBar1.TabIndex = 59;
			this.siticoneTrackBar1.ThumbColor = Color.FromArgb(243, 109, 109);
			this.siticoneTrackBar1.Value = 100;
			this.siticoneTrackBar1.Scroll += this.siticoneTrackBar1_Scroll;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(5, 221);
			this.label7.Name = "label7";
			this.label7.Size = new Size(47, 15);
			this.label7.TabIndex = 57;
			this.label7.Text = "Opacity";
			this.siticoneTextBox1.Animated = false;
			this.siticoneTextBox1.Cursor = Cursors.IBeam;
			this.siticoneTextBox1.DefaultText = "";
			this.siticoneTextBox1.DisabledState.BorderColor = Color.White;
			this.siticoneTextBox1.DisabledState.FillColor = Color.FromArgb(36, 38, 42);
			this.siticoneTextBox1.DisabledState.ForeColor = Color.FromArgb(243, 109, 109);
			this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(243, 109, 109);
			this.siticoneTextBox1.Enabled = false;
			this.siticoneTextBox1.FillColor = Color.FromArgb(36, 38, 42);
			this.siticoneTextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.ForeColor = Color.FromArgb(243, 109, 109);
			this.siticoneTextBox1.HoveredState.BorderColor = Color.FromArgb(64, 64, 64);
			this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Location = new Point(225, 242);
			this.siticoneTextBox1.Name = "siticoneTextBox1";
			this.siticoneTextBox1.PasswordChar = '\0';
			this.siticoneTextBox1.PlaceholderText = "";
			this.siticoneTextBox1.ReadOnly = true;
			this.siticoneTextBox1.SelectedText = "";
			this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Size = new Size(38, 20);
			this.siticoneTextBox1.TabIndex = 56;
			this.siticoneTextBox1.TextAlign = HorizontalAlignment.Center;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(36, 38, 42);
			base.Controls.Add(this.siticoneTrackBar1);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.siticoneTextBox1);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.label1);
			base.Name = "az_HOME";
			base.Size = new Size(439, 267);
			base.Load += this.az_HOME_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005E RID: 94
		private IContainer components = null;

		// Token: 0x0400005F RID: 95
		private Label label1;

		// Token: 0x04000060 RID: 96
		private SiticonePanel siticonePanel1;

		// Token: 0x04000061 RID: 97
		private Timer timerProcess;

		// Token: 0x04000062 RID: 98
		private Timer timer1;

		// Token: 0x04000063 RID: 99
		private SiticoneTrackBar siticoneTrackBar1;

		// Token: 0x04000064 RID: 100
		private Label label7;

		// Token: 0x04000065 RID: 101
		private SiticoneTextBox siticoneTextBox1;
	}
}
