using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000009 RID: 9
internal abstract class aQ : Control
{
	// Token: 0x06000031 RID: 49 RVA: 0x00003140 File Offset: 0x00001340
	public aQ()
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint, true);
		this.U = new Bitmap(1, 1);
		this.V = Graphics.FromImage(this.U);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00003174 File Offset: 0x00001374
	public void aT()
	{
		base.SetStyle(ControlStyles.Opaque, false);
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0000318C File Offset: 0x0000138C
	protected override void OnMouseLeave(EventArgs e)
	{
		this.aU(aQ.MJ.MK);
		base.OnMouseLeave(e);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0000319C File Offset: 0x0000139C
	protected override void OnMouseEnter(EventArgs e)
	{
		this.aU(aQ.MJ.ML);
		base.OnMouseEnter(e);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000031AC File Offset: 0x000013AC
	protected override void OnMouseUp(MouseEventArgs e)
	{
		this.aU(aQ.MJ.ML);
		base.OnMouseUp(e);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000031BC File Offset: 0x000013BC
	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			this.aU(aQ.MJ.MM);
		}
		base.OnMouseDown(e);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000031DC File Offset: 0x000013DC
	private void aU(aQ.MJ aV)
	{
		this.aR = aV;
		base.Invalidate();
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000031EC File Offset: 0x000013EC
	protected override void OnSizeChanged(EventArgs e)
	{
		this.V.Dispose();
		this.U.Dispose();
		this.U = new Bitmap(base.Width, base.Height);
		this.V = Graphics.FromImage(this.U);
		base.Invalidate();
		base.OnSizeChanged(e);
	}

	// Token: 0x06000039 RID: 57
	protected abstract override void OnPaint(PaintEventArgs e);

	// Token: 0x0600003A RID: 58 RVA: 0x00003244 File Offset: 0x00001444
	public void aC(Color aW, Rectangle aX)
	{
		this.U.SetPixel(aX.X, aX.Y, aW);
		this.U.SetPixel(aX.X + (aX.Width - 1), aX.Y, aW);
		this.U.SetPixel(aX.X, aX.Y + (aX.Height - 1), aW);
		this.U.SetPixel(aX.X + (aX.Width - 1), aX.Y + (aX.Height - 1), aW);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000032E4 File Offset: 0x000014E4
	public void aF(Pen aY, Pen aZ, Rectangle ba)
	{
		this.V.DrawRectangle(aY, ba.X, ba.Y, ba.Width - 1, ba.Height - 1);
		this.V.DrawRectangle(aZ, ba.X + 1, ba.Y + 1, ba.Width - 3, ba.Height - 3);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003350 File Offset: 0x00001550
	public void aJ(HorizontalAlignment bb, Brush bc, int bd = 0)
	{
		if (string.IsNullOrEmpty(this.Text))
		{
			return;
		}
		this.ai = this.V.MeasureString(this.Text, this.Font).ToSize();
		switch (bb)
		{
		case HorizontalAlignment.Left:
			this.V.DrawString(this.Text, this.Font, bc, (float)(5 + bd), (float)(base.Height / 2 - this.ai.Height / 2));
			return;
		case HorizontalAlignment.Right:
			this.V.DrawString(this.Text, this.Font, bc, (float)(base.Width - 5 - this.ai.Width - bd), (float)(base.Height / 2 - this.ai.Height / 2));
			return;
		case HorizontalAlignment.Center:
			this.V.DrawString(this.Text, this.Font, bc, (float)(base.Width / 2 - this.ai.Width / 2), (float)(base.Height / 2 - this.ai.Height / 2));
			return;
		default:
			return;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600003D RID: 61 RVA: 0x00003464 File Offset: 0x00001664
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

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600003E RID: 62 RVA: 0x0000347C File Offset: 0x0000167C
	// (set) Token: 0x0600003F RID: 63 RVA: 0x00003484 File Offset: 0x00001684
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

	// Token: 0x06000040 RID: 64 RVA: 0x00003494 File Offset: 0x00001694
	public void aN(HorizontalAlignment be, int bf = 0)
	{
		if (this.aj == null)
		{
			return;
		}
		switch (be)
		{
		case HorizontalAlignment.Left:
			this.V.DrawImage(this.aj, base.Width / 10 + bf, base.Height / 2 - this.aj.Height / 2);
			return;
		case HorizontalAlignment.Right:
			this.V.DrawImage(this.aj, base.Width - base.Width / 10 - this.ai.Width - bf, base.Height / 2 - this.ai.Height / 2);
			return;
		case HorizontalAlignment.Center:
			this.V.DrawImage(this.aj, base.Width / 2 - this.ai.Width / 2, base.Height / 2 - this.ai.Height / 2);
			return;
		default:
			return;
		}
	}

	// Token: 0x04000021 RID: 33
	protected Bitmap U;

	// Token: 0x04000022 RID: 34
	protected Graphics V;

	// Token: 0x04000023 RID: 35
	protected aQ.MJ aR;

	// Token: 0x04000024 RID: 36
	private Size ai;

	// Token: 0x04000025 RID: 37
	private Image aj;

	// Token: 0x0200000A RID: 10
	public enum MJ : byte
	{
		// Token: 0x04000027 RID: 39
		MK,
		// Token: 0x04000028 RID: 40
		ML,
		// Token: 0x04000029 RID: 41
		MM
	}
}
