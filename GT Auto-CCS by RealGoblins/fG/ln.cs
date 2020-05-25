using System;
using System.Drawing;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000037 RID: 55
	public class ln : Control
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0000BF58 File Offset: 0x0000A158
		public ln()
		{
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.Size = new Size(120, 10);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000BF78 File Offset: 0x0000A178
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.DrawLine(new Pen(Color.FromArgb(184, 183, 188)), 0, 5, base.Width, 5);
		}
	}
}
