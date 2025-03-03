namespace prxshot_mod_config
{
	// Token: 0x02000008 RID: 8
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000067A0 File Offset: 0x00004BA0
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

		// Token: 0x06000025 RID: 37 RVA: 0x000067F0 File Offset: 0x00004BF0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label_A = new global::System.Windows.Forms.Label();
			this.Button_OK = new global::System.Windows.Forms.Button();
			this.Button_Visit = new global::System.Windows.Forms.Button();
			this.Button_Donate = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			global::System.Windows.Forms.Control label_A = this.Label_A;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 15);
			label_A.Location = location;
			this.Label_A.Name = "Label_A";
			global::System.Windows.Forms.Control label_A2 = this.Label_A;
			global::System.Drawing.Size size = new global::System.Drawing.Size(266, 87);
			label_A2.Size = size;
			this.Label_A.TabIndex = 0;
			this.Label_A.Text = "PRXShot MOD Config By LMAN (c) 2012\r\n\r\nDesigned for PRXShot MOD By LMAN\r\n\r\nPRXShot source code by Codestation";
			this.Label_A.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			global::System.Windows.Forms.Control button_OK = this.Button_OK;
			location = new global::System.Drawing.Point(223, 111);
			button_OK.Location = location;
			this.Button_OK.Name = "Button_OK";
			global::System.Windows.Forms.Control button_OK2 = this.Button_OK;
			size = new global::System.Drawing.Size(55, 23);
			button_OK2.Size = size;
			this.Button_OK.TabIndex = 1;
			this.Button_OK.Text = "OK";
			this.Button_OK.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button_Visit = this.Button_Visit;
			location = new global::System.Drawing.Point(12, 111);
			button_Visit.Location = location;
			this.Button_Visit.Name = "Button_Visit";
			global::System.Windows.Forms.Control button_Visit2 = this.Button_Visit;
			size = new global::System.Drawing.Size(111, 23);
			button_Visit2.Size = size;
			this.Button_Visit.TabIndex = 2;
			this.Button_Visit.Text = "Visit Home Page";
			this.Button_Visit.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button_Donate = this.Button_Donate;
			location = new global::System.Drawing.Point(129, 111);
			button_Donate.Location = location;
			this.Button_Donate.Name = "Button_Donate";
			global::System.Windows.Forms.Control button_Donate2 = this.Button_Donate;
			size = new global::System.Drawing.Size(88, 23);
			button_Donate2.Size = size;
			this.Button_Donate.TabIndex = 3;
			this.Button_Donate.Text = "Donate";
			this.Button_Donate.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			size = new global::System.Drawing.Size(290, 146);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Button_Donate);
			this.Controls.Add(this.Button_Visit);
			this.Controls.Add(this.Button_OK);
			this.Controls.Add(this.Label_A);
			this.ForeColor = global::System.Drawing.Color.Black;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			size = new global::System.Drawing.Size(296, 174);
			this.MaximumSize = size;
			size = new global::System.Drawing.Size(296, 174);
			this.MinimumSize = size;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);
		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components;
	}
}
