using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200004C RID: 76
	internal class ol : Control
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0000E530 File Offset: 0x0000C730
		public ol()
		{
			this.ForeColor = Color.DimGray;
			this.BackColor = Color.FromArgb(246, 246, 246);
			base.Size = new Size(33, 33);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000E580 File Offset: 0x0000C780
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			e.Graphics.FillEllipse(new SolidBrush(Color.Gray), new Rectangle(1, 1, 29, 29));
			e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(246, 246, 246)), new Rectangle(3, 3, 25, 25));
			e.Graphics.DrawString("¡", new Font("Segoe UI", 25f, FontStyle.Bold), new SolidBrush(Color.Gray), new Rectangle(4, -14, base.Width, 43), new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Near
			});
		}
	}
}
