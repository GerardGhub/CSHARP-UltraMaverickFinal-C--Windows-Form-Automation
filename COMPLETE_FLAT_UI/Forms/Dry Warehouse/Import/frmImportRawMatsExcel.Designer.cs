
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    partial class frmImportRawMatsExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvRawMats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primary_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matBtnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.txtFileName = new MaterialSkin.Controls.MaterialTextBox();
            this.cbosheet = new MetroFramework.Controls.MetroComboBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvRawMats);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(58, 157);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(2664, 861);
            this.materialCard1.TabIndex = 0;
            // 
            // dgvRawMats
            // 
            this.dgvRawMats.AllowUserToAddRows = false;
            this.dgvRawMats.AllowUserToDeleteRows = false;
            this.dgvRawMats.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRawMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRawMats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRawMats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRawMats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRawMats.ColumnHeadersHeight = 40;
            this.dgvRawMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_id,
            this.Column2,
            this.item_code,
            this.Item_description,
            this.item_class,
            this.major_category,
            this.sub_category,
            this.primary_unit,
            this.conversion,
            this.item_type,
            this.created_at,
            this.created_by,
            this.updated_at,
            this.updated_by});
            this.dgvRawMats.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMats.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRawMats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMats.EnableHeadersVisualStyles = false;
            this.dgvRawMats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.Location = new System.Drawing.Point(14, 14);
            this.dgvRawMats.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvRawMats.MultiSelect = false;
            this.dgvRawMats.Name = "dgvRawMats";
            this.dgvRawMats.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRawMats.RowHeadersVisible = false;
            this.dgvRawMats.RowHeadersWidth = 102;
            this.dgvRawMats.RowTemplate.DividerHeight = 5;
            this.dgvRawMats.RowTemplate.Height = 40;
            this.dgvRawMats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMats.Size = new System.Drawing.Size(2636, 833);
            this.dgvRawMats.TabIndex = 5;
            this.dgvRawMats.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvRawMats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvRawMats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.ReadOnly = true;
            this.dgvRawMats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRawMats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRawMats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // item_id
            // 
            this.item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.item_id.DataPropertyName = "item_id";
            this.item_id.FillWeight = 40.60914F;
            this.item_id.HeaderText = "Item ID";
            this.item_id.MinimumWidth = 12;
            this.item_id.Name = "item_id";
            this.item_id.ReadOnly = true;
            this.item_id.Width = 12;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 162.4365F;
            this.Column2.HeaderText = "";
            this.Column2.Image = global::ULTRAMAVERICK.Properties.Resources.ULTRA_MAVERICK;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "Item Code";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 192;
            // 
            // Item_description
            // 
            this.Item_description.DataPropertyName = "Item_description";
            this.Item_description.FillWeight = 99.49239F;
            this.Item_description.HeaderText = "Item Description";
            this.Item_description.MinimumWidth = 12;
            this.Item_description.Name = "Item_description";
            this.Item_description.ReadOnly = true;
            this.Item_description.Width = 264;
            // 
            // item_class
            // 
            this.item_class.DataPropertyName = "item_class";
            this.item_class.FillWeight = 99.49239F;
            this.item_class.HeaderText = "Item Class";
            this.item_class.MinimumWidth = 12;
            this.item_class.Name = "item_class";
            this.item_class.ReadOnly = true;
            this.item_class.Width = 189;
            // 
            // major_category
            // 
            this.major_category.DataPropertyName = "major_category";
            this.major_category.FillWeight = 99.49239F;
            this.major_category.HeaderText = "Major Category";
            this.major_category.MinimumWidth = 12;
            this.major_category.Name = "major_category";
            this.major_category.ReadOnly = true;
            this.major_category.Width = 254;
            // 
            // sub_category
            // 
            this.sub_category.DataPropertyName = "sub_category";
            this.sub_category.FillWeight = 99.49239F;
            this.sub_category.HeaderText = "Sub Category";
            this.sub_category.MinimumWidth = 12;
            this.sub_category.Name = "sub_category";
            this.sub_category.ReadOnly = true;
            this.sub_category.Width = 229;
            // 
            // primary_unit
            // 
            this.primary_unit.DataPropertyName = "primary_unit";
            this.primary_unit.FillWeight = 99.49239F;
            this.primary_unit.HeaderText = "Primary Unit";
            this.primary_unit.MinimumWidth = 12;
            this.primary_unit.Name = "primary_unit";
            this.primary_unit.ReadOnly = true;
            this.primary_unit.Width = 216;
            // 
            // conversion
            // 
            this.conversion.DataPropertyName = "conversion";
            this.conversion.FillWeight = 99.49239F;
            this.conversion.HeaderText = "Conversion";
            this.conversion.MinimumWidth = 12;
            this.conversion.Name = "conversion";
            this.conversion.ReadOnly = true;
            this.conversion.Width = 202;
            // 
            // item_type
            // 
            this.item_type.DataPropertyName = "item_type";
            this.item_type.HeaderText = "Item Type";
            this.item_type.MinimumWidth = 12;
            this.item_type.Name = "item_type";
            this.item_type.ReadOnly = true;
            this.item_type.Width = 185;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Created Date";
            this.created_at.MinimumWidth = 12;
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Width = 225;
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.HeaderText = "Created By";
            this.created_by.MinimumWidth = 12;
            this.created_by.Name = "created_by";
            this.created_by.ReadOnly = true;
            this.created_by.Width = 197;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Updated Date";
            this.updated_at.MinimumWidth = 12;
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Width = 236;
            // 
            // updated_by
            // 
            this.updated_by.DataPropertyName = "updated_by";
            this.updated_by.HeaderText = "Updated By";
            this.updated_by.MinimumWidth = 12;
            this.updated_by.Name = "updated_by";
            this.updated_by.ReadOnly = true;
            this.updated_by.Width = 208;
            // 
            // matBtnBrowse
            // 
            this.matBtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matBtnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnBrowse.Depth = 0;
            this.matBtnBrowse.DrawShadows = true;
            this.matBtnBrowse.HighEmphasis = true;
            this.matBtnBrowse.Icon = null;
            this.matBtnBrowse.Location = new System.Drawing.Point(2628, 1327);
            this.matBtnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnBrowse.Name = "matBtnBrowse";
            this.matBtnBrowse.Size = new System.Drawing.Size(80, 36);
            this.matBtnBrowse.TabIndex = 1;
            this.matBtnBrowse.Text = "BROWSE";
            this.matBtnBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnBrowse.UseAccentColor = false;
            this.matBtnBrowse.UseVisualStyleBackColor = true;
            this.matBtnBrowse.Click += new System.EventHandler(this.matBtnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Depth = 0;
            this.txtFileName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFileName.Hint = "File Name";
            this.txtFileName.Location = new System.Drawing.Point(1730, 1308);
            this.txtFileName.MaxLength = 50;
            this.txtFileName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFileName.Multiline = false;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(466, 50);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.Text = "";
            // 
            // cbosheet
            // 
            this.cbosheet.FormattingEnabled = true;
            this.cbosheet.ItemHeight = 24;
            this.cbosheet.Location = new System.Drawing.Point(1367, 1249);
            this.cbosheet.Name = "cbosheet";
            this.cbosheet.Size = new System.Drawing.Size(121, 30);
            this.cbosheet.TabIndex = 3;
            this.cbosheet.UseSelectable = true;
            // 
            // frmImportRawMatsExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2796, 1432);
            this.Controls.Add(this.cbosheet);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.matBtnBrowse);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmImportRawMatsExcel";
            this.Text = "Import Raw Material";
            this.Load += new System.EventHandler(this.frmImportRawMatsExcel_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRawMats;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn primary_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private MaterialSkin.Controls.MaterialButton matBtnBrowse;
        private MaterialSkin.Controls.MaterialTextBox txtFileName;
        private MetroFramework.Controls.MetroComboBox cbosheet;
    }
}