using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x02000009 RID: 9
	public class az_PLAYER : UserControl
	{
		// Token: 0x0600004D RID: 77
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600004E RID: 78 RVA: 0x0000A3D4 File Offset: 0x000085D4
		public az_PLAYER()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000A4B0 File Offset: 0x000086B0
		private void LoadAllCheats()
		{
			this.immortality.ScanCode = "08 D9 40 28 D9 40 2C 83";
			this.immortality.ChangeToCode = "90";
			this.immortality.AddressAlign = 334254915;
			this.InfiniteOxygen.ScanCode = "55 8B EC 56 83 EC 24 8B 75 08 D9 EE D9 5D EC 8D 46 14 8B 08 89 4D F0";
			this.InfiniteOxygen.ChangeToCode = "55 8B FC 56 83 EC 24 8B 75 08 D9 EE D9 5D EC 8D 46 14 8B 08 89 4D F0";
			this.InfiniteOxygen.AddressAlign = 333454920;
			this.GiantClass.ScanCode = "08 D9 45 0C 8B 45 08 D9 40 28 D9 40 2C 83 EC 04 83 EC 04 D9 1C 24 83 EC";
			this.GiantClass.ChangeToCode = "08 D9 45 3C 8B 45 08 D9 40 28 D9 40 2C 83 EC 04 83 EC 04 D9 1C 24 83 3C";
			this.GiantClass.AddressAlign = 51564573;
			this.CheatAntAFK.ScanCode = "2C 85 C0 74 0E";
			this.CheatAntAFK.ChangeToCode = "2C 85 C0 EB 0E";
			this.CheatAntAFK.AddressAlign = 323135963;
			this.AutoHeal.ScanCode = "03 00 00 00 15 01 00 00 00 00 00 00 00 00 70 41";
			this.AutoHeal.ChangeToCode = "03 00 00 00 15 01 00 00 00 00 00 00 F9 02 15 D0";
			this.AutoHeal.AddressAlign = 382787860;
			this.NoClip.ScanCode = "89 48 04 C9 C3 00 00 00 00 00 00 55 8B EC";
			this.NoClip.ChangeToCode = "89 48 90";
			this.NoClip.AddressAlign = 407519117;
			this.NoClip2.ScanCode = "89 48 90";
			this.NoClip2.ChangeToCode = "89 48 04 C9 C3 00 00 00 00 00 00 55 8B EC";
			this.NoClip2.AddressAlign = 407519117;
			this.freeze.ScanCode = "8B 7D 08 8B 87 ?? 01 00 00 89 45 F8 E8 ?? ?? ?? ?? 8B C8 8B 45 F8 3B C1";
			this.freeze.ChangeToCode = "8B 7D 08 8B 87 ?? 01 00 00 89 45 F8 E8 ?? ?? ?? ?? 8B C8 8B 45 F8 90 90";
			this.freeze.AddressAlign = 89993047;
			this.NoChatLimit.ScanCode = "05 00 00 00 ?? ?? 00 00 ?? ?? ?? ?? 07 00 00 00 00 00 00 00 EA E9 69 3F 85 84 04 3F 00 00 00 00";
			this.NoChatLimit.ChangeToCode = "E7 03 00 00";
			this.NoChatLimit.AddressAlign = 379130572;
			this.Person3RD.ScanCode = "0F B6 40 54 85 C0 74 04 33 C0 EB 15";
			this.Person3RD.ChangeToCode = "90 90 90 90 85 C0 74 04 33 C0 EB 15";
			this.Person3RD.AddressAlign = 48968636;
			this.WithoutBlinking.ScanCode = "0F 86 69 00 00 00 33";
			this.WithoutBlinking.ChangeToCode = "90 90 90 90 90 90";
			this.WithoutBlinking.AddressAlign = 49221160;
			this.NoImpulse.ScanCode = "55 8B EC 56 83 EC 04 8B 75 0C 85 F6 0F 94";
			this.NoImpulse.ChangeToCode = "C3";
			this.NoImpulse.AddressAlign = 511399400;
			this.Invisible.ScanCode = "51 08 8B 55 F0 89 51 0C 8B 55 F4 89 51 10 8D 4D F8 83 EC 08 50 51 8B 00 BA ?? ?? ?? ??";
			this.Invisible.ChangeToCode = "90";
			this.Invisible.AddressAlign = 401370932;
			this.HealingParticles.ScanCode = "0F 83 FE 00 00 00 D9 45 F4 D9 E8 DF F1 DD D8 0F";
			this.HealingParticles.ChangeToCode = "90 90 90 90 90 90";
			this.HealingParticles.AddressAlign = 408335949;
			this.NeverCrushed.ScanCode = "75 18 8B 47 08";
			this.NeverCrushed.ChangeToCode = "90 90";
			this.NeverCrushed.AddressAlign = 337686807;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000A790 File Offset: 0x00008990
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

		// Token: 0x06000051 RID: 81 RVA: 0x0000A815 File Offset: 0x00008A15
		private void az_PLAYER_Load(object sender, EventArgs e)
		{
			this.LoadAllCheats();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000A820 File Offset: 0x00008A20
		private void immortality_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.immortality_Check.Checked;
			if (@checked)
			{
				this.label5.Text = "ON";
				this.label5.ForeColor = Color.SpringGreen;
				this.immortality.ScanCheat(this.kogProc);
				bool found = this.immortality.Found;
				if (found)
				{
					this.immortality.ActivateCheat(this.kogProc);
				}
				else
				{
					this.immortality_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label5.Text = "OFF";
				this.label5.ForeColor = Color.LightCoral;
				bool found2 = this.immortality.Found;
				if (found2)
				{
					this.immortality.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		private void Infiniteoxygen_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Infiniteoxygen_Check.Checked;
			if (@checked)
			{
				this.label3.Text = "ON";
				this.label3.ForeColor = Color.SpringGreen;
				this.InfiniteOxygen.ScanCheat(this.kogProc);
				bool found = this.InfiniteOxygen.Found;
				if (found)
				{
					this.InfiniteOxygen.ActivateCheat(this.kogProc);
				}
				else
				{
					this.Infiniteoxygen_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label3.Text = "OFF";
				this.label3.ForeColor = Color.LightCoral;
				bool found2 = this.InfiniteOxygen.Found;
				if (found2)
				{
					this.InfiniteOxygen.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		private void GiantClass_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.GiantClass_Check.Checked;
			if (@checked)
			{
				this.label2.Text = "ON";
				this.label2.ForeColor = Color.SpringGreen;
				this.GiantClass.ScanCheat(this.kogProc);
				bool found = this.GiantClass.Found;
				if (found)
				{
					this.GiantClass.ActivateCheat(this.kogProc);
				}
				else
				{
					this.GiantClass_Check.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label2.Text = "OFF";
				this.label2.ForeColor = Color.LightCoral;
				bool found2 = this.GiantClass.Found;
				if (found2)
				{
					this.GiantClass.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000AA90 File Offset: 0x00008C90
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox1.Checked;
			if (@checked)
			{
				this.label7.Text = "ON";
				this.label7.ForeColor = Color.SpringGreen;
				this.CheatAntAFK.ScanCheat(this.kogProc);
				bool found = this.CheatAntAFK.Found;
				if (found)
				{
					this.CheatAntAFK.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox1.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label7.Text = "OFF";
				this.label7.ForeColor = Color.LightCoral;
				bool found2 = this.CheatAntAFK.Found;
				if (found2)
				{
					this.CheatAntAFK.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000AB60 File Offset: 0x00008D60
		private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox2.Checked;
			if (@checked)
			{
				this.label10.Text = "ON";
				this.label10.ForeColor = Color.SpringGreen;
				this.AutoHeal.ScanCheat(this.kogProc);
				bool found = this.AutoHeal.Found;
				if (found)
				{
					this.AutoHeal.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox2.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label10.Text = "OFF";
				this.label10.ForeColor = Color.LightCoral;
				bool found2 = this.AutoHeal.Found;
				if (found2)
				{
					this.AutoHeal.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000AC30 File Offset: 0x00008E30
		private void az_PLAYER_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000AC34 File Offset: 0x00008E34
		private void siticoneCustomCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox3.Checked;
			if (@checked)
			{
				this.label12.Text = "ON";
				this.label12.ForeColor = Color.SpringGreen;
				this.NoClip.ScanCheat(this.kogProc);
				bool found = this.NoClip.Found;
				if (found)
				{
					this.NoClip.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox3.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label12.Text = "OFF";
				this.label12.ForeColor = Color.LightCoral;
				bool found2 = this.NoClip.Found;
				if (found2)
				{
					this.NoClip.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000AD04 File Offset: 0x00008F04
		private void siticoneCustomCheckBox3_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000AD08 File Offset: 0x00008F08
		private void siticoneCustomCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox4.Checked;
			if (@checked)
			{
				this.label15.Text = "ON";
				this.label15.ForeColor = Color.SpringGreen;
				this.freeze.ScanCheat(this.kogProc);
				bool found = this.freeze.Found;
				if (found)
				{
					this.freeze.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox4.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label15.Text = "OFF";
				this.label15.ForeColor = Color.LightCoral;
				bool found2 = this.freeze.Found;
				if (found2)
				{
					this.freeze.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		private void siticoneCustomCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox5.Checked;
			if (@checked)
			{
				this.label16.Text = "ON";
				this.label16.ForeColor = Color.SpringGreen;
				this.NoChatLimit.ScanCheat(this.kogProc);
				bool found = this.NoChatLimit.Found;
				if (found)
				{
					this.NoChatLimit.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox5.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label16.Text = "OFF";
				this.label16.ForeColor = Color.LightCoral;
				bool found2 = this.NoChatLimit.Found;
				if (found2)
				{
					this.NoChatLimit.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000AEA8 File Offset: 0x000090A8
		private void siticoneCustomCheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox6.Checked;
			if (@checked)
			{
				this.label18.Text = "ON";
				this.label18.ForeColor = Color.SpringGreen;
				this.Person3RD.ScanCheat(this.kogProc);
				bool found = this.Person3RD.Found;
				if (found)
				{
					this.Person3RD.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox6.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label18.Text = "OFF";
				this.label18.ForeColor = Color.LightCoral;
				bool found2 = this.Person3RD.Found;
				if (found2)
				{
					this.Person3RD.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000AF78 File Offset: 0x00009178
		private void siticoneCustomCheckBox9_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox9.Checked;
			if (@checked)
			{
				this.label24.Text = "ON";
				this.label24.ForeColor = Color.SpringGreen;
				this.WithoutBlinking.ScanCheat(this.kogProc);
				bool found = this.WithoutBlinking.Found;
				if (found)
				{
					this.WithoutBlinking.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox9.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label24.Text = "OFF";
				this.label24.ForeColor = Color.LightCoral;
				bool found2 = this.WithoutBlinking.Found;
				if (found2)
				{
					this.WithoutBlinking.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000B048 File Offset: 0x00009248
		private void siticoneCustomCheckBox11_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox11.Checked;
			if (@checked)
			{
				this.label28.Text = "ON";
				this.label28.ForeColor = Color.SpringGreen;
				this.Invisible.ScanCheat(this.kogProc);
				bool found = this.Invisible.Found;
				if (found)
				{
					this.Invisible.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox11.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label28.Text = "OFF";
				this.label28.ForeColor = Color.LightCoral;
				bool found2 = this.Invisible.Found;
				if (found2)
				{
					this.Invisible.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000B118 File Offset: 0x00009318
		private void siticoneCustomCheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox7.Checked;
			if (@checked)
			{
				this.label20.Text = "ON";
				this.label20.ForeColor = Color.SpringGreen;
				this.HealingParticles.ScanCheat(this.kogProc);
				bool found = this.HealingParticles.Found;
				if (found)
				{
					this.HealingParticles.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox7.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label20.Text = "OFF";
				this.label20.ForeColor = Color.LightCoral;
				bool found2 = this.HealingParticles.Found;
				if (found2)
				{
					this.HealingParticles.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000B1EC File Offset: 0x000093EC
		private void siticoneCustomCheckBox10_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox10.Checked;
			if (@checked)
			{
				this.label26.Text = "ON";
				this.label26.ForeColor = Color.SpringGreen;
				this.NoImpulse.ScanCheat(this.kogProc);
				bool found = this.NoImpulse.Found;
				if (found)
				{
					this.NoImpulse.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox10.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label26.Text = "OFF";
				this.label26.ForeColor = Color.LightCoral;
				bool found2 = this.NoImpulse.Found;
				if (found2)
				{
					this.NoImpulse.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000B2BC File Offset: 0x000094BC
		private void siticoneCustomCheckBox12_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox12.Checked;
			if (@checked)
			{
				this.label30.Text = "ON";
				this.label30.ForeColor = Color.SpringGreen;
				this.NeverCrushed.ScanCheat(this.kogProc);
				bool found = this.NeverCrushed.Found;
				if (found)
				{
					this.NeverCrushed.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox12.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label30.Text = "OFF";
				this.label30.ForeColor = Color.LightCoral;
				bool found2 = this.NeverCrushed.Found;
				if (found2)
				{
					this.NeverCrushed.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000B38C File Offset: 0x0000958C
		private void siticoneCustomCheckBox8_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000B390 File Offset: 0x00009590
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000B3C8 File Offset: 0x000095C8
		private void InitializeComponent()
		{
			this.components = new Container();
			this.label1 = new Label();
			this.timerProcess = new Timer(this.components);
			this.timer1 = new Timer(this.components);
			this.siticonePanel1 = new SiticonePanel();
			this.label9 = new Label();
			this.label8 = new Label();
			this.label2 = new Label();
			this.GiantClass_Check = new SiticoneCustomCheckBox();
			this.label3 = new Label();
			this.Infiniteoxygen_Check = new SiticoneCustomCheckBox();
			this.label5 = new Label();
			this.label4 = new Label();
			this.immortality_Check = new SiticoneCustomCheckBox();
			this.label6 = new Label();
			this.siticoneCustomCheckBox1 = new SiticoneCustomCheckBox();
			this.label7 = new Label();
			this.siticoneCustomCheckBox2 = new SiticoneCustomCheckBox();
			this.label10 = new Label();
			this.label11 = new Label();
			this.siticoneCustomCheckBox3 = new SiticoneCustomCheckBox();
			this.label12 = new Label();
			this.label13 = new Label();
			this.label14 = new Label();
			this.siticoneCustomCheckBox4 = new SiticoneCustomCheckBox();
			this.label15 = new Label();
			this.label16 = new Label();
			this.siticoneCustomCheckBox5 = new SiticoneCustomCheckBox();
			this.label17 = new Label();
			this.label18 = new Label();
			this.siticoneCustomCheckBox6 = new SiticoneCustomCheckBox();
			this.label19 = new Label();
			this.label20 = new Label();
			this.label21 = new Label();
			this.siticoneCustomCheckBox7 = new SiticoneCustomCheckBox();
			this.label24 = new Label();
			this.label25 = new Label();
			this.siticoneCustomCheckBox9 = new SiticoneCustomCheckBox();
			this.label26 = new Label();
			this.label27 = new Label();
			this.siticoneCustomCheckBox10 = new SiticoneCustomCheckBox();
			this.label28 = new Label();
			this.label29 = new Label();
			this.siticoneCustomCheckBox11 = new SiticoneCustomCheckBox();
			this.label30 = new Label();
			this.label31 = new Label();
			this.siticoneCustomCheckBox12 = new SiticoneCustomCheckBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(166, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(106, 21);
			this.label1.TabIndex = 55;
			this.label1.Text = "•PLAYER•";
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += this.timerProcess_Tick;
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 91;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(6, 90);
			this.label9.Name = "label9";
			this.label9.Size = new Size(69, 15);
			this.label9.TabIndex = 100;
			this.label9.Text = "Giant Class";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(6, 64);
			this.label8.Name = "label8";
			this.label8.Size = new Size(85, 15);
			this.label8.TabIndex = 99;
			this.label8.Text = "Infinite oxygen";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label2.ForeColor = Color.LightCoral;
			this.label2.Location = new Point(125, 90);
			this.label2.Name = "label2";
			this.label2.Size = new Size(30, 15);
			this.label2.TabIndex = 98;
			this.label2.Text = "OFF";
			this.GiantClass_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.GiantClass_Check.CheckedState.BorderRadius = 2;
			this.GiantClass_Check.CheckedState.BorderThickness = 0;
			this.GiantClass_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.GiantClass_Check.CheckedState.Parent = this.GiantClass_Check;
			this.GiantClass_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.GiantClass_Check.Location = new Point(99, 87);
			this.GiantClass_Check.Name = "GiantClass_Check";
			this.GiantClass_Check.ShadowDecoration.Parent = this.GiantClass_Check;
			this.GiantClass_Check.Size = new Size(20, 20);
			this.GiantClass_Check.TabIndex = 97;
			this.GiantClass_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.GiantClass_Check.UncheckedState.BorderRadius = 2;
			this.GiantClass_Check.UncheckedState.BorderThickness = 0;
			this.GiantClass_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.GiantClass_Check.UncheckedState.Parent = this.GiantClass_Check;
			this.GiantClass_Check.CheckedChanged += this.GiantClass_Check_CheckedChanged;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label3.ForeColor = Color.LightCoral;
			this.label3.Location = new Point(125, 64);
			this.label3.Name = "label3";
			this.label3.Size = new Size(30, 15);
			this.label3.TabIndex = 96;
			this.label3.Text = "OFF";
			this.Infiniteoxygen_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.Infiniteoxygen_Check.CheckedState.BorderRadius = 2;
			this.Infiniteoxygen_Check.CheckedState.BorderThickness = 0;
			this.Infiniteoxygen_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.Infiniteoxygen_Check.CheckedState.Parent = this.Infiniteoxygen_Check;
			this.Infiniteoxygen_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.Infiniteoxygen_Check.Location = new Point(99, 61);
			this.Infiniteoxygen_Check.Name = "Infiniteoxygen_Check";
			this.Infiniteoxygen_Check.ShadowDecoration.Parent = this.Infiniteoxygen_Check;
			this.Infiniteoxygen_Check.Size = new Size(20, 20);
			this.Infiniteoxygen_Check.TabIndex = 95;
			this.Infiniteoxygen_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.Infiniteoxygen_Check.UncheckedState.BorderRadius = 2;
			this.Infiniteoxygen_Check.UncheckedState.BorderThickness = 0;
			this.Infiniteoxygen_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.Infiniteoxygen_Check.UncheckedState.Parent = this.Infiniteoxygen_Check;
			this.Infiniteoxygen_Check.CheckedChanged += this.Infiniteoxygen_Check_CheckedChanged;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label5.ForeColor = Color.LightCoral;
			this.label5.Location = new Point(125, 38);
			this.label5.Name = "label5";
			this.label5.Size = new Size(30, 15);
			this.label5.TabIndex = 94;
			this.label5.Text = "OFF";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(6, 37);
			this.label4.Name = "label4";
			this.label4.Size = new Size(67, 15);
			this.label4.TabIndex = 93;
			this.label4.Text = "Immortality";
			this.immortality_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.immortality_Check.CheckedState.BorderRadius = 2;
			this.immortality_Check.CheckedState.BorderThickness = 0;
			this.immortality_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.immortality_Check.CheckedState.Parent = this.immortality_Check;
			this.immortality_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.immortality_Check.Location = new Point(99, 35);
			this.immortality_Check.Name = "immortality_Check";
			this.immortality_Check.ShadowDecoration.Parent = this.immortality_Check;
			this.immortality_Check.Size = new Size(20, 20);
			this.immortality_Check.TabIndex = 92;
			this.immortality_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.immortality_Check.UncheckedState.BorderRadius = 2;
			this.immortality_Check.UncheckedState.BorderThickness = 0;
			this.immortality_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.immortality_Check.UncheckedState.Parent = this.immortality_Check;
			this.immortality_Check.CheckedChanged += this.immortality_Check_CheckedChanged;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(6, 115);
			this.label6.Name = "label6";
			this.label6.Size = new Size(49, 15);
			this.label6.TabIndex = 101;
			this.label6.Text = "Ant AFK";
			this.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.Location = new Point(99, 113);
			this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Size = new Size(20, 20);
			this.siticoneCustomCheckBox1.TabIndex = 102;
			this.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckedChanged += this.siticoneCustomCheckBox1_CheckedChanged;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label7.ForeColor = Color.LightCoral;
			this.label7.Location = new Point(125, 115);
			this.label7.Name = "label7";
			this.label7.Size = new Size(30, 15);
			this.label7.TabIndex = 103;
			this.label7.Text = "OFF";
			this.siticoneCustomCheckBox2.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.Location = new Point(99, 139);
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
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label10.ForeColor = Color.LightCoral;
			this.label10.Location = new Point(125, 141);
			this.label10.Name = "label10";
			this.label10.Size = new Size(30, 15);
			this.label10.TabIndex = 105;
			this.label10.Text = "OFF";
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(6, 142);
			this.label11.Name = "label11";
			this.label11.Size = new Size(60, 15);
			this.label11.TabIndex = 106;
			this.label11.Text = "Auto Heal";
			this.siticoneCustomCheckBox3.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox3.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox3.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.Location = new Point(99, 165);
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
			this.siticoneCustomCheckBox3.KeyDown += this.siticoneCustomCheckBox3_KeyDown;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label12.ForeColor = Color.LightCoral;
			this.label12.Location = new Point(125, 168);
			this.label12.Name = "label12";
			this.label12.Size = new Size(30, 15);
			this.label12.TabIndex = 108;
			this.label12.Text = "OFF";
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label13.ForeColor = Color.White;
			this.label13.Location = new Point(6, 168);
			this.label13.Name = "label13";
			this.label13.Size = new Size(47, 15);
			this.label13.TabIndex = 109;
			this.label13.Text = "No Clip";
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label14.ForeColor = Color.White;
			this.label14.Location = new Point(6, 194);
			this.label14.Name = "label14";
			this.label14.Size = new Size(81, 15);
			this.label14.TabIndex = 110;
			this.label14.Text = "Freeze player";
			this.siticoneCustomCheckBox4.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.Location = new Point(99, 191);
			this.siticoneCustomCheckBox4.Name = "siticoneCustomCheckBox4";
			this.siticoneCustomCheckBox4.ShadowDecoration.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.Size = new Size(20, 20);
			this.siticoneCustomCheckBox4.TabIndex = 111;
			this.siticoneCustomCheckBox4.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckedChanged += this.siticoneCustomCheckBox4_CheckedChanged;
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label15.ForeColor = Color.LightCoral;
			this.label15.Location = new Point(125, 194);
			this.label15.Name = "label15";
			this.label15.Size = new Size(30, 15);
			this.label15.TabIndex = 112;
			this.label15.Text = "OFF";
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label16.ForeColor = Color.LightCoral;
			this.label16.Location = new Point(125, 220);
			this.label16.Name = "label16";
			this.label16.Size = new Size(30, 15);
			this.label16.TabIndex = 118;
			this.label16.Text = "OFF";
			this.siticoneCustomCheckBox5.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.Location = new Point(99, 217);
			this.siticoneCustomCheckBox5.Name = "siticoneCustomCheckBox5";
			this.siticoneCustomCheckBox5.ShadowDecoration.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.Size = new Size(20, 20);
			this.siticoneCustomCheckBox5.TabIndex = 117;
			this.siticoneCustomCheckBox5.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.CheckedChanged += this.siticoneCustomCheckBox5_CheckedChanged;
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label17.ForeColor = Color.White;
			this.label17.Location = new Point(6, 220);
			this.label17.Name = "label17";
			this.label17.Size = new Size(75, 15);
			this.label17.TabIndex = 116;
			this.label17.Text = "NoChatLimit";
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label18.ForeColor = Color.LightCoral;
			this.label18.Location = new Point(125, 246);
			this.label18.Name = "label18";
			this.label18.Size = new Size(30, 15);
			this.label18.TabIndex = 121;
			this.label18.Text = "OFF";
			this.siticoneCustomCheckBox6.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox6.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox6.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox6.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox6.CheckedState.Parent = this.siticoneCustomCheckBox6;
			this.siticoneCustomCheckBox6.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox6.Location = new Point(99, 243);
			this.siticoneCustomCheckBox6.Name = "siticoneCustomCheckBox6";
			this.siticoneCustomCheckBox6.ShadowDecoration.Parent = this.siticoneCustomCheckBox6;
			this.siticoneCustomCheckBox6.Size = new Size(20, 20);
			this.siticoneCustomCheckBox6.TabIndex = 120;
			this.siticoneCustomCheckBox6.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox6.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox6.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox6.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox6.UncheckedState.Parent = this.siticoneCustomCheckBox6;
			this.siticoneCustomCheckBox6.CheckedChanged += this.siticoneCustomCheckBox6_CheckedChanged;
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label19.ForeColor = Color.White;
			this.label19.Location = new Point(6, 246);
			this.label19.Name = "label19";
			this.label19.Size = new Size(67, 15);
			this.label19.TabIndex = 119;
			this.label19.Text = "3rd Person";
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label20.ForeColor = Color.LightCoral;
			this.label20.Location = new Point(310, 39);
			this.label20.Name = "label20";
			this.label20.Size = new Size(30, 15);
			this.label20.TabIndex = 124;
			this.label20.Text = "OFF";
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label21.ForeColor = Color.White;
			this.label21.Location = new Point(167, 38);
			this.label21.Name = "label21";
			this.label21.Size = new Size(100, 15);
			this.label21.TabIndex = 123;
			this.label21.Text = "Healing Particles";
			this.siticoneCustomCheckBox7.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox7.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox7.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox7.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox7.CheckedState.Parent = this.siticoneCustomCheckBox7;
			this.siticoneCustomCheckBox7.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox7.Location = new Point(284, 36);
			this.siticoneCustomCheckBox7.Name = "siticoneCustomCheckBox7";
			this.siticoneCustomCheckBox7.ShadowDecoration.Parent = this.siticoneCustomCheckBox7;
			this.siticoneCustomCheckBox7.Size = new Size(20, 20);
			this.siticoneCustomCheckBox7.TabIndex = 122;
			this.siticoneCustomCheckBox7.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox7.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox7.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox7.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox7.UncheckedState.Parent = this.siticoneCustomCheckBox7;
			this.siticoneCustomCheckBox7.CheckedChanged += this.siticoneCustomCheckBox7_CheckedChanged;
			this.label24.AutoSize = true;
			this.label24.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label24.ForeColor = Color.LightCoral;
			this.label24.Location = new Point(310, 65);
			this.label24.Name = "label24";
			this.label24.Size = new Size(30, 15);
			this.label24.TabIndex = 130;
			this.label24.Text = "OFF";
			this.label25.AutoSize = true;
			this.label25.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label25.ForeColor = Color.White;
			this.label25.Location = new Point(167, 64);
			this.label25.Name = "label25";
			this.label25.Size = new Size(95, 15);
			this.label25.TabIndex = 129;
			this.label25.Text = "Without Blinking";
			this.siticoneCustomCheckBox9.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox9.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox9.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox9.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox9.CheckedState.Parent = this.siticoneCustomCheckBox9;
			this.siticoneCustomCheckBox9.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox9.Location = new Point(284, 62);
			this.siticoneCustomCheckBox9.Name = "siticoneCustomCheckBox9";
			this.siticoneCustomCheckBox9.ShadowDecoration.Parent = this.siticoneCustomCheckBox9;
			this.siticoneCustomCheckBox9.Size = new Size(20, 20);
			this.siticoneCustomCheckBox9.TabIndex = 128;
			this.siticoneCustomCheckBox9.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox9.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox9.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox9.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox9.UncheckedState.Parent = this.siticoneCustomCheckBox9;
			this.siticoneCustomCheckBox9.CheckedChanged += this.siticoneCustomCheckBox9_CheckedChanged;
			this.label26.AutoSize = true;
			this.label26.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label26.ForeColor = Color.LightCoral;
			this.label26.Location = new Point(310, 91);
			this.label26.Name = "label26";
			this.label26.Size = new Size(30, 15);
			this.label26.TabIndex = 133;
			this.label26.Text = "OFF";
			this.label27.AutoSize = true;
			this.label27.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label27.ForeColor = Color.White;
			this.label27.Location = new Point(167, 90);
			this.label27.Name = "label27";
			this.label27.Size = new Size(70, 15);
			this.label27.TabIndex = 132;
			this.label27.Text = "No Impulse";
			this.siticoneCustomCheckBox10.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox10.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox10.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox10.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox10.CheckedState.Parent = this.siticoneCustomCheckBox10;
			this.siticoneCustomCheckBox10.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox10.Location = new Point(284, 88);
			this.siticoneCustomCheckBox10.Name = "siticoneCustomCheckBox10";
			this.siticoneCustomCheckBox10.ShadowDecoration.Parent = this.siticoneCustomCheckBox10;
			this.siticoneCustomCheckBox10.Size = new Size(20, 20);
			this.siticoneCustomCheckBox10.TabIndex = 131;
			this.siticoneCustomCheckBox10.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox10.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox10.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox10.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox10.UncheckedState.Parent = this.siticoneCustomCheckBox10;
			this.siticoneCustomCheckBox10.CheckedChanged += this.siticoneCustomCheckBox10_CheckedChanged;
			this.label28.AutoSize = true;
			this.label28.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label28.ForeColor = Color.LightCoral;
			this.label28.Location = new Point(310, 117);
			this.label28.Name = "label28";
			this.label28.Size = new Size(30, 15);
			this.label28.TabIndex = 136;
			this.label28.Text = "OFF";
			this.label29.AutoSize = true;
			this.label29.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label29.ForeColor = Color.White;
			this.label29.Location = new Point(167, 116);
			this.label29.Name = "label29";
			this.label29.Size = new Size(51, 15);
			this.label29.TabIndex = 135;
			this.label29.Text = "Invisible";
			this.siticoneCustomCheckBox11.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox11.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox11.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox11.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox11.CheckedState.Parent = this.siticoneCustomCheckBox11;
			this.siticoneCustomCheckBox11.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox11.Location = new Point(284, 114);
			this.siticoneCustomCheckBox11.Name = "siticoneCustomCheckBox11";
			this.siticoneCustomCheckBox11.ShadowDecoration.Parent = this.siticoneCustomCheckBox11;
			this.siticoneCustomCheckBox11.Size = new Size(20, 20);
			this.siticoneCustomCheckBox11.TabIndex = 134;
			this.siticoneCustomCheckBox11.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox11.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox11.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox11.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox11.UncheckedState.Parent = this.siticoneCustomCheckBox11;
			this.siticoneCustomCheckBox11.CheckedChanged += this.siticoneCustomCheckBox11_CheckedChanged;
			this.label30.AutoSize = true;
			this.label30.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label30.ForeColor = Color.LightCoral;
			this.label30.Location = new Point(310, 143);
			this.label30.Name = "label30";
			this.label30.Size = new Size(30, 15);
			this.label30.TabIndex = 139;
			this.label30.Text = "OFF";
			this.label31.AutoSize = true;
			this.label31.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label31.ForeColor = Color.White;
			this.label31.Location = new Point(167, 142);
			this.label31.Name = "label31";
			this.label31.Size = new Size(88, 15);
			this.label31.TabIndex = 138;
			this.label31.Text = "Never Crushed";
			this.siticoneCustomCheckBox12.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox12.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox12.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox12.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox12.CheckedState.Parent = this.siticoneCustomCheckBox12;
			this.siticoneCustomCheckBox12.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox12.Location = new Point(284, 140);
			this.siticoneCustomCheckBox12.Name = "siticoneCustomCheckBox12";
			this.siticoneCustomCheckBox12.ShadowDecoration.Parent = this.siticoneCustomCheckBox12;
			this.siticoneCustomCheckBox12.Size = new Size(20, 20);
			this.siticoneCustomCheckBox12.TabIndex = 137;
			this.siticoneCustomCheckBox12.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox12.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox12.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox12.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox12.UncheckedState.Parent = this.siticoneCustomCheckBox12;
			this.siticoneCustomCheckBox12.CheckedChanged += this.siticoneCustomCheckBox12_CheckedChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(36, 38, 42);
			base.Controls.Add(this.label30);
			base.Controls.Add(this.label31);
			base.Controls.Add(this.siticoneCustomCheckBox12);
			base.Controls.Add(this.label28);
			base.Controls.Add(this.label29);
			base.Controls.Add(this.siticoneCustomCheckBox11);
			base.Controls.Add(this.label26);
			base.Controls.Add(this.label27);
			base.Controls.Add(this.siticoneCustomCheckBox10);
			base.Controls.Add(this.label24);
			base.Controls.Add(this.label25);
			base.Controls.Add(this.siticoneCustomCheckBox9);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.label21);
			base.Controls.Add(this.siticoneCustomCheckBox7);
			base.Controls.Add(this.label18);
			base.Controls.Add(this.siticoneCustomCheckBox6);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.siticoneCustomCheckBox5);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.siticoneCustomCheckBox4);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.siticoneCustomCheckBox3);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.siticoneCustomCheckBox2);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.siticoneCustomCheckBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.GiantClass_Check);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Infiniteoxygen_Check);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.immortality_Check);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.label1);
			base.Name = "az_PLAYER";
			base.Size = new Size(439, 267);
			base.Load += this.az_PLAYER_Load;
			base.KeyDown += this.az_PLAYER_KeyDown;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400009C RID: 156
		private int ProcessID = 0;

		// Token: 0x0400009D RID: 157
		private Process kogProc;

		// Token: 0x0400009E RID: 158
		private Cheat immortality = new Cheat();

		// Token: 0x0400009F RID: 159
		private Cheat InfiniteOxygen = new Cheat();

		// Token: 0x040000A0 RID: 160
		private Cheat GiantClass = new Cheat();

		// Token: 0x040000A1 RID: 161
		private Cheat CheatAntAFK = new Cheat();

		// Token: 0x040000A2 RID: 162
		private Cheat AutoHeal = new Cheat();

		// Token: 0x040000A3 RID: 163
		private Cheat NoClip = new Cheat();

		// Token: 0x040000A4 RID: 164
		private Cheat NoClip2 = new Cheat();

		// Token: 0x040000A5 RID: 165
		private Cheat freeze = new Cheat();

		// Token: 0x040000A6 RID: 166
		private Cheat NoChatLimit = new Cheat();

		// Token: 0x040000A7 RID: 167
		private Cheat Person3RD = new Cheat();

		// Token: 0x040000A8 RID: 168
		private Cheat InfMutant = new Cheat();

		// Token: 0x040000A9 RID: 169
		private Cheat WithoutBlinking = new Cheat();

		// Token: 0x040000AA RID: 170
		private Cheat NoImpulse = new Cheat();

		// Token: 0x040000AB RID: 171
		private Cheat Invisible = new Cheat();

		// Token: 0x040000AC RID: 172
		private Cheat HealingParticles = new Cheat();

		// Token: 0x040000AD RID: 173
		private Cheat NeverCrushed = new Cheat();

		// Token: 0x040000AE RID: 174
		private IContainer components = null;

		// Token: 0x040000AF RID: 175
		private Label label1;

		// Token: 0x040000B0 RID: 176
		private Timer timerProcess;

		// Token: 0x040000B1 RID: 177
		private Timer timer1;

		// Token: 0x040000B2 RID: 178
		private SiticonePanel siticonePanel1;

		// Token: 0x040000B3 RID: 179
		private Label label9;

		// Token: 0x040000B4 RID: 180
		private Label label8;

		// Token: 0x040000B5 RID: 181
		private Label label2;

		// Token: 0x040000B6 RID: 182
		private SiticoneCustomCheckBox GiantClass_Check;

		// Token: 0x040000B7 RID: 183
		private Label label3;

		// Token: 0x040000B8 RID: 184
		private SiticoneCustomCheckBox Infiniteoxygen_Check;

		// Token: 0x040000B9 RID: 185
		private Label label5;

		// Token: 0x040000BA RID: 186
		private Label label4;

		// Token: 0x040000BB RID: 187
		private SiticoneCustomCheckBox immortality_Check;

		// Token: 0x040000BC RID: 188
		private Label label6;

		// Token: 0x040000BD RID: 189
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x040000BE RID: 190
		private Label label7;

		// Token: 0x040000BF RID: 191
		private SiticoneCustomCheckBox siticoneCustomCheckBox2;

		// Token: 0x040000C0 RID: 192
		private Label label10;

		// Token: 0x040000C1 RID: 193
		private Label label11;

		// Token: 0x040000C2 RID: 194
		private SiticoneCustomCheckBox siticoneCustomCheckBox3;

		// Token: 0x040000C3 RID: 195
		private Label label12;

		// Token: 0x040000C4 RID: 196
		private Label label13;

		// Token: 0x040000C5 RID: 197
		private Label label14;

		// Token: 0x040000C6 RID: 198
		private SiticoneCustomCheckBox siticoneCustomCheckBox4;

		// Token: 0x040000C7 RID: 199
		private Label label15;

		// Token: 0x040000C8 RID: 200
		private Label label16;

		// Token: 0x040000C9 RID: 201
		private SiticoneCustomCheckBox siticoneCustomCheckBox5;

		// Token: 0x040000CA RID: 202
		private Label label17;

		// Token: 0x040000CB RID: 203
		private Label label18;

		// Token: 0x040000CC RID: 204
		private SiticoneCustomCheckBox siticoneCustomCheckBox6;

		// Token: 0x040000CD RID: 205
		private Label label19;

		// Token: 0x040000CE RID: 206
		private Label label20;

		// Token: 0x040000CF RID: 207
		private Label label21;

		// Token: 0x040000D0 RID: 208
		private SiticoneCustomCheckBox siticoneCustomCheckBox7;

		// Token: 0x040000D1 RID: 209
		private Label label24;

		// Token: 0x040000D2 RID: 210
		private Label label25;

		// Token: 0x040000D3 RID: 211
		private SiticoneCustomCheckBox siticoneCustomCheckBox9;

		// Token: 0x040000D4 RID: 212
		private Label label26;

		// Token: 0x040000D5 RID: 213
		private Label label27;

		// Token: 0x040000D6 RID: 214
		private SiticoneCustomCheckBox siticoneCustomCheckBox10;

		// Token: 0x040000D7 RID: 215
		private Label label28;

		// Token: 0x040000D8 RID: 216
		private Label label29;

		// Token: 0x040000D9 RID: 217
		private SiticoneCustomCheckBox siticoneCustomCheckBox11;

		// Token: 0x040000DA RID: 218
		private Label label30;

		// Token: 0x040000DB RID: 219
		private Label label31;

		// Token: 0x040000DC RID: 220
		private SiticoneCustomCheckBox siticoneCustomCheckBox12;
	}
}
