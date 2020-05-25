using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using fG;
using LX;

namespace pq
{
	// Token: 0x02000071 RID: 113
	public partial class IE : Form
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00021C60 File Offset: 0x0001FE60
		public IE()
		{
			this.oZ();
			this.tO.Text = cF.Mq;
			this.IL.Text = cF.MC;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00021C90 File Offset: 0x0001FE90
		private void IM(object sender, EventArgs e)
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00021C94 File Offset: 0x0001FE94
		private void IP(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00021C9C File Offset: 0x0001FE9C
		private void IS(object sender, EventArgs e)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00021CA0 File Offset: 0x0001FEA0
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 132)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00021CC4 File Offset: 0x0001FEC4
		private void IV(object sender, EventArgs e)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00021CC8 File Offset: 0x0001FEC8
		private void IY(object sender, EventArgs e)
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00021CCC File Offset: 0x0001FECC
		public void Jb(string Jc)
		{
			this.tf.SelectTab(Jc);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00021D08 File Offset: 0x0001FF08
		private void oZ()
		{
			this.II = new iL();
			this.tf = new ni();
			this.IJ = new TabPage();
			this.qU = new Label();
			this.qW = new Label();
			this.rs = new PictureBox();
			this.tO = new kr();
			this.IK = new TabPage();
			this.IL = new kr();
			this.tf.SuspendLayout();
			this.IJ.SuspendLayout();
			((ISupportInitialize)this.rs).BeginInit();
			this.IK.SuspendLayout();
			base.SuspendLayout();
			this.II.BackColor = Color.Black;
			this.II.Font = new Font("Segoe UI", 14f);
			this.II.ForeColor = Color.White;
			this.II.ax = null;
			this.II.iA = ContentAlignment.MiddleLeft;
			this.II.Location = new Point(12, 393);
			this.II.Name = "iTalk_Button_21";
			this.II.Size = new Size(113, 29);
			this.II.TabIndex = 0;
			this.II.Text = "Close help";
			this.II.iE = StringAlignment.Center;
			this.II.Click += this.IP;
			this.tf.Alignment = TabAlignment.Left;
			this.tf.Controls.Add(this.IJ);
			this.tf.Controls.Add(this.IK);
			this.tf.DrawMode = TabDrawMode.OwnerDrawFixed;
			this.tf.ItemSize = new Size(44, 135);
			this.tf.Location = new Point(3, 2);
			this.tf.Multiline = true;
			this.tf.Name = "iTalk_TabControl1";
			this.tf.SelectedIndex = 0;
			this.tf.Size = new Size(781, 432);
			this.tf.SizeMode = TabSizeMode.Fixed;
			this.tf.TabIndex = 1;
			this.IJ.BackColor = Color.FromArgb(0, 0, 0);
			this.IJ.Controls.Add(this.qU);
			this.IJ.Controls.Add(this.qW);
			this.IJ.Controls.Add(this.rs);
			this.IJ.Controls.Add(this.tO);
			this.IJ.Location = new Point(139, 4);
			this.IJ.Name = "mouse";
			this.IJ.Padding = new Padding(3);
			this.IJ.Size = new Size(638, 424);
			this.IJ.TabIndex = 0;
			this.IJ.Text = "Help - Mouse";
			this.IJ.Click += this.IS;
			this.qU.AutoSize = true;
			this.qU.Location = new Point(377, 313);
			this.qU.Name = "label2";
			this.qU.Size = new Size(46, 13);
			this.qU.TabIndex = 3;
			this.qU.Text = "End pos";
			this.qW.AutoSize = true;
			this.qW.Location = new Point(206, 313);
			this.qW.Name = "label1";
			this.qW.Size = new Size(49, 13);
			this.qW.TabIndex = 2;
			this.qW.Text = "Start pos";
			this.rs.Image = cF.Me;
			this.rs.Location = new Point(167, 289);
			this.rs.Name = "pictureBox1";
			this.rs.Size = new Size(297, 128);
			this.rs.SizeMode = PictureBoxSizeMode.Zoom;
			this.rs.TabIndex = 1;
			this.rs.TabStop = false;
			this.tO.kD = false;
			this.tO.BackColor = Color.Transparent;
			this.tO.Font = new Font("Tahoma", 10f);
			this.tO.ForeColor = Color.White;
			this.tO.Location = new Point(6, 6);
			this.tO.Name = "iTalk_RichTextBox1";
			this.tO.jU = true;
			this.tO.Size = new Size(627, 280);
			this.tO.TabIndex = 0;
			this.tO.kz = true;
			this.tO.TextChanged += this.IV;
			this.IK.BackColor = Color.FromArgb(0, 0, 0);
			this.IK.Controls.Add(this.IL);
			this.IK.Location = new Point(139, 4);
			this.IK.Name = "unbanner";
			this.IK.Padding = new Padding(3);
			this.IK.Size = new Size(638, 424);
			this.IK.TabIndex = 1;
			this.IK.Text = "Help - Unbanner";
			this.IL.kD = false;
			this.IL.BackColor = Color.Transparent;
			this.IL.Font = new Font("Tahoma", 10f);
			this.IL.ForeColor = Color.White;
			this.IL.Location = new Point(5, 6);
			this.IL.Name = "iTalk_RichTextBox2";
			this.IL.jU = true;
			this.IL.Size = new Size(627, 410);
			this.IL.TabIndex = 1;
			this.IL.kz = true;
			this.IL.TextChanged += this.IY;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.ActiveCaptionText;
			base.ClientSize = new Size(787, 435);
			base.Controls.Add(this.II);
			base.Controls.Add(this.tf);
			this.ForeColor = Color.White;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "Help";
			this.Text = "Help";
			this.tf.ResumeLayout(false);
			this.IJ.ResumeLayout(false);
			this.IJ.PerformLayout();
			((ISupportInitialize)this.rs).EndInit();
			this.IK.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040002D9 RID: 729
		private const int IF = 132;

		// Token: 0x040002DA RID: 730
		private const int IG = 1;

		// Token: 0x040002DB RID: 731
		private const int IH = 2;

		// Token: 0x040002DD RID: 733
		private iL II;

		// Token: 0x040002DE RID: 734
		private ni tf;

		// Token: 0x040002DF RID: 735
		private TabPage IJ;

		// Token: 0x040002E0 RID: 736
		private kr tO;

		// Token: 0x040002E1 RID: 737
		private PictureBox rs;

		// Token: 0x040002E2 RID: 738
		private Label qU;

		// Token: 0x040002E3 RID: 739
		private Label qW;

		// Token: 0x040002E4 RID: 740
		private TabPage IK;

		// Token: 0x040002E5 RID: 741
		private kr IL;
	}
}
