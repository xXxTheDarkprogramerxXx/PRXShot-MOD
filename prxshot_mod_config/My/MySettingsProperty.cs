using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace prxshot_mod_config.My
{
	// Token: 0x0200000B RID: 11
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[HideModuleName]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00006034 File Offset: 0x00004434
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
