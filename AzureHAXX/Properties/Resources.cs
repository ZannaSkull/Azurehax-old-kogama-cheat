using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AzureHAXX.Properties
{
	// Token: 0x0200000F RID: 15
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00015BB8 File Offset: 0x00013DB8
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00015BC4 File Offset: 0x00013DC4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("AzureHAXX.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00015C0C File Offset: 0x00013E0C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00015C23 File Offset: 0x00013E23
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400016D RID: 365
		private static ResourceManager resourceMan;

		// Token: 0x0400016E RID: 366
		private static CultureInfo resourceCulture;
	}
}
