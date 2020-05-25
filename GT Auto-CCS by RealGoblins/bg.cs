using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x0200000B RID: 11
internal class bg : T
{
	// Token: 0x06000041 RID: 65 RVA: 0x00003574 File Offset: 0x00001774
	public bg()
	{
		base.ar = 28;
		this.ForeColor = Color.FromArgb(100, 100, 100);
		base.aA(Color.Fuchsia);
		this.C = Color.FromArgb(41, 41, 41);
		this.D = Color.FromArgb(25, 25, 25);
		this.bh = new Pen(Color.FromArgb(58, 58, 58));
		this.bi = new Pen(this.D);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000035F4 File Offset: 0x000017F4
	protected override void OnPaint(PaintEventArgs e)
	{
		this.V.Clear(this.C);
		this.bk = new Rectangle(0, 0, base.Width, 28);
		this.bj = new LinearGradientBrush(this.bk, this.D, this.C, LinearGradientMode.Vertical);
		this.V.FillRectangle(this.bj, this.bk);
		this.V.DrawLine(this.bi, 0, 28, base.Width, 28);
		this.V.DrawLine(this.bh, 0, 29, base.Width, 29);
		base.aJ(HorizontalAlignment.Left, new SolidBrush(this.ForeColor), base.at);
		base.aN(HorizontalAlignment.Left, 0);
		base.aF(Pens.Black, this.bh, base.ClientRectangle);
		base.aC(Color.Fuchsia, base.ClientRectangle);
		e.Graphics.DrawImage(this.U, 0, 0);
	}

	// Token: 0x0400002A RID: 42
	private Color C;

	// Token: 0x0400002B RID: 43
	private Color D;

	// Token: 0x0400002C RID: 44
	private Pen bh;

	// Token: 0x0400002D RID: 45
	private Pen bi;

	// Token: 0x0400002E RID: 46
	private LinearGradientBrush bj;

	// Token: 0x0400002F RID: 47
	private Rectangle bk;
}
