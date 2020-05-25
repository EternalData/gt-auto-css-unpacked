using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using bR;
using Bunifu.Framework.UI;
using cU;
using DotRas;
using fG;
using fk;
using Growtopia_macro.Properties;
using IWshRuntimeLibrary;
using LX;
using Memory;
using Microsoft.CSharp.RuntimeBinder;
using MySql.Data.MySqlClient;
using oo;
using Tesseract;

namespace pq
{
	// Token: 0x02000054 RID: 84
	public partial class pw : Form
	{
		// Token: 0x06000277 RID: 631
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool ReadProcessMemory(IntPtr uG, IntPtr uH, byte[] uI, int uJ, int uK);

		// Token: 0x06000278 RID: 632
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(pw.Os uM, bool uN, int uO);

		// Token: 0x06000279 RID: 633
		[DllImport("kernel32.dll")]
		public static extern bool VirtualProtectEx(int uQ, IntPtr uR, int uS, uint uT, out uint uU);

		// Token: 0x0600027A RID: 634
		[DllImport("kernel32.dll")]
		private static extern uint GetLastError();

		// Token: 0x0600027B RID: 635
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		public static extern bool ReadProcessMemory_1(int uW, IntPtr uX, byte[] uY, int uZ, ref int va);

		// Token: 0x0600027C RID: 636
		[DllImport("user32.dll", SetLastError = true)]
		private static extern void keybd_event(byte vc, byte vd, int ve, int vf);

		// Token: 0x0600027D RID: 637
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern uint MapVirtualKey(uint vh, uint vi);

		// Token: 0x0600027E RID: 638
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern short VkKeyScan(char vk);

		// Token: 0x0600027F RID: 639
		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr vm, int vn);

		// Token: 0x06000280 RID: 640
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr vp, out Rectangle vq);

		// Token: 0x06000281 RID: 641
		[DllImport("user32.dll")]
		private static extern int SendMessageA(IntPtr vs, uint vt, IntPtr vu, IntPtr vv);

		// Token: 0x06000282 RID: 642
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr vx, uint vy, IntPtr vz, IntPtr vA);

		// Token: 0x06000283 RID: 643
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private static extern int SendMessage_1(IntPtr vB, uint vC, UIntPtr vD, IntPtr vE);

		// Token: 0x06000284 RID: 644
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool PostMessage(IntPtr vG, uint vH, IntPtr vI, IntPtr vJ);

		// Token: 0x06000285 RID: 645
		[DllImport("User32.Dll")]
		protected static extern bool PostMessageA(IntPtr vK, uint vL, int vM, int vN);

		// Token: 0x06000286 RID: 646
		[DllImport("user32.dll")]
		private static extern int SetWindowText(IntPtr vP, string vQ);

		// Token: 0x06000287 RID: 647
		[DllImport("USER32.DLL")]
		public static extern bool SetForegroundWindow(IntPtr vS);

		// Token: 0x06000288 RID: 648
		[DllImport("user32.dll")]
		private static extern bool AllowSetForegroundWindow(IntPtr vU);

		// Token: 0x06000289 RID: 649
		[DllImport("User32.dll")]
		public static extern IntPtr GetDC(IntPtr vW);

		// Token: 0x0600028A RID: 650
		[DllImport("User32.dll")]
		public static extern void ReleaseDC(IntPtr vY, IntPtr vZ);

		// Token: 0x0600028B RID: 651
		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();

		// Token: 0x0600028C RID: 652
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600028D RID: 653
		[DllImport("ntdll.dll")]
		private static extern uint NtQuerySystemInformation(uint wd, IntPtr we, int wf, ref int wg);

		// Token: 0x0600028E RID: 654
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		public static extern IntPtr OpenProcess_1(uint wh, [MarshalAs(UnmanagedType.Bool)] bool wi, int wj);

		// Token: 0x0600028F RID: 655
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x06000290 RID: 656
		[DllImport("kernel32.dll")]
		public static extern int CloseHandle(IntPtr wm);

		// Token: 0x06000291 RID: 657
		[DllImport("ntdll.dll")]
		public static extern int NtQueryObject(IntPtr wo, int wp, IntPtr wq, int wr, ref int ws);

		// Token: 0x06000292 RID: 658
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool DuplicateHandle(IntPtr wv, ushort ww, IntPtr wx, out IntPtr wy, uint wz, [MarshalAs(UnmanagedType.Bool)] bool wA, uint wB);

		// Token: 0x06000293 RID: 659
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(int wD, bool wE, uint wF);

		// Token: 0x06000294 RID: 660
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr wH);

		// Token: 0x06000295 RID: 661
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr wJ);

		// Token: 0x06000296 RID: 662
		[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
		private static extern bool GetWindowRect_1(IntPtr wK, ref pw.NW wL);

		// Token: 0x06000297 RID: 663
		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr wN, out uint wO);

		// Token: 0x06000298 RID: 664
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool FlashWindowEx(ref pw.NZ wR);

		// Token: 0x06000299 RID: 665
		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern IntPtr FindWindow(string wT, string wU);

		// Token: 0x0600029A RID: 666 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		private static pw.NZ wV(IntPtr wW, uint wX, uint wY, uint wZ)
		{
			pw.NZ nz = default(pw.NZ);
			nz.Oa = Convert.ToUInt32(Marshal.SizeOf<pw.NZ>(nz));
			nz.Ni = wW;
			nz.Ob = wX;
			nz.Oc = wY;
			nz.Od = wZ;
			return nz;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0000F200 File Offset: 0x0000D400
		private string uE
		{
			get
			{
				return this.pS;
			}
			set
			{
				if (File.Exists(value))
				{
					this.pS = value;
				}
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000F214 File Offset: 0x0000D414
		public pw(bool ad, string bd, string u)
		{
			this.oZ();
			pw.qh = bd;
			pw.qg = ad;
			this.qL = u;
			if (ad)
			{
				try
				{
					if (this.yA(string.Concat(new string[]
					{
						bQ.ce(),
						"bin",
						Settings.Default.Setting1,
						"itLYJ",
						cF.MA
					})).Contains(bd))
					{
						this.tB.Text = "Account type: Premium";
						this.tB.ForeColor = Color.GreenYellow;
					}
					else
					{
						this.tB.Text = "Account type: Free";
					}
					goto IL_135;
				}
				catch (Exception ex)
				{
					string str = "Can access the internet. Your account type will be set Free. Try to re-log in when you have a stable internet connection and/or VPN.\n\rException: ";
					Exception ex2 = ex;
					MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null));
					this.tB.Text = "Account type: Free";
					goto IL_135;
				}
			}
			this.tB.Text = "Account type: Free";
			IL_135:
			this.tC.Text = "User: " + u;
			this.BP(1000);
			if (pw.qh != bd)
			{
				base.Close();
			}
			if (pw.qg != ad)
			{
				base.Close();
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		private void xa(object sender, EventArgs e)
		{
			this.rg.Checked = false;
			this.xd();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		private void xd()
		{
			if (this.qY.SelectedItem != null)
			{
				this.qV.Text = this.qk[this.qY.SelectedItem.ToString()].HG;
				this.rb.Value = this.qk[this.qY.SelectedItem.ToString()].Ir;
				this.ra.Value = this.qk[this.qY.SelectedItem.ToString()].Iv;
				this.ri.Value = this.qk[this.qY.SelectedItem.ToString()].Iz;
				this.rh.Value = this.qk[this.qY.SelectedItem.ToString()].ID;
				for (int k = 0; k < this.re.Items.Count; k++)
				{
					this.re.SetItemChecked(k, false);
					if (this.qj.ContainsKey(this.re.Items[k].ToString()) && this.qj[this.re.Items[k].ToString()].HG == this.qY.SelectedItem.ToString())
					{
						this.re.SetItemChecked(k, true);
					}
				}
				if (this.qY.GetItemCheckState(this.qY.SelectedIndex) == CheckState.Checked)
				{
					int i;
					ThreadStart <>9__0;
					int i2;
					for (i = 0; i < this.re.Items.Count; i = i2 + 1)
					{
						if (this.qj[this.re.Items[i].ToString()].HG == this.qY.SelectedItem.ToString() && !this.qj[this.re.Items[i].ToString()].HK)
						{
							this.qj[this.re.Items[i].ToString()].HK = true;
							this.qj[this.re.Items[i].ToString()].HO = false;
							ThreadStart start;
							if ((start = <>9__0) == null)
							{
								start = (<>9__0 = delegate()
								{
									this.ys(this.qj[this.re.Items[i].ToString()]);
								});
							}
							new Thread(start).Start();
							Thread.Sleep(250);
						}
						i2 = i;
					}
					return;
				}
				for (int j = 0; j < this.re.Items.Count; j++)
				{
					if (this.qj[this.re.Items[j].ToString()].HG == this.qY.SelectedItem.ToString() && this.qj[this.re.Items[j].ToString()].HK)
					{
						this.qj[this.re.Items[j].ToString()].HK = false;
						this.qj[this.re.Items[j].ToString()].HO = false;
					}
				}
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000F79C File Offset: 0x0000D99C
		private void xe(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		private void xh(object sender, EventArgs e)
		{
			for (int i = 0; i < this.re.Items.Count; i++)
			{
				if (this.rg.Checked)
				{
					this.re.SetItemChecked(i, true);
				}
				else
				{
					this.re.SetItemChecked(i, false);
				}
			}
			this.yg();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		private void xk(object sender, EventArgs e)
		{
			this.qF = 1;
			this.qq.eU();
			MessageBox.Show("Put the window in foreground, hover the cursor over the position you'd like to select and press Space");
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000F818 File Offset: 0x0000DA18
		private void xn(object sender, EventArgs e)
		{
			if (!this.qk.ContainsKey(this.qV.Text))
			{
				this.qk.Add(this.qV.Text, new Ii(this.qV.Text, (int)this.rb.Value, (int)this.ra.Value, (int)this.ri.Value, (int)this.rh.Value));
				this.ym();
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000F8AC File Offset: 0x0000DAAC
		private void xq(object sender, EventArgs e)
		{
			for (int i = 0; i < this.qY.Items.Count; i++)
			{
				if (this.rf.Checked)
				{
					this.qY.ClearSelected();
					this.qY.SetSelected(i, true);
					this.qY.SetItemChecked(i, true);
					this.xd();
				}
				else
				{
					this.qY.ClearSelected();
					this.qY.SetSelected(i, true);
					this.qY.SetItemChecked(i, false);
					this.xd();
				}
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000F93C File Offset: 0x0000DB3C
		private void xt(object sender, EventArgs e)
		{
			this.qF = 2;
			this.qq.eU();
			MessageBox.Show("Put the window in foreground, hover the cursor over the position you'd like to select and press Space");
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000F95C File Offset: 0x0000DB5C
		private void xw(object sender, EventArgs e)
		{
			this.tV.Checked = false;
			this.CD();
			this.CC();
			this.uE = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\Local\\Growtopia\\Growtopia.exe";
			this.rn.Visible = false;
			this.qo = new cT();
			this.qo.dE += this.yU;
			this.qo.dJ += this.zy;
			this.qo.dY += this.zB;
			this.qq = new cT();
			this.qq.en += this.zE;
			this.qr = new cT();
			this.qr.en += this.zQ;
			this.qp = new cT();
			this.qp.dO += this.yX;
			this.qp.dT += this.za;
			this.qp.dY += this.zd;
			this.qp.ed += this.zg;
			this.qp.en += this.zH;
			this.qp.ex += this.zK;
			pw.qn.Tick += pw.zj;
			this.qo.eX();
			this.qp.eX();
			this.qq.eX();
			this.qr.eX();
			pw.qn.Stop();
			this.qE = 0;
			this.qy = false;
			this.qG = false;
			this.qH = false;
			this.qD = new Form();
			this.qD.BackColor = Color.LightBlue;
			this.qD.TransparencyKey = Color.Black;
			this.qD.Opacity = 0.5;
			this.qD.FormBorderStyle = FormBorderStyle.None;
			this.qD.Bounds = new Rectangle(0, 0, 0, 0);
			this.qD.TopMost = true;
			this.qD.Hide();
			this.qJ = this.Ab();
			pw.AllowSetForegroundWindow(pw.GetCurrentProcess());
			this.yr();
			this.ur.Items.Clear();
			for (int i = 1; i < Environment.ProcessorCount + 1; i++)
			{
				this.ur.Items.Add("Thread: " + i.ToString(), true);
			}
			this.uz.SelectedIndex = 1;
			this.uq.SelectedIndex = 3;
			this.rV.View = View.Details;
			this.sg.Visible = false;
			this.sf.SelectedItem = "/pull";
			this.sT.SelectedIndex = this.sT.Items.Count - 1;
			for (int j = 0; j < this.rV.Columns.Count; j++)
			{
				this.rV.Columns[j].Width = -2;
			}
			bQ.cb(this);
			this.pW = new Thread(new ThreadStart(this.xF))
			{
				IsBackground = true
			};
			this.pX = new Thread(new ThreadStart(this.xC))
			{
				IsBackground = true
			};
			this.pW.Start();
			this.pZ = new Thread(new ThreadStart(this.xB))
			{
				IsBackground = true
			};
			this.pZ.Start();
			this.sY.Hide();
			this.sZ.Show();
			this.te.Enabled = true;
			this.sY.Enabled = false;
			this.sZ.Enabled = false;
			this.ta.Enabled = false;
			this.tr.Enabled = false;
			this.tq.Enabled = false;
			this.tp.Enabled = false;
			try
			{
				this.qK = new MySqlConnection("Server=auto-ccs.duckdns.org; Port=47700; Uid=7aVrfaFU9PtVG7CX; Pwd=ZUf2aKrzH9Mr668A;SSL Mode=Required");
				this.qK.Open();
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM AutoCCS.Users", this.qK);
				DataSet dataSet = new DataSet();
				mySqlDataAdapter.Fill(dataSet, "HWID");
				dataSet.Dispose();
				mySqlDataAdapter.Dispose();
				try
				{
					Cursor.Current = Cursors.AppStarting;
					this.xU();
					Application.DoEvents();
					Console.WriteLine("Users online: " + this.xW());
					Cursor.Current = Cursors.Default;
					this.un.Text = "Users online: " + this.xW();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				try
				{
					this.xR();
					this.qK.Close();
				}
				catch (Exception)
				{
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message + " You can still continue.");
			}
			if (Settings.Default.RunFirst.ToString() == "true")
			{
				this.CE();
				Settings.Default.RunFirst = "false";
				Settings.Default.Save();
			}
			if (pw.qg)
			{
				try
				{
					if (this.yA(string.Concat(new string[]
					{
						bQ.ce(),
						"bin",
						Settings.Default.Setting1,
						"itLYJ",
						cF.MA
					})).Contains(pw.qh))
					{
						this.tB.Text = "Account type: Premium";
					}
					else
					{
						this.tB.Text = "Account type: Free";
						this.sc.Enabled = false;
						this.tt.Enabled = false;
						this.tt.Checked = false;
						this.ts.Enabled = false;
						this.ts.Checked = false;
						this.tx.Checked = false;
						this.tw.Checked = false;
					}
					goto IL_6F4;
				}
				catch (Exception ex3)
				{
					string str = "Can access the internet. Your account type will be set Free. Try to re-log in when you have a stable internet connection.\n\rException: ";
					Exception ex4 = ex3;
					MessageBox.Show(str + ((ex4 != null) ? ex4.ToString() : null));
					this.tB.Text = "Account type: Free";
					this.sc.Enabled = false;
					this.tt.Enabled = false;
					this.tt.Checked = false;
					this.ts.Enabled = false;
					this.ts.Checked = false;
					this.tx.Checked = false;
					this.tw.Checked = false;
					throw;
				}
			}
			this.tB.Text = "Account type: Free";
			this.tt.Enabled = false;
			this.tt.Checked = false;
			this.ts.Enabled = false;
			this.ts.Checked = false;
			this.tx.Checked = false;
			this.tw.Checked = false;
			this.sc.Enabled = false;
			IL_6F4:
			try
			{
				byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L0oxNEV1c1ZB");
				string @string = Encoding.UTF8.GetString(bytes);
				string[] array = this.yA(@string).Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.None);
				this.sT.Items.Add(array[0]);
			}
			catch (Exception)
			{
			}
			this.tS.Items.Clear();
			if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Accounts\\"))
			{
				for (int k = 0; k < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); k++)
				{
					this.tS.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[k]));
				}
			}
			if (this.tB.Text == "Account type: Free")
			{
				this.tZ.Checked = false;
			}
			else
			{
				if (Settings.Default.SL)
				{
					this.tZ.Checked = true;
				}
				if (this.tZ.Checked)
				{
					this.xz();
				}
			}
			Settings.Default.Save();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000101C8 File Offset: 0x0000E3C8
		public void xz()
		{
			this.rz.Value = Settings.Default.no_GT_windows;
			this.tX.Value = Settings.Default.iTalk_NumericUpDown1;
			this.tT.Checked = Settings.Default.checkBox8;
			this.tV.Checked = Settings.Default.checkBox9;
			if (Settings.Default.maskedTextBox2 != "")
			{
				this.rY.Text = Settings.Default.maskedTextBox2;
			}
			this.sf.SelectedIndex = Settings.Default.comboBox1;
			this.sg.Text = Settings.Default.textBox1;
			this.so.Value = Settings.Default.numericUpDown5;
			this.rG.Text = Settings.Default.SpammerText1;
			this.tr.Text = Settings.Default.SpammerText2;
			this.tq.Text = Settings.Default.SpammerText3;
			this.tp.Text = Settings.Default.SpammerText4;
			this.tv.Checked = Settings.Default.SpamTxt1;
			this.tu.Checked = Settings.Default.SpamTxt2;
			this.tt.Checked = Settings.Default.SpamTxt3;
			this.ts.Checked = Settings.Default.SpamTxt4;
			this.rU.Checked = Settings.Default.AddInFrontCheckBox;
			this.rQ.Checked = Settings.Default.MsgSpamCheckBox;
			this.tx.Checked = Settings.Default.checkBox6;
			this.tw.Checked = Settings.Default.checkBox7;
			this.rO.Text = Settings.Default.MsgSpamTo;
			this.rR.Text = Settings.Default.addInFront;
			this.rL.Value = Settings.Default.SpamDelay;
			this.tH.Value = Settings.Default.trackBar2;
			this.qk.Clear();
			for (int i = 0; i < Settings.Default.SavedMacros.Count; i += 5)
			{
				string text = Settings.Default.SavedMacros[i];
				int xs = int.Parse(Settings.Default.SavedMacros[i + 1]);
				int ys = int.Parse(Settings.Default.SavedMacros[i + 2]);
				int xe = int.Parse(Settings.Default.SavedMacros[i + 3]);
				int ye = int.Parse(Settings.Default.SavedMacros[i + 4]);
				this.qk.Add(text, new Ii(text, xs, ys, xe, ye));
			}
			this.ym();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000104A4 File Offset: 0x0000E6A4
		public void xA()
		{
			Settings.Default.no_GT_windows = (int)this.rz.Value;
			Settings.Default.Save();
			Settings.Default.checkBox8 = this.tT.Checked;
			Settings.Default.Save();
			Settings.Default.checkBox9 = this.tT.Checked;
			Settings.Default.Save();
			Settings.Default.iTalk_NumericUpDown1 = this.tX.Value;
			Settings.Default.Save();
			Settings.Default.maskedTextBox2 = this.rY.Text;
			Settings.Default.Save();
			Settings.Default.comboBox1 = this.sf.SelectedIndex;
			Settings.Default.Save();
			Settings.Default.textBox1 = this.sg.Text;
			Settings.Default.Save();
			Settings.Default.numericUpDown5 = this.so.Value;
			Settings.Default.Save();
			Settings.Default.SpammerText1 = this.rG.Text;
			Settings.Default.Save();
			Settings.Default.SpammerText2 = this.rG.Text;
			Settings.Default.Save();
			Settings.Default.SpammerText3 = this.rG.Text;
			Settings.Default.Save();
			Settings.Default.SpammerText4 = this.rG.Text;
			Settings.Default.SpamTxt1 = this.tv.Checked;
			Settings.Default.SpamTxt2 = this.tu.Checked;
			Settings.Default.SpamTxt3 = this.tt.Checked;
			Settings.Default.SpamTxt4 = this.ts.Checked;
			Settings.Default.Save();
			Settings.Default.AddInFrontCheckBox = this.rU.Checked;
			Settings.Default.Save();
			Settings.Default.MsgSpamCheckBox = this.rQ.Checked;
			Settings.Default.Save();
			Settings.Default.checkBox6 = this.tx.Checked;
			Settings.Default.Save();
			Settings.Default.checkBox7 = this.tw.Checked;
			Settings.Default.Save();
			Settings.Default.addInFront = this.rR.Text;
			Settings.Default.Save();
			Settings.Default.MsgSpamTo = this.rO.Text;
			Settings.Default.Save();
			Settings.Default.SpamDelay = this.rL.Value;
			Settings.Default.Save();
			Settings.Default.trackBar2 = this.tH.Value;
			Settings.Default.Save();
			StringCollection stringCollection = new StringCollection();
			foreach (Ii ii in this.qk.Values)
			{
				stringCollection.Add(ii.HG);
				stringCollection.Add(ii.Ir.ToString());
				stringCollection.Add(ii.Iv.ToString());
				stringCollection.Add(ii.Iz.ToString());
				stringCollection.Add(ii.ID.ToString());
			}
			Settings.Default.SavedMacros = stringCollection;
			Settings.Default.Save();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00010834 File Offset: 0x0000EA34
		public void xB()
		{
			Thread.Sleep(1200);
			for (;;)
			{
				try
				{
					if (!this.pZ.IsAlive)
					{
						Application.Exit();
					}
					this.xU();
					Application.DoEvents();
					Console.WriteLine("Users online: " + this.xW());
					a.b(this, this.un, "Users online: " + this.xW());
					try
					{
						this.xR();
						this.qK.Close();
					}
					catch (Exception)
					{
					}
				}
				catch (Exception)
				{
				}
				Thread.Sleep(120000);
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000108DC File Offset: 0x0000EADC
		public void xC()
		{
			for (;;)
			{
				try
				{
					if (!this.pW.IsAlive)
					{
						Application.Exit();
					}
					if (!this.pZ.IsAlive)
					{
						Application.Exit();
					}
					goto IL_177;
				}
				catch (ThreadInterruptedException value)
				{
					Console.WriteLine(value);
					Application.Exit();
					goto IL_177;
				}
				goto IL_39;
				IL_168:
				Thread.Sleep(10000);
				continue;
				IL_39:
				try
				{
					if (this.yA(string.Concat(new string[]
					{
						bQ.ce(),
						"bin",
						Settings.Default.Setting1,
						"itLYJ",
						cF.MA
					})).Contains(pw.qh))
					{
						this.tB.Text = "Account type: Premium";
					}
					else
					{
						this.tB.Text = "Account type: Free";
						this.sc.Enabled = false;
						this.tt.Enabled = false;
						this.tt.Checked = false;
						this.ts.Enabled = false;
						this.ts.Checked = false;
						this.tx.Checked = false;
						this.tw.Checked = false;
					}
					goto IL_168;
				}
				catch (Exception)
				{
					throw;
				}
				IL_104:
				this.tB.Text = "Account type: Free";
				this.sc.Enabled = false;
				this.tt.Enabled = false;
				this.tt.Checked = false;
				this.ts.Enabled = false;
				this.ts.Checked = false;
				this.tx.Checked = false;
				this.tw.Checked = false;
				goto IL_168;
				IL_177:
				if (pw.qg)
				{
					goto IL_39;
				}
				goto IL_104;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00010A88 File Offset: 0x0000EC88
		public string xD(string xE)
		{
			string @string;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(xE))
				{
					@string = Encoding.Default.GetString(md.ComputeHash(fileStream));
				}
			}
			return @string;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		public void xF()
		{
			this.pX.Start();
			while (!this.pX.IsAlive)
			{
				Thread.Sleep(500);
			}
			for (;;)
			{
				try
				{
					if (pw.qg)
					{
						try
						{
							if (this.yA(string.Concat(new string[]
							{
								bQ.ce(),
								"bin",
								Settings.Default.Setting1,
								"itLYJ",
								cF.MA
							})).Contains(pw.qh))
							{
								this.tB.Text = "Account type: Premium";
							}
							else
							{
								this.tB.Text = "Account type: Free";
								this.sc.Enabled = false;
								this.tt.Enabled = false;
								this.tt.Checked = false;
								this.ts.Enabled = false;
								this.ts.Checked = false;
								this.tx.Checked = false;
								this.tw.Checked = false;
							}
							goto IL_15D;
						}
						catch (Exception)
						{
							throw;
						}
					}
					this.tB.Text = "Account type: Free";
					this.sc.Enabled = false;
					this.tt.Enabled = false;
					this.tt.Checked = false;
					this.ts.Enabled = false;
					this.ts.Checked = false;
					this.tx.Checked = false;
					this.tw.Checked = false;
					IL_15D:
					if (this.Text != "GT Auto-CCS by RealGoblins")
					{
						Console.WriteLine("error1");
						Application.Exit();
					}
					string fileName = Path.GetFileName(Application.ExecutablePath);
					if (fileName != "GT Auto-CCS by RealGoblins.exe")
					{
						File.Move(fileName, "GT Auto-CCS by RealGoblins.exe");
					}
					if (this.su.Width != 585 | this.su.Height != 31)
					{
						Console.WriteLine("error2");
						Application.Exit();
					}
					if (this.sP.Text != "By RealGoblins" | this.sP.Size.Width != 121 | this.sP.Size.Height != 23 | !this.sP.Visible | this.sP.Font.Size != 12f)
					{
						Console.WriteLine("error3");
						Application.Exit();
					}
					if (!this.pX.IsAlive)
					{
						Application.Exit();
					}
				}
				catch (ThreadInterruptedException value)
				{
					Console.WriteLine(value);
					Application.Exit();
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		private void xG(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00010DBC File Offset: 0x0000EFBC
		private void xJ(object sender, EventArgs e)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00010DC0 File Offset: 0x0000EFC0
		public string xM(string xN)
		{
			string result = "";
			string text = "joaDSKds";
			string text2 = "joaDSKds";
			byte[] rgbIV = new byte[0];
			rgbIV = Encoding.UTF8.GetBytes(text2.Substring(0, 8));
			byte[] rgbKey = new byte[0];
			rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
			byte[] bytes = Encoding.UTF8.GetBytes(xN);
			using (DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider())
			{
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				result = Convert.ToBase64String(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00010E7C File Offset: 0x0000F07C
		public static string xO(string xP)
		{
			string result = "";
			string text = "joaDSKds";
			string text2 = "joaDSKds";
			byte[] rgbIV = new byte[0];
			rgbIV = Encoding.UTF8.GetBytes(text2.Substring(0, 8));
			byte[] rgbKey = new byte[0];
			rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
			byte[] array = new byte[xP.Replace(" ", "+").Length];
			array = Convert.FromBase64String(xP.Replace(" ", "+"));
			using (DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider())
			{
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, descryptoServiceProvider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				result = Encoding.UTF8.GetString(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00010F6C File Offset: 0x0000F16C
		public void xQ()
		{
			if (this.qK.State == ConnectionState.Closed)
			{
				this.qK.Open();
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00010F88 File Offset: 0x0000F188
		public void xR()
		{
			if (this.qK.State == ConnectionState.Open)
			{
				this.qK.Close();
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		public void xS(string xT)
		{
			try
			{
				this.xQ();
				this.qM = new MySqlCommand(xT, this.qK);
				this.qM.ExecuteNonQuery();
			}
			catch (Exception)
			{
			}
			finally
			{
				this.xR();
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00011000 File Offset: 0x0000F200
		public void xU()
		{
			string cmdText = "select * from AutoCCS.Users where HWID='" + on.oq() + "'";
			this.qM = new MySqlCommand(cmdText, this.qK);
			MySqlDataReader mySqlDataReader = this.qM.ExecuteReader();
			bool flag = false;
			if (mySqlDataReader.Read())
			{
				mySqlDataReader[0].ToString();
				if (mySqlDataReader[0].ToString() != "")
				{
					mySqlDataReader.Close();
					flag = true;
					string text = DateTime.UtcNow.ToString("yyyy:MM:dd:hh:mm");
					string cmdText2 = string.Concat(new string[]
					{
						"UPDATE AutoCCS.Users SET latestOnline = '",
						text,
						"', LatestName='",
						this.qL,
						"'  Where HWID='",
						on.oq(),
						"'"
					});
					this.qM = new MySqlCommand(cmdText2, this.qK);
					this.qM.ExecuteReader().Close();
				}
				else
				{
					mySqlDataReader.Close();
				}
			}
			if (!flag)
			{
				string text2 = DateTime.UtcNow.ToString("yyyy:MM:dd:hh:mm");
				string cmdText3 = string.Concat(new string[]
				{
					"INSERT INTO AutoCCS.Users(HWID, online, latestOnline, registered, LatestName) VALUES('",
					on.oq(),
					"', false, '",
					text2,
					"', '",
					text2,
					"', LatestName='",
					this.qL,
					"')"
				});
				this.qM = new MySqlCommand(cmdText3, this.qK);
				this.qM.ExecuteReader().Close();
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00011190 File Offset: 0x0000F390
		public void xV()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00011194 File Offset: 0x0000F394
		public string xW()
		{
			string cmdText = "select * from AutoCCS.Users";
			this.qM = new MySqlCommand(cmdText, this.qK);
			MySqlDataReader mySqlDataReader = this.qM.ExecuteReader();
			List<string> list = new List<string>();
			while (mySqlDataReader.Read())
			{
				string text = mySqlDataReader["Latestonline"].ToString();
				string s = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
				DateTime dateTime = DateTime.Parse(text);
				DateTime dateTime2 = DateTime.Parse(s);
				if (!(dateTime >= dateTime2) && (int)(dateTime2 - dateTime).TotalMinutes < 2)
				{
					list.Add(text);
					Console.WriteLine(text);
				}
			}
			mySqlDataReader.Close();
			using (MySqlCommand mySqlCommand = new MySqlCommand("SELECT COUNT(*) FROM AutoCCS.Users", this.qK))
			{
				int num = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				a.b(this, this.up, "Unique accounts: " + num.ToString());
			}
			return list.Count.ToString();
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000112AC File Offset: 0x0000F4AC
		private void xX(object sender, EventArgs e)
		{
			this.yr();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000112B4 File Offset: 0x0000F4B4
		private void ya(object sender, EventArgs e)
		{
			if (this.re.SelectedItem != null)
			{
				foreach (Process process in Process.GetProcessesByName("Growtopia"))
				{
					IntPtr mainWindowHandle = process.MainWindowHandle;
					if (process.MainWindowTitle == this.re.SelectedItem.ToString())
					{
						pw.SetForegroundWindow(process.MainWindowHandle);
					}
				}
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001131C File Offset: 0x0000F51C
		private void yd(object sender, EventArgs e)
		{
			for (int i = 0; i < this.re.Items.Count; i++)
			{
				if (this.re.GetItemCheckState(i) == CheckState.Unchecked)
				{
					this.rg.Checked = false;
				}
			}
			this.yg();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00011364 File Offset: 0x0000F564
		private void yg()
		{
			if (this.qY.SelectedItem != null)
			{
				for (int i = 0; i < this.re.Items.Count; i++)
				{
					if (this.re.GetItemCheckState(i) == CheckState.Checked)
					{
						if (this.qj.ContainsKey(this.re.Items[i].ToString()))
						{
							this.qj[this.re.Items[i].ToString()].HG = this.qY.SelectedItem.ToString();
							this.qj[this.re.Items[i].ToString()].HK = false;
							this.qj[this.re.Items[i].ToString()].HO = false;
						}
						else
						{
							this.qj.Add(this.re.Items[i].ToString(), new Hs(this.re.Items[i].ToString(), this.qY.SelectedItem.ToString(), false, false, false, false));
						}
					}
					else if (this.qj.ContainsKey(this.re.Items[i].ToString()) && this.qj[this.re.Items[i].ToString()].HG == this.qY.SelectedItem.ToString())
					{
						this.qj[this.re.Items[i].ToString()].HG = "";
						this.qj[this.re.Items[i].ToString()].HK = false;
						this.qj[this.re.Items[i].ToString()].HO = false;
					}
				}
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00011594 File Offset: 0x0000F794
		private void yh(object sender, EventArgs e)
		{
			if (this.qY.SelectedItem != null)
			{
				if (this.qY.GetItemCheckState(this.qY.SelectedIndex) != CheckState.Checked)
				{
					if (this.qk.ContainsKey(this.qY.SelectedItem.ToString()))
					{
						for (int i = 0; i < this.re.Items.Count; i++)
						{
							if (this.qj.ContainsKey(this.re.Items[i].ToString()) && this.qj[this.re.Items[i].ToString()].HG == this.qY.SelectedItem.ToString())
							{
								this.qj[this.re.Items[i].ToString()].HG = "";
								this.qj[this.re.Items[i].ToString()].HK = false;
								this.qj[this.re.Items[i].ToString()].HO = false;
							}
						}
						this.qk.Remove(this.qY.SelectedItem.ToString());
						this.ym();
						return;
					}
				}
				else
				{
					MessageBox.Show("Can't remove an active macro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00011720 File Offset: 0x0000F920
		private void yk()
		{
			this.rV.Clear();
			for (int i = 0; i < this.qm.Length; i++)
			{
				string[] array = this.qm[i].Split(new char[]
				{
					'|'
				});
				if (i == 0)
				{
					for (int j = 0; j < array.Length; j++)
					{
						this.rV.Columns.Add(array[j]);
					}
				}
				else if (this.qm[i].ToLower().Contains(this.rY.Text.ToLower()))
				{
					ListViewItem value = new ListViewItem(array);
					this.rV.Items.Add(value);
					if (i % 1000 == 0)
					{
						Application.DoEvents();
					}
				}
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000117DC File Offset: 0x0000F9DC
		private void yl()
		{
			this.re.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.re.Items.Add(process.MainWindowTitle, false);
				if (!this.qj.ContainsKey(process.MainWindowTitle))
				{
					this.qj.Add(process.MainWindowTitle, new Hs(process.MainWindowTitle, "", false, false, false, false));
				}
			}
			if (this.qY.SelectedItem != null)
			{
				for (int j = 0; j < this.re.Items.Count; j++)
				{
					this.re.SetItemChecked(j, false);
					if (this.qj.ContainsKey(this.re.Items[j].ToString()) && this.qj[this.re.Items[j].ToString()].HG == this.qY.SelectedItem.ToString())
					{
						this.re.SetItemChecked(j, true);
					}
				}
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00011918 File Offset: 0x0000FB18
		private void ym()
		{
			int num = 0;
			this.qY.Items.Clear();
			foreach (KeyValuePair<string, Ii> keyValuePair in this.qk)
			{
				this.qY.Items.Add(keyValuePair.Key.ToString());
				num++;
				for (int i = 0; i < this.re.Items.Count; i++)
				{
					this.re.SetItemChecked(i, false);
					if (this.qj.ContainsKey(this.re.Items[i].ToString()) && this.qj[this.re.Items[i].ToString()].HG == keyValuePair.Key.ToString() && this.qj[this.re.Items[i].ToString()].HK)
					{
						this.qY.SetItemChecked(num - 1, true);
					}
				}
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00011A5C File Offset: 0x0000FC5C
		public int yn()
		{
			return this.tH.Value;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00011A6C File Offset: 0x0000FC6C
		private void yo()
		{
			this.rB.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.rB.Items.Add(process.MainWindowTitle, false);
			}
			this.rD.CheckState = CheckState.Unchecked;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00011AD4 File Offset: 0x0000FCD4
		private void yp()
		{
			this.rI.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.rI.Items.Add(process.MainWindowTitle, false);
			}
			this.rT.CheckState = CheckState.Unchecked;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00011B3C File Offset: 0x0000FD3C
		private void yq()
		{
			this.sb.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.sb.Items.Add(process.MainWindowTitle);
			}
			this.sh.CheckState = CheckState.Unchecked;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00011BA0 File Offset: 0x0000FDA0
		private void yr()
		{
			this.yq();
			this.yo();
			this.yp();
			this.yl();
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		private void ys(Hs yt)
		{
			Process process = null;
			IntPtr vx = IntPtr.Zero;
			Console.WriteLine(yt.HG + "->" + yt.HC + " running");
			foreach (Process process2 in Process.GetProcessesByName("Growtopia"))
			{
				if (yt.HC == process2.MainWindowTitle)
				{
					vx = process2.MainWindowHandle;
					process = process2;
					IL_67:
					if (process != null)
					{
						double num = (double)this.qk[yt.HG].Ir;
						double num2 = (double)this.qk[yt.HG].Iv;
						double num3 = (double)this.qk[yt.HG].Iz;
						double num4 = (double)this.qk[yt.HG].ID;
						double num5 = Math.Sqrt((num3 - num) * (num3 - num) + (num4 - num2) * (num4 - num2)) / 30.0;
						double num6 = (double)(this.qk[yt.HG].Iz - this.qk[yt.HG].Ir) / num5;
						double num7 = (double)(this.qk[yt.HG].ID - this.qk[yt.HG].Iv) / num5;
						IntPtr zero = IntPtr.Zero;
						while (this.qj[yt.HC].HK)
						{
							if (!this.qj[yt.HC].HO)
							{
								double num8 = num;
								double num9 = num2;
								int num10 = (int)num8;
								IntPtr vA = (IntPtr)((int)num9 << 16 | num10);
								zero = IntPtr.Zero;
								pw.SendMessage(vx, 513U, zero, vA);
								Thread.Sleep(100);
								int num11 = 0;
								while ((double)num11 < num5)
								{
									num8 += num6;
									num9 += num7;
									num10 = (int)num8;
									vA = (IntPtr)((int)num9 << 16 | num10);
									zero = IntPtr.Zero;
									pw.SendMessage(vx, 512U, zero, vA);
									Thread.Sleep(this.qi);
									num11++;
								}
								pw.SendMessage(vx, 514U, zero, vA);
							}
							Thread.Sleep(200);
						}
					}
					return;
				}
			}
			goto IL_67;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00011E24 File Offset: 0x00010024
		private void yu(Hs yv)
		{
			Process process = null;
			IntPtr hc = IntPtr.Zero;
			int num = 1;
			string text = this.rG.Text;
			int num2 = (int)(this.rL.Value * 10m);
			string str = "";
			string str2 = "";
			if (this.rU.CheckState == CheckState.Checked)
			{
				str = this.rR.Text;
			}
			if (this.rQ.CheckState == CheckState.Checked)
			{
				str2 = "/msg " + this.rO.Text + " ";
			}
			str2 + str + text;
			Console.WriteLine("Spammer -> " + yv.HC + " running");
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				Process process2 = processesByName[i];
				if (yv.HC == process2.MainWindowTitle)
				{
					hc = process2.MainWindowHandle;
					process = process2;
					IL_F3:
					if (process != null)
					{
						while (this.qj[yv.HC].HS)
						{
							if (!this.qj[yv.HC].HW)
							{
								switch (num)
								{
								case 1:
									text = this.rG.Text;
									if (this.tu.Checked)
									{
										num = 2;
									}
									else if (this.tt.Checked)
									{
										num = 3;
									}
									else if (this.ts.Checked)
									{
										num = 4;
									}
									else if (this.tv.Checked)
									{
										num = 1;
									}
									break;
								case 2:
									text = this.tr.Text;
									if (this.tt.Checked)
									{
										num = 3;
									}
									else if (this.ts.Checked)
									{
										num = 4;
									}
									else if (this.tv.Checked)
									{
										num = 1;
									}
									else if (this.tu.Checked)
									{
										num = 2;
									}
									break;
								case 3:
									text = this.tq.Text;
									if (this.ts.Checked)
									{
										num = 4;
									}
									else if (this.tv.Checked)
									{
										num = 1;
									}
									else if (this.tu.Checked)
									{
										num = 2;
									}
									else if (this.tt.Checked)
									{
										num = 3;
									}
									break;
								case 4:
									text = this.tp.Text;
									if (this.tv.Checked)
									{
										num = 1;
									}
									else if (this.tu.Checked)
									{
										num = 2;
									}
									else if (this.tt.Checked)
									{
										num = 3;
									}
									else if (this.ts.Checked)
									{
										num = 4;
									}
									break;
								default:
									text = this.rG.Text;
									num = 1;
									break;
								}
								string text2 = str2 + str + text;
								pw.Hb(hc, 13, false);
								Thread.Sleep(50);
								string text3 = text2;
								i = 0;
								while (i < text3.Length)
								{
									char c = text3[i];
									char c2 = c;
									bool flag = false;
									if (this.tx.Checked)
									{
										try
										{
											short num3 = pw.VkKeyScan(c2);
											bool flag2 = (num3 & 256) > 0;
											bool flag3 = (num3 & 512) > 0;
											bool flag4 = (num3 & 1024) > 0;
											if (flag2)
											{
												flag = true;
											}
											if (flag4 && flag3)
											{
												flag = true;
											}
											if (char.IsLetter(c2))
											{
												c2 = c.ToString().ToLower().ToCharArray()[0];
												flag = false;
											}
											goto IL_34A;
										}
										catch (Exception)
										{
											flag = true;
											throw;
										}
										goto IL_346;
									}
									goto IL_346;
									IL_34A:
									if (!flag)
									{
										short num4 = pw.VkKeyScan(c2);
										int num5 = (int)(num4 & 255);
										bool flag5 = (num4 & 256) > 0;
										bool flag6 = (num4 & 512) > 0;
										bool flag7 = (num4 & 1024) > 0;
										if (flag5 && !this.tx.Checked)
										{
											pw.keybd_event(160, 42, 0, 0);
											Thread.Sleep(50);
										}
										if (flag7 && flag6 && !this.tx.Checked)
										{
											pw.keybd_event(164, 56, 0, 0);
											pw.keybd_event(162, 29, 0, 0);
											Thread.Sleep(50);
										}
										pw.Hb(hc, (byte)num5, false);
										Thread.Sleep(50);
										if (flag5 && !this.tx.Checked)
										{
											pw.keybd_event(160, 170, 2, 0);
											Thread.Sleep(50);
										}
										if (flag7 && flag6 && !this.tx.Checked)
										{
											pw.keybd_event(164, 184, 2, 0);
											pw.keybd_event(162, 157, 2, 0);
											Thread.Sleep(50);
										}
									}
									i++;
									continue;
									IL_346:
									c2 = c;
									goto IL_34A;
								}
								pw.Hb(hc, 13, false);
							}
							if (this.tw.Checked)
							{
								if (!this.tu.Checked & !this.tt.Checked & !this.ts.Checked)
								{
									for (int j = 0; j < num2; j++)
									{
										Thread.Sleep(100);
										if (!this.qj[yv.HC].HS)
										{
											break;
										}
									}
								}
								else
								{
									switch (num)
									{
									case 1:
										for (int k = 0; k < num2; k++)
										{
											Thread.Sleep(100);
											if (!this.qj[yv.HC].HS)
											{
												break;
											}
										}
										break;
									case 2:
										for (int l = 0; l < 20; l++)
										{
											Thread.Sleep(100);
											if (!this.qj[yv.HC].HS)
											{
												break;
											}
										}
										break;
									case 3:
										if (this.tt.Checked)
										{
											for (int m = 0; m < 20; m++)
											{
												Thread.Sleep(100);
												if (!this.qj[yv.HC].HS)
												{
													break;
												}
											}
										}
										else
										{
											for (int n = 0; n < num2; n++)
											{
												Thread.Sleep(100);
												if (!this.qj[yv.HC].HS)
												{
													break;
												}
											}
										}
										break;
									case 4:
										if (this.ts.Checked)
										{
											for (int num6 = 0; num6 < 20; num6++)
											{
												Thread.Sleep(100);
												if (!this.qj[yv.HC].HS)
												{
													break;
												}
											}
										}
										else
										{
											for (int num7 = 0; num7 < num2; num7++)
											{
												Thread.Sleep(100);
												if (!this.qj[yv.HC].HS)
												{
													break;
												}
											}
										}
										break;
									}
								}
							}
							else
							{
								for (int num8 = 0; num8 < num2; num8++)
								{
									Thread.Sleep(100);
									if (!this.qj[yv.HC].HS)
									{
										break;
									}
								}
							}
						}
					}
					return;
				}
			}
			goto IL_F3;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000124F0 File Offset: 0x000106F0
		private void yw()
		{
			IntPtr zero = IntPtr.Zero;
			TesseractEngine tesseractEngine = new TesseractEngine("tessdata", "eng+equ", EngineMode.Default);
			while (this.qG)
			{
				foreach (Process process in Process.GetProcessesByName("Growtopia"))
				{
					pw.SetForegroundWindow(process.MainWindowHandle);
					Thread.Sleep(250);
					Rectangle rectangle;
					pw.GetWindowRect(process.MainWindowHandle, out rectangle);
					this.qu = this.qv;
					Bitmap bitmap = new Bitmap(this.qu.Width, this.qu.Height, PixelFormat.Format32bppArgb);
					Graphics.FromImage(bitmap).CopyFromScreen(this.qu.Left, this.qu.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
					bitmap = this.Ae(bitmap, 2 * this.qu.Width, 2 * this.qu.Height);
					tesseractEngine.SetVariable("tessedit_char_whitelist", "AreyouHuman?");
					Page page = tesseractEngine.Process(bitmap, null);
					string text = page.GetText();
					if (text.Contains("Are you Human"))
					{
						if (this.qj[process.MainWindowTitle].HK)
						{
							this.qj[process.MainWindowTitle].HO = true;
							Thread.Sleep(500);
						}
						if (this.qj[process.MainWindowTitle].HS)
						{
							this.qj[process.MainWindowTitle].HW = true;
							Thread.Sleep(500);
						}
						page.Dispose();
						this.qu = this.qw;
						bitmap = new Bitmap(this.qu.Width, this.qu.Height, PixelFormat.Format32bppArgb);
						Graphics.FromImage(bitmap).CopyFromScreen(this.qu.Left, this.qu.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
						bitmap = this.Ae(bitmap, 2 * this.qu.Width, 2 * this.qu.Height);
						tesseractEngine.SetVariable("tessedit_char_whitelist", "0123456789+");
						page = tesseractEngine.Process(bitmap, null);
						text = page.GetText();
						if (text.Contains("+"))
						{
							this.qu = this.qx;
							this.qu.X = this.qu.X + this.qu.Width / 2 - rectangle.X;
							this.qu.Y = this.qu.Y + this.qu.Height / 2 - rectangle.Y - 30;
							this.qu.X = (int)((float)this.qu.X / this.qJ);
							this.qu.Y = (int)((float)this.qu.Y / this.qJ);
							IntPtr vA = (IntPtr)(this.qu.Y << 16 | this.qu.X);
							zero = IntPtr.Zero;
							text.Replace(" ", "");
							string[] array = text.Split(new char[]
							{
								char.Parse("+")
							});
							if (array.Length == 2)
							{
								int num;
								int num2;
								if (int.TryParse(array[0], out num) && int.TryParse(array[1], out num2))
								{
									int num3 = num + num2;
									Console.WriteLine(page.GetText() + " = " + num3.ToString());
									SendKeys.SendWait("{BS}{BS}{BS}{BS}{BS}{BS}");
									SendKeys.SendWait(num3.ToString());
									Thread.Sleep(100);
									pw.SendMessage(process.MainWindowHandle, 513U, zero, vA);
									Thread.Sleep(100);
									pw.SendMessage(process.MainWindowHandle, 514U, zero, vA);
								}
								else
								{
									SendKeys.SendWait("{BS}{BS}{BS}{BS}{BS}{BS}");
									pw.SendMessage(process.MainWindowHandle, 513U, zero, vA);
									Thread.Sleep(100);
									pw.SendMessage(process.MainWindowHandle, 514U, zero, vA);
								}
							}
							else
							{
								SendKeys.SendWait("{BS}{BS}{BS}{BS}{BS}{BS}");
								pw.SendMessage(process.MainWindowHandle, 513U, zero, vA);
								Thread.Sleep(100);
								pw.SendMessage(process.MainWindowHandle, 514U, zero, vA);
							}
						}
						else
						{
							Console.WriteLine(page.GetText());
						}
						if (this.qj[process.MainWindowTitle].HK)
						{
							Thread.Sleep(500);
							this.qj[process.MainWindowTitle].HO = false;
						}
						if (this.qj[process.MainWindowTitle].HS)
						{
							Thread.Sleep(500);
							this.qj[process.MainWindowTitle].HW = false;
						}
					}
					page.Dispose();
					Thread.Sleep(500);
				}
				if (this.qH)
				{
					this.qG = false;
					this.qH = false;
				}
				else
				{
					Thread.Sleep(5000);
				}
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00012A34 File Offset: 0x00010C34
		private void yx(object sender, EventArgs e)
		{
			this.rn.Visible = false;
			this.ro.Visible = true;
			this.rv.Enabled = true;
			this.rr.Enabled = true;
			this.rq.Enabled = true;
			this.rp.Enabled = true;
			this.qG = false;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00012A90 File Offset: 0x00010C90
		public string yA(string yB)
		{
			string result;
			try
			{
				result = new WebClient().DownloadString(yB);
			}
			catch (Exception)
			{
				try
				{
					WebClient webClient = new WebClient();
					WebProxy proxy = new WebProxy("104.211.157.43:3128");
					webClient.Proxy = proxy;
					result = webClient.DownloadString(yB);
				}
				catch (Exception)
				{
					try
					{
						WebClient webClient2 = new WebClient();
						WebProxy proxy2 = new WebProxy("80.240.17.199:3128");
						webClient2.Proxy = proxy2;
						result = webClient2.DownloadString(yB);
					}
					catch (Exception)
					{
						try
						{
							WebClient webClient3 = new WebClient();
							WebProxy proxy3 = new WebProxy("31.193.196.3:3128");
							webClient3.Proxy = proxy3;
							result = webClient3.DownloadString(yB);
						}
						catch (Exception)
						{
							try
							{
								WebClient webClient4 = new WebClient();
								WebProxy proxy4 = new WebProxy("34.90.113.143:3128");
								webClient4.Proxy = proxy4;
								result = webClient4.DownloadString(yB);
							}
							catch (Exception ex)
							{
								string str = "No internet connection? Shutting down. Error: ";
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

		// Token: 0x060002C9 RID: 713 RVA: 0x00012BA0 File Offset: 0x00010DA0
		private void yC(object sender, EventArgs e)
		{
			this.rn.Visible = true;
			this.ro.Visible = false;
			this.rv.Enabled = false;
			this.rr.Enabled = false;
			this.rq.Enabled = false;
			this.rp.Enabled = false;
			this.qG = true;
			this.qH = false;
			new Thread(delegate()
			{
				this.yw();
			}).Start();
			Thread.Sleep(250);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00012C24 File Offset: 0x00010E24
		private void yF(object sender, EventArgs e)
		{
			this.qE = 1;
			this.qo.eU();
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00012C38 File Offset: 0x00010E38
		private void yI(object sender, EventArgs e)
		{
			this.qG = true;
			this.qH = true;
			new Thread(delegate()
			{
				this.yw();
			}).Start();
			Thread.Sleep(250);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00012C74 File Offset: 0x00010E74
		private void yL(object sender, EventArgs e)
		{
			this.qE = 3;
			this.qo.eU();
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00012C88 File Offset: 0x00010E88
		private void yO(object sender, EventArgs e)
		{
			this.qE = 2;
			this.qo.eU();
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00012C9C File Offset: 0x00010E9C
		public void yR(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00012CA0 File Offset: 0x00010EA0
		public void yU(object sender, MouseEventArgs e)
		{
			this.qo.eX();
			this.qy = false;
			this.qD.Hide();
			Bitmap bitmap = new Bitmap(this.qu.Width, this.qu.Height, PixelFormat.Format32bppArgb);
			Graphics.FromImage(bitmap).CopyFromScreen(this.qu.Left, this.qu.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
			switch (this.qE)
			{
			case 1:
				this.qE = 0;
				this.qv = this.qu;
				this.rs.Image = bitmap;
				return;
			case 2:
				this.qE = 0;
				this.qw = this.qu;
				this.ru.Image = bitmap;
				return;
			case 3:
				this.qE = 0;
				this.qx = this.qu;
				this.rt.Image = bitmap;
				return;
			default:
				return;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00012D94 File Offset: 0x00010F94
		public void yX(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.zm(e, 514U);
			}
			if (e.Button == MouseButtons.Right)
			{
				this.zm(e, 517U);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00012DD4 File Offset: 0x00010FD4
		public void za(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.zm(e, 513U);
			}
			if (e.Button == MouseButtons.Right)
			{
				this.zm(e, 516U);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00012E14 File Offset: 0x00011014
		public void zd(object sender, MouseEventArgs e)
		{
			if (!pw.qn.Enabled)
			{
				this.zm(e, 512U);
				pw.qn.Interval = 500;
				pw.qn.Start();
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00012E54 File Offset: 0x00011054
		public void zg(object sender, MouseEventArgs e)
		{
			this.zm(e, 522U);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00012E64 File Offset: 0x00011064
		private static void zj(object sender, EventArgs e)
		{
			pw.qn.Stop();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00012E70 File Offset: 0x00011070
		public void zm(MouseEventArgs zn, uint zo)
		{
			bool flag = false;
			IntPtr foregroundWindow = pw.GetForegroundWindow();
			IntPtr intPtr = IntPtr.Zero;
			Process[] array = this.qs;
			for (int i = 0; i < array.Length; i++)
			{
				intPtr = array[i].MainWindowHandle;
				if (intPtr == foregroundWindow)
				{
					flag = true;
					IL_3E:
					if (flag)
					{
						Rectangle rectangle;
						pw.GetWindowRect(foregroundWindow, out rectangle);
						array = this.qs;
						for (i = 0; i < array.Length; i++)
						{
							intPtr = array[i].MainWindowHandle;
							if (intPtr != foregroundWindow)
							{
								IntPtr vz = IntPtr.Zero;
								int num = (int)((float)zn.X / this.qJ) - rectangle.X;
								IntPtr vA = (IntPtr)((int)((float)zn.Y / this.qJ) - rectangle.Y - 30 << 16 | num);
								vz = IntPtr.Zero;
								if (zo == 522U)
								{
									vz = (IntPtr)(zn.Delta << 16);
								}
								pw.SendMessage(intPtr, zo, vz, vA);
							}
						}
					}
					return;
				}
			}
			goto IL_3E;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00012F70 File Offset: 0x00011170
		private void zp(object sender, EventArgs e)
		{
			this.qE = 1;
			this.qo.eU();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00012F84 File Offset: 0x00011184
		private void zs(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/aCWG8R9");
			Process.Start("https://discord.gg/8ytpE44");
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00012F9C File Offset: 0x0001119C
		private void zv(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCY_VhfecGXDZQ3A_fQg6DCQ/videos");
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00012FAC File Offset: 0x000111AC
		public void zy(object sender, MouseEventArgs e)
		{
			this.qy = true;
			this.qz = e.X;
			this.qA = e.Y;
			this.qD.Show();
			this.qD.Bounds = new Rectangle((int)((float)e.X / this.qJ), (int)((float)e.Y / this.qJ), 0, 0);
			this.Refresh();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001301C File Offset: 0x0001121C
		public void zB(object sender, MouseEventArgs e)
		{
			if (!this.qy)
			{
				return;
			}
			int num = Math.Min(this.qz, e.X);
			int num2 = Math.Min(this.qA, e.Y);
			int num3 = Math.Max(this.qz, e.X) - Math.Min(this.qz, e.X);
			int num4 = Math.Max(this.qA, e.Y) - Math.Min(this.qA, e.Y);
			this.qu = new Rectangle(num, num2, num3, num4);
			this.qt = new Rectangle((int)((float)num / this.qJ), (int)((float)num2 / this.qJ), (int)((float)num3 / this.qJ), (int)((float)num4 / this.qJ));
			this.qD.Bounds = this.qt;
			this.Refresh();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000130F8 File Offset: 0x000112F8
		public void zE(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Space)
			{
				this.qq.eX();
				Rectangle rectangle;
				pw.GetWindowRect(pw.GetForegroundWindow(), out rectangle);
				Point position = Cursor.Position;
				switch (this.qF)
				{
				case 1:
					this.rb.Value = position.X - rectangle.X;
					this.ra.Value = position.Y - rectangle.Y - 30;
					break;
				case 2:
					this.ri.Value = position.X - rectangle.X;
					this.rh.Value = position.Y - rectangle.Y - 30;
					break;
				case 3:
					this.qB = position.X - rectangle.X;
					this.qC = position.Y - rectangle.Y - 30;
					this.sY.Enabled = true;
					this.sZ.Enabled = true;
					this.ta.Enabled = true;
					break;
				}
				this.qF = 0;
				e.Handled = true;
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00013238 File Offset: 0x00011438
		public void zH(object sender, KeyEventArgs e)
		{
			this.zN(e, 256U);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00013248 File Offset: 0x00011448
		public void zK(object sender, KeyEventArgs e)
		{
			this.zN(e, 257U);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00013258 File Offset: 0x00011458
		public void zN(KeyEventArgs zO, uint zP)
		{
			bool flag = false;
			IntPtr foregroundWindow = pw.GetForegroundWindow();
			IntPtr intPtr = IntPtr.Zero;
			Process[] array = this.qs;
			for (int i = 0; i < array.Length; i++)
			{
				intPtr = array[i].MainWindowHandle;
				if (intPtr == foregroundWindow)
				{
					flag = true;
					IL_3E:
					if (flag)
					{
						array = this.qs;
						for (i = 0; i < array.Length; i++)
						{
							intPtr = array[i].MainWindowHandle;
							if (intPtr != foregroundWindow)
							{
								bool flag2 = false;
								uint keyCode = (uint)zO.KeyCode;
								uint num = pw.MapVirtualKey(keyCode, 0U);
								if (zP == 256U)
								{
									uint num2 = 1U | num << 16;
									if (flag2)
									{
										num2 |= 16777216U;
									}
									pw.PostMessageA(intPtr, 256U, (int)keyCode, (int)num2);
								}
								if (zP == 257U)
								{
									uint num2 = 1U | num << 16;
									num2 |= 3221225472U;
									pw.PostMessageA(intPtr, 257U, (int)keyCode, (int)num2);
								}
							}
						}
					}
					return;
				}
			}
			goto IL_3E;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001334C File Offset: 0x0001154C
		public void zQ(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.F5)
			{
				this.qr.eX();
				this.qI = true;
				e.Handled = true;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001337C File Offset: 0x0001157C
		public void zT(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00013380 File Offset: 0x00011580
		public void zW(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00013384 File Offset: 0x00011584
		private void zZ(string Aa)
		{
			Console.WriteLine(Aa + Environment.NewLine);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00013398 File Offset: 0x00011598
		private float Ab()
		{
			IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
			int deviceCaps = pw.GetDeviceCaps(hdc, 10);
			return (float)pw.GetDeviceCaps(hdc, 117) / (float)deviceCaps;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000133C8 File Offset: 0x000115C8
		public static Bitmap Ac(Bitmap Ad)
		{
			Bitmap bitmap = new Bitmap(Ad.Width, Ad.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			float[][] array = new float[5][];
			array[0] = new float[]
			{
				0.3f,
				0.3f,
				0.3f,
				0f,
				0f
			};
			array[1] = new float[]
			{
				0.59f,
				0.59f,
				0.59f,
				0f,
				0f
			};
			array[2] = new float[]
			{
				0.11f,
				0.11f,
				0.11f,
				0f,
				0f
			};
			int num = 3;
			float[] array2 = new float[5];
			array2[3] = 1f;
			array[num] = array2;
			array[4] = new float[]
			{
				0f,
				0f,
				0f,
				0f,
				1f
			};
			ColorMatrix colorMatrix = new ColorMatrix(array);
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix);
			graphics.DrawImage(Ad, new Rectangle(0, 0, Ad.Width, Ad.Height), 0, 0, Ad.Width, Ad.Height, GraphicsUnit.Pixel, imageAttributes);
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00013498 File Offset: 0x00011698
		public Bitmap Ae(Bitmap Af, int Ag, int Ah)
		{
			Bitmap bitmap = new Bitmap(Ag, Ah, Af.PixelFormat);
			double num = (double)Af.Width / (double)Ag;
			double num2 = (double)Af.Height / (double)Ah;
			Color color = default(Color);
			Color color2 = default(Color);
			Color color3 = default(Color);
			Color color4 = default(Color);
			for (int i = 0; i < bitmap.Width; i++)
			{
				for (int j = 0; j < bitmap.Height; j++)
				{
					int num3 = (int)Math.Floor((double)i * num);
					int num4 = (int)Math.Floor((double)j * num2);
					int num5 = num3 + 1;
					if (num5 >= Af.Width)
					{
						num5 = num3;
					}
					int num6 = num4 + 1;
					if (num6 >= Af.Height)
					{
						num6 = num4;
					}
					double num7 = (double)i * num - (double)num3;
					double num8 = (double)j * num2 - (double)num4;
					double num9 = 1.0 - num7;
					double num10 = 1.0 - num8;
					color = Af.GetPixel(num3, num4);
					color2 = Af.GetPixel(num5, num4);
					color3 = Af.GetPixel(num3, num6);
					color4 = Af.GetPixel(num5, num6);
					byte b = (byte)(num9 * (double)color.B + num7 * (double)color2.B);
					byte b2 = (byte)(num9 * (double)color3.B + num7 * (double)color4.B);
					byte blue = (byte)(num10 * (double)b + num8 * (double)b2);
					b = (byte)(num9 * (double)color.G + num7 * (double)color2.G);
					b2 = (byte)(num9 * (double)color3.G + num7 * (double)color4.G);
					byte green = (byte)(num10 * (double)b + num8 * (double)b2);
					b = (byte)(num9 * (double)color.R + num7 * (double)color2.R);
					b2 = (byte)(num9 * (double)color3.R + num7 * (double)color4.R);
					byte red = (byte)(num10 * (double)b + num8 * (double)b2);
					bitmap.SetPixel(i, j, Color.FromArgb(255, (int)red, (int)green, (int)blue));
				}
			}
			bitmap = this.Ai(bitmap);
			return this.An(bitmap);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000136B4 File Offset: 0x000118B4
		public Bitmap Ai(Bitmap Aj)
		{
			Bitmap bitmap = (Bitmap)Aj.Clone();
			for (int i = 0; i < bitmap.Width; i++)
			{
				for (int j = 0; j < bitmap.Height; j++)
				{
					Color pixel = bitmap.GetPixel(i, j);
					byte b = (byte)(0.299 * (double)pixel.R + 0.587 * (double)pixel.G + 0.114 * (double)pixel.B);
					bitmap.SetPixel(i, j, Color.FromArgb((int)b, (int)b, (int)b));
				}
			}
			return (Bitmap)bitmap.Clone();
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00013754 File Offset: 0x00011954
		private void Ak(object sender, EventArgs e)
		{
			if (this.tT.Checked && (int)this.rz.Value > this.tS.Items.Count)
			{
				MessageBox.Show("You are opening more windows than accounts you have added. Please uncheck the checkbox 'Auto Log In' to disable auto log in. \n\rWindows to open: " + ((int)this.rz.Value).ToString() + "\n\rAccounts added:" + this.tS.Items.Count.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			this.AB((int)this.rz.Value);
			this.yr();
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000137FC File Offset: 0x000119FC
		public Bitmap An(Bitmap Ao)
		{
			int num = 145;
			for (int i = 0; i < Ao.Width; i++)
			{
				for (int j = 0; j < Ao.Height; j++)
				{
					Color pixel = Ao.GetPixel(i, j);
					if ((int)pixel.R <= num && (int)pixel.G <= num && (int)pixel.B <= num)
					{
						Ao.SetPixel(i, j, Color.White);
					}
					else if ((int)pixel.R > num && (int)pixel.G > num && (int)pixel.B > num)
					{
						Ao.SetPixel(i, j, Color.Black);
					}
				}
			}
			return Ao;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00013894 File Offset: 0x00011A94
		private void Ap(object sender, EventArgs e)
		{
			this.yr();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001389C File Offset: 0x00011A9C
		private void As(object sender, EventArgs e)
		{
			for (int i = 0; i < this.rB.Items.Count; i++)
			{
				if (this.rD.Checked)
				{
					this.rB.SetItemChecked(i, true);
				}
				else
				{
					this.rB.SetItemChecked(i, false);
				}
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000138F0 File Offset: 0x00011AF0
		private void Av(object sender, EventArgs e)
		{
			int num = 0;
			foreach (Process process in this.pR)
			{
				if (pw.GY(process.MainWindowTitle))
				{
					for (int i = 0; i < this.rB.Items.Count; i++)
					{
						if (this.rB.GetItemCheckState(i) == CheckState.Checked && process.MainWindowTitle == this.rB.Items[i].ToString())
						{
							if (num != this.pR.Count - 1)
							{
								process.Kill();
								Thread.Sleep(200);
							}
							else if (pw.Ha() == 1)
							{
								process.Kill();
							}
						}
					}
				}
				num++;
			}
			Thread.Sleep(500);
			this.yr();
			if (pw.Ha() == 0)
			{
				this.pR.Clear();
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000139F8 File Offset: 0x00011BF8
		private void Ay(object sender, EventArgs e)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000139FC File Offset: 0x00011BFC
		private void AB(int AC)
		{
			if (this.uE != "")
			{
				List<Process> list = new List<Process>();
				if (this.pR.Count > 0)
				{
					foreach (Process process in this.pR)
					{
						if (pw.GY(process.MainWindowTitle))
						{
							this.Bq(process);
							list.Add(process);
						}
					}
					Thread.Sleep(1000);
				}
				for (int i = 0; i < AC; i++)
				{
					if (this.tT.Checked && i + 1 <= this.tS.Items.Count)
					{
						if (File.Exists(this.uE.Replace("Growtopia.exe", "save.dat")))
						{
							File.Delete(this.uE.Replace("Growtopia.exe", "save.dat"));
						}
						string currentDirectory = Directory.GetCurrentDirectory();
						string str = "/Accounts/";
						object obj = this.tS.Items[i];
						File.Copy(currentDirectory + str + ((obj != null) ? obj.ToString() : null), this.uE.Replace("Growtopia.exe", "save.dat"));
					}
					if (i != 0)
					{
						this.Bq(this.pR[this.pR.Count - 1]);
						list.Add(this.pR[this.pR.Count - 1]);
						Thread.Sleep(1000);
					}
					if (this.pR.Count > 0)
					{
						this.Bo(this.pR[this.pR.Count - 1]);
					}
					Process process2 = new Process();
					process2.StartInfo.FileName = this.uE;
					this.pR.Add(process2);
					process2.Start();
					Thread.Sleep(1500);
					process2.WaitForInputIdle();
					pw.SetWindowText(process2.MainWindowHandle, "Growtopia " + this.pR.Count.ToString());
					Process process3 = process2;
					switch (this.uq.SelectedIndex)
					{
					case 0:
						process3.PriorityClass = ProcessPriorityClass.RealTime;
						break;
					case 1:
						process3.PriorityClass = ProcessPriorityClass.High;
						break;
					case 2:
						process3.PriorityClass = ProcessPriorityClass.AboveNormal;
						break;
					case 3:
						process3.PriorityClass = ProcessPriorityClass.Normal;
						break;
					case 4:
						process3.PriorityClass = ProcessPriorityClass.BelowNormal;
						break;
					case 5:
						process3.PriorityClass = ProcessPriorityClass.Idle;
						break;
					}
					(long)process3.ProcessorAffinity;
					double num = 0.0;
					for (int j = 0; j < this.ur.Items.Count; j++)
					{
						if (this.ur.GetItemChecked(j))
						{
							num += Math.Pow(2.0, (double)j);
						}
					}
					int value = (int)num;
					Console.WriteLine(Convert.ToString(value, 2));
					process3.ProcessorAffinity = (IntPtr)value;
					if (this.tT.Checked)
					{
						SendKeys.Send("{Enter}");
						if (i + 1 <= this.tS.Items.Count)
						{
							if (this.tV.Checked)
							{
								Thread.Sleep(100);
								SendKeys.Send("{Enter}");
								Thread.Sleep(100);
								SendKeys.Send("{Enter}");
								Thread.Sleep((int)this.tX.Value);
							}
							else
							{
								SendKeys.Send("{Enter}");
								Thread.Sleep(100);
							}
						}
					}
				}
				using (List<Process>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Process bt = enumerator.Current;
						this.Bs(bt);
					}
					return;
				}
			}
			MessageBox.Show("Please set a file path for Growtopia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "exe |*.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show(openFileDialog.FileName);
				this.uE = openFileDialog.FileName;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00013E34 File Offset: 0x00012034
		private void AD(object sender, MaskInputRejectedEventArgs e)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00013E38 File Offset: 0x00012038
		private void AG(object sender, EventArgs e)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00013E3C File Offset: 0x0001203C
		private void AJ(object sender, EventArgs e)
		{
			this.yr();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00013E44 File Offset: 0x00012044
		private void AM(object sender, EventArgs e)
		{
			for (int i = 0; i < this.rI.Items.Count; i++)
			{
				if (this.rT.Checked)
				{
					this.rI.SetItemChecked(i, true);
				}
				else
				{
					this.rI.SetItemChecked(i, false);
				}
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00013E98 File Offset: 0x00012098
		private void AP(object sender, EventArgs e)
		{
			if (this.rJ.CheckState == CheckState.Checked)
			{
				int i;
				ThreadStart <>9__0;
				int k;
				for (i = 0; i < this.rI.Items.Count; i = k + 1)
				{
					if (this.rI.GetItemCheckState(i) == CheckState.Checked && !this.qj[this.rI.Items[i].ToString()].HS)
					{
						this.qj[this.rI.Items[i].ToString()].HS = true;
						this.qj[this.rI.Items[i].ToString()].HW = false;
						ThreadStart start;
						if ((start = <>9__0) == null)
						{
							start = (<>9__0 = delegate()
							{
								this.yu(this.qj[this.rI.Items[i].ToString()]);
							});
						}
						new Thread(start).Start();
						Thread.Sleep(250);
					}
					k = i;
				}
				return;
			}
			for (int j = 0; j < this.rI.Items.Count; j++)
			{
				if (this.qj[this.rI.Items[j].ToString()].HS)
				{
					this.qj[this.rI.Items[j].ToString()].HS = false;
					this.qj[this.rI.Items[j].ToString()].HW = false;
				}
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00014064 File Offset: 0x00012264
		private void AS(object sender, EventArgs e)
		{
			this.qm = File.ReadAllLines("ItemData.txt");
			this.yk();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001407C File Offset: 0x0001227C
		private void AV(object sender, KeyEventArgs e)
		{
			if (this.qm != null)
			{
				this.yk();
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001408C File Offset: 0x0001228C
		private void AY(object sender, MaskInputRejectedEventArgs e)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00014090 File Offset: 0x00012290
		private void Bb(object sender, EventArgs e)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00014094 File Offset: 0x00012294
		private void Be(object sender, EventArgs e)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00014098 File Offset: 0x00012298
		private static bool Bh()
		{
			return Marshal.SizeOf(typeof(IntPtr)) == 8;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000140B0 File Offset: 0x000122B0
		private void Bi(object sender, EventArgs e)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000140B4 File Offset: 0x000122B4
		private static string Bl(pw.Oe.OY Bm, Process Bn)
		{
			IntPtr wv = pw.OpenProcess_1(2035711U, false, Bn.Id);
			IntPtr zero = IntPtr.Zero;
			if (!pw.DuplicateHandle(wv, Bm.Pc, pw.GetCurrentProcess(), out zero, 0U, false, 2U))
			{
				return null;
			}
			IntPtr intPtr = IntPtr.Zero;
			pw.Oe.Pf pf = default(pw.Oe.Pf);
			pw.Oe.Ps ps = default(pw.Oe.Ps);
			intPtr = Marshal.AllocHGlobal(Marshal.SizeOf<pw.Oe.Pf>(pf));
			int num = 0;
			pw.NtQueryObject(zero, 0, intPtr, Marshal.SizeOf<pw.Oe.Pf>(pf), ref num);
			pf = (pw.Oe.Pf)Marshal.PtrToStructure(intPtr, pf.GetType());
			Marshal.FreeHGlobal(intPtr);
			num = pf.Po;
			IntPtr intPtr2 = Marshal.AllocHGlobal(num);
			while (pw.NtQueryObject(zero, 1, intPtr2, num, ref num) == -1073741820)
			{
				Marshal.FreeHGlobal(intPtr2);
				intPtr2 = Marshal.AllocHGlobal(num);
			}
			ps = (pw.Oe.Ps)Marshal.PtrToStructure(intPtr2, ps.GetType());
			IntPtr intPtr3;
			if (pw.Bh())
			{
				intPtr3 = (IntPtr)((long)((ulong)((long)ps.Pt.Px) >> 32));
			}
			else
			{
				intPtr3 = ps.Pt.Px;
			}
			if (intPtr3 != IntPtr.Zero)
			{
				if (pw.Bh())
				{
					intPtr3 = intPtr2 + 16;
				}
				byte[] destination = new byte[num];
				string result;
				try
				{
					Marshal.Copy(intPtr3, destination, 0, num);
					result = Marshal.PtrToStringUni(pw.Bh() ? new IntPtr(intPtr3.ToInt64()) : new IntPtr(intPtr3.ToInt32()));
				}
				catch (AccessViolationException)
				{
					result = null;
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr2);
					pw.CloseHandle(zero);
				}
				return result;
			}
			return null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00014258 File Offset: 0x00012458
		private void Bo(Process Bp)
		{
			Console.WriteLine("Starting handle magic...");
			int num = 0;
			IntPtr zero = IntPtr.Zero;
			int wf = 65536;
			IntPtr intPtr = Marshal.AllocHGlobal(65536);
			while (pw.NtQuerySystemInformation(16U, intPtr, wf, ref num) == 3221225476U)
			{
				wf = num;
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(num);
			}
			byte[] destination = new byte[num];
			Marshal.Copy(intPtr, destination, 0, num);
			long num2;
			if (pw.Bh())
			{
				num2 = Marshal.ReadInt64(intPtr);
				zero = new IntPtr(intPtr.ToInt64() + 8L);
			}
			else
			{
				num2 = (long)Marshal.ReadInt32(intPtr);
				zero = new IntPtr(intPtr.ToInt32() + 4);
			}
			List<pw.Oe.OY> list = new List<pw.Oe.OY>();
			for (long num3 = 0L; num3 < num2; num3 += 1L)
			{
				pw.Oe.OY oy = default(pw.Oe.OY);
				if (pw.Bh())
				{
					oy = (pw.Oe.OY)Marshal.PtrToStructure(zero, oy.GetType());
					zero = new IntPtr(zero.ToInt64() + (long)Marshal.SizeOf<pw.Oe.OY>(oy) + 8L);
				}
				else
				{
					oy = (pw.Oe.OY)Marshal.PtrToStructure(zero, oy.GetType());
					zero = new IntPtr(zero.ToInt64() + (long)Marshal.SizeOf<pw.Oe.OY>(oy));
				}
				if (oy.OZ == Bp.Id)
				{
					string text = pw.Bl(oy, Bp);
					if (text != null && text.StartsWith("\\Sessions\\") && text.EndsWith("\\BaseNamedObjects\\Growtopia"))
					{
						list.Add(oy);
						Console.WriteLine("PID {0,7} Pointer {1,12} Type {2,4} Name {3}", new object[]
						{
							oy.OZ.ToString(),
							oy.Pd.ToString(),
							oy.Pa.ToString(),
							text
						});
					}
				}
			}
			Console.WriteLine("Closing mutexes?");
			foreach (pw.Oe.OY gx in list)
			{
				this.GW(gx);
			}
			Console.WriteLine("Handle closed.");
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00014494 File Offset: 0x00012694
		private void Bq(Process Br)
		{
			foreach (object obj in Br.Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = pw.OpenThread(2, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					pw.SuspendThread(intPtr);
					pw.CloseHandle(intPtr);
				}
			}
			Console.WriteLine("SUSPENDED");
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001451C File Offset: 0x0001271C
		private void Bs(Process Bt)
		{
			foreach (object obj in Bt.Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = pw.OpenThread(2, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					int num;
					do
					{
						num = pw.ResumeThread(intPtr);
					}
					while (num > 0);
					pw.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000145A4 File Offset: 0x000127A4
		private void Bu(object sender, EventArgs e)
		{
			if (this.sf.Text == "/msg")
			{
				this.sg.Visible = true;
				this.sm.Visible = true;
				this.so.Visible = true;
				return;
			}
			this.sg.Visible = false;
			this.sm.Visible = false;
			this.so.Visible = false;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00014614 File Offset: 0x00012814
		private void Bx(object sender, EventArgs e)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00014618 File Offset: 0x00012818
		private void BA(object sender, EventArgs e)
		{
			for (int i = 0; i < this.si.Items.Count; i++)
			{
				if (this.sh.Checked)
				{
					this.si.SetItemChecked(i, true);
				}
				else
				{
					this.si.SetItemChecked(i, false);
				}
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0001466C File Offset: 0x0001286C
		private void BD(object sender, EventArgs e)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00014670 File Offset: 0x00012870
		private void BG(object sender, EventArgs e)
		{
			if (this.sb.SelectedItem != null)
			{
				this.sh.CheckState = CheckState.Unchecked;
				this.sj.Text = "GT:" + this.sb.Text;
				this.si.Items.Clear();
				List<string> list = this.Hf(this.qj[this.sb.Text], this.sT.SelectedIndex);
				for (int i = 0; i < list.Count; i++)
				{
					this.si.Items.Add(list[i]);
				}
				this.sh.Text = "Select all (" + this.si.Items.Count.ToString() + ")";
				return;
			}
			MessageBox.Show("Please select a window under 'Attatch to:'");
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00014758 File Offset: 0x00012958
		private void BJ(object sender, EventArgs e)
		{
			this.yr();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00014760 File Offset: 0x00012960
		private void BM(object sender, EventArgs e)
		{
			this.qI = false;
			this.qr.eU();
			int num = 0;
			IL_2A5:
			while (num < this.sq.Value)
			{
				if (this.sb.SelectedItem != null)
				{
					foreach (Process process in Process.GetProcessesByName("Growtopia"))
					{
						IntPtr mainWindowHandle = process.MainWindowHandle;
						if (process.MainWindowTitle == this.sb.SelectedItem.ToString())
						{
							pw.SetForegroundWindow(process.MainWindowHandle);
						}
					}
				}
				else
				{
					MessageBox.Show("Please select a target window under the section 'Attach to:'");
				}
				int j = 0;
				while (j < this.si.Items.Count)
				{
					if (!this.qI)
					{
						if (this.si.GetItemCheckState(j) == CheckState.Checked)
						{
							string text = this.sf.Text;
							string keys;
							if (text != null && text == "/msg")
							{
								int num2 = new Random().Next(1, 10);
								string text2 = "";
								for (int k = 0; k < num2; k++)
								{
									text2 += " ";
								}
								string text3;
								if (j % 2 == 0)
								{
									text3 = "'";
								}
								else
								{
									text3 = "''";
								}
								keys = string.Concat(new string[]
								{
									this.sf.Text,
									" ",
									this.si.Items[j].ToString(),
									" ",
									this.sg.Text,
									text2,
									text3
								});
							}
							else
							{
								keys = this.sf.Text + " " + this.si.Items[j].ToString();
							}
							SendKeys.SendWait("{ENTER}");
							Thread.Sleep(50);
							SendKeys.SendWait(keys);
							Thread.Sleep(50);
							if (this.sf.Text == "/msg")
							{
								Thread.Sleep(250);
							}
							SendKeys.SendWait("{ENTER}");
							Thread.Sleep(50);
							if (this.sf.Text == "/msg")
							{
								this.BP((int)this.so.Value);
							}
						}
						j++;
					}
					else
					{
						pw.SetForegroundWindow(base.Handle);
						MessageBox.Show("Operation aborted!");
						IL_26C:
						if (this.sq.Value > 1m)
						{
							this.BR((int)this.ss.Value);
						}
						if (!this.qI)
						{
							num++;
							goto IL_2A5;
						}
						pw.SetForegroundWindow(base.Handle);
						MessageBox.Show("Operation aborted!");
						goto IL_2D9;
					}
				}
				goto IL_26C;
				IL_2D9:
				this.qr.eX();
				pw.SetForegroundWindow(base.Handle);
				return;
			}
			goto IL_2D9;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00014A60 File Offset: 0x00012C60
		public void BP(int BQ)
		{
			System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
			if (BQ != 0 && BQ >= 0)
			{
				timer1.Interval = BQ;
				timer1.Enabled = true;
				timer1.Start();
				timer1.Tick += delegate(object sender, EventArgs e)
				{
					timer1.Enabled = false;
					timer1.Stop();
				};
				while (timer1.Enabled)
				{
					Application.DoEvents();
				}
				return;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00014AD4 File Offset: 0x00012CD4
		public void BR(int BS)
		{
			System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
			if (BS != 0 && BS >= 0)
			{
				timer1.Interval = BS;
				timer1.Enabled = true;
				timer1.Start();
				timer1.Tick += delegate(object sender, EventArgs e)
				{
					timer1.Enabled = false;
					timer1.Stop();
				};
				while (timer1.Enabled)
				{
					Application.DoEvents();
					if (this.qI)
					{
						timer1.Enabled = false;
						timer1.Stop();
					}
				}
				return;
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00014B68 File Offset: 0x00012D68
		private void BT(object sender, EventArgs e)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00014B6C File Offset: 0x00012D6C
		private void BW(object sender, EventArgs e)
		{
			bQ.ci();
			this.BZ();
			this.sw.Items.Add("MAC Addresses Done！");
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00014B90 File Offset: 0x00012D90
		private void BZ()
		{
			foreach (NetworkInterface i in from a in NetworkInterface.GetAllNetworkInterfaces()
			where fj.cj(a.GetPhysicalAddress().GetAddressBytes(), true)
			orderby a.Speed descending
			select a)
			{
				fj fj = new fj(i);
				string text = fj.fz();
				if (!fj.cj(text, false))
				{
					MessageBox.Show("Entered MAC-address is not valid; will not update.", "Invalid MAC-address specified", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					break;
				}
				if (fj.fx(text))
				{
					Thread.Sleep(100);
					MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00014C6C File Offset: 0x00012E6C
		private void Ca(object sender, EventArgs e)
		{
			this.sx.Width = 549;
			this.sx.Height = 235;
			this.sx.Location = new Point(-4, 75);
			this.sx.Image = null;
			WebClient webClient = new WebClient();
			try
			{
				if (this.sB.Checked)
				{
					if (!Directory.Exists("Saved Worlds"))
					{
						Directory.CreateDirectory("Saved Worlds");
					}
					webClient.DownloadFile("https://s3.amazonaws.com/world.growtopiagame.com/" + this.sz.Text + ".png", "Saved Worlds\\" + this.sz.Text + ".png");
					MemoryStream memoryStream = new MemoryStream(webClient.DownloadData("https://s3.amazonaws.com/world.growtopiagame.com/" + this.sz.Text + ".png"));
					this.pT = Image.FromStream(memoryStream);
					memoryStream.Close();
					this.sx.Image = this.pT;
				}
				else
				{
					MemoryStream memoryStream2 = new MemoryStream(webClient.DownloadData("https://s3.amazonaws.com/world.growtopiagame.com/" + this.sz.Text + ".png"));
					this.pT = Image.FromStream(memoryStream2);
					memoryStream2.Close();
					this.sx.Image = this.pT;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("That world can't be rendered");
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00014DD4 File Offset: 0x00012FD4
		private void Cd()
		{
			this.sx.Width = 549 * this.sC.Value / 2;
			this.sx.Height = 235 * this.sC.Value / 2;
			Application.DoEvents();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00014E24 File Offset: 0x00013024
		private void Ce(object sender, EventArgs e)
		{
			this.Cd();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00014E2C File Offset: 0x0001302C
		private void Ch(object sender, EventArgs e)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00014E30 File Offset: 0x00013030
		private void Ck(object sender, EventArgs e)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00014E34 File Offset: 0x00013034
		private void Cn(object sender, EventArgs e)
		{
			this.sx.Location = new Point(this.sx.Location.X, this.sx.Location.Y + 25);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00014E7C File Offset: 0x0001307C
		private void Cq(object sender, EventArgs e)
		{
			this.sx.Location = new Point(this.sx.Location.X, this.sx.Location.Y - 25);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00014EC4 File Offset: 0x000130C4
		private void Ct(object sender, EventArgs e)
		{
			this.sx.Location = new Point(this.sx.Location.X - 25, this.sx.Location.Y);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00014F0C File Offset: 0x0001310C
		private void Cw(object sender, EventArgs e)
		{
			this.sx.Location = new Point(this.sx.Location.X + 25, this.sx.Location.Y);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00014F54 File Offset: 0x00013154
		private void Cz(object sender, EventArgs e)
		{
			Process.Start(Directory.GetCurrentDirectory() + "\\Saved Worlds\\");
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00014F6C File Offset: 0x0001316C
		private void CC()
		{
			this.sN.Items.Clear();
			string[] array = Ls.Lx.Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains("["))
				{
					array[i] = array[i].Replace("[", "").Replace("]", "");
					array[i] = array[i].Remove(array[i].Length - 1, 1);
					this.sN.Items.Add(array[i]);
				}
			}
			this.sN.SelectedIndex = 0;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00015018 File Offset: 0x00013218
		private void CD()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0001501C File Offset: 0x0001321C
		private void CE()
		{
			object obj = "Desktop";
			 <<<NULL>>> = ()Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			if (pw.<>o__246.<>p__0 == null)
			{
				pw.<>o__246.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(pw)));
			}
			string pathLink = pw.<>o__246.<>p__0.Target(pw.<>o__246.<>p__0, <<<NULL>>>.SpecialFolders.Item(ref obj)) + "\\GT Auto-CCS by RealGoblins.lnk";
			if (pw.<>o__246.<>p__1 == null)
			{
				pw.<>o__246.<>p__1 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(pw)));
			}
			IWshShortcut wshShortcut = pw.<>o__246.<>p__1.Target(pw.<>o__246.<>p__1, <<<NULL>>>.CreateShortcut(pathLink));
			wshShortcut.Description = "GT Auto-CCS by RealGoblins";
			wshShortcut.Hotkey = "";
			wshShortcut.TargetPath = Environment.CurrentDirectory + "\\GT Auto-CCS by RealGoblins.exe";
			wshShortcut.Save();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00015118 File Offset: 0x00013318
		private void CF(object sender, StateChangedEventArgs e)
		{
			Console.WriteLine(string.Format("State: {0}", e.State));
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				for (;;)
				{
					int num = Math.Abs(-1);
					for (;;)
					{
						switch (num)
						{
						case 0:
							Application.DoEvents();
							num = Math.Abs(-3);
							continue;
						case 1:
						{
							string item = string.Format("State: {0}", e.State);
							num = Math.Abs(0);
							continue;
						}
						case 2:
							goto IL_B8;
						case 3:
						{
							string item;
							this.sw.Items.Add(item);
							num = Math.Abs(-4);
							continue;
						}
						case 4:
							this.sw.Refresh();
							num = Math.Abs(-2);
							continue;
						}
						break;
					}
				}
				IL_B8:
				Application.DoEvents();
			}));
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0001516C File Offset: 0x0001336C
		private void CI(object sender, DotRas.ErrorEventArgs e)
		{
			Console.WriteLine(string.Format("Error: {0}", e.GetException()));
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.sw.Items.Add(string.Format("Error: {0}", e.GetException()));
				Application.DoEvents();
			}));
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000151BC File Offset: 0x000133BC
		private void CL(object sender, EventArgs e)
		{
			this.sw.Items.Add("Connecting...");
			this.sN.Enabled = false;
			this.sK.Enabled = false;
			this.sL.Enabled = true;
			string vpn_name = this.sN.SelectedItem.ToString();
			new Thread(delegate()
			{
				this.CO(vpn_name, "vpn", "vpn");
			}).Start();
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0001523C File Offset: 0x0001343C
		private void CO(string CP, string CQ, string CR)
		{
			this.pV = new RasDialer();
			this.pV.StateChanged += this.CF;
			this.pV.Error += this.CI;
			File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk", Ls.Lv);
			this.pV.PhoneBookPath = Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk";
			this.pV.EntryName = CP;
			this.pV.Credentials = new NetworkCredential(CQ, CR);
			try
			{
				this.pU = this.pV.Connect();
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					this.sw.Items.Add("Connection succeded!");
					this.sw.Items.Add(" ");
					Application.DoEvents();
				}));
				File.Delete(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk");
			}
			catch (Exception ex)
			{
				Exception ex3;
				Exception ex2 = ex3;
				Exception ex = ex2;
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					for (;;)
					{
						int num = Math.Abs(-5);
						for (;;)
						{
							switch (num)
							{
							case 0:
								this.sw.Items.Add(ex);
								num = Math.Abs(-4);
								continue;
							case 1:
								this.sN.Enabled = true;
								num = Math.Abs(-3);
								continue;
							case 2:
								goto IL_FC;
							case 3:
								this.sK.Enabled = true;
								num = Math.Abs(-2);
								continue;
							case 4:
								this.sw.Items.Add(" ");
								num = Math.Abs(-1);
								continue;
							case 5:
								this.sw.Items.Add("Connection failed!");
								num = Math.Abs(0);
								continue;
							}
							break;
						}
					}
					IL_FC:
					Application.DoEvents();
				}));
				File.Delete(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk");
			}
			File.Exists(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk");
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00015370 File Offset: 0x00013570
		private void CS(object sender, EventArgs e)
		{
			this.sN.Enabled = true;
			this.sK.Enabled = true;
			if (this.pU != null)
			{
				this.pU.Disconnect();
				this.sw.Items.Add("Connection disconnected!");
				this.sw.Items.Add(" ");
				Application.DoEvents();
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000153E0 File Offset: 0x000135E0
		private void CV(object sender, EventArgs e)
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "rasdial.exe",
					Arguments = "",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}
			};
			process.Start();
			while (!process.StandardOutput.EndOfStream)
			{
				string item = process.StandardOutput.ReadLine();
				this.sw.Items.Add(item);
				Application.DoEvents();
			}
			this.sw.Items.Add(" ");
			Application.DoEvents();
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00015480 File Offset: 0x00013680
		private void CY(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00015484 File Offset: 0x00013684
		private void Db(object sender, EventArgs e)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00015488 File Offset: 0x00013688
		private void De(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0001548C File Offset: 0x0001368C
		private void Dh(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(Environment.ExitCode);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00015498 File Offset: 0x00013698
		private void Dk(object sender, EventArgs e)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001549C File Offset: 0x0001369C
		private void Dn(object sender, EventArgs e)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000154A0 File Offset: 0x000136A0
		private void Dq(object sender, EventArgs e)
		{
			if (this.sR.CheckState == CheckState.Checked)
			{
				this.qs = Process.GetProcessesByName("Growtopia");
				this.qp.eU();
				return;
			}
			this.qp.eX();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000154E4 File Offset: 0x000136E4
		private void Dt(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = 
				{
					FileName = "MAC Address Tool",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00015514 File Offset: 0x00013714
		private void Dw(object sender, EventArgs e)
		{
			int num = (int)Math.Max(400.0 - (double)this.sg.Text.Length / 5.0 * 50.0, 75.0);
			this.so.Value = this.sg.Text.Length * num;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00015584 File Offset: 0x00013784
		private void Dz(object sender, EventArgs e)
		{
			Process process = new Process();
			process.StartInfo.FileName = this.uE;
			process.Start();
			Process process2 = process;
			switch (this.uq.SelectedIndex)
			{
			case 0:
				process2.PriorityClass = ProcessPriorityClass.RealTime;
				break;
			case 1:
				process2.PriorityClass = ProcessPriorityClass.High;
				break;
			case 2:
				process2.PriorityClass = ProcessPriorityClass.AboveNormal;
				break;
			case 3:
				process2.PriorityClass = ProcessPriorityClass.Normal;
				break;
			case 4:
				process2.PriorityClass = ProcessPriorityClass.BelowNormal;
				break;
			case 5:
				process2.PriorityClass = ProcessPriorityClass.Idle;
				break;
			}
			(long)process2.ProcessorAffinity;
			double num = 0.0;
			for (int i = 0; i < this.ur.Items.Count; i++)
			{
				if (this.ur.GetItemChecked(i))
				{
					num += Math.Pow(2.0, (double)i);
				}
			}
			int value = (int)num;
			Console.WriteLine(Convert.ToString(value, 2));
			process2.ProcessorAffinity = (IntPtr)value;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00015698 File Offset: 0x00013898
		public void DC(bool DD, Process DE)
		{
			List<string> list = new List<string>();
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.tc.AppendText(DE.MainWindowTitle + " -> Captcha Solver Started! \r\n");
				Application.DoEvents();
			}));
			bool flag = true;
			Mem mem = new Mem();
			mem.OpenProcess(DE.Id);
			while (flag & this.qd)
			{
				Task<IEnumerable<long>> task = mem.AoBScan("57 68 61 74 20 77 69 6C 6C 20 62 65 20 74 68 65 20 73 75 6D 20 6F 66 20 74 68 65 20 66 6F 6C 6C 6F 77 69 6E 67 20 6E 75 6D 62 65 72 73 7C 6C 65 66 74 7C 0A 61 64 64 5F 74 65 78 74 62 6F 78 7C", true, false, "");
				task.Result.Count<long>();
				foreach (long num in task.Result)
				{
					this.qb = num;
					string read_str = mem.readString(this.qb.ToString("x"), "", 75, false);
					read_str = read_str.Substring(60);
					read_str = read_str.Replace("|", "");
					read_str = read_str.Replace("b", "");
					read_str = read_str.Replace("o", "");
					read_str = read_str.Replace("x", "");
					read_str = read_str.Replace(" ", "");
					read_str = read_str.Replace("l", "");
					read_str = read_str.Replace("e", "");
					read_str = read_str.Replace("f", "");
					read_str = read_str.Replace("t", "");
					Console.WriteLine(read_str);
					if (!list.Contains(read_str))
					{
						if (this.qj[DE.MainWindowTitle].HK)
						{
							this.qj[DE.MainWindowTitle].HO = true;
							Thread.Sleep(500);
						}
						if (this.qj[DE.MainWindowTitle].HS)
						{
							this.qj[DE.MainWindowTitle].HW = true;
							Thread.Sleep(500);
						}
						this.qc = read_str;
						list.Add(read_str);
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.tc.AppendText(DE.MainWindowTitle + " -> Captcha found: " + read_str + "\r\n");
							Application.DoEvents();
						}));
						string[] source = read_str.Split(new char[]
						{
							'+'
						});
						int num1;
						int num2;
						if (int.TryParse(source.First<string>(), out num1) & int.TryParse(source.Last<string>(), out num2))
						{
							int value = num1 + num2;
							Console.WriteLine(value);
							string text = value.ToString();
							text = "\b\b\b\b\b\b\b\b\b" + text;
							string text2 = text;
							int i;
							for (i = 0; i < text2.Length; i++)
							{
								short num9 = pw.VkKeyScan(text2[i]);
								int num3 = (int)(num9 & 255);
								bool flag2 = (num9 & 256) > 0;
								bool flag3 = (num9 & 512) > 0;
								bool flag4 = (num9 & 1024) > 0;
								if (flag2)
								{
									pw.keybd_event(160, 42, 0, 0);
									Thread.Sleep(50);
								}
								if (flag4 && flag3)
								{
									pw.keybd_event(164, 56, 0, 0);
									pw.keybd_event(162, 29, 0, 0);
									Thread.Sleep(50);
								}
								pw.Hb(DE.MainWindowHandle, (byte)num3, false);
								Thread.Sleep(50);
								if (flag2)
								{
									pw.keybd_event(160, 170, 2, 0);
									Thread.Sleep(50);
								}
								if (flag4 && flag3)
								{
									pw.keybd_event(164, 184, 2, 0);
									pw.keybd_event(162, 157, 2, 0);
									Thread.Sleep(50);
								}
							}
							Rectangle rectangle;
							pw.GetWindowRect(DE.MainWindowHandle, out rectangle);
							double num4 = (double)rectangle.Width;
							int height = rectangle.Height;
							i = rectangle.Width;
							if (i <= 1280)
							{
								if (i != 1024)
								{
									if (i != 1280)
									{
									}
								}
							}
							else if (i != 1366)
							{
								if (i != 1536)
								{
									if (i != 1920)
									{
									}
								}
							}
							IL_538:
							num4 = (double)this.qB;
							int num5 = (int)((double)this.qC);
							int num6 = (int)num4;
							int num7 = num5;
							IntPtr zero = IntPtr.Zero;
							IntPtr vA = (IntPtr)(num7 << 16 | num6);
							zero = IntPtr.Zero;
							pw.SendMessage(DE.MainWindowHandle, 513U, zero, vA);
							Thread.Sleep(100);
							pw.SendMessage(DE.MainWindowHandle, 514U, zero, vA);
							Thread.Sleep(100);
							pw.SendMessage(DE.MainWindowHandle, 513U, zero, vA);
							Thread.Sleep(100);
							pw.SendMessage(DE.MainWindowHandle, 514U, zero, vA);
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								int num8 = num1 + num2;
								this.tc.AppendText(string.Concat(new string[]
								{
									DE.MainWindowTitle,
									" -> Captcha Solved: ",
									read_str,
									" = ",
									num8.ToString(),
									"\r\n"
								}));
							}));
							if (this.qj[DE.MainWindowTitle].HK)
							{
								Thread.Sleep(500);
								this.qj[DE.MainWindowTitle].HO = false;
							}
							if (this.qj[DE.MainWindowTitle].HS)
							{
								Thread.Sleep(500);
								this.qj[DE.MainWindowTitle].HW = false;
								continue;
							}
							continue;
							goto IL_538;
						}
					}
				}
				if (!DD)
				{
					flag = false;
				}
				Thread.Sleep(10000);
			}
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.tc.AppendText(DE.MainWindowTitle + " -> Captcha Solver Exited! \r\n");
			}));
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00015DE4 File Offset: 0x00013FE4
		private void DF(object sender, EventArgs e)
		{
			if (!this.sU.Checked)
			{
				this.qa = false;
				return;
			}
			if (this.sb.SelectedItem != null)
			{
				this.qa = true;
				new Thread(new ThreadStart(this.DI)).Start();
				return;
			}
			MessageBox.Show("Please select a window under 'Attatch to:'");
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00015E3C File Offset: 0x0001403C
		public void DI()
		{
			while (this.qa)
			{
				base.Invoke(new Action(delegate()
				{
					int topIndex = this.si.TopIndex;
					this.sj.Text = "GT:" + this.sb.Text;
					this.ql.Clear();
					for (int i = 0; i < this.si.Items.Count; i++)
					{
						this.ql.Add(this.si.Items[i].ToString(), new HX(this.si.Items[i].ToString(), this.si.GetItemCheckState(i)));
					}
					List<string> list = this.Hf(this.qj[this.sb.Text], this.sT.SelectedIndex);
					this.si.Items.Clear();
					for (int j = 0; j < list.Count; j++)
					{
						if (this.sh.Checked)
						{
							this.si.Items.Add(list[j], this.sh.Checked);
							this.si.TopIndex = topIndex;
						}
						else if (this.ql.ContainsKey(list[j]))
						{
							this.si.Items.Add(list[j], this.ql[list[j]].Ih);
							this.si.TopIndex = topIndex;
						}
						else
						{
							this.si.Items.Add(list[j]);
							this.si.TopIndex = topIndex;
						}
					}
					this.sh.Text = "Select all (" + this.si.Items.Count.ToString() + ")";
					this.si.TopIndex = topIndex;
				}));
				this.BP(2000);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00015E74 File Offset: 0x00014074
		protected virtual bool IsFileLocked(FileInfo file)
		{
			bool result;
			try
			{
				using (FileStream fileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
				{
					fileStream.Close();
				}
				return false;
			}
			catch (IOException)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00015EC4 File Offset: 0x000140C4
		private void DJ(object sender, EventArgs e)
		{
			if (File.Exists("memory.dll"))
			{
				FileInfo file = new FileInfo("memory.dll");
				if (this.IsFileLocked(file))
				{
					MessageBox.Show("Memory.dll seems to exist but is unaccessable, most likely by anti-virus.");
				}
			}
			else
			{
				MessageBox.Show("Memory.dll doesn't seem to exist. Please download a new version of the application. The DLL might be removed by your anti-virus");
			}
			this.yr();
			this.qd = true;
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				Process p = processesByName[i];
				Thread thread = new Thread(delegate()
				{
					this.DC(false, p);
				});
				thread.Start();
				thread.Priority = ThreadPriority.Lowest;
				Thread.Sleep(250);
			}
			Application.DoEvents();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00015F70 File Offset: 0x00014170
		private void DM(object sender, EventArgs e)
		{
			this.sY.Hide();
			this.sZ.Show();
			this.qd = false;
			Application.DoEvents();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00015FA0 File Offset: 0x000141A0
		private void DP(object sender, EventArgs e)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00015FA4 File Offset: 0x000141A4
		private void DS(object sender, EventArgs e)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00015FA8 File Offset: 0x000141A8
		private void DV(object sender, EventArgs e)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00015FAC File Offset: 0x000141AC
		private void DY(object sender, EventArgs e)
		{
			if (this.tu.Checked)
			{
				this.tr.Enabled = true;
				return;
			}
			this.tr.Enabled = false;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00015FE0 File Offset: 0x000141E0
		private void Eb(object sender, EventArgs e)
		{
			if (this.tt.Checked)
			{
				this.tq.Enabled = true;
				return;
			}
			this.tq.Enabled = false;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00016014 File Offset: 0x00014214
		private void Ee(object sender, EventArgs e)
		{
			if (this.ts.Checked)
			{
				this.tp.Enabled = true;
				return;
			}
			this.tp.Enabled = false;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00016048 File Offset: 0x00014248
		private void Eh(object sender, EventArgs e)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001604C File Offset: 0x0001424C
		private void Ek(object sender, EventArgs e)
		{
			pw.qe = new IE();
			pw.qe.Jb("mouse");
			pw.qe.Show();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00016074 File Offset: 0x00014274
		private void En(object sender, EventArgs e)
		{
			this.ty.BackColor = Color.Transparent;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00016088 File Offset: 0x00014288
		private void Eq(object sender, EventArgs e)
		{
			this.ty.BackColor = Color.Transparent;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001609C File Offset: 0x0001429C
		private void Et(object sender, EventArgs e)
		{
			this.ty.BackColor = Color.Transparent;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000160B0 File Offset: 0x000142B0
		private void Ew(object sender, EventArgs e)
		{
			this.ty.BackColor = Color.Transparent;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000160C4 File Offset: 0x000142C4
		private void Ez(object sender, EventArgs e)
		{
			pw.qe = new IE();
			pw.qe.Jb("unbanner");
			pw.qe.Show();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000160EC File Offset: 0x000142EC
		private void EC(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000160F0 File Offset: 0x000142F0
		private void EF(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000160F4 File Offset: 0x000142F4
		private void EI(object sender, KeyPressEventArgs e)
		{
			if (DateTime.Now.Minute % 2 == 0)
			{
				try
				{
					if (pw.qg)
					{
						string text = this.yA(string.Concat(new string[]
						{
							bQ.ce(),
							"bin",
							Settings.Default.Setting1,
							"itLYJ",
							cF.MA
						}));
						if (text == "0")
						{
							this.tB.Text = "Account type: Free";
							this.sc.Enabled = false;
							this.tt.Enabled = false;
							this.tt.Checked = false;
							this.ts.Enabled = false;
							this.ts.Checked = false;
							this.tx.Checked = false;
							this.tw.Checked = false;
						}
						if (text.Contains(pw.qh))
						{
							this.tB.Text = "Account type: Premium";
						}
						else
						{
							this.tB.Text = "Account type: Free";
							this.sc.Enabled = false;
							this.tt.Enabled = false;
							this.tt.Checked = false;
							this.ts.Enabled = false;
							this.ts.Checked = false;
							this.tx.Checked = false;
							this.tw.Checked = false;
						}
					}
					else
					{
						this.tB.Text = "Account type: Free";
						this.sc.Enabled = false;
						this.tt.Enabled = false;
						this.tt.Checked = false;
						this.ts.Enabled = false;
						this.ts.Checked = false;
						this.tx.Checked = false;
						this.tw.Checked = false;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000162E0 File Offset: 0x000144E0
		private void EL(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000162E4 File Offset: 0x000144E4
		private void EO(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000162E8 File Offset: 0x000144E8
		private void ER(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				this.tw.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00016318 File Offset: 0x00014518
		private void EU(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				this.tx.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00016348 File Offset: 0x00014548
		private void EX(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				this.tH.Value = 100;
				this.qi = 100;
				MessageBox.Show("[Premium users only]");
				return;
			}
			this.qi = this.tH.Value;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000163A0 File Offset: 0x000145A0
		private void Fa(object sender, EventArgs e)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000163A4 File Offset: 0x000145A4
		private void Fd(object sender, EventArgs e)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000163A8 File Offset: 0x000145A8
		private void Fg(object sender, DragEventArgs e)
		{
			object data = e.Data.GetData(DataFormats.FileDrop);
			if (data != null)
			{
				string[] array = data as string[];
				if (array.Length != 0)
				{
					this.tS.Items.Add(array[0]);
				}
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000163E8 File Offset: 0x000145E8
		private void Fj(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001641C File Offset: 0x0001461C
		private void Fm(object sender, EventArgs e)
		{
			this.rF = new OpenFileDialog
			{
				FileName = "save.dat",
				Filter = "Data files (*.dat)|*.dat",
				Title = "Select the save.dat",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\Local\\Growtopia\\",
				Multiselect = false
			};
			if (this.rF.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.tR.Text = this.rF.SafeFileName;
				}
				catch (SecurityException ex)
				{
					MessageBox.Show("Security error.\n\nError message: " + ex.Message + "\n\nDetails:\n\n" + ex.StackTrace);
				}
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000164D0 File Offset: 0x000146D0
		private void Fp(object sender, EventArgs e)
		{
			this.tS.Items.Clear();
			if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Accounts\\"))
			{
				for (int i = 0; i < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); i++)
				{
					this.tS.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[i]));
				}
				return;
			}
			MessageBox.Show("No accounts available!");
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00016560 File Offset: 0x00014760
		private void oT(object sender, EventArgs e)
		{
			if (this.tR.Text == "Select a file")
			{
				MessageBox.Show("Please select a file containing the username and password first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (!Directory.Exists("Accounts"))
			{
				Directory.CreateDirectory("Accounts");
			}
			File.Copy(this.rF.FileName, this.FD(Directory.GetCurrentDirectory() + "\\Accounts\\save (" + this.tO.Text + ").dat"));
			this.tS.Items.Clear();
			for (int i = 0; i < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); i++)
			{
				this.tS.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[i]));
			}
			this.tR.Text = "Select a file";
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00016654 File Offset: 0x00014854
		private void Fu(object sender, EventArgs e)
		{
			foreach (object obj in this.tS.CheckedItems)
			{
				File.Delete(Directory.GetCurrentDirectory() + "\\Accounts\\" + ((obj != null) ? obj.ToString() : null));
			}
			this.tS.Items.Clear();
			if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Accounts\\"))
			{
				for (int i = 0; i < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); i++)
				{
					this.tS.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[i]));
				}
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00016740 File Offset: 0x00014940
		private void Fx(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				this.tT.Checked = false;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00016768 File Offset: 0x00014968
		private void FA(object sender, EventArgs e)
		{
			if (!this.tT.Checked)
			{
				this.tV.Checked = false;
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00016784 File Offset: 0x00014984
		public string FD(string FE)
		{
			string directoryName = Path.GetDirectoryName(FE);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(FE);
			string extension = Path.GetExtension(FE);
			int num = 1;
			while (File.Exists(FE))
			{
				FE = Path.Combine(directoryName, string.Concat(new string[]
				{
					fileNameWithoutExtension,
					" (",
					num.ToString(),
					")",
					extension
				}));
				num++;
			}
			return FE;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000167EC File Offset: 0x000149EC
		private void FF(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				this.tT.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001681C File Offset: 0x00014A1C
		private void FI(object sender, EventArgs e)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00016820 File Offset: 0x00014A20
		private void FL(object sender, EventArgs e)
		{
			MessageBox.Show(cF.Mw, "Premium features", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00016838 File Offset: 0x00014A38
		private void FO(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				MessageBox.Show("[Premium users only]");
				return;
			}
			this.xA();
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00016870 File Offset: 0x00014A70
		private void FR(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				MessageBox.Show("[Premium users only]");
				return;
			}
			this.xz();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000168A8 File Offset: 0x00014AA8
		private void FU(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Free")
			{
				this.tZ.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
			else if (this.tZ.Checked)
			{
				Settings.Default.SL = true;
			}
			else
			{
				Settings.Default.SL = false;
			}
			Settings.Default.Save();
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00016914 File Offset: 0x00014B14
		private void FX(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.ShowDialog();
			this.ue.Text = openFileDialog.FileName;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00016948 File Offset: 0x00014B48
		private void Ga(object sender, EventArgs e)
		{
			this.ui.Rows.Clear();
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "Save Decrypter by RealGoblins.exe";
			process.StartInfo.RedirectStandardOutput = true;
			if (this.ue.Text != "")
			{
				string str = "-path=" + this.ue.Text;
				process.StartInfo.Arguments = "RG " + str;
			}
			else
			{
				process.StartInfo.Arguments = "RG";
			}
			process.Start();
			foreach (string text in process.StandardOutput.ReadToEnd().Split(new string[]
			{
				"\r\n",
				"\r",
				"\n"
			}, StringSplitOptions.None))
			{
				if (text != "")
				{
					try
					{
						if (text.ToCharArray().Count((char c) => c == ':') > 1)
						{
							string[] array2 = new string[]
							{
								"Mac",
								text
							};
							DataGridViewRowCollection rows = this.ui.Rows;
							object[] values = array2;
							rows.Add(values);
						}
						else
						{
							string text2 = text.Split(new char[]
							{
								':'
							}).First<string>();
							string text3 = text.Split(new char[]
							{
								':'
							}).Last<string>().Substring(1, text.Split(new char[]
							{
								':'
							}).Last<string>().Length - 1);
							string[] array3 = new string[]
							{
								text2,
								text3
							};
							DataGridViewRowCollection rows2 = this.ui.Rows;
							object[] values = array3;
							rows2.Add(values);
							if (text2 == "tankid_password")
							{
								this.uk.Text = "Pass: " + text3;
							}
							if (text2 == "tankid_name")
							{
								this.uj.Text = "GrowID: " + text3;
							}
						}
					}
					catch (Exception)
					{
						string[] array4 = new string[]
						{
							text
						};
						DataGridViewRowCollection rows3 = this.ui.Rows;
						object[] values = array4;
						rows3.Add(values);
					}
				}
			}
			process.WaitForExit();
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00016BC8 File Offset: 0x00014DC8
		private void Gd(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00016BCC File Offset: 0x00014DCC
		private void Gg(object sender, EventArgs e)
		{
			try
			{
				this.xQ();
				Cursor.Current = Cursors.AppStarting;
				this.xU();
				Application.DoEvents();
				Application.DoEvents();
				Console.WriteLine("Users online: " + this.xW());
				MessageBox.Show("Users online: " + this.xW());
				Cursor.Current = Cursors.Default;
				this.un.Text = "Users online: " + this.xW();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			try
			{
				this.xR();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00016C80 File Offset: 0x00014E80
		private void Gj(object sender, EventArgs e)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00016C84 File Offset: 0x00014E84
		private void Gm(object sender, EventArgs e)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00016C88 File Offset: 0x00014E88
		private void Gp(object sender, EventArgs e)
		{
			if (this.tB.Text == "Account type: Premium")
			{
				switch (this.uz.SelectedIndex)
				{
				case 0:
					for (int i = 0; i < this.ur.Items.Count; i++)
					{
						this.ur.SetItemCheckState(i, CheckState.Unchecked);
					}
					this.ur.SetItemCheckState(this.ur.Items.Count - 1, CheckState.Checked);
					this.uq.SelectedIndex = 5;
					break;
				case 1:
					for (int j = 0; j < this.ur.Items.Count; j++)
					{
						this.ur.SetItemCheckState(j, CheckState.Unchecked);
					}
					for (int k = this.ur.Items.Count - 1; k >= this.ur.Items.Count / 2; k--)
					{
						this.ur.SetItemCheckState(k, CheckState.Checked);
					}
					this.uq.SelectedIndex = 3;
					break;
				case 2:
					for (int l = 0; l < this.ur.Items.Count; l++)
					{
						this.ur.SetItemCheckState(l, CheckState.Checked);
					}
					this.uq.SelectedIndex = 0;
					break;
				}
			}
			else
			{
				for (int m = 0; m < this.ur.Items.Count; m++)
				{
					this.ur.SetItemCheckState(m, CheckState.Checked);
				}
				if (this.uz.SelectedIndex != 1)
				{
					this.uz.SelectedIndex = 1;
					MessageBox.Show("[Premium users only]");
				}
			}
			this.qN = false;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00016E34 File Offset: 0x00015034
		private void Gs(object sender, EventArgs e)
		{
			if (!(this.tB.Text == "Account type: Premium") && this.ur.CheckedItems.Count != this.ur.Items.Count)
			{
				for (int i = 0; i < this.ur.Items.Count; i++)
				{
					this.ur.SetItemCheckState(i, CheckState.Checked);
				}
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00016EB0 File Offset: 0x000150B0
		private void Gv(object sender, EventArgs e)
		{
			if (!(this.tB.Text == "Account type: Premium") && this.uq.SelectedIndex != 3)
			{
				this.uq.SelectedIndex = 3;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00016EFC File Offset: 0x000150FC
		private void Gy(object sender, MouseEventArgs e)
		{
			if (!(this.tB.Text == "Account type: Premium"))
			{
				if (this.ur.CheckedItems.Count != this.ur.Items.Count)
				{
					for (int i = 0; i < this.ur.Items.Count; i++)
					{
						this.ur.SetItemCheckState(i, CheckState.Checked);
					}
					MessageBox.Show("[Premium users only]");
					return;
				}
				for (int j = 0; j < this.ur.Items.Count; j++)
				{
					this.ur.SetItemCheckState(j, CheckState.Checked);
				}
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00016FA0 File Offset: 0x000151A0
		private void GB(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00016FA4 File Offset: 0x000151A4
		private void GE(object sender, EventArgs e)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00016FA8 File Offset: 0x000151A8
		private void GH(object sender, MouseEventArgs e)
		{
			if (!(this.tB.Text == "Account type: Premium"))
			{
				if (this.ur.CheckedItems.Count != this.ur.Items.Count)
				{
					for (int i = 0; i < this.ur.Items.Count; i++)
					{
						this.ur.SetItemCheckState(i, CheckState.Checked);
					}
					MessageBox.Show("[Premium users only]");
					return;
				}
				for (int j = 0; j < this.ur.Items.Count; j++)
				{
					this.ur.SetItemCheckState(j, CheckState.Checked);
				}
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0001704C File Offset: 0x0001524C
		private void GK(object sender, EventArgs e)
		{
			this.sZ.Hide();
			this.sY.Show();
			if (File.Exists("memory.dll"))
			{
				FileInfo file = new FileInfo("memory.dll");
				if (this.IsFileLocked(file))
				{
					MessageBox.Show("Memory.dll seems to exist but is unaccessable, most likely by anti-virus.");
				}
			}
			else
			{
				MessageBox.Show("Memory.dll doesn't seem to exist. Please download a new version of the application. The DLL might be removed by your anti-virus");
			}
			this.qd = true;
			this.yr();
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				Process p = processesByName[i];
				new Thread(delegate()
				{
					this.DC(true, p);
				})
				{
					Priority = ThreadPriority.Lowest
				}.Start();
				Thread.Sleep(250);
			}
			Application.DoEvents();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00017110 File Offset: 0x00015310
		private void GN(object sender, EventArgs e)
		{
			this.qF = 3;
			this.qq.eU();
			MessageBox.Show("Put the window in foreground, hover the cursor over the Submit button and press Space");
			Application.DoEvents();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00017140 File Offset: 0x00015340
		public IntPtr GQ(Process GR, byte[] GS)
		{
			ProcessModule mainModule = GR.MainModule;
			long num = (long)mainModule.BaseAddress;
			long num2 = (long)mainModule.ModuleMemorySize;
			for (long num3 = 0L; num3 < num2; num3 += 1L)
			{
				byte[] array = new byte[GS.Length];
				pw.ReadProcessMemory(GR.Handle, (IntPtr)(num + num3), array, GS.Length, 0);
				if (this.GT(array, GS))
				{
					return (IntPtr)(num + num3);
				}
			}
			return IntPtr.Zero;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000171C0 File Offset: 0x000153C0
		public bool GT(byte[] GU, byte[] GV)
		{
			if (GU.Length != GV.Length)
			{
				return false;
			}
			if (GU == GV)
			{
				return true;
			}
			for (int i = 0; i < GU.Length; i++)
			{
				if (GU[i] != GV[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000171F8 File Offset: 0x000153F8
		private void GW(pw.Oe.OY GX)
		{
			IntPtr intPtr;
			if (!pw.DuplicateHandle(Process.GetProcessById(GX.OZ).Handle, GX.Pc, IntPtr.Zero, out intPtr, 0U, false, 1U))
			{
				MessageBox.Show("Failed to close mutex: " + Marshal.GetLastWin32Error().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			Console.WriteLine("Mutex was killed");
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001725C File Offset: 0x0001545C
		public static bool GY(string GZ)
		{
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				if (processesByName[i].MainWindowTitle == GZ)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00017298 File Offset: 0x00015498
		public static int Ha()
		{
			int num = 0;
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000172C8 File Offset: 0x000154C8
		public static void Hb(IntPtr Hc, byte Hd, bool He)
		{
			uint num = pw.MapVirtualKey((uint)Hd, 0U);
			uint num2 = 1U | num << 16;
			if (He)
			{
				num2 |= 16777216U;
			}
			pw.PostMessageA(Hc, 256U, (int)Hd, (int)num2);
			num2 |= 3221225472U;
			pw.PostMessageA(Hc, 257U, (int)Hd, (int)num2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00017314 File Offset: 0x00015514
		private List<string> Hf(Hs Hg, int Hh)
		{
			Process process = null;
			int num = 100;
			List<string> list = new List<string>();
			foreach (Process process2 in Process.GetProcessesByName("Growtopia"))
			{
				if (Hg.HC == process2.MainWindowTitle)
				{
					IntPtr mainWindowHandle = process2.MainWindowHandle;
					process = process2;
					IL_52:
					byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L0oxNEV1c1ZB");
					string @string = Encoding.UTF8.GetString(bytes);
					string[] array = this.yA(@string).Split(new string[]
					{
						Environment.NewLine
					}, StringSplitOptions.None);
					if (process != null)
					{
						IntPtr value = pw.OpenProcess_1(16U, false, process.Id);
						IntPtr intPtr = process.MainModule.BaseAddress;
						if (Hh == 0)
						{
							intPtr += 4253488;
						}
						if (Hh == 1)
						{
							intPtr += 5328072;
							int[] ho = new int[]
							{
								64,
								280,
								32,
								32,
								0
							};
							intPtr = pw.Hl((int)value, intPtr, ho) + 5672 - 3048;
						}
						if (Hh == 2)
						{
							intPtr += 5406608;
						}
						if (Hh == 3)
						{
							intPtr += 5542224;
						}
						if (Hh == 4)
						{
							int.Parse(array[1], NumberStyles.HexNumber);
							intPtr += int.Parse(array[1], NumberStyles.HexNumber);
						}
						for (int j = 0; j < num + 1; j++)
						{
							int[] array2 = null;
							if (Hh == 0)
							{
								array2 = new int[j + 5];
								array2[0] = 2832;
								array2[1] = 360;
								array2[2] = 0;
								for (int k = 0; k < j; k++)
								{
									array2[k + 3] = 0;
								}
								array2[j + 3] = 16;
								array2[j + 4] = 0;
							}
							if (Hh == 1)
							{
								array2 = new int[j + 5];
								array2[0] = 544;
								array2[1] = 360;
								array2[2] = 0;
								for (int l = 0; l < j; l++)
								{
									array2[l + 3] = 0;
								}
								array2[j + 3] = 16;
								array2[j + 4] = 0;
							}
							if (Hh == 2)
							{
								array2 = new int[j + 9];
								array2[0] = 64;
								array2[1] = 280;
								array2[2] = 32;
								array2[3] = 32;
								array2[4] = 760;
								array2[5] = 376;
								array2[6] = 0;
								for (int m = 0; m < j; m++)
								{
									array2[m + 7] = 0;
								}
								array2[j + 7] = 16;
								array2[j + 8] = 0;
							}
							if (Hh == 3)
							{
								array2 = new int[j + 9];
								array2[0] = 64;
								array2[1] = 280;
								array2[2] = 32;
								array2[3] = 32;
								array2[4] = 760;
								array2[5] = 360;
								array2[6] = 0;
								for (int n = 0; n < j; n++)
								{
									array2[n + 7] = 0;
								}
								array2[j + 7] = 16;
								array2[j + 8] = 0;
							}
							if (Hh == 4)
							{
								array2 = new int[j + 9];
								array2[0] = int.Parse(array[2], NumberStyles.HexNumber);
								array2[1] = int.Parse(array[3], NumberStyles.HexNumber);
								array2[2] = int.Parse(array[4], NumberStyles.HexNumber);
								array2[3] = int.Parse(array[5], NumberStyles.HexNumber);
								array2[4] = int.Parse(array[6], NumberStyles.HexNumber);
								array2[5] = int.Parse(array[7], NumberStyles.HexNumber);
								array2[6] = int.Parse(array[8], NumberStyles.HexNumber);
								for (int num2 = 0; num2 < j; num2++)
								{
									array2[num2 + 7] = 0;
								}
								array2[j + 7] = 16;
								array2[j + 8] = 0;
							}
							IntPtr intPtr2 = pw.Hl((int)value, intPtr, array2);
							if (intPtr2 == IntPtr.Zero)
							{
								break;
							}
							IntPtr intPtr3 = intPtr2 + 40;
							int[] ho2 = new int[]
							{
								0
							};
							IntPtr intPtr4 = pw.Hl((int)value, intPtr3, ho2);
							string text;
							if (this.Hp((int)value, intPtr4) == 0)
							{
								text = this.Hi((int)value, intPtr3);
								if (!text.StartsWith("`"))
								{
									break;
								}
							}
							else
							{
								text = this.Hi((int)value, intPtr4);
								if (!text.StartsWith("`"))
								{
									break;
								}
							}
							text = text.Replace("`", "");
							text = text.Substring(1, text.Length - 1);
							list.Add(text);
						}
					}
					return list;
				}
			}
			goto IL_52;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00017788 File Offset: 0x00015988
		private string Hi(int Hj, IntPtr Hk)
		{
			int num = 0;
			byte[] array = new byte[40];
			pw.ReadProcessMemory_1(Hj, Hk, array, array.Length, ref num);
			int count = array.Length;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 0)
				{
					count = i;
					break;
				}
			}
			return Encoding.Default.GetString(array, 0, count);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000177D8 File Offset: 0x000159D8
		public static IntPtr Hl(int Hm, IntPtr Hn, int[] Ho)
		{
			int num = 0;
			byte[] array = new byte[IntPtr.Size];
			foreach (int offset in Ho)
			{
				if (pw.ReadProcessMemory_1(Hm, Hn, array, array.Length, ref num))
				{
					Hn = ((IntPtr.Size == 4) ? IntPtr.Add(new IntPtr(BitConverter.ToInt32(array, 0)), offset) : (Hn = IntPtr.Add(new IntPtr(BitConverter.ToInt64(array, 0)), offset)));
				}
			}
			return Hn;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001784C File Offset: 0x00015A4C
		private int Hp(int Hq, IntPtr Hr)
		{
			int num = 0;
			byte[] array = new byte[4];
			pw.ReadProcessMemory_1(Hq, Hr, array, array.Length, ref num);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000178A4 File Offset: 0x00015AA4
		private void oZ()
		{
			this.oL = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(pw));
			this.rF = new OpenFileDialog();
			this.su = new PictureBox();
			this.sO = new BackgroundWorker();
			this.sP = new Label();
			this.td = new PictureBox();
			this.tz = new ToolTip(this.oL);
			this.qO = new GroupBox();
			this.tE = new Label();
			this.tF = new Label();
			this.tG = new Label();
			this.qY = new CheckedListBox();
			this.rf = new CheckBox();
			this.qZ = new Button();
			this.tH = new TrackBar();
			this.rc = new Button();
			this.rd = new Button();
			this.qP = new GroupBox();
			this.ty = new Button();
			this.rh = new NumericUpDown();
			this.ri = new NumericUpDown();
			this.rj = new Button();
			this.rk = new Label();
			this.rl = new Label();
			this.rm = new Label();
			this.ra = new NumericUpDown();
			this.rb = new NumericUpDown();
			this.qQ = new Button();
			this.qR = new Button();
			this.qS = new Label();
			this.qT = new Label();
			this.qU = new Label();
			this.qV = new MaskedTextBox();
			this.qW = new Label();
			this.tw = new CheckBox();
			this.rS = new Button();
			this.sl = new Button();
			this.rC = new Button();
			this.rz = new NumericUpDown();
			this.tA = new Button();
			this.tB = new Label();
			this.tC = new Label();
			this.un = new Label();
			this.up = new Label();
			this.tf = new ni();
			this.tg = new TabPage();
			this.qX = new GroupBox();
			this.rg = new CheckBox();
			this.re = new CheckedListBox();
			this.th = new TabPage();
			this.rM = new GroupBox();
			this.tx = new CheckBox();
			this.rO = new MaskedTextBox();
			this.rR = new MaskedTextBox();
			this.rU = new CheckBox();
			this.rP = new Label();
			this.rL = new NumericUpDown();
			this.rQ = new CheckBox();
			this.rN = new Label();
			this.rJ = new CheckBox();
			this.rK = new GroupBox();
			this.ts = new CheckBox();
			this.tt = new CheckBox();
			this.tu = new CheckBox();
			this.tp = new MaskedTextBox();
			this.tq = new MaskedTextBox();
			this.tr = new MaskedTextBox();
			this.rG = new MaskedTextBox();
			this.tv = new CheckBox();
			this.rH = new GroupBox();
			this.rI = new CheckedListBox();
			this.rT = new CheckBox();
			this.ti = new TabPage();
			this.sr = new Label();
			this.sa = new GroupBox();
			this.sb = new ListBox();
			this.ss = new NumericUpDown();
			this.se = new GroupBox();
			this.sm = new Label();
			this.sn = new Label();
			this.so = new NumericUpDown();
			this.sg = new TextBox();
			this.sf = new ComboBox();
			this.sp = new Label();
			this.sd = new GroupBox();
			this.sU = new CheckBox();
			this.sS = new Label();
			this.sj = new Label();
			this.sT = new ComboBox();
			this.sk = new Button();
			this.sh = new CheckBox();
			this.si = new CheckedListBox();
			this.sq = new NumericUpDown();
			this.sc = new Button();
			this.uc = new TabPage();
			this.uj = new Label();
			this.uk = new Label();
			this.ui = new DataGridView();
			this.ul = new DataGridViewTextBoxColumn();
			this.um = new DataGridViewTextBoxColumn();
			this.ug = new Label();
			this.uh = new Label();
			this.ud = new Button();
			this.ue = new TextBox();
			this.uf = new Button();
			this.tj = new TabPage();
			this.sV = new TabControl();
			this.sX = new TabPage();
			this.te = new Button();
			this.sY = new Button();
			this.sZ = new Button();
			this.ta = new Button();
			this.tb = new GroupBox();
			this.tc = new TextBox();
			this.sW = new TabPage();
			this.rv = new Button();
			this.rn = new Button();
			this.ro = new Button();
			this.rr = new Button();
			this.rp = new Button();
			this.rq = new Button();
			this.rs = new PictureBox();
			this.rt = new PictureBox();
			this.ru = new PictureBox();
			this.tk = new TabPage();
			this.rX = new GroupBox();
			this.rY = new MaskedTextBox();
			this.rW = new Button();
			this.rV = new ListView();
			this.tl = new TabPage();
			this.tI = new TabControl();
			this.tJ = new TabPage();
			this.uu = new Panel();
			this.uA = new Label();
			this.uy = new Label();
			this.uz = new ComboBox();
			this.uw = new Label();
			this.uv = new Label();
			this.sR = new CheckBox();
			this.tT = new CheckBox();
			this.tV = new CheckBox();
			this.tW = new Label();
			this.tX = new NumericUpDown();
			this.ur = new CheckedListBox();
			this.uq = new ComboBox();
			this.ut = new Panel();
			this.ux = new Label();
			this.rA = new Button();
			this.rE = new Button();
			this.rB = new CheckedListBox();
			this.rD = new CheckBox();
			this.tK = new TabPage();
			this.tP = new GroupBox();
			this.tU = new BunifuFlatButton();
			this.tS = new CheckedListBox();
			this.tQ = new BunifuFlatButton();
			this.tL = new GroupBox();
			this.tR = new jy();
			this.oO = new BunifuFlatButton();
			this.tN = new jy();
			this.tO = new kr();
			this.tM = new BunifuTileButton();
			this.tm = new TabPage();
			this.sQ = new Button();
			this.sw = new ListBox();
			this.sN = new ComboBox();
			this.sv = new Button();
			this.sM = new Button();
			this.sK = new Button();
			this.sL = new Button();
			this.tn = new TabPage();
			this.sJ = new Button();
			this.sy = new Label();
			this.sE = new Button();
			this.sF = new Button();
			this.sG = new Button();
			this.sD = new Button();
			this.sA = new Button();
			this.sC = new TrackBar();
			this.sz = new MaskedTextBox();
			this.sB = new CheckBox();
			this.sI = new PictureBox();
			this.sH = new PictureBox();
			this.sx = new PictureBox();
			this.to = new TabPage();
			this.us = new Panel();
			this.tZ = new CheckBox();
			this.ua = new BunifuThinButton2();
			this.ub = new BunifuThinButton2();
			this.uo = new BunifuThinButton2();
			this.tY = new BunifuThinButton2();
			this.tD = new Label();
			this.st = new PictureBox();
			this.rZ = new PictureBox();
			this.rx = new PictureBox();
			this.ry = new Label();
			this.rw = new PictureBox();
			((ISupportInitialize)this.su).BeginInit();
			((ISupportInitialize)this.td).BeginInit();
			this.qO.SuspendLayout();
			((ISupportInitialize)this.tH).BeginInit();
			this.qP.SuspendLayout();
			((ISupportInitialize)this.rh).BeginInit();
			((ISupportInitialize)this.ri).BeginInit();
			((ISupportInitialize)this.ra).BeginInit();
			((ISupportInitialize)this.rb).BeginInit();
			((ISupportInitialize)this.rz).BeginInit();
			this.tf.SuspendLayout();
			this.tg.SuspendLayout();
			this.qX.SuspendLayout();
			this.th.SuspendLayout();
			this.rM.SuspendLayout();
			((ISupportInitialize)this.rL).BeginInit();
			this.rK.SuspendLayout();
			this.rH.SuspendLayout();
			this.ti.SuspendLayout();
			this.sa.SuspendLayout();
			((ISupportInitialize)this.ss).BeginInit();
			this.se.SuspendLayout();
			((ISupportInitialize)this.so).BeginInit();
			this.sd.SuspendLayout();
			((ISupportInitialize)this.sq).BeginInit();
			this.uc.SuspendLayout();
			((ISupportInitialize)this.ui).BeginInit();
			this.tj.SuspendLayout();
			this.sV.SuspendLayout();
			this.sX.SuspendLayout();
			this.tb.SuspendLayout();
			this.sW.SuspendLayout();
			((ISupportInitialize)this.rs).BeginInit();
			((ISupportInitialize)this.rt).BeginInit();
			((ISupportInitialize)this.ru).BeginInit();
			this.tk.SuspendLayout();
			this.rX.SuspendLayout();
			this.tl.SuspendLayout();
			this.tI.SuspendLayout();
			this.tJ.SuspendLayout();
			this.uu.SuspendLayout();
			((ISupportInitialize)this.tX).BeginInit();
			this.ut.SuspendLayout();
			this.tK.SuspendLayout();
			this.tP.SuspendLayout();
			this.tL.SuspendLayout();
			this.tm.SuspendLayout();
			this.tn.SuspendLayout();
			((ISupportInitialize)this.sC).BeginInit();
			((ISupportInitialize)this.sI).BeginInit();
			((ISupportInitialize)this.sH).BeginInit();
			((ISupportInitialize)this.sx).BeginInit();
			this.to.SuspendLayout();
			this.us.SuspendLayout();
			((ISupportInitialize)this.st).BeginInit();
			((ISupportInitialize)this.rZ).BeginInit();
			((ISupportInitialize)this.rx).BeginInit();
			((ISupportInitialize)this.rw).BeginInit();
			base.SuspendLayout();
			this.rF.FileName = "openFileDialog1";
			this.su.Anchor = AnchorStyles.Bottom;
			this.su.Cursor = Cursors.Arrow;
			this.su.Image = cF.Ms;
			this.su.Location = new Point(1, 406);
			this.su.Name = "pictureBox5";
			this.su.Size = new Size(585, 31);
			this.su.SizeMode = PictureBoxSizeMode.Zoom;
			this.su.TabIndex = 1;
			this.su.TabStop = false;
			this.su.Click += this.Dz;
			this.sO.DoWork += this.De;
			this.sP.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.sP.AutoSize = true;
			this.sP.BackColor = Color.Transparent;
			this.sP.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			this.sP.ForeColor = Color.Lime;
			this.sP.Location = new Point(12, 409);
			this.sP.Name = "label17";
			this.sP.Size = new Size(121, 23);
			this.sP.TabIndex = 2;
			this.sP.Text = "By RealGoblins";
			this.sP.Click += this.Dk;
			this.td.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.td.BackColor = Color.White;
			this.td.BorderStyle = BorderStyle.Fixed3D;
			this.td.Location = new Point(15, 406);
			this.td.Margin = new Padding(0);
			this.td.Name = "pictureBox9";
			this.td.Size = new Size(692, 1);
			this.td.TabIndex = 7;
			this.td.TabStop = false;
			this.qO.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.qO.BackColor = Color.Black;
			this.qO.Controls.Add(this.tE);
			this.qO.Controls.Add(this.tF);
			this.qO.Controls.Add(this.tG);
			this.qO.Controls.Add(this.qY);
			this.qO.Controls.Add(this.rf);
			this.qO.Controls.Add(this.qZ);
			this.qO.Controls.Add(this.tH);
			this.qO.ForeColor = Color.White;
			this.qO.Location = new Point(211, 7);
			this.qO.Name = "Macros_box";
			this.qO.Size = new Size(160, 387);
			this.qO.TabIndex = 9;
			this.qO.TabStop = false;
			this.qO.Text = "Macros";
			this.tz.SetToolTip(this.qO, "A list of macros. Select a macro to view its properties and attach it to a window or two");
			this.tE.AutoSize = true;
			this.tE.Location = new Point(8, 309);
			this.tE.Name = "label24";
			this.tE.Size = new Size(54, 18);
			this.tE.TabIndex = 6;
			this.tE.Text = "Speed:";
			this.tF.AutoSize = true;
			this.tF.Location = new Point(115, 360);
			this.tF.Name = "label23";
			this.tF.Size = new Size(41, 18);
			this.tF.TabIndex = 5;
			this.tF.Text = "Slow";
			this.tG.AutoSize = true;
			this.tG.Location = new Point(4, 360);
			this.tG.Name = "label22";
			this.tG.Size = new Size(37, 18);
			this.tG.TabIndex = 4;
			this.tG.Text = "Fast";
			this.qY.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.qY.BackColor = Color.FromArgb(36, 36, 36);
			this.qY.ForeColor = Color.White;
			this.qY.FormattingEnabled = true;
			this.qY.Location = new Point(9, 53);
			this.qY.Name = "Macros";
			this.qY.Size = new Size(142, 194);
			this.qY.Sorted = true;
			this.qY.TabIndex = 0;
			this.tz.SetToolTip(this.qY, "Select a macro to view its properties and attach it to a window or two");
			this.qY.SelectedIndexChanged += this.xa;
			this.rf.AutoSize = true;
			this.rf.Location = new Point(10, 24);
			this.rf.Name = "checkBox1";
			this.rf.Size = new Size(90, 22);
			this.rf.TabIndex = 2;
			this.rf.Text = "Enable all";
			this.rf.UseVisualStyleBackColor = true;
			this.rf.CheckedChanged += this.xq;
			this.qZ.Anchor = AnchorStyles.Bottom;
			this.qZ.AutoSize = true;
			this.qZ.BackColor = Color.FromArgb(36, 36, 36);
			this.qZ.FlatStyle = FlatStyle.Flat;
			this.qZ.ForeColor = Color.White;
			this.qZ.Location = new Point(36, 253);
			this.qZ.Name = "button3";
			this.qZ.Size = new Size(91, 35);
			this.qZ.TabIndex = 1;
			this.qZ.Text = "Remove";
			this.tz.SetToolTip(this.qZ, "Remove the selected macro from the list");
			this.qZ.UseVisualStyleBackColor = false;
			this.qZ.Click += this.yh;
			this.tH.AutoSize = false;
			this.tH.LargeChange = 20;
			this.tH.Location = new Point(10, 329);
			this.tH.Maximum = 400;
			this.tH.Minimum = 20;
			this.tH.Name = "trackBar2";
			this.tH.Size = new Size(142, 34);
			this.tH.SmallChange = 20;
			this.tH.TabIndex = 20;
			this.tH.TickFrequency = 20;
			this.tH.Value = 100;
			this.tH.Scroll += this.EX;
			this.rc.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.rc.BackColor = Color.FromArgb(36, 36, 36);
			this.rc.FlatStyle = FlatStyle.Flat;
			this.rc.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.rc.ForeColor = Color.White;
			this.rc.Location = new Point(4, 346);
			this.rc.Margin = new Padding(1, 3, 1, 3);
			this.rc.Name = "button5";
			this.rc.Size = new Size(82, 35);
			this.rc.TabIndex = 3;
			this.rc.Text = "Refresh";
			this.tz.SetToolTip(this.rc, "Refresh the list of open windows");
			this.rc.UseVisualStyleBackColor = false;
			this.rc.Click += this.xX;
			this.rd.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.rd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.rd.BackColor = Color.FromArgb(36, 36, 36);
			this.rd.FlatStyle = FlatStyle.Flat;
			this.rd.Font = new Font("Microsoft Sans Serif", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.rd.ForeColor = Color.White;
			this.rd.Location = new Point(91, 346);
			this.rd.Margin = new Padding(1, 3, 1, 3);
			this.rd.Name = "button4";
			this.rd.Size = new Size(103, 35);
			this.rd.TabIndex = 2;
			this.rd.Text = "Bring to front";
			this.tz.SetToolTip(this.rd, "Bring the selected window to front");
			this.rd.UseVisualStyleBackColor = false;
			this.rd.Click += this.ya;
			this.qP.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.qP.BackColor = Color.Black;
			this.qP.Controls.Add(this.ty);
			this.qP.Controls.Add(this.rh);
			this.qP.Controls.Add(this.ri);
			this.qP.Controls.Add(this.rj);
			this.qP.Controls.Add(this.rk);
			this.qP.Controls.Add(this.rl);
			this.qP.Controls.Add(this.rm);
			this.qP.Controls.Add(this.ra);
			this.qP.Controls.Add(this.rb);
			this.qP.Controls.Add(this.qQ);
			this.qP.Controls.Add(this.qR);
			this.qP.Controls.Add(this.qS);
			this.qP.Controls.Add(this.qT);
			this.qP.Controls.Add(this.qU);
			this.qP.Controls.Add(this.qV);
			this.qP.Controls.Add(this.qW);
			this.qP.ForeColor = Color.White;
			this.qP.Location = new Point(0, 7);
			this.qP.Name = "groupBox1";
			this.qP.Size = new Size(205, 387);
			this.qP.TabIndex = 0;
			this.qP.TabStop = false;
			this.qP.Text = "Add";
			this.tz.SetToolTip(this.qP, "Add a macro to the macro list");
			this.ty.BackColor = Color.Transparent;
			this.ty.FlatAppearance.BorderSize = 0;
			this.ty.FlatStyle = FlatStyle.Flat;
			this.ty.ForeColor = Color.Transparent;
			this.ty.Image = cF.Mi;
			this.ty.Location = new Point(167, 23);
			this.ty.Name = "button30";
			this.ty.Size = new Size(34, 30);
			this.ty.TabIndex = 17;
			this.tz.SetToolTip(this.ty, "Help");
			this.ty.UseVisualStyleBackColor = false;
			this.ty.Click += this.Ek;
			this.ty.MouseLeave += this.Ew;
			this.ty.MouseHover += this.Et;
			this.rh.BackColor = Color.FromArgb(36, 36, 36);
			this.rh.ForeColor = Color.White;
			this.rh.Location = new Point(45, 248);
			NumericUpDown numericUpDown = this.rh;
			int[] array = new int[4];
			array[0] = -727379968;
			array[1] = 232;
			numericUpDown.Maximum = new decimal(array);
			this.rh.Minimum = new decimal(new int[]
			{
				1215752192,
				23,
				0,
				int.MinValue
			});
			this.rh.Name = "numericUpDown3";
			this.rh.Size = new Size(85, 24);
			this.rh.TabIndex = 16;
			this.rh.ThousandsSeparator = true;
			this.ri.BackColor = Color.FromArgb(36, 36, 36);
			this.ri.ForeColor = Color.White;
			this.ri.Location = new Point(45, 204);
			NumericUpDown numericUpDown2 = this.ri;
			int[] array2 = new int[4];
			array2[0] = 1215752192;
			array2[1] = 23;
			numericUpDown2.Maximum = new decimal(array2);
			this.ri.Minimum = new decimal(new int[]
			{
				-727379968,
				232,
				0,
				int.MinValue
			});
			this.ri.Name = "numericUpDown4";
			this.ri.Size = new Size(85, 24);
			this.ri.TabIndex = 15;
			this.rj.AutoSize = true;
			this.rj.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.rj.BackColor = Color.FromArgb(36, 36, 36);
			this.rj.FlatStyle = FlatStyle.Flat;
			this.rj.ForeColor = Color.White;
			this.rj.Location = new Point(136, 224);
			this.rj.Name = "button6";
			this.rj.Size = new Size(61, 30);
			this.rj.TabIndex = 14;
			this.rj.Text = "Select";
			this.tz.SetToolTip(this.rj, "Select the end position for the macro");
			this.rj.UseVisualStyleBackColor = false;
			this.rj.Click += this.xt;
			this.rk.AutoSize = true;
			this.rk.Location = new Point(11, 250);
			this.rk.Name = "label5";
			this.rk.Size = new Size(17, 18);
			this.rk.TabIndex = 13;
			this.rk.Text = "Y";
			this.rl.AutoSize = true;
			this.rl.Location = new Point(11, 206);
			this.rl.Name = "label6";
			this.rl.Size = new Size(18, 18);
			this.rl.TabIndex = 12;
			this.rl.Text = "X";
			this.rm.AutoSize = true;
			this.rm.Location = new Point(6, 176);
			this.rm.Name = "label7";
			this.rm.Size = new Size(67, 18);
			this.rm.TabIndex = 11;
			this.rm.Text = "End pos:";
			this.ra.BackColor = Color.FromArgb(36, 36, 36);
			this.ra.ForeColor = Color.White;
			this.ra.Location = new Point(46, 135);
			NumericUpDown numericUpDown3 = this.ra;
			int[] array3 = new int[4];
			array3[0] = -727379968;
			array3[1] = 232;
			numericUpDown3.Maximum = new decimal(array3);
			this.ra.Minimum = new decimal(new int[]
			{
				1215752192,
				23,
				0,
				int.MinValue
			});
			this.ra.Name = "numericUpDown2";
			this.ra.Size = new Size(84, 24);
			this.ra.TabIndex = 10;
			this.ra.ThousandsSeparator = true;
			this.rb.BackColor = Color.FromArgb(36, 36, 36);
			this.rb.ForeColor = Color.White;
			this.rb.Location = new Point(46, 91);
			NumericUpDown numericUpDown4 = this.rb;
			int[] array4 = new int[4];
			array4[0] = 1215752192;
			array4[1] = 23;
			numericUpDown4.Maximum = new decimal(array4);
			this.rb.Minimum = new decimal(new int[]
			{
				-727379968,
				232,
				0,
				int.MinValue
			});
			this.rb.Name = "numericUpDown1";
			this.rb.Size = new Size(84, 24);
			this.rb.TabIndex = 9;
			this.rb.ValueChanged += this.xe;
			this.qQ.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.qQ.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.qQ.BackColor = Color.FromArgb(36, 36, 36);
			this.qQ.FlatAppearance.BorderColor = Color.White;
			this.qQ.FlatStyle = FlatStyle.Flat;
			this.qQ.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.qQ.ForeColor = Color.White;
			this.qQ.Location = new Point(46, 308);
			this.qQ.Name = "button2";
			this.qQ.Size = new Size(100, 35);
			this.qQ.TabIndex = 8;
			this.qQ.Text = "Add";
			this.tz.SetToolTip(this.qQ, "Add a macro with the properties above");
			this.qQ.UseVisualStyleBackColor = false;
			this.qQ.Click += this.xn;
			this.qR.AutoSize = true;
			this.qR.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.qR.BackColor = Color.FromArgb(36, 36, 36);
			this.qR.FlatStyle = FlatStyle.Flat;
			this.qR.ForeColor = Color.White;
			this.qR.Location = new Point(136, 114);
			this.qR.Name = "button1";
			this.qR.Size = new Size(61, 30);
			this.qR.TabIndex = 7;
			this.qR.Text = "Select";
			this.tz.SetToolTip(this.qR, "Select the start position for the macro");
			this.qR.UseVisualStyleBackColor = false;
			this.qR.Click += this.xk;
			this.qS.AutoSize = true;
			this.qS.Location = new Point(11, 141);
			this.qS.Name = "label4";
			this.qS.Size = new Size(17, 18);
			this.qS.TabIndex = 4;
			this.qS.Text = "Y";
			this.qT.AutoSize = true;
			this.qT.Location = new Point(11, 97);
			this.qT.Name = "label3";
			this.qT.Size = new Size(18, 18);
			this.qT.TabIndex = 3;
			this.qT.Text = "X";
			this.qU.AutoSize = true;
			this.qU.Location = new Point(7, 63);
			this.qU.Name = "label2";
			this.qU.Size = new Size(72, 18);
			this.qU.TabIndex = 2;
			this.qU.Text = "Start pos:";
			this.qV.BackColor = Color.FromArgb(36, 36, 36);
			this.qV.ForeColor = Color.White;
			this.qV.Location = new Point(65, 28);
			this.qV.Name = "maskedTextBox1";
			this.qV.Size = new Size(100, 24);
			this.qV.TabIndex = 1;
			this.tz.SetToolTip(this.qV, "The name of the macro, can be anything");
			this.qW.AutoSize = true;
			this.qW.Location = new Point(7, 28);
			this.qW.Name = "label1";
			this.qW.Size = new Size(52, 18);
			this.qW.TabIndex = 0;
			this.qW.Text = "Name:";
			this.tw.AutoSize = true;
			this.tw.Location = new Point(13, 138);
			this.tw.Name = "checkBox7";
			this.tw.Size = new Size(190, 22);
			this.tw.TabIndex = 13;
			this.tw.Text = "Stack the text (Premium)";
			this.tz.SetToolTip(this.tw, "[Premium only]");
			this.tw.UseVisualStyleBackColor = true;
			this.tw.CheckedChanged += this.ER;
			this.rS.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.rS.BackColor = Color.FromArgb(36, 36, 36);
			this.rS.FlatStyle = FlatStyle.Flat;
			this.rS.ForeColor = Color.White;
			this.rS.Location = new Point(176, 166);
			this.rS.Name = "RefreshSpam";
			this.rS.Size = new Size(100, 31);
			this.rS.TabIndex = 7;
			this.rS.Text = "Refresh";
			this.tz.SetToolTip(this.rS, "Refresh the list of open windows");
			this.rS.UseVisualStyleBackColor = false;
			this.rS.Click += this.AJ;
			this.sl.BackColor = Color.FromArgb(36, 36, 36);
			this.sl.FlatStyle = FlatStyle.Flat;
			this.sl.ForeColor = Color.White;
			this.sl.Location = new Point(6, 330);
			this.sl.Name = "button14";
			this.sl.Size = new Size(150, 37);
			this.sl.TabIndex = 2;
			this.sl.Text = "Refresh";
			this.tz.SetToolTip(this.sl, "Refresh the list of open windows");
			this.sl.UseVisualStyleBackColor = false;
			this.sl.Click += this.BJ;
			this.rC.BackColor = Color.FromArgb(36, 36, 36);
			this.rC.FlatStyle = FlatStyle.Flat;
			this.rC.ForeColor = Color.White;
			this.rC.Location = new Point(21, 268);
			this.rC.Name = "Refresh";
			this.rC.Size = new Size(90, 35);
			this.rC.TabIndex = 3;
			this.rC.Text = "Refresh";
			this.tz.SetToolTip(this.rC, "Refresh the list of open windows");
			this.rC.UseVisualStyleBackColor = false;
			this.rC.Click += this.Ap;
			this.rz.BackColor = Color.FromArgb(36, 36, 36);
			this.rz.ForeColor = Color.FromArgb(192, 255, 255);
			this.rz.Location = new Point(150, 25);
			NumericUpDown numericUpDown5 = this.rz;
			int[] array5 = new int[4];
			array5[0] = 1874919423;
			array5[1] = 2328306;
			numericUpDown5.Maximum = new decimal(array5);
			NumericUpDown numericUpDown6 = this.rz;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Minimum = new decimal(array6);
			this.rz.Name = "no_GT_windows";
			this.rz.Size = new Size(72, 24);
			this.rz.TabIndex = 1;
			this.tz.SetToolTip(this.rz, "Number of windows to open");
			NumericUpDown numericUpDown7 = this.rz;
			int[] array7 = new int[4];
			array7[0] = 1;
			numericUpDown7.Value = new decimal(array7);
			this.rz.ValueChanged += this.FI;
			this.tA.BackColor = Color.Transparent;
			this.tA.FlatAppearance.BorderSize = 0;
			this.tA.FlatStyle = FlatStyle.Flat;
			this.tA.ForeColor = Color.Transparent;
			this.tA.Image = cF.Mi;
			this.tA.Location = new Point(546, 7);
			this.tA.Name = "button31";
			this.tA.Size = new Size(34, 30);
			this.tA.TabIndex = 18;
			this.tz.SetToolTip(this.tA, "Help");
			this.tA.UseVisualStyleBackColor = false;
			this.tA.Click += this.Ez;
			this.tB.AutoSize = true;
			this.tB.Location = new Point(451, 424);
			this.tB.Name = "label19";
			this.tB.Size = new Size(41, 13);
			this.tB.TabIndex = 12;
			this.tB.Text = "label19";
			this.tC.AutoSize = true;
			this.tC.Location = new Point(451, 409);
			this.tC.Name = "label20";
			this.tC.Size = new Size(41, 13);
			this.tC.TabIndex = 13;
			this.tC.Text = "label20";
			this.tC.Click += this.Fa;
			this.un.AutoSize = true;
			this.un.Location = new Point(594, 423);
			this.un.Name = "label28";
			this.un.Size = new Size(110, 13);
			this.un.TabIndex = 14;
			this.un.Text = "Server might be down";
			this.up.AutoSize = true;
			this.up.Location = new Point(594, 409);
			this.up.Name = "label31";
			this.up.Size = new Size(78, 13);
			this.up.TabIndex = 15;
			this.up.Text = "Not connected";
			this.tf.Alignment = TabAlignment.Left;
			this.tf.Controls.Add(this.tg);
			this.tf.Controls.Add(this.th);
			this.tf.Controls.Add(this.ti);
			this.tf.Controls.Add(this.uc);
			this.tf.Controls.Add(this.tj);
			this.tf.Controls.Add(this.tk);
			this.tf.Controls.Add(this.tl);
			this.tf.Controls.Add(this.tm);
			this.tf.Controls.Add(this.tn);
			this.tf.Controls.Add(this.to);
			this.tf.DrawMode = TabDrawMode.OwnerDrawFixed;
			this.tf.Font = new Font("Microsoft Sans Serif", 11.25f);
			this.tf.ItemSize = new Size(39, 135);
			this.tf.Location = new Point(1, 1);
			this.tf.Multiline = true;
			this.tf.Name = "iTalk_TabControl1";
			this.tf.SelectedIndex = 0;
			this.tf.Size = new Size(768, 402);
			this.tf.SizeMode = TabSizeMode.Fixed;
			this.tf.TabIndex = 11;
			this.tg.BackColor = Color.FromArgb(0, 0, 0);
			this.tg.Controls.Add(this.qO);
			this.tg.Controls.Add(this.qX);
			this.tg.Controls.Add(this.qP);
			this.tg.Location = new Point(139, 4);
			this.tg.Name = "tabPage3";
			this.tg.Padding = new Padding(3);
			this.tg.Size = new Size(625, 394);
			this.tg.TabIndex = 0;
			this.tg.Text = "Mouse";
			this.qX.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.qX.BackColor = Color.Black;
			this.qX.Controls.Add(this.rg);
			this.qX.Controls.Add(this.rc);
			this.qX.Controls.Add(this.rd);
			this.qX.Controls.Add(this.re);
			this.qX.ForeColor = Color.White;
			this.qX.Location = new Point(377, 7);
			this.qX.Name = "Windows_box";
			this.qX.Size = new Size(198, 387);
			this.qX.TabIndex = 10;
			this.qX.TabStop = false;
			this.qX.Text = "Windows";
			this.qX.Enter += this.EC;
			this.rg.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.rg.AutoSize = true;
			this.rg.Location = new Point(7, 27);
			this.rg.Name = "checkBox2";
			this.rg.Size = new Size(86, 22);
			this.rg.TabIndex = 3;
			this.rg.Text = "Select all";
			this.rg.UseVisualStyleBackColor = true;
			this.rg.CheckedChanged += this.xh;
			this.re.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.re.BackColor = Color.FromArgb(36, 36, 36);
			this.re.CheckOnClick = true;
			this.re.ForeColor = Color.White;
			this.re.FormattingEnabled = true;
			this.re.Location = new Point(6, 53);
			this.re.Name = "Windows";
			this.re.Size = new Size(184, 251);
			this.re.Sorted = true;
			this.re.TabIndex = 2;
			this.re.SelectedIndexChanged += this.yd;
			this.th.BackColor = Color.FromArgb(0, 0, 0);
			this.th.Controls.Add(this.rM);
			this.th.Controls.Add(this.rJ);
			this.th.Controls.Add(this.rK);
			this.th.Controls.Add(this.rH);
			this.th.Location = new Point(139, 4);
			this.th.Name = "tabPage4";
			this.th.Padding = new Padding(3);
			this.th.Size = new Size(625, 394);
			this.th.TabIndex = 1;
			this.th.Text = "Spammer";
			this.rM.Controls.Add(this.tw);
			this.rM.Controls.Add(this.tx);
			this.rM.Controls.Add(this.rO);
			this.rM.Controls.Add(this.rR);
			this.rM.Controls.Add(this.rU);
			this.rM.Controls.Add(this.rP);
			this.rM.Controls.Add(this.rL);
			this.rM.Controls.Add(this.rQ);
			this.rM.Controls.Add(this.rN);
			this.rM.ForeColor = Color.White;
			this.rM.Location = new Point(4, 182);
			this.rM.Name = "groupBox2";
			this.rM.Size = new Size(272, 209);
			this.rM.TabIndex = 6;
			this.rM.TabStop = false;
			this.rM.Text = "Settings";
			this.tx.AutoSize = true;
			this.tx.Location = new Point(13, 111);
			this.tx.Name = "checkBox6";
			this.tx.Size = new Size(150, 22);
			this.tx.TabIndex = 11;
			this.tx.Text = "NoShift (Premium)";
			this.tx.UseVisualStyleBackColor = true;
			this.tx.CheckedChanged += this.EU;
			this.rO.BackColor = Color.FromArgb(36, 36, 36);
			this.rO.ForeColor = Color.White;
			this.rO.Location = new Point(166, 82);
			this.rO.Name = "MsgSpamTo";
			this.rO.Size = new Size(100, 24);
			this.rO.TabIndex = 11;
			this.rR.BackColor = Color.FromArgb(36, 36, 36);
			this.rR.ForeColor = Color.White;
			this.rR.Location = new Point(61, 49);
			this.rR.Name = "addInFront";
			this.rR.Size = new Size(65, 24);
			this.rR.TabIndex = 8;
			this.rR.Text = "`#";
			this.rU.AutoSize = true;
			this.rU.ForeColor = Color.White;
			this.rU.Location = new Point(13, 51);
			this.rU.Name = "AddInFrontCheckBox";
			this.rU.Size = new Size(173, 22);
			this.rU.TabIndex = 12;
			this.rU.Text = "Add                   in front";
			this.rU.UseVisualStyleBackColor = true;
			this.rP.AutoSize = true;
			this.rP.Location = new Point(128, 85);
			this.rP.Name = "label11";
			this.rP.Size = new Size(30, 18);
			this.rP.TabIndex = 10;
			this.rP.Text = "To:";
			this.rL.BackColor = Color.FromArgb(36, 36, 36);
			this.rL.DecimalPlaces = 1;
			this.rL.ForeColor = Color.White;
			this.rL.Location = new Point(63, 20);
			this.rL.Maximum = new decimal(new int[]
			{
				-1304428543,
				434162106,
				542,
				1245184
			});
			this.rL.Minimum = new decimal(new int[]
			{
				1,
				0,
				0,
				1114112
			});
			this.rL.Name = "SpamDelay";
			this.rL.Size = new Size(65, 24);
			this.rL.TabIndex = 5;
			NumericUpDown numericUpDown8 = this.rL;
			int[] array8 = new int[4];
			array8[0] = 5;
			numericUpDown8.Value = new decimal(array8);
			this.rQ.AutoSize = true;
			this.rQ.Location = new Point(13, 82);
			this.rQ.Name = "MsgSpamCheckBox";
			this.rQ.Size = new Size(97, 22);
			this.rQ.TabIndex = 9;
			this.rQ.Text = "Msg spam";
			this.rQ.UseVisualStyleBackColor = true;
			this.rN.AutoSize = true;
			this.rN.Location = new Point(11, 23);
			this.rN.Name = "label9";
			this.rN.Size = new Size(157, 18);
			this.rN.TabIndex = 6;
			this.rN.Text = "Delay                      sec";
			this.rN.Click += this.AG;
			this.rJ.AutoSize = true;
			this.rJ.Location = new Point(4, 4);
			this.rJ.Name = "EnableSpammer";
			this.rJ.Size = new Size(72, 22);
			this.rJ.TabIndex = 1;
			this.rJ.Text = "Enable";
			this.rJ.UseVisualStyleBackColor = true;
			this.rJ.CheckedChanged += this.AP;
			this.rK.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.rK.Controls.Add(this.ts);
			this.rK.Controls.Add(this.tt);
			this.rK.Controls.Add(this.tu);
			this.rK.Controls.Add(this.tp);
			this.rK.Controls.Add(this.tq);
			this.rK.Controls.Add(this.tr);
			this.rK.Controls.Add(this.rG);
			this.rK.Controls.Add(this.tv);
			this.rK.ForeColor = Color.White;
			this.rK.Location = new Point(4, 24);
			this.rK.Name = "spammertextgroup";
			this.rK.Size = new Size(569, 152);
			this.rK.TabIndex = 4;
			this.rK.TabStop = false;
			this.rK.Text = "Spammer Text";
			this.ts.AutoSize = true;
			this.ts.BackColor = Color.Transparent;
			this.ts.Location = new Point(15, 122);
			this.ts.Name = "SpamTxt4";
			this.ts.Size = new Size(15, 14);
			this.ts.TabIndex = 10;
			this.ts.UseVisualStyleBackColor = false;
			this.ts.CheckedChanged += this.Ee;
			this.tt.AutoSize = true;
			this.tt.BackColor = Color.Transparent;
			this.tt.Location = new Point(15, 92);
			this.tt.Name = "SpamTxt3";
			this.tt.Size = new Size(15, 14);
			this.tt.TabIndex = 9;
			this.tt.UseVisualStyleBackColor = false;
			this.tt.CheckedChanged += this.Eb;
			this.tu.AutoSize = true;
			this.tu.BackColor = Color.Transparent;
			this.tu.Location = new Point(15, 62);
			this.tu.Name = "SpamTxt2";
			this.tu.Size = new Size(15, 14);
			this.tu.TabIndex = 8;
			this.tu.UseVisualStyleBackColor = false;
			this.tu.CheckedChanged += this.DY;
			this.tp.AllowDrop = true;
			this.tp.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.tp.BackColor = Color.FromArgb(36, 36, 36);
			this.tp.ForeColor = Color.White;
			this.tp.Location = new Point(36, 116);
			this.tp.Name = "SpammerText4";
			this.tp.Size = new Size(527, 24);
			this.tp.TabIndex = 6;
			this.tp.Text = "Text #4 (Premium)";
			this.tq.AllowDrop = true;
			this.tq.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.tq.BackColor = Color.FromArgb(36, 36, 36);
			this.tq.ForeColor = Color.White;
			this.tq.Location = new Point(36, 86);
			this.tq.Name = "SpammerText3";
			this.tq.Size = new Size(527, 24);
			this.tq.TabIndex = 5;
			this.tq.Text = "Text #3 (Premium)";
			this.tr.AllowDrop = true;
			this.tr.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.tr.BackColor = Color.FromArgb(36, 36, 36);
			this.tr.ForeColor = Color.White;
			this.tr.Location = new Point(36, 56);
			this.tr.Name = "SpammerText2";
			this.tr.Size = new Size(527, 24);
			this.tr.TabIndex = 4;
			this.tr.Text = "Text #2";
			this.rG.AllowDrop = true;
			this.rG.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.rG.BackColor = Color.FromArgb(36, 36, 36);
			this.rG.ForeColor = Color.White;
			this.rG.Location = new Point(36, 26);
			this.rG.Name = "SpammerText1";
			this.rG.Size = new Size(527, 24);
			this.rG.TabIndex = 3;
			this.rG.Text = "Text #1";
			this.rG.MaskInputRejected += this.AD;
			this.tv.AutoSize = true;
			this.tv.BackColor = Color.Transparent;
			this.tv.Checked = true;
			this.tv.CheckState = CheckState.Checked;
			this.tv.Enabled = false;
			this.tv.Location = new Point(15, 32);
			this.tv.Name = "SpamTxt1";
			this.tv.Size = new Size(15, 14);
			this.tv.TabIndex = 7;
			this.tv.UseVisualStyleBackColor = false;
			this.tv.CheckedChanged += this.DV;
			this.rH.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.rH.Controls.Add(this.rI);
			this.rH.Controls.Add(this.rS);
			this.rH.Controls.Add(this.rT);
			this.rH.ForeColor = Color.White;
			this.rH.Location = new Point(291, 182);
			this.rH.Name = "Attach";
			this.rH.Size = new Size(282, 207);
			this.rH.TabIndex = 2;
			this.rH.TabStop = false;
			this.rH.Text = "Attach";
			this.rI.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.rI.BackColor = Color.FromArgb(36, 36, 36);
			this.rI.CheckOnClick = true;
			this.rI.ForeColor = Color.White;
			this.rI.FormattingEnabled = true;
			this.rI.Location = new Point(6, 42);
			this.rI.Name = "ProcessesSpam";
			this.rI.Size = new Size(164, 156);
			this.rI.TabIndex = 0;
			this.rI.SelectedIndexChanged += this.Be;
			this.rT.AutoSize = true;
			this.rT.BackColor = Color.Transparent;
			this.rT.Location = new Point(8, 19);
			this.rT.Name = "SelectAllSpam";
			this.rT.Size = new Size(86, 22);
			this.rT.TabIndex = 8;
			this.rT.Text = "Select all";
			this.rT.UseVisualStyleBackColor = false;
			this.rT.CheckedChanged += this.AM;
			this.ti.BackColor = Color.FromArgb(0, 0, 0);
			this.ti.Controls.Add(this.sr);
			this.ti.Controls.Add(this.sa);
			this.ti.Controls.Add(this.ss);
			this.ti.Controls.Add(this.se);
			this.ti.Controls.Add(this.sp);
			this.ti.Controls.Add(this.sd);
			this.ti.Controls.Add(this.sq);
			this.ti.Controls.Add(this.sc);
			this.ti.Location = new Point(139, 4);
			this.ti.Name = "tabPage5";
			this.ti.Size = new Size(625, 394);
			this.ti.TabIndex = 2;
			this.ti.Text = "Commands";
			this.sr.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.sr.AutoSize = true;
			this.sr.Location = new Point(485, 337);
			this.sr.Name = "label15";
			this.sr.Size = new Size(84, 18);
			this.sr.TabIndex = 8;
			this.sr.Text = "Delay (ms):";
			this.sa.Controls.Add(this.sl);
			this.sa.Controls.Add(this.sb);
			this.sa.ForeColor = Color.White;
			this.sa.Location = new Point(3, 7);
			this.sa.Name = "groupBox3";
			this.sa.Size = new Size(163, 383);
			this.sa.TabIndex = 1;
			this.sa.TabStop = false;
			this.sa.Text = "Attach to:";
			this.sb.BackColor = Color.FromArgb(36, 36, 36);
			this.sb.ForeColor = Color.White;
			this.sb.FormattingEnabled = true;
			this.sb.ItemHeight = 18;
			this.sb.Location = new Point(6, 36);
			this.sb.Name = "listBox1";
			this.sb.Size = new Size(150, 274);
			this.sb.Sorted = true;
			this.sb.TabIndex = 2;
			this.sb.SelectedIndexChanged += this.BD;
			this.ss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.ss.BackColor = Color.FromArgb(36, 36, 36);
			this.ss.ForeColor = Color.White;
			this.ss.Location = new Point(486, 358);
			this.ss.Maximum = new decimal(new int[]
			{
				1241513983,
				370409800,
				542101,
				0
			});
			this.ss.Name = "numericUpDown7";
			this.ss.Size = new Size(87, 24);
			this.ss.TabIndex = 7;
			this.se.Controls.Add(this.sm);
			this.se.Controls.Add(this.sn);
			this.se.Controls.Add(this.so);
			this.se.Controls.Add(this.sg);
			this.se.Controls.Add(this.sf);
			this.se.ForeColor = Color.White;
			this.se.Location = new Point(171, 7);
			this.se.Name = "groupBox4";
			this.se.Size = new Size(145, 383);
			this.se.TabIndex = 2;
			this.se.TabStop = false;
			this.se.Text = "Command";
			this.sm.AutoSize = true;
			this.sm.Location = new Point(7, 258);
			this.sm.Name = "label13";
			this.sm.Size = new Size(84, 18);
			this.sm.TabIndex = 4;
			this.sm.Text = "Delay (ms):";
			this.sn.AllowDrop = true;
			this.sn.Location = new Point(7, 326);
			this.sn.Name = "label12";
			this.sn.Size = new Size(133, 37);
			this.sn.TabIndex = 3;
			this.sn.Text = "Press F5 to cancel the operation";
			this.so.BackColor = Color.FromArgb(36, 36, 36);
			this.so.ForeColor = Color.White;
			this.so.Location = new Point(10, 284);
			NumericUpDown numericUpDown9 = this.so;
			int[] array9 = new int[4];
			array9[0] = 100000;
			numericUpDown9.Maximum = new decimal(array9);
			this.so.Name = "numericUpDown5";
			this.so.Size = new Size(120, 24);
			this.so.TabIndex = 2;
			NumericUpDown numericUpDown10 = this.so;
			int[] array10 = new int[4];
			array10[0] = 2000;
			numericUpDown10.Value = new decimal(array10);
			this.sg.BackColor = Color.FromArgb(36, 36, 36);
			this.sg.ForeColor = Color.White;
			this.sg.Location = new Point(6, 75);
			this.sg.Multiline = true;
			this.sg.Name = "textBox1";
			this.sg.Size = new Size(134, 167);
			this.sg.TabIndex = 1;
			this.sg.Text = "message";
			this.sg.TextChanged += this.Dw;
			this.sf.BackColor = Color.FromArgb(36, 36, 36);
			this.sf.DropDownStyle = ComboBoxStyle.DropDownList;
			this.sf.ForeColor = Color.White;
			this.sf.FormattingEnabled = true;
			this.sf.Items.AddRange(new object[]
			{
				"/pull",
				"/kick",
				"/ban",
				"/msg"
			});
			this.sf.Location = new Point(6, 35);
			this.sf.MaxDropDownItems = 100;
			this.sf.Name = "comboBox1";
			this.sf.Size = new Size(133, 26);
			this.sf.TabIndex = 0;
			this.sf.SelectedIndexChanged += this.Bu;
			this.sp.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.sp.AutoSize = true;
			this.sp.Location = new Point(485, 287);
			this.sp.Name = "label14";
			this.sp.Size = new Size(59, 18);
			this.sp.TabIndex = 6;
			this.sp.Text = "Repeat:";
			this.sd.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.sd.Controls.Add(this.sU);
			this.sd.Controls.Add(this.sS);
			this.sd.Controls.Add(this.sj);
			this.sd.Controls.Add(this.sT);
			this.sd.Controls.Add(this.sk);
			this.sd.Controls.Add(this.sh);
			this.sd.Controls.Add(this.si);
			this.sd.ForeColor = Color.White;
			this.sd.Location = new Point(323, 7);
			this.sd.Name = "groupBox5";
			this.sd.Size = new Size(159, 383);
			this.sd.TabIndex = 3;
			this.sd.TabStop = false;
			this.sd.Text = "Apply to (players):";
			this.sU.AllowDrop = true;
			this.sU.Location = new Point(6, 289);
			this.sU.Name = "checkBox5";
			this.sU.Size = new Size(141, 49);
			this.sU.TabIndex = 6;
			this.sU.Text = "Auto refresh player list";
			this.sU.UseVisualStyleBackColor = true;
			this.sU.CheckedChanged += this.DF;
			this.sS.AutoSize = true;
			this.sS.Location = new Point(10, 227);
			this.sS.Name = "label18";
			this.sS.Size = new Size(57, 18);
			this.sS.TabIndex = 5;
			this.sS.Text = "GT ver:";
			this.sj.AutoSize = true;
			this.sj.Location = new Point(4, 344);
			this.sj.Name = "label10";
			this.sj.Size = new Size(64, 18);
			this.sj.TabIndex = 4;
			this.sj.Text = "GT wnd:";
			this.sT.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.sT.BackColor = Color.FromArgb(36, 36, 36);
			this.sT.DropDownStyle = ComboBoxStyle.DropDownList;
			this.sT.ForeColor = Color.White;
			this.sT.FormattingEnabled = true;
			this.sT.Items.AddRange(new object[]
			{
				"Fixed GT",
				"3.000",
				"3.011",
				"3.021"
			});
			this.sT.Location = new Point(70, 222);
			this.sT.Name = "GT_version_cmd";
			this.sT.Size = new Size(80, 26);
			this.sT.TabIndex = 5;
			this.sT.SelectedIndexChanged += this.DS;
			this.sk.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.sk.BackColor = Color.FromArgb(36, 36, 36);
			this.sk.FlatStyle = FlatStyle.Flat;
			this.sk.ForeColor = Color.White;
			this.sk.Location = new Point(12, 255);
			this.sk.Name = "button15";
			this.sk.Size = new Size(136, 31);
			this.sk.TabIndex = 3;
			this.sk.Text = "Refresh player list";
			this.sk.UseVisualStyleBackColor = false;
			this.sk.Click += this.BG;
			this.sh.AutoSize = true;
			this.sh.Location = new Point(8, 19);
			this.sh.Name = "checkBox3";
			this.sh.Size = new Size(86, 22);
			this.sh.TabIndex = 1;
			this.sh.Text = "Select all";
			this.sh.UseVisualStyleBackColor = true;
			this.sh.CheckedChanged += this.BA;
			this.si.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.si.BackColor = Color.FromArgb(36, 36, 36);
			this.si.CheckOnClick = true;
			this.si.ForeColor = Color.White;
			this.si.FormattingEnabled = true;
			this.si.Location = new Point(6, 43);
			this.si.Name = "checkedListBox2";
			this.si.Size = new Size(147, 156);
			this.si.TabIndex = 0;
			this.si.SelectedIndexChanged += this.Fd;
			this.sq.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.sq.BackColor = Color.FromArgb(36, 36, 36);
			this.sq.ForeColor = Color.White;
			this.sq.Location = new Point(486, 308);
			NumericUpDown numericUpDown11 = this.sq;
			int[] array11 = new int[4];
			array11[0] = 1;
			numericUpDown11.Minimum = new decimal(array11);
			this.sq.Name = "numericUpDown6";
			this.sq.Size = new Size(87, 24);
			this.sq.TabIndex = 5;
			NumericUpDown numericUpDown12 = this.sq;
			int[] array12 = new int[4];
			array12[0] = 1;
			numericUpDown12.Value = new decimal(array12);
			this.sc.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.sc.BackColor = Color.FromArgb(36, 36, 36);
			this.sc.FlatStyle = FlatStyle.Flat;
			this.sc.ForeColor = Color.White;
			this.sc.Location = new Point(488, 7);
			this.sc.Name = "Execute";
			this.sc.Size = new Size(92, 276);
			this.sc.TabIndex = 4;
			this.sc.Text = "Execute (Premium)";
			this.sc.UseVisualStyleBackColor = false;
			this.sc.Click += this.BM;
			this.uc.BackColor = Color.FromArgb(0, 0, 0);
			this.uc.Controls.Add(this.uj);
			this.uc.Controls.Add(this.uk);
			this.uc.Controls.Add(this.ui);
			this.uc.Controls.Add(this.ug);
			this.uc.Controls.Add(this.uh);
			this.uc.Controls.Add(this.ud);
			this.uc.Controls.Add(this.ue);
			this.uc.Controls.Add(this.uf);
			this.uc.Location = new Point(139, 4);
			this.uc.Name = "tabPage14";
			this.uc.Padding = new Padding(3);
			this.uc.Size = new Size(625, 394);
			this.uc.TabIndex = 9;
			this.uc.Text = "Decoder";
			this.uj.AutoSize = true;
			this.uj.Location = new Point(127, 62);
			this.uj.Name = "label30";
			this.uj.Size = new Size(63, 18);
			this.uj.TabIndex = 19;
			this.uj.Text = "GrowID:";
			this.uk.AutoSize = true;
			this.uk.Location = new Point(127, 85);
			this.uk.Name = "label29";
			this.uk.Size = new Size(46, 18);
			this.uk.TabIndex = 18;
			this.uk.Text = "Pass:";
			this.ui.AllowUserToAddRows = false;
			this.ui.AllowUserToDeleteRows = false;
			this.ui.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(36, 36, 36);
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(36, 36, 36);
			this.ui.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.ui.BackgroundColor = Color.FromArgb(36, 36, 36);
			this.ui.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ui.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ul,
				this.um
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(36, 36, 36);
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25f);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(36, 36, 36);
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.ui.DefaultCellStyle = dataGridViewCellStyle2;
			this.ui.GridColor = Color.White;
			this.ui.Location = new Point(16, 123);
			this.ui.Name = "dataGridView1";
			this.ui.RowHeadersVisible = false;
			this.ui.Size = new Size(551, 265);
			this.ui.TabIndex = 17;
			this.ui.CellContentClick += this.Gd;
			this.ul.HeaderText = "Variable";
			this.ul.Name = "Variable";
			this.ul.Width = 300;
			this.um.HeaderText = "Value";
			this.um.Name = "Value";
			this.um.Width = 245;
			this.ug.AutoSize = true;
			this.ug.Location = new Point(13, 102);
			this.ug.Name = "label27";
			this.ug.Size = new Size(95, 18);
			this.ug.TabIndex = 15;
			this.ug.Text = "General Data";
			this.uh.AutoSize = true;
			this.uh.Location = new Point(13, 8);
			this.uh.Name = "label26";
			this.uh.Size = new Size(31, 18);
			this.uh.TabIndex = 14;
			this.uh.Text = "File";
			this.ud.BackColor = Color.FromArgb(36, 36, 36);
			this.ud.FlatStyle = FlatStyle.Flat;
			this.ud.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ud.Location = new Point(386, 25);
			this.ud.Name = "button33";
			this.ud.Size = new Size(64, 33);
			this.ud.TabIndex = 5;
			this.ud.Text = "Select";
			this.ud.UseVisualStyleBackColor = false;
			this.ud.Click += this.FX;
			this.ue.BackColor = Color.FromArgb(36, 36, 36);
			this.ue.ForeColor = Color.White;
			this.ue.Location = new Point(16, 29);
			this.ue.Name = "textBox3";
			this.ue.Size = new Size(364, 24);
			this.ue.TabIndex = 3;
			this.uf.BackColor = Color.FromArgb(36, 36, 36);
			this.uf.FlatStyle = FlatStyle.Flat;
			this.uf.Location = new Point(473, 25);
			this.uf.Name = "button32";
			this.uf.Size = new Size(94, 33);
			this.uf.TabIndex = 2;
			this.uf.Text = "Decode";
			this.uf.UseVisualStyleBackColor = false;
			this.uf.Click += this.Ga;
			this.tj.BackColor = Color.FromArgb(0, 0, 0);
			this.tj.Controls.Add(this.sV);
			this.tj.Location = new Point(139, 4);
			this.tj.Name = "tabPage6";
			this.tj.Size = new Size(625, 394);
			this.tj.TabIndex = 3;
			this.tj.Text = "Captcha";
			this.sV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.sV.Controls.Add(this.sX);
			this.sV.Controls.Add(this.sW);
			this.sV.Location = new Point(3, 7);
			this.sV.Name = "tabControl1";
			this.sV.SelectedIndex = 0;
			this.sV.Size = new Size(580, 383);
			this.sV.TabIndex = 10;
			this.sX.BackColor = Color.Black;
			this.sX.Controls.Add(this.te);
			this.sX.Controls.Add(this.sY);
			this.sX.Controls.Add(this.sZ);
			this.sX.Controls.Add(this.ta);
			this.sX.Controls.Add(this.tb);
			this.sX.Location = new Point(4, 27);
			this.sX.Name = "tabPage2";
			this.sX.Padding = new Padding(3);
			this.sX.Size = new Size(572, 352);
			this.sX.TabIndex = 1;
			this.sX.Text = "Background Captcha Solver";
			this.te.Anchor = AnchorStyles.Right;
			this.te.BackColor = Color.FromArgb(36, 36, 36);
			this.te.FlatStyle = FlatStyle.Flat;
			this.te.Location = new Point(433, 29);
			this.te.Name = "button29";
			this.te.Size = new Size(136, 77);
			this.te.TabIndex = 5;
			this.te.Text = "Select Submit button (position)";
			this.te.UseVisualStyleBackColor = false;
			this.te.Click += this.GN;
			this.sY.Anchor = AnchorStyles.Right;
			this.sY.BackColor = Color.FromArgb(36, 36, 36);
			this.sY.FlatStyle = FlatStyle.Flat;
			this.sY.Location = new Point(430, 265);
			this.sY.Name = "button28";
			this.sY.Size = new Size(136, 75);
			this.sY.TabIndex = 4;
			this.sY.Text = "Stop auto-solver";
			this.sY.UseVisualStyleBackColor = false;
			this.sY.Click += this.DM;
			this.sZ.Anchor = AnchorStyles.Right;
			this.sZ.BackColor = Color.FromArgb(36, 36, 36);
			this.sZ.FlatStyle = FlatStyle.Flat;
			this.sZ.Location = new Point(430, 265);
			this.sZ.Name = "button27";
			this.sZ.Size = new Size(136, 75);
			this.sZ.TabIndex = 3;
			this.sZ.Text = "Start auto-solver";
			this.sZ.UseVisualStyleBackColor = false;
			this.sZ.Click += this.GK;
			this.ta.Anchor = AnchorStyles.Right;
			this.ta.BackColor = Color.FromArgb(36, 36, 36);
			this.ta.FlatStyle = FlatStyle.Flat;
			this.ta.Location = new Point(430, 150);
			this.ta.Name = "button26";
			this.ta.Size = new Size(136, 77);
			this.ta.TabIndex = 2;
			this.ta.Text = "Solve captcha(s)";
			this.ta.UseVisualStyleBackColor = false;
			this.ta.Click += this.DJ;
			this.tb.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tb.Controls.Add(this.tc);
			this.tb.ForeColor = Color.White;
			this.tb.Location = new Point(6, 6);
			this.tb.Name = "groupBox6";
			this.tb.Size = new Size(421, 334);
			this.tb.TabIndex = 1;
			this.tb.TabStop = false;
			this.tb.Text = "Output";
			this.tc.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tc.BackColor = Color.FromArgb(36, 36, 36);
			this.tc.ForeColor = Color.White;
			this.tc.Location = new Point(6, 23);
			this.tc.Multiline = true;
			this.tc.Name = "textBox2";
			this.tc.ReadOnly = true;
			this.tc.ShortcutsEnabled = false;
			this.tc.Size = new Size(409, 305);
			this.tc.TabIndex = 0;
			this.sW.BackColor = Color.Black;
			this.sW.Controls.Add(this.rv);
			this.sW.Controls.Add(this.rn);
			this.sW.Controls.Add(this.ro);
			this.sW.Controls.Add(this.rr);
			this.sW.Controls.Add(this.rp);
			this.sW.Controls.Add(this.rq);
			this.sW.Controls.Add(this.rs);
			this.sW.Controls.Add(this.rt);
			this.sW.Controls.Add(this.ru);
			this.sW.Location = new Point(4, 22);
			this.sW.Name = "tabPage1";
			this.sW.Padding = new Padding(3);
			this.sW.Size = new Size(572, 357);
			this.sW.TabIndex = 0;
			this.sW.Text = "Foreground Captcha Solver";
			this.rv.BackColor = Color.FromArgb(36, 36, 36);
			this.rv.FlatStyle = FlatStyle.Flat;
			this.rv.Location = new Point(14, 36);
			this.rv.Name = "button7";
			this.rv.Size = new Size(140, 39);
			this.rv.TabIndex = 9;
			this.rv.Text = "Are you human?";
			this.rv.UseVisualStyleBackColor = false;
			this.rv.Click += this.zp;
			this.rn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.rn.BackColor = Color.FromArgb(36, 36, 36);
			this.rn.FlatStyle = FlatStyle.Flat;
			this.rn.ForeColor = Color.White;
			this.rn.Location = new Point(426, 290);
			this.rn.Name = "button12";
			this.rn.Size = new Size(140, 39);
			this.rn.TabIndex = 5;
			this.rn.Text = "Stop auto solver";
			this.rn.UseVisualStyleBackColor = false;
			this.rn.Click += this.yx;
			this.ro.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.ro.BackColor = Color.FromArgb(36, 36, 36);
			this.ro.FlatStyle = FlatStyle.Flat;
			this.ro.Location = new Point(426, 290);
			this.ro.Name = "button11";
			this.ro.Size = new Size(140, 39);
			this.ro.TabIndex = 4;
			this.ro.Text = "Start auto solver";
			this.ro.UseVisualStyleBackColor = false;
			this.ro.Click += this.yC;
			this.rr.BackColor = Color.FromArgb(36, 36, 36);
			this.rr.FlatStyle = FlatStyle.Flat;
			this.rr.Location = new Point(14, 123);
			this.rr.Name = "button8";
			this.rr.Size = new Size(140, 39);
			this.rr.TabIndex = 1;
			this.rr.Text = "Math question";
			this.rr.UseVisualStyleBackColor = false;
			this.rr.Click += this.yO;
			this.rp.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.rp.BackColor = Color.FromArgb(36, 36, 36);
			this.rp.FlatStyle = FlatStyle.Flat;
			this.rp.Location = new Point(426, 234);
			this.rp.Name = "button10";
			this.rp.Size = new Size(140, 39);
			this.rp.TabIndex = 3;
			this.rp.Text = "Solve captcha";
			this.rp.UseVisualStyleBackColor = false;
			this.rp.Click += this.yI;
			this.rq.BackColor = Color.FromArgb(36, 36, 36);
			this.rq.FlatStyle = FlatStyle.Flat;
			this.rq.Location = new Point(14, 208);
			this.rq.Name = "button9";
			this.rq.Size = new Size(140, 39);
			this.rq.TabIndex = 2;
			this.rq.Text = "Submit button";
			this.rq.UseVisualStyleBackColor = false;
			this.rq.Click += this.yL;
			this.rs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.rs.BackColor = Color.FromArgb(36, 36, 36);
			this.rs.BackgroundImageLayout = ImageLayout.Center;
			this.rs.BorderStyle = BorderStyle.FixedSingle;
			this.rs.Location = new Point(160, 21);
			this.rs.Name = "pictureBox1";
			this.rs.Size = new Size(235, 83);
			this.rs.SizeMode = PictureBoxSizeMode.Zoom;
			this.rs.TabIndex = 6;
			this.rs.TabStop = false;
			this.rt.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.rt.BackColor = Color.FromArgb(36, 36, 36);
			this.rt.BackgroundImageLayout = ImageLayout.Center;
			this.rt.BorderStyle = BorderStyle.FixedSingle;
			this.rt.Location = new Point(160, 221);
			this.rt.Name = "pictureBox3";
			this.rt.Size = new Size(235, 74);
			this.rt.SizeMode = PictureBoxSizeMode.Zoom;
			this.rt.TabIndex = 8;
			this.rt.TabStop = false;
			this.ru.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ru.BackColor = Color.FromArgb(36, 36, 36);
			this.ru.BackgroundImageLayout = ImageLayout.Center;
			this.ru.BorderStyle = BorderStyle.FixedSingle;
			this.ru.Location = new Point(160, 124);
			this.ru.Name = "pictureBox2";
			this.ru.Size = new Size(235, 80);
			this.ru.SizeMode = PictureBoxSizeMode.Zoom;
			this.ru.TabIndex = 7;
			this.ru.TabStop = false;
			this.tk.BackColor = Color.FromArgb(0, 0, 0);
			this.tk.Controls.Add(this.rX);
			this.tk.Controls.Add(this.rW);
			this.tk.Controls.Add(this.rV);
			this.tk.Location = new Point(139, 4);
			this.tk.Name = "tabPage7";
			this.tk.Size = new Size(625, 394);
			this.tk.TabIndex = 4;
			this.tk.Text = "Item info";
			this.rX.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.rX.Controls.Add(this.rY);
			this.rX.ForeColor = Color.White;
			this.rX.Location = new Point(3, 0);
			this.rX.Name = "SearchGroup";
			this.rX.Size = new Size(482, 52);
			this.rX.TabIndex = 3;
			this.rX.TabStop = false;
			this.rX.Text = "Search";
			this.rY.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.rY.BackColor = Color.FromArgb(36, 36, 36);
			this.rY.ForeColor = Color.White;
			this.rY.Location = new Point(6, 20);
			this.rY.Name = "maskedTextBox2";
			this.rY.Size = new Size(470, 24);
			this.rY.TabIndex = 2;
			this.rY.MaskInputRejected += this.AY;
			this.rY.KeyUp += this.AV;
			this.rW.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.rW.BackColor = Color.FromArgb(36, 36, 36);
			this.rW.FlatStyle = FlatStyle.Flat;
			this.rW.ForeColor = Color.White;
			this.rW.Location = new Point(491, 5);
			this.rW.Name = "button13";
			this.rW.Size = new Size(75, 47);
			this.rW.TabIndex = 1;
			this.rW.Text = "Load";
			this.rW.UseVisualStyleBackColor = false;
			this.rW.Click += this.AS;
			this.rV.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.rV.BackColor = Color.FromArgb(36, 36, 36);
			this.rV.ForeColor = Color.White;
			this.rV.HideSelection = false;
			this.rV.Location = new Point(3, 58);
			this.rV.Name = "listView1";
			this.rV.Size = new Size(563, 334);
			this.rV.TabIndex = 0;
			this.rV.UseCompatibleStateImageBehavior = false;
			this.rV.View = View.Details;
			this.tl.BackColor = Color.FromArgb(0, 0, 0);
			this.tl.Controls.Add(this.tI);
			this.tl.Location = new Point(139, 4);
			this.tl.Name = "tabPage8";
			this.tl.Padding = new Padding(3);
			this.tl.Size = new Size(625, 394);
			this.tl.TabIndex = 5;
			this.tl.Text = "Multiboxing";
			this.tI.Controls.Add(this.tJ);
			this.tI.Controls.Add(this.tK);
			this.tI.Location = new Point(0, -4);
			this.tI.Name = "tabControl2";
			this.tI.SelectedIndex = 0;
			this.tI.Size = new Size(586, 395);
			this.tI.TabIndex = 9;
			this.tJ.BackColor = Color.Black;
			this.tJ.Controls.Add(this.uu);
			this.tJ.Controls.Add(this.ut);
			this.tJ.Location = new Point(4, 27);
			this.tJ.Name = "tabPage12";
			this.tJ.Padding = new Padding(3);
			this.tJ.Size = new Size(578, 364);
			this.tJ.TabIndex = 0;
			this.tJ.Text = "Multiboxing";
			this.uu.BackColor = Color.FromArgb(26, 26, 26);
			this.uu.Controls.Add(this.uA);
			this.uu.Controls.Add(this.uy);
			this.uu.Controls.Add(this.uz);
			this.uu.Controls.Add(this.uw);
			this.uu.Controls.Add(this.uv);
			this.uu.Controls.Add(this.sR);
			this.uu.Controls.Add(this.tT);
			this.uu.Controls.Add(this.tV);
			this.uu.Controls.Add(this.tW);
			this.uu.Controls.Add(this.tX);
			this.uu.Controls.Add(this.ur);
			this.uu.Controls.Add(this.uq);
			this.uu.Location = new Point(267, 23);
			this.uu.Name = "panel5";
			this.uu.Size = new Size(299, 317);
			this.uu.TabIndex = 24;
			this.uA.AutoSize = true;
			this.uA.Location = new Point(12, 136);
			this.uA.Name = "label36";
			this.uA.Size = new Size(131, 18);
			this.uA.TabIndex = 25;
			this.uA.Text = "CPU usage tuning:";
			this.uy.AutoSize = true;
			this.uy.Location = new Point(12, 168);
			this.uy.Name = "label35";
			this.uy.Size = new Size(62, 18);
			this.uy.TabIndex = 24;
			this.uy.Text = "Profiles:";
			this.uz.DropDownStyle = ComboBoxStyle.DropDownList;
			this.uz.FormattingEnabled = true;
			this.uz.Items.AddRange(new object[]
			{
				"Xtreme - GT@4% CPU",
				"Default - GT@25% CPU",
				"High FPS - GT@30%+ CPU"
			});
			this.uz.Location = new Point(14, 194);
			this.uz.Name = "comboBox4";
			this.uz.Size = new Size(161, 26);
			this.uz.TabIndex = 23;
			this.uz.SelectedIndexChanged += this.Gp;
			this.uw.AutoSize = true;
			this.uw.Location = new Point(11, 242);
			this.uw.Name = "label34";
			this.uw.Size = new Size(116, 18);
			this.uw.TabIndex = 22;
			this.uw.Text = "Process priority:";
			this.uv.AutoSize = true;
			this.uv.Location = new Point(166, 136);
			this.uv.Name = "label32";
			this.uv.Size = new Size(133, 18);
			this.uv.TabIndex = 21;
			this.uv.Text = "Run on: (thread(s))";
			this.sR.AutoSize = true;
			this.sR.Location = new Point(14, 6);
			this.sR.Name = "MB_enable";
			this.sR.Size = new Size(150, 22);
			this.sR.TabIndex = 8;
			this.sR.Text = "Enable Multiboxing";
			this.sR.UseVisualStyleBackColor = true;
			this.sR.CheckedChanged += this.Dq;
			this.tT.AutoSize = true;
			this.tT.Location = new Point(14, 36);
			this.tT.Name = "checkBox8";
			this.tT.Size = new Size(96, 22);
			this.tT.TabIndex = 9;
			this.tT.Text = "Auto log in";
			this.tT.UseVisualStyleBackColor = true;
			this.tT.CheckedChanged += this.Fx;
			this.tT.Click += this.FF;
			this.tV.AutoSize = true;
			this.tV.Location = new Point(14, 65);
			this.tV.Name = "checkBox9";
			this.tV.Size = new Size(200, 22);
			this.tV.TabIndex = 10;
			this.tV.Text = "Bypass \"Error connecting\"";
			this.tV.UseVisualStyleBackColor = true;
			this.tV.CheckedChanged += this.FA;
			this.tW.AutoSize = true;
			this.tW.Location = new Point(31, 94);
			this.tW.Name = "label25";
			this.tW.Size = new Size(144, 18);
			this.tW.TabIndex = 15;
			this.tW.Text = "With a delay of: (ms)";
			this.tX.BackColor = Color.FromArgb(36, 36, 36);
			this.tX.ForeColor = Color.White;
			this.tX.Location = new Point(187, 90);
			NumericUpDown numericUpDown13 = this.tX;
			int[] array13 = new int[4];
			array13[0] = 1215752192;
			array13[1] = 23;
			numericUpDown13.Maximum = new decimal(array13);
			this.tX.Name = "iTalk_NumericUpDown1";
			this.tX.Size = new Size(65, 24);
			this.tX.TabIndex = 18;
			NumericUpDown numericUpDown14 = this.tX;
			int[] array14 = new int[4];
			array14[0] = 8000;
			numericUpDown14.Value = new decimal(array14);
			this.tX.ValueChanged += this.Gm;
			this.ur.BackColor = Color.FromArgb(36, 36, 36);
			this.ur.ForeColor = Color.White;
			this.ur.FormattingEnabled = true;
			this.ur.Location = new Point(179, 166);
			this.ur.Name = "checkedListBox4";
			this.ur.Size = new Size(113, 137);
			this.ur.TabIndex = 20;
			this.ur.Click += this.GE;
			this.ur.MouseClick += this.Gy;
			this.ur.SelectedIndexChanged += this.Gs;
			this.ur.MouseDown += this.GB;
			this.ur.MouseUp += this.GH;
			this.uq.DropDownStyle = ComboBoxStyle.DropDownList;
			this.uq.FormattingEnabled = true;
			this.uq.Items.AddRange(new object[]
			{
				"Realtime - highest",
				"High - high",
				"Above normal - above normal",
				"Normal - default",
				"Below normal - below normal",
				"Idle - lowest"
			});
			this.uq.Location = new Point(14, 270);
			this.uq.Name = "comboBox3";
			this.uq.Size = new Size(161, 26);
			this.uq.TabIndex = 19;
			this.uq.SelectedIndexChanged += this.Gv;
			this.ut.BackColor = Color.FromArgb(26, 26, 26);
			this.ut.Controls.Add(this.ux);
			this.ut.Controls.Add(this.rA);
			this.ut.Controls.Add(this.rC);
			this.ut.Controls.Add(this.rz);
			this.ut.Controls.Add(this.rE);
			this.ut.Controls.Add(this.rB);
			this.ut.Controls.Add(this.rD);
			this.ut.Location = new Point(21, 20);
			this.ut.Name = "panel2";
			this.ut.Size = new Size(234, 320);
			this.ut.TabIndex = 21;
			this.ux.AutoSize = true;
			this.ux.Location = new Point(122, 28);
			this.ux.Name = "label33";
			this.ux.Size = new Size(22, 18);
			this.ux.TabIndex = 22;
			this.ux.Text = "->";
			this.rA.BackColor = Color.FromArgb(36, 36, 36);
			this.rA.FlatStyle = FlatStyle.Flat;
			this.rA.ForeColor = Color.FromArgb(192, 255, 255);
			this.rA.Location = new Point(27, 20);
			this.rA.Name = "startGTwindows";
			this.rA.Size = new Size(89, 33);
			this.rA.TabIndex = 0;
			this.rA.Text = "Start GT";
			this.rA.UseVisualStyleBackColor = false;
			this.rA.Click += this.Ak;
			this.rE.BackColor = Color.FromArgb(36, 36, 36);
			this.rE.FlatStyle = FlatStyle.Flat;
			this.rE.ForeColor = Color.White;
			this.rE.Location = new Point(131, 268);
			this.rE.Name = "close_gt_windows";
			this.rE.Size = new Size(91, 35);
			this.rE.TabIndex = 5;
			this.rE.Text = "Close";
			this.rE.UseVisualStyleBackColor = false;
			this.rE.Click += this.Av;
			this.rB.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.rB.BackColor = Color.FromArgb(36, 36, 36);
			this.rB.CheckOnClick = true;
			this.rB.ForeColor = Color.White;
			this.rB.FormattingEnabled = true;
			this.rB.Location = new Point(21, 96);
			this.rB.Name = "checkedListBox1";
			this.rB.Size = new Size(201, 156);
			this.rB.Sorted = true;
			this.rB.TabIndex = 2;
			this.rD.AutoSize = true;
			this.rD.Location = new Point(24, 68);
			this.rD.Name = "Select_all";
			this.rD.Size = new Size(86, 22);
			this.rD.TabIndex = 4;
			this.rD.Text = "Select all";
			this.rD.UseVisualStyleBackColor = true;
			this.rD.CheckedChanged += this.As;
			this.tK.BackColor = Color.Black;
			this.tK.Controls.Add(this.tP);
			this.tK.Controls.Add(this.tL);
			this.tK.Location = new Point(4, 22);
			this.tK.Name = "tabPage13";
			this.tK.Padding = new Padding(3);
			this.tK.Size = new Size(578, 369);
			this.tK.TabIndex = 1;
			this.tK.Text = "Auto Log In";
			this.tP.Controls.Add(this.tU);
			this.tP.Controls.Add(this.tS);
			this.tP.Controls.Add(this.tQ);
			this.tP.ForeColor = Color.White;
			this.tP.Location = new Point(306, 6);
			this.tP.Name = "groupBox8";
			this.tP.Size = new Size(263, 352);
			this.tP.TabIndex = 5;
			this.tP.TabStop = false;
			this.tP.Text = "2. View your accounts";
			this.tU.Activecolor = Color.FromArgb(70, 70, 70);
			this.tU.BackColor = Color.FromArgb(36, 36, 36);
			this.tU.BackgroundImageLayout = ImageLayout.Stretch;
			this.tU.BorderRadius = 0;
			this.tU.ButtonText = "                Refresh";
			this.tU.Cursor = Cursors.Hand;
			this.tU.DisabledColor = Color.Gray;
			this.tU.Iconcolor = Color.Transparent;
			this.tU.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton3.Iconimage");
			this.tU.Iconimage_right = null;
			this.tU.Iconimage_right_Selected = null;
			this.tU.Iconimage_Selected = null;
			this.tU.IconMarginLeft = 0;
			this.tU.IconMarginRight = 0;
			this.tU.IconRightVisible = false;
			this.tU.IconRightZoom = 0.0;
			this.tU.IconVisible = false;
			this.tU.IconZoom = 100.0;
			this.tU.IsTab = false;
			this.tU.Location = new Point(12, 216);
			this.tU.Margin = new Padding(6);
			this.tU.Name = "bunifuFlatButton3";
			this.tU.Normalcolor = Color.FromArgb(36, 36, 36);
			this.tU.OnHovercolor = Color.FromArgb(50, 50, 50);
			this.tU.OnHoverTextColor = Color.White;
			this.tU.selected = false;
			this.tU.Size = new Size(244, 48);
			this.tU.TabIndex = 7;
			this.tU.Text = "                Refresh";
			this.tU.TextAlign = ContentAlignment.MiddleLeft;
			this.tU.Textcolor = Color.White;
			this.tU.TextFont = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tU.Click += this.Fp;
			this.tS.BackColor = Color.FromArgb(36, 36, 36);
			this.tS.CheckOnClick = true;
			this.tS.ForeColor = Color.White;
			this.tS.FormattingEnabled = true;
			this.tS.Location = new Point(12, 34);
			this.tS.Name = "checkedListBox3";
			this.tS.Size = new Size(244, 156);
			this.tS.TabIndex = 6;
			this.tQ.Activecolor = Color.FromArgb(70, 70, 70);
			this.tQ.BackColor = Color.FromArgb(36, 36, 36);
			this.tQ.BackgroundImageLayout = ImageLayout.Stretch;
			this.tQ.BorderRadius = 0;
			this.tQ.ButtonText = "               Remove account(s)";
			this.tQ.Cursor = Cursors.Hand;
			this.tQ.DisabledColor = Color.Gray;
			this.tQ.Iconcolor = Color.Transparent;
			this.tQ.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton2.Iconimage");
			this.tQ.Iconimage_right = null;
			this.tQ.Iconimage_right_Selected = null;
			this.tQ.Iconimage_Selected = null;
			this.tQ.IconMarginLeft = 0;
			this.tQ.IconMarginRight = 0;
			this.tQ.IconRightVisible = false;
			this.tQ.IconRightZoom = 0.0;
			this.tQ.IconVisible = false;
			this.tQ.IconZoom = 60.0;
			this.tQ.IsTab = false;
			this.tQ.Location = new Point(12, 287);
			this.tQ.Margin = new Padding(4);
			this.tQ.Name = "bunifuFlatButton2";
			this.tQ.Normalcolor = Color.FromArgb(36, 36, 36);
			this.tQ.OnHovercolor = Color.FromArgb(50, 50, 50);
			this.tQ.OnHoverTextColor = Color.White;
			this.tQ.selected = false;
			this.tQ.Size = new Size(244, 48);
			this.tQ.TabIndex = 3;
			this.tQ.Text = "               Remove account(s)";
			this.tQ.TextAlign = ContentAlignment.MiddleLeft;
			this.tQ.Textcolor = Color.White;
			this.tQ.TextFont = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tQ.Click += this.Fu;
			this.tL.Controls.Add(this.tR);
			this.tL.Controls.Add(this.oO);
			this.tL.Controls.Add(this.tN);
			this.tL.Controls.Add(this.tO);
			this.tL.Controls.Add(this.tM);
			this.tL.ForeColor = Color.White;
			this.tL.Location = new Point(6, 6);
			this.tL.Name = "groupBox7";
			this.tL.Size = new Size(294, 352);
			this.tL.TabIndex = 0;
			this.tL.TabStop = false;
			this.tL.Text = "1. Add accounts";
			this.tR.AutoSize = true;
			this.tR.BackColor = Color.Transparent;
			this.tR.Font = new Font("Segoe UI", 8f);
			this.tR.ForeColor = Color.White;
			this.tR.Location = new Point(28, 177);
			this.tR.Name = "iTalk_Label2";
			this.tR.Size = new Size(65, 13);
			this.tR.TabIndex = 4;
			this.tR.Text = "Select a file";
			this.oO.Activecolor = Color.FromArgb(70, 70, 70);
			this.oO.BackColor = Color.FromArgb(36, 36, 36);
			this.oO.BackgroundImageLayout = ImageLayout.Stretch;
			this.oO.BorderRadius = 0;
			this.oO.ButtonText = "               Add account";
			this.oO.Cursor = Cursors.Hand;
			this.oO.DisabledColor = Color.Gray;
			this.oO.Iconcolor = Color.Transparent;
			this.oO.Iconimage = (Image)componentResourceManager.GetObject("bunifuFlatButton1.Iconimage");
			this.oO.Iconimage_right = null;
			this.oO.Iconimage_right_Selected = null;
			this.oO.Iconimage_Selected = null;
			this.oO.IconMarginLeft = 0;
			this.oO.IconMarginRight = 0;
			this.oO.IconRightVisible = false;
			this.oO.IconRightZoom = 0.0;
			this.oO.IconVisible = false;
			this.oO.IconZoom = 90.0;
			this.oO.IsTab = false;
			this.oO.Location = new Point(12, 287);
			this.oO.Margin = new Padding(4);
			this.oO.Name = "bunifuFlatButton1";
			this.oO.Normalcolor = Color.FromArgb(36, 36, 36);
			this.oO.OnHovercolor = Color.FromArgb(50, 50, 50);
			this.oO.OnHoverTextColor = Color.White;
			this.oO.selected = false;
			this.oO.Size = new Size(275, 48);
			this.oO.TabIndex = 3;
			this.oO.Text = "               Add account";
			this.oO.TextAlign = ContentAlignment.MiddleLeft;
			this.oO.Textcolor = Color.White;
			this.oO.TextFont = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.oO.Click += this.oT;
			this.tN.AutoSize = true;
			this.tN.BackColor = Color.Transparent;
			this.tN.Font = new Font("Segoe UI", 8f);
			this.tN.ForeColor = Color.White;
			this.tN.Location = new Point(28, 209);
			this.tN.Name = "iTalk_Label1";
			this.tN.Size = new Size(146, 13);
			this.tN.TabIndex = 2;
			this.tN.Text = "Description/Account name:";
			this.tO.AllowDrop = true;
			this.tO.kD = false;
			this.tO.BackColor = Color.FromArgb(36, 36, 36);
			this.tO.Font = new Font("Tahoma", 10f);
			this.tO.ForeColor = Color.White;
			this.tO.Location = new Point(31, 235);
			this.tO.Name = "iTalk_RichTextBox1";
			this.tO.jU = false;
			this.tO.Size = new Size(237, 29);
			this.tO.TabIndex = 1;
			this.tO.Text = "Account";
			this.tO.kz = true;
			this.tM.AllowDrop = true;
			this.tM.BackColor = Color.FromArgb(36, 36, 36);
			this.tM.color = Color.FromArgb(36, 36, 36);
			this.tM.colorActive = Color.FromArgb(50, 50, 50);
			this.tM.Cursor = Cursors.Hand;
			this.tM.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tM.ForeColor = Color.White;
			this.tM.Image = (Image)componentResourceManager.GetObject("bunifuTileButton1.Image");
			this.tM.ImagePosition = 10;
			this.tM.ImageZoom = 30;
			this.tM.LabelPosition = 30;
			this.tM.LabelText = "Tap to add a save.dat";
			this.tM.Location = new Point(31, 25);
			this.tM.Margin = new Padding(5, 5, 5, 5);
			this.tM.Name = "bunifuTileButton1";
			this.tM.Size = new Size(237, 121);
			this.tM.TabIndex = 0;
			this.tM.Click += this.Fm;
			this.tM.DragDrop += this.Fg;
			this.tM.DragEnter += this.Fj;
			this.tm.BackColor = Color.FromArgb(0, 0, 0);
			this.tm.Controls.Add(this.tA);
			this.tm.Controls.Add(this.sQ);
			this.tm.Controls.Add(this.sw);
			this.tm.Controls.Add(this.sN);
			this.tm.Controls.Add(this.sv);
			this.tm.Controls.Add(this.sM);
			this.tm.Controls.Add(this.sK);
			this.tm.Controls.Add(this.sL);
			this.tm.Location = new Point(139, 4);
			this.tm.Name = "tabPage9";
			this.tm.Padding = new Padding(3);
			this.tm.Size = new Size(625, 394);
			this.tm.TabIndex = 6;
			this.tm.Text = "Unbanner";
			this.sQ.Anchor = AnchorStyles.Bottom;
			this.sQ.BackColor = Color.FromArgb(36, 36, 36);
			this.sQ.FlatStyle = FlatStyle.Flat;
			this.sQ.ForeColor = Color.White;
			this.sQ.Location = new Point(5, 351);
			this.sQ.Name = "button25";
			this.sQ.Size = new Size(165, 33);
			this.sQ.TabIndex = 7;
			this.sQ.Text = "Manually change MAC";
			this.sQ.UseVisualStyleBackColor = false;
			this.sQ.Click += this.Dt;
			this.sw.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.sw.BackColor = Color.FromArgb(36, 36, 36);
			this.sw.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.sw.ForeColor = Color.White;
			this.sw.FormattingEnabled = true;
			this.sw.HorizontalScrollbar = true;
			this.sw.ItemHeight = 15;
			this.sw.Location = new Point(3, 6);
			this.sw.Name = "UnbanLog";
			this.sw.Size = new Size(540, 274);
			this.sw.TabIndex = 2;
			this.sw.ControlAdded += this.CY;
			this.sN.Anchor = AnchorStyles.Bottom;
			this.sN.BackColor = Color.FromArgb(36, 36, 36);
			this.sN.DropDownStyle = ComboBoxStyle.DropDownList;
			this.sN.ForeColor = Color.White;
			this.sN.FormattingEnabled = true;
			this.sN.Items.AddRange(new object[]
			{
				"q",
				"q"
			});
			this.sN.Location = new Point(370, 308);
			this.sN.Name = "comboBox2";
			this.sN.Size = new Size(210, 26);
			this.sN.TabIndex = 6;
			this.sN.SelectedIndexChanged += this.Db;
			this.sv.Anchor = AnchorStyles.Bottom;
			this.sv.BackColor = Color.FromArgb(36, 36, 36);
			this.sv.FlatStyle = FlatStyle.Flat;
			this.sv.ForeColor = Color.White;
			this.sv.Location = new Point(5, 308);
			this.sv.Name = "UnbanButton";
			this.sv.Size = new Size(165, 33);
			this.sv.TabIndex = 1;
			this.sv.Text = "Unban";
			this.sv.UseVisualStyleBackColor = false;
			this.sv.Click += this.BW;
			this.sM.Anchor = AnchorStyles.Bottom;
			this.sM.BackColor = Color.FromArgb(36, 36, 36);
			this.sM.FlatStyle = FlatStyle.Flat;
			this.sM.ForeColor = Color.White;
			this.sM.Location = new Point(411, 351);
			this.sM.Name = "button24";
			this.sM.Size = new Size(169, 33);
			this.sM.TabIndex = 5;
			this.sM.Text = "Check VPN status";
			this.sM.UseVisualStyleBackColor = false;
			this.sM.Click += this.CV;
			this.sK.Anchor = AnchorStyles.Bottom;
			this.sK.BackColor = Color.FromArgb(36, 36, 36);
			this.sK.FlatStyle = FlatStyle.Flat;
			this.sK.ForeColor = Color.White;
			this.sK.Location = new Point(192, 308);
			this.sK.Name = "button22";
			this.sK.Size = new Size(168, 33);
			this.sK.TabIndex = 3;
			this.sK.Text = "Connect to VPN";
			this.sK.UseVisualStyleBackColor = false;
			this.sK.Click += this.CL;
			this.sL.Anchor = AnchorStyles.Bottom;
			this.sL.BackColor = Color.FromArgb(36, 36, 36);
			this.sL.FlatStyle = FlatStyle.Flat;
			this.sL.ForeColor = Color.White;
			this.sL.Location = new Point(192, 351);
			this.sL.Name = "button23";
			this.sL.Size = new Size(209, 33);
			this.sL.TabIndex = 4;
			this.sL.Text = "Disconnect from VPN";
			this.sL.UseVisualStyleBackColor = false;
			this.sL.Click += this.CS;
			this.tn.BackColor = Color.FromArgb(0, 0, 0);
			this.tn.Controls.Add(this.sJ);
			this.tn.Controls.Add(this.sy);
			this.tn.Controls.Add(this.sE);
			this.tn.Controls.Add(this.sF);
			this.tn.Controls.Add(this.sG);
			this.tn.Controls.Add(this.sD);
			this.tn.Controls.Add(this.sA);
			this.tn.Controls.Add(this.sC);
			this.tn.Controls.Add(this.sz);
			this.tn.Controls.Add(this.sB);
			this.tn.Controls.Add(this.sI);
			this.tn.Controls.Add(this.sH);
			this.tn.Controls.Add(this.sx);
			this.tn.Location = new Point(139, 4);
			this.tn.Name = "tabPage10";
			this.tn.Padding = new Padding(3);
			this.tn.Size = new Size(625, 394);
			this.tn.TabIndex = 7;
			this.tn.Text = "W-Render";
			this.sJ.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.sJ.BackColor = Color.FromArgb(36, 36, 36);
			this.sJ.FlatStyle = FlatStyle.Flat;
			this.sJ.ForeColor = Color.White;
			this.sJ.Location = new Point(308, 67);
			this.sJ.Name = "button21";
			this.sJ.Size = new Size(152, 28);
			this.sJ.TabIndex = 11;
			this.sJ.Text = "Open output folder";
			this.sJ.UseVisualStyleBackColor = false;
			this.sJ.Click += this.Cz;
			this.sy.AutoSize = true;
			this.sy.Location = new Point(16, 41);
			this.sy.Name = "label16";
			this.sy.Size = new Size(96, 18);
			this.sy.TabIndex = 2;
			this.sy.Text = "World Name:";
			this.sE.Anchor = AnchorStyles.Right;
			this.sE.AutoSize = true;
			this.sE.BackColor = Color.FromArgb(36, 36, 36);
			this.sE.FlatStyle = FlatStyle.Flat;
			this.sE.Location = new Point(539, 264);
			this.sE.Name = "button20";
			this.sE.Size = new Size(41, 36);
			this.sE.TabIndex = 8;
			this.sE.Text = "→";
			this.sE.UseVisualStyleBackColor = false;
			this.sE.Click += this.Ct;
			this.sF.Anchor = AnchorStyles.Right;
			this.sF.AutoSize = true;
			this.sF.BackColor = Color.FromArgb(36, 36, 36);
			this.sF.FlatStyle = FlatStyle.Flat;
			this.sF.Location = new Point(539, 300);
			this.sF.Name = "button19";
			this.sF.Size = new Size(41, 36);
			this.sF.TabIndex = 7;
			this.sF.Text = "←";
			this.sF.UseVisualStyleBackColor = false;
			this.sF.Click += this.Cw;
			this.sG.Anchor = AnchorStyles.Right;
			this.sG.AutoSize = true;
			this.sG.BackColor = Color.FromArgb(36, 36, 36);
			this.sG.FlatStyle = FlatStyle.Flat;
			this.sG.Location = new Point(539, 186);
			this.sG.Name = "button18";
			this.sG.Size = new Size(36, 36);
			this.sG.TabIndex = 6;
			this.sG.Text = "↓";
			this.sG.UseVisualStyleBackColor = false;
			this.sG.Click += this.Cq;
			this.sD.Anchor = AnchorStyles.Right;
			this.sD.AutoSize = true;
			this.sD.BackColor = Color.FromArgb(36, 36, 36);
			this.sD.FlatStyle = FlatStyle.Flat;
			this.sD.Location = new Point(539, 148);
			this.sD.Name = "button17";
			this.sD.Size = new Size(36, 36);
			this.sD.TabIndex = 5;
			this.sD.Text = "↑";
			this.sD.UseVisualStyleBackColor = false;
			this.sD.Click += this.Cn;
			this.sA.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.sA.BackColor = Color.FromArgb(36, 36, 36);
			this.sA.FlatStyle = FlatStyle.Flat;
			this.sA.ForeColor = Color.White;
			this.sA.Location = new Point(493, 35);
			this.sA.Name = "button16";
			this.sA.Size = new Size(86, 31);
			this.sA.TabIndex = 0;
			this.sA.Text = "Render!";
			this.sA.UseVisualStyleBackColor = false;
			this.sA.Click += this.Ca;
			this.sC.AutoSize = false;
			this.sC.LargeChange = 1;
			this.sC.Location = new Point(16, 71);
			this.sC.Minimum = 2;
			this.sC.Name = "trackBar1";
			this.sC.Size = new Size(225, 22);
			this.sC.TabIndex = 1;
			this.sC.TickFrequency = 100;
			this.sC.TickStyle = TickStyle.None;
			this.sC.Value = 2;
			this.sC.Scroll += this.Ce;
			this.sC.ValueChanged += this.Ce;
			this.sz.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.sz.BackColor = Color.FromArgb(36, 36, 36);
			this.sz.ForeColor = Color.White;
			this.sz.Location = new Point(118, 38);
			this.sz.Name = "maskedTextBox3";
			this.sz.Size = new Size(366, 24);
			this.sz.TabIndex = 1;
			this.sB.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.sB.AutoSize = true;
			this.sB.Checked = true;
			this.sB.CheckState = CheckState.Checked;
			this.sB.FlatStyle = FlatStyle.Flat;
			this.sB.Location = new Point(471, 71);
			this.sB.Name = "checkBox4";
			this.sB.Size = new Size(105, 22);
			this.sB.TabIndex = 4;
			this.sB.Text = "Save as png";
			this.sB.UseVisualStyleBackColor = true;
			this.sI.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.sI.Location = new Point(3, -4);
			this.sI.Name = "pictureBox8";
			this.sI.Size = new Size(618, 106);
			this.sI.TabIndex = 10;
			this.sI.TabStop = false;
			this.sH.Anchor = AnchorStyles.Right;
			this.sH.Location = new Point(531, 99);
			this.sH.Name = "pictureBox7";
			this.sH.Size = new Size(53, 295);
			this.sH.TabIndex = 9;
			this.sH.TabStop = false;
			this.sx.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.sx.BackColor = Color.FromArgb(36, 36, 36);
			this.sx.Location = new Point(8, 102);
			this.sx.Name = "pictureBox6";
			this.sx.Size = new Size(525, 276);
			this.sx.SizeMode = PictureBoxSizeMode.Zoom;
			this.sx.TabIndex = 3;
			this.sx.TabStop = false;
			this.sx.Click += this.Ch;
			this.to.BackColor = Color.FromArgb(0, 0, 0);
			this.to.Controls.Add(this.us);
			this.to.Controls.Add(this.uo);
			this.to.Controls.Add(this.tY);
			this.to.Controls.Add(this.tD);
			this.to.Controls.Add(this.st);
			this.to.Controls.Add(this.rZ);
			this.to.Controls.Add(this.rx);
			this.to.Controls.Add(this.ry);
			this.to.Controls.Add(this.rw);
			this.to.Location = new Point(139, 4);
			this.to.Name = "tabPage11";
			this.to.Padding = new Padding(3);
			this.to.Size = new Size(625, 394);
			this.to.TabIndex = 8;
			this.to.Text = "Info/settings";
			this.us.BackColor = Color.FromArgb(26, 26, 26);
			this.us.Controls.Add(this.tZ);
			this.us.Controls.Add(this.ua);
			this.us.Controls.Add(this.ub);
			this.us.Location = new Point(309, 141);
			this.us.Name = "panel1";
			this.us.Size = new Size(264, 240);
			this.us.TabIndex = 28;
			this.tZ.AutoSize = true;
			this.tZ.Location = new Point(12, 175);
			this.tZ.Name = "checkBox10";
			this.tZ.Size = new Size(225, 22);
			this.tZ.TabIndex = 29;
			this.tZ.Text = "Always load settings at startup";
			this.tZ.UseVisualStyleBackColor = true;
			this.tZ.CheckedChanged += this.FU;
			this.ua.ActiveBorderThickness = 1;
			this.ua.ActiveCornerRadius = 20;
			this.ua.ActiveFillColor = Color.FromArgb(56, 56, 56);
			this.ua.ActiveForecolor = Color.White;
			this.ua.ActiveLineColor = Color.White;
			this.ua.BackColor = Color.FromArgb(26, 26, 26);
			this.ua.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuThinButton22.BackgroundImage");
			this.ua.ButtonText = "Save settings";
			this.ua.Cursor = Cursors.Hand;
			this.ua.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ua.ForeColor = Color.White;
			this.ua.IdleBorderThickness = 1;
			this.ua.IdleCornerRadius = 20;
			this.ua.IdleFillColor = Color.FromArgb(36, 36, 36);
			this.ua.IdleForecolor = Color.White;
			this.ua.IdleLineColor = Color.White;
			this.ua.Location = new Point(12, 25);
			this.ua.Margin = new Padding(5);
			this.ua.Name = "bunifuThinButton22";
			this.ua.Size = new Size(239, 38);
			this.ua.TabIndex = 28;
			this.ua.TextAlign = ContentAlignment.MiddleCenter;
			this.ua.Click += this.FO;
			this.ub.ActiveBorderThickness = 1;
			this.ub.ActiveCornerRadius = 20;
			this.ub.ActiveFillColor = Color.FromArgb(56, 56, 56);
			this.ub.ActiveForecolor = Color.White;
			this.ub.ActiveLineColor = Color.White;
			this.ub.BackColor = Color.FromArgb(26, 26, 26);
			this.ub.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuThinButton21.BackgroundImage");
			this.ub.ButtonText = "Load settings";
			this.ub.Cursor = Cursors.Hand;
			this.ub.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ub.ForeColor = Color.White;
			this.ub.IdleBorderThickness = 1;
			this.ub.IdleCornerRadius = 20;
			this.ub.IdleFillColor = Color.FromArgb(36, 36, 36);
			this.ub.IdleForecolor = Color.White;
			this.ub.IdleLineColor = Color.White;
			this.ub.Location = new Point(12, 102);
			this.ub.Margin = new Padding(5);
			this.ub.Name = "bunifuThinButton21";
			this.ub.Size = new Size(239, 39);
			this.ub.TabIndex = 27;
			this.ub.TextAlign = ContentAlignment.MiddleCenter;
			this.ub.Click += this.FR;
			this.uo.ActiveBorderThickness = 1;
			this.uo.ActiveCornerRadius = 20;
			this.uo.ActiveFillColor = Color.FromArgb(56, 56, 56);
			this.uo.ActiveForecolor = Color.White;
			this.uo.ActiveLineColor = Color.White;
			this.uo.BackColor = Color.FromArgb(0, 0, 0);
			this.uo.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuThinButton23.BackgroundImage");
			this.uo.ButtonText = "Check online user count";
			this.uo.Cursor = Cursors.Hand;
			this.uo.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.uo.ForeColor = Color.White;
			this.uo.IdleBorderThickness = 1;
			this.uo.IdleCornerRadius = 20;
			this.uo.IdleFillColor = Color.FromArgb(36, 36, 36);
			this.uo.IdleForecolor = Color.White;
			this.uo.IdleLineColor = Color.White;
			this.uo.Location = new Point(9, 316);
			this.uo.Margin = new Padding(5);
			this.uo.Name = "bunifuThinButton23";
			this.uo.Size = new Size(213, 42);
			this.uo.TabIndex = 27;
			this.uo.TextAlign = ContentAlignment.MiddleCenter;
			this.uo.Click += this.Gg;
			this.tY.ActiveBorderThickness = 1;
			this.tY.ActiveCornerRadius = 20;
			this.tY.ActiveFillColor = Color.FromArgb(56, 56, 56);
			this.tY.ActiveForecolor = Color.White;
			this.tY.ActiveLineColor = Color.White;
			this.tY.BackColor = Color.FromArgb(0, 0, 0);
			this.tY.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuThinButton24.BackgroundImage");
			this.tY.ButtonText = "Show premium features";
			this.tY.Cursor = Cursors.Hand;
			this.tY.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.tY.ForeColor = Color.White;
			this.tY.IdleBorderThickness = 1;
			this.tY.IdleCornerRadius = 20;
			this.tY.IdleFillColor = Color.FromArgb(36, 36, 36);
			this.tY.IdleForecolor = Color.White;
			this.tY.IdleLineColor = Color.White;
			this.tY.Location = new Point(8, 278);
			this.tY.Margin = new Padding(5);
			this.tY.Name = "bunifuThinButton24";
			this.tY.Size = new Size(213, 42);
			this.tY.TabIndex = 26;
			this.tY.TextAlign = ContentAlignment.MiddleCenter;
			this.tY.Click += this.FL;
			this.tD.AutoSize = true;
			this.tD.Location = new Point(74, 363);
			this.tD.Name = "label21";
			this.tD.Size = new Size(36, 18);
			this.tD.TabIndex = 9;
			this.tD.Text = "1.91";
			this.st.ErrorImage = (Image)componentResourceManager.GetObject("dsugugdHGHSDGid730hjd.ErrorImage");
			this.st.Image = cF.Mu;
			this.st.Location = new Point(3, 6);
			this.st.Name = "dsugugdHGHSDGid730hjd";
			this.st.Size = new Size(328, 78);
			this.st.SizeMode = PictureBoxSizeMode.Zoom;
			this.st.TabIndex = 8;
			this.st.TabStop = false;
			this.rZ.Image = cF.Mc;
			this.rZ.Location = new Point(8, 90);
			this.rZ.Name = "pictureBox4";
			this.rZ.Size = new Size(259, 174);
			this.rZ.SizeMode = PictureBoxSizeMode.StretchImage;
			this.rZ.TabIndex = 7;
			this.rZ.TabStop = false;
			this.rZ.Click += this.Eh;
			this.rx.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.rx.BackgroundImageLayout = ImageLayout.None;
			this.rx.Image = (Image)componentResourceManager.GetObject("discordLogo.Image");
			this.rx.InitialImage = null;
			this.rx.Location = new Point(321, 7);
			this.rx.Name = "discordLogo";
			this.rx.Size = new Size(126, 91);
			this.rx.SizeMode = PictureBoxSizeMode.Zoom;
			this.rx.TabIndex = 4;
			this.rx.TabStop = false;
			this.rx.Click += this.zs;
			this.ry.AutoSize = true;
			this.ry.Location = new Point(6, 363);
			this.ry.Name = "label8";
			this.ry.Size = new Size(62, 18);
			this.ry.TabIndex = 6;
			this.ry.Text = "Version:";
			this.ry.Click += this.Ay;
			this.rw.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.rw.BackgroundImageLayout = ImageLayout.None;
			this.rw.Image = (Image)componentResourceManager.GetObject("YTlogo.Image");
			this.rw.InitialImage = null;
			this.rw.Location = new Point(453, 11);
			this.rw.Name = "YTlogo";
			this.rw.Size = new Size(123, 87);
			this.rw.SizeMode = PictureBoxSizeMode.Zoom;
			this.rw.TabIndex = 5;
			this.rw.TabStop = false;
			this.rw.Click += this.zv;
			this.AllowDrop = true;
			base.AutoScaleMode = AutoScaleMode.None;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(725, 441);
			base.Controls.Add(this.up);
			base.Controls.Add(this.un);
			base.Controls.Add(this.tC);
			base.Controls.Add(this.tB);
			base.Controls.Add(this.td);
			base.Controls.Add(this.tf);
			base.Controls.Add(this.sP);
			base.Controls.Add(this.su);
			this.ForeColor = Color.White;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new Size(741, 600);
			this.MinimumSize = new Size(624, 435);
			base.Name = "Form1";
			base.Opacity = 0.98;
			this.Text = "GT Auto-CCS by RealGoblins";
			this.tz.SetToolTip(this, "Made by RealGoblins");
			base.FormClosing += this.xG;
			base.Load += this.xw;
			base.Click += this.EO;
			base.KeyPress += this.EI;
			base.MouseClick += this.EF;
			base.Move += this.EL;
			((ISupportInitialize)this.su).EndInit();
			((ISupportInitialize)this.td).EndInit();
			this.qO.ResumeLayout(false);
			this.qO.PerformLayout();
			((ISupportInitialize)this.tH).EndInit();
			this.qP.ResumeLayout(false);
			this.qP.PerformLayout();
			((ISupportInitialize)this.rh).EndInit();
			((ISupportInitialize)this.ri).EndInit();
			((ISupportInitialize)this.ra).EndInit();
			((ISupportInitialize)this.rb).EndInit();
			((ISupportInitialize)this.rz).EndInit();
			this.tf.ResumeLayout(false);
			this.tg.ResumeLayout(false);
			this.qX.ResumeLayout(false);
			this.qX.PerformLayout();
			this.th.ResumeLayout(false);
			this.th.PerformLayout();
			this.rM.ResumeLayout(false);
			this.rM.PerformLayout();
			((ISupportInitialize)this.rL).EndInit();
			this.rK.ResumeLayout(false);
			this.rK.PerformLayout();
			this.rH.ResumeLayout(false);
			this.rH.PerformLayout();
			this.ti.ResumeLayout(false);
			this.ti.PerformLayout();
			this.sa.ResumeLayout(false);
			((ISupportInitialize)this.ss).EndInit();
			this.se.ResumeLayout(false);
			this.se.PerformLayout();
			((ISupportInitialize)this.so).EndInit();
			this.sd.ResumeLayout(false);
			this.sd.PerformLayout();
			((ISupportInitialize)this.sq).EndInit();
			this.uc.ResumeLayout(false);
			this.uc.PerformLayout();
			((ISupportInitialize)this.ui).EndInit();
			this.tj.ResumeLayout(false);
			this.sV.ResumeLayout(false);
			this.sX.ResumeLayout(false);
			this.tb.ResumeLayout(false);
			this.tb.PerformLayout();
			this.sW.ResumeLayout(false);
			((ISupportInitialize)this.rs).EndInit();
			((ISupportInitialize)this.rt).EndInit();
			((ISupportInitialize)this.ru).EndInit();
			this.tk.ResumeLayout(false);
			this.rX.ResumeLayout(false);
			this.rX.PerformLayout();
			this.tl.ResumeLayout(false);
			this.tI.ResumeLayout(false);
			this.tJ.ResumeLayout(false);
			this.uu.ResumeLayout(false);
			this.uu.PerformLayout();
			((ISupportInitialize)this.tX).EndInit();
			this.ut.ResumeLayout(false);
			this.ut.PerformLayout();
			this.tK.ResumeLayout(false);
			this.tP.ResumeLayout(false);
			this.tL.ResumeLayout(false);
			this.tL.PerformLayout();
			this.tm.ResumeLayout(false);
			this.tn.ResumeLayout(false);
			this.tn.PerformLayout();
			((ISupportInitialize)this.sC).EndInit();
			((ISupportInitialize)this.sI).EndInit();
			((ISupportInitialize)this.sH).EndInit();
			((ISupportInitialize)this.sx).EndInit();
			this.to.ResumeLayout(false);
			this.to.PerformLayout();
			this.us.ResumeLayout(false);
			this.us.PerformLayout();
			((ISupportInitialize)this.st).EndInit();
			((ISupportInitialize)this.rZ).EndInit();
			((ISupportInitialize)this.rx).EndInit();
			((ISupportInitialize)this.rw).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000162 RID: 354
		public const int px = 16;

		// Token: 0x04000163 RID: 355
		public const uint py = 4U;

		// Token: 0x04000164 RID: 356
		public const uint pz = 0U;

		// Token: 0x04000165 RID: 357
		public const uint pA = 1U;

		// Token: 0x04000166 RID: 358
		public const uint pB = 2U;

		// Token: 0x04000167 RID: 359
		public const uint pC = 3U;

		// Token: 0x04000168 RID: 360
		public const uint pD = 4U;

		// Token: 0x04000169 RID: 361
		public const uint pE = 12U;

		// Token: 0x0400016A RID: 362
		private const int cZ = 512;

		// Token: 0x0400016B RID: 363
		private const int da = 513;

		// Token: 0x0400016C RID: 364
		private const int dd = 514;

		// Token: 0x0400016D RID: 365
		private const int dg = 515;

		// Token: 0x0400016E RID: 366
		private const int db = 516;

		// Token: 0x0400016F RID: 367
		private const int de = 517;

		// Token: 0x04000170 RID: 368
		private const int dh = 518;

		// Token: 0x04000171 RID: 369
		private const int dc = 519;

		// Token: 0x04000172 RID: 370
		private const int df = 520;

		// Token: 0x04000173 RID: 371
		private const int di = 521;

		// Token: 0x04000174 RID: 372
		private const int dj = 522;

		// Token: 0x04000175 RID: 373
		private const int pF = 523;

		// Token: 0x04000176 RID: 374
		private const int pG = 524;

		// Token: 0x04000177 RID: 375
		private const int pH = 525;

		// Token: 0x04000178 RID: 376
		private const int pI = 526;

		// Token: 0x04000179 RID: 377
		private const uint dk = 256U;

		// Token: 0x0400017A RID: 378
		private const uint dl = 257U;

		// Token: 0x0400017B RID: 379
		private const uint pJ = 258U;

		// Token: 0x0400017C RID: 380
		private const int pK = 0;

		// Token: 0x0400017D RID: 381
		private const int pL = 1;

		// Token: 0x0400017E RID: 382
		private const int pM = 2;

		// Token: 0x0400017F RID: 383
		private const int pN = 162;

		// Token: 0x04000180 RID: 384
		private const int pO = 160;

		// Token: 0x04000181 RID: 385
		private const int pP = 164;

		// Token: 0x04000182 RID: 386
		public pw pQ;

		// Token: 0x04000183 RID: 387
		private List<Process> pR = new List<Process>();

		// Token: 0x04000184 RID: 388
		private string pS = "";

		// Token: 0x04000185 RID: 389
		public Image pT;

		// Token: 0x04000186 RID: 390
		public RasConnection pU;

		// Token: 0x04000187 RID: 391
		public RasDialer pV;

		// Token: 0x04000188 RID: 392
		public Thread pW;

		// Token: 0x04000189 RID: 393
		public Thread pX;

		// Token: 0x0400018A RID: 394
		public Thread pY;

		// Token: 0x0400018B RID: 395
		public Thread pZ;

		// Token: 0x0400018C RID: 396
		private bool qa;

		// Token: 0x0400018D RID: 397
		private long qb;

		// Token: 0x0400018E RID: 398
		private string qc = "";

		// Token: 0x0400018F RID: 399
		private bool qd;

		// Token: 0x04000190 RID: 400
		public static IE qe;

		// Token: 0x04000191 RID: 401
		public static Jj qf;

		// Token: 0x04000192 RID: 402
		private static bool qg;

		// Token: 0x04000193 RID: 403
		private static string qh;

		// Token: 0x04000194 RID: 404
		public int qi = 100;

		// Token: 0x04000195 RID: 405
		public SortedList<string, Hs> qj = new SortedList<string, Hs>();

		// Token: 0x04000196 RID: 406
		public SortedList<string, Ii> qk = new SortedList<string, Ii>();

		// Token: 0x04000197 RID: 407
		public SortedList<string, HX> ql = new SortedList<string, HX>();

		// Token: 0x04000198 RID: 408
		private string[] qm;

		// Token: 0x04000199 RID: 409
		private static System.Windows.Forms.Timer qn = new System.Windows.Forms.Timer();

		// Token: 0x0400019A RID: 410
		private cT qo;

		// Token: 0x0400019B RID: 411
		private cT qp;

		// Token: 0x0400019C RID: 412
		private cT qq;

		// Token: 0x0400019D RID: 413
		private cT qr;

		// Token: 0x0400019E RID: 414
		private Process[] qs;

		// Token: 0x0400019F RID: 415
		private Rectangle qt;

		// Token: 0x040001A0 RID: 416
		private Rectangle qu;

		// Token: 0x040001A1 RID: 417
		private Rectangle qv;

		// Token: 0x040001A2 RID: 418
		private Rectangle qw;

		// Token: 0x040001A3 RID: 419
		private Rectangle qx;

		// Token: 0x040001A4 RID: 420
		private bool qy;

		// Token: 0x040001A5 RID: 421
		private int qz;

		// Token: 0x040001A6 RID: 422
		private int qA;

		// Token: 0x040001A7 RID: 423
		private int qB;

		// Token: 0x040001A8 RID: 424
		private int qC;

		// Token: 0x040001A9 RID: 425
		private Form qD;

		// Token: 0x040001AA RID: 426
		private int qE;

		// Token: 0x040001AB RID: 427
		private int qF;

		// Token: 0x040001AC RID: 428
		private bool qG;

		// Token: 0x040001AD RID: 429
		private bool qH;

		// Token: 0x040001AE RID: 430
		private bool qI;

		// Token: 0x040001AF RID: 431
		public float qJ;

		// Token: 0x040001B0 RID: 432
		private MySqlConnection qK;

		// Token: 0x040001B1 RID: 433
		private string qL;

		// Token: 0x040001B2 RID: 434
		private MySqlCommand qM;

		// Token: 0x040001B3 RID: 435
		private bool qN = true;

		// Token: 0x040001B5 RID: 437
		private GroupBox qO;

		// Token: 0x040001B6 RID: 438
		private GroupBox qP;

		// Token: 0x040001B7 RID: 439
		private Button qQ;

		// Token: 0x040001B8 RID: 440
		private Button qR;

		// Token: 0x040001B9 RID: 441
		private Label qS;

		// Token: 0x040001BA RID: 442
		private Label qT;

		// Token: 0x040001BB RID: 443
		private Label qU;

		// Token: 0x040001BC RID: 444
		private MaskedTextBox qV;

		// Token: 0x040001BD RID: 445
		private Label qW;

		// Token: 0x040001BE RID: 446
		private GroupBox qX;

		// Token: 0x040001BF RID: 447
		private CheckedListBox qY;

		// Token: 0x040001C0 RID: 448
		private Button qZ;

		// Token: 0x040001C1 RID: 449
		private NumericUpDown ra;

		// Token: 0x040001C2 RID: 450
		private NumericUpDown rb;

		// Token: 0x040001C3 RID: 451
		private Button rc;

		// Token: 0x040001C4 RID: 452
		private Button rd;

		// Token: 0x040001C5 RID: 453
		private CheckedListBox re;

		// Token: 0x040001C6 RID: 454
		private CheckBox rf;

		// Token: 0x040001C7 RID: 455
		private CheckBox rg;

		// Token: 0x040001C8 RID: 456
		private NumericUpDown rh;

		// Token: 0x040001C9 RID: 457
		private NumericUpDown ri;

		// Token: 0x040001CA RID: 458
		private Button rj;

		// Token: 0x040001CB RID: 459
		private Label rk;

		// Token: 0x040001CC RID: 460
		private Label rl;

		// Token: 0x040001CD RID: 461
		private Label rm;

		// Token: 0x040001CE RID: 462
		private Button rn;

		// Token: 0x040001CF RID: 463
		private Button ro;

		// Token: 0x040001D0 RID: 464
		private Button rp;

		// Token: 0x040001D1 RID: 465
		private Button rq;

		// Token: 0x040001D2 RID: 466
		private Button rr;

		// Token: 0x040001D3 RID: 467
		private PictureBox rs;

		// Token: 0x040001D4 RID: 468
		private PictureBox rt;

		// Token: 0x040001D5 RID: 469
		private PictureBox ru;

		// Token: 0x040001D6 RID: 470
		private Button rv;

		// Token: 0x040001D7 RID: 471
		private PictureBox rw;

		// Token: 0x040001D8 RID: 472
		private PictureBox rx;

		// Token: 0x040001D9 RID: 473
		private Label ry;

		// Token: 0x040001DA RID: 474
		private NumericUpDown rz;

		// Token: 0x040001DB RID: 475
		private Button rA;

		// Token: 0x040001DC RID: 476
		private CheckedListBox rB;

		// Token: 0x040001DD RID: 477
		private Button rC;

		// Token: 0x040001DE RID: 478
		private CheckBox rD;

		// Token: 0x040001DF RID: 479
		private Button rE;

		// Token: 0x040001E0 RID: 480
		private OpenFileDialog rF;

		// Token: 0x040001E1 RID: 481
		private MaskedTextBox rG;

		// Token: 0x040001E2 RID: 482
		private GroupBox rH;

		// Token: 0x040001E3 RID: 483
		private CheckedListBox rI;

		// Token: 0x040001E4 RID: 484
		private CheckBox rJ;

		// Token: 0x040001E5 RID: 485
		private GroupBox rK;

		// Token: 0x040001E6 RID: 486
		private NumericUpDown rL;

		// Token: 0x040001E7 RID: 487
		private GroupBox rM;

		// Token: 0x040001E8 RID: 488
		private Label rN;

		// Token: 0x040001E9 RID: 489
		private MaskedTextBox rO;

		// Token: 0x040001EA RID: 490
		private Label rP;

		// Token: 0x040001EB RID: 491
		private CheckBox rQ;

		// Token: 0x040001EC RID: 492
		private MaskedTextBox rR;

		// Token: 0x040001ED RID: 493
		private Button rS;

		// Token: 0x040001EE RID: 494
		private CheckBox rT;

		// Token: 0x040001EF RID: 495
		private CheckBox rU;

		// Token: 0x040001F0 RID: 496
		private ListView rV;

		// Token: 0x040001F1 RID: 497
		private Button rW;

		// Token: 0x040001F2 RID: 498
		private GroupBox rX;

		// Token: 0x040001F3 RID: 499
		private MaskedTextBox rY;

		// Token: 0x040001F4 RID: 500
		private PictureBox rZ;

		// Token: 0x040001F5 RID: 501
		private GroupBox sa;

		// Token: 0x040001F6 RID: 502
		private ListBox sb;

		// Token: 0x040001F7 RID: 503
		private Button sc;

		// Token: 0x040001F8 RID: 504
		private GroupBox sd;

		// Token: 0x040001F9 RID: 505
		private GroupBox se;

		// Token: 0x040001FA RID: 506
		private ComboBox sf;

		// Token: 0x040001FB RID: 507
		private TextBox sg;

		// Token: 0x040001FC RID: 508
		private CheckBox sh;

		// Token: 0x040001FD RID: 509
		private CheckedListBox si;

		// Token: 0x040001FE RID: 510
		private Label sj;

		// Token: 0x040001FF RID: 511
		private Button sk;

		// Token: 0x04000200 RID: 512
		private Button sl;

		// Token: 0x04000201 RID: 513
		private Label sm;

		// Token: 0x04000202 RID: 514
		private Label sn;

		// Token: 0x04000203 RID: 515
		private NumericUpDown so;

		// Token: 0x04000204 RID: 516
		private Label sp;

		// Token: 0x04000205 RID: 517
		private NumericUpDown sq;

		// Token: 0x04000206 RID: 518
		private Label sr;

		// Token: 0x04000207 RID: 519
		private NumericUpDown ss;

		// Token: 0x04000208 RID: 520
		private PictureBox st;

		// Token: 0x04000209 RID: 521
		private PictureBox su;

		// Token: 0x0400020A RID: 522
		private Button sv;

		// Token: 0x0400020B RID: 523
		public ListBox sw;

		// Token: 0x0400020C RID: 524
		private PictureBox sx;

		// Token: 0x0400020D RID: 525
		private Label sy;

		// Token: 0x0400020E RID: 526
		private MaskedTextBox sz;

		// Token: 0x0400020F RID: 527
		private Button sA;

		// Token: 0x04000210 RID: 528
		private CheckBox sB;

		// Token: 0x04000211 RID: 529
		private TrackBar sC;

		// Token: 0x04000212 RID: 530
		private Button sD;

		// Token: 0x04000213 RID: 531
		private Button sE;

		// Token: 0x04000214 RID: 532
		private Button sF;

		// Token: 0x04000215 RID: 533
		private Button sG;

		// Token: 0x04000216 RID: 534
		private PictureBox sH;

		// Token: 0x04000217 RID: 535
		private PictureBox sI;

		// Token: 0x04000218 RID: 536
		private Button sJ;

		// Token: 0x04000219 RID: 537
		private Button sK;

		// Token: 0x0400021A RID: 538
		private Button sL;

		// Token: 0x0400021B RID: 539
		private Button sM;

		// Token: 0x0400021C RID: 540
		private ComboBox sN;

		// Token: 0x0400021D RID: 541
		private BackgroundWorker sO;

		// Token: 0x0400021E RID: 542
		private Label sP;

		// Token: 0x0400021F RID: 543
		private Button sQ;

		// Token: 0x04000220 RID: 544
		private CheckBox sR;

		// Token: 0x04000221 RID: 545
		private Label sS;

		// Token: 0x04000222 RID: 546
		private ComboBox sT;

		// Token: 0x04000223 RID: 547
		private CheckBox sU;

		// Token: 0x04000224 RID: 548
		private TabControl sV;

		// Token: 0x04000225 RID: 549
		private TabPage sW;

		// Token: 0x04000226 RID: 550
		private TabPage sX;

		// Token: 0x04000227 RID: 551
		private Button sY;

		// Token: 0x04000228 RID: 552
		private Button sZ;

		// Token: 0x04000229 RID: 553
		private Button ta;

		// Token: 0x0400022A RID: 554
		private GroupBox tb;

		// Token: 0x0400022B RID: 555
		private TextBox tc;

		// Token: 0x0400022C RID: 556
		private PictureBox td;

		// Token: 0x0400022D RID: 557
		private Button te;

		// Token: 0x0400022E RID: 558
		private ni tf;

		// Token: 0x0400022F RID: 559
		private TabPage tg;

		// Token: 0x04000230 RID: 560
		private TabPage th;

		// Token: 0x04000231 RID: 561
		private TabPage ti;

		// Token: 0x04000232 RID: 562
		private TabPage tj;

		// Token: 0x04000233 RID: 563
		private TabPage tk;

		// Token: 0x04000234 RID: 564
		private TabPage tl;

		// Token: 0x04000235 RID: 565
		private TabPage tm;

		// Token: 0x04000236 RID: 566
		private TabPage tn;

		// Token: 0x04000237 RID: 567
		private TabPage to;

		// Token: 0x04000238 RID: 568
		private MaskedTextBox tp;

		// Token: 0x04000239 RID: 569
		private MaskedTextBox tq;

		// Token: 0x0400023A RID: 570
		private MaskedTextBox tr;

		// Token: 0x0400023B RID: 571
		private CheckBox ts;

		// Token: 0x0400023C RID: 572
		private CheckBox tt;

		// Token: 0x0400023D RID: 573
		private CheckBox tu;

		// Token: 0x0400023E RID: 574
		private CheckBox tv;

		// Token: 0x0400023F RID: 575
		private CheckBox tw;

		// Token: 0x04000240 RID: 576
		private CheckBox tx;

		// Token: 0x04000241 RID: 577
		private Button ty;

		// Token: 0x04000242 RID: 578
		private ToolTip tz;

		// Token: 0x04000243 RID: 579
		private Button tA;

		// Token: 0x04000244 RID: 580
		private Label tB;

		// Token: 0x04000245 RID: 581
		private Label tC;

		// Token: 0x04000246 RID: 582
		private Label tD;

		// Token: 0x04000247 RID: 583
		private Label tE;

		// Token: 0x04000248 RID: 584
		private Label tF;

		// Token: 0x04000249 RID: 585
		private Label tG;

		// Token: 0x0400024A RID: 586
		private TrackBar tH;

		// Token: 0x0400024B RID: 587
		private TabControl tI;

		// Token: 0x0400024C RID: 588
		private TabPage tJ;

		// Token: 0x0400024D RID: 589
		private TabPage tK;

		// Token: 0x0400024E RID: 590
		private GroupBox tL;

		// Token: 0x0400024F RID: 591
		private BunifuTileButton tM;

		// Token: 0x04000250 RID: 592
		private BunifuFlatButton oO;

		// Token: 0x04000251 RID: 593
		private jy tN;

		// Token: 0x04000252 RID: 594
		private kr tO;

		// Token: 0x04000253 RID: 595
		private GroupBox tP;

		// Token: 0x04000254 RID: 596
		private BunifuFlatButton tQ;

		// Token: 0x04000255 RID: 597
		private jy tR;

		// Token: 0x04000256 RID: 598
		private CheckedListBox tS;

		// Token: 0x04000257 RID: 599
		private CheckBox tT;

		// Token: 0x04000258 RID: 600
		private BunifuFlatButton tU;

		// Token: 0x04000259 RID: 601
		private CheckBox tV;

		// Token: 0x0400025A RID: 602
		private Label tW;

		// Token: 0x0400025B RID: 603
		private NumericUpDown tX;

		// Token: 0x0400025C RID: 604
		private BunifuThinButton2 tY;

		// Token: 0x0400025D RID: 605
		private CheckBox tZ;

		// Token: 0x0400025E RID: 606
		private BunifuThinButton2 ua;

		// Token: 0x0400025F RID: 607
		private BunifuThinButton2 ub;

		// Token: 0x04000260 RID: 608
		private TabPage uc;

		// Token: 0x04000261 RID: 609
		private Button ud;

		// Token: 0x04000262 RID: 610
		private TextBox ue;

		// Token: 0x04000263 RID: 611
		private Button uf;

		// Token: 0x04000264 RID: 612
		private Label ug;

		// Token: 0x04000265 RID: 613
		private Label uh;

		// Token: 0x04000266 RID: 614
		private DataGridView ui;

		// Token: 0x04000267 RID: 615
		private Label uj;

		// Token: 0x04000268 RID: 616
		private Label uk;

		// Token: 0x04000269 RID: 617
		private DataGridViewTextBoxColumn ul;

		// Token: 0x0400026A RID: 618
		private DataGridViewTextBoxColumn um;

		// Token: 0x0400026B RID: 619
		private Label un;

		// Token: 0x0400026C RID: 620
		private BunifuThinButton2 uo;

		// Token: 0x0400026D RID: 621
		private Label up;

		// Token: 0x0400026E RID: 622
		private ComboBox uq;

		// Token: 0x0400026F RID: 623
		private CheckedListBox ur;

		// Token: 0x04000270 RID: 624
		private Panel us;

		// Token: 0x04000271 RID: 625
		private Panel ut;

		// Token: 0x04000272 RID: 626
		private Panel uu;

		// Token: 0x04000273 RID: 627
		private Label uv;

		// Token: 0x04000274 RID: 628
		private Label uw;

		// Token: 0x04000275 RID: 629
		private Label ux;

		// Token: 0x04000276 RID: 630
		private Label uy;

		// Token: 0x04000277 RID: 631
		private ComboBox uz;

		// Token: 0x04000278 RID: 632
		private Label uA;

		// Token: 0x02000055 RID: 85
		private struct NW
		{
			// Token: 0x04000279 RID: 633
			public int Nz;

			// Token: 0x0400027A RID: 634
			public int NX;

			// Token: 0x0400027B RID: 635
			public int NA;

			// Token: 0x0400027C RID: 636
			public int NY;
		}

		// Token: 0x02000056 RID: 86
		private struct NZ
		{
			// Token: 0x0400027D RID: 637
			public uint Oa;

			// Token: 0x0400027E RID: 638
			public IntPtr Ni;

			// Token: 0x0400027F RID: 639
			public uint Ob;

			// Token: 0x04000280 RID: 640
			public uint Oc;

			// Token: 0x04000281 RID: 641
			public uint Od;
		}

		// Token: 0x02000057 RID: 87
		private class Oe
		{
			// Token: 0x02000058 RID: 88
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct OY
			{
				// Token: 0x04000282 RID: 642
				public int OZ;

				// Token: 0x04000283 RID: 643
				public byte Pa;

				// Token: 0x04000284 RID: 644
				public byte Pb;

				// Token: 0x04000285 RID: 645
				public ushort Pc;

				// Token: 0x04000286 RID: 646
				public int Pd;

				// Token: 0x04000287 RID: 647
				public uint Pe;
			}

			// Token: 0x02000059 RID: 89
			public struct Pf
			{
				// Token: 0x04000288 RID: 648
				public int Pg;

				// Token: 0x04000289 RID: 649
				public int Pe;

				// Token: 0x0400028A RID: 650
				public int Ph;

				// Token: 0x0400028B RID: 651
				public int Pi;

				// Token: 0x0400028C RID: 652
				public int Pj;

				// Token: 0x0400028D RID: 653
				public int Pk;

				// Token: 0x0400028E RID: 654
				public int Pl;

				// Token: 0x0400028F RID: 655
				public int Pm;

				// Token: 0x04000290 RID: 656
				public int Pn;

				// Token: 0x04000291 RID: 657
				public int Po;

				// Token: 0x04000292 RID: 658
				public int Pp;

				// Token: 0x04000293 RID: 659
				public int Pq;

				// Token: 0x04000294 RID: 660
				public System.Runtime.InteropServices.ComTypes.FILETIME Pr;
			}

			// Token: 0x0200005A RID: 90
			public struct Ps
			{
				// Token: 0x04000295 RID: 661
				public pw.Oe.Pu Pt;
			}

			// Token: 0x0200005B RID: 91
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct Pu
			{
				// Token: 0x04000296 RID: 662
				public ushort Pv;

				// Token: 0x04000297 RID: 663
				public ushort Pw;

				// Token: 0x04000298 RID: 664
				public IntPtr Px;
			}
		}

		// Token: 0x0200005C RID: 92
		internal static class Of
		{
			// Token: 0x06000374 RID: 884
			[DllImport("GDLL.dll")]
			public static extern void NewWindow();

			// Token: 0x04000299 RID: 665
			private const string Og = "GDLL.dll";
		}

		// Token: 0x0200005D RID: 93
		public enum Op
		{
			// Token: 0x0400029B RID: 667
			Oq = 10,
			// Token: 0x0400029C RID: 668
			Or = 117
		}

		// Token: 0x0200005E RID: 94
		[Flags]
		public enum Os : uint
		{
			// Token: 0x0400029E RID: 670
			Ot = 2035711U,
			// Token: 0x0400029F RID: 671
			Ou = 1U,
			// Token: 0x040002A0 RID: 672
			Ov = 2U,
			// Token: 0x040002A1 RID: 673
			Ow = 8U,
			// Token: 0x040002A2 RID: 674
			Ox = 16U,
			// Token: 0x040002A3 RID: 675
			Oy = 32U,
			// Token: 0x040002A4 RID: 676
			Oz = 64U,
			// Token: 0x040002A5 RID: 677
			OA = 128U,
			// Token: 0x040002A6 RID: 678
			OB = 256U,
			// Token: 0x040002A7 RID: 679
			OC = 512U,
			// Token: 0x040002A8 RID: 680
			OD = 1024U,
			// Token: 0x040002A9 RID: 681
			OE = 4096U,
			// Token: 0x040002AA RID: 682
			OF = 1048576U
		}
	}
}
