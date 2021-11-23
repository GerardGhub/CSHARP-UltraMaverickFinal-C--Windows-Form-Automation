
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmManageActivePrimaryUnit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageActivePrimaryUnit));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvRawMats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.txtmatItemDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtPrimaryUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.txtmatSearchUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.lbltotalRecordsActiveUnits = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvActiveUnits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active_pu_primary_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active_pu_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active_pu_conversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_primary_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_description_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modified_at_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modified_by_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmatid = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddTool = new System.Windows.Forms.ToolStripButton();
            this.btnEditTool = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTool = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateTool = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTool = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUnits)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(434, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 480;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvRawMats
            // 
            this.dgvRawMats.AllowUserToAddRows = false;
            this.dgvRawMats.AllowUserToDeleteRows = false;
            this.dgvRawMats.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRawMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRawMats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRawMats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRawMats.ColumnHeadersHeight = 40;
            this.dgvRawMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_id,
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMats.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRawMats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMats.EnableHeadersVisualStyles = false;
            this.dgvRawMats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.Location = new System.Drawing.Point(5, 6);
            this.dgvRawMats.MultiSelect = false;
            this.dgvRawMats.Name = "dgvRawMats";
            this.dgvRawMats.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRawMats.RowHeadersVisible = false;
            this.dgvRawMats.RowHeadersWidth = 30;
            this.dgvRawMats.RowTemplate.DividerHeight = 5;
            this.dgvRawMats.RowTemplate.Height = 40;
            this.dgvRawMats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMats.Size = new System.Drawing.Size(366, 372);
            this.dgvRawMats.TabIndex = 4;
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
            this.dgvRawMats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.ReadOnly = true;
            this.dgvRawMats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.CurrentCellChanged += new System.EventHandler(this.dgvRawMats_CurrentCellChanged);
            this.dgvRawMats.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRawMats_RowPostPaint);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(16, 554);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(46, 40);
            this.lbltotalrecords.TabIndex = 474;
            this.lbltotalrecords.Text = "76";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(19, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 476;
            this.label2.Text = "Items";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvRawMats);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(16, 151);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(376, 384);
            this.materialCard2.TabIndex = 477;
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(16, 99);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(207, 50);
            this.mattxtSearch.TabIndex = 7;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            // 
            // txtmatItemDescription
            // 
            this.txtmatItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatItemDescription.Depth = 0;
            this.txtmatItemDescription.Enabled = false;
            this.txtmatItemDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatItemDescription.Hint = "Item Description";
            this.txtmatItemDescription.Location = new System.Drawing.Point(16, 44);
            this.txtmatItemDescription.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatItemDescription.MaxLength = 50;
            this.txtmatItemDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatItemDescription.Multiline = false;
            this.txtmatItemDescription.Name = "txtmatItemDescription";
            this.txtmatItemDescription.Size = new System.Drawing.Size(244, 50);
            this.txtmatItemDescription.TabIndex = 481;
            this.txtmatItemDescription.Text = "";
            this.txtmatItemDescription.Visible = false;
            // 
            // mattxtPrimaryUnit
            // 
            this.mattxtPrimaryUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mattxtPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtPrimaryUnit.Depth = 0;
            this.mattxtPrimaryUnit.Enabled = false;
            this.mattxtPrimaryUnit.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtPrimaryUnit.Hint = "Primary Unit";
            this.mattxtPrimaryUnit.Location = new System.Drawing.Point(412, 99);
            this.mattxtPrimaryUnit.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtPrimaryUnit.MaxLength = 50;
            this.mattxtPrimaryUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtPrimaryUnit.Multiline = false;
            this.mattxtPrimaryUnit.Name = "mattxtPrimaryUnit";
            this.mattxtPrimaryUnit.Size = new System.Drawing.Size(171, 50);
            this.mattxtPrimaryUnit.TabIndex = 486;
            this.mattxtPrimaryUnit.Text = "";
            // 
            // txtmatSearchUnit
            // 
            this.txtmatSearchUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatSearchUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatSearchUnit.Depth = 0;
            this.txtmatSearchUnit.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatSearchUnit.Hint = "Search";
            this.txtmatSearchUnit.Location = new System.Drawing.Point(1514, 101);
            this.txtmatSearchUnit.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatSearchUnit.MaxLength = 50;
            this.txtmatSearchUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatSearchUnit.Multiline = false;
            this.txtmatSearchUnit.Name = "txtmatSearchUnit";
            this.txtmatSearchUnit.Size = new System.Drawing.Size(135, 50);
            this.txtmatSearchUnit.TabIndex = 482;
            this.txtmatSearchUnit.Text = "";
            this.txtmatSearchUnit.TextChanged += new System.EventHandler(this.txtmatSearchUnit_TextChanged);
            // 
            // lbltotalRecordsActiveUnits
            // 
            this.lbltotalRecordsActiveUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalRecordsActiveUnits.AutoSize = true;
            this.lbltotalRecordsActiveUnits.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalRecordsActiveUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalRecordsActiveUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalRecordsActiveUnits.Location = new System.Drawing.Point(1603, 541);
            this.lbltotalRecordsActiveUnits.Name = "lbltotalRecordsActiveUnits";
            this.lbltotalRecordsActiveUnits.Size = new System.Drawing.Size(51, 36);
            this.lbltotalRecordsActiveUnits.TabIndex = 483;
            this.lbltotalRecordsActiveUnits.Text = "76";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(1606, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 484;
            this.label3.Text = "Items";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvActiveUnits);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(412, 151);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(395, 384);
            this.materialCard1.TabIndex = 485;
            // 
            // dgvActiveUnits
            // 
            this.dgvActiveUnits.AllowUserToAddRows = false;
            this.dgvActiveUnits.AllowUserToDeleteRows = false;
            this.dgvActiveUnits.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvActiveUnits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvActiveUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActiveUnits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvActiveUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActiveUnits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvActiveUnits.ColumnHeadersHeight = 40;
            this.dgvActiveUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.active_pu_primary_id,
            this.active_pu_description,
            this.active_pu_conversion,
            this.item_primary_id,
            this.item_item_code,
            this.item_description_units,
            this.created_at_units,
            this.created_by_units,
            this.modified_at_units,
            this.modified_by_units,
            this.is_active});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveUnits.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvActiveUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveUnits.EnableHeadersVisualStyles = false;
            this.dgvActiveUnits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvActiveUnits.Location = new System.Drawing.Point(5, 6);
            this.dgvActiveUnits.MultiSelect = false;
            this.dgvActiveUnits.Name = "dgvActiveUnits";
            this.dgvActiveUnits.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvActiveUnits.RowHeadersVisible = false;
            this.dgvActiveUnits.RowHeadersWidth = 102;
            this.dgvActiveUnits.RowTemplate.DividerHeight = 5;
            this.dgvActiveUnits.RowTemplate.Height = 40;
            this.dgvActiveUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveUnits.Size = new System.Drawing.Size(385, 372);
            this.dgvActiveUnits.TabIndex = 4;
            this.dgvActiveUnits.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvActiveUnits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveUnits.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveUnits.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveUnits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveUnits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveUnits.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvActiveUnits.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvActiveUnits.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvActiveUnits.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvActiveUnits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActiveUnits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvActiveUnits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvActiveUnits.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvActiveUnits.ThemeStyle.ReadOnly = true;
            this.dgvActiveUnits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveUnits.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvActiveUnits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActiveUnits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvActiveUnits.ThemeStyle.RowsStyle.Height = 40;
            this.dgvActiveUnits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvActiveUnits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvActiveUnits.CurrentCellChanged += new System.EventHandler(this.dgvActiveUnits_CurrentCellChanged);
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
            // active_pu_primary_id
            // 
            this.active_pu_primary_id.DataPropertyName = "active_pu_primary_id";
            this.active_pu_primary_id.HeaderText = "PrimaryUnitID";
            this.active_pu_primary_id.MinimumWidth = 12;
            this.active_pu_primary_id.Name = "active_pu_primary_id";
            this.active_pu_primary_id.ReadOnly = true;
            this.active_pu_primary_id.Width = 128;
            // 
            // active_pu_description
            // 
            this.active_pu_description.DataPropertyName = "active_pu_description";
            this.active_pu_description.FillWeight = 99.49239F;
            this.active_pu_description.HeaderText = "PRIMARY UNIT";
            this.active_pu_description.MinimumWidth = 12;
            this.active_pu_description.Name = "active_pu_description";
            this.active_pu_description.ReadOnly = true;
            this.active_pu_description.Width = 135;
            // 
            // active_pu_conversion
            // 
            this.active_pu_conversion.DataPropertyName = "active_pu_conversion";
            this.active_pu_conversion.FillWeight = 99.49239F;
            this.active_pu_conversion.HeaderText = "CONVERSION";
            this.active_pu_conversion.MinimumWidth = 12;
            this.active_pu_conversion.Name = "active_pu_conversion";
            this.active_pu_conversion.ReadOnly = true;
            this.active_pu_conversion.Width = 130;
            // 
            // item_primary_id
            // 
            this.item_primary_id.DataPropertyName = "item_primary_id";
            this.item_primary_id.FillWeight = 99.49239F;
            this.item_primary_id.HeaderText = "PrimaryItemID";
            this.item_primary_id.MinimumWidth = 12;
            this.item_primary_id.Name = "item_primary_id";
            this.item_primary_id.ReadOnly = true;
            this.item_primary_id.Width = 131;
            // 
            // item_item_code
            // 
            this.item_item_code.DataPropertyName = "item_item_code";
            this.item_item_code.FillWeight = 99.49239F;
            this.item_item_code.HeaderText = "Item Code";
            this.item_item_code.MinimumWidth = 12;
            this.item_item_code.Name = "item_item_code";
            this.item_item_code.ReadOnly = true;
            this.item_item_code.Width = 105;
            // 
            // item_description_units
            // 
            this.item_description_units.DataPropertyName = "item_description";
            this.item_description_units.FillWeight = 99.49239F;
            this.item_description_units.HeaderText = "Item Description";
            this.item_description_units.MinimumWidth = 12;
            this.item_description_units.Name = "item_description_units";
            this.item_description_units.ReadOnly = true;
            this.item_description_units.Width = 144;
            // 
            // created_at_units
            // 
            this.created_at_units.DataPropertyName = "created_at";
            this.created_at_units.HeaderText = "Created Date";
            this.created_at_units.MinimumWidth = 12;
            this.created_at_units.Name = "created_at_units";
            this.created_at_units.ReadOnly = true;
            this.created_at_units.Width = 124;
            // 
            // created_by_units
            // 
            this.created_by_units.DataPropertyName = "created_by";
            this.created_by_units.HeaderText = "Created By";
            this.created_by_units.MinimumWidth = 12;
            this.created_by_units.Name = "created_by_units";
            this.created_by_units.ReadOnly = true;
            this.created_by_units.Width = 108;
            // 
            // modified_at_units
            // 
            this.modified_at_units.DataPropertyName = "modified_at";
            this.modified_at_units.HeaderText = "Updated Date";
            this.modified_at_units.MinimumWidth = 12;
            this.modified_at_units.Name = "modified_at_units";
            this.modified_at_units.ReadOnly = true;
            this.modified_at_units.Width = 129;
            // 
            // modified_by_units
            // 
            this.modified_by_units.DataPropertyName = "modified_by";
            this.modified_by_units.HeaderText = "Updated By";
            this.modified_by_units.MinimumWidth = 12;
            this.modified_by_units.Name = "modified_by_units";
            this.modified_by_units.ReadOnly = true;
            this.modified_by_units.Width = 113;
            // 
            // is_active
            // 
            this.is_active.DataPropertyName = "is_active";
            this.is_active.HeaderText = "STATUS";
            this.is_active.MinimumWidth = 12;
            this.is_active.Name = "is_active";
            this.is_active.ReadOnly = true;
            this.is_active.Width = 83;
            // 
            // txtmatid
            // 
            this.txtmatid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatid.Depth = 0;
            this.txtmatid.Enabled = false;
            this.txtmatid.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatid.Hint = "Item ID";
            this.txtmatid.Location = new System.Drawing.Point(283, 44);
            this.txtmatid.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatid.MaxLength = 50;
            this.txtmatid.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatid.Multiline = false;
            this.txtmatid.Name = "txtmatid";
            this.txtmatid.Size = new System.Drawing.Size(62, 50);
            this.txtmatid.TabIndex = 487;
            this.txtmatid.Text = "";
            this.txtmatid.TextChanged += new System.EventHandler(this.txtmatid_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(412, 545);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 61);
            this.panel1.TabIndex = 566;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTool,
            this.btnEditTool,
            this.btnDeleteTool,
            this.btnUpdateTool,
            this.btnCancelTool});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(464, 61);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTool.Image")));
            this.btnAddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(75, 58);
            this.btnAddTool.Text = "&New";
            this.btnAddTool.Click += new System.EventHandler(this.btnAddTool_Click);
            // 
            // btnEditTool
            // 
            this.btnEditTool.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTool.Image")));
            this.btnEditTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(94, 58);
            this.btnEditTool.Text = "&Activate";
            this.btnEditTool.Click += new System.EventHandler(this.btnEditTool_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTool.Image")));
            this.btnDeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(94, 58);
            this.btnDeleteTool.Text = "&Remove";
            this.btnDeleteTool.Click += new System.EventHandler(this.btnDeleteTool_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTool.Image")));
            this.btnUpdateTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(75, 58);
            this.btnUpdateTool.Text = "&Save";
            this.btnUpdateTool.Visible = false;
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTool.Image")));
            this.btnCancelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(87, 58);
            this.btnCancelTool.Text = "&Cancel";
            this.btnCancelTool.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 162.4365F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ULTRAMAVERICK.Properties.Resources.ULTRA_MAVERICK;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 12;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // item_id
            // 
            this.item_id.DataPropertyName = "item_id";
            this.item_id.FillWeight = 40.60914F;
            this.item_id.Frozen = true;
            this.item_id.HeaderText = "ID";
            this.item_id.MinimumWidth = 12;
            this.item_id.Name = "item_id";
            this.item_id.ReadOnly = true;
            this.item_id.Width = 50;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.Frozen = true;
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 113;
            // 
            // Item_description
            // 
            this.Item_description.DataPropertyName = "Item_description";
            this.Item_description.FillWeight = 99.49239F;
            this.Item_description.HeaderText = "DESCRIPTION";
            this.Item_description.MinimumWidth = 12;
            this.Item_description.Name = "Item_description";
            this.Item_description.ReadOnly = true;
            this.Item_description.Width = 129;
            // 
            // item_class
            // 
            this.item_class.DataPropertyName = "item_class";
            this.item_class.FillWeight = 99.49239F;
            this.item_class.HeaderText = "ITEM CLASS";
            this.item_class.MinimumWidth = 12;
            this.item_class.Name = "item_class";
            this.item_class.ReadOnly = true;
            this.item_class.Width = 116;
            // 
            // major_category
            // 
            this.major_category.DataPropertyName = "major_category";
            this.major_category.FillWeight = 99.49239F;
            this.major_category.HeaderText = "Major Category";
            this.major_category.MinimumWidth = 12;
            this.major_category.Name = "major_category";
            this.major_category.ReadOnly = true;
            this.major_category.Width = 139;
            // 
            // sub_category
            // 
            this.sub_category.DataPropertyName = "sub_category";
            this.sub_category.FillWeight = 99.49239F;
            this.sub_category.HeaderText = "Sub Category";
            this.sub_category.MinimumWidth = 12;
            this.sub_category.Name = "sub_category";
            this.sub_category.ReadOnly = true;
            this.sub_category.Width = 127;
            // 
            // primary_unit
            // 
            this.primary_unit.DataPropertyName = "primary_unit";
            this.primary_unit.FillWeight = 99.49239F;
            this.primary_unit.HeaderText = "PRIMARY UNIT";
            this.primary_unit.MinimumWidth = 12;
            this.primary_unit.Name = "primary_unit";
            this.primary_unit.ReadOnly = true;
            this.primary_unit.Width = 135;
            // 
            // conversion
            // 
            this.conversion.DataPropertyName = "conversion";
            this.conversion.FillWeight = 99.49239F;
            this.conversion.HeaderText = "Conversion";
            this.conversion.MinimumWidth = 12;
            this.conversion.Name = "conversion";
            this.conversion.ReadOnly = true;
            this.conversion.Width = 110;
            // 
            // item_type
            // 
            this.item_type.DataPropertyName = "item_type";
            this.item_type.HeaderText = "Item Type";
            this.item_type.MinimumWidth = 12;
            this.item_type.Name = "item_type";
            this.item_type.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Created Date";
            this.created_at.MinimumWidth = 12;
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Width = 124;
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.HeaderText = "Created By";
            this.created_by.MinimumWidth = 12;
            this.created_by.Name = "created_by";
            this.created_by.ReadOnly = true;
            this.created_by.Width = 108;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Updated Date";
            this.updated_at.MinimumWidth = 12;
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Width = 129;
            // 
            // updated_by
            // 
            this.updated_by.DataPropertyName = "updated_by";
            this.updated_by.HeaderText = "Updated By";
            this.updated_by.MinimumWidth = 12;
            this.updated_by.Name = "updated_by";
            this.updated_by.ReadOnly = true;
            this.updated_by.Width = 113;
            // 
            // frmManageActivePrimaryUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtmatid);
            this.Controls.Add(this.mattxtPrimaryUnit);
            this.Controls.Add(this.txtmatSearchUnit);
            this.Controls.Add(this.lbltotalRecordsActiveUnits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtmatItemDescription);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmManageActivePrimaryUnit";
            this.Text = "Manage Conversion";
            this.Load += new System.EventHandler(this.frmManageActivePrimaryUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUnits)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRawMats;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private MaterialSkin.Controls.MaterialTextBox txtmatItemDescription;
        private MaterialSkin.Controls.MaterialTextBox mattxtPrimaryUnit;
        private MaterialSkin.Controls.MaterialTextBox txtmatSearchUnit;
        private System.Windows.Forms.Label lbltotalRecordsActiveUnits;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvActiveUnits;
        private MaterialSkin.Controls.MaterialTextBox txtmatid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddTool;
        private System.Windows.Forms.ToolStripButton btnEditTool;
        private System.Windows.Forms.ToolStripButton btnUpdateTool;
        private System.Windows.Forms.ToolStripButton btnDeleteTool;
        private System.Windows.Forms.ToolStripButton btnCancelTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn active_pu_primary_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn active_pu_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn active_pu_conversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_primary_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_description_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn modified_at_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn modified_by_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
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
    }
}