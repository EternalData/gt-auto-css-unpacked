using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000035 RID: 53
	public class kZ : Control
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000B9AC File Offset: 0x00009BAC
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000B9B4 File Offset: 0x00009BB4
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000B9CC File Offset: 0x00009BCC
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000B9DC File Offset: 0x00009BDC
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000B9E4 File Offset: 0x00009BE4
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

		// Token: 0x060001C1 RID: 449 RVA: 0x0000B9F4 File Offset: 0x00009BF4
		public kZ()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(152, 38);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.FromArgb(52, 52, 52);
			this.Font = new Font("Segoe UI", 10f);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000BA90 File Offset: 0x00009C90
		protected override void OnResize(EventArgs e)
		{
			this.il = new GraphicsPath();
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(9, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(9, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
			base.OnResize(e);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000BB3C File Offset: 0x00009D3C
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
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Rectangle(15, 4, base.Width - 17, base.Height - 5));
			if (this.lb)
			{
				Point[] points = new Point[]
				{
					new Point(9, base.Height - 19),
					new Point(0, base.Height - 25),
					new Point(9, base.Height - 30)
				};
				graphics2.FillPolygon(new SolidBrush(this.la), points);
				graphics2.DrawPolygon(new Pen(new SolidBrush(this.la)), points);
			}
			graphics.Dispose();
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x0400010A RID: 266
		private GraphicsPath il;

		// Token: 0x0400010B RID: 267
		private Color @is = Color.FromArgb(52, 52, 52);

		// Token: 0x0400010C RID: 268
		private Color la = Color.FromArgb(217, 217, 217);

		// Token: 0x0400010D RID: 269
		private bool lb = true;
	}
}
