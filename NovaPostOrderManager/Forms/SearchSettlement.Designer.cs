namespace NovaPostOrderManager.Forms
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
            Root.Controls.Add(DataGridOrder, 1, 1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.RowCount = 3;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Root.Size = new Size(800, 450);
            Root.TabIndex = 2;
            // 
            // DataGridOrder
            // 
            DataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridOrder.Dock = DockStyle.Fill;
            DataGridOrder.Location = new Point(43, 43);
            DataGridOrder.Name = "DataGridOrder";
            DataGridOrder.RowHeadersWidth = 51;
            DataGridOrder.Size = new Size(714, 364);
            DataGridOrder.TabIndex = 0;
            DataGridOrder.CellContentClick += DataGridOrder_CellContentClick;
            // 
            // SearchSettlement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Root);
            Name = "SearchSettlement";
            Text = "SearchSettlement";
            Root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private DataGridView DataGridOrder;
    }
}