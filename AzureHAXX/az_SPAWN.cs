using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x0200000A RID: 10
	public class az_SPAWN : UserControl
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000E11C File Offset: 0x0000C31C
		public az_SPAWN()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000E290 File Offset: 0x0000C490
		private void LoadAllCheats()
		{
			this.SpawnProtection.ScanCode = "4E E9 9F 00 00 00 8B C0 8B 47 14 8D 8D 78 FF FF FF 83 EC 04 56 50 51 39 00 E8";
			this.SpawnProtection.ChangeToCode = "90 E9 9F 00 00 00 8B C0 8B 47 14 8D 8D 78 FF FF FF 83 EC 04 56 50 51 39 00 E8";
			this.SpawnProtection.AddressAlign = 378751176;
			this.Enable.ScanCode = "6A 07 50 39 00 E8 ?? ?? ?? ?? 83 C4 ?? 8D 65 F8";
			this.Enable.ChangeToCode = "6A 04 50 39 00 E8 ?? ?? ?? ?? 83 C4 ?? 8D 65 F8";
			this.Enable.AddressAlign = 379367013;
			this.Disable.ScanCode = "6A 04 50 39 00 E8 ?? ?? ?? ?? 83 C4 ?? 8D 65 F8";
			this.Disable.ChangeToCode = "6A 07 50 39 00 E8 ?? ?? ?? ?? 83 C4 ?? 8D 65 F8";
			this.Disable.AddressAlign = 379367013;
			this.GrowthGun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.GrowthGun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 3E FF 75 08";
			this.GrowthGun.AddressAlign = 386404006;
			this.MouseGun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.MouseGun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 3C FF 75 08";
			this.MouseGun.AddressAlign = 386404006;
			this.Sworld.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.Sworld.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 08 FF 75 08";
			this.Sworld.AddressAlign = 386404006;
			this.FlameThrower.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.FlameThrower.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 0A FF 75 08";
			this.FlameThrower.AddressAlign = 386404006;
			this.MultiShuriken.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.MultiShuriken.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 2D FF 75 08";
			this.MultiShuriken.AddressAlign = 386404006;
			this.Shuriken.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.Shuriken.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 2E FF 75 08";
			this.Shuriken.AddressAlign = 386404006;
			this.DualRevolver.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.DualRevolver.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 0D FF 75 08";
			this.DualRevolver.AddressAlign = 386404006;
			this.Revolver.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.Revolver.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 0C FF 75 08";
			this.Revolver.AddressAlign = 386404006;
			this.ImpulseGun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.ImpulseGun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 02 FF 75 08";
			this.ImpulseGun.AddressAlign = 386404006;
			this.Machine_Gun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.Machine_Gun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 01 FF 75 08";
			this.Machine_Gun.AddressAlign = 386404006;
			this.Shotgun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.Shotgun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 09 FF 75 08";
			this.Shotgun.AddressAlign = 386404006;
			this.CubeGun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.CubeGun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 0B FF 75 08";
			this.CubeGun.AddressAlign = 386404006;
			this.RailGun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.RailGun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 06 FF 75 08";
			this.RailGun.AddressAlign = 386404006;
			this.Bazooca.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.Bazooca.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 04 FF 75 08";
			this.Bazooca.AddressAlign = 386404006;
			this.HealRay.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.HealRay.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 46 FF 75 08";
			this.HealRay.AddressAlign = 386404006;
			this.None.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.None.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 05 FF 75 08";
			this.None.AddressAlign = 386404006;
			this.SlapGun.ScanCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A ?? FF";
			this.SlapGun.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 41 FF 75 08";
			this.SlapGun.AddressAlign = 386404006;
			this.None1.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.None1.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 41 FF 75 08";
			this.None1.AddressAlign = 152556940;
			this.Mutant.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Mutant.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 41 FF 75 08";
			this.Mutant.AddressAlign = 152556940;
			this.Bubble.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Bubble.ChangeToCode = "6A 11 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Bubble.AddressAlign = 152556940;
			this.Fire.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Fire.ChangeToCode = "6A 01 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Fire.AddressAlign = 152556940;
			this.NinjaRun.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.NinjaRun.ChangeToCode = "6A 0B 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.NinjaRun.AddressAlign = 152556940;
			this.Shrunken.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Shrunken.ChangeToCode = "6A 0C 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Shrunken.AddressAlign = 152556940;
			this.Enlarged.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Enlarged.ChangeToCode = "6A 0F 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Enlarged.AddressAlign = 152556940;
			this.RayHeal.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.RayHeal.ChangeToCode = "6A 12 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07w";
			this.RayHeal.AddressAlign = 152556940;
			this.Frozen.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Frozen.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 41 FF 75 08";
			this.Frozen.AddressAlign = 152556940;
			this.Circle.ScanCode = "6A 09 57 8B 07 90 90 90 FF 50 50 83 C4 10 EB 28 83 EC 08 6A 09 57 8B 07";
			this.Circle.ChangeToCode = "83 EC 08 6A 01 6A 00 6A 00 6A 00 6A 41 FF 75 08";
			this.Circle.AddressAlign = 152556940;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000E840 File Offset: 0x0000CA40
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

		// Token: 0x06000068 RID: 104 RVA: 0x0000E8C5 File Offset: 0x0000CAC5
		private void az_SPAWN_Load(object sender, EventArgs e)
		{
			this.LoadAllCheats();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		private void SpawnShieldCheck_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.SpawnShieldCheck.Checked;
			if (@checked)
			{
				this.siticoneRoundedComboBox1.Enabled = true;
				this.SpawnProtection.ScanCheat(this.kogProc);
				bool found = this.SpawnProtection.Found;
				if (found)
				{
					this.SpawnProtection.ActivateCheat(this.kogProc);
				}
				else
				{
					this.SpawnShieldCheck.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.siticoneRoundedComboBox1.Enabled = false;
				bool found2 = this.SpawnProtection.Found;
				if (found2)
				{
					this.SpawnProtection.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000E978 File Offset: 0x0000CB78
		private void siticoneRoundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.siticoneRoundedComboBox1.SelectedIndex;
			int num = selectedIndex;
			if (num != 0)
			{
				if (num == 1)
				{
					bool flag = this.siticoneRoundedComboBox1.SelectedIndex == 1;
					if (flag)
					{
						this.Enable.ScanCheat(this.kogProc);
						bool found = this.Enable.Found;
						if (found)
						{
							this.Enable.ActivateCheat(this.kogProc);
						}
						else
						{
							this.siticoneRoundedComboBox1.SelectedIndex = 0;
						}
					}
					else
					{
						bool found2 = this.Enable.Found;
						if (found2)
						{
							this.Enable.DeactivateCheat(this.kogProc);
						}
					}
				}
			}
			else
			{
				bool flag2 = this.siticoneRoundedComboBox1.SelectedIndex == 0;
				if (flag2)
				{
					this.Disable.ScanCheat(this.kogProc);
					bool found3 = this.Disable.Found;
					if (found3)
					{
						this.Disable.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox1.SelectedIndex = 0;
					}
				}
				else
				{
					bool found4 = this.Disable.Found;
					if (found4)
					{
						this.Disable.DeactivateCheat(this.kogProc);
					}
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		private void siticoneRoundedComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.siticoneRoundedComboBox2.SelectedIndex)
			{
			case 0:
			{
				bool flag = this.siticoneRoundedComboBox2.SelectedIndex == 0;
				if (flag)
				{
					this.None.ScanCheat(this.kogProc);
					bool found = this.None.Found;
					if (found)
					{
						this.None.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found2 = this.None.Found;
					if (found2)
					{
						this.None.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 1:
			{
				bool flag2 = this.siticoneRoundedComboBox2.SelectedIndex == 1;
				if (flag2)
				{
					this.HealRay.ScanCheat(this.kogProc);
					bool found3 = this.HealRay.Found;
					if (found3)
					{
						this.HealRay.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found4 = this.HealRay.Found;
					if (found4)
					{
						this.HealRay.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 2:
			{
				bool flag3 = this.siticoneRoundedComboBox2.SelectedIndex == 2;
				if (flag3)
				{
					this.MouseGun.ScanCheat(this.kogProc);
					bool found5 = this.MouseGun.Found;
					if (found5)
					{
						this.MouseGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found6 = this.MouseGun.Found;
					if (found6)
					{
						this.MouseGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 3:
			{
				bool flag4 = this.siticoneRoundedComboBox2.SelectedIndex == 3;
				if (flag4)
				{
					this.GrowthGun.ScanCheat(this.kogProc);
					bool found7 = this.GrowthGun.Found;
					if (found7)
					{
						this.GrowthGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found8 = this.GrowthGun.Found;
					if (found8)
					{
						this.GrowthGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 4:
			{
				bool flag5 = this.siticoneRoundedComboBox2.SelectedIndex == 4;
				if (flag5)
				{
					this.Revolver.ScanCheat(this.kogProc);
					bool found9 = this.Revolver.Found;
					if (found9)
					{
						this.Revolver.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found10 = this.Revolver.Found;
					if (found10)
					{
						this.Revolver.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 5:
			{
				bool flag6 = this.siticoneRoundedComboBox2.SelectedIndex == 5;
				if (flag6)
				{
					this.DualRevolver.ScanCheat(this.kogProc);
					bool found11 = this.DualRevolver.Found;
					if (found11)
					{
						this.DualRevolver.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found12 = this.DualRevolver.Found;
					if (found12)
					{
						this.DualRevolver.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 6:
			{
				bool flag7 = this.siticoneRoundedComboBox2.SelectedIndex == 6;
				if (flag7)
				{
					this.Shuriken.ScanCheat(this.kogProc);
					bool found13 = this.Shuriken.Found;
					if (found13)
					{
						this.Shuriken.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found14 = this.Shuriken.Found;
					if (found14)
					{
						this.Shuriken.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 7:
			{
				bool flag8 = this.siticoneRoundedComboBox2.SelectedIndex == 7;
				if (flag8)
				{
					this.MultiShuriken.ScanCheat(this.kogProc);
					bool found15 = this.MultiShuriken.Found;
					if (found15)
					{
						this.MultiShuriken.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found16 = this.MultiShuriken.Found;
					if (found16)
					{
						this.MultiShuriken.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 8:
			{
				bool flag9 = this.siticoneRoundedComboBox2.SelectedIndex == 8;
				if (flag9)
				{
					this.FlameThrower.ScanCheat(this.kogProc);
					bool found17 = this.FlameThrower.Found;
					if (found17)
					{
						this.FlameThrower.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found18 = this.FlameThrower.Found;
					if (found18)
					{
						this.FlameThrower.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 9:
			{
				bool flag10 = this.siticoneRoundedComboBox2.SelectedIndex == 9;
				if (flag10)
				{
					this.Sworld.ScanCheat(this.kogProc);
					bool found19 = this.Sworld.Found;
					if (found19)
					{
						this.Sworld.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found20 = this.Sworld.Found;
					if (found20)
					{
						this.Sworld.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 10:
			{
				bool flag11 = this.siticoneRoundedComboBox2.SelectedIndex == 10;
				if (flag11)
				{
					this.Bazooca.ScanCheat(this.kogProc);
					bool found21 = this.Bazooca.Found;
					if (found21)
					{
						this.Bazooca.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found22 = this.Bazooca.Found;
					if (found22)
					{
						this.Bazooca.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 11:
			{
				bool flag12 = this.siticoneRoundedComboBox2.SelectedIndex == 11;
				if (flag12)
				{
					this.Machine_Gun.ScanCheat(this.kogProc);
					bool found23 = this.Machine_Gun.Found;
					if (found23)
					{
						this.Machine_Gun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found24 = this.Machine_Gun.Found;
					if (found24)
					{
						this.Machine_Gun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 12:
			{
				bool flag13 = this.siticoneRoundedComboBox2.SelectedIndex == 12;
				if (flag13)
				{
					this.Shotgun.ScanCheat(this.kogProc);
					bool found25 = this.Shotgun.Found;
					if (found25)
					{
						this.Shotgun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found26 = this.Shotgun.Found;
					if (found26)
					{
						this.Shotgun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 13:
			{
				bool flag14 = this.siticoneRoundedComboBox2.SelectedIndex == 13;
				if (flag14)
				{
					this.RailGun.ScanCheat(this.kogProc);
					bool found27 = this.RailGun.Found;
					if (found27)
					{
						this.RailGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found28 = this.RailGun.Found;
					if (found28)
					{
						this.RailGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 14:
			{
				bool flag15 = this.siticoneRoundedComboBox2.SelectedIndex == 14;
				if (flag15)
				{
					this.ImpulseGun.ScanCheat(this.kogProc);
					bool found29 = this.ImpulseGun.Found;
					if (found29)
					{
						this.ImpulseGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found30 = this.ImpulseGun.Found;
					if (found30)
					{
						this.ImpulseGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 15:
			{
				bool flag16 = this.siticoneRoundedComboBox2.SelectedIndex == 15;
				if (flag16)
				{
					this.CubeGun.ScanCheat(this.kogProc);
					bool found31 = this.CubeGun.Found;
					if (found31)
					{
						this.CubeGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found32 = this.CubeGun.Found;
					if (found32)
					{
						this.CubeGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 16:
			{
				bool flag17 = this.siticoneRoundedComboBox2.SelectedIndex == 16;
				if (flag17)
				{
					this.SlapGun.ScanCheat(this.kogProc);
					bool found33 = this.SlapGun.Found;
					if (found33)
					{
						this.SlapGun.ActivateCheat(this.kogProc);
					}
					else
					{
						this.siticoneRoundedComboBox2.SelectedIndex = 0;
					}
				}
				else
				{
					bool found34 = this.SlapGun.Found;
					if (found34)
					{
						this.SlapGun.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000F470 File Offset: 0x0000D670
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		private void InitializeComponent()
		{
			this.components = new Container();
			this.label1 = new Label();
			this.timerProcess = new Timer(this.components);
			this.siticonePanel1 = new SiticonePanel();
			this.SpawnShieldCheck = new SiticoneCustomCheckBox();
			this.siticoneRoundedComboBox1 = new SiticoneRoundedComboBox();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label11 = new Label();
			this.siticoneRoundedComboBox2 = new SiticoneRoundedComboBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(172, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(94, 21);
			this.label1.TabIndex = 57;
			this.label1.Text = "•SPAWN•";
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += this.timerProcess_Tick;
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 58;
			this.SpawnShieldCheck.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.SpawnShieldCheck.CheckedState.BorderRadius = 2;
			this.SpawnShieldCheck.CheckedState.BorderThickness = 0;
			this.SpawnShieldCheck.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.SpawnShieldCheck.CheckedState.Parent = this.SpawnShieldCheck;
			this.SpawnShieldCheck.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.SpawnShieldCheck.Location = new Point(124, 54);
			this.SpawnShieldCheck.Name = "SpawnShieldCheck";
			this.SpawnShieldCheck.ShadowDecoration.Parent = this.SpawnShieldCheck;
			this.SpawnShieldCheck.Size = new Size(20, 20);
			this.SpawnShieldCheck.TabIndex = 62;
			this.SpawnShieldCheck.UncheckedState.BorderColor = Color.FromArgb(243, 109, 109);
			this.SpawnShieldCheck.UncheckedState.BorderRadius = 2;
			this.SpawnShieldCheck.UncheckedState.BorderThickness = 0;
			this.SpawnShieldCheck.UncheckedState.FillColor = Color.FromArgb(243, 109, 109);
			this.SpawnShieldCheck.UncheckedState.Parent = this.SpawnShieldCheck;
			this.SpawnShieldCheck.CheckedChanged += this.SpawnShieldCheck_CheckedChanged;
			this.siticoneRoundedComboBox1.Animated = true;
			this.siticoneRoundedComboBox1.BackColor = Color.Transparent;
			this.siticoneRoundedComboBox1.BorderColor = Color.FromArgb(243, 109, 109);
			this.siticoneRoundedComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
			this.siticoneRoundedComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.siticoneRoundedComboBox1.Enabled = false;
			this.siticoneRoundedComboBox1.FillColor = Color.FromArgb(36, 38, 42);
			this.siticoneRoundedComboBox1.FocusedColor = Color.FromArgb(243, 109, 109);
			this.siticoneRoundedComboBox1.Font = new Font("Segoe UI", 10f);
			this.siticoneRoundedComboBox1.ForeColor = Color.White;
			this.siticoneRoundedComboBox1.HoveredState.Parent = this.siticoneRoundedComboBox1;
			this.siticoneRoundedComboBox1.ItemHeight = 30;
			this.siticoneRoundedComboBox1.Items.AddRange(new object[]
			{
				"Enable",
				"Disable"
			});
			this.siticoneRoundedComboBox1.ItemsAppearance.Parent = this.siticoneRoundedComboBox1;
			this.siticoneRoundedComboBox1.Location = new Point(8, 77);
			this.siticoneRoundedComboBox1.Name = "siticoneRoundedComboBox1";
			this.siticoneRoundedComboBox1.ShadowDecoration.Parent = this.siticoneRoundedComboBox1;
			this.siticoneRoundedComboBox1.Size = new Size(139, 36);
			this.siticoneRoundedComboBox1.TabIndex = 61;
			this.siticoneRoundedComboBox1.SelectedIndexChanged += this.siticoneRoundedComboBox1_SelectedIndexChanged;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label6.ForeColor = Color.FromArgb(243, 109, 109);
			this.label6.Location = new Point(15, 56);
			this.label6.Name = "label6";
			this.label6.Size = new Size(103, 15);
			this.label6.TabIndex = 60;
			this.label6.Text = "Spawn Protection";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(54, 39);
			this.label7.Name = "label7";
			this.label7.Size = new Size(46, 13);
			this.label7.TabIndex = 59;
			this.label7.Text = "SHIELD";
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(30, 121);
			this.label11.Name = "label11";
			this.label11.Size = new Size(98, 13);
			this.label11.TabIndex = 64;
			this.label11.Text = "SPAWN WEAPON";
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
				"None",
				"Heal Gun",
				"Mouse Gun",
				"Growth Gun",
				"Revolver",
				"Dual Revolvers",
				"Shuriken",
				"Multi Shuriken",
				"FlameThrower",
				"Sworld",
				"Bazooca",
				"Machine Gun",
				"Shotgun",
				"Rail Gun",
				"Impulse Gun",
				"Cube Gun",
				"SlapGun"
			});
			this.siticoneRoundedComboBox2.ItemsAppearance.Parent = this.siticoneRoundedComboBox2;
			this.siticoneRoundedComboBox2.Location = new Point(8, 139);
			this.siticoneRoundedComboBox2.Name = "siticoneRoundedComboBox2";
			this.siticoneRoundedComboBox2.ShadowDecoration.Parent = this.siticoneRoundedComboBox2;
			this.siticoneRoundedComboBox2.Size = new Size(139, 36);
			this.siticoneRoundedComboBox2.TabIndex = 63;
			this.siticoneRoundedComboBox2.SelectedIndexChanged += this.siticoneRoundedComboBox2_SelectedIndexChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(36, 38, 42);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.siticoneRoundedComboBox2);
			base.Controls.Add(this.SpawnShieldCheck);
			base.Controls.Add(this.siticoneRoundedComboBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.label1);
			base.Name = "az_SPAWN";
			base.Size = new Size(439, 267);
			base.Load += this.az_SPAWN_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000DD RID: 221
		private int ProcessID = 0;

		// Token: 0x040000DE RID: 222
		private Process kogProc;

		// Token: 0x040000DF RID: 223
		private Cheat SpawnProtection = new Cheat();

		// Token: 0x040000E0 RID: 224
		private Cheat Enable = new Cheat();

		// Token: 0x040000E1 RID: 225
		private Cheat Disable = new Cheat();

		// Token: 0x040000E2 RID: 226
		private Cheat GrowthGun = new Cheat();

		// Token: 0x040000E3 RID: 227
		private Cheat MouseGun = new Cheat();

		// Token: 0x040000E4 RID: 228
		private Cheat Sworld = new Cheat();

		// Token: 0x040000E5 RID: 229
		private Cheat FlameThrower = new Cheat();

		// Token: 0x040000E6 RID: 230
		private Cheat MultiShuriken = new Cheat();

		// Token: 0x040000E7 RID: 231
		private Cheat Shuriken = new Cheat();

		// Token: 0x040000E8 RID: 232
		private Cheat DualRevolver = new Cheat();

		// Token: 0x040000E9 RID: 233
		private Cheat Revolver = new Cheat();

		// Token: 0x040000EA RID: 234
		private Cheat ImpulseGun = new Cheat();

		// Token: 0x040000EB RID: 235
		private Cheat Machine_Gun = new Cheat();

		// Token: 0x040000EC RID: 236
		private Cheat Shotgun = new Cheat();

		// Token: 0x040000ED RID: 237
		private Cheat CubeGun = new Cheat();

		// Token: 0x040000EE RID: 238
		private Cheat RailGun = new Cheat();

		// Token: 0x040000EF RID: 239
		private Cheat Bazooca = new Cheat();

		// Token: 0x040000F0 RID: 240
		private Cheat HealRay = new Cheat();

		// Token: 0x040000F1 RID: 241
		private Cheat None = new Cheat();

		// Token: 0x040000F2 RID: 242
		private Cheat SlapGun = new Cheat();

		// Token: 0x040000F3 RID: 243
		private Cheat None1 = new Cheat();

		// Token: 0x040000F4 RID: 244
		private Cheat Mutant = new Cheat();

		// Token: 0x040000F5 RID: 245
		private Cheat Bubble = new Cheat();

		// Token: 0x040000F6 RID: 246
		private Cheat Fire = new Cheat();

		// Token: 0x040000F7 RID: 247
		private Cheat NinjaRun = new Cheat();

		// Token: 0x040000F8 RID: 248
		private Cheat Shrunken = new Cheat();

		// Token: 0x040000F9 RID: 249
		private Cheat Enlarged = new Cheat();

		// Token: 0x040000FA RID: 250
		private Cheat RayHeal = new Cheat();

		// Token: 0x040000FB RID: 251
		private Cheat Frozen = new Cheat();

		// Token: 0x040000FC RID: 252
		private Cheat Circle = new Cheat();

		// Token: 0x040000FD RID: 253
		private IContainer components = null;

		// Token: 0x040000FE RID: 254
		private Label label1;

		// Token: 0x040000FF RID: 255
		private Timer timerProcess;

		// Token: 0x04000100 RID: 256
		private SiticonePanel siticonePanel1;

		// Token: 0x04000101 RID: 257
		private SiticoneCustomCheckBox SpawnShieldCheck;

		// Token: 0x04000102 RID: 258
		private SiticoneRoundedComboBox siticoneRoundedComboBox1;

		// Token: 0x04000103 RID: 259
		private Label label6;

		// Token: 0x04000104 RID: 260
		private Label label7;

		// Token: 0x04000105 RID: 261
		private Label label11;

		// Token: 0x04000106 RID: 262
		private SiticoneRoundedComboBox siticoneRoundedComboBox2;
	}
}
