using System;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200004A RID: 74
	public class oh : ContextMenuStrip
	{
		// Token: 0x0600024B RID: 587 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		public oh()
		{
			this.og = new gI();
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000E4DC File Offset: 0x0000C6DC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000E4EC File Offset: 0x0000C6EC
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
