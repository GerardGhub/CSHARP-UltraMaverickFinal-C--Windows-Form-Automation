﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crV1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.metroCmbStoreCode = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.matcmbPackaging = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mattxtReceivingID = new MaterialSkin.Controls.MaterialTextBox();
            this.bunifuDateOrdered = new System.Windows.Forms.DateTimePicker();
            this.txtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matbtnPrint = new MaterialSkin.Controls.MaterialButton();
            this.dgvReprinting = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprinting)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crV1
            // 
            this.crV1.ActiveViewIndex = -1;
            this.crV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crV1.Location = new System.Drawing.Point(463, 551);
            this.crV1.Margin = new System.Windows.Forms.Padding(1);
            this.crV1.Name = "crV1";
            this.crV1.Size = new System.Drawing.Size(20, 63);
            this.crV1.TabIndex = 584;
            this.crV1.ToolPanelWidth = 75;
            this.crV1.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.metroComboBox3);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.metroComboBox2);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.metroCmbStoreCode);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.matcmbPackaging);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.mattxtReceivingID);
            this.materialCard1.Controls.Add(this.bunifuDateOrdered);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(1158, 97);
            this.materialCard1.TabIndex = 582;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(954, 30);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(124, 19);
            this.materialLabel5.TabIndex = 584;
            this.materialLabel5.Text = "Preparation Date:";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(953, 55);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(182, 29);
            this.metroComboBox3.TabIndex = 583;
            this.metroComboBox3.UseSelectable = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(635, 29);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 582;
            this.materialLabel4.Text = "Route:";
            this.materialLabel4.Visible = false;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(634, 54);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(182, 29);
            this.metroComboBox2.TabIndex = 581;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.Visible = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(428, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(78, 19);
            this.materialLabel3.TabIndex = 580;
            this.materialLabel3.Text = "Store Code";
            // 
            // metroCmbStoreCode
            // 
            this.metroCmbStoreCode.FormattingEnabled = true;
            this.metroCmbStoreCode.ItemHeight = 23;
            this.metroCmbStoreCode.Location = new System.Drawing.Point(427, 54);
            this.metroCmbStoreCode.Name = "metroCmbStoreCode";
            this.metroCmbStoreCode.Size = new System.Drawing.Size(182, 29);
            this.metroCmbStoreCode.TabIndex = 579;
            this.metroCmbStoreCode.UseSelectable = true;
            this.metroCmbStoreCode.SelectionChangeCommitted += new System.EventHandler(this.metroCmbStoreCode_SelectionChangeCommitted);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(221, 29);
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
            this.matcmbPackaging.Location = new System.Drawing.Point(220, 54);
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
            this.materialLabel1.Location = new System.Drawing.Point(6, 28);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 575;
            this.materialLabel1.Text = "Order Date:";
            // 
            // mattxtReceivingID
            // 
            this.mattxtReceivingID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtReceivingID.Depth = 0;
            this.mattxtReceivingID.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtReceivingID.Hint = "Receiving ID";
            this.mattxtReceivingID.Location = new System.Drawing.Point(520, -21);
            this.mattxtReceivingID.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtReceivingID.MaxLength = 50;
            this.mattxtReceivingID.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtReceivingID.Multiline = false;
            this.mattxtReceivingID.Name = "mattxtReceivingID";
            this.mattxtReceivingID.Size = new System.Drawing.Size(205, 50);
            this.mattxtReceivingID.TabIndex = 569;
            this.mattxtReceivingID.Text = "";
            this.mattxtReceivingID.Visible = false;
            // 
            // bunifuDateOrdered
            // 
            this.bunifuDateOrdered.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDateOrdered.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuDateOrdered.CustomFormat = "yyyy-M-dd";
            this.bunifuDateOrdered.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDateOrdered.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDateOrdered.Location = new System.Drawing.Point(8, 49);
            this.bunifuDateOrdered.Name = "bunifuDateOrdered";
            this.bunifuDateOrdered.Size = new System.Drawing.Size(170, 35);
            this.bunifuDateOrdered.TabIndex = 574;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemCode.Depth = 0;
            this.txtItemCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtItemCode.Hint = "Item Code";
            this.txtItemCode.Location = new System.Drawing.Point(950, 60);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(1);
            this.txtItemCode.MaxLength = 50;
            this.txtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItemCode.Multiline = false;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(205, 50);
            this.txtItemCode.TabIndex = 573;
            this.txtItemCode.Text = "";
            this.txtItemCode.Visible = false;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(975, 750);
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
            this.label3.Location = new System.Drawing.Point(1017, 766);
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
            this.matbtnPrint.Location = new System.Drawing.Point(20, 571);
            this.matbtnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnPrint.Name = "matbtnPrint";
            this.matbtnPrint.Size = new System.Drawing.Size(63, 36);
            this.matbtnPrint.TabIndex = 583;
            this.matbtnPrint.Text = "PRINT";
            this.matbtnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnPrint.UseAccentColor = false;
            this.matbtnPrint.UseVisualStyleBackColor = true;
            // 
            // dgvReprinting
            // 
            this.dgvReprinting.AllowUserToAddRows = false;
            this.dgvReprinting.AllowUserToDeleteRows = false;
            this.dgvReprinting.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReprinting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReprinting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReprinting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvReprinting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReprinting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReprinting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReprinting.ColumnHeadersHeight = 45;
            this.dgvReprinting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReprinting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReprinting.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReprinting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReprinting.EnableHeadersVisualStyles = false;
            this.dgvReprinting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvReprinting.Location = new System.Drawing.Point(5, 6);
            this.dgvReprinting.MultiSelect = false;
            this.dgvReprinting.Name = "dgvReprinting";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReprinting.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReprinting.RowHeadersVisible = false;
            this.dgvReprinting.RowHeadersWidth = 102;
            this.dgvReprinting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReprinting.RowTemplate.DividerHeight = 5;
            this.dgvReprinting.RowTemplate.Height = 40;
            this.dgvReprinting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReprinting.Size = new System.Drawing.Size(1148, 341);
            this.dgvReprinting.TabIndex = 594;
            this.dgvReprinting.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvReprinting.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReprinting.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReprinting.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReprinting.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReprinting.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReprinting.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvReprinting.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvReprinting.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvReprinting.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvReprinting.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReprinting.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReprinting.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReprinting.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvReprinting.ThemeStyle.ReadOnly = false;
            this.dgvReprinting.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReprinting.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvReprinting.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReprinting.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvReprinting.ThemeStyle.RowsStyle.Height = 40;
            this.dgvReprinting.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvReprinting.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.item_code.Name = "item_code";
            this.item_code.Width = 102;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "DESCRIPTION";
            this.description.Name = "description";
            this.description.Width = 127;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UOM";
            this.uom.Name = "uom";
            this.uom.Width = 68;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.Width = 61;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.Name = "date_added";
            this.date_added.Width = 112;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvReprinting);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(20, 200);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(1158, 353);
            this.materialCard2.TabIndex = 579;
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(1092, 574);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(46, 40);
            this.lbltotaldata.TabIndex = 639;
            this.lbltotaldata.Text = "76";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(1137, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 640;
            this.label4.Text = "Items";
            // 
            // frmStoreOrderforApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 644);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crV1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matbtnPrint);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.materialCard2);
            this.Name = "frmStoreOrderforApproval";
            this.Text = "Store Order For Approval";
            this.Load += new System.EventHandler(this.frmStoreOrderforApproval_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprinting)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crV1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox mattxtReceivingID;
        private System.Windows.Forms.DateTimePicker bunifuDateOrdered;
        private MaterialSkin.Controls.MaterialTextBox txtItemCode;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton matbtnPrint;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReprinting;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox matcmbPackaging;
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
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroComboBox metroCmbStoreCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
    }
}