using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x02000086 RID: 134
	[DefaultMember("FullName")]
	[CompilerGenerated]
	[ComImport]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	public interface IWshShortcut
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000476 RID: 1142
		[IndexerName("FullName")]
		[DispId(0)]
		string FullName { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(0)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000477 RID: 1143
		void _VtblGap1_2();

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000478 RID: 1144
		// (set) Token: 0x06000479 RID: 1145
		[DispId(1001)]
		string Description { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1001)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1001)] [param: In] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600047A RID: 1146
		// (set) Token: 0x0600047B RID: 1147
		[DispId(1002)]
		string Hotkey { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1002)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1002)] [param: In] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x0600047C RID: 1148
		void _VtblGap2_3();

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600047D RID: 1149
		// (set) Token: 0x0600047E RID: 1150
		[DispId(1005)]
		string TargetPath { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1005)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [DispId(1005)] [param: In] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x0600047F RID: 1151
		void _VtblGap3_5();

		// Token: 0x06000480 RID: 1152
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2001)]
		void Save();
	}
}
