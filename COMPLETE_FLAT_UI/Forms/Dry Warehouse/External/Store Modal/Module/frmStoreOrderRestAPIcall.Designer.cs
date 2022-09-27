
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmStoreOrderRestAPIcall
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvStoreOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matbtnUpload = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvStoreOrdersCutOff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_from_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_from_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.matlblTime = new MaterialSkin.Controls.MaterialLabel();
            this.date_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNeeded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrder)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrdersCutOff)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvStoreOrder);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(26, 135);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(973, 441);
            this.materialCard1.TabIndex = 575;
            // 
            // dgvStoreOrder
            // 
            this.dgvStoreOrder.AllowUserToAddRows = false;
            this.dgvStoreOrder.AllowUserToDeleteRows = false;
            this.dgvStoreOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoreOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStoreOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStoreOrder.ColumnHeadersHeight = 30;
            this.dgvStoreOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_ordered,
            this.id,
            this.store_code,
            this.store_name,
            this.route,
            this.area,
            this.category,
            this.item_code,
            this.description,
            this.uom,
            this.qty,
            this.dateNeeded});
            this.dgvStoreOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStoreOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreOrder.EnableHeadersVisualStyles = false;
            this.dgvStoreOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrder.Location = new System.Drawing.Point(5, 6);
            this.dgvStoreOrder.MultiSelect = false;
            this.dgvStoreOrder.Name = "dgvStoreOrder";
            this.dgvStoreOrder.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStoreOrder.RowHeadersVisible = false;
            this.dgvStoreOrder.RowHeadersWidth = 102;
            this.dgvStoreOrder.RowTemplate.DividerHeight = 5;
            this.dgvStoreOrder.RowTemplate.Height = 40;
            this.dgvStoreOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreOrder.Size = new System.Drawing.Size(963, 429);
            this.dgvStoreOrder.TabIndex = 5;
            this.dgvStoreOrder.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvStoreOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStoreOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStoreOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrder.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvStoreOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvStoreOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrder.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvStoreOrder.ThemeStyle.ReadOnly = true;
            this.dgvStoreOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrder.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStoreOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvStoreOrder.CurrentCellChanged += new System.EventHandler(this.dgvStoreOrder_CurrentCellChanged);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(40, 88);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(31, 35);
            this.lbltotalrecords.TabIndex = 610;
            this.lbltotalrecords.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(110, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 611;
            this.label2.Text = "Items";
            // 
            // matbtnUpload
            // 
            this.matbtnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matbtnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnUpload.Depth = 0;
            this.matbtnUpload.DrawShadows = true;
            this.matbtnUpload.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matbtnUpload.HighEmphasis = true;
            this.matbtnUpload.Icon = null;
            this.matbtnUpload.Location = new System.Drawing.Point(940, 84);
            this.matbtnUpload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnUpload.Name = "matbtnUpload";
            this.matbtnUpload.Size = new System.Drawing.Size(59, 36);
            this.matbtnUpload.TabIndex = 612;
            this.matbtnUpload.Text = "SYNC";
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
            this.materialCard2.Controls.Add(this.dgvStoreOrdersCutOff);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(26, 622);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(973, 123);
            this.materialCard2.TabIndex = 613;
            // 
            // dgvStoreOrdersCutOff
            // 
            this.dgvStoreOrdersCutOff.AllowUserToAddRows = false;
            this.dgvStoreOrdersCutOff.AllowUserToDeleteRows = false;
            this.dgvStoreOrdersCutOff.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrdersCutOff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStoreOrdersCutOff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreOrdersCutOff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrdersCutOff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrdersCutOff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrdersCutOff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStoreOrdersCutOff.ColumnHeadersHeight = 30;
            this.dgvStoreOrdersCutOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrdersCutOff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.time_from_desc,
            this.time_from_to,
            this.is_active,
            this.added_by,
            this.date_added,
            this.updated_by,
            this.updated_at});
            this.dgvStoreOrdersCutOff.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrdersCutOff.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStoreOrdersCutOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreOrdersCutOff.EnableHeadersVisualStyles = false;
            this.dgvStoreOrdersCutOff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrdersCutOff.Location = new System.Drawing.Point(14, 14);
            this.dgvStoreOrdersCutOff.MultiSelect = false;
            this.dgvStoreOrdersCutOff.Name = "dgvStoreOrdersCutOff";
            this.dgvStoreOrdersCutOff.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrdersCutOff.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStoreOrdersCutOff.RowHeadersVisible = false;
            this.dgvStoreOrdersCutOff.RowHeadersWidth = 102;
            this.dgvStoreOrdersCutOff.RowTemplate.DividerHeight = 5;
            this.dgvStoreOrdersCutOff.RowTemplate.Height = 40;
            this.dgvStoreOrdersCutOff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreOrdersCutOff.Size = new System.Drawing.Size(945, 95);
            this.dgvStoreOrdersCutOff.TabIndex = 6;
            this.dgvStoreOrdersCutOff.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvStoreOrdersCutOff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrdersCutOff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStoreOrdersCutOff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrdersCutOff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStoreOrdersCutOff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrdersCutOff.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrdersCutOff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrdersCutOff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvStoreOrdersCutOff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvStoreOrdersCutOff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrdersCutOff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrdersCutOff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrdersCutOff.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvStoreOrdersCutOff.ThemeStyle.ReadOnly = true;
            this.dgvStoreOrdersCutOff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrdersCutOff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrdersCutOff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrdersCutOff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrdersCutOff.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrdersCutOff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStoreOrdersCutOff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvStoreOrdersCutOff.CurrentCellChanged += new System.EventHandler(this.dgvStoreOrdersCutOff_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // time_from_desc
            // 
            this.time_from_desc.DataPropertyName = "time_from_desc";
            this.time_from_desc.FillWeight = 59.93546F;
            this.time_from_desc.HeaderText = "FROM";
            this.time_from_desc.MinimumWidth = 12;
            this.time_from_desc.Name = "time_from_desc";
            this.time_from_desc.ReadOnly = true;
            // 
            // time_from_to
            // 
            this.time_from_to.DataPropertyName = "time_from_to";
            this.time_from_to.HeaderText = "TO";
            this.time_from_to.Name = "time_from_to";
            this.time_from_to.ReadOnly = true;
            // 
            // is_active
            // 
            this.is_active.DataPropertyName = "is_active";
            this.is_active.HeaderText = "STATUS";
            this.is_active.Name = "is_active";
            this.is_active.ReadOnly = true;
            // 
            // added_by
            // 
            this.added_by.DataPropertyName = "added_by";
            this.added_by.HeaderText = "ADDED BY";
            this.added_by.Name = "added_by";
            this.added_by.ReadOnly = true;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // updated_by
            // 
            this.updated_by.DataPropertyName = "updated_by";
            this.updated_by.HeaderText = "UPDATED BY";
            this.updated_by.Name = "updated_by";
            this.updated_by.ReadOnly = true;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "UPDATED DATE";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(30, 589);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(195, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Consolidated Order Cut-Off ";
            // 
            // matlblTime
            // 
            this.matlblTime.AutoSize = true;
            this.matlblTime.Depth = 0;
            this.matlblTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matlblTime.Location = new System.Drawing.Point(716, 589);
            this.matlblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.matlblTime.Name = "matlblTime";
            this.matlblTime.Size = new System.Drawing.Size(45, 19);
            this.matlblTime.TabIndex = 614;
            this.matlblTime.Text = "TIme :";
            // 
            // date_ordered
            // 
            this.date_ordered.DataPropertyName = "dateOrdered";
            this.date_ordered.Frozen = true;
            this.date_ordered.HeaderText = "ORDER DATE";
            this.date_ordered.MinimumWidth = 12;
            this.date_ordered.Name = "date_ordered";
            this.date_ordered.ReadOnly = true;
            this.date_ordered.Width = 128;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 49;
            // 
            // store_code
            // 
            this.store_code.DataPropertyName = "fox";
            this.store_code.Frozen = true;
            this.store_code.HeaderText = "STORE CODE";
            this.store_code.Name = "store_code";
            this.store_code.ReadOnly = true;
            this.store_code.Width = 129;
            // 
            // store_name
            // 
            this.store_name.DataPropertyName = "name";
            this.store_name.HeaderText = "STORE";
            this.store_name.MinimumWidth = 12;
            this.store_name.Name = "store_name";
            this.store_name.ReadOnly = true;
            this.store_name.Width = 84;
            // 
            // route
            // 
            this.route.DataPropertyName = "route";
            this.route.HeaderText = "ROUTE";
            this.route.Name = "route";
            this.route.ReadOnly = true;
            this.route.Width = 84;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "AREA";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Width = 73;
            // 
            // category
            // 
            this.category.DataPropertyName = "meattype";
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 114;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "productcode";
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 116;
            // 
            // description
            // 
            this.description.DataPropertyName = "products";
            this.description.HeaderText = "DESCRIPTION";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 134;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UOM";
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            this.uom.Width = 69;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QUANTITY ORDER";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 165;
            // 
            // dateNeeded
            // 
            this.dateNeeded.DataPropertyName = "dateNeeded";
            this.dateNeeded.HeaderText = "DATE NEEDED";
            this.dateNeeded.Name = "dateNeeded";
            this.dateNeeded.ReadOnly = true;
            this.dateNeeded.Width = 137;
            // 
            // frmStoreOrderRestAPIcall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.matlblTime);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.matbtnUpload);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.Name = "frmStoreOrderRestAPIcall";
            this.Text = "Store Order REST-API";
            this.Load += new System.EventHandler(this.frmStoreOrderRestAPIcall_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrder)).EndInit();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrdersCutOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrder;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton matbtnUpload;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrdersCutOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_from_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_from_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private MaterialSkin.Controls.MaterialLabel matlblTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordered;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn route;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNeeded;
    }
}