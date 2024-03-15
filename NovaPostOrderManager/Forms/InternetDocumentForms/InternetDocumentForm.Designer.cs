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
            tableLayoutPanel1 = new TableLayoutPanel();
            DataGridInternetDocument = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            DTPStart = new DateTimePicker();
            DTPEnd = new DateTimePicker();
            BLoad = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridInternetDocument).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(151, 62, 189);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.18397F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.81603F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Controls.Add(DataGridInternetDocument, 1, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.2964172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.7035828F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(1362, 692);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DataGridInternetDocument
            // 
            DataGridInternetDocument.AllowUserToAddRows = false;
            DataGridInternetDocument.AllowUserToDeleteRows = false;
            DataGridInternetDocument.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridInternetDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(DataGridInternetDocument, 2);
            DataGridInternetDocument.Dock = DockStyle.Fill;
            DataGridInternetDocument.Location = new Point(58, 275);
            DataGridInternetDocument.Name = "DataGridInternetDocument";
            DataGridInternetDocument.RowHeadersWidth = 51;
            DataGridInternetDocument.Size = new Size(1244, 357);
            DataGridInternetDocument.TabIndex = 0;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(58, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1244, 210);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фільтр ТТН";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(151, 62, 189);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.90083F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.0991745F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 496F));
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(DTPStart, 1, 1);
            tableLayoutPanel2.Controls.Add(DTPEnd, 1, 2);
            tableLayoutPanel2.Controls.Add(BLoad, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.Size = new Size(1238, 177);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(264, 44);
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
            label2.Location = new Point(3, 89);
            label2.Name = "label2";
            label2.Size = new Size(264, 46);
            label2.TabIndex = 1;
            label2.Text = "Кінцева дата";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DTPStart
            // 
            DTPStart.Font = new Font("Segoe UI", 12F);
            DTPStart.Location = new Point(273, 48);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(275, 34);
            DTPStart.TabIndex = 2;
            DTPStart.ValueChanged += DTPStart_ValueChanged;
            // 
            // DTPEnd
            // 
            DTPEnd.Font = new Font("Segoe UI", 12F);
            DTPEnd.Location = new Point(273, 92);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(275, 34);
            DTPEnd.TabIndex = 3;
            DTPEnd.ValueChanged += DTPEnd_ValueChanged;
            // 
            // BLoad
            // 
            BLoad.BackColor = Color.FromArgb(235, 99, 117);
            BLoad.Dock = DockStyle.Fill;
            BLoad.FlatStyle = FlatStyle.Flat;
            BLoad.Font = new Font("Segoe UI", 12F);
            BLoad.Location = new Point(3, 138);
            BLoad.Name = "BLoad";
            BLoad.Size = new Size(264, 39);
            BLoad.TabIndex = 4;
            BLoad.Text = "Завантажити дані";
            BLoad.UseVisualStyleBackColor = false;
            BLoad.Click += BLoad_Click;
            // 
            // InternetDocumentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 692);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "InternetDocumentForm";
            Text = "Мої посилки";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridInternetDocument).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DataGridInternetDocument;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private DateTimePicker DTPStart;
        private DateTimePicker DTPEnd;
        private Button BLoad;
    }
}