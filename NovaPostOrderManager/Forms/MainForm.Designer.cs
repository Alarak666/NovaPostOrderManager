namespace NovaPostOrderManager.Forms
{
    sealed partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Root = new TableLayoutPanel();
            MainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Options = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            BCity = new Button();
            BOrder = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            Root.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // Root
            // 
            Root.BackColor = Color.FromArgb(115, 89, 173);
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            Root.Controls.Add(MainPanel, 1, 1);
            Root.Controls.Add(label1, 1, 0);
            Root.Controls.Add(label2, 1, 2);
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
            tableLayoutPanel1.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5159F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4841F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 318F));
            tableLayoutPanel1.Controls.Add(Options, 3, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 324F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.Size = new Size(1298, 672);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Options
            // 
            Options.BackColor = Color.FromArgb(194, 92, 104);
            Options.Dock = DockStyle.Fill;
            Options.FlatStyle = FlatStyle.Popup;
            Options.ForeColor = SystemColors.ActiveCaptionText;
            Options.ImageAlign = ContentAlignment.MiddleLeft;
            Options.Location = new Point(983, 4);
            Options.Margin = new Padding(4);
            Options.Name = "Options";
            Options.Size = new Size(311, 51);
            Options.TabIndex = 2;
            Options.Text = "Налаштування";
            Options.UseVisualStyleBackColor = false;
            Options.Click += Options_Click;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 3);
            panel1.Size = new Size(973, 115);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 397F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Controls.Add(button2, 0, 1);
            tableLayoutPanel2.Controls.Add(button1, 1, 1);
            tableLayoutPanel2.Controls.Add(BCity, 1, 0);
            tableLayoutPanel2.Controls.Add(BOrder, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.Size = new Size(973, 115);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(194, 92, 104);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(4, 59);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(180, 47);
            button2.TabIndex = 5;
            button2.Text = "Мої посилки";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BInternetDocument_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(194, 92, 104);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(192, 59);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(225, 48);
            button1.TabIndex = 3;
            button1.Text = "Відслідковування замовлень ";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // BCity
            // 
            BCity.BackColor = Color.FromArgb(194, 92, 104);
            BCity.FlatStyle = FlatStyle.Popup;
            BCity.ForeColor = SystemColors.ActiveCaptionText;
            BCity.Location = new Point(192, 4);
            BCity.Margin = new Padding(4);
            BCity.Name = "BCity";
            BCity.Size = new Size(225, 47);
            BCity.TabIndex = 0;
            BCity.Text = "Міста";
            BCity.UseVisualStyleBackColor = false;
            BCity.Visible = false;
            BCity.Click += BCity_Click;
            // 
            // BOrder
            // 
            BOrder.BackColor = Color.FromArgb(194, 92, 104);
            BOrder.FlatStyle = FlatStyle.Popup;
            BOrder.ForeColor = SystemColors.ActiveCaptionText;
            BOrder.Location = new Point(4, 4);
            BOrder.Margin = new Padding(4);
            BOrder.Name = "BOrder";
            BOrder.Size = new Size(180, 47);
            BOrder.TabIndex = 1;
            BOrder.Text = "Замовлення";
            BOrder.UseVisualStyleBackColor = false;
            BOrder.Click += BOrder_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 241F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(button5, 0, 0);
            tableLayoutPanel3.Location = new Point(982, 62);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(313, 48);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(194, 92, 104);
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(4, 4);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(172, 40);
            button5.TabIndex = 1;
            button5.Text = "Відправити лог";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(115, 89, 173);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(59, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1298, 56);
            label1.TabIndex = 1;
            label1.Text = "Нова пошта менеджер";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(1358, 736);
            label2.Name = "label2";
            label2.Size = new Size(0, 56);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(115, 89, 173);
            ClientSize = new Size(1416, 792);
            Controls.Add(Root);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Головне меню";
            Root.ResumeLayout(false);
            Root.PerformLayout();
            MainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
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
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button5;
        private Button button2;
    }
}
