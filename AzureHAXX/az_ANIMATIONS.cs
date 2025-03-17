using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x02000004 RID: 4
	public class az_ANIMATIONS : UserControl
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002C60 File Offset: 0x00000E60
		public az_ANIMATIONS()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002D1C File Offset: 0x00000F1C
		private void LoadAllCheats()
		{
			this.Default.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Default.ChangeToCode = "08 89 45 E8 8D 45 EC 83 EC 0C 8B 4D E0 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Default.AddressAlign = 323082161;
			this.Animation1.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation1.ChangeToCode = "08 89 45 E8 8D 45 EC 83 EC 0C 8B 4D E0 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E7 89 4C 24 08 50 E8";
			this.Animation1.AddressAlign = 323082161;
			this.Animation2.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation2.ChangeToCode = "08 89 45 E7 8D 45 EC 83 EC 0C 8B 4D E0 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Animation2.AddressAlign = 323082161;
			this.Animation3.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation3.ChangeToCode = "08 89 45 E8 8D 45 EC 83 EC 2C 8B 4D E0 89 0C 24 8B 4D E7 89 4C 24 04 8B 4D E8 89 4C 23 08 50 E8";
			this.Animation3.AddressAlign = 323082161;
			this.Animation4.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation4.ChangeToCode = "08 89 45 E8 8D 45 EC 83 EC 0C 8B 4D E3 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Animation4.AddressAlign = 323082161;
			this.Animation5.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation5.ChangeToCode = "08 89 45 E8 8D 45 EC 83 EC 0C 8B 4D E7 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Animation5.AddressAlign = 323082161;
			this.Animation6.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation6.ChangeToCode = "08 89 45 E7 8D 45 EC 83 EC 0C 8B 4D E7 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Animation6.AddressAlign = 323082161;
			this.Animation7.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation7.ChangeToCode = "08 89 45 E6 8D 45 EC 83 EC 0C 8B 4D E7 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Animation7.AddressAlign = 323082161;
			this.Animation8.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation8.ChangeToCode = "08 89 45 E6 8D 45 EC 83 EC 0C 8B 4D E6 89 0C 24 8B 4D E4 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Animation8.AddressAlign = 323082161;
			this.Animation9.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation9.ChangeToCode = "08 89 45 E8 8D 45 EC 83 EC 2C 8B 4D E0 89 0C 24 8B 4D E7 89 4C 24 04 8B 4D E8 89 4C 24 08 50 E8";
			this.Animation9.AddressAlign = 323082161;
			this.Animation10.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation10.ChangeToCode = "08 89 45 E4 8D 45 EC 83 EC 0C 8B 4D E2 89 0C 24 8B 4D E6 89 4C 24 04 8B 4D E7 89 4C 24 08 50 E8";
			this.Animation10.AddressAlign = 323082161;
			this.Animation11.ScanCode = "08 89 45 ?? 8D 45 EC 83 EC ?? 8B 4D ?? 89 0C 24 8B 4D ?? 89 4C 24 04 8B 4D ?? 89 4C ?? 08 50 E8";
			this.Animation11.ChangeToCode = "08 89 45 E9 8D 45 EC 83 EC 0C 8B 4D E2 89 0C 24 8B 4D E9 89 4C 24 04 8B 4D E7 89 4C 24 08 50 E8";
			this.Animation11.AddressAlign = 323082161;
			this.fr.ScanCode = "47 08 8B 80 50 01 00 00 83 EC 0C";
			this.fr.ChangeToCode = "89 03";
			this.fr.AddressAlign = 532589444;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002F9A File Offset: 0x0000119A
		private void az_ANIMATIONS_Load(object sender, EventArgs e)
		{
			this.LoadAllCheats();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002FA4 File Offset: 0x000011A4
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

		// Token: 0x06000018 RID: 24 RVA: 0x0000302C File Offset: 0x0000122C
		private void Animation_Box_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.Animation_Box.SelectedIndex)
			{
			case 0:
			{
				bool flag = this.Animation_Box.SelectedIndex == 0;
				if (flag)
				{
					this.Default.ScanCheat(this.kogProc);
					bool found = this.Default.Found;
					if (found)
					{
						this.Default.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found2 = this.Default.Found;
					if (found2)
					{
						this.Default.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 1:
			{
				bool flag2 = this.Animation_Box.SelectedIndex == 1;
				if (flag2)
				{
					this.Animation1.ScanCheat(this.kogProc);
					bool found3 = this.Animation1.Found;
					if (found3)
					{
						this.Animation1.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found4 = this.Animation1.Found;
					if (found4)
					{
						this.Animation1.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 2:
			{
				bool flag3 = this.Animation_Box.SelectedIndex == 2;
				if (flag3)
				{
					this.Animation2.ScanCheat(this.kogProc);
					bool found5 = this.Animation2.Found;
					if (found5)
					{
						this.Animation2.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found6 = this.Animation2.Found;
					if (found6)
					{
						this.Animation2.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 3:
			{
				bool flag4 = this.Animation_Box.SelectedIndex == 3;
				if (flag4)
				{
					this.Animation3.ScanCheat(this.kogProc);
					bool found7 = this.Animation3.Found;
					if (found7)
					{
						this.Animation3.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found8 = this.Animation3.Found;
					if (found8)
					{
						this.Animation3.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 4:
			{
				bool flag5 = this.Animation_Box.SelectedIndex == 4;
				if (flag5)
				{
					this.Animation4.ScanCheat(this.kogProc);
					bool found9 = this.Animation4.Found;
					if (found9)
					{
						this.Animation4.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found10 = this.Animation4.Found;
					if (found10)
					{
						this.Animation4.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 5:
			{
				bool flag6 = this.Animation_Box.SelectedIndex == 5;
				if (flag6)
				{
					this.Animation5.ScanCheat(this.kogProc);
					bool found11 = this.Animation5.Found;
					if (found11)
					{
						this.Animation5.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found12 = this.Animation5.Found;
					if (found12)
					{
						this.Animation5.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 6:
			{
				bool flag7 = this.Animation_Box.SelectedIndex == 6;
				if (flag7)
				{
					this.Animation6.ScanCheat(this.kogProc);
					bool found13 = this.Animation6.Found;
					if (found13)
					{
						this.Animation6.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found14 = this.Animation6.Found;
					if (found14)
					{
						this.Animation6.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 7:
			{
				bool flag8 = this.Animation_Box.SelectedIndex == 7;
				if (flag8)
				{
					this.Animation7.ScanCheat(this.kogProc);
					bool found15 = this.Animation7.Found;
					if (found15)
					{
						this.Animation7.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found16 = this.Animation7.Found;
					if (found16)
					{
						this.Animation7.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 8:
			{
				bool flag9 = this.Animation_Box.SelectedIndex == 8;
				if (flag9)
				{
					this.Animation8.ScanCheat(this.kogProc);
					bool found17 = this.Animation8.Found;
					if (found17)
					{
						this.Animation8.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found18 = this.Animation8.Found;
					if (found18)
					{
						this.Animation8.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 9:
			{
				bool flag10 = this.Animation_Box.SelectedIndex == 9;
				if (flag10)
				{
					this.Animation9.ScanCheat(this.kogProc);
					bool found19 = this.Animation9.Found;
					if (found19)
					{
						this.Animation9.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found20 = this.Animation9.Found;
					if (found20)
					{
						this.Animation9.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 10:
			{
				bool flag11 = this.Animation_Box.SelectedIndex == 10;
				if (flag11)
				{
					this.Animation10.ScanCheat(this.kogProc);
					bool found21 = this.Animation10.Found;
					if (found21)
					{
						this.Animation10.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found22 = this.Animation10.Found;
					if (found22)
					{
						this.Animation10.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			case 11:
			{
				bool flag12 = this.Animation_Box.SelectedIndex == 11;
				if (flag12)
				{
					this.Animation11.ScanCheat(this.kogProc);
					bool found23 = this.Animation11.Found;
					if (found23)
					{
						this.Animation11.ActivateCheat(this.kogProc);
					}
					else
					{
						this.Animation_Box.SelectedIndex = 0;
					}
				}
				else
				{
					bool found24 = this.Animation11.Found;
					if (found24)
					{
						this.Animation11.DeactivateCheat(this.kogProc);
					}
				}
				break;
			}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003710 File Offset: 0x00001910
		private void siticoneCustomCheckBox12_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox12.Checked;
			if (@checked)
			{
				this.label30.Text = "ON";
				this.label30.ForeColor = Color.SpringGreen;
				this.fr.ScanCheat(this.kogProc);
				bool found = this.fr.Found;
				if (found)
				{
					this.fr.ActivateCheat(this.kogProc);
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
				bool found2 = this.fr.Found;
				if (found2)
				{
					this.fr.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000037E0 File Offset: 0x000019E0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003818 File Offset: 0x00001A18
		private void InitializeComponent()
		{
			this.components = new Container();
			this.label1 = new Label();
			this.timerProcess = new Timer(this.components);
			this.timer1 = new Timer(this.components);
			this.siticonePanel1 = new SiticonePanel();
			this.label11 = new Label();
			this.Animation_Box = new SiticoneRoundedComboBox();
			this.label30 = new Label();
			this.label31 = new Label();
			this.siticoneCustomCheckBox12 = new SiticoneCustomCheckBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("MS Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 238);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(142, 7);
			this.label1.Name = "label1";
			this.label1.Size = new Size(154, 21);
			this.label1.TabIndex = 56;
			this.label1.Text = "•ANIMATIONS•";
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += this.timerProcess_Tick;
			this.siticonePanel1.BackColor = Color.FromArgb(243, 109, 109);
			this.siticonePanel1.Location = new Point(8, 31);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new Size(423, 1);
			this.siticonePanel1.TabIndex = 59;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(32, 40);
			this.label11.Name = "label11";
			this.label11.Size = new Size(85, 13);
			this.label11.TabIndex = 66;
			this.label11.Text = "ANIMATION 0-9";
			this.Animation_Box.Animated = true;
			this.Animation_Box.BackColor = Color.Transparent;
			this.Animation_Box.BorderColor = Color.FromArgb(243, 109, 109);
			this.Animation_Box.DrawMode = DrawMode.OwnerDrawFixed;
			this.Animation_Box.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Animation_Box.FillColor = Color.FromArgb(36, 38, 42);
			this.Animation_Box.FocusedColor = Color.FromArgb(243, 109, 109);
			this.Animation_Box.Font = new Font("Segoe UI", 10f);
			this.Animation_Box.ForeColor = Color.White;
			this.Animation_Box.HoveredState.Parent = this.Animation_Box;
			this.Animation_Box.ItemHeight = 30;
			this.Animation_Box.Items.AddRange(new object[]
			{
				"Default",
				"Animation-1",
				"Animation-2",
				"Animation-3",
				"Animation-4",
				"Animation-5",
				"Animation-6",
				"Animation-7",
				"Animation-8",
				"Animation-9",
				"Animation-10",
				"Animation-11"
			});
			this.Animation_Box.ItemsAppearance.Parent = this.Animation_Box;
			this.Animation_Box.Location = new Point(8, 58);
			this.Animation_Box.Name = "Animation_Box";
			this.Animation_Box.ShadowDecoration.Parent = this.Animation_Box;
			this.Animation_Box.Size = new Size(139, 36);
			this.Animation_Box.TabIndex = 65;
			this.label30.AutoSize = true;
			this.label30.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label30.ForeColor = Color.LightCoral;
			this.label30.Location = new Point(148, 107);
			this.label30.Name = "label30";
			this.label30.Size = new Size(30, 15);
			this.label30.TabIndex = 142;
			this.label30.Text = "OFF";
			this.label31.AutoSize = true;
			this.label31.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 238);
			this.label31.ForeColor = Color.White;
			this.label31.Location = new Point(5, 106);
			this.label31.Name = "label31";
			this.label31.Size = new Size(103, 15);
			this.label31.TabIndex = 141;
			this.label31.Text = "Freeze Animation";
			this.siticoneCustomCheckBox12.CheckedState.BorderColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox12.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox12.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox12.CheckedState.FillColor = Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox12.CheckedState.Parent = this.siticoneCustomCheckBox12;
			this.siticoneCustomCheckBox12.CheckMarkColor = Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox12.Location = new Point(122, 104);
			this.siticoneCustomCheckBox12.Name = "siticoneCustomCheckBox12";
			this.siticoneCustomCheckBox12.ShadowDecoration.Parent = this.siticoneCustomCheckBox12;
			this.siticoneCustomCheckBox12.Size = new Size(20, 20);
			this.siticoneCustomCheckBox12.TabIndex = 140;
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
			base.Controls.Add(this.label11);
			base.Controls.Add(this.Animation_Box);
			base.Controls.Add(this.siticonePanel1);
			base.Controls.Add(this.label1);
			base.Name = "az_ANIMATIONS";
			base.Size = new Size(439, 267);
			base.Load += this.az_ANIMATIONS_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000016 RID: 22
		private int ProcessID = 0;

		// Token: 0x04000017 RID: 23
		private Process kogProc;

		// Token: 0x04000018 RID: 24
		private Cheat Default = new Cheat();

		// Token: 0x04000019 RID: 25
		private Cheat Animation1 = new Cheat();

		// Token: 0x0400001A RID: 26
		private Cheat Animation2 = new Cheat();

		// Token: 0x0400001B RID: 27
		private Cheat Animation3 = new Cheat();

		// Token: 0x0400001C RID: 28
		private Cheat Animation4 = new Cheat();

		// Token: 0x0400001D RID: 29
		private Cheat Animation5 = new Cheat();

		// Token: 0x0400001E RID: 30
		private Cheat Animation6 = new Cheat();

		// Token: 0x0400001F RID: 31
		private Cheat Animation7 = new Cheat();

		// Token: 0x04000020 RID: 32
		private Cheat Animation8 = new Cheat();

		// Token: 0x04000021 RID: 33
		private Cheat Animation9 = new Cheat();

		// Token: 0x04000022 RID: 34
		private Cheat Animation10 = new Cheat();

		// Token: 0x04000023 RID: 35
		private Cheat Animation11 = new Cheat();

		// Token: 0x04000024 RID: 36
		private Cheat fr = new Cheat();

		// Token: 0x04000025 RID: 37
		private IContainer components = null;

		// Token: 0x04000026 RID: 38
		private Label label1;

		// Token: 0x04000027 RID: 39
		private Timer timerProcess;

		// Token: 0x04000028 RID: 40
		private Timer timer1;

		// Token: 0x04000029 RID: 41
		private SiticonePanel siticonePanel1;

		// Token: 0x0400002A RID: 42
		private Label label11;

		// Token: 0x0400002B RID: 43
		private SiticoneRoundedComboBox Animation_Box;

		// Token: 0x0400002C RID: 44
		private Label label30;

		// Token: 0x0400002D RID: 45
		private Label label31;

		// Token: 0x0400002E RID: 46
		private SiticoneCustomCheckBox siticoneCustomCheckBox12;
	}
}
