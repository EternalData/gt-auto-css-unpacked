using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200004D RID: 77
	internal class om : Control
	{
		// Token: 0x06000253 RID: 595 RVA: 0x0000E648 File Offset: 0x0000C848
		public om()
		{
			this.ForeColor = Color.DimGray;
			this.BackColor = Color.FromArgb(246, 246, 246);
			base.Size = new Size(33, 33);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000E698 File Offset: 0x0000C898
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			e.Graphics.FillEllipse(new SolidBrush(Color.Gray), new Rectangle(1, 1, 29, 29));
			e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(246, 246, 246)), new Rectangle(3, 3, 25, 25));
			e.Graphics.DrawString("ü", new Font("Wingdings", 25f, FontStyle.Bold), new SolidBrush(Color.Gray), new Rectangle(0, -3, base.Width, 43), new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Near
			});
		}
	}
}
