using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x02000005 RID: 5
	public class az_CAR : UserControl
	{
		// Token: 0x0600001C RID: 28
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600001D RID: 29 RVA: 0x00003FF7 File Offset: 0x000021F7
		private void LoadAllCheats()
		{
			this.Phyhics.ScanCode = "41 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 80 3F 00 00 00 00 ?? ?? ?? ?? CD CC CC 3E";
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000400C File Offset: 0x0000220C
		public az_CAR()
		{
			this.LoadAllCheats();
			new Thread(new ThreadStart(this.FlyChecker)).Start();
			this.InitializeComponent();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004060 File Offset: 0x00002260
		private void FlyChecker()
		{
			for (;;)
			{
				bool flag = this.Phyhics.Found && this.siticoneCustomCheckBox1.Checked && az_CAR.GetAsyncKeyState(Keys.Space) < 0;
				if (flag)
				{
					this.setFly(Convert.ToSingle(this.siticoneTrackBar2.Value));
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000040BC File Offset: 0x000022BC
		private void setFly(float val)
		{
			byte[] bytes = BitConverter.GetBytes(val);
			AobScan.WriteProcessMemory(this.kogProc.Handle, IntPtr.Add(this.Phyhics.Addresses[0], 9), bytes, (uint)bytes.Length, 0U);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000040FC File Offset: 0x000022FC
		private void setSpeed(float val)
		{
			byte[] bytes = BitConverter.GetBytes(val);
			AobScan.WriteProcessMemory(this.kogProc.Handle, IntPtr.Subtract(this.Phyhics.Addresses[0], 3), bytes, (uint)bytes.Length, 0U);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000413C File Offset: 0x0000233C
		private void siticoneTrackBar2_Scroll(object sender, ScrollEventArgs e)
		{
			this.siticoneTextBox2.Text = this.siticoneTrackBar2.Value.ToString();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004169 File Offset: 0x00002369
		private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000416C File Offset: 0x0000236C
		private void az_CAR_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004170 File Offset: 0x00002370
		private void timerProcess_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("kogama");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				bool flag2 = this.ProcessID != 0;
				if (flag2)
				{
				}
				this.ProcessID = 0;
			}
			else
			{
				this.kogProc = processesByName[0];
				bool flag3 = this.ProcessID != this.kogProc.Id;
				if (flag3)
				{
					this.ProcessID = this.kogProc.Id;
				}
				this.ProcessID = this.kogProc.Id;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000041F8 File Offset: 0x000023F8
		private void siticoneCustomCheckBox2_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox2.Checked;
			if (@checked)
			{
				bool flag = !this.Phyhics.Found;
				if (flag)
				{
					this.Phyhics.ScanCheat(this.kogProc);
				}
				bool found = this.Phyhics.Found;
				if (found)
				{
					this.siticoneTrackBar1.Enabled = true;
					this.siticoneTextBox1.Enabled = true;
				}
				else
				{
					this.siticoneCustomCheckBox2.Checked = false;
				}
			}
			else
			{
				this.setSpeed(8f);
				this.siticoneTrackBar1.Enabled = false;
				this.siticoneTextBox1.Enabled = false;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000042A0 File Offset: 0x000024A0
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox1.Checked;
			if (@checked)
			{
				bool flag = !this.Phyhics.Found;
				if (flag)
				{
					this.Phyhics.ScanCheat(this.kogProc);
				}
				bool found = this.Phyhics.Found;
				if (found)
				{
					this.siticoneTrackBar2.Enabled = true;
					this.siticoneTextBox2.Enabled = true;
				}
				else
				{
					this.siticoneCustomCheckBox1.Checked = false;
				}
			}
			else
			{
				this.siticoneTrackBar2.Enabled = false;
				this.siticoneTextBox2.Enabled = false;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000433C File Offset: 0x0000253C
		private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.siticoneTextBox1.Text = this.siticoneTrackBar1.Value.ToString();
			this.setSpeed(Convert.ToSingle(this.siticoneTrackBar1.Value));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004380 File Offset: 0x00002580
		private void siticoneTrackBar2_Scroll_1(object sender, ScrollEventArgs e)
		{
			this.siticoneTextBox2.Text = this.siticoneTrackBar2.Value.ToString();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000043AD File Offset: 0x000025AD
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000043B0 File Offset: 0x000025B0
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000043B4 File Offset: 0x000025B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000043EC File Offset: 0x000025EC
		private void InitializeComponent()
		{
			this.components = new Container();
			this.label1 = new Label();
			this.siticoneTextBox2 = new SiticoneTextBox();
			this.siticoneTextBox1 = new SiticoneTextBox();
			this.siticoneCustomCheckBox1 = new SiticoneCustomCheckBox();
			this.label2 = new Label();
			this.siticoneTrackBar2 = new SiticoneTrackBar();
			this.siticoneCustomCheckBox2 = new SiticoneCustomCheckBox();
			this.label7 = new Label();
			this.siticoneTrackBar1 = new SiticoneTrackBar();
			this.timerProcess = new System.Windows.Forms.Timer(this.components);
			this.siticonePanel1 = new SiticonePanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(160, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(118, 21);
			this.label1.TabIndex = 58;
			this.label1.Text = "•PSYHICS•";
			this.label1.Click += this.label1_Click;
			this.siticoneTextBox2.Animated = false;
			this.siticoneTextBox2.BorderRadius = 5;
			this.siticoneTextBox2.Cursor = Cursors.IBeam;
			this.siticoneTextBox2.DefaultText = "25";
			this.siticoneTextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.siticoneTextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.siticoneTextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneTextBox2.Enabled = false;
			this.siticoneTextBox2.FillColor = Color.FromArgb(36, 38, 42);
			this.siticoneTextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.ForeColor = Color.FromArgb(243, 109, 109);
			this.siticoneTextBox2.HoveredState.BorderColor = Color.FromArgb(64, 64, 64);
			this.siticoneTextBox2.HoveredState.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.Location = new Point(176, 103);
			this.siticoneTextBox2.Margin = new Padding(4);
			this.siticoneTextBox2.Name = "siticoneTextBox2";
			this.siticoneTextBox2.PasswordChar = '\0';
			this.siticoneTextBox2.PlaceholderText = "";
			this.siticoneTextBox2.ReadOnly = true;
			this.siticoneTextBox2.SelectedText = "";
			this.siticoneTextBox2.SelectionStart = 2;
			this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
			this.siticoneTextBox2.Size = new Size(38, 20);
			this.siticoneTextBox2.TabIndex = 66;
			this.siticoneTextBox2.TextAlign = HorizontalAlignment.Center;
			this.siticoneTextBox1.Animated = false;
			this.siticoneTextBox1.BorderRadius = 5;
			this.siticoneTextBox1.Cursor = Cursors.IBeam;
			this.siticoneTextBox1.DefaultText = "25";
			this.siticoneTextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.siticoneTextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.siticoneTextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.siticoneTextBox1.Enabled = false;
			this.siticoneTextBox1.FillColor = Color.FromArgb(36, 38, 42);
			this.siticoneTextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.ForeColor = Color.FromArgb(243, 109, 109);
			this.siticoneTextBox1.HoveredState.BorderColor = Color.FromArgb(64, 64, 64);
			this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Location = new Point(176, 57);
			this.siticoneTextBox1.Margin = new Padding(4);
			this.siticoneTextBox1.Name = "siticoneTextBox1";
			this.siticoneTextBox1.PasswordChar = '\0';
			this.siticoneTextBox1.PlaceholderText = "";
			this.siticoneTextBox1.ReadOnly = true;
			this.siticoneTextBox1.SelectedText = "";
			this.siticoneTextBox1.SelectionStart = 2;
			this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
			this.siticoneTextBox1.Size = new Size(38, 20);
			this.siticoneTextBox1.TabIndex = 65;
			this.siticoneTextBox1.TextAlign = HorizontalAlignment.Center;
			this.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.Location = new Point(17, 103);
			this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Size = new Size(20, 20);
			this.siticoneCustomCheckBox1.TabIndex = 64;
			this.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckedChanged += this.siticoneCustomCheckBox1_CheckedChanged;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(14, 84);
			this.label2.Name = "label2";
			this.label2.Size = new Size(22, 15);
			this.label2.TabIndex = 63;
			this.label2.Text = "Fly";
			this.siticoneTrackBar2.Enabled = false;
			this.siticoneTrackBar2.FillColor = Color.FromArgb(193, 200, 207);
			this.siticoneTrackBar2.HoveredState.Parent = this.siticoneTrackBar2;
			this.siticoneTrackBar2.IndicateFocus = false;
			this.siticoneTrackBar2.Location = new Point(43, 103);
			this.siticoneTrackBar2.Minimum = 25;
			this.siticoneTrackBar2.Name = "siticoneTrackBar2";
			this.siticoneTrackBar2.Size = new Size(127, 20);
			this.siticoneTrackBar2.TabIndex = 62;
			this.siticoneTrackBar2.ThumbColor = Color.FromArgb(243, 109, 109);
			this.siticoneTrackBar2.Value = 25;
			this.siticoneTrackBar2.Scroll += this.siticoneTrackBar2_Scroll_1;
			this.siticoneCustomCheckBox2.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.Location = new Point(17, 57);
			this.siticoneCustomCheckBox2.Name = "siticoneCustomCheckBox2";
			this.siticoneCustomCheckBox2.ShadowDecoration.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.Size = new Size(20, 20);
			this.siticoneCustomCheckBox2.TabIndex = 61;
			this.siticoneCustomCheckBox2.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckedChanged += this.siticoneCustomCheckBox2_CheckedChanged_1;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(14, 38);
			this.label7.Name = "label7";
			this.label7.Size = new Size(43, 15);
			this.label7.TabIndex = 60;
			this.label7.Text = "Speed";
			this.siticoneTrackBar1.Enabled = false;
			this.siticoneTrackBar1.FillColor = Color.FromArgb(193, 200, 207);
			this.siticoneTrackBar1.HoveredState.Parent = this.siticoneTrackBar1;
			this.siticoneTrackBar1.IndicateFocus = false;
			this.siticoneTrackBar1.Location = new Point(43, 57);
			this.siticoneTrackBar1.Minimum = 25;
			this.siticoneTrackBar1.Name = "siticoneTrackBar1";
			this.siticoneTrackBar1.Size = new Size(127, 20);
			this.siticoneTrackBar1.TabIndex = 59;
			this.siticoneTrackBar1.ThumbColor = Color.FromArgb(243, 109, 109);
			this.siticoneTrackBar1.Value = 25;
			this.siticoneTrackBar1.Scroll += this.siticoneTrackBar1_Scroll;
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += this.timerProcess_Tick;
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 67;
			this.timer1.Tick += this.timer1_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(36, 38, 42);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.siticoneTextBox2);
			base.Controls.Add(this.siticoneTextBox1);
			base.Controls.Add(this.siticoneCustomCheckBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.siticoneTrackBar2);
			base.Controls.Add(this.siticoneCustomCheckBox2);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.siticoneTrackBar1);
			base.Controls.Add(this.label1);
			base.Name = "az_CAR";
			base.Size = new Size(439, 267);
			base.Load += this.az_CAR_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002F RID: 47
		private int ProcessID = 0;

		// Token: 0x04000030 RID: 48
		private Process kogProc;

		// Token: 0x04000031 RID: 49
		private Cheat Phyhics = new Cheat();

		// Token: 0x04000032 RID: 50
		private IContainer components = null;

		// Token: 0x04000033 RID: 51
		private Label label1;

		// Token: 0x04000034 RID: 52
		private SiticoneTextBox siticoneTextBox2;

		// Token: 0x04000035 RID: 53
		private SiticoneTextBox siticoneTextBox1;

		// Token: 0x04000036 RID: 54
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000037 RID: 55
		private Label label2;

		// Token: 0x04000038 RID: 56
		private SiticoneTrackBar siticoneTrackBar2;

		// Token: 0x04000039 RID: 57
		private SiticoneCustomCheckBox siticoneCustomCheckBox2;

		// Token: 0x0400003A RID: 58
		private Label label7;

		// Token: 0x0400003B RID: 59
		private SiticoneTrackBar siticoneTrackBar1;

		// Token: 0x0400003C RID: 60
		private System.Windows.Forms.Timer timerProcess;

		// Token: 0x0400003D RID: 61
		private SiticonePanel siticonePanel1;

		// Token: 0x0400003E RID: 62
		private System.Windows.Forms.Timer timer1;
	}
}
