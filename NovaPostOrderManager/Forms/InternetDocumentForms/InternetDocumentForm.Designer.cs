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
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.18397F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.81603F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(DataGridInternetDocument, 1, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.2964172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.7035828F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1199, 715);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DataGridInternetDocument
            // 
            DataGridInternetDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(DataGridInternetDocument, 2);
            DataGridInternetDocument.Dock = DockStyle.Fill;
            DataGridInternetDocument.Location = new Point(53, 282);
            DataGridInternetDocument.Name = "DataGridInternetDocument";
            DataGridInternetDocument.RowHeadersWidth = 51;
            DataGridInternetDocument.Size = new Size(1092, 379);
            DataGridInternetDocument.TabIndex = 0;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(53, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1092, 223);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фільтр ТТН";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.90083F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.0991745F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450F));
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(DTPStart, 1, 1);
            tableLayoutPanel2.Controls.Add(DTPEnd, 1, 2);
            tableLayoutPanel2.Controls.Add(BLoad, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(1086, 192);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Початкова дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 1;
            label2.Text = "Кінцева дата";
            // 
            // DTPStart
            // 
            DTPStart.Location = new Point(230, 43);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(250, 32);
            DTPStart.TabIndex = 2;
            DTPStart.ValueChanged += DTPStart_ValueChanged;
            // 
            // DTPEnd
            // 
            DTPEnd.Location = new Point(230, 83);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(250, 32);
            DTPEnd.TabIndex = 3;
            DTPEnd.ValueChanged += DTPEnd_ValueChanged;
            // 
            // BLoad
            // 
            BLoad.Dock = DockStyle.Fill;
            BLoad.Location = new Point(3, 123);
            BLoad.Name = "BLoad";
            BLoad.Size = new Size(221, 34);
            BLoad.TabIndex = 4;
            BLoad.Text = "Завантажити дані";
            BLoad.UseVisualStyleBackColor = true;
            BLoad.Click += BLoad_Click;
            // 
            // InternetDocumentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 715);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "InternetDocumentForm";
            Text = "InternetDocumentForm";
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