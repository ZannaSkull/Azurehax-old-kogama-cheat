using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace AzureHAXX
{
	// Token: 0x0200000D RID: 13
	public partial class Loader : Form
	{
		// Token: 0x06000093 RID: 147
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRect(int leftRect, int topRect, int rightRect, int bottomRect, int widthEllipse, int heightEllipse);

		// Token: 0x06000094 RID: 148 RVA: 0x0001530C File Offset: 0x0001350C
		public Loader()
		{
			this.InitializeComponent();
			base.Region = Region.FromHrgn(Loader.CreateRoundRect(0, 0, base.Width, base.Height, 7, 7));
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0001535E File Offset: 0x0001355E
		private void siticonePanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00015364 File Offset: 0x00013564
		private void Loader_Load(object sender, EventArgs e)
		{
			this.text = this.label1.Text;
			this.len = this.text.Length;
			this.label1.Text = "";
			this.timer1.Start();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000153B4 File Offset: 0x000135B4
		private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
		{
			this.siticoneButton10.Enabled = true;
			bool flag = this.siticoneTextBox1.Text == "vK2H1UkTzSYDmJQ1p2a644";
			if (flag)
			{
				this.siticoneButton10.Enabled = true;
			}
			else
			{
				bool flag2 = this.siticoneTextBox1.Text == "";
				if (flag2)
				{
					this.siticoneButton10.Enabled = false;
				}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00015424 File Offset: 0x00013624
		private void siticoneButton10_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			base.Hide();
			form.Show();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00015446 File Offset: 0x00013646
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00015449 File Offset: 0x00013649
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0001544C File Offset: 0x0001364C
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			this.label1.Text = this.text.Substring(0, this.counter);
			this.counter++;
			bool flag = this.counter > this.len;
			if (flag)
			{
				this.timer1.Stop();
			}
		}

		// Token: 0x04000162 RID: 354
		private int counter = 0;

		// Token: 0x04000163 RID: 355
		private int len = 0;

		// Token: 0x04000164 RID: 356
		private string text;
	}
}
