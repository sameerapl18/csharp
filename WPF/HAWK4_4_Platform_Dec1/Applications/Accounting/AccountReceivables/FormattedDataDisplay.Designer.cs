namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class FormattedDataDisplay
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbox_DataStrings = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DocNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlCustomerDetails = new System.Windows.Forms.Panel();
            this.label_SupplierEmail = new System.Windows.Forms.Label();
            this.UPS = new System.Windows.Forms.Label();
            this.DeliveryMode = new System.Windows.Forms.Label();
            this.label_ShipAddress = new System.Windows.Forms.Label();
            this.label_ShippingAddr2 = new System.Windows.Forms.Label();
            this.label_ShipName = new System.Windows.Forms.Label();
            this.label_DateValue = new System.Windows.Forms.Label();
            this.label_OrderNum = new System.Windows.Forms.Label();
            this.InvoiceDate = new System.Windows.Forms.Label();
            this.ShipFrom = new System.Windows.Forms.Label();
            this.label_SupplierPhone = new System.Windows.Forms.Label();
            this.label_SupplierAddress2 = new System.Windows.Forms.Label();
            this.label_SupplierAddr = new System.Windows.Forms.Label();
            this.label_SupplierName = new System.Windows.Forms.Label();
            this.label_CustomerNum = new System.Windows.Forms.Label();
            this.Invoice = new System.Windows.Forms.Label();
            this.label_OrderNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(526, 149);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(363, 158);
            // 
            // comboBox_TableName
            // 
            this.comboBox_TableName.Size = new System.Drawing.Size(14, 21);
            this.comboBox_TableName.Visible = false;
            // 
            // textBox_ExternalRef
            // 
            this.textBox_ExternalRef.Location = new System.Drawing.Point(363, 200);
            // 
            // comboBox1
            // 
            this.comboBox1.Size = new System.Drawing.Size(10, 21);
            this.comboBox1.Visible = false;
            // 
            // textBox_InternalRef
            // 
            this.textBox_InternalRef.Location = new System.Drawing.Point(363, 232);
            this.textBox_InternalRef.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Size = new System.Drawing.Size(10, 21);
            this.comboBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.Visible = false;
            // 
            // button_Display
            // 
            this.button_Display.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button_Display.Location = new System.Drawing.Point(537, 243);
            this.button_Display.Text = "Display Invoice";
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(702, 243);
            this.button_Reset.Size = new System.Drawing.Size(115, 52);
            this.button_Reset.UseVisualStyleBackColor = false;
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(228, 28);
            this.label_SubName.Text = " Receivable Documents";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comments,
            this.Qunatity,
            this.Rate,
            this.TotalValue});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(186, 488);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Description";
            this.Comments.Name = "Comments";
            // 
            // Qunatity
            // 
            this.Qunatity.HeaderText = "Quantity";
            this.Qunatity.Name = "Qunatity";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "TotalValue";
            this.TotalValue.Name = "TotalValue";
            // 
            // textbox_DataStrings
            // 
            this.textbox_DataStrings.Location = new System.Drawing.Point(702, 493);
            this.textbox_DataStrings.Name = "textbox_DataStrings";
            this.textbox_DataStrings.Size = new System.Drawing.Size(375, 96);
            this.textbox_DataStrings.TabIndex = 20;
            this.textbox_DataStrings.Text = "";
            this.textbox_DataStrings.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Doc Num";
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Location = new System.Drawing.Point(361, 266);
            this.textBox_DocNum.Name = "textBox_DocNum";
            this.textBox_DocNum.Size = new System.Drawing.Size(114, 20);
            this.textBox_DocNum.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(839, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "Show/Hide Raw Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_RawData_Click);
            // 
            // pnlCustomerDetails
            // 
            this.pnlCustomerDetails.Controls.Add(this.label_SupplierEmail);
            this.pnlCustomerDetails.Controls.Add(this.UPS);
            this.pnlCustomerDetails.Controls.Add(this.DeliveryMode);
            this.pnlCustomerDetails.Controls.Add(this.label_ShipAddress);
            this.pnlCustomerDetails.Controls.Add(this.label_ShippingAddr2);
            this.pnlCustomerDetails.Controls.Add(this.label_ShipName);
            this.pnlCustomerDetails.Controls.Add(this.label_DateValue);
            this.pnlCustomerDetails.Controls.Add(this.label_OrderNum);
            this.pnlCustomerDetails.Controls.Add(this.InvoiceDate);
            this.pnlCustomerDetails.Controls.Add(this.ShipFrom);
            this.pnlCustomerDetails.Controls.Add(this.label_SupplierPhone);
            this.pnlCustomerDetails.Controls.Add(this.label_SupplierAddress2);
            this.pnlCustomerDetails.Controls.Add(this.label_SupplierAddr);
            this.pnlCustomerDetails.Controls.Add(this.label_SupplierName);
            this.pnlCustomerDetails.Controls.Add(this.label_CustomerNum);
            this.pnlCustomerDetails.Controls.Add(this.Invoice);
            this.pnlCustomerDetails.Controls.Add(this.label_OrderNumber);
            this.pnlCustomerDetails.Controls.Add(this.label3);
            this.pnlCustomerDetails.Location = new System.Drawing.Point(186, 301);
            this.pnlCustomerDetails.Name = "pnlCustomerDetails";
            this.pnlCustomerDetails.Size = new System.Drawing.Size(891, 175);
            this.pnlCustomerDetails.TabIndex = 24;
            this.pnlCustomerDetails.Visible = false;
            // 
            // label_SupplierEmail
            // 
            this.label_SupplierEmail.AutoSize = true;
            this.label_SupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SupplierEmail.Location = new System.Drawing.Point(287, 145);
            this.label_SupplierEmail.Name = "label_SupplierEmail";
            this.label_SupplierEmail.Size = new System.Drawing.Size(117, 13);
            this.label_SupplierEmail.TabIndex = 18;
            this.label_SupplierEmail.Text = "label_SupplierEmail";
            // 
            // UPS
            // 
            this.UPS.AutoSize = true;
            this.UPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPS.Location = new System.Drawing.Point(779, 145);
            this.UPS.Name = "UPS";
            this.UPS.Size = new System.Drawing.Size(32, 13);
            this.UPS.TabIndex = 17;
            this.UPS.Text = "UPS";
            // 
            // DeliveryMode
            // 
            this.DeliveryMode.AutoSize = true;
            this.DeliveryMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryMode.Location = new System.Drawing.Point(639, 146);
            this.DeliveryMode.Name = "DeliveryMode";
            this.DeliveryMode.Size = new System.Drawing.Size(88, 13);
            this.DeliveryMode.TabIndex = 16;
            this.DeliveryMode.Text = "Delivery Mode";
            // 
            // label_ShipAddress
            // 
            this.label_ShipAddress.AutoSize = true;
            this.label_ShipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShipAddress.Location = new System.Drawing.Point(639, 120);
            this.label_ShipAddress.Name = "label_ShipAddress";
            this.label_ShipAddress.Size = new System.Drawing.Size(111, 13);
            this.label_ShipAddress.TabIndex = 15;
            this.label_ShipAddress.Text = "label_ShipAddress";
            // 
            // label_ShippingAddr2
            // 
            this.label_ShippingAddr2.AutoSize = true;
            this.label_ShippingAddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShippingAddr2.Location = new System.Drawing.Point(639, 96);
            this.label_ShippingAddr2.Name = "label_ShippingAddr2";
            this.label_ShippingAddr2.Size = new System.Drawing.Size(123, 13);
            this.label_ShippingAddr2.TabIndex = 14;
            this.label_ShippingAddr2.Text = "label_ShippingAddr2";
            // 
            // label_ShipName
            // 
            this.label_ShipName.AutoSize = true;
            this.label_ShipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShipName.Location = new System.Drawing.Point(639, 73);
            this.label_ShipName.Name = "label_ShipName";
            this.label_ShipName.Size = new System.Drawing.Size(98, 13);
            this.label_ShipName.TabIndex = 13;
            this.label_ShipName.Text = "label_ShipName";
            // 
            // label_DateValue
            // 
            this.label_DateValue.AutoSize = true;
            this.label_DateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateValue.Location = new System.Drawing.Point(776, 30);
            this.label_DateValue.Name = "label_DateValue";
            this.label_DateValue.Size = new System.Drawing.Size(100, 13);
            this.label_DateValue.TabIndex = 12;
            this.label_DateValue.Text = "label_DateValue";
            // 
            // label_OrderNum
            // 
            this.label_OrderNum.AutoSize = true;
            this.label_OrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OrderNum.Location = new System.Drawing.Point(154, 30);
            this.label_OrderNum.Name = "label_OrderNum";
            this.label_OrderNum.Size = new System.Drawing.Size(97, 13);
            this.label_OrderNum.TabIndex = 11;
            this.label_OrderNum.Text = "label_OrderNum";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AutoSize = true;
            this.InvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceDate.Location = new System.Drawing.Point(663, 30);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(80, 13);
            this.InvoiceDate.TabIndex = 10;
            this.InvoiceDate.Text = "Invoice Date";
            // 
            // ShipFrom
            // 
            this.ShipFrom.AutoSize = true;
            this.ShipFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipFrom.Location = new System.Drawing.Point(555, 56);
            this.ShipFrom.Name = "ShipFrom";
            this.ShipFrom.Size = new System.Drawing.Size(63, 13);
            this.ShipFrom.TabIndex = 9;
            this.ShipFrom.Text = "Ship From";
            // 
            // label_SupplierPhone
            // 
            this.label_SupplierPhone.AutoSize = true;
            this.label_SupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SupplierPhone.Location = new System.Drawing.Point(124, 146);
            this.label_SupplierPhone.Name = "label_SupplierPhone";
            this.label_SupplierPhone.Size = new System.Drawing.Size(123, 13);
            this.label_SupplierPhone.TabIndex = 8;
            this.label_SupplierPhone.Text = "label_SupplierPhone";
            // 
            // label_SupplierAddress2
            // 
            this.label_SupplierAddress2.AutoSize = true;
            this.label_SupplierAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SupplierAddress2.Location = new System.Drawing.Point(124, 120);
            this.label_SupplierAddress2.Name = "label_SupplierAddress2";
            this.label_SupplierAddress2.Size = new System.Drawing.Size(139, 13);
            this.label_SupplierAddress2.TabIndex = 7;
            this.label_SupplierAddress2.Text = "label_SupplierAddress2";
            // 
            // label_SupplierAddr
            // 
            this.label_SupplierAddr.AutoSize = true;
            this.label_SupplierAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SupplierAddr.Location = new System.Drawing.Point(124, 96);
            this.label_SupplierAddr.Name = "label_SupplierAddr";
            this.label_SupplierAddr.Size = new System.Drawing.Size(113, 13);
            this.label_SupplierAddr.TabIndex = 6;
            this.label_SupplierAddr.Text = "label_SupplierAddr";
            // 
            // label_SupplierName
            // 
            this.label_SupplierName.AutoSize = true;
            this.label_SupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SupplierName.Location = new System.Drawing.Point(124, 73);
            this.label_SupplierName.Name = "label_SupplierName";
            this.label_SupplierName.Size = new System.Drawing.Size(119, 13);
            this.label_SupplierName.TabIndex = 5;
            this.label_SupplierName.Text = "label_SupplierName";
            // 
            // label_CustomerNum
            // 
            this.label_CustomerNum.AutoSize = true;
            this.label_CustomerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerNum.Location = new System.Drawing.Point(323, 57);
            this.label_CustomerNum.Name = "label_CustomerNum";
            this.label_CustomerNum.Size = new System.Drawing.Size(118, 13);
            this.label_CustomerNum.TabIndex = 4;
            this.label_CustomerNum.Text = "label_CustomerNum";
            // 
            // Invoice
            // 
            this.Invoice.AutoSize = true;
            this.Invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice.Location = new System.Drawing.Point(3, 0);
            this.Invoice.Name = "Invoice";
            this.Invoice.Size = new System.Drawing.Size(49, 13);
            this.Invoice.TabIndex = 3;
            this.Invoice.Text = "Invoice";
            // 
            // label_OrderNumber
            // 
            this.label_OrderNumber.AutoSize = true;
            this.label_OrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OrderNumber.Location = new System.Drawing.Point(3, 30);
            this.label_OrderNumber.Name = "label_OrderNumber";
            this.label_OrderNumber.Size = new System.Drawing.Size(115, 13);
            this.label_OrderNumber.TabIndex = 2;
            this.label_OrderNumber.Text = "label_OrderNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Details";
            // 
            // FormattedDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1168, 650);
            this.Controls.Add(this.pnlCustomerDetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_DocNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_DataStrings);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormattedDataDisplay";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.comboBox_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.label_3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox_ExternalRef, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.textBox_InternalRef, 0);
            this.Controls.SetChildIndex(this.button_Reset, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.textbox_DataStrings, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.pnlCustomerDetails, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlCustomerDetails.ResumeLayout(false);
            this.pnlCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qunatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
        protected System.Windows.Forms.DataGridView dataGridView2;
        protected System.Windows.Forms.RichTextBox textbox_DataStrings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DocNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlCustomerDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_OrderNumber;
        private System.Windows.Forms.Label Invoice;
        private System.Windows.Forms.Label label_CustomerNum;
        private System.Windows.Forms.Label label_SupplierName;
        private System.Windows.Forms.Label label_SupplierAddr;
        private System.Windows.Forms.Label label_SupplierAddress2;
        private System.Windows.Forms.Label label_SupplierPhone;
        private System.Windows.Forms.Label ShipFrom;
        private System.Windows.Forms.Label InvoiceDate;
        private System.Windows.Forms.Label label_OrderNum;
        private System.Windows.Forms.Label label_DateValue;
        private System.Windows.Forms.Label label_ShipName;
        private System.Windows.Forms.Label label_ShippingAddr2;
        private System.Windows.Forms.Label label_ShipAddress;
        private System.Windows.Forms.Label DeliveryMode;
        private System.Windows.Forms.Label UPS;
        private System.Windows.Forms.Label label_SupplierEmail;
    }
}
