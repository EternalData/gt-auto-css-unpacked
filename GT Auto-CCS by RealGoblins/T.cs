using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000007 RID: 7
internal abstract class T : ContainerControl
{
	// Token: 0x0600001C RID: 28 RVA: 0x00002A30 File Offset: 0x00000C30
	public T()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint, true);
		this.U = new Bitmap(1, 1);
		this.V = Graphics.FromImage(this.U);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002A7C File Offset: 0x00000C7C
	protected override void OnHandleCreated(EventArgs e)
	{
		this.Dock = DockStyle.Fill;
		this.W = (base.Parent is Form);
		if (this.W)
		{
			base.ParentForm.FormBorderStyle = FormBorderStyle.None;
		}
		base.OnHandleCreated(e);
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001E RID: 30 RVA: 0x00002AC0 File Offset: 0x00000CC0
	// (set) Token: 0x0600001F RID: 31 RVA: 0x00002AC8 File Offset: 0x00000CC8
	public bool an
	{
		get
		{
			return this.X;
		}
		set
		{
			this.X = value;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000020 RID: 32 RVA: 0x00002AD4 File Offset: 0x00000CD4
	// (set) Token: 0x06000021 RID: 33 RVA: 0x00002ADC File Offset: 0x00000CDC
	public int ar
	{
		get
		{
			return this.Y;
		}
		set
		{
			this.Y = value;
			this.ah = new Rectangle(7, 7, base.Width - 14, this.Y);
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002B04 File Offset: 0x00000D04
	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		if (this.W && base.ParentForm.WindowState == FormWindowState.Maximized)
		{
			return;
		}
		if (this.ah.Contains(e.Location))
		{
			this.Z = new IntPtr(2);
		}
		else
		{
			if (this.af.MI == 0 | !this.X)
			{
				return;
			}
			this.Z = new IntPtr((int)this.af.MI);
		}
		base.Capture = false;
		Message message = Message.Create(base.Parent.Handle, 161, this.Z, IntPtr.Zero);
		this.DefWndProc(ref message);
		base.OnMouseDown(e);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002BC0 File Offset: 0x00000DC0
	private T.MG ay()
	{
		this.ae = base.PointToClient(Control.MousePosition);
		this.aa = (this.ae.X < 7);
		this.ab = (this.ae.X > base.Width - 7);
		this.ac = (this.ae.Y < 7);
		this.ad = (this.ae.Y > base.Height - 7);
		if (this.aa & this.ac)
		{
			return new T.MG(Cursors.SizeNWSE, 13);
		}
		if (this.aa & this.ad)
		{
			return new T.MG(Cursors.SizeNESW, 16);
		}
		if (this.ab & this.ac)
		{
			return new T.MG(Cursors.SizeNESW, 14);
		}
		if (this.ab & this.ad)
		{
			return new T.MG(Cursors.SizeNWSE, 17);
		}
		if (this.aa)
		{
			return new T.MG(Cursors.SizeWE, 10);
		}
		if (this.ab)
		{
			return new T.MG(Cursors.SizeWE, 11);
		}
		if (this.ac)
		{
			return new T.MG(Cursors.SizeNS, 12);
		}
		if (this.ad)
		{
			return new T.MG(Cursors.SizeNS, 15);
		}
		return new T.MG(Cursors.Default, 0);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002D0C File Offset: 0x00000F0C
	private void az()
	{
		this.ag = this.ay();
		if (this.af.MI == this.ag.MI)
		{
			return;
		}
		this.af = this.ay();
		this.Cursor = this.af.MH;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002D5C File Offset: 0x00000F5C
	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (this.X)
		{
			this.az();
		}
		base.OnMouseMove(e);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002D74 File Offset: 0x00000F74
	protected override void OnSizeChanged(EventArgs e)
	{
		this.ah = new Rectangle(7, 7, base.Width - 14, this.Y);
		this.V.Dispose();
		this.U.Dispose();
		this.U = new Bitmap(base.Width, base.Height);
		this.V = Graphics.FromImage(this.U);
		base.Invalidate();
		base.OnSizeChanged(e);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002DE8 File Offset: 0x00000FE8
	public void aA(Color aB)
	{
		if (this.W)
		{
			base.ParentForm.TransparencyKey = aB;
		}
	}

	// Token: 0x06000028 RID: 40
	protected abstract override void OnPaint(PaintEventArgs e);

	// Token: 0x06000029 RID: 41 RVA: 0x00002E00 File Offset: 0x00001000
	public void aC(Color aD, Rectangle aE)
	{
		this.U.SetPixel(aE.X, aE.Y, aD);
		this.U.SetPixel(aE.X + (aE.Width - 1), aE.Y, aD);
		this.U.SetPixel(aE.X, aE.Y + (aE.Height - 1), aD);
		this.U.SetPixel(aE.X + (aE.Width - 1), aE.Y + (aE.Height - 1), aD);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002EA0 File Offset: 0x000010A0
	public void aF(Pen aG, Pen aH, Rectangle aI)
	{
		this.V.DrawRectangle(aG, aI.X, aI.Y, aI.Width - 1, aI.Height - 1);
		this.V.DrawRectangle(aH, aI.X + 1, aI.Y + 1, aI.Width - 3, aI.Height - 3);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002F0C File Offset: 0x0000110C
	public void aJ(HorizontalAlignment aK, Brush aL, int aM = 0)
	{
		if (string.IsNullOrEmpty(this.Text))
		{
			return;
		}
		this.ai = this.V.MeasureString(this.Text, this.Font).ToSize();
		switch (aK)
		{
		case HorizontalAlignment.Left:
			this.V.DrawString(this.Text, this.Font, aL, (float)(5 + aM), (float)(this.Y / 2 - this.ai.Height / 2 + 7));
			return;
		case HorizontalAlignment.Right:
			this.V.DrawString(this.Text, this.Font, aL, (float)(base.Width - 5 - this.ai.Width - aM), (float)(this.Y / 2 - this.ai.Height / 2 + 7));
			return;
		case HorizontalAlignment.Center:
			this.V.DrawString(this.Text, this.Font, aL, (float)(base.Width / 2 - this.ai.Width / 2), (float)(this.Y / 2 - this.ai.Height / 2 + 7));
			return;
		default:
			return;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600002C RID: 44 RVA: 0x00003028 File Offset: 0x00001228
	public int at
	{
		get
		{
			if (this.aj == null)
			{
				return 0;
			}
			return this.aj.Width;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600002D RID: 45 RVA: 0x00003040 File Offset: 0x00001240
	// (set) Token: 0x0600002E RID: 46 RVA: 0x00003048 File Offset: 0x00001248
	public Image ax
	{
		get
		{
			return this.aj;
		}
		set
		{
			this.aj = value;
			base.Invalidate();
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003058 File Offset: 0x00001258
	public void aN(HorizontalAlignment aO, int aP = 0)
	{
		if (this.aj == null)
		{
			return;
		}
		switch (aO)
		{
		case HorizontalAlignment.Left:
			this.V.DrawImage(this.aj, 5 + aP, this.Y / 2 - this.aj.Height / 2 + 7);
			return;
		case HorizontalAlignment.Right:
			this.V.DrawImage(this.aj, base.Width - 5 - this.ai.Width - aP, this.Y / 2 - this.ai.Height / 2 + 7);
			return;
		case HorizontalAlignment.Center:
			this.V.DrawImage(this.aj, base.Width / 2 - this.ai.Width / 2, this.Y / 2 - this.ai.Height / 2 + 7);
			return;
		default:
			return;
		}
	}

	// Token: 0x0400000F RID: 15
	protected Bitmap U;

	// Token: 0x04000010 RID: 16
	protected Graphics V;

	// Token: 0x04000011 RID: 17
	private bool W;

	// Token: 0x04000012 RID: 18
	private bool X = true;

	// Token: 0x04000013 RID: 19
	private int Y = 24;

	// Token: 0x04000014 RID: 20
	private IntPtr Z;

	// Token: 0x04000015 RID: 21
	private bool aa;

	// Token: 0x04000016 RID: 22
	private bool ab;

	// Token: 0x04000017 RID: 23
	private bool ac;

	// Token: 0x04000018 RID: 24
	private bool ad;

	// Token: 0x04000019 RID: 25
	private Point ae;

	// Token: 0x0400001A RID: 26
	private T.MG af;

	// Token: 0x0400001B RID: 27
	private T.MG ag;

	// Token: 0x0400001C RID: 28
	protected Rectangle ah;

	// Token: 0x0400001D RID: 29
	private Size ai;

	// Token: 0x0400001E RID: 30
	private Image aj;

	// Token: 0x02000008 RID: 8
	private struct MG
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003130 File Offset: 0x00001330
		public MG(Cursor c, byte p)
		{
			this.MH = c;
			this.MI = p;
		}

		// Token: 0x0400001F RID: 31
		public readonly Cursor MH;

		// Token: 0x04000020 RID: 32
		public readonly byte MI;
	}
}
