
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmAVGOrderTrendSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAVGOrderTrendSetup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioNotActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.matBtnSave = new System.Windows.Forms.ToolStripButton();
            this.matBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.matBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.matBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.txtmatavgdescription = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtmatAverageqty = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvAVGOrderTrend = new Guna.UI2.WinForms.Guna2DataGridView();
            this.avg_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVGOrderTrend)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.matRadioActive);
            this.materialCard3.Controls.Add(this.matRadioNotActive);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(766, 182);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(221, 59);
            this.materialCard3.TabIndex = 607;
            // 
            // matRadioActive
            // 
            this.matRadioActive.AutoSize = true;
            this.matRadioActive.Depth = 0;
            this.matRadioActive.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRadioActive.Location = new System.Drawing.Point(18, 14);
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
            this.matRadioNotActive.Location = new System.Drawing.Point(112, 14);
            this.matRadioNotActive.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioNotActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioNotActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioNotActive.Name = "matRadioNotActive";
            this.matRadioNotActive.Ripple = true;
            this.matRadioNotActive.Size = new System.Drawing.Size(91, 37);
            this.matRadioNotActive.TabIndex = 598;
            this.matRadioNotActive.TabStop = true;
            this.matRadioNotActive.Text = "InActive";
            this.matRadioNotActive.UseVisualStyleBackColor = true;
            this.matRadioNotActive.CheckedChanged += new System.EventHandler(this.matRadioNotActive_CheckedChanged);
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
            // matBtnDelete
            // 
            this.matBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("matBtnDelete.Image")));
            this.matBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(94, 33);
            this.matBtnDelete.Text = "&InActive";
            this.matBtnDelete.Click += new System.EventHandler(this.matBtnDelete_Click);
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
            // matBtnNew
            // 
            this.matBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("matBtnNew.Image")));
            this.matBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(75, 33);
            this.matBtnNew.Text = "&New";
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(35, 205);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 36);
            this.panel1.TabIndex = 604;
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(413, 204);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(1);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(68, 20);
            this.metroFinalSaving.TabIndex = 603;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(762, 37);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(197, 50);
            this.mattxtSearch.TabIndex = 600;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            this.mattxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtSearch_KeyPress);
            // 
            // txtmatavgdescription
            // 
            this.txtmatavgdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatavgdescription.Depth = 0;
            this.txtmatavgdescription.Enabled = false;
            this.txtmatavgdescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatavgdescription.Hint = "Average Description";
            this.txtmatavgdescription.Location = new System.Drawing.Point(23, 38);
            this.txtmatavgdescription.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatavgdescription.MaxLength = 50;
            this.txtmatavgdescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatavgdescription.Multiline = false;
            this.txtmatavgdescription.Name = "txtmatavgdescription";
            this.txtmatavgdescription.Size = new System.Drawing.Size(344, 50);
            this.txtmatavgdescription.TabIndex = 0;
            this.txtmatavgdescription.Text = "";
            this.txtmatavgdescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatavgdescription_KeyPress);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtmatAverageqty);
            this.materialCard1.Controls.Add(this.mattxtSearch);
            this.materialCard1.Controls.Add(this.txtmatavgdescription);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(22, 75);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(965, 100);
            this.materialCard1.TabIndex = 601;
            // 
            // txtmatAverageqty
            // 
            this.txtmatAverageqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatAverageqty.Depth = 0;
            this.txtmatAverageqty.Enabled = false;
            this.txtmatAverageqty.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatAverageqty.Hint = "Average Quantity";
            this.txtmatAverageqty.Location = new System.Drawing.Point(391, 37);
            this.txtmatAverageqty.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatAverageqty.MaxLength = 50;
            this.txtmatAverageqty.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatAverageqty.Multiline = false;
            this.txtmatAverageqty.Name = "txtmatAverageqty";
            this.txtmatAverageqty.Size = new System.Drawing.Size(344, 50);
            this.txtmatAverageqty.TabIndex = 601;
            this.txtmatAverageqty.Text = "";
            this.txtmatAverageqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatAverageqty_KeyPress);
            // 
            // dgvAVGOrderTrend
            // 
            this.dgvAVGOrderTrend.AllowUserToAddRows = false;
            this.dgvAVGOrderTrend.AllowUserToDeleteRows = false;
            this.dgvAVGOrderTrend.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAVGOrderTrend.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAVGOrderTrend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAVGOrderTrend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvAVGOrderTrend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAVGOrderTrend.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAVGOrderTrend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAVGOrderTrend.ColumnHeadersHeight = 35;
            this.dgvAVGOrderTrend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAVGOrderTrend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.avg_id,
            this.avg_desc,
            this.avg_days,
            this.added_by,
            this.date_added,
            this.updated_by,
            this.updated_date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAVGOrderTrend.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAVGOrderTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAVGOrderTrend.EnableHeadersVisualStyles = false;
            this.dgvAVGOrderTrend.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAVGOrderTrend.Location = new System.Drawing.Point(5, 6);
            this.dgvAVGOrderTrend.MultiSelect = false;
            this.dgvAVGOrderTrend.Name = "dgvAVGOrderTrend";
            this.dgvAVGOrderTrend.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAVGOrderTrend.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAVGOrderTrend.RowHeadersVisible = false;
            this.dgvAVGOrderTrend.RowHeadersWidth = 102;
            this.dgvAVGOrderTrend.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAVGOrderTrend.RowTemplate.DividerHeight = 5;
            this.dgvAVGOrderTrend.RowTemplate.Height = 40;
            this.dgvAVGOrderTrend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAVGOrderTrend.Size = new System.Drawing.Size(955, 454);
            this.dgvAVGOrderTrend.TabIndex = 593;
            this.dgvAVGOrderTrend.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAVGOrderTrend.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAVGOrderTrend.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvAVGOrderTrend.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAVGOrderTrend.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAVGOrderTrend.ThemeStyle.ReadOnly = true;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.Height = 40;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvAVGOrderTrend.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvAVGOrderTrend.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAVGOrderTrend_CellFormatting);
            this.dgvAVGOrderTrend.CurrentCellChanged += new System.EventHandler(this.dgvitemClass_CurrentCellChanged);
            // 
            // avg_id
            // 
            this.avg_id.DataPropertyName = "avg_id";
            this.avg_id.FillWeight = 40.60914F;
            this.avg_id.HeaderText = "ID";
            this.avg_id.MinimumWidth = 12;
            this.avg_id.Name = "avg_id";
            this.avg_id.ReadOnly = true;
            // 
            // avg_desc
            // 
            this.avg_desc.DataPropertyName = "avg_desc";
            this.avg_desc.FillWeight = 99.49239F;
            this.avg_desc.HeaderText = "DESCRIPTION";
            this.avg_desc.MinimumWidth = 12;
            this.avg_desc.Name = "avg_desc";
            this.avg_desc.ReadOnly = true;
            // 
            // avg_days
            // 
            this.avg_days.DataPropertyName = "avg_days";
            this.avg_days.FillWeight = 99.49239F;
            this.avg_days.HeaderText = "DAYS";
            this.avg_days.MinimumWidth = 12;
            this.avg_days.Name = "avg_days";
            this.avg_days.ReadOnly = true;
            // 
            // added_by
            // 
            this.added_by.DataPropertyName = "added_by";
            this.added_by.FillWeight = 99.49239F;
            this.added_by.HeaderText = "ADDED BY";
            this.added_by.MinimumWidth = 12;
            this.added_by.Name = "added_by";
            this.added_by.ReadOnly = true;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.FillWeight = 99.49239F;
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.MinimumWidth = 12;
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // updated_by
            // 
            this.updated_by.DataPropertyName = "updated_by";
            this.updated_by.HeaderText = "UPDATED BY";
            this.updated_by.Name = "updated_by";
            this.updated_by.ReadOnly = true;
            // 
            // updated_date
            // 
            this.updated_date.DataPropertyName = "updated_date";
            this.updated_date.HeaderText = "UPDATED DATE";
            this.updated_date.Name = "updated_date";
            this.updated_date.ReadOnly = true;
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(400, 182);
            this.metroSave.Margin = new System.Windows.Forms.Padding(1);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(68, 20);
            this.metroSave.TabIndex = 602;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvAVGOrderTrend);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(22, 246);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(965, 466);
            this.materialCard2.TabIndex = 600;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(861, 725);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(33, 36);
            this.lbltotalrecords.TabIndex = 608;
            this.lbltotalrecords.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.Location = new System.Drawing.Point(928, 737);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 609;
            this.label2.Text = "Items";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmAVGOrderTrendSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.materialCard2);
            this.Name = "frmAVGOrderTrendSetup";
            this.Sizable = false;
            this.Text = "Average Order Trend";
            this.Load += new System.EventHandler(this.frmAVGOrderTrendSetup_Load);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVGOrderTrend)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton matRadioActive;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotActive;
        private System.Windows.Forms.ToolStripButton matBtnCancel;
        private System.Windows.Forms.ToolStripButton matBtnSave;
        private System.Windows.Forms.ToolStripButton matBtnDelete;
        private System.Windows.Forms.ToolStripButton matBtnEdit;
        private System.Windows.Forms.ToolStripButton matBtnNew;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private MaterialSkin.Controls.MaterialTextBox txtmatavgdescription;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAVGOrderTrend;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox txtmatAverageqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalrecords;
    }
}