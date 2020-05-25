using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200003A RID: 58
	[DefaultEvent("CheckedChanged")]
	internal class lq : Control
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060001D4 RID: 468 RVA: 0x0000C328 File Offset: 0x0000A528
		// (remove) Token: 0x060001D5 RID: 469 RVA: 0x0000C360 File Offset: 0x0000A560
		public event lq.NK lC
		{
			[CompilerGenerated]
			add
			{
				lq.NK nk = this.CheckedChanged;
				lq.NK nk2;
				do
				{
					nk2 = nk;
					lq.NK value2 = (lq.NK)Delegate.Combine(nk2, value);
					nk = Interlocked.CompareExchange<lq.NK>(ref this.CheckedChanged, value2, nk2);
				}
				while (nk != nk2);
			}
			[CompilerGenerated]
			remove
			{
				lq.NK nk = this.CheckedChanged;
				lq.NK nk2;
				do
				{
					nk2 = nk;
					lq.NK value2 = (lq.NK)Delegate.Remove(nk2, value);
					nk = Interlocked.CompareExchange<lq.NK>(ref this.CheckedChanged, value2, nk2);
				}
				while (nk != nk2);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000C398 File Offset: 0x0000A598
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		public bool lx
		{
			get
			{
				return this.lt;
			}
			set
			{
				this.lt = value;
				if (this.CheckedChanged != null)
				{
					this.CheckedChanged(this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000C3D0 File Offset: 0x0000A5D0
		public lq()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 10f);
			base.Size = new Size(120, 26);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000C428 File Offset: 0x0000A628
		protected override void OnClick(EventArgs e)
		{
			this.lt = !this.lt;
			if (this.CheckedChanged != null)
			{
				this.CheckedChanged(this);
			}
			base.Invalidate();
			base.OnClick(e);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000C468 File Offset: 0x0000A668
		protected override void OnTextChanged(EventArgs e)
		{
			base.Invalidate();
			base.OnTextChanged(e);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000C478 File Offset: 0x0000A678
		protected override void OnResize(EventArgs e)
		{
			if (base.Width > 0 && base.Height > 0)
			{
				this.il = new GraphicsPath();
				this.bk = new Rectangle(17, 0, base.Width, base.Height + 1);
				this.ls = new Rectangle(0, 0, base.Width, base.Height);
				this.lr = new LinearGradientBrush(new Rectangle(0, 0, 25, 25), Color.FromArgb(250, 250, 250), Color.FromArgb(240, 240, 240), 90f);
				GraphicsPath graphicsPath = this.il;
				graphicsPath.AddArc(0, 0, 7, 7, 180f, 90f);
				graphicsPath.AddArc(7, 0, 7, 7, -90f, 90f);
				graphicsPath.AddArc(7, 7, 7, 7, 0f, 90f);
				graphicsPath.AddArc(0, 7, 7, 7, 90f, 90f);
				graphicsPath.CloseAllFigures();
				base.Height = 15;
			}
			base.Invalidate();
			base.OnResize(e);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000C590 File Offset: 0x0000A790
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.Clear(Color.FromArgb(246, 246, 246));
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.FillPath(this.lr, this.il);
			graphics.DrawPath(new Pen(Color.FromArgb(160, 160, 160)), this.il);
			graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(142, 142, 142)), this.bk, new StringFormat
			{
				LineAlignment = StringAlignment.Center
			});
			if (this.lx)
			{
				graphics.DrawString("ü", new Font("Wingdings", 14f), new SolidBrush(Color.FromArgb(142, 142, 142)), new Rectangle(-2, 1, base.Width, base.Height), new StringFormat
				{
					LineAlignment = StringAlignment.Center
				});
			}
			e.Dispose();
		}

		// Token: 0x04000113 RID: 275
		private GraphicsPath il;

		// Token: 0x04000114 RID: 276
		private LinearGradientBrush lr;

		// Token: 0x04000115 RID: 277
		private Rectangle bk;

		// Token: 0x04000116 RID: 278
		private Rectangle ls;

		// Token: 0x04000117 RID: 279
		private bool lt;

		// Token: 0x04000118 RID: 280
		[CompilerGenerated]
		private lq.NK CheckedChanged;

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001DE RID: 478
		public delegate void NK(object sender);
	}
}
