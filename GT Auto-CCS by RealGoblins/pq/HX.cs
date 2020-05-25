using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace pq
{
	// Token: 0x0200006F RID: 111
	public class HX
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00021B9C File Offset: 0x0001FD9C
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00021B90 File Offset: 0x0001FD90
		public string Id { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00021BA4 File Offset: 0x0001FDA4
		public CheckState Ih { get; set; }

		// Token: 0x060003A6 RID: 934 RVA: 0x00021BB8 File Offset: 0x0001FDB8
		public HX(string name, CheckState chk)
		{
			name = name;
			this.Ih = chk;
		}

		// Token: 0x040002D2 RID: 722
		[CompilerGenerated]
		private string HY;

		// Token: 0x040002D3 RID: 723
		[CompilerGenerated]
		private CheckState HZ;
	}
}
