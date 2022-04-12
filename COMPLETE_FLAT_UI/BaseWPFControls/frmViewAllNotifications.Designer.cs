
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPLogisticCheckerCancel = new System.Windows.Forms.TabPage();
            this.DatagridViewGuna1 = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.tPCheckerDispatching = new System.Windows.Forms.TabPage();
            this.gunaDgvLogisticCheckerDispatching = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tPLabResultReceiving = new System.Windows.Forms.TabPage();
            this.dgvRawMats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAYSTOEXPIRED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STANDARDEXPIRYDAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HISTORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_exp_date_extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_result_remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_sub_remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratory_procedure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tPLogisticCheckerCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridViewGuna1)).BeginInit();
            this.tPCheckerDispatching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvLogisticCheckerDispatching)).BeginInit();
            this.tPLabResultReceiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPLogisticCheckerCancel);
            this.tabControl1.Controls.Add(this.tPCheckerDispatching);
            this.tabControl1.Controls.Add(this.tPLabResultReceiving);
            this.tabControl1.Location = new System.Drawing.Point(13, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 406);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tPLogisticCheckerCancel
            // 
            this.tPLogisticCheckerCancel.Controls.Add(this.DatagridViewGuna1);
            this.tPLogisticCheckerCancel.Location = new System.Drawing.Point(4, 22);
            this.tPLogisticCheckerCancel.Name = "tPLogisticCheckerCancel";
            this.tPLogisticCheckerCancel.Padding = new System.Windows.Forms.Padding(3);
            this.tPLogisticCheckerCancel.Size = new System.Drawing.Size(1028, 380);
            this.tPLogisticCheckerCancel.TabIndex = 0;
            this.tPLogisticCheckerCancel.Text = "Logistic Checker Cancel";
            this.tPLogisticCheckerCancel.UseVisualStyleBackColor = true;
            // 
            // DatagridViewGuna1
            // 
            this.DatagridViewGuna1.AllowUserToAddRows = false;
            this.DatagridViewGuna1.AllowUserToDeleteRows = false;
            this.DatagridViewGuna1.AllowUserToResizeRows = false;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            this.DatagridViewGuna1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
            this.DatagridViewGuna1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DatagridViewGuna1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DatagridViewGuna1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatagridViewGuna1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridViewGuna1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridViewGuna1.DefaultCellStyle = dataGridViewCellStyle29;
            this.DatagridViewGuna1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatagridViewGuna1.EnableHeadersVisualStyles = false;
            this.DatagridViewGuna1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DatagridViewGuna1.Location = new System.Drawing.Point(3, 3);
            this.DatagridViewGuna1.MultiSelect = false;
            this.DatagridViewGuna1.Name = "DatagridViewGuna1";
            this.DatagridViewGuna1.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridViewGuna1.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.DatagridViewGuna1.RowHeadersVisible = false;
            this.DatagridViewGuna1.RowHeadersWidth = 102;
            this.DatagridViewGuna1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatagridViewGuna1.RowTemplate.DividerHeight = 5;
            this.DatagridViewGuna1.RowTemplate.Height = 40;
            this.DatagridViewGuna1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridViewGuna1.Size = new System.Drawing.Size(1022, 374);
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
            // tPCheckerDispatching
            // 
            this.tPCheckerDispatching.Controls.Add(this.gunaDgvLogisticCheckerDispatching);
            this.tPCheckerDispatching.Location = new System.Drawing.Point(4, 22);
            this.tPCheckerDispatching.Name = "tPCheckerDispatching";
            this.tPCheckerDispatching.Padding = new System.Windows.Forms.Padding(3);
            this.tPCheckerDispatching.Size = new System.Drawing.Size(1028, 380);
            this.tPCheckerDispatching.TabIndex = 1;
            this.tPCheckerDispatching.Text = "Logistic Checker Dispatching";
            this.tPCheckerDispatching.UseVisualStyleBackColor = true;
            // 
            // gunaDgvLogisticCheckerDispatching
            // 
            this.gunaDgvLogisticCheckerDispatching.AllowUserToAddRows = false;
            this.gunaDgvLogisticCheckerDispatching.AllowUserToDeleteRows = false;
            this.gunaDgvLogisticCheckerDispatching.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.gunaDgvLogisticCheckerDispatching.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.gunaDgvLogisticCheckerDispatching.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gunaDgvLogisticCheckerDispatching.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaDgvLogisticCheckerDispatching.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDgvLogisticCheckerDispatching.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvLogisticCheckerDispatching.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.gunaDgvLogisticCheckerDispatching.ColumnHeadersHeight = 35;
            this.gunaDgvLogisticCheckerDispatching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDgvLogisticCheckerDispatching.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDgvLogisticCheckerDispatching.DefaultCellStyle = dataGridViewCellStyle33;
            this.gunaDgvLogisticCheckerDispatching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDgvLogisticCheckerDispatching.EnableHeadersVisualStyles = false;
            this.gunaDgvLogisticCheckerDispatching.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.gunaDgvLogisticCheckerDispatching.Location = new System.Drawing.Point(3, 3);
            this.gunaDgvLogisticCheckerDispatching.MultiSelect = false;
            this.gunaDgvLogisticCheckerDispatching.Name = "gunaDgvLogisticCheckerDispatching";
            this.gunaDgvLogisticCheckerDispatching.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDgvLogisticCheckerDispatching.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.gunaDgvLogisticCheckerDispatching.RowHeadersVisible = false;
            this.gunaDgvLogisticCheckerDispatching.RowHeadersWidth = 102;
            this.gunaDgvLogisticCheckerDispatching.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gunaDgvLogisticCheckerDispatching.RowTemplate.DividerHeight = 5;
            this.gunaDgvLogisticCheckerDispatching.RowTemplate.Height = 40;
            this.gunaDgvLogisticCheckerDispatching.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDgvLogisticCheckerDispatching.Size = new System.Drawing.Size(1022, 374);
            this.gunaDgvLogisticCheckerDispatching.TabIndex = 596;
            this.gunaDgvLogisticCheckerDispatching.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.ReadOnly = true;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.RowsStyle.Height = 40;
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.gunaDgvLogisticCheckerDispatching.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "is_approved_prepa_date";
            this.dataGridViewTextBoxColumn1.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "PREPARATION DATE";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 169;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "item_code";
            this.dataGridViewTextBoxColumn2.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ITEM CODE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 113;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 129;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn4.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn4.HeaderText = "CATEGORY";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fox";
            this.dataGridViewTextBoxColumn5.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn5.HeaderText = "FOX";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 63;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "store_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "STORE";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 79;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn7.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 63;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "prepared_allocated_qty";
            this.dataGridViewTextBoxColumn8.HeaderText = "SERVE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "is_wh_approved_by";
            this.dataGridViewTextBoxColumn9.HeaderText = "APPROVED BY";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 134;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "is_wh_approved_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "APPROVED DATE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 152;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(962, 499);
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
            this.label4.Location = new System.Drawing.Point(994, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 662;
            this.label4.Text = "Items";
            // 
            // tPLabResultReceiving
            // 
            this.tPLabResultReceiving.Controls.Add(this.dgvRawMats);
            this.tPLabResultReceiving.Location = new System.Drawing.Point(4, 22);
            this.tPLabResultReceiving.Name = "tPLabResultReceiving";
            this.tPLabResultReceiving.Padding = new System.Windows.Forms.Padding(3);
            this.tPLabResultReceiving.Size = new System.Drawing.Size(1028, 380);
            this.tPLabResultReceiving.TabIndex = 2;
            this.tPLabResultReceiving.Text = "Laboratory Result Receiving";
            this.tPLabResultReceiving.UseVisualStyleBackColor = true;
            // 
            // dgvRawMats
            // 
            this.dgvRawMats.AllowUserToAddRows = false;
            this.dgvRawMats.AllowUserToDeleteRows = false;
            this.dgvRawMats.AllowUserToResizeRows = false;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvRawMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawMats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRawMats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvRawMats.ColumnHeadersHeight = 45;
            this.dgvRawMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn11,
            this.item_description,
            this.dataGridViewTextBoxColumn12,
            this.qty_received,
            this.remaining_qty,
            this.exp_date,
            this.DAYSTOEXPIRED,
            this.STANDARDEXPIRYDAYS,
            this.lab_status,
            this.HISTORY,
            this.AGING,
            this.lab_exp_date_extension,
            this.lab_result_remarks,
            this.lab_sub_remarks,
            this.laboratory_procedure});
            this.dgvRawMats.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMats.DefaultCellStyle = dataGridViewCellStyle37;
            this.dgvRawMats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMats.EnableHeadersVisualStyles = false;
            this.dgvRawMats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.Location = new System.Drawing.Point(3, 3);
            this.dgvRawMats.MultiSelect = false;
            this.dgvRawMats.Name = "dgvRawMats";
            this.dgvRawMats.ReadOnly = true;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvRawMats.RowHeadersVisible = false;
            this.dgvRawMats.RowHeadersWidth = 102;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.RowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvRawMats.RowTemplate.DividerHeight = 5;
            this.dgvRawMats.RowTemplate.Height = 40;
            this.dgvRawMats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMats.Size = new System.Drawing.Size(1022, 374);
            this.dgvRawMats.TabIndex = 6;
            this.dgvRawMats.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvRawMats.ThemeStyle.ReadOnly = true;
            this.dgvRawMats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 40.60914F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "item_code";
            this.dataGridViewTextBoxColumn11.FillWeight = 59.93546F;
            this.dataGridViewTextBoxColumn11.HeaderText = "ITEM CODE";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // item_description
            // 
            this.item_description.DataPropertyName = "item_description";
            this.item_description.FillWeight = 97.00433F;
            this.item_description.HeaderText = "ITEM DESCRIPTION";
            this.item_description.MinimumWidth = 12;
            this.item_description.Name = "item_description";
            this.item_description.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn12.HeaderText = "CATEGORY";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // qty_received
            // 
            this.qty_received.DataPropertyName = "qty_received";
            this.qty_received.FillWeight = 77.07378F;
            this.qty_received.HeaderText = "QTY RECEIVED";
            this.qty_received.MinimumWidth = 12;
            this.qty_received.Name = "qty_received";
            this.qty_received.ReadOnly = true;
            // 
            // remaining_qty
            // 
            this.remaining_qty.DataPropertyName = "remaining_qty";
            this.remaining_qty.HeaderText = "QTY";
            this.remaining_qty.Name = "remaining_qty";
            this.remaining_qty.ReadOnly = true;
            // 
            // exp_date
            // 
            this.exp_date.DataPropertyName = "exp_date";
            this.exp_date.HeaderText = "EXPIRATION DATE";
            this.exp_date.Name = "exp_date";
            this.exp_date.ReadOnly = true;
            // 
            // DAYSTOEXPIRED
            // 
            this.DAYSTOEXPIRED.DataPropertyName = "DAYSTOEXPIRED";
            this.DAYSTOEXPIRED.HeaderText = "EXPIRY DAYS";
            this.DAYSTOEXPIRED.Name = "DAYSTOEXPIRED";
            this.DAYSTOEXPIRED.ReadOnly = true;
            // 
            // STANDARDEXPIRYDAYS
            // 
            this.STANDARDEXPIRYDAYS.DataPropertyName = "STANDARDEXPIRYDAYS";
            this.STANDARDEXPIRYDAYS.HeaderText = "STANDARD EXPIRY DAY";
            this.STANDARDEXPIRYDAYS.Name = "STANDARDEXPIRYDAYS";
            this.STANDARDEXPIRYDAYS.ReadOnly = true;
            // 
            // lab_status
            // 
            this.lab_status.DataPropertyName = "lab_status";
            this.lab_status.HeaderText = "STATUS";
            this.lab_status.Name = "lab_status";
            this.lab_status.ReadOnly = true;
            // 
            // HISTORY
            // 
            this.HISTORY.DataPropertyName = "HISTORY";
            this.HISTORY.HeaderText = "HISTORY";
            this.HISTORY.Name = "HISTORY";
            this.HISTORY.ReadOnly = true;
            // 
            // AGING
            // 
            this.AGING.DataPropertyName = "AGING";
            this.AGING.HeaderText = "AGING";
            this.AGING.Name = "AGING";
            this.AGING.ReadOnly = true;
            // 
            // lab_exp_date_extension
            // 
            this.lab_exp_date_extension.DataPropertyName = "lab_exp_date_extension";
            this.lab_exp_date_extension.HeaderText = "EXTENSION DATE";
            this.lab_exp_date_extension.Name = "lab_exp_date_extension";
            this.lab_exp_date_extension.ReadOnly = true;
            // 
            // lab_result_remarks
            // 
            this.lab_result_remarks.DataPropertyName = "lab_result_remarks";
            this.lab_result_remarks.HeaderText = "REMARKS";
            this.lab_result_remarks.Name = "lab_result_remarks";
            this.lab_result_remarks.ReadOnly = true;
            // 
            // lab_sub_remarks
            // 
            this.lab_sub_remarks.DataPropertyName = "lab_sub_remarks";
            this.lab_sub_remarks.HeaderText = "SUB REMARKS";
            this.lab_sub_remarks.Name = "lab_sub_remarks";
            this.lab_sub_remarks.ReadOnly = true;
            // 
            // laboratory_procedure
            // 
            this.laboratory_procedure.DataPropertyName = "laboratory_procedure";
            this.laboratory_procedure.HeaderText = "PROCEDURE";
            this.laboratory_procedure.Name = "laboratory_procedure";
            this.laboratory_procedure.ReadOnly = true;
            // 
            // frmViewAllNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 540);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmViewAllNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.frmViewAllNotifications_Load);
            this.tabControl1.ResumeLayout(false);
            this.tPLogisticCheckerCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridViewGuna1)).EndInit();
            this.tPCheckerDispatching.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDgvLogisticCheckerDispatching)).EndInit();
            this.tPLabResultReceiving.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPLogisticCheckerCancel;
        private System.Windows.Forms.TabPage tPCheckerDispatching;
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
        private Guna.UI2.WinForms.Guna2DataGridView gunaDgvLogisticCheckerDispatching;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabPage tPLabResultReceiving;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRawMats;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYSTOEXPIRED;
        private System.Windows.Forms.DataGridViewTextBoxColumn STANDARDEXPIRYDAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn HISTORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGING;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_exp_date_extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_result_remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_sub_remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratory_procedure;
    }
}