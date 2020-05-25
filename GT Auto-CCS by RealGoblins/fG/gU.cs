using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace fG
{
	// Token: 0x02000022 RID: 34
	public class gU
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00007754 File Offset: 0x00005954
		public static void gV(Graphics gW, fP gX, Rectangle gY)
		{
			Rectangle rect = default(Rectangle);
			Rectangle rect2 = default(Rectangle);
			Rectangle rectangle = new Rectangle(gY.X + 1, gY.Y + 1, gY.Width - 1, gY.Height - 1);
			rect = rectangle;
			rect.Height -= Convert.ToInt32(rect.Height / 2);
			rect2 = new Rectangle(rect.X, rect.Bottom, rect.Width, rectangle.Height - rect.Height);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, gX.fX, gX.fZ, LinearGradientMode.Vertical))
			{
				gW.FillRectangle(linearGradientBrush, rect);
			}
			using (SolidBrush solidBrush = new SolidBrush(gX.gb))
			{
				gW.FillRectangle(solidBrush, rect2);
			}
			using (Pen pen = new Pen(gX.fV))
			{
				gU.gZ(gW, pen, Convert.ToSingle(gY.X), Convert.ToSingle(gY.Y), Convert.ToSingle(gY.Width), Convert.ToSingle(gY.Height), 2f);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000078B4 File Offset: 0x00005AB4
		public static void gZ(Graphics ha, Pen hb, float hc, float hd, float he, float hf, float hg)
		{
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				graphicsPath.AddLine(hc + hg, hd, hc + he - hg * 2f, hd);
				graphicsPath.AddArc(hc + he - hg * 2f, hd, hg * 2f, hg * 2f, 270f, 90f);
				graphicsPath.AddLine(hc + he, hd + hg, hc + he, hd + hf - hg * 2f);
				graphicsPath.AddArc(hc + he - hg * 2f, hd + hf - hg * 2f, hg * 2f, hg * 2f, 0f, 90f);
				graphicsPath.AddLine(hc + he - hg * 2f, hd + hf, hc + hg, hd + hf);
				graphicsPath.AddArc(hc, hd + hf - hg * 2f, hg * 2f, hg * 2f, 90f, 90f);
				graphicsPath.AddLine(hc, hd + hf - hg * 2f, hc, hd + hg);
				graphicsPath.AddArc(hc, hd, hg * 2f, hg * 2f, 180f, 90f);
				graphicsPath.CloseFigure();
				ha.SmoothingMode = SmoothingMode.AntiAlias;
				ha.DrawPath(hb, graphicsPath);
				ha.SmoothingMode = SmoothingMode.Default;
			}
		}
	}
}
