using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000030 RID: 48
	[DefaultEvent("TextChanged")]
	internal class jB : Control
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000A370 File Offset: 0x00008570
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000A378 File Offset: 0x00008578
		public HorizontalAlignment iE
		{
			get
			{
				return this.jG;
			}
			set
			{
				this.jG = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000A388 File Offset: 0x00008588
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000A390 File Offset: 0x00008590
		public int jM
		{
			get
			{
				return this.jD;
			}
			set
			{
				this.jD = value;
				this.jC.MaxLength = this.jM;
				base.Invalidate();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000A3B0 File Offset: 0x000085B0
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public bool jQ
		{
			get
			{
				return this.jH;
			}
			set
			{
				this.jC.UseSystemPasswordChar = this.jQ;
				this.jH = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000A3D8 File Offset: 0x000085D8
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000A3E0 File Offset: 0x000085E0
		public bool jU
		{
			get
			{
				return this.jE;
			}
			set
			{
				this.jE = value;
				if (this.jC != null)
				{
					this.jC.ReadOnly = value;
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000A400 File Offset: 0x00008600
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000A408 File Offset: 0x00008608
		public bool jY
		{
			get
			{
				return this.jF;
			}
			set
			{
				this.jF = value;
				if (this.jC != null)
				{
					this.jC.Multiline = value;
					if (value)
					{
						this.jC.Height = base.Height - 23;
						return;
					}
					base.Height = this.jC.Height + 23;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000A45C File Offset: 0x0000865C
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000A464 File Offset: 0x00008664
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
				if (this.ax == null)
				{
					this.jC.Location = new Point(8, 10);
				}
				else
				{
					this.jC.Location = new Point(35, 11);
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000A4CC File Offset: 0x000086CC
		protected Size iw
		{
			get
			{
				return this.iq;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000A4D4 File Offset: 0x000086D4
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			this.jC.Text = this.Text;
			base.Invalidate();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000A4F4 File Offset: 0x000086F4
		private void ka(object sender, EventArgs e)
		{
			this.Text = this.jC.Text;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000A508 File Offset: 0x00008708
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.jC.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000A528 File Offset: 0x00008728
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.jC.Font = this.Font;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000A544 File Offset: 0x00008744
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000A550 File Offset: 0x00008750
		private void kd(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				this.jC.SelectAll();
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				this.jC.Copy();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000A5A8 File Offset: 0x000087A8
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.jF)
			{
				this.jC.Height = base.Height - 23;
			}
			else
			{
				base.Height = this.jC.Height + 23;
			}
			this.il = new GraphicsPath();
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000A67C File Offset: 0x0000887C
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.jC.Focus();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000A694 File Offset: 0x00008894
		public void kg()
		{
			TextBox textBox = this.jC;
			textBox.Location = new Point(7, 10);
			textBox.Text = string.Empty;
			textBox.BorderStyle = BorderStyle.None;
			textBox.TextAlign = HorizontalAlignment.Left;
			textBox.Font = new Font("Tahoma", 11f);
			textBox.UseSystemPasswordChar = this.jQ;
			textBox.Multiline = false;
			this.jC.KeyDown += this.kd;
			this.jC.TextChanged += this.ka;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000A724 File Offset: 0x00008924
		public jB()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.kg();
			base.Controls.Add(this.jC);
			this.bh = new Pen(Color.FromArgb(180, 180, 180));
			this.bj = new SolidBrush(Color.White);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.DimGray;
			this.Text = null;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(135, 43);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000A7F4 File Offset: 0x000089F4
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (this.ax == null)
			{
				this.jC.Width = base.Width - 18;
			}
			else
			{
				this.jC.Width = base.Width - 45;
			}
			this.jC.TextAlign = this.iE;
			this.jC.UseSystemPasswordChar = this.jQ;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(this.bj, this.il);
			graphics.DrawPath(this.bh, this.il);
			if (this.ax != null)
			{
				graphics.DrawImage(this.aj, 5, 8, 24, 24);
			}
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040000E4 RID: 228
		public TextBox jC = new TextBox();

		// Token: 0x040000E5 RID: 229
		private GraphicsPath il;

		// Token: 0x040000E6 RID: 230
		private int jD = 32767;

		// Token: 0x040000E7 RID: 231
		private bool jE;

		// Token: 0x040000E8 RID: 232
		private bool jF;

		// Token: 0x040000E9 RID: 233
		private Image aj;

		// Token: 0x040000EA RID: 234
		private Size iq;

		// Token: 0x040000EB RID: 235
		private HorizontalAlignment jG;

		// Token: 0x040000EC RID: 236
		private bool jH;

		// Token: 0x040000ED RID: 237
		private Pen bh;

		// Token: 0x040000EE RID: 238
		private SolidBrush bj;
	}
}
