using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200000F RID: 15
public class bF : Control
{
	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000054 RID: 84 RVA: 0x00003C38 File Offset: 0x00001E38
	// (set) Token: 0x06000055 RID: 85 RVA: 0x00003C40 File Offset: 0x00001E40
	public int bL
	{
		get
		{
			return this.bG;
		}
		set
		{
			this.bG = value;
			base.Invalidate();
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000056 RID: 86 RVA: 0x00003C50 File Offset: 0x00001E50
	// (set) Token: 0x06000057 RID: 87 RVA: 0x00003C58 File Offset: 0x00001E58
	public int bP
	{
		get
		{
			return this.bH;
		}
		set
		{
			if (value == 0)
			{
				value = 1;
			}
			this.bH = value;
			base.Invalidate();
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003C78 File Offset: 0x00001E78
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00003C7C File Offset: 0x00001E7C
	protected override void OnPaint(PaintEventArgs e)
	{
		int num = base.Width * this.bG / this.bH;
		using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				f.g(graphics, this.D, this.E, 1, 1, base.Width - 2, base.Height - 2);
				graphics.DrawRectangle(new Pen(this.D), 1, 1, num - 3, base.Height - 3);
				f.g(graphics, this.E, this.D, 2, 2, num - 4, base.Height - 4);
				graphics.DrawRectangle(new Pen(this.C), 0, 0, base.Width - 1, base.Height - 1);
				e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			}
		}
	}

	// Token: 0x04000042 RID: 66
	private int bG;

	// Token: 0x04000043 RID: 67
	private int bH = 100;

	// Token: 0x04000044 RID: 68
	private Color C = Color.FromArgb(31, 31, 31);

	// Token: 0x04000045 RID: 69
	private Color D = Color.FromArgb(41, 41, 41);

	// Token: 0x04000046 RID: 70
	private Color E = Color.FromArgb(51, 51, 51);

	// Token: 0x04000047 RID: 71
	private Color F = Color.FromArgb(0, 0, 0, 0);

	// Token: 0x04000048 RID: 72
	private Color G = Color.FromArgb(25, 255, 255, 255);
}
