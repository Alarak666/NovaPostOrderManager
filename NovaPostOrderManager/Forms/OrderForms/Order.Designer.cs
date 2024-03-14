namespace NovaPostOrderManager.Forms.OrderForms
{
    partial class Order
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).BeginInit();
            SuspendLayout();
            // 
            // Root
            // 
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.Controls.Add(DataGridOrder, 1, 2);
            Root.Controls.Add(tableLayoutPanel1, 1, 1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.RowCount = 4;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5121956F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 80.48781F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.Size = new Size(1172, 737);
            Root.TabIndex = 1;
            // 
            // DataGridOrder
            // 
            DataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridOrder.Dock = DockStyle.Fill;
            DataGridOrder.Location = new Point(43, 171);
            DataGridOrder.Name = "DataGridOrder";
            DataGridOrder.RowHeadersWidth = 51;
            DataGridOrder.Size = new Size(1086, 522);
            DataGridOrder.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5533981F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.4466F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(43, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1086, 122);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 737);
            Controls.Add(Root);
            Name = "Order";
            Text = "Order";
            Root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private DataGridView DataGridOrder;
        private TableLayoutPanel tableLayoutPanel1;
    }
}