namespace NovaPostOrderManager.Forms.AddressForms
{
    partial class SearchSettlement
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
            Root = new TableLayoutPanel();
            DataGridOrder = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Root
            // 
            Root.BackColor = Color.FromArgb(151, 62, 189);
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            Root.Controls.Add(DataGridOrder, 1, 2);
            Root.Controls.Add(panel1, 1, 1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Margin = new Padding(4, 4, 4, 4);
            Root.Name = "Root";
            Root.RowCount = 4;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0039444F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 85.9960556F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            Root.Size = new Size(1213, 672);
            Root.TabIndex = 2;
            // 
            // DataGridOrder
            // 
            DataGridOrder.BackgroundColor = SystemColors.Control;
            DataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridOrder.Dock = DockStyle.Fill;
            DataGridOrder.Location = new Point(59, 114);
            DataGridOrder.Margin = new Padding(4, 4, 4, 4);
            DataGridOrder.Name = "DataGridOrder";
            DataGridOrder.RowHeadersWidth = 51;
            DataGridOrder.Size = new Size(1095, 497);
            DataGridOrder.TabIndex = 0;
            DataGridOrder.CellContentClick += DataGridOrder_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(59, 32);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 74);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 99, 117);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(340, 19);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(159, 41);
            button1.TabIndex = 1;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 22);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 34);
            textBox1.TabIndex = 0;
            // 
            // SearchSettlement
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 672);
            Controls.Add(Root);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "SearchSettlement";
            Text = "SearchSettlement";
            Root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private DataGridView DataGridOrder;
        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
    }
}