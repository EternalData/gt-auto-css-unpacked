using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000027 RID: 39
	internal class ik : Control
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00008B3C File Offset: 0x00006D3C
		private static PointF iF(StringFormat iG, SizeF iH, SizeF iI)
		{
			PointF result = default(PointF);
			switch (iG.Alignment)
			{
			case StringAlignment.Near:
				result.X = 2f;
				break;
			case StringAlignment.Center:
				result.X = Convert.ToSingle((iH.Width - iI.Width) / 2f);
				break;
			case StringAlignment.Far:
				result.X = iH.Width - iI.Width - 2f;
				break;
			}
			switch (iG.LineAlignment)
			{
			case StringAlignment.Near:
				result.Y = 2f;
				break;
			case StringAlignment.Center:
				result.Y = Convert.ToSingle((iH.Height - iI.Height) / 2f);
				break;
			case StringAlignment.Far:
				result.Y = iH.Height - iI.Height - 2f;
				break;
			}
			return result;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008C24 File Offset: 0x00006E24
		private StringFormat iJ(ContentAlignment iK)
		{
			StringFormat stringFormat = new StringFormat();
			if (iK <= ContentAlignment.MiddleCenter)
			{
				switch (iK)
				{
				case ContentAlignment.TopLeft:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Near;
					break;
				case ContentAlignment.TopCenter:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Center;
					break;
				case (ContentAlignment)3:
					break;
				case ContentAlignment.TopRight:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Far;
					break;
				default:
					if (iK != ContentAlignment.MiddleLeft)
					{
						if (iK == ContentAlignment.MiddleCenter)
						{
							stringFormat.LineAlignment = StringAlignment.Center;
							stringFormat.Alignment = StringAlignment.Center;
						}
					}
					else
					{
						stringFormat.LineAlignment = StringAlignment.Center;
						stringFormat.Alignment = StringAlignment.Near;
					}
					break;
				}
			}
			else if (iK <= ContentAlignment.BottomLeft)
			{
				if (iK != ContentAlignment.MiddleRight)
				{
					if (iK == ContentAlignment.BottomLeft)
					{
						stringFormat.LineAlignment = StringAlignment.Far;
						stringFormat.Alignment = StringAlignment.Near;
					}
				}
				else
				{
					stringFormat.LineAlignment = StringAlignment.Center;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else if (iK != ContentAlignment.BottomCenter)
			{
				if (iK == ContentAlignment.BottomRight)
				{
					stringFormat.LineAlignment = StringAlignment.Far;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else
			{
				stringFormat.LineAlignment = StringAlignment.Far;
				stringFormat.Alignment = StringAlignment.Center;
			}
			return stringFormat;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00008D28 File Offset: 0x00006F28
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00008D30 File Offset: 0x00006F30
		public Image ax
		{
			get
			{
				return this.aj;
			}
			set
			{
				if (value == null)
				{
					this.iq = Size.Empty;
				}
				else
				{
					this.iq = value.Size;
				}
				this.aj = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00008D68 File Offset: 0x00006F68
		protected Size iw
		{
			get
			{
				return this.iq;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00008D70 File Offset: 0x00006F70
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00008D78 File Offset: 0x00006F78
		public ContentAlignment iA
		{
			get
			{
				return this.it;
			}
			set
			{
				this.it = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00008D88 File Offset: 0x00006F88
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00008D90 File Offset: 0x00006F90
		public StringAlignment iE
		{
			get
			{
				return this.ir;
			}
			set
			{
				this.ir = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00008DA0 File Offset: 0x00006FA0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00008DA8 File Offset: 0x00006FA8
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

		// Token: 0x0600013E RID: 318 RVA: 0x00008DB8 File Offset: 0x00006FB8
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.aR = 0;
			base.Invalidate();
			base.OnMouseUp(e);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00008DD0 File Offset: 0x00006FD0
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.aR = 1;
			base.Invalidate();
			base.OnMouseDown(e);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008DE8 File Offset: 0x00006FE8
		protected override void OnMouseLeave(EventArgs e)
		{
			this.aR = 0;
			base.Invalidate();
			base.OnMouseLeave(e);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00008E00 File Offset: 0x00007000
		protected override void OnTextChanged(EventArgs e)
		{
			base.Invalidate();
			base.OnTextChanged(e);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008E10 File Offset: 0x00007010
		public ik()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.FromArgb(36, 36, 36);
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 12f);
			this.ForeColor = Color.FromArgb(255, 255, 255);
			base.Size = new Size(166, 40);
			this.ir = StringAlignment.Center;
			this.bh = new Pen(Color.FromArgb(36, 36, 36));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008ED0 File Offset: 0x000070D0
		protected override void OnResize(EventArgs e)
		{
			if (base.Width > 0 && base.Height > 0)
			{
				this.il = new GraphicsPath();
				this.bk = new Rectangle(0, 0, base.Width, base.Height);
				this.im = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(251, 251, 251), Color.FromArgb(225, 225, 225), 90f);
				this.@in = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(46, 46, 46), Color.FromArgb(46, 46, 46), 90f);
				this.io = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(167, 167, 167), Color.FromArgb(167, 167, 167), 90f);
				this.ip = new Pen(this.io);
			}
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
			base.OnResize(e);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000908C File Offset: 0x0000728C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			PointF pointF = ik.iF(this.iJ(this.iA), base.Size, this.iw);
			int num = this.aR;
			if (num != 0)
			{
				if (num == 1)
				{
					graphics.FillPath(this.@in, this.il);
					graphics.DrawPath(this.ip, this.il);
					if (this.ax == null)
					{
						graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.bk, new StringFormat
						{
							Alignment = this.ir,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawImage(this.aj, pointF.X, pointF.Y, (float)this.iw.Width, (float)this.iw.Height);
						graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.bk, new StringFormat
						{
							Alignment = this.ir,
							LineAlignment = StringAlignment.Center
						});
					}
				}
			}
			else
			{
				graphics.FillPath(this.im, this.il);
				graphics.DrawPath(this.bh, this.il);
				if (this.ax == null)
				{
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.bk, new StringFormat
					{
						Alignment = this.ir,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawImage(this.aj, pointF.X, pointF.Y, (float)this.iw.Width, (float)this.iw.Height);
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.bk, new StringFormat
					{
						Alignment = this.ir,
						LineAlignment = StringAlignment.Center
					});
				}
			}
			base.OnPaint(e);
		}

		// Token: 0x040000BE RID: 190
		private int aR;

		// Token: 0x040000BF RID: 191
		private GraphicsPath il;

		// Token: 0x040000C0 RID: 192
		private LinearGradientBrush im;

		// Token: 0x040000C1 RID: 193
		private LinearGradientBrush @in;

		// Token: 0x040000C2 RID: 194
		private LinearGradientBrush io;

		// Token: 0x040000C3 RID: 195
		private Rectangle bk;

		// Token: 0x040000C4 RID: 196
		private Pen bh;

		// Token: 0x040000C5 RID: 197
		private Pen ip;

		// Token: 0x040000C6 RID: 198
		private Image aj;

		// Token: 0x040000C7 RID: 199
		private Size iq;

		// Token: 0x040000C8 RID: 200
		private StringAlignment ir = StringAlignment.Center;

		// Token: 0x040000C9 RID: 201
		private Color @is = Color.FromArgb(150, 150, 150);

		// Token: 0x040000CA RID: 202
		private ContentAlignment it = ContentAlignment.MiddleLeft;
	}
}
