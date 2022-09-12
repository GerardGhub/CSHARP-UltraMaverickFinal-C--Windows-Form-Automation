
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmAddNewLotModal
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboMajorCategory = new MetroFramework.Controls.MetroComboBox();
            this.matdescription = new MaterialSkin.Controls.MaterialTextBox();
            this.matlotnumber = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblMajorCatId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mattotalsku = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(325, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 593;
            this.label2.Text = "Major Category:";
            // 
            // cboMajorCategory
            // 
            this.cboMajorCategory.FormattingEnabled = true;
            this.cboMajorCategory.ItemHeight = 23;
            this.cboMajorCategory.Location = new System.Drawing.Point(325, 164);
            this.cboMajorCategory.Margin = new System.Windows.Forms.Padding(1);
            this.cboMajorCategory.Name = "cboMajorCategory";
            this.cboMajorCategory.PromptText = "Major Category";
            this.cboMajorCategory.Size = new System.Drawing.Size(253, 29);
            this.cboMajorCategory.TabIndex = 577;
            this.cboMajorCategory.UseSelectable = true;
            this.cboMajorCategory.SelectionChangeCommitted += new System.EventHandler(this.cboMajorCategory_SelectionChangeCommitted);
            // 
            // matdescription
            // 
            this.matdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matdescription.Depth = 0;
            this.matdescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.matdescription.Hint = "Lot Description";
            this.matdescription.Location = new System.Drawing.Point(328, 48);
            this.matdescription.Margin = new System.Windows.Forms.Padding(1);
            this.matdescription.MaxLength = 50;
            this.matdescription.MouseState = MaterialSkin.MouseState.OUT;
            this.matdescription.Multiline = false;
            this.matdescription.Name = "matdescription";
            this.matdescription.Size = new System.Drawing.Size(250, 50);
            this.matdescription.TabIndex = 1;
            this.matdescription.Text = "";
            this.matdescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matdescription_KeyPress);
            // 
            // matlotnumber
            // 
            this.matlotnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matlotnumber.Depth = 0;
            this.matlotnumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.matlotnumber.Hint = "Lot  Number";
            this.matlotnumber.Location = new System.Drawing.Point(42, 48);
            this.matlotnumber.Margin = new System.Windows.Forms.Padding(1);
            this.matlotnumber.MaxLength = 50;
            this.matlotnumber.MouseState = MaterialSkin.MouseState.OUT;
            this.matlotnumber.Multiline = false;
            this.matlotnumber.Name = "matlotnumber";
            this.matlotnumber.Size = new System.Drawing.Size(250, 50);
            this.matlotnumber.TabIndex = 0;
            this.matlotnumber.Text = "";
            this.matlotnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matlotnumber_KeyPress);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(594, 345);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 479;
            this.matBtnSave.Text = "Save";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblMajorCatId);
            this.materialCard1.Controls.Add(this.mattotalsku);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.cboMajorCategory);
            this.materialCard1.Controls.Add(this.matdescription);
            this.materialCard1.Controls.Add(this.matlotnumber);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(24, 76);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(628, 253);
            this.materialCard1.TabIndex = 477;
            // 
            // lblMajorCatId
            // 
            this.lblMajorCatId.AutoSize = true;
            this.lblMajorCatId.BackColor = System.Drawing.Color.Transparent;
            this.lblMajorCatId.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajorCatId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMajorCatId.Location = new System.Drawing.Point(404, 131);
            this.lblMajorCatId.Name = "lblMajorCatId";
            this.lblMajorCatId.Size = new System.Drawing.Size(86, 13);
            this.lblMajorCatId.TabIndex = 599;
            this.lblMajorCatId.Text = "Major Category:";
            this.lblMajorCatId.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(398, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 476;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mattotalsku
            // 
            this.mattotalsku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattotalsku.Depth = 0;
            this.mattotalsku.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattotalsku.Hint = "Total SKU";
            this.mattotalsku.Location = new System.Drawing.Point(42, 143);
            this.mattotalsku.Margin = new System.Windows.Forms.Padding(1);
            this.mattotalsku.MaxLength = 50;
            this.mattotalsku.MouseState = MaterialSkin.MouseState.OUT;
            this.mattotalsku.Multiline = false;
            this.mattotalsku.Name = "mattotalsku";
            this.mattotalsku.Size = new System.Drawing.Size(250, 50);
            this.mattotalsku.TabIndex = 597;
            this.mattotalsku.Text = "";
            // 
            // frmAddNewLotModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 397);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewLotModal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Lot ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewLotModal_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNewLotModal_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cboMajorCategory;
        private MaterialSkin.Controls.MaterialTextBox matdescription;
        private MaterialSkin.Controls.MaterialTextBox matlotnumber;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox mattotalsku;
        private System.Windows.Forms.Label lblMajorCatId;
    }
}