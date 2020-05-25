using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace pq
{
	// Token: 0x0200007A RID: 122
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class Ls
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x00024894 File Offset: 0x00022A94
		internal Ls()
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0002489C File Offset: 0x00022A9C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager cK
		{
			get
			{
				if (Ls.cH == null)
				{
					Ls.cH = new ResourceManager("pq.Ls", typeof(Ls).Assembly);
				}
				return Ls.cH;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000248C8 File Offset: 0x00022AC8
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x000248D0 File Offset: 0x00022AD0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo cO
		{
			get
			{
				return Ls.cI;
			}
			set
			{
				Ls.cI = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000248D8 File Offset: 0x00022AD8
		public static byte[] Lv
		{
			get
			{
				return (byte[])Ls.cK.GetObject("rasphone", Ls.cI);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000248F4 File Offset: 0x00022AF4
		public static string Lx
		{
			get
			{
				return Ls.cK.GetString("rasphone_txt", Ls.cI);
			}
		}

		// Token: 0x04000336 RID: 822
		private static ResourceManager cH;

		// Token: 0x04000337 RID: 823
		private static CultureInfo cI;
	}
}
