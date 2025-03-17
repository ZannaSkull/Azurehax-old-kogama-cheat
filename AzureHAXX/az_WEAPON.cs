using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x0200000B RID: 11
	public class az_WEAPON : UserControl
	{
		// Token: 0x0600006E RID: 110 RVA: 0x0000FE70 File Offset: 0x0000E070
		public az_WEAPON()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000FF08 File Offset: 0x0000E108
		private void LoadAllCheats()
		{
			this.OthersRapidFire.ScanCode = "D9 87 A4 00 00 00 DE E9 DD 5D C0 8D 47 5C 8B 08 89 4D CC 8B 48 04 89 4D D0 8B 48 08 89 4D D4 8B 48 0C 89 4D D8 8B 40 10 89 45 DC 83 EC 0C 83 EC";
			this.OthersRapidFire.ChangeToCode = "D9 87 A4 00 00 00 DE C1";
			this.OthersRapidFire.AddressAlign = 325215538;
			this.CubeGunRapidFire.ScanCode = "D9 9F EC 00 00 00 0F B6 87 05 01 00 00 85 C0 ?? ?? ?? ?? ?? ?? 8B 47";
			this.CubeGunRapidFire.ChangeToCode = "D8 87";
			this.CubeGunRapidFire.AddressAlign = 342932959;
			this.ImpulseGunRapidFire.ScanCode = "D9 9F CC 00 00 00 8D 65 FC 5F C9 C3";
			this.ImpulseGunRapidFire.ChangeToCode = "D8 9F";
			this.ImpulseGunRapidFire.AddressAlign = 342992411;
			this.RailGunRapidFire.ScanCode = "D9 98 18 01 00 00 C9 C3";
			this.RailGunRapidFire.ChangeToCode = "D8 80";
			this.RailGunRapidFire.AddressAlign = 343002553;
			this.CheatInfiniteAmmo.ScanCode = "55 8B EC 83 EC 08 8B 45 08 8B 40 0C 8B C8 39 09 0F B6 40 44 C9 C3";
			this.CheatInfiniteAmmo.ChangeToCode = "55 8B EC 83 EC 08 8B 45 08 8B 40 0C 8B C8 39 09 0F B6 40 45";
			this.CheatInfiniteAmmo.AddressAlign = 328550448;
			this.SuperImpulse.ScanCode = "D9 45 F8 D9 47 7C DE C9 D9 45 F8 D9 87 80";
			this.SuperImpulse.ChangeToCode = "D9 47 7C D9 47 7C DE C9 D9 45 F8 D9 87 80";
			this.SuperImpulse.AddressAlign = 525984837;
			this.SlowAmmo.ScanCode = "55 8B EC 56 83 EC 34 8B 75 08 0F B6 86 84 00 00 00 85 C0 0F 85 11 01 00 00";
			this.SlowAmmo.ChangeToCode = "55 8B EC 56 83 EC 34 8B 75 08 C7 45 0C 00 00 80 3F 90 90 90 90 90 90 90 90";
			this.SlowAmmo.AddressAlign = 493206992;
			this.AutoShot.ScanCode = "08 0F B6 80 A0 00 00 00 85 C0 74 0E 83 EC 0C";
			this.AutoShot.ChangeToCode = "08 0F B6 80 A0 00 00 00 85 C0 90 90 83 EC 0C";
			this.AutoShot.AddressAlign = 407981160;
			this.msb.ScanCode = "00 00 F0 41 00 00 16 43 01 10";
			this.msb.ChangeToCode = "00 40 1C 46 00 00 16 43 01 10";
			this.msb.AddressAlign = 476806828;
			this.SB.ScanCode = "89 4D BC 8B 48 04 89 4D C0 8B 40 08 89 45 C4 8D 46 24 8B 4D BC 89 08 8B";
			this.SB.ChangeToCode = "89 4D BC 8B 48 04 89 4D C0 8B 40 08 89 41 C4 8D 46 24 8B 4D BC 89 08 8B";
			this.SB.AddressAlign = 518961260;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000100F8 File Offset: 0x0000E2F8
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

		// Token: 0x06000071 RID: 113 RVA: 0x0001017D File Offset: 0x0000E37D
		private void az_WEAPON_Load(object sender, EventArgs e)
		{
			this.LoadAllCheats();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00010188 File Offset: 0x0000E388
		private void RP_CubeGun_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.RP_CubeGun_Check.Checked;
			if (@checked)
			{
				this.label6.Text = "ON";
				this.label6.ForeColor = Color.SpringGreen;
				this.CubeGunRapidFire.ScanCheat(this.kogProc);
				bool found = this.CubeGunRapidFire.Found;
				if (found)
				{
					this.CubeGunRapidFire.ActivateCheat(this.kogProc);
				}
				else
				{
					this.RP_CubeGun_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label6.Text = "OFF";
				this.label6.ForeColor = Color.LightCoral;
				bool found2 = this.CubeGunRapidFire.Found;
				if (found2)
				{
					this.CubeGunRapidFire.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00010258 File Offset: 0x0000E458
		private void RP_ImpulseGun_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.RP_ImpulseGun_Check.Checked;
			if (@checked)
			{
				this.label2.Text = "ON";
				this.label2.ForeColor = Color.SpringGreen;
				this.ImpulseGunRapidFire.ScanCheat(this.kogProc);
				bool found = this.ImpulseGunRapidFire.Found;
				if (found)
				{
					this.ImpulseGunRapidFire.ActivateCheat(this.kogProc);
				}
				else
				{
					this.RP_ImpulseGun_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label2.Text = "OFF";
				this.label2.ForeColor = Color.LightCoral;
				bool found2 = this.ImpulseGunRapidFire.Found;
				if (found2)
				{
					this.ImpulseGunRapidFire.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00010328 File Offset: 0x0000E528
		private void RP_RailGun_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.RP_RailGun_Check.Checked;
			if (@checked)
			{
				this.label3.Text = "ON";
				this.label3.ForeColor = Color.SpringGreen;
				this.RailGunRapidFire.ScanCheat(this.kogProc);
				bool found = this.RailGunRapidFire.Found;
				if (found)
				{
					this.RailGunRapidFire.ActivateCheat(this.kogProc);
				}
				else
				{
					this.RP_RailGun_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label3.Text = "OFF";
				this.label3.ForeColor = Color.LightCoral;
				bool found2 = this.RailGunRapidFire.Found;
				if (found2)
				{
					this.RailGunRapidFire.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000103F8 File Offset: 0x0000E5F8
		private void RP_Other_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.RP_Other_Check.Checked;
			if (@checked)
			{
				this.label4.Text = "ON";
				this.label4.ForeColor = Color.SpringGreen;
				this.OthersRapidFire.ScanCheat(this.kogProc);
				bool found = this.OthersRapidFire.Found;
				if (found)
				{
					this.OthersRapidFire.ActivateCheat(this.kogProc);
				}
				else
				{
					this.RP_Other_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label4.Text = "OFF";
				this.label4.ForeColor = Color.LightCoral;
				bool found2 = this.OthersRapidFire.Found;
				if (found2)
				{
					this.OthersRapidFire.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000104C8 File Offset: 0x0000E6C8
		private void InfiniteAmmo_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.InfiniteAmmo_Check.Checked;
			if (@checked)
			{
				this.label12.Text = "ON";
				this.label12.ForeColor = Color.SpringGreen;
				this.CheatInfiniteAmmo.ScanCheat(this.kogProc);
				bool found = this.CheatInfiniteAmmo.Found;
				if (found)
				{
					this.CheatInfiniteAmmo.ActivateCheat(this.kogProc);
				}
				else
				{
					this.RP_Other_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label12.Text = "OFF";
				this.label12.ForeColor = Color.LightCoral;
				bool found2 = this.CheatInfiniteAmmo.Found;
				if (found2)
				{
					this.CheatInfiniteAmmo.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00010598 File Offset: 0x0000E798
		private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox2.Checked;
			if (@checked)
			{
				this.label16.Text = "ON";
				this.label16.ForeColor = Color.SpringGreen;
				this.SuperImpulse.ScanCheat(this.kogProc);
				bool found = this.SuperImpulse.Found;
				if (found)
				{
					this.SuperImpulse.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox2.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label16.Text = "OFF";
				this.label16.ForeColor = Color.LightCoral;
				bool found2 = this.SuperImpulse.Found;
				if (found2)
				{
					this.SuperImpulse.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00010668 File Offset: 0x0000E868
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox1.Checked;
			if (@checked)
			{
				this.label19.Text = "ON";
				this.label19.ForeColor = Color.SpringGreen;
				this.AutoShot.ScanCheat(this.kogProc);
				bool found = this.AutoShot.Found;
				if (found)
				{
					this.AutoShot.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox1.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label19.Text = "OFF";
				this.label19.ForeColor = Color.LightCoral;
				bool found2 = this.AutoShot.Found;
				if (found2)
				{
					this.AutoShot.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00010738 File Offset: 0x0000E938
		private void siticoneCustomCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox3.Checked;
			if (@checked)
			{
				this.label18.Text = "ON";
				this.label18.ForeColor = Color.SpringGreen;
				this.SlowAmmo.ScanCheat(this.kogProc);
				bool found = this.SlowAmmo.Found;
				if (found)
				{
					this.SlowAmmo.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox3.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label18.Text = "OFF";
				this.label18.ForeColor = Color.LightCoral;
				bool found2 = this.SlowAmmo.Found;
				if (found2)
				{
					this.SlowAmmo.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00010808 File Offset: 0x0000EA08
		private void siticoneCustomCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox4.Checked;
			if (@checked)
			{
				this.label20.Text = "ON";
				this.label20.ForeColor = Color.SpringGreen;
				this.msb.ScanCheat(this.kogProc);
				bool found = this.msb.Found;
				if (found)
				{
					this.msb.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox4.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label20.Text = "OFF";
				this.label20.ForeColor = Color.LightCoral;
				bool found2 = this.msb.Found;
				if (found2)
				{
					this.msb.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000108D8 File Offset: 0x0000EAD8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00010910 File Offset: 0x0000EB10
		private void InitializeComponent()
		{
			this.components = new Container();
			this.label1 = new Label();
			this.timerProcess = new Timer(this.components);
			this.timer1 = new Timer(this.components);
			this.label5 = new Label();
			this.panel3 = new Panel();
			this.label10 = new Label();
			this.label8 = new Label();
			this.label4 = new Label();
			this.RP_Other_Check = new SiticoneCustomCheckBox();
			this.label7 = new Label();
			this.label9 = new Label();
			this.label3 = new Label();
			this.RP_RailGun_Check = new SiticoneCustomCheckBox();
			this.label2 = new Label();
			this.RP_ImpulseGun_Check = new SiticoneCustomCheckBox();
			this.label6 = new Label();
			this.RP_CubeGun_Check = new SiticoneCustomCheckBox();
			this.siticonePanel1 = new SiticonePanel();
			this.label11 = new Label();
			this.label12 = new Label();
			this.InfiniteAmmo_Check = new SiticoneCustomCheckBox();
			this.label119 = new Label();
			this.panel2 = new Panel();
			this.label17 = new Label();
			this.label18 = new Label();
			this.siticoneCustomCheckBox3 = new SiticoneCustomCheckBox();
			this.label15 = new Label();
			this.label16 = new Label();
			this.siticoneCustomCheckBox2 = new SiticoneCustomCheckBox();
			this.panel1 = new Panel();
			this.label13 = new Label();
			this.label14 = new Label();
			this.siticoneCustomCheckBox1 = new SiticoneCustomCheckBox();
			this.label19 = new Label();
			this.label20 = new Label();
			this.siticoneCustomCheckBox4 = new SiticoneCustomCheckBox();
			this.label21 = new Label();
			this.label22 = new Label();
			this.label23 = new Label();
			this.siticoneCustomCheckBox5 = new SiticoneCustomCheckBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(166, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(106, 21);
			this.label1.TabIndex = 56;
			this.label1.Text = "•WEAPON•";
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += this.timerProcess_Tick;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(47, 38);
			this.label5.Name = "label5";
			this.label5.Size = new Size(67, 15);
			this.label5.TabIndex = 89;
			this.label5.Text = "Rapid Fire:";
			this.panel3.BackColor = Color.FromArgb(243, 109, 109);
			this.panel3.Location = new Point(11, 45);
			this.panel3.Margin = new Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(143, 1);
			this.panel3.TabIndex = 77;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label10.ForeColor = Color.White;
			this.label10.Location = new Point(8, 140);
			this.label10.Name = "label10";
			this.label10.Size = new Size(43, 15);
			this.label10.TabIndex = 88;
			this.label10.Text = "Others";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(8, 86);
			this.label8.Name = "label8";
			this.label8.Size = new Size(77, 15);
			this.label8.TabIndex = 87;
			this.label8.Text = "Impulse Gun";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label4.ForeColor = Color.LightCoral;
			this.label4.Location = new Point(131, 140);
			this.label4.Name = "label4";
			this.label4.Size = new Size(30, 15);
			this.label4.TabIndex = 86;
			this.label4.Text = "OFF";
			this.RP_Other_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.RP_Other_Check.CheckedState.BorderRadius = 2;
			this.RP_Other_Check.CheckedState.BorderThickness = 0;
			this.RP_Other_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.RP_Other_Check.CheckedState.Parent = this.RP_Other_Check;
			this.RP_Other_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.RP_Other_Check.Location = new Point(105, 138);
			this.RP_Other_Check.Name = "RP_Other_Check";
			this.RP_Other_Check.ShadowDecoration.Parent = this.RP_Other_Check;
			this.RP_Other_Check.Size = new Size(20, 20);
			this.RP_Other_Check.TabIndex = 85;
			this.RP_Other_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.RP_Other_Check.UncheckedState.BorderRadius = 2;
			this.RP_Other_Check.UncheckedState.BorderThickness = 0;
			this.RP_Other_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.RP_Other_Check.UncheckedState.Parent = this.RP_Other_Check;
			this.RP_Other_Check.CheckedChanged += this.RP_Other_Check_CheckedChanged;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(8, 60);
			this.label7.Name = "label7";
			this.label7.Size = new Size(59, 15);
			this.label7.TabIndex = 84;
			this.label7.Text = "CubeGun";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(8, 112);
			this.label9.Name = "label9";
			this.label9.Size = new Size(52, 15);
			this.label9.TabIndex = 83;
			this.label9.Text = "RailGun";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label3.ForeColor = Color.LightCoral;
			this.label3.Location = new Point(131, 111);
			this.label3.Name = "label3";
			this.label3.Size = new Size(30, 15);
			this.label3.TabIndex = 82;
			this.label3.Text = "OFF";
			this.RP_RailGun_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.RP_RailGun_Check.CheckedState.BorderRadius = 2;
			this.RP_RailGun_Check.CheckedState.BorderThickness = 0;
			this.RP_RailGun_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.RP_RailGun_Check.CheckedState.Parent = this.RP_RailGun_Check;
			this.RP_RailGun_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.RP_RailGun_Check.Location = new Point(105, 109);
			this.RP_RailGun_Check.Name = "RP_RailGun_Check";
			this.RP_RailGun_Check.ShadowDecoration.Parent = this.RP_RailGun_Check;
			this.RP_RailGun_Check.Size = new Size(20, 20);
			this.RP_RailGun_Check.TabIndex = 81;
			this.RP_RailGun_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.RP_RailGun_Check.UncheckedState.BorderRadius = 2;
			this.RP_RailGun_Check.UncheckedState.BorderThickness = 0;
			this.RP_RailGun_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.RP_RailGun_Check.UncheckedState.Parent = this.RP_RailGun_Check;
			this.RP_RailGun_Check.CheckedChanged += this.RP_RailGun_Check_CheckedChanged;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label2.ForeColor = Color.LightCoral;
			this.label2.Location = new Point(131, 85);
			this.label2.Name = "label2";
			this.label2.Size = new Size(30, 15);
			this.label2.TabIndex = 80;
			this.label2.Text = "OFF";
			this.RP_ImpulseGun_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.RP_ImpulseGun_Check.CheckedState.BorderRadius = 2;
			this.RP_ImpulseGun_Check.CheckedState.BorderThickness = 0;
			this.RP_ImpulseGun_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.RP_ImpulseGun_Check.CheckedState.Parent = this.RP_ImpulseGun_Check;
			this.RP_ImpulseGun_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.RP_ImpulseGun_Check.Location = new Point(105, 83);
			this.RP_ImpulseGun_Check.Name = "RP_ImpulseGun_Check";
			this.RP_ImpulseGun_Check.ShadowDecoration.Parent = this.RP_ImpulseGun_Check;
			this.RP_ImpulseGun_Check.Size = new Size(20, 20);
			this.RP_ImpulseGun_Check.TabIndex = 79;
			this.RP_ImpulseGun_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.RP_ImpulseGun_Check.UncheckedState.BorderRadius = 2;
			this.RP_ImpulseGun_Check.UncheckedState.BorderThickness = 0;
			this.RP_ImpulseGun_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.RP_ImpulseGun_Check.UncheckedState.Parent = this.RP_ImpulseGun_Check;
			this.RP_ImpulseGun_Check.CheckedChanged += this.RP_ImpulseGun_Check_CheckedChanged;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label6.ForeColor = Color.LightCoral;
			this.label6.Location = new Point(131, 59);
			this.label6.Name = "label6";
			this.label6.Size = new Size(30, 15);
			this.label6.TabIndex = 78;
			this.label6.Text = "OFF";
			this.RP_CubeGun_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.RP_CubeGun_Check.CheckedState.BorderRadius = 2;
			this.RP_CubeGun_Check.CheckedState.BorderThickness = 0;
			this.RP_CubeGun_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.RP_CubeGun_Check.CheckedState.Parent = this.RP_CubeGun_Check;
			this.RP_CubeGun_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.RP_CubeGun_Check.Location = new Point(105, 57);
			this.RP_CubeGun_Check.Name = "RP_CubeGun_Check";
			this.RP_CubeGun_Check.ShadowDecoration.Parent = this.RP_CubeGun_Check;
			this.RP_CubeGun_Check.Size = new Size(20, 20);
			this.RP_CubeGun_Check.TabIndex = 76;
			this.RP_CubeGun_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.RP_CubeGun_Check.UncheckedState.BorderRadius = 2;
			this.RP_CubeGun_Check.UncheckedState.BorderThickness = 0;
			this.RP_CubeGun_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.RP_CubeGun_Check.UncheckedState.Parent = this.RP_CubeGun_Check;
			this.RP_CubeGun_Check.CheckedChanged += this.RP_CubeGun_Check_CheckedChanged;
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 90;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(58, 162);
			this.label11.Name = "label11";
			this.label11.Size = new Size(43, 15);
			this.label11.TabIndex = 95;
			this.label11.Text = "Ammo";
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label12.ForeColor = Color.LightCoral;
			this.label12.Location = new Point(131, 184);
			this.label12.Name = "label12";
			this.label12.Size = new Size(30, 15);
			this.label12.TabIndex = 94;
			this.label12.Text = "OFF";
			this.InfiniteAmmo_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.InfiniteAmmo_Check.CheckedState.BorderRadius = 2;
			this.InfiniteAmmo_Check.CheckedState.BorderThickness = 0;
			this.InfiniteAmmo_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.InfiniteAmmo_Check.CheckedState.Parent = this.InfiniteAmmo_Check;
			this.InfiniteAmmo_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.InfiniteAmmo_Check.Location = new Point(105, 181);
			this.InfiniteAmmo_Check.Name = "InfiniteAmmo_Check";
			this.InfiniteAmmo_Check.ShadowDecoration.Parent = this.InfiniteAmmo_Check;
			this.InfiniteAmmo_Check.Size = new Size(20, 20);
			this.InfiniteAmmo_Check.TabIndex = 93;
			this.InfiniteAmmo_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.InfiniteAmmo_Check.UncheckedState.BorderRadius = 2;
			this.InfiniteAmmo_Check.UncheckedState.BorderThickness = 0;
			this.InfiniteAmmo_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.InfiniteAmmo_Check.UncheckedState.Parent = this.InfiniteAmmo_Check;
			this.InfiniteAmmo_Check.CheckedChanged += this.InfiniteAmmo_Check_CheckedChanged;
			this.label119.AutoSize = true;
			this.label119.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label119.ForeColor = Color.White;
			this.label119.Location = new Point(8, 183);
			this.label119.Name = "label119";
			this.label119.Size = new Size(67, 15);
			this.label119.TabIndex = 92;
			this.label119.Text = "INF AMMO";
			this.panel2.BackColor = Color.FromArgb(243, 109, 109);
			this.panel2.Location = new Point(11, 170);
			this.panel2.Margin = new Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(143, 1);
			this.panel2.TabIndex = 91;
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label17.ForeColor = Color.White;
			this.label17.Location = new Point(7, 211);
			this.label17.Name = "label17";
			this.label17.Size = new Size(73, 15);
			this.label17.TabIndex = 98;
			this.label17.Text = "Slow Ammo";
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label18.ForeColor = Color.LightCoral;
			this.label18.Location = new Point(131, 211);
			this.label18.Name = "label18";
			this.label18.Size = new Size(30, 15);
			this.label18.TabIndex = 97;
			this.label18.Text = "OFF";
			this.siticoneCustomCheckBox3.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox3.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox3.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.Location = new Point(105, 209);
			this.siticoneCustomCheckBox3.Name = "siticoneCustomCheckBox3";
			this.siticoneCustomCheckBox3.ShadowDecoration.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.Size = new Size(20, 20);
			this.siticoneCustomCheckBox3.TabIndex = 96;
			this.siticoneCustomCheckBox3.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox3.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox3.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.UncheckedState.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.CheckedChanged += this.siticoneCustomCheckBox3_CheckedChanged;
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label15.ForeColor = Color.White;
			this.label15.Location = new Point(223, 61);
			this.label15.Name = "label15";
			this.label15.Size = new Size(87, 15);
			this.label15.TabIndex = 101;
			this.label15.Text = "Super Impulse";
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label16.ForeColor = Color.LightCoral;
			this.label16.Location = new Point(369, 60);
			this.label16.Name = "label16";
			this.label16.Size = new Size(30, 15);
			this.label16.TabIndex = 100;
			this.label16.Text = "OFF";
			this.siticoneCustomCheckBox2.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.Location = new Point(343, 58);
			this.siticoneCustomCheckBox2.Name = "siticoneCustomCheckBox2";
			this.siticoneCustomCheckBox2.ShadowDecoration.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.Size = new Size(20, 20);
			this.siticoneCustomCheckBox2.TabIndex = 99;
			this.siticoneCustomCheckBox2.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckedChanged += this.siticoneCustomCheckBox2_CheckedChanged;
			this.panel1.BackColor = Color.FromArgb(243, 109, 109);
			this.panel1.Location = new Point(226, 45);
			this.panel1.Margin = new Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(170, 1);
			this.panel1.TabIndex = 78;
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label13.ForeColor = Color.White;
			this.label13.Location = new Point(286, 37);
			this.label13.Name = "label13";
			this.label13.Size = new Size(43, 15);
			this.label13.TabIndex = 102;
			this.label13.Text = "Others";
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label14.ForeColor = Color.White;
			this.label14.Location = new Point(223, 87);
			this.label14.Name = "label14";
			this.label14.Size = new Size(59, 15);
			this.label14.TabIndex = 103;
			this.label14.Text = "Auto Shot";
			this.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.Location = new Point(343, 84);
			this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Size = new Size(20, 20);
			this.siticoneCustomCheckBox1.TabIndex = 104;
			this.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckedChanged += this.siticoneCustomCheckBox1_CheckedChanged;
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label19.ForeColor = Color.LightCoral;
			this.label19.Location = new Point(369, 86);
			this.label19.Name = "label19";
			this.label19.Size = new Size(30, 15);
			this.label19.TabIndex = 105;
			this.label19.Text = "OFF";
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label20.ForeColor = Color.LightCoral;
			this.label20.Location = new Point(369, 111);
			this.label20.Name = "label20";
			this.label20.Size = new Size(30, 15);
			this.label20.TabIndex = 108;
			this.label20.Text = "OFF";
			this.siticoneCustomCheckBox4.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.Location = new Point(343, 109);
			this.siticoneCustomCheckBox4.Name = "siticoneCustomCheckBox4";
			this.siticoneCustomCheckBox4.ShadowDecoration.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.Size = new Size(20, 20);
			this.siticoneCustomCheckBox4.TabIndex = 107;
			this.siticoneCustomCheckBox4.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckedChanged += this.siticoneCustomCheckBox4_CheckedChanged;
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label21.ForeColor = Color.White;
			this.label21.Location = new Point(223, 112);
			this.label21.Name = "label21";
			this.label21.Size = new Size(118, 15);
			this.label21.TabIndex = 106;
			this.label21.Text = "Max speed bazooka";
			this.label22.AutoSize = true;
			this.label22.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label22.ForeColor = Color.White;
			this.label22.Location = new Point(7, 237);
			this.label22.Name = "label22";
			this.label22.Size = new Size(72, 15);
			this.label22.TabIndex = 111;
			this.label22.Text = "Stop Bullets";
			this.label23.AutoSize = true;
			this.label23.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label23.ForeColor = Color.LightCoral;
			this.label23.Location = new Point(131, 237);
			this.label23.Name = "label23";
			this.label23.Size = new Size(30, 15);
			this.label23.TabIndex = 110;
			this.label23.Text = "OFF";
			this.siticoneCustomCheckBox5.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.Location = new Point(105, 235);
			this.siticoneCustomCheckBox5.Name = "siticoneCustomCheckBox5";
			this.siticoneCustomCheckBox5.ShadowDecoration.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.Size = new Size(20, 20);
			this.siticoneCustomCheckBox5.TabIndex = 109;
			this.siticoneCustomCheckBox5.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.Parent = this.siticoneCustomCheckBox5;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(36, 38, 42);
			base.Controls.Add(this.label22);
			base.Controls.Add(this.label23);
			base.Controls.Add(this.siticoneCustomCheckBox5);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.siticoneCustomCheckBox4);
			base.Controls.Add(this.label21);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.siticoneCustomCheckBox1);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.siticoneCustomCheckBox2);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.label18);
			base.Controls.Add(this.siticoneCustomCheckBox3);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.InfiniteAmmo_Check);
			base.Controls.Add(this.label119);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.RP_Other_Check);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.RP_RailGun_Check);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.RP_ImpulseGun_Check);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.RP_CubeGun_Check);
			base.Controls.Add(this.label1);
			base.Name = "az_WEAPON";
			base.Size = new Size(439, 267);
			base.Load += this.az_WEAPON_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000107 RID: 263
		private int ProcessID = 0;

		// Token: 0x04000108 RID: 264
		private Process kogProc;

		// Token: 0x04000109 RID: 265
		private Cheat CubeGunRapidFire = new Cheat();

		// Token: 0x0400010A RID: 266
		private Cheat ImpulseGunRapidFire = new Cheat();

		// Token: 0x0400010B RID: 267
		private Cheat RailGunRapidFire = new Cheat();

		// Token: 0x0400010C RID: 268
		private Cheat OthersRapidFire = new Cheat();

		// Token: 0x0400010D RID: 269
		private Cheat CheatInfiniteAmmo = new Cheat();

		// Token: 0x0400010E RID: 270
		private Cheat SuperImpulse = new Cheat();

		// Token: 0x0400010F RID: 271
		private Cheat SlowAmmo = new Cheat();

		// Token: 0x04000110 RID: 272
		private Cheat AutoShot = new Cheat();

		// Token: 0x04000111 RID: 273
		private Cheat msb = new Cheat();

		// Token: 0x04000112 RID: 274
		private Cheat SB = new Cheat();

		// Token: 0x04000113 RID: 275
		private IContainer components = null;

		// Token: 0x04000114 RID: 276
		private Label label1;

		// Token: 0x04000115 RID: 277
		private Timer timerProcess;

		// Token: 0x04000116 RID: 278
		private Timer timer1;

		// Token: 0x04000117 RID: 279
		private Label label5;

		// Token: 0x04000118 RID: 280
		private Panel panel3;

		// Token: 0x04000119 RID: 281
		private Label label10;

		// Token: 0x0400011A RID: 282
		private Label label8;

		// Token: 0x0400011B RID: 283
		private Label label4;

		// Token: 0x0400011C RID: 284
		private SiticoneCustomCheckBox RP_Other_Check;

		// Token: 0x0400011D RID: 285
		private Label label7;

		// Token: 0x0400011E RID: 286
		private Label label9;

		// Token: 0x0400011F RID: 287
		private Label label3;

		// Token: 0x04000120 RID: 288
		private SiticoneCustomCheckBox RP_RailGun_Check;

		// Token: 0x04000121 RID: 289
		private Label label2;

		// Token: 0x04000122 RID: 290
		private SiticoneCustomCheckBox RP_ImpulseGun_Check;

		// Token: 0x04000123 RID: 291
		private Label label6;

		// Token: 0x04000124 RID: 292
		private SiticoneCustomCheckBox RP_CubeGun_Check;

		// Token: 0x04000125 RID: 293
		private SiticonePanel siticonePanel1;

		// Token: 0x04000126 RID: 294
		private Label label11;

		// Token: 0x04000127 RID: 295
		private Label label12;

		// Token: 0x04000128 RID: 296
		private SiticoneCustomCheckBox InfiniteAmmo_Check;

		// Token: 0x04000129 RID: 297
		private Label label119;

		// Token: 0x0400012A RID: 298
		private Panel panel2;

		// Token: 0x0400012B RID: 299
		private Label label17;

		// Token: 0x0400012C RID: 300
		private Label label18;

		// Token: 0x0400012D RID: 301
		private SiticoneCustomCheckBox siticoneCustomCheckBox3;

		// Token: 0x0400012E RID: 302
		private Label label15;

		// Token: 0x0400012F RID: 303
		private Label label16;

		// Token: 0x04000130 RID: 304
		private SiticoneCustomCheckBox siticoneCustomCheckBox2;

		// Token: 0x04000131 RID: 305
		private Panel panel1;

		// Token: 0x04000132 RID: 306
		private Label label13;

		// Token: 0x04000133 RID: 307
		private Label label14;

		// Token: 0x04000134 RID: 308
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000135 RID: 309
		private Label label19;

		// Token: 0x04000136 RID: 310
		private Label label20;

		// Token: 0x04000137 RID: 311
		private SiticoneCustomCheckBox siticoneCustomCheckBox4;

		// Token: 0x04000138 RID: 312
		private Label label21;

		// Token: 0x04000139 RID: 313
		private Label label22;

		// Token: 0x0400013A RID: 314
		private Label label23;

		// Token: 0x0400013B RID: 315
		private SiticoneCustomCheckBox siticoneCustomCheckBox5;
	}
}
