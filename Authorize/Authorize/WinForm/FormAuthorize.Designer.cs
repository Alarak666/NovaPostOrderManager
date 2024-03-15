namespace Authorize.WinForm
{
    partial class FormAuthorize
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorize));
            Root = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelImageOrganization = new Panel();
            Logo = new PictureBox();
            panel1 = new Panel();
            MainMenuLayout = new TableLayoutPanel();
            panelButtonLogin = new Panel();
            BLogin = new Button();
            panekButtonClose = new Panel();
            BClose = new Button();
            PUserinfo = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            TPassword = new TextBox();
            TLogin = new TextBox();
            LPassword = new Label();
            LUserName = new Label();
            LDomen = new Label();
            panel3 = new Panel();
            TDomain = new TextBox();
            panel4 = new Panel();
            CBCurrentUserLogin = new CheckBox();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            UserImage = new PictureBox();
            Root.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            PanelImageOrganization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel1.SuspendLayout();
            MainMenuLayout.SuspendLayout();
            panelButtonLogin.SuspendLayout();
            panekButtonClose.SuspendLayout();
            PUserinfo.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserImage).BeginInit();
            SuspendLayout();
            // 
            // Root
            // 
            Root.Controls.Add(tableLayoutPanel1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.Size = new Size(666, 672);
            Root.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(131, 111, 180);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.480484F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.51952F));
            tableLayoutPanel1.Controls.Add(PanelImageOrganization, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 259F));
            tableLayoutPanel1.Size = new Size(666, 672);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelImageOrganization
            // 
            tableLayoutPanel1.SetColumnSpan(PanelImageOrganization, 2);
            PanelImageOrganization.Controls.Add(Logo);
            PanelImageOrganization.Dock = DockStyle.Fill;
            PanelImageOrganization.Location = new Point(3, 43);
            PanelImageOrganization.Name = "PanelImageOrganization";
            PanelImageOrganization.Size = new Size(660, 185);
            PanelImageOrganization.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(131, 111, 180);
            Logo.Dock = DockStyle.Fill;
            Logo.Image = Resource.Resource.logo;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(660, 185);
            Logo.SizeMode = PictureBoxSizeMode.CenterImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(MainMenuLayout);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 253);
            panel1.TabIndex = 3;
            // 
            // MainMenuLayout
            // 
            MainMenuLayout.ColumnCount = 3;
            MainMenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.2585831F));
            MainMenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.7414169F));
            MainMenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            MainMenuLayout.Controls.Add(panelButtonLogin, 1, 1);
            MainMenuLayout.Controls.Add(panekButtonClose, 2, 1);
            MainMenuLayout.Controls.Add(PUserinfo, 0, 0);
            MainMenuLayout.Dock = DockStyle.Fill;
            MainMenuLayout.Location = new Point(0, 0);
            MainMenuLayout.Name = "MainMenuLayout";
            MainMenuLayout.RowCount = 2;
            MainMenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 84.09894F));
            MainMenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15.90106F));
            MainMenuLayout.Size = new Size(660, 253);
            MainMenuLayout.TabIndex = 0;
            // 
            // panelButtonLogin
            // 
            panelButtonLogin.Controls.Add(BLogin);
            panelButtonLogin.Location = new Point(227, 215);
            panelButtonLogin.Name = "panelButtonLogin";
            panelButtonLogin.Size = new Size(207, 35);
            panelButtonLogin.TabIndex = 0;
            // 
            // BLogin
            // 
            BLogin.Dock = DockStyle.Fill;
            BLogin.Location = new Point(0, 0);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(207, 35);
            BLogin.TabIndex = 0;
            BLogin.Text = "Авторизація";
            BLogin.UseVisualStyleBackColor = true;
            BLogin.Click += BLogin_Click;
            // 
            // panekButtonClose
            // 
            panekButtonClose.Controls.Add(BClose);
            panekButtonClose.Location = new Point(440, 215);
            panekButtonClose.Name = "panekButtonClose";
            panekButtonClose.Size = new Size(213, 35);
            panekButtonClose.TabIndex = 1;
            // 
            // BClose
            // 
            BClose.Dock = DockStyle.Fill;
            BClose.Location = new Point(0, 0);
            BClose.Name = "BClose";
            BClose.Size = new Size(213, 35);
            BClose.TabIndex = 0;
            BClose.Text = "Закрити";
            BClose.UseVisualStyleBackColor = true;
            BClose.Click += BClose_Click;
            // 
            // PUserinfo
            // 
            MainMenuLayout.SetColumnSpan(PUserinfo, 3);
            PUserinfo.Controls.Add(tableLayoutPanel3);
            PUserinfo.Dock = DockStyle.Fill;
            PUserinfo.Location = new Point(3, 3);
            PUserinfo.Name = "PUserinfo";
            PUserinfo.Size = new Size(654, 206);
            PUserinfo.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5738831F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.42612F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(654, 206);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.Controls.Add(TPassword, 1, 3);
            tableLayoutPanel4.Controls.Add(TLogin, 1, 2);
            tableLayoutPanel4.Controls.Add(LPassword, 0, 3);
            tableLayoutPanel4.Controls.Add(LUserName, 0, 2);
            tableLayoutPanel4.Controls.Add(LDomen, 0, 1);
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Controls.Add(TDomain, 1, 1);
            tableLayoutPanel4.Controls.Add(panel4, 1, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(82, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel4.Size = new Size(497, 200);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // TPassword
            // 
            TPassword.Dock = DockStyle.Fill;
            TPassword.Location = new Point(152, 108);
            TPassword.Name = "TPassword";
            TPassword.PasswordChar = '*';
            TPassword.Size = new Size(342, 27);
            TPassword.TabIndex = 13;
            TPassword.KeyDown += Form_KeyDown;
            // 
            // TLogin
            // 
            TLogin.Dock = DockStyle.Fill;
            TLogin.Location = new Point(152, 73);
            TLogin.Name = "TLogin";
            TLogin.Size = new Size(342, 27);
            TLogin.TabIndex = 12;
            TLogin.KeyDown += Form_KeyDown;
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.Dock = DockStyle.Fill;
            LPassword.Location = new Point(3, 105);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(143, 35);
            LPassword.TabIndex = 9;
            LPassword.Text = "Пароль";
            LPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LUserName
            // 
            LUserName.AutoSize = true;
            LUserName.Dock = DockStyle.Fill;
            LUserName.Location = new Point(3, 70);
            LUserName.Name = "LUserName";
            LUserName.Size = new Size(143, 35);
            LUserName.TabIndex = 5;
            LUserName.Text = "Логін";
            LUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LDomen
            // 
            LDomen.AutoSize = true;
            LDomen.Dock = DockStyle.Fill;
            LDomen.Location = new Point(3, 35);
            LDomen.Name = "LDomen";
            LDomen.Size = new Size(143, 35);
            LDomen.TabIndex = 0;
            LDomen.Text = "Домен";
            LDomen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            tableLayoutPanel4.SetColumnSpan(panel3, 2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 29);
            panel3.TabIndex = 10;
            // 
            // TDomain
            // 
            TDomain.Dock = DockStyle.Fill;
            TDomain.Location = new Point(152, 38);
            TDomain.Name = "TDomain";
            TDomain.Size = new Size(342, 27);
            TDomain.TabIndex = 11;
            TDomain.KeyDown += Form_KeyDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(CBCurrentUserLogin);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(152, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(342, 54);
            panel4.TabIndex = 14;
            // 
            // CBCurrentUserLogin
            // 
            CBCurrentUserLogin.AutoSize = true;
            CBCurrentUserLogin.Location = new Point(37, 14);
            CBCurrentUserLogin.Name = "CBCurrentUserLogin";
            CBCurrentUserLogin.Size = new Size(280, 24);
            CBCurrentUserLogin.TabIndex = 16;
            CBCurrentUserLogin.Text = "Увійти під поточним користувачем ";
            CBCurrentUserLogin.TextAlign = ContentAlignment.MiddleCenter;
            CBCurrentUserLogin.UseVisualStyleBackColor = true;
            CBCurrentUserLogin.CheckedChanged += CBCurrentUserLogin_CheckedChanged;
            // 
            // panel2
            // 
            tableLayoutPanel1.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 176);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.4482765F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.103447F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.4482765F));
            tableLayoutPanel2.Controls.Add(UserImage, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(660, 176);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // UserImage
            // 
            UserImage.Dock = DockStyle.Fill;
            UserImage.Image = Resource.Resource.userDefault;
            UserImage.Location = new Point(190, 3);
            UserImage.Name = "UserImage";
            UserImage.Size = new Size(278, 170);
            UserImage.SizeMode = PictureBoxSizeMode.Zoom;
            UserImage.TabIndex = 0;
            UserImage.TabStop = false;
            // 
            // FormAuthorize
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 672);
            ControlBox = false;
            Controls.Add(Root);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAuthorize";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизація";
            Root.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            PanelImageOrganization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel1.ResumeLayout(false);
            MainMenuLayout.ResumeLayout(false);
            panelButtonLogin.ResumeLayout(false);
            panekButtonClose.ResumeLayout(false);
            PUserinfo.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Root;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel PanelImageOrganization;
        private PictureBox Logo;
        private Panel panel1;
        private TableLayoutPanel MainMenuLayout;
        private Panel panelButtonLogin;
        private Button BLogin;
        private Panel panekButtonClose;
        private Button BClose;
        private Panel PUserinfo;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox TPassword;
        private TextBox TLogin;
        private Label LPassword;
        private Label LUserName;
        private Label LDomen;
        private Panel panel3;
        private TextBox TDomain;
        private Panel panel4;
        private CheckBox CBCurrentUserLogin;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox UserImage;
    }
}
