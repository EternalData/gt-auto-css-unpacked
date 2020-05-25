using System;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200004B RID: 75
	public class oj : StatusStrip
	{
		// Token: 0x0600024E RID: 590 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		public oj()
		{
			this.og = new gI();
			base.SizingGrip = false;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000E514 File Offset: 0x0000C714
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000E524 File Offset: 0x0000C724
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
