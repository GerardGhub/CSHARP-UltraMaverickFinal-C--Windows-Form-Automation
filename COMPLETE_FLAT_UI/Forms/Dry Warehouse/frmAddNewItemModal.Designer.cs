
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmAddNewItemModal
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtcreatedBy = new System.Windows.Forms.TextBox();
            this.txtMatItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatItemDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.cboItemClass = new MetroFramework.Controls.MetroComboBox();
            this.cboMajorCategory = new MetroFramework.Controls.MetroComboBox();
            this.cboSubCat = new MetroFramework.Controls.MetroComboBox();
            this.cboItemType = new MetroFramework.Controls.MetroComboBox();
            this.cboPrimaryUnit = new MetroFramework.Controls.MetroComboBox();
            this.txtmatConversion = new MaterialSkin.Controls.MaterialTextBox();
            this.lblItemClassID = new System.Windows.Forms.Label();
            this.lblMajorCatId = new System.Windows.Forms.Label();
            this.lblIDSubCat = new System.Windows.Forms.Label();
            this.lblItemTypeID = new System.Windows.Forms.Label();
            this.lblPrimaryUnitID = new System.Windows.Forms.Label();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtcreatedAt = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1409, 973);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 39);
            this.textBox1.TabIndex = 471;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblPrimaryUnitID);
            this.materialCard1.Controls.Add(this.lblItemTypeID);
            this.materialCard1.Controls.Add(this.lblIDSubCat);
            this.materialCard1.Controls.Add(this.lblMajorCatId);
            this.materialCard1.Controls.Add(this.lblItemClassID);
            this.materialCard1.Controls.Add(this.txtmatConversion);
            this.materialCard1.Controls.Add(this.cboPrimaryUnit);
            this.materialCard1.Controls.Add(this.cboItemType);
            this.materialCard1.Controls.Add(this.cboSubCat);
            this.materialCard1.Controls.Add(this.cboMajorCategory);
            this.materialCard1.Controls.Add(this.cboItemClass);
            this.materialCard1.Controls.Add(this.txtMatItemDesc);
            this.materialCard1.Controls.Add(this.txtMatItemCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(63, 193);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1810, 624);
            this.materialCard1.TabIndex = 472;
            // 
            // txtcreatedBy
            // 
            this.txtcreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcreatedBy.Enabled = false;
            this.txtcreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcreatedBy.Location = new System.Drawing.Point(95, 945);
            this.txtcreatedBy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcreatedBy.Name = "txtcreatedBy";
            this.txtcreatedBy.Size = new System.Drawing.Size(383, 39);
            this.txtcreatedBy.TabIndex = 473;
            this.txtcreatedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcreatedBy.Visible = false;
            // 
            // txtMatItemCode
            // 
            this.txtMatItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatItemCode.Depth = 0;
            this.txtMatItemCode.Font = new System.Drawing.Font("Roboto", 12F);
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
            // txtMatItemDesc
            // 
            this.txtMatItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatItemDesc.Depth = 0;
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
            // cboItemClass
            // 
            this.cboItemClass.FormattingEnabled = true;
            this.cboItemClass.ItemHeight = 24;
            this.cboItemClass.Location = new System.Drawing.Point(1338, 108);
            this.cboItemClass.Name = "cboItemClass";
            this.cboItemClass.PromptText = "Item Class";
            this.cboItemClass.Size = new System.Drawing.Size(414, 30);
            this.cboItemClass.TabIndex = 577;
            this.cboItemClass.UseSelectable = true;
            this.cboItemClass.SelectionChangeCommitted += new System.EventHandler(this.cboItemClass_SelectionChangeCommitted);
            // 
            // cboMajorCategory
            // 
            this.cboMajorCategory.FormattingEnabled = true;
            this.cboMajorCategory.ItemHeight = 24;
            this.cboMajorCategory.Location = new System.Drawing.Point(64, 258);
            this.cboMajorCategory.Name = "cboMajorCategory";
            this.cboMajorCategory.PromptText = "Major Category";
            this.cboMajorCategory.Size = new System.Drawing.Size(419, 30);
            this.cboMajorCategory.TabIndex = 579;
            this.cboMajorCategory.UseSelectable = true;
            this.cboMajorCategory.SelectionChangeCommitted += new System.EventHandler(this.cboMajorCategory_SelectionChangeCommitted);
            // 
            // cboSubCat
            // 
            this.cboSubCat.FormattingEnabled = true;
            this.cboSubCat.ItemHeight = 24;
            this.cboSubCat.Location = new System.Drawing.Point(693, 256);
            this.cboSubCat.Name = "cboSubCat";
            this.cboSubCat.PromptText = "Sub Category";
            this.cboSubCat.Size = new System.Drawing.Size(414, 30);
            this.cboSubCat.TabIndex = 581;
            this.cboSubCat.UseSelectable = true;
            this.cboSubCat.SelectionChangeCommitted += new System.EventHandler(this.cboSubCat_SelectionChangeCommitted);
            // 
            // cboItemType
            // 
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.ItemHeight = 24;
            this.cboItemType.Location = new System.Drawing.Point(1338, 256);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.PromptText = "Item Type";
            this.cboItemType.Size = new System.Drawing.Size(414, 30);
            this.cboItemType.TabIndex = 583;
            this.cboItemType.UseSelectable = true;
            this.cboItemType.SelectionChangeCommitted += new System.EventHandler(this.cboItemType_SelectionChangeCommitted);
            // 
            // cboPrimaryUnit
            // 
            this.cboPrimaryUnit.FormattingEnabled = true;
            this.cboPrimaryUnit.ItemHeight = 24;
            this.cboPrimaryUnit.Location = new System.Drawing.Point(59, 424);
            this.cboPrimaryUnit.Name = "cboPrimaryUnit";
            this.cboPrimaryUnit.PromptText = "Primary Unit";
            this.cboPrimaryUnit.Size = new System.Drawing.Size(419, 30);
            this.cboPrimaryUnit.TabIndex = 585;
            this.cboPrimaryUnit.UseSelectable = true;
            this.cboPrimaryUnit.SelectionChangeCommitted += new System.EventHandler(this.cboPrimaryUnit_SelectionChangeCommitted);
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
            this.txtmatConversion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatConversion_KeyPress);
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
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(95, 856);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 474;
            this.matBtnSave.Text = "Save";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // txtcreatedAt
            // 
            this.txtcreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcreatedAt.Enabled = false;
            this.txtcreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcreatedAt.Location = new System.Drawing.Point(563, 945);
            this.txtcreatedAt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcreatedAt.Name = "txtcreatedAt";
            this.txtcreatedAt.Size = new System.Drawing.Size(383, 39);
            this.txtcreatedAt.TabIndex = 475;
            this.txtcreatedAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcreatedAt.Visible = false;
            // 
            // frmAddNewItemModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1944, 1055);
            this.Controls.Add(this.txtcreatedAt);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.txtcreatedBy);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmAddNewItemModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Raw Material";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewItemModal_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNewItemModal_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox txtcreatedBy;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemDesc;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemCode;
        private MetroFramework.Controls.MetroComboBox cboItemClass;
        private MetroFramework.Controls.MetroComboBox cboMajorCategory;
        private MetroFramework.Controls.MetroComboBox cboSubCat;
        private MetroFramework.Controls.MetroComboBox cboItemType;
        private MetroFramework.Controls.MetroComboBox cboPrimaryUnit;
        private MaterialSkin.Controls.MaterialTextBox txtmatConversion;
        private System.Windows.Forms.Label lblItemClassID;
        private System.Windows.Forms.Label lblMajorCatId;
        private System.Windows.Forms.Label lblIDSubCat;
        private System.Windows.Forms.Label lblItemTypeID;
        private System.Windows.Forms.Label lblPrimaryUnitID;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private System.Windows.Forms.TextBox txtcreatedAt;
    }
}