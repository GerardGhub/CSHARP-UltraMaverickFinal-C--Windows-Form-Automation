
namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    partial class frmItemClass
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
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvitemClass = new Guna.UI2.WinForms.Guna2DataGridView();
            this.item_class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_class_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.lblrecordDesc = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtmatItemClass = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnNew = new MaterialSkin.Controls.MaterialButton();
            this.matBtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.txtModifiedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCreatedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCreatedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.matBtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemClass)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvitemClass);
            this.materialCard2.Controls.Add(this.lbltotalrecords);
            this.materialCard2.Controls.Add(this.lblrecordDesc);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(105, 548);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1769, 669);
            this.materialCard2.TabIndex = 580;
            // 
            // dgvitemClass
            // 
            this.dgvitemClass.AllowUserToAddRows = false;
            this.dgvitemClass.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvitemClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvitemClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvitemClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvitemClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvitemClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvitemClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitemClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvitemClass.ColumnHeadersHeight = 35;
            this.dgvitemClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvitemClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_class_id,
            this.item_class_desc,
            this.item_added_at,
            this.item_added_by,
            this.item_updated_at,
            this.item_updated_by});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitemClass.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvitemClass.EnableHeadersVisualStyles = false;
            this.dgvitemClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvitemClass.Location = new System.Drawing.Point(36, 48);
            this.dgvitemClass.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvitemClass.Name = "dgvitemClass";
            this.dgvitemClass.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitemClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvitemClass.RowHeadersVisible = false;
            this.dgvitemClass.RowHeadersWidth = 102;
            this.dgvitemClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvitemClass.RowTemplate.DividerHeight = 5;
            this.dgvitemClass.RowTemplate.Height = 40;
            this.dgvitemClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitemClass.Size = new System.Drawing.Size(1706, 539);
            this.dgvitemClass.TabIndex = 593;
            this.dgvitemClass.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvitemClass.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvitemClass.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvitemClass.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvitemClass.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvitemClass.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvitemClass.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvitemClass.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvitemClass.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvitemClass.ThemeStyle.ReadOnly = true;
            this.dgvitemClass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvitemClass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvitemClass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvitemClass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvitemClass.ThemeStyle.RowsStyle.Height = 40;
            this.dgvitemClass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvitemClass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvitemClass.CurrentCellChanged += new System.EventHandler(this.dgvitemClass_CurrentCellChanged_1);
            // 
            // item_class_id
            // 
            this.item_class_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.item_class_id.DataPropertyName = "item_class_id";
            this.item_class_id.FillWeight = 40.60914F;
            this.item_class_id.HeaderText = "ID";
            this.item_class_id.MinimumWidth = 12;
            this.item_class_id.Name = "item_class_id";
            this.item_class_id.ReadOnly = true;
            this.item_class_id.Width = 12;
            // 
            // item_class_desc
            // 
            this.item_class_desc.DataPropertyName = "item_class_desc";
            this.item_class_desc.FillWeight = 99.49239F;
            this.item_class_desc.HeaderText = "Item Class";
            this.item_class_desc.MinimumWidth = 12;
            this.item_class_desc.Name = "item_class_desc";
            this.item_class_desc.ReadOnly = true;
            this.item_class_desc.Width = 189;
            // 
            // item_added_at
            // 
            this.item_added_at.DataPropertyName = "item_added_at";
            this.item_added_at.FillWeight = 99.49239F;
            this.item_added_at.HeaderText = "Created Date";
            this.item_added_at.MinimumWidth = 12;
            this.item_added_at.Name = "item_added_at";
            this.item_added_at.ReadOnly = true;
            this.item_added_at.Width = 225;
            // 
            // item_added_by
            // 
            this.item_added_by.DataPropertyName = "item_added_by";
            this.item_added_by.FillWeight = 99.49239F;
            this.item_added_by.HeaderText = "Created By";
            this.item_added_by.MinimumWidth = 12;
            this.item_added_by.Name = "item_added_by";
            this.item_added_by.ReadOnly = true;
            this.item_added_by.Width = 197;
            // 
            // item_updated_at
            // 
            this.item_updated_at.DataPropertyName = "item_updated_at";
            this.item_updated_at.FillWeight = 99.49239F;
            this.item_updated_at.HeaderText = "Updated Date";
            this.item_updated_at.MinimumWidth = 12;
            this.item_updated_at.Name = "item_updated_at";
            this.item_updated_at.ReadOnly = true;
            this.item_updated_at.Width = 236;
            // 
            // item_updated_by
            // 
            this.item_updated_by.DataPropertyName = "item_updated_by";
            this.item_updated_by.HeaderText = "Updated By";
            this.item_updated_by.MinimumWidth = 12;
            this.item_updated_by.Name = "item_updated_by";
            this.item_updated_by.ReadOnly = true;
            this.item_updated_by.Width = 208;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltotalrecords.Location = new System.Drawing.Point(316, 613);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(92, 39);
            this.lbltotalrecords.TabIndex = 550;
            this.lbltotalrecords.Text = "CCC";
            // 
            // lblrecordDesc
            // 
            this.lblrecordDesc.AutoSize = true;
            this.lblrecordDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblrecordDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecordDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrecordDesc.Location = new System.Drawing.Point(43, 613);
            this.lblrecordDesc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblrecordDesc.Name = "lblrecordDesc";
            this.lblrecordDesc.Size = new System.Drawing.Size(247, 39);
            this.lblrecordDesc.TabIndex = 550;
            this.lblrecordDesc.Text = "Total Records :";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtmatItemClass);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(105, 142);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1769, 238);
            this.materialCard1.TabIndex = 582;
            // 
            // txtmatItemClass
            // 
            this.txtmatItemClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatItemClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatItemClass.Depth = 0;
            this.txtmatItemClass.Enabled = false;
            this.txtmatItemClass.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatItemClass.Hint = "Item Class";
            this.txtmatItemClass.Location = new System.Drawing.Point(36, 90);
            this.txtmatItemClass.MaxLength = 50;
            this.txtmatItemClass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatItemClass.Multiline = false;
            this.txtmatItemClass.Name = "txtmatItemClass";
            this.txtmatItemClass.Size = new System.Drawing.Size(1706, 50);
            this.txtmatItemClass.TabIndex = 0;
            this.txtmatItemClass.Text = "";
            // 
            // matBtnNew
            // 
            this.matBtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnNew.Depth = 0;
            this.matBtnNew.DrawShadows = true;
            this.matBtnNew.HighEmphasis = true;
            this.matBtnNew.Icon = null;
            this.matBtnNew.Location = new System.Drawing.Point(141, 431);
            this.matBtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(53, 36);
            this.matBtnNew.TabIndex = 583;
            this.matBtnNew.Text = "NEW";
            this.matBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnNew.UseAccentColor = false;
            this.matBtnNew.UseVisualStyleBackColor = true;
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnEdit.Depth = 0;
            this.matBtnEdit.DrawShadows = true;
            this.matBtnEdit.HighEmphasis = true;
            this.matBtnEdit.Icon = null;
            this.matBtnEdit.Location = new System.Drawing.Point(317, 431);
            this.matBtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matBtnEdit.TabIndex = 584;
            this.matBtnEdit.Text = "EDIT";
            this.matBtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnEdit.UseAccentColor = false;
            this.matBtnEdit.UseVisualStyleBackColor = true;
            this.matBtnEdit.Click += new System.EventHandler(this.matBtnEdit_Click);
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedAt.Depth = 0;
            this.txtModifiedAt.Enabled = false;
            this.txtModifiedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedAt.Hint = "Modified At";
            this.txtModifiedAt.Location = new System.Drawing.Point(1452, 451);
            this.txtModifiedAt.MaxLength = 50;
            this.txtModifiedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedAt.Multiline = false;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedAt.TabIndex = 1;
            this.txtModifiedAt.Text = "";
            this.txtModifiedAt.Visible = false;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedBy.Depth = 0;
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedBy.Hint = "Modified By";
            this.txtModifiedBy.Location = new System.Drawing.Point(1764, 451);
            this.txtModifiedBy.MaxLength = 50;
            this.txtModifiedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedBy.Multiline = false;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedBy.TabIndex = 585;
            this.txtModifiedBy.Text = "";
            this.txtModifiedBy.Visible = false;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Depth = 0;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedAt.Hint = "Created At";
            this.txtCreatedAt.Location = new System.Drawing.Point(801, 451);
            this.txtCreatedAt.MaxLength = 50;
            this.txtCreatedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedAt.Multiline = false;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedAt.TabIndex = 586;
            this.txtCreatedAt.Text = "";
            this.txtCreatedAt.Visible = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Depth = 0;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedBy.Hint = "Created By";
            this.txtCreatedBy.Location = new System.Drawing.Point(1133, 451);
            this.txtCreatedBy.MaxLength = 50;
            this.txtCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedBy.Multiline = false;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedBy.TabIndex = 587;
            this.txtCreatedBy.Text = "";
            this.txtCreatedBy.Visible = false;
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnCancel.Depth = 0;
            this.matBtnCancel.DrawShadows = true;
            this.matBtnCancel.HighEmphasis = true;
            this.matBtnCancel.Icon = null;
            this.matBtnCancel.Location = new System.Drawing.Point(639, 431);
            this.matBtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matBtnCancel.TabIndex = 588;
            this.matBtnCancel.Text = "CANCEL";
            this.matBtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnCancel.UseAccentColor = false;
            this.matBtnCancel.UseVisualStyleBackColor = true;
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.matBtnCancel_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnDelete.Depth = 0;
            this.matBtnDelete.DrawShadows = true;
            this.matBtnDelete.HighEmphasis = true;
            this.matBtnDelete.Icon = null;
            this.matBtnDelete.Location = new System.Drawing.Point(471, 431);
            this.matBtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(80, 36);
            this.matBtnDelete.TabIndex = 589;
            this.matBtnDelete.Text = "REMOVE";
            this.matBtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnDelete.UseAccentColor = false;
            this.matBtnDelete.UseVisualStyleBackColor = true;
            this.matBtnDelete.Click += new System.EventHandler(this.matBtnDelete_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(317, 431);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 590;
            this.matBtnSave.Text = "SAVE";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(1079, 396);
            this.metroSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(181, 48);
            this.metroSave.TabIndex = 591;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(1403, 396);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(181, 48);
            this.metroFinalSaving.TabIndex = 592;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            this.metroFinalSaving.Click += new System.EventHandler(this.metroFinalSaving_Click);
            // 
            // frmItemClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1259);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.matBtnDelete);
            this.Controls.Add(this.matBtnCancel);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.txtModifiedAt);
            this.Controls.Add(this.matBtnEdit);
            this.Controls.Add(this.matBtnNew);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialCard2);
            this.Name = "frmItemClass";
            this.Text = "Item Class";
            this.Load += new System.EventHandler(this.frmItemClass_Load);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemClass)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label lblrecordDesc;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtmatItemClass;
        private MaterialSkin.Controls.MaterialButton matBtnNew;
        private MaterialSkin.Controls.MaterialButton matBtnEdit;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedAt;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedBy;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedAt;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedBy;
        private MaterialSkin.Controls.MaterialButton matBtnCancel;
        private MaterialSkin.Controls.MaterialButton matBtnDelete;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MetroFramework.Controls.MetroButton metroSave;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private Guna.UI2.WinForms.Guna2DataGridView dgvitemClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_class_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_updated_by;
    }
}