using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x02000008 RID: 8
	public class az_OTHERS : UserControl
	{
		// Token: 0x0600003F RID: 63 RVA: 0x0000744C File Offset: 0x0000564C
		public az_OTHERS()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000751C File Offset: 0x0000571C
		private void LoadAllCheats()
		{
			this.ESP.ScanCode = "FF D7 EA FF FF FF FF FF 00 00 80 BF";
			this.ESP.ChangeToCode = "3C 90 FF";
			this.ESP.AddressAlign = 343294492;
			this.DAR.ScanCode = "75 07 B8 02 00 00 00 EB 3B 33 F6 33 DB EB 25 90";
			this.DAR.ChangeToCode = "90 90";
			this.DAR.AddressAlign = 323833400;
			this.InfMutant.ScanCode = "89 57 0C 39 48 0C 0F 86 29 00 00 00 C1 E1 06 03 C1";
			this.InfMutant.ChangeToCode = "90 90 90";
			this.InfMutant.AddressAlign = 49216049;
			this.GiantCamera.ScanCode = "00 00 A0 40 00 00 C0 3F 00 00 A0 C2 00 00 A0 42 00 00 C0 3F 00 00 00 00 CD CC 4C BE 00 00 00 00 00 00 C0 3F 00 00 00 00 00 00 00 40 00 00 00 40 00 00 00 00 00 00 80 3F 00 00 00 00 00 00 00 00 00 00 80";
			this.GiantCamera.ChangeToCode = "00 00 70 42 00 00 C0 3F 00 00 A0 C2 00 00 A0 42 00 00 C0 3F 00 00 00 00 CD CC 4C BE 00 00 00 00";
			this.GiantCamera.AddressAlign = 325555220;
			this.DeleteB.ScanCode = "D8 7A 02 74 28 D9 45 E4 D9 45 0C DF F1 DD D8 72 07 B8 02 00 00 00 EB 17 D9 45 E4 D9 45 0C DF F1";
			this.DeleteB.ChangeToCode = "D8 7A 02 90 90 D9 45 E4 D9 45 0C DF F1 DD D8 72 07 B8 02 00 00 00 EB 17 D9 45 E4 D9 45 0C DF F1";
			this.DeleteB.AddressAlign = 466056096;
			this.DeleteAllOculus.ScanCode = "10 8B 45 0C 89 46 14 8D 65";
			this.DeleteAllOculus.ChangeToCode = "10 90 90 90 89 46 14 8D 65";
			this.DeleteAllOculus.AddressAlign = 442960888;
			this.Elite.ScanCode = "8B 45 08 8B 40 08 83 EC 08 FF 75 0C 50 39 00 E8 16 00 00 00 83 C4 10 C9 C3";
			this.Elite.ChangeToCode = "B8 01 00 00 00 90 90 90 90 90 90 90 90 90 90 90 90 90 90 90 83 C4 10 C9 C3";
			this.Elite.AddressAlign = 436632254;
			this.CR.ScanCode = "0f b6 48 20 88 8d ?? ?? ?? ?? 8b 05 ?? ?? ?? ?? 83 ec 04 51 ff 75 10 50";
			this.CR.ChangeToCode = "C6 40 20 03 90 90 90 90 90 90";
			this.CR.AddressAlign = 432529431;
			this.hcb.ScanCode = "E8 95 00 00 00 83 C4 10 83 EC 0C 57";
			this.hcb.ChangeToCode = "90 90 90 90 90";
			this.hcb.AddressAlign = 449320894;
			this.KickClass.ScanCode = "D9 40 28 D9 40 2C 83 EC 04 83";
			this.KickClass.ChangeToCode = "D8 40 28 D9 40 2C 83 EC 04 83";
			this.KickClass.AddressAlign = 383707004;
			this.ImpluseKick.ScanCode = "00 80 3B 45 00 00 C8 44 00 00";
			this.ImpluseKick.ChangeToCode = "A6 6F A5 6A 00 00 C8 44 00 00";
			this.ImpluseKick.AddressAlign = 68878204;
			this.KickBazzoka.ScanCode = "00 00 7A 44 00 00 F0 41 00 00 16 43 01 10";
			this.KickBazzoka.ChangeToCode = "99 76 96 7E 00 00 F0 41 00 00 16 43 01 10";
			this.KickBazzoka.AddressAlign = 364391016;
			this.KickShotGun.ScanCode = "00 00 48 43 00 00 48 42 00 00 AF 43 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 01";
			this.KickShotGun.ChangeToCode = "99 76 96 7E 00 00 48 42 00 00 AF 43 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 01";
			this.KickShotGun.AddressAlign = 502325188;
			this.KickSlapGun.ScanCode = "00 00 FA 43 45 72 1F 3D 96 96 96 3E 45 72 1F 3D 81 80 00 3F 01";
			this.KickSlapGun.ChangeToCode = "99 76 96 7E 45 72 1F 3D 96 96 96 3E 45 72 1F 3D 81 80 00 3F 01";
			this.KickSlapGun.AddressAlign = 398641212;
			this.KickSword.ScanCode = "00 00 FA 43 00 00 00 00 00 00 ?? ?? 00 00 00 40 01 10 00 00 ?? ?? ?? ?? 00 00 00 00 ?? ?? ?? ?? ?? 00 00 00";
			this.KickSword.ChangeToCode = " 99 76 96 7E 00 00 00 00 00 00 ?? ?? 00 00 00 40 01 10 00 00 ?? ?? ?? ?? 00 00 00 00 ?? ?? ?? ?? ?? 00 00 00";
			this.KickSword.AddressAlign = 398641212;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000077FA File Offset: 0x000059FA
		private void az_OTHERS_Load(object sender, EventArgs e)
		{
			this.LoadAllCheats();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00007804 File Offset: 0x00005A04
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

		// Token: 0x06000043 RID: 67 RVA: 0x0000788C File Offset: 0x00005A8C
		private void Esp_Check_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Esp_Check.Checked;
			if (@checked)
			{
				this.label2.Text = "ON";
				this.label2.ForeColor = Color.SpringGreen;
				this.ESP.ScanCheat(this.kogProc);
				bool found = this.ESP.Found;
				if (found)
				{
					this.ESP.ActivateCheat(this.kogProc);
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
				bool found2 = this.ESP.Found;
				if (found2)
				{
					this.ESP.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000795C File Offset: 0x00005B5C
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox1.Checked;
			if (@checked)
			{
				this.label4.Text = "ON";
				this.label4.ForeColor = Color.SpringGreen;
				this.DAR.ScanCheat(this.kogProc);
				bool found = this.DAR.Found;
				if (found)
				{
					this.DAR.ActivateCheat(this.kogProc);
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
				bool found2 = this.DAR.Found;
				if (found2)
				{
					this.DAR.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007A2C File Offset: 0x00005C2C
		private void siticoneCustomCheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox8.Checked;
			if (@checked)
			{
				this.label22.Text = "ON";
				this.label22.ForeColor = Color.SpringGreen;
				this.InfMutant.ScanCheat(this.kogProc);
				bool found = this.InfMutant.Found;
				if (found)
				{
					this.InfMutant.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox8.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label22.Text = "OFF";
				this.label22.ForeColor = Color.LightCoral;
				bool found2 = this.InfMutant.Found;
				if (found2)
				{
					this.InfMutant.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007AFC File Offset: 0x00005CFC
		private void siticoneRoundedComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.siticoneRoundedComboBox2.SelectedIndex)
			{
			case 0:
			{
				bool flag = this.siticoneRoundedComboBox2.SelectedIndex == 0;
				if (flag)
				{
					this.KickClass.ScanCheat(this.kogProc);
					bool found = this.KickClass.Found;
					if (found)
					{
						this.KickClass.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found2 = this.KickClass.Found;
					if (found2)
					{
						this.KickClass.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 1:
			{
				bool flag2 = this.siticoneRoundedComboBox2.SelectedIndex == 1;
				if (flag2)
				{
					this.ImpluseKick.ScanCheat(this.kogProc);
					bool found3 = this.ImpluseKick.Found;
					if (found3)
					{
						this.ImpluseKick.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found4 = this.ImpluseKick.Found;
					if (found4)
					{
						this.ImpluseKick.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 2:
			{
				bool flag3 = this.siticoneRoundedComboBox2.SelectedIndex == 2;
				if (flag3)
				{
					this.KickBazzoka.ScanCheat(this.kogProc);
					bool found5 = this.KickBazzoka.Found;
					if (found5)
					{
						this.KickBazzoka.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found6 = this.KickBazzoka.Found;
					if (found6)
					{
						this.KickBazzoka.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 3:
			{
				bool flag4 = this.siticoneRoundedComboBox2.SelectedIndex == 3;
				if (flag4)
				{
					this.KickShotGun.ScanCheat(this.kogProc);
					bool found7 = this.KickShotGun.Found;
					if (found7)
					{
						this.KickShotGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found8 = this.KickShotGun.Found;
					if (found8)
					{
						this.KickShotGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 4:
			{
				bool flag5 = this.siticoneRoundedComboBox2.SelectedIndex == 4;
				if (flag5)
				{
					this.KickSlapGun.ScanCheat(this.kogProc);
					bool found9 = this.KickSlapGun.Found;
					if (found9)
					{
						this.KickSlapGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found10 = this.KickSlapGun.Found;
					if (found10)
					{
						this.KickSlapGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007DF0 File Offset: 0x00005FF0
		private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox2.Checked;
			if (@checked)
			{
				this.label6.Text = "ON";
				this.label6.ForeColor = Color.SpringGreen;
				this.GiantCamera.ScanCheat(this.kogProc);
				bool found = this.GiantCamera.Found;
				if (found)
				{
					this.GiantCamera.ActivateCheat(this.kogProc);
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
				bool found2 = this.GiantCamera.Found;
				if (found2)
				{
					this.GiantCamera.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007EC0 File Offset: 0x000060C0
		private void siticoneCustomCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox3.Checked;
			if (@checked)
			{
				this.label8.Text = "ON";
				this.label8.ForeColor = Color.SpringGreen;
				this.DeleteB.ScanCheat(this.kogProc);
				bool found = this.DeleteB.Found;
				if (found)
				{
					this.DeleteB.ActivateCheat(this.kogProc);
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
				bool found2 = this.DeleteB.Found;
				if (found2)
				{
					this.DeleteB.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007F90 File Offset: 0x00006190
		private void siticoneCustomCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox4.Checked;
			if (@checked)
			{
				this.label10.Text = "ON";
				this.label10.ForeColor = Color.SpringGreen;
				this.DeleteAllOculus.ScanCheat(this.kogProc);
				bool found = this.DeleteAllOculus.Found;
				if (found)
				{
					this.DeleteAllOculus.ActivateCheat(this.kogProc);
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
				bool found2 = this.DeleteAllOculus.Found;
				if (found2)
				{
					this.DeleteAllOculus.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00008060 File Offset: 0x00006260
		private void siticoneCustomCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox5.Checked;
			if (@checked)
			{
				this.label13.Text = "ON";
				this.label13.ForeColor = Color.SpringGreen;
				this.Elite.ScanCheat(this.kogProc);
				bool found = this.Elite.Found;
				if (found)
				{
					this.Elite.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox5.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label13.Text = "OFF";
				this.label13.ForeColor = Color.LightCoral;
				bool found2 = this.Elite.Found;
				if (found2)
				{
					this.Elite.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00008130 File Offset: 0x00006330
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008168 File Offset: 0x00006368
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
			this.label22 = new Label();
			this.label23 = new Label();
			this.siticoneCustomCheckBox8 = new SiticoneCustomCheckBox();
			this.label11 = new Label();
			this.siticoneRoundedComboBox2 = new SiticoneRoundedComboBox();
			this.label6 = new Label();
			this.label7 = new Label();
			this.siticoneCustomCheckBox2 = new SiticoneCustomCheckBox();
			this.label8 = new Label();
			this.label9 = new Label();
			this.siticoneCustomCheckBox3 = new SiticoneCustomCheckBox();
			this.label10 = new Label();
			this.label12 = new Label();
			this.siticoneCustomCheckBox4 = new SiticoneCustomCheckBox();
			this.label13 = new Label();
			this.label14 = new Label();
			this.siticoneCustomCheckBox5 = new SiticoneCustomCheckBox();
			this.label15 = new Label();
			this.label16 = new Label();
			this.siticoneCustomCheckBox6 = new SiticoneCustomCheckBox();
			this.siticonePanel2 = new SiticonePanel();
			this.label17 = new Label();
			this.siticonePanel3 = new SiticonePanel();
			this.label18 = new Label();
			this.label19 = new Label();
			this.siticoneCustomCheckBox7 = new SiticoneCustomCheckBox();
			this.siticonePanel2.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(166, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(106, 21);
			this.label1.TabIndex = 59;
			this.label1.Text = "•OTHERS•";
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += this.timerProcess_Tick;
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 92;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label2.ForeColor = Color.LightCoral;
			this.label2.Location = new Point(134, 40);
			this.label2.Name = "label2";
			this.label2.Size = new Size(30, 15);
			this.label2.TabIndex = 97;
			this.label2.Text = "OFF";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(6, 40);
			this.label3.Name = "label3";
			this.label3.Size = new Size(28, 15);
			this.label3.TabIndex = 96;
			this.label3.Text = "Esp";
			this.Esp_Check.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.Esp_Check.CheckedState.BorderRadius = 2;
			this.Esp_Check.CheckedState.BorderThickness = 0;
			this.Esp_Check.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.Esp_Check.CheckedState.Parent = this.Esp_Check;
			this.Esp_Check.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.Esp_Check.Location = new Point(108, 37);
			this.Esp_Check.Name = "Esp_Check";
			this.Esp_Check.ShadowDecoration.Parent = this.Esp_Check;
			this.Esp_Check.Size = new Size(20, 20);
			this.Esp_Check.TabIndex = 95;
			this.Esp_Check.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.Esp_Check.UncheckedState.BorderRadius = 2;
			this.Esp_Check.UncheckedState.BorderThickness = 0;
			this.Esp_Check.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.Esp_Check.UncheckedState.Parent = this.Esp_Check;
			this.Esp_Check.CheckedChanged += this.Esp_Check_CheckedChanged;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label4.ForeColor = Color.LightCoral;
			this.label4.Location = new Point(176, 246);
			this.label4.Name = "label4";
			this.label4.Size = new Size(30, 15);
			this.label4.TabIndex = 100;
			this.label4.Text = "OFF";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(6, 245);
			this.label5.Name = "label5";
			this.label5.Size = new Size(141, 15);
			this.label5.TabIndex = 99;
			this.label5.Text = "Disable all requeriments";
			this.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.Location = new Point(150, 243);
			this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Size = new Size(20, 20);
			this.siticoneCustomCheckBox1.TabIndex = 98;
			this.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckedChanged += this.siticoneCustomCheckBox1_CheckedChanged;
			this.label22.AutoSize = true;
			this.label22.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label22.ForeColor = Color.LightCoral;
			this.label22.Location = new Point(134, 66);
			this.label22.Name = "label22";
			this.label22.Size = new Size(30, 15);
			this.label22.TabIndex = 130;
			this.label22.Text = "OFF";
			this.label23.AutoSize = true;
			this.label23.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label23.ForeColor = Color.White;
			this.label23.Location = new Point(6, 65);
			this.label23.Name = "label23";
			this.label23.Size = new Size(84, 15);
			this.label23.TabIndex = 129;
			this.label23.Text = "Infinite Mutant";
			this.siticoneCustomCheckBox8.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox8.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox8.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox8.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox8.CheckedState.Parent = this.siticoneCustomCheckBox8;
			this.siticoneCustomCheckBox8.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox8.Location = new Point(108, 63);
			this.siticoneCustomCheckBox8.Name = "siticoneCustomCheckBox8";
			this.siticoneCustomCheckBox8.ShadowDecoration.Parent = this.siticoneCustomCheckBox8;
			this.siticoneCustomCheckBox8.Size = new Size(20, 20);
			this.siticoneCustomCheckBox8.TabIndex = 128;
			this.siticoneCustomCheckBox8.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox8.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox8.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox8.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox8.UncheckedState.Parent = this.siticoneCustomCheckBox8;
			this.siticoneCustomCheckBox8.CheckedChanged += this.siticoneCustomCheckBox8_CheckedChanged;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(265, 44);
			this.label11.Name = "label11";
			this.label11.Size = new Size(62, 13);
			this.label11.TabIndex = 132;
			this.label11.Text = "Kick Option";
			this.siticoneRoundedComboBox2.Animated = true;
			this.siticoneRoundedComboBox2.BackColor = Color.Transparent;
			this.siticoneRoundedComboBox2.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneRoundedComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
			this.siticoneRoundedComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.siticoneRoundedComboBox2.FillColor = Color.FromArgb(36, 38, 42);
			this.siticoneRoundedComboBox2.FocusedColor = Color.FromArgb(243, 109, 109);
			this.siticoneRoundedComboBox2.Font = new Font("Segoe UI", 10f);
			this.siticoneRoundedComboBox2.ForeColor = Color.White;
			this.siticoneRoundedComboBox2.HoveredState.Parent = this.siticoneRoundedComboBox2;
			this.siticoneRoundedComboBox2.ItemHeight = 30;
			this.siticoneRoundedComboBox2.Items.AddRange(new object[]
			{
				"Class Kick",
				"Impulse Kick",
				"Bazooka Kick",
				"ShotGun Kick",
				"SlapGun Kick",
				"Sword Kick"
			});
			this.siticoneRoundedComboBox2.ItemsAppearance.Parent = this.siticoneRoundedComboBox2;
			this.siticoneRoundedComboBox2.Location = new Point(228, 62);
			this.siticoneRoundedComboBox2.Name = "siticoneRoundedComboBox2";
			this.siticoneRoundedComboBox2.ShadowDecoration.Parent = this.siticoneRoundedComboBox2;
			this.siticoneRoundedComboBox2.Size = new Size(139, 36);
			this.siticoneRoundedComboBox2.TabIndex = 131;
			this.siticoneRoundedComboBox2.SelectedIndexChanged += this.siticoneRoundedComboBox2_SelectedIndexChanged;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label6.ForeColor = Color.LightCoral;
			this.label6.Location = new Point(134, 92);
			this.label6.Name = "label6";
			this.label6.Size = new Size(30, 15);
			this.label6.TabIndex = 135;
			this.label6.Text = "OFF";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(6, 91);
			this.label7.Name = "label7";
			this.label7.Size = new Size(83, 15);
			this.label7.TabIndex = 134;
			this.label7.Text = "Giant Camera";
			this.siticoneCustomCheckBox2.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox2.CheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.Location = new Point(108, 89);
			this.siticoneCustomCheckBox2.Name = "siticoneCustomCheckBox2";
			this.siticoneCustomCheckBox2.ShadowDecoration.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.Size = new Size(20, 20);
			this.siticoneCustomCheckBox2.TabIndex = 133;
			this.siticoneCustomCheckBox2.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox2.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox2.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox2.UncheckedState.Parent = this.siticoneCustomCheckBox2;
			this.siticoneCustomCheckBox2.CheckedChanged += this.siticoneCustomCheckBox2_CheckedChanged;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label8.ForeColor = Color.LightCoral;
			this.label8.Location = new Point(134, 118);
			this.label8.Name = "label8";
			this.label8.Size = new Size(30, 15);
			this.label8.TabIndex = 138;
			this.label8.Text = "OFF";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(6, 117);
			this.label9.Name = "label9";
			this.label9.Size = new Size(76, 15);
			this.label9.TabIndex = 137;
			this.label9.Text = "Delete Block";
			this.siticoneCustomCheckBox3.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox3.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox3.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox3.CheckedState.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.Location = new Point(108, 115);
			this.siticoneCustomCheckBox3.Name = "siticoneCustomCheckBox3";
			this.siticoneCustomCheckBox3.ShadowDecoration.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.Size = new Size(20, 20);
			this.siticoneCustomCheckBox3.TabIndex = 136;
			this.siticoneCustomCheckBox3.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox3.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox3.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox3.UncheckedState.Parent = this.siticoneCustomCheckBox3;
			this.siticoneCustomCheckBox3.CheckedChanged += this.siticoneCustomCheckBox3_CheckedChanged;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label10.ForeColor = Color.LightCoral;
			this.label10.Location = new Point(134, 144);
			this.label10.Name = "label10";
			this.label10.Size = new Size(30, 15);
			this.label10.TabIndex = 141;
			this.label10.Text = "OFF";
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label12.ForeColor = Color.White;
			this.label12.Location = new Point(6, 143);
			this.label12.Name = "label12";
			this.label12.Size = new Size(98, 15);
			this.label12.TabIndex = 140;
			this.label12.Text = "Delete all oculus";
			this.siticoneCustomCheckBox4.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox4.CheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.Location = new Point(108, 141);
			this.siticoneCustomCheckBox4.Name = "siticoneCustomCheckBox4";
			this.siticoneCustomCheckBox4.ShadowDecoration.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.Size = new Size(20, 20);
			this.siticoneCustomCheckBox4.TabIndex = 139;
			this.siticoneCustomCheckBox4.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox4.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox4.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox4.UncheckedState.Parent = this.siticoneCustomCheckBox4;
			this.siticoneCustomCheckBox4.CheckedChanged += this.siticoneCustomCheckBox4_CheckedChanged;
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label13.ForeColor = Color.LightCoral;
			this.label13.Location = new Point(134, 170);
			this.label13.Name = "label13";
			this.label13.Size = new Size(30, 15);
			this.label13.TabIndex = 144;
			this.label13.Text = "OFF";
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label14.ForeColor = Color.White;
			this.label14.Location = new Point(7, 170);
			this.label14.Name = "label14";
			this.label14.Size = new Size(59, 15);
			this.label14.TabIndex = 143;
			this.label14.Text = "Free Elite";
			this.siticoneCustomCheckBox5.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox5.CheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.Location = new Point(108, 167);
			this.siticoneCustomCheckBox5.Name = "siticoneCustomCheckBox5";
			this.siticoneCustomCheckBox5.ShadowDecoration.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.Size = new Size(20, 20);
			this.siticoneCustomCheckBox5.TabIndex = 142;
			this.siticoneCustomCheckBox5.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox5.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox5.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox5.UncheckedState.Parent = this.siticoneCustomCheckBox5;
			this.siticoneCustomCheckBox5.CheckedChanged += this.siticoneCustomCheckBox5_CheckedChanged;
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label15.ForeColor = Color.LightCoral;
			this.label15.Location = new Point(134, 196);
			this.label15.Name = "label15";
			this.label15.Size = new Size(30, 15);
			this.label15.TabIndex = 147;
			this.label15.Text = "OFF";
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label16.ForeColor = Color.White;
			this.label16.Location = new Point(7, 196);
			this.label16.Name = "label16";
			this.label16.Size = new Size(75, 15);
			this.label16.TabIndex = 146;
			this.label16.Text = "Crystal Rank";
			this.siticoneCustomCheckBox6.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox6.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox6.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox6.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox6.CheckedState.Parent = this.siticoneCustomCheckBox6;
			this.siticoneCustomCheckBox6.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox6.Location = new Point(108, 193);
			this.siticoneCustomCheckBox6.Name = "siticoneCustomCheckBox6";
			this.siticoneCustomCheckBox6.ShadowDecoration.Parent = this.siticoneCustomCheckBox6;
			this.siticoneCustomCheckBox6.Size = new Size(20, 20);
			this.siticoneCustomCheckBox6.TabIndex = 145;
			this.siticoneCustomCheckBox6.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox6.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox6.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox6.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox6.UncheckedState.Parent = this.siticoneCustomCheckBox6;
			this.siticonePanel2.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel2.Controls.Add(this.siticonePanel3);
			this.siticonePanel2.Location = new Point(179, 112);
			this.siticonePanel2.Name = "siticonePanel2";
			this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
			this.siticonePanel2.Size = new Size(252, 1);
			this.siticonePanel2.TabIndex = 93;
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label17.ForeColor = Color.White;
			this.label17.Location = new Point(269, 103);
			this.label17.Name = "label17";
			this.label17.Size = new Size(64, 15);
			this.label17.TabIndex = 148;
			this.label17.Text = "HoverCraft";
			this.siticonePanel3.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel3.Location = new Point(0, 114);
			this.siticonePanel3.Name = "siticonePanel3";
			this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
			this.siticonePanel3.Size = new Size(252, 1);
			this.siticonePanel3.TabIndex = 94;
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label18.ForeColor = Color.LightCoral;
			this.label18.Location = new Point(368, 124);
			this.label18.Name = "label18";
			this.label18.Size = new Size(30, 15);
			this.label18.TabIndex = 151;
			this.label18.Text = "OFF";
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label19.ForeColor = Color.White;
			this.label19.Location = new Point(178, 124);
			this.label19.Name = "label19";
			this.label19.Size = new Size(110, 15);
			this.label19.TabIndex = 150;
			this.label19.Text = "HoverCraft Backflip";
			this.siticoneCustomCheckBox7.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox7.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox7.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox7.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox7.CheckedState.Parent = this.siticoneCustomCheckBox7;
			this.siticoneCustomCheckBox7.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox7.Location = new Point(343, 122);
			this.siticoneCustomCheckBox7.Name = "siticoneCustomCheckBox7";
			this.siticoneCustomCheckBox7.ShadowDecoration.Parent = this.siticoneCustomCheckBox7;
			this.siticoneCustomCheckBox7.Size = new Size(20, 20);
			this.siticoneCustomCheckBox7.TabIndex = 149;
			this.siticoneCustomCheckBox7.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox7.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox7.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox7.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox7.UncheckedState.Parent = this.siticoneCustomCheckBox7;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(36, 38, 42);
			base.Controls.Add(this.label18);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.siticoneCustomCheckBox7);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.siticonePanel2);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.siticoneCustomCheckBox6);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.siticoneCustomCheckBox5);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.siticoneCustomCheckBox4);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.siticoneCustomCheckBox3);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.siticoneCustomCheckBox2);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.siticoneRoundedComboBox2);
			base.Controls.Add(this.label22);
			base.Controls.Add(this.label23);
			base.Controls.Add(this.siticoneCustomCheckBox8);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.siticoneCustomCheckBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Esp_Check);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.label1);
			base.Name = "az_OTHERS";
			base.Size = new Size(439, 267);
			base.Load += this.az_OTHERS_Load;
			this.siticonePanel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000066 RID: 102
		private int ProcessID = 0;

		// Token: 0x04000067 RID: 103
		private Process kogProc;

		// Token: 0x04000068 RID: 104
		private Cheat ESP = new Cheat();

		// Token: 0x04000069 RID: 105
		private Cheat DAR = new Cheat();

		// Token: 0x0400006A RID: 106
		private Cheat InfMutant = new Cheat();

		// Token: 0x0400006B RID: 107
		private Cheat GiantCamera = new Cheat();

		// Token: 0x0400006C RID: 108
		private Cheat DeleteB = new Cheat();

		// Token: 0x0400006D RID: 109
		private Cheat DeleteAllOculus = new Cheat();

		// Token: 0x0400006E RID: 110
		private Cheat Elite = new Cheat();

		// Token: 0x0400006F RID: 111
		private Cheat CR = new Cheat();

		// Token: 0x04000070 RID: 112
		private Cheat hcb = new Cheat();

		// Token: 0x04000071 RID: 113
		private Cheat KickClass = new Cheat();

		// Token: 0x04000072 RID: 114
		private Cheat ImpluseKick = new Cheat();

		// Token: 0x04000073 RID: 115
		private Cheat KickBazzoka = new Cheat();

		// Token: 0x04000074 RID: 116
		private Cheat KickShotGun = new Cheat();

		// Token: 0x04000075 RID: 117
		private Cheat KickSlapGun = new Cheat();

		// Token: 0x04000076 RID: 118
		private Cheat KickSword = new Cheat();

		// Token: 0x04000077 RID: 119
		private IContainer components = null;

		// Token: 0x04000078 RID: 120
		private Label label1;

		// Token: 0x04000079 RID: 121
		private Timer timerProcess;

		// Token: 0x0400007A RID: 122
		private Timer timer1;

		// Token: 0x0400007B RID: 123
		private SiticonePanel siticonePanel1;

		// Token: 0x0400007C RID: 124
		private Label label2;

		// Token: 0x0400007D RID: 125
		private Label label3;

		// Token: 0x0400007E RID: 126
		private SiticoneCustomCheckBox Esp_Check;

		// Token: 0x0400007F RID: 127
		private Label label4;

		// Token: 0x04000080 RID: 128
		private Label label5;

		// Token: 0x04000081 RID: 129
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000082 RID: 130
		private Label label22;

		// Token: 0x04000083 RID: 131
		private Label label23;

		// Token: 0x04000084 RID: 132
		private SiticoneCustomCheckBox siticoneCustomCheckBox8;

		// Token: 0x04000085 RID: 133
		private Label label11;

		// Token: 0x04000086 RID: 134
		private SiticoneRoundedComboBox siticoneRoundedComboBox2;

		// Token: 0x04000087 RID: 135
		private Label label6;

		// Token: 0x04000088 RID: 136
		private Label label7;

		// Token: 0x04000089 RID: 137
		private SiticoneCustomCheckBox siticoneCustomCheckBox2;

		// Token: 0x0400008A RID: 138
		private Label label8;

		// Token: 0x0400008B RID: 139
		private Label label9;

		// Token: 0x0400008C RID: 140
		private SiticoneCustomCheckBox siticoneCustomCheckBox3;

		// Token: 0x0400008D RID: 141
		private Label label10;

		// Token: 0x0400008E RID: 142
		private Label label12;

		// Token: 0x0400008F RID: 143
		private SiticoneCustomCheckBox siticoneCustomCheckBox4;

		// Token: 0x04000090 RID: 144
		private Label label13;

		// Token: 0x04000091 RID: 145
		private Label label14;

		// Token: 0x04000092 RID: 146
		private SiticoneCustomCheckBox siticoneCustomCheckBox5;

		// Token: 0x04000093 RID: 147
		private Label label15;

		// Token: 0x04000094 RID: 148
		private Label label16;

		// Token: 0x04000095 RID: 149
		private SiticoneCustomCheckBox siticoneCustomCheckBox6;

		// Token: 0x04000096 RID: 150
		private SiticonePanel siticonePanel2;

		// Token: 0x04000097 RID: 151
		private SiticonePanel siticonePanel3;

		// Token: 0x04000098 RID: 152
		private Label label17;

		// Token: 0x04000099 RID: 153
		private Label label18;

		// Token: 0x0400009A RID: 154
		private Label label19;

		// Token: 0x0400009B RID: 155
		private SiticoneCustomCheckBox siticoneCustomCheckBox7;
	}
}
