using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;

namespace pq
{
	// Token: 0x0200007C RID: 124
	public class LE : IDisposable
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x000249D8 File Offset: 0x00022BD8
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x000249E0 File Offset: 0x00022BE0
		public string LN { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x000249EC File Offset: 0x00022BEC
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000249F4 File Offset: 0x00022BF4
		public string LR { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00024A00 File Offset: 0x00022C00
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00024A08 File Offset: 0x00022C08
		public string LV { get; set; }

		// Token: 0x06000415 RID: 1045 RVA: 0x00024A14 File Offset: 0x00022C14
		public LE()
		{
			this.LF = new WebClient();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00024A28 File Offset: 0x00022C28
		public void vw(string LW)
		{
			LE.LG.Add("username", this.LR);
			LE.LG.Add("avatar_url", this.LV);
			LE.LG.Add("content", LW);
			this.LF.UploadValues(this.LN, LE.LG);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00024A88 File Offset: 0x00022C88
		public void Dispose()
		{
			this.LF.Dispose();
		}

		// Token: 0x0400033D RID: 829
		private readonly WebClient LF;

		// Token: 0x0400033E RID: 830
		private static NameValueCollection LG = new NameValueCollection();

		// Token: 0x0400033F RID: 831
		[CompilerGenerated]
		private string LH;

		// Token: 0x04000340 RID: 832
		[CompilerGenerated]
		private string LI;

		// Token: 0x04000341 RID: 833
		[CompilerGenerated]
		private string LJ;
	}
}
