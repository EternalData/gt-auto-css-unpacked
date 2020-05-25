using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000040 RID: 64
	internal class lL : ListView
	{
		// Token: 0x060001F6 RID: 502
		[DllImport("uxtheme", CharSet = CharSet.Unicode)]
		public static extern int SetWindowTheme(IntPtr lN, string lO, string lP);

		// Token: 0x060001F7 RID: 503 RVA: 0x0000CB98 File Offset: 0x0000AD98
		public lL()
		{
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			base.BorderStyle = BorderStyle.None;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		protected override void OnHandleCreated(EventArgs e)
		{
			lL.SetWindowTheme(base.Handle, "explorer", null);
			base.OnHandleCreated(e);
		}
	}
}
