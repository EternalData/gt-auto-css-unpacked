using System;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000049 RID: 73
	public class oc : MenuStrip
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0000E498 File Offset: 0x0000C698
		public oc()
		{
			this.og = new gI();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		public gI og
		{
			get
			{
				return (gI)base.Renderer;
			}
			set
			{
				base.Renderer = value;
			}
		}
	}
}
