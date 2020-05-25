using System;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
public static class a
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	public static void b(Form c, Control d, string e)
	{
		if (d.InvokeRequired)
		{
			a.MF method = new a.MF(a.b);
			c.Invoke(method, new object[]
			{
				c,
				d,
				e
			});
			return;
		}
		d.Text = e;
	}

	// Token: 0x02000003 RID: 3
	// (Invoke) Token: 0x06000004 RID: 4
	private delegate void MF(Form f, Control ctrl, string text);
}
