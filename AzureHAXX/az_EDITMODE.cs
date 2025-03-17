using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x02000006 RID: 6
	public class az_EDITMODE : UserControl
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000051E8 File Offset: 0x000033E8
		public az_EDITMODE()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005254 File Offset: 0x00003454
		private void LoadAllCheats()
		{
			this.UnlockAllMaterials.ScanCode = "25 85 C0 74 36";
			this.UnlockAllMaterials.ChangeToCode = "25 85 C0 EB 32";
			this.UnlockAllMaterials.AddressAlign = 488906891;
			this.BuildLimit.ScanCode = "55 8B EC 56 83 EC 14 8B 45 08 8B 40";
			this.BuildLimit.ChangeToCode = "C3 8B EC 56 83 EC 14 8B 45 08 8B 40";
			this.BuildLimit.AddressAlign = 488839520;
			this.FreeTheme.ScanCode = "55 8B EC 57 83 EC 04 8B 7D 0C 83 EC 0C 68";
			this.FreeTheme.ChangeToCode = "C3";
			this.FreeTheme.AddressAlign = 489370224;
			this.DNL.ScanCode = "55 8B EC 83 EC 08 8B 45 08 8B 40 44 8B";
			this.DNL.ChangeToCode = "C3";
			this.DNL.AddressAlign = 488929168;
			this.Fp.ScanCode = "0F 84 39 01 00 00 83 EC 0C 57";
			this.Fp.ChangeToCode = "90 90 90 90 90 90";
			this.Fp.AddressAlign = 442790754;
			this.Fd.ScanCode = "0F 84 EA 00 00 00 39 3F";
			this.Fd.ChangeToCode = "90 90 90 90 90 90";
			this.Fd.AddressAlign = 488927471;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005382 File Offset: 0x00003582
		private void az_EDITMODE_Load(object sender, EventArgs e)
		{
			this.LoadAllCheats();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000538C File Offset: 0x0000358C
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

		// Token: 0x06000032 RID: 50 RVA: 0x00005414 File Offset: 0x00003614
		private void Esp_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Esp_Check.Checked;
			if (@checked)
			{
				this.label2.Text = "ON";
				this.label2.ForeColor = Color.SpringGreen;
				this.UnlockAllMaterials.ScanCheat(this.kogProc);
				bool found = this.UnlockAllMaterials.Found;
				if (found)
				{
					this.UnlockAllMaterials.ActivateCheat(this.kogProc);
				}
				else
				{
					this.Esp_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label2.Text = "OFF";
				this.label2.ForeColor = Color.LightCoral;
				bool found2 = this.UnlockAllMaterials.Found;
				if (found2)
				{
					this.UnlockAllMaterials.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000054E4 File Offset: 0x000036E4
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox1.Checked;
			if (@checked)
			{
				this.label4.Text = "ON";
				this.label4.ForeColor = Color.SpringGreen;
				this.BuildLimit.ScanCheat(this.kogProc);
				bool found = this.BuildLimit.Found;
				if (found)
				{
					this.BuildLimit.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox1.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label4.Text = "OFF";
				this.label4.ForeColor = Color.LightCoral;
				bool found2 = this.BuildLimit.Found;
				if (found2)
				{
					this.BuildLimit.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000055B4 File Offset: 0x000037B4
		private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox2.Checked;
			if (@checked)
			{
				this.label6.Text = "ON";
				this.label6.ForeColor = Color.SpringGreen;
				this.FreeTheme.ScanCheat(this.kogProc);
				bool found = this.FreeTheme.Found;
				if (found)
				{
					this.FreeTheme.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox2.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label6.Text = "OFF";
				this.label6.ForeColor = Color.LightCoral;
				bool found2 = this.FreeTheme.Found;
				if (found2)
				{
					this.FreeTheme.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005684 File Offset: 0x00003884
		private void siticoneCustomCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox3.Checked;
			if (@checked)
			{
				this.label8.Text = "ON";
				this.label8.ForeColor = Color.SpringGreen;
				this.DNL.ScanCheat(this.kogProc);
				bool found = this.DNL.Found;
				if (found)
				{
					this.DNL.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox3.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label8.Text = "OFF";
				this.label8.ForeColor = Color.LightCoral;
				bool found2 = this.DNL.Found;
				if (found2)
				{
					this.DNL.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005754 File Offset: 0x00003954
		private void siticoneCustomCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox4.Checked;
			if (@checked)
			{
				this.label10.Text = "ON";
				this.label10.ForeColor = Color.SpringGreen;
				this.Fp.ScanCheat(this.kogProc);
				bool found = this.Fp.Found;
				if (found)
				{
					this.Fp.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox4.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label10.Text = "OFF";
				this.label10.ForeColor = Color.LightCoral;
				bool found2 = this.Fp.Found;
				if (found2)
				{
					this.Fp.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005824 File Offset: 0x00003A24
		private void siticoneCustomCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox5.Checked;
			if (@checked)
			{
				this.label12.Text = "ON";
				this.label12.ForeColor = Color.SpringGreen;
				this.Fp.ScanCheat(this.kogProc);
				bool found = this.Fd.Found;
				if (found)
				{
					this.Fd.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox5.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label12.Text = "OFF";
				this.label12.ForeColor = Color.LightCoral;
				bool found2 = this.Fd.Found;
				if (found2)
				{
					this.Fd.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000058F4 File Offset: 0x00003AF4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000592C File Offset: 0x00003B2C
		private void InitializeComponent()
		{
			this.components = new Container();
			this.label1 = new Label();
			this.timerProcess = new Timer(this.components);
			this.timer1 = new Timer(this.components);
			this.siticonePanel1 = new SiticonePanel();
			this.label2 = new Label();
			this.label3 = new Label();
			this.Esp_Check = new SiticoneCustomCheckBox();
			this.label4 = new Label();
			this.label5 = new Label();
			this.siticoneCustomCheckBox1 = new SiticoneCustomCheckBox();
			this.label6 = new Label();
			this.label7 = new Label();
			this.siticoneCustomCheckBox2 = new SiticoneCustomCheckBox();
			this.label8 = new Label();
			this.label9 = new Label();
			this.siticoneCustomCheckBox3 = new SiticoneCustomCheckBox();
			this.label10 = new Label();
			this.label11 = new Label();
			this.siticoneCustomCheckBox4 = new SiticoneCustomCheckBox();
			this.label12 = new Label();
			this.label13 = new Label();
			this.siticoneCustomCheckBox5 = new SiticoneCustomCheckBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(148, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(142, 21);
			this.label1.TabIndex = 55;
			this.label1.Text = "•EDIT·MODE•";
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += this.timerProcess_Tick;
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 59;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label2.ForeColor = Color.LightCoral;
			this.label2.Location = new Point(153, 41);
			this.label2.Name = "label2";
			this.label2.Size = new Size(30, 15);
			this.label2.TabIndex = 100;
			this.label2.Text = "OFF";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(6, 40);
			this.label3.Name = "label3";
			this.label3.Size = new Size(115, 15);
			this.label3.TabIndex = 99;
			this.label3.Text = "Unlock All Materials";
			this.Esp_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.Esp_Check.CheckedState.BorderRadius = 2;
			this.Esp_Check.CheckedState.BorderThickness = 0;
			this.Esp_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.Esp_Check.CheckedState.Parent = this.Esp_Check;
			this.Esp_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.Esp_Check.Location = new Point(127, 38);
			this.Esp_Check.Name = "Esp_Check";
			this.Esp_Check.ShadowDecoration.Parent = this.Esp_Check;
			this.Esp_Check.Size = new Size(20, 20);
			this.Esp_Check.TabIndex = 98;
			this.Esp_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.Esp_Check.UncheckedState.BorderRadius = 2;
			this.Esp_Check.UncheckedState.BorderThickness = 0;
			this.Esp_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.Esp_Check.UncheckedState.Parent = this.Esp_Check;
			this.Esp_Check.CheckedChanged += this.Esp_Check_CheckedChanged;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label4.ForeColor = Color.LightCoral;
			this.label4.Location = new Point(153, 67);
			this.label4.Name = "label4";
			this.label4.Size = new Size(30, 15);
			this.label4.TabIndex = 103;
			this.label4.Text = "OFF";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(6, 66);
			this.label5.Name = "label5";
			this.label5.Size = new Size(84, 15);
			this.label5.TabIndex = 102;
			this.label5.Text = "Build No Limit";
			this.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.Location = new Point(127, 64);
			this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Size = new Size(20, 20);
			this.siticoneCustomCheckBox1.TabIndex = 101;
			this.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckedChanged += this.siticoneCustomCheckBox1_CheckedChanged;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label6.ForeColor = Color.LightCoral;
			this.label6.Location = new Point(153, 93);
			this.label6.Name = "label6";
			this.label6.Size = new Size(30, 15);
			this.label6.TabIndex = 106;
			this.label6.Text = "OFF";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(6, 92);
			this.label7.Name = "label7";
			this.label7.Size = new Size(74, 15);
			this.label7.TabIndex = 105;
			this.label7.Text = "Free Theme";
			this.siticoneCustomCheckBox2.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.Location = new Point(127, 90);
			this.siticoneCustomCheckBox2.Name = "siticoneCustomCheckBox2";
			this.siticoneCustomCheckBox2.ShadowDecoration.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.Size = new Size(20, 20);
			this.siticoneCustomCheckBox2.TabIndex = 104;
			this.siticoneCustomCheckBox2.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckedChanged += this.siticoneCustomCheckBox2_CheckedChanged;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label8.ForeColor = Color.LightCoral;
			this.label8.Location = new Point(153, 119);
			this.label8.Name = "label8";
			this.label8.Size = new Size(30, 15);
			this.label8.TabIndex = 109;
			this.label8.Text = "OFF";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(6, 118);
			this.label9.Name = "label9";
			this.label9.Size = new Size(92, 15);
			this.label9.TabIndex = 108;
			this.label9.Text = "Delete No Limit";
			this.siticoneCustomCheckBox3.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox3.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox3.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.Location = new Point(127, 116);
			this.siticoneCustomCheckBox3.Name = "siticoneCustomCheckBox3";
			this.siticoneCustomCheckBox3.ShadowDecoration.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.Size = new Size(20, 20);
			this.siticoneCustomCheckBox3.TabIndex = 107;
			this.siticoneCustomCheckBox3.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox3.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox3.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.UncheckedState.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.CheckedChanged += this.siticoneCustomCheckBox3_CheckedChanged;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label10.ForeColor = Color.LightCoral;
			this.label10.Location = new Point(153, 145);
			this.label10.Name = "label10";
			this.label10.Size = new Size(30, 15);
			this.label10.TabIndex = 112;
			this.label10.Text = "OFF";
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(6, 144);
			this.label11.Name = "label11";
			this.label11.Size = new Size(64, 15);
			this.label11.TabIndex = 111;
			this.label11.Text = "Fast Place";
			this.siticoneCustomCheckBox4.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.Location = new Point(127, 142);
			this.siticoneCustomCheckBox4.Name = "siticoneCustomCheckBox4";
			this.siticoneCustomCheckBox4.ShadowDecoration.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.Size = new Size(20, 20);
			this.siticoneCustomCheckBox4.TabIndex = 110;
			this.siticoneCustomCheckBox4.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckedChanged += this.siticoneCustomCheckBox4_CheckedChanged;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label12.ForeColor = Color.LightCoral;
			this.label12.Location = new Point(153, 171);
			this.label12.Name = "label12";
			this.label12.Size = new Size(30, 15);
			this.label12.TabIndex = 115;
			this.label12.Text = "OFF";
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label13.ForeColor = Color.White;
			this.label13.Location = new Point(6, 170);
			this.label13.Name = "label13";
			this.label13.Size = new Size(69, 15);
			this.label13.TabIndex = 114;
			this.label13.Text = "Fast Delete";
			this.siticoneCustomCheckBox5.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.Location = new Point(127, 168);
			this.siticoneCustomCheckBox5.Name = "siticoneCustomCheckBox5";
			this.siticoneCustomCheckBox5.ShadowDecoration.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.Size = new Size(20, 20);
			this.siticoneCustomCheckBox5.TabIndex = 113;
			this.siticoneCustomCheckBox5.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.CheckedChanged += this.siticoneCustomCheckBox5_CheckedChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(36, 38, 42);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.siticoneCustomCheckBox5);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.siticoneCustomCheckBox4);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.siticoneCustomCheckBox3);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.siticoneCustomCheckBox2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.siticoneCustomCheckBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Esp_Check);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.label1);
			base.Name = "az_EDITMODE";
			base.Size = new Size(439, 267);
			base.Load += this.az_EDITMODE_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003F RID: 63
		private int ProcessID = 0;

		// Token: 0x04000040 RID: 64
		private Process kogProc;

		// Token: 0x04000041 RID: 65
		private Cheat UnlockAllMaterials = new Cheat();

		// Token: 0x04000042 RID: 66
		private Cheat BuildLimit = new Cheat();

		// Token: 0x04000043 RID: 67
		private Cheat FreeTheme = new Cheat();

		// Token: 0x04000044 RID: 68
		private Cheat DNL = new Cheat();

		// Token: 0x04000045 RID: 69
		private Cheat Fp = new Cheat();

		// Token: 0x04000046 RID: 70
		private Cheat Fd = new Cheat();

		// Token: 0x04000047 RID: 71
		private IContainer components = null;

		// Token: 0x04000048 RID: 72
		private Label label1;

		// Token: 0x04000049 RID: 73
		private Timer timerProcess;

		// Token: 0x0400004A RID: 74
		private Timer timer1;

		// Token: 0x0400004B RID: 75
		private SiticonePanel siticonePanel1;

		// Token: 0x0400004C RID: 76
		private Label label2;

		// Token: 0x0400004D RID: 77
		private Label label3;

		// Token: 0x0400004E RID: 78
		private SiticoneCustomCheckBox Esp_Check;

		// Token: 0x0400004F RID: 79
		private Label label4;

		// Token: 0x04000050 RID: 80
		private Label label5;

		// Token: 0x04000051 RID: 81
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000052 RID: 82
		private Label label6;

		// Token: 0x04000053 RID: 83
		private Label label7;

		// Token: 0x04000054 RID: 84
		private SiticoneCustomCheckBox siticoneCustomCheckBox2;

		// Token: 0x04000055 RID: 85
		private Label label8;

		// Token: 0x04000056 RID: 86
		private Label label9;

		// Token: 0x04000057 RID: 87
		private SiticoneCustomCheckBox siticoneCustomCheckBox3;

		// Token: 0x04000058 RID: 88
		private Label label10;

		// Token: 0x04000059 RID: 89
		private Label label11;

		// Token: 0x0400005A RID: 90
		private SiticoneCustomCheckBox siticoneCustomCheckBox4;

		// Token: 0x0400005B RID: 91
		private Label label12;

		// Token: 0x0400005C RID: 92
		private Label label13;

		// Token: 0x0400005D RID: 93
		private SiticoneCustomCheckBox siticoneCustomCheckBox5;
	}
}
