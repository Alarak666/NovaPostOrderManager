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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetDocumentForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            DTPStart = new DateTimePicker();
            DTPEnd = new DateTimePicker();
            BLoad = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            FindByAddress = new TextBox();
            CheckOnlyCurrentApteka = new CheckBox();
            label5 = new Label();
            FindByPhone = new MaskedTextBox();
            FilterFlag = new CheckBox();
            NavigationBar = new ToolStrip();
            toolStripBack = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLCount = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripNext = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            DataGridInternetDocument = new Zuby.ADGV.AdvancedDataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            NavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridInternetDocument).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.18397F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.81603F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(NavigationBar, 1, 3);
            tableLayoutPanel1.Controls.Add(DataGridInternetDocument, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.2964172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.7035828F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.Size = new Size(1362, 692);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(22, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1323, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фільтр ТТН";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.0628357F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.9371643F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 685F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(DTPStart, 1, 1);
            tableLayoutPanel2.Controls.Add(DTPEnd, 1, 2);
            tableLayoutPanel2.Controls.Add(BLoad, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel2.Size = new Size(1317, 192);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 42);
            label1.Name = "label1";
            label1.Size = new Size(227, 39);
            label1.TabIndex = 0;
            label1.Text = "Початкова дата";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 81);
            label2.Name = "label2";
            label2.Size = new Size(227, 39);
            label2.TabIndex = 1;
            label2.Text = "Кінцева дата";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DTPStart
            // 
            DTPStart.Dock = DockStyle.Fill;
            DTPStart.Font = new Font("Segoe UI", 12F);
            DTPStart.Location = new Point(236, 45);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(278, 34);
            DTPStart.TabIndex = 2;
            DTPStart.ValueChanged += DTPStart_ValueChanged;
            // 
            // DTPEnd
            // 
            DTPEnd.Dock = DockStyle.Fill;
            DTPEnd.Font = new Font("Segoe UI", 12F);
            DTPEnd.Location = new Point(236, 84);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(278, 34);
            DTPEnd.TabIndex = 3;
            DTPEnd.ValueChanged += DTPEnd_ValueChanged;
            // 
            // BLoad
            // 
            BLoad.BackColor = Color.FromArgb(235, 99, 117);
            BLoad.Dock = DockStyle.Fill;
            BLoad.FlatStyle = FlatStyle.Flat;
            BLoad.Font = new Font("Segoe UI", 12F);
            BLoad.Location = new Point(3, 123);
            BLoad.Name = "BLoad";
            BLoad.Size = new Size(227, 37);
            BLoad.TabIndex = 4;
            BLoad.Text = "Завантажити дані";
            BLoad.UseVisualStyleBackColor = false;
            BLoad.Click += BLoad_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label6, 0, 3);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(FindByAddress, 1, 1);
            tableLayoutPanel3.Controls.Add(CheckOnlyCurrentApteka, 1, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 2);
            tableLayoutPanel3.Controls.Add(FindByPhone, 1, 2);
            tableLayoutPanel3.Controls.Add(FilterFlag, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(520, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel3, 4);
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(679, 157);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 120);
            label6.Name = "label6";
            label6.Size = new Size(333, 40);
            label6.TabIndex = 13;
            label6.Text = "Включити фільтр";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(333, 40);
            label3.TabIndex = 8;
            label3.Text = "Данні тільки аптеки";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 40);
            label4.Name = "label4";
            label4.Size = new Size(333, 40);
            label4.TabIndex = 6;
            label4.Text = "Пошук за адресою ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FindByAddress
            // 
            FindByAddress.Dock = DockStyle.Fill;
            FindByAddress.Font = new Font("Segoe UI", 12F);
            FindByAddress.Location = new Point(342, 43);
            FindByAddress.Name = "FindByAddress";
            FindByAddress.Size = new Size(334, 34);
            FindByAddress.TabIndex = 7;
            // 
            // CheckOnlyCurrentApteka
            // 
            CheckOnlyCurrentApteka.AutoSize = true;
            CheckOnlyCurrentApteka.Dock = DockStyle.Fill;
            CheckOnlyCurrentApteka.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CheckOnlyCurrentApteka.Location = new Point(359, 3);
            CheckOnlyCurrentApteka.Margin = new Padding(20, 3, 3, 3);
            CheckOnlyCurrentApteka.Name = "CheckOnlyCurrentApteka";
            CheckOnlyCurrentApteka.Size = new Size(317, 34);
            CheckOnlyCurrentApteka.TabIndex = 9;
            CheckOnlyCurrentApteka.TextAlign = ContentAlignment.MiddleCenter;
            CheckOnlyCurrentApteka.TextImageRelation = TextImageRelation.ImageAboveText;
            CheckOnlyCurrentApteka.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 80);
            label5.Name = "label5";
            label5.Size = new Size(333, 40);
            label5.TabIndex = 10;
            label5.Text = "Пошук за номером телефона";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FindByPhone
            // 
            FindByPhone.Dock = DockStyle.Fill;
            FindByPhone.Font = new Font("Segoe UI", 12F);
            FindByPhone.Location = new Point(342, 83);
            FindByPhone.Name = "FindByPhone";
            FindByPhone.Size = new Size(334, 34);
            FindByPhone.TabIndex = 12;
            // 
            // FilterFlag
            // 
            FilterFlag.AutoSize = true;
            FilterFlag.Dock = DockStyle.Fill;
            FilterFlag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FilterFlag.Location = new Point(359, 123);
            FilterFlag.Margin = new Padding(20, 3, 3, 3);
            FilterFlag.Name = "FilterFlag";
            FilterFlag.Size = new Size(317, 34);
            FilterFlag.TabIndex = 14;
            FilterFlag.TextAlign = ContentAlignment.MiddleCenter;
            FilterFlag.TextImageRelation = TextImageRelation.ImageAboveText;
            FilterFlag.UseVisualStyleBackColor = true;
            // 
            // NavigationBar
            // 
            NavigationBar.Dock = DockStyle.Fill;
            NavigationBar.Font = new Font("Segoe UI", 9F);
            NavigationBar.ImageScalingSize = new Size(20, 20);
            NavigationBar.Items.AddRange(new ToolStripItem[] { toolStripBack, toolStripSeparator1, toolStripLCount, toolStripSeparator2, toolStripNext, toolStripSeparator3 });
            NavigationBar.Location = new Point(19, 639);
            NavigationBar.Name = "NavigationBar";
            NavigationBar.RenderMode = ToolStripRenderMode.Professional;
            NavigationBar.Size = new Size(680, 53);
            NavigationBar.TabIndex = 2;
            NavigationBar.Text = "toolStrip1";
            // 
            // toolStripBack
            // 
            toolStripBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBack.Image = Properties.Resources.left;
            toolStripBack.ImageTransparentColor = Color.Magenta;
            toolStripBack.Name = "toolStripBack";
            toolStripBack.Size = new Size(29, 50);
            toolStripBack.Text = "toolStripBack";
            toolStripBack.Click += toolStripBack_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 53);
            // 
            // toolStripLCount
            // 
            toolStripLCount.Name = "toolStripLCount";
            toolStripLCount.Size = new Size(0, 50);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 53);
            // 
            // toolStripNext
            // 
            toolStripNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripNext.Image = Properties.Resources.right;
            toolStripNext.ImageTransparentColor = Color.Magenta;
            toolStripNext.Name = "toolStripNext";
            toolStripNext.RightToLeft = RightToLeft.No;
            toolStripNext.Size = new Size(29, 50);
            toolStripNext.Text = "toolStripNext";
            toolStripNext.TextDirection = ToolStripTextDirection.Vertical270;
            toolStripNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            toolStripNext.Click += toolStripNext_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 53);
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
            DataGridInternetDocument.Location = new Point(22, 253);
            DataGridInternetDocument.Name = "DataGridInternetDocument";
            DataGridInternetDocument.RightToLeft = RightToLeft.No;
            DataGridInternetDocument.RowHeadersWidth = 51;
            DataGridInternetDocument.Size = new Size(1323, 383);
            DataGridInternetDocument.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            DataGridInternetDocument.TabIndex = 3;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            NavigationBar.ResumeLayout(false);
            NavigationBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridInternetDocument).EndInit();
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
        private TableLayoutPanel tableLayoutPanel3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLCount;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Label label4;
        private TextBox FindByAddress;
        private Label label3;
        private CheckBox CheckOnlyCurrentApteka;
        private Label label5;
        private MaskedTextBox FindByPhone;
        private Label label6;
        private CheckBox FilterFlag;
        private Zuby.ADGV.AdvancedDataGridView DataGridInternetDocument;
    }
}