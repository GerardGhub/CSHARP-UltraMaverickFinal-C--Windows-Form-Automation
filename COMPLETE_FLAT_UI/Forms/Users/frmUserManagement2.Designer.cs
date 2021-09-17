
namespace ULTRAMAVERICK.Forms.Users
{
    partial class frmUserManagement2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement2));
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mattxtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cmbNotif = new MaterialSkin.Controls.MaterialTextBox();
            this.cboRequestorType = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.cbodepartment = new MaterialSkin.Controls.MaterialTextBox();
            this.cboUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.cboPosition = new MaterialSkin.Controls.MaterialTextBox();
            this.cbousertype = new MaterialSkin.Controls.MaterialTextBox();
            this.lblGenderSelected = new System.Windows.Forms.Label();
            this.lblgenderLabel = new System.Windows.Forms.Label();
            this.matRadioFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtpassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtuser = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtname = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddTool = new System.Windows.Forms.ToolStripButton();
            this.btnEditTool = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTool = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateTool = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTool = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userfile_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_of_approver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_rights_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiving_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvUsers);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(69, 323);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(2603, 974);
            this.materialCard2.TabIndex = 555;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 35;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userfile_id,
            this.Column1,
            this.username,
            this.employee_name,
            this.employee_lastname,
            this.gender,
            this.department_name,
            this.Unit,
            this.Position,
            this.type_of_approver,
            this.password,
            this.user_rights_name,
            this.receiving_status,
            this.user_section});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUsers.Location = new System.Drawing.Point(14, 14);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 102;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.RowTemplate.DividerHeight = 5;
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(2575, 946);
            this.dgvUsers.TabIndex = 577;
            this.dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 40;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentCellChanged += new System.EventHandler(this.dgvUsers_CurrentCellChanged);
            this.dgvUsers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUsers_RowPostPaint);
            // 
            // mattxtSearch
            // 
            this.mattxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSearch.Depth = 0;
            this.mattxtSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSearch.Hint = "Search";
            this.mattxtSearch.Location = new System.Drawing.Point(2167, 191);
            this.mattxtSearch.MaxLength = 50;
            this.mattxtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSearch.Multiline = false;
            this.mattxtSearch.Name = "mattxtSearch";
            this.mattxtSearch.Size = new System.Drawing.Size(547, 50);
            this.mattxtSearch.TabIndex = 663;
            this.mattxtSearch.Text = "";
            this.mattxtSearch.TextChanged += new System.EventHandler(this.mattxtSearch_TextChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cmbNotif);
            this.materialCard1.Controls.Add(this.cboRequestorType);
            this.materialCard1.Controls.Add(this.cmbLocation);
            this.materialCard1.Controls.Add(this.cbodepartment);
            this.materialCard1.Controls.Add(this.cboUnit);
            this.materialCard1.Controls.Add(this.cboPosition);
            this.materialCard1.Controls.Add(this.cbousertype);
            this.materialCard1.Controls.Add(this.lblGenderSelected);
            this.materialCard1.Controls.Add(this.lblgenderLabel);
            this.materialCard1.Controls.Add(this.matRadioFemale);
            this.materialCard1.Controls.Add(this.matRadioMale);
            this.materialCard1.Controls.Add(this.txtpassword);
            this.materialCard1.Controls.Add(this.txtuser);
            this.materialCard1.Controls.Add(this.txtLastName);
            this.materialCard1.Controls.Add(this.txtname);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(2252, 1325);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(324, 369);
            this.materialCard1.TabIndex = 664;
            this.materialCard1.Visible = false;
            // 
            // cmbNotif
            // 
            this.cmbNotif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmbNotif.Depth = 0;
            this.cmbNotif.Enabled = false;
            this.cmbNotif.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbNotif.Hint = "System Notification";
            this.cmbNotif.Location = new System.Drawing.Point(501, 471);
            this.cmbNotif.MaxLength = 50;
            this.cmbNotif.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNotif.Multiline = false;
            this.cmbNotif.Name = "cmbNotif";
            this.cmbNotif.Size = new System.Drawing.Size(349, 36);
            this.cmbNotif.TabIndex = 592;
            this.cmbNotif.Text = "";
            this.cmbNotif.UseTallSize = false;
            // 
            // cboRequestorType
            // 
            this.cboRequestorType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboRequestorType.Depth = 0;
            this.cboRequestorType.Enabled = false;
            this.cboRequestorType.Font = new System.Drawing.Font("Roboto", 12F);
            this.cboRequestorType.Hint = "Requestor Type";
            this.cboRequestorType.Location = new System.Drawing.Point(78, 471);
            this.cboRequestorType.MaxLength = 50;
            this.cboRequestorType.MouseState = MaterialSkin.MouseState.OUT;
            this.cboRequestorType.Multiline = false;
            this.cboRequestorType.Name = "cboRequestorType";
            this.cboRequestorType.Size = new System.Drawing.Size(349, 36);
            this.cboRequestorType.TabIndex = 591;
            this.cboRequestorType.Text = "";
            this.cboRequestorType.UseTallSize = false;
            // 
            // cmbLocation
            // 
            this.cmbLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmbLocation.Depth = 0;
            this.cmbLocation.Enabled = false;
            this.cmbLocation.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbLocation.Hint = "System Type";
            this.cmbLocation.Location = new System.Drawing.Point(939, 315);
            this.cmbLocation.MaxLength = 50;
            this.cmbLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbLocation.Multiline = false;
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(349, 50);
            this.cmbLocation.TabIndex = 590;
            this.cmbLocation.Text = "";
            // 
            // cbodepartment
            // 
            this.cbodepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbodepartment.Depth = 0;
            this.cbodepartment.Enabled = false;
            this.cbodepartment.Font = new System.Drawing.Font("Roboto", 12F);
            this.cbodepartment.Hint = "Department";
            this.cbodepartment.Location = new System.Drawing.Point(77, 177);
            this.cbodepartment.MaxLength = 50;
            this.cbodepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.cbodepartment.Multiline = false;
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Size = new System.Drawing.Size(349, 36);
            this.cbodepartment.TabIndex = 589;
            this.cbodepartment.Text = "";
            this.cbodepartment.UseTallSize = false;
            // 
            // cboUnit
            // 
            this.cboUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboUnit.Depth = 0;
            this.cboUnit.Enabled = false;
            this.cboUnit.Font = new System.Drawing.Font("Roboto", 12F);
            this.cboUnit.Hint = "Unit";
            this.cboUnit.Location = new System.Drawing.Point(501, 177);
            this.cboUnit.MaxLength = 50;
            this.cboUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.cboUnit.Multiline = false;
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(349, 36);
            this.cboUnit.TabIndex = 588;
            this.cboUnit.Text = "";
            this.cboUnit.UseTallSize = false;
            // 
            // cboPosition
            // 
            this.cboPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboPosition.Depth = 0;
            this.cboPosition.Enabled = false;
            this.cboPosition.Font = new System.Drawing.Font("Roboto", 12F);
            this.cboPosition.Hint = "Position";
            this.cboPosition.Location = new System.Drawing.Point(939, 177);
            this.cboPosition.MaxLength = 50;
            this.cboPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.cboPosition.Multiline = false;
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(349, 50);
            this.cboPosition.TabIndex = 587;
            this.cboPosition.Text = "";
            // 
            // cbousertype
            // 
            this.cbousertype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbousertype.Depth = 0;
            this.cbousertype.Enabled = false;
            this.cbousertype.Font = new System.Drawing.Font("Roboto", 12F);
            this.cbousertype.Hint = "User Rights";
            this.cbousertype.Location = new System.Drawing.Point(939, 32);
            this.cbousertype.MaxLength = 50;
            this.cbousertype.MouseState = MaterialSkin.MouseState.OUT;
            this.cbousertype.Multiline = false;
            this.cbousertype.Name = "cbousertype";
            this.cbousertype.Size = new System.Drawing.Size(349, 50);
            this.cbousertype.TabIndex = 586;
            this.cbousertype.Text = "";
            // 
            // lblGenderSelected
            // 
            this.lblGenderSelected.AutoSize = true;
            this.lblGenderSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenderSelected.Location = new System.Drawing.Point(1170, 441);
            this.lblGenderSelected.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGenderSelected.Name = "lblGenderSelected";
            this.lblGenderSelected.Size = new System.Drawing.Size(118, 32);
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
            this.lblgenderLabel.Location = new System.Drawing.Point(932, 441);
            this.lblgenderLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblgenderLabel.Name = "lblgenderLabel";
            this.lblgenderLabel.Size = new System.Drawing.Size(118, 32);
            this.lblgenderLabel.TabIndex = 578;
            this.lblgenderLabel.Text = "Gender:";
            // 
            // matRadioFemale
            // 
            this.matRadioFemale.AutoSize = true;
            this.matRadioFemale.Depth = 0;
            this.matRadioFemale.Enabled = false;
            this.matRadioFemale.Location = new System.Drawing.Point(941, 570);
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
            // 
            // matRadioMale
            // 
            this.matRadioMale.AutoSize = true;
            this.matRadioMale.Depth = 0;
            this.matRadioMale.Enabled = false;
            this.matRadioMale.Location = new System.Drawing.Point(941, 482);
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
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Depth = 0;
            this.txtpassword.Enabled = false;
            this.txtpassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtpassword.Hint = "Password";
            this.txtpassword.Location = new System.Drawing.Point(501, 313);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(349, 36);
            this.txtpassword.TabIndex = 564;
            this.txtpassword.Text = "";
            this.txtpassword.UseTallSize = false;
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Depth = 0;
            this.txtuser.Enabled = false;
            this.txtuser.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtuser.Hint = "UserName";
            this.txtuser.Location = new System.Drawing.Point(77, 315);
            this.txtuser.MaxLength = 50;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(349, 36);
            this.txtuser.TabIndex = 563;
            this.txtuser.Text = "";
            this.txtuser.UseTallSize = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLastName.Hint = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(501, 32);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(349, 36);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "";
            this.txtLastName.UseTallSize = false;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Depth = 0;
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtname.Hint = "First Name";
            this.txtname.Location = new System.Drawing.Point(78, 31);
            this.txtname.MaxLength = 50;
            this.txtname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtname.Multiline = false;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(349, 36);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "";
            this.txtname.UseTallSize = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(83, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 95);
            this.panel1.TabIndex = 665;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.toolStrip2.Size = new System.Drawing.Size(825, 95);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTool.Image")));
            this.btnAddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(122, 88);
            this.btnAddTool.Text = "&New";
            this.btnAddTool.Click += new System.EventHandler(this.btnAddTool_Click);
            // 
            // btnEditTool
            // 
            this.btnEditTool.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTool.Image")));
            this.btnEditTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(112, 88);
            this.btnEditTool.Text = "&Edit";
            this.btnEditTool.Click += new System.EventHandler(this.btnEditTool_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTool.Image")));
            this.btnDeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(169, 88);
            this.btnDeleteTool.Text = "&Remove";
            this.btnDeleteTool.Click += new System.EventHandler(this.btnDeleteTool_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTool.Image")));
            this.btnUpdateTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(123, 88);
            this.btnUpdateTool.Text = "&Save";
            this.btnUpdateTool.Visible = false;
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTool.Image")));
            this.btnCancelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(150, 88);
            this.btnCancelTool.Text = "&Cancel";
            this.btnCancelTool.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(2606, 1331);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 667;
            this.label2.Text = "Items";
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(2489, 1298);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(121, 85);
            this.lbltotalrecords.TabIndex = 668;
            this.lbltotalrecords.Text = "76";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1210, 1389);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 39);
            this.textBox1.TabIndex = 669;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userfile_id
            // 
            this.userfile_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userfile_id.DataPropertyName = "userfile_id";
            this.userfile_id.FillWeight = 40.60914F;
            this.userfile_id.HeaderText = "ID";
            this.userfile_id.MinimumWidth = 12;
            this.userfile_id.Name = "userfile_id";
            this.userfile_id.ReadOnly = true;
            this.userfile_id.Visible = false;
            this.userfile_id.Width = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NO";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 99.49239F;
            this.username.HeaderText = "USERNAME";
            this.username.MinimumWidth = 12;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // employee_name
            // 
            this.employee_name.DataPropertyName = "employee_name";
            this.employee_name.FillWeight = 99.49239F;
            this.employee_name.HeaderText = "FIRST NAME";
            this.employee_name.MinimumWidth = 12;
            this.employee_name.Name = "employee_name";
            this.employee_name.ReadOnly = true;
            // 
            // employee_lastname
            // 
            this.employee_lastname.DataPropertyName = "employee_lastname";
            this.employee_lastname.FillWeight = 99.49239F;
            this.employee_lastname.HeaderText = "LAST NAME";
            this.employee_lastname.MinimumWidth = 12;
            this.employee_lastname.Name = "employee_lastname";
            this.employee_lastname.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 12;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // department_name
            // 
            this.department_name.DataPropertyName = "department_name";
            this.department_name.HeaderText = "DEPARTMENT";
            this.department_name.MinimumWidth = 12;
            this.department_name.Name = "department_name";
            this.department_name.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "UNIT";
            this.Unit.MinimumWidth = 12;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "POSITION";
            this.Position.MinimumWidth = 12;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // type_of_approver
            // 
            this.type_of_approver.DataPropertyName = "type_of_approver";
            this.type_of_approver.HeaderText = "REQUESTOR TYPE";
            this.type_of_approver.MinimumWidth = 12;
            this.type_of_approver.Name = "type_of_approver";
            this.type_of_approver.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "PASSWORD";
            this.password.MinimumWidth = 12;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // user_rights_name
            // 
            this.user_rights_name.DataPropertyName = "user_rights_name";
            this.user_rights_name.HeaderText = "USER RIGHTS";
            this.user_rights_name.MinimumWidth = 12;
            this.user_rights_name.Name = "user_rights_name";
            this.user_rights_name.ReadOnly = true;
            // 
            // receiving_status
            // 
            this.receiving_status.DataPropertyName = "receiving_status";
            this.receiving_status.HeaderText = "NOTIFICATION";
            this.receiving_status.MinimumWidth = 12;
            this.receiving_status.Name = "receiving_status";
            this.receiving_status.ReadOnly = true;
            // 
            // user_section
            // 
            this.user_section.DataPropertyName = "user_section";
            this.user_section.HeaderText = "LAYOUT";
            this.user_section.MinimumWidth = 12;
            this.user_section.Name = "user_section";
            this.user_section.ReadOnly = true;
            // 
            // frmUserManagement2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2749, 1483);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.mattxtSearch);
            this.Controls.Add(this.materialCard2);
            this.Name = "frmUserManagement2";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement2_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private MaterialSkin.Controls.MaterialTextBox mattxtSearch;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblGenderSelected;
        private System.Windows.Forms.Label lblgenderLabel;
        private MaterialSkin.Controls.MaterialRadioButton matRadioFemale;
        private MaterialSkin.Controls.MaterialRadioButton matRadioMale;
        private MaterialSkin.Controls.MaterialTextBox txtpassword;
        private MaterialSkin.Controls.MaterialTextBox txtuser;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddTool;
        private System.Windows.Forms.ToolStripButton btnEditTool;
        private System.Windows.Forms.ToolStripButton btnDeleteTool;
        private System.Windows.Forms.ToolStripButton btnUpdateTool;
        private System.Windows.Forms.ToolStripButton btnCancelTool;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox cbousertype;
        private MaterialSkin.Controls.MaterialTextBox cmbLocation;
        private MaterialSkin.Controls.MaterialTextBox cbodepartment;
        private MaterialSkin.Controls.MaterialTextBox cboUnit;
        private MaterialSkin.Controls.MaterialTextBox cboPosition;
        private System.Windows.Forms.Label lbltotalrecords;
        private MaterialSkin.Controls.MaterialTextBox cboRequestorType;
        private MaterialSkin.Controls.MaterialTextBox cmbNotif;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userfile_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_of_approver;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiving_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_section;
    }
}