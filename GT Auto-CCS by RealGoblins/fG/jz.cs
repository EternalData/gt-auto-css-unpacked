using System;
using System.Drawing;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200002E RID: 46
	internal class jz : LinkLabel
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0000A2BC File Offset: 0x000084BC
		public jz()
		{
			this.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
			this.BackColor = Color.Transparent;
			base.LinkColor = Color.FromArgb(51, 153, 225);
			base.ActiveLinkColor = Color.FromArgb(0, 101, 202);
			base.VisitedLinkColor = Color.FromArgb(0, 101, 202);
			base.LinkBehavior = LinkBehavior.NeverUnderline;
		}
	}
}
