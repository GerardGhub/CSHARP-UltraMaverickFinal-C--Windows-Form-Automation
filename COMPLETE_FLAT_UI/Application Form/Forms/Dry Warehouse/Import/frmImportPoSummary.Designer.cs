﻿
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Import
{
    partial class frmImportPoSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvRawMats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pr_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_billed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drymaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraMaverickDBDataSet = new ULTRAMAVERICK.UltraMaverickDBDataSet();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matbtnUpload = new MaterialSkin.Controls.MaterialButton();
            this.txtFileName = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.cbosheet = new MetroFramework.Controls.MetroComboBox();
            this.project_Po_SummaryTableAdapter = new ULTRAMAVERICK.UltraMaverickDBDataSetTableAdapters.Raw_Materials_DryTableAdapter();
            this.ultraMaverickDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.dgvUnits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drymaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSet)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSetBindingSource)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
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
            this.materialCard1.Location = new System.Drawing.Point(30, 71);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(963, 462);
            this.materialCard1.TabIndex = 1;
            // 
            // dgvRawMats
            // 
            this.dgvRawMats.AllowUserToAddRows = false;
            this.dgvRawMats.AllowUserToDeleteRows = false;
            this.dgvRawMats.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvRawMats.AutoGenerateColumns = false;
            this.dgvRawMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRawMats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRawMats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvRawMats.ColumnHeadersHeight = 30;
            this.dgvRawMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_number,
            this.pr_date,
            this.po_number,
            this.po_date,
            this.item_code,
            this.item_description,
            this.qty_order,
            this.qty_delivered,
            this.qty_billed,
            this.qty_uom,
            this.unit_price,
            this.supplier,
            this.Active,
            this.PrimaryID,
            this.created_by,
            this.created_at});
            this.dgvRawMats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRawMats.DataSource = this.drymaterialsBindingSource;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMats.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvRawMats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMats.EnableHeadersVisualStyles = false;
            this.dgvRawMats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.Location = new System.Drawing.Point(5, 6);
            this.dgvRawMats.MultiSelect = false;
            this.dgvRawMats.Name = "dgvRawMats";
            this.dgvRawMats.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
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
            this.dgvRawMats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvRawMats.ThemeStyle.ReadOnly = true;
            this.dgvRawMats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvRawMats.CurrentCellChanged += new System.EventHandler(this.dgvRawMats_CurrentCellChanged);
            this.dgvRawMats.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRawMats_DataBindingComplete);
            this.dgvRawMats.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRawMats_RowPostPaint);
            // 
            // pr_number
            // 
            this.pr_number.DataPropertyName = "pr_number";
            this.pr_number.HeaderText = "PR NUMBER";
            this.pr_number.Name = "pr_number";
            this.pr_number.ReadOnly = true;
            this.pr_number.Width = 122;
            // 
            // pr_date
            // 
            this.pr_date.DataPropertyName = "pr_date";
            this.pr_date.HeaderText = "PR DATE";
            this.pr_date.Name = "pr_date";
            this.pr_date.ReadOnly = true;
            this.pr_date.Width = 97;
            // 
            // po_number
            // 
            this.po_number.DataPropertyName = "po_number";
            this.po_number.HeaderText = "PO NUMBER";
            this.po_number.Name = "po_number";
            this.po_number.ReadOnly = true;
            this.po_number.Width = 123;
            // 
            // po_date
            // 
            this.po_date.DataPropertyName = "po_date";
            this.po_date.HeaderText = "PO DATE";
            this.po_date.Name = "po_date";
            this.po_date.ReadOnly = true;
            this.po_date.Width = 98;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 116;
            // 
            // item_description
            // 
            this.item_description.DataPropertyName = "item_description";
            this.item_description.HeaderText = "ITEM DESCRIPTION";
            this.item_description.MinimumWidth = 12;
            this.item_description.Name = "item_description";
            this.item_description.ReadOnly = true;
            this.item_description.Width = 175;
            // 
            // qty_order
            // 
            this.qty_order.DataPropertyName = "qty_order";
            this.qty_order.HeaderText = "QTY ORDERED";
            this.qty_order.Name = "qty_order";
            this.qty_order.ReadOnly = true;
            this.qty_order.Width = 140;
            // 
            // qty_delivered
            // 
            this.qty_delivered.DataPropertyName = "qty_delivered";
            this.qty_delivered.HeaderText = "QTY DELIVERED";
            this.qty_delivered.Name = "qty_delivered";
            this.qty_delivered.ReadOnly = true;
            this.qty_delivered.Width = 151;
            // 
            // qty_billed
            // 
            this.qty_billed.DataPropertyName = "qty_billed";
            this.qty_billed.HeaderText = "QTY BILLED";
            this.qty_billed.Name = "qty_billed";
            this.qty_billed.ReadOnly = true;
            this.qty_billed.Width = 121;
            // 
            // qty_uom
            // 
            this.qty_uom.DataPropertyName = "qty_uom";
            this.qty_uom.HeaderText = "UOM";
            this.qty_uom.Name = "qty_uom";
            this.qty_uom.ReadOnly = true;
            this.qty_uom.Width = 69;
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "unit_price";
            this.unit_price.HeaderText = "UNIT PRICE";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 116;
            // 
            // supplier
            // 
            this.supplier.DataPropertyName = "supplier";
            this.supplier.HeaderText = "VENDOR NAME";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            this.supplier.Width = 144;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "ACTIVE";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 87;
            // 
            // PrimaryID
            // 
            this.PrimaryID.DataPropertyName = "PrimaryID";
            this.PrimaryID.HeaderText = "PrimaryID";
            this.PrimaryID.Name = "PrimaryID";
            this.PrimaryID.ReadOnly = true;
            this.PrimaryID.Width = 104;
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.HeaderText = "created_by";
            this.created_by.Name = "created_by";
            this.created_by.ReadOnly = true;
            this.created_by.Width = 110;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Width = 107;
            // 
            // drymaterialsBindingSource
            // 
            this.drymaterialsBindingSource.AllowNew = true;
            this.drymaterialsBindingSource.DataSource = this.ultraMaverickDBDataSet;
            this.drymaterialsBindingSource.Position = 0;
            // 
            // ultraMaverickDBDataSet
            // 
            this.ultraMaverickDBDataSet.DataSetName = "UltraMaverickDBDataSet";
            this.ultraMaverickDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.lbltotalrecords);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.matbtnUpload);
            this.materialCard2.Controls.Add(this.txtFileName);
            this.materialCard2.Controls.Add(this.matBtnBrowse);
            this.materialCard2.Controls.Add(this.cbosheet);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(29, 567);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(964, 116);
            this.materialCard2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 610;
            this.label4.Text = "Sheet :";
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(901, 21);
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
            this.label2.Location = new System.Drawing.Point(904, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 609;
            this.label2.Text = "Items";
            // 
            // matbtnUpload
            // 
            this.matbtnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matbtnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnUpload.Depth = 0;
            this.matbtnUpload.DrawShadows = true;
            this.matbtnUpload.HighEmphasis = true;
            this.matbtnUpload.Icon = null;
            this.matbtnUpload.Location = new System.Drawing.Point(782, 66);
            this.matbtnUpload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnUpload.Name = "matbtnUpload";
            this.matbtnUpload.Size = new System.Drawing.Size(78, 36);
            this.matbtnUpload.TabIndex = 4;
            this.matbtnUpload.Text = "UPLOAD";
            this.matbtnUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnUpload.UseAccentColor = false;
            this.matbtnUpload.UseVisualStyleBackColor = true;
            this.matbtnUpload.Visible = false;
            this.matbtnUpload.Click += new System.EventHandler(this.matbtnUpload_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Depth = 0;
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFileName.Hint = "File Name";
            this.txtFileName.Location = new System.Drawing.Point(20, 8);
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
            // matBtnBrowse
            // 
            this.matBtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matBtnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnBrowse.Depth = 0;
            this.matBtnBrowse.DrawShadows = true;
            this.matBtnBrowse.HighEmphasis = true;
            this.matBtnBrowse.Icon = null;
            this.matBtnBrowse.Location = new System.Drawing.Point(781, 15);
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
            // cbosheet
            // 
            this.cbosheet.Enabled = false;
            this.cbosheet.FormattingEnabled = true;
            this.cbosheet.ItemHeight = 23;
            this.cbosheet.Location = new System.Drawing.Point(22, 77);
            this.cbosheet.Margin = new System.Windows.Forms.Padding(1);
            this.cbosheet.Name = "cbosheet";
            this.cbosheet.PromptText = "Sheet";
            this.cbosheet.Size = new System.Drawing.Size(650, 29);
            this.cbosheet.TabIndex = 3;
            this.cbosheet.UseSelectable = true;
            this.cbosheet.SelectedIndexChanged += new System.EventHandler(this.cbosheet_SelectedIndexChanged);
            this.cbosheet.SelectionChangeCommitted += new System.EventHandler(this.cbosheet_SelectionChangeCommitted);
            // 
            // project_Po_SummaryTableAdapter
            // 
            this.project_Po_SummaryTableAdapter.ClearBeforeFill = true;
            // 
            // ultraMaverickDBDataSetBindingSource
            // 
            this.ultraMaverickDBDataSetBindingSource.DataSource = this.ultraMaverickDBDataSet;
            this.ultraMaverickDBDataSetBindingSource.Position = 0;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.dgvUnits);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(880, 15);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.Size = new System.Drawing.Size(10, 34);
            this.materialCard3.TabIndex = 564;
            this.materialCard3.Visible = false;
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dgvUnits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvUnits.ColumnHeadersHeight = 40;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnits.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnits.EnableHeadersVisualStyles = false;
            this.dgvUnits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUnits.Location = new System.Drawing.Point(5, 6);
            this.dgvUnits.MultiSelect = false;
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvUnits.RowHeadersVisible = false;
            this.dgvUnits.RowHeadersWidth = 102;
            this.dgvUnits.RowTemplate.DividerHeight = 5;
            this.dgvUnits.RowTemplate.Height = 40;
            this.dgvUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnits.Size = new System.Drawing.Size(0, 22);
            this.dgvUnits.TabIndex = 562;
            this.dgvUnits.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUnits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUnits.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUnits.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUnits.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUnits.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvUnits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvUnits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUnits.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvUnits.ThemeStyle.ReadOnly = true;
            this.dgvUnits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnits.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUnits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvUnits.ThemeStyle.RowsStyle.Height = 40;
            this.dgvUnits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvUnits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUnits.CurrentCellChanged += new System.EventHandler(this.dgvUnits_CurrentCellChanged);
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(217, 10);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(484, 50);
            this.mattxtSearch.TabIndex = 569;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            // 
            // frmImportPoSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 696);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmImportPoSummary";
            this.Text = "PO Summary";
            this.Load += new System.EventHandler(this.frmImportPoSummary_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drymaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSet)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraMaverickDBDataSetBindingSource)).EndInit();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRawMats;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton matbtnUpload;
        private MaterialSkin.Controls.MaterialTextBox txtFileName;
        private MaterialSkin.Controls.MaterialButton matBtnBrowse;
        private MetroFramework.Controls.MetroComboBox cbosheet;
        private System.Windows.Forms.BindingSource drymaterialsBindingSource;
        private UltraMaverickDBDataSet ultraMaverickDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private UltraMaverickDBDataSetTableAdapters.Raw_Materials_DryTableAdapter project_Po_SummaryTableAdapter;
        private System.Windows.Forms.BindingSource ultraMaverickDBDataSetBindingSource;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUnits;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn po_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn po_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_billed;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
    }
}