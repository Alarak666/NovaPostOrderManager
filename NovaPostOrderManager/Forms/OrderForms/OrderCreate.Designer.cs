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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label23 = new Label();
            NUDDetailWeight = new NumericUpDown();
            label2 = new Label();
            label20 = new Label();
            label21 = new Label();
            NUDDetailLenght = new NumericUpDown();
            NUDDetailWidht = new NumericUpDown();
            NUDDetailHeight = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            NUDSeatsAmount = new NumericUpDown();
            label8 = new Label();
            NUDWeight = new NumericUpDown();
            label7 = new Label();
            NUDVolumeGeneral = new NumericUpDown();
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
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailLenght).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWidht).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailHeight).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDSeatsAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDVolumeGeneral).BeginInit();
            SuspendLayout();
            // 
            // Root
            // 
            Root.AutoScroll = true;
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.Controls.Add(groupBox1, 1, 1);
            Root.Controls.Add(tableLayoutPanel4, 1, 3);
            Root.Controls.Add(groupBox4, 1, 2);
            Root.Dock = DockStyle.Fill;
            Root.Font = new Font("Segoe UI", 11F);
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.RowCount = 5;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 243F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 448F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            Root.Size = new Size(1216, 1055);
            Root.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(43, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 237);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметри відправлення";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
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
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Size = new Size(1124, 206);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            tableLayoutPanel2.SetRowSpan(label12, 2);
            label12.Size = new Size(237, 70);
            label12.TabIndex = 19;
            label12.Text = "Опис";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TDescription
            // 
            tableLayoutPanel2.SetColumnSpan(TDescription, 2);
            TDescription.Dock = DockStyle.Fill;
            TDescription.Font = new Font("Segoe UI", 9F);
            TDescription.Location = new Point(246, 3);
            TDescription.Multiline = true;
            TDescription.Name = "TDescription";
            TDescription.ReadOnly = true;
            tableLayoutPanel2.SetRowSpan(TDescription, 2);
            TDescription.ScrollBars = ScrollBars.Horizontal;
            TDescription.Size = new Size(431, 64);
            TDescription.TabIndex = 32;
            TDescription.Text = "Товари медичного призначення ";
            toolTip1.SetToolTip(TDescription, "Максимум 120 символів");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(683, 0);
            label9.Name = "label9";
            label9.Size = new Size(171, 43);
            label9.TabIndex = 16;
            label9.Text = "Ціна";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDCost
            // 
            NUDCost.DecimalPlaces = 2;
            NUDCost.Dock = DockStyle.Fill;
            NUDCost.Enabled = false;
            NUDCost.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NUDCost.Location = new Point(860, 3);
            NUDCost.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            NUDCost.Name = "NUDCost";
            NUDCost.Size = new Size(261, 32);
            NUDCost.TabIndex = 33;
            toolTip1.SetToolTip(NUDCost, "Ціна");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(683, 43);
            label3.Name = "label3";
            label3.Size = new Size(171, 27);
            label3.TabIndex = 2;
            label3.Text = "Платник за доставку";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbPayerType
            // 
            CbPayerType.Dock = DockStyle.Fill;
            CbPayerType.Enabled = false;
            CbPayerType.FormattingEnabled = true;
            CbPayerType.Location = new Point(860, 46);
            CbPayerType.Name = "CbPayerType";
            CbPayerType.Size = new Size(261, 33);
            CbPayerType.TabIndex = 9;
            // 
            // DtpDateTime
            // 
            DtpDateTime.Dock = DockStyle.Fill;
            DtpDateTime.Enabled = false;
            DtpDateTime.Location = new Point(246, 73);
            DtpDateTime.Name = "DtpDateTime";
            DtpDateTime.Size = new Size(224, 32);
            DtpDateTime.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 70);
            label5.Name = "label5";
            label5.Size = new Size(237, 35);
            label5.TabIndex = 4;
            label5.Text = "Дата відправлення";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(683, 70);
            label4.Name = "label4";
            label4.Size = new Size(171, 35);
            label4.TabIndex = 3;
            label4.Text = "Форма оплати";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbPaymentMethod
            // 
            CbPaymentMethod.Dock = DockStyle.Fill;
            CbPaymentMethod.Enabled = false;
            CbPaymentMethod.FormattingEnabled = true;
            CbPaymentMethod.Location = new Point(860, 73);
            CbPaymentMethod.Name = "CbPaymentMethod";
            CbPaymentMethod.Size = new Size(261, 33);
            CbPaymentMethod.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(683, 144);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 5;
            label6.Text = "Тип вантажу";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbCargoType
            // 
            CbCargoType.Dock = DockStyle.Fill;
            CbCargoType.Enabled = false;
            CbCargoType.FormattingEnabled = true;
            CbCargoType.Location = new Point(860, 147);
            CbCargoType.Name = "CbCargoType";
            CbCargoType.Size = new Size(261, 33);
            CbCargoType.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(683, 105);
            label10.Name = "label10";
            label10.Size = new Size(127, 25);
            label10.TabIndex = 17;
            label10.Text = "Тип доставки";
            // 
            // CbServiceType
            // 
            CbServiceType.Dock = DockStyle.Fill;
            CbServiceType.Enabled = false;
            CbServiceType.FormattingEnabled = true;
            CbServiceType.Location = new Point(860, 108);
            CbServiceType.Name = "CbServiceType";
            CbServiceType.Size = new Size(261, 33);
            CbServiceType.TabIndex = 30;
            // 
            // BCreateOrder
            // 
            BCreateOrder.Dock = DockStyle.Fill;
            BCreateOrder.Enabled = false;
            BCreateOrder.Location = new Point(3, 108);
            BCreateOrder.Name = "BCreateOrder";
            BCreateOrder.Size = new Size(237, 33);
            BCreateOrder.TabIndex = 34;
            BCreateOrder.Text = "Створити ТТН";
            BCreateOrder.UseVisualStyleBackColor = true;
            BCreateOrder.Click += BCreateOrder_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(43, 564);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1130, 442);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(568, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(559, 436);
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
            tableLayoutPanel5.Location = new Point(3, 28);
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
            tableLayoutPanel5.Size = new Size(553, 405);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Location = new Point(3, 80);
            label22.Name = "label22";
            label22.Size = new Size(547, 40);
            label22.TabIndex = 29;
            label22.Text = "Місто";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(547, 40);
            label17.TabIndex = 24;
            label17.Text = "Отримувач ПІБ";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBRecipient
            // 
            CBRecipient.Dock = DockStyle.Fill;
            CBRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            CBRecipient.Enabled = false;
            CBRecipient.FormattingEnabled = true;
            CBRecipient.Location = new Point(3, 43);
            CBRecipient.Name = "CBRecipient";
            CBRecipient.Size = new Size(547, 33);
            CBRecipient.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Location = new Point(3, 160);
            label18.Name = "label18";
            label18.Size = new Size(547, 40);
            label18.TabIndex = 25;
            label18.Text = "Адреса";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBCityRecipient
            // 
            CBCityRecipient.Dock = DockStyle.Fill;
            CBCityRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCityRecipient.Enabled = false;
            CBCityRecipient.FormattingEnabled = true;
            CBCityRecipient.Location = new Point(3, 123);
            CBCityRecipient.Name = "CBCityRecipient";
            CBCityRecipient.Size = new Size(547, 33);
            CBCityRecipient.TabIndex = 30;
            // 
            // CBContactRecipient
            // 
            CBContactRecipient.Dock = DockStyle.Fill;
            CBContactRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            CBContactRecipient.Enabled = false;
            CBContactRecipient.FormattingEnabled = true;
            CBContactRecipient.Location = new Point(3, 283);
            CBContactRecipient.Name = "CBContactRecipient";
            CBContactRecipient.Size = new Size(547, 33);
            CBContactRecipient.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Location = new Point(3, 240);
            label19.Name = "label19";
            label19.Size = new Size(547, 40);
            label19.TabIndex = 26;
            label19.Text = "Контакт";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LRecipientsPhone
            // 
            LRecipientsPhone.AutoSize = true;
            LRecipientsPhone.Dock = DockStyle.Fill;
            LRecipientsPhone.Location = new Point(3, 320);
            LRecipientsPhone.Name = "LRecipientsPhone";
            LRecipientsPhone.Size = new Size(547, 40);
            LRecipientsPhone.TabIndex = 0;
            LRecipientsPhone.Text = "Телефон";
            LRecipientsPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TRecipientsPhone
            // 
            TRecipientsPhone.Dock = DockStyle.Fill;
            TRecipientsPhone.Enabled = false;
            TRecipientsPhone.Location = new Point(3, 363);
            TRecipientsPhone.Name = "TRecipientsPhone";
            TRecipientsPhone.Size = new Size(547, 32);
            TRecipientsPhone.TabIndex = 35;
            // 
            // CBRecipientAddress
            // 
            CBRecipientAddress.Dock = DockStyle.Fill;
            CBRecipientAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            CBRecipientAddress.Enabled = false;
            CBRecipientAddress.FormattingEnabled = true;
            CBRecipientAddress.Location = new Point(3, 203);
            CBRecipientAddress.Name = "CBRecipientAddress";
            CBRecipientAddress.Size = new Size(547, 33);
            CBRecipientAddress.TabIndex = 36;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel6);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(559, 436);
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
            tableLayoutPanel6.Location = new Point(3, 28);
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
            tableLayoutPanel6.Size = new Size(553, 405);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(3, 80);
            label16.Name = "label16";
            label16.Size = new Size(547, 40);
            label16.TabIndex = 23;
            label16.Text = "Місто";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(547, 40);
            label13.TabIndex = 20;
            label13.Text = "Відправник ПІБ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBSender
            // 
            CBSender.Dock = DockStyle.Fill;
            CBSender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSender.Enabled = false;
            CBSender.FormattingEnabled = true;
            CBSender.Location = new Point(3, 43);
            CBSender.Name = "CBSender";
            CBSender.Size = new Size(547, 33);
            CBSender.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(3, 160);
            label15.Name = "label15";
            label15.Size = new Size(547, 40);
            label15.TabIndex = 22;
            label15.Text = "Адреса";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBCitySender
            // 
            CBCitySender.Dock = DockStyle.Fill;
            CBCitySender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCitySender.Enabled = false;
            CBCitySender.FormattingEnabled = true;
            CBCitySender.Location = new Point(3, 123);
            CBCitySender.Name = "CBCitySender";
            CBCitySender.Size = new Size(547, 33);
            CBCitySender.TabIndex = 31;
            // 
            // CBSenderAddress
            // 
            CBSenderAddress.Dock = DockStyle.Fill;
            CBSenderAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSenderAddress.Enabled = false;
            CBSenderAddress.FormattingEnabled = true;
            CBSenderAddress.Location = new Point(3, 203);
            CBSenderAddress.Name = "CBSenderAddress";
            CBSenderAddress.Size = new Size(547, 33);
            CBSenderAddress.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(3, 240);
            label14.Name = "label14";
            label14.Size = new Size(547, 40);
            label14.TabIndex = 21;
            label14.Text = "Контакт";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBContactSender
            // 
            CBContactSender.Dock = DockStyle.Fill;
            CBContactSender.DropDownStyle = ComboBoxStyle.DropDownList;
            CBContactSender.Enabled = false;
            CBContactSender.FormattingEnabled = true;
            CBContactSender.Location = new Point(3, 283);
            CBContactSender.Name = "CBContactSender";
            CBContactSender.Size = new Size(547, 33);
            CBContactSender.TabIndex = 33;
            // 
            // LSendersPhone
            // 
            LSendersPhone.AutoSize = true;
            LSendersPhone.Dock = DockStyle.Fill;
            LSendersPhone.Location = new Point(3, 320);
            LSendersPhone.Name = "LSendersPhone";
            LSendersPhone.Size = new Size(547, 40);
            LSendersPhone.TabIndex = 27;
            LSendersPhone.Text = "Телефон";
            LSendersPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TSendersPhone
            // 
            TSendersPhone.Dock = DockStyle.Fill;
            TSendersPhone.Enabled = false;
            TSendersPhone.Location = new Point(3, 363);
            TSendersPhone.Name = "TSendersPhone";
            TSendersPhone.Size = new Size(547, 32);
            TSendersPhone.TabIndex = 34;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tabControl1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(43, 284);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1130, 274);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Розміри";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1124, 243);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1116, 205);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Загальні параметри";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1116, 205);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Детальні параметри";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel3.Controls.Add(label23, 0, 0);
            tableLayoutPanel3.Controls.Add(NUDDetailWeight, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label20, 0, 2);
            tableLayoutPanel3.Controls.Add(label21, 0, 3);
            tableLayoutPanel3.Controls.Add(NUDDetailLenght, 1, 1);
            tableLayoutPanel3.Controls.Add(NUDDetailWidht, 1, 2);
            tableLayoutPanel3.Controls.Add(NUDDetailHeight, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(1110, 199);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(3, 0);
            label23.Name = "label23";
            label23.Size = new Size(50, 25);
            label23.TabIndex = 34;
            label23.Text = "Вага";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDDetailWeight
            // 
            NUDDetailWeight.Location = new Point(223, 3);
            NUDDetailWeight.Name = "NUDDetailWeight";
            NUDDetailWeight.Size = new Size(214, 32);
            NUDDetailWeight.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 7;
            label2.Text = "Довжина";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 80);
            label20.Name = "label20";
            label20.Size = new Size(84, 25);
            label20.TabIndex = 18;
            label20.Text = "Ширина";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 120);
            label21.Name = "label21";
            label21.Size = new Size(72, 25);
            label21.TabIndex = 32;
            label21.Text = "Висота";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDDetailLenght
            // 
            NUDDetailLenght.Location = new Point(223, 43);
            NUDDetailLenght.Name = "NUDDetailLenght";
            NUDDetailLenght.Size = new Size(214, 32);
            NUDDetailLenght.TabIndex = 31;
            // 
            // NUDDetailWidht
            // 
            NUDDetailWidht.Location = new Point(223, 83);
            NUDDetailWidht.Name = "NUDDetailWidht";
            NUDDetailWidht.Size = new Size(214, 32);
            NUDDetailWidht.TabIndex = 36;
            // 
            // NUDDetailHeight
            // 
            NUDDetailHeight.Location = new Point(223, 123);
            NUDDetailHeight.Name = "NUDDetailHeight";
            NUDDetailHeight.Size = new Size(214, 32);
            NUDDetailHeight.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(NUDVolumeGeneral, 1, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(NUDWeight, 1, 2);
            tableLayoutPanel1.Controls.Add(label11, 0, 3);
            tableLayoutPanel1.Controls.Add(NUDSeatsAmount, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1110, 199);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 120);
            label11.Name = "label11";
            label11.Size = new Size(214, 79);
            label11.TabIndex = 18;
            label11.Text = "Кількість місць";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDSeatsAmount
            // 
            NUDSeatsAmount.Dock = DockStyle.Fill;
            NUDSeatsAmount.Enabled = false;
            NUDSeatsAmount.Location = new Point(223, 123);
            NUDSeatsAmount.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDSeatsAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDSeatsAmount.Name = "NUDSeatsAmount";
            NUDSeatsAmount.Size = new Size(214, 32);
            NUDSeatsAmount.TabIndex = 31;
            NUDSeatsAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 80);
            label8.Name = "label8";
            label8.Size = new Size(214, 40);
            label8.TabIndex = 7;
            label8.Text = "Загальна вага";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDWeight
            // 
            NUDWeight.DecimalPlaces = 2;
            NUDWeight.Dock = DockStyle.Fill;
            NUDWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NUDWeight.Location = new Point(223, 83);
            NUDWeight.Name = "NUDWeight";
            NUDWeight.Size = new Size(214, 32);
            NUDWeight.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 40);
            label7.Name = "label7";
            label7.Size = new Size(214, 40);
            label7.TabIndex = 6;
            label7.Text = "Загальний об'єм";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NUDVolumeGeneral
            // 
            NUDVolumeGeneral.DecimalPlaces = 2;
            NUDVolumeGeneral.Dock = DockStyle.Fill;
            NUDVolumeGeneral.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NUDVolumeGeneral.Location = new Point(223, 43);
            NUDVolumeGeneral.Name = "NUDVolumeGeneral";
            NUDVolumeGeneral.Size = new Size(214, 32);
            NUDVolumeGeneral.TabIndex = 14;
            toolTip1.SetToolTip(NUDVolumeGeneral, "Загальний об’єм є необовязковим за умови заповнення поля «Загальна вага»");
            // 
            // OrderCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 1055);
            Controls.Add(Root);
            Name = "OrderCreate";
            Text = "OrderCreate";
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
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailLenght).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailWidht).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDetailHeight).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDSeatsAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDVolumeGeneral).EndInit();
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
        private TabPage tabPage1;
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
        private Label label7;
        private NumericUpDown NUDVolumeGeneral;
        private Label label8;
        private NumericUpDown NUDWeight;
        private Label label11;
        private NumericUpDown NUDSeatsAmount;
    }
}