using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace prxshot_mod_config
{
	// Token: 0x0200000D RID: 13
	public class INIClass
	{
		// Token: 0x06000084 RID: 132 RVA: 0x0000A93C File Offset: 0x00008D3C
		[DebuggerNonUserCode]
		public INIClass()
		{
		}

		// Token: 0x06000085 RID: 133
		[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "WritePrivateProfileStringW", ExactSpelling = true, SetLastError = true)]
		private static extern int WritePrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06000086 RID: 134
		[DllImport("kernel32", CharSet = CharSet.Unicode, EntryPoint = "GetPrivateProfileStringW", ExactSpelling = true, SetLastError = true)]
		private static extern int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

		// Token: 0x06000087 RID: 135 RVA: 0x0000A948 File Offset: 0x00008D48
		public string INIRead(string INIPath, string SectionName, string KeyName, string DefaultValue)
		{
			string text = Strings.Space(1024);
			int privateProfileString = INIClass.GetPrivateProfileString(ref SectionName, ref KeyName, ref DefaultValue, ref text, text.Length, ref INIPath);
			bool flag = privateProfileString > 0;
			string result;
			if (flag)
			{
				result = text.Substring(0, privateProfileString);
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000A994 File Offset: 0x00008D94
		public string INIRead(string INIPath, string SectionName, string KeyName)
		{
			return this.INIRead(INIPath, SectionName, KeyName, "");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A9B4 File Offset: 0x00008DB4
		public string INIRead(string INIPath, string SectionName)
		{
			return this.INIRead(INIPath, SectionName, null, "");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000A9D4 File Offset: 0x00008DD4
		public string INIRead(string INIPath)
		{
			return this.INIRead(INIPath, null, null, "");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000A9F4 File Offset: 0x00008DF4
		public void INIWrite(string INIPath, string SectionName, string KeyName, string TheValue)
		{
			INIClass.WritePrivateProfileString(ref SectionName, ref KeyName, ref TheValue, ref INIPath);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AA08 File Offset: 0x00008E08
		public void INIDelete(string INIPath, string SectionName, string KeyName)
		{
			string text = null;
			INIClass.WritePrivateProfileString(ref SectionName, ref KeyName, ref text, ref INIPath);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000AA28 File Offset: 0x00008E28
		public void INIDelete(string INIPath, string SectionName)
		{
			string text = null;
			string text2 = null;
			INIClass.WritePrivateProfileString(ref SectionName, ref text, ref text2, ref INIPath);
		}
	}
}
