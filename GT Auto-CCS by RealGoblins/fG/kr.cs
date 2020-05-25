using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000032 RID: 50
	[DefaultEvent("TextChanged")]
	internal class kr : Control
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000ADCC File Offset: 0x00008FCC
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public override string Text
		{
			get
			{
				return this.ks.Text;
			}
			set
			{
				this.ks.Text = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000ADF0 File Offset: 0x00008FF0
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000ADF8 File Offset: 0x00008FF8
		public bool jU
		{
			get
			{
				return this.jE;
			}
			set
			{
				this.jE = value;
				if (this.ks != null)
				{
					this.ks.ReadOnly = value;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000AE18 File Offset: 0x00009018
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000AE20 File Offset: 0x00009020
		public bool kz
		{
			get
			{
				return this.kt;
			}
			set
			{
				this.kt = value;
				if (this.ks != null)
				{
					this.ks.WordWrap = value;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000AE40 File Offset: 0x00009040
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0000AE48 File Offset: 0x00009048
		public bool kD
		{
			get
			{
				return this.ku;
			}
			set
			{
				this.ku = value;
				if (this.ks != null)
				{
					this.ks.AutoWordSelection = value;
				}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000AE68 File Offset: 0x00009068
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.ks.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000AE88 File Offset: 0x00009088
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.ks.Font = this.Font;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000AEA4 File Offset: 0x000090A4
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000AEB0 File Offset: 0x000090B0
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.ks.Size = new Size(base.Width - 13, base.Height - 11);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000AEDC File Offset: 0x000090DC
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.il = new GraphicsPath();
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000AF80 File Offset: 0x00009180
		public void kE(object sender, EventArgs e)
		{
			this.ks.Text = this.Text;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000AF94 File Offset: 0x00009194
		public void kH()
		{
			RichTextBox richTextBox = this.ks;
			richTextBox.BackColor = Color.Black;
			richTextBox.Size = new Size(base.Width - 10, 100);
			richTextBox.Location = new Point(7, 5);
			richTextBox.Text = string.Empty;
			richTextBox.BorderStyle = BorderStyle.None;
			richTextBox.Font = new Font("Tahoma", 10f);
			richTextBox.Multiline = true;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000B004 File Offset: 0x00009204
		public kr()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.kH();
			base.Controls.Add(this.ks);
			this.BackColor = Color.Black;
			this.ForeColor = Color.White;
			this.Text = null;
			this.Font = new Font("Tahoma", 10f);
			base.Size = new Size(150, 100);
			this.kz = true;
			this.kD = false;
			this.DoubleBuffered = true;
			base.TextChanged += this.kE;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000B0B8 File Offset: 0x000092B8
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.Clear(Color.Black);
			graphics.FillPath(Brushes.Black, this.il);
			graphics.DrawPath(new Pen(Color.FromArgb(255, 255, 255)), this.il);
			graphics.Dispose();
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x040000F8 RID: 248
		public RichTextBox ks = new RichTextBox();

		// Token: 0x040000F9 RID: 249
		private bool jE;

		// Token: 0x040000FA RID: 250
		private bool kt;

		// Token: 0x040000FB RID: 251
		private bool ku;

		// Token: 0x040000FC RID: 252
		private GraphicsPath il;
	}
}
