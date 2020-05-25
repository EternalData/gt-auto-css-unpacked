using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using bR;
using Bunifu.Framework.UI;
using fG;
using Growtopia_macro.Properties;
using LX;
using oo;

namespace pq
{
	// Token: 0x02000079 RID: 121
	public partial class KC : Form
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00023510 File Offset: 0x00021710
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00023518 File Offset: 0x00021718
		public string KQ { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00023524 File Offset: 0x00021724
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0002352C File Offset: 0x0002172C
		public string KU { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00023538 File Offset: 0x00021738
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00023540 File Offset: 0x00021740
		public string KY { get; set; }

		// Token: 0x060003F3 RID: 1011 RVA: 0x0002354C File Offset: 0x0002174C
		public KC()
		{
			this.oZ();
			this.KF = new WebClient();
			this.KE = on.oq();
			this.JD.text = on.oq();
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00023580 File Offset: 0x00021780
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 132)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000235A4 File Offset: 0x000217A4
		private void FO(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000235AC File Offset: 0x000217AC
		public string yA(string Lb)
		{
			string result;
			try
			{
				result = new WebClient().DownloadString(Lb);
			}
			catch (Exception)
			{
				try
				{
					WebClient webClient = new WebClient();
					WebProxy proxy = new WebProxy("104.211.157.43:3128");
					webClient.Proxy = proxy;
					result = webClient.DownloadString(Lb);
				}
				catch (Exception)
				{
					try
					{
						WebClient webClient2 = new WebClient();
						WebProxy proxy2 = new WebProxy("80.240.17.199:3128");
						webClient2.Proxy = proxy2;
						result = webClient2.DownloadString(Lb);
					}
					catch (Exception)
					{
						try
						{
							WebClient webClient3 = new WebClient();
							WebProxy proxy3 = new WebProxy("31.193.196.3:3128");
							webClient3.Proxy = proxy3;
							result = webClient3.DownloadString(Lb);
						}
						catch (Exception)
						{
							try
							{
								WebClient webClient4 = new WebClient();
								WebProxy proxy4 = new WebProxy("34.90.113.143:3128");
								webClient4.Proxy = proxy4;
								result = webClient4.DownloadString(Lb);
							}
							catch (Exception ex)
							{
								string str = "No internet? Shutting down for security reasons.  Error: ";
								Exception ex2 = ex;
								MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null));
								result = "0";
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000236BC File Offset: 0x000218BC
		private void FR(object sender, EventArgs e)
		{
			MessageBox.Show("Confirm purchase\r\n\r\nPrice/payment:\n\r> 1 DL\r\n> Donate the DL in the Growtopia world GTAutoCCS\r\n> As a comment, type your Discord Name#tag. If you won't pay, I will block your PC by putting the HWID in a blacklist");
			try
			{
				byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L1g1N1daWDlB");
				string @string = Encoding.UTF8.GetString(bytes);
				string[] array = this.yA(@string).Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.None);
				bool flag = false;
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i].Split(new char[]
					{
						':'
					}).Last<string>() == on.oq())
					{
						flag = true;
					}
				}
				if (!flag)
				{
					this.KD = false;
					array2 = this.yA(string.Concat(new string[]
					{
						bQ.ce(),
						"bin",
						Settings.Default.Setting1,
						"itLYJ",
						cF.MA
					})).Split(new string[]
					{
						Environment.NewLine
					}, StringSplitOptions.None);
					int i = 0;
					while (i < array2.Length)
					{
						string text = array2[i];
						if (!(text.Split(new char[]
						{
							':'
						}).First<string>() == this.JC.text))
						{
							if (!(text.Split(new char[]
							{
								':'
							}).Last<string>() == this.KE))
							{
								i++;
								continue;
							}
							MessageBox.Show("You already have premium. You cannot purchase it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.KD = true;
						}
						else
						{
							MessageBox.Show("That Username is already taken. Choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.KD = true;
						}
						IL_176:
						if (!this.KD)
						{
							this.JC.Visible = false;
							this.JD.Visible = false;
							this.KL.Visible = false;
							this.KM.Visible = false;
							this.rs.Visible = true;
							this.tO.Visible = false;
							this.ub.Visible = false;
							this.tN.Text = "You have successfully purchased Premium. The order will be processed within 36h";
							Ly ly = new Ly();
							ly.KY = "";
							ly.KU = "Bot";
							ly.KQ = string.Concat(new string[]
							{
								cF.My,
								"/api/webhooks/6887765934",
								Settings.Default.Setting,
								"jaRnIbTw2TrKmRa68",
								this.qW.Text
							});
							ly.vw(this.JC.text + ":" + this.JD.text);
							ly.Dispose();
							LE le = new LE();
							le.LV = "";
							le.LR = "Bot";
							le.LN = string.Concat(new string[]
							{
								cF.My,
								"/api/webhooks/6887765934",
								Settings.Default.Setting,
								"jaRnIbTw2TrKmRa68",
								this.qW.Text
							});
							le.vw(string.Concat(new string[]
							{
								"Username:",
								this.JC.text,
								"\r\nID",
								this.JD.text,
								"\r\nGrowID:",
								this.KL.text,
								"\r\nDiscord name:",
								this.KM.text
							}));
							le.Dispose();
							goto IL_361;
						}
						goto IL_361;
					}
					goto IL_176;
				}
				MessageBox.Show("Your device is currently blacklisted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				IL_361:;
			}
			catch (Exception)
			{
				MessageBox.Show("No internet connection!?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00023A60 File Offset: 0x00021C60
		private void JN(object sender, EventArgs e)
		{
			this.JD.text = this.KE;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00023A74 File Offset: 0x00021C74
		private void Gg(object sender, EventArgs e)
		{
			MessageBox.Show("", "Premium features and requirements", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00023A8C File Offset: 0x00021C8C
		private void IV(object sender, EventArgs e)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00023A90 File Offset: 0x00021C90
		private void Lk(object sender, EventArgs e)
		{
			this.tO.Text = cF.Mw;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00023AD0 File Offset: 0x00021CD0
		private void oZ()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KC));
			this.ua = new BunifuThinButton2();
			this.KK = new BunifuSeparator();
			this.JC = new BunifuTextbox();
			this.JD = new BunifuTextbox();
			this.KL = new BunifuTextbox();
			this.ub = new BunifuThinButton2();
			this.KM = new BunifuTextbox();
			this.rs = new PictureBox();
			this.qW = new Label();
			this.tN = new jy();
			this.Jz = new jA();
			this.qU = new Label();
			this.tO = new kr();
			this.tR = new jy();
			((ISupportInitialize)this.rs).BeginInit();
			base.SuspendLayout();
			this.ua.ActiveBorderThickness = 1;
			this.ua.ActiveCornerRadius = 20;
			this.ua.ActiveFillColor = Color.FromArgb(56, 56, 56);
			this.ua.ActiveForecolor = Color.White;
			this.ua.ActiveLineColor = Color.White;
			this.ua.BackColor = Color.Black;
			this.ua.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuThinButton22.BackgroundImage");
			this.ua.ButtonText = "Close";
			this.ua.Cursor = Cursors.Hand;
			this.ua.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ua.ForeColor = Color.White;
			this.ua.IdleBorderThickness = 1;
			this.ua.IdleCornerRadius = 20;
			this.ua.IdleFillColor = Color.FromArgb(36, 36, 36);
			this.ua.IdleForecolor = Color.White;
			this.ua.IdleLineColor = Color.White;
			this.ua.Location = new Point(407, 451);
			this.ua.Margin = new Padding(5);
			this.ua.Name = "bunifuThinButton22";
			this.ua.Size = new Size(62, 41);
			this.ua.TabIndex = 11;
			this.ua.TextAlign = ContentAlignment.MiddleCenter;
			this.ua.Click += this.FO;
			this.KK.BackColor = Color.Transparent;
			this.KK.LineColor = Color.FromArgb(105, 105, 105);
			this.KK.LineThickness = 1;
			this.KK.Location = new Point(95, 53);
			this.KK.Name = "bunifuSeparator1";
			this.KK.Size = new Size(289, 35);
			this.KK.TabIndex = 13;
			this.KK.Transparency = 255;
			this.KK.Vertical = false;
			this.JC.BackColor = Color.FromArgb(36, 36, 36);
			this.JC.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuTextbox1.BackgroundImage");
			this.JC.BackgroundImageLayout = ImageLayout.Stretch;
			this.JC.ForeColor = Color.White;
			this.JC.Icon = (Image)componentResourceManager.GetObject("bunifuTextbox1.Icon");
			this.JC.Location = new Point(58, 102);
			this.JC.Name = "bunifuTextbox1";
			this.JC.Size = new Size(351, 34);
			this.JC.TabIndex = 14;
			this.JC.text = "Username";
			this.JD.AllowDrop = true;
			this.JD.BackColor = Color.FromArgb(36, 36, 36);
			this.JD.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuTextbox2.BackgroundImage");
			this.JD.BackgroundImageLayout = ImageLayout.Stretch;
			this.JD.ForeColor = Color.White;
			this.JD.Icon = (Image)componentResourceManager.GetObject("bunifuTextbox2.Icon");
			this.JD.Location = new Point(58, 152);
			this.JD.Name = "bunifuTextbox2";
			this.JD.Size = new Size(351, 34);
			this.JD.TabIndex = 15;
			this.JD.text = "Password";
			this.JD.OnTextChange += this.JN;
			this.KL.AllowDrop = true;
			this.KL.BackColor = Color.FromArgb(36, 36, 36);
			this.KL.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuTextbox3.BackgroundImage");
			this.KL.BackgroundImageLayout = ImageLayout.Stretch;
			this.KL.ForeColor = Color.White;
			this.KL.Icon = (Image)componentResourceManager.GetObject("bunifuTextbox3.Icon");
			this.KL.Location = new Point(58, 202);
			this.KL.Name = "bunifuTextbox3";
			this.KL.Size = new Size(351, 34);
			this.KL.TabIndex = 16;
			this.KL.text = "GrowID";
			this.ub.ActiveBorderThickness = 1;
			this.ub.ActiveCornerRadius = 20;
			this.ub.ActiveFillColor = Color.FromArgb(56, 56, 56);
			this.ub.ActiveForecolor = Color.White;
			this.ub.ActiveLineColor = Color.White;
			this.ub.BackColor = Color.Black;
			this.ub.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuThinButton21.BackgroundImage");
			this.ub.ButtonText = "Send Order";
			this.ub.Cursor = Cursors.Hand;
			this.ub.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ub.ForeColor = Color.White;
			this.ub.IdleBorderThickness = 1;
			this.ub.IdleCornerRadius = 20;
			this.ub.IdleFillColor = Color.FromArgb(36, 36, 36);
			this.ub.IdleForecolor = Color.White;
			this.ub.IdleLineColor = Color.White;
			this.ub.Location = new Point(160, 451);
			this.ub.Margin = new Padding(5);
			this.ub.Name = "bunifuThinButton21";
			this.ub.Size = new Size(134, 41);
			this.ub.TabIndex = 17;
			this.ub.TextAlign = ContentAlignment.MiddleCenter;
			this.ub.Click += this.FR;
			this.KM.BackColor = Color.FromArgb(36, 36, 36);
			this.KM.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuTextbox4.BackgroundImage");
			this.KM.BackgroundImageLayout = ImageLayout.Stretch;
			this.KM.ForeColor = Color.White;
			this.KM.Icon = (Image)componentResourceManager.GetObject("bunifuTextbox4.Icon");
			this.KM.Location = new Point(58, 252);
			this.KM.Name = "bunifuTextbox4";
			this.KM.Size = new Size(351, 34);
			this.KM.TabIndex = 18;
			this.KM.text = "Discord Name#tag";
			this.rs.BackColor = Color.Black;
			this.rs.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage");
			this.rs.Location = new Point(79, 108);
			this.rs.Name = "pictureBox1";
			this.rs.Size = new Size(242, 178);
			this.rs.SizeMode = PictureBoxSizeMode.Zoom;
			this.rs.TabIndex = 20;
			this.rs.TabStop = false;
			this.rs.Visible = false;
			this.qW.AutoSize = true;
			this.qW.Location = new Point(235, 506);
			this.qW.Name = "label1";
			this.qW.Size = new Size(112, 13);
			this.qW.TabIndex = 21;
			this.qW.Text = "edKUVEwmTJif6Mx9z";
			this.tN.AllowDrop = true;
			this.tN.BackColor = Color.Transparent;
			this.tN.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tN.ForeColor = Color.LightGray;
			this.tN.Location = new Point(81, 326);
			this.tN.Name = "iTalk_Label1";
			this.tN.Size = new Size(296, 107);
			this.tN.TabIndex = 19;
			this.tN.Text = "RealGoblins#9029";
			this.Jz.AutoSize = true;
			this.Jz.BackColor = Color.Transparent;
			this.Jz.Font = new Font("Segoe UI", 25f);
			this.Jz.ForeColor = Color.FromArgb(255, 255, 192);
			this.Jz.Location = new Point(94, 20);
			this.Jz.Name = "iTalk_HeaderLabel1";
			this.Jz.Size = new Size(297, 46);
			this.Jz.TabIndex = 12;
			this.Jz.Text = "Purchase Premium";
			this.qU.AutoSize = true;
			this.qU.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.qU.ForeColor = Color.FromArgb(255, 128, 0);
			this.qU.Location = new Point(3, 5);
			this.qU.Name = "label2";
			this.qU.Size = new Size(184, 16);
			this.qU.TabIndex = 23;
			this.qU.Text = "GT Auto-CCS by RealGoblins";
			this.tO.kD = false;
			this.tO.BackColor = Color.Black;
			this.tO.Font = new Font("Tahoma", 10f);
			this.tO.ForeColor = Color.White;
			this.tO.Location = new Point(12, 313);
			this.tO.Name = "iTalk_RichTextBox1";
			this.tO.jU = true;
			this.tO.Size = new Size(459, 130);
			this.tO.TabIndex = 24;
			this.tO.Text = "RealGoblins#9029";
			this.tO.kz = true;
			this.tO.TextChanged += this.IV;
			this.tR.AutoSize = true;
			this.tR.BackColor = Color.Transparent;
			this.tR.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tR.ForeColor = Color.Silver;
			this.tR.Location = new Point(55, 76);
			this.tR.Name = "iTalk_Label2";
			this.tR.Size = new Size(231, 17);
			this.tR.TabIndex = 25;
			this.tR.Text = "Price: 1DL Pay in the world GTAutoCCS";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(483, 506);
			base.Controls.Add(this.tR);
			base.Controls.Add(this.tO);
			base.Controls.Add(this.qU);
			base.Controls.Add(this.qW);
			base.Controls.Add(this.rs);
			base.Controls.Add(this.tN);
			base.Controls.Add(this.KM);
			base.Controls.Add(this.ub);
			base.Controls.Add(this.KL);
			base.Controls.Add(this.JD);
			base.Controls.Add(this.JC);
			base.Controls.Add(this.Jz);
			base.Controls.Add(this.ua);
			base.Controls.Add(this.KK);
			this.ForeColor = Color.White;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "PurchasePremium";
			this.Text = "PurchasePremium";
			base.Load += this.Lk;
			((ISupportInitialize)this.rs).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400031D RID: 797
		public bool KD;

		// Token: 0x0400031E RID: 798
		public string KE;

		// Token: 0x0400031F RID: 799
		private readonly WebClient KF;

		// Token: 0x04000320 RID: 800
		private static NameValueCollection KG = new NameValueCollection();

		// Token: 0x04000321 RID: 801
		[CompilerGenerated]
		private string KH;

		// Token: 0x04000322 RID: 802
		[CompilerGenerated]
		private string KI;

		// Token: 0x04000323 RID: 803
		[CompilerGenerated]
		private string KJ;

		// Token: 0x04000324 RID: 804
		private const int IF = 132;

		// Token: 0x04000325 RID: 805
		private const int IG = 1;

		// Token: 0x04000326 RID: 806
		private const int IH = 2;

		// Token: 0x04000328 RID: 808
		private BunifuThinButton2 ua;

		// Token: 0x04000329 RID: 809
		private jA Jz;

		// Token: 0x0400032A RID: 810
		private BunifuSeparator KK;

		// Token: 0x0400032B RID: 811
		private BunifuTextbox JC;

		// Token: 0x0400032C RID: 812
		private BunifuTextbox JD;

		// Token: 0x0400032D RID: 813
		private BunifuTextbox KL;

		// Token: 0x0400032E RID: 814
		private BunifuThinButton2 ub;

		// Token: 0x0400032F RID: 815
		private BunifuTextbox KM;

		// Token: 0x04000330 RID: 816
		private jy tN;

		// Token: 0x04000331 RID: 817
		private PictureBox rs;

		// Token: 0x04000332 RID: 818
		private Label qW;

		// Token: 0x04000333 RID: 819
		private Label qU;

		// Token: 0x04000334 RID: 820
		private kr tO;

		// Token: 0x04000335 RID: 821
		private jy tR;
	}
}
