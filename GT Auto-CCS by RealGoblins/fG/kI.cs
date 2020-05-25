using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000033 RID: 51
	public class kI : Control
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000B150 File Offset: 0x00009350
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000B158 File Offset: 0x00009358
		public long bL
		{
			get
			{
				return this.bG;
			}
			set
			{
				if (value <= this.bH & value >= this.kJ)
				{
					this.bG = value;
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000B184 File Offset: 0x00009384
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000B18C File Offset: 0x0000938C
		public long kS
		{
			get
			{
				return this.kJ;
			}
			set
			{
				if (value < this.bH)
				{
					this.kJ = value;
				}
				if (this.bG < this.kJ)
				{
					this.bG = this.kS;
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000B1CC File Offset: 0x000093CC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000B1D4 File Offset: 0x000093D4
		public long bP
		{
			get
			{
				return this.bH;
			}
			set
			{
				if (value > this.kJ)
				{
					this.bH = value;
				}
				if (this.bG > this.bH)
				{
					this.bG = this.bH;
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000B214 File Offset: 0x00009414
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000B21C File Offset: 0x0000941C
		public kI.NH iE
		{
			get
			{
				return this.kN;
			}
			set
			{
				this.kN = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000B22C File Offset: 0x0000942C
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 28;
			this.il = new GraphicsPath();
			this.il.AddArc(0, 0, 10, 10, 180f, 90f);
			this.il.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			this.il.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			this.il.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			this.il.CloseAllFigures();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000B2EC File Offset: 0x000094EC
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.kK = e.Location.X;
			this.kL = e.Location.Y;
			base.Invalidate();
			if (e.X < base.Width - 24)
			{
				this.Cursor = Cursors.IBeam;
				return;
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000B358 File Offset: 0x00009558
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			if (this.kK > base.Width - 23 && this.kK < base.Width - 3)
			{
				if (this.kL < 15)
				{
					if (this.bL + 1L <= this.bH)
					{
						this.bG += 1L;
					}
				}
				else if (this.bL - 1L >= this.kJ)
				{
					this.bG -= 1L;
				}
			}
			else
			{
				this.kM = !this.kM;
				base.Focus();
			}
			base.Invalidate();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000B414 File Offset: 0x00009614
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			try
			{
				if (this.kM)
				{
					this.bG = long.Parse(this.bG.ToString() + e.KeyChar.ToString().ToString());
				}
				if (this.bG > this.bH)
				{
					this.bG = this.bH;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000B490 File Offset: 0x00009690
		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (e.KeyCode == Keys.Back)
			{
				string text = this.bG.ToString();
				text = text.Remove(Convert.ToInt32(text.Length - 1));
				if (text.Length == 0)
				{
					text = "0";
				}
				this.bG = (long)Convert.ToInt32(text);
			}
			base.Invalidate();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000B4F0 File Offset: 0x000096F0
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			base.OnMouseWheel(e);
			if (e.Delta > 0)
			{
				if (this.bL + 1L <= this.bH)
				{
					this.bG += 1L;
				}
				base.Invalidate();
				return;
			}
			if (this.bL - 1L >= this.kJ)
			{
				this.bG -= 1L;
			}
			base.Invalidate();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000B578 File Offset: 0x00009778
		public kI()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.bh = new Pen(Color.FromArgb(180, 180, 180));
			this.bj = new SolidBrush(Color.White);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.DimGray;
			this.kJ = 0L;
			this.bH = 100L;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(70, 28);
			this.MinimumSize = new Size(62, 28);
			this.DoubleBuffered = true;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000B63C File Offset: 0x0000983C
		public void kV(int kW)
		{
			this.bG += (long)kW;
			base.Invalidate();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000B654 File Offset: 0x00009854
		public void kX(int kY)
		{
			this.bG -= (long)kY;
			base.Invalidate();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000B66C File Offset: 0x0000986C
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(this.bj, this.il);
			graphics.DrawPath(this.bh, this.il);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(base.Width - 23, 4, 19, 19), Color.FromArgb(241, 241, 241), Color.FromArgb(241, 241, 241), 90f);
			graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle);
			graphics.DrawRectangle(new Pen(Color.FromArgb(252, 252, 252)), new Rectangle(base.Width - 22, 5, 17, 17));
			graphics.DrawRectangle(new Pen(Color.FromArgb(180, 180, 180)), new Rectangle(base.Width - 23, 4, 19, 19));
			graphics.DrawLine(new Pen(Color.FromArgb(250, 252, 250)), new Point(base.Width - 22, base.Height - 16), new Point(base.Width - 5, base.Height - 16));
			graphics.DrawLine(new Pen(Color.FromArgb(180, 180, 180)), new Point(base.Width - 22, base.Height - 15), new Point(base.Width - 5, base.Height - 15));
			graphics.DrawLine(new Pen(Color.FromArgb(250, 250, 250)), new Point(base.Width - 22, base.Height - 14), new Point(base.Width - 5, base.Height - 14));
			graphics.DrawString("+", new Font("Tahoma", 8f), Brushes.Gray, (float)(base.Width - 19), (float)(base.Height - 26));
			graphics.DrawString("-", new Font("Tahoma", 12f), Brushes.Gray, (float)(base.Width - 19), (float)(base.Height - 20));
			kI.NH nh = this.kN;
			if (nh != kI.NH.NI)
			{
				if (nh == kI.NH.NJ)
				{
					graphics.DrawString(Convert.ToString(this.bL), this.Font, new SolidBrush(this.ForeColor), new Rectangle(0, 0, base.Width - 1, base.Height - 1), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
			}
			else
			{
				graphics.DrawString(Convert.ToString(this.bL), this.Font, new SolidBrush(this.ForeColor), new Rectangle(5, 0, base.Width - 1, base.Height - 1), new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Center
				});
			}
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040000FD RID: 253
		private GraphicsPath il;

		// Token: 0x040000FE RID: 254
		private Pen bh;

		// Token: 0x040000FF RID: 255
		private SolidBrush bj;

		// Token: 0x04000100 RID: 256
		private long bG;

		// Token: 0x04000101 RID: 257
		private long kJ;

		// Token: 0x04000102 RID: 258
		private long bH;

		// Token: 0x04000103 RID: 259
		private int kK;

		// Token: 0x04000104 RID: 260
		private int kL;

		// Token: 0x04000105 RID: 261
		private bool kM;

		// Token: 0x04000106 RID: 262
		private kI.NH kN;

		// Token: 0x02000034 RID: 52
		public enum NH
		{
			// Token: 0x04000108 RID: 264
			NI,
			// Token: 0x04000109 RID: 265
			NJ
		}
	}
}
