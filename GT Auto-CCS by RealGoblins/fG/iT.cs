using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000029 RID: 41
	[DefaultEvent("ToggledChanged")]
	internal class iT : Control
	{
		// Token: 0x06000155 RID: 341 RVA: 0x000099F0 File Offset: 0x00007BF0
		public GraphicsPath jn(Rectangle jo, iT.Ny jp)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			if (jp.Nz)
			{
				graphicsPath.AddArc(new Rectangle(jo.X, jo.Y, jo.Height, jo.Height), -270f, 180f);
			}
			else
			{
				graphicsPath.AddLine(jo.X, jo.Y + jo.Height, jo.X, jo.Y);
			}
			if (jp.NA)
			{
				graphicsPath.AddArc(new Rectangle(jo.X + jo.Width - jo.Height, jo.Y, jo.Height, jo.Height), -90f, 180f);
			}
			else
			{
				graphicsPath.AddLine(jo.X + jo.Width, jo.Y, jo.X + jo.Width, jo.Y + jo.Height);
			}
			graphicsPath.CloseAllFigures();
			return graphicsPath;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009AF8 File Offset: 0x00007CF8
		public object jn(int jq, int jr, int js, int jt, iT.Ny ju)
		{
			return this.jn(new Rectangle(jq, jr, js, jt), ju);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000157 RID: 343 RVA: 0x00009B0C File Offset: 0x00007D0C
		// (remove) Token: 0x06000158 RID: 344 RVA: 0x00009B44 File Offset: 0x00007D44
		public event iT.NF jm
		{
			[CompilerGenerated]
			add
			{
				iT.NF nf = this.ToggledChanged;
				iT.NF nf2;
				do
				{
					nf2 = nf;
					iT.NF value2 = (iT.NF)Delegate.Combine(nf2, value);
					nf = Interlocked.CompareExchange<iT.NF>(ref this.ToggledChanged, value2, nf2);
				}
				while (nf != nf2);
			}
			[CompilerGenerated]
			remove
			{
				iT.NF nf = this.ToggledChanged;
				iT.NF nf2;
				do
				{
					nf2 = nf;
					iT.NF value2 = (iT.NF)Delegate.Remove(nf2, value);
					nf = Interlocked.CompareExchange<iT.NF>(ref this.ToggledChanged, value2, nf2);
				}
				while (nf != nf2);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00009B7C File Offset: 0x00007D7C
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00009B84 File Offset: 0x00007D84
		public bool jd
		{
			get
			{
				return this.iW;
			}
			set
			{
				this.iW = value;
				base.Invalidate();
				if (this.ToggledChanged != null)
				{
					this.ToggledChanged();
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00009BB4 File Offset: 0x00007DB4
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00009BBC File Offset: 0x00007DBC
		public iT.NB jh
		{
			get
			{
				return this.iX;
			}
			set
			{
				this.iX = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00009BCC File Offset: 0x00007DCC
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Width = 41;
			base.Height = 23;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00009BE8 File Offset: 0x00007DE8
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.jd = !this.jd;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00009C00 File Offset: 0x00007E00
		public iT()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.iU.Tick += this.jv;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00009C58 File Offset: 0x00007E58
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.iU.Start();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00009C6C File Offset: 0x00007E6C
		private void jv(object sender, EventArgs e)
		{
			if (this.iW)
			{
				if (this.iV < 100)
				{
					this.iV += 10;
					base.Invalidate(false);
					return;
				}
			}
			else if (this.iV > 0)
			{
				this.iV -= 10;
				base.Invalidate(false);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00009CC4 File Offset: 0x00007EC4
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.Clear(base.Parent.BackColor);
			checked
			{
				Point point = new Point(0, (int)Math.Round(unchecked((double)base.Height / 2.0 - (double)this.iZ.Height / 2.0)));
				Point point2 = new Point(0, (int)Math.Round(unchecked((double)base.Height / 2.0 + (double)this.iZ.Height / 2.0)));
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush(point, point2, Color.FromArgb(250, 250, 250), Color.FromArgb(240, 240, 240));
				this.iY = new Rectangle(8, 10, base.Width - 21, base.Height - 21);
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.FillPath(linearGradientBrush, (GraphicsPath)this.jn(0, (int)Math.Round(unchecked((double)base.Height / 2.0 - (double)this.iZ.Height / 2.0)), base.Width - 1, this.iZ.Height - 5, new iT.Ny
				{
					Nz = true,
					NA = true
				}));
				graphics.DrawPath(new Pen(Color.FromArgb(177, 177, 176)), (GraphicsPath)this.jn(0, (int)Math.Round(unchecked((double)base.Height / 2.0 - (double)this.iZ.Height / 2.0)), base.Width - 1, this.iZ.Height - 5, new iT.Ny
				{
					Nz = true,
					NA = true
				}));
				linearGradientBrush.Dispose();
				switch (this.iX)
				{
				case iT.NB.NC:
					if (this.jd)
					{
						graphics.DrawString("Yes", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.iY.X + 7), (float)this.iY.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawString("No", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.iY.X + 18), (float)this.iY.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					break;
				case iT.NB.ND:
					if (this.jd)
					{
						graphics.DrawString("On", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.iY.X + 7), (float)this.iY.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawString("Off", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.iY.X + 18), (float)this.iY.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					break;
				case iT.NB.NE:
					if (this.jd)
					{
						graphics.DrawString("I", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.iY.X + 7), (float)this.iY.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawString("O", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.iY.X + 18), (float)this.iY.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					break;
				}
				graphics.FillEllipse(new SolidBrush(Color.FromArgb(249, 249, 249)), this.iY.X + (int)Math.Round(unchecked((double)this.iY.Width * ((double)this.iV / 80.0))) - (int)Math.Round((double)this.iZ.Width / 2.0), this.iY.Y + (int)Math.Round((double)this.iY.Height / 2.0) - (int)Math.Round(unchecked((double)this.iZ.Height / 2.0 - 1.0)), this.iZ.Width, this.iZ.Height - 5);
				graphics.DrawEllipse(new Pen(Color.FromArgb(177, 177, 176)), this.iY.X + (int)Math.Round(unchecked((double)this.iY.Width * ((double)this.iV / 80.0) - (double)(checked((int)Math.Round((double)this.iZ.Width / 2.0))))), this.iY.Y + (int)Math.Round((double)this.iY.Height / 2.0) - (int)Math.Round(unchecked((double)this.iZ.Height / 2.0 - 1.0)), this.iZ.Width, this.iZ.Height - 5);
			}
		}

		// Token: 0x040000D7 RID: 215
		private System.Windows.Forms.Timer iU = new System.Windows.Forms.Timer
		{
			Interval = 1
		};

		// Token: 0x040000D8 RID: 216
		private int iV;

		// Token: 0x040000D9 RID: 217
		[CompilerGenerated]
		private iT.NF ToggledChanged;

		// Token: 0x040000DA RID: 218
		private bool iW;

		// Token: 0x040000DB RID: 219
		private iT.NB iX;

		// Token: 0x040000DC RID: 220
		private Rectangle iY;

		// Token: 0x040000DD RID: 221
		private Size iZ = new Size(15, 20);

		// Token: 0x0200002A RID: 42
		public class Ny
		{
			// Token: 0x040000DE RID: 222
			public bool Nz;

			// Token: 0x040000DF RID: 223
			public bool NA;
		}

		// Token: 0x0200002B RID: 43
		public enum NB
		{
			// Token: 0x040000E1 RID: 225
			NC,
			// Token: 0x040000E2 RID: 226
			ND,
			// Token: 0x040000E3 RID: 227
			NE
		}

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000165 RID: 357
		public delegate void NF();
	}
}
