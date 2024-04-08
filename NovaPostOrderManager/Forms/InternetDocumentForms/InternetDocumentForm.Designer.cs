namespace NovaPostOrderManager.Forms.InternetDocumentForms
{
    partial class InternetDocumentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetDocumentForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            TTN = new TextBox();
            label7 = new Label();
            label1 = new Label();
            DTPStart = new DateTimePicker();
            label2 = new Label();
            DTPEnd = new DateTimePicker();
            label6 = new Label();
            FilterFlag = new CheckBox();
            label8 = new Label();
            FindByPhone = new MaskedTextBox();
            label4 = new Label();
            FindByAddress = new TextBox();
            label3 = new Label();
            CheckOnlyCurrentApteka = new CheckBox();
            BLoad = new Button();
            DataGridInternetDocument = new Zuby.ADGV.AdvancedDataGridView();
            NavigationBar = new ToolStrip();
            toolStripBack = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLCount = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripNext = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            PanelSumStatus = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridInternetDocument).BeginInit();
            NavigationBar.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 464F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.18397F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.81603F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(DataGridInternetDocument, 1, 1);
            tableLayoutPanel1.Controls.Add(NavigationBar, 1, 4);
            tableLayoutPanel1.Controls.Add(PanelSumStatus, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.29642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.7035828F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.Size = new Size(1362, 692);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(3, 8);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 5);
            groupBox1.Size = new Size(458, 681);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фільтр ТТН";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.88864F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.11136F));
            tableLayoutPanel2.Controls.Add(TTN, 1, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(DTPStart, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(DTPEnd, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(FilterFlag, 1, 2);
            tableLayoutPanel2.Controls.Add(label8, 0, 4);
            tableLayoutPanel2.Controls.Add(FindByPhone, 1, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(FindByAddress, 1, 5);
            tableLayoutPanel2.Controls.Add(label3, 0, 6);
            tableLayoutPanel2.Controls.Add(CheckOnlyCurrentApteka, 1, 6);
            tableLayoutPanel2.Controls.Add(BLoad, 0, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 12;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(452, 648);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TTN
            // 
            TTN.Dock = DockStyle.Fill;
            TTN.Font = new Font("Segoe UI", 12F);
            TTN.Location = new Point(228, 123);
            TTN.Name = "TTN";
            TTN.Size = new Size(221, 34);
            TTN.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 120);
            label7.Name = "label7";
            label7.Size = new Size(219, 40);
            label7.TabIndex = 15;
            label7.Text = "ТТН";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 40);
            label1.TabIndex = 0;
            label1.Text = "Початкова дата";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DTPStart
            // 
            DTPStart.Dock = DockStyle.Fill;
            DTPStart.Font = new Font("Segoe UI", 12F);
            DTPStart.Location = new Point(228, 3);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(221, 34);
            DTPStart.TabIndex = 2;
            DTPStart.ValueChanged += DTPStart_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(219, 40);
            label2.TabIndex = 1;
            label2.Text = "Кінцева дата";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DTPEnd
            // 
            DTPEnd.Dock = DockStyle.Fill;
            DTPEnd.Font = new Font("Segoe UI", 12F);
            DTPEnd.Location = new Point(228, 43);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(221, 34);
            DTPEnd.TabIndex = 3;
            DTPEnd.ValueChanged += DTPEnd_ValueChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 80);
            label6.Name = "label6";
            label6.Size = new Size(219, 30);
            label6.TabIndex = 13;
            label6.Text = "Включити фільтр";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FilterFlag
            // 
            FilterFlag.AutoSize = true;
            FilterFlag.Dock = DockStyle.Fill;
            FilterFlag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FilterFlag.Location = new Point(245, 83);
            FilterFlag.Margin = new Padding(20, 3, 3, 3);
            FilterFlag.Name = "FilterFlag";
            FilterFlag.Size = new Size(204, 34);
            FilterFlag.TabIndex = 14;
            FilterFlag.TextAlign = ContentAlignment.MiddleCenter;
            FilterFlag.TextImageRelation = TextImageRelation.ImageAboveText;
            FilterFlag.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 160);
            label8.Name = "label8";
            label8.Size = new Size(219, 40);
            label8.TabIndex = 17;
            label8.Text = "Пошук за телефоном ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(label8, "ПОшук за телефоном отримувача");
            // 
            // FindByPhone
            // 
            FindByPhone.Font = new Font("Segoe UI", 12F);
            FindByPhone.Location = new Point(228, 163);
            FindByPhone.Name = "FindByPhone";
            FindByPhone.Size = new Size(219, 34);
            FindByPhone.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 200);
            label4.Name = "label4";
            label4.Size = new Size(219, 40);
            label4.TabIndex = 6;
            label4.Text = "Пошук за адресою ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FindByAddress
            // 
            FindByAddress.Font = new Font("Segoe UI", 12F);
            FindByAddress.Location = new Point(228, 203);
            FindByAddress.Name = "FindByAddress";
            FindByAddress.Size = new Size(219, 34);
            FindByAddress.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 240);
            label3.Name = "label3";
            label3.Size = new Size(219, 40);
            label3.TabIndex = 8;
            label3.Text = "Данні тільки аптеки";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CheckOnlyCurrentApteka
            // 
            CheckOnlyCurrentApteka.AutoSize = true;
            CheckOnlyCurrentApteka.Dock = DockStyle.Fill;
            CheckOnlyCurrentApteka.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CheckOnlyCurrentApteka.Location = new Point(245, 243);
            CheckOnlyCurrentApteka.Margin = new Padding(20, 3, 3, 3);
            CheckOnlyCurrentApteka.Name = "CheckOnlyCurrentApteka";
            CheckOnlyCurrentApteka.Size = new Size(204, 34);
            CheckOnlyCurrentApteka.TabIndex = 9;
            CheckOnlyCurrentApteka.TextAlign = ContentAlignment.MiddleCenter;
            CheckOnlyCurrentApteka.TextImageRelation = TextImageRelation.ImageAboveText;
            CheckOnlyCurrentApteka.UseVisualStyleBackColor = true;
            // 
            // BLoad
            // 
            BLoad.BackColor = Color.FromArgb(235, 99, 117);
            BLoad.FlatStyle = FlatStyle.Flat;
            BLoad.Font = new Font("Segoe UI", 12F);
            BLoad.Location = new Point(3, 283);
            BLoad.Name = "BLoad";
            BLoad.Size = new Size(218, 34);
            BLoad.TabIndex = 4;
            BLoad.Text = "Завантажити дані";
            BLoad.UseVisualStyleBackColor = false;
            BLoad.Click += BLoad_Click;
            // 
            // DataGridInternetDocument
            // 
            DataGridInternetDocument.AllowUserToAddRows = false;
            DataGridInternetDocument.AllowUserToDeleteRows = false;
            DataGridInternetDocument.AllowUserToOrderColumns = true;
            DataGridInternetDocument.AllowUserToResizeColumns = false;
            DataGridInternetDocument.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridInternetDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(DataGridInternetDocument, 2);
            DataGridInternetDocument.Dock = DockStyle.Fill;
            DataGridInternetDocument.FilterAndSortEnabled = true;
            DataGridInternetDocument.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            DataGridInternetDocument.Location = new Point(467, 8);
            DataGridInternetDocument.MaxFilterButtonImageHeight = 23;
            DataGridInternetDocument.Name = "DataGridInternetDocument";
            DataGridInternetDocument.RightToLeft = RightToLeft.No;
            DataGridInternetDocument.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(DataGridInternetDocument, 2);
            DataGridInternetDocument.Size = new Size(878, 466);
            DataGridInternetDocument.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            DataGridInternetDocument.TabIndex = 3;
            DataGridInternetDocument.DoubleClick += DataGridInternetDocument_DoubleClick;
            // 
            // NavigationBar
            // 
            NavigationBar.Dock = DockStyle.Fill;
            NavigationBar.Font = new Font("Segoe UI", 9F);
            NavigationBar.ImageScalingSize = new Size(20, 20);
            NavigationBar.Items.AddRange(new ToolStripItem[] { toolStripBack, toolStripSeparator1, toolStripLCount, toolStripSeparator2, toolStripNext, toolStripSeparator3 });
            NavigationBar.Location = new Point(464, 649);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.RenderMode = ToolStripRenderMode.Professional;
            NavigationBar.Size = new Size(452, 37);
            NavigationBar.TabIndex = 2;
            NavigationBar.Text = "toolStrip1";
            // 
            // toolStripBack
            // 
            toolStripBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBack.Image = Properties.Resources.left;
            toolStripBack.ImageTransparentColor = Color.Magenta;
            toolStripBack.Name = "toolStripBack";
            toolStripBack.Size = new Size(29, 34);
            toolStripBack.Text = "toolStripBack";
            toolStripBack.Click += toolStripBack_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // toolStripLCount
            // 
            toolStripLCount.Name = "toolStripLCount";
            toolStripLCount.Size = new Size(0, 34);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 37);
            // 
            // toolStripNext
            // 
            toolStripNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripNext.Image = Properties.Resources.right;
            toolStripNext.ImageTransparentColor = Color.Magenta;
            toolStripNext.Name = "toolStripNext";
            toolStripNext.RightToLeft = RightToLeft.No;
            toolStripNext.Size = new Size(29, 34);
            toolStripNext.Text = "toolStripNext";
            toolStripNext.TextDirection = ToolStripTextDirection.Vertical270;
            toolStripNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolStripNext.Click += toolStripNext_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 37);
            // 
            // PanelSumStatus
            // 
            tableLayoutPanel1.SetColumnSpan(PanelSumStatus, 2);
            PanelSumStatus.Dock = DockStyle.Fill;
            PanelSumStatus.Location = new Point(467, 480);
            PanelSumStatus.Name = "PanelSumStatus";
            PanelSumStatus.Size = new Size(878, 166);
            PanelSumStatus.TabIndex = 4;
            // 
            // InternetDocumentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 692);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "InternetDocumentForm";
            Text = "Мої посилки";
            Enter += InternetDocumentForm_Enter;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridInternetDocument).EndInit();
            NavigationBar.ResumeLayout(false);
            NavigationBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private DateTimePicker DTPStart;
        private DateTimePicker DTPEnd;
        private Button BLoad;
        private ToolStrip NavigationBar;
        private ToolStripButton toolStripBack;
        private ToolStripButton toolStripNext;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLCount;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Label label4;
        private TextBox FindByAddress;
        private Label label3;
        private CheckBox CheckOnlyCurrentApteka;
        private MaskedTextBox FindByPhone;
        private Label label6;
        private Zuby.ADGV.AdvancedDataGridView DataGridInternetDocument;
        private TextBox TTN;
        private Label label7;
        private ToolTip toolTip1;
        private Label label8;
        private CheckBox FilterFlag;
        private FlowLayoutPanel PanelSumStatus;
    }
}