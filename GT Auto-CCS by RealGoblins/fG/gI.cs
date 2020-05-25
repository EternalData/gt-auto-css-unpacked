using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000021 RID: 33
	public class gI : ToolStripProfessionalRenderer
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00006A18 File Offset: 0x00004C18
		public gI() : this(new gF())
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006A28 File Offset: 0x00004C28
		public gI(go ColorTable)
		{
			this.gN = ColorTable;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00006A54 File Offset: 0x00004C54
		public go gN
		{
			get
			{
				if (this.gJ == null)
				{
					this.gJ = new gF();
				}
				return this.gJ;
			}
			set
			{
				this.gJ = value;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006A60 File Offset: 0x00004C60
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBackground(e);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(e.AffectedBounds, this.gN.gs, this.gN.gu, LinearGradientMode.Vertical))
			{
				e.Graphics.FillRectangle(linearGradientBrush, e.AffectedBounds);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006AC8 File Offset: 0x00004CC8
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			if (e.ToolStrip.Parent == null)
			{
				Rectangle rect = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
				using (Pen pen = new Pen(this.gN.gq.gj))
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
				using (SolidBrush solidBrush = new SolidBrush(this.gN.gw))
				{
					e.Graphics.FillRectangle(solidBrush, e.ConnectedArea);
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006B84 File Offset: 0x00004D84
		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			if (e.Item.Enabled)
			{
				if (e.Item.Selected)
				{
					if (!e.Item.IsOnDropDown)
					{
						Rectangle gY = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
						gU.gV(e.Graphics, this.gN.gq, gY);
					}
					else
					{
						Rectangle gY2 = new Rectangle(2, 0, e.Item.Width - 4, e.Item.Height - 1);
						gU.gV(e.Graphics, this.gN.gq, gY2);
					}
				}
				if (((ToolStripMenuItem)e.Item).DropDown.Visible && !e.Item.IsOnDropDown)
				{
					Rectangle rectangle = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height);
					Rectangle rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height + 2);
					using (SolidBrush solidBrush = new SolidBrush(this.gN.gw))
					{
						e.Graphics.FillRectangle(solidBrush, rect);
					}
					using (Pen pen = new Pen(this.gN.gq.gj))
					{
						gU.gZ(e.Graphics, pen, Convert.ToSingle(rectangle.X), Convert.ToSingle(rectangle.Y), Convert.ToSingle(rectangle.Width), Convert.ToSingle(rectangle.Height), 2f);
					}
				}
				e.Item.ForeColor = this.gN.gq.fR;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006D70 File Offset: 0x00004F70
		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
			e.TextColor = this.gN.gq.fR;
			base.OnRenderItemText(e);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006D90 File Offset: 0x00004F90
		protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
		{
			base.OnRenderItemCheck(e);
			Rectangle rect = new Rectangle(3, 1, e.Item.Height - 3, e.Item.Height - 3);
			Color color = default(Color);
			if (e.Item.Selected)
			{
				color = this.gN.gq.gh;
			}
			else
			{
				color = this.gN.gq.gf;
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				e.Graphics.FillRectangle(solidBrush, rect);
			}
			using (Pen pen = new Pen(this.gN.gq.fV))
			{
				e.Graphics.DrawRectangle(pen, rect);
			}
			e.Graphics.DrawString("ü", new Font("Wingdings", 13f, FontStyle.Regular), Brushes.Black, new Point(4, 2));
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006E9C File Offset: 0x0000509C
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			base.OnRenderSeparator(e);
			int x = 28;
			int x2 = Convert.ToInt32(e.Item.Width);
			int num = 3;
			using (Pen pen = new Pen(this.gN.gC))
			{
				e.Graphics.DrawLine(pen, x, num, x2, num);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006F04 File Offset: 0x00005104
		protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
		{
			base.OnRenderImageMargin(e);
			Rectangle rect = new Rectangle(0, -1, e.ToolStrip.Width, e.ToolStrip.Height + 1);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, this.gN.gy, this.gN.gA, LinearGradientMode.Vertical))
			{
				e.Graphics.FillRectangle(linearGradientBrush, rect);
			}
			using (SolidBrush solidBrush = new SolidBrush(this.gN.gE))
			{
				e.Graphics.FillRectangle(solidBrush, e.AffectedBounds);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00006FBC File Offset: 0x000051BC
		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Rectangle rectangle = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
			bool flag = Convert.ToBoolean(((ToolStripButton)e.Item).Checked);
			bool flag2 = false;
			if (flag)
			{
				flag2 = true;
				if (e.Item.Selected && !e.Item.Pressed)
				{
					using (SolidBrush solidBrush = new SolidBrush(this.gN.gq.gh))
					{
						e.Graphics.FillRectangle(solidBrush, rectangle);
						goto IL_121;
					}
				}
				using (SolidBrush solidBrush2 = new SolidBrush(this.gN.gq.gf))
				{
					e.Graphics.FillRectangle(solidBrush2, rectangle);
					goto IL_121;
				}
			}
			if (e.Item.Pressed)
			{
				flag2 = true;
				using (SolidBrush solidBrush3 = new SolidBrush(this.gN.gq.gd))
				{
					e.Graphics.FillRectangle(solidBrush3, rectangle);
					goto IL_121;
				}
			}
			if (e.Item.Selected)
			{
				flag2 = true;
				gU.gV(e.Graphics, this.gN.gq, rectangle);
			}
			IL_121:
			if (flag2)
			{
				using (Pen pen = new Pen(this.gN.gq.fV))
				{
					e.Graphics.DrawRectangle(pen, rectangle);
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007154 File Offset: 0x00005354
		protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Rectangle rectangle = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
			bool flag = false;
			if (e.Item.Pressed)
			{
				flag = true;
				using (SolidBrush solidBrush = new SolidBrush(this.gN.gq.gd))
				{
					e.Graphics.FillRectangle(solidBrush, rectangle);
					goto IL_89;
				}
			}
			if (e.Item.Selected)
			{
				flag = true;
				gU.gV(e.Graphics, this.gN.gq, rectangle);
			}
			IL_89:
			if (flag)
			{
				using (Pen pen = new Pen(this.gN.gq.fV))
				{
					e.Graphics.DrawRectangle(pen, rectangle);
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007238 File Offset: 0x00005438
		protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e)
		{
			base.OnRenderSplitButtonBackground(e);
			bool flag = false;
			bool flag2 = true;
			ToolStripSplitButton toolStripSplitButton = (ToolStripSplitButton)e.Item;
			checked
			{
				Rectangle rect = new Rectangle(0, 0, toolStripSplitButton.ButtonBounds.Width - 1, toolStripSplitButton.ButtonBounds.Height - 1);
				Rectangle rectangle = new Rectangle(0, 0, toolStripSplitButton.Bounds.Width - 1, toolStripSplitButton.Bounds.Height - 1);
				if (toolStripSplitButton.DropDownButtonPressed)
				{
					flag = true;
					flag2 = false;
					using (SolidBrush solidBrush = new SolidBrush(this.gN.gq.gd))
					{
						e.Graphics.FillRectangle(solidBrush, rectangle);
						goto IL_D2;
					}
				}
				if (toolStripSplitButton.DropDownButtonSelected)
				{
					flag = true;
					gU.gV(e.Graphics, this.gN.gq, rectangle);
				}
				IL_D2:
				if (toolStripSplitButton.ButtonPressed)
				{
					using (SolidBrush solidBrush2 = new SolidBrush(this.gN.gq.gd))
					{
						e.Graphics.FillRectangle(solidBrush2, rect);
					}
				}
				if (flag)
				{
					using (Pen pen = new Pen(this.gN.gq.fV))
					{
						e.Graphics.DrawRectangle(pen, rectangle);
						if (flag2)
						{
							e.Graphics.DrawRectangle(pen, rect);
						}
					}
					this.gO(e.Graphics, toolStripSplitButton);
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000073D8 File Offset: 0x000055D8
		private void gO(Graphics gP, ToolStripSplitButton gQ)
		{
			int num = Convert.ToInt32(gQ.DropDownButtonBounds.Width - 1);
			int num2 = Convert.ToInt32(gQ.DropDownButtonBounds.Height - 1);
			float num3 = (float)num / 2f + 1f;
			float x = Convert.ToSingle((float)gQ.DropDownButtonBounds.Left + ((float)num - num3) / 2f);
			float num4 = num3 / 2f;
			float y = Convert.ToSingle((float)gQ.DropDownButtonBounds.Top + ((float)num2 - num4) / 2f + 1f);
			RectangleF value = new RectangleF(x, y, num3, num4);
			this.gO(gP, gQ, Rectangle.Round(value));
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00007494 File Offset: 0x00005694
		private void gO(Graphics gR, ToolStripItem gS, Rectangle gT)
		{
			ToolStripArrowRenderEventArgs e = new ToolStripArrowRenderEventArgs(gR, gS, gT, this.gN.gq.gl, ArrowDirection.Down);
			base.OnRenderArrow(e);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000074C4 File Offset: 0x000056C4
		protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e)
		{
			Rectangle rectangle = default(Rectangle);
			Rectangle rectangle2 = default(Rectangle);
			rectangle = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 2);
			rectangle2 = new Rectangle(rectangle.X - 5, rectangle.Y, rectangle.Width - 5, rectangle.Height);
			if (e.Item.Pressed)
			{
				using (SolidBrush solidBrush = new SolidBrush(this.gN.gq.gd))
				{
					e.Graphics.FillRectangle(solidBrush, rectangle);
					goto IL_EB;
				}
			}
			if (e.Item.Selected)
			{
				gU.gV(e.Graphics, this.gN.gq, rectangle);
			}
			else
			{
				using (SolidBrush solidBrush2 = new SolidBrush(this.gN.gq.gn))
				{
					e.Graphics.FillRectangle(solidBrush2, rectangle);
				}
			}
			IL_EB:
			using (Pen pen = new Pen(this.gN.gq.fT))
			{
				gU.gZ(e.Graphics, pen, Convert.ToSingle(rectangle2.X), Convert.ToSingle(rectangle2.Y), Convert.ToSingle(rectangle2.Width), Convert.ToSingle(rectangle2.Height), 3f);
			}
			int num = Convert.ToInt32(rectangle.Width - 1);
			int num2 = Convert.ToInt32(rectangle.Height - 1);
			float num3 = (float)num / 2f + 1f;
			float num4 = Convert.ToSingle((float)rectangle.Left + ((float)num - num3) / 2f + 3f);
			float num5 = num3 / 2f;
			float num6 = Convert.ToSingle((float)rectangle.Top + ((float)num2 - num5) / 2f + 7f);
			RectangleF value = new RectangleF(num4, num6, num3, num5);
			this.gO(e.Graphics, e.Item, Rectangle.Round(value));
			using (Pen pen2 = new Pen(this.gN.gq.gl))
			{
				e.Graphics.DrawLine(pen2, num4 + 2f, num6 - 2f, num4 + num3 - 2f, num6 - 2f);
			}
		}

		// Token: 0x0400009A RID: 154
		private go gJ;
	}
}
