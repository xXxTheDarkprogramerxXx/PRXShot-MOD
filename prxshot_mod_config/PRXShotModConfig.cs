using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using prxshot_mod_config.My;

namespace prxshot_mod_config
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class PRXShotModConfig : Form
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00006D58 File Offset: 0x00005158
		public PRXShotModConfig()
		{
			base.Load += this.PRXShotModConfig_Load;
			PRXShotModConfig.__ENCAddToList(this);
			this.fileExist = false;
			this.OutputKey1 = "";
			this.OutputKey2 = "";
			this.OutputKey3 = "";
			this.INI = new INIClass();
			this.InitializeComponent();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006DC4 File Offset: 0x000051C4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = PRXShotModConfig.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = PRXShotModConfig.__ENCList.Count == PRXShotModConfig.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int num2 = 0;
						int num3 = PRXShotModConfig.__ENCList.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = PRXShotModConfig.__ENCList[num4];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num4 != num;
								if (flag2)
								{
									PRXShotModConfig.__ENCList[num] = PRXShotModConfig.__ENCList[num4];
								}
								num++;
							}
							num4++;
						}
						PRXShotModConfig.__ENCList.RemoveRange(num, PRXShotModConfig.__ENCList.Count - num);
						PRXShotModConfig.__ENCList.Capacity = PRXShotModConfig.__ENCList.Count;
					}
					PRXShotModConfig.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000085E0 File Offset: 0x000069E0
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000085F8 File Offset: 0x000069F8
		internal virtual TextBox TextBox_path
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox_path;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox_path = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00008604 File Offset: 0x00006A04
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000861C File Offset: 0x00006A1C
		internal virtual ComboBox ComboBox_key1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox_key1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox_key1_SelectedIndexChanged);
				bool flag = this._ComboBox_key1 != null;
				if (flag)
				{
					this._ComboBox_key1.SelectedIndexChanged -= value2;
				}
				this._ComboBox_key1 = value;
				flag = (this._ComboBox_key1 != null);
				if (flag)
				{
					this._ComboBox_key1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000867C File Offset: 0x00006A7C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00008694 File Offset: 0x00006A94
		internal virtual ComboBox ComboBox_key2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox_key2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox_key2_SelectedIndexChanged);
				bool flag = this._ComboBox_key2 != null;
				if (flag)
				{
					this._ComboBox_key2.SelectedIndexChanged -= value2;
				}
				this._ComboBox_key2 = value;
				flag = (this._ComboBox_key2 != null);
				if (flag)
				{
					this._ComboBox_key2.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000086F4 File Offset: 0x00006AF4
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000870C File Offset: 0x00006B0C
		internal virtual ComboBox ComboBox_key3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox_key3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox_key3_SelectedIndexChanged);
				bool flag = this._ComboBox_key3 != null;
				if (flag)
				{
					this._ComboBox_key3.SelectedIndexChanged -= value2;
				}
				this._ComboBox_key3 = value;
				flag = (this._ComboBox_key3 != null);
				if (flag)
				{
					this._ComboBox_key3.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000876C File Offset: 0x00006B6C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00008784 File Offset: 0x00006B84
		internal virtual TextBox TextBox_Keys
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox_Keys;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox_Keys_TextChanged);
				bool flag = this._TextBox_Keys != null;
				if (flag)
				{
					this._TextBox_Keys.TextChanged -= value2;
				}
				this._TextBox_Keys = value;
				flag = (this._TextBox_Keys != null);
				if (flag)
				{
					this._TextBox_Keys.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000087E4 File Offset: 0x00006BE4
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000087FC File Offset: 0x00006BFC
		internal virtual Button Button_Apply
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_Apply;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_Apply_Click);
				bool flag = this._Button_Apply != null;
				if (flag)
				{
					this._Button_Apply.Click -= value2;
				}
				this._Button_Apply = value;
				flag = (this._Button_Apply != null);
				if (flag)
				{
					this._Button_Apply.Click += value2;
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000885C File Offset: 0x00006C5C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00008874 File Offset: 0x00006C74
		internal virtual Button Button_CopyKey
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_CopyKey;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_CopyKey_Click);
				bool flag = this._Button_CopyKey != null;
				if (flag)
				{
					this._Button_CopyKey.Click -= value2;
				}
				this._Button_CopyKey = value;
				flag = (this._Button_CopyKey != null);
				if (flag)
				{
					this._Button_CopyKey.Click += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000088D4 File Offset: 0x00006CD4
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000088EC File Offset: 0x00006CEC
		internal virtual ComboBox ComboBox_KeyName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox_KeyName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox_KeyName = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000088F8 File Offset: 0x00006CF8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00008910 File Offset: 0x00006D10
		internal virtual Button Button_VisitPage
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_VisitPage;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_VisitPage_Click);
				bool flag = this._Button_VisitPage != null;
				if (flag)
				{
					this._Button_VisitPage.Click -= value2;
				}
				this._Button_VisitPage = value;
				flag = (this._Button_VisitPage != null);
				if (flag)
				{
					this._Button_VisitPage.Click += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00008970 File Offset: 0x00006D70
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00008988 File Offset: 0x00006D88
		internal virtual Button Button_Donate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_Donate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_Donate_Click);
				bool flag = this._Button_Donate != null;
				if (flag)
				{
					this._Button_Donate.Click -= value2;
				}
				this._Button_Donate = value;
				flag = (this._Button_Donate != null);
				if (flag)
				{
					this._Button_Donate.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000089E8 File Offset: 0x00006DE8
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00008A00 File Offset: 0x00006E00
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00008A0C File Offset: 0x00006E0C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00008A24 File Offset: 0x00006E24
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00008A30 File Offset: 0x00006E30
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00008A48 File Offset: 0x00006E48
		internal virtual GroupBox GroupBox_Misc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox_Misc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox_Misc = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00008A54 File Offset: 0x00006E54
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00008A6C File Offset: 0x00006E6C
		internal virtual TextBox TextBox_ScreenshotName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox_ScreenshotName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox_ScreenshotName_TextChanged);
				bool flag = this._TextBox_ScreenshotName != null;
				if (flag)
				{
					this._TextBox_ScreenshotName.TextChanged -= value2;
				}
				this._TextBox_ScreenshotName = value;
				flag = (this._TextBox_ScreenshotName != null);
				if (flag)
				{
					this._TextBox_ScreenshotName.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00008ACC File Offset: 0x00006ECC
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00008AE4 File Offset: 0x00006EE4
		internal virtual NumericUpDown NumericUpDown_UseGameID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown_UseGameID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown_UseGameID = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00008AF0 File Offset: 0x00006EF0
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00008B08 File Offset: 0x00006F08
		internal virtual Label Label_UseGameID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_UseGameID;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_UseGameID = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00008B14 File Offset: 0x00006F14
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00008B2C File Offset: 0x00006F2C
		internal virtual Label Label_ScreenshotName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_ScreenshotName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_ScreenshotName = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00008B38 File Offset: 0x00006F38
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00008B50 File Offset: 0x00006F50
		internal virtual NumericUpDown NumericUpDown_CreatePic1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown_CreatePic1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown_CreatePic1 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00008B5C File Offset: 0x00006F5C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00008B74 File Offset: 0x00006F74
		internal virtual NumericUpDown NumericUpDown_PSPGoUseMS0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown_PSPGoUseMS0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown_PSPGoUseMS0 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00008B80 File Offset: 0x00006F80
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00008B98 File Offset: 0x00006F98
		internal virtual NumericUpDown NumericUpDown_KeyTimeout
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown_KeyTimeout;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown_KeyTimeout = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00008BA4 File Offset: 0x00006FA4
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00008BBC File Offset: 0x00006FBC
		internal virtual NumericUpDown NumericUpDown_XMBClearCache
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown_XMBClearCache;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown_XMBClearCache = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00008BC8 File Offset: 0x00006FC8
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00008BE0 File Offset: 0x00006FE0
		internal virtual Label Label_KeyTimeout
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_KeyTimeout;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_KeyTimeout = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00008BEC File Offset: 0x00006FEC
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00008C04 File Offset: 0x00007004
		internal virtual Label Label_XMBClearCache
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_XMBClearCache;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_XMBClearCache = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00008C10 File Offset: 0x00007010
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00008C28 File Offset: 0x00007028
		internal virtual Label Label_PSPGoUseMS0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_PSPGoUseMS0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_PSPGoUseMS0 = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00008C34 File Offset: 0x00007034
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00008C4C File Offset: 0x0000704C
		internal virtual Label Label_CreatePic1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_CreatePic1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_CreatePic1 = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00008C58 File Offset: 0x00007058
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00008C70 File Offset: 0x00007070
		internal virtual Button Button_SaveMisc
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_SaveMisc;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_SaveMisc_Click);
				bool flag = this._Button_SaveMisc != null;
				if (flag)
				{
					this._Button_SaveMisc.Click -= value2;
				}
				this._Button_SaveMisc = value;
				flag = (this._Button_SaveMisc != null);
				if (flag)
				{
					this._Button_SaveMisc.Click += value2;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00008CD0 File Offset: 0x000070D0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00008CE8 File Offset: 0x000070E8
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00008D48 File Offset: 0x00007148
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00008D60 File Offset: 0x00007160
		internal virtual NumericUpDown NumericUpDown_SaveToPICTURE
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown_SaveToPICTURE;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown_SaveToPICTURE = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00008D6C File Offset: 0x0000716C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00008D84 File Offset: 0x00007184
		internal virtual Label Label_SaveToPICTURE
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_SaveToPICTURE;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_SaveToPICTURE = value;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008D90 File Offset: 0x00007190
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void PRXShotModConfig_Load(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0A:
				int num2 = 2;
				bool flag = MyProject.Computer.FileSystem.FileExists(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini");
				if (!flag)
				{
					goto IL_310;
				}
				IL_3E:
				num2 = 3;
				this.fileExist = true;
				IL_48:
				num2 = 4;
				this.TextBox_path.Text = "prxshot_mod.ini -> is loaded!";
				IL_5C:
				num2 = 5;
				this.ComboBox_KeyName.Text = "ScreenshotKey ( XMB, GAME, POPS )";
				IL_70:
				num2 = 6;
				flag = (Operators.CompareString(this.ComboBox_key1.Text, "", false) != 0);
				if (!flag)
				{
					goto IL_B7;
				}
				IL_95:
				num2 = 7;
				this.Button_Apply.Enabled = true;
				IL_A5:
				num2 = 8;
				this.ComboBox_key2.Enabled = true;
				IL_B5:
				goto IL_EF;
				IL_B7:
				num2 = 10;
				IL_BC:
				num2 = 11;
				this.Button_Apply.Enabled = false;
				IL_CD:
				num2 = 12;
				this.ComboBox_key2.Enabled = false;
				IL_DE:
				num2 = 13;
				this.ComboBox_key3.Enabled = false;
				IL_EF:
				IL_F0:
				num2 = 15;
				string value = this.INI.INIRead(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "CreatePic1");
				IL_123:
				num2 = 16;
				string value2 = this.INI.INIRead(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "PSPGoUseMS0");
				IL_156:
				num2 = 17;
				string value3 = this.INI.INIRead(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "XMBClearCache");
				IL_18A:
				num2 = 18;
				string value4 = this.INI.INIRead(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "KeyTimeout");
				IL_1BD:
				num2 = 19;
				string value5 = this.INI.INIRead(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "SaveToPICTURE");
				IL_1F0:
				num2 = 20;
				string text = this.INI.INIRead(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotName");
				IL_224:
				num2 = 21;
				string value6 = this.INI.INIRead(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotNameUseGameID");
				IL_258:
				num2 = 22;
				this.NumericUpDown_CreatePic1.Value = Conversions.ToDecimal(value);
				IL_26E:
				num2 = 23;
				this.NumericUpDown_PSPGoUseMS0.Value = Conversions.ToDecimal(value2);
				IL_284:
				num2 = 24;
				this.NumericUpDown_XMBClearCache.Value = Conversions.ToDecimal(value3);
				IL_29B:
				num2 = 25;
				this.NumericUpDown_KeyTimeout.Value = Conversions.ToDecimal(value4);
				IL_2B1:
				num2 = 26;
				this.TextBox_ScreenshotName.Text = text.Replace("%s/", "").Replace("%04d.bmp", "");
				IL_2E1:
				num2 = 27;
				this.NumericUpDown_UseGameID.Value = Conversions.ToDecimal(value6);
				IL_2F8:
				num2 = 28;
				this.NumericUpDown_SaveToPICTURE.Value = Conversions.ToDecimal(value5);
				IL_30E:
				goto IL_357;
				IL_310:
				num2 = 30;
				IL_315:
				num2 = 31;
				this.fileExist = false;
				IL_320:
				num2 = 32;
				this.Button_Apply.Enabled = false;
				IL_331:
				num2 = 33;
				this.ComboBox_KeyName.Enabled = false;
				IL_342:
				num2 = 34;
				this.TextBox_path.Text = "prxshot_mod.ini -> is not exist!";
				IL_357:
				IL_358:
				goto IL_44E;
				IL_361:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_401:
				goto IL_443;
				IL_403:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_41F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_403;
			}
			IL_443:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_44E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00009214 File Offset: 0x00007614
		private void Button_CopyKey_Click(object sender, EventArgs e)
		{
			MyProject.Computer.Clipboard.SetText(this.TextBox_Keys.Text);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009234 File Offset: 0x00007634
		private void ComboBox_key1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.ComboBox_key1.Text;
			bool flag = Operators.CompareString(text, "START", false) == 0;
			if (flag)
			{
				this.OutputKey1 = "0x000008";
			}
			else
			{
				flag = (Operators.CompareString(text, "SELECT", false) == 0);
				if (flag)
				{
					this.OutputKey1 = "0x000001";
				}
				else
				{
					flag = (Operators.CompareString(text, "NOTE", false) == 0);
					if (flag)
					{
						this.OutputKey1 = "0x800000";
					}
					else
					{
						flag = (Operators.CompareString(text, "SCREEN", false) == 0);
						if (flag)
						{
							this.OutputKey1 = "0x400000";
						}
						else
						{
							flag = (Operators.CompareString(text, "VOL-UP", false) == 0);
							if (flag)
							{
								this.OutputKey1 = "0x100000";
							}
							else
							{
								flag = (Operators.CompareString(text, "VOL-DOWN", false) == 0);
								if (flag)
								{
									this.OutputKey1 = "0x200000";
								}
								else
								{
									flag = (Operators.CompareString(text, "HOME", false) == 0);
									if (flag)
									{
										this.OutputKey1 = "0x010000";
									}
									else
									{
										flag = (Operators.CompareString(text, "HOLD", false) == 0);
										if (flag)
										{
											this.OutputKey1 = "0x020000";
										}
										else
										{
											flag = (Operators.CompareString(text, "LEFT", false) == 0);
											if (flag)
											{
												this.OutputKey1 = "0x000080";
											}
											else
											{
												flag = (Operators.CompareString(text, "RIGHT", false) == 0);
												if (flag)
												{
													this.OutputKey1 = "0x000020";
												}
												else
												{
													flag = (Operators.CompareString(text, "UP", false) == 0);
													if (flag)
													{
														this.OutputKey1 = "0x000010";
													}
													else
													{
														flag = (Operators.CompareString(text, "DOWN", false) == 0);
														if (flag)
														{
															this.OutputKey1 = "0x000040";
														}
														else
														{
															flag = (Operators.CompareString(text, "L-TRIGGER", false) == 0);
															if (flag)
															{
																this.OutputKey1 = "0x000100";
															}
															else
															{
																flag = (Operators.CompareString(text, "R-TRIGGER", false) == 0);
																if (flag)
																{
																	this.OutputKey1 = "0x000200";
																}
																else
																{
																	flag = (Operators.CompareString(text, "TRIANGLE", false) == 0);
																	if (flag)
																	{
																		this.OutputKey1 = "0x001000";
																	}
																	else
																	{
																		flag = (Operators.CompareString(text, "CIRCLE", false) == 0);
																		if (flag)
																		{
																			this.OutputKey1 = "0x002000";
																		}
																		else
																		{
																			flag = (Operators.CompareString(text, "CROSS", false) == 0);
																			if (flag)
																			{
																				this.OutputKey1 = "0x004000";
																			}
																			else
																			{
																				flag = (Operators.CompareString(text, "SQUARE", false) == 0);
																				if (flag)
																				{
																					this.OutputKey1 = "0x008000";
																				}
																				else
																				{
																					this.OutputKey1 = "";
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			flag = (Operators.CompareString(this.ComboBox_key1.Text, "", false) != 0);
			bool flag2;
			if (flag)
			{
				flag2 = this.fileExist;
				if (flag2)
				{
					this.Button_Apply.Enabled = true;
					this.ComboBox_KeyName.Enabled = true;
				}
				this.Button_CopyKey.Enabled = true;
				this.ComboBox_key2.Enabled = true;
			}
			else
			{
				this.ComboBox_KeyName.Enabled = false;
				this.Button_Apply.Enabled = false;
				this.Button_CopyKey.Enabled = false;
				this.ComboBox_key2.Enabled = false;
				this.ComboBox_key3.Enabled = false;
				this.ComboBox_key2.Text = "";
				this.ComboBox_key3.Text = "";
			}
			int num = checked((int)Math.Round(unchecked(Conversion.Val(this.OutputKey1.Replace("0x", "")) + Conversion.Val(this.OutputKey2.Replace("0x", "")) + Conversion.Val(this.OutputKey3.Replace("0x", "")))));
			string left = Strings.Format(num, "0x######");
			flag2 = (Operators.CompareString(left, "0x000000", false) != 0);
			if (flag2)
			{
				this.TextBox_Keys.Text = Strings.Format(num, "0x######");
			}
			else
			{
				this.TextBox_Keys.Text = "";
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009664 File Offset: 0x00007A64
		private void ComboBox_key2_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.ComboBox_key2.Text;
			bool flag = Operators.CompareString(text, "START", false) == 0;
			if (flag)
			{
				this.OutputKey2 = "0x000008";
			}
			else
			{
				flag = (Operators.CompareString(text, "SELECT", false) == 0);
				if (flag)
				{
					this.OutputKey2 = "0x000001";
				}
				else
				{
					flag = (Operators.CompareString(text, "NOTE", false) == 0);
					if (flag)
					{
						this.OutputKey2 = "0x800000";
					}
					else
					{
						flag = (Operators.CompareString(text, "SCREEN", false) == 0);
						if (flag)
						{
							this.OutputKey2 = "0x400000";
						}
						else
						{
							flag = (Operators.CompareString(text, "VOL-UP", false) == 0);
							if (flag)
							{
								this.OutputKey2 = "0x100000";
							}
							else
							{
								flag = (Operators.CompareString(text, "VOL-DOWN", false) == 0);
								if (flag)
								{
									this.OutputKey2 = "0x200000";
								}
								else
								{
									flag = (Operators.CompareString(text, "HOME", false) == 0);
									if (flag)
									{
										this.OutputKey2 = "0x010000";
									}
									else
									{
										flag = (Operators.CompareString(text, "HOLD", false) == 0);
										if (flag)
										{
											this.OutputKey2 = "0x020000";
										}
										else
										{
											flag = (Operators.CompareString(text, "LEFT", false) == 0);
											if (flag)
											{
												this.OutputKey2 = "0x000080";
											}
											else
											{
												flag = (Operators.CompareString(text, "RIGHT", false) == 0);
												if (flag)
												{
													this.OutputKey2 = "0x000020";
												}
												else
												{
													flag = (Operators.CompareString(text, "UP", false) == 0);
													if (flag)
													{
														this.OutputKey2 = "0x000010";
													}
													else
													{
														flag = (Operators.CompareString(text, "DOWN", false) == 0);
														if (flag)
														{
															this.OutputKey2 = "0x000040";
														}
														else
														{
															flag = (Operators.CompareString(text, "L-TRIGGER", false) == 0);
															if (flag)
															{
																this.OutputKey2 = "0x000100";
															}
															else
															{
																flag = (Operators.CompareString(text, "R-TRIGGER", false) == 0);
																if (flag)
																{
																	this.OutputKey2 = "0x000200";
																}
																else
																{
																	flag = (Operators.CompareString(text, "TRIANGLE", false) == 0);
																	if (flag)
																	{
																		this.OutputKey2 = "0x001000";
																	}
																	else
																	{
																		flag = (Operators.CompareString(text, "CIRCLE", false) == 0);
																		if (flag)
																		{
																			this.OutputKey2 = "0x002000";
																		}
																		else
																		{
																			flag = (Operators.CompareString(text, "CROSS", false) == 0);
																			if (flag)
																			{
																				this.OutputKey2 = "0x004000";
																			}
																			else
																			{
																				flag = (Operators.CompareString(text, "SQUARE", false) == 0);
																				if (flag)
																				{
																					this.OutputKey2 = "0x008000";
																				}
																				else
																				{
																					this.OutputKey2 = "";
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			flag = (Operators.CompareString(this.ComboBox_key2.Text, "", false) != 0);
			if (flag)
			{
				this.ComboBox_key3.Enabled = true;
			}
			else
			{
				this.ComboBox_key3.Enabled = false;
				this.ComboBox_key3.Text = "";
			}
			int num = checked((int)Math.Round(unchecked(Conversion.Val(this.OutputKey1.Replace("0x", "")) + Conversion.Val(this.OutputKey2.Replace("0x", "")) + Conversion.Val(this.OutputKey3.Replace("0x", "")))));
			string left = Strings.Format(num, "0x######");
			flag = (Operators.CompareString(left, "0x000000", false) != 0);
			if (flag)
			{
				this.TextBox_Keys.Text = Strings.Format(num, "0x######");
			}
			else
			{
				this.TextBox_Keys.Text = "";
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009A1C File Offset: 0x00007E1C
		private void ComboBox_key3_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.ComboBox_key3.Text;
			bool flag = Operators.CompareString(text, "START", false) == 0;
			if (flag)
			{
				this.OutputKey3 = "0x000008";
			}
			else
			{
				flag = (Operators.CompareString(text, "SELECT", false) == 0);
				if (flag)
				{
					this.OutputKey3 = "0x000001";
				}
				else
				{
					flag = (Operators.CompareString(text, "NOTE", false) == 0);
					if (flag)
					{
						this.OutputKey3 = "0x800000";
					}
					else
					{
						flag = (Operators.CompareString(text, "SCREEN", false) == 0);
						if (flag)
						{
							this.OutputKey3 = "0x400000";
						}
						else
						{
							flag = (Operators.CompareString(text, "VOL-UP", false) == 0);
							if (flag)
							{
								this.OutputKey3 = "0x100000";
							}
							else
							{
								flag = (Operators.CompareString(text, "VOL-DOWN", false) == 0);
								if (flag)
								{
									this.OutputKey3 = "0x200000";
								}
								else
								{
									flag = (Operators.CompareString(text, "HOME", false) == 0);
									if (flag)
									{
										this.OutputKey3 = "0x010000";
									}
									else
									{
										flag = (Operators.CompareString(text, "HOLD", false) == 0);
										if (flag)
										{
											this.OutputKey3 = "0x020000";
										}
										else
										{
											flag = (Operators.CompareString(text, "LEFT", false) == 0);
											if (flag)
											{
												this.OutputKey3 = "0x000080";
											}
											else
											{
												flag = (Operators.CompareString(text, "RIGHT", false) == 0);
												if (flag)
												{
													this.OutputKey3 = "0x000020";
												}
												else
												{
													flag = (Operators.CompareString(text, "UP", false) == 0);
													if (flag)
													{
														this.OutputKey3 = "0x000010";
													}
													else
													{
														flag = (Operators.CompareString(text, "DOWN", false) == 0);
														if (flag)
														{
															this.OutputKey3 = "0x000040";
														}
														else
														{
															flag = (Operators.CompareString(text, "L-TRIGGER", false) == 0);
															if (flag)
															{
																this.OutputKey3 = "0x000100";
															}
															else
															{
																flag = (Operators.CompareString(text, "R-TRIGGER", false) == 0);
																if (flag)
																{
																	this.OutputKey3 = "0x000200";
																}
																else
																{
																	flag = (Operators.CompareString(text, "TRIANGLE", false) == 0);
																	if (flag)
																	{
																		this.OutputKey3 = "0x001000";
																	}
																	else
																	{
																		flag = (Operators.CompareString(text, "CIRCLE", false) == 0);
																		if (flag)
																		{
																			this.OutputKey3 = "0x002000";
																		}
																		else
																		{
																			flag = (Operators.CompareString(text, "CROSS", false) == 0);
																			if (flag)
																			{
																				this.OutputKey3 = "0x004000";
																			}
																			else
																			{
																				flag = (Operators.CompareString(text, "SQUARE", false) == 0);
																				if (flag)
																				{
																					this.OutputKey3 = "0x008000";
																				}
																				else
																				{
																					this.OutputKey3 = "";
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num = checked((int)Math.Round(unchecked(Conversion.Val(this.OutputKey1.Replace("0x", "")) + Conversion.Val(this.OutputKey2.Replace("0x", "")) + Conversion.Val(this.OutputKey3.Replace("0x", "")))));
			string left = Strings.Format(num, "0x######");
			flag = (Operators.CompareString(left, "0x000000", false) != 0);
			if (flag)
			{
				this.TextBox_Keys.Text = Strings.Format(num, "0x######");
			}
			else
			{
				this.TextBox_Keys.Text = "";
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009D84 File Offset: 0x00008184
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button_Apply_Click(object sender, EventArgs e)
		{
			try
			{
				string str = string.Format(" # {0} {1} {2}", this.ComboBox_key1.Text, this.ComboBox_key2.Text, this.ComboBox_key3.Text);
				string text = this.ComboBox_KeyName.Text;
				string left = text;
				bool flag = Operators.CompareString(left, "ScreenshotKey ( XMB, GAME, POPS )", false) == 0;
				if (flag)
				{
					this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_XMB", " " + (this.TextBox_Keys.Text + str).Trim());
					this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_GAME", " " + (this.TextBox_Keys.Text + str).Trim());
					this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_POPS", " " + (this.TextBox_Keys.Text + str).Trim());
				}
				else
				{
					flag = (Operators.CompareString(left, "ScreenshotKey ( GAME, POPS )", false) == 0);
					if (flag)
					{
						this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_GAME", " " + (this.TextBox_Keys.Text + str).Trim());
						this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_POPS", " " + (this.TextBox_Keys.Text + str).Trim());
					}
					else
					{
						flag = (Operators.CompareString(left, "ScreenshotKey ( XMB )", false) == 0);
						if (flag)
						{
							this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_XMB", " " + (this.TextBox_Keys.Text + str).Trim());
						}
						else
						{
							flag = (Operators.CompareString(left, "ScreenshotKey ( GAME )", false) == 0);
							if (flag)
							{
								this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_GAME", " " + (this.TextBox_Keys.Text + str).Trim());
							}
							else
							{
								flag = (Operators.CompareString(left, "ScreenshotKey ( POPS )", false) == 0);
								if (flag)
								{
									this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotKey_POPS", " " + (this.TextBox_Keys.Text + str).Trim());
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000A100 File Offset: 0x00008500
		private void Button_VisitPage_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://sites.google.com/site/theleecherman/");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, (MsgBoxStyle)262144, "Error Openning URL");
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000A154 File Offset: 0x00008554
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button_SaveMisc_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "CreatePic1", " " + this.NumericUpDown_CreatePic1.Value.ToString().Trim());
				IL_5C:
				num2 = 3;
				this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "PSPGoUseMS0", " " + this.NumericUpDown_PSPGoUseMS0.Value.ToString().Trim());
				IL_AF:
				num2 = 4;
				this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "XMBClearCache", " " + this.NumericUpDown_XMBClearCache.Value.ToString().Trim());
				IL_102:
				num2 = 5;
				this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "KeyTimeout", " " + this.NumericUpDown_KeyTimeout.Value.ToString().Trim());
				IL_155:
				num2 = 6;
				this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "SaveToPICTURE", " " + this.NumericUpDown_SaveToPICTURE.Value.ToString().Trim());
				IL_1A8:
				num2 = 7;
				this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotName", " %s/" + this.TextBox_ScreenshotName.Text + "%04d.bmp".Trim());
				IL_1F8:
				num2 = 8;
				this.INI.INIWrite(MyProject.Application.Info.DirectoryPath + "\\prxshot_mod.ini", "General", "ScreenshotNameUseGameID", " " + this.NumericUpDown_UseGameID.Value.ToString().Trim());
				IL_24B:
				goto IL_2C9;
				IL_250:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_282:
				goto IL_2BE;
				IL_284:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_29C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_284;
			}
			IL_2BE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2C9:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000A450 File Offset: 0x00008850
		private void TextBox_ScreenshotName_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.TextBox_ScreenshotName.Text, "", false) != 0;
			if (flag)
			{
				this.Button_SaveMisc.Enabled = true;
			}
			else
			{
				this.Button_SaveMisc.Enabled = false;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000A4A0 File Offset: 0x000088A0
		private void Button_Donate_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=TGGGHWTV89ZGG");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, (MsgBoxStyle)262144, "Error Openning URL, Please visit the site to donate!");
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000A4F4 File Offset: 0x000088F4
		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.About.ShowDialog();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000A508 File Offset: 0x00008908
		private void TextBox_Keys_TextChanged(object sender, EventArgs e)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				int num3 = checked((int)Math.Round(unchecked(Conversion.Val(this.OutputKey1.Replace("0x", "")) + Conversion.Val(this.OutputKey2.Replace("0x", "")) + Conversion.Val(this.OutputKey3.Replace("0x", "")))));
				IL_63:
				num2 = 3;
				string str = Strings.Format(num3, "0x######");
				IL_77:
				num2 = 4;
				bool flag = this.TextBox_Keys.Text.StartsWith("1x");
				if (!flag)
				{
					goto IL_D1;
				}
				IL_95:
				num2 = 5;
				this.Button_Apply.Enabled = false;
				IL_A5:
				num2 = 6;
				this.Button_CopyKey.Enabled = false;
				IL_B5:
				num2 = 7;
				this.TextBox_Keys.Text = str + " - Unsupported Key!";
				IL_CF:
				goto IL_F8;
				IL_D1:
				num2 = 9;
				IL_D6:
				num2 = 10;
				this.Button_Apply.Enabled = true;
				IL_E7:
				num2 = 11;
				this.Button_CopyKey.Enabled = true;
				IL_F8:
				IL_F9:
				num2 = 13;
				flag = ((Operators.CompareString(this.ComboBox_key1.Text, "", false) != 0 && Operators.CompareString(this.ComboBox_key2.Text, "", false) != 0) | Operators.CompareString(this.ComboBox_key3.Text, "", false) != 0);
				if (!flag)
				{
					goto IL_27C;
				}
				IL_159:
				num2 = 14;
				bool flag2 = Operators.CompareString(this.ComboBox_key1.Text, this.ComboBox_key2.Text, false) == 0;
				if (!flag2)
				{
					goto IL_1B9;
				}
				IL_182:
				num2 = 15;
				this.TextBox_Keys.Text = "Doubled Key is Not Allowed!";
				IL_197:
				num2 = 16;
				this.Button_Apply.Enabled = false;
				IL_1A8:
				num2 = 17;
				this.Button_CopyKey.Enabled = false;
				IL_1B9:
				IL_1BA:
				num2 = 19;
				flag2 = (Operators.CompareString(this.ComboBox_key1.Text, this.ComboBox_key3.Text, false) == 0);
				if (!flag2)
				{
					goto IL_21A;
				}
				IL_1E3:
				num2 = 20;
				this.TextBox_Keys.Text = "Doubled Key is Not Allowed!";
				IL_1F8:
				num2 = 21;
				this.Button_Apply.Enabled = false;
				IL_209:
				num2 = 22;
				this.Button_CopyKey.Enabled = false;
				IL_21A:
				IL_21B:
				num2 = 24;
				flag2 = (Operators.CompareString(this.ComboBox_key2.Text, this.ComboBox_key3.Text, false) == 0);
				if (!flag2)
				{
					goto IL_27B;
				}
				IL_244:
				num2 = 25;
				this.TextBox_Keys.Text = "Doubled Key is Not Allowed!";
				IL_259:
				num2 = 26;
				this.Button_Apply.Enabled = false;
				IL_26A:
				num2 = 27;
				this.Button_CopyKey.Enabled = false;
				IL_27B:
				IL_27C:
				IL_27D:
				num2 = 30;
				flag2 = (Operators.CompareString(this.TextBox_Keys.Text, "Doubled Key is Not Allowed!", false) == 0 | Operators.CompareString(this.TextBox_Keys.Text, str + " - Unsupported Key!", false) == 0);
				if (!flag2)
				{
					goto IL_2E4;
				}
				IL_2C0:
				num2 = 31;
				this.Button_Apply.Enabled = false;
				IL_2D1:
				num2 = 32;
				this.Button_CopyKey.Enabled = false;
				IL_2E2:
				goto IL_30B;
				IL_2E4:
				num2 = 34;
				IL_2E9:
				num2 = 35;
				this.Button_Apply.Enabled = true;
				IL_2FA:
				num2 = 36;
				this.Button_CopyKey.Enabled = true;
				IL_30B:
				IL_30C:
				goto IL_402;
				IL_314:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_3BA:
				goto IL_3F7;
				IL_3BC:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_3D5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3BC;
			}
			IL_3F7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_402:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x04000016 RID: 22
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("TextBox_path")]
		private TextBox _TextBox_path;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("ComboBox_key1")]
		private ComboBox _ComboBox_key1;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("ComboBox_key2")]
		private ComboBox _ComboBox_key2;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("ComboBox_key3")]
		private ComboBox _ComboBox_key3;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("TextBox_Keys")]
		private TextBox _TextBox_Keys;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("Button_Apply")]
		private Button _Button_Apply;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("Button_CopyKey")]
		private Button _Button_CopyKey;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("ComboBox_KeyName")]
		private ComboBox _ComboBox_KeyName;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("Button_VisitPage")]
		private Button _Button_VisitPage;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("Button_Donate")]
		private Button _Button_Donate;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("GroupBox_Misc")]
		private GroupBox _GroupBox_Misc;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("TextBox_ScreenshotName")]
		private TextBox _TextBox_ScreenshotName;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("NumericUpDown_UseGameID")]
		private NumericUpDown _NumericUpDown_UseGameID;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("Label_UseGameID")]
		private Label _Label_UseGameID;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("Label_ScreenshotName")]
		private Label _Label_ScreenshotName;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("NumericUpDown_CreatePic1")]
		private NumericUpDown _NumericUpDown_CreatePic1;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("NumericUpDown_PSPGoUseMS0")]
		private NumericUpDown _NumericUpDown_PSPGoUseMS0;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("NumericUpDown_KeyTimeout")]
		private NumericUpDown _NumericUpDown_KeyTimeout;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("NumericUpDown_XMBClearCache")]
		private NumericUpDown _NumericUpDown_XMBClearCache;

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("Label_KeyTimeout")]
		private Label _Label_KeyTimeout;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("Label_XMBClearCache")]
		private Label _Label_XMBClearCache;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("Label_PSPGoUseMS0")]
		private Label _Label_PSPGoUseMS0;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("Label_CreatePic1")]
		private Label _Label_CreatePic1;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("Button_SaveMisc")]
		private Button _Button_SaveMisc;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("NumericUpDown_SaveToPICTURE")]
		private NumericUpDown _NumericUpDown_SaveToPICTURE;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("Label_SaveToPICTURE")]
		private Label _Label_SaveToPICTURE;

		// Token: 0x04000035 RID: 53
		private bool fileExist;

		// Token: 0x04000036 RID: 54
		private string OutputKey1;

		// Token: 0x04000037 RID: 55
		private string OutputKey2;

		// Token: 0x04000038 RID: 56
		private string OutputKey3;

		// Token: 0x04000039 RID: 57
		private INIClass INI;
	}
}
