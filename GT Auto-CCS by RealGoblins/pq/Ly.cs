using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;

namespace pq
{
	// Token: 0x0200007B RID: 123
	public class Ly : IDisposable
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0002490C File Offset: 0x00022B0C
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00024914 File Offset: 0x00022B14
		public string KQ { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00024920 File Offset: 0x00022B20
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00024928 File Offset: 0x00022B28
		public string KU { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00024934 File Offset: 0x00022B34
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0002493C File Offset: 0x00022B3C
		public string KY { get; set; }

		// Token: 0x0600040B RID: 1035 RVA: 0x00024948 File Offset: 0x00022B48
		public Ly()
		{
			this.KF = new WebClient();
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0002495C File Offset: 0x00022B5C
		public void vw(string LC)
		{
			Ly.KG.Add("username", this.KU);
			Ly.KG.Add("avatar_url", this.KY);
			Ly.KG.Add("content", LC);
			this.KF.UploadValues(this.KQ, Ly.KG);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000249BC File Offset: 0x00022BBC
		public void Dispose()
		{
			this.KF.Dispose();
		}

		// Token: 0x04000338 RID: 824
		private readonly WebClient KF;

		// Token: 0x04000339 RID: 825
		private static NameValueCollection KG = new NameValueCollection();

		// Token: 0x0400033A RID: 826
		[CompilerGenerated]
		private string KH;

		// Token: 0x0400033B RID: 827
		[CompilerGenerated]
		private string KI;

		// Token: 0x0400033C RID: 828
		[CompilerGenerated]
		private string KJ;
	}
}
