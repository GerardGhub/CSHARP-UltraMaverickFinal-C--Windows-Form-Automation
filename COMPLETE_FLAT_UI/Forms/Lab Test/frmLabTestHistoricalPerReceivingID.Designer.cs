
namespace ULTRAMAVERICK.Forms.Lab_Test
{
    partial class frmLabTestHistoricalPerReceivingID
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
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WizardBalloon4 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.WizardBalloon3 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.WizardBalloon2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.WizardBalloon1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvRawMats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fk_receiving_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAYSTOEXPIRED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STANDARDEXPIRYDAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HISTORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_result_remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_sub_remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_request_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qa_approval_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_exp_date_extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPattern4 = new System.Windows.Forms.Label();
            this.lblPattern3 = new System.Windows.Forms.Label();
            this.lblPattern2 = new System.Windows.Forms.Label();
            this.lblPattern1 = new System.Windows.Forms.Label();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon1)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(892, 551);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(31, 35);
            this.lbltotalrecords.TabIndex = 679;
            this.lbltotalrecords.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(944, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 680;
            this.label2.Text = "Items";
            // 
            // WizardBalloon4
            // 
            this.WizardBalloon4.Cursor = System.Windows.Forms.Cursors.Default;
            this.WizardBalloon4.Enabled = false;
            this.WizardBalloon4.FillColor = System.Drawing.Color.Transparent;
            this.WizardBalloon4.Image = global::ULTRAMAVERICK.Properties.Resources.pending;
            this.WizardBalloon4.ImageRotate = 0F;
            this.WizardBalloon4.Location = new System.Drawing.Point(590, 95);
            this.WizardBalloon4.Name = "WizardBalloon4";
            this.WizardBalloon4.ShadowDecoration.Parent = this.WizardBalloon4;
            this.WizardBalloon4.Size = new System.Drawing.Size(45, 45);
            this.WizardBalloon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WizardBalloon4.TabIndex = 673;
            this.WizardBalloon4.TabStop = false;
            // 
            // WizardBalloon3
            // 
            this.WizardBalloon3.Cursor = System.Windows.Forms.Cursors.Default;
            this.WizardBalloon3.Enabled = false;
            this.WizardBalloon3.FillColor = System.Drawing.Color.Transparent;
            this.WizardBalloon3.Image = global::ULTRAMAVERICK.Properties.Resources.pending;
            this.WizardBalloon3.ImageRotate = 0F;
            this.WizardBalloon3.Location = new System.Drawing.Point(406, 95);
            this.WizardBalloon3.Name = "WizardBalloon3";
            this.WizardBalloon3.ShadowDecoration.Parent = this.WizardBalloon3;
            this.WizardBalloon3.Size = new System.Drawing.Size(45, 45);
            this.WizardBalloon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WizardBalloon3.TabIndex = 672;
            this.WizardBalloon3.TabStop = false;
            // 
            // WizardBalloon2
            // 
            this.WizardBalloon2.Cursor = System.Windows.Forms.Cursors.Default;
            this.WizardBalloon2.Enabled = false;
            this.WizardBalloon2.FillColor = System.Drawing.Color.Transparent;
            this.WizardBalloon2.Image = global::ULTRAMAVERICK.Properties.Resources.pending;
            this.WizardBalloon2.ImageRotate = 0F;
            this.WizardBalloon2.Location = new System.Drawing.Point(216, 95);
            this.WizardBalloon2.Name = "WizardBalloon2";
            this.WizardBalloon2.ShadowDecoration.Parent = this.WizardBalloon2;
            this.WizardBalloon2.Size = new System.Drawing.Size(45, 45);
            this.WizardBalloon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WizardBalloon2.TabIndex = 671;
            this.WizardBalloon2.TabStop = false;
            // 
            // WizardBalloon1
            // 
            this.WizardBalloon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.WizardBalloon1.Enabled = false;
            this.WizardBalloon1.FillColor = System.Drawing.Color.Transparent;
            this.WizardBalloon1.Image = global::ULTRAMAVERICK.Properties.Resources.current;
            this.WizardBalloon1.ImageRotate = 0F;
            this.WizardBalloon1.Location = new System.Drawing.Point(28, 95);
            this.WizardBalloon1.Name = "WizardBalloon1";
            this.WizardBalloon1.ShadowDecoration.Parent = this.WizardBalloon1;
            this.WizardBalloon1.Size = new System.Drawing.Size(45, 45);
            this.WizardBalloon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WizardBalloon1.TabIndex = 665;
            this.WizardBalloon1.TabStop = false;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvRawMats);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(28, 169);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(967, 376);
            this.materialCard2.TabIndex = 678;
            // 
            // dgvRawMats
            // 
            this.dgvRawMats.AllowUserToAddRows = false;
            this.dgvRawMats.AllowUserToDeleteRows = false;
            this.dgvRawMats.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRawMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRawMats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRawMats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRawMats.ColumnHeadersHeight = 45;
            this.dgvRawMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fk_receiving_id,
            this.item_code,
            this.item_desc,
            this.category,
            this.qty_received,
            this.remaining_qty,
            this.exp_date,
            this.DAYSTOEXPIRED,
            this.STANDARDEXPIRYDAYS,
            this.lab_status,
            this.HISTORY,
            this.AGING,
            this.lab_result_remarks,
            this.lab_sub_remarks,
            this.lab_request_by,
            this.qa_approval_by,
            this.lab_exp_date_extension});
            this.dgvRawMats.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMats.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRawMats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMats.EnableHeadersVisualStyles = false;
            this.dgvRawMats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.Location = new System.Drawing.Point(5, 6);
            this.dgvRawMats.MultiSelect = false;
            this.dgvRawMats.Name = "dgvRawMats";
            this.dgvRawMats.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRawMats.RowHeadersVisible = false;
            this.dgvRawMats.RowHeadersWidth = 102;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRawMats.RowTemplate.DividerHeight = 5;
            this.dgvRawMats.RowTemplate.Height = 40;
            this.dgvRawMats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMats.Size = new System.Drawing.Size(957, 364);
            this.dgvRawMats.TabIndex = 5;
            this.dgvRawMats.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvRawMats.ThemeStyle.ReadOnly = true;
            this.dgvRawMats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvRawMats.CurrentCellChanged += new System.EventHandler(this.dgvRawMats_CurrentCellChanged);
            // 
            // fk_receiving_id
            // 
            this.fk_receiving_id.DataPropertyName = "fk_receiving_id";
            this.fk_receiving_id.FillWeight = 40.60914F;
            this.fk_receiving_id.HeaderText = "ID";
            this.fk_receiving_id.MinimumWidth = 12;
            this.fk_receiving_id.Name = "fk_receiving_id";
            this.fk_receiving_id.ReadOnly = true;
            this.fk_receiving_id.Width = 49;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.FillWeight = 59.93546F;
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 106;
            // 
            // item_desc
            // 
            this.item_desc.DataPropertyName = "item_desc";
            this.item_desc.FillWeight = 97.00433F;
            this.item_desc.HeaderText = "ITEM DESCRIPTION";
            this.item_desc.MinimumWidth = 12;
            this.item_desc.Name = "item_desc";
            this.item_desc.ReadOnly = true;
            this.item_desc.Width = 159;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 114;
            // 
            // qty_received
            // 
            this.qty_received.DataPropertyName = "qty_received";
            this.qty_received.FillWeight = 77.07378F;
            this.qty_received.HeaderText = "QTY RECEIVED";
            this.qty_received.MinimumWidth = 12;
            this.qty_received.Name = "qty_received";
            this.qty_received.ReadOnly = true;
            this.qty_received.Width = 129;
            // 
            // remaining_qty
            // 
            this.remaining_qty.DataPropertyName = "remaining_qty";
            this.remaining_qty.HeaderText = "QTY";
            this.remaining_qty.Name = "remaining_qty";
            this.remaining_qty.ReadOnly = true;
            this.remaining_qty.Width = 65;
            // 
            // exp_date
            // 
            this.exp_date.DataPropertyName = "exp_date";
            this.exp_date.HeaderText = "EXPIRATION DATE";
            this.exp_date.Name = "exp_date";
            this.exp_date.ReadOnly = true;
            this.exp_date.Width = 150;
            // 
            // DAYSTOEXPIRED
            // 
            this.DAYSTOEXPIRED.DataPropertyName = "DAYSTOEXPIRED";
            this.DAYSTOEXPIRED.HeaderText = "DAYS TO EXPIRED";
            this.DAYSTOEXPIRED.Name = "DAYSTOEXPIRED";
            this.DAYSTOEXPIRED.ReadOnly = true;
            this.DAYSTOEXPIRED.Width = 151;
            // 
            // STANDARDEXPIRYDAYS
            // 
            this.STANDARDEXPIRYDAYS.DataPropertyName = "STANDARDEXPIRYDAYS";
            this.STANDARDEXPIRYDAYS.HeaderText = "STANDARD EXPIRY DAY";
            this.STANDARDEXPIRYDAYS.Name = "STANDARDEXPIRYDAYS";
            this.STANDARDEXPIRYDAYS.ReadOnly = true;
            this.STANDARDEXPIRYDAYS.Width = 161;
            // 
            // lab_status
            // 
            this.lab_status.DataPropertyName = "lab_status";
            this.lab_status.HeaderText = "STATUS";
            this.lab_status.Name = "lab_status";
            this.lab_status.ReadOnly = true;
            this.lab_status.Width = 92;
            // 
            // HISTORY
            // 
            this.HISTORY.DataPropertyName = "HISTORY";
            this.HISTORY.HeaderText = "HISTORY";
            this.HISTORY.Name = "HISTORY";
            this.HISTORY.ReadOnly = true;
            // 
            // AGING
            // 
            this.AGING.DataPropertyName = "AGING";
            this.AGING.HeaderText = "AGING";
            this.AGING.Name = "AGING";
            this.AGING.ReadOnly = true;
            this.AGING.Width = 81;
            // 
            // lab_result_remarks
            // 
            this.lab_result_remarks.DataPropertyName = "lab_result_remarks";
            this.lab_result_remarks.HeaderText = "REMARKS";
            this.lab_result_remarks.Name = "lab_result_remarks";
            this.lab_result_remarks.ReadOnly = true;
            this.lab_result_remarks.Width = 107;
            // 
            // lab_sub_remarks
            // 
            this.lab_sub_remarks.DataPropertyName = "lab_sub_remarks";
            this.lab_sub_remarks.HeaderText = "SUB REMARKS";
            this.lab_sub_remarks.Name = "lab_sub_remarks";
            this.lab_sub_remarks.ReadOnly = true;
            this.lab_sub_remarks.Width = 129;
            // 
            // lab_request_by
            // 
            this.lab_request_by.DataPropertyName = "lab_request_by";
            this.lab_request_by.HeaderText = "REQUEST BY";
            this.lab_request_by.Name = "lab_request_by";
            this.lab_request_by.ReadOnly = true;
            this.lab_request_by.Width = 116;
            // 
            // qa_approval_by
            // 
            this.qa_approval_by.DataPropertyName = "qa_approval_by";
            this.qa_approval_by.HeaderText = "QA APPROVED BY";
            this.qa_approval_by.Name = "qa_approval_by";
            this.qa_approval_by.ReadOnly = true;
            this.qa_approval_by.Width = 150;
            // 
            // lab_exp_date_extension
            // 
            this.lab_exp_date_extension.DataPropertyName = "lab_exp_date_extension";
            this.lab_exp_date_extension.HeaderText = "SHELF LIFE EXTENSION";
            this.lab_exp_date_extension.Name = "lab_exp_date_extension";
            this.lab_exp_date_extension.ReadOnly = true;
            this.lab_exp_date_extension.Width = 187;
            // 
            // lblPattern4
            // 
            this.lblPattern4.AutoSize = true;
            this.lblPattern4.BackColor = System.Drawing.Color.Transparent;
            this.lblPattern4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern4.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPattern4.Location = new System.Drawing.Point(638, 124);
            this.lblPattern4.Name = "lblPattern4";
            this.lblPattern4.Size = new System.Drawing.Size(23, 24);
            this.lblPattern4.TabIndex = 677;
            this.lblPattern4.Text = "◙";
            this.lblPattern4.Visible = false;
            this.lblPattern4.MouseHover += new System.EventHandler(this.lblPattern4_MouseHover);
            // 
            // lblPattern3
            // 
            this.lblPattern3.AutoSize = true;
            this.lblPattern3.BackColor = System.Drawing.Color.Transparent;
            this.lblPattern3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern3.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPattern3.Location = new System.Drawing.Point(455, 124);
            this.lblPattern3.Name = "lblPattern3";
            this.lblPattern3.Size = new System.Drawing.Size(23, 24);
            this.lblPattern3.TabIndex = 676;
            this.lblPattern3.Text = "◙";
            this.lblPattern3.Visible = false;
            this.lblPattern3.MouseHover += new System.EventHandler(this.lblPattern3_MouseHover);
            // 
            // lblPattern2
            // 
            this.lblPattern2.AutoSize = true;
            this.lblPattern2.BackColor = System.Drawing.Color.Transparent;
            this.lblPattern2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPattern2.Location = new System.Drawing.Point(266, 124);
            this.lblPattern2.Name = "lblPattern2";
            this.lblPattern2.Size = new System.Drawing.Size(23, 24);
            this.lblPattern2.TabIndex = 675;
            this.lblPattern2.Text = "◙";
            this.lblPattern2.Visible = false;
            this.lblPattern2.MouseHover += new System.EventHandler(this.lblPattern2_MouseHover);
            // 
            // lblPattern1
            // 
            this.lblPattern1.AutoSize = true;
            this.lblPattern1.BackColor = System.Drawing.Color.Transparent;
            this.lblPattern1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPattern1.Location = new System.Drawing.Point(78, 124);
            this.lblPattern1.Name = "lblPattern1";
            this.lblPattern1.Size = new System.Drawing.Size(23, 24);
            this.lblPattern1.TabIndex = 674;
            this.lblPattern1.Text = "◙";
            this.lblPattern1.Visible = false;
            this.lblPattern1.MouseHover += new System.EventHandler(this.lblPattern1_MouseHover);
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Enabled = false;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(642, 104);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(97, 25);
            this.siticoneHtmlLabel4.TabIndex = 670;
            this.siticoneHtmlLabel4.Text = "Warehouse";
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Enabled = false;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(459, 104);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(92, 25);
            this.siticoneHtmlLabel3.TabIndex = 669;
            this.siticoneHtmlLabel3.Text = "Lab Result";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Enabled = false;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(270, 104);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(78, 25);
            this.siticoneHtmlLabel2.TabIndex = 668;
            this.siticoneHtmlLabel2.Text = "Approval";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Enabled = false;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(81, 104);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(72, 25);
            this.siticoneHtmlLabel1.TabIndex = 666;
            this.siticoneHtmlLabel1.Text = "Request";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneSeparator1.Enabled = false;
            this.siticoneSeparator1.FillColor = System.Drawing.Color.LightGray;
            this.siticoneSeparator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.siticoneSeparator1.Location = new System.Drawing.Point(35, 113);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(607, 10);
            this.siticoneSeparator1.TabIndex = 667;
            // 
            // frmLabTestHistoricalPerReceivingID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 598);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WizardBalloon4);
            this.Controls.Add(this.WizardBalloon3);
            this.Controls.Add(this.WizardBalloon2);
            this.Controls.Add(this.WizardBalloon1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.lblPattern4);
            this.Controls.Add(this.lblPattern3);
            this.Controls.Add(this.lblPattern2);
            this.Controls.Add(this.lblPattern1);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.siticoneSeparator1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLabTestHistoricalPerReceivingID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Test Historical Per Receiving";
            this.Load += new System.EventHandler(this.frmLabTestHistoricalPerReceivingID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizardBalloon1)).EndInit();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox WizardBalloon4;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox WizardBalloon3;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox WizardBalloon2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox WizardBalloon1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRawMats;
        private System.Windows.Forms.Label lblPattern4;
        private System.Windows.Forms.Label lblPattern3;
        private System.Windows.Forms.Label lblPattern2;
        private System.Windows.Forms.Label lblPattern1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_receiving_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYSTOEXPIRED;
        private System.Windows.Forms.DataGridViewTextBoxColumn STANDARDEXPIRYDAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn HISTORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGING;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_result_remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_sub_remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_request_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn qa_approval_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_exp_date_extension;
    }
}