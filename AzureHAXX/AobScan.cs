using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
public class AobScan
{
	// Token: 0x06000001 RID: 1
	[DllImport("kernel32.dll")]
	public static extern uint GetLastError();

	// Token: 0x06000002 RID: 2
	[DllImport("kernel32.dll")]
	protected static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, uint lpNumberOfBytesRead);

	// Token: 0x06000003 RID: 3
	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, uint lpNumberOfBytesWritten);

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32.dll", SetLastError = true)]
	protected static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out AobScan.MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000006 RID: 6 RVA: 0x00002058 File Offset: 0x00000258
	private List<AobScan.MEMORY_BASIC_INFORMATION> MappedMemory { get; set; }

	// Token: 0x06000007 RID: 7 RVA: 0x00002064 File Offset: 0x00000264
	public static string GetSystemMessage(uint errorCode)
	{
		Win32Exception ex = new Win32Exception((int)errorCode);
		return ex.Message;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
	protected void MemInfo(IntPtr pHandle)
	{
		IntPtr intPtr = (IntPtr)((long)this.BeginScan);
		for (;;)
		{
			bool flag = (long)intPtr > (long)this.EndScan;
			if (flag)
			{
				break;
			}
			AobScan.MEMORY_BASIC_INFORMATION memory_BASIC_INFORMATION = default(AobScan.MEMORY_BASIC_INFORMATION);
			int num = AobScan.VirtualQueryEx(pHandle, intPtr, out memory_BASIC_INFORMATION, (uint)Marshal.SizeOf<AobScan.MEMORY_BASIC_INFORMATION>(memory_BASIC_INFORMATION));
			bool flag2 = num == 0;
			if (flag2)
			{
				break;
			}
			bool flag3 = (memory_BASIC_INFORMATION.State & 4096U) != 0U && (memory_BASIC_INFORMATION.Protect & 256U) != 256U;
			if (flag3)
			{
				this.MappedMemory.Add(memory_BASIC_INFORMATION);
			}
			intPtr = (IntPtr)((int)memory_BASIC_INFORMATION.BaseAddress + (int)memory_BASIC_INFORMATION.RegionSize);
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000213C File Offset: 0x0000033C
	protected IntPtr ScanInBuff(IntPtr Address, byte[] Buff)
	{
		long num = (long)Buff.Length;
		int num2 = this.SigScan.Length;
		int num3 = num2 - 1;
		for (long num4 = 0L; num4 <= num - (long)num2 - 1L; num4 += 1L)
		{
			bool flag = Buff[(int)(checked((IntPtr)num4))] == this.SigScan[0];
			if (flag)
			{
				int num5 = num3;
				while (this.SigScanUnknown[num5] || Buff[(int)(checked((IntPtr)(unchecked(num4 + (long)num5))))] == this.SigScan[num5])
				{
					bool flag2 = num5 == 0;
					if (flag2)
					{
						bool stopTheFirst = this.StopTheFirst;
						if (stopTheFirst)
						{
							return new IntPtr(num4);
						}
						bool flag3 = Address.ToInt64() + num4 >= (long)this.BeginScan && Address.ToInt64() + num4 <= (long)this.EndScan;
						if (flag3)
						{
							this.AddressList.Add((IntPtr)(Address.ToInt64() + num4));
						}
						break;
					}
					else
					{
						num5--;
					}
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000224C File Offset: 0x0000044C
	protected IntPtr ScanInBuffFast(IntPtr Address, byte[] Buff)
	{
		long num = (long)Buff.Length;
		int num2 = this.SigScan.Length;
		int num3 = num2 - 1;
		for (long num4 = ((long)(this.AddAlign % 8) - Address.ToInt64() % 8L + 16L) % 8L; num4 <= num - (long)num2 - 1L; num4 += 8L)
		{
			bool flag = Buff[(int)(checked((IntPtr)num4))] == this.SigScan[0];
			if (flag)
			{
				int num5 = num3;
				while (this.SigScanUnknown[num5] || Buff[(int)(checked((IntPtr)(unchecked(num4 + (long)num5))))] == this.SigScan[num5])
				{
					bool flag2 = num5 == 0;
					if (flag2)
					{
						bool stopTheFirst = this.StopTheFirst;
						if (stopTheFirst)
						{
							return new IntPtr(num4);
						}
						bool flag3 = Address.ToInt64() + num4 >= (long)this.BeginScan && Address.ToInt64() + num4 <= (long)this.EndScan;
						if (flag3)
						{
							this.AddressList.Add((IntPtr)(Address.ToInt64() + num4));
						}
						break;
					}
					else
					{
						num5--;
					}
				}
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002374 File Offset: 0x00000574
	public IntPtr[] ScanArray(Process P, string ArrayString_)
	{
		bool flag = P == null;
		IntPtr[] result;
		if (flag)
		{
			result = this.toReturn;
		}
		else
		{
			this.Attacked = Process.GetProcessById(P.Id);
			this.hProcess = this.Attacked.Handle;
			this.ArrayString = ArrayString_;
			bool fastScan = this.FastScan;
			if (fastScan)
			{
				this.StartFastScan();
			}
			else
			{
				this.StartScan();
			}
			result = this.toReturn;
		}
		return result;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000023E8 File Offset: 0x000005E8
	private void StartScan()
	{
		string[] array = this.ArrayString.Split(new char[]
		{
			" "[0]
		});
		for (int i = 0; i < array.Length; i++)
		{
			bool flag = array[i] == "?";
			if (flag)
			{
				array[i] = "??";
			}
		}
		int num = array.Length;
		this.SigScan = new byte[num];
		this.SigScanUnknown = new bool[num];
		for (int j = 0; j < num; j++)
		{
			bool flag2 = array[j] == "??";
			if (flag2)
			{
				this.SigScan[j] = 0;
				this.SigScanUnknown[j] = true;
			}
			else
			{
				this.SigScanUnknown[j] = false;
				this.SigScan[j] = Convert.ToByte(array[j], 16);
			}
		}
		this.MappedMemory = new List<AobScan.MEMORY_BASIC_INFORMATION>();
		this.MemInfo(this.hProcess);
		for (int k = 0; k < this.MappedMemory.Count; k++)
		{
			byte[] array2 = new byte[this.MappedMemory[k].RegionSize];
			AobScan.ReadProcessMemory(this.hProcess, this.MappedMemory[k].BaseAddress, array2, this.MappedMemory[k].RegionSize, 0U);
			IntPtr intPtr = IntPtr.Zero;
			bool flag3 = array2.Length != 0;
			if (flag3)
			{
				intPtr = this.ScanInBuff(this.MappedMemory[k].BaseAddress, array2);
			}
			bool stopTheFirst = this.StopTheFirst;
			if (stopTheFirst)
			{
				bool flag4 = intPtr != IntPtr.Zero;
				if (flag4)
				{
					this.toReturn = new IntPtr[0];
					this.toReturn[0] = (IntPtr)((long)((int)this.MappedMemory[k].BaseAddress) + Convert.ToInt64(intPtr));
					return;
				}
			}
		}
		bool flag5 = !this.StopTheFirst && this.AddressList.Count > 0;
		if (flag5)
		{
			this.toReturn = new IntPtr[this.AddressList.Count];
			for (int l = 0; l < this.AddressList.Count; l++)
			{
				this.toReturn[l] = this.AddressList[l];
			}
			this.AddressList.Clear();
			return;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002668 File Offset: 0x00000868
	private void StartFastScan()
	{
		string[] array = this.ArrayString.Split(new char[]
		{
			" "[0]
		});
		for (int i = 0; i < array.Length; i++)
		{
			bool flag = array[i] == "?";
			if (flag)
			{
				array[i] = "??";
			}
		}
		int num = array.Length;
		this.SigScan = new byte[num];
		this.SigScanUnknown = new bool[num];
		for (int j = 0; j < num; j++)
		{
			bool flag2 = array[j] == "??";
			if (flag2)
			{
				this.SigScan[j] = 0;
				this.SigScanUnknown[j] = true;
			}
			else
			{
				this.SigScanUnknown[j] = false;
				this.SigScan[j] = Convert.ToByte(array[j], 16);
			}
		}
		this.MappedMemory = new List<AobScan.MEMORY_BASIC_INFORMATION>();
		this.MemInfo(this.hProcess);
		for (int k = 0; k < this.MappedMemory.Count; k++)
		{
			byte[] array2 = new byte[this.MappedMemory[k].RegionSize];
			AobScan.ReadProcessMemory(this.hProcess, this.MappedMemory[k].BaseAddress, array2, this.MappedMemory[k].RegionSize, 0U);
			IntPtr intPtr = IntPtr.Zero;
			bool flag3 = array2.Length != 0;
			if (flag3)
			{
				intPtr = this.ScanInBuffFast(this.MappedMemory[k].BaseAddress, array2);
			}
			bool stopTheFirst = this.StopTheFirst;
			if (stopTheFirst)
			{
				bool flag4 = intPtr != IntPtr.Zero;
				if (flag4)
				{
					this.toReturn = new IntPtr[0];
					this.toReturn[0] = (IntPtr)((long)((int)this.MappedMemory[k].BaseAddress) + Convert.ToInt64(intPtr));
					return;
				}
			}
		}
		bool flag5 = !this.StopTheFirst && this.AddressList.Count > 0;
		if (flag5)
		{
			this.toReturn = new IntPtr[this.AddressList.Count];
			for (int l = 0; l < this.AddressList.Count; l++)
			{
				this.toReturn[l] = this.AddressList[l];
			}
			this.AddressList.Clear();
			return;
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000028E8 File Offset: 0x00000AE8
	public bool WriteArray(Process proc, IntPtr address, string ArrayString)
	{
		bool flag = proc == null;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			string[] array = ArrayString.Split(new char[]
			{
				" "[0]
			});
			for (int i = 0; i < array.Length; i++)
			{
				bool flag2 = array[i] == "?" || array[i] == "??";
				if (!flag2)
				{
					byte b = Convert.ToByte(array[i], 16);
					AobScan.WriteProcessMemory(proc.Handle, new IntPtr(address.ToInt32() + i), new byte[]
					{
						b
					}, 1U, 0U);
				}
			}
			result = true;
		}
		return result;
	}

	// Token: 0x04000002 RID: 2
	public ulong BeginScan = 0UL;

	// Token: 0x04000003 RID: 3
	public ulong EndScan = (ulong)-1;

	// Token: 0x04000004 RID: 4
	private bool StopTheFirst = false;

	// Token: 0x04000005 RID: 5
	private Process Attacked;

	// Token: 0x04000006 RID: 6
	private List<IntPtr> AddressList = new List<IntPtr>();

	// Token: 0x04000007 RID: 7
	private byte[] SigScan;

	// Token: 0x04000008 RID: 8
	private bool[] SigScanUnknown;

	// Token: 0x04000009 RID: 9
	public int AddAlign = -1;

	// Token: 0x0400000A RID: 10
	private IntPtr[] toReturn = null;

	// Token: 0x0400000B RID: 11
	private string ArrayString;

	// Token: 0x0400000C RID: 12
	public bool FastScan = false;

	// Token: 0x0400000D RID: 13
	private IntPtr hProcess = IntPtr.Zero;

	// Token: 0x02000011 RID: 17
	protected struct MEMORY_BASIC_INFORMATION
	{
		// Token: 0x04000170 RID: 368
		public IntPtr BaseAddress;

		// Token: 0x04000171 RID: 369
		public IntPtr AllocationBase;

		// Token: 0x04000172 RID: 370
		public uint AllocationProtect;

		// Token: 0x04000173 RID: 371
		public uint RegionSize;

		// Token: 0x04000174 RID: 372
		public uint State;

		// Token: 0x04000175 RID: 373
		public uint Protect;

		// Token: 0x04000176 RID: 374
		public uint Type;
	}

	// Token: 0x02000012 RID: 18
	private enum AllocationProtectEnum : uint
	{
		// Token: 0x04000178 RID: 376
		PAGE_EXECUTE = 16U,
		// Token: 0x04000179 RID: 377
		PAGE_EXECUTE_READ = 32U,
		// Token: 0x0400017A RID: 378
		PAGE_EXECUTE_READWRITE = 64U,
		// Token: 0x0400017B RID: 379
		PAGE_EXECUTE_WRITECOPY = 128U,
		// Token: 0x0400017C RID: 380
		PAGE_NOACCESS = 1U,
		// Token: 0x0400017D RID: 381
		PAGE_READONLY,
		// Token: 0x0400017E RID: 382
		PAGE_READWRITE = 4U,
		// Token: 0x0400017F RID: 383
		PAGE_WRITECOPY = 8U,
		// Token: 0x04000180 RID: 384
		PAGE_GUARD = 256U,
		// Token: 0x04000181 RID: 385
		PAGE_NOCACHE = 512U,
		// Token: 0x04000182 RID: 386
		PAGE_WRITECOMBINE = 1024U
	}

	// Token: 0x02000013 RID: 19
	private enum StateEnum : uint
	{
		// Token: 0x04000184 RID: 388
		MEM_COMMIT = 4096U,
		// Token: 0x04000185 RID: 389
		MEM_FREE = 65536U,
		// Token: 0x04000186 RID: 390
		MEM_RESERVE = 8192U
	}

	// Token: 0x02000014 RID: 20
	private enum TypeEnum : uint
	{
		// Token: 0x04000188 RID: 392
		MEM_IMAGE = 16777216U,
		// Token: 0x04000189 RID: 393
		MEM_MAPPED = 262144U,
		// Token: 0x0400018A RID: 394
		MEM_PRIVATE = 131072U
	}
}
