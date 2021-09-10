
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimaryUnit));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtmatPrimaryUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.txtCreatedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvPrimaryUnit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.txtCreatedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.matBtnNew = new System.Windows.Forms.ToolStripButton();
            this.matBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryUnit)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.materialCard1.Location = new System.Drawing.Point(49, 172);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1769, 157);
            this.materialCard1.TabIndex = 621;
            // 
            // txtmatPrimaryUnit
            // 
            this.txtmatPrimaryUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatPrimaryUnit.Depth = 0;
            this.txtmatPrimaryUnit.Enabled = false;
            this.txtmatPrimaryUnit.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.metroSave.Location = new System.Drawing.Point(1023, 403);
            this.metroSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(181, 48);
            this.metroSave.TabIndex = 630;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Depth = 0;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedAt.Hint = "Created At";
            this.txtCreatedAt.Location = new System.Drawing.Point(745, 437);
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
            this.txtModifiedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedBy.Hint = "Modified By";
            this.txtModifiedBy.Location = new System.Drawing.Point(1708, 437);
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
            this.txtModifiedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedAt.Hint = "Modified At";
            this.txtModifiedAt.Location = new System.Drawing.Point(1396, 437);
            this.txtModifiedAt.MaxLength = 50;
            this.txtModifiedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedAt.Multiline = false;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedAt.TabIndex = 619;
            this.txtModifiedAt.Text = "";
            this.txtModifiedAt.Visible = false;
            // 
            // dgvPrimaryUnit
            // 
            this.dgvPrimaryUnit.AllowUserToAddRows = false;
            this.dgvPrimaryUnit.AllowUserToDeleteRows = false;
            this.dgvPrimaryUnit.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvPrimaryUnit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPrimaryUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrimaryUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrimaryUnit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrimaryUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimaryUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPrimaryUnit.ColumnHeadersHeight = 35;
            this.dgvPrimaryUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrimaryUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unit_id,
            this.unit_desc,
            this.pm_added_at,
            this.pm_added_by,
            this.pm_updated_at,
            this.pm_updated_by});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrimaryUnit.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPrimaryUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrimaryUnit.EnableHeadersVisualStyles = false;
            this.dgvPrimaryUnit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvPrimaryUnit.Location = new System.Drawing.Point(14, 14);
            this.dgvPrimaryUnit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPrimaryUnit.MultiSelect = false;
            this.dgvPrimaryUnit.Name = "dgvPrimaryUnit";
            this.dgvPrimaryUnit.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrimaryUnit.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPrimaryUnit.RowHeadersVisible = false;
            this.dgvPrimaryUnit.RowHeadersWidth = 102;
            this.dgvPrimaryUnit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrimaryUnit.RowTemplate.DividerHeight = 5;
            this.dgvPrimaryUnit.RowTemplate.Height = 40;
            this.dgvPrimaryUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrimaryUnit.Size = new System.Drawing.Size(1741, 690);
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
            // 
            // pm_added_at
            // 
            this.pm_added_at.DataPropertyName = "pm_added_at";
            this.pm_added_at.FillWeight = 99.49239F;
            this.pm_added_at.HeaderText = "Created Date";
            this.pm_added_at.MinimumWidth = 12;
            this.pm_added_at.Name = "pm_added_at";
            this.pm_added_at.ReadOnly = true;
            // 
            // pm_added_by
            // 
            this.pm_added_by.DataPropertyName = "pm_added_by";
            this.pm_added_by.FillWeight = 99.49239F;
            this.pm_added_by.HeaderText = "Created By";
            this.pm_added_by.MinimumWidth = 12;
            this.pm_added_by.Name = "pm_added_by";
            this.pm_added_by.ReadOnly = true;
            // 
            // pm_updated_at
            // 
            this.pm_updated_at.DataPropertyName = "pm_updated_at";
            this.pm_updated_at.FillWeight = 99.49239F;
            this.pm_updated_at.HeaderText = "Updated Date";
            this.pm_updated_at.MinimumWidth = 12;
            this.pm_updated_at.Name = "pm_updated_at";
            this.pm_updated_at.ReadOnly = true;
            // 
            // pm_updated_by
            // 
            this.pm_updated_by.DataPropertyName = "pm_updated_by";
            this.pm_updated_by.HeaderText = "Updated By";
            this.pm_updated_by.MinimumWidth = 12;
            this.pm_updated_by.Name = "pm_updated_by";
            this.pm_updated_by.ReadOnly = true;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvPrimaryUnit);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(49, 501);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1769, 718);
            this.materialCard2.TabIndex = 620;
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(1347, 403);
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
            this.txtCreatedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedBy.Hint = "Created By";
            this.txtCreatedBy.Location = new System.Drawing.Point(1077, 437);
            this.txtCreatedBy.MaxLength = 50;
            this.txtCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedBy.Multiline = false;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedBy.TabIndex = 626;
            this.txtCreatedBy.Text = "";
            this.txtCreatedBy.Visible = false;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(1670, 1226);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(121, 85);
            this.lbltotalrecords.TabIndex = 632;
            this.lbltotalrecords.Text = "76";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.Location = new System.Drawing.Point(1678, 1311);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 633;
            this.label2.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(49, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 85);
            this.panel1.TabIndex = 634;
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
            this.toolStrip2.Size = new System.Drawing.Size(857, 85);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // matBtnNew
            // 
            this.matBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("matBtnNew.Image")));
            this.matBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(122, 78);
            this.matBtnNew.Text = "&New";
            this.matBtnNew.Click += new System.EventHandler(this.neww_Click);
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEdit.Image")));
            this.matBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(112, 78);
            this.matBtnEdit.Text = "&Edit";
            this.matBtnEdit.Click += new System.EventHandler(this.editt_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(169, 78);
            this.matBtnDelete.Text = "&Remove";
            this.matBtnDelete.Click += new System.EventHandler(this.removee_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(123, 78);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.savee_Click);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(150, 78);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.canceel_Click);
            // 
            // frmPrimaryUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 1362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.txtModifiedAt);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.txtCreatedBy);
            this.Name = "frmPrimaryUnit";
            this.Text = "Primary Unit";
            this.Load += new System.EventHandler(this.frmPrimaryUnit_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryUnit)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtmatPrimaryUnit;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedAt;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedBy;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedAt;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrimaryUnit;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_updated_by;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton matBtnNew;
        private System.Windows.Forms.ToolStripButton matBtnEdit;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
    }
}