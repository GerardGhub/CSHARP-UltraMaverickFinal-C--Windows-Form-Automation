
namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    partial class frmSubCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubCategory));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioNotExpirable = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioExpirable = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtSubCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvSubCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sub_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_category_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_expirable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.matBtnNew = new System.Windows.Forms.ToolStripButton();
            this.matBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.matRadioNotExpirable);
            this.materialCard1.Controls.Add(this.matRadioExpirable);
            this.materialCard1.Controls.Add(this.txtSubCategory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 77);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(993, 68);
            this.materialCard1.TabIndex = 608;
            // 
            // matRadioNotExpirable
            // 
            this.matRadioNotExpirable.AutoSize = true;
            this.matRadioNotExpirable.Depth = 0;
            this.matRadioNotExpirable.Enabled = false;
            this.matRadioNotExpirable.Location = new System.Drawing.Point(516, 23);
            this.matRadioNotExpirable.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioNotExpirable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioNotExpirable.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioNotExpirable.Name = "matRadioNotExpirable";
            this.matRadioNotExpirable.Ripple = true;
            this.matRadioNotExpirable.Size = new System.Drawing.Size(141, 37);
            this.matRadioNotExpirable.TabIndex = 580;
            this.matRadioNotExpirable.TabStop = true;
            this.matRadioNotExpirable.Text = "Non - Expirable";
            this.matRadioNotExpirable.UseVisualStyleBackColor = true;
            this.matRadioNotExpirable.CheckedChanged += new System.EventHandler(this.matRadioNotExpirable_CheckedChanged);
            // 
            // matRadioExpirable
            // 
            this.matRadioExpirable.AutoSize = true;
            this.matRadioExpirable.Depth = 0;
            this.matRadioExpirable.Enabled = false;
            this.matRadioExpirable.Location = new System.Drawing.Point(401, 23);
            this.matRadioExpirable.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioExpirable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioExpirable.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioExpirable.Name = "matRadioExpirable";
            this.matRadioExpirable.Ripple = true;
            this.matRadioExpirable.Size = new System.Drawing.Size(100, 37);
            this.matRadioExpirable.TabIndex = 579;
            this.matRadioExpirable.TabStop = true;
            this.matRadioExpirable.Text = "Expirable";
            this.matRadioExpirable.UseVisualStyleBackColor = true;
            this.matRadioExpirable.CheckedChanged += new System.EventHandler(this.matRadioExpirable_CheckedChanged);
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubCategory.Depth = 0;
            this.txtSubCategory.Enabled = false;
            this.txtSubCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSubCategory.Hint = "Category";
            this.txtSubCategory.Location = new System.Drawing.Point(14, 13);
            this.txtSubCategory.Margin = new System.Windows.Forms.Padding(1);
            this.txtSubCategory.MaxLength = 50;
            this.txtSubCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubCategory.Multiline = false;
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(314, 50);
            this.txtSubCategory.TabIndex = 0;
            this.txtSubCategory.Text = "";
            this.txtSubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubCategory_KeyPress);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvSubCategory);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 204);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(992, 518);
            this.materialCard2.TabIndex = 607;
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AllowUserToAddRows = false;
            this.dgvSubCategory.AllowUserToDeleteRows = false;
            this.dgvSubCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubCategory.ColumnHeadersHeight = 35;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sub_category_id,
            this.sub_category_desc,
            this.sc_added_at,
            this.sc_added_by,
            this.sc_updated_at,
            this.sc_updated_by,
            this.is_expirable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategory.EnableHeadersVisualStyles = false;
            this.dgvSubCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSubCategory.Location = new System.Drawing.Point(5, 6);
            this.dgvSubCategory.MultiSelect = false;
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubCategory.RowHeadersVisible = false;
            this.dgvSubCategory.RowHeadersWidth = 102;
            this.dgvSubCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubCategory.RowTemplate.DividerHeight = 5;
            this.dgvSubCategory.RowTemplate.Height = 40;
            this.dgvSubCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubCategory.Size = new System.Drawing.Size(982, 506);
            this.dgvSubCategory.TabIndex = 593;
            this.dgvSubCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSubCategory.ThemeStyle.ReadOnly = true;
            this.dgvSubCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSubCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubCategory.ThemeStyle.RowsStyle.Height = 40;
            this.dgvSubCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSubCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSubCategory.CurrentCellChanged += new System.EventHandler(this.dgvMajorCategory_CurrentCellChanged);
            // 
            // sub_category_id
            // 
            this.sub_category_id.DataPropertyName = "sub_category_id";
            this.sub_category_id.FillWeight = 40.60914F;
            this.sub_category_id.HeaderText = "ID";
            this.sub_category_id.MinimumWidth = 12;
            this.sub_category_id.Name = "sub_category_id";
            this.sub_category_id.ReadOnly = true;
            // 
            // sub_category_desc
            // 
            this.sub_category_desc.DataPropertyName = "sub_category_desc";
            this.sub_category_desc.FillWeight = 99.49239F;
            this.sub_category_desc.HeaderText = "ITEM CLASS";
            this.sub_category_desc.MinimumWidth = 12;
            this.sub_category_desc.Name = "sub_category_desc";
            this.sub_category_desc.ReadOnly = true;
            // 
            // sc_added_at
            // 
            this.sc_added_at.DataPropertyName = "sc_added_at";
            this.sc_added_at.FillWeight = 99.49239F;
            this.sc_added_at.HeaderText = "CREATED DATE";
            this.sc_added_at.MinimumWidth = 12;
            this.sc_added_at.Name = "sc_added_at";
            this.sc_added_at.ReadOnly = true;
            // 
            // sc_added_by
            // 
            this.sc_added_by.DataPropertyName = "sc_added_by";
            this.sc_added_by.FillWeight = 99.49239F;
            this.sc_added_by.HeaderText = "CREATED BY";
            this.sc_added_by.MinimumWidth = 12;
            this.sc_added_by.Name = "sc_added_by";
            this.sc_added_by.ReadOnly = true;
            // 
            // sc_updated_at
            // 
            this.sc_updated_at.DataPropertyName = "sc_updated_at";
            this.sc_updated_at.FillWeight = 99.49239F;
            this.sc_updated_at.HeaderText = "UPDATED DATE";
            this.sc_updated_at.MinimumWidth = 12;
            this.sc_updated_at.Name = "sc_updated_at";
            this.sc_updated_at.ReadOnly = true;
            // 
            // sc_updated_by
            // 
            this.sc_updated_by.DataPropertyName = "sc_updated_by";
            this.sc_updated_by.HeaderText = "UPDATED BY";
            this.sc_updated_by.MinimumWidth = 12;
            this.sc_updated_by.Name = "sc_updated_by";
            this.sc_updated_by.ReadOnly = true;
            // 
            // is_expirable
            // 
            this.is_expirable.DataPropertyName = "is_expirable";
            this.is_expirable.HeaderText = "EXPIRY STATUS";
            this.is_expirable.MinimumWidth = 12;
            this.is_expirable.Name = "is_expirable";
            this.is_expirable.ReadOnly = true;
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(511, 151);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(1);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(68, 20);
            this.metroFinalSaving.TabIndex = 618;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            this.metroFinalSaving.Click += new System.EventHandler(this.metroFinalSaving_Click);
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(602, 152);
            this.metroSave.Margin = new System.Windows.Forms.Padding(1);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(68, 20);
            this.metroSave.TabIndex = 617;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(24, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 36);
            this.panel1.TabIndex = 621;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.matBtnNew.Size = new System.Drawing.Size(75, 33);
            this.matBtnNew.Text = "&New";
            this.matBtnNew.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEdit.Image")));
            this.matBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(71, 33);
            this.matBtnEdit.Text = "&Edit";
            this.matBtnEdit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(94, 33);
            this.matBtnDelete.Text = "&Remove";
            this.matBtnDelete.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(75, 44);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(87, 44);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(906, 725);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(46, 40);
            this.lbltotalrecords.TabIndex = 622;
            this.lbltotalrecords.Text = "76";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(961, 739);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 623;
            this.label2.Text = "Items";
            // 
            // frmSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.metroSave);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmSubCategory";
            this.Sizable = false;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.frmSubCategory_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtSubCategory;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSubCategory;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MetroFramework.Controls.MetroButton metroSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton matBtnNew;
        private System.Windows.Forms.ToolStripButton matBtnEdit;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotExpirable;
        private MaterialSkin.Controls.MaterialRadioButton matRadioExpirable;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_category_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_expirable;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
    }
}