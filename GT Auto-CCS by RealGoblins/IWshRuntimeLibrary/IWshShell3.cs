using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x02000085 RID: 133
	[CompilerGenerated]
	[ComImport]
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[TypeIdentifier]
	public interface IWshShell3
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000473 RID: 1139
		[DispId(100)]
		IWshCollection SpecialFolders { [MethodImpl(MethodImplOptions.InternalCall)] [DispId(100)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000474 RID: 1140
		void _VtblGap1_3();

		// Token: 0x06000475 RID: 1141
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1002)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([In] [MarshalAs(UnmanagedType.BStr)] string PathLink);
	}
}
