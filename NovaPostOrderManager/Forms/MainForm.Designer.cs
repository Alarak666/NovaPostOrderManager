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
            Root.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Root
            // 
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.Controls.Add(MainPanel, 1, 1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.RowCount = 3;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Root.Size = new Size(1030, 566);
            Root.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.Controls.Add(tableLayoutPanel1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(43, 43);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(944, 480);
            MainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5159F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4841F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(BCity, 0, 0);
            tableLayoutPanel1.Controls.Add(BOrder, 0, 1);
            tableLayoutPanel1.Controls.Add(Options, 3, 0);
            tableLayoutPanel1.Controls.Add(BInternetDocument, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(944, 480);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(221, 3);
            button1.Name = "button1";
            button1.Size = new Size(342, 34);
            button1.TabIndex = 3;
            button1.Text = "Відслідковування замовлень ";
            button1.UseVisualStyleBackColor = true;
            // 
            // BCity
            // 
            BCity.Dock = DockStyle.Fill;
            BCity.Location = new Point(3, 3);
            BCity.Name = "BCity";
            BCity.Size = new Size(212, 34);
            BCity.TabIndex = 0;
            BCity.Text = "Міста";
            BCity.UseVisualStyleBackColor = true;
            BCity.Click += BCity_Click;
            // 
            // BOrder
            // 
            BOrder.Dock = DockStyle.Fill;
            BOrder.Location = new Point(3, 43);
            BOrder.Name = "BOrder";
            BOrder.Size = new Size(212, 34);
            BOrder.TabIndex = 1;
            BOrder.Text = "Замовлення";
            BOrder.UseVisualStyleBackColor = true;
            BOrder.Click += BOrder_Click;
            // 
            // Options
            // 
            Options.Dock = DockStyle.Fill;
            Options.Location = new Point(716, 3);
            Options.Name = "Options";
            Options.Size = new Size(225, 34);
            Options.TabIndex = 2;
            Options.Text = "Налаштування";
            Options.UseVisualStyleBackColor = true;
            Options.Click += Options_Click;
            // 
            // BInternetDocument
            // 
            BInternetDocument.Location = new Point(3, 83);
            BInternetDocument.Name = "BInternetDocument";
            BInternetDocument.Size = new Size(212, 34);
            BInternetDocument.TabIndex = 4;
            BInternetDocument.Text = "ТТН";
            BInternetDocument.UseVisualStyleBackColor = true;
            BInternetDocument.Click += BInternetDocument_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 566);
            Controls.Add(Root);
            Name = "MainForm";
            Text = "Form1";
            Root.ResumeLayout(false);
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
    }
}
