namespace AzureHAXX
{
	// Token: 0x0200000C RID: 12
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000091 RID: 145 RVA: 0x000131C4 File Offset: 0x000113C4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000131FC File Offset: 0x000113FC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AzureHAXX.Form1));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticonePanel3 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticonePanel1 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.siticonePanel4 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.siticoneCustomCheckBox1 = new global::Siticone.UI.WinForms.SiticoneCustomCheckBox();
			this.siticoneProgressBar1 = new global::Siticone.UI.WinForms.SiticoneProgressBar();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.az_HOME1 = new global::AzureHAXX.az_HOME();
			this.az_PLAYER1 = new global::AzureHAXX.az_PLAYER();
			this.az_WEAPON1 = new global::AzureHAXX.az_WEAPON();
			this.az_EDITMODE1 = new global::AzureHAXX.az_EDITMODE();
			this.az_ANIMATIONS1 = new global::AzureHAXX.az_ANIMATIONS();
			this.az_SPAWN1 = new global::AzureHAXX.az_SPAWN();
			this.az_CAR1 = new global::AzureHAXX.az_CAR();
			this.az_OTHERS1 = new global::AzureHAXX.az_OTHERS();
			this.siticonePanel2 = new global::Siticone.UI.WinForms.SiticonePanel();
			this.siticoneButton8 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton7 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton6 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton5 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton4 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton3 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton2 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton1 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton10 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticoneButton9 = new global::Siticone.UI.WinForms.SiticoneButton();
			this.siticonePictureBox1 = new global::Siticone.UI.WinForms.SiticonePictureBox();
			this.siticoneShadowForm1 = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.timerProcess = new global::System.Windows.Forms.Timer(this.components);
			this.siticonePanel3.SuspendLayout();
			this.siticonePanel1.SuspendLayout();
			this.siticonePanel4.SuspendLayout();
			this.siticonePanel2.SuspendLayout();
			this.siticonePictureBox1.BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this.siticonePanel3;
			this.siticonePanel3.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.siticonePanel3.Controls.Add(this.siticoneControlBox2);
			this.siticonePanel3.Controls.Add(this.siticoneControlBox1);
			this.siticonePanel3.Location = new global::System.Drawing.Point(117, 0);
			this.siticonePanel3.Name = "siticonePanel3";
			this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
			this.siticonePanel3.Size = new global::System.Drawing.Size(456, 32);
			this.siticonePanel3.TabIndex = 0;
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(366, 0);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 32);
			this.siticoneControlBox2.TabIndex = 1;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(411, 0);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 32);
			this.siticoneControlBox1.TabIndex = 0;
			this.siticonePanel1.BackColor = global::System.Drawing.Color.FromArgb(54, 57, 63);
			this.siticonePanel1.Controls.Add(this.siticonePanel4);
			this.siticonePanel1.Controls.Add(this.az_HOME1);
			this.siticonePanel1.Controls.Add(this.az_PLAYER1);
			this.siticonePanel1.Controls.Add(this.az_WEAPON1);
			this.siticonePanel1.Controls.Add(this.az_EDITMODE1);
			this.siticonePanel1.Controls.Add(this.az_ANIMATIONS1);
			this.siticonePanel1.Controls.Add(this.az_SPAWN1);
			this.siticonePanel1.Controls.Add(this.az_CAR1);
			this.siticonePanel1.Controls.Add(this.az_OTHERS1);
			this.siticonePanel1.Controls.Add(this.siticonePanel2);
			this.siticonePanel1.Controls.Add(this.siticonePanel3);
			this.siticonePanel1.Location = new global::System.Drawing.Point(2, 1);
			this.siticonePanel1.Name = "siticonePanel1";
			this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
			this.siticonePanel1.Size = new global::System.Drawing.Size(571, 339);
			this.siticonePanel1.TabIndex = 0;
			this.siticonePanel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
			this.siticonePanel4.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.siticonePanel4.Controls.Add(this.label5);
			this.siticonePanel4.Controls.Add(this.label4);
			this.siticonePanel4.Controls.Add(this.siticoneCustomCheckBox1);
			this.siticonePanel4.Controls.Add(this.siticoneProgressBar1);
			this.siticonePanel4.Controls.Add(this.label3);
			this.siticonePanel4.Controls.Add(this.label6);
			this.siticonePanel4.Location = new global::System.Drawing.Point(124, 309);
			this.siticonePanel4.Name = "siticonePanel4";
			this.siticonePanel4.ShadowDecoration.Parent = this.siticonePanel4;
			this.siticonePanel4.Size = new global::System.Drawing.Size(439, 25);
			this.siticonePanel4.TabIndex = 16;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label5.ForeColor = global::System.Drawing.Color.LightCoral;
			this.label5.Location = new global::System.Drawing.Point(80, 4);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(30, 15);
			this.label5.TabIndex = 19;
			this.label5.Text = "OFF";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(6, 4);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(46, 15);
			this.label4.TabIndex = 18;
			this.label4.Text = "AntBan";
			this.siticoneCustomCheckBox1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(53, 53, 53);
			this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckMarkColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.Location = new global::System.Drawing.Point(56, 2);
			this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.Size = new global::System.Drawing.Size(20, 20);
			this.siticoneCustomCheckBox1.TabIndex = 17;
			this.siticoneCustomCheckBox1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			this.siticoneCustomCheckBox1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
			this.siticoneCustomCheckBox1.CheckedChanged += new global::System.EventHandler(this.siticoneCustomCheckBox1_CheckedChanged);
			this.siticoneProgressBar1.BorderRadius = 5;
			this.siticoneProgressBar1.FillColor = global::System.Drawing.Color.FromArgb(54, 57, 63);
			this.siticoneProgressBar1.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.siticoneProgressBar1.Location = new global::System.Drawing.Point(116, 4);
			this.siticoneProgressBar1.Name = "siticoneProgressBar1";
			this.siticoneProgressBar1.ProgressColor = global::System.Drawing.Color.FromArgb(240, 71, 71);
			this.siticoneProgressBar1.ProgressColor2 = global::System.Drawing.Color.FromArgb(240, 71, 71);
			this.siticoneProgressBar1.ShadowDecoration.Parent = this.siticoneProgressBar1;
			this.siticoneProgressBar1.Size = new global::System.Drawing.Size(182, 18);
			this.siticoneProgressBar1.TabIndex = 16;
			this.siticoneProgressBar1.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(365, 5);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(69, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "OFFLINE !";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(304, 5);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(66, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "STATUS:";
			this.az_HOME1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_HOME1.Location = new global::System.Drawing.Point(124, 39);
			this.az_HOME1.Name = "az_HOME1";
			this.az_HOME1.Size = new global::System.Drawing.Size(439, 267);
			this.az_HOME1.TabIndex = 11;
			this.az_HOME1.Load += new global::System.EventHandler(this.az_HOME1_Load);
			this.az_PLAYER1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_PLAYER1.Location = new global::System.Drawing.Point(125, 39);
			this.az_PLAYER1.Name = "az_PLAYER1";
			this.az_PLAYER1.Size = new global::System.Drawing.Size(439, 267);
			this.az_PLAYER1.TabIndex = 10;
			this.az_WEAPON1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_WEAPON1.Location = new global::System.Drawing.Point(125, 39);
			this.az_WEAPON1.Name = "az_WEAPON1";
			this.az_WEAPON1.Size = new global::System.Drawing.Size(439, 267);
			this.az_WEAPON1.TabIndex = 9;
			this.az_EDITMODE1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_EDITMODE1.Location = new global::System.Drawing.Point(125, 39);
			this.az_EDITMODE1.Name = "az_EDITMODE1";
			this.az_EDITMODE1.Size = new global::System.Drawing.Size(439, 267);
			this.az_EDITMODE1.TabIndex = 8;
			this.az_ANIMATIONS1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_ANIMATIONS1.Location = new global::System.Drawing.Point(125, 39);
			this.az_ANIMATIONS1.Name = "az_ANIMATIONS1";
			this.az_ANIMATIONS1.Size = new global::System.Drawing.Size(439, 267);
			this.az_ANIMATIONS1.TabIndex = 7;
			this.az_SPAWN1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_SPAWN1.Location = new global::System.Drawing.Point(125, 39);
			this.az_SPAWN1.Name = "az_SPAWN1";
			this.az_SPAWN1.Size = new global::System.Drawing.Size(439, 267);
			this.az_SPAWN1.TabIndex = 6;
			this.az_CAR1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_CAR1.Location = new global::System.Drawing.Point(125, 39);
			this.az_CAR1.Name = "az_CAR1";
			this.az_CAR1.Size = new global::System.Drawing.Size(439, 267);
			this.az_CAR1.TabIndex = 5;
			this.az_OTHERS1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.az_OTHERS1.Location = new global::System.Drawing.Point(125, 39);
			this.az_OTHERS1.Name = "az_OTHERS1";
			this.az_OTHERS1.Size = new global::System.Drawing.Size(439, 267);
			this.az_OTHERS1.TabIndex = 4;
			this.siticonePanel2.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.siticonePanel2.Controls.Add(this.siticoneButton8);
			this.siticonePanel2.Controls.Add(this.siticoneButton7);
			this.siticonePanel2.Controls.Add(this.siticoneButton6);
			this.siticonePanel2.Controls.Add(this.siticoneButton5);
			this.siticonePanel2.Controls.Add(this.siticoneButton4);
			this.siticonePanel2.Controls.Add(this.siticoneButton3);
			this.siticonePanel2.Controls.Add(this.siticoneButton2);
			this.siticonePanel2.Controls.Add(this.siticoneButton1);
			this.siticonePanel2.Controls.Add(this.siticoneButton10);
			this.siticonePanel2.Controls.Add(this.siticoneButton9);
			this.siticonePanel2.Controls.Add(this.siticonePictureBox1);
			this.siticonePanel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.siticonePanel2.Location = new global::System.Drawing.Point(0, 0);
			this.siticonePanel2.Name = "siticonePanel2";
			this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
			this.siticonePanel2.Size = new global::System.Drawing.Size(117, 339);
			this.siticonePanel2.TabIndex = 3;
			this.siticoneButton8.BorderRadius = 4;
			this.siticoneButton8.ButtonMode = 1;
			this.siticoneButton8.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton8.CheckedState.Parent = this.siticoneButton8;
			this.siticoneButton8.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton8.CustomImages.Parent = this.siticoneButton8;
			this.siticoneButton8.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton8.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton8.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton8.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton8.HoveredState.Parent = this.siticoneButton8;
			this.siticoneButton8.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton8.Location = new global::System.Drawing.Point(5, 277);
			this.siticoneButton8.Name = "siticoneButton8";
			this.siticoneButton8.PressedDepth = 0;
			this.siticoneButton8.ShadowDecoration.Parent = this.siticoneButton8;
			this.siticoneButton8.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton8.TabIndex = 45;
			this.siticoneButton8.Text = "Others";
			this.siticoneButton8.CheckedChanged += new global::System.EventHandler(this.siticoneButton8_CheckedChanged);
			this.siticoneButton7.BorderRadius = 4;
			this.siticoneButton7.ButtonMode = 1;
			this.siticoneButton7.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton7.CheckedState.Parent = this.siticoneButton7;
			this.siticoneButton7.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton7.CustomImages.Parent = this.siticoneButton7;
			this.siticoneButton7.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton7.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton7.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton7.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton7.HoveredState.Parent = this.siticoneButton7;
			this.siticoneButton7.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton7.Location = new global::System.Drawing.Point(5, 242);
			this.siticoneButton7.Name = "siticoneButton7";
			this.siticoneButton7.PressedDepth = 0;
			this.siticoneButton7.ShadowDecoration.Parent = this.siticoneButton7;
			this.siticoneButton7.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton7.TabIndex = 44;
			this.siticoneButton7.Text = "Psyhics";
			this.siticoneButton7.CheckedChanged += new global::System.EventHandler(this.siticoneButton7_CheckedChanged_1);
			this.siticoneButton7.Click += new global::System.EventHandler(this.siticoneButton7_Click);
			this.siticoneButton6.BorderRadius = 4;
			this.siticoneButton6.ButtonMode = 1;
			this.siticoneButton6.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton6.CheckedState.Parent = this.siticoneButton6;
			this.siticoneButton6.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton6.CustomImages.Parent = this.siticoneButton6;
			this.siticoneButton6.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton6.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton6.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton6.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton6.HoveredState.Parent = this.siticoneButton6;
			this.siticoneButton6.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton6.Location = new global::System.Drawing.Point(5, 207);
			this.siticoneButton6.Name = "siticoneButton6";
			this.siticoneButton6.PressedDepth = 0;
			this.siticoneButton6.ShadowDecoration.Parent = this.siticoneButton6;
			this.siticoneButton6.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton6.TabIndex = 43;
			this.siticoneButton6.Text = "Spawn";
			this.siticoneButton6.CheckedChanged += new global::System.EventHandler(this.siticoneButton6_CheckedChanged_1);
			this.siticoneButton5.BorderRadius = 4;
			this.siticoneButton5.ButtonMode = 1;
			this.siticoneButton5.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
			this.siticoneButton5.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
			this.siticoneButton5.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton5.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton5.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton5.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
			this.siticoneButton5.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton5.Location = new global::System.Drawing.Point(5, 172);
			this.siticoneButton5.Name = "siticoneButton5";
			this.siticoneButton5.PressedDepth = 0;
			this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
			this.siticoneButton5.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton5.TabIndex = 42;
			this.siticoneButton5.Text = "Animations";
			this.siticoneButton5.CheckedChanged += new global::System.EventHandler(this.siticoneButton5_CheckedChanged_1);
			this.siticoneButton4.BorderRadius = 4;
			this.siticoneButton4.ButtonMode = 1;
			this.siticoneButton4.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
			this.siticoneButton4.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
			this.siticoneButton4.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton4.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton4.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
			this.siticoneButton4.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton4.Location = new global::System.Drawing.Point(5, 137);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.PressedDepth = 0;
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton4.TabIndex = 41;
			this.siticoneButton4.Text = "EditMode";
			this.siticoneButton4.CheckedChanged += new global::System.EventHandler(this.siticoneButton4_CheckedChanged);
			this.siticoneButton3.BorderRadius = 4;
			this.siticoneButton3.ButtonMode = 1;
			this.siticoneButton3.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
			this.siticoneButton3.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
			this.siticoneButton3.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton3.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
			this.siticoneButton3.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton3.Location = new global::System.Drawing.Point(5, 102);
			this.siticoneButton3.Name = "siticoneButton3";
			this.siticoneButton3.PressedDepth = 0;
			this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
			this.siticoneButton3.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton3.TabIndex = 40;
			this.siticoneButton3.Text = "Weapon";
			this.siticoneButton3.Click += new global::System.EventHandler(this.siticoneButton3_Click);
			this.siticoneButton2.BorderRadius = 4;
			this.siticoneButton2.ButtonMode = 1;
			this.siticoneButton2.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneButton2.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton2.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
			this.siticoneButton2.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton2.Location = new global::System.Drawing.Point(5, 67);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.PressedDepth = 0;
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton2.TabIndex = 39;
			this.siticoneButton2.Text = "Player";
			this.siticoneButton2.Click += new global::System.EventHandler(this.siticoneButton2_Click);
			this.siticoneButton1.BorderRadius = 4;
			this.siticoneButton1.ButtonMode = 1;
			this.siticoneButton1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(162, 72, 72);
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			this.siticoneButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton1.HoveredState.CustomBorderColor = global::System.Drawing.Color.FromArgb(108, 48, 48);
			this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
			this.siticoneButton1.ImageSize = new global::System.Drawing.Size(18, 18);
			this.siticoneButton1.Location = new global::System.Drawing.Point(5, 32);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.PressedDepth = 0;
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new global::System.Drawing.Size(106, 29);
			this.siticoneButton1.TabIndex = 38;
			this.siticoneButton1.Text = "Home";
			this.siticoneButton1.CheckedChanged += new global::System.EventHandler(this.siticoneButton1_CheckedChanged);
			this.siticoneButton10.CheckedState.Parent = this.siticoneButton10;
			this.siticoneButton10.CustomImages.Parent = this.siticoneButton10;
			this.siticoneButton10.FillColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.siticoneButton10.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton10.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton10.HoveredState.Parent = this.siticoneButton10;
			this.siticoneButton10.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneButton10.Image");
			this.siticoneButton10.Location = new global::System.Drawing.Point(61, 310);
			this.siticoneButton10.Name = "siticoneButton10";
			this.siticoneButton10.ShadowDecoration.Parent = this.siticoneButton10;
			this.siticoneButton10.Size = new global::System.Drawing.Size(48, 26);
			this.siticoneButton10.TabIndex = 9;
			this.siticoneButton10.Click += new global::System.EventHandler(this.siticoneButton10_Click);
			this.siticoneButton9.CheckedState.Parent = this.siticoneButton9;
			this.siticoneButton9.CustomImages.Parent = this.siticoneButton9;
			this.siticoneButton9.FillColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.siticoneButton9.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.siticoneButton9.ForeColor = global::System.Drawing.Color.White;
			this.siticoneButton9.HoveredState.Parent = this.siticoneButton9;
			this.siticoneButton9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneButton9.Image");
			this.siticoneButton9.Location = new global::System.Drawing.Point(8, 310);
			this.siticoneButton9.Name = "siticoneButton9";
			this.siticoneButton9.ShadowDecoration.Parent = this.siticoneButton9;
			this.siticoneButton9.Size = new global::System.Drawing.Size(48, 26);
			this.siticoneButton9.TabIndex = 8;
			this.siticonePictureBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 38, 42);
			this.siticonePictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticonePictureBox1.Image");
			this.siticonePictureBox1.Location = new global::System.Drawing.Point(-2, -5);
			this.siticonePictureBox1.Name = "siticonePictureBox1";
			this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
			this.siticonePictureBox1.Size = new global::System.Drawing.Size(117, 37);
			this.siticonePictureBox1.TabIndex = 4;
			this.siticonePictureBox1.TabStop = false;
			this.timerProcess.Enabled = true;
			this.timerProcess.Tick += new global::System.EventHandler(this.timerProcess_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(243, 109, 109);
			base.ClientSize = new global::System.Drawing.Size(576, 342);
			base.ControlBox = false;
			base.Controls.Add(this.siticonePanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.siticonePanel3.ResumeLayout(false);
			this.siticonePanel1.ResumeLayout(false);
			this.siticonePanel4.ResumeLayout(false);
			this.siticonePanel4.PerformLayout();
			this.siticonePanel2.ResumeLayout(false);
			this.siticonePictureBox1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400013F RID: 319
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000140 RID: 320
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000141 RID: 321
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel1;

		// Token: 0x04000142 RID: 322
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel2;

		// Token: 0x04000143 RID: 323
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel3;

		// Token: 0x04000144 RID: 324
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000145 RID: 325
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000146 RID: 326
		private global::Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;

		// Token: 0x04000147 RID: 327
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton10;

		// Token: 0x04000148 RID: 328
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton9;

		// Token: 0x04000149 RID: 329
		private global::AzureHAXX.az_SPAWN az_SPAWN1;

		// Token: 0x0400014A RID: 330
		private global::AzureHAXX.az_CAR az_CAR1;

		// Token: 0x0400014B RID: 331
		private global::AzureHAXX.az_OTHERS az_OTHERS1;

		// Token: 0x0400014C RID: 332
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton8;

		// Token: 0x0400014D RID: 333
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton7;

		// Token: 0x0400014E RID: 334
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton6;

		// Token: 0x0400014F RID: 335
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton5;

		// Token: 0x04000150 RID: 336
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton4;

		// Token: 0x04000151 RID: 337
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton3;

		// Token: 0x04000152 RID: 338
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton2;

		// Token: 0x04000153 RID: 339
		private global::Siticone.UI.WinForms.SiticoneButton siticoneButton1;

		// Token: 0x04000154 RID: 340
		private global::AzureHAXX.az_HOME az_HOME1;

		// Token: 0x04000155 RID: 341
		private global::AzureHAXX.az_PLAYER az_PLAYER1;

		// Token: 0x04000156 RID: 342
		private global::AzureHAXX.az_WEAPON az_WEAPON1;

		// Token: 0x04000157 RID: 343
		private global::AzureHAXX.az_EDITMODE az_EDITMODE1;

		// Token: 0x04000158 RID: 344
		private global::AzureHAXX.az_ANIMATIONS az_ANIMATIONS1;

		// Token: 0x04000159 RID: 345
		private global::Siticone.UI.WinForms.SiticonePanel siticonePanel4;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400015E RID: 350
		private global::Siticone.UI.WinForms.SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x0400015F RID: 351
		private global::Siticone.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;

		// Token: 0x04000160 RID: 352
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.Timer timerProcess;
	}
}
