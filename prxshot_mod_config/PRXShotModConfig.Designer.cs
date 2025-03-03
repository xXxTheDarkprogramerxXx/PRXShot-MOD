namespace prxshot_mod_config
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PRXShotModConfig : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00006EC8 File Offset: 0x000052C8
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006F18 File Offset: 0x00005318
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::prxshot_mod_config.PRXShotModConfig));
			this.TextBox_path = new global::System.Windows.Forms.TextBox();
			this.ComboBox_key1 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_key2 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_key3 = new global::System.Windows.Forms.ComboBox();
			this.TextBox_Keys = new global::System.Windows.Forms.TextBox();
			this.Button_Apply = new global::System.Windows.Forms.Button();
			this.Button_CopyKey = new global::System.Windows.Forms.Button();
			this.ComboBox_KeyName = new global::System.Windows.Forms.ComboBox();
			this.Button_VisitPage = new global::System.Windows.Forms.Button();
			this.Button_Donate = new global::System.Windows.Forms.Button();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox_Misc = new global::System.Windows.Forms.GroupBox();
			this.NumericUpDown_SaveToPICTURE = new global::System.Windows.Forms.NumericUpDown();
			this.Label_SaveToPICTURE = new global::System.Windows.Forms.Label();
			this.Button_SaveMisc = new global::System.Windows.Forms.Button();
			this.TextBox_ScreenshotName = new global::System.Windows.Forms.TextBox();
			this.NumericUpDown_UseGameID = new global::System.Windows.Forms.NumericUpDown();
			this.Label_UseGameID = new global::System.Windows.Forms.Label();
			this.Label_ScreenshotName = new global::System.Windows.Forms.Label();
			this.NumericUpDown_CreatePic1 = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_PSPGoUseMS0 = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_KeyTimeout = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_XMBClearCache = new global::System.Windows.Forms.NumericUpDown();
			this.Label_KeyTimeout = new global::System.Windows.Forms.Label();
			this.Label_XMBClearCache = new global::System.Windows.Forms.Label();
			this.Label_PSPGoUseMS0 = new global::System.Windows.Forms.Label();
			this.Label_CreatePic1 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox_Misc.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_SaveToPICTURE).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_UseGameID).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_CreatePic1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_PSPGoUseMS0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_KeyTimeout).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_XMBClearCache).BeginInit();
			this.SuspendLayout();
			this.TextBox_path.BackColor = global::System.Drawing.Color.White;
			this.TextBox_path.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.TextBox_path.Enabled = false;
			this.TextBox_path.ForeColor = global::System.Drawing.Color.Black;
			global::System.Windows.Forms.Control textBox_path = this.TextBox_path;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 386);
			textBox_path.Location = location;
			this.TextBox_path.Name = "TextBox_path";
			this.TextBox_path.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_path2 = this.TextBox_path;
			global::System.Drawing.Size size = new global::System.Drawing.Size(354, 13);
			textBox_path2.Size = size;
			this.TextBox_path.TabIndex = 0;
			this.TextBox_path.Text = "...";
			this.TextBox_path.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ComboBox_key1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_key1.FormattingEnabled = true;
			this.ComboBox_key1.Items.AddRange(new object[]
			{
				"",
				"START",
				"SELECT",
				"NOTE",
				"SCREEN",
				"VOL-UP",
				"VOL-DOWN",
				"HOME",
				"HOLD",
				"LEFT",
				"RIGHT",
				"UP",
				"DOWN",
				"L-TRIGGER",
				"R-TRIGGER",
				"TRIANGLE",
				"CIRCLE",
				"CROSS",
				"SQUARE"
			});
			global::System.Windows.Forms.Control comboBox_key = this.ComboBox_key1;
			location = new global::System.Drawing.Point(10, 24);
			comboBox_key.Location = location;
			this.ComboBox_key1.Name = "ComboBox_key1";
			global::System.Windows.Forms.Control comboBox_key2 = this.ComboBox_key1;
			size = new global::System.Drawing.Size(86, 21);
			comboBox_key2.Size = size;
			this.ComboBox_key1.TabIndex = 1;
			this.ComboBox_key2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_key2.Enabled = false;
			this.ComboBox_key2.FormattingEnabled = true;
			this.ComboBox_key2.Items.AddRange(new object[]
			{
				"",
				"START",
				"SELECT",
				"NOTE",
				"SCREEN",
				"VOL-UP",
				"VOL-DOWN",
				"HOME",
				"HOLD",
				"LEFT",
				"RIGHT",
				"UP",
				"DOWN",
				"L-TRIGGER",
				"R-TRIGGER",
				"TRIANGLE",
				"CIRCLE",
				"CROSS",
				"SQUARE"
			});
			global::System.Windows.Forms.Control comboBox_key3 = this.ComboBox_key2;
			location = new global::System.Drawing.Point(102, 24);
			comboBox_key3.Location = location;
			this.ComboBox_key2.Name = "ComboBox_key2";
			global::System.Windows.Forms.Control comboBox_key4 = this.ComboBox_key2;
			size = new global::System.Drawing.Size(86, 21);
			comboBox_key4.Size = size;
			this.ComboBox_key2.TabIndex = 2;
			this.ComboBox_key3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_key3.Enabled = false;
			this.ComboBox_key3.FormattingEnabled = true;
			this.ComboBox_key3.Items.AddRange(new object[]
			{
				"",
				"START",
				"SELECT",
				"NOTE",
				"SCREEN",
				"VOL-UP",
				"VOL-DOWN",
				"HOME",
				"HOLD",
				"LEFT",
				"RIGHT",
				"UP",
				"DOWN",
				"L-TRIGGER",
				"R-TRIGGER",
				"TRIANGLE",
				"CIRCLE",
				"CROSS",
				"SQUARE"
			});
			global::System.Windows.Forms.Control comboBox_key5 = this.ComboBox_key3;
			location = new global::System.Drawing.Point(194, 24);
			comboBox_key5.Location = location;
			this.ComboBox_key3.Name = "ComboBox_key3";
			global::System.Windows.Forms.Control comboBox_key6 = this.ComboBox_key3;
			size = new global::System.Drawing.Size(86, 21);
			comboBox_key6.Size = size;
			this.ComboBox_key3.TabIndex = 3;
			this.TextBox_Keys.BackColor = global::System.Drawing.Color.White;
			this.TextBox_Keys.Enabled = false;
			global::System.Windows.Forms.Control textBox_Keys = this.TextBox_Keys;
			location = new global::System.Drawing.Point(10, 56);
			textBox_Keys.Location = location;
			this.TextBox_Keys.Name = "TextBox_Keys";
			this.TextBox_Keys.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_Keys2 = this.TextBox_Keys;
			size = new global::System.Drawing.Size(270, 20);
			textBox_Keys2.Size = size;
			this.TextBox_Keys.TabIndex = 4;
			this.TextBox_Keys.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Button_Apply.Enabled = false;
			global::System.Windows.Forms.Control button_Apply = this.Button_Apply;
			location = new global::System.Drawing.Point(289, 87);
			button_Apply.Location = location;
			this.Button_Apply.Name = "Button_Apply";
			global::System.Windows.Forms.Control button_Apply2 = this.Button_Apply;
			size = new global::System.Drawing.Size(54, 23);
			button_Apply2.Size = size;
			this.Button_Apply.TabIndex = 5;
			this.Button_Apply.Text = "Save";
			this.Button_Apply.UseMnemonic = false;
			this.Button_Apply.UseVisualStyleBackColor = true;
			this.Button_CopyKey.Enabled = false;
			global::System.Windows.Forms.Control button_CopyKey = this.Button_CopyKey;
			location = new global::System.Drawing.Point(289, 24);
			button_CopyKey.Location = location;
			this.Button_CopyKey.Name = "Button_CopyKey";
			global::System.Windows.Forms.Control button_CopyKey2 = this.Button_CopyKey;
			size = new global::System.Drawing.Size(54, 53);
			button_CopyKey2.Size = size;
			this.Button_CopyKey.TabIndex = 6;
			this.Button_CopyKey.Text = "Copy Key";
			this.Button_CopyKey.UseVisualStyleBackColor = true;
			this.ComboBox_KeyName.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_KeyName.Enabled = false;
			this.ComboBox_KeyName.FormattingEnabled = true;
			this.ComboBox_KeyName.Items.AddRange(new object[]
			{
				"ScreenshotKey ( XMB, GAME, POPS )",
				"ScreenshotKey ( GAME, POPS )",
				"ScreenshotKey ( XMB )",
				"ScreenshotKey ( GAME )",
				"ScreenshotKey ( POPS )"
			});
			global::System.Windows.Forms.Control comboBox_KeyName = this.ComboBox_KeyName;
			location = new global::System.Drawing.Point(10, 88);
			comboBox_KeyName.Location = location;
			this.ComboBox_KeyName.Name = "ComboBox_KeyName";
			global::System.Windows.Forms.Control comboBox_KeyName2 = this.ComboBox_KeyName;
			size = new global::System.Drawing.Size(270, 21);
			comboBox_KeyName2.Size = size;
			this.ComboBox_KeyName.TabIndex = 8;
			global::System.Windows.Forms.Control button_VisitPage = this.Button_VisitPage;
			location = new global::System.Drawing.Point(9, 24);
			button_VisitPage.Location = location;
			this.Button_VisitPage.Name = "Button_VisitPage";
			global::System.Windows.Forms.Control button_VisitPage2 = this.Button_VisitPage;
			size = new global::System.Drawing.Size(108, 23);
			button_VisitPage2.Size = size;
			this.Button_VisitPage.TabIndex = 9;
			this.Button_VisitPage.Text = "Visit Home Page";
			this.Button_VisitPage.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button_Donate = this.Button_Donate;
			location = new global::System.Drawing.Point(123, 24);
			button_Donate.Location = location;
			this.Button_Donate.Name = "Button_Donate";
			global::System.Windows.Forms.Control button_Donate2 = this.Button_Donate;
			size = new global::System.Drawing.Size(108, 23);
			button_Donate2.Size = size;
			this.Button_Donate.TabIndex = 10;
			this.Button_Donate.Text = "Donate";
			this.Button_Donate.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.ComboBox_KeyName);
			this.GroupBox1.Controls.Add(this.Button_Apply);
			this.GroupBox1.Controls.Add(this.ComboBox_key1);
			this.GroupBox1.Controls.Add(this.ComboBox_key2);
			this.GroupBox1.Controls.Add(this.ComboBox_key3);
			this.GroupBox1.Controls.Add(this.TextBox_Keys);
			this.GroupBox1.Controls.Add(this.Button_CopyKey);
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			location = new global::System.Drawing.Point(12, 12);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			size = new global::System.Drawing.Size(354, 124);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 11;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "PSP Control Keys:";
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Controls.Add(this.Button_VisitPage);
			this.GroupBox2.Controls.Add(this.Button_Donate);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new global::System.Drawing.Point(12, 319);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new global::System.Drawing.Size(354, 59);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 13;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Other:";
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(237, 24);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(108, 23);
			button2.Size = size;
			this.Button1.TabIndex = 11;
			this.Button1.Text = "About";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBox_Misc.Controls.Add(this.NumericUpDown_SaveToPICTURE);
			this.GroupBox_Misc.Controls.Add(this.Label_SaveToPICTURE);
			this.GroupBox_Misc.Controls.Add(this.Button_SaveMisc);
			this.GroupBox_Misc.Controls.Add(this.TextBox_ScreenshotName);
			this.GroupBox_Misc.Controls.Add(this.NumericUpDown_UseGameID);
			this.GroupBox_Misc.Controls.Add(this.Label_UseGameID);
			this.GroupBox_Misc.Controls.Add(this.Label_ScreenshotName);
			this.GroupBox_Misc.Controls.Add(this.NumericUpDown_CreatePic1);
			this.GroupBox_Misc.Controls.Add(this.NumericUpDown_PSPGoUseMS0);
			this.GroupBox_Misc.Controls.Add(this.NumericUpDown_KeyTimeout);
			this.GroupBox_Misc.Controls.Add(this.NumericUpDown_XMBClearCache);
			this.GroupBox_Misc.Controls.Add(this.Label_KeyTimeout);
			this.GroupBox_Misc.Controls.Add(this.Label_XMBClearCache);
			this.GroupBox_Misc.Controls.Add(this.Label_PSPGoUseMS0);
			this.GroupBox_Misc.Controls.Add(this.Label_CreatePic1);
			global::System.Windows.Forms.Control groupBox_Misc = this.GroupBox_Misc;
			location = new global::System.Drawing.Point(12, 142);
			groupBox_Misc.Location = location;
			this.GroupBox_Misc.Name = "GroupBox_Misc";
			global::System.Windows.Forms.Control groupBox_Misc2 = this.GroupBox_Misc;
			size = new global::System.Drawing.Size(354, 171);
			groupBox_Misc2.Size = size;
			this.GroupBox_Misc.TabIndex = 14;
			this.GroupBox_Misc.TabStop = false;
			this.GroupBox_Misc.Text = "Misc: ( Loaded from \"prxshot_mod.ini\" )";
			global::System.Windows.Forms.Control numericUpDown_SaveToPICTURE = this.NumericUpDown_SaveToPICTURE;
			location = new global::System.Drawing.Point(110, 139);
			numericUpDown_SaveToPICTURE.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown_SaveToPICTURE2 = this.NumericUpDown_SaveToPICTURE;
			decimal maximum = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_SaveToPICTURE2.Maximum = maximum;
			this.NumericUpDown_SaveToPICTURE.Name = "NumericUpDown_SaveToPICTURE";
			global::System.Windows.Forms.Control numericUpDown_SaveToPICTURE3 = this.NumericUpDown_SaveToPICTURE;
			size = new global::System.Drawing.Size(42, 20);
			numericUpDown_SaveToPICTURE3.Size = size;
			this.NumericUpDown_SaveToPICTURE.TabIndex = 13;
			this.Label_SaveToPICTURE.AutoSize = true;
			global::System.Windows.Forms.Control label_SaveToPICTURE = this.Label_SaveToPICTURE;
			location = new global::System.Drawing.Point(10, 142);
			label_SaveToPICTURE.Location = location;
			this.Label_SaveToPICTURE.Name = "Label_SaveToPICTURE";
			global::System.Windows.Forms.Control label_SaveToPICTURE2 = this.Label_SaveToPICTURE;
			size = new global::System.Drawing.Size(90, 13);
			label_SaveToPICTURE2.Size = size;
			this.Label_SaveToPICTURE.TabIndex = 12;
			this.Label_SaveToPICTURE.Text = "SaveToPICTURE:";
			global::System.Windows.Forms.Control button_SaveMisc = this.Button_SaveMisc;
			location = new global::System.Drawing.Point(165, 70);
			button_SaveMisc.Location = location;
			this.Button_SaveMisc.Name = "Button_SaveMisc";
			global::System.Windows.Forms.Control button_SaveMisc2 = this.Button_SaveMisc;
			size = new global::System.Drawing.Size(179, 89);
			button_SaveMisc2.Size = size;
			this.Button_SaveMisc.TabIndex = 9;
			this.Button_SaveMisc.Text = "Save";
			this.Button_SaveMisc.UseMnemonic = false;
			this.Button_SaveMisc.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control textBox_ScreenshotName = this.TextBox_ScreenshotName;
			location = new global::System.Drawing.Point(165, 43);
			textBox_ScreenshotName.Location = location;
			this.TextBox_ScreenshotName.Name = "TextBox_ScreenshotName";
			global::System.Windows.Forms.Control textBox_ScreenshotName2 = this.TextBox_ScreenshotName;
			size = new global::System.Drawing.Size(179, 20);
			textBox_ScreenshotName2.Size = size;
			this.TextBox_ScreenshotName.TabIndex = 11;
			global::System.Windows.Forms.Control numericUpDown_UseGameID = this.NumericUpDown_UseGameID;
			location = new global::System.Drawing.Point(110, 113);
			numericUpDown_UseGameID.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown_UseGameID2 = this.NumericUpDown_UseGameID;
			maximum = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_UseGameID2.Maximum = maximum;
			this.NumericUpDown_UseGameID.Name = "NumericUpDown_UseGameID";
			global::System.Windows.Forms.Control numericUpDown_UseGameID3 = this.NumericUpDown_UseGameID;
			size = new global::System.Drawing.Size(42, 20);
			numericUpDown_UseGameID3.Size = size;
			this.NumericUpDown_UseGameID.TabIndex = 10;
			this.Label_UseGameID.AutoSize = true;
			global::System.Windows.Forms.Control label_UseGameID = this.Label_UseGameID;
			location = new global::System.Drawing.Point(10, 116);
			label_UseGameID.Location = location;
			this.Label_UseGameID.Name = "Label_UseGameID";
			global::System.Windows.Forms.Control label_UseGameID2 = this.Label_UseGameID;
			size = new global::System.Drawing.Size(67, 13);
			label_UseGameID2.Size = size;
			this.Label_UseGameID.TabIndex = 9;
			this.Label_UseGameID.Text = "UseGameID:";
			this.Label_ScreenshotName.AutoSize = true;
			global::System.Windows.Forms.Control label_ScreenshotName = this.Label_ScreenshotName;
			location = new global::System.Drawing.Point(162, 23);
			label_ScreenshotName.Location = location;
			this.Label_ScreenshotName.Name = "Label_ScreenshotName";
			global::System.Windows.Forms.Control label_ScreenshotName2 = this.Label_ScreenshotName;
			size = new global::System.Drawing.Size(92, 13);
			label_ScreenshotName2.Size = size;
			this.Label_ScreenshotName.TabIndex = 8;
			this.Label_ScreenshotName.Text = "ScreenshotName:";
			global::System.Windows.Forms.Control numericUpDown_CreatePic = this.NumericUpDown_CreatePic1;
			location = new global::System.Drawing.Point(110, 21);
			numericUpDown_CreatePic.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown_CreatePic2 = this.NumericUpDown_CreatePic1;
			maximum = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_CreatePic2.Maximum = maximum;
			this.NumericUpDown_CreatePic1.Name = "NumericUpDown_CreatePic1";
			global::System.Windows.Forms.Control numericUpDown_CreatePic3 = this.NumericUpDown_CreatePic1;
			size = new global::System.Drawing.Size(42, 20);
			numericUpDown_CreatePic3.Size = size;
			this.NumericUpDown_CreatePic1.TabIndex = 7;
			global::System.Windows.Forms.Control numericUpDown_PSPGoUseMS = this.NumericUpDown_PSPGoUseMS0;
			location = new global::System.Drawing.Point(110, 44);
			numericUpDown_PSPGoUseMS.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown_PSPGoUseMS2 = this.NumericUpDown_PSPGoUseMS0;
			maximum = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_PSPGoUseMS2.Maximum = maximum;
			this.NumericUpDown_PSPGoUseMS0.Name = "NumericUpDown_PSPGoUseMS0";
			global::System.Windows.Forms.Control numericUpDown_PSPGoUseMS3 = this.NumericUpDown_PSPGoUseMS0;
			size = new global::System.Drawing.Size(42, 20);
			numericUpDown_PSPGoUseMS3.Size = size;
			this.NumericUpDown_PSPGoUseMS0.TabIndex = 6;
			global::System.Windows.Forms.Control numericUpDown_KeyTimeout = this.NumericUpDown_KeyTimeout;
			location = new global::System.Drawing.Point(110, 90);
			numericUpDown_KeyTimeout.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown_KeyTimeout2 = this.NumericUpDown_KeyTimeout;
			maximum = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_KeyTimeout2.Maximum = maximum;
			this.NumericUpDown_KeyTimeout.Name = "NumericUpDown_KeyTimeout";
			global::System.Windows.Forms.Control numericUpDown_KeyTimeout3 = this.NumericUpDown_KeyTimeout;
			size = new global::System.Drawing.Size(42, 20);
			numericUpDown_KeyTimeout3.Size = size;
			this.NumericUpDown_KeyTimeout.TabIndex = 5;
			global::System.Windows.Forms.Control numericUpDown_XMBClearCache = this.NumericUpDown_XMBClearCache;
			location = new global::System.Drawing.Point(110, 67);
			numericUpDown_XMBClearCache.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown_XMBClearCache2 = this.NumericUpDown_XMBClearCache;
			maximum = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_XMBClearCache2.Maximum = maximum;
			this.NumericUpDown_XMBClearCache.Name = "NumericUpDown_XMBClearCache";
			global::System.Windows.Forms.Control numericUpDown_XMBClearCache3 = this.NumericUpDown_XMBClearCache;
			size = new global::System.Drawing.Size(42, 20);
			numericUpDown_XMBClearCache3.Size = size;
			this.NumericUpDown_XMBClearCache.TabIndex = 4;
			this.Label_KeyTimeout.AutoSize = true;
			global::System.Windows.Forms.Control label_KeyTimeout = this.Label_KeyTimeout;
			location = new global::System.Drawing.Point(10, 93);
			label_KeyTimeout.Location = location;
			this.Label_KeyTimeout.Name = "Label_KeyTimeout";
			global::System.Windows.Forms.Control label_KeyTimeout2 = this.Label_KeyTimeout;
			size = new global::System.Drawing.Size(67, 13);
			label_KeyTimeout2.Size = size;
			this.Label_KeyTimeout.TabIndex = 3;
			this.Label_KeyTimeout.Text = "KeyTimeout:";
			this.Label_XMBClearCache.AutoSize = true;
			global::System.Windows.Forms.Control label_XMBClearCache = this.Label_XMBClearCache;
			location = new global::System.Drawing.Point(8, 70);
			label_XMBClearCache.Location = location;
			this.Label_XMBClearCache.Name = "Label_XMBClearCache";
			global::System.Windows.Forms.Control label_XMBClearCache2 = this.Label_XMBClearCache;
			size = new global::System.Drawing.Size(86, 13);
			label_XMBClearCache2.Size = size;
			this.Label_XMBClearCache.TabIndex = 2;
			this.Label_XMBClearCache.Text = "XMBClearCache:";
			this.Label_PSPGoUseMS0.AutoSize = true;
			global::System.Windows.Forms.Control label_PSPGoUseMS = this.Label_PSPGoUseMS0;
			location = new global::System.Drawing.Point(8, 47);
			label_PSPGoUseMS.Location = location;
			this.Label_PSPGoUseMS0.Name = "Label_PSPGoUseMS0";
			global::System.Windows.Forms.Control label_PSPGoUseMS2 = this.Label_PSPGoUseMS0;
			size = new global::System.Drawing.Size(80, 13);
			label_PSPGoUseMS2.Size = size;
			this.Label_PSPGoUseMS0.TabIndex = 1;
			this.Label_PSPGoUseMS0.Text = "PSPGoUseMS0:";
			this.Label_CreatePic1.AutoSize = true;
			global::System.Windows.Forms.Control label_CreatePic = this.Label_CreatePic1;
			location = new global::System.Drawing.Point(8, 24);
			label_CreatePic.Location = location;
			this.Label_CreatePic1.Name = "Label_CreatePic1";
			global::System.Windows.Forms.Control label_CreatePic2 = this.Label_CreatePic1;
			size = new global::System.Drawing.Size(63, 13);
			label_CreatePic2.Size = size;
			this.Label_CreatePic1.TabIndex = 0;
			this.Label_CreatePic1.Text = "CreatePic1:";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(378, 414);
			this.ClientSize = size;
			this.Controls.Add(this.GroupBox_Misc);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.TextBox_path);
			this.ForeColor = global::System.Drawing.Color.Black;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			size = new global::System.Drawing.Size(384, 442);
			this.MaximumSize = size;
			size = new global::System.Drawing.Size(384, 442);
			this.MinimumSize = size;
			this.Name = "PRXShotModConfig";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PRXShotMod Config By LMAN v0.2";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox_Misc.ResumeLayout(false);
			this.GroupBox_Misc.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_SaveToPICTURE).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_UseGameID).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_CreatePic1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_PSPGoUseMS0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_KeyTimeout).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown_XMBClearCache).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000017 RID: 23
		private global::System.ComponentModel.IContainer components;
	}
}
