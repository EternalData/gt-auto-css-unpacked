using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace fG
{
	// Token: 0x02000041 RID: 65
	internal class lR : ComboBox
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		public int lX
		{
			get
			{
				return this.lS;
			}
			set
			{
				this.lS = value;
				try
				{
					base.SelectedIndex = value;
				}
				catch
				{
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000CC20 File Offset: 0x0000AE20
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000CC28 File Offset: 0x0000AE28
		public Color mb
		{
			get
			{
				return this.lT;
			}
			set
			{
				this.lT = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000CC38 File Offset: 0x0000AE38
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				e.Graphics.FillRectangle(new SolidBrush(this.lT), e.Bounds);
			}
			else
			{
				e.Graphics.FillRectangle(Brushes.White, e.Bounds);
			}
			if (e.Index != -1)
			{
				e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), e.Font, Brushes.DimGray, e.Bounds);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			base.SuspendLayout();
			base.Update();
			base.ResumeLayout();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		public lR()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.Selectable, false);
			base.DrawMode = DrawMode.OwnerDrawFixed;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			this.BackColor = Color.FromArgb(246, 246, 246);
			this.ForeColor = Color.FromArgb(142, 142, 142);
			base.Size = new Size(135, 26);
			base.ItemHeight = 20;
			base.DropDownHeight = 100;
			this.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.Clear(this.BackColor);
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			GraphicsPath graphicsPath = fF.fH(0, 0, base.Width - 1, base.Height - 1, 5);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(241, 241, 241), Color.FromArgb(241, 241, 241), 90f);
			e.Graphics.SetClip(graphicsPath);
			e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			e.Graphics.ResetClip();
			e.Graphics.DrawPath(new Pen(Color.FromArgb(204, 204, 204)), graphicsPath);
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(142, 142, 142)), new Rectangle(3, 0, base.Width - 20, base.Height), new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Near
			});
			e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2f), new Point(base.Width - 18, 10), new Point(base.Width - 14, 14));
			e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2f), new Point(base.Width - 14, 14), new Point(base.Width - 10, 10));
			e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160)), new Point(base.Width - 14, 15), new Point(base.Width - 14, 14));
			graphicsPath.Dispose();
			linearGradientBrush.Dispose();
		}

		// Token: 0x04000122 RID: 290
		private int lS;

		// Token: 0x04000123 RID: 291
		private Color lT = Color.FromArgb(241, 241, 241);
	}
}
