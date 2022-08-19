
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    partial class FrmAddNewMiscellaneousIssue
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MatCmbItemCode = new MetroFramework.Controls.MetroComboBox();
            this.MatTxtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtLotNo = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtLotDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.MatBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.MatTxtCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtItemDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtExpiryDays = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatTxtReceivedDate = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtReceivingID = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MatCmbExpiryDate = new MetroFramework.Controls.MetroComboBox();
            this.MatTxtAvailableStock = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtTransactionType = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtQtyOut = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(816, 480);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 657;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 583;
            this.label3.Text = "Item Code";
            // 
            // MatCmbItemCode
            // 
            this.MatCmbItemCode.FormattingEnabled = true;
            this.MatCmbItemCode.ItemHeight = 23;
            this.MatCmbItemCode.Location = new System.Drawing.Point(27, 60);
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
            this.MatTxtQuantity.Enabled = false;
            this.MatTxtQuantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtQuantity.Hint = "Actual Quantity";
            this.MatTxtQuantity.Location = new System.Drawing.Point(367, 105);
            this.MatTxtQuantity.MaxLength = 50;
            this.MatTxtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtQuantity.Multiline = false;
            this.MatTxtQuantity.Name = "MatTxtQuantity";
            this.MatTxtQuantity.Size = new System.Drawing.Size(129, 50);
            this.MatTxtQuantity.TabIndex = 580;
            this.MatTxtQuantity.Text = "";
            this.MatTxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatTxtQuantity_KeyPress);
            // 
            // MatTxtLotNo
            // 
            this.MatTxtLotNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtLotNo.Depth = 0;
            this.MatTxtLotNo.Enabled = false;
            this.MatTxtLotNo.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtLotNo.Hint = "Lot No.";
            this.MatTxtLotNo.Location = new System.Drawing.Point(369, 168);
            this.MatTxtLotNo.MaxLength = 50;
            this.MatTxtLotNo.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtLotNo.Multiline = false;
            this.MatTxtLotNo.Name = "MatTxtLotNo";
            this.MatTxtLotNo.Size = new System.Drawing.Size(270, 50);
            this.MatTxtLotNo.TabIndex = 2;
            this.MatTxtLotNo.Text = "";
            // 
            // MatTxtLotDesc
            // 
            this.MatTxtLotDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtLotDesc.Depth = 0;
            this.MatTxtLotDesc.Enabled = false;
            this.MatTxtLotDesc.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtLotDesc.Hint = "Lot Description";
            this.MatTxtLotDesc.Location = new System.Drawing.Point(708, 168);
            this.MatTxtLotDesc.MaxLength = 50;
            this.MatTxtLotDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtLotDesc.Multiline = false;
            this.MatTxtLotDesc.Name = "MatTxtLotDesc";
            this.MatTxtLotDesc.Size = new System.Drawing.Size(270, 50);
            this.MatTxtLotDesc.TabIndex = 3;
            this.MatTxtLotDesc.Text = "";
            // 
            // MatBtnSave
            // 
            this.MatBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnSave.Depth = 0;
            this.MatBtnSave.DrawShadows = true;
            this.MatBtnSave.HighEmphasis = true;
            this.MatBtnSave.Icon = null;
            this.MatBtnSave.Location = new System.Drawing.Point(29, 454);
            this.MatBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnSave.Name = "MatBtnSave";
            this.MatBtnSave.Size = new System.Drawing.Size(58, 36);
            this.MatBtnSave.TabIndex = 656;
            this.MatBtnSave.Text = "Save";
            this.MatBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnSave.UseAccentColor = false;
            this.MatBtnSave.UseVisualStyleBackColor = true;
            this.MatBtnSave.Click += new System.EventHandler(this.MatBtnSave_Click);
            // 
            // MatTxtCategory
            // 
            this.MatTxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtCategory.Depth = 0;
            this.MatTxtCategory.Enabled = false;
            this.MatTxtCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtCategory.Hint = "Category";
            this.MatTxtCategory.Location = new System.Drawing.Point(705, 42);
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
            this.MatTxtItemDescription.Location = new System.Drawing.Point(366, 42);
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
            this.MatTxtExpiryDays.Location = new System.Drawing.Point(711, 234);
            this.MatTxtExpiryDays.MaxLength = 50;
            this.MatTxtExpiryDays.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtExpiryDays.Multiline = false;
            this.MatTxtExpiryDays.Name = "MatTxtExpiryDays";
            this.MatTxtExpiryDays.Size = new System.Drawing.Size(270, 50);
            this.MatTxtExpiryDays.TabIndex = 6;
            this.MatTxtExpiryDays.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(795, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 658;
            this.label5.Text = "TextBox for Two Way Binding";
            this.label5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.MatTxtQtyOut);
            this.groupBox1.Controls.Add(this.MatTxtReceivedDate);
            this.groupBox1.Controls.Add(this.MatTxtReceivingID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MatCmbExpiryDate);
            this.groupBox1.Controls.Add(this.MatTxtAvailableStock);
            this.groupBox1.Controls.Add(this.MatTxtTransactionType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MatTxtExpiryDays);
            this.groupBox1.Controls.Add(this.MatCmbItemCode);
            this.groupBox1.Controls.Add(this.MatTxtQuantity);
            this.groupBox1.Controls.Add(this.MatTxtLotNo);
            this.groupBox1.Controls.Add(this.MatTxtLotDesc);
            this.groupBox1.Controls.Add(this.MatTxtCategory);
            this.groupBox1.Controls.Add(this.MatTxtItemDescription);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 351);
            this.groupBox1.TabIndex = 655;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Material Information";
            // 
            // MatTxtReceivedDate
            // 
            this.MatTxtReceivedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtReceivedDate.Depth = 0;
            this.MatTxtReceivedDate.Enabled = false;
            this.MatTxtReceivedDate.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtReceivedDate.Hint = "Received Date";
            this.MatTxtReceivedDate.Location = new System.Drawing.Point(28, 234);
            this.MatTxtReceivedDate.MaxLength = 50;
            this.MatTxtReceivedDate.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtReceivedDate.Multiline = false;
            this.MatTxtReceivedDate.Name = "MatTxtReceivedDate";
            this.MatTxtReceivedDate.Size = new System.Drawing.Size(270, 50);
            this.MatTxtReceivedDate.TabIndex = 594;
            this.MatTxtReceivedDate.Text = "";
            // 
            // MatTxtReceivingID
            // 
            this.MatTxtReceivingID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtReceivingID.Depth = 0;
            this.MatTxtReceivingID.Enabled = false;
            this.MatTxtReceivingID.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtReceivingID.Hint = "Receiving ID";
            this.MatTxtReceivingID.Location = new System.Drawing.Point(369, 234);
            this.MatTxtReceivingID.MaxLength = 50;
            this.MatTxtReceivingID.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtReceivingID.Multiline = false;
            this.MatTxtReceivingID.Name = "MatTxtReceivingID";
            this.MatTxtReceivingID.Size = new System.Drawing.Size(270, 50);
            this.MatTxtReceivingID.TabIndex = 593;
            this.MatTxtReceivingID.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 592;
            this.label4.Text = "Expiry Date";
            // 
            // MatCmbExpiryDate
            // 
            this.MatCmbExpiryDate.FormattingEnabled = true;
            this.MatCmbExpiryDate.ItemHeight = 23;
            this.MatCmbExpiryDate.Location = new System.Drawing.Point(28, 124);
            this.MatCmbExpiryDate.Name = "MatCmbExpiryDate";
            this.MatCmbExpiryDate.Size = new System.Drawing.Size(270, 29);
            this.MatCmbExpiryDate.TabIndex = 591;
            this.MatCmbExpiryDate.UseSelectable = true;
            this.MatCmbExpiryDate.SelectionChangeCommitted += new System.EventHandler(this.MatCmbReceivingId_SelectionChangeCommitted);
            // 
            // MatTxtAvailableStock
            // 
            this.MatTxtAvailableStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtAvailableStock.Depth = 0;
            this.MatTxtAvailableStock.Enabled = false;
            this.MatTxtAvailableStock.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtAvailableStock.Hint = "Available Stock";
            this.MatTxtAvailableStock.Location = new System.Drawing.Point(708, 103);
            this.MatTxtAvailableStock.MaxLength = 50;
            this.MatTxtAvailableStock.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtAvailableStock.Multiline = false;
            this.MatTxtAvailableStock.Name = "MatTxtAvailableStock";
            this.MatTxtAvailableStock.Size = new System.Drawing.Size(270, 50);
            this.MatTxtAvailableStock.TabIndex = 585;
            this.MatTxtAvailableStock.Text = "";
            // 
            // MatTxtTransactionType
            // 
            this.MatTxtTransactionType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtTransactionType.Depth = 0;
            this.MatTxtTransactionType.Enabled = false;
            this.MatTxtTransactionType.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtTransactionType.Hint = "Transaction Type";
            this.MatTxtTransactionType.Location = new System.Drawing.Point(27, 168);
            this.MatTxtTransactionType.MaxLength = 50;
            this.MatTxtTransactionType.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtTransactionType.Multiline = false;
            this.MatTxtTransactionType.Name = "MatTxtTransactionType";
            this.MatTxtTransactionType.Size = new System.Drawing.Size(270, 50);
            this.MatTxtTransactionType.TabIndex = 584;
            this.MatTxtTransactionType.Text = "";
            // 
            // MatTxtQtyOut
            // 
            this.MatTxtQtyOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtQtyOut.Depth = 0;
            this.MatTxtQtyOut.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtQtyOut.Hint = "Quantity";
            this.MatTxtQtyOut.Location = new System.Drawing.Point(507, 105);
            this.MatTxtQtyOut.MaxLength = 50;
            this.MatTxtQtyOut.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtQtyOut.Multiline = false;
            this.MatTxtQtyOut.Name = "MatTxtQtyOut";
            this.MatTxtQtyOut.Size = new System.Drawing.Size(129, 50);
            this.MatTxtQtyOut.TabIndex = 595;
            this.MatTxtQtyOut.Text = "";
            this.MatTxtQtyOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatTxtQtyOut_KeyPress);
            // 
            // FrmAddNewMiscellaneousIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MatBtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewMiscellaneousIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNewMiscellaneousIssue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddNewMiscellaneousIssue_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddNewMiscellaneousIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox MatCmbItemCode;
        private MaterialSkin.Controls.MaterialTextBox MatTxtQuantity;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotNo;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotDesc;
        public MaterialSkin.Controls.MaterialButton MatBtnSave;
        private MaterialSkin.Controls.MaterialTextBox MatTxtCategory;
        private MaterialSkin.Controls.MaterialTextBox MatTxtItemDescription;
        private MaterialSkin.Controls.MaterialTextBox MatTxtExpiryDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox MatTxtAvailableStock;
        public MaterialSkin.Controls.MaterialTextBox MatTxtTransactionType;
        private System.Windows.Forms.Label label4;
        public MetroFramework.Controls.MetroComboBox MatCmbExpiryDate;
        public MaterialSkin.Controls.MaterialTextBox MatTxtReceivingID;
        public MaterialSkin.Controls.MaterialTextBox MatTxtReceivedDate;
        private MaterialSkin.Controls.MaterialTextBox MatTxtQtyOut;
    }
}