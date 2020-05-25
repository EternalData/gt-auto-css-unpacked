using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Growtopia_macro.Properties
{
	// Token: 0x0200007D RID: 125
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00024F00 File Offset: 0x00023100
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00024F14 File Offset: 0x00023114
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public StringCollection SavedMacros
		{
			get
			{
				return (StringCollection)this["SavedMacros"];
			}
			set
			{
				this["SavedMacros"] = value;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00024F7C File Offset: 0x0002317C
		private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00024F80 File Offset: 0x00023180
		private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
		{
		}
	}
}
