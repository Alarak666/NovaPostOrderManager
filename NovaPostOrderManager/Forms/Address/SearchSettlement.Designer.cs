namespace NovaPostOrderManager.Forms.Address
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
            textBox1 = new TextBox();
            button1 = new Button();
            Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Root
            // 
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.Controls.Add(DataGridOrder, 1, 2);
            Root.Controls.Add(panel1, 1, 1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.RowCount = 4;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0039444F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 85.9960556F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.Size = new Size(940, 567);
            Root.TabIndex = 2;
            // 
            // DataGridOrder
            // 
            DataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridOrder.Dock = DockStyle.Fill;
            DataGridOrder.Location = new Point(43, 94);
            DataGridOrder.Name = "DataGridOrder";
            DataGridOrder.RowHeadersWidth = 51;
            DataGridOrder.Size = new Size(854, 430);
            DataGridOrder.TabIndex = 0;
            DataGridOrder.CellContentClick += DataGridOrder_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(43, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 65);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(249, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchSettlement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 567);
            Controls.Add(Root);
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