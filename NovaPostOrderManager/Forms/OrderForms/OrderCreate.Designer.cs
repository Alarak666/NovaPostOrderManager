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
            Root = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label10 = new Label();
            NUDWeight = new NumericUpDown();
            CbCargoType = new ComboBox();
            TRecipientWarehouseIndex = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TSenderWarehouseIndex = new TextBox();
            CbPayerType = new ComboBox();
            DtpDateTime = new DateTimePicker();
            CbPaymentMethod = new ComboBox();
            NUDVolumeGeneral = new NumericUpDown();
            label12 = new Label();
            label9 = new Label();
            label11 = new Label();
            label17 = new Label();
            label14 = new Label();
            label13 = new Label();
            label16 = new Label();
            label15 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label19 = new Label();
            label18 = new Label();
            CbServiceType = new ComboBox();
            NUDSeatsAmount = new NumericUpDown();
            TDescription = new TextBox();
            NUDCost = new NumericUpDown();
            TSender = new TextBox();
            TCitySender = new TextBox();
            TContactSender = new TextBox();
            TSenderAddress = new TextBox();
            TSendersPhone = new TextBox();
            TRecipientAddress = new TextBox();
            TCityRecipient = new TextBox();
            TRecipient = new TextBox();
            TContactRecipient = new TextBox();
            TRecipientsPhone = new TextBox();
            Root.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDVolumeGeneral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDSeatsAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDCost).BeginInit();
            SuspendLayout();
            // 
            // Root
            // 
            Root.ColumnCount = 3;
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Root.Controls.Add(tableLayoutPanel1, 1, 1);
            Root.Dock = DockStyle.Fill;
            Root.Location = new Point(0, 0);
            Root.Name = "Root";
            Root.RowCount = 3;
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            Root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Root.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Root.Size = new Size(941, 728);
            Root.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(NUDWeight, 3, 3);
            tableLayoutPanel1.Controls.Add(CbCargoType, 3, 2);
            tableLayoutPanel1.Controls.Add(TRecipientWarehouseIndex, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 2, 3);
            tableLayoutPanel1.Controls.Add(TSenderWarehouseIndex, 1, 0);
            tableLayoutPanel1.Controls.Add(CbPayerType, 1, 1);
            tableLayoutPanel1.Controls.Add(DtpDateTime, 1, 2);
            tableLayoutPanel1.Controls.Add(CbPaymentMethod, 3, 1);
            tableLayoutPanel1.Controls.Add(NUDVolumeGeneral, 1, 3);
            tableLayoutPanel1.Controls.Add(label12, 0, 5);
            tableLayoutPanel1.Controls.Add(label9, 2, 5);
            tableLayoutPanel1.Controls.Add(label11, 2, 4);
            tableLayoutPanel1.Controls.Add(label17, 2, 10);
            tableLayoutPanel1.Controls.Add(label14, 0, 9);
            tableLayoutPanel1.Controls.Add(label13, 0, 6);
            tableLayoutPanel1.Controls.Add(label16, 0, 7);
            tableLayoutPanel1.Controls.Add(label15, 0, 8);
            tableLayoutPanel1.Controls.Add(label20, 0, 10);
            tableLayoutPanel1.Controls.Add(label21, 2, 6);
            tableLayoutPanel1.Controls.Add(label22, 2, 7);
            tableLayoutPanel1.Controls.Add(label19, 2, 9);
            tableLayoutPanel1.Controls.Add(label18, 2, 8);
            tableLayoutPanel1.Controls.Add(CbServiceType, 1, 4);
            tableLayoutPanel1.Controls.Add(NUDSeatsAmount, 3, 4);
            tableLayoutPanel1.Controls.Add(TDescription, 1, 5);
            tableLayoutPanel1.Controls.Add(NUDCost, 3, 5);
            tableLayoutPanel1.Controls.Add(TSender, 1, 6);
            tableLayoutPanel1.Controls.Add(TCitySender, 1, 7);
            tableLayoutPanel1.Controls.Add(TContactSender, 1, 9);
            tableLayoutPanel1.Controls.Add(TSenderAddress, 1, 8);
            tableLayoutPanel1.Controls.Add(TSendersPhone, 1, 10);
            tableLayoutPanel1.Controls.Add(TRecipientAddress, 3, 8);
            tableLayoutPanel1.Controls.Add(TCityRecipient, 3, 7);
            tableLayoutPanel1.Controls.Add(TRecipient, 3, 6);
            tableLayoutPanel1.Controls.Add(TContactRecipient, 3, 9);
            tableLayoutPanel1.Controls.Add(TRecipientsPhone, 3, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(43, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(855, 644);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 120);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 17;
            label10.Text = "ServiceType";
            // 
            // NUDWeight
            // 
            NUDWeight.DecimalPlaces = 2;
            NUDWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NUDWeight.Location = new Point(670, 93);
            NUDWeight.Name = "NUDWeight";
            NUDWeight.Size = new Size(150, 27);
            NUDWeight.TabIndex = 15;
            // 
            // CbCargoType
            // 
            CbCargoType.FormattingEnabled = true;
            CbCargoType.Location = new Point(670, 63);
            CbCargoType.Name = "CbCargoType";
            CbCargoType.Size = new Size(151, 28);
            CbCargoType.TabIndex = 13;
            // 
            // TRecipientWarehouseIndex
            // 
            TRecipientWarehouseIndex.Location = new Point(670, 3);
            TRecipientWarehouseIndex.Name = "TRecipientWarehouseIndex";
            TRecipientWarehouseIndex.Size = new Size(125, 27);
            TRecipientWarehouseIndex.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "SenderWarehouseIndex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 30);
            label2.TabIndex = 1;
            label2.Text = "RecipientWarehouseIndex";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "PayerType";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 30);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 3;
            label4.Text = "PaymentMethod";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 60);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "DateTime";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(509, 60);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 5;
            label6.Text = "CargoType";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 90);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 6;
            label7.Text = "VolumeGeneral";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(509, 90);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 7;
            label8.Text = "Weight";
            // 
            // TSenderWarehouseIndex
            // 
            TSenderWarehouseIndex.Location = new Point(315, 3);
            TSenderWarehouseIndex.Name = "TSenderWarehouseIndex";
            TSenderWarehouseIndex.Size = new Size(125, 27);
            TSenderWarehouseIndex.TabIndex = 8;
            // 
            // CbPayerType
            // 
            CbPayerType.FormattingEnabled = true;
            CbPayerType.Location = new Point(315, 33);
            CbPayerType.Name = "CbPayerType";
            CbPayerType.Size = new Size(151, 28);
            CbPayerType.TabIndex = 9;
            // 
            // DtpDateTime
            // 
            DtpDateTime.Location = new Point(315, 63);
            DtpDateTime.Name = "DtpDateTime";
            DtpDateTime.Size = new Size(188, 27);
            DtpDateTime.TabIndex = 10;
            // 
            // CbPaymentMethod
            // 
            CbPaymentMethod.FormattingEnabled = true;
            CbPaymentMethod.Location = new Point(670, 33);
            CbPaymentMethod.Name = "CbPaymentMethod";
            CbPaymentMethod.Size = new Size(151, 28);
            CbPaymentMethod.TabIndex = 11;
            // 
            // NUDVolumeGeneral
            // 
            NUDVolumeGeneral.DecimalPlaces = 2;
            NUDVolumeGeneral.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NUDVolumeGeneral.Location = new Point(315, 93);
            NUDVolumeGeneral.Name = "NUDVolumeGeneral";
            NUDVolumeGeneral.Size = new Size(150, 27);
            NUDVolumeGeneral.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 150);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 19;
            label12.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(509, 150);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 16;
            label9.Text = "Cost";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(509, 120);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 18;
            label11.Text = "SeatsAmount";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(509, 300);
            label17.Name = "label17";
            label17.Size = new Size(118, 20);
            label17.TabIndex = 24;
            label17.Text = "RecipientsPhone";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 270);
            label14.Name = "label14";
            label14.Size = new Size(106, 20);
            label14.TabIndex = 21;
            label14.Text = "ContactSender";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 180);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 20;
            label13.Text = "Sender";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 210);
            label16.Name = "label16";
            label16.Size = new Size(80, 20);
            label16.TabIndex = 23;
            label16.Text = "CitySender";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 240);
            label15.Name = "label15";
            label15.Size = new Size(108, 20);
            label15.TabIndex = 22;
            label15.Text = "SenderAddress";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 300);
            label20.Name = "label20";
            label20.Size = new Size(102, 20);
            label20.TabIndex = 27;
            label20.Text = "SendersPhone";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(509, 180);
            label21.Name = "label21";
            label21.Size = new Size(71, 20);
            label21.TabIndex = 28;
            label21.Text = "Recipient";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(509, 210);
            label22.Name = "label22";
            label22.Size = new Size(96, 20);
            label22.TabIndex = 29;
            label22.Text = "CityRecipient";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(509, 270);
            label19.Name = "label19";
            label19.Size = new Size(122, 20);
            label19.TabIndex = 26;
            label19.Text = "ContactRecipient";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(509, 240);
            label18.Name = "label18";
            label18.Size = new Size(124, 20);
            label18.TabIndex = 25;
            label18.Text = "RecipientAddress";
            // 
            // CbServiceType
            // 
            CbServiceType.FormattingEnabled = true;
            CbServiceType.Location = new Point(315, 123);
            CbServiceType.Name = "CbServiceType";
            CbServiceType.Size = new Size(151, 28);
            CbServiceType.TabIndex = 30;
            // 
            // NUDSeatsAmount
            // 
            NUDSeatsAmount.Location = new Point(670, 123);
            NUDSeatsAmount.Name = "NUDSeatsAmount";
            NUDSeatsAmount.Size = new Size(150, 27);
            NUDSeatsAmount.TabIndex = 31;
            // 
            // TDescription
            // 
            TDescription.Location = new Point(315, 153);
            TDescription.Name = "TDescription";
            TDescription.Size = new Size(125, 27);
            TDescription.TabIndex = 32;
            // 
            // NUDCost
            // 
            NUDCost.DecimalPlaces = 2;
            NUDCost.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NUDCost.Location = new Point(670, 153);
            NUDCost.Name = "NUDCost";
            NUDCost.Size = new Size(150, 27);
            NUDCost.TabIndex = 33;
            // 
            // TSender
            // 
            TSender.Location = new Point(315, 183);
            TSender.Name = "TSender";
            TSender.Size = new Size(125, 27);
            TSender.TabIndex = 35;
            // 
            // TCitySender
            // 
            TCitySender.Location = new Point(315, 213);
            TCitySender.Name = "TCitySender";
            TCitySender.Size = new Size(125, 27);
            TCitySender.TabIndex = 36;
            // 
            // TContactSender
            // 
            TContactSender.Location = new Point(315, 273);
            TContactSender.Name = "TContactSender";
            TContactSender.Size = new Size(125, 27);
            TContactSender.TabIndex = 37;
            // 
            // TSenderAddress
            // 
            TSenderAddress.Location = new Point(315, 243);
            TSenderAddress.Name = "TSenderAddress";
            TSenderAddress.Size = new Size(125, 27);
            TSenderAddress.TabIndex = 38;
            // 
            // TSendersPhone
            // 
            TSendersPhone.Location = new Point(315, 303);
            TSendersPhone.Name = "TSendersPhone";
            TSendersPhone.Size = new Size(125, 27);
            TSendersPhone.TabIndex = 39;
            // 
            // TRecipientAddress
            // 
            TRecipientAddress.Location = new Point(670, 243);
            TRecipientAddress.Name = "TRecipientAddress";
            TRecipientAddress.Size = new Size(125, 27);
            TRecipientAddress.TabIndex = 42;
            // 
            // TCityRecipient
            // 
            TCityRecipient.Location = new Point(670, 213);
            TCityRecipient.Name = "TCityRecipient";
            TCityRecipient.Size = new Size(125, 27);
            TCityRecipient.TabIndex = 40;
            // 
            // TRecipient
            // 
            TRecipient.Location = new Point(670, 183);
            TRecipient.Name = "TRecipient";
            TRecipient.Size = new Size(125, 27);
            TRecipient.TabIndex = 41;
            // 
            // TContactRecipient
            // 
            TContactRecipient.Location = new Point(670, 273);
            TContactRecipient.Name = "TContactRecipient";
            TContactRecipient.Size = new Size(125, 27);
            TContactRecipient.TabIndex = 43;
            // 
            // TRecipientsPhone
            // 
            TRecipientsPhone.Location = new Point(670, 303);
            TRecipientsPhone.Name = "TRecipientsPhone";
            TRecipientsPhone.Size = new Size(125, 27);
            TRecipientsPhone.TabIndex = 44;
            // 
            // OrderCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 728);
            Controls.Add(Root);
            Name = "OrderCreate";
            Text = "OrderCreate";
            Root.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDVolumeGeneral).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDSeatsAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDCost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Root;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TSenderWarehouseIndex;
        private ComboBox CbPayerType;
        private NumericUpDown NUDWeight;
        private ComboBox CbCargoType;
        private TextBox TRecipientWarehouseIndex;
        private DateTimePicker DtpDateTime;
        private ComboBox CbPaymentMethod;
        private NumericUpDown NUDVolumeGeneral;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label17;
        private Label label14;
        private Label label13;
        private Label label16;
        private Label label15;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label19;
        private Label label18;
        private ComboBox CbServiceType;
        private NumericUpDown NUDSeatsAmount;
        private TextBox TDescription;
        private NumericUpDown NUDCost;
        private TextBox TSender;
        private TextBox TCitySender;
        private TextBox TContactSender;
        private TextBox TSenderAddress;
        private TextBox TSendersPhone;
        private TextBox TRecipientAddress;
        private TextBox TCityRecipient;
        private TextBox TRecipient;
        private TextBox TContactRecipient;
        private TextBox TRecipientsPhone;
    }
}