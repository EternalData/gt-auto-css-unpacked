using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace fG
{
	// Token: 0x0200001C RID: 28
	internal static class fF
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00006620 File Offset: 0x00004820
		public static GraphicsPath fH(Rectangle fI, int fJ)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			int num = fJ * 2;
			graphicsPath.AddArc(new Rectangle(fI.X, fI.Y, num, num), -180f, 90f);
			graphicsPath.AddArc(new Rectangle(fI.Width - num + fI.X, fI.Y, num, num), -90f, 90f);
			graphicsPath.AddArc(new Rectangle(fI.Width - num + fI.X, fI.Height - num + fI.Y, num, num), 0f, 90f);
			graphicsPath.AddArc(new Rectangle(fI.X, fI.Height - num + fI.Y, num, num), 90f, 90f);
			graphicsPath.AddLine(new Point(fI.X, fI.Height - num + fI.Y), new Point(fI.X, fJ + fI.Y));
			return graphicsPath;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000672C File Offset: 0x0000492C
		public static GraphicsPath fH(int fK, int fL, int fM, int fN, int fO)
		{
			Rectangle rectangle = new Rectangle(fK, fL, fM, fN);
			GraphicsPath graphicsPath = new GraphicsPath();
			int num = fO * 2;
			graphicsPath.AddArc(new Rectangle(rectangle.X, rectangle.Y, num, num), -180f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -90f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90f, 90f);
			graphicsPath.AddLine(new Point(rectangle.X, rectangle.Height - num + rectangle.Y), new Point(rectangle.X, fO + rectangle.Y));
			return graphicsPath;
		}
	}
}
