using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using bR;
using Bunifu.Framework.UI;
using fG;
using Growtopia_macro.Properties;
using LX;
using oK;
using oo;

namespace pq
{
	// Token: 0x02000073 RID: 115
	public partial class Jj : Form
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x00022AC0 File Offset: 0x00020CC0
		public Jj()
		{
			this.Jp = new oI();
			this.oZ();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00022AFC File Offset: 0x00020CFC
		public void oS()
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.Jp.Show();
			}));
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00022B14 File Offset: 0x00020D14
		private void JE(object sender, EventArgs e)
		{
			Jj.<LogIn_Load>d__14 <LogIn_Load>d__;
			<LogIn_Load>d__.<>4__this = this;
			<LogIn_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LogIn_Load>d__.<>1__state = -1;
			AsyncVoidMethodBuilder <>t__builder = <LogIn_Load>d__.<>t__builder;
			<>t__builder.Start<Jj.<LogIn_Load>d__14>(ref <LogIn_Load>d__);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00022B50 File Offset: 0x00020D50
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 132)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00022B74 File Offset: 0x00020D74
		private void FO(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00022B7C File Offset: 0x00020D7C
		private void JJ(object JK)
		{
			this.JC.Enabled = true;
			this.JD.Enabled = true;
			this.JD.text = "Free";
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00022BA8 File Offset: 0x00020DA8
		private void JL(object JM)
		{
			this.JC.Enabled = true;
			this.JD.Enabled = true;
			if (this.JB.lx)
			{
				this.Ju = on.oq();
				this.JD.text = on.oq();
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00022BF8 File Offset: 0x00020DF8
		private void JN(object sender, EventArgs e)
		{
			if (this.JA.lx)
			{
				this.JD.text = "Free";
				return;
			}
			this.JD.text = this.Ju;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00022C34 File Offset: 0x00020E34
		public bool JQ()
		{
			return Jj.Jo;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00022C3C File Offset: 0x00020E3C
		public string JR()
		{
			return Jj.Jn;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00022C44 File Offset: 0x00020E44
		private void FR(object sender, EventArgs e)
		{
			this.Jp = new oI();
			this.Jp.Show();
			if (this.JA.lx)
			{
				Settings.Default.Premium = false;
			}
			else
			{
				Settings.Default.Premium = true;
			}
			Settings.Default.Save();
			if (this.JB.lx)
			{
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
						string[] array3 = this.yA(string.Concat(new string[]
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
						this.Jk = false;
						this.Jl = false;
						array2 = array3;
						int i = 0;
						while (i < array2.Length)
						{
							string text = array2[i];
							if (this.Jk || !(text.Split(new char[]
							{
								':'
							}).First<string>() == this.JC.text))
							{
								i++;
							}
							else
							{
								this.Jl = true;
								if (text.Split(new char[]
								{
									':'
								}).Last<string>() == this.Ju)
								{
									Settings.Default.Username = this.JC.text;
									Settings.Default.Save();
									Jj.Jn = this.JC.text + ":" + this.Ju;
									Jj.Jo = true;
									new pw(Jj.Jo, Jj.Jn, this.JC.text).Show();
									base.Hide();
								}
								else
								{
									MessageBox.Show("The username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									this.Jk = true;
									Jj.Jo = false;
								}
								IL_22F:
								if (!this.Jl)
								{
									MessageBox.Show("The username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									this.Jk = true;
									Jj.Jo = false;
									goto IL_26C;
								}
								goto IL_26C;
							}
						}
						goto IL_22F;
					}
					MessageBox.Show("Your device is currently blacklisted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					IL_26C:
					goto IL_3EC;
				}
				catch (Exception ex)
				{
					string str = "No internet connection, or cannot access database!? \n\rError: ";
					Exception ex2 = ex;
					MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					goto IL_3EC;
				}
			}
			try
			{
				byte[] bytes2 = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L1g1N1daWDlB");
				string string2 = Encoding.UTF8.GetString(bytes2);
				string[] array4 = this.yA(string2).Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.None);
				bool flag2 = false;
				string[] array2 = array4;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i].Split(new char[]
					{
						':'
					}).Last<string>() == on.oq())
					{
						flag2 = true;
					}
				}
				if (!flag2)
				{
					Settings.Default.Username = this.JC.text;
					Settings.Default.Save();
					Jj.Jo = false;
					new pw(Jj.Jo, Jj.Jn, this.JC.text).Show();
					base.Hide();
				}
				else
				{
					MessageBox.Show("Your device is currently blacklisted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex3)
			{
				string str2 = "Cannot access pastebin! \n\r Error: ";
				Exception ex4 = ex3;
				MessageBox.Show(str2 + ((ex4 != null) ? ex4.ToString() : null), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Settings.Default.Username = this.JC.text;
				Settings.Default.Save();
				Jj.Jo = false;
				new pw(Jj.Jo, Jj.Jn, this.JC.text).Show();
				base.Hide();
			}
			IL_3EC:
			this.Jp.Close();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0002307C File Offset: 0x0002127C
		private void Gg(object sender, EventArgs e)
		{
			new KC().Show();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00023088 File Offset: 0x00021288
		private void JW(object sender, DragEventArgs e)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0002308C File Offset: 0x0002128C
		private void JZ(object sender, DragEventArgs e)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00023090 File Offset: 0x00021290
		private void Kc(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00023094 File Offset: 0x00021294
		public void Kf()
		{
			try
			{
				WebClient webClient = new WebClient();
				WebProxy proxy = new WebProxy(this.Jy);
				webClient.Proxy = proxy;
				webClient.DownloadString(this.Jx);
				this.Jw = true;
			}
			catch (Exception)
			{
				this.Jw = false;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000230E8 File Offset: 0x000212E8
		public string yA(string Kg)
		{
			string result;
			try
			{
				Application.DoEvents();
				WebClient webClient = new WebClient();
				if (this.Jm)
				{
					webClient.Proxy = new WebProxy(this.Jr);
				}
				string text = webClient.DownloadString(Kg);
				Application.DoEvents();
				result = text;
			}
			catch (Exception)
			{
				int num = this.Kk("https://pastebin.com/");
				while (Jj.Jq < num || Jj.Jt.Enabled)
				{
					Application.DoEvents();
				}
				foreach (Jj.OG og in Jj.Js)
				{
					if (og.OV)
					{
						this.Jm = true;
						this.Jr = og.ON;
						Application.DoEvents();
						string result2 = new WebClient
						{
							Proxy = new WebProxy(this.Jr)
						}.DownloadString(Kg);
						Application.DoEvents();
						return result2;
					}
				}
				result = "0";
			}
			return result;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000231F0 File Offset: 0x000213F0
		private static void Kh(object sender, EventArgs e)
		{
			Jj.Jt.Stop();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000231FC File Offset: 0x000213FC
		public int Kk(string Kl)
		{
			Jj.Jq = 0;
			Jj.Js.Clear();
			if (File.Exists(Directory.GetCurrentDirectory() + "\\proxies.txt"))
			{
				foreach (string addr in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\proxies.txt"))
				{
					Jj.Js.Add(new Jj.OG(addr, "Unknown", false));
				}
				Jj.Jt.Interval = 10000;
				Jj.Jt.Start();
				bool test_res;
				Action<Jj.OG> <>9__1;
				Task.Factory.StartNew(delegate()
				{
					IEnumerable<Jj.OG> js = Jj.Js;
					ParallelOptions parallelOptions = new ParallelOptions();
					parallelOptions.MaxDegreeOfParallelism = 32;
					Action<Jj.OG> body;
					if ((body = <>9__1) == null)
					{
						body = (<>9__1 = delegate(Jj.OG proxy)
						{
							test_res = this.Km(proxy, Kl);
							Jj.Jq++;
							Console.WriteLine(Jj.Jq);
						});
					}
					Parallel.ForEach<Jj.OG>(js, parallelOptions, body);
				});
				return Jj.Js.Count<Jj.OG>();
			}
			return 0;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000232BC File Offset: 0x000214BC
		public bool Km(Jj.OG Kn, string Ko)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Ko);
			httpWebRequest.Proxy = new WebProxy(Kn.ON);
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36";
			httpWebRequest.Timeout = 2000;
			bool result;
			try
			{
				httpWebRequest.GetResponse();
				goto IL_55;
			}
			catch (Exception)
			{
				Kn.OV = false;
				Kn.OR = "Offline";
				result = false;
			}
			return result;
			IL_55:
			Kn.OV = true;
			Kn.OR = "Online";
			return true;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00023344 File Offset: 0x00021544
		private void FL(object sender, EventArgs e)
		{
			MessageBox.Show(cF.Mw, "Premium features", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0002335C File Offset: 0x0002155C
		private void Kr(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00023360 File Offset: 0x00021560
		private void Gd(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00023364 File Offset: 0x00021564
		private void Kw(object sender, EventArgs e)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00023398 File Offset: 0x00021598
		private void oZ()
		{
			Jj.<InitializeComponent>d__45 <InitializeComponent>d__;
			<InitializeComponent>d__.<>4__this = this;
			<InitializeComponent>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InitializeComponent>d__.<>1__state = -1;
			AsyncVoidMethodBuilder <>t__builder = <InitializeComponent>d__.<>t__builder;
			<>t__builder.Start<Jj.<InitializeComponent>d__45>(ref <InitializeComponent>d__);
		}

		// Token: 0x040002F0 RID: 752
		public bool Jk;

		// Token: 0x040002F1 RID: 753
		public bool Jl;

		// Token: 0x040002F2 RID: 754
		public bool Jm;

		// Token: 0x040002F3 RID: 755
		public static string Jn = "ä";

		// Token: 0x040002F4 RID: 756
		public static bool Jo = false;

		// Token: 0x040002F5 RID: 757
		public Form Jp;

		// Token: 0x040002F6 RID: 758
		public static int Jq = 0;

		// Token: 0x040002F7 RID: 759
		public string Jr = "";

		// Token: 0x040002F8 RID: 760
		public static List<Jj.OG> Js = new List<Jj.OG>();

		// Token: 0x040002F9 RID: 761
		private static System.Windows.Forms.Timer Jt = new System.Windows.Forms.Timer();

		// Token: 0x040002FA RID: 762
		public string Ju;

		// Token: 0x040002FB RID: 763
		public Thread Jv;

		// Token: 0x040002FC RID: 764
		private const int IF = 132;

		// Token: 0x040002FD RID: 765
		private const int IG = 1;

		// Token: 0x040002FE RID: 766
		private const int IH = 2;

		// Token: 0x040002FF RID: 767
		private bool Jw;

		// Token: 0x04000300 RID: 768
		private string Jx = "";

		// Token: 0x04000301 RID: 769
		private string Jy = "";

		// Token: 0x04000303 RID: 771
		private jA Jz;

		// Token: 0x04000304 RID: 772
		private lD JA;

		// Token: 0x04000305 RID: 773
		private lD JB;

		// Token: 0x04000306 RID: 774
		private jy tN;

		// Token: 0x04000307 RID: 775
		private BunifuTextbox JC;

		// Token: 0x04000308 RID: 776
		private BunifuTextbox JD;

		// Token: 0x04000309 RID: 777
		private BunifuThinButton2 ub;

		// Token: 0x0400030A RID: 778
		private BunifuThinButton2 ua;

		// Token: 0x0400030B RID: 779
		private BunifuThinButton2 uo;

		// Token: 0x0400030C RID: 780
		private Label qW;

		// Token: 0x0400030D RID: 781
		private Label qU;

		// Token: 0x0400030E RID: 782
		private Label qT;

		// Token: 0x0400030F RID: 783
		private BunifuThinButton2 tY;

		// Token: 0x02000074 RID: 116
		public class OG
		{
			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060003DE RID: 990 RVA: 0x00023410 File Offset: 0x00021610
			// (set) Token: 0x060003DF RID: 991 RVA: 0x00023418 File Offset: 0x00021618
			public string ON { get; set; }

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x00023424 File Offset: 0x00021624
			// (set) Token: 0x060003E1 RID: 993 RVA: 0x0002342C File Offset: 0x0002162C
			public string OR { get; set; }

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00023438 File Offset: 0x00021638
			// (set) Token: 0x060003E3 RID: 995 RVA: 0x00023440 File Offset: 0x00021640
			public bool OV { get; set; }

			// Token: 0x060003E4 RID: 996 RVA: 0x0002344C File Offset: 0x0002164C
			public OG(string addr, string s, bool r)
			{
				this.ON = addr;
				this.OR = s;
				this.OV = r;
			}

			// Token: 0x04000310 RID: 784
			[CompilerGenerated]
			private string OH;

			// Token: 0x04000311 RID: 785
			[CompilerGenerated]
			private string OI;

			// Token: 0x04000312 RID: 786
			[CompilerGenerated]
			private bool OJ;
		}
	}
}
