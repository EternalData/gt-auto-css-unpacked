using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace pq
{
	// Token: 0x02000053 RID: 83
	public class pp : WebClient
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000F170 File Offset: 0x0000D370
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000F178 File Offset: 0x0000D378
		public int pv { get; set; }

		// Token: 0x06000275 RID: 629 RVA: 0x0000F184 File Offset: 0x0000D384
		public pp()
		{
			this.pv = 5000;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000F198 File Offset: 0x0000D398
		protected override WebRequest GetWebRequest(Uri address)
		{
			WebRequest webRequest = base.GetWebRequest(address);
			webRequest.Timeout = this.pv;
			return webRequest;
		}

		// Token: 0x04000161 RID: 353
		[CompilerGenerated]
		private int pr;
	}
}
