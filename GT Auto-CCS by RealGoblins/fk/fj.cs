using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace fk
{
	// Token: 0x0200001A RID: 26
	public class fj
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00006148 File Offset: 0x00004348
		public fj(ManagementObject a, string aname, string cname, int n)
		{
			this.fl = a;
			this.fm = aname;
			this.fn = cname;
			this.fo = n;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006170 File Offset: 0x00004370
		public fj(NetworkInterface i) : this(i.Description)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006180 File Offset: 0x00004380
		public fj(string aname)
		{
			this.fm = aname;
			ManagementObjectCollection source = new ManagementObjectSearcher("select * from win32_networkadapter where Name='" + this.fm + "'").Get();
			this.fl = source.Cast<ManagementObject>().FirstOrDefault<ManagementObject>();
			try
			{
				Match match = Regex.Match(this.fl.Path.RelativePath, "\\\"(\\d+)\\\"$");
				this.fo = int.Parse(match.Groups[1].Value);
			}
			catch
			{
				return;
			}
			this.fn = (from i in NetworkInterface.GetAllNetworkInterfaces()
			where i.Description == this.fm
			select " (" + i.Name + ")").FirstOrDefault<string>();
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000625C File Offset: 0x0000445C
		public NetworkInterface fq
		{
			get
			{
				return (from nic in NetworkInterface.GetAllNetworkInterfaces()
				where nic.Description == this.fm
				select nic).FirstOrDefault<NetworkInterface>();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000627C File Offset: 0x0000447C
		public string fs
		{
			get
			{
				string result;
				try
				{
					result = BitConverter.ToString(this.fq.GetPhysicalAddress().GetAddressBytes()).Replace("-", "").ToUpper();
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000062CC File Offset: 0x000044CC
		public string fu
		{
			get
			{
				return string.Format("SYSTEM\\ControlSet001\\Control\\Class\\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\\{0:D4}", this.fo);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000062E4 File Offset: 0x000044E4
		public string fw
		{
			get
			{
				string result;
				try
				{
					using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.fu, false))
					{
						result = registryKey.GetValue("NetworkAddress").ToString();
					}
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006344 File Offset: 0x00004544
		public bool fx(string fy)
		{
			bool flag = false;
			bool result;
			try
			{
				if (fy.Length > 0 && !fj.cj(fy, false))
				{
					throw new Exception(fy + " is not a valid mac address");
				}
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.fu, true))
				{
					if (registryKey == null)
					{
						throw new Exception("Failed to open the registry key");
					}
					if (registryKey.GetValue("AdapterModel") as string != this.fm && registryKey.GetValue("DriverDesc") as string != this.fm)
					{
						throw new Exception("Adapter not found in registry");
					}
					if (MessageBox.Show(string.Format((fy.Length > 0) ? "Changing MAC-adress of adapter {0} from {1} to {2}. Proceed?" : "Clearing custom MAC-address of adapter {0}. Proceed?", this.ToString(), this.fs, fy), "Change MAC-address?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						result = false;
					}
					else
					{
						if ((uint)this.fl.InvokeMethod("Disable", null) != 0U)
						{
							throw new Exception("Failed to disable network adapter.");
						}
						flag = true;
						if (fy.Length > 0)
						{
							registryKey.SetValue("NetworkAddress", fy, RegistryValueKind.String);
						}
						else
						{
							registryKey.DeleteValue("NetworkAddress");
						}
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				result = false;
			}
			finally
			{
				if (flag && (uint)this.fl.InvokeMethod("Enable", null) != 0U)
				{
					MessageBox.Show("Failed to re-enable network adapter.");
				}
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000064F4 File Offset: 0x000046F4
		public override string ToString()
		{
			return this.fm + this.fn;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006508 File Offset: 0x00004708
		public static string fz()
		{
			Random random = new Random();
			byte[] array = new byte[6];
			random.NextBytes(array);
			array[0] = (array[0] | 2);
			array[0] = (array[0] & 254);
			return fj.cq(array);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006544 File Offset: 0x00004744
		public static bool cj(string fA, bool fB)
		{
			if (fA.Length != 12)
			{
				return false;
			}
			if (fA != fA.ToUpper())
			{
				return false;
			}
			if (!Regex.IsMatch(fA, "^[0-9A-F]*$"))
			{
				return false;
			}
			if (fB)
			{
				return true;
			}
			char c = fA[1];
			return c == '2' || c == '6' || c == 'A' || c == 'E';
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000065A0 File Offset: 0x000047A0
		public static bool cj(byte[] fC, bool fD)
		{
			return fj.cj(fj.cq(fC), fD);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000065B0 File Offset: 0x000047B0
		public static string cq(byte[] fE)
		{
			return BitConverter.ToString(fE).Replace("-", "").ToUpper();
		}

		// Token: 0x04000093 RID: 147
		public ManagementObject fl;

		// Token: 0x04000094 RID: 148
		public string fm;

		// Token: 0x04000095 RID: 149
		public string fn;

		// Token: 0x04000096 RID: 150
		public int fo;
	}
}
