
namespace ULTRAMAVERICK.Forms.Users
{
    partial class frmParentAvailableForms
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
            this.lstParentMenu = new System.Windows.Forms.ListBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.lblrecordDesc = new System.Windows.Forms.Label();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtModifiedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.txtCreatedByAndUserID = new System.Windows.Forms.TextBox();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cboDepartmentMaterial = new System.Windows.Forms.ComboBox();
            this.txtMaterialDepartment = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaterialMenu = new MaterialSkin.Controls.MaterialTextBox();
            this.materialBtnNew = new MaterialSkin.Controls.MaterialButton();
            this.matBtnEDit = new MaterialSkin.Controls.MaterialButton();
            this.matBtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.matBtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvUserRights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.user_rights_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_rights_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matBtnNext = new MaterialSkin.Controls.MaterialButton();
            this.txtRightsID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).BeginInit();
            this.SuspendLayout();
            // 
            // lstParentMenu
            // 
            this.lstParentMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstParentMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lstParentMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstParentMenu.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParentMenu.FormattingEnabled = true;
            this.lstParentMenu.ItemHeight = 50;
            this.lstParentMenu.Location = new System.Drawing.Point(22, 41);
            this.lstParentMenu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstParentMenu.Name = "lstParentMenu";
            this.lstParentMenu.Size = new System.Drawing.Size(1917, 450);
            this.lstParentMenu.TabIndex = 152;
            this.lstParentMenu.Click += new System.EventHandler(this.lstParentMenu_Click);
            this.lstParentMenu.SelectedIndexChanged += new System.EventHandler(this.lstParentMenu_SelectedIndexChanged);
            this.lstParentMenu.SelectedValueChanged += new System.EventHandler(this.lstParentMenu_SelectedValueChanged);
            this.lstParentMenu.CursorChanged += new System.EventHandler(this.lstParentMenu_CursorChanged);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.Black;
            this.lbltotalrecords.Location = new System.Drawing.Point(295, 529);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(92, 39);
            this.lbltotalrecords.TabIndex = 431;
            this.lbltotalrecords.Text = "CCC";
            // 
            // lblrecordDesc
            // 
            this.lblrecordDesc.AutoSize = true;
            this.lblrecordDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblrecordDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecordDesc.ForeColor = System.Drawing.Color.Black;
            this.lblrecordDesc.Location = new System.Drawing.Point(32, 529);
            this.lblrecordDesc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblrecordDesc.Name = "lblrecordDesc";
            this.lblrecordDesc.Size = new System.Drawing.Size(247, 39);
            this.lblrecordDesc.TabIndex = 432;
            this.lblrecordDesc.Text = "Total Records :";
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BackColor = System.Drawing.Color.White;
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedAt.ForeColor = System.Drawing.Color.Black;
            this.txtCreatedAt.Location = new System.Drawing.Point(1998, 975);
            this.txtCreatedAt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCreatedAt.MaxLength = 100;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(444, 36);
            this.txtCreatedAt.TabIndex = 180;
            this.txtCreatedAt.Visible = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.Color.White;
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.txtCreatedBy.Location = new System.Drawing.Point(2762, 975);
            this.txtCreatedBy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCreatedBy.MaxLength = 100;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(447, 36);
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
            this.txtModifiedBy.Location = new System.Drawing.Point(2762, 1056);
            this.txtModifiedBy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtModifiedBy.MaxLength = 100;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(445, 36);
            this.txtModifiedBy.TabIndex = 178;
            this.txtModifiedBy.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2492, 1053);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 39);
            this.label6.TabIndex = 177;
            this.label6.Text = "Modified By :";
            this.label6.Visible = false;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.BackColor = System.Drawing.Color.White;
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedAt.Enabled = false;
            this.txtModifiedAt.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifiedAt.ForeColor = System.Drawing.Color.Black;
            this.txtModifiedAt.Location = new System.Drawing.Point(1997, 1053);
            this.txtModifiedAt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtModifiedAt.MaxLength = 100;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(445, 36);
            this.txtModifiedAt.TabIndex = 176;
            this.txtModifiedAt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1752, 1053);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 39);
            this.label5.TabIndex = 175;
            this.label5.Text = "Modified_At :";
            this.label5.Visible = false;
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(1944, 896);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(181, 48);
            this.metroButtonDelete.TabIndex = 448;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Visible = false;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2500, 972);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 39);
            this.label4.TabIndex = 173;
            this.label4.Text = "Created By :";
            this.label4.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(1771, 968);
            this.label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 39);
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
            this.dgv_table.Location = new System.Drawing.Point(2438, 276);
            this.dgv_table.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(267, 469);
            this.dgv_table.TabIndex = 446;
            this.dgv_table.Visible = false;
            this.dgv_table.CurrentCellChanged += new System.EventHandler(this.dgv_table_CurrentCellChanged);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(2261, 896);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(181, 48);
            this.metroButtonSave.TabIndex = 445;
            this.metroButtonSave.Text = "Add";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Visible = false;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // txtCreatedByAndUserID
            // 
            this.txtCreatedByAndUserID.BackColor = System.Drawing.Color.White;
            this.txtCreatedByAndUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedByAndUserID.Enabled = false;
            this.txtCreatedByAndUserID.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedByAndUserID.Location = new System.Drawing.Point(2155, 821);
            this.txtCreatedByAndUserID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCreatedByAndUserID.MaxLength = 100;
            this.txtCreatedByAndUserID.Name = "txtCreatedByAndUserID";
            this.txtCreatedByAndUserID.Size = new System.Drawing.Size(445, 36);
            this.txtCreatedByAndUserID.TabIndex = 444;
            this.txtCreatedByAndUserID.Visible = false;
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.ForeColor = System.Drawing.Color.Black;
            this.lblDepartmentID.Location = new System.Drawing.Point(1635, 79);
            this.lblDepartmentID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(238, 39);
            this.lblDepartmentID.TabIndex = 449;
            this.lblDepartmentID.Text = "Department ID";
            this.lblDepartmentID.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cboDepartmentMaterial);
            this.materialCard1.Controls.Add(this.txtMaterialDepartment);
            this.materialCard1.Controls.Add(this.txtMaterialMenu);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(108, 200);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1961, 249);
            this.materialCard1.TabIndex = 450;
            // 
            // cboDepartmentMaterial
            // 
            this.cboDepartmentMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDepartmentMaterial.FormattingEnabled = true;
            this.cboDepartmentMaterial.Location = new System.Drawing.Point(1406, 86);
            this.cboDepartmentMaterial.Name = "cboDepartmentMaterial";
            this.cboDepartmentMaterial.Size = new System.Drawing.Size(527, 39);
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
            this.txtMaterialDepartment.Location = new System.Drawing.Point(1406, 77);
            this.txtMaterialDepartment.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMaterialDepartment.MaxLength = 50;
            this.txtMaterialDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaterialDepartment.Multiline = false;
            this.txtMaterialDepartment.Name = "txtMaterialDepartment";
            this.txtMaterialDepartment.Size = new System.Drawing.Size(527, 50);
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
            this.txtMaterialMenu.Location = new System.Drawing.Point(39, 77);
            this.txtMaterialMenu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMaterialMenu.MaxLength = 50;
            this.txtMaterialMenu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaterialMenu.Multiline = false;
            this.txtMaterialMenu.Name = "txtMaterialMenu";
            this.txtMaterialMenu.Size = new System.Drawing.Size(527, 50);
            this.txtMaterialMenu.TabIndex = 583;
            this.txtMaterialMenu.Text = "";
            this.txtMaterialMenu.TextChanged += new System.EventHandler(this.txtMaterialMenu_TextChanged);
            // 
            // materialBtnNew
            // 
            this.materialBtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtnNew.Depth = 0;
            this.materialBtnNew.DrawShadows = true;
            this.materialBtnNew.HighEmphasis = true;
            this.materialBtnNew.Icon = null;
            this.materialBtnNew.Location = new System.Drawing.Point(133, 469);
            this.materialBtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtnNew.Name = "materialBtnNew";
            this.materialBtnNew.Size = new System.Drawing.Size(53, 36);
            this.materialBtnNew.TabIndex = 571;
            this.materialBtnNew.Text = "NEW";
            this.materialBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtnNew.UseAccentColor = false;
            this.materialBtnNew.UseVisualStyleBackColor = true;
            this.materialBtnNew.Click += new System.EventHandler(this.materialBtnNew_Click);
            // 
            // matBtnEDit
            // 
            this.matBtnEDit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnEDit.Depth = 0;
            this.matBtnEDit.DrawShadows = true;
            this.matBtnEDit.HighEmphasis = true;
            this.matBtnEDit.Icon = null;
            this.matBtnEDit.Location = new System.Drawing.Point(356, 469);
            this.matBtnEDit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnEDit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnEDit.Name = "matBtnEDit";
            this.matBtnEDit.Size = new System.Drawing.Size(53, 36);
            this.matBtnEDit.TabIndex = 572;
            this.matBtnEDit.Text = "EDIT";
            this.matBtnEDit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnEDit.UseAccentColor = false;
            this.matBtnEDit.UseVisualStyleBackColor = true;
            this.matBtnEDit.Click += new System.EventHandler(this.matBtnEDit_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnDelete.Depth = 0;
            this.matBtnDelete.DrawShadows = true;
            this.matBtnDelete.HighEmphasis = true;
            this.matBtnDelete.Icon = null;
            this.matBtnDelete.Location = new System.Drawing.Point(560, 469);
            this.matBtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(80, 36);
            this.matBtnDelete.TabIndex = 573;
            this.matBtnDelete.Text = "REMOVE";
            this.matBtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnDelete.UseAccentColor = false;
            this.matBtnDelete.UseVisualStyleBackColor = true;
            this.matBtnDelete.Click += new System.EventHandler(this.matBtnDelete_Click);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnCancel.Depth = 0;
            this.matBtnCancel.DrawShadows = true;
            this.matBtnCancel.HighEmphasis = true;
            this.matBtnCancel.Icon = null;
            this.matBtnCancel.Location = new System.Drawing.Point(823, 469);
            this.matBtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matBtnCancel.TabIndex = 574;
            this.matBtnCancel.Text = "CANCEL";
            this.matBtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnCancel.UseAccentColor = false;
            this.matBtnCancel.UseVisualStyleBackColor = true;
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.matBtnCancel_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(356, 469);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 575;
            this.matBtnSave.Text = "SAVE";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lstParentMenu);
            this.materialCard2.Controls.Add(this.lbltotalrecords);
            this.materialCard2.Controls.Add(this.lblrecordDesc);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(108, 636);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1961, 592);
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
            this.dgvUserRights.Location = new System.Drawing.Point(1466, 365);
            this.dgvUserRights.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
            this.dgvUserRights.Size = new System.Drawing.Size(834, 476);
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
            // matBtnNext
            // 
            this.matBtnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnNext.Depth = 0;
            this.matBtnNext.DrawShadows = true;
            this.matBtnNext.HighEmphasis = true;
            this.matBtnNext.Icon = null;
            this.matBtnNext.Location = new System.Drawing.Point(2048, 146);
            this.matBtnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // txtRightsID
            // 
            this.txtRightsID.BackColor = System.Drawing.Color.White;
            this.txtRightsID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRightsID.Enabled = false;
            this.txtRightsID.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightsID.Location = new System.Drawing.Point(1426, 145);
            this.txtRightsID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRightsID.MaxLength = 100;
            this.txtRightsID.Name = "txtRightsID";
            this.txtRightsID.Size = new System.Drawing.Size(445, 36);
            this.txtRightsID.TabIndex = 580;
            this.txtRightsID.Visible = false;
            // 
            // frmParentAvailableForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2205, 1358);
            this.Controls.Add(this.txtRightsID);
            this.Controls.Add(this.matBtnNext);
            this.Controls.Add(this.dgvUserRights);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.matBtnCancel);
            this.Controls.Add(this.matBtnDelete);
            this.Controls.Add(this.matBtnEDit);
            this.Controls.Add(this.materialBtnNew);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.txtModifiedAt);
            this.Controls.Add(this.txtCreatedByAndUserID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.Name = "frmParentAvailableForms";
            this.Text = "Major Menu";
            this.Load += new System.EventHandler(this.frmParentAvailableForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstParentMenu;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label lblrecordDesc;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.TextBox txtModifiedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModifiedAt;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgv_table;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private System.Windows.Forms.TextBox txtCreatedByAndUserID;
        private System.Windows.Forms.Label lblDepartmentID;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtMaterialMenu;
        private MaterialSkin.Controls.MaterialTextBox txtMaterialDepartment;
        private MaterialSkin.Controls.MaterialButton materialBtnNew;
        private System.Windows.Forms.ComboBox cboDepartmentMaterial;
        private MaterialSkin.Controls.MaterialButton matBtnEDit;
        private MaterialSkin.Controls.MaterialButton matBtnDelete;
        private MaterialSkin.Controls.MaterialButton matBtnCancel;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserRights;
        private MaterialSkin.Controls.MaterialButton matBtnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_name;
        private System.Windows.Forms.TextBox txtRightsID;
    }
}