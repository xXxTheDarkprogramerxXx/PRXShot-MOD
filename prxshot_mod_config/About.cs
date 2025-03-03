using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace prxshot_mod_config
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class About : Form
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00006684 File Offset: 0x00004A84
		[DebuggerNonUserCode]
		public About()
		{
			About.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000669C File Offset: 0x00004A9C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = About.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = About.__ENCList.Count == About.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int num2 = 0;
						int num3 = About.__ENCList.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = About.__ENCList[num4];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num4 != num;
								if (flag2)
								{
									About.__ENCList[num] = About.__ENCList[num4];
								}
								num++;
							}
							num4++;
						}
						About.__ENCList.RemoveRange(num, About.__ENCList.Count - num);
						About.__ENCList.Capacity = About.__ENCList.Count;
					}
					About.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00006B08 File Offset: 0x00004F08
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00006B20 File Offset: 0x00004F20
		internal virtual Label Label_A
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label_A;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label_A = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00006B2C File Offset: 0x00004F2C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00006B44 File Offset: 0x00004F44
		internal virtual Button Button_OK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_OK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_OK_Click);
				bool flag = this._Button_OK != null;
				if (flag)
				{
					this._Button_OK.Click -= value2;
				}
				this._Button_OK = value;
				flag = (this._Button_OK != null);
				if (flag)
				{
					this._Button_OK.Click += value2;
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00006BA4 File Offset: 0x00004FA4
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00006BBC File Offset: 0x00004FBC
		internal virtual Button Button_Visit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_Visit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button_Visit_Click);
				bool flag = this._Button_Visit != null;
				if (flag)
				{
					this._Button_Visit.Click -= value2;
				}
				this._Button_Visit = value;
				flag = (this._Button_Visit != null);
				if (flag)
				{
					this._Button_Visit.Click += value2;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00006C1C File Offset: 0x0000501C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00006C34 File Offset: 0x00005034
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

		// Token: 0x0600002E RID: 46 RVA: 0x00006C94 File Offset: 0x00005094
		private void Button_OK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006CA0 File Offset: 0x000050A0
		private void Button_Visit_Click(object sender, EventArgs e)
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

		// Token: 0x06000030 RID: 48 RVA: 0x00006CF4 File Offset: 0x000050F4
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

		// Token: 0x0400000B RID: 11
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400000D RID: 13
		[AccessedThroughProperty("Label_A")]
		private Label _Label_A;

		// Token: 0x0400000E RID: 14
		[AccessedThroughProperty("Button_OK")]
		private Button _Button_OK;

		// Token: 0x0400000F RID: 15
		[AccessedThroughProperty("Button_Visit")]
		private Button _Button_Visit;

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("Button_Donate")]
		private Button _Button_Donate;
	}
}
