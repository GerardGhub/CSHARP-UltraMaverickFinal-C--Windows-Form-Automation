
namespace ULTRAMAVERICK.Forms.Users
{
    partial class frmSubMenusAvailableForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubMenusAvailableForms));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.MatTxtSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvChildForms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.menu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_form_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tagging_Relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddTool = new System.Windows.Forms.ToolStripButton();
            this.btnEditTool = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateTool = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTool = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTool = new System.Windows.Forms.ToolStripButton();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioNotActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildForms)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.MatTxtSearchBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(25, 71);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(970, 88);
            this.materialCard1.TabIndex = 553;
            // 
            // MatTxtSearchBox
            // 
            this.MatTxtSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MatTxtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtSearchBox.Depth = 0;
            this.MatTxtSearchBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtSearchBox.Hint = "Search";
            this.MatTxtSearchBox.Location = new System.Drawing.Point(734, 18);
            this.MatTxtSearchBox.Margin = new System.Windows.Forms.Padding(1);
            this.MatTxtSearchBox.MaxLength = 50;
            this.MatTxtSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtSearchBox.Multiline = false;
            this.MatTxtSearchBox.Name = "MatTxtSearchBox";
            this.MatTxtSearchBox.Size = new System.Drawing.Size(205, 50);
            this.MatTxtSearchBox.TabIndex = 668;
            this.MatTxtSearchBox.Text = "";
            this.MatTxtSearchBox.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvChildForms);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(25, 255);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(969, 458);
            this.materialCard2.TabIndex = 554;
            // 
            // dgvChildForms
            // 
            this.dgvChildForms.AllowUserToAddRows = false;
            this.dgvChildForms.AllowUserToDeleteRows = false;
            this.dgvChildForms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvChildForms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChildForms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChildForms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvChildForms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChildForms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChildForms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChildForms.ColumnHeadersHeight = 45;
            this.dgvChildForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChildForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu_id,
            this.count,
            this.menu_name,
            this.menu_form_name,
            this.created_at,
            this.created_by,
            this.updated_at,
            this.updated_by,
            this.Tagging_Relationship});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChildForms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChildForms.EnableHeadersVisualStyles = false;
            this.dgvChildForms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvChildForms.Location = new System.Drawing.Point(5, 6);
            this.dgvChildForms.MultiSelect = false;
            this.dgvChildForms.Name = "dgvChildForms";
            this.dgvChildForms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChildForms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChildForms.RowHeadersVisible = false;
            this.dgvChildForms.RowHeadersWidth = 102;
            this.dgvChildForms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChildForms.RowTemplate.DividerHeight = 5;
            this.dgvChildForms.RowTemplate.Height = 40;
            this.dgvChildForms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChildForms.Size = new System.Drawing.Size(959, 446);
            this.dgvChildForms.TabIndex = 577;
            this.dgvChildForms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvChildForms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChildForms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChildForms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChildForms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChildForms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChildForms.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvChildForms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvChildForms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvChildForms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvChildForms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChildForms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChildForms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChildForms.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvChildForms.ThemeStyle.ReadOnly = true;
            this.dgvChildForms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChildForms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvChildForms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChildForms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChildForms.ThemeStyle.RowsStyle.Height = 40;
            this.dgvChildForms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvChildForms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvChildForms.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvChildForms_CellFormatting);
            this.dgvChildForms.CurrentCellChanged += new System.EventHandler(this.dgvChildForms_CurrentCellChanged_1);
            // 
            // menu_id
            // 
            this.menu_id.DataPropertyName = "menu_id";
            this.menu_id.FillWeight = 40.60914F;
            this.menu_id.HeaderText = "ID";
            this.menu_id.MinimumWidth = 12;
            this.menu_id.Name = "menu_id";
            this.menu_id.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.FillWeight = 99.49239F;
            this.count.HeaderText = "PARENT MENU";
            this.count.MinimumWidth = 12;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // menu_name
            // 
            this.menu_name.DataPropertyName = "menu_name";
            this.menu_name.FillWeight = 99.49239F;
            this.menu_name.HeaderText = "CHILD MENU";
            this.menu_name.MinimumWidth = 12;
            this.menu_name.Name = "menu_name";
            this.menu_name.ReadOnly = true;
            // 
            // menu_form_name
            // 
            this.menu_form_name.DataPropertyName = "menu_form_name";
            this.menu_form_name.FillWeight = 99.49239F;
            this.menu_form_name.HeaderText = "FORM NAME";
            this.menu_form_name.MinimumWidth = 12;
            this.menu_form_name.Name = "menu_form_name";
            this.menu_form_name.ReadOnly = true;
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
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.FillWeight = 99.49239F;
            this.created_by.HeaderText = "CREATED BY";
            this.created_by.MinimumWidth = 12;
            this.created_by.Name = "created_by";
            this.created_by.ReadOnly = true;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.FillWeight = 99.49239F;
            this.updated_at.HeaderText = "UPDATED DATE";
            this.updated_at.MinimumWidth = 12;
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            // 
            // updated_by
            // 
            this.updated_by.DataPropertyName = "updated_by";
            this.updated_by.HeaderText = "UPDATED BY";
            this.updated_by.MinimumWidth = 12;
            this.updated_by.Name = "updated_by";
            this.updated_by.ReadOnly = true;
            // 
            // Tagging_Relationship
            // 
            this.Tagging_Relationship.DataPropertyName = "Tagging_Relationship";
            this.Tagging_Relationship.HeaderText = "RELATIONSHIP";
            this.Tagging_Relationship.MinimumWidth = 12;
            this.Tagging_Relationship.Name = "Tagging_Relationship";
            this.Tagging_Relationship.ReadOnly = true;
            this.Tagging_Relationship.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(23, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 40);
            this.panel1.TabIndex = 663;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTool,
            this.btnEditTool,
            this.btnUpdateTool,
            this.btnDeleteTool,
            this.btnCancelTool});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(329, 40);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTool.Image")));
            this.btnAddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(77, 37);
            this.btnAddTool.Text = "&New";
            this.btnAddTool.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnEditTool
            // 
            this.btnEditTool.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTool.Image")));
            this.btnEditTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(72, 37);
            this.btnEditTool.Text = "&Edit";
            this.btnEditTool.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTool.Image")));
            this.btnUpdateTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(79, 37);
            this.btnUpdateTool.Text = "&Save";
            this.btnUpdateTool.Visible = false;
            this.btnUpdateTool.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTool.Image")));
            this.btnDeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(97, 44);
            this.btnDeleteTool.Text = "&Remove";
            this.btnDeleteTool.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTool.Image")));
            this.btnCancelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(90, 44);
            this.btnCancelTool.Text = "&Cancel";
            this.btnCancelTool.Visible = false;
            this.btnCancelTool.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(912, 723);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(31, 35);
            this.lbltotalrecords.TabIndex = 664;
            this.lbltotalrecords.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(955, 737);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 665;
            this.label3.Text = "Items";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(472, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 666;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.matRadioActive);
            this.materialCard3.Controls.Add(this.matRadioNotActive);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(773, 176);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(221, 59);
            this.materialCard3.TabIndex = 667;
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
            // frmSubMenusAvailableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmSubMenusAvailableForms";
            this.Text = "Sub Menu";
            this.Load += new System.EventHandler(this.frmChildAvailableForms_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildForms)).EndInit();
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChildForms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddTool;
        private System.Windows.Forms.ToolStripButton btnEditTool;
        private System.Windows.Forms.ToolStripButton btnUpdateTool;
        private System.Windows.Forms.ToolStripButton btnDeleteTool;
        private System.Windows.Forms.ToolStripButton btnCancelTool;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_form_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tagging_Relationship;
        public System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox MatTxtSearchBox;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton matRadioActive;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotActive;
    }
}