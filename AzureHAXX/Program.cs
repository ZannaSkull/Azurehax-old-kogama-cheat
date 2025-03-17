using System;
using System.Windows.Forms;

namespace AzureHAXX
{
	// Token: 0x0200000E RID: 14
	internal static class Program
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00015B9D File Offset: 0x00013D9D
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Loader());
		}
	}
}
