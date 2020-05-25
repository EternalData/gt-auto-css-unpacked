using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x0200000D RID: 13
internal class bm : aQ
{
	// Token: 0x06000045 RID: 69 RVA: 0x00003840 File Offset: 0x00001A40
	public bm()
	{
		base.aT();
		this.BackColor = Color.Transparent;
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000046 RID: 70 RVA: 0x00003880 File Offset: 0x00001A80
	// (set) Token: 0x06000047 RID: 71 RVA: 0x00003888 File Offset: 0x00001A88
	public Orientation bu
	{
		get
		{
			return this.bn;
		}
		set
		{
			this.bn = value;
			base.Invalidate();
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000048 RID: 72 RVA: 0x00003898 File Offset: 0x00001A98
	// (set) Token: 0x06000049 RID: 73 RVA: 0x000038A0 File Offset: 0x00001AA0
	public Color by
	{
		get
		{
			return this.bo;
		}
		set
		{
			this.bo = value;
			base.Invalidate();
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600004A RID: 74 RVA: 0x000038B0 File Offset: 0x00001AB0
	// (set) Token: 0x0600004B RID: 75 RVA: 0x000038B8 File Offset: 0x00001AB8
	public Color bC
	{
		get
		{
			return this.bp;
		}
		set
		{
			this.bp = value;
			base.Invalidate();
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000038C8 File Offset: 0x00001AC8
	protected override void OnPaint(PaintEventArgs e)
	{
		this.V.Clear(this.BackColor);
		if (this.bn == Orientation.Horizontal)
		{
			this.V.DrawLine(new Pen(this.bo), 0, base.Height / 2, base.Width, base.Height / 2);
			this.V.DrawLine(new Pen(this.bp), 0, base.Height / 2 + 1, base.Width, base.Height / 2 + 1);
		}
		else
		{
			this.V.DrawLine(new Pen(this.bo), base.Width / 2, 0, base.Width / 2, base.Height);
			this.V.DrawLine(new Pen(this.bp), base.Width / 2 + 1, 0, base.Width / 2 + 1, base.Height);
		}
		e.Graphics.DrawImage(this.U, 0, 0);
	}

	// Token: 0x04000036 RID: 54
	private Orientation bn;

	// Token: 0x04000037 RID: 55
	private Color bo = Color.FromArgb(90, Color.Black);

	// Token: 0x04000038 RID: 56
	private Color bp = Color.FromArgb(14, Color.White);

	// Token: 0x04000039 RID: 57
	private Rectangle bk;

	// Token: 0x0400003A RID: 58
	private LinearGradientBrush bj;

	// Token: 0x0400003B RID: 59
	private int bq;
}
