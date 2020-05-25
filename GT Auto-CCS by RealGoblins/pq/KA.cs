using System;
using System.Windows.Forms;

namespace pq
{
	// Token: 0x02000078 RID: 120
	internal static class KA
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x000234F8 File Offset: 0x000216F8
		[STAThread]
		private static void KB()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Jj());
		}
	}
}
