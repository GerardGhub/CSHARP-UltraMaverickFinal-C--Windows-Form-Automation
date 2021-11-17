
namespace ULTRAMAVERICK.Forms.Users
{
    partial class frmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblrecords = new System.Windows.Forms.Label();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new System.Windows.Forms.Button();
            this.metroButtonUpdate = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.lblPositionId = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.lblRequestorTypeID = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cbodepartment = new MetroFramework.Controls.MetroComboBox();
            this.cboUnit = new MetroFramework.Controls.MetroComboBox();
            this.cboPosition = new MetroFramework.Controls.MetroComboBox();
            this.cmbLocation = new MetroFramework.Controls.MetroComboBox();
            this.cboRequestorType = new MetroFramework.Controls.MetroComboBox();
            this.cmbNotif = new MetroFramework.Controls.MetroComboBox();
            this.lblGenderSelected = new System.Windows.Forms.Label();
            this.lblgenderLabel = new System.Windows.Forms.Label();
            this.matRadioFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbousertype = new MetroFramework.Controls.MetroComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtpassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtuser = new MaterialSkin.Controls.MaterialTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtname = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddTool = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.btnEditTool = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteTool = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateTool = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelTool = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3RequestorSetup = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblrightsID = new System.Windows.Forms.Label();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.materialCard3RequestorSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUsers.BackColor = System.Drawing.SystemColors.Control;
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsers.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(8, 10);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(493, 200);
            this.lstUsers.TabIndex = 152;
            this.lstUsers.Click += new System.EventHandler(this.lstUsers_Click);
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            this.lstUsers.SelectedValueChanged += new System.EventHandler(this.lstUsers_SelectedValueChanged);
            this.lstUsers.CursorChanged += new System.EventHandler(this.lstUsers_CursorChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(27, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 554;
            this.label9.Text = "Department:";
            // 
            // lblrecords
            // 
            this.lblrecords.AutoSize = true;
            this.lblrecords.BackColor = System.Drawing.Color.Transparent;
            this.lblrecords.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrecords.Location = new System.Drawing.Point(608, 33);
            this.lblrecords.Name = "lblrecords";
            this.lblrecords.Size = new System.Drawing.Size(81, 13);
            this.lblrecords.TabIndex = 416;
            this.lblrecords.Text = "SearchCount";
            this.lblrecords.Visible = false;
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(721, 549);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(68, 20);
            this.metroButtonSave.TabIndex = 420;
            this.metroButtonSave.Text = "Add";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Visible = false;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 20;
            this.button1.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.button1.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "UPDATE";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 20;
            this.button1.IdleFillColor = System.Drawing.Color.CornflowerBlue;
            this.button1.IdleForecolor = System.Drawing.SystemColors.Window;
            this.button1.IdleLineColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(747, 485);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 423;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(634, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 425;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            // 
            // metroButtonUpdate
            // 
            this.metroButtonUpdate.Location = new System.Drawing.Point(628, 579);
            this.metroButtonUpdate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.metroButtonUpdate.Name = "metroButtonUpdate";
            this.metroButtonUpdate.Size = new System.Drawing.Size(68, 20);
            this.metroButtonUpdate.TabIndex = 426;
            this.metroButtonUpdate.Text = "Update";
            this.metroButtonUpdate.UseSelectable = true;
            this.metroButtonUpdate.Visible = false;
            this.metroButtonUpdate.Click += new System.EventHandler(this.metroButtonUpdate_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(620, 442);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(68, 20);
            this.metroButtonDelete.TabIndex = 427;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Visible = false;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // lblPositionId
            // 
            this.lblPositionId.AutoSize = true;
            this.lblPositionId.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPositionId.Location = new System.Drawing.Point(395, 33);
            this.lblPositionId.Name = "lblPositionId";
            this.lblPositionId.Size = new System.Drawing.Size(75, 17);
            this.lblPositionId.TabIndex = 554;
            this.lblPositionId.Text = "Position ID";
            this.lblPositionId.Visible = false;
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartmentID.Location = new System.Drawing.Point(470, 27);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(99, 17);
            this.lblDepartmentID.TabIndex = 556;
            this.lblDepartmentID.Text = "Deparmtent ID";
            this.lblDepartmentID.Visible = false;
            // 
            // lblRequestorTypeID
            // 
            this.lblRequestorTypeID.AutoSize = true;
            this.lblRequestorTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestorTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestorTypeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRequestorTypeID.Location = new System.Drawing.Point(288, 31);
            this.lblRequestorTypeID.Name = "lblRequestorTypeID";
            this.lblRequestorTypeID.Size = new System.Drawing.Size(91, 17);
            this.lblRequestorTypeID.TabIndex = 557;
            this.lblRequestorTypeID.Text = "Requestor ID";
            this.lblRequestorTypeID.Visible = false;
            this.lblRequestorTypeID.TextChanged += new System.EventHandler(this.lblRequestorTypeID_TextChanged);
            this.lblRequestorTypeID.Click += new System.EventHandler(this.lblRequestorTypeID_Click);
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitID.Location = new System.Drawing.Point(688, 33);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(52, 17);
            this.lblUnitID.TabIndex = 558;
            this.lblUnitID.Text = "UNit ID";
            this.lblUnitID.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cbodepartment);
            this.materialCard1.Controls.Add(this.cboUnit);
            this.materialCard1.Controls.Add(this.cboPosition);
            this.materialCard1.Controls.Add(this.cmbLocation);
            this.materialCard1.Controls.Add(this.cboRequestorType);
            this.materialCard1.Controls.Add(this.cmbNotif);
            this.materialCard1.Controls.Add(this.lblGenderSelected);
            this.materialCard1.Controls.Add(this.lblgenderLabel);
            this.materialCard1.Controls.Add(this.matRadioFemale);
            this.materialCard1.Controls.Add(this.matRadioMale);
            this.materialCard1.Controls.Add(this.cbousertype);
            this.materialCard1.Controls.Add(this.label16);
            this.materialCard1.Controls.Add(this.label15);
            this.materialCard1.Controls.Add(this.label14);
            this.materialCard1.Controls.Add(this.txtpassword);
            this.materialCard1.Controls.Add(this.txtuser);
            this.materialCard1.Controls.Add(this.label13);
            this.materialCard1.Controls.Add(this.label12);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.txtLastName);
            this.materialCard1.Controls.Add(this.txtname);
            this.materialCard1.Controls.Add(this.label9);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 118);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(510, 232);
            this.materialCard1.TabIndex = 559;
            // 
            // cbodepartment
            // 
            this.cbodepartment.Enabled = false;
            this.cbodepartment.FormattingEnabled = true;
            this.cbodepartment.ItemHeight = 23;
            this.cbodepartment.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cbodepartment.Location = new System.Drawing.Point(29, 83);
            this.cbodepartment.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Size = new System.Drawing.Size(135, 29);
            this.cbodepartment.TabIndex = 585;
            this.cbodepartment.UseSelectable = true;
            this.cbodepartment.SelectedValueChanged += new System.EventHandler(this.metroComboBox1_SelectedValueChanged_1);
            // 
            // cboUnit
            // 
            this.cboUnit.Enabled = false;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.ItemHeight = 23;
            this.cboUnit.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cboUnit.Location = new System.Drawing.Point(188, 83);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(135, 29);
            this.cboUnit.TabIndex = 584;
            this.cboUnit.UseSelectable = true;
            this.cboUnit.SelectionChangeCommitted += new System.EventHandler(this.metroComboBox1_SelectionChangeCommitted_2);
            // 
            // cboPosition
            // 
            this.cboPosition.Enabled = false;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.ItemHeight = 23;
            this.cboPosition.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cboPosition.Location = new System.Drawing.Point(352, 83);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(135, 29);
            this.cboPosition.TabIndex = 583;
            this.cboPosition.UseSelectable = true;
            this.cboPosition.SelectionChangeCommitted += new System.EventHandler(this.metroComboBox1_SelectionChangeCommitted_1);
            // 
            // cmbLocation
            // 
            this.cmbLocation.Enabled = false;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.ItemHeight = 23;
            this.cmbLocation.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cmbLocation.Location = new System.Drawing.Point(352, 127);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(135, 29);
            this.cmbLocation.TabIndex = 582;
            this.cmbLocation.UseSelectable = true;
            // 
            // cboRequestorType
            // 
            this.cboRequestorType.Enabled = false;
            this.cboRequestorType.FormattingEnabled = true;
            this.cboRequestorType.ItemHeight = 23;
            this.cboRequestorType.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboRequestorType.Location = new System.Drawing.Point(29, 184);
            this.cboRequestorType.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cboRequestorType.Name = "cboRequestorType";
            this.cboRequestorType.Size = new System.Drawing.Size(135, 29);
            this.cboRequestorType.TabIndex = 581;
            this.cboRequestorType.UseSelectable = true;
            this.cboRequestorType.SelectionChangeCommitted += new System.EventHandler(this.metroComboBox1_SelectionChangeCommitted);
            this.cboRequestorType.SelectedValueChanged += new System.EventHandler(this.metroComboBox1_SelectedValueChanged);
            // 
            // cmbNotif
            // 
            this.cmbNotif.Enabled = false;
            this.cmbNotif.FormattingEnabled = true;
            this.cmbNotif.ItemHeight = 23;
            this.cmbNotif.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cmbNotif.Location = new System.Drawing.Point(183, 184);
            this.cmbNotif.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbNotif.Name = "cmbNotif";
            this.cmbNotif.Size = new System.Drawing.Size(135, 29);
            this.cmbNotif.TabIndex = 580;
            this.cmbNotif.UseSelectable = true;
            // 
            // lblGenderSelected
            // 
            this.lblGenderSelected.AutoSize = true;
            this.lblGenderSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenderSelected.Location = new System.Drawing.Point(439, 166);
            this.lblGenderSelected.Name = "lblGenderSelected";
            this.lblGenderSelected.Size = new System.Drawing.Size(45, 13);
            this.lblGenderSelected.TabIndex = 579;
            this.lblGenderSelected.Text = "Gender:";
            this.lblGenderSelected.Visible = false;
            // 
            // lblgenderLabel
            // 
            this.lblgenderLabel.AutoSize = true;
            this.lblgenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblgenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgenderLabel.Location = new System.Drawing.Point(350, 166);
            this.lblgenderLabel.Name = "lblgenderLabel";
            this.lblgenderLabel.Size = new System.Drawing.Size(45, 13);
            this.lblgenderLabel.TabIndex = 578;
            this.lblgenderLabel.Text = "Gender:";
            this.lblgenderLabel.Click += new System.EventHandler(this.lblgenderLabel_Click);
            // 
            // matRadioFemale
            // 
            this.matRadioFemale.AutoSize = true;
            this.matRadioFemale.Depth = 0;
            this.matRadioFemale.Enabled = false;
            this.matRadioFemale.Location = new System.Drawing.Point(410, 182);
            this.matRadioFemale.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioFemale.Name = "matRadioFemale";
            this.matRadioFemale.Ripple = true;
            this.matRadioFemale.Size = new System.Drawing.Size(87, 37);
            this.matRadioFemale.TabIndex = 577;
            this.matRadioFemale.TabStop = true;
            this.matRadioFemale.Text = "Female";
            this.matRadioFemale.UseVisualStyleBackColor = true;
            this.matRadioFemale.CheckedChanged += new System.EventHandler(this.matRadioFemale_CheckedChanged);
            // 
            // matRadioMale
            // 
            this.matRadioMale.AutoSize = true;
            this.matRadioMale.Depth = 0;
            this.matRadioMale.Enabled = false;
            this.matRadioMale.Location = new System.Drawing.Point(353, 183);
            this.matRadioMale.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioMale.Name = "matRadioMale";
            this.matRadioMale.Ripple = true;
            this.matRadioMale.Size = new System.Drawing.Size(70, 37);
            this.matRadioMale.TabIndex = 576;
            this.matRadioMale.TabStop = true;
            this.matRadioMale.Text = "Male";
            this.matRadioMale.UseVisualStyleBackColor = true;
            this.matRadioMale.CheckedChanged += new System.EventHandler(this.matRadioMale_CheckedChanged);
            // 
            // cbousertype
            // 
            this.cbousertype.Enabled = false;
            this.cbousertype.FormattingEnabled = true;
            this.cbousertype.ItemHeight = 23;
            this.cbousertype.Location = new System.Drawing.Point(352, 28);
            this.cbousertype.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbousertype.Name = "cbousertype";
            this.cbousertype.Size = new System.Drawing.Size(135, 29);
            this.cbousertype.TabIndex = 575;
            this.cbousertype.UseSelectable = true;
            this.cbousertype.SelectionChangeCommitted += new System.EventHandler(this.cboLocation_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(27, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 567;
            this.label16.Text = "User Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(351, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 566;
            this.label15.Text = "System Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(186, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 565;
            this.label14.Text = "Notification:";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Depth = 0;
            this.txtpassword.Enabled = false;
            this.txtpassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtpassword.Hint = "Password";
            this.txtpassword.Location = new System.Drawing.Point(188, 115);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(131, 50);
            this.txtpassword.TabIndex = 564;
            this.txtpassword.Text = "";
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Depth = 0;
            this.txtuser.Enabled = false;
            this.txtuser.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtuser.Hint = "UserName";
            this.txtuser.Location = new System.Drawing.Point(29, 116);
            this.txtuser.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtuser.MaxLength = 50;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(131, 50);
            this.txtuser.TabIndex = 563;
            this.txtuser.Text = "";
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(351, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 562;
            this.label13.Text = "User Rights:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(351, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 561;
            this.label12.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(186, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 556;
            this.label1.Text = "SubUnit:";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLastName.Hint = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(188, 13);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 50);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Depth = 0;
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtname.Hint = "First Name";
            this.txtname.Location = new System.Drawing.Point(29, 13);
            this.txtname.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtname.MaxLength = 50;
            this.txtname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtname.Multiline = false;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(131, 50);
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
            this.btnAddTool.Location = new System.Drawing.Point(33, 374);
            this.btnAddTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(53, 36);
            this.btnAddTool.TabIndex = 568;
            this.btnAddTool.Text = "NEW";
            this.btnAddTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTool.UseAccentColor = false;
            this.btnAddTool.UseVisualStyleBackColor = true;
            this.btnAddTool.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lstUsers);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(2022, 295);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(510, 232);
            this.materialCard2.TabIndex = 560;
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgv_table.Location = new System.Drawing.Point(869, 466);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(100, 118);
            this.dgv_table.TabIndex = 415;
            this.dgv_table.CurrentCellChanged += new System.EventHandler(this.dgv_table_CurrentCellChanged);
            // 
            // btnEditTool
            // 
            this.btnEditTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditTool.Depth = 0;
            this.btnEditTool.DrawShadows = true;
            this.btnEditTool.HighEmphasis = true;
            this.btnEditTool.Icon = null;
            this.btnEditTool.Location = new System.Drawing.Point(117, 374);
            this.btnEditTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(53, 36);
            this.btnEditTool.TabIndex = 569;
            this.btnEditTool.Text = "EDIT";
            this.btnEditTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditTool.UseAccentColor = false;
            this.btnEditTool.UseVisualStyleBackColor = true;
            this.btnEditTool.Click += new System.EventHandler(this.materialButton1_Click_2);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteTool.Depth = 0;
            this.btnDeleteTool.DrawShadows = true;
            this.btnDeleteTool.HighEmphasis = true;
            this.btnDeleteTool.Icon = null;
            this.btnDeleteTool.Location = new System.Drawing.Point(172, 374);
            this.btnDeleteTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteTool.TabIndex = 570;
            this.btnDeleteTool.Text = "DELETE";
            this.btnDeleteTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteTool.UseAccentColor = true;
            this.btnDeleteTool.UseVisualStyleBackColor = true;
            this.btnDeleteTool.Click += new System.EventHandler(this.materialButton1_Click_4);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateTool.Depth = 0;
            this.btnUpdateTool.DrawShadows = true;
            this.btnUpdateTool.HighEmphasis = true;
            this.btnUpdateTool.Icon = null;
            this.btnUpdateTool.Location = new System.Drawing.Point(115, 392);
            this.btnUpdateTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(58, 36);
            this.btnUpdateTool.TabIndex = 571;
            this.btnUpdateTool.Text = "SAVE";
            this.btnUpdateTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateTool.UseAccentColor = false;
            this.btnUpdateTool.UseVisualStyleBackColor = true;
            this.btnUpdateTool.Visible = false;
            this.btnUpdateTool.Click += new System.EventHandler(this.materialButton1_Click_3);
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelTool.Depth = 0;
            this.btnCancelTool.DrawShadows = true;
            this.btnCancelTool.HighEmphasis = true;
            this.btnCancelTool.Icon = null;
            this.btnCancelTool.Location = new System.Drawing.Point(248, 374);
            this.btnCancelTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(77, 36);
            this.btnCancelTool.TabIndex = 572;
            this.btnCancelTool.Text = "CANCEL";
            this.btnCancelTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelTool.UseAccentColor = true;
            this.btnCancelTool.UseVisualStyleBackColor = true;
            this.btnCancelTool.Click += new System.EventHandler(this.materialButton1_Click_5);
            // 
            // materialCard3RequestorSetup
            // 
            this.materialCard3RequestorSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3RequestorSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3RequestorSetup.Controls.Add(this.materialLabel1);
            this.materialCard3RequestorSetup.Depth = 0;
            this.materialCard3RequestorSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3RequestorSetup.Location = new System.Drawing.Point(719, 1057);
            this.materialCard3RequestorSetup.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3RequestorSetup.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3RequestorSetup.Name = "materialCard3RequestorSetup";
            this.materialCard3RequestorSetup.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3RequestorSetup.Size = new System.Drawing.Size(442, 194);
            this.materialCard3RequestorSetup.TabIndex = 573;
            this.materialCard3RequestorSetup.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(27, 19);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Select Approver";
            // 
            // lblrightsID
            // 
            this.lblrightsID.AutoSize = true;
            this.lblrightsID.BackColor = System.Drawing.Color.Transparent;
            this.lblrightsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrightsID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrightsID.Location = new System.Drawing.Point(362, 203);
            this.lblrightsID.Name = "lblrightsID";
            this.lblrightsID.Size = new System.Drawing.Size(58, 17);
            this.lblrightsID.TabIndex = 574;
            this.lblrightsID.Text = "Right ID";
            this.lblrightsID.Visible = false;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(3084, 1135);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(51, 36);
            this.lbltotalrecords.TabIndex = 662;
            this.lbltotalrecords.Text = "76";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(3189, 1166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 663;
            this.label3.Text = "Items";
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(2784, 172);
            this.mattxtSearch.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(205, 50);
            this.mattxtSearch.TabIndex = 664;
            this.mattxtSearch.Text = "";
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1099, 461);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblrightsID);
            this.Controls.Add(this.materialCard3RequestorSetup);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.btnCancelTool);
            this.Controls.Add(this.btnUpdateTool);
            this.Controls.Add(this.btnDeleteTool);
            this.Controls.Add(this.btnEditTool);
            this.Controls.Add(this.btnAddTool);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblUnitID);
            this.Controls.Add(this.lblRequestorTypeID);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.lblPositionId);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.lblrecords);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmUserManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.materialCard3RequestorSetup.ResumeLayout(false);
            this.materialCard3RequestorSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label lblrecords;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private System.Windows.Forms.Button btnCancel;
        private MetroFramework.Controls.MetroButton metroButtonUpdate;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private System.Windows.Forms.Label lblPositionId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblRequestorTypeID;
        private System.Windows.Forms.Label lblUnitID;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialTextBox txtuser;
        private MaterialSkin.Controls.MaterialTextBox txtpassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialButton btnAddTool;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView dgv_table;
        private MaterialSkin.Controls.MaterialButton btnEditTool;
        private MaterialSkin.Controls.MaterialButton btnDeleteTool;
        private MaterialSkin.Controls.MaterialButton btnUpdateTool;
        private MaterialSkin.Controls.MaterialButton btnCancelTool;
        private MaterialSkin.Controls.MaterialCard materialCard3RequestorSetup;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblrightsID;
        private MetroFramework.Controls.MetroComboBox cbousertype;
        private MaterialSkin.Controls.MaterialRadioButton matRadioMale;
        private MaterialSkin.Controls.MaterialRadioButton matRadioFemale;
        private System.Windows.Forms.Label lblgenderLabel;
        private System.Windows.Forms.Label lblGenderSelected;
        private MetroFramework.Controls.MetroComboBox cmbNotif;
        private MetroFramework.Controls.MetroComboBox cboRequestorType;
        private MetroFramework.Controls.MetroComboBox cmbLocation;
        private MetroFramework.Controls.MetroComboBox cboPosition;
        private MetroFramework.Controls.MetroComboBox cboUnit;
        private MetroFramework.Controls.MetroComboBox cbodepartment;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
    }
}