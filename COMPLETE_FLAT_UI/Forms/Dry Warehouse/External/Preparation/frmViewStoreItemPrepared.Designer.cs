
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Preparation
{
    partial class frmViewStoreItemPrepared
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
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.guna2DgvMaterialPreparation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prepa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.converted_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serve_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ordered_materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_approved_preparation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvMaterialPreparation)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.guna2DgvMaterialPreparation);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(18, 77);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard4.Size = new System.Drawing.Size(808, 413);
            this.materialCard4.TabIndex = 658;
            // 
            // guna2DgvMaterialPreparation
            // 
            this.guna2DgvMaterialPreparation.AllowUserToAddRows = false;
            this.guna2DgvMaterialPreparation.AllowUserToDeleteRows = false;
            this.guna2DgvMaterialPreparation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DgvMaterialPreparation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DgvMaterialPreparation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DgvMaterialPreparation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DgvMaterialPreparation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DgvMaterialPreparation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DgvMaterialPreparation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DgvMaterialPreparation.ColumnHeadersHeight = 40;
            this.guna2DgvMaterialPreparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DgvMaterialPreparation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prepa_id,
            this.fox,
            this.item_code,
            this.description,
            this.category,
            this.uom,
            this.qty,
            this.converted_qty,
            this.Serve_Qty,
            this.Remaining_Qty,
            this.date_ordered_materials,
            this.is_approved_preparation_date,
            this.conversion,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DgvMaterialPreparation.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DgvMaterialPreparation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DgvMaterialPreparation.EnableHeadersVisualStyles = false;
            this.guna2DgvMaterialPreparation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DgvMaterialPreparation.Location = new System.Drawing.Point(5, 6);
            this.guna2DgvMaterialPreparation.MultiSelect = false;
            this.guna2DgvMaterialPreparation.Name = "guna2DgvMaterialPreparation";
            this.guna2DgvMaterialPreparation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DgvMaterialPreparation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DgvMaterialPreparation.RowHeadersVisible = false;
            this.guna2DgvMaterialPreparation.RowHeadersWidth = 102;
            this.guna2DgvMaterialPreparation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DgvMaterialPreparation.RowTemplate.DividerHeight = 5;
            this.guna2DgvMaterialPreparation.RowTemplate.Height = 40;
            this.guna2DgvMaterialPreparation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DgvMaterialPreparation.Size = new System.Drawing.Size(798, 401);
            this.guna2DgvMaterialPreparation.TabIndex = 595;
            this.guna2DgvMaterialPreparation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DgvMaterialPreparation.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Window;
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DgvMaterialPreparation.ThemeStyle.ReadOnly = true;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DgvMaterialPreparation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DgvMaterialPreparation_CellContentClick);
            this.guna2DgvMaterialPreparation.CurrentCellChanged += new System.EventHandler(this.guna2DgvMaterialPreparation_CurrentCellChanged);
            this.guna2DgvMaterialPreparation.DoubleClick += new System.EventHandler(this.guna2DgvMaterialPreparation_DoubleClick);
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(765, 497);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(26, 29);
            this.lbltotaldata.TabIndex = 659;
            this.lbltotaldata.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(797, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 660;
            this.label4.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 662;
            this.label3.Text = "TextBox for Two Way Binding";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(318, 509);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 661;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prepa_id
            // 
            this.prepa_id.DataPropertyName = "prepa_id";
            this.prepa_id.HeaderText = "ID";
            this.prepa_id.Name = "prepa_id";
            this.prepa_id.ReadOnly = true;
            // 
            // fox
            // 
            this.fox.DataPropertyName = "fox";
            this.fox.HeaderText = "STORE CODE";
            this.fox.Name = "fox";
            this.fox.ReadOnly = true;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.FillWeight = 66.91177F;
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 66.57212F;
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 12;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.FillWeight = 66.57212F;
            this.uom.HeaderText = "UOM";
            this.uom.MinimumWidth = 12;
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.FillWeight = 66.57212F;
            this.qty.HeaderText = "ORDER";
            this.qty.MinimumWidth = 12;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // converted_qty
            // 
            this.converted_qty.DataPropertyName = "converted_qty";
            this.converted_qty.HeaderText = "ALLOCATED QTY";
            this.converted_qty.MinimumWidth = 6;
            this.converted_qty.Name = "converted_qty";
            this.converted_qty.ReadOnly = true;
            // 
            // Serve_Qty
            // 
            this.Serve_Qty.DataPropertyName = "Serve_Qty";
            this.Serve_Qty.FillWeight = 66.91177F;
            this.Serve_Qty.HeaderText = "SERVE";
            this.Serve_Qty.MinimumWidth = 12;
            this.Serve_Qty.Name = "Serve_Qty";
            this.Serve_Qty.ReadOnly = true;
            // 
            // Remaining_Qty
            // 
            this.Remaining_Qty.DataPropertyName = "Remaining_Qty";
            this.Remaining_Qty.HeaderText = "REMAINING";
            this.Remaining_Qty.Name = "Remaining_Qty";
            this.Remaining_Qty.ReadOnly = true;
            // 
            // date_ordered_materials
            // 
            this.date_ordered_materials.DataPropertyName = "date_ordered";
            this.date_ordered_materials.HeaderText = "DATE ORDERED";
            this.date_ordered_materials.Name = "date_ordered_materials";
            this.date_ordered_materials.ReadOnly = true;
            // 
            // is_approved_preparation_date
            // 
            this.is_approved_preparation_date.DataPropertyName = "is_approved_preparation_date";
            this.is_approved_preparation_date.HeaderText = "APPROVED DATE";
            this.is_approved_preparation_date.Name = "is_approved_preparation_date";
            this.is_approved_preparation_date.ReadOnly = true;
            // 
            // conversion
            // 
            this.conversion.DataPropertyName = "conversion";
            this.conversion.HeaderText = "CONVERSION";
            this.conversion.Name = "conversion";
            this.conversion.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "CANCEL";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "CANCEL";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // frmViewStoreItemPrepared
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 539);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialCard4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewStoreItemPrepared";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIEWING OF ITEM PREPARED";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewStoreItemPrepared_FormClosing);
            this.Load += new System.EventHandler(this.frmViewStoreItemPrepared_Load);
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvMaterialPreparation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DgvMaterialPreparation;
        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fox;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn converted_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serve_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaining_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordered_materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_approved_preparation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversion;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}