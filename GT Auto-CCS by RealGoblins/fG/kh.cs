using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000031 RID: 49
	[DefaultEvent("TextChanged")]
	internal class kh : Control
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000A8EC File Offset: 0x00008AEC
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000A8F4 File Offset: 0x00008AF4
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000A904 File Offset: 0x00008B04
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000A90C File Offset: 0x00008B0C
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A92C File Offset: 0x00008B2C
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000A934 File Offset: 0x00008B34
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000A954 File Offset: 0x00008B54
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000A95C File Offset: 0x00008B5C
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A97C File Offset: 0x00008B7C
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000A984 File Offset: 0x00008B84
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
						this.jC.Height = base.Height - 10;
						return;
					}
					base.Height = this.jC.Height + 10;
				}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			this.jC.Text = this.Text;
			base.Invalidate();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		private void ka(object sender, EventArgs e)
		{
			this.Text = this.jC.Text;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000AA0C File Offset: 0x00008C0C
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.jC.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000AA2C File Offset: 0x00008C2C
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.jC.Font = this.Font;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000AA48 File Offset: 0x00008C48
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000AA54 File Offset: 0x00008C54
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

		// Token: 0x06000193 RID: 403 RVA: 0x0000AAAC File Offset: 0x00008CAC
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.jF)
			{
				this.jC.Height = base.Height - 10;
			}
			else
			{
				base.Height = this.jC.Height + 10;
			}
			this.il = new GraphicsPath();
			GraphicsPath graphicsPath = this.il;
			graphicsPath.AddArc(0, 0, 10, 10, 180f, 90f);
			graphicsPath.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			graphicsPath.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			graphicsPath.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			graphicsPath.CloseAllFigures();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000AB80 File Offset: 0x00008D80
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.jC.Focus();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000AB98 File Offset: 0x00008D98
		public void kg()
		{
			TextBox textBox = this.jC;
			textBox.Size = new Size(base.Width - 10, 33);
			textBox.Location = new Point(7, 5);
			textBox.Text = string.Empty;
			textBox.BorderStyle = BorderStyle.None;
			textBox.TextAlign = HorizontalAlignment.Left;
			textBox.Font = new Font("Tahoma", 11f);
			textBox.UseSystemPasswordChar = this.jQ;
			textBox.Multiline = false;
			this.jC.KeyDown += this.kd;
			this.jC.TextChanged += this.ka;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000AC3C File Offset: 0x00008E3C
		public kh()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.kg();
			base.Controls.Add(this.jC);
			this.bh = new Pen(Color.FromArgb(36, 36, 36));
			this.bj = new SolidBrush(Color.FromArgb(36, 36, 36));
			this.BackColor = Color.FromArgb(36, 36, 36);
			this.ForeColor = Color.FromArgb(36, 36, 36);
			this.Text = null;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(135, 33);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000AD14 File Offset: 0x00008F14
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			TextBox textBox = this.jC;
			textBox.Width = base.Width - 10;
			textBox.TextAlign = this.iE;
			textBox.UseSystemPasswordChar = this.jQ;
			graphics.Clear(Color.FromArgb(36, 36, 36));
			graphics.FillPath(this.bj, this.il);
			graphics.DrawPath(this.bh, this.il);
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040000EF RID: 239
		public TextBox jC = new TextBox();

		// Token: 0x040000F0 RID: 240
		private GraphicsPath il;

		// Token: 0x040000F1 RID: 241
		private int jD = 32767;

		// Token: 0x040000F2 RID: 242
		private bool jE;

		// Token: 0x040000F3 RID: 243
		private bool jF;

		// Token: 0x040000F4 RID: 244
		private HorizontalAlignment jG;

		// Token: 0x040000F5 RID: 245
		private bool jH;

		// Token: 0x040000F6 RID: 246
		private Pen bh;

		// Token: 0x040000F7 RID: 247
		private SolidBrush bj;
	}
}
