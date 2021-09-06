
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtSubCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvSubCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.lblrecordDesc = new System.Windows.Forms.Label();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.matBtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.matBtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.txtCreatedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCreatedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.matBtnNew = new MaterialSkin.Controls.MaterialButton();
            this.sub_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_category_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtSubCategory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(50, 125);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1769, 101);
            this.materialCard1.TabIndex = 608;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubCategory.Depth = 0;
            this.txtSubCategory.Enabled = false;
            this.txtSubCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSubCategory.Hint = "Sub Category";
            this.txtSubCategory.Location = new System.Drawing.Point(36, 19);
            this.txtSubCategory.MaxLength = 50;
            this.txtSubCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubCategory.Multiline = false;
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(1706, 50);
            this.txtSubCategory.TabIndex = 0;
            this.txtSubCategory.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvSubCategory);
            this.materialCard2.Controls.Add(this.lbltotalrecords);
            this.materialCard2.Controls.Add(this.lblrecordDesc);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(50, 392);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1769, 669);
            this.materialCard2.TabIndex = 607;
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AllowUserToAddRows = false;
            this.dgvSubCategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSubCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSubCategory.ColumnHeadersHeight = 35;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sub_category_id,
            this.sub_category_desc,
            this.sc_added_at,
            this.sc_added_by,
            this.sc_updated_at,
            this.sc_updated_by});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubCategory.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSubCategory.EnableHeadersVisualStyles = false;
            this.dgvSubCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.Location = new System.Drawing.Point(36, 48);
            this.dgvSubCategory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSubCategory.RowHeadersVisible = false;
            this.dgvSubCategory.RowHeadersWidth = 102;
            this.dgvSubCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubCategory.RowTemplate.DividerHeight = 5;
            this.dgvSubCategory.RowTemplate.Height = 40;
            this.dgvSubCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubCategory.Size = new System.Drawing.Size(1706, 539);
            this.dgvSubCategory.TabIndex = 593;
            this.dgvSubCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSubCategory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvSubCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvSubCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubCategory.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSubCategory.ThemeStyle.ReadOnly = true;
            this.dgvSubCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSubCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvSubCategory.ThemeStyle.RowsStyle.Height = 40;
            this.dgvSubCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvSubCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSubCategory.CurrentCellChanged += new System.EventHandler(this.dgvMajorCategory_CurrentCellChanged);
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
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(1348, 240);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(181, 48);
            this.metroFinalSaving.TabIndex = 618;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            this.metroFinalSaving.Click += new System.EventHandler(this.metroFinalSaving_Click);
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(1024, 240);
            this.metroSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(181, 48);
            this.metroSave.TabIndex = 617;
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
            this.matBtnSave.Location = new System.Drawing.Point(258, 276);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 616;
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
            this.matBtnDelete.Location = new System.Drawing.Point(416, 275);
            this.matBtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(80, 36);
            this.matBtnDelete.TabIndex = 615;
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
            this.matBtnCancel.Location = new System.Drawing.Point(584, 275);
            this.matBtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matBtnCancel.TabIndex = 614;
            this.matBtnCancel.Text = "CANCEL";
            this.matBtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnCancel.UseAccentColor = false;
            this.matBtnCancel.UseVisualStyleBackColor = true;
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.matBtnCancel_Click);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Depth = 0;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedBy.Hint = "Created By";
            this.txtCreatedBy.Location = new System.Drawing.Point(1078, 295);
            this.txtCreatedBy.MaxLength = 50;
            this.txtCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedBy.Multiline = false;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedBy.TabIndex = 613;
            this.txtCreatedBy.Text = "";
            this.txtCreatedBy.Visible = false;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Depth = 0;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedAt.Hint = "Created At";
            this.txtCreatedAt.Location = new System.Drawing.Point(746, 295);
            this.txtCreatedAt.MaxLength = 50;
            this.txtCreatedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedAt.Multiline = false;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedAt.TabIndex = 612;
            this.txtCreatedAt.Text = "";
            this.txtCreatedAt.Visible = false;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedBy.Depth = 0;
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedBy.Hint = "Modified By";
            this.txtModifiedBy.Location = new System.Drawing.Point(1709, 295);
            this.txtModifiedBy.MaxLength = 50;
            this.txtModifiedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedBy.Multiline = false;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedBy.TabIndex = 611;
            this.txtModifiedBy.Text = "";
            this.txtModifiedBy.Visible = false;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedAt.Depth = 0;
            this.txtModifiedAt.Enabled = false;
            this.txtModifiedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedAt.Hint = "Modified At";
            this.txtModifiedAt.Location = new System.Drawing.Point(1397, 295);
            this.txtModifiedAt.MaxLength = 50;
            this.txtModifiedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedAt.Multiline = false;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedAt.TabIndex = 606;
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
            this.matBtnEdit.Location = new System.Drawing.Point(262, 275);
            this.matBtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matBtnEdit.TabIndex = 610;
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
            this.matBtnNew.Location = new System.Drawing.Point(86, 275);
            this.matBtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(53, 36);
            this.matBtnNew.TabIndex = 609;
            this.matBtnNew.Text = "NEW";
            this.matBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnNew.UseAccentColor = false;
            this.matBtnNew.UseVisualStyleBackColor = true;
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
            // 
            // sub_category_id
            // 
            this.sub_category_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sub_category_id.DataPropertyName = "sub_category_id";
            this.sub_category_id.FillWeight = 40.60914F;
            this.sub_category_id.HeaderText = "ID";
            this.sub_category_id.MinimumWidth = 12;
            this.sub_category_id.Name = "sub_category_id";
            this.sub_category_id.ReadOnly = true;
            this.sub_category_id.Width = 12;
            // 
            // sub_category_desc
            // 
            this.sub_category_desc.DataPropertyName = "sub_category_desc";
            this.sub_category_desc.FillWeight = 99.49239F;
            this.sub_category_desc.HeaderText = "Item Class";
            this.sub_category_desc.MinimumWidth = 12;
            this.sub_category_desc.Name = "sub_category_desc";
            this.sub_category_desc.ReadOnly = true;
            this.sub_category_desc.Width = 189;
            // 
            // sc_added_at
            // 
            this.sc_added_at.DataPropertyName = "sc_added_at";
            this.sc_added_at.FillWeight = 99.49239F;
            this.sc_added_at.HeaderText = "Created Date";
            this.sc_added_at.MinimumWidth = 12;
            this.sc_added_at.Name = "sc_added_at";
            this.sc_added_at.ReadOnly = true;
            this.sc_added_at.Width = 225;
            // 
            // sc_added_by
            // 
            this.sc_added_by.DataPropertyName = "sc_added_by";
            this.sc_added_by.FillWeight = 99.49239F;
            this.sc_added_by.HeaderText = "Created By";
            this.sc_added_by.MinimumWidth = 12;
            this.sc_added_by.Name = "sc_added_by";
            this.sc_added_by.ReadOnly = true;
            this.sc_added_by.Width = 197;
            // 
            // sc_updated_at
            // 
            this.sc_updated_at.DataPropertyName = "sc_updated_at";
            this.sc_updated_at.FillWeight = 99.49239F;
            this.sc_updated_at.HeaderText = "Updated Date";
            this.sc_updated_at.MinimumWidth = 12;
            this.sc_updated_at.Name = "sc_updated_at";
            this.sc_updated_at.ReadOnly = true;
            this.sc_updated_at.Width = 236;
            // 
            // sc_updated_by
            // 
            this.sc_updated_by.DataPropertyName = "sc_updated_by";
            this.sc_updated_by.HeaderText = "Updated By";
            this.sc_updated_by.MinimumWidth = 12;
            this.sc_updated_by.Name = "sc_updated_by";
            this.sc_updated_by.ReadOnly = true;
            this.sc_updated_by.Width = 208;
            // 
            // frmSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1083);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialCard2);
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
            this.Name = "frmSubCategory";
            this.Text = "Sub Category";
            this.Load += new System.EventHandler(this.frmSubCategory_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtSubCategory;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSubCategory;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label lblrecordDesc;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MaterialSkin.Controls.MaterialButton matBtnDelete;
        private MaterialSkin.Controls.MaterialButton matBtnCancel;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedBy;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedAt;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedBy;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedAt;
        private MaterialSkin.Controls.MaterialButton matBtnEdit;
        private MaterialSkin.Controls.MaterialButton matBtnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_category_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc_updated_by;
    }
}