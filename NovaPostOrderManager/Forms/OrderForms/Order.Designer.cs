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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            Root = new TableLayoutPanel();
            DataGridOrder = new DataGridView();
            Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).BeginInit();
            SuspendLayout();
            // 
            // Root
            // 
            Root.BackColor = Color.FromArgb(151, 62, 189);
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            Root.Controls.Add(DataGridOrder, 1, 1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Margin = new Padding(4);
            Root.Name = "Root";
            Root.RowCount = 3;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            Root.Size = new Size(1337, 718);
            Root.TabIndex = 1;
            // 
            // DataGridOrder
            // 
            DataGridOrder.AllowUserToAddRows = false;
            DataGridOrder.AllowUserToDeleteRows = false;
            DataGridOrder.AllowUserToOrderColumns = true;
            DataGridOrder.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridOrder.Dock = DockStyle.Fill;
            DataGridOrder.Location = new Point(14, 14);
            DataGridOrder.Margin = new Padding(4);
            DataGridOrder.Name = "DataGridOrder";
            DataGridOrder.RowHeadersWidth = 51;
            DataGridOrder.Size = new Size(1309, 690);
            DataGridOrder.TabIndex = 0;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 718);
            Controls.Add(Root);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Order";
            Text = "Замовлення";
            Root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private DataGridView DataGridOrder;
    }
}