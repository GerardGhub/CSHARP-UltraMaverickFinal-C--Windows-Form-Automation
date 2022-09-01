
namespace ULTRAMAVERICK.Forms.Users
{
    partial class frmMajorAvailableForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMajorAvailableForms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.materialBtnNew = new System.Windows.Forms.ToolStripButton();
            this.matBtnEDit = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.DgvMajorMenu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.parent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_form_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_TOUCHED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioNotActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMajorMenu)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mattxtSearch);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(33, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(968, 80);
            this.materialCard1.TabIndex = 450;
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(747, 16);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(205, 50);
            this.mattxtSearch.TabIndex = 615;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(49, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 40);
            this.panel1.TabIndex = 581;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialBtnNew,
            this.matBtnEDit,
            this.matBtnDelete,
            this.matBtnSave,
            this.matBtnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(578, 40);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // materialBtnNew
            // 
            this.materialBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("materialBtnNew.Image")));
            this.materialBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.materialBtnNew.Name = "materialBtnNew";
            this.materialBtnNew.Size = new System.Drawing.Size(75, 37);
            this.materialBtnNew.Text = "&New";
            this.materialBtnNew.Click += new System.EventHandler(this.btnAddTool_Click_1);
            // 
            // matBtnEDit
            // 
            this.matBtnEDit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEDit.Image")));
            this.matBtnEDit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEDit.Name = "matBtnEDit";
            this.matBtnEDit.Size = new System.Drawing.Size(72, 37);
            this.matBtnEDit.Text = "&Edit";
            this.matBtnEDit.Click += new System.EventHandler(this.btnEditTool_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(94, 37);
            this.matBtnDelete.Text = "&InActive";
            this.matBtnDelete.Click += new System.EventHandler(this.btnDeleteTool_Click_1);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(77, 37);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.btnUpdateTool_Click_1);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(88, 37);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.btnCancelTool_Click_1);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(877, 729);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(31, 35);
            this.lbltotalrecords.TabIndex = 584;
            this.lbltotalrecords.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(929, 741);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 585;
            this.label3.Text = "Items";
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.DgvMajorMenu);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(33, 244);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.Size = new System.Drawing.Size(968, 479);
            this.materialCard3.TabIndex = 604;
            // 
            // DgvMajorMenu
            // 
            this.DgvMajorMenu.AllowUserToAddRows = false;
            this.DgvMajorMenu.AllowUserToDeleteRows = false;
            this.DgvMajorMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvMajorMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMajorMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMajorMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DgvMajorMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMajorMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMajorMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMajorMenu.ColumnHeadersHeight = 50;
            this.DgvMajorMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvMajorMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parent_id,
            this.parent_form_name,
            this.created_by,
            this.created_at,
            this.TOTAL_TOUCHED});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMajorMenu.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvMajorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMajorMenu.EnableHeadersVisualStyles = false;
            this.DgvMajorMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DgvMajorMenu.Location = new System.Drawing.Point(5, 6);
            this.DgvMajorMenu.MultiSelect = false;
            this.DgvMajorMenu.Name = "DgvMajorMenu";
            this.DgvMajorMenu.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMajorMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvMajorMenu.RowHeadersVisible = false;
            this.DgvMajorMenu.RowHeadersWidth = 102;
            this.DgvMajorMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvMajorMenu.RowTemplate.DividerHeight = 5;
            this.DgvMajorMenu.RowTemplate.Height = 40;
            this.DgvMajorMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMajorMenu.Size = new System.Drawing.Size(958, 467);
            this.DgvMajorMenu.TabIndex = 593;
            this.DgvMajorMenu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.DgvMajorMenu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvMajorMenu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvMajorMenu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvMajorMenu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvMajorMenu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvMajorMenu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DgvMajorMenu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DgvMajorMenu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DgvMajorMenu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.DgvMajorMenu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMajorMenu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvMajorMenu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvMajorMenu.ThemeStyle.HeaderStyle.Height = 50;
            this.DgvMajorMenu.ThemeStyle.ReadOnly = true;
            this.DgvMajorMenu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvMajorMenu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvMajorMenu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvMajorMenu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DgvMajorMenu.ThemeStyle.RowsStyle.Height = 40;
            this.DgvMajorMenu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.DgvMajorMenu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.DgvMajorMenu.CurrentCellChanged += new System.EventHandler(this.DgvMajorMenu_CurrentCellChanged);
            // 
            // parent_id
            // 
            this.parent_id.DataPropertyName = "parent_id";
            this.parent_id.FillWeight = 40.60914F;
            this.parent_id.HeaderText = "ID";
            this.parent_id.MinimumWidth = 12;
            this.parent_id.Name = "parent_id";
            this.parent_id.ReadOnly = true;
            // 
            // parent_form_name
            // 
            this.parent_form_name.DataPropertyName = "parent_form_name";
            this.parent_form_name.FillWeight = 99.49239F;
            this.parent_form_name.HeaderText = "MENU";
            this.parent_form_name.MinimumWidth = 12;
            this.parent_form_name.Name = "parent_form_name";
            this.parent_form_name.ReadOnly = true;
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.FillWeight = 99.49239F;
            this.created_by.HeaderText = "CREATED BY";
            this.created_by.MinimumWidth = 12;
            this.created_by.Name = "created_by";
            this.created_by.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.FillWeight = 99.49239F;
            this.created_at.HeaderText = "CREATED DATE";
            this.created_at.MinimumWidth = 12;
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // TOTAL_TOUCHED
            // 
            this.TOTAL_TOUCHED.DataPropertyName = "TOTAL_TOUCHED";
            this.TOTAL_TOUCHED.HeaderText = "TOTAL USED";
            this.TOTAL_TOUCHED.Name = "TOTAL_TOUCHED";
            this.TOTAL_TOUCHED.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(399, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 605;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.matRadioActive);
            this.materialCard2.Controls.Add(this.matRadioNotActive);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(780, 174);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(221, 59);
            this.materialCard2.TabIndex = 614;
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
            this.matRadioActive.CheckedChanged += new System.EventHandler(this.matRadioActive_CheckedChanged);
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
            // frmMajorAvailableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMajorAvailableForms";
            this.Text = "Major Menu";
            this.Load += new System.EventHandler(this.frmParentAvailableForms_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMajorMenu)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton materialBtnNew;
        private System.Windows.Forms.ToolStripButton matBtnEDit;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Guna.UI2.WinForms.Guna2DataGridView DgvMajorMenu;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_form_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_TOUCHED;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialRadioButton matRadioActive;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotActive;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
    }
}