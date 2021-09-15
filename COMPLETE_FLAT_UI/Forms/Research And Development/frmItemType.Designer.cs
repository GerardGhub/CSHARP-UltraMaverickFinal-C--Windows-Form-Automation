
namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    partial class frmItemType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemType));
            this.dgvItemType = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtmatItemType = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCreatedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.txtCreatedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.matBtnNew = new System.Windows.Forms.ToolStripButton();
            this.matBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.item_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_type_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemType)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemType
            // 
            this.dgvItemType.AllowUserToAddRows = false;
            this.dgvItemType.AllowUserToDeleteRows = false;
            this.dgvItemType.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvItemType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItemType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemType.ColumnHeadersHeight = 35;
            this.dgvItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_type_id,
            this.item_type_desc,
            this.it_added_at,
            this.it_added_by,
            this.it_updated_at,
            this.it_updated_by});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemType.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemType.EnableHeadersVisualStyles = false;
            this.dgvItemType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.Location = new System.Drawing.Point(14, 14);
            this.dgvItemType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvItemType.MultiSelect = false;
            this.dgvItemType.Name = "dgvItemType";
            this.dgvItemType.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemType.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemType.RowHeadersVisible = false;
            this.dgvItemType.RowHeadersWidth = 102;
            this.dgvItemType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItemType.RowTemplate.DividerHeight = 5;
            this.dgvItemType.RowTemplate.Height = 40;
            this.dgvItemType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemType.Size = new System.Drawing.Size(1741, 697);
            this.dgvItemType.TabIndex = 593;
            this.dgvItemType.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvItemType.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemType.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvItemType.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvItemType.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemType.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvItemType.ThemeStyle.ReadOnly = true;
            this.dgvItemType.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItemType.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItemType.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvItemType.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvItemType.ThemeStyle.RowsStyle.Height = 40;
            this.dgvItemType.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvItemType.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItemType.CurrentCellChanged += new System.EventHandler(this.dgvItemType_CurrentCellChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtmatItemType);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(36, 168);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1769, 161);
            this.materialCard1.TabIndex = 634;
            // 
            // txtmatItemType
            // 
            this.txtmatItemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatItemType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatItemType.Depth = 0;
            this.txtmatItemType.Enabled = false;
            this.txtmatItemType.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatItemType.Hint = "Item Type";
            this.txtmatItemType.Location = new System.Drawing.Point(36, 32);
            this.txtmatItemType.MaxLength = 50;
            this.txtmatItemType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatItemType.Multiline = false;
            this.txtmatItemType.Name = "txtmatItemType";
            this.txtmatItemType.Size = new System.Drawing.Size(1706, 50);
            this.txtmatItemType.TabIndex = 0;
            this.txtmatItemType.Text = "";
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Depth = 0;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedAt.Hint = "Created At";
            this.txtCreatedAt.Location = new System.Drawing.Point(732, 474);
            this.txtCreatedAt.MaxLength = 50;
            this.txtCreatedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedAt.Multiline = false;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedAt.TabIndex = 638;
            this.txtCreatedAt.Text = "";
            this.txtCreatedAt.Visible = false;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedAt.Depth = 0;
            this.txtModifiedAt.Enabled = false;
            this.txtModifiedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedAt.Hint = "Modified At";
            this.txtModifiedAt.Location = new System.Drawing.Point(1458, 110);
            this.txtModifiedAt.MaxLength = 50;
            this.txtModifiedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedAt.Multiline = false;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedAt.TabIndex = 632;
            this.txtModifiedAt.Text = "";
            this.txtModifiedAt.Visible = false;
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(1010, 329);
            this.metroSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(181, 48);
            this.metroSave.TabIndex = 643;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvItemType);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(36, 538);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1769, 725);
            this.materialCard2.TabIndex = 633;
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(1334, 329);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(181, 48);
            this.metroFinalSaving.TabIndex = 644;
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
            this.txtCreatedBy.Location = new System.Drawing.Point(763, 90);
            this.txtCreatedBy.MaxLength = 50;
            this.txtCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedBy.Multiline = false;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedBy.TabIndex = 639;
            this.txtCreatedBy.Text = "";
            this.txtCreatedBy.Visible = false;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedBy.Depth = 0;
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedBy.Hint = "Modified By";
            this.txtModifiedBy.Location = new System.Drawing.Point(1087, 90);
            this.txtModifiedBy.MaxLength = 50;
            this.txtModifiedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedBy.Multiline = false;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedBy.TabIndex = 637;
            this.txtModifiedBy.Text = "";
            this.txtModifiedBy.Visible = false;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(1579, 1265);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(121, 85);
            this.lbltotalrecords.TabIndex = 645;
            this.lbltotalrecords.Text = "76";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(1691, 1301);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 646;
            this.label2.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(36, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 85);
            this.panel1.TabIndex = 647;
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
            this.matBtnNew.Click += new System.EventHandler(this.New_Click);
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEdit.Image")));
            this.matBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(112, 78);
            this.matBtnEdit.Text = "&Edit";
            this.matBtnEdit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(169, 78);
            this.matBtnDelete.Text = "&Remove";
            this.matBtnDelete.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(123, 78);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(150, 78);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(1258, 406);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(547, 50);
            this.mattxtSearch.TabIndex = 648;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            // 
            // item_type_id
            // 
            this.item_type_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.item_type_id.DataPropertyName = "item_type_id";
            this.item_type_id.FillWeight = 40.60914F;
            this.item_type_id.HeaderText = "ID";
            this.item_type_id.MinimumWidth = 12;
            this.item_type_id.Name = "item_type_id";
            this.item_type_id.ReadOnly = true;
            this.item_type_id.Width = 12;
            // 
            // item_type_desc
            // 
            this.item_type_desc.DataPropertyName = "item_type_desc";
            this.item_type_desc.FillWeight = 99.49239F;
            this.item_type_desc.HeaderText = "ITEM CLASS";
            this.item_type_desc.MinimumWidth = 12;
            this.item_type_desc.Name = "item_type_desc";
            this.item_type_desc.ReadOnly = true;
            // 
            // it_added_at
            // 
            this.it_added_at.DataPropertyName = "it_added_at";
            this.it_added_at.FillWeight = 99.49239F;
            this.it_added_at.HeaderText = "CREATED DATE";
            this.it_added_at.MinimumWidth = 12;
            this.it_added_at.Name = "it_added_at";
            this.it_added_at.ReadOnly = true;
            // 
            // it_added_by
            // 
            this.it_added_by.DataPropertyName = "it_added_by";
            this.it_added_by.FillWeight = 99.49239F;
            this.it_added_by.HeaderText = "CREATED BY";
            this.it_added_by.MinimumWidth = 12;
            this.it_added_by.Name = "it_added_by";
            this.it_added_by.ReadOnly = true;
            // 
            // it_updated_at
            // 
            this.it_updated_at.DataPropertyName = "it_updated_at";
            this.it_updated_at.FillWeight = 99.49239F;
            this.it_updated_at.HeaderText = "UPDATED DATE";
            this.it_updated_at.MinimumWidth = 12;
            this.it_updated_at.Name = "it_updated_at";
            this.it_updated_at.ReadOnly = true;
            // 
            // it_updated_by
            // 
            this.it_updated_by.DataPropertyName = "it_updated_by";
            this.it_updated_by.HeaderText = "UPDATED BY";
            this.it_updated_by.MinimumWidth = 12;
            this.it_updated_by.Name = "it_updated_by";
            this.it_updated_by.ReadOnly = true;
            // 
            // frmItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 1359);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtModifiedAt);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtModifiedBy);
            this.Name = "frmItemType";
            this.Text = "Item Type";
            this.Load += new System.EventHandler(this.frmItemType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemType)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvItemType;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtmatItemType;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedAt;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedAt;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedBy;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedBy;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton matBtnNew;
        private System.Windows.Forms.ToolStripButton matBtnEdit;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_updated_by;
    }
}