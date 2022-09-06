
namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    partial class frmWarehouses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouses));
            this.dgvMajorCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.major_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_category_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.MatTxtSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.matBtnNew = new System.Windows.Forms.ToolStripButton();
            this.matBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioNotActive = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorCategory)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMajorCategory
            // 
            this.dgvMajorCategory.AllowUserToAddRows = false;
            this.dgvMajorCategory.AllowUserToDeleteRows = false;
            this.dgvMajorCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMajorCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMajorCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMajorCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMajorCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMajorCategory.ColumnHeadersHeight = 35;
            this.dgvMajorCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMajorCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.major_category_id,
            this.major_category_desc,
            this.mc_added_at,
            this.mc_added_by,
            this.mc_updated_at,
            this.mc_updated_by});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMajorCategory.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMajorCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMajorCategory.EnableHeadersVisualStyles = false;
            this.dgvMajorCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMajorCategory.Location = new System.Drawing.Point(5, 6);
            this.dgvMajorCategory.MultiSelect = false;
            this.dgvMajorCategory.Name = "dgvMajorCategory";
            this.dgvMajorCategory.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMajorCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMajorCategory.RowHeadersVisible = false;
            this.dgvMajorCategory.RowHeadersWidth = 102;
            this.dgvMajorCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMajorCategory.RowTemplate.DividerHeight = 5;
            this.dgvMajorCategory.RowTemplate.Height = 40;
            this.dgvMajorCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMajorCategory.Size = new System.Drawing.Size(984, 461);
            this.dgvMajorCategory.TabIndex = 593;
            this.dgvMajorCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMajorCategory.ThemeStyle.ReadOnly = true;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMajorCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvMajorCategory.CurrentCellChanged += new System.EventHandler(this.dgvMajorCategory_CurrentCellChanged);
            // 
            // major_category_id
            // 
            this.major_category_id.DataPropertyName = "major_category_id";
            this.major_category_id.FillWeight = 40.60914F;
            this.major_category_id.HeaderText = "ID";
            this.major_category_id.MinimumWidth = 12;
            this.major_category_id.Name = "major_category_id";
            this.major_category_id.ReadOnly = true;
            // 
            // major_category_desc
            // 
            this.major_category_desc.DataPropertyName = "major_category_desc";
            this.major_category_desc.FillWeight = 99.49239F;
            this.major_category_desc.HeaderText = "ITEM CLASS";
            this.major_category_desc.MinimumWidth = 12;
            this.major_category_desc.Name = "major_category_desc";
            this.major_category_desc.ReadOnly = true;
            // 
            // mc_added_at
            // 
            this.mc_added_at.DataPropertyName = "mc_added_at";
            this.mc_added_at.FillWeight = 99.49239F;
            this.mc_added_at.HeaderText = "CREATED DATE";
            this.mc_added_at.MinimumWidth = 12;
            this.mc_added_at.Name = "mc_added_at";
            this.mc_added_at.ReadOnly = true;
            // 
            // mc_added_by
            // 
            this.mc_added_by.DataPropertyName = "mc_added_by";
            this.mc_added_by.FillWeight = 99.49239F;
            this.mc_added_by.HeaderText = "CREATED BY";
            this.mc_added_by.MinimumWidth = 12;
            this.mc_added_by.Name = "mc_added_by";
            this.mc_added_by.ReadOnly = true;
            // 
            // mc_updated_at
            // 
            this.mc_updated_at.DataPropertyName = "mc_updated_at";
            this.mc_updated_at.FillWeight = 99.49239F;
            this.mc_updated_at.HeaderText = "UPDATED DATE";
            this.mc_updated_at.MinimumWidth = 12;
            this.mc_updated_at.Name = "mc_updated_at";
            this.mc_updated_at.ReadOnly = true;
            // 
            // mc_updated_by
            // 
            this.mc_updated_by.DataPropertyName = "mc_updated_by";
            this.mc_updated_by.HeaderText = "UPDATED BY";
            this.mc_updated_by.MinimumWidth = 12;
            this.mc_updated_by.Name = "mc_updated_by";
            this.mc_updated_by.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.MatTxtSearchBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 87);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(997, 73);
            this.materialCard1.TabIndex = 595;
            // 
            // MatTxtSearchBox
            // 
            this.MatTxtSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MatTxtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtSearchBox.Depth = 0;
            this.MatTxtSearchBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtSearchBox.Hint = "Search";
            this.MatTxtSearchBox.Location = new System.Drawing.Point(777, 14);
            this.MatTxtSearchBox.Margin = new System.Windows.Forms.Padding(1);
            this.MatTxtSearchBox.MaxLength = 50;
            this.MatTxtSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtSearchBox.Multiline = false;
            this.MatTxtSearchBox.Name = "MatTxtSearchBox";
            this.MatTxtSearchBox.Size = new System.Drawing.Size(205, 50);
            this.MatTxtSearchBox.TabIndex = 613;
            this.MatTxtSearchBox.Text = "";
            this.MatTxtSearchBox.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvMajorCategory);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(16, 249);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(994, 473);
            this.materialCard2.TabIndex = 594;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(15, 198);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 36);
            this.panel1.TabIndex = 608;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matBtnNew,
            this.matBtnEdit,
            this.matBtnDelete,
            this.matBtnSave,
            this.matBtnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(321, 36);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // matBtnNew
            // 
            this.matBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("matBtnNew.Image")));
            this.matBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(82, 33);
            this.matBtnNew.Text = "&New";
            this.matBtnNew.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEdit.Image")));
            this.matBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(78, 33);
            this.matBtnEdit.Text = "&Edit";
            this.matBtnEdit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(106, 33);
            this.matBtnDelete.Text = "&Remove";
            this.matBtnDelete.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(84, 44);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(98, 44);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(1108, 166);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(205, 50);
            this.mattxtSearch.TabIndex = 609;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.MattxtSearch_TextChanged);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(937, 725);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(31, 35);
            this.lbltotalrecords.TabIndex = 610;
            this.lbltotalrecords.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(974, 741);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 608;
            this.label2.Text = "Items";
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(507, 188);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(145, 20);
            this.TextBox1.TabIndex = 611;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.Visible = false;
            this.TextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.matRadioActive);
            this.materialCard3.Controls.Add(this.matRadioNotActive);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(789, 177);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(221, 59);
            this.materialCard3.TabIndex = 612;
            // 
            // matRadioActive
            // 
            this.matRadioActive.AutoSize = true;
            this.matRadioActive.Depth = 0;
            this.matRadioActive.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRadioActive.Location = new System.Drawing.Point(9, 14);
            this.matRadioActive.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioActive.Name = "matRadioActive";
            this.matRadioActive.Ripple = true;
            this.matRadioActive.Size = new System.Drawing.Size(78, 37);
            this.matRadioActive.TabIndex = 597;
            this.matRadioActive.TabStop = true;
            this.matRadioActive.Text = "Active";
            this.matRadioActive.UseVisualStyleBackColor = true;
            // 
            // matRadioNotActive
            // 
            this.matRadioNotActive.AutoSize = true;
            this.matRadioNotActive.Depth = 0;
            this.matRadioNotActive.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRadioNotActive.Location = new System.Drawing.Point(103, 14);
            this.matRadioNotActive.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioNotActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioNotActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioNotActive.Name = "matRadioNotActive";
            this.matRadioNotActive.Ripple = true;
            this.matRadioNotActive.Size = new System.Drawing.Size(103, 37);
            this.matRadioNotActive.TabIndex = 598;
            this.matRadioNotActive.TabStop = true;
            this.matRadioNotActive.Text = "In - Active";
            this.matRadioNotActive.UseVisualStyleBackColor = true;
            this.matRadioNotActive.CheckedChanged += new System.EventHandler(this.matRadioNotActive_CheckedChanged);
            // 
            // frmWarehouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialCard2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmWarehouses";
            this.Sizable = false;
            this.Text = "Warehouses";
            this.Load += new System.EventHandler(this.FrmMajorCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorCategory)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvMajorCategory;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton matBtnNew;
        private System.Windows.Forms.ToolStripButton matBtnEdit;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_category_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_updated_by;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TextBox1;
        private MaterialSkin.Controls.MaterialTextBox MatTxtSearchBox;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton matRadioActive;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotActive;
    }
}