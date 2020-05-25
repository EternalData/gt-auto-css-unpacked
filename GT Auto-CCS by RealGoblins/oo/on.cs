using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace oo
{
	// Token: 0x0200004E RID: 78
	public class on
	{
		// Token: 0x06000255 RID: 597 RVA: 0x0000E760 File Offset: 0x0000C960
		public static string oq()
		{
			if (string.IsNullOrEmpty(on.op))
			{
				on.op = on.or(string.Concat(new string[]
				{
					"CPU >> ",
					on.oB(),
					"\nBIOS >> ",
					on.oC(),
					"\nBASE >> ",
					on.oE()
				}));
			}
			return on.op;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		private static string or(string os)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] bytes = new ASCIIEncoding().GetBytes(os);
			return on.ot(hashAlgorithm.ComputeHash(bytes));
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		private static string ot(byte[] ou)
		{
			string text = string.Empty;
			for (int i = 0; i < ou.Length; i++)
			{
				byte b = ou[i];
				int num = (int)(b & 15);
				int num2 = b >> 4 & 15;
				if (num2 > 9)
				{
					text += ((char)(num2 - 10 + 65)).ToString();
				}
				else
				{
					text += num2.ToString();
				}
				if (num > 9)
				{
					text += ((char)(num - 10 + 65)).ToString();
				}
				else
				{
					text += num.ToString();
				}
				if (i + 1 != ou.Length && (i + 1) % 2 == 0)
				{
					text += "-";
				}
			}
			return text;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000E89C File Offset: 0x0000CA9C
		private static string ov(string ow, string ox, string oy)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(ow).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject[oy].ToString() == "True" && text == "")
				{
					try
					{
						text = managementObject[ox].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000E938 File Offset: 0x0000CB38
		private static string ov(string oz, string oA)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(oz).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == "")
				{
					try
					{
						text = managementObject[oA].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000E9BC File Offset: 0x0000CBBC
		private static string oB()
		{
			string text = on.ov("Win32_Processor", "UniqueId");
			if (text == "")
			{
				text = on.ov("Win32_Processor", "ProcessorId");
				if (text == "")
				{
					text = on.ov("Win32_Processor", "Name");
					if (text == "")
					{
						text = on.ov("Win32_Processor", "Manufacturer");
					}
					text += on.ov("Win32_Processor", "MaxClockSpeed");
				}
			}
			return text;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000EA48 File Offset: 0x0000CC48
		private static string oC()
		{
			return string.Concat(new string[]
			{
				on.ov("Win32_BIOS", "Manufacturer"),
				on.ov("Win32_BIOS", "SMBIOSBIOSVersion"),
				on.ov("Win32_BIOS", "IdentificationCode"),
				on.ov("Win32_BIOS", "SerialNumber"),
				on.ov("Win32_BIOS", "ReleaseDate"),
				on.ov("Win32_BIOS", "Version")
			});
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000EACC File Offset: 0x0000CCCC
		private static string oD()
		{
			return on.ov("Win32_DiskDrive", "Model") + on.ov("Win32_DiskDrive", "Manufacturer") + on.ov("Win32_DiskDrive", "Signature") + on.ov("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000EB1C File Offset: 0x0000CD1C
		private static string oE()
		{
			return on.ov("Win32_BaseBoard", "Model") + on.ov("Win32_BaseBoard", "Manufacturer") + on.ov("Win32_BaseBoard", "Name") + on.ov("Win32_BaseBoard", "SerialNumber");
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		private static string oF()
		{
			return on.ov("Win32_VideoController", "DriverVersion") + on.ov("Win32_VideoController", "Name");
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000EB94 File Offset: 0x0000CD94
		private static string oG()
		{
			return on.ov("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		// Token: 0x0400014C RID: 332
		private static string op = string.Empty;
	}
}
