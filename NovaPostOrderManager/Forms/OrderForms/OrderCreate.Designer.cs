namespace NovaPostOrderManager.Forms.OrderForms
{
    partial class OrderCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCreate));
            Root = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label12 = new Label();
            TDescription = new TextBox();
            label9 = new Label();
            NUDCost = new NumericUpDown();
            label3 = new Label();
            CbPayerType = new ComboBox();
            DtpDateTime = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            CbPaymentMethod = new ComboBox();
            label6 = new Label();
            CbCargoType = new ComboBox();
            label10 = new Label();
            CbServiceType = new ComboBox();
            BCreateOrder = new Button();
            BPrinter = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label22 = new Label();
            label17 = new Label();
            CBRecipient = new ComboBox();
            label18 = new Label();
            CBCityRecipient = new ComboBox();
            CBContactRecipient = new ComboBox();
            label19 = new Label();
            LRecipientsPhone = new Label();
            TRecipientsPhone = new TextBox();
            CBRecipientAddress = new ComboBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label16 = new Label();
            label13 = new Label();
            CBSender = new ComboBox();
            label15 = new Label();
            CBCitySender = new ComboBox();
            CBSenderAddress = new ComboBox();
            label14 = new Label();
            CBContactSender = new ComboBox();
            LSendersPhone = new Label();
            TSendersPhone = new TextBox();
            groupBox4 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label24 = new Label();
            label8 = new Label();
            label23 = new Label();
            NUDDetailWeight = new NumericUpDown();
            label2 = new Label();
            label20 = new Label();
            NUDDetailLenght = new NumericUpDown();
            NUDDetailWidht = new NumericUpDown();
            NUDDetailHeight = new NumericUpDown();
            label21 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            VolumeGeneral = new Label();
            label1 = new Label();
            label7 = new Label();
            label11 = new Label();
            toolTip1 = new ToolTip(components);
            Root.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCost).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailLenght).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWidht).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailHeight).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Root
            // 
            Root.BackColor = Color.FromArgb(115, 89, 173);
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            Root.Controls.Add(groupBox1, 1, 1);
            Root.Controls.Add(tableLayoutPanel4, 1, 3);
            Root.Controls.Add(groupBox4, 1, 2);
            Root.Dock = DockStyle.Fill;
            Root.Font = new Font("Segoe UI", 11F);
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.RowCount = 5;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 243F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 251F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 447F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            Root.Size = new Size(1241, 961);
            Root.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1215, 237);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметри відправлення";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel2.Controls.Add(label12, 0, 0);
            tableLayoutPanel2.Controls.Add(TDescription, 1, 0);
            tableLayoutPanel2.Controls.Add(label9, 3, 0);
            tableLayoutPanel2.Controls.Add(NUDCost, 4, 0);
            tableLayoutPanel2.Controls.Add(label3, 3, 1);
            tableLayoutPanel2.Controls.Add(CbPayerType, 4, 1);
            tableLayoutPanel2.Controls.Add(DtpDateTime, 1, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 3, 2);
            tableLayoutPanel2.Controls.Add(CbPaymentMethod, 4, 2);
            tableLayoutPanel2.Controls.Add(label6, 3, 4);
            tableLayoutPanel2.Controls.Add(CbCargoType, 4, 4);
            tableLayoutPanel2.Controls.Add(label10, 3, 3);
            tableLayoutPanel2.Controls.Add(CbServiceType, 4, 3);
            tableLayoutPanel2.Controls.Add(BCreateOrder, 0, 3);
            tableLayoutPanel2.Controls.Add(BPrinter, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1209, 204);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Dock = DockStyle.Fill;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            tableLayoutPanel2.SetRowSpan(label12, 2);
            label12.Size = new Size(237, 80);
            label12.TabIndex = 19;
            label12.Text = "Опис";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TDescription
            // 
            tableLayoutPanel2.SetColumnSpan(TDescription, 2);
            TDescription.Dock = DockStyle.Fill;
            TDescription.Enabled = false;
            TDescription.Font = new Font("Segoe UI", 9F);
            TDescription.Location = new Point(246, 3);
            TDescription.Multiline = true;
            TDescription.Name = "TDescription";
            tableLayoutPanel2.SetRowSpan(TDescription, 2);
            TDescription.ScrollBars = ScrollBars.Horizontal;
            TDescription.Size = new Size(431, 74);
            TDescription.TabIndex = 32;
            TDescription.Text = "Товари медичного призначення ";
            toolTip1.SetToolTip(TDescription, "Максимум 120 символів");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Dock = DockStyle.Fill;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(683, 0);
            label9.Name = "label9";
            label9.Size = new Size(171, 40);
            label9.TabIndex = 16;
            label9.Text = "Ціна";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDCost
            // 
            NUDCost.DecimalPlaces = 2;
            NUDCost.Dock = DockStyle.Fill;
            NUDCost.Enabled = false;
            NUDCost.Font = new Font("Segoe UI", 12F);
            NUDCost.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NUDCost.Location = new Point(860, 3);
            NUDCost.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            NUDCost.Name = "NUDCost";
            NUDCost.Size = new Size(346, 34);
            NUDCost.TabIndex = 33;
            toolTip1.SetToolTip(NUDCost, "Ціна");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(683, 40);
            label3.Name = "label3";
            label3.Size = new Size(171, 40);
            label3.TabIndex = 2;
            label3.Text = "Платник за доставку";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbPayerType
            // 
            CbPayerType.Dock = DockStyle.Fill;
            CbPayerType.DropDownStyle = ComboBoxStyle.Simple;
            CbPayerType.Enabled = false;
            CbPayerType.Font = new Font("Segoe UI", 12F);
            CbPayerType.Location = new Point(860, 43);
            CbPayerType.Name = "CbPayerType";
            CbPayerType.Size = new Size(346, 34);
            CbPayerType.TabIndex = 9;
            // 
            // DtpDateTime
            // 
            DtpDateTime.Dock = DockStyle.Fill;
            DtpDateTime.Enabled = false;
            DtpDateTime.Font = new Font("Segoe UI", 12F);
            DtpDateTime.Location = new Point(246, 83);
            DtpDateTime.Name = "DtpDateTime";
            DtpDateTime.Size = new Size(224, 34);
            DtpDateTime.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Fill;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(3, 80);
            label5.Name = "label5";
            label5.Size = new Size(237, 40);
            label5.TabIndex = 4;
            label5.Text = "Дата відправлення";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(683, 80);
            label4.Name = "label4";
            label4.Size = new Size(171, 40);
            label4.TabIndex = 3;
            label4.Text = "Форма оплати";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbPaymentMethod
            // 
            CbPaymentMethod.Dock = DockStyle.Fill;
            CbPaymentMethod.DrawMode = DrawMode.OwnerDrawFixed;
            CbPaymentMethod.DropDownStyle = ComboBoxStyle.Simple;
            CbPaymentMethod.Enabled = false;
            CbPaymentMethod.Font = new Font("Segoe UI", 12F);
            CbPaymentMethod.Location = new Point(860, 83);
            CbPaymentMethod.Name = "CbPaymentMethod";
            CbPaymentMethod.Size = new Size(346, 34);
            CbPaymentMethod.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Fill;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(683, 163);
            label6.Name = "label6";
            label6.Size = new Size(171, 41);
            label6.TabIndex = 5;
            label6.Text = "Тип вантажу";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbCargoType
            // 
            CbCargoType.Dock = DockStyle.Fill;
            CbCargoType.DrawMode = DrawMode.OwnerDrawFixed;
            CbCargoType.DropDownStyle = ComboBoxStyle.Simple;
            CbCargoType.Enabled = false;
            CbCargoType.Font = new Font("Segoe UI", 12F);
            CbCargoType.Location = new Point(860, 166);
            CbCargoType.Name = "CbCargoType";
            CbCargoType.Size = new Size(346, 35);
            CbCargoType.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Dock = DockStyle.Fill;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(683, 120);
            label10.Name = "label10";
            label10.Size = new Size(171, 43);
            label10.TabIndex = 17;
            label10.Text = "Тип доставки";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbServiceType
            // 
            CbServiceType.Dock = DockStyle.Fill;
            CbServiceType.DrawMode = DrawMode.OwnerDrawFixed;
            CbServiceType.DropDownStyle = ComboBoxStyle.Simple;
            CbServiceType.Enabled = false;
            CbServiceType.Font = new Font("Segoe UI", 12F);
            CbServiceType.Location = new Point(860, 123);
            CbServiceType.Name = "CbServiceType";
            CbServiceType.Size = new Size(346, 37);
            CbServiceType.TabIndex = 30;
            // 
            // BCreateOrder
            // 
            BCreateOrder.BackColor = Color.FromArgb(235, 99, 117);
            BCreateOrder.Dock = DockStyle.Fill;
            BCreateOrder.Enabled = false;
            BCreateOrder.FlatStyle = FlatStyle.Popup;
            BCreateOrder.Font = new Font("Segoe UI", 12F);
            BCreateOrder.Location = new Point(3, 123);
            BCreateOrder.Name = "BCreateOrder";
            BCreateOrder.Size = new Size(237, 37);
            BCreateOrder.TabIndex = 34;
            BCreateOrder.Text = "Створити ТТН";
            BCreateOrder.UseVisualStyleBackColor = false;
            BCreateOrder.Click += BCreateOrder_Click;
            // 
            // BPrinter
            // 
            BPrinter.BackColor = Color.FromArgb(235, 99, 117);
            BPrinter.Dock = DockStyle.Fill;
            BPrinter.FlatStyle = FlatStyle.Popup;
            BPrinter.Font = new Font("Segoe UI", 12F);
            BPrinter.Location = new Point(246, 123);
            BPrinter.Name = "BPrinter";
            BPrinter.Size = new Size(224, 37);
            BPrinter.TabIndex = 35;
            BPrinter.Text = "Друкувати ТТН";
            BPrinter.UseVisualStyleBackColor = false;
            BPrinter.Click += BPrinter_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(13, 507);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1215, 441);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(610, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(602, 435);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Одержувач";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoScroll = true;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label22, 0, 2);
            tableLayoutPanel5.Controls.Add(label17, 0, 0);
            tableLayoutPanel5.Controls.Add(CBRecipient, 0, 1);
            tableLayoutPanel5.Controls.Add(label18, 0, 4);
            tableLayoutPanel5.Controls.Add(CBCityRecipient, 0, 3);
            tableLayoutPanel5.Controls.Add(CBContactRecipient, 0, 7);
            tableLayoutPanel5.Controls.Add(label19, 0, 6);
            tableLayoutPanel5.Controls.Add(LRecipientsPhone, 0, 8);
            tableLayoutPanel5.Controls.Add(TRecipientsPhone, 0, 9);
            tableLayoutPanel5.Controls.Add(CBRecipientAddress, 0, 5);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 30);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 10;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.Size = new Size(596, 402);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(3, 80);
            label22.Name = "label22";
            label22.Size = new Size(590, 40);
            label22.TabIndex = 29;
            label22.Text = "Місто";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(590, 40);
            label17.TabIndex = 24;
            label17.Text = "Отримувач ПІБ";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBRecipient
            // 
            CBRecipient.Dock = DockStyle.Fill;
            CBRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            CBRecipient.Enabled = false;
            CBRecipient.Font = new Font("Segoe UI", 12F);
            CBRecipient.FormattingEnabled = true;
            CBRecipient.Location = new Point(3, 43);
            CBRecipient.Name = "CBRecipient";
            CBRecipient.Size = new Size(590, 36);
            CBRecipient.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(3, 160);
            label18.Name = "label18";
            label18.Size = new Size(590, 40);
            label18.TabIndex = 25;
            label18.Text = "Адреса";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBCityRecipient
            // 
            CBCityRecipient.Dock = DockStyle.Fill;
            CBCityRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCityRecipient.Enabled = false;
            CBCityRecipient.Font = new Font("Segoe UI", 12F);
            CBCityRecipient.FormattingEnabled = true;
            CBCityRecipient.Location = new Point(3, 123);
            CBCityRecipient.Name = "CBCityRecipient";
            CBCityRecipient.Size = new Size(590, 36);
            CBCityRecipient.TabIndex = 30;
            // 
            // CBContactRecipient
            // 
            CBContactRecipient.Dock = DockStyle.Fill;
            CBContactRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            CBContactRecipient.Enabled = false;
            CBContactRecipient.Font = new Font("Segoe UI", 12F);
            CBContactRecipient.FormattingEnabled = true;
            CBContactRecipient.Location = new Point(3, 283);
            CBContactRecipient.Name = "CBContactRecipient";
            CBContactRecipient.Size = new Size(590, 36);
            CBContactRecipient.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(3, 240);
            label19.Name = "label19";
            label19.Size = new Size(590, 40);
            label19.TabIndex = 26;
            label19.Text = "Контакт";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LRecipientsPhone
            // 
            LRecipientsPhone.AutoSize = true;
            LRecipientsPhone.Dock = DockStyle.Fill;
            LRecipientsPhone.Font = new Font("Segoe UI", 12F);
            LRecipientsPhone.Location = new Point(3, 320);
            LRecipientsPhone.Name = "LRecipientsPhone";
            LRecipientsPhone.Size = new Size(590, 40);
            LRecipientsPhone.TabIndex = 0;
            LRecipientsPhone.Text = "Телефон";
            LRecipientsPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TRecipientsPhone
            // 
            TRecipientsPhone.Dock = DockStyle.Fill;
            TRecipientsPhone.Enabled = false;
            TRecipientsPhone.Font = new Font("Segoe UI", 12F);
            TRecipientsPhone.Location = new Point(3, 363);
            TRecipientsPhone.Name = "TRecipientsPhone";
            TRecipientsPhone.Size = new Size(590, 34);
            TRecipientsPhone.TabIndex = 35;
            // 
            // CBRecipientAddress
            // 
            CBRecipientAddress.Dock = DockStyle.Fill;
            CBRecipientAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            CBRecipientAddress.Enabled = false;
            CBRecipientAddress.Font = new Font("Segoe UI", 12F);
            CBRecipientAddress.FormattingEnabled = true;
            CBRecipientAddress.Location = new Point(3, 203);
            CBRecipientAddress.Name = "CBRecipientAddress";
            CBRecipientAddress.Size = new Size(590, 36);
            CBRecipientAddress.TabIndex = 36;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel6);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 435);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Відправник";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoScroll = true;
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label16, 0, 2);
            tableLayoutPanel6.Controls.Add(label13, 0, 0);
            tableLayoutPanel6.Controls.Add(CBSender, 0, 1);
            tableLayoutPanel6.Controls.Add(label15, 0, 4);
            tableLayoutPanel6.Controls.Add(CBCitySender, 0, 3);
            tableLayoutPanel6.Controls.Add(CBSenderAddress, 0, 5);
            tableLayoutPanel6.Controls.Add(label14, 0, 6);
            tableLayoutPanel6.Controls.Add(CBContactSender, 0, 7);
            tableLayoutPanel6.Controls.Add(LSendersPhone, 0, 8);
            tableLayoutPanel6.Controls.Add(TSendersPhone, 0, 9);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 30);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 10;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(595, 402);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(3, 80);
            label16.Name = "label16";
            label16.Size = new Size(589, 40);
            label16.TabIndex = 23;
            label16.Text = "Місто";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(589, 40);
            label13.TabIndex = 20;
            label13.Text = "Відправник ПІБ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBSender
            // 
            CBSender.Dock = DockStyle.Fill;
            CBSender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSender.Enabled = false;
            CBSender.Font = new Font("Segoe UI", 12F);
            CBSender.FormattingEnabled = true;
            CBSender.Location = new Point(3, 43);
            CBSender.Name = "CBSender";
            CBSender.Size = new Size(589, 36);
            CBSender.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(3, 160);
            label15.Name = "label15";
            label15.Size = new Size(589, 40);
            label15.TabIndex = 22;
            label15.Text = "Адреса";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBCitySender
            // 
            CBCitySender.Dock = DockStyle.Fill;
            CBCitySender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCitySender.Enabled = false;
            CBCitySender.Font = new Font("Segoe UI", 12F);
            CBCitySender.FormattingEnabled = true;
            CBCitySender.Location = new Point(3, 123);
            CBCitySender.Name = "CBCitySender";
            CBCitySender.Size = new Size(589, 36);
            CBCitySender.TabIndex = 31;
            // 
            // CBSenderAddress
            // 
            CBSenderAddress.Dock = DockStyle.Fill;
            CBSenderAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSenderAddress.Enabled = false;
            CBSenderAddress.Font = new Font("Segoe UI", 12F);
            CBSenderAddress.FormattingEnabled = true;
            CBSenderAddress.Location = new Point(3, 203);
            CBSenderAddress.Name = "CBSenderAddress";
            CBSenderAddress.Size = new Size(589, 36);
            CBSenderAddress.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(3, 240);
            label14.Name = "label14";
            label14.Size = new Size(589, 40);
            label14.TabIndex = 21;
            label14.Text = "Контакт";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBContactSender
            // 
            CBContactSender.Dock = DockStyle.Fill;
            CBContactSender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBContactSender.Enabled = false;
            CBContactSender.Font = new Font("Segoe UI", 12F);
            CBContactSender.FormattingEnabled = true;
            CBContactSender.Location = new Point(3, 283);
            CBContactSender.Name = "CBContactSender";
            CBContactSender.Size = new Size(589, 36);
            CBContactSender.TabIndex = 33;
            // 
            // LSendersPhone
            // 
            LSendersPhone.AutoSize = true;
            LSendersPhone.Dock = DockStyle.Fill;
            LSendersPhone.Font = new Font("Segoe UI", 12F);
            LSendersPhone.Location = new Point(3, 320);
            LSendersPhone.Name = "LSendersPhone";
            LSendersPhone.Size = new Size(589, 40);
            LSendersPhone.TabIndex = 27;
            LSendersPhone.Text = "Телефон";
            LSendersPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TSendersPhone
            // 
            TSendersPhone.Dock = DockStyle.Fill;
            TSendersPhone.Enabled = false;
            TSendersPhone.Font = new Font("Segoe UI", 12F);
            TSendersPhone.Location = new Point(3, 363);
            TSendersPhone.Name = "TSendersPhone";
            TSendersPhone.Size = new Size(589, 34);
            TSendersPhone.TabIndex = 34;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tabControl1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox4.Location = new Point(13, 256);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1215, 245);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Розміри";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1209, 212);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1201, 171);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Детальні параметри";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 397F));
            tableLayoutPanel3.Controls.Add(label24, 2, 2);
            tableLayoutPanel3.Controls.Add(label8, 2, 1);
            tableLayoutPanel3.Controls.Add(label23, 0, 0);
            tableLayoutPanel3.Controls.Add(NUDDetailWeight, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label20, 0, 2);
            tableLayoutPanel3.Controls.Add(NUDDetailLenght, 1, 1);
            tableLayoutPanel3.Controls.Add(NUDDetailWidht, 1, 2);
            tableLayoutPanel3.Controls.Add(NUDDetailHeight, 1, 3);
            tableLayoutPanel3.Controls.Add(label21, 0, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 3, 0);
            tableLayoutPanel3.Controls.Add(label7, 2, 0);
            tableLayoutPanel3.Controls.Add(label11, 2, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(1195, 165);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Fill;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(446, 83);
            label24.Name = "label24";
            label24.Size = new Size(54, 40);
            label24.TabIndex = 42;
            label24.Text = "см";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(446, 42);
            label8.Name = "label8";
            label8.Size = new Size(54, 40);
            label8.TabIndex = 40;
            label8.Text = "см";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Dock = DockStyle.Fill;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(4, 1);
            label23.Name = "label23";
            label23.Size = new Size(214, 40);
            label23.TabIndex = 34;
            label23.Text = "Вага";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDDetailWeight
            // 
            NUDDetailWeight.DecimalPlaces = 1;
            NUDDetailWeight.Dock = DockStyle.Fill;
            NUDDetailWeight.Font = new Font("Segoe UI", 12F);
            NUDDetailWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NUDDetailWeight.Location = new Point(225, 4);
            NUDDetailWeight.Name = "NUDDetailWeight";
            NUDDetailWeight.Size = new Size(214, 34);
            NUDDetailWeight.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(4, 42);
            label2.Name = "label2";
            label2.Size = new Size(214, 40);
            label2.TabIndex = 7;
            label2.Text = "Довжина";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(4, 83);
            label20.Name = "label20";
            label20.Size = new Size(214, 40);
            label20.TabIndex = 18;
            label20.Text = "Ширина";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDDetailLenght
            // 
            NUDDetailLenght.Dock = DockStyle.Fill;
            NUDDetailLenght.Font = new Font("Segoe UI", 12F);
            NUDDetailLenght.Location = new Point(225, 45);
            NUDDetailLenght.Name = "NUDDetailLenght";
            NUDDetailLenght.Size = new Size(214, 34);
            NUDDetailLenght.TabIndex = 31;
            // 
            // NUDDetailWidht
            // 
            NUDDetailWidht.Dock = DockStyle.Fill;
            NUDDetailWidht.Font = new Font("Segoe UI", 12F);
            NUDDetailWidht.Location = new Point(225, 86);
            NUDDetailWidht.Name = "NUDDetailWidht";
            NUDDetailWidht.Size = new Size(214, 34);
            NUDDetailWidht.TabIndex = 36;
            // 
            // NUDDetailHeight
            // 
            NUDDetailHeight.Dock = DockStyle.Fill;
            NUDDetailHeight.Font = new Font("Segoe UI", 12F);
            NUDDetailHeight.Location = new Point(225, 127);
            NUDDetailHeight.Name = "NUDDetailHeight";
            NUDDetailHeight.Size = new Size(214, 34);
            NUDDetailHeight.TabIndex = 37;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(4, 124);
            label21.Name = "label21";
            label21.Size = new Size(214, 40);
            label21.TabIndex = 32;
            label21.Text = "Висота";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(VolumeGeneral, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(507, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(394, 34);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // VolumeGeneral
            // 
            VolumeGeneral.AutoSize = true;
            VolumeGeneral.Dock = DockStyle.Fill;
            VolumeGeneral.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VolumeGeneral.Location = new Point(200, 0);
            VolumeGeneral.Name = "VolumeGeneral";
            VolumeGeneral.Size = new Size(191, 34);
            VolumeGeneral.TabIndex = 1;
            toolTip1.SetToolTip(VolumeGeneral, "Об’ємна вага розраховується за формулою (Довжина × Ширина × Висота, см) / 4000 та порівнюється з фактичною вагою. Більший показник використовується в розрахунках вартості перевезення.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 34);
            label1.TabIndex = 0;
            label1.Text = "Загальний об'єм";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(446, 1);
            label7.Name = "label7";
            label7.Size = new Size(54, 40);
            label7.TabIndex = 39;
            label7.Text = "кг";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(446, 124);
            label11.Name = "label11";
            label11.Size = new Size(54, 40);
            label11.TabIndex = 41;
            label11.Text = "см";
            // 
            // OrderCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(151, 62, 189);
            ClientSize = new Size(1241, 961);
            Controls.Add(Root);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderCreate";
            Text = "Створення відправлення";
            Root.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCost).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailLenght).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWidht).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailHeight).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox CbPayerType;
        private ComboBox CbCargoType;
        private DateTimePicker DtpDateTime;
        private ComboBox CbPaymentMethod;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label14;
        private Label label13;
        private Label label16;
        private Label label15;
        private Label LSendersPhone;
        private ComboBox CbServiceType;
        private TextBox TDescription;
        private NumericUpDown NUDCost;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel6;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox CBContactRecipient;
        private Label label19;
        private Label label22;
        private Label label18;
        private Label label17;
        private ComboBox CBCityRecipient;
        private Label LRecipientsPhone;
        private ComboBox CBRecipient;
        private ComboBox CBContactSender;
        private ComboBox CBSenderAddress;
        private ComboBox CBCitySender;
        private ComboBox CBSender;
        private TextBox TRecipientsPhone;
        private Button BCreateOrder;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TextBox TSendersPhone;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label label20;
        private NumericUpDown NUDDetailLenght;
        private ComboBox CBRecipientAddress;
        private Label label23;
        private NumericUpDown NUDDetailWeight;
        private Label label21;
        private NumericUpDown NUDDetailWidht;
        private NumericUpDown NUDDetailHeight;
        private TableLayoutPanel tableLayoutPanel1;
        private Label VolumeGeneral;
        private Label label1;
        private Button BPrinter;
        private Label label24;
        private Label label8;
        private Label label7;
        private Label label11;
    }
}