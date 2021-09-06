
namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    partial class frmPrimaryUnit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtmatPrimaryUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.matBtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.matBtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.lblrecordDesc = new System.Windows.Forms.Label();
            this.txtCreatedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.matBtnNew = new MaterialSkin.Controls.MaterialButton();
            this.dgvPrimaryUnit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.txtCreatedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryUnit)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtmatPrimaryUnit);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(33, 138);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1769, 143);
            this.materialCard1.TabIndex = 621;
            // 
            // txtmatPrimaryUnit
            // 
            this.txtmatPrimaryUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatPrimaryUnit.Depth = 0;
            this.txtmatPrimaryUnit.Enabled = false;
            this.txtmatPrimaryUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmatPrimaryUnit.Hint = "Primary Unit";
            this.txtmatPrimaryUnit.Location = new System.Drawing.Point(36, 32);
            this.txtmatPrimaryUnit.MaxLength = 50;
            this.txtmatPrimaryUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatPrimaryUnit.Multiline = false;
            this.txtmatPrimaryUnit.Name = "txtmatPrimaryUnit";
            this.txtmatPrimaryUnit.Size = new System.Drawing.Size(1706, 50);
            this.txtmatPrimaryUnit.TabIndex = 0;
            this.txtmatPrimaryUnit.Text = "";
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(1007, 299);
            this.metroSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(181, 48);
            this.metroSave.TabIndex = 630;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(245, 333);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 629;
            this.matBtnSave.Text = "SAVE";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnDelete.Depth = 0;
            this.matBtnDelete.DrawShadows = true;
            this.matBtnDelete.HighEmphasis = true;
            this.matBtnDelete.Icon = null;
            this.matBtnDelete.Location = new System.Drawing.Point(399, 301);
            this.matBtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(80, 36);
            this.matBtnDelete.TabIndex = 628;
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
            this.matBtnCancel.Location = new System.Drawing.Point(567, 301);
            this.matBtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matBtnCancel.TabIndex = 627;
            this.matBtnCancel.Text = "CANCEL";
            this.matBtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnCancel.UseAccentColor = false;
            this.matBtnCancel.UseVisualStyleBackColor = true;
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.matBtnCancel_Click);
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
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Depth = 0;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCreatedAt.Hint = "Created At";
            this.txtCreatedAt.Location = new System.Drawing.Point(729, 333);
            this.txtCreatedAt.MaxLength = 50;
            this.txtCreatedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedAt.Multiline = false;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedAt.TabIndex = 625;
            this.txtCreatedAt.Text = "";
            this.txtCreatedAt.Visible = false;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedBy.Depth = 0;
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModifiedBy.Hint = "Modified By";
            this.txtModifiedBy.Location = new System.Drawing.Point(1692, 333);
            this.txtModifiedBy.MaxLength = 50;
            this.txtModifiedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedBy.Multiline = false;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedBy.TabIndex = 624;
            this.txtModifiedBy.Text = "";
            this.txtModifiedBy.Visible = false;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedAt.Depth = 0;
            this.txtModifiedAt.Enabled = false;
            this.txtModifiedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModifiedAt.Hint = "Modified At";
            this.txtModifiedAt.Location = new System.Drawing.Point(1380, 333);
            this.txtModifiedAt.MaxLength = 50;
            this.txtModifiedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedAt.Multiline = false;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedAt.TabIndex = 619;
            this.txtModifiedAt.Text = "";
            this.txtModifiedAt.Visible = false;
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnEdit.Depth = 0;
            this.matBtnEdit.DrawShadows = true;
            this.matBtnEdit.HighEmphasis = true;
            this.matBtnEdit.Icon = null;
            this.matBtnEdit.Location = new System.Drawing.Point(245, 301);
            this.matBtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matBtnEdit.TabIndex = 623;
            this.matBtnEdit.Text = "EDIT";
            this.matBtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnEdit.UseAccentColor = false;
            this.matBtnEdit.UseVisualStyleBackColor = true;
            this.matBtnEdit.Click += new System.EventHandler(this.matBtnEdit_Click);
            // 
            // matBtnNew
            // 
            this.matBtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnNew.Depth = 0;
            this.matBtnNew.DrawShadows = true;
            this.matBtnNew.HighEmphasis = true;
            this.matBtnNew.Icon = null;
            this.matBtnNew.Location = new System.Drawing.Point(69, 301);
            this.matBtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(53, 36);
            this.matBtnNew.TabIndex = 622;
            this.matBtnNew.Text = "NEW";
            this.matBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnNew.UseAccentColor = false;
            this.matBtnNew.UseVisualStyleBackColor = true;
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
            // 
            // dgvPrimaryUnit
            // 
            this.dgvPrimaryUnit.AllowUserToAddRows = false;
            this.dgvPrimaryUnit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvPrimaryUnit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPrimaryUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrimaryUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrimaryUnit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrimaryUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimaryUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPrimaryUnit.ColumnHeadersHeight = 35;
            this.dgvPrimaryUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrimaryUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unit_id,
            this.unit_desc,
            this.pm_added_at,
            this.pm_added_by,
            this.pm_updated_at,
            this.pm_updated_by});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrimaryUnit.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPrimaryUnit.EnableHeadersVisualStyles = false;
            this.dgvPrimaryUnit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvPrimaryUnit.Location = new System.Drawing.Point(36, 48);
            this.dgvPrimaryUnit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPrimaryUnit.Name = "dgvPrimaryUnit";
            this.dgvPrimaryUnit.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimaryUnit.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPrimaryUnit.RowHeadersVisible = false;
            this.dgvPrimaryUnit.RowHeadersWidth = 102;
            this.dgvPrimaryUnit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrimaryUnit.RowTemplate.DividerHeight = 5;
            this.dgvPrimaryUnit.RowTemplate.Height = 40;
            this.dgvPrimaryUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrimaryUnit.Size = new System.Drawing.Size(1706, 539);
            this.dgvPrimaryUnit.TabIndex = 593;
            this.dgvPrimaryUnit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPrimaryUnit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrimaryUnit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrimaryUnit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrimaryUnit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrimaryUnit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrimaryUnit.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvPrimaryUnit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvPrimaryUnit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvPrimaryUnit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrimaryUnit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvPrimaryUnit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvPrimaryUnit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrimaryUnit.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPrimaryUnit.ThemeStyle.ReadOnly = true;
            this.dgvPrimaryUnit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrimaryUnit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrimaryUnit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPrimaryUnit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvPrimaryUnit.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPrimaryUnit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvPrimaryUnit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPrimaryUnit.CurrentCellChanged += new System.EventHandler(this.dgvPrimaryUnit_CurrentCellChanged);
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
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvPrimaryUnit);
            this.materialCard2.Controls.Add(this.lbltotalrecords);
            this.materialCard2.Controls.Add(this.lblrecordDesc);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(33, 397);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1769, 669);
            this.materialCard2.TabIndex = 620;
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(1331, 299);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(181, 48);
            this.metroFinalSaving.TabIndex = 631;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            this.metroFinalSaving.Click += new System.EventHandler(this.metroFinalSaving_Click);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Depth = 0;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCreatedBy.Hint = "Created By";
            this.txtCreatedBy.Location = new System.Drawing.Point(1061, 333);
            this.txtCreatedBy.MaxLength = 50;
            this.txtCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedBy.Multiline = false;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedBy.TabIndex = 626;
            this.txtCreatedBy.Text = "";
            this.txtCreatedBy.Visible = false;
            // 
            // unit_id
            // 
            this.unit_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unit_id.DataPropertyName = "unit_id";
            this.unit_id.FillWeight = 40.60914F;
            this.unit_id.HeaderText = "ID";
            this.unit_id.MinimumWidth = 12;
            this.unit_id.Name = "unit_id";
            this.unit_id.ReadOnly = true;
            this.unit_id.Width = 12;
            // 
            // unit_desc
            // 
            this.unit_desc.DataPropertyName = "unit_desc";
            this.unit_desc.FillWeight = 99.49239F;
            this.unit_desc.HeaderText = "Item Class";
            this.unit_desc.MinimumWidth = 12;
            this.unit_desc.Name = "unit_desc";
            this.unit_desc.ReadOnly = true;
            this.unit_desc.Width = 189;
            // 
            // pm_added_at
            // 
            this.pm_added_at.DataPropertyName = "pm_added_at";
            this.pm_added_at.FillWeight = 99.49239F;
            this.pm_added_at.HeaderText = "Created Date";
            this.pm_added_at.MinimumWidth = 12;
            this.pm_added_at.Name = "pm_added_at";
            this.pm_added_at.ReadOnly = true;
            this.pm_added_at.Width = 225;
            // 
            // pm_added_by
            // 
            this.pm_added_by.DataPropertyName = "pm_added_by";
            this.pm_added_by.FillWeight = 99.49239F;
            this.pm_added_by.HeaderText = "Created By";
            this.pm_added_by.MinimumWidth = 12;
            this.pm_added_by.Name = "pm_added_by";
            this.pm_added_by.ReadOnly = true;
            this.pm_added_by.Width = 197;
            // 
            // pm_updated_at
            // 
            this.pm_updated_at.DataPropertyName = "pm_updated_at";
            this.pm_updated_at.FillWeight = 99.49239F;
            this.pm_updated_at.HeaderText = "Updated Date";
            this.pm_updated_at.MinimumWidth = 12;
            this.pm_updated_at.Name = "pm_updated_at";
            this.pm_updated_at.ReadOnly = true;
            this.pm_updated_at.Width = 236;
            // 
            // pm_updated_by
            // 
            this.pm_updated_by.DataPropertyName = "pm_updated_by";
            this.pm_updated_by.HeaderText = "Updated By";
            this.pm_updated_by.MinimumWidth = 12;
            this.pm_updated_by.Name = "pm_updated_by";
            this.pm_updated_by.ReadOnly = true;
            this.pm_updated_by.Width = 208;
            // 
            // frmPrimaryUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 1105);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.matBtnDelete);
            this.Controls.Add(this.matBtnCancel);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.txtModifiedAt);
            this.Controls.Add(this.matBtnEdit);
            this.Controls.Add(this.matBtnNew);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "frmPrimaryUnit";
            this.Text = "Primary Unit";
            this.Load += new System.EventHandler(this.frmPrimaryUnit_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryUnit)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtmatPrimaryUnit;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MaterialSkin.Controls.MaterialButton matBtnDelete;
        private MaterialSkin.Controls.MaterialButton matBtnCancel;
        private System.Windows.Forms.Label lblrecordDesc;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedAt;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedBy;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedAt;
        private MaterialSkin.Controls.MaterialButton matBtnEdit;
        private MaterialSkin.Controls.MaterialButton matBtnNew;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrimaryUnit;
        private System.Windows.Forms.Label lbltotalrecords;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_updated_by;
    }
}