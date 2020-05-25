using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000038 RID: 56
	internal class lo : ContainerControl
	{
		// Token: 0x060001CF RID: 463 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		public lo()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.Transparent;
			base.Size = new Size(187, 117);
			base.Padding = new Padding(5, 5, 5, 5);
			this.DoubleBuffered = true;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000C00C File Offset: 0x0000A20C
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.il = new GraphicsPath();
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(Brushes.White, this.il);
			graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), this.il);
			graphics.Dispose();
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x04000112 RID: 274
		private GraphicsPath il;
	}
}
