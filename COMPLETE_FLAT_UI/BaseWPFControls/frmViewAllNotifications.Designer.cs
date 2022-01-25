
namespace ULTRAMAVERICK.BaseWPFControls
{
    partial class frmViewAllNotifications
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DatagridViewGuna1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.is_approved_prepa_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepared_allocated_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_wh_checker_cancel_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_wh_checker_cancel_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_wh_checker_cancel_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridViewGuna1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DatagridViewGuna1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logistic Checker Cancel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DatagridViewGuna1
            // 
            this.DatagridViewGuna1.AllowUserToAddRows = false;
            this.DatagridViewGuna1.AllowUserToDeleteRows = false;
            this.DatagridViewGuna1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DatagridViewGuna1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridViewGuna1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DatagridViewGuna1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DatagridViewGuna1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatagridViewGuna1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridViewGuna1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridViewGuna1.ColumnHeadersHeight = 35;
            this.DatagridViewGuna1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DatagridViewGuna1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_approved_prepa_date,
            this.item_code,
            this.description,
            this.category,
            this.fox,
            this.store_name,
            this.qty,
            this.prepared_allocated_qty,
            this.is_wh_checker_cancel_by,
            this.is_wh_checker_cancel_date,
            this.is_wh_checker_cancel_reason});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridViewGuna1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridViewGuna1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatagridViewGuna1.EnableHeadersVisualStyles = false;
            this.DatagridViewGuna1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DatagridViewGuna1.Location = new System.Drawing.Point(3, 3);
            this.DatagridViewGuna1.MultiSelect = false;
            this.DatagridViewGuna1.Name = "DatagridViewGuna1";
            this.DatagridViewGuna1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridViewGuna1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatagridViewGuna1.RowHeadersVisible = false;
            this.DatagridViewGuna1.RowHeadersWidth = 102;
            this.DatagridViewGuna1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatagridViewGuna1.RowTemplate.DividerHeight = 5;
            this.DatagridViewGuna1.RowTemplate.Height = 40;
            this.DatagridViewGuna1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridViewGuna1.Size = new System.Drawing.Size(1022, 314);
            this.DatagridViewGuna1.TabIndex = 595;
            this.DatagridViewGuna1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.DatagridViewGuna1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridViewGuna1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DatagridViewGuna1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DatagridViewGuna1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DatagridViewGuna1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DatagridViewGuna1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DatagridViewGuna1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DatagridViewGuna1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DatagridViewGuna1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.DatagridViewGuna1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatagridViewGuna1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DatagridViewGuna1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DatagridViewGuna1.ThemeStyle.HeaderStyle.Height = 35;
            this.DatagridViewGuna1.ThemeStyle.ReadOnly = true;
            this.DatagridViewGuna1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DatagridViewGuna1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DatagridViewGuna1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatagridViewGuna1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DatagridViewGuna1.ThemeStyle.RowsStyle.Height = 40;
            this.DatagridViewGuna1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DatagridViewGuna1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(962, 422);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(27, 32);
            this.lbltotalrecords.TabIndex = 661;
            this.lbltotalrecords.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(994, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 662;
            this.label4.Text = "Items";
            // 
            // is_approved_prepa_date
            // 
            this.is_approved_prepa_date.DataPropertyName = "is_approved_prepa_date";
            this.is_approved_prepa_date.FillWeight = 40.60914F;
            this.is_approved_prepa_date.Frozen = true;
            this.is_approved_prepa_date.HeaderText = "PREPARATION DATE";
            this.is_approved_prepa_date.MinimumWidth = 12;
            this.is_approved_prepa_date.Name = "is_approved_prepa_date";
            this.is_approved_prepa_date.ReadOnly = true;
            this.is_approved_prepa_date.Width = 169;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.FillWeight = 99.49239F;
            this.item_code.Frozen = true;
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 113;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 99.49239F;
            this.description.Frozen = true;
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 12;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 129;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 99.49239F;
            this.category.HeaderText = "CATEGORY";
            this.category.MinimumWidth = 12;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 110;
            // 
            // fox
            // 
            this.fox.DataPropertyName = "fox";
            this.fox.FillWeight = 99.49239F;
            this.fox.HeaderText = "FOX";
            this.fox.MinimumWidth = 12;
            this.fox.Name = "fox";
            this.fox.ReadOnly = true;
            this.fox.Width = 63;
            // 
            // store_name
            // 
            this.store_name.DataPropertyName = "store_name";
            this.store_name.HeaderText = "STORE";
            this.store_name.MinimumWidth = 12;
            this.store_name.Name = "store_name";
            this.store_name.ReadOnly = true;
            this.store_name.Width = 79;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 63;
            // 
            // prepared_allocated_qty
            // 
            this.prepared_allocated_qty.DataPropertyName = "prepared_allocated_qty";
            this.prepared_allocated_qty.HeaderText = "SERVE";
            this.prepared_allocated_qty.Name = "prepared_allocated_qty";
            this.prepared_allocated_qty.ReadOnly = true;
            this.prepared_allocated_qty.Width = 78;
            // 
            // is_wh_checker_cancel_by
            // 
            this.is_wh_checker_cancel_by.DataPropertyName = "is_wh_checker_cancel_by";
            this.is_wh_checker_cancel_by.HeaderText = "CANCEL BY";
            this.is_wh_checker_cancel_by.Name = "is_wh_checker_cancel_by";
            this.is_wh_checker_cancel_by.ReadOnly = true;
            this.is_wh_checker_cancel_by.Width = 112;
            // 
            // is_wh_checker_cancel_date
            // 
            this.is_wh_checker_cancel_date.DataPropertyName = "is_wh_checker_cancel_date";
            this.is_wh_checker_cancel_date.HeaderText = "CANCEL DATE";
            this.is_wh_checker_cancel_date.Name = "is_wh_checker_cancel_date";
            this.is_wh_checker_cancel_date.ReadOnly = true;
            this.is_wh_checker_cancel_date.Width = 130;
            // 
            // is_wh_checker_cancel_reason
            // 
            this.is_wh_checker_cancel_reason.DataPropertyName = "is_wh_checker_cancel_reason";
            this.is_wh_checker_cancel_reason.HeaderText = "CANCEL REASON";
            this.is_wh_checker_cancel_reason.Name = "is_wh_checker_cancel_reason";
            this.is_wh_checker_cancel_reason.ReadOnly = true;
            this.is_wh_checker_cancel_reason.Width = 153;
            // 
            // frmViewAllNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 456);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmViewAllNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.frmViewAllNotifications_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridViewGuna1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView DatagridViewGuna1;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_approved_prepa_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn fox;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepared_allocated_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_wh_checker_cancel_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_wh_checker_cancel_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_wh_checker_cancel_reason;
    }
}