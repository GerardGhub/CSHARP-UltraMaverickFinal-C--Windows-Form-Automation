
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmChooseLotNumber
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
            this.mattxtLotnumber = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvLotData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matbtnSelect = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotData)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mattxtLotnumber);
            this.materialCard1.Controls.Add(this.mattxtCategory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(37, 110);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard1.Size = new System.Drawing.Size(567, 97);
            this.materialCard1.TabIndex = 2;
            // 
            // mattxtLotnumber
            // 
            this.mattxtLotnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtLotnumber.Depth = 0;
            this.mattxtLotnumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtLotnumber.Hint = "Lot Number";
            this.mattxtLotnumber.Location = new System.Drawing.Point(417, 22);
            this.mattxtLotnumber.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtLotnumber.MaxLength = 50;
            this.mattxtLotnumber.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtLotnumber.Multiline = false;
            this.mattxtLotnumber.Name = "mattxtLotnumber";
            this.mattxtLotnumber.Size = new System.Drawing.Size(136, 50);
            this.mattxtLotnumber.TabIndex = 3;
            this.mattxtLotnumber.Text = "";
            this.mattxtLotnumber.TextChanged += new System.EventHandler(this.mattxtLotnumber_TextChanged);
            this.mattxtLotnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtLotnumber_KeyPress);
            // 
            // mattxtCategory
            // 
            this.mattxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtCategory.Depth = 0;
            this.mattxtCategory.Enabled = false;
            this.mattxtCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtCategory.Hint = "Major Category";
            this.mattxtCategory.Location = new System.Drawing.Point(23, 22);
            this.mattxtCategory.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtCategory.MaxLength = 50;
            this.mattxtCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtCategory.Multiline = false;
            this.mattxtCategory.Name = "mattxtCategory";
            this.mattxtCategory.Size = new System.Drawing.Size(380, 50);
            this.mattxtCategory.TabIndex = 2;
            this.mattxtCategory.Text = "Takla";
            this.mattxtCategory.TextChanged += new System.EventHandler(this.mattxtCategory_TextChanged);
            // 
            // dgvLotData
            // 
            this.dgvLotData.AllowUserToAddRows = false;
            this.dgvLotData.AllowUserToDeleteRows = false;
            this.dgvLotData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLotData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLotData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLotData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLotData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLotData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLotData.ColumnHeadersHeight = 55;
            this.dgvLotData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLotData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lot_number,
            this.description,
            this.category,
            this.added_by,
            this.date_added});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLotData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLotData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLotData.EnableHeadersVisualStyles = false;
            this.dgvLotData.GridColor = System.Drawing.SystemColors.Window;
            this.dgvLotData.Location = new System.Drawing.Point(7, 7);
            this.dgvLotData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLotData.MultiSelect = false;
            this.dgvLotData.Name = "dgvLotData";
            this.dgvLotData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLotData.RowHeadersVisible = false;
            this.dgvLotData.RowHeadersWidth = 102;
            this.dgvLotData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLotData.RowTemplate.DividerHeight = 5;
            this.dgvLotData.RowTemplate.Height = 40;
            this.dgvLotData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotData.Size = new System.Drawing.Size(553, 503);
            this.dgvLotData.TabIndex = 594;
            this.dgvLotData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvLotData.ThemeStyle.GridColor = System.Drawing.SystemColors.Window;
            this.dgvLotData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvLotData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvLotData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLotData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLotData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLotData.ThemeStyle.HeaderStyle.Height = 55;
            this.dgvLotData.ThemeStyle.ReadOnly = true;
            this.dgvLotData.ThemeStyle.RowsStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvLotData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvLotData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLotData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLotData.ThemeStyle.RowsStyle.Height = 40;
            this.dgvLotData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvLotData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvLotData.CurrentCellChanged += new System.EventHandler(this.dgvLotData_CurrentCellChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 40.60914F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 12;
            // 
            // lot_number
            // 
            this.lot_number.DataPropertyName = "lot_number";
            this.lot_number.FillWeight = 99.49239F;
            this.lot_number.HeaderText = "LOT NO.";
            this.lot_number.MinimumWidth = 12;
            this.lot_number.Name = "lot_number";
            this.lot_number.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 99.49239F;
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 12;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 99.49239F;
            this.category.HeaderText = "CATEGORY";
            this.category.MinimumWidth = 12;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // added_by
            // 
            this.added_by.DataPropertyName = "added_by";
            this.added_by.FillWeight = 99.49239F;
            this.added_by.HeaderText = "ADDED BY";
            this.added_by.MinimumWidth = 12;
            this.added_by.Name = "added_by";
            this.added_by.ReadOnly = true;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.MinimumWidth = 12;
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvLotData);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(37, 263);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard2.Size = new System.Drawing.Size(567, 517);
            this.materialCard2.TabIndex = 3;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(656, 794);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(62, 42);
            this.lbltotalrecords.TabIndex = 610;
            this.lbltotalrecords.Text = "76";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(660, 837);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 611;
            this.label2.Text = "Items";
            // 
            // matbtnSelect
            // 
            this.matbtnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnSelect.Depth = 0;
            this.matbtnSelect.DrawShadows = true;
            this.matbtnSelect.HighEmphasis = true;
            this.matbtnSelect.Icon = null;
            this.matbtnSelect.Location = new System.Drawing.Point(37, 818);
            this.matbtnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.matbtnSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnSelect.Name = "matbtnSelect";
            this.matbtnSelect.Size = new System.Drawing.Size(74, 36);
            this.matbtnSelect.TabIndex = 613;
            this.matbtnSelect.Text = "Select";
            this.matbtnSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnSelect.UseAccentColor = false;
            this.matbtnSelect.UseVisualStyleBackColor = true;
            this.matbtnSelect.Click += new System.EventHandler(this.matbtnSelect_Click);
            // 
            // frmChooseLotNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 898);
            this.Controls.Add(this.matbtnSelect);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChooseLotNumber";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Lot Number";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChooseLotNumber_FormClosed);
            this.Load += new System.EventHandler(this.frmChooseLotNumber_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotData)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox mattxtCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLotData;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox mattxtLotnumber;
        private MaterialSkin.Controls.MaterialButton matbtnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
    }
}