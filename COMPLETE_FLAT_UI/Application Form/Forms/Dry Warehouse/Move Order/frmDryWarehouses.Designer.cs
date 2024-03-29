﻿
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
            this.dgvWarehousing = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtmatDescription = new MaterialSkin.Controls.MaterialTextBox();
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
            this.txtmatAccountTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.wh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wh_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wh_account_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wh_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wh_date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wh_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wh_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehousing)).BeginInit();
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
            // dgvWarehousing
            // 
            this.dgvWarehousing.AllowUserToAddRows = false;
            this.dgvWarehousing.AllowUserToDeleteRows = false;
            this.dgvWarehousing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvWarehousing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWarehousing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehousing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvWarehousing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWarehousing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarehousing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWarehousing.ColumnHeadersHeight = 35;
            this.dgvWarehousing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWarehousing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wh_id,
            this.wh_description,
            this.wh_account_title,
            this.wh_added_by,
            this.wh_date_added,
            this.wh_updated_by,
            this.wh_updated_at});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWarehousing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWarehousing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWarehousing.EnableHeadersVisualStyles = false;
            this.dgvWarehousing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvWarehousing.Location = new System.Drawing.Point(5, 6);
            this.dgvWarehousing.MultiSelect = false;
            this.dgvWarehousing.Name = "dgvWarehousing";
            this.dgvWarehousing.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarehousing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWarehousing.RowHeadersVisible = false;
            this.dgvWarehousing.RowHeadersWidth = 102;
            this.dgvWarehousing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvWarehousing.RowTemplate.DividerHeight = 5;
            this.dgvWarehousing.RowTemplate.Height = 40;
            this.dgvWarehousing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehousing.Size = new System.Drawing.Size(965, 452);
            this.dgvWarehousing.TabIndex = 593;
            this.dgvWarehousing.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvWarehousing.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvWarehousing.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvWarehousing.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvWarehousing.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvWarehousing.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvWarehousing.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvWarehousing.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvWarehousing.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvWarehousing.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvWarehousing.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWarehousing.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWarehousing.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWarehousing.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvWarehousing.ThemeStyle.ReadOnly = true;
            this.dgvWarehousing.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvWarehousing.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvWarehousing.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWarehousing.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvWarehousing.ThemeStyle.RowsStyle.Height = 40;
            this.dgvWarehousing.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvWarehousing.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvWarehousing.CurrentCellChanged += new System.EventHandler(this.dgvitemClass_CurrentCellChanged);
            this.dgvWarehousing.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvitemClass_DataBindingComplete);
            // 
            // txtmatDescription
            // 
            this.txtmatDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatDescription.Depth = 0;
            this.txtmatDescription.Enabled = false;
            this.txtmatDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatDescription.Hint = "Description";
            this.txtmatDescription.Location = new System.Drawing.Point(14, 16);
            this.txtmatDescription.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatDescription.MaxLength = 50;
            this.txtmatDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatDescription.Multiline = false;
            this.txtmatDescription.Name = "txtmatDescription";
            this.txtmatDescription.Size = new System.Drawing.Size(349, 50);
            this.txtmatDescription.TabIndex = 0;
            this.txtmatDescription.Text = "";
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
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("matBtnEdit.Image")));
            this.matBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(72, 33);
            this.matBtnEdit.Text = "&Edit";
            this.matBtnEdit.Click += new System.EventHandler(this.matBtnEdit_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(94, 33);
            this.matBtnDelete.Text = "&InActive";
            this.matBtnDelete.Click += new System.EventHandler(this.matBtnDelete_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("matBtnSave.Image")));
            this.matBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(77, 44);
            this.matBtnSave.Text = "&Save";
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("matBtnCancel.Image")));
            this.matBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(88, 44);
            this.matBtnCancel.Text = "&Cancel";
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.matBtnCancel_Click);
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
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
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
            this.metroFinalSaving.Click += new System.EventHandler(this.metroFinalSaving_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtmatAccountTitle);
            this.materialCard1.Controls.Add(this.mattxtSearch);
            this.materialCard1.Controls.Add(this.txtmatDescription);
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
            // txtmatAccountTitle
            // 
            this.txtmatAccountTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatAccountTitle.Depth = 0;
            this.txtmatAccountTitle.Enabled = false;
            this.txtmatAccountTitle.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatAccountTitle.Hint = "Account Title";
            this.txtmatAccountTitle.Location = new System.Drawing.Point(378, 15);
            this.txtmatAccountTitle.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatAccountTitle.MaxLength = 50;
            this.txtmatAccountTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatAccountTitle.Multiline = false;
            this.txtmatAccountTitle.Name = "txtmatAccountTitle";
            this.txtmatAccountTitle.Size = new System.Drawing.Size(349, 50);
            this.txtmatAccountTitle.TabIndex = 601;
            this.txtmatAccountTitle.Text = "";
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
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvWarehousing);
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
            // wh_id
            // 
            this.wh_id.DataPropertyName = "wh_id";
            this.wh_id.FillWeight = 40.60914F;
            this.wh_id.HeaderText = "ID";
            this.wh_id.MinimumWidth = 12;
            this.wh_id.Name = "wh_id";
            this.wh_id.ReadOnly = true;
            // 
            // wh_description
            // 
            this.wh_description.DataPropertyName = "wh_description";
            this.wh_description.FillWeight = 99.49239F;
            this.wh_description.HeaderText = "DESCRIPTION";
            this.wh_description.MinimumWidth = 12;
            this.wh_description.Name = "wh_description";
            this.wh_description.ReadOnly = true;
            // 
            // wh_account_title
            // 
            this.wh_account_title.DataPropertyName = "wh_account_title";
            this.wh_account_title.FillWeight = 99.49239F;
            this.wh_account_title.HeaderText = "ACCOUNT TITLE";
            this.wh_account_title.MinimumWidth = 12;
            this.wh_account_title.Name = "wh_account_title";
            this.wh_account_title.ReadOnly = true;
            // 
            // wh_added_by
            // 
            this.wh_added_by.DataPropertyName = "wh_added_by";
            this.wh_added_by.FillWeight = 99.49239F;
            this.wh_added_by.HeaderText = "CREATED BY";
            this.wh_added_by.MinimumWidth = 12;
            this.wh_added_by.Name = "wh_added_by";
            this.wh_added_by.ReadOnly = true;
            // 
            // wh_date_added
            // 
            this.wh_date_added.DataPropertyName = "wh_date_added";
            this.wh_date_added.FillWeight = 99.49239F;
            this.wh_date_added.HeaderText = "DATE ADDED";
            this.wh_date_added.MinimumWidth = 12;
            this.wh_date_added.Name = "wh_date_added";
            this.wh_date_added.ReadOnly = true;
            // 
            // wh_updated_by
            // 
            this.wh_updated_by.DataPropertyName = "wh_updated_by";
            this.wh_updated_by.HeaderText = "UPDATED BY";
            this.wh_updated_by.Name = "wh_updated_by";
            this.wh_updated_by.ReadOnly = true;
            // 
            // wh_updated_at
            // 
            this.wh_updated_at.DataPropertyName = "wh_updated_at";
            this.wh_updated_at.HeaderText = "UPDATED DATE";
            this.wh_updated_at.Name = "wh_updated_at";
            this.wh_updated_at.ReadOnly = true;
            // 
            // frmDryWarehouses
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
            this.Name = "frmDryWarehouses";
            this.Text = "Warehouses";
            this.Load += new System.EventHandler(this.frmWarehouses_Load);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehousing)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvWarehousing;
        private MaterialSkin.Controls.MaterialTextBox txtmatDescription;
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
        private MaterialSkin.Controls.MaterialTextBox txtmatAccountTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_account_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_updated_at;
    }
}