using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000005 RID: 5
public class z : Control
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002184 File Offset: 0x00000384
	// (set) Token: 0x0600000B RID: 11 RVA: 0x0000218C File Offset: 0x0000038C
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

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000C RID: 12 RVA: 0x000021C4 File Offset: 0x000003C4
	// (set) Token: 0x0600000D RID: 13 RVA: 0x000021CC File Offset: 0x000003CC
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

	// Token: 0x0600000E RID: 14 RVA: 0x000021DC File Offset: 0x000003DC
	protected override void OnHandleCreated(EventArgs e)
	{
		this.Dock = DockStyle.Fill;
		if (base.Parent is Form)
		{
			((Form)base.Parent).FormBorderStyle = FormBorderStyle.None;
		}
		base.OnHandleCreated(e);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002218 File Offset: 0x00000418
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

	// Token: 0x06000010 RID: 16 RVA: 0x000022C4 File Offset: 0x000004C4
	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000022C8 File Offset: 0x000004C8
	protected override void OnPaint(PaintEventArgs e)
	{
		using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(this.E);
				f.g(graphics, this.F, this.E, 0, 0, base.Width, this.A);
				SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
				int x = 6;
				if (this.B == HorizontalAlignment.Center)
				{
					x = base.Width / 2 - (int)sizeF.Width / 2;
				}
				if (this.B == HorizontalAlignment.Right)
				{
					x = base.Width - (int)sizeF.Width - 6;
				}
				Rectangle rectangle = new Rectangle(x, (this.A + 2) / 2 - (int)sizeF.Height / 2, (int)sizeF.Width, (int)sizeF.Height);
				using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, this.C, this.E, LinearGradientMode.Vertical))
				{
					graphics.DrawString(this.Text, this.Font, linearGradientBrush, rectangle);
				}
				graphics.DrawLine(new Pen(this.E), 0, 1, base.Width, 1);
				f.o(graphics, this.G, this.H, this.G, 0.5f, 0, 0, this.A + 1, base.Width, 1);
				graphics.DrawLine(new Pen(this.F), 0, this.A, base.Width, this.A);
				graphics.DrawRectangle(new Pen(this.F), 0, 0, base.Width - 1, base.Height - 1);
				e.Graphics.DrawImage((Image)bitmap.Clone(), 0f, 0f);
			}
		}
	}

	// Token: 0x04000001 RID: 1
	private int A = 25;

	// Token: 0x04000002 RID: 2
	private HorizontalAlignment B = HorizontalAlignment.Center;

	// Token: 0x04000003 RID: 3
	private Color C = Color.FromArgb(74, 74, 74);

	// Token: 0x04000004 RID: 4
	private Color D = Color.FromArgb(63, 63, 63);

	// Token: 0x04000005 RID: 5
	private Color E = Color.FromArgb(41, 41, 41);

	// Token: 0x04000006 RID: 6
	private Color F = Color.FromArgb(27, 27, 27);

	// Token: 0x04000007 RID: 7
	private Color G = Color.FromArgb(0, 0, 0, 0);

	// Token: 0x04000008 RID: 8
	private Color H = Color.FromArgb(25, 255, 255, 255);
}
