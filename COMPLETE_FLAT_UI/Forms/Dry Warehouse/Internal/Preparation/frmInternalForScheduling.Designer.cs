
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    partial class frmInternalForScheduling
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
            this.groupColorCoding = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFindDataForAlocation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.matbtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.labelSelectedSum = new System.Windows.Forms.Label();
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialCheckboxSelectAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioForApproval = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioForAllocation = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.matcmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.matbtnPrint = new MaterialSkin.Controls.MaterialButton();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mrs_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_req_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_requested_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_ITEMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_requested_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewItems = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupColorCoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDataForAlocation)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupColorCoding
            // 
            this.groupColorCoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupColorCoding.BackColor = System.Drawing.SystemColors.Window;
            this.groupColorCoding.Controls.Add(this.panel2);
            this.groupColorCoding.Controls.Add(this.materialLabel6);
            this.groupColorCoding.Controls.Add(this.materialLabel4);
            this.groupColorCoding.Controls.Add(this.panel1);
            this.groupColorCoding.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupColorCoding.Location = new System.Drawing.Point(698, 691);
            this.groupColorCoding.Name = "groupColorCoding";
            this.groupColorCoding.Size = new System.Drawing.Size(394, 62);
            this.groupColorCoding.TabIndex = 651;
            this.groupColorCoding.TabStop = false;
            this.groupColorCoding.Text = "Color Coding Guide :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(329, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 29);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.Location = new System.Drawing.Point(202, 27);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(87, 14);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Abnormal Order";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel4.Location = new System.Drawing.Point(13, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 14);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "For Allocation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(131, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 29);
            this.panel1.TabIndex = 0;
            // 
            // dgvFindDataForAlocation
            // 
            this.dgvFindDataForAlocation.AllowUserToAddRows = false;
            this.dgvFindDataForAlocation.AllowUserToDeleteRows = false;
            this.dgvFindDataForAlocation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFindDataForAlocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFindDataForAlocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFindDataForAlocation.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgvFindDataForAlocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFindDataForAlocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindDataForAlocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFindDataForAlocation.ColumnHeadersHeight = 35;
            this.dgvFindDataForAlocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFindDataForAlocation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFindDataForAlocation.EnableHeadersVisualStyles = false;
            this.dgvFindDataForAlocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindDataForAlocation.Location = new System.Drawing.Point(337, 701);
            this.dgvFindDataForAlocation.MultiSelect = false;
            this.dgvFindDataForAlocation.Name = "dgvFindDataForAlocation";
            this.dgvFindDataForAlocation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindDataForAlocation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFindDataForAlocation.RowHeadersVisible = false;
            this.dgvFindDataForAlocation.RowHeadersWidth = 102;
            this.dgvFindDataForAlocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFindDataForAlocation.RowTemplate.DividerHeight = 5;
            this.dgvFindDataForAlocation.RowTemplate.Height = 40;
            this.dgvFindDataForAlocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindDataForAlocation.Size = new System.Drawing.Size(63, 34);
            this.dgvFindDataForAlocation.TabIndex = 657;
            this.dgvFindDataForAlocation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFindDataForAlocation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFindDataForAlocation.ThemeStyle.BackColor = System.Drawing.Color.Yellow;
            this.dgvFindDataForAlocation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFindDataForAlocation.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvFindDataForAlocation.ThemeStyle.ReadOnly = true;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.Height = 40;
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindDataForAlocation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFindDataForAlocation.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(432, 721);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 656;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // matbtnEdit
            // 
            this.matbtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnEdit.Depth = 0;
            this.matbtnEdit.DrawShadows = true;
            this.matbtnEdit.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matbtnEdit.HighEmphasis = true;
            this.matbtnEdit.Icon = null;
            this.matbtnEdit.Location = new System.Drawing.Point(130, 711);
            this.matbtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnEdit.Name = "matbtnEdit";
            this.matbtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matbtnEdit.TabIndex = 655;
            this.matbtnEdit.Text = "EDIT";
            this.matbtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnEdit.UseAccentColor = false;
            this.matbtnEdit.UseVisualStyleBackColor = true;
            this.matbtnEdit.Visible = false;
            // 
            // labelSelectedSum
            // 
            this.labelSelectedSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedSum.AutoSize = true;
            this.labelSelectedSum.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedSum.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.labelSelectedSum.Location = new System.Drawing.Point(961, 160);
            this.labelSelectedSum.Name = "labelSelectedSum";
            this.labelSelectedSum.Size = new System.Drawing.Size(31, 35);
            this.labelSelectedSum.TabIndex = 654;
            this.labelSelectedSum.Text = "0";
            this.labelSelectedSum.Visible = false;
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(1097, 711);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(31, 35);
            this.lbltotaldata.TabIndex = 652;
            this.lbltotaldata.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(1142, 725);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 653;
            this.label4.Text = "Items";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvStoreOrderApproval);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(22, 200);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(1158, 489);
            this.materialCard2.TabIndex = 645;
            // 
            // dgvStoreOrderApproval
            // 
            this.dgvStoreOrderApproval.AllowUserToAddRows = false;
            this.dgvStoreOrderApproval.AllowUserToDeleteRows = false;
            this.dgvStoreOrderApproval.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStoreOrderApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreOrderApproval.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrderApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStoreOrderApproval.ColumnHeadersHeight = 45;
            this.dgvStoreOrderApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.mrs_id,
            this.department_id,
            this.mrs_req_desc,
            this.mrs_requested_by,
            this.TOTAL_ITEMS,
            this.mrs_requested_date,
            this.ViewItems});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
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
            this.dgvStoreOrderApproval.Size = new System.Drawing.Size(1148, 477);
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
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStoreOrderApproval.ThemeStyle.ReadOnly = false;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvStoreOrderApproval.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreOrderApproval_CellContentClick);
            this.dgvStoreOrderApproval.CurrentCellChanged += new System.EventHandler(this.dgvStoreOrderApproval_CurrentCellChanged);
            // 
            // materialCheckboxSelectAll
            // 
            this.materialCheckboxSelectAll.AutoSize = true;
            this.materialCheckboxSelectAll.Depth = 0;
            this.materialCheckboxSelectAll.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCheckboxSelectAll.Location = new System.Drawing.Point(24, 164);
            this.materialCheckboxSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxSelectAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxSelectAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxSelectAll.Name = "materialCheckboxSelectAll";
            this.materialCheckboxSelectAll.Ripple = true;
            this.materialCheckboxSelectAll.Size = new System.Drawing.Size(100, 37);
            this.materialCheckboxSelectAll.TabIndex = 650;
            this.materialCheckboxSelectAll.Text = "Select All";
            this.materialCheckboxSelectAll.UseVisualStyleBackColor = true;
            this.materialCheckboxSelectAll.Visible = false;
            this.materialCheckboxSelectAll.CheckedChanged += new System.EventHandler(this.materialCheckboxSelectAll_CheckedChanged);
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.matRadioForApproval);
            this.materialCard3.Controls.Add(this.matRadioForAllocation);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(833, 12);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(320, 59);
            this.materialCard3.TabIndex = 645;
            // 
            // matRadioForApproval
            // 
            this.matRadioForApproval.AutoSize = true;
            this.matRadioForApproval.Depth = 0;
            this.matRadioForApproval.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRadioForApproval.Location = new System.Drawing.Point(10, 14);
            this.matRadioForApproval.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioForApproval.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioForApproval.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioForApproval.Name = "matRadioForApproval";
            this.matRadioForApproval.Ripple = true;
            this.matRadioForApproval.Size = new System.Drawing.Size(141, 37);
            this.matRadioForApproval.TabIndex = 597;
            this.matRadioForApproval.TabStop = true;
            this.matRadioForApproval.Text = "For Scheduling";
            this.matRadioForApproval.UseVisualStyleBackColor = true;
            this.matRadioForApproval.CheckedChanged += new System.EventHandler(this.matRadioForApproval_CheckedChanged);
            // 
            // matRadioForAllocation
            // 
            this.matRadioForAllocation.AutoSize = true;
            this.matRadioForAllocation.Depth = 0;
            this.matRadioForAllocation.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRadioForAllocation.Location = new System.Drawing.Point(166, 14);
            this.matRadioForAllocation.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioForAllocation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioForAllocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioForAllocation.Name = "matRadioForAllocation";
            this.matRadioForAllocation.Ripple = true;
            this.matRadioForAllocation.Size = new System.Drawing.Size(133, 37);
            this.matRadioForAllocation.TabIndex = 598;
            this.matRadioForAllocation.TabStop = true;
            this.matRadioForAllocation.Text = "For Allocation";
            this.matRadioForAllocation.UseVisualStyleBackColor = true;
            this.matRadioForAllocation.CheckedChanged += new System.EventHandler(this.matRadioForAllocation_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(19, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 578;
            this.materialLabel2.Text = "Category:";
            // 
            // matcmbCategory
            // 
            this.matcmbCategory.FormattingEnabled = true;
            this.matcmbCategory.ItemHeight = 23;
            this.matcmbCategory.Location = new System.Drawing.Point(18, 39);
            this.matcmbCategory.Name = "matcmbCategory";
            this.matcmbCategory.Size = new System.Drawing.Size(182, 29);
            this.matcmbCategory.TabIndex = 577;
            this.matcmbCategory.UseSelectable = true;
            this.matcmbCategory.SelectionChangeCommitted += new System.EventHandler(this.matcmbCategory_SelectionChangeCommitted);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.matcmbCategory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(22, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(1158, 90);
            this.materialCard1.TabIndex = 648;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(1019, 819);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 647;
            this.label3.Text = "Items";
            // 
            // matbtnPrint
            // 
            this.matbtnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnPrint.Depth = 0;
            this.matbtnPrint.DrawShadows = true;
            this.matbtnPrint.HighEmphasis = true;
            this.matbtnPrint.Icon = null;
            this.matbtnPrint.Location = new System.Drawing.Point(22, 711);
            this.matbtnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnPrint.Name = "matbtnPrint";
            this.matbtnPrint.Size = new System.Drawing.Size(87, 36);
            this.matbtnPrint.TabIndex = 649;
            this.matbtnPrint.Text = "APPROVE";
            this.matbtnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnPrint.UseAccentColor = false;
            this.matbtnPrint.UseVisualStyleBackColor = true;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(977, 803);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(51, 36);
            this.lbltotalrecords.TabIndex = 646;
            this.lbltotalrecords.Text = "76";
            // 
            // selected
            // 
            this.selected.DataPropertyName = "selected";
            this.selected.FalseValue = "FALSE";
            this.selected.HeaderText = "*";
            this.selected.MinimumWidth = 12;
            this.selected.Name = "selected";
            this.selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selected.TrueValue = "TRUE";
            this.selected.Visible = false;
            // 
            // mrs_id
            // 
            this.mrs_id.DataPropertyName = "mrs_id";
            this.mrs_id.FillWeight = 66.91177F;
            this.mrs_id.HeaderText = "MRS ID";
            this.mrs_id.MinimumWidth = 12;
            this.mrs_id.Name = "mrs_id";
            // 
            // department_id
            // 
            this.department_id.DataPropertyName = "department_id";
            this.department_id.FillWeight = 66.57212F;
            this.department_id.HeaderText = "DEPARTMENT";
            this.department_id.MinimumWidth = 12;
            this.department_id.Name = "department_id";
            // 
            // mrs_req_desc
            // 
            this.mrs_req_desc.DataPropertyName = "mrs_req_desc";
            this.mrs_req_desc.HeaderText = "DESCRIPTION";
            this.mrs_req_desc.Name = "mrs_req_desc";
            // 
            // mrs_requested_by
            // 
            this.mrs_requested_by.DataPropertyName = "mrs_requested_by";
            this.mrs_requested_by.FillWeight = 66.57212F;
            this.mrs_requested_by.HeaderText = "REQUESTED BY";
            this.mrs_requested_by.MinimumWidth = 12;
            this.mrs_requested_by.Name = "mrs_requested_by";
            // 
            // TOTAL_ITEMS
            // 
            this.TOTAL_ITEMS.DataPropertyName = "TOTAL_ITEMS";
            this.TOTAL_ITEMS.FillWeight = 66.57212F;
            this.TOTAL_ITEMS.HeaderText = "TOTAL ITEM";
            this.TOTAL_ITEMS.MinimumWidth = 12;
            this.TOTAL_ITEMS.Name = "TOTAL_ITEMS";
            // 
            // mrs_requested_date
            // 
            this.mrs_requested_date.DataPropertyName = "mrs_requested_date";
            this.mrs_requested_date.HeaderText = "DATE ORDERED";
            this.mrs_requested_date.MinimumWidth = 6;
            this.mrs_requested_date.Name = "mrs_requested_date";
            // 
            // ViewItems
            // 
            this.ViewItems.DataPropertyName = "ViewItems";
            this.ViewItems.HeaderText = "VIEW ITEMS";
            this.ViewItems.Name = "ViewItems";
            this.ViewItems.Text = "VIEW";
            this.ViewItems.UseColumnTextForButtonValue = true;
            // 
            // frmInternalForScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 768);
            this.Controls.Add(this.groupColorCoding);
            this.Controls.Add(this.dgvFindDataForAlocation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matbtnEdit);
            this.Controls.Add(this.labelSelectedSum);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCheckboxSelectAll);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matbtnPrint);
            this.Controls.Add(this.lbltotalrecords);
            this.Name = "frmInternalForScheduling";
            this.Text = "READY FOR SCHEDULING";
            this.Load += new System.EventHandler(this.frmInternalForScheduling_Load);
            this.groupColorCoding.ResumeLayout(false);
            this.groupColorCoding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDataForAlocation)).EndInit();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupColorCoding;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFindDataForAlocation;
        public System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton matbtnEdit;
        private System.Windows.Forms.Label labelSelectedSum;
        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxSelectAll;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton matRadioForApproval;
        private MaterialSkin.Controls.MaterialRadioButton matRadioForAllocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox matcmbCategory;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton matbtnPrint;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_req_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_requested_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_ITEMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_requested_date;
        private System.Windows.Forms.DataGridViewButtonColumn ViewItems;
    }
}