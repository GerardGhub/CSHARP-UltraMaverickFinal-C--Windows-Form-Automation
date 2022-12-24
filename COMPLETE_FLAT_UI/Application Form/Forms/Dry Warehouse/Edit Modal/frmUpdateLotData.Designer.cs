
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmUpdateLotData
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
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.matdescription = new MaterialSkin.Controls.MaterialTextBox();
            this.matlotnumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cboMajorCategory = new System.Windows.Forms.ComboBox();
            this.lblMajorCatId = new System.Windows.Forms.Label();
            this.mattotalsku = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matBtnSave
            // 
            this.matBtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(2, 3);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 479;
            this.matBtnSave.Text = "SAVE";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategory.Location = new System.Drawing.Point(344, 127);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 15);
            this.lblCategory.TabIndex = 593;
            this.lblCategory.Text = "Category:";
            // 
            // matdescription
            // 
            this.matdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matdescription.Depth = 0;
            this.matdescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.matdescription.Hint = "Lot Description";
            this.matdescription.Location = new System.Drawing.Point(345, 41);
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
            this.matlotnumber.Enabled = false;
            this.matlotnumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.matlotnumber.Hint = "Lot  Number";
            this.matlotnumber.Location = new System.Drawing.Point(35, 43);
            this.matlotnumber.Margin = new System.Windows.Forms.Padding(1);
            this.matlotnumber.MaxLength = 50;
            this.matlotnumber.MouseState = MaterialSkin.MouseState.OUT;
            this.matlotnumber.Multiline = false;
            this.matlotnumber.Name = "matlotnumber";
            this.matlotnumber.Size = new System.Drawing.Size(250, 50);
            this.matlotnumber.TabIndex = 0;
            this.matlotnumber.Text = "";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cboMajorCategory);
            this.materialCard1.Controls.Add(this.lblMajorCatId);
            this.materialCard1.Controls.Add(this.mattotalsku);
            this.materialCard1.Controls.Add(this.lblCategory);
            this.materialCard1.Controls.Add(this.matdescription);
            this.materialCard1.Controls.Add(this.matlotnumber);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 87);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(628, 253);
            this.materialCard1.TabIndex = 482;
            // 
            // cboMajorCategory
            // 
            this.cboMajorCategory.Enabled = false;
            this.cboMajorCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMajorCategory.FormattingEnabled = true;
            this.cboMajorCategory.Location = new System.Drawing.Point(345, 145);
            this.cboMajorCategory.Margin = new System.Windows.Forms.Padding(1);
            this.cboMajorCategory.Name = "cboMajorCategory";
            this.cboMajorCategory.Size = new System.Drawing.Size(250, 32);
            this.cboMajorCategory.TabIndex = 602;
            // 
            // lblMajorCatId
            // 
            this.lblMajorCatId.AutoSize = true;
            this.lblMajorCatId.BackColor = System.Drawing.Color.Transparent;
            this.lblMajorCatId.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajorCatId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMajorCatId.Location = new System.Drawing.Point(439, 126);
            this.lblMajorCatId.Name = "lblMajorCatId";
            this.lblMajorCatId.Size = new System.Drawing.Size(86, 13);
            this.lblMajorCatId.TabIndex = 599;
            this.lblMajorCatId.Text = "Major Category:";
            this.lblMajorCatId.Visible = false;
            // 
            // mattotalsku
            // 
            this.mattotalsku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattotalsku.Depth = 0;
            this.mattotalsku.Enabled = false;
            this.mattotalsku.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattotalsku.Hint = "Total SKU";
            this.mattotalsku.Location = new System.Drawing.Point(35, 130);
            this.mattotalsku.Margin = new System.Windows.Forms.Padding(1);
            this.mattotalsku.MaxLength = 50;
            this.mattotalsku.MouseState = MaterialSkin.MouseState.OUT;
            this.mattotalsku.Multiline = false;
            this.mattotalsku.Name = "mattotalsku";
            this.mattotalsku.Size = new System.Drawing.Size(250, 50);
            this.mattotalsku.TabIndex = 597;
            this.mattotalsku.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(152, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 481;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.BtnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.matBtnSave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(507, 349);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 47);
            this.tableLayoutPanel1.TabIndex = 483;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.DrawShadows = true;
            this.BtnCancel.HighEmphasis = true;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(64, 3);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(78, 36);
            this.BtnCancel.TabIndex = 480;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnCancel.UseAccentColor = false;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmUpdateLotData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 397);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateLotData";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Lot Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdateLotData_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdateLotData_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private System.Windows.Forms.Label lblCategory;
        private MaterialSkin.Controls.MaterialTextBox matdescription;
        private MaterialSkin.Controls.MaterialTextBox matlotnumber;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblMajorCatId;
        private MaterialSkin.Controls.MaterialTextBox mattotalsku;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboMajorCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton BtnCancel;
    }
}