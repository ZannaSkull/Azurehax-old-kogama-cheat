using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x0200000C RID: 12
	public partial class Form1 : Form
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00012DB8 File Offset: 0x00010FB8
		public Form1()
		{
			this.InitializeComponent();
			this.siticoneShadowForm1.SetShadowForm(this);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00012DEF File Offset: 0x00010FEF
		private void LoadAllCheats()
		{
			this.CheatAntBan.ScanCode = "7E ?? ?? ?? ?? 2D ?? ?? ?? ?? ?? ?? ?? ?? 73 ?? ?? ?? ?? 80 ?? ?? ?? ?? 7E ?? ?? ?? ?? 22 ?? ?? ?? ?? ?? 28 ?? ?? ?? ?? 7E ?? ?? ?? ?? 2D ?? 14 FE 06 ?? ?? ?? ?? 73 ?? ?? ?? ?? 80 ?? ?? ?? ?? 7E ?? ?? ?? ?? 28 ?? ?? ?? ?? 2A ?? ?? 28 ?? ?? ?? ?? 2A ?? ?? 28 ?? ?? ?? ?? 2A ?? ?? 28 ?? ?? ?? ?? 2A ?? 16 28 ?? ?? ?? ?? 2A ?? ?? 28 ?? ?? ?? ?? 2A ?? 28 ?? ?? ?? ?? ?? 6F ?? ?? ?? ?? 28 ?? ?? ?? ?? 2A";
			this.CheatAntBan.ChangeToCode = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
			this.CheatAntBan.AddressAlign = 265124940;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00012E24 File Offset: 0x00011024
		private void siticoneButton7_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton7.Checked;
			if (@checked)
			{
				this.az_OTHERS1.BringToFront();
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00012E50 File Offset: 0x00011050
		private void siticoneButton6_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton6.Checked;
			if (@checked)
			{
				this.az_CAR1.BringToFront();
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00012E7C File Offset: 0x0001107C
		private void siticoneButton5_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton5.Checked;
			if (@checked)
			{
				this.az_SPAWN1.BringToFront();
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00012EA8 File Offset: 0x000110A8
		private void siticoneButton5_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton5.Checked;
			if (@checked)
			{
				this.az_ANIMATIONS1.BringToFront();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00012ED4 File Offset: 0x000110D4
		private void siticoneButton7_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton7.Checked;
			if (@checked)
			{
				this.az_CAR1.BringToFront();
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00012F00 File Offset: 0x00011100
		private void siticoneButton6_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton6.Checked;
			if (@checked)
			{
				this.az_SPAWN1.BringToFront();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00012F2C File Offset: 0x0001112C
		private void siticoneButton8_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton8.Checked;
			if (@checked)
			{
				this.az_OTHERS1.BringToFront();
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00012F58 File Offset: 0x00011158
		private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton4.Checked;
			if (@checked)
			{
				this.az_EDITMODE1.BringToFront();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00012F84 File Offset: 0x00011184
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton3.Checked;
			if (@checked)
			{
				this.az_WEAPON1.BringToFront();
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00012FB0 File Offset: 0x000111B0
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton2.Checked;
			if (@checked)
			{
				this.az_PLAYER1.BringToFront();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00012FDC File Offset: 0x000111DC
		private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneButton1.Checked;
			if (@checked)
			{
				this.az_HOME1.BringToFront();
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00013005 File Offset: 0x00011205
		private void Form1_Load(object sender, EventArgs e)
		{
			this.LoadAllCheats();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0001300F File Offset: 0x0001120F
		private void siticonePanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00013014 File Offset: 0x00011214
		private void timerProcess_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("kogama");
			this.label3.Text = "OFFLINE !";
			this.label3.ForeColor = Color.LightCoral;
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
				this.label3.Text = "ONLINE !";
				this.label3.ForeColor = Color.SpringGreen;
				bool flag3 = this.ProcessID != this.kogProc.Id;
				if (flag3)
				{
					this.ProcessID = this.kogProc.Id;
				}
				this.ProcessID = this.kogProc.Id;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000130E0 File Offset: 0x000112E0
		private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.siticoneCustomCheckBox1.Checked;
			if (@checked)
			{
				this.label5.Text = "ON";
				this.label5.ForeColor = Color.SpringGreen;
				this.CheatAntBan.ScanCheat(this.kogProc);
				bool found = this.CheatAntBan.Found;
				if (found)
				{
					this.CheatAntBan.ActivateCheat(this.kogProc);
				}
				else
				{
					this.siticoneCustomCheckBox1.CheckState = CheckState.Unchecked;
				}
			}
			else
			{
				this.label5.Text = "OFF";
				this.label5.ForeColor = Color.LightCoral;
				bool found2 = this.CheatAntBan.Found;
				if (found2)
				{
					this.CheatAntBan.DeactivateCheat(this.kogProc);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000131B0 File Offset: 0x000113B0
		private void siticoneButton7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000131B3 File Offset: 0x000113B3
		private void siticoneButton10_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/DJSJP6decg");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000131C1 File Offset: 0x000113C1
		private void az_HOME1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400013C RID: 316
		private int ProcessID = 0;

		// Token: 0x0400013D RID: 317
		private Process kogProc;

		// Token: 0x0400013E RID: 318
		private Cheat CheatAntBan = new Cheat();
	}
}
