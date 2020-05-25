using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000025 RID: 37
	public class ig : Control
	{
		// Token: 0x0600012A RID: 298 RVA: 0x0000852C File Offset: 0x0000672C
		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			if (this.ih > 0 & this.ih < 28)
			{
				base.FindForm().WindowState = FormWindowState.Minimized;
			}
			else if (this.ih > 30 & this.ih < 75)
			{
				base.FindForm().Close();
			}
			this.bE = ig.Nt.Nw;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008590 File Offset: 0x00006790
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.bE = ig.Nt.Nv;
			base.Invalidate();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000085A8 File Offset: 0x000067A8
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.bE = ig.Nt.Nu;
			base.Invalidate();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000085C0 File Offset: 0x000067C0
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.bE = ig.Nt.Nv;
			base.Invalidate();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000085D8 File Offset: 0x000067D8
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.ih = e.Location.X;
			base.Invalidate();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008608 File Offset: 0x00006808
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Width = 77;
			base.Height = 19;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00008624 File Offset: 0x00006824
		public ig()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008680 File Offset: 0x00006880
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			Point location = new Point(checked(base.FindForm().Width - 81), -1);
			base.Location = location;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000086B0 File Offset: 0x000068B0
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			GraphicsPath graphicsPath = new GraphicsPath();
			GraphicsPath graphicsPath2 = new GraphicsPath();
			graphicsPath.AddRectangle(this.ij);
			graphicsPath2.AddRectangle(this.ii);
			graphics.Clear(this.BackColor);
			ig.Nt nt = this.bE;
			if (nt != ig.Nt.Nu)
			{
				if (nt != ig.Nt.Nv)
				{
					goto IL_44E;
				}
				if (this.ih > 0 & this.ih < 28)
				{
					LinearGradientBrush brush = new LinearGradientBrush(this.ij, Color.FromArgb(76, 76, 76, 76), Color.FromArgb(48, 48, 48), 90f);
					graphics.FillPath(brush, graphicsPath);
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath);
					graphics.DrawString("0", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.ij.Width - 22), (float)(this.ij.Height - 16));
					LinearGradientBrush brush2 = new LinearGradientBrush(this.ii, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
					graphics.FillPath(brush2, graphicsPath2);
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath2);
					graphics.DrawString("r", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.ii.Width - 4), (float)(this.ii.Height - 16));
					goto IL_44E;
				}
				if (this.ih > 30 & this.ih < 75)
				{
					LinearGradientBrush brush3 = new LinearGradientBrush(this.ii, Color.FromArgb(76, 76, 76, 76), Color.FromArgb(48, 48, 48), 90f);
					graphics.FillPath(brush3, graphicsPath2);
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath2);
					graphics.DrawString("r", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.ii.Width - 4), (float)(this.ii.Height - 16));
					LinearGradientBrush brush4 = new LinearGradientBrush(this.ij, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
					graphics.FillPath(brush4, fF.fH(this.ij, 1));
					graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath);
					graphics.DrawString("0", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.ij.Width - 22), (float)(this.ij.Height - 16));
					goto IL_44E;
				}
			}
			LinearGradientBrush brush5 = new LinearGradientBrush(this.ij, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
			graphics.FillPath(brush5, graphicsPath);
			graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath);
			graphics.DrawString("0", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.ij.Width - 22), (float)(this.ij.Height - 16));
			LinearGradientBrush brush6 = new LinearGradientBrush(this.ii, Color.FromArgb(73, 73, 73), Color.FromArgb(58, 58, 58), 90f);
			graphics.FillPath(brush6, graphicsPath2);
			graphics.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), graphicsPath2);
			graphics.DrawString("r", new Font("Marlett", 11f, FontStyle.Regular), new SolidBrush(Color.FromArgb(221, 221, 221)), (float)(this.ii.Width - 4), (float)(this.ii.Height - 16));
			IL_44E:
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			graphicsPath2.Dispose();
			graphicsPath.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040000B5 RID: 181
		private ig.Nt bE;

		// Token: 0x040000B6 RID: 182
		private int ih;

		// Token: 0x040000B7 RID: 183
		private Rectangle ii = new Rectangle(28, 0, 47, 18);

		// Token: 0x040000B8 RID: 184
		private Rectangle ij = new Rectangle(0, 0, 28, 18);

		// Token: 0x02000026 RID: 38
		public enum Nt : byte
		{
			// Token: 0x040000BA RID: 186
			Nu,
			// Token: 0x040000BB RID: 187
			Nv,
			// Token: 0x040000BC RID: 188
			Nw,
			// Token: 0x040000BD RID: 189
			Nx
		}
	}
}
