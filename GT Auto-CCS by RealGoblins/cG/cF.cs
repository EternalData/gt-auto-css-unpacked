using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace cG
{
	// Token: 0x02000012 RID: 18
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class cF
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00005638 File Offset: 0x00003838
		internal cF()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005640 File Offset: 0x00003840
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager cK
		{
			get
			{
				if (cF.cH == null)
				{
					cF.cH = new ResourceManager("LX.cF", typeof(cF).Assembly);
				}
				return cF.cH;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00005670 File Offset: 0x00003870
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00005678 File Offset: 0x00003878
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo cO
		{
			get
			{
				return cF.cI;
			}
			set
			{
				cF.cI = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005680 File Offset: 0x00003880
		internal static byte[] cQ
		{
			get
			{
				return (byte[])cF.cK.GetObject("bin", cF.cI);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000569C File Offset: 0x0000389C
		internal static string cS
		{
			get
			{
				return cF.cK.GetString("oui", cF.cI);
			}
		}

		// Token: 0x04000059 RID: 89
		private static ResourceManager cH;

		// Token: 0x0400005A RID: 90
		private static CultureInfo cI;
	}
}
