using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000046 RID: 70
	[DefaultEvent("ValueChanged")]
	internal class nj : Control
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000DE84 File Offset: 0x0000C084
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000DE8C File Offset: 0x0000C08C
		public int kS
		{
			get
			{
				return this.kJ;
			}
			set
			{
				if (value >= this.bH)
				{
					value = this.bH - 10;
				}
				if (this.bG < value)
				{
					this.bG = value;
				}
				this.kJ = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000DECC File Offset: 0x0000C0CC
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		public int bP
		{
			get
			{
				return this.bH;
			}
			set
			{
				if (value <= this.kJ)
				{
					value = this.kJ + 10;
				}
				if (this.bG > value)
				{
					this.bG = value;
				}
				this.bH = value;
				base.Invalidate();
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600022E RID: 558 RVA: 0x0000DF14 File Offset: 0x0000C114
		// (remove) Token: 0x0600022F RID: 559 RVA: 0x0000DF4C File Offset: 0x0000C14C
		public event nj.NV ob
		{
			[CompilerGenerated]
			add
			{
				nj.NV nv = this.ValueChanged;
				nj.NV nv2;
				do
				{
					nv2 = nv;
					nj.NV value2 = (nj.NV)Delegate.Combine(nv2, value);
					nv = Interlocked.CompareExchange<nj.NV>(ref this.ValueChanged, value2, nv2);
				}
				while (nv != nv2);
			}
			[CompilerGenerated]
			remove
			{
				nj.NV nv = this.ValueChanged;
				nj.NV nv2;
				do
				{
					nv2 = nv;
					nj.NV value2 = (nj.NV)Delegate.Remove(nv2, value);
					nv = Interlocked.CompareExchange<nj.NV>(ref this.ValueChanged, value2, nv2);
				}
				while (nv != nv2);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000DF84 File Offset: 0x0000C184
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0000DF8C File Offset: 0x0000C18C
		public int bL
		{
			get
			{
				return this.bG;
			}
			set
			{
				if (this.bG != value)
				{
					if (value < this.kJ)
					{
						this.bG = this.kJ;
					}
					else if (value > this.bH)
					{
						this.bG = this.bH;
					}
					else
					{
						this.bG = value;
					}
					base.Invalidate();
					if (this.ValueChanged != null)
					{
						this.ValueChanged();
					}
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		public nj.NQ nC
		{
			get
			{
				return this.nv;
			}
			set
			{
				this.nv = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000E008 File Offset: 0x0000C208
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0000E01C File Offset: 0x0000C21C
		[Browsable(false)]
		public float nG
		{
			get
			{
				return (float)((double)this.bG / (double)this.nv);
			}
			set
			{
				this.bL = (int)Math.Round((double)(value * (float)this.nv));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000E034 File Offset: 0x0000C234
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0000E03C File Offset: 0x0000C23C
		public Color nK
		{
			get
			{
				return this.nr;
			}
			set
			{
				this.nr = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000E04C File Offset: 0x0000C24C
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000E054 File Offset: 0x0000C254
		public bool nO
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000E064 File Offset: 0x0000C264
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000E06C File Offset: 0x0000C26C
		public bool nS
		{
			get
			{
				return this.nt;
			}
			set
			{
				this.nt = value;
				if (this.nt)
				{
					base.Height = 40;
				}
				else
				{
					base.Height = 22;
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		public bool nW
		{
			get
			{
				return this.nu;
			}
			set
			{
				this.nu = value;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this.hj && e.X > -1 && e.X < base.Width + 1)
			{
				this.bL = this.kJ + (int)Math.Round((double)(this.bH - this.kJ) * ((double)e.X / (double)base.Width));
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000E11C File Offset: 0x0000C31C
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (e.Button == MouseButtons.Left)
			{
				this.nq = (int)Math.Round((double)(this.bG - this.kJ) / (double)(this.bH - this.kJ) * (double)(base.Width - 11));
				this.nm = new Rectangle(this.nq, 0, 10, 20);
				this.hj = this.nm.Contains(e.Location);
				if (this.nu)
				{
					this.bL = this.kJ + (int)Math.Round((double)(this.bH - this.kJ) * ((double)e.X / (double)base.Width));
				}
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000E1DC File Offset: 0x0000C3DC
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.hj = false;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000E1EC File Offset: 0x0000C3EC
		public nj()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.ns = true;
			base.Size = new Size(80, 22);
			this.MinimumSize = new Size(37, 22);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000E260 File Offset: 0x0000C460
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.nt)
			{
				base.Height = 40;
				return;
			}
			base.Height = 22;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000E290 File Offset: 0x0000C490
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			HatchBrush brush = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent);
			graphics.Clear(base.Parent.BackColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			checked
			{
				this.nk = fF.fH(1, 6, base.Width - 3, 8, 3);
				try
				{
					this.nq = (int)Math.Round(unchecked(checked((double)(this.bG - this.kJ) / (double)(this.bH - this.kJ)) * (double)(checked(base.Width - 11))));
				}
				catch (Exception)
				{
				}
				this.nm = new Rectangle(this.nq, 0, 10, 20);
				graphics.SetClip(this.nk);
				this.nn = new Rectangle(1, 7, this.nm.X + this.nm.Width - 2, 7);
				this.no = new LinearGradientBrush(this.nn, this.nr, this.nr, 90f);
				graphics.FillRectangle(this.no, this.nn);
				if (this.ns)
				{
					graphics.FillRectangle(brush, this.nn);
				}
				graphics.ResetClip();
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), this.nk);
				this.nl = fF.fH(this.nm, 3);
				this.np = new LinearGradientBrush(base.ClientRectangle, SystemColors.Control, SystemColors.Control, 90f);
				graphics.FillPath(this.np, this.nl);
				graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), this.nl);
				if (this.nt)
				{
					graphics.DrawString(Convert.ToString(this.nG), this.Font, Brushes.Gray, 0f, 25f);
				}
			}
		}

		// Token: 0x04000136 RID: 310
		private GraphicsPath nk;

		// Token: 0x04000137 RID: 311
		private GraphicsPath nl;

		// Token: 0x04000138 RID: 312
		private Rectangle nm;

		// Token: 0x04000139 RID: 313
		private Rectangle nn;

		// Token: 0x0400013A RID: 314
		private LinearGradientBrush no;

		// Token: 0x0400013B RID: 315
		private LinearGradientBrush np;

		// Token: 0x0400013C RID: 316
		private bool hj;

		// Token: 0x0400013D RID: 317
		private int nq;

		// Token: 0x0400013E RID: 318
		private int kJ;

		// Token: 0x0400013F RID: 319
		private int bH = 10;

		// Token: 0x04000140 RID: 320
		private int bG;

		// Token: 0x04000141 RID: 321
		private Color nr = Color.FromArgb(224, 224, 224);

		// Token: 0x04000142 RID: 322
		private bool ns = true;

		// Token: 0x04000143 RID: 323
		private bool nt;

		// Token: 0x04000144 RID: 324
		private bool nu;

		// Token: 0x04000145 RID: 325
		private nj.NQ nv = nj.NQ.NR;

		// Token: 0x04000146 RID: 326
		[CompilerGenerated]
		private nj.NV ValueChanged;

		// Token: 0x02000047 RID: 71
		public enum NQ
		{
			// Token: 0x04000148 RID: 328
			NR = 1,
			// Token: 0x04000149 RID: 329
			NS = 10,
			// Token: 0x0400014A RID: 330
			NT = 100,
			// Token: 0x0400014B RID: 331
			NU = 1000
		}

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000245 RID: 581
		public delegate void NV();
	}
}
