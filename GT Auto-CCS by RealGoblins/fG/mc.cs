using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000042 RID: 66
	public class mc : Control
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		public long bL
		{
			get
			{
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000D008 File Offset: 0x0000B208
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0000D010 File Offset: 0x0000B210
		public long bP
		{
			get
			{
				return this.bH;
			}
			set
			{
				if (value < 1L)
				{
					value = 1L;
				}
				this.bH = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000D044 File Offset: 0x0000B244
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000D04C File Offset: 0x0000B24C
		public Color ml
		{
			get
			{
				return this.md;
			}
			set
			{
				this.md = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000D05C File Offset: 0x0000B25C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000D064 File Offset: 0x0000B264
		public Color mp
		{
			get
			{
				return this.me;
			}
			set
			{
				this.me = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000D074 File Offset: 0x0000B274
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000D07C File Offset: 0x0000B27C
		public mc.NM mt
		{
			get
			{
				return this.mf;
			}
			set
			{
				this.mf = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000D08C File Offset: 0x0000B28C
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.mu();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000D09C File Offset: 0x0000B29C
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.mu();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		protected override void OnPaintBackground(PaintEventArgs p)
		{
			base.OnPaintBackground(p);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		public mc()
		{
			base.Size = new Size(130, 130);
			this.Font = new Font("Segoe UI", 15f);
			this.MinimumSize = new Size(100, 100);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000D13C File Offset: 0x0000B33C
		private void mu()
		{
			int num = Math.Max(base.Width, base.Height);
			base.Size = new Size(num, num);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000D168 File Offset: 0x0000B368
		public void kV(int mv)
		{
			this.bG += (long)mv;
			base.Invalidate();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000D180 File Offset: 0x0000B380
		public void kX(int mw)
		{
			this.bG -= (long)mw;
			base.Invalidate();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000D198 File Offset: 0x0000B398
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.Clear(this.BackColor);
					using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, this.md, this.me, LinearGradientMode.ForwardDiagonal))
					{
						using (Pen pen = new Pen(linearGradientBrush, 14f))
						{
							mc.NM nm = this.mf;
							if (nm != mc.NM.NN)
							{
								if (nm == mc.NM.NO)
								{
									pen.StartCap = LineCap.Flat;
									pen.EndCap = LineCap.Flat;
								}
							}
							else
							{
								pen.StartCap = LineCap.Round;
								pen.EndCap = LineCap.Round;
							}
							graphics.DrawArc(pen, 18, 18, base.Width - 35 - 2, base.Height - 35 - 2, -90, (int)Math.Round(360.0 / (double)this.bH * (double)this.bG));
						}
					}
					using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(52, 52, 52), Color.FromArgb(52, 52, 52), LinearGradientMode.Vertical))
					{
						graphics.FillEllipse(linearGradientBrush2, 24, 24, base.Width - 48 - 1, base.Height - 48 - 1);
					}
					SizeF sizeF = graphics.MeasureString(Convert.ToString(Convert.ToInt32(100L / this.bH * this.bG)), this.Font);
					graphics.DrawString(Convert.ToString(Convert.ToInt32(100L / this.bH * this.bG)), this.Font, Brushes.White, (float)Convert.ToInt32((float)(base.Width / 2) - sizeF.Width / 2f), (float)Convert.ToInt32((float)(base.Height / 2) - sizeF.Height / 2f));
					e.Graphics.DrawImage(bitmap, 0, 0);
					graphics.Dispose();
					bitmap.Dispose();
				}
			}
		}

		// Token: 0x04000124 RID: 292
		private long bG;

		// Token: 0x04000125 RID: 293
		private long bH = 100L;

		// Token: 0x04000126 RID: 294
		private Color md = Color.FromArgb(92, 92, 92);

		// Token: 0x04000127 RID: 295
		private Color me = Color.FromArgb(92, 92, 92);

		// Token: 0x04000128 RID: 296
		private mc.NM mf;

		// Token: 0x02000043 RID: 67
		public enum NM
		{
			// Token: 0x0400012A RID: 298
			NN,
			// Token: 0x0400012B RID: 299
			NO
		}
	}
}
