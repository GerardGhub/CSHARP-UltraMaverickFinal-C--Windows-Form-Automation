
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.lblrecordDesc = new System.Windows.Forms.Label();
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
            this.btnAddTool = new MaterialSkin.Controls.MaterialButton();
            this.btnEditTool = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteTool = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelTool = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateTool = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbltotalrecords);
            this.groupBox1.Controls.Add(this.lblrecordDesc);
            this.groupBox1.Controls.Add(this.lstPosition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(68, 636);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1447, 607);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltotalrecords.Location = new System.Drawing.Point(318, 550);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(92, 39);
            this.lbltotalrecords.TabIndex = 431;
            this.lbltotalrecords.Text = "CCC";
            // 
            // lblrecordDesc
            // 
            this.lblrecordDesc.AutoSize = true;
            this.lblrecordDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblrecordDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecordDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrecordDesc.Location = new System.Drawing.Point(55, 550);
            this.lblrecordDesc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblrecordDesc.Name = "lblrecordDesc";
            this.lblrecordDesc.Size = new System.Drawing.Size(247, 39);
            this.lblrecordDesc.TabIndex = 432;
            this.lblrecordDesc.Text = "Total Records :";
            // 
            // lstPosition
            // 
            this.lstPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPosition.BackColor = System.Drawing.SystemColors.Control;
            this.lstPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPosition.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPosition.FormattingEnabled = true;
            this.lstPosition.ItemHeight = 50;
            this.lstPosition.Location = new System.Drawing.Point(21, 66);
            this.lstPosition.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstPosition.Name = "lstPosition";
            this.lstPosition.Size = new System.Drawing.Size(1247, 450);
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
            this.txtCreatedAt.Location = new System.Drawing.Point(2165, 1095);
            this.txtCreatedAt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCreatedAt.MaxLength = 100;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(444, 36);
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
            this.txtCreatedBy.Location = new System.Drawing.Point(2058, 898);
            this.txtCreatedBy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCreatedBy.MaxLength = 100;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(447, 36);
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
            this.txtModifiedBy.Location = new System.Drawing.Point(2058, 979);
            this.txtModifiedBy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtModifiedBy.MaxLength = 100;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(445, 36);
            this.txtModifiedBy.TabIndex = 178;
            this.txtModifiedBy.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1788, 976);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 39);
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
            this.txtModifiedAt.Location = new System.Drawing.Point(2164, 1173);
            this.txtModifiedAt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtModifiedAt.MaxLength = 100;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(445, 36);
            this.txtModifiedAt.TabIndex = 176;
            this.txtModifiedAt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1919, 1173);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 39);
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
            this.label4.Location = new System.Drawing.Point(1796, 895);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 39);
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
            this.label19.Location = new System.Drawing.Point(1938, 1088);
            this.label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 39);
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
            this.txtCreatedByAndUserID.Location = new System.Drawing.Point(2348, 1390);
            this.txtCreatedByAndUserID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCreatedByAndUserID.MaxLength = 100;
            this.txtCreatedByAndUserID.Name = "txtCreatedByAndUserID";
            this.txtCreatedByAndUserID.Size = new System.Drawing.Size(445, 36);
            this.txtCreatedByAndUserID.TabIndex = 180;
            this.txtCreatedByAndUserID.Visible = false;
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(2544, 1313);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(181, 48);
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
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_table.ColumnHeadersHeight = 45;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_table.EnableHeadersVisualStyles = false;
            this.dgv_table.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_table.Location = new System.Drawing.Point(2526, 609);
            this.dgv_table.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(267, 469);
            this.dgv_table.TabIndex = 426;
            this.dgv_table.Visible = false;
            this.dgv_table.CurrentCellChanged += new System.EventHandler(this.dgv_table_CurrentCellChanged);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(2526, 1230);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(181, 48);
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
            this.lblDepartmentID.Location = new System.Drawing.Point(1695, 29);
            this.lblDepartmentID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(238, 39);
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
            this.materialCard1.Location = new System.Drawing.Point(68, 149);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1452, 203);
            this.materialCard1.TabIndex = 431;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(991, 44);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 32);
            this.label15.TabIndex = 568;
            this.label15.Text = "Department:";
            // 
            // cbodepartment
            // 
            this.cbodepartment.FormattingEnabled = true;
            this.cbodepartment.ItemHeight = 24;
            this.cbodepartment.Location = new System.Drawing.Point(997, 79);
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Size = new System.Drawing.Size(345, 30);
            this.cbodepartment.TabIndex = 1;
            this.cbodepartment.UseSelectable = true;
            this.cbodepartment.SelectionChangeCommitted += new System.EventHandler(this.metroComboBox1_SelectionChangeCommitted);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Depth = 0;
            this.txtname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtname.Hint = "Position";
            this.txtname.Location = new System.Drawing.Point(115, 59);
            this.txtname.MaxLength = 50;
            this.txtname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtname.Multiline = false;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(351, 50);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "";
            // 
            // btnAddTool
            // 
            this.btnAddTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTool.Depth = 0;
            this.btnAddTool.DrawShadows = true;
            this.btnAddTool.HighEmphasis = true;
            this.btnAddTool.Icon = null;
            this.btnAddTool.Location = new System.Drawing.Point(159, 413);
            this.btnAddTool.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(53, 36);
            this.btnAddTool.TabIndex = 432;
            this.btnAddTool.Text = "NEW";
            this.btnAddTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTool.UseAccentColor = false;
            this.btnAddTool.UseVisualStyleBackColor = true;
            this.btnAddTool.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnEditTool
            // 
            this.btnEditTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditTool.Depth = 0;
            this.btnEditTool.DrawShadows = true;
            this.btnEditTool.HighEmphasis = true;
            this.btnEditTool.Icon = null;
            this.btnEditTool.Location = new System.Drawing.Point(373, 413);
            this.btnEditTool.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(53, 36);
            this.btnEditTool.TabIndex = 433;
            this.btnEditTool.Text = "EDIT";
            this.btnEditTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditTool.UseAccentColor = false;
            this.btnEditTool.UseVisualStyleBackColor = true;
            this.btnEditTool.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteTool.Depth = 0;
            this.btnDeleteTool.DrawShadows = true;
            this.btnDeleteTool.HighEmphasis = true;
            this.btnDeleteTool.Icon = null;
            this.btnDeleteTool.Location = new System.Drawing.Point(563, 413);
            this.btnDeleteTool.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteTool.TabIndex = 434;
            this.btnDeleteTool.Text = "DELETE";
            this.btnDeleteTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteTool.UseAccentColor = false;
            this.btnDeleteTool.UseVisualStyleBackColor = true;
            this.btnDeleteTool.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelTool.Depth = 0;
            this.btnCancelTool.DrawShadows = true;
            this.btnCancelTool.HighEmphasis = true;
            this.btnCancelTool.Icon = null;
            this.btnCancelTool.Location = new System.Drawing.Point(806, 413);
            this.btnCancelTool.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(77, 36);
            this.btnCancelTool.TabIndex = 435;
            this.btnCancelTool.Text = "CANCEL";
            this.btnCancelTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelTool.UseAccentColor = false;
            this.btnCancelTool.UseVisualStyleBackColor = true;
            this.btnCancelTool.Click += new System.EventHandler(this.matbtnCancel_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateTool.Depth = 0;
            this.btnUpdateTool.DrawShadows = true;
            this.btnUpdateTool.HighEmphasis = true;
            this.btnUpdateTool.Icon = null;
            this.btnUpdateTool.Location = new System.Drawing.Point(373, 413);
            this.btnUpdateTool.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(58, 36);
            this.btnUpdateTool.TabIndex = 436;
            this.btnUpdateTool.Text = "SAVE";
            this.btnUpdateTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateTool.UseAccentColor = false;
            this.btnUpdateTool.UseVisualStyleBackColor = true;
            this.btnUpdateTool.Visible = false;
            this.btnUpdateTool.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1599, 1291);
            this.Controls.Add(this.btnUpdateTool);
            this.Controls.Add(this.btnCancelTool);
            this.Controls.Add(this.btnDeleteTool);
            this.Controls.Add(this.btnEditTool);
            this.Controls.Add(this.btnAddTool);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Name = "frmPosition";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label lblrecordDesc;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MetroFramework.Controls.MetroComboBox cbodepartment;
        private MaterialSkin.Controls.MaterialTextBox txtname;
        private System.Windows.Forms.Label label15;
        private MaterialSkin.Controls.MaterialButton btnAddTool;
        private MaterialSkin.Controls.MaterialButton btnEditTool;
        private MaterialSkin.Controls.MaterialButton btnDeleteTool;
        private MaterialSkin.Controls.MaterialButton btnCancelTool;
        private MaterialSkin.Controls.MaterialButton btnUpdateTool;
    }
}