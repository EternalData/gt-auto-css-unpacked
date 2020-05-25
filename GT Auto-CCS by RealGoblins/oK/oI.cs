using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using pq;

namespace oK
{
	// Token: 0x0200004F RID: 79
	public partial class oI : Form
	{
		// Token: 0x06000262 RID: 610 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		public oI()
		{
			this.oZ();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		public void oS()
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				new Jj().Show();
			}));
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		private void oT(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000EC00 File Offset: 0x0000CE00
		private void oW(object sender, EventArgs e)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000EC30 File Offset: 0x0000CE30
		private void oZ()
		{
			oI.<InitializeComponent>d__6 <InitializeComponent>d__;
			<InitializeComponent>d__.<>4__this = this;
			<InitializeComponent>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitializeComponent>d__.<>1__state = -1;
			AsyncVoidMethodBuilder <>t__builder = <InitializeComponent>d__.<>t__builder;
			<>t__builder.Start<oI.<InitializeComponent>d__6>(ref <InitializeComponent>d__);
		}

		// Token: 0x0400014E RID: 334
		private BunifuElipse oM;

		// Token: 0x0400014F RID: 335
		private BunifuDragControl oN;

		// Token: 0x04000150 RID: 336
		private BunifuFlatButton oO;

		// Token: 0x04000151 RID: 337
		private pa oP;

		// Token: 0x04000152 RID: 338
		private BunifuCustomLabel oQ;

		// Token: 0x04000153 RID: 339
		private BunifuCustomLabel oR;
	}
}
