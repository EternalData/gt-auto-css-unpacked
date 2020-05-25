using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000036 RID: 54
	public class lk : Control
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000BC7C File Offset: 0x00009E7C
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000BC84 File Offset: 0x00009E84
		public override Color ForeColor
		{
			get
			{
				return this.@is;
			}
			set
			{
				this.@is = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000BC94 File Offset: 0x00009E94
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000BC9C File Offset: 0x00009E9C
		public Color lf
		{
			get
			{
				return this.la;
			}
			set
			{
				this.la = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000BCAC File Offset: 0x00009EAC
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		public bool lj
		{
			get
			{
				return this.lb;
			}
			set
			{
				this.lb = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public lk()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(152, 38);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.FromArgb(52, 52, 52);
			this.Font = new Font("Segoe UI", 10f);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000BD60 File Offset: 0x00009F60
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.il = new GraphicsPath();
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 18, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 18, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000BE08 File Offset: 0x0000A008
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(this.BackColor);
			graphics2.FillPath(new SolidBrush(this.la), this.il);
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Rectangle(6, 4, base.Width - 15, base.Height));
			if (this.lb)
			{
				Point[] points = new Point[]
				{
					new Point(base.Width - 8, base.Height - 19),
					new Point(base.Width, base.Height - 25),
					new Point(base.Width - 8, base.Height - 30)
				};
				graphics2.FillPolygon(new SolidBrush(this.la), points);
				graphics2.DrawPolygon(new Pen(new SolidBrush(this.la)), points);
			}
			graphics.Dispose();
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x0400010E RID: 270
		private GraphicsPath il;

		// Token: 0x0400010F RID: 271
		private Color @is = Color.FromArgb(52, 52, 52);

		// Token: 0x04000110 RID: 272
		private Color la = Color.FromArgb(192, 206, 215);

		// Token: 0x04000111 RID: 273
		private bool lb = true;
	}
}
