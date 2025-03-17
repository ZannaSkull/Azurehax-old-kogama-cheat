using System;
using System.Diagnostics;
using System.Windows.Forms;

// Token: 0x02000003 RID: 3
public class Cheat
{
	// Token: 0x06000010 RID: 16 RVA: 0x000029F4 File Offset: 0x00000BF4
	public void ScanCheat(Process Proc)
	{
		try
		{
			AobScan aobScan = new AobScan();
			bool flag = this.FastScan && this.AddressAlign != -1;
			if (flag)
			{
				aobScan.FastScan = true;
				aobScan.AddAlign = this.AddressAlign % 8;
			}
			this.Addresses = aobScan.ScanArray(Proc, this.ScanCode);
			bool flag2 = this.Addresses != null;
			if (flag2)
			{
				bool flag3 = this.Addresses.Length != 0;
				if (flag3)
				{
					bool flag4 = this.Addresses[0] == IntPtr.Zero;
					if (flag4)
					{
						Array.Clear(this.Addresses, 0, this.Addresses.Length);
						this.Found = false;
					}
					else
					{
						this.Found = true;
					}
				}
				else
				{
					Array.Clear(this.Addresses, 0, this.Addresses.Length);
					this.Found = false;
				}
			}
			else
			{
				this.Found = false;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002B00 File Offset: 0x00000D00
	public void ActivateCheat(Process Proc)
	{
		try
		{
			AobScan aobScan = new AobScan();
			foreach (IntPtr address in this.Addresses)
			{
				aobScan.WriteArray(Proc, address, this.ChangeToCode);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002B68 File Offset: 0x00000D68
	public void DeactivateCheat(Process Proc)
	{
		try
		{
			foreach (IntPtr address in this.Addresses)
			{
				AobScan aobScan = new AobScan();
				bool flag = this.DisabledCode == "";
				if (flag)
				{
					this.DisabledCode = this.ScanCode;
				}
				aobScan.WriteArray(Proc, address, this.DisabledCode);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	// Token: 0x0400000E RID: 14
	public string Name = "";

	// Token: 0x0400000F RID: 15
	public string ScanCode = "";

	// Token: 0x04000010 RID: 16
	public string ChangeToCode = "";

	// Token: 0x04000011 RID: 17
	public string DisabledCode = "";

	// Token: 0x04000012 RID: 18
	public IntPtr[] Addresses = new IntPtr[]
	{
		IntPtr.Zero
	};

	// Token: 0x04000013 RID: 19
	public bool Found = false;

	// Token: 0x04000014 RID: 20
	public bool FastScan = true;

	// Token: 0x04000015 RID: 21
	public int AddressAlign = -1;
}
