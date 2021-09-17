
namespace ULTRAMAVERICK.Forms.Users
{
    partial class frmModulesAvailableForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModulesAvailableForms));
            this.txtCreatedByAndUserID = new System.Windows.Forms.TextBox();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.txtcountChildId = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtgchild = new MaterialSkin.Controls.MaterialTextBox();
            this.txtfname = new MaterialSkin.Controls.MaterialTextBox();
            this.cboChildMenu = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtParentName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvGrandChildForms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvUserRights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.user_rights_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_rights_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRightsID = new System.Windows.Forms.TextBox();
            this.matBtnNext = new MaterialSkin.Controls.MaterialButton();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddTool = new System.Windows.Forms.ToolStripButton();
            this.btnEditTool = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTool = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateTool = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTool = new System.Windows.Forms.ToolStripButton();
            this.menu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_form_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrandChildForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCreatedByAndUserID
            // 
            this.txtCreatedByAndUserID.BackColor = System.Drawing.Color.White;
            this.txtCreatedByAndUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedByAndUserID.Enabled = false;
            this.txtCreatedByAndUserID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedByAndUserID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCreatedByAndUserID.Location = new System.Drawing.Point(1443, 26);
            this.txtCreatedByAndUserID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCreatedByAndUserID.MaxLength = 100;
            this.txtCreatedByAndUserID.Name = "txtCreatedByAndUserID";
            this.txtCreatedByAndUserID.ReadOnly = true;
            this.txtCreatedByAndUserID.Size = new System.Drawing.Size(176, 32);
            this.txtCreatedByAndUserID.TabIndex = 560;
            this.txtCreatedByAndUserID.Visible = false;
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(2101, 758);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(181, 48);
            this.metroFinalSaving.TabIndex = 559;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            this.metroFinalSaving.Click += new System.EventHandler(this.metroFinalSaving_Click);
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(2382, 773);
            this.metroSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(181, 48);
            this.metroSave.TabIndex = 558;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // txtcountChildId
            // 
            this.txtcountChildId.BackColor = System.Drawing.Color.White;
            this.txtcountChildId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcountChildId.Enabled = false;
            this.txtcountChildId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcountChildId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcountChildId.Location = new System.Drawing.Point(1089, 26);
            this.txtcountChildId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcountChildId.MaxLength = 100;
            this.txtcountChildId.Name = "txtcountChildId";
            this.txtcountChildId.ReadOnly = true;
            this.txtcountChildId.Size = new System.Drawing.Size(176, 32);
            this.txtcountChildId.TabIndex = 557;
            this.txtcountChildId.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtgchild);
            this.materialCard1.Controls.Add(this.txtfname);
            this.materialCard1.Controls.Add(this.cboChildMenu);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 297);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(2158, 340);
            this.materialCard1.TabIndex = 561;
            // 
            // txtgchild
            // 
            this.txtgchild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgchild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgchild.Depth = 0;
            this.txtgchild.Enabled = false;
            this.txtgchild.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtgchild.Hint = "Module Name";
            this.txtgchild.Location = new System.Drawing.Point(85, 203);
            this.txtgchild.MaxLength = 50;
            this.txtgchild.MouseState = MaterialSkin.MouseState.OUT;
            this.txtgchild.Multiline = false;
            this.txtgchild.Name = "txtgchild";
            this.txtgchild.Size = new System.Drawing.Size(1989, 50);
            this.txtgchild.TabIndex = 432;
            this.txtgchild.Text = "";
            // 
            // txtfname
            // 
            this.txtfname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfname.Depth = 0;
            this.txtfname.Enabled = false;
            this.txtfname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtfname.Hint = "Developer Form Name";
            this.txtfname.Location = new System.Drawing.Point(1356, 61);
            this.txtfname.MaxLength = 50;
            this.txtfname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfname.Multiline = false;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(718, 50);
            this.txtfname.TabIndex = 431;
            this.txtfname.Text = "";
            // 
            // cboChildMenu
            // 
            this.cboChildMenu.Enabled = false;
            this.cboChildMenu.FormattingEnabled = true;
            this.cboChildMenu.ItemHeight = 24;
            this.cboChildMenu.Location = new System.Drawing.Point(85, 97);
            this.cboChildMenu.Name = "cboChildMenu";
            this.cboChildMenu.Size = new System.Drawing.Size(481, 30);
            this.cboChildMenu.TabIndex = 430;
            this.cboChildMenu.UseSelectable = true;
            this.cboChildMenu.SelectionChangeCommitted += new System.EventHandler(this.metroComboBox1_SelectionChangeCommitted);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(82, 55);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 429;
            this.materialLabel1.Text = "Sub Menu:";
            // 
            // txtParentName
            // 
            this.txtParentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParentName.Depth = 0;
            this.txtParentName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtParentName.Hint = "Module Name";
            this.txtParentName.Location = new System.Drawing.Point(1019, 674);
            this.txtParentName.MaxLength = 50;
            this.txtParentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtParentName.Multiline = false;
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(426, 50);
            this.txtParentName.TabIndex = 433;
            this.txtParentName.Text = "";
            this.txtParentName.Visible = false;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvGrandChildForms);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(23, 806);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(2165, 732);
            this.materialCard2.TabIndex = 579;
            // 
            // dgvGrandChildForms
            // 
            this.dgvGrandChildForms.AllowUserToAddRows = false;
            this.dgvGrandChildForms.AllowUserToDeleteRows = false;
            this.dgvGrandChildForms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvGrandChildForms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrandChildForms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrandChildForms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvGrandChildForms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrandChildForms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGrandChildForms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrandChildForms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrandChildForms.ColumnHeadersHeight = 35;
            this.dgvGrandChildForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrandChildForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu_id,
            this.count,
            this.ChildForm,
            this.menu_name,
            this.menu_form_name,
            this.created_at,
            this.created_by,
            this.updated_at,
            this.updated_by,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrandChildForms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrandChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrandChildForms.EnableHeadersVisualStyles = false;
            this.dgvGrandChildForms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvGrandChildForms.Location = new System.Drawing.Point(14, 14);
            this.dgvGrandChildForms.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvGrandChildForms.MultiSelect = false;
            this.dgvGrandChildForms.Name = "dgvGrandChildForms";
            this.dgvGrandChildForms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrandChildForms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGrandChildForms.RowHeadersVisible = false;
            this.dgvGrandChildForms.RowHeadersWidth = 102;
            this.dgvGrandChildForms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGrandChildForms.RowTemplate.DividerHeight = 5;
            this.dgvGrandChildForms.RowTemplate.Height = 40;
            this.dgvGrandChildForms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrandChildForms.Size = new System.Drawing.Size(2137, 704);
            this.dgvGrandChildForms.TabIndex = 578;
            this.dgvGrandChildForms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvGrandChildForms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGrandChildForms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGrandChildForms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGrandChildForms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGrandChildForms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGrandChildForms.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvGrandChildForms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvGrandChildForms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvGrandChildForms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGrandChildForms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvGrandChildForms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvGrandChildForms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrandChildForms.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvGrandChildForms.ThemeStyle.ReadOnly = true;
            this.dgvGrandChildForms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGrandChildForms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGrandChildForms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGrandChildForms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvGrandChildForms.ThemeStyle.RowsStyle.Height = 40;
            this.dgvGrandChildForms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvGrandChildForms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGrandChildForms.CurrentCellChanged += new System.EventHandler(this.dgvChildForms_CurrentCellChanged);
            // 
            // dgvUserRights
            // 
            this.dgvUserRights.AllowUserToAddRows = false;
            this.dgvUserRights.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvUserRights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserRights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUserRights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserRights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserRights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserRights.ColumnHeadersHeight = 35;
            this.dgvUserRights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_rights_id,
            this.user_rights_name});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserRights.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUserRights.EnableHeadersVisualStyles = false;
            this.dgvUserRights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.Location = new System.Drawing.Point(2010, 152);
            this.dgvUserRights.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvUserRights.Name = "dgvUserRights";
            this.dgvUserRights.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRights.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUserRights.RowHeadersVisible = false;
            this.dgvUserRights.RowHeadersWidth = 102;
            this.dgvUserRights.RowTemplate.DividerHeight = 5;
            this.dgvUserRights.RowTemplate.Height = 40;
            this.dgvUserRights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserRights.Size = new System.Drawing.Size(472, 476);
            this.dgvUserRights.TabIndex = 585;
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
            this.user_rights_id.Width = 95;
            // 
            // user_rights_name
            // 
            this.user_rights_name.DataPropertyName = "user_rights_name";
            this.user_rights_name.FillWeight = 99.49239F;
            this.user_rights_name.HeaderText = "User Rights";
            this.user_rights_name.MinimumWidth = 12;
            this.user_rights_name.Name = "user_rights_name";
            this.user_rights_name.ReadOnly = true;
            this.user_rights_name.Width = 203;
            // 
            // txtRightsID
            // 
            this.txtRightsID.BackColor = System.Drawing.Color.White;
            this.txtRightsID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRightsID.Enabled = false;
            this.txtRightsID.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightsID.Location = new System.Drawing.Point(1944, 83);
            this.txtRightsID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRightsID.MaxLength = 100;
            this.txtRightsID.Name = "txtRightsID";
            this.txtRightsID.Size = new System.Drawing.Size(445, 36);
            this.txtRightsID.TabIndex = 587;
            this.txtRightsID.Visible = false;
            // 
            // matBtnNext
            // 
            this.matBtnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnNext.Depth = 0;
            this.matBtnNext.DrawShadows = true;
            this.matBtnNext.HighEmphasis = true;
            this.matBtnNext.Icon = null;
            this.matBtnNext.Location = new System.Drawing.Point(2566, 84);
            this.matBtnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnNext.Name = "matBtnNext";
            this.matBtnNext.Size = new System.Drawing.Size(58, 36);
            this.matBtnNext.TabIndex = 586;
            this.matBtnNext.Text = "NEXT";
            this.matBtnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnNext.UseAccentColor = false;
            this.matBtnNext.UseVisualStyleBackColor = true;
            this.matBtnNext.Visible = false;
            this.matBtnNext.Click += new System.EventHandler(this.matBtnNext_Click);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(1896, 1544);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(121, 85);
            this.lbltotalrecords.TabIndex = 588;
            this.lbltotalrecords.Text = "76";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(2023, 1580);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 589;
            this.label2.Text = "Items";
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(1641, 691);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(547, 50);
            this.mattxtSearch.TabIndex = 590;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(35, 695);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 95);
            this.panel1.TabIndex = 664;
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
            this.toolStrip2.Size = new System.Drawing.Size(825, 95);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // btnAddTool
            // 
            this.btnAddTool.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTool.Image")));
            this.btnAddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(122, 88);
            this.btnAddTool.Text = "&New";
            this.btnAddTool.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnEditTool
            // 
            this.btnEditTool.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTool.Image")));
            this.btnEditTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(112, 88);
            this.btnEditTool.Text = "&Edit";
            this.btnEditTool.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTool.Image")));
            this.btnDeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(169, 88);
            this.btnDeleteTool.Text = "&Remove";
            this.btnDeleteTool.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTool.Image")));
            this.btnUpdateTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(123, 88);
            this.btnUpdateTool.Text = "&Save";
            this.btnUpdateTool.Visible = false;
            this.btnUpdateTool.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTool.Image")));
            this.btnCancelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(150, 88);
            this.btnCancelTool.Text = "&Cancel";
            this.btnCancelTool.Visible = false;
            this.btnCancelTool.Click += new System.EventHandler(this.btnCancelTool_Click_1);
            // 
            // menu_id
            // 
            this.menu_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.menu_id.DataPropertyName = "menu_id";
            this.menu_id.FillWeight = 40.60914F;
            this.menu_id.HeaderText = "ID";
            this.menu_id.MinimumWidth = 12;
            this.menu_id.Name = "menu_id";
            this.menu_id.ReadOnly = true;
            this.menu_id.Width = 12;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.FillWeight = 99.49239F;
            this.count.HeaderText = "MAJOR MENU";
            this.count.MinimumWidth = 12;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // ChildForm
            // 
            this.ChildForm.DataPropertyName = "ChildForm";
            this.ChildForm.FillWeight = 99.49239F;
            this.ChildForm.HeaderText = "SUB MENU";
            this.ChildForm.MinimumWidth = 12;
            this.ChildForm.Name = "ChildForm";
            this.ChildForm.ReadOnly = true;
            // 
            // menu_name
            // 
            this.menu_name.DataPropertyName = "menu_name";
            this.menu_name.FillWeight = 99.49239F;
            this.menu_name.HeaderText = "MODULE";
            this.menu_name.MinimumWidth = 12;
            this.menu_name.Name = "menu_name";
            this.menu_name.ReadOnly = true;
            // 
            // menu_form_name
            // 
            this.menu_form_name.DataPropertyName = "menu_form_name";
            this.menu_form_name.FillWeight = 99.49239F;
            this.menu_form_name.HeaderText = "DEV FORM NAME";
            this.menu_form_name.MinimumWidth = 12;
            this.menu_form_name.Name = "menu_form_name";
            this.menu_form_name.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "CREATED DATE";
            this.created_at.MinimumWidth = 12;
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.HeaderText = "CREATED BY";
            this.created_by.MinimumWidth = 12;
            this.created_by.Name = "created_by";
            this.created_by.ReadOnly = true;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
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
            // Column1
            // 
            this.Column1.DataPropertyName = "search";
            this.Column1.HeaderText = "ss";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // frmModulesAvailableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2218, 1638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRightsID);
            this.Controls.Add(this.matBtnNext);
            this.Controls.Add(this.dgvUserRights);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtCreatedByAndUserID);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.txtcountChildId);
            this.Name = "frmModulesAvailableForms";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.frmGrandChildAvailableForms_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrandChildForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCreatedByAndUserID;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MetroFramework.Controls.MetroButton metroSave;
        private System.Windows.Forms.TextBox txtcountChildId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MetroFramework.Controls.MetroComboBox cboChildMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtfname;
        private MaterialSkin.Controls.MaterialTextBox txtgchild;
        private MaterialSkin.Controls.MaterialTextBox txtParentName;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_name;
        private System.Windows.Forms.TextBox txtRightsID;
        private MaterialSkin.Controls.MaterialButton matBtnNext;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGrandChildForms;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddTool;
        private System.Windows.Forms.ToolStripButton btnEditTool;
        private System.Windows.Forms.ToolStripButton btnUpdateTool;
        private System.Windows.Forms.ToolStripButton btnDeleteTool;
        private System.Windows.Forms.ToolStripButton btnCancelTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_form_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}