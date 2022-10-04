namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    partial class FrmImportMrsOrders
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.drywhordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ultraMaverickDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraMaverickDBDataSet = new ULTRAMAVERICK.UltraMaverickDBDataSet();
            this.drymaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvRawMats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.date_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNeeded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateorderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tbl_storesTableAdapter = new ULTRAMAVERICK.UltraMaverickDBDataSetTableAdapters.tbl_storesTableAdapter();
            this.project_Po_SummaryTableAdapter = new ULTRAMAVERICK.UltraMaverickDBDataSetTableAdapters.Raw_Materials_DryTableAdapter();
            this.drywhordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dry_wh_ordersTableAdapter = new ULTRAMAVERICK.UltraMaverickDBDataSetTableAdapters.dry_wh_ordersTableAdapter();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new MaterialSkin.Controls.MaterialTextBox();
            this.cbosheet = new MetroFramework.Controls.MetroComboBox();
            this.matBtnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.matbtnUpload = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drywhordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drymaterialsBindingSource)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drywhordersBindingSource)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drywhordersBindingSource1
            // 
            this.drywhordersBindingSource1.DataMember = "dry_wh_orders";
            this.drywhordersBindingSource1.DataSource = this.ultraMaverickDBDataSetBindingSource;
            // 
            // ultraMaverickDBDataSetBindingSource
            // 
            this.ultraMaverickDBDataSetBindingSource.DataSource = this.ultraMaverickDBDataSet;
            this.ultraMaverickDBDataSetBindingSource.Position = 0;
            // 
            // ultraMaverickDBDataSet
            // 
            this.ultraMaverickDBDataSet.DataSetName = "UltraMaverickDBDataSet";
            this.ultraMaverickDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drymaterialsBindingSource
            // 
            this.drymaterialsBindingSource.AllowNew = true;
            this.drymaterialsBindingSource.DataMember = "tbl_stores";
            this.drymaterialsBindingSource.DataSource = this.ultraMaverickDBDataSet;
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(971, 74);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(37, 50);
            this.mattxtSearch.TabIndex = 581;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvRawMats);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(29, 74);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(963, 462);
            this.materialCard1.TabIndex = 578;
            // 
            // dgvRawMats
            // 
            this.dgvRawMats.AllowUserToAddRows = false;
            this.dgvRawMats.AllowUserToDeleteRows = false;
            this.dgvRawMats.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRawMats.AutoGenerateColumns = false;
            this.dgvRawMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawMats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRawMats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRawMats.ColumnHeadersHeight = 40;
            this.dgvRawMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_ordered,
            this.fox,
            this.item_code,
            this.description,
            this.uom,
            this.qty,
            this.DateNeeded,
            this.storenameDataGridViewTextBoxColumn,
            this.dateorderedDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.itemcodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.uomDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.foxDataGridViewTextBoxColumn});
            this.dgvRawMats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRawMats.DataSource = this.drywhordersBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMats.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRawMats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMats.EnableHeadersVisualStyles = false;
            this.dgvRawMats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.Location = new System.Drawing.Point(5, 6);
            this.dgvRawMats.MultiSelect = false;
            this.dgvRawMats.Name = "dgvRawMats";
            this.dgvRawMats.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRawMats.RowHeadersVisible = false;
            this.dgvRawMats.RowHeadersWidth = 102;
            this.dgvRawMats.RowTemplate.DividerHeight = 5;
            this.dgvRawMats.RowTemplate.Height = 40;
            this.dgvRawMats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMats.Size = new System.Drawing.Size(953, 450);
            this.dgvRawMats.TabIndex = 5;
            this.dgvRawMats.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvRawMats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.ReadOnly = true;
            this.dgvRawMats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvRawMats.CurrentCellChanged += new System.EventHandler(this.dgvRawMats_CurrentCellChanged);
            this.dgvRawMats.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRawMats_DataBindingComplete);
            // 
            // date_ordered
            // 
            this.date_ordered.DataPropertyName = "date_ordered";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.date_ordered.DefaultCellStyle = dataGridViewCellStyle3;
            this.date_ordered.HeaderText = "ORDER DATE";
            this.date_ordered.MinimumWidth = 12;
            this.date_ordered.Name = "date_ordered";
            this.date_ordered.ReadOnly = true;
            // 
            // fox
            // 
            this.fox.DataPropertyName = "fox";
            this.fox.HeaderText = "DEPARTMENT";
            this.fox.MinimumWidth = 6;
            this.fox.Name = "fox";
            this.fox.ReadOnly = true;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 6;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UOM";
            this.uom.MinimumWidth = 6;
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QUANTITY ORDER";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // DateNeeded
            // 
            this.DateNeeded.DataPropertyName = "DateNeeded";
            this.DateNeeded.HeaderText = "DATE NEEDED";
            this.DateNeeded.Name = "DateNeeded";
            this.DateNeeded.ReadOnly = true;
            // 
            // storenameDataGridViewTextBoxColumn
            // 
            this.storenameDataGridViewTextBoxColumn.DataPropertyName = "store_name";
            this.storenameDataGridViewTextBoxColumn.HeaderText = "store_name";
            this.storenameDataGridViewTextBoxColumn.Name = "storenameDataGridViewTextBoxColumn";
            this.storenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.storenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateorderedDataGridViewTextBoxColumn
            // 
            this.dateorderedDataGridViewTextBoxColumn.DataPropertyName = "date_ordered";
            this.dateorderedDataGridViewTextBoxColumn.HeaderText = "date_ordered";
            this.dateorderedDataGridViewTextBoxColumn.Name = "dateorderedDataGridViewTextBoxColumn";
            this.dateorderedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateorderedDataGridViewTextBoxColumn.Visible = false;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeDataGridViewTextBoxColumn.Visible = false;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemcodeDataGridViewTextBoxColumn
            // 
            this.itemcodeDataGridViewTextBoxColumn.DataPropertyName = "item_code";
            this.itemcodeDataGridViewTextBoxColumn.HeaderText = "item_code";
            this.itemcodeDataGridViewTextBoxColumn.Name = "itemcodeDataGridViewTextBoxColumn";
            this.itemcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // uomDataGridViewTextBoxColumn
            // 
            this.uomDataGridViewTextBoxColumn.DataPropertyName = "uom";
            this.uomDataGridViewTextBoxColumn.HeaderText = "uom";
            this.uomDataGridViewTextBoxColumn.Name = "uomDataGridViewTextBoxColumn";
            this.uomDataGridViewTextBoxColumn.ReadOnly = true;
            this.uomDataGridViewTextBoxColumn.Visible = false;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Visible = false;
            // 
            // foxDataGridViewTextBoxColumn
            // 
            this.foxDataGridViewTextBoxColumn.DataPropertyName = "fox";
            this.foxDataGridViewTextBoxColumn.HeaderText = "fox";
            this.foxDataGridViewTextBoxColumn.Name = "foxDataGridViewTextBoxColumn";
            this.foxDataGridViewTextBoxColumn.ReadOnly = true;
            this.foxDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvUnits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUnits.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnits.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnits.EnableHeadersVisualStyles = false;
            this.dgvUnits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvUnits.Location = new System.Drawing.Point(5, 6);
            this.dgvUnits.MultiSelect = false;
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUnits.RowHeadersVisible = false;
            this.dgvUnits.RowHeadersWidth = 102;
            this.dgvUnits.RowTemplate.DividerHeight = 5;
            this.dgvUnits.RowTemplate.Height = 40;
            this.dgvUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnits.Size = new System.Drawing.Size(220, 22);
            this.dgvUnits.TabIndex = 562;
            this.dgvUnits.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUnits.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUnits.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvUnits.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvUnits.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvUnits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUnits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUnits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUnits.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvUnits.ThemeStyle.ReadOnly = true;
            this.dgvUnits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnits.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUnits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUnits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvUnits.ThemeStyle.RowsStyle.Height = 40;
            this.dgvUnits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvUnits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.dgvUnits);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(530, 90);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.Size = new System.Drawing.Size(230, 34);
            this.materialCard3.TabIndex = 580;
            // 
            // tbl_storesTableAdapter
            // 
            this.tbl_storesTableAdapter.ClearBeforeFill = true;
            // 
            // project_Po_SummaryTableAdapter
            // 
            this.project_Po_SummaryTableAdapter.ClearBeforeFill = true;
            // 
            // drywhordersBindingSource
            // 
            this.drywhordersBindingSource.DataMember = "dry_wh_orders";
            this.drywhordersBindingSource.DataSource = this.ultraMaverickDBDataSetBindingSource;
            // 
            // dry_wh_ordersTableAdapter
            // 
            this.dry_wh_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(875, 16);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(31, 35);
            this.lbltotalrecords.TabIndex = 608;
            this.lbltotalrecords.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(907, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 609;
            this.label2.Text = "Items";
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Depth = 0;
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFileName.Hint = "File Name";
            this.txtFileName.Location = new System.Drawing.Point(26, 13);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(1);
            this.txtFileName.MaxLength = 50;
            this.txtFileName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFileName.Multiline = false;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(652, 50);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.Text = "";
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // cbosheet
            // 
            this.cbosheet.Enabled = false;
            this.cbosheet.FormattingEnabled = true;
            this.cbosheet.ItemHeight = 23;
            this.cbosheet.Location = new System.Drawing.Point(25, 88);
            this.cbosheet.Margin = new System.Windows.Forms.Padding(1);
            this.cbosheet.Name = "cbosheet";
            this.cbosheet.PromptText = "Sheet";
            this.cbosheet.Size = new System.Drawing.Size(652, 29);
            this.cbosheet.TabIndex = 3;
            this.cbosheet.UseSelectable = true;
            this.cbosheet.SelectedIndexChanged += new System.EventHandler(this.cbosheet_SelectedIndexChanged);
            this.cbosheet.SelectionChangeCommitted += new System.EventHandler(this.cbosheet_SelectionChangeCommitted);
            // 
            // matBtnBrowse
            // 
            this.matBtnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnBrowse.Depth = 0;
            this.matBtnBrowse.DrawShadows = true;
            this.matBtnBrowse.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matBtnBrowse.HighEmphasis = true;
            this.matBtnBrowse.Icon = null;
            this.matBtnBrowse.Location = new System.Drawing.Point(776, 20);
            this.matBtnBrowse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            // matbtnUpload
            // 
            this.matbtnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnUpload.Depth = 0;
            this.matbtnUpload.DrawShadows = true;
            this.matbtnUpload.Enabled = false;
            this.matbtnUpload.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matbtnUpload.HighEmphasis = true;
            this.matbtnUpload.Icon = null;
            this.matbtnUpload.Location = new System.Drawing.Point(776, 81);
            this.matbtnUpload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnUpload.Name = "matbtnUpload";
            this.matbtnUpload.Size = new System.Drawing.Size(78, 36);
            this.matbtnUpload.TabIndex = 4;
            this.matbtnUpload.Text = "UPLOAD";
            this.matbtnUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnUpload.UseAccentColor = false;
            this.matbtnUpload.UseVisualStyleBackColor = true;
            this.matbtnUpload.Click += new System.EventHandler(this.matbtnUpload_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.lbltotalrecords);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.txtFileName);
            this.materialCard2.Controls.Add(this.cbosheet);
            this.materialCard2.Controls.Add(this.matBtnBrowse);
            this.materialCard2.Controls.Add(this.matbtnUpload);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(29, 569);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(963, 126);
            this.materialCard2.TabIndex = 579;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 610;
            this.label4.Text = "Sheet :";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "store_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "store_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "store_area";
            this.dataGridViewTextBoxColumn2.HeaderText = "store_area";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "store_code";
            this.dataGridViewTextBoxColumn3.HeaderText = "store_code";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 121;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "store_route";
            this.dataGridViewTextBoxColumn4.HeaderText = "store_route";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // FrmImportMrsOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Name = "FrmImportMrsOrders";
            this.Text = "Import MRS Orders";
            this.Load += new System.EventHandler(this.FrmImportMrsOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drywhordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drymaterialsBindingSource)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drywhordersBindingSource)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource drywhordersBindingSource1;
        private System.Windows.Forms.BindingSource ultraMaverickDBDataSetBindingSource;
        private UltraMaverickDBDataSet ultraMaverickDBDataSet;
        private System.Windows.Forms.BindingSource drymaterialsBindingSource;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRawMats;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUnits;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private UltraMaverickDBDataSetTableAdapters.tbl_storesTableAdapter tbl_storesTableAdapter;
        private UltraMaverickDBDataSetTableAdapters.Raw_Materials_DryTableAdapter project_Po_SummaryTableAdapter;
        private System.Windows.Forms.BindingSource drywhordersBindingSource;
        private UltraMaverickDBDataSetTableAdapters.dry_wh_ordersTableAdapter dry_wh_ordersTableAdapter;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtFileName;
        private MetroFramework.Controls.MetroComboBox cbosheet;
        private MaterialSkin.Controls.MaterialButton matBtnBrowse;
        private MaterialSkin.Controls.MaterialButton matbtnUpload;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordered;
        private System.Windows.Forms.DataGridViewTextBoxColumn fox;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNeeded;
        private System.Windows.Forms.DataGridViewTextBoxColumn storenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateorderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foxDataGridViewTextBoxColumn;
    }
}