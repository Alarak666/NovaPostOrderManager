namespace NovaPostOrderManager.Forms
{
    partial class MainForm
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
            Root = new TableLayoutPanel();
            MainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            BCity = new Button();
            BOrder = new Button();
            Options = new Button();
            BInternetDocument = new Button();
            label1 = new Label();
            Root.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Root
            // 
            Root.BackColor = Color.FromArgb(245, 245, 255);
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            Root.Controls.Add(MainPanel, 1, 1);
            Root.Controls.Add(label1, 1, 0);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Margin = new Padding(4);
            Root.Name = "Root";
            Root.RowCount = 3;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Root.Size = new Size(1416, 792);
            Root.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.Controls.Add(tableLayoutPanel1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(59, 60);
            MainPanel.Margin = new Padding(4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1298, 672);
            MainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5159F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4841F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 318F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(BCity, 0, 0);
            tableLayoutPanel1.Controls.Add(BOrder, 0, 1);
            tableLayoutPanel1.Controls.Add(Options, 3, 0);
            tableLayoutPanel1.Controls.Add(BInternetDocument, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(1298, 672);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 248, 245);
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(303, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(470, 48);
            button1.TabIndex = 3;
            button1.Text = "Відслідковування замовлень ";
            button1.UseVisualStyleBackColor = false;
            // 
            // BCity
            // 
            BCity.BackColor = Color.FromArgb(255, 248, 245);
            BCity.Dock = DockStyle.Fill;
            BCity.FlatStyle = FlatStyle.Popup;
            BCity.ForeColor = SystemColors.ActiveCaptionText;
            BCity.Location = new Point(4, 4);
            BCity.Margin = new Padding(4);
            BCity.Name = "BCity";
            BCity.Size = new Size(291, 48);
            BCity.TabIndex = 0;
            BCity.Text = "Міста";
            BCity.UseVisualStyleBackColor = false;
            BCity.Click += BCity_Click;
            // 
            // BOrder
            // 
            BOrder.BackColor = Color.FromArgb(255, 248, 245);
            BOrder.Dock = DockStyle.Fill;
            BOrder.FlatStyle = FlatStyle.Popup;
            BOrder.ForeColor = SystemColors.ActiveCaptionText;
            BOrder.Location = new Point(4, 60);
            BOrder.Margin = new Padding(4);
            BOrder.Name = "BOrder";
            BOrder.Size = new Size(291, 48);
            BOrder.TabIndex = 1;
            BOrder.Text = "Замовлення";
            BOrder.UseVisualStyleBackColor = false;
            BOrder.Click += BOrder_Click;
            // 
            // Options
            // 
            Options.BackColor = Color.FromArgb(255, 248, 245);
            Options.Dock = DockStyle.Fill;
            Options.FlatStyle = FlatStyle.Popup;
            Options.ForeColor = SystemColors.ActiveCaptionText;
            Options.ImageAlign = ContentAlignment.MiddleLeft;
            Options.Location = new Point(983, 4);
            Options.Margin = new Padding(4);
            Options.Name = "Options";
            Options.Size = new Size(311, 48);
            Options.TabIndex = 2;
            Options.Text = "Налаштування";
            Options.UseVisualStyleBackColor = false;
            Options.Click += Options_Click;
            // 
            // BInternetDocument
            // 
            BInternetDocument.BackColor = Color.FromArgb(255, 248, 245);
            BInternetDocument.FlatStyle = FlatStyle.Popup;
            BInternetDocument.ForeColor = SystemColors.ActiveCaptionText;
            BInternetDocument.Location = new Point(4, 116);
            BInternetDocument.Margin = new Padding(4);
            BInternetDocument.Name = "BInternetDocument";
            BInternetDocument.Size = new Size(291, 48);
            BInternetDocument.TabIndex = 4;
            BInternetDocument.Text = "ТТН";
            BInternetDocument.UseVisualStyleBackColor = false;
            BInternetDocument.Click += BInternetDocument_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(59, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1298, 56);
            label1.TabIndex = 1;
            label1.Text = "Нова почта менеджер";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 792);
            Controls.Add(Root);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Головне меню";
            Root.ResumeLayout(false);
            Root.PerformLayout();
            MainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private Panel MainPanel;
        private Button BCity;
        private Button BOrder;
        private Button Options;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button BInternetDocument;
        private Label label1;
    }
}
