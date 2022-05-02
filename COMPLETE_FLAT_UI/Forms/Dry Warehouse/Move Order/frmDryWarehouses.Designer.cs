
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    partial class frmDryWarehouses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDryWarehouses));
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioNotActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.dgvitemClass = new Guna.UI2.WinForms.Guna2DataGridView();
            this.item_class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_class_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmatItemClass = new MaterialSkin.Controls.MaterialTextBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.matBtnNew = new System.Windows.Forms.ToolStripButton();
            this.matBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemClass)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(962, 726);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 617;
            this.label2.Text = "Items";
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.matRadioActive);
            this.materialCard3.Controls.Add(this.matRadioNotActive);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(779, 180);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(221, 59);
            this.materialCard3.TabIndex = 615;
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
            // 
            // dgvitemClass
            // 
            this.dgvitemClass.AllowUserToAddRows = false;
            this.dgvitemClass.AllowUserToDeleteRows = false;
            this.dgvitemClass.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvitemClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitemClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitemClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvitemClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvitemClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitemClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvitemClass.ColumnHeadersHeight = 35;
            this.dgvitemClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvitemClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_class_id,
            this.item_class_desc,
            this.item_added_at,
            this.item_added_by,
            this.item_updated_at,
            this.item_updated_by});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvitemClass.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvitemClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvitemClass.EnableHeadersVisualStyles = false;
            this.dgvitemClass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvitemClass.Location = new System.Drawing.Point(5, 6);
            this.dgvitemClass.MultiSelect = false;
            this.dgvitemClass.Name = "dgvitemClass";
            this.dgvitemClass.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitemClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvitemClass.RowHeadersVisible = false;
            this.dgvitemClass.RowHeadersWidth = 102;
            this.dgvitemClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvitemClass.RowTemplate.DividerHeight = 5;
            this.dgvitemClass.RowTemplate.Height = 40;
            this.dgvitemClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitemClass.Size = new System.Drawing.Size(965, 452);
            this.dgvitemClass.TabIndex = 593;
            this.dgvitemClass.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvitemClass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvitemClass.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvitemClass.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvitemClass.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvitemClass.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvitemClass.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitemClass.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvitemClass.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvitemClass.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvitemClass.ThemeStyle.ReadOnly = true;
            this.dgvitemClass.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvitemClass.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvitemClass.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvitemClass.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvitemClass.ThemeStyle.RowsStyle.Height = 40;
            this.dgvitemClass.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvitemClass.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            // 
            // item_class_id
            // 
            this.item_class_id.DataPropertyName = "item_class_id";
            this.item_class_id.FillWeight = 40.60914F;
            this.item_class_id.HeaderText = "ID";
            this.item_class_id.MinimumWidth = 12;
            this.item_class_id.Name = "item_class_id";
            this.item_class_id.ReadOnly = true;
            // 
            // item_class_desc
            // 
            this.item_class_desc.DataPropertyName = "item_class_desc";
            this.item_class_desc.FillWeight = 99.49239F;
            this.item_class_desc.HeaderText = "ITEM CLASS";
            this.item_class_desc.MinimumWidth = 12;
            this.item_class_desc.Name = "item_class_desc";
            this.item_class_desc.ReadOnly = true;
            // 
            // item_added_at
            // 
            this.item_added_at.DataPropertyName = "item_added_at";
            this.item_added_at.FillWeight = 99.49239F;
            this.item_added_at.HeaderText = "CREATED DATE";
            this.item_added_at.MinimumWidth = 12;
            this.item_added_at.Name = "item_added_at";
            this.item_added_at.ReadOnly = true;
            // 
            // item_added_by
            // 
            this.item_added_by.DataPropertyName = "item_added_by";
            this.item_added_by.FillWeight = 99.49239F;
            this.item_added_by.HeaderText = "CREATED BY";
            this.item_added_by.MinimumWidth = 12;
            this.item_added_by.Name = "item_added_by";
            this.item_added_by.ReadOnly = true;
            // 
            // item_updated_at
            // 
            this.item_updated_at.DataPropertyName = "item_updated_at";
            this.item_updated_at.FillWeight = 99.49239F;
            this.item_updated_at.HeaderText = "UPDATED DATE";
            this.item_updated_at.MinimumWidth = 12;
            this.item_updated_at.Name = "item_updated_at";
            this.item_updated_at.ReadOnly = true;
            // 
            // item_updated_by
            // 
            this.item_updated_by.DataPropertyName = "item_updated_by";
            this.item_updated_by.HeaderText = "UPDATED BY";
            this.item_updated_by.MinimumWidth = 12;
            this.item_updated_by.Name = "item_updated_by";
            this.item_updated_by.ReadOnly = true;
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
            this.txtmatItemClass.Location = new System.Drawing.Point(14, 16);
            this.txtmatItemClass.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatItemClass.MaxLength = 50;
            this.txtmatItemClass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatItemClass.Multiline = false;
            this.txtmatItemClass.Name = "txtmatItemClass";
            this.txtmatItemClass.Size = new System.Drawing.Size(738, 50);
            this.txtmatItemClass.TabIndex = 0;
            this.txtmatItemClass.Text = "";
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(900, 714);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(31, 35);
            this.lbltotalrecords.TabIndex = 616;
            this.lbltotalrecords.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(38, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 36);
            this.panel1.TabIndex = 614;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEdit.Image")));
            this.matBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(72, 33);
            this.matBtnEdit.Text = "&Edit";
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(94, 33);
            this.matBtnDelete.Text = "&InActive";
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(77, 44);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(88, 44);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(763, 15);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(205, 50);
            this.mattxtSearch.TabIndex = 600;
            this.mattxtSearch.Text = "";
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(416, 202);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(1);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(68, 20);
            this.metroFinalSaving.TabIndex = 613;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mattxtSearch);
            this.materialCard1.Controls.Add(this.txtmatItemClass);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(25, 73);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(975, 87);
            this.materialCard1.TabIndex = 611;
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(403, 180);
            this.metroSave.Margin = new System.Windows.Forms.Padding(1);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(68, 20);
            this.metroSave.TabIndex = 612;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvitemClass);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(25, 244);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(975, 464);
            this.materialCard2.TabIndex = 610;
            // 
            // frmWarehouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.materialCard2);
            this.MaximizeBox = false;
            this.Name = "frmWarehouses";
            this.Text = "Warehouses";
            this.Load += new System.EventHandler(this.frmWarehouses_Load);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemClass)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton matRadioActive;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotActive;
        private Guna.UI2.WinForms.Guna2DataGridView dgvitemClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_class_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_updated_by;
        private MaterialSkin.Controls.MaterialTextBox txtmatItemClass;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton matBtnNew;
        private System.Windows.Forms.ToolStripButton matBtnEdit;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}