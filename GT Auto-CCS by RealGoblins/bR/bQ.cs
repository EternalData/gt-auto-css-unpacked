using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using cG;
using Microsoft.Win32;
using pq;

namespace bR
{
	// Token: 0x02000010 RID: 16
	public static class bQ
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003E04 File Offset: 0x00002004
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00003E0C File Offset: 0x0000200C
		private static string ca { get; set; }

		// Token: 0x0600005D RID: 93 RVA: 0x00003E14 File Offset: 0x00002014
		public static void cb(pw cc)
		{
			bQ.bS = cc;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003E1C File Offset: 0x0000201C
		private static void cd()
		{
			string item = "Growtopia Unbanner " + Environment.UserName + ":->";
			bQ.bS.sw.Items.Add(item);
			Application.DoEvents();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003E5C File Offset: 0x0000205C
		public static string ce()
		{
			return "https://paste";
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003E64 File Offset: 0x00002064
		private static void cf(string[] cg)
		{
			Console.Title = "RAID";
			Console.ForegroundColor = ConsoleColor.DarkRed;
			bQ.bS.sw.Items.Add("Enter。");
			Application.DoEvents();
			Console.ForegroundColor = ConsoleColor.Red;
			string str = Console.ReadLine();
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			bQ.bS.sw.Items.Add("こんにちは " + str + "! へようこそ");
			Application.DoEvents();
			Console.ForegroundColor = ConsoleColor.Cyan;
			bQ.cd();
			bool flag = true;
			while (flag)
			{
				string a = Console.ReadLine();
				if (!(a == "unban"))
				{
					if (!(a == "connect"))
					{
						bQ.bS.sw.Items.Add("<------------------------->");
						bQ.bS.sw.Items.Add("Type ---->>>>  unban ");
						bQ.bS.sw.Items.Add("<------------------------->");
						Application.DoEvents();
						bQ.cd();
					}
				}
				else
				{
					bQ.ch();
					bQ.cd();
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003F80 File Offset: 0x00002180
		public static void ch()
		{
			bQ.bS.sw.Items.Add("unbanning...");
			Application.DoEvents();
			Application.DoEvents();
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat");
				bQ.bS.sw.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Application.DoEvents();
				bQ.bS.sw.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\log.txt");
				bQ.bS.sw.Items.Add("Log.txt deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				bQ.bS.sw.Items.Add("log.txt deleted");
				Application.DoEvents();
			}
			try
			{
				bQ.ct();
				bQ.cv();
				bQ.bS.sw.Items.Add(bQ.bU + "deleted");
				Application.DoEvents();
			}
			catch
			{
				bQ.bS.sw.Items.Add("Couldn't delete HKEY_CURRENT_USER");
				Application.DoEvents();
			}
			Console.ForegroundColor = ConsoleColor.Magenta;
			try
			{
				bQ.cs();
				bQ.cu();
				bQ.bS.sw.Items.Add("Deleted " + bQ.bV);
				Application.DoEvents();
			}
			catch
			{
				bQ.bS.sw.Items.Add("Couldn't delete HKEY_CURRENT_USER \\ Software \\ Microsoft");
				Application.DoEvents();
			}
			try
			{
				bQ.cA();
				bQ.cB();
				bQ.cw();
				List<string> list = new List<string>();
				foreach (NetworkInterface networkInterface in from a in NetworkInterface.GetAllNetworkInterfaces()
				where bQ.cj(a.GetPhysicalAddress().GetAddressBytes(), true)
				orderby a.Speed descending
				select a)
				{
					list.Add(networkInterface.Name);
				}
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.ForegroundColor = ConsoleColor.Red;
				foreach (string cE in list)
				{
					bQ.cC(false, cE);
				}
				bQ.bS.sw.Items.Add("Restarting all active connections..." + Environment.NewLine);
				Thread.Sleep(1000);
				foreach (string cE2 in list)
				{
					bQ.cC(true, cE2);
				}
				Console.ForegroundColor = ConsoleColor.Green;
				bQ.bS.sw.Items.Add("Active connection" + Environment.NewLine);
				try
				{
					if (File.Exists("config.txt"))
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("VPN..." + Environment.NewLine);
						Process.Start(File.ReadAllText("config.txt"));
					}
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("config.txt error" + Environment.NewLine);
				}
			}
			catch (Exception ex)
			{
				bQ.bS.sw.Items.Add("Error: " + ex.Message);
				Application.DoEvents();
			}
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.Cyan;
			bQ.bS.sw.Items.Add("Done！");
			Application.DoEvents();
			bQ.ca = null;
			bQ.bV = null;
			bQ.bU = null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004440 File Offset: 0x00002640
		public static void ci()
		{
			bQ.bS.sw.Items.Add("unbanning...");
			Application.DoEvents();
			Application.DoEvents();
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat");
				bQ.bS.sw.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Application.DoEvents();
				bQ.bS.sw.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\log.txt");
				bQ.bS.sw.Items.Add("Log.txt deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				bQ.bS.sw.Items.Add("log.txt deleted");
				Application.DoEvents();
			}
			try
			{
				bQ.ct();
				bQ.cv();
				bQ.bS.sw.Items.Add(bQ.bU + "deleted");
				Application.DoEvents();
			}
			catch
			{
				bQ.bS.sw.Items.Add("Couldn't delete HKEY_CURRENT_USER");
				Application.DoEvents();
			}
			Console.ForegroundColor = ConsoleColor.Magenta;
			try
			{
				bQ.cs();
				bQ.cu();
				bQ.bS.sw.Items.Add("Deleted " + bQ.bV);
				Application.DoEvents();
			}
			catch
			{
				bQ.bS.sw.Items.Add("Couldn't delete HKEY_CURRENT_USER \\ Software \\ Microsoft");
				Application.DoEvents();
			}
			try
			{
				bQ.cA();
				bQ.cB();
			}
			catch (Exception ex)
			{
				bQ.bS.sw.Items.Add("Error: " + ex.Message);
				Application.DoEvents();
			}
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.Cyan;
			bQ.bS.sw.Items.Add("Registry Done！");
			Application.DoEvents();
			bQ.ca = null;
			bQ.bV = null;
			bQ.bU = null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000046B4 File Offset: 0x000028B4
		private static bool cj(string ck, bool cl)
		{
			bool result;
			if (ck.Length != 12)
			{
				result = false;
			}
			else if (ck != ck.ToUpper())
			{
				result = false;
			}
			else if (!Regex.IsMatch(ck, "^[0-9A-F]*$"))
			{
				result = false;
			}
			else if (cl)
			{
				result = true;
			}
			else
			{
				char c = ck[1];
				result = (c == '2' || c == '6' || c == 'A' || c == 'E');
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004724 File Offset: 0x00002924
		private static string cm(int cn)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", cn)
			select s[bQ.bW.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004760 File Offset: 0x00002960
		private static bool cj(byte[] co, bool cp)
		{
			return bQ.cj(bQ.cq(co), cp);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004770 File Offset: 0x00002970
		private static string cq(byte[] cr)
		{
			return BitConverter.ToString(cr).Replace("-", "").ToUpper();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000478C File Offset: 0x0000298C
		private static string cs()
		{
			string result;
			try
			{
				string[] subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft", true).GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 5)
					{
						bQ.bV = text;
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 5)
					{
						bQ.bS.sw.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
						Application.DoEvents();
					}
				}
				result = bQ.bV;
			}
			catch
			{
				bQ.bS.sw.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004858 File Offset: 0x00002A58
		private static string ct()
		{
			string result;
			try
			{
				string[] subKeyNames = Registry.CurrentUser.GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 9)
					{
						bQ.bU = text;
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 9)
					{
						bQ.bS.sw.Items.Add("HKEY_CURRENT_USER No keys found!");
						Application.DoEvents();
					}
				}
				result = bQ.bU;
			}
			catch
			{
				bQ.bS.sw.Items.Add("HKEY_CURRENT_USER No keys found!");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000491C File Offset: 0x00002B1C
		private static void cu()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser;
				registryKey = registryKey.OpenSubKey("Software\\Microsoft", true);
				string[] subKeyNames = registryKey.GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 5)
					{
						registryKey.DeleteSubKey(text);
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 5)
					{
						bQ.bS.sw.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				bQ.bS.sw.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
				Application.DoEvents();
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000049E0 File Offset: 0x00002BE0
		private static void cv()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				string[] subKeyNames = currentUser.GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 9)
					{
						currentUser.DeleteSubKey(text);
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 9)
					{
						bQ.bS.sw.Items.Add("HKEY_CURRENT_USER");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				bQ.bS.sw.Items.Add("HKEY_CURRENT_USER");
				Application.DoEvents();
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004A9C File Offset: 0x00002C9C
		public static void cw()
		{
			/*
An exception occurred when decompiling this method (0600006B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void bR.bQ::cw()
 ---> System.Exception: Inconsistent stack size at IL_2C3
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004E14 File Offset: 0x00003014
		public static string cx()
		{
			Random random = new Random();
			byte[] array = new byte[6];
			random.NextBytes(array);
			return string.Concat((from x in array
			select string.Format("{0}:", x.ToString("X2"))).ToArray<string>()).TrimEnd(new char[]
			{
				':'
			}).Replace(":", "");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004E84 File Offset: 0x00003084
		private static string cy()
		{
			string result;
			try
			{
				List<string> list = cF.cS.Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				int index = new Random().Next(0, list.Count);
				string str = list[index].Split(new char[]
				{
					','
				})[0];
				Random random = new Random();
				byte[] array = new byte[3];
				random.NextBytes(array);
				string str2 = string.Concat(array.Select(delegate(byte x)
				{
					string format = "{0}:";
					byte b = x;
					return string.Format(format, b.ToString("X2"));
				}).ToArray<string>());
				result = (str + ":" + str2).Replace(":", "");
			}
			catch
			{
				bQ.bS.sw.Items.Add("Mac-address gen failed to generate a new mac");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004F78 File Offset: 0x00003178
		private static string cz()
		{
			string result;
			try
			{
				List<string> list = cF.cS.Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				int index = new Random().Next(0, 12686);
				string str = list[index].Split(new char[]
				{
					','
				})[0];
				Random random = new Random();
				byte[] array = new byte[3];
				random.NextBytes(array);
				string str2 = string.Concat(array.Select(delegate(byte x)
				{
					string format = "{0}:";
					byte b = x;
					return string.Format(format, b.ToString("X2"));
				}).ToArray<string>());
				result = (str + ":" + str2).Replace(":", "");
			}
			catch
			{
				bQ.bS.sw.Items.Add("Mac-address");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005064 File Offset: 0x00003264
		private static void cA()
		{
			try
			{
				bool is64BitOperatingSystem;
				if (is64BitOperatingSystem = Environment.Is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					bQ.bS.sw.Items.Add("OS is running on 64 bit!");
					Application.DoEvents();
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey = registryKey.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Cryptography", true);
					if (registryKey != null)
					{
						registryKey.DeleteValue("MachineGuid");
						Process process = Process.Start(new ProcessStartInfo("regedit")
						{
							RedirectStandardError = false,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							CreateNoWindow = true,
							Verb = "run as"
						});
						Thread.Sleep(50);
						process.Kill();
						Console.ForegroundColor = ConsoleColor.Green;
						bQ.bS.sw.Items.Add("MachineGUID successfully changed!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						bQ.bS.sw.Items.Add("Cannot be changed!");
					}
				}
				else if (!is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					bQ.bS.sw.Items.Add("OS is running on 32bit!");
					Application.DoEvents();
					Guid.NewGuid().ToString();
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
					registryKey2 = registryKey2.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Cryptography", true);
					if (registryKey2 != null)
					{
						registryKey2.DeleteValue("MachineGuid");
						Process process2 = Process.Start(new ProcessStartInfo("regedit")
						{
							RedirectStandardError = false,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							CreateNoWindow = true,
							Verb = "run as"
						});
						Thread.Sleep(50);
						process2.Kill();
						Console.ForegroundColor = ConsoleColor.Green;
						bQ.bS.sw.Items.Add("Successfully Changed MachineGUID!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						bQ.bS.sw.Items.Add("Unable to modify!");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				bQ.bS.sw.Items.Add("Access Denied on Modifying MachineGuid!");
				Application.DoEvents();
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000052AC File Offset: 0x000034AC
		private static void cB()
		{
			try
			{
				bool is64BitOperatingSystem;
				if (is64BitOperatingSystem = Environment.Is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey = registryKey.OpenSubKey("SYSTEM\\\\CurrentControlSet\\\\Services\\\\Tcpip\\\\Parameters", true);
					if (registryKey != null)
					{
						try
						{
							registryKey.DeleteValue("Hostname");
						}
						catch
						{
						}
						registryKey.SetValue("Hostname", "zXaAwBaF");
						Console.ForegroundColor = ConsoleColor.Green;
						bQ.bS.sw.Items.Add("Successfully Changed Hostname!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						bQ.bS.sw.Items.Add("Unable to modify!");
						Application.DoEvents();
					}
				}
				else if (!is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Guid.NewGuid().ToString();
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
					registryKey2 = registryKey2.OpenSubKey("SYSTEM\\\\CurrentControlSet\\\\Services\\\\Tcpip\\\\Parameters", true);
					if (registryKey2 != null)
					{
						try
						{
							registryKey2.DeleteValue("Hostname");
						}
						catch
						{
						}
						registryKey2.SetValue("Hostname", "i11KfH1p");
						Console.ForegroundColor = ConsoleColor.Green;
						bQ.bS.sw.Items.Add("Successfully Changed Hostname!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						bQ.bS.sw.Items.Add("Unable to modify!");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				bQ.bS.sw.Items.Add("Access Denied on Modifying MachineGuid!");
				Application.DoEvents();
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005494 File Offset: 0x00003694
		private static void cC(bool cD, string cE)
		{
			try
			{
				string str;
				if (cD)
				{
					str = "enable";
				}
				else
				{
					str = "disable";
				}
				ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + cE + "\" " + str)
				{
					RedirectStandardError = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true,
					Verb = "run as"
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				process.Start();
				process.WaitForExit();
			}
			catch
			{
				bQ.bS.sw.Items.Add("Failed to Disable/Enable the connection");
				Application.DoEvents();
			}
		}

		// Token: 0x04000049 RID: 73
		private static pw bS;

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		private static string bT;

		// Token: 0x0400004B RID: 75
		private static string bU;

		// Token: 0x0400004C RID: 76
		private static string bV;

		// Token: 0x0400004D RID: 77
		private static Random bW = new Random();
	}
}
