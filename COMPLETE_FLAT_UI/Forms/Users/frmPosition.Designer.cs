
namespace ULTRAMAVERICK.Forms.Users
{
    partial class frmPosition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosition));
            this.lstPosition = new System.Windows.Forms.ListBox();
            this.txtCreatedAt = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtModifiedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCreatedByAndUserID = new System.Windows.Forms.TextBox();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label15 = new System.Windows.Forms.Label();
            this.cbodepartment = new MetroFramework.Controls.MetroComboBox();
            this.txtname = new MaterialSkin.Controls.MaterialTextBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddTool = new System.Windows.Forms.ToolStripButton();
            this.btnEditTool = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTool = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateTool = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTool = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPosition
            // 
            this.lstPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPosition.BackColor = System.Drawing.SystemColors.Control;
            this.lstPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPosition.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPosition.FormattingEnabled = true;
            this.lstPosition.ItemHeight = 18;
            this.lstPosition.Location = new System.Drawing.Point(8, 13);
            this.lstPosition.Name = "lstPosition";
            this.lstPosition.Size = new System.Drawing.Size(628, 234);
            this.lstPosition.TabIndex = 152;
            this.lstPosition.Click += new System.EventHandler(this.lstPosition_Click);
            this.lstPosition.SelectedIndexChanged += new System.EventHandler(this.lstPosition_SelectedIndexChanged);
            this.lstPosition.SelectedValueChanged += new System.EventHandler(this.lstPosition_SelectedValueChanged);
            this.lstPosition.CursorChanged += new System.EventHandler(this.lstPosition_CursorChanged);
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BackColor = System.Drawing.Color.White;
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedAt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCreatedAt.Location = new System.Drawing.Point(819, 423);
            this.txtCreatedAt.MaxLength = 100;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(166, 15);
            this.txtCreatedAt.TabIndex = 180;
            this.txtCreatedAt.Visible = false;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BackColor = System.Drawing.Color.White;
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCreatedBy.Location = new System.Drawing.Point(779, 341);
            this.txtCreatedBy.MaxLength = 100;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(168, 15);
            this.txtCreatedBy.TabIndex = 179;
            this.txtCreatedBy.Visible = false;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.BackColor = System.Drawing.Color.White;
            this.txtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifiedBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtModifiedBy.Location = new System.Drawing.Point(779, 375);
            this.txtModifiedBy.MaxLength = 100;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(167, 15);
            this.txtModifiedBy.TabIndex = 178;
            this.txtModifiedBy.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(677, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
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
            this.txtModifiedAt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtModifiedAt.Location = new System.Drawing.Point(819, 456);
            this.txtModifiedAt.MaxLength = 100;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(167, 15);
            this.txtModifiedAt.TabIndex = 176;
            this.txtModifiedAt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(727, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 175;
            this.label5.Text = "Modified_At :";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(681, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 173;
            this.label4.Text = "Created By :";
            this.label4.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(734, 420);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 17);
            this.label19.TabIndex = 168;
            this.label19.Text = "Created At :";
            this.label19.Visible = false;
            // 
            // txtCreatedByAndUserID
            // 
            this.txtCreatedByAndUserID.BackColor = System.Drawing.Color.White;
            this.txtCreatedByAndUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedByAndUserID.Enabled = false;
            this.txtCreatedByAndUserID.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedByAndUserID.Location = new System.Drawing.Point(880, 583);
            this.txtCreatedByAndUserID.MaxLength = 100;
            this.txtCreatedByAndUserID.Name = "txtCreatedByAndUserID";
            this.txtCreatedByAndUserID.Size = new System.Drawing.Size(167, 15);
            this.txtCreatedByAndUserID.TabIndex = 180;
            this.txtCreatedByAndUserID.Visible = false;
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(954, 551);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(1);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(68, 20);
            this.metroButtonSave.TabIndex = 425;
            this.metroButtonSave.Text = "Add";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Visible = false;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AllowUserToResizeColumns = false;
            this.dgv_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_table.ColumnHeadersHeight = 45;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_table.EnableHeadersVisualStyles = false;
            this.dgv_table.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_table.Location = new System.Drawing.Point(779, 201);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(100, 94);
            this.dgv_table.TabIndex = 426;
            this.dgv_table.Visible = false;
            this.dgv_table.CurrentCellChanged += new System.EventHandler(this.dgv_table_CurrentCellChanged);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(947, 516);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(1);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(68, 20);
            this.metroButtonDelete.TabIndex = 430;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Visible = false;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartmentID.Location = new System.Drawing.Point(636, 12);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(99, 17);
            this.lblDepartmentID.TabIndex = 428;
            this.lblDepartmentID.Text = "Department ID";
            this.lblDepartmentID.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label15);
            this.materialCard1.Controls.Add(this.cbodepartment);
            this.materialCard1.Controls.Add(this.txtname);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(22, 86);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(974, 85);
            this.materialCard1.TabIndex = 431;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(793, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 568;
            this.label15.Text = "Department:";
            // 
            // cbodepartment
            // 
            this.cbodepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbodepartment.Enabled = false;
            this.cbodepartment.FormattingEnabled = true;
            this.cbodepartment.ItemHeight = 23;
            this.cbodepartment.Location = new System.Drawing.Point(790, 33);
            this.cbodepartment.Margin = new System.Windows.Forms.Padding(1);
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Size = new System.Drawing.Size(167, 29);
            this.cbodepartment.TabIndex = 1;
            this.cbodepartment.UseSelectable = true;
            this.cbodepartment.SelectionChangeCommitted += new System.EventHandler(this.metroComboBox1_SelectionChangeCommitted);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Depth = 0;
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtname.Hint = "Position";
            this.txtname.Location = new System.Drawing.Point(43, 25);
            this.txtname.Margin = new System.Windows.Forms.Padding(1);
            this.txtname.MaxLength = 50;
            this.txtname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtname.Multiline = false;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(281, 50);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "";
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(1150, 840);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(51, 36);
            this.lbltotalrecords.TabIndex = 580;
            this.lbltotalrecords.Text = "76";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(1152, 876);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 581;
            this.label3.Text = "Items";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lstPosition);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(22, 375);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(644, 280);
            this.materialCard2.TabIndex = 582;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(22, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 40);
            this.panel1.TabIndex = 583;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTool,
            this.btnEditTool,
            this.btnDeleteTool,
            this.btnUpdateTool,
            this.btnCancelTool});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(578, 40);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTool.Image")));
            this.btnAddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(75, 37);
            this.btnAddTool.Text = "&New";
            this.btnAddTool.Click += new System.EventHandler(this.neww_Click);
            // 
            // btnEditTool
            // 
            this.btnEditTool.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTool.Image")));
            this.btnEditTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(72, 37);
            this.btnEditTool.Text = "&Edit";
            this.btnEditTool.Click += new System.EventHandler(this.editt_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTool.Image")));
            this.btnDeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(94, 37);
            this.btnDeleteTool.Text = "&Remove";
            this.btnDeleteTool.Click += new System.EventHandler(this.removee_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTool.Image")));
            this.btnUpdateTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(77, 37);
            this.btnUpdateTool.Text = "&Save";
            this.btnUpdateTool.Visible = false;
            this.btnUpdateTool.Click += new System.EventHandler(this.savee_Click);
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTool.Image")));
            this.btnCancelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(88, 37);
            this.btnCancelTool.Text = "&Cancel";
            this.btnCancelTool.Visible = false;
            this.btnCancelTool.Click += new System.EventHandler(this.cancel_Click);
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCreatedByAndUserID);
            this.Controls.Add(this.txtModifiedAt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmPosition";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPosition;
        private System.Windows.Forms.TextBox txtModifiedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModifiedAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.TextBox txtCreatedByAndUserID;
        private System.Windows.Forms.TextBox txtCreatedAt;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private System.Windows.Forms.DataGridView dgv_table;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private System.Windows.Forms.Label lblDepartmentID;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MetroFramework.Controls.MetroComboBox cbodepartment;
        private MaterialSkin.Controls.MaterialTextBox txtname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddTool;
        private System.Windows.Forms.ToolStripButton btnEditTool;
        private System.Windows.Forms.ToolStripButton btnDeleteTool;
        private System.Windows.Forms.ToolStripButton btnUpdateTool;
        private System.Windows.Forms.ToolStripButton btnCancelTool;
    }
}