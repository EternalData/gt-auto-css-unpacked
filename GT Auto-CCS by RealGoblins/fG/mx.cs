using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000044 RID: 68
	internal class mx : Control
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000D424 File Offset: 0x0000B624
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000D434 File Offset: 0x0000B634
		public Color mL
		{
			get
			{
				return this.my.Color;
			}
			set
			{
				this.my.Color = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000D444 File Offset: 0x0000B644
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000D454 File Offset: 0x0000B654
		public Color mP
		{
			get
			{
				return this.mz.Color;
			}
			set
			{
				this.mz.Color = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000D464 File Offset: 0x0000B664
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0000D474 File Offset: 0x0000B674
		public int mT
		{
			get
			{
				return this.mA.Interval;
			}
			set
			{
				this.mA.Interval = value;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000D484 File Offset: 0x0000B684
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.mu();
			this.na();
			this.mZ();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		protected override void OnEnabledChanged(EventArgs e)
		{
			base.OnEnabledChanged(e);
			this.mA.Enabled = base.Enabled;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.mA.Tick += this.mW;
			this.mA.Start();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000D4F4 File Offset: 0x0000B6F4
		private void mW(object sender, EventArgs e)
		{
			if (this.mD.Equals(0))
			{
				this.mD = this.mB.Length - 1;
			}
			else
			{
				this.mD--;
			}
			base.Invalidate(false);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000D538 File Offset: 0x0000B738
		public mx()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.Size = new Size(80, 80);
			this.Text = string.Empty;
			this.MinimumSize = new Size(80, 80);
			this.mZ();
			this.mA.Interval = 100;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000D5CC File Offset: 0x0000B7CC
		private void mu()
		{
			int num = Math.Max(base.Width, base.Height);
			base.Size = new Size(num, num);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
		private void mZ()
		{
			Stack<PointF> stack = new Stack<PointF>();
			PointF nf = new PointF((float)base.Width / 2f, (float)base.Height / 2f);
			for (float num = 0f; num < 360f; num += 45f)
			{
				this.ne(nf, (int)Math.Round((double)base.Width / 2.0 - 15.0), (double)num);
				PointF mV = this.mV;
				mV = new PointF(mV.X - 7.5f, mV.Y - 7.5f);
				stack.Push(mV);
			}
			this.mB = stack.ToArray();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		private void na()
		{
			if (base.Width > 0 && base.Height > 0)
			{
				Size maximumBuffer = new Size(base.Width + 1, base.Height + 1);
				this.mE.MaximumBuffer = maximumBuffer;
				this.mC = this.mE.Allocate(base.CreateGraphics(), base.ClientRectangle);
				this.mC.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000D71C File Offset: 0x0000B91C
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			this.mC.Graphics.Clear(this.BackColor);
			int num = this.mB.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.mD == i)
				{
					this.mC.Graphics.FillEllipse(this.mz, this.mB[i].X, this.mB[i].Y, 15f, 15f);
				}
				else
				{
					this.mC.Graphics.FillEllipse(this.my, this.mB[i].X, this.mB[i].Y, 15f, 15f);
				}
			}
			this.mC.Render(e.Graphics);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000D804 File Offset: 0x0000BA04
		private X nb<X>(ref X nc, X nd)
		{
			nc = nd;
			return nd;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000D810 File Offset: 0x0000BA10
		private void ne(PointF nf, int ng, double nh)
		{
			double num = 3.1415926535897931 * nh / 180.0;
			this.mH = nf;
			this.mF = this.nb<double>(ref this.mG, (double)ng);
			this.mF = Math.Sin(num) * this.mF;
			this.mG = Math.Cos(num) * this.mG;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000D874 File Offset: 0x0000BA74
		private PointF mV
		{
			get
			{
				float y = Convert.ToSingle((double)this.mH.Y + this.mF);
				return new PointF(Convert.ToSingle((double)this.mH.X + this.mG), y);
			}
		}

		// Token: 0x0400012C RID: 300
		private readonly SolidBrush my = new SolidBrush(Color.DarkGray);

		// Token: 0x0400012D RID: 301
		private readonly SolidBrush mz = new SolidBrush(Color.DimGray);

		// Token: 0x0400012E RID: 302
		private readonly Timer mA = new Timer();

		// Token: 0x0400012F RID: 303
		private PointF[] mB;

		// Token: 0x04000130 RID: 304
		private BufferedGraphics mC;

		// Token: 0x04000131 RID: 305
		private int mD;

		// Token: 0x04000132 RID: 306
		private readonly BufferedGraphicsContext mE = BufferedGraphicsManager.Current;

		// Token: 0x04000133 RID: 307
		private double mF;

		// Token: 0x04000134 RID: 308
		private double mG;

		// Token: 0x04000135 RID: 309
		private PointF mH;
	}
}
