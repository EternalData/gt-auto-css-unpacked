using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200000E RID: 14
public class bD : Control
{
	// Token: 0x0600004D RID: 77 RVA: 0x000039C0 File Offset: 0x00001BC0
	public bD()
	{
		this.ForeColor = Color.FromArgb(65, 65, 65);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003A44 File Offset: 0x00001C44
	protected override void OnMouseEnter(EventArgs e)
	{
		this.bE = 1;
		base.Invalidate();
		base.OnMouseEnter(e);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003A5C File Offset: 0x00001C5C
	protected override void OnMouseDown(MouseEventArgs e)
	{
		this.bE = 2;
		base.Invalidate();
		base.OnMouseDown(e);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00003A74 File Offset: 0x00001C74
	protected override void OnMouseLeave(EventArgs e)
	{
		this.bE = 0;
		base.Invalidate();
		base.OnMouseLeave(e);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00003A8C File Offset: 0x00001C8C
	protected override void OnMouseUp(MouseEventArgs e)
	{
		this.bE = 1;
		base.Invalidate();
		base.OnMouseUp(e);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00003AA4 File Offset: 0x00001CA4
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003AA8 File Offset: 0x00001CA8
	protected override void OnPaint(PaintEventArgs e)
	{
		using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawRectangle(new Pen(this.C), 0, 0, base.Width - 1, base.Height - 1);
				if (this.bE == 2)
				{
					f.g(graphics, this.D, this.E, 1, 1, base.Width - 2, base.Height - 2);
				}
				else
				{
					f.g(graphics, this.E, this.D, 1, 1, base.Width - 2, base.Height - 2);
				}
				SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
				graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), (float)(base.Width / 2) - sizeF.Width / 2f, (float)(base.Height / 2) - sizeF.Height / 2f);
				f.o(graphics, this.F, this.G, this.F, 0.5f, 0, 1, 1, base.Width - 2, 1);
				e.Graphics.DrawImage((Image)bitmap.Clone(), 0f, 0f);
			}
		}
	}

	// Token: 0x0400003C RID: 60
	private int bE;

	// Token: 0x0400003D RID: 61
	private Color C = Color.FromArgb(31, 31, 31);

	// Token: 0x0400003E RID: 62
	private Color D = Color.FromArgb(41, 41, 41);

	// Token: 0x0400003F RID: 63
	private Color E = Color.FromArgb(51, 51, 51);

	// Token: 0x04000040 RID: 64
	private Color F = Color.FromArgb(0, 0, 0, 0);

	// Token: 0x04000041 RID: 65
	private Color G = Color.FromArgb(25, 255, 255, 255);
}
