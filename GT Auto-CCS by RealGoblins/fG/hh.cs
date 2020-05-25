using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000023 RID: 35
	public class hh : ContainerControl
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00007A3C File Offset: 0x00005C3C
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00007A44 File Offset: 0x00005C44
		public bool hF
		{
			get
			{
				return this.hp;
			}
			set
			{
				this.hp = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00007A50 File Offset: 0x00005C50
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00007A58 File Offset: 0x00005C58
		public bool hJ
		{
			get
			{
				return this.hq;
			}
			set
			{
				this.hq = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00007A64 File Offset: 0x00005C64
		protected bool hL
		{
			get
			{
				return this.hr;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00007A6C File Offset: 0x00005C6C
		protected bool hN
		{
			get
			{
				return base.Parent != null && base.Parent.Parent != null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00007A88 File Offset: 0x00005C88
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00007A90 File Offset: 0x00005C90
		protected bool hR
		{
			get
			{
				return this.hs;
			}
			set
			{
				this.hs = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00007AA0 File Offset: 0x00005CA0
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public FormStartPosition hV
		{
			get
			{
				if (this.hr && !this.hs)
				{
					return base.ParentForm.StartPosition;
				}
				return this.ht;
			}
			set
			{
				this.ht = value;
				if (this.hr && !this.hs)
				{
					base.ParentForm.StartPosition = value;
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007AF4 File Offset: 0x00005CF4
		protected sealed override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
			if (base.Parent == null)
			{
				return;
			}
			this.hr = (base.Parent is Form);
			if (!this.hs)
			{
				this.id();
				if (this.hr)
				{
					base.ParentForm.FormBorderStyle = FormBorderStyle.None;
					base.ParentForm.TransparencyKey = Color.Fuchsia;
					if (!base.DesignMode)
					{
						base.ParentForm.Shown += this.hW;
					}
				}
				base.Parent.BackColor = this.BackColor;
				base.Parent.MinimumSize = new Size(126, 39);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00007B9C File Offset: 0x00005D9C
		protected sealed override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (!this.hs)
			{
				this.ho = new Rectangle(0, 0, base.Width - 14, this.hk - 7);
			}
			base.Invalidate();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00007BDC File Offset: 0x00005DDC
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (e.Button == MouseButtons.Left)
			{
				this.hZ(hh.Nt.Nw);
			}
			if ((!this.hr || base.ParentForm.WindowState != FormWindowState.Maximized) && !this.hs)
			{
				if (this.ho.Contains(e.Location))
				{
					base.Capture = false;
					this.hB = true;
					this.DefWndProc(ref this.hA[0]);
					return;
				}
				if (this.hp && this.hz != 0)
				{
					base.Capture = false;
					this.hB = true;
					this.DefWndProc(ref this.hA[this.hz]);
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00007C8C File Offset: 0x00005E8C
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.hj = false;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00007C9C File Offset: 0x00005E9C
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if ((!this.hr || base.ParentForm.WindowState != FormWindowState.Maximized) && this.hp && !this.hs)
			{
				this.ic();
			}
			if (this.hj)
			{
				base.Parent.Location = (Point)(Convert.ToDouble(Control.MousePosition) - Convert.ToDouble(this.hi));
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00007D1C File Offset: 0x00005F1C
		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);
			base.ParentForm.Text = this.Text;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007D38 File Offset: 0x00005F38
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00007D44 File Offset: 0x00005F44
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007D54 File Offset: 0x00005F54
		private void hW(object sender, EventArgs e)
		{
			if (!this.hs && !this.hn)
			{
				if (this.ht == FormStartPosition.CenterParent || this.ht == FormStartPosition.CenterScreen)
				{
					Rectangle bounds = Screen.PrimaryScreen.Bounds;
					Rectangle bounds2 = base.ParentForm.Bounds;
					base.ParentForm.Location = new Point(bounds.Width / 2 - bounds2.Width / 2, bounds.Height / 2 - bounds2.Width / 2);
				}
				this.hn = true;
				return;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00007DD8 File Offset: 0x00005FD8
		private void hZ(hh.Nt ia)
		{
			this.bE = ia;
			base.Invalidate();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007DE8 File Offset: 0x00005FE8
		private int ib()
		{
			this.hu = base.PointToClient(Control.MousePosition);
			this.hv = (this.hu.X < 7);
			this.hw = (this.hu.X > base.Width - 7);
			this.hx = (this.hu.Y < 7);
			this.hy = (this.hu.Y > base.Height - 7);
			if (this.hv && this.hx)
			{
				return 4;
			}
			if (this.hv && this.hy)
			{
				return 7;
			}
			if (this.hw && this.hx)
			{
				return 5;
			}
			if (this.hw && this.hy)
			{
				return 8;
			}
			if (this.hv)
			{
				return 1;
			}
			if (this.hw)
			{
				return 2;
			}
			if (this.hx)
			{
				return 3;
			}
			if (this.hy)
			{
				return 6;
			}
			return 0;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00007ED8 File Offset: 0x000060D8
		private void ic()
		{
			this.af = this.ib();
			if (this.af == this.hz)
			{
				return;
			}
			this.hz = this.af;
			int num = this.hz;
			if (num == 0)
			{
				this.Cursor = Cursors.Default;
				return;
			}
			switch (num)
			{
			case 6:
				this.Cursor = Cursors.SizeNS;
				return;
			case 7:
				this.Cursor = Cursors.SizeNESW;
				return;
			case 8:
				this.Cursor = Cursors.SizeNWSE;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00007F5C File Offset: 0x0000615C
		private void id()
		{
			this.hA[0] = Message.Create(base.Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
			for (int i = 1; i <= 8; i++)
			{
				this.hA[i] = Message.Create(base.Parent.Handle, 161, new IntPtr(i + 9), IntPtr.Zero);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00007FD0 File Offset: 0x000061D0
		private void ie(Rectangle @if)
		{
			if (base.Parent.Width > @if.Width)
			{
				base.Parent.Width = @if.Width;
			}
			if (base.Parent.Height > @if.Height)
			{
				base.Parent.Height = @if.Height;
			}
			int num = base.Parent.Location.X;
			int num2 = base.Parent.Location.Y;
			if (num < @if.X)
			{
				num = @if.X;
			}
			if (num2 < @if.Y)
			{
				num2 = @if.Y;
			}
			int num3 = @if.X + @if.Width;
			int num4 = @if.Y + @if.Height;
			if (num + base.Parent.Width > num3)
			{
				num = num3 - base.Parent.Width;
			}
			if (num2 + base.Parent.Height > num4)
			{
				num2 = num4 - base.Parent.Height;
			}
			base.Parent.Location = new Point(num, num2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000080E8 File Offset: 0x000062E8
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (this.hB && m.Msg == 513)
			{
				this.hB = false;
				this.hZ(hh.Nt.Nv);
				if (!this.hq)
				{
					return;
				}
				if (this.hN)
				{
					this.ie(new Rectangle(Point.Empty, base.Parent.Parent.Size));
					return;
				}
				this.ie(Screen.FromControl(base.Parent).WorkingArea);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008168 File Offset: 0x00006368
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			base.ParentForm.FormBorderStyle = FormBorderStyle.None;
			base.ParentForm.TransparencyKey = Color.Fuchsia;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000818C File Offset: 0x0000638C
		protected override void CreateHandle()
		{
			base.CreateHandle();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008194 File Offset: 0x00006394
		public hh()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.Dock = DockStyle.Fill;
			this.hk = 25;
			base.Padding = new Padding(3, 28, 3, 28);
			this.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
			this.ForeColor = Color.FromArgb(142, 142, 142);
			this.BackColor = Color.FromArgb(246, 246, 246);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008248 File Offset: 0x00006448
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Rectangle fI = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
			Color transparencyKey = base.ParentForm.TransparencyKey;
			graphics.SmoothingMode = SmoothingMode.Default;
			graphics.Clear(transparencyKey);
			graphics.FillPath(new SolidBrush(Color.FromArgb(52, 52, 52)), fF.fH(fI, 7));
			graphics.FillPath(new SolidBrush(Color.FromArgb(246, 246, 246)), fF.fH(new Rectangle(2, 20, base.Width - 5, base.Height - 42), 7));
			graphics.FillPath(new SolidBrush(Color.FromArgb(52, 52, 52)), fF.fH(new Rectangle(2, 2, base.Width / 2 + 2, 16), 7));
			graphics.FillPath(new SolidBrush(Color.FromArgb(52, 52, 52)), fF.fH(new Rectangle(base.Width / 2 - 3, 2, base.Width / 2, 16), 7));
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 52, 52)), new Rectangle(2, 15, base.Width - 5, 10));
			graphics.DrawPath(new Pen(Color.FromArgb(52, 52, 52)), fF.fH(new Rectangle(2, 2, base.Width - 5, base.Height - 5), 7));
			graphics.DrawPath(new Pen(Color.FromArgb(52, 52, 52)), fF.fH(fI, 7));
			graphics.DrawString(this.Text, new Font("Trebuchet MS", 10f, FontStyle.Bold), new SolidBrush(Color.FromArgb(221, 221, 221)), new Rectangle(7, 3, base.Width - 1, 22), new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Near
			});
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 52, 52)), 0, base.Height - 25, base.Width - 3, 20);
			graphics.DrawLine(new Pen(Color.FromArgb(52, 52, 52)), 5, base.Height - 5, base.Width - 6, base.Height - 5);
			graphics.DrawLine(new Pen(Color.FromArgb(52, 52, 52)), 7, base.Height - 4, base.Width - 7, base.Height - 4);
			graphics.DrawString(this.hl, new Font("Trebuchet MS", 10f, FontStyle.Bold), new SolidBrush(Color.FromArgb(221, 221, 221)), 5f, (float)(base.Height - 23));
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x0400009B RID: 155
		private Point hi = new Point(0, 0);

		// Token: 0x0400009C RID: 156
		private bool hj;

		// Token: 0x0400009D RID: 157
		private int hk;

		// Token: 0x0400009E RID: 158
		private string hl;

		// Token: 0x0400009F RID: 159
		private const int hm = 7;

		// Token: 0x040000A0 RID: 160
		protected hh.Nt bE;

		// Token: 0x040000A1 RID: 161
		private bool hn;

		// Token: 0x040000A2 RID: 162
		private Rectangle ho;

		// Token: 0x040000A3 RID: 163
		private bool hp = true;

		// Token: 0x040000A4 RID: 164
		private bool hq;

		// Token: 0x040000A5 RID: 165
		private bool hr;

		// Token: 0x040000A6 RID: 166
		private bool hs;

		// Token: 0x040000A7 RID: 167
		private FormStartPosition ht;

		// Token: 0x040000A8 RID: 168
		private Point hu;

		// Token: 0x040000A9 RID: 169
		private bool hv;

		// Token: 0x040000AA RID: 170
		private bool hw;

		// Token: 0x040000AB RID: 171
		private bool hx;

		// Token: 0x040000AC RID: 172
		private bool hy;

		// Token: 0x040000AD RID: 173
		private int af;

		// Token: 0x040000AE RID: 174
		private int hz;

		// Token: 0x040000AF RID: 175
		private Message[] hA = new Message[9];

		// Token: 0x040000B0 RID: 176
		private bool hB;

		// Token: 0x02000024 RID: 36
		public enum Nt
		{
			// Token: 0x040000B2 RID: 178
			Nu,
			// Token: 0x040000B3 RID: 179
			Nv,
			// Token: 0x040000B4 RID: 180
			Nw
		}
	}
}
