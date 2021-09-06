
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmEditItemModal
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
            this.txtcreatedAt = new System.Windows.Forms.TextBox();
            this.lblPrimaryUnitID = new System.Windows.Forms.Label();
            this.lblItemTypeID = new System.Windows.Forms.Label();
            this.lblIDSubCat = new System.Windows.Forms.Label();
            this.lblMajorCatId = new System.Windows.Forms.Label();
            this.lblItemClassID = new System.Windows.Forms.Label();
            this.txtmatConversion = new MaterialSkin.Controls.MaterialTextBox();
            this.cboPrimaryUnit = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.cboItemType = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMajorCategory = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItemClass = new MetroFramework.Controls.MetroComboBox();
            this.txtMatItemDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMatItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.txtcreatedBy = new System.Windows.Forms.TextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboSubCat = new System.Windows.Forms.ComboBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcreatedAt
            // 
            this.txtcreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcreatedAt.Enabled = false;
            this.txtcreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcreatedAt.Location = new System.Drawing.Point(553, 917);
            this.txtcreatedAt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcreatedAt.Name = "txtcreatedAt";
            this.txtcreatedAt.Size = new System.Drawing.Size(383, 39);
            this.txtcreatedAt.TabIndex = 480;
            this.txtcreatedAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcreatedAt.Visible = false;
            // 
            // lblPrimaryUnitID
            // 
            this.lblPrimaryUnitID.AutoSize = true;
            this.lblPrimaryUnitID.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimaryUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryUnitID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrimaryUnitID.Location = new System.Drawing.Point(305, 382);
            this.lblPrimaryUnitID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPrimaryUnitID.Name = "lblPrimaryUnitID";
            this.lblPrimaryUnitID.Size = new System.Drawing.Size(178, 32);
            this.lblPrimaryUnitID.TabIndex = 591;
            this.lblPrimaryUnitID.Text = "Primary Unit:";
            this.lblPrimaryUnitID.Visible = false;
            // 
            // lblItemTypeID
            // 
            this.lblItemTypeID.AutoSize = true;
            this.lblItemTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblItemTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTypeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemTypeID.Location = new System.Drawing.Point(1582, 221);
            this.lblItemTypeID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblItemTypeID.Name = "lblItemTypeID";
            this.lblItemTypeID.Size = new System.Drawing.Size(147, 32);
            this.lblItemTypeID.TabIndex = 590;
            this.lblItemTypeID.Text = "Item Type:";
            this.lblItemTypeID.Visible = false;
            // 
            // lblIDSubCat
            // 
            this.lblIDSubCat.AutoSize = true;
            this.lblIDSubCat.BackColor = System.Drawing.Color.Transparent;
            this.lblIDSubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSubCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIDSubCat.Location = new System.Drawing.Point(940, 221);
            this.lblIDSubCat.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblIDSubCat.Name = "lblIDSubCat";
            this.lblIDSubCat.Size = new System.Drawing.Size(196, 32);
            this.lblIDSubCat.TabIndex = 589;
            this.lblIDSubCat.Text = "Sub Category:";
            this.lblIDSubCat.Visible = false;
            // 
            // lblMajorCatId
            // 
            this.lblMajorCatId.AutoSize = true;
            this.lblMajorCatId.BackColor = System.Drawing.Color.Transparent;
            this.lblMajorCatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajorCatId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMajorCatId.Location = new System.Drawing.Point(320, 221);
            this.lblMajorCatId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMajorCatId.Name = "lblMajorCatId";
            this.lblMajorCatId.Size = new System.Drawing.Size(216, 32);
            this.lblMajorCatId.TabIndex = 588;
            this.lblMajorCatId.Text = "Major Category:";
            this.lblMajorCatId.Visible = false;
            // 
            // lblItemClassID
            // 
            this.lblItemClassID.AutoSize = true;
            this.lblItemClassID.BackColor = System.Drawing.Color.Transparent;
            this.lblItemClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemClassID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemClassID.Location = new System.Drawing.Point(1534, 71);
            this.lblItemClassID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblItemClassID.Name = "lblItemClassID";
            this.lblItemClassID.Size = new System.Drawing.Size(155, 32);
            this.lblItemClassID.TabIndex = 587;
            this.lblItemClassID.Text = "Item Class:";
            this.lblItemClassID.Visible = false;
            // 
            // txtmatConversion
            // 
            this.txtmatConversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatConversion.Depth = 0;
            this.txtmatConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmatConversion.Hint = "Conversion";
            this.txtmatConversion.Location = new System.Drawing.Point(693, 371);
            this.txtmatConversion.MaxLength = 50;
            this.txtmatConversion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatConversion.Multiline = false;
            this.txtmatConversion.Name = "txtmatConversion";
            this.txtmatConversion.Size = new System.Drawing.Size(414, 50);
            this.txtmatConversion.TabIndex = 586;
            this.txtmatConversion.Text = "";
            // 
            // cboPrimaryUnit
            // 
            this.cboPrimaryUnit.FormattingEnabled = true;
            this.cboPrimaryUnit.ItemHeight = 24;
            this.cboPrimaryUnit.Location = new System.Drawing.Point(59, 424);
            this.cboPrimaryUnit.Name = "cboPrimaryUnit";
            this.cboPrimaryUnit.Size = new System.Drawing.Size(419, 30);
            this.cboPrimaryUnit.TabIndex = 585;
            this.cboPrimaryUnit.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(58, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 32);
            this.label4.TabIndex = 584;
            this.label4.Text = "Primary Unit:";
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(85, 828);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 479;
            this.matBtnSave.Text = "Save";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            // 
            // cboItemType
            // 
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.ItemHeight = 24;
            this.cboItemType.Location = new System.Drawing.Point(1338, 256);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(414, 30);
            this.cboItemType.TabIndex = 583;
            this.cboItemType.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1332, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 582;
            this.label3.Text = "Item Type:";
            // 
            // cboMajorCategory
            // 
            this.cboMajorCategory.FormattingEnabled = true;
            this.cboMajorCategory.ItemHeight = 24;
            this.cboMajorCategory.Location = new System.Drawing.Point(64, 258);
            this.cboMajorCategory.Name = "cboMajorCategory";
            this.cboMajorCategory.Size = new System.Drawing.Size(419, 30);
            this.cboMajorCategory.TabIndex = 579;
            this.cboMajorCategory.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(63, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 578;
            this.label1.Text = "Major Category:";
            // 
            // cboItemClass
            // 
            this.cboItemClass.FormattingEnabled = true;
            this.cboItemClass.ItemHeight = 24;
            this.cboItemClass.Location = new System.Drawing.Point(1338, 108);
            this.cboItemClass.Name = "cboItemClass";
            this.cboItemClass.Size = new System.Drawing.Size(414, 30);
            this.cboItemClass.TabIndex = 577;
            this.cboItemClass.UseSelectable = true;
            // 
            // txtMatItemDesc
            // 
            this.txtMatItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatItemDesc.Depth = 0;
            this.txtMatItemDesc.Enabled = false;
            this.txtMatItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatItemDesc.Hint = "Item Description";
            this.txtMatItemDesc.Location = new System.Drawing.Point(693, 68);
            this.txtMatItemDesc.MaxLength = 50;
            this.txtMatItemDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatItemDesc.Multiline = false;
            this.txtMatItemDesc.Name = "txtMatItemDesc";
            this.txtMatItemDesc.Size = new System.Drawing.Size(414, 50);
            this.txtMatItemDesc.TabIndex = 1;
            this.txtMatItemDesc.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(1337, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 32);
            this.label13.TabIndex = 576;
            this.label13.Text = "Item Class:";
            // 
            // txtMatItemCode
            // 
            this.txtMatItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatItemCode.Depth = 0;
            this.txtMatItemCode.Enabled = false;
            this.txtMatItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatItemCode.Hint = "Item Code";
            this.txtMatItemCode.Location = new System.Drawing.Point(69, 68);
            this.txtMatItemCode.MaxLength = 50;
            this.txtMatItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatItemCode.Multiline = false;
            this.txtMatItemCode.Name = "txtMatItemCode";
            this.txtMatItemCode.Size = new System.Drawing.Size(414, 50);
            this.txtMatItemCode.TabIndex = 0;
            this.txtMatItemCode.Text = "";
            // 
            // txtcreatedBy
            // 
            this.txtcreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcreatedBy.Enabled = false;
            this.txtcreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcreatedBy.Location = new System.Drawing.Point(85, 917);
            this.txtcreatedBy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcreatedBy.Name = "txtcreatedBy";
            this.txtcreatedBy.Size = new System.Drawing.Size(383, 39);
            this.txtcreatedBy.TabIndex = 478;
            this.txtcreatedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcreatedBy.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cboSubCat);
            this.materialCard1.Controls.Add(this.lblPrimaryUnitID);
            this.materialCard1.Controls.Add(this.lblItemTypeID);
            this.materialCard1.Controls.Add(this.lblIDSubCat);
            this.materialCard1.Controls.Add(this.lblMajorCatId);
            this.materialCard1.Controls.Add(this.lblItemClassID);
            this.materialCard1.Controls.Add(this.txtmatConversion);
            this.materialCard1.Controls.Add(this.cboPrimaryUnit);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.cboItemType);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.cboMajorCategory);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.cboItemClass);
            this.materialCard1.Controls.Add(this.txtMatItemDesc);
            this.materialCard1.Controls.Add(this.label13);
            this.materialCard1.Controls.Add(this.txtMatItemCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(53, 165);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1810, 624);
            this.materialCard1.TabIndex = 477;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1399, 945);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 39);
            this.textBox1.TabIndex = 476;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboSubCat
            // 
            this.cboSubCat.FormattingEnabled = true;
            this.cboSubCat.Location = new System.Drawing.Point(693, 247);
            this.cboSubCat.Name = "cboSubCat";
            this.cboSubCat.Size = new System.Drawing.Size(414, 39);
            this.cboSubCat.TabIndex = 592;
            // 
            // frmEditItemModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1934, 1035);
            this.Controls.Add(this.txtcreatedAt);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.txtcreatedBy);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmEditItemModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Raw Materials";
            this.Load += new System.EventHandler(this.frmEditItemModal_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcreatedAt;
        private System.Windows.Forms.Label lblPrimaryUnitID;
        private System.Windows.Forms.Label lblItemTypeID;
        private System.Windows.Forms.Label lblIDSubCat;
        private System.Windows.Forms.Label lblMajorCatId;
        private System.Windows.Forms.Label lblItemClassID;
        private MaterialSkin.Controls.MaterialTextBox txtmatConversion;
        private MetroFramework.Controls.MetroComboBox cboPrimaryUnit;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MetroFramework.Controls.MetroComboBox cboItemType;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cboMajorCategory;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cboItemClass;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemDesc;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemCode;
        private System.Windows.Forms.TextBox txtcreatedBy;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboSubCat;
    }
}