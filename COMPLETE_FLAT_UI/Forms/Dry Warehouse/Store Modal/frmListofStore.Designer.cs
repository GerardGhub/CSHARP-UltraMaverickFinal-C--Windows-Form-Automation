
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmListofStore
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
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvSubCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stored_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modified_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modified_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(12, 558);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(46, 40);
            this.lbltotaldata.TabIndex = 637;
            this.lbltotaldata.Text = "76";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(57, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 638;
            this.label4.Text = "Items";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvSubCategory);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 82);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(996, 470);
            this.materialCard2.TabIndex = 636;
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AllowUserToAddRows = false;
            this.dgvSubCategory.AllowUserToDeleteRows = false;
            this.dgvSubCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubCategory.ColumnHeadersHeight = 35;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stored_id,
            this.store_code,
            this.store_name,
            this.store_area,
            this.store_route,
            this.date_added,
            this.added_by,
            this.modified_date,
            this.modified_by});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategory.EnableHeadersVisualStyles = false;
            this.dgvSubCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSubCategory.Location = new System.Drawing.Point(5, 6);
            this.dgvSubCategory.MultiSelect = false;
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubCategory.RowHeadersVisible = false;
            this.dgvSubCategory.RowHeadersWidth = 102;
            this.dgvSubCategory.RowTemplate.DividerHeight = 5;
            this.dgvSubCategory.RowTemplate.Height = 40;
            this.dgvSubCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubCategory.Size = new System.Drawing.Size(986, 458);
            this.dgvSubCategory.TabIndex = 593;
            this.dgvSubCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSubCategory.ThemeStyle.ReadOnly = true;
            this.dgvSubCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSubCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubCategory.ThemeStyle.RowsStyle.Height = 40;
            this.dgvSubCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSubCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(1393, 333);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(51, 36);
            this.lbltotalrecords.TabIndex = 634;
            this.lbltotalrecords.Text = "76";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(1438, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 635;
            this.label2.Text = "Items";
            // 
            // stored_id
            // 
            this.stored_id.DataPropertyName = "stored_id";
            this.stored_id.FillWeight = 40.60914F;
            this.stored_id.HeaderText = "STORE ID";
            this.stored_id.MinimumWidth = 12;
            this.stored_id.Name = "stored_id";
            this.stored_id.ReadOnly = true;
            this.stored_id.Width = 98;
            // 
            // store_code
            // 
            this.store_code.DataPropertyName = "store_code";
            this.store_code.FillWeight = 99.49239F;
            this.store_code.HeaderText = "STORE CODE";
            this.store_code.MinimumWidth = 12;
            this.store_code.Name = "store_code";
            this.store_code.ReadOnly = true;
            this.store_code.Width = 124;
            // 
            // store_name
            // 
            this.store_name.DataPropertyName = "store_name";
            this.store_name.FillWeight = 99.49239F;
            this.store_name.HeaderText = "STORE NAME";
            this.store_name.MinimumWidth = 12;
            this.store_name.Name = "store_name";
            this.store_name.ReadOnly = true;
            this.store_name.Width = 125;
            // 
            // store_area
            // 
            this.store_area.DataPropertyName = "store_area";
            this.store_area.FillWeight = 99.49239F;
            this.store_area.HeaderText = "STORE AREA";
            this.store_area.MinimumWidth = 12;
            this.store_area.Name = "store_area";
            this.store_area.ReadOnly = true;
            this.store_area.Width = 120;
            // 
            // store_route
            // 
            this.store_route.DataPropertyName = "store_route";
            this.store_route.FillWeight = 99.49239F;
            this.store_route.HeaderText = "STORE ROUTE";
            this.store_route.MinimumWidth = 12;
            this.store_route.Name = "store_route";
            this.store_route.ReadOnly = true;
            this.store_route.Width = 130;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.MinimumWidth = 12;
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            this.date_added.Width = 125;
            // 
            // added_by
            // 
            this.added_by.DataPropertyName = "added_by";
            this.added_by.HeaderText = "ADDED BY";
            this.added_by.Name = "added_by";
            this.added_by.ReadOnly = true;
            this.added_by.Width = 107;
            // 
            // modified_date
            // 
            this.modified_date.DataPropertyName = "modified_date";
            this.modified_date.HeaderText = "MODIFIED DATE";
            this.modified_date.Name = "modified_date";
            this.modified_date.ReadOnly = true;
            this.modified_date.Width = 144;
            // 
            // modified_by
            // 
            this.modified_by.DataPropertyName = "modified_by";
            this.modified_by.HeaderText = "MODIFIED BY";
            this.modified_by.Name = "modified_by";
            this.modified_by.ReadOnly = true;
            this.modified_by.Width = 126;
            // 
            // frmListofStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 598);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Name = "frmListofStore";
            this.Text = "List of Store";
            this.Load += new System.EventHandler(this.frmListofStore_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSubCategory;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stored_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_route;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn modified_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn modified_by;
    }
}