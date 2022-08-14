
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    partial class FrmAddNewMiscellaneousReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewMiscellaneousReceipt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatTxtParentDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MatCmbItemCode = new MetroFramework.Controls.MetroComboBox();
            this.MatTxtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtSupplier = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MatDtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.MatDtpMFtgDate = new System.Windows.Forms.DateTimePicker();
            this.MatTxtCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtItemDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtExpiryDays = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtLotDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtLotNo = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtTransactNo = new MaterialSkin.Controls.MaterialTextBox();
            this.MatBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.MatCmbReason = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSelectLot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.btnSelectLot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MatCmbReason);
            this.groupBox1.Controls.Add(this.MatTxtParentDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MatCmbItemCode);
            this.groupBox1.Controls.Add(this.MatTxtQuantity);
            this.groupBox1.Controls.Add(this.MatTxtSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MatDtpExpDate);
            this.groupBox1.Controls.Add(this.MatDtpMFtgDate);
            this.groupBox1.Controls.Add(this.MatTxtCategory);
            this.groupBox1.Controls.Add(this.MatTxtItemDescription);
            this.groupBox1.Controls.Add(this.MatTxtExpiryDays);
            this.groupBox1.Controls.Add(this.MatTxtLotDesc);
            this.groupBox1.Controls.Add(this.MatTxtLotNo);
            this.groupBox1.Controls.Add(this.MatTxtTransactNo);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Material Information";
            // 
            // MatTxtParentDescription
            // 
            this.MatTxtParentDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtParentDescription.Depth = 0;
            this.MatTxtParentDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtParentDescription.Hint = "Description";
            this.MatTxtParentDescription.Location = new System.Drawing.Point(26, 36);
            this.MatTxtParentDescription.MaxLength = 50;
            this.MatTxtParentDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtParentDescription.Multiline = false;
            this.MatTxtParentDescription.Name = "MatTxtParentDescription";
            this.MatTxtParentDescription.Size = new System.Drawing.Size(947, 50);
            this.MatTxtParentDescription.TabIndex = 584;
            this.MatTxtParentDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 583;
            this.label3.Text = "Item Code";
            // 
            // MatCmbItemCode
            // 
            this.MatCmbItemCode.FormattingEnabled = true;
            this.MatCmbItemCode.ItemHeight = 23;
            this.MatCmbItemCode.Location = new System.Drawing.Point(26, 222);
            this.MatCmbItemCode.Name = "MatCmbItemCode";
            this.MatCmbItemCode.Size = new System.Drawing.Size(270, 29);
            this.MatCmbItemCode.TabIndex = 582;
            this.MatCmbItemCode.UseSelectable = true;
            this.MatCmbItemCode.SelectionChangeCommitted += new System.EventHandler(this.MatCmbItemCode_SelectionChangeCommitted);
            // 
            // MatTxtQuantity
            // 
            this.MatTxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtQuantity.Depth = 0;
            this.MatTxtQuantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtQuantity.Hint = "Quantity";
            this.MatTxtQuantity.Location = new System.Drawing.Point(365, 260);
            this.MatTxtQuantity.MaxLength = 50;
            this.MatTxtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtQuantity.Multiline = false;
            this.MatTxtQuantity.Name = "MatTxtQuantity";
            this.MatTxtQuantity.Size = new System.Drawing.Size(270, 50);
            this.MatTxtQuantity.TabIndex = 580;
            this.MatTxtQuantity.Text = "";
            this.MatTxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox6_KeyPress);
            // 
            // MatTxtSupplier
            // 
            this.MatTxtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtSupplier.Depth = 0;
            this.MatTxtSupplier.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtSupplier.Hint = "Supplier";
            this.MatTxtSupplier.Location = new System.Drawing.Point(26, 259);
            this.MatTxtSupplier.MaxLength = 50;
            this.MatTxtSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtSupplier.Multiline = false;
            this.MatTxtSupplier.Name = "MatTxtSupplier";
            this.MatTxtSupplier.Size = new System.Drawing.Size(270, 50);
            this.MatTxtSupplier.TabIndex = 579;
            this.MatTxtSupplier.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 578;
            this.label2.Text = "Exp. Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 577;
            this.label1.Text = "Mftg. Date";
            // 
            // MatDtpExpDate
            // 
            this.MatDtpExpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDtpExpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.MatDtpExpDate.CustomFormat = "yyyy-MM-dd";
            this.MatDtpExpDate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MatDtpExpDate.Location = new System.Drawing.Point(365, 166);
            this.MatDtpExpDate.Name = "MatDtpExpDate";
            this.MatDtpExpDate.Size = new System.Drawing.Size(270, 30);
            this.MatDtpExpDate.TabIndex = 576;
            this.MatDtpExpDate.ValueChanged += new System.EventHandler(this.MatDtpExpDate_ValueChanged);
            // 
            // MatDtpMFtgDate
            // 
            this.MatDtpMFtgDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDtpMFtgDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.MatDtpMFtgDate.CustomFormat = "yyyy-MM-dd";
            this.MatDtpMFtgDate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDtpMFtgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MatDtpMFtgDate.Location = new System.Drawing.Point(26, 166);
            this.MatDtpMFtgDate.MaxDate = new System.DateTime(2022, 8, 14, 0, 0, 0, 0);
            this.MatDtpMFtgDate.Name = "MatDtpMFtgDate";
            this.MatDtpMFtgDate.Size = new System.Drawing.Size(270, 30);
            this.MatDtpMFtgDate.TabIndex = 575;
            this.MatDtpMFtgDate.Value = new System.DateTime(2022, 8, 14, 0, 0, 0, 0);
            this.MatDtpMFtgDate.ValueChanged += new System.EventHandler(this.MatDtpMFtgDate_ValueChanged);
            // 
            // MatTxtCategory
            // 
            this.MatTxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtCategory.Depth = 0;
            this.MatTxtCategory.Enabled = false;
            this.MatTxtCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtCategory.Hint = "Category";
            this.MatTxtCategory.Location = new System.Drawing.Point(704, 204);
            this.MatTxtCategory.MaxLength = 50;
            this.MatTxtCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtCategory.Multiline = false;
            this.MatTxtCategory.Name = "MatTxtCategory";
            this.MatTxtCategory.Size = new System.Drawing.Size(270, 50);
            this.MatTxtCategory.TabIndex = 9;
            this.MatTxtCategory.Text = "";
            // 
            // MatTxtItemDescription
            // 
            this.MatTxtItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtItemDescription.Depth = 0;
            this.MatTxtItemDescription.Enabled = false;
            this.MatTxtItemDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtItemDescription.Hint = "Item Description";
            this.MatTxtItemDescription.Location = new System.Drawing.Point(365, 204);
            this.MatTxtItemDescription.MaxLength = 50;
            this.MatTxtItemDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtItemDescription.Multiline = false;
            this.MatTxtItemDescription.Name = "MatTxtItemDescription";
            this.MatTxtItemDescription.Size = new System.Drawing.Size(270, 50);
            this.MatTxtItemDescription.TabIndex = 8;
            this.MatTxtItemDescription.Text = "";
            // 
            // MatTxtExpiryDays
            // 
            this.MatTxtExpiryDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtExpiryDays.Depth = 0;
            this.MatTxtExpiryDays.Enabled = false;
            this.MatTxtExpiryDays.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtExpiryDays.Hint = "Expiry Days";
            this.MatTxtExpiryDays.Location = new System.Drawing.Point(704, 148);
            this.MatTxtExpiryDays.MaxLength = 50;
            this.MatTxtExpiryDays.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtExpiryDays.Multiline = false;
            this.MatTxtExpiryDays.Name = "MatTxtExpiryDays";
            this.MatTxtExpiryDays.Size = new System.Drawing.Size(270, 50);
            this.MatTxtExpiryDays.TabIndex = 6;
            this.MatTxtExpiryDays.Text = "";
            // 
            // MatTxtLotDesc
            // 
            this.MatTxtLotDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtLotDesc.Depth = 0;
            this.MatTxtLotDesc.Enabled = false;
            this.MatTxtLotDesc.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtLotDesc.Hint = "Lot Description";
            this.MatTxtLotDesc.Location = new System.Drawing.Point(704, 92);
            this.MatTxtLotDesc.MaxLength = 50;
            this.MatTxtLotDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtLotDesc.Multiline = false;
            this.MatTxtLotDesc.Name = "MatTxtLotDesc";
            this.MatTxtLotDesc.Size = new System.Drawing.Size(270, 50);
            this.MatTxtLotDesc.TabIndex = 3;
            this.MatTxtLotDesc.Text = "";
            // 
            // MatTxtLotNo
            // 
            this.MatTxtLotNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtLotNo.Depth = 0;
            this.MatTxtLotNo.Enabled = false;
            this.MatTxtLotNo.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtLotNo.Hint = "Lot No.";
            this.MatTxtLotNo.Location = new System.Drawing.Point(365, 92);
            this.MatTxtLotNo.MaxLength = 50;
            this.MatTxtLotNo.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtLotNo.Multiline = false;
            this.MatTxtLotNo.Name = "MatTxtLotNo";
            this.MatTxtLotNo.Size = new System.Drawing.Size(270, 50);
            this.MatTxtLotNo.TabIndex = 2;
            this.MatTxtLotNo.Text = "";
            // 
            // MatTxtTransactNo
            // 
            this.MatTxtTransactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtTransactNo.Depth = 0;
            this.MatTxtTransactNo.Enabled = false;
            this.MatTxtTransactNo.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtTransactNo.Hint = "Transaction No.";
            this.MatTxtTransactNo.Location = new System.Drawing.Point(26, 91);
            this.MatTxtTransactNo.MaxLength = 50;
            this.MatTxtTransactNo.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtTransactNo.Multiline = false;
            this.MatTxtTransactNo.Name = "MatTxtTransactNo";
            this.MatTxtTransactNo.Size = new System.Drawing.Size(270, 50);
            this.MatTxtTransactNo.TabIndex = 0;
            this.MatTxtTransactNo.Text = "";
            // 
            // MatBtnSave
            // 
            this.MatBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnSave.Depth = 0;
            this.MatBtnSave.DrawShadows = true;
            this.MatBtnSave.HighEmphasis = true;
            this.MatBtnSave.Icon = null;
            this.MatBtnSave.Location = new System.Drawing.Point(17, 439);
            this.MatBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnSave.Name = "MatBtnSave";
            this.MatBtnSave.Size = new System.Drawing.Size(58, 36);
            this.MatBtnSave.TabIndex = 3;
            this.MatBtnSave.Text = "Save";
            this.MatBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnSave.UseAccentColor = false;
            this.MatBtnSave.UseVisualStyleBackColor = true;
            this.MatBtnSave.Click += new System.EventHandler(this.MatBtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(705, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 586;
            this.label4.Text = "Reason";
            // 
            // MatCmbReason
            // 
            this.MatCmbReason.FormattingEnabled = true;
            this.MatCmbReason.ItemHeight = 23;
            this.MatCmbReason.Items.AddRange(new object[] {
            "Delivery",
            "Adjustment",
            "Production"});
            this.MatCmbReason.Location = new System.Drawing.Point(704, 279);
            this.MatCmbReason.Name = "MatCmbReason";
            this.MatCmbReason.Size = new System.Drawing.Size(270, 29);
            this.MatCmbReason.TabIndex = 585;
            this.MatCmbReason.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 654;
            this.label5.Text = "TextBox for Two Way Binding";
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(808, 459);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 653;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // btnSelectLot
            // 
            this.btnSelectLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectLot.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectLot.FlatAppearance.BorderSize = 0;
            this.btnSelectLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLot.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectLot.Image")));
            this.btnSelectLot.Location = new System.Drawing.Point(639, 101);
            this.btnSelectLot.Margin = new System.Windows.Forms.Padding(1);
            this.btnSelectLot.Name = "btnSelectLot";
            this.btnSelectLot.Size = new System.Drawing.Size(41, 37);
            this.btnSelectLot.TabIndex = 26;
            this.btnSelectLot.UseVisualStyleBackColor = false;
            this.btnSelectLot.Click += new System.EventHandler(this.btnSelectLot_Click);
            // 
            // FrmAddNewMiscellaneousReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MatBtnSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewMiscellaneousReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Receipt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddNewMiscellaneousReceipt_FormClosing);
            this.Load += new System.EventHandler(this.AddNewMiscellaneousReceipt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox MatCmbItemCode;
        private MaterialSkin.Controls.MaterialTextBox MatTxtQuantity;
        private MaterialSkin.Controls.MaterialTextBox MatTxtSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker MatDtpExpDate;
        private System.Windows.Forms.DateTimePicker MatDtpMFtgDate;
        private MaterialSkin.Controls.MaterialTextBox MatTxtCategory;
        private MaterialSkin.Controls.MaterialTextBox MatTxtItemDescription;
        private MaterialSkin.Controls.MaterialTextBox MatTxtExpiryDays;
        private MaterialSkin.Controls.MaterialTextBox MatTxtTransactNo;
        private MaterialSkin.Controls.MaterialTextBox MatTxtParentDescription;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox MatCmbReason;
        private System.Windows.Forms.Button btnSelectLot;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox1;
        public MaterialSkin.Controls.MaterialButton MatBtnSave;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotDesc;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotNo;
    }
}