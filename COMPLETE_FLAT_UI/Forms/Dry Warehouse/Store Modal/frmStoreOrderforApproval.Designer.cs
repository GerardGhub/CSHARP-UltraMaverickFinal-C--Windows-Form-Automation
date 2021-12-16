
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmStoreOrderforApproval
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDateOrder = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.metroCmbStoreCode = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.matcmbPackaging = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            this.materialCheckboxSelectAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matbtnPrint = new MaterialSkin.Controls.MaterialButton();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.primary_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSelectedSum = new System.Windows.Forms.Label();
            this.matbtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.cmbDateOrder);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.metroCmbStoreCode);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.matcmbPackaging);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.bunifuPrepaDate);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(1158, 90);
            this.materialCard1.TabIndex = 582;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(957, 14);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(124, 19);
            this.materialLabel5.TabIndex = 584;
            this.materialLabel5.Text = "Preparation Date:";
            // 
            // cmbDateOrder
            // 
            this.cmbDateOrder.FormattingEnabled = true;
            this.cmbDateOrder.ItemHeight = 23;
            this.cmbDateOrder.Location = new System.Drawing.Point(13, 41);
            this.cmbDateOrder.Name = "cmbDateOrder";
            this.cmbDateOrder.Size = new System.Drawing.Size(182, 29);
            this.cmbDateOrder.TabIndex = 583;
            this.cmbDateOrder.UseSelectable = true;
            this.cmbDateOrder.SelectedIndexChanged += new System.EventHandler(this.cmbDateOrder_SelectedIndexChanged);
            this.cmbDateOrder.SelectionChangeCommitted += new System.EventHandler(this.cmbDateOrder_SelectionChangeCommitted);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(428, 16);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(38, 19);
            this.materialLabel3.TabIndex = 580;
            this.materialLabel3.Text = "Store";
            // 
            // metroCmbStoreCode
            // 
            this.metroCmbStoreCode.FormattingEnabled = true;
            this.metroCmbStoreCode.ItemHeight = 23;
            this.metroCmbStoreCode.Location = new System.Drawing.Point(427, 41);
            this.metroCmbStoreCode.Name = "metroCmbStoreCode";
            this.metroCmbStoreCode.Size = new System.Drawing.Size(224, 29);
            this.metroCmbStoreCode.TabIndex = 579;
            this.metroCmbStoreCode.UseSelectable = true;
            this.metroCmbStoreCode.SelectionChangeCommitted += new System.EventHandler(this.metroCmbStoreCode_SelectionChangeCommitted);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(221, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 578;
            this.materialLabel2.Text = "Category:";
            // 
            // matcmbPackaging
            // 
            this.matcmbPackaging.FormattingEnabled = true;
            this.matcmbPackaging.ItemHeight = 23;
            this.matcmbPackaging.Location = new System.Drawing.Point(220, 41);
            this.matcmbPackaging.Name = "matcmbPackaging";
            this.matcmbPackaging.Size = new System.Drawing.Size(182, 29);
            this.matcmbPackaging.TabIndex = 577;
            this.matcmbPackaging.UseSelectable = true;
            this.matcmbPackaging.SelectionChangeCommitted += new System.EventHandler(this.matcmbPackaging_SelectionChangeCommitted);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(14, 15);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 575;
            this.materialLabel1.Text = "Order Date:";
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-M-dd";
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(957, 37);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(170, 35);
            this.bunifuPrepaDate.TabIndex = 574;
            // 
            // materialCheckboxSelectAll
            // 
            this.materialCheckboxSelectAll.AutoSize = true;
            this.materialCheckboxSelectAll.Depth = 0;
            this.materialCheckboxSelectAll.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCheckboxSelectAll.Location = new System.Drawing.Point(22, 173);
            this.materialCheckboxSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxSelectAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxSelectAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxSelectAll.Name = "materialCheckboxSelectAll";
            this.materialCheckboxSelectAll.Ripple = true;
            this.materialCheckboxSelectAll.Size = new System.Drawing.Size(100, 37);
            this.materialCheckboxSelectAll.TabIndex = 585;
            this.materialCheckboxSelectAll.Text = "Select All";
            this.materialCheckboxSelectAll.UseVisualStyleBackColor = true;
            this.materialCheckboxSelectAll.Visible = false;
            this.materialCheckboxSelectAll.CheckedChanged += new System.EventHandler(this.materialCheckboxSelectAll_CheckedChanged);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(975, 794);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(51, 36);
            this.lbltotalrecords.TabIndex = 580;
            this.lbltotalrecords.Text = "76";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(1017, 810);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 581;
            this.label3.Text = "Items";
            // 
            // matbtnPrint
            // 
            this.matbtnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnPrint.Depth = 0;
            this.matbtnPrint.DrawShadows = true;
            this.matbtnPrint.HighEmphasis = true;
            this.matbtnPrint.Icon = null;
            this.matbtnPrint.Location = new System.Drawing.Point(20, 685);
            this.matbtnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnPrint.Name = "matbtnPrint";
            this.matbtnPrint.Size = new System.Drawing.Size(87, 36);
            this.matbtnPrint.TabIndex = 583;
            this.matbtnPrint.Text = "APPROVE";
            this.matbtnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnPrint.UseAccentColor = false;
            this.matbtnPrint.UseVisualStyleBackColor = true;
            this.matbtnPrint.Click += new System.EventHandler(this.matbtnPrint_Click);
            // 
            // dgvStoreOrderApproval
            // 
            this.dgvStoreOrderApproval.AllowUserToAddRows = false;
            this.dgvStoreOrderApproval.AllowUserToDeleteRows = false;
            this.dgvStoreOrderApproval.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStoreOrderApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStoreOrderApproval.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrderApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStoreOrderApproval.ColumnHeadersHeight = 45;
            this.dgvStoreOrderApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.primary_id,
            this.order_id,
            this.date_ordered,
            this.fox,
            this.store_name,
            this.route,
            this.area,
            this.category,
            this.item_code,
            this.description,
            this.uom,
            this.qty,
            this.date_added});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrderApproval.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStoreOrderApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreOrderApproval.EnableHeadersVisualStyles = false;
            this.dgvStoreOrderApproval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.Location = new System.Drawing.Point(5, 6);
            this.dgvStoreOrderApproval.MultiSelect = false;
            this.dgvStoreOrderApproval.Name = "dgvStoreOrderApproval";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStoreOrderApproval.RowHeadersVisible = false;
            this.dgvStoreOrderApproval.RowHeadersWidth = 102;
            this.dgvStoreOrderApproval.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.RowTemplate.DividerHeight = 5;
            this.dgvStoreOrderApproval.RowTemplate.Height = 40;
            this.dgvStoreOrderApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreOrderApproval.Size = new System.Drawing.Size(1148, 455);
            this.dgvStoreOrderApproval.TabIndex = 594;
            this.dgvStoreOrderApproval.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStoreOrderApproval.ThemeStyle.ReadOnly = false;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReprinting_CellContentClick);
            this.dgvStoreOrderApproval.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReprinting_CellContentDoubleClick);
            this.dgvStoreOrderApproval.CurrentCellChanged += new System.EventHandler(this.dgvReprinting_CurrentCellChanged);
            // 
            // selected
            // 
            this.selected.DataPropertyName = "selected";
            this.selected.FalseValue = "FALSE";
            this.selected.HeaderText = "SELECTED";
            this.selected.MinimumWidth = 12;
            this.selected.Name = "selected";
            this.selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selected.TrueValue = "TRUE";
            this.selected.Width = 82;
            // 
            // primary_id
            // 
            this.primary_id.DataPropertyName = "primary_id";
            this.primary_id.FillWeight = 66.91177F;
            this.primary_id.HeaderText = "ID";
            this.primary_id.MinimumWidth = 12;
            this.primary_id.Name = "primary_id";
            this.primary_id.Width = 48;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.FillWeight = 66.57212F;
            this.order_id.HeaderText = "ORDER ID";
            this.order_id.MinimumWidth = 12;
            this.order_id.Name = "order_id";
            this.order_id.Width = 93;
            // 
            // date_ordered
            // 
            this.date_ordered.DataPropertyName = "date_ordered";
            this.date_ordered.FillWeight = 66.57212F;
            this.date_ordered.HeaderText = "ORDER DATE";
            this.date_ordered.MinimumWidth = 12;
            this.date_ordered.Name = "date_ordered";
            this.date_ordered.Width = 111;
            // 
            // fox
            // 
            this.fox.DataPropertyName = "fox";
            this.fox.FillWeight = 66.57212F;
            this.fox.HeaderText = "STORE CODE";
            this.fox.MinimumWidth = 12;
            this.fox.Name = "fox";
            this.fox.Width = 112;
            // 
            // store_name
            // 
            this.store_name.DataPropertyName = "store_name";
            this.store_name.HeaderText = "STORE";
            this.store_name.MinimumWidth = 6;
            this.store_name.Name = "store_name";
            this.store_name.Width = 77;
            // 
            // route
            // 
            this.route.DataPropertyName = "route";
            this.route.FillWeight = 66.91177F;
            this.route.HeaderText = "ROUTE";
            this.route.MinimumWidth = 12;
            this.route.Name = "route";
            this.route.Width = 80;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.FillWeight = 66.91177F;
            this.area.HeaderText = "AREA";
            this.area.MinimumWidth = 12;
            this.area.Name = "area";
            this.area.Width = 70;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 66.91177F;
            this.category.HeaderText = "CATEGORY";
            this.category.MinimumWidth = 12;
            this.category.Name = "category";
            this.category.Width = 108;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 6;
            this.item_code.Name = "item_code";
            this.item_code.Width = 102;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 127;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UOM";
            this.uom.MinimumWidth = 6;
            this.uom.Name = "uom";
            this.uom.Width = 68;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QTY";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 61;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.MinimumWidth = 6;
            this.date_added.Name = "date_added";
            this.date_added.Width = 112;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvStoreOrderApproval);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(20, 209);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(1158, 467);
            this.materialCard2.TabIndex = 579;
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(1095, 690);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(32, 40);
            this.lbltotaldata.TabIndex = 639;
            this.lbltotaldata.Text = "0";
            this.lbltotaldata.TextChanged += new System.EventHandler(this.lbltotaldata_TextChanged);
            this.lbltotaldata.Click += new System.EventHandler(this.lbltotaldata_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(1140, 704);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 640;
            this.label4.Text = "Items";
            // 
            // labelSelectedSum
            // 
            this.labelSelectedSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedSum.AutoSize = true;
            this.labelSelectedSum.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedSum.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.labelSelectedSum.Location = new System.Drawing.Point(959, 169);
            this.labelSelectedSum.Name = "labelSelectedSum";
            this.labelSelectedSum.Size = new System.Drawing.Size(32, 40);
            this.labelSelectedSum.TabIndex = 641;
            this.labelSelectedSum.Text = "0";
            this.labelSelectedSum.Visible = false;
            this.labelSelectedSum.TextChanged += new System.EventHandler(this.labelSelectedSum_TextChanged);
            // 
            // matbtnEdit
            // 
            this.matbtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnEdit.Depth = 0;
            this.matbtnEdit.DrawShadows = true;
            this.matbtnEdit.HighEmphasis = true;
            this.matbtnEdit.Icon = null;
            this.matbtnEdit.Location = new System.Drawing.Point(128, 685);
            this.matbtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnEdit.Name = "matbtnEdit";
            this.matbtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matbtnEdit.TabIndex = 642;
            this.matbtnEdit.Text = "EDIT";
            this.matbtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnEdit.UseAccentColor = false;
            this.matbtnEdit.UseVisualStyleBackColor = true;
            this.matbtnEdit.Visible = false;
            this.matbtnEdit.Click += new System.EventHandler(this.matbtnEdit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(553, 690);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 643;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmStoreOrderforApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 733);
            this.Controls.Add(this.materialCheckboxSelectAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matbtnEdit);
            this.Controls.Add(this.labelSelectedSum);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matbtnPrint);
            this.Controls.Add(this.materialCard2);
            this.Name = "frmStoreOrderforApproval";
            this.Text = "Order  Approval";
            this.Load += new System.EventHandler(this.frmStoreOrderforApproval_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton matbtnPrint;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn primary_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordered;
        private System.Windows.Forms.DataGridViewTextBoxColumn fox;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn route;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Label labelSelectedSum;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxSelectAll;
        private MetroFramework.Controls.MetroComboBox cmbDateOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroComboBox metroCmbStoreCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox matcmbPackaging;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton matbtnEdit;
        public System.Windows.Forms.TextBox textBox1;
    }
}