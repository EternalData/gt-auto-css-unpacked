using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x0200000C RID: 12
internal class bl : aQ
{
	// Token: 0x06000043 RID: 67 RVA: 0x000036F0 File Offset: 0x000018F0
	public bl()
	{
		base.aT();
		this.BackColor = Color.FromArgb(41, 41, 41);
		this.ForeColor = Color.FromArgb(100, 100, 100);
		this.bh = new Pen(Color.FromArgb(25, 25, 25));
		this.bi = new Pen(Color.FromArgb(11, Color.White));
		this.C = Color.FromArgb(41, 41, 41);
		this.D = Color.FromArgb(51, 51, 51);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000377C File Offset: 0x0000197C
	protected override void OnPaint(PaintEventArgs e)
	{
		if (this.aR == aQ.MJ.MM)
		{
			this.bj = new LinearGradientBrush(base.ClientRectangle, this.C, this.D, LinearGradientMode.Vertical);
		}
		else
		{
			this.bj = new LinearGradientBrush(base.ClientRectangle, this.D, this.C, LinearGradientMode.Vertical);
		}
		this.V.FillRectangle(this.bj, base.ClientRectangle);
		base.aJ(HorizontalAlignment.Center, new SolidBrush(this.ForeColor), 0);
		base.aN(HorizontalAlignment.Left, 0);
		base.aF(this.bh, this.bi, base.ClientRectangle);
		base.aC(this.BackColor, base.ClientRectangle);
		e.Graphics.DrawImage(this.U, 0, 0);
	}

	// Token: 0x04000030 RID: 48
	private Pen bh;

	// Token: 0x04000031 RID: 49
	private Pen bi;

	// Token: 0x04000032 RID: 50
	private LinearGradientBrush bj;

	// Token: 0x04000033 RID: 51
	private Color C;

	// Token: 0x04000034 RID: 52
	private Color D;

	// Token: 0x04000035 RID: 53
	private Rectangle bk;
}
