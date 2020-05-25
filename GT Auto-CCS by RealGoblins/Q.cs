using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000006 RID: 6
public class Q : Control
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00002578 File Offset: 0x00000778
	// (set) Token: 0x06000014 RID: 20 RVA: 0x00002580 File Offset: 0x00000780
	public int L
	{
		get
		{
			return this.A;
		}
		set
		{
			if (value > base.Height)
			{
				value = base.Height;
			}
			if (value < 2)
			{
				base.Height = 1;
			}
			this.A = value;
			base.Invalidate();
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000015 RID: 21 RVA: 0x000025B8 File Offset: 0x000007B8
	// (set) Token: 0x06000016 RID: 22 RVA: 0x000025C0 File Offset: 0x000007C0
	public HorizontalAlignment P
	{
		get
		{
			return this.B;
		}
		set
		{
			this.B = value;
			base.Invalidate();
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000025D0 File Offset: 0x000007D0
	protected override void OnHandleCreated(EventArgs e)
	{
		this.Dock = DockStyle.Fill;
		if (base.Parent is Form)
		{
			((Form)base.Parent).FormBorderStyle = FormBorderStyle.None;
		}
		base.OnHandleCreated(e);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000260C File Offset: 0x0000080C
	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (new Rectangle(base.Parent.Location.X, base.Parent.Location.Y, base.Width - 1, this.A - 1).IntersectsWith(new Rectangle(Control.MousePosition.X, Control.MousePosition.Y, 1, 1)))
		{
			base.Capture = false;
			Message message = Message.Create(base.Parent.Handle, 161, new IntPtr(2), new IntPtr(0));
			this.DefWndProc(ref message);
		}
		base.OnMouseDown(e);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000026B8 File Offset: 0x000008B8
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000026BC File Offset: 0x000008BC
	protected override void OnPaint(PaintEventArgs e)
	{
		using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(this.E);
				f.o(graphics, this.D, this.E, this.C, 0.5f, 1, 0, 0, base.Width, this.A);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(15, 255, 255, 255)), 1, 1, base.Width - 2, Convert.ToInt32((double)this.A / 2.0) - 2);
				graphics.DrawRectangle(new Pen(Color.FromArgb(35, 255, 255, 255)), 1, 1, base.Width - 3, this.A - 2);
				SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
				int num = 6;
				if (this.B == HorizontalAlignment.Center)
				{
					num = base.Width / 2 - (int)sizeF.Width / 2;
				}
				if (this.B == HorizontalAlignment.Right)
				{
					num = base.Width - (int)sizeF.Width - 14;
				}
				int num2 = Convert.ToInt32((double)this.A / 2.0 - (double)((sizeF.Height + 4f) / 2f));
				f.g(graphics, this.E, this.D, num, num2, (int)sizeF.Width + 8, (int)sizeF.Height + 4);
				graphics.DrawRectangle(new Pen(this.E), (float)num, (float)num2, sizeF.Width + 7f, sizeF.Height + 3f);
				Rectangle rectangle = new Rectangle(num + 4, Convert.ToInt32((float)(this.A / 2) - sizeF.Height / 2f), (int)sizeF.Width, (int)sizeF.Height);
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, this.C, this.D, LinearGradientMode.Vertical))
				{
					graphics.DrawString(this.Text, this.Font, linearGradientBrush, rectangle);
				}
				graphics.DrawRectangle(new Pen(this.C), 1, this.A + 1, base.Width - 3, base.Height - this.A - 3);
				graphics.DrawLine(new Pen(this.F), 0, this.A, base.Width, this.A);
				graphics.DrawRectangle(new Pen(this.F), 0, 0, base.Width - 1, base.Height - 1);
				e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			}
		}
	}

	// Token: 0x04000009 RID: 9
	private int A = 25;

	// Token: 0x0400000A RID: 10
	private HorizontalAlignment B = HorizontalAlignment.Center;

	// Token: 0x0400000B RID: 11
	private Color C = Color.FromArgb(0, 70, 114);

	// Token: 0x0400000C RID: 12
	private Color D = Color.FromArgb(0, 47, 78);

	// Token: 0x0400000D RID: 13
	private Color E = Color.FromArgb(0, 34, 57);

	// Token: 0x0400000E RID: 14
	private Color F = Color.FromArgb(0, 30, 50);
}
