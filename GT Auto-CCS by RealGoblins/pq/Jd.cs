using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace pq
{
	// Token: 0x02000072 RID: 114
	public class Jd : UserControl
	{
		// Token: 0x060003BC RID: 956 RVA: 0x00022448 File Offset: 0x00020648
		public Jd()
		{
			this.oZ();
			this.pb.Add(Color.FromArgb(0, 150, 136));
			this.pb.Add(Color.FromArgb(0, 188, 212));
			this.pb.Add(Color.FromArgb(63, 81, 181));
			this.pb.Add(Color.FromArgb(156, 39, 176));
			this.pe.ProgressColor = this.pb[this.pc];
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000224FC File Offset: 0x000206FC
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

		// Token: 0x060003BE RID: 958 RVA: 0x00022574 File Offset: 0x00020774
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

		// Token: 0x060003BF RID: 959 RVA: 0x000225F0 File Offset: 0x000207F0
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

		// Token: 0x060003C0 RID: 960 RVA: 0x00022668 File Offset: 0x00020868
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.oL != null)
			{
				this.oL.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00022694 File Offset: 0x00020894
		private void oZ()
		{
			this.oL = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Jd));
			this.us = new Panel();
			this.qW = new Label();
			this.Je = new BunifuProgressBar();
			this.pe = new BunifuCircleProgressbar();
			this.ph = new BunifuColorTransition(this.oL);
			this.pg = new Timer(this.oL);
			base.SuspendLayout();
			this.us.BackColor = Color.Black;
			this.us.BackgroundImage = (Image)componentResourceManager.GetObject("panel1.BackgroundImage");
			this.us.BackgroundImageLayout = ImageLayout.Zoom;
			this.us.Location = new Point(257, -12);
			this.us.Name = "panel1";
			this.us.Size = new Size(231, 157);
			this.us.TabIndex = 0;
			this.qW.AutoSize = true;
			this.qW.Font = new Font("Josefin Sans", 18f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			this.qW.ForeColor = Color.White;
			this.qW.Location = new Point(15, 9);
			this.qW.Name = "label1";
			this.qW.Size = new Size(304, 29);
			this.qW.TabIndex = 2;
			this.qW.Text = "GT Auto-CCS by RealGoblins";
			this.Je.BackColor = Color.Silver;
			this.Je.BorderRadius = 5;
			this.Je.Location = new Point(42, 245);
			this.Je.MaximumValue = 100;
			this.Je.Name = "bunifuProgressBar1";
			this.Je.ProgressColor = Color.Teal;
			this.Je.Size = new Size(372, 27);
			this.Je.TabIndex = 0;
			this.Je.Value = 0;
			this.pe.animated = true;
			this.pe.animationIterval = 5;
			this.pe.animationSpeed = 300;
			this.pe.BackColor = Color.Black;
			this.pe.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuCircleProgressbar1.BackgroundImage");
			this.pe.Font = new Font("Microsoft Sans Serif", 26.25f);
			this.pe.ForeColor = Color.SeaGreen;
			this.pe.LabelVisible = true;
			this.pe.LineProgressThickness = 8;
			this.pe.LineThickness = 5;
			this.pe.Location = new Point(98, 47);
			this.pe.Margin = new Padding(10, 9, 10, 9);
			this.pe.MaxValue = 100;
			this.pe.Name = "bunifuCircleProgressbar1";
			this.pe.ProgressBackColor = Color.Black;
			this.pe.ProgressColor = Color.SeaGreen;
			this.pe.Size = new Size(169, 169);
			this.pe.TabIndex = 3;
			this.pe.Value = 30;
			this.ph.Color1 = Color.White;
			this.ph.Color2 = Color.White;
			this.ph.ProgessValue = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.Controls.Add(this.pe);
			base.Controls.Add(this.Je);
			base.Controls.Add(this.qW);
			base.Controls.Add(this.us);
			this.ForeColor = Color.White;
			base.Name = "Loading";
			base.Size = new Size(453, 305);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002E6 RID: 742
		private List<Color> pb = new List<Color>();

		// Token: 0x040002E7 RID: 743
		private int pc;

		// Token: 0x040002E8 RID: 744
		private int pd = 1;

		// Token: 0x040002E9 RID: 745
		private IContainer oL;

		// Token: 0x040002EA RID: 746
		private Panel us;

		// Token: 0x040002EB RID: 747
		private Label qW;

		// Token: 0x040002EC RID: 748
		private BunifuProgressBar Je;

		// Token: 0x040002ED RID: 749
		private BunifuCircleProgressbar pe;

		// Token: 0x040002EE RID: 750
		private BunifuColorTransition ph;

		// Token: 0x040002EF RID: 751
		private Timer pg;
	}
}
