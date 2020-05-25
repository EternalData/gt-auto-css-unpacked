using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace oK
{
	// Token: 0x02000052 RID: 82
	public class pa : UserControl
	{
		// Token: 0x0600026D RID: 621 RVA: 0x0000EC94 File Offset: 0x0000CE94
		public pa()
		{
			this.oZ();
			this.pb.Add(Color.FromArgb(0, 150, 136));
			this.pb.Add(Color.FromArgb(0, 188, 212));
			this.pb.Add(Color.FromArgb(63, 81, 181));
			this.pb.Add(Color.FromArgb(156, 39, 176));
			this.pe.ProgressColor = this.pb[this.pc];
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000ED48 File Offset: 0x0000CF48
		private void pi(object sender, EventArgs e)
		{
			if (this.pe.Value == 90)
			{
				this.pd = -1;
				this.pe.animationIterval = 4;
				this.pl();
			}
			else if (this.pe.Value == 10)
			{
				this.pd = 1;
				this.pe.animationIterval = 2;
				this.pl();
			}
			this.pe.Value += this.pd;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		private void pl()
		{
			this.ph.Color1 = this.pb[this.pc];
			if (this.pc < this.pb.Count - 1)
			{
				this.pc++;
			}
			else
			{
				this.pc = 0;
			}
			this.ph.Color2 = this.pb[this.pc];
			this.pg.Start();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000EE3C File Offset: 0x0000D03C
		private void pm(object sender, EventArgs e)
		{
			if (this.ph.ProgessValue < 100)
			{
				BunifuColorTransition bunifuColorTransition = this.ph;
				int progessValue = bunifuColorTransition.ProgessValue;
				bunifuColorTransition.ProgessValue = progessValue + 1;
				this.pe.ProgressColor = this.ph.Value;
				return;
			}
			this.pg.Stop();
			this.ph.Color1 = this.ph.Color2;
			this.ph.ProgessValue = 0;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.oL != null)
			{
				this.oL.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		private void oZ()
		{
			this.oL = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(pa));
			this.pe = new BunifuCircleProgressbar();
			this.pf = new Timer(this.oL);
			this.pg = new Timer(this.oL);
			this.ph = new BunifuColorTransition(this.oL);
			base.SuspendLayout();
			this.pe.animated = true;
			this.pe.animationIterval = 2;
			this.pe.animationSpeed = 1;
			this.pe.BackColor = Color.Black;
			this.pe.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuCircleProgressbar1.BackgroundImage");
			this.pe.Dock = DockStyle.Fill;
			this.pe.Font = new Font("Microsoft Sans Serif", 26.25f);
			this.pe.ForeColor = Color.SeaGreen;
			this.pe.LabelVisible = false;
			this.pe.LineProgressThickness = 8;
			this.pe.LineThickness = 5;
			this.pe.Location = new Point(0, 0);
			this.pe.Margin = new Padding(10, 9, 10, 9);
			this.pe.MaxValue = 100;
			this.pe.Name = "bunifuCircleProgressbar1";
			this.pe.ProgressBackColor = SystemColors.ActiveCaptionText;
			this.pe.ProgressColor = Color.SeaGreen;
			this.pe.Size = new Size(260, 260);
			this.pe.TabIndex = 0;
			this.pe.Value = 30;
			this.pf.Enabled = true;
			this.pf.Interval = 30;
			this.pf.Tick += this.pi;
			this.pg.Interval = 10;
			this.pg.Tick += this.pm;
			this.ph.Color1 = Color.White;
			this.ph.Color2 = Color.White;
			this.ph.ProgessValue = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.Controls.Add(this.pe);
			base.Name = "MyPreloader";
			base.Size = new Size(288, 260);
			base.ResumeLayout(false);
		}

		// Token: 0x04000159 RID: 345
		private List<Color> pb = new List<Color>();

		// Token: 0x0400015A RID: 346
		private int pc;

		// Token: 0x0400015B RID: 347
		private int pd = 1;

		// Token: 0x0400015C RID: 348
		private IContainer oL;

		// Token: 0x0400015D RID: 349
		private BunifuCircleProgressbar pe;

		// Token: 0x0400015E RID: 350
		private Timer pf;

		// Token: 0x0400015F RID: 351
		private Timer pg;

		// Token: 0x04000160 RID: 352
		private BunifuColorTransition ph;
	}
}
