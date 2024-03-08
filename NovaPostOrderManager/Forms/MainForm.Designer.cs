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
            BOrder = new Button();
            BCity = new Button();
            Root.SuspendLayout();
            MainPanel.SuspendLayout();
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
            MainPanel.Controls.Add(BOrder);
            MainPanel.Controls.Add(BCity);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(43, 43);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(944, 480);
            MainPanel.TabIndex = 0;
            // 
            // BOrder
            // 
            BOrder.Location = new Point(32, 77);
            BOrder.Name = "BOrder";
            BOrder.Size = new Size(137, 29);
            BOrder.TabIndex = 1;
            BOrder.Text = "Замовлення";
            BOrder.UseVisualStyleBackColor = true;
            BOrder.Click += BOrder_Click;
            // 
            // BCity
            // 
            BCity.Location = new Point(32, 25);
            BCity.Name = "BCity";
            BCity.Size = new Size(137, 29);
            BCity.TabIndex = 0;
            BCity.Text = "Міста";
            BCity.UseVisualStyleBackColor = true;
            BCity.Click += BCity_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private Panel MainPanel;
        private Button BCity;
        private Button BOrder;
    }
}
