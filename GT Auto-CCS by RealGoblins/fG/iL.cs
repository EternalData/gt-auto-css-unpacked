using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000028 RID: 40
	internal class iL : Control
	{
		// Token: 0x06000145 RID: 325 RVA: 0x000092C0 File Offset: 0x000074C0
		private static PointF iF(StringFormat iP, SizeF iQ, SizeF iR)
		{
			PointF result = default(PointF);
			switch (iP.Alignment)
			{
			case StringAlignment.Near:
				result.X = 2f;
				break;
			case StringAlignment.Center:
				result.X = Convert.ToSingle((iQ.Width - iR.Width) / 2f);
				break;
			case StringAlignment.Far:
				result.X = iQ.Width - iR.Width - 2f;
				break;
			}
			switch (iP.LineAlignment)
			{
			case StringAlignment.Near:
				result.Y = 2f;
				break;
			case StringAlignment.Center:
				result.Y = Convert.ToSingle((iQ.Height - iR.Height) / 2f);
				break;
			case StringAlignment.Far:
				result.Y = iQ.Height - iR.Height - 2f;
				break;
			}
			return result;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000093A8 File Offset: 0x000075A8
		private StringFormat iJ(ContentAlignment iS)
		{
			StringFormat stringFormat = new StringFormat();
			if (iS <= ContentAlignment.MiddleCenter)
			{
				switch (iS)
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
					if (iS != ContentAlignment.MiddleLeft)
					{
						if (iS == ContentAlignment.MiddleCenter)
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
			else if (iS <= ContentAlignment.BottomLeft)
			{
				if (iS != ContentAlignment.MiddleRight)
				{
					if (iS == ContentAlignment.BottomLeft)
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
			else if (iS != ContentAlignment.BottomCenter)
			{
				if (iS == ContentAlignment.BottomRight)
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000094AC File Offset: 0x000076AC
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000094B4 File Offset: 0x000076B4
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000094EC File Offset: 0x000076EC
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000094F4 File Offset: 0x000076F4
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00009504 File Offset: 0x00007704
		protected Size iw
		{
			get
			{
				return this.iq;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000950C File Offset: 0x0000770C
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00009514 File Offset: 0x00007714
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

		// Token: 0x0600014E RID: 334 RVA: 0x00009524 File Offset: 0x00007724
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.aR = 0;
			base.Invalidate();
			base.OnMouseUp(e);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000953C File Offset: 0x0000773C
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.aR = 1;
			base.Invalidate();
			base.OnMouseDown(e);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00009554 File Offset: 0x00007754
		protected override void OnMouseLeave(EventArgs e)
		{
			this.aR = 0;
			base.Invalidate();
			base.OnMouseLeave(e);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000956C File Offset: 0x0000776C
		protected override void OnTextChanged(EventArgs e)
		{
			base.Invalidate();
			base.OnTextChanged(e);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000957C File Offset: 0x0000777C
		public iL()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 14f);
			this.ForeColor = Color.White;
			base.Size = new Size(166, 40);
			this.ir = StringAlignment.Center;
			this.bh = new Pen(Color.FromArgb(0, 118, 176));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00009610 File Offset: 0x00007810
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (base.Width > 0 && base.Height > 0)
			{
				this.il = new GraphicsPath();
				this.bk = new Rectangle(0, 0, base.Width, base.Height);
				this.im = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(0, 176, 231), Color.FromArgb(0, 152, 224), 90f);
				this.@in = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(0, 118, 176), Color.FromArgb(0, 149, 222), 90f);
				this.io = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(0, 118, 176), Color.FromArgb(0, 118, 176), 90f);
				this.ip = new Pen(this.io);
			}
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
			base.Invalidate();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000097BC File Offset: 0x000079BC
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			PointF pointF = iL.iF(this.iJ(this.iA), base.Size, this.iw);
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

		// Token: 0x040000CB RID: 203
		private int aR;

		// Token: 0x040000CC RID: 204
		private GraphicsPath il;

		// Token: 0x040000CD RID: 205
		private LinearGradientBrush im;

		// Token: 0x040000CE RID: 206
		private LinearGradientBrush @in;

		// Token: 0x040000CF RID: 207
		private LinearGradientBrush io;

		// Token: 0x040000D0 RID: 208
		private Rectangle bk;

		// Token: 0x040000D1 RID: 209
		private Pen bh;

		// Token: 0x040000D2 RID: 210
		private Pen ip;

		// Token: 0x040000D3 RID: 211
		private Image aj;

		// Token: 0x040000D4 RID: 212
		private Size iq;

		// Token: 0x040000D5 RID: 213
		private StringAlignment ir = StringAlignment.Center;

		// Token: 0x040000D6 RID: 214
		private ContentAlignment it = ContentAlignment.MiddleLeft;
	}
}
