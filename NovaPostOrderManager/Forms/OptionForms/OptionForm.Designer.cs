namespace NovaPostOrderManager.Forms.OptionForms
{
    partial class OptionForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox1 = new TextBox();
            LinkNovaPost = new LinkLabel();
            label15 = new Label();
            TSendersPhone = new TextBox();
            LSendersPhone = new Label();
            CBContactSender = new ComboBox();
            label14 = new Label();
            CBSenderAddress = new ComboBox();
            BSave = new Button();
            TBSearchAddress = new TextBox();
            TBSearchContacts = new TextBox();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 809F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 374F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.Size = new Size(829, 389);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 366);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(115, 89, 173);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 306F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(LinkNovaPost, 0, 1);
            tableLayoutPanel2.Controls.Add(label15, 0, 2);
            tableLayoutPanel2.Controls.Add(TSendersPhone, 0, 7);
            tableLayoutPanel2.Controls.Add(LSendersPhone, 0, 6);
            tableLayoutPanel2.Controls.Add(CBContactSender, 0, 5);
            tableLayoutPanel2.Controls.Add(label14, 0, 4);
            tableLayoutPanel2.Controls.Add(CBSenderAddress, 0, 3);
            tableLayoutPanel2.Controls.Add(BSave, 0, 8);
            tableLayoutPanel2.Controls.Add(TBSearchAddress, 1, 3);
            tableLayoutPanel2.Controls.Add(TBSearchContacts, 1, 5);
            tableLayoutPanel2.Controls.Add(label1, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(801, 366);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(4, 4);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введіть ключ API, Нової пошти, та натисніть Enter";
            textBox1.Size = new Size(487, 32);
            textBox1.TabIndex = 0;
            toolTip1.SetToolTip(textBox1, "Введіть ключ API, Нової пошти, та натисніть Enter");
            // 
            // LinkNovaPost
            // 
            LinkNovaPost.AutoSize = true;
            LinkNovaPost.BackColor = Color.Gainsboro;
            LinkNovaPost.Dock = DockStyle.Fill;
            LinkNovaPost.Location = new Point(4, 40);
            LinkNovaPost.Margin = new Padding(4, 0, 4, 0);
            LinkNovaPost.Name = "LinkNovaPost";
            LinkNovaPost.Size = new Size(487, 40);
            LinkNovaPost.TabIndex = 1;
            LinkNovaPost.TabStop = true;
            LinkNovaPost.Text = "Не знаєш де ключ?";
            LinkNovaPost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(3, 80);
            label15.Name = "label15";
            label15.Size = new Size(489, 40);
            label15.TabIndex = 36;
            label15.Text = "Адрес";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            label15.Visible = false;
            // 
            // TSendersPhone
            // 
            TSendersPhone.Dock = DockStyle.Fill;
            TSendersPhone.Enabled = false;
            TSendersPhone.Font = new Font("Segoe UI", 12F);
            TSendersPhone.Location = new Point(3, 283);
            TSendersPhone.Name = "TSendersPhone";
            TSendersPhone.Size = new Size(489, 34);
            TSendersPhone.TabIndex = 40;
            TSendersPhone.Visible = false;
            // 
            // LSendersPhone
            // 
            LSendersPhone.AutoSize = true;
            LSendersPhone.BorderStyle = BorderStyle.FixedSingle;
            LSendersPhone.Dock = DockStyle.Fill;
            LSendersPhone.Font = new Font("Segoe UI", 12F);
            LSendersPhone.Location = new Point(3, 240);
            LSendersPhone.Name = "LSendersPhone";
            LSendersPhone.Size = new Size(489, 40);
            LSendersPhone.TabIndex = 37;
            LSendersPhone.Text = "Телефон";
            LSendersPhone.TextAlign = ContentAlignment.MiddleLeft;
            LSendersPhone.Visible = false;
            // 
            // CBContactSender
            // 
            CBContactSender.Dock = DockStyle.Fill;
            CBContactSender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBContactSender.Font = new Font("Segoe UI", 12F);
            CBContactSender.FormattingEnabled = true;
            CBContactSender.Location = new Point(3, 203);
            CBContactSender.Name = "CBContactSender";
            CBContactSender.Size = new Size(489, 36);
            CBContactSender.TabIndex = 39;
            CBContactSender.Visible = false;
            CBContactSender.SelectedValueChanged += CBContactSender_SelectedValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(3, 160);
            label14.Name = "label14";
            label14.Size = new Size(489, 40);
            label14.TabIndex = 35;
            label14.Text = "Контакт";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            label14.Visible = false;
            // 
            // CBSenderAddress
            // 
            CBSenderAddress.Dock = DockStyle.Fill;
            CBSenderAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSenderAddress.Font = new Font("Segoe UI", 12F);
            CBSenderAddress.FormattingEnabled = true;
            CBSenderAddress.Location = new Point(3, 123);
            CBSenderAddress.Name = "CBSenderAddress";
            CBSenderAddress.Size = new Size(489, 36);
            CBSenderAddress.TabIndex = 38;
            CBSenderAddress.Visible = false;
            // 
            // BSave
            // 
            BSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BSave.Location = new Point(3, 323);
            BSave.Name = "BSave";
            BSave.Size = new Size(213, 40);
            BSave.TabIndex = 41;
            BSave.Text = "Зберегти";
            BSave.UseVisualStyleBackColor = true;
            BSave.Visible = false;
            BSave.Click += BSave_Click;
            // 
            // TBSearchAddress
            // 
            TBSearchAddress.Dock = DockStyle.Fill;
            TBSearchAddress.Font = new Font("Segoe UI", 12F);
            TBSearchAddress.Location = new Point(498, 123);
            TBSearchAddress.Name = "TBSearchAddress";
            TBSearchAddress.Size = new Size(300, 34);
            TBSearchAddress.TabIndex = 42;
            TBSearchAddress.Visible = false;
            // 
            // TBSearchContacts
            // 
            TBSearchContacts.Dock = DockStyle.Fill;
            TBSearchContacts.Font = new Font("Segoe UI", 12F);
            TBSearchContacts.Location = new Point(498, 203);
            TBSearchContacts.Name = "TBSearchContacts";
            TBSearchContacts.Size = new Size(300, 34);
            TBSearchContacts.TabIndex = 43;
            TBSearchContacts.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(498, 80);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 44;
            label1.Text = "Пошук адреси";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(498, 160);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 45;
            label2.Text = "Пошук контакта";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Visible = false;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 389);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "OptionForm";
            Text = "Налаштування";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private LinkLabel LinkNovaPost;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolTip toolTip1;
        private Label label15;
        private TextBox TSendersPhone;
        private Label LSendersPhone;
        private ComboBox CBContactSender;
        private Label label14;
        private ComboBox CBSenderAddress;
        private Button BSave;
        private TextBox TBSearchAddress;
        private TextBox TBSearchContacts;
        private Label label1;
        private Label label2;
    }
}