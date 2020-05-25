using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x0200003C RID: 60
	[DefaultEvent("CheckedChanged")]
	internal class lD : Control
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060001E1 RID: 481 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		// (remove) Token: 0x060001E2 RID: 482 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		public event lD.NK lC
		{
			[CompilerGenerated]
			add
			{
				lD.NK nk = this.CheckedChanged;
				lD.NK nk2;
				do
				{
					nk2 = nk;
					lD.NK value2 = (lD.NK)Delegate.Combine(nk2, value);
					nk = Interlocked.CompareExchange<lD.NK>(ref this.CheckedChanged, value2, nk2);
				}
				while (nk != nk2);
			}
			[CompilerGenerated]
			remove
			{
				lD.NK nk = this.CheckedChanged;
				lD.NK nk2;
				do
				{
					nk2 = nk;
					lD.NK value2 = (lD.NK)Delegate.Remove(nk2, value);
					nk = Interlocked.CompareExchange<lD.NK>(ref this.CheckedChanged, value2, nk2);
				}
				while (nk != nk2);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000C71C File Offset: 0x0000A91C
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000C724 File Offset: 0x0000A924
		public bool lx
		{
			get
			{
				return this.lt;
			}
			set
			{
				this.lt = value;
				this.lH();
				if (this.CheckedChanged != null)
				{
					this.CheckedChanged(this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000C758 File Offset: 0x0000A958
		protected override void OnTextChanged(EventArgs e)
		{
			base.Invalidate();
			base.OnTextChanged(e);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000C768 File Offset: 0x0000A968
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 15;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000C77C File Offset: 0x0000A97C
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (!this.lt)
			{
				this.lx = true;
			}
			base.OnMouseDown(e);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000C794 File Offset: 0x0000A994
		public lD()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this.Font = new Font("Segoe UI", 10f);
			base.Width = 132;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		private void lH()
		{
			if (base.IsHandleCreated && this.lt)
			{
				foreach (object obj in base.Parent.Controls)
				{
					Control control = (Control)obj;
					if (control != this && control is lD)
					{
						((lD)control).lx = false;
					}
				}
				return;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000C858 File Offset: 0x0000AA58
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.Clear(Color.FromArgb(0, 0, 0));
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(14, 14)), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), 90f);
			graphics.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(14, 14)));
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(new Rectangle(0, 0, 14, 14));
			graphics.SetClip(graphicsPath);
			graphics.ResetClip();
			graphics.DrawEllipse(new Pen(Color.FromArgb(255, 255, 255)), new Rectangle(new Point(0, 0), new Size(14, 14)));
			if (this.lt)
			{
				SolidBrush brush2 = new SolidBrush(Color.FromArgb(255, 255, 255));
				graphics.FillEllipse(brush2, new Rectangle(new Point(4, 4), new Size(6, 6)));
			}
			graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(255, 255, 255)), 16f, 8f, new StringFormat
			{
				LineAlignment = StringAlignment.Center
			});
			e.Dispose();
		}

		// Token: 0x04000119 RID: 281
		private bool lt;

		// Token: 0x0400011A RID: 282
		[CompilerGenerated]
		private lD.NK CheckedChanged;

		// Token: 0x0200003D RID: 61
		public enum Nt : byte
		{
			// Token: 0x0400011C RID: 284
			Nu,
			// Token: 0x0400011D RID: 285
			Nv,
			// Token: 0x0400011E RID: 286
			Nw,
			// Token: 0x0400011F RID: 287
			Nx
		}

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060001EC RID: 492
		public delegate void NK(object sender);
	}
}
