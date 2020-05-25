using System;
using System.Drawing;
using System.Drawing.Drawing2D;

// Token: 0x02000004 RID: 4
public class f
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002098 File Offset: 0x00000298
	public static void g(Graphics h, Color i, Color j, int k, int l, int m, int n)
	{
		Rectangle rect = new Rectangle(k, l, m, n);
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, i, j, LinearGradientMode.Vertical))
		{
			h.FillRectangle(linearGradientBrush, rect);
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000020E4 File Offset: 0x000002E4
	public static void o(Graphics p, Color q, Color r, Color s, float t, int u, int v, int w, int x, int y)
	{
		ColorBlend colorBlend = new ColorBlend(3);
		colorBlend.Colors = new Color[]
		{
			q,
			r,
			s
		};
		colorBlend.Positions = new float[]
		{
			0f,
			t,
			1f
		};
		Rectangle rect = new Rectangle(v, w, x, y);
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, q, q, (LinearGradientMode)u))
		{
			linearGradientBrush.InterpolationColors = colorBlend;
			p.FillRectangle(linearGradientBrush, rect);
		}
	}
}
