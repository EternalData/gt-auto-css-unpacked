using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200003F RID: 63
	internal class lI : Control
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		public int bL
		{
			get
			{
				if (this.bG == 0)
				{
					return 0;
				}
				return this.bG;
			}
			set
			{
				if (value > this.bH)
				{
					value = this.bH;
				}
				this.bG = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public int bP
		{
			get
			{
				return this.bH;
			}
			set
			{
				if (value < this.bG)
				{
					this.bG = value;
				}
				this.bH = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000CA24 File Offset: 0x0000AC24
		public lI()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.Text = null;
			this.DoubleBuffered = true;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000CA58 File Offset: 0x0000AC58
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 20;
			base.Width = 20;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000CA74 File Offset: 0x0000AC74
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			string s = this.bG.ToString();
			graphics.Clear(this.BackColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(18, 20)), Color.FromArgb(197, 69, 68), Color.FromArgb(176, 52, 52), 90f);
			graphics.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(18, 18)));
			graphics.DrawEllipse(new Pen(Color.FromArgb(205, 70, 66)), new Rectangle(new Point(0, 0), new Size(18, 18)));
			graphics.DrawString(s, new Font("Segoe UI", 8f, FontStyle.Bold), new SolidBrush(Color.FromArgb(255, 255, 253)), new Rectangle(0, 0, base.Width - 2, base.Height), new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			});
			e.Dispose();
		}

		// Token: 0x04000120 RID: 288
		private int bG;

		// Token: 0x04000121 RID: 289
		private int bH = 99;
	}
}
