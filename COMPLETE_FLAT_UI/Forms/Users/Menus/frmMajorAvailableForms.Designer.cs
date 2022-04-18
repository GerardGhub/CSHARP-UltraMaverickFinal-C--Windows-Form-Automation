
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMajorAvailableForms));
            this.lstParentMenu = new System.Windows.Forms.ListBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtModifiedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.label19 = new System.Windows.Forms.Label();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartmentMaterial = new System.Windows.Forms.ComboBox();
            this.txtMaterialDepartment = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaterialMenu = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvUserRights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.user_rights_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_rights_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matBtnNext = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.materialBtnNew = new System.Windows.Forms.ToolStripButton();
            this.matBtnEDit = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstParentMenu
            // 
            this.lstParentMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstParentMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lstParentMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstParentMenu.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParentMenu.FormattingEnabled = true;
            this.lstParentMenu.ItemHeight = 18;
            this.lstParentMenu.Location = new System.Drawing.Point(8, 87);
            this.lstParentMenu.Name = "lstParentMenu";
            this.lstParentMenu.Size = new System.Drawing.Size(927, 324);
            this.lstParentMenu.TabIndex = 152;
            this.lstParentMenu.Click += new System.EventHandler(this.lstParentMenu_Click);
            this.lstParentMenu.SelectedIndexChanged += new System.EventHandler(this.lstParentMenu_SelectedIndexChanged);
            this.lstParentMenu.SelectedValueChanged += new System.EventHandler(this.lstParentMenu_SelectedValueChanged);
            this.lstParentMenu.CursorChanged += new System.EventHandler(this.lstParentMenu_CursorChanged);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.Color.White;
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.txtCreatedBy.Location = new System.Drawing.Point(1036, 409);
            this.txtCreatedBy.MaxLength = 100;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(168, 15);
            this.txtCreatedBy.TabIndex = 179;
            this.txtCreatedBy.Visible = false;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.BackColor = System.Drawing.Color.White;
            this.txtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifiedBy.ForeColor = System.Drawing.Color.Black;
            this.txtModifiedBy.Location = new System.Drawing.Point(1036, 443);
            this.txtModifiedBy.MaxLength = 100;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(167, 15);
            this.txtModifiedBy.TabIndex = 178;
            this.txtModifiedBy.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(657, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 175;
            this.label5.Text = "Modified_At :";
            this.label5.Visible = false;
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(729, 376);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(1);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(68, 20);
            this.metroButtonDelete.TabIndex = 448;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Visible = false;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(664, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 17);
            this.label19.TabIndex = 168;
            this.label19.Text = "Created At :";
            this.label19.Visible = false;
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AllowUserToResizeColumns = false;
            this.dgv_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_table.ColumnHeadersHeight = 45;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_table.EnableHeadersVisualStyles = false;
            this.dgv_table.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_table.Location = new System.Drawing.Point(575, 16);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(100, 45);
            this.dgv_table.TabIndex = 446;
            this.dgv_table.Visible = false;
            this.dgv_table.CurrentCellChanged += new System.EventHandler(this.dgv_table_CurrentCellChanged);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(848, 376);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(1);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(68, 20);
            this.metroButtonSave.TabIndex = 445;
            this.metroButtonSave.Text = "Add";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Visible = false;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.cboDepartmentMaterial);
            this.materialCard1.Controls.Add(this.txtMaterialDepartment);
            this.materialCard1.Controls.Add(this.txtMaterialMenu);
            this.materialCard1.Controls.Add(this.dgv_table);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(944, 104);
            this.materialCard1.TabIndex = 450;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(733, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 599;
            this.label1.Text = "Department:";
            // 
            // cboDepartmentMaterial
            // 
            this.cboDepartmentMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDepartmentMaterial.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartmentMaterial.FormattingEnabled = true;
            this.cboDepartmentMaterial.Location = new System.Drawing.Point(736, 36);
            this.cboDepartmentMaterial.Margin = new System.Windows.Forms.Padding(1);
            this.cboDepartmentMaterial.Name = "cboDepartmentMaterial";
            this.cboDepartmentMaterial.Size = new System.Drawing.Size(200, 21);
            this.cboDepartmentMaterial.TabIndex = 587;
            this.cboDepartmentMaterial.Visible = false;
            this.cboDepartmentMaterial.SelectionChangeCommitted += new System.EventHandler(this.cboDepartmentMaterial_SelectionChangeCommitted_1);
            // 
            // txtMaterialDepartment
            // 
            this.txtMaterialDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterialDepartment.Depth = 0;
            this.txtMaterialDepartment.Enabled = false;
            this.txtMaterialDepartment.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaterialDepartment.Hint = "Department";
            this.txtMaterialDepartment.Location = new System.Drawing.Point(736, 32);
            this.txtMaterialDepartment.MaxLength = 50;
            this.txtMaterialDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaterialDepartment.Multiline = false;
            this.txtMaterialDepartment.Name = "txtMaterialDepartment";
            this.txtMaterialDepartment.Size = new System.Drawing.Size(198, 50);
            this.txtMaterialDepartment.TabIndex = 586;
            this.txtMaterialDepartment.Text = "";
            // 
            // txtMaterialMenu
            // 
            this.txtMaterialMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterialMenu.Depth = 0;
            this.txtMaterialMenu.Enabled = false;
            this.txtMaterialMenu.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaterialMenu.Hint = "Menu";
            this.txtMaterialMenu.Location = new System.Drawing.Point(15, 32);
            this.txtMaterialMenu.MaxLength = 50;
            this.txtMaterialMenu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaterialMenu.Multiline = false;
            this.txtMaterialMenu.Name = "txtMaterialMenu";
            this.txtMaterialMenu.Size = new System.Drawing.Size(260, 50);
            this.txtMaterialMenu.TabIndex = 583;
            this.txtMaterialMenu.Text = "";
            this.txtMaterialMenu.TextChanged += new System.EventHandler(this.txtMaterialMenu_TextChanged);
            this.txtMaterialMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterialMenu_KeyPress);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lstParentMenu);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(40, 273);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(944, 450);
            this.materialCard2.TabIndex = 576;
            // 
            // dgvUserRights
            // 
            this.dgvUserRights.AllowUserToAddRows = false;
            this.dgvUserRights.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvUserRights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserRights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUserRights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserRights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserRights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserRights.ColumnHeadersHeight = 35;
            this.dgvUserRights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_rights_id,
            this.user_rights_name});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserRights.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserRights.EnableHeadersVisualStyles = false;
            this.dgvUserRights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.Location = new System.Drawing.Point(643, 28);
            this.dgvUserRights.Name = "dgvUserRights";
            this.dgvUserRights.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRights.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUserRights.RowHeadersVisible = false;
            this.dgvUserRights.RowHeadersWidth = 102;
            this.dgvUserRights.RowTemplate.DividerHeight = 5;
            this.dgvUserRights.RowTemplate.Height = 40;
            this.dgvUserRights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserRights.Size = new System.Drawing.Size(72, 32);
            this.dgvUserRights.TabIndex = 578;
            this.dgvUserRights.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUserRights.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUserRights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvUserRights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvUserRights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUserRights.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvUserRights.ThemeStyle.ReadOnly = true;
            this.dgvUserRights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserRights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserRights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUserRights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvUserRights.ThemeStyle.RowsStyle.Height = 40;
            this.dgvUserRights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvUserRights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserRights.Visible = false;
            this.dgvUserRights.CurrentCellChanged += new System.EventHandler(this.dgvUserRights_CurrentCellChanged);
            // 
            // user_rights_id
            // 
            this.user_rights_id.DataPropertyName = "user_rights_id";
            this.user_rights_id.FillWeight = 99.49239F;
            this.user_rights_id.HeaderText = "ID";
            this.user_rights_id.MinimumWidth = 12;
            this.user_rights_id.Name = "user_rights_id";
            this.user_rights_id.ReadOnly = true;
            this.user_rights_id.Width = 41;
            // 
            // user_rights_name
            // 
            this.user_rights_name.DataPropertyName = "user_rights_name";
            this.user_rights_name.FillWeight = 99.49239F;
            this.user_rights_name.HeaderText = "User Rights";
            this.user_rights_name.MinimumWidth = 12;
            this.user_rights_name.Name = "user_rights_name";
            this.user_rights_name.ReadOnly = true;
            this.user_rights_name.Width = 82;
            // 
            // matBtnNext
            // 
            this.matBtnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnNext.Depth = 0;
            this.matBtnNext.DrawShadows = true;
            this.matBtnNext.HighEmphasis = true;
            this.matBtnNext.Icon = null;
            this.matBtnNext.Location = new System.Drawing.Point(815, 39);
            this.matBtnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnNext.Name = "matBtnNext";
            this.matBtnNext.Size = new System.Drawing.Size(58, 36);
            this.matBtnNext.TabIndex = 579;
            this.matBtnNext.Text = "NEXT";
            this.matBtnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnNext.UseAccentColor = false;
            this.matBtnNext.UseVisualStyleBackColor = true;
            this.matBtnNext.Visible = false;
            this.matBtnNext.Click += new System.EventHandler(this.matBtnNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(49, 227);
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
            this.matBtnDelete.Text = "&Remove";
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
            // frmMajorAvailableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.matBtnNext);
            this.Controls.Add(this.dgvUserRights);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMajorAvailableForms";
            this.Text = "Major Menu";
            this.Load += new System.EventHandler(this.frmParentAvailableForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstParentMenu;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.TextBox txtModifiedBy;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgv_table;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtMaterialMenu;
        private MaterialSkin.Controls.MaterialTextBox txtMaterialDepartment;
        private System.Windows.Forms.ComboBox cboDepartmentMaterial;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserRights;
        private MaterialSkin.Controls.MaterialButton matBtnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton materialBtnNew;
        private System.Windows.Forms.ToolStripButton matBtnEDit;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
    }
}