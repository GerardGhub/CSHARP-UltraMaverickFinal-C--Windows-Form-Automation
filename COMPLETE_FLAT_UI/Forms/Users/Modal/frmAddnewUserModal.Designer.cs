
namespace ULTRAMAVERICK.Forms.Users.Modal
{
    partial class frmAddnewUserModal
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnUpdateTool = new MaterialSkin.Controls.MaterialButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.Cbodepartment = new MetroFramework.Controls.MetroComboBox();
            this.CboUnit = new MetroFramework.Controls.MetroComboBox();
            this.cboPosition = new MetroFramework.Controls.MetroComboBox();
            this.CmBLocation = new MetroFramework.Controls.MetroComboBox();
            this.cmbNotif = new MetroFramework.Controls.MetroComboBox();
            this.lblGenderSelected = new System.Windows.Forms.Label();
            this.matRadioFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.CboUserType = new MetroFramework.Controls.MetroComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtUserName = new MaterialSkin.Controls.MaterialTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.matChkQAUserAccount = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblgenderLabel = new System.Windows.Forms.Label();
            this.odbEmployeeImage = new System.Windows.Forms.OpenFileDialog();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblgenderLabel);
            this.materialCard1.Controls.Add(this.btnRemove);
            this.materialCard1.Controls.Add(this.btnImage);
            this.materialCard1.Controls.Add(this.btnUpdateTool);
            this.materialCard1.Controls.Add(this.pbImage);
            this.materialCard1.Controls.Add(this.Cbodepartment);
            this.materialCard1.Controls.Add(this.CboUnit);
            this.materialCard1.Controls.Add(this.cboPosition);
            this.materialCard1.Controls.Add(this.CmBLocation);
            this.materialCard1.Controls.Add(this.cmbNotif);
            this.materialCard1.Controls.Add(this.matRadioFemale);
            this.materialCard1.Controls.Add(this.matRadioMale);
            this.materialCard1.Controls.Add(this.CboUserType);
            this.materialCard1.Controls.Add(this.label15);
            this.materialCard1.Controls.Add(this.label14);
            this.materialCard1.Controls.Add(this.TxtPassword);
            this.materialCard1.Controls.Add(this.TxtUserName);
            this.materialCard1.Controls.Add(this.label13);
            this.materialCard1.Controls.Add(this.label12);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.TxtLastName);
            this.materialCard1.Controls.Add(this.TxtFirstName);
            this.materialCard1.Controls.Add(this.label9);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(30, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(905, 282);
            this.materialCard1.TabIndex = 560;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(87, 233);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 27);
            this.btnRemove.TabIndex = 597;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(9, 233);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(60, 27);
            this.btnImage.TabIndex = 596;
            this.btnImage.Text = "Select";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateTool.Depth = 0;
            this.btnUpdateTool.DrawShadows = true;
            this.btnUpdateTool.HighEmphasis = true;
            this.btnUpdateTool.Icon = null;
            this.btnUpdateTool.Location = new System.Drawing.Point(827, 227);
            this.btnUpdateTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(58, 36);
            this.btnUpdateTool.TabIndex = 572;
            this.btnUpdateTool.Text = "SAVE";
            this.btnUpdateTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateTool.UseAccentColor = false;
            this.btnUpdateTool.UseVisualStyleBackColor = true;
            this.btnUpdateTool.Click += new System.EventHandler(this.btnUpdateTool_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(10, 18);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(158, 180);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 595;
            this.pbImage.TabStop = false;
            // 
            // Cbodepartment
            // 
            this.Cbodepartment.Enabled = false;
            this.Cbodepartment.FormattingEnabled = true;
            this.Cbodepartment.ItemHeight = 23;
            this.Cbodepartment.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.Cbodepartment.Location = new System.Drawing.Point(176, 101);
            this.Cbodepartment.Margin = new System.Windows.Forms.Padding(1);
            this.Cbodepartment.Name = "Cbodepartment";
            this.Cbodepartment.Size = new System.Drawing.Size(179, 29);
            this.Cbodepartment.TabIndex = 585;
            this.Cbodepartment.UseSelectable = true;
            this.Cbodepartment.SelectedValueChanged += new System.EventHandler(this.cbodepartment_SelectedValueChanged);
            // 
            // CboUnit
            // 
            this.CboUnit.Enabled = false;
            this.CboUnit.FormattingEnabled = true;
            this.CboUnit.ItemHeight = 23;
            this.CboUnit.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.CboUnit.Location = new System.Drawing.Point(398, 101);
            this.CboUnit.Margin = new System.Windows.Forms.Padding(1);
            this.CboUnit.Name = "CboUnit";
            this.CboUnit.Size = new System.Drawing.Size(201, 29);
            this.CboUnit.TabIndex = 584;
            this.CboUnit.UseSelectable = true;
            this.CboUnit.SelectionChangeCommitted += new System.EventHandler(this.cboUnit_SelectionChangeCommitted);
            // 
            // cboPosition
            // 
            this.cboPosition.Enabled = false;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.ItemHeight = 23;
            this.cboPosition.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cboPosition.Location = new System.Drawing.Point(647, 100);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(1);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(238, 29);
            this.cboPosition.TabIndex = 583;
            this.cboPosition.UseSelectable = true;
            this.cboPosition.SelectionChangeCommitted += new System.EventHandler(this.cboPosition_SelectionChangeCommitted);
            // 
            // CmBLocation
            // 
            this.CmBLocation.Enabled = false;
            this.CmBLocation.FormattingEnabled = true;
            this.CmBLocation.ItemHeight = 23;
            this.CmBLocation.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.CmBLocation.Location = new System.Drawing.Point(647, 159);
            this.CmBLocation.Margin = new System.Windows.Forms.Padding(1);
            this.CmBLocation.Name = "CmBLocation";
            this.CmBLocation.Size = new System.Drawing.Size(238, 29);
            this.CmBLocation.TabIndex = 582;
            this.CmBLocation.UseSelectable = true;
            // 
            // cmbNotif
            // 
            this.cmbNotif.Enabled = false;
            this.cmbNotif.FormattingEnabled = true;
            this.cmbNotif.ItemHeight = 23;
            this.cmbNotif.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cmbNotif.Location = new System.Drawing.Point(175, 230);
            this.cmbNotif.Margin = new System.Windows.Forms.Padding(1);
            this.cmbNotif.Name = "cmbNotif";
            this.cmbNotif.Size = new System.Drawing.Size(180, 29);
            this.cmbNotif.TabIndex = 580;
            this.cmbNotif.UseSelectable = true;
            // 
            // lblGenderSelected
            // 
            this.lblGenderSelected.AutoSize = true;
            this.lblGenderSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderSelected.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.lblGenderSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenderSelected.Location = new System.Drawing.Point(869, 389);
            this.lblGenderSelected.Name = "lblGenderSelected";
            this.lblGenderSelected.Size = new System.Drawing.Size(46, 13);
            this.lblGenderSelected.TabIndex = 579;
            this.lblGenderSelected.Text = "Gender:";
            this.lblGenderSelected.Visible = false;
            // 
            // matRadioFemale
            // 
            this.matRadioFemale.AutoSize = true;
            this.matRadioFemale.Depth = 0;
            this.matRadioFemale.Enabled = false;
            this.matRadioFemale.Location = new System.Drawing.Point(486, 227);
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
            this.matRadioMale.Location = new System.Drawing.Point(410, 228);
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
            // CboUserType
            // 
            this.CboUserType.Enabled = false;
            this.CboUserType.FormattingEnabled = true;
            this.CboUserType.ItemHeight = 23;
            this.CboUserType.Location = new System.Drawing.Point(647, 32);
            this.CboUserType.Margin = new System.Windows.Forms.Padding(1);
            this.CboUserType.Name = "CboUserType";
            this.CboUserType.Size = new System.Drawing.Size(238, 29);
            this.CboUserType.TabIndex = 575;
            this.CboUserType.UseSelectable = true;
            this.CboUserType.SelectionChangeCommitted += new System.EventHandler(this.cbousertype_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(647, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 566;
            this.label15.Text = "System Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(176, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 565;
            this.label14.Text = "Notification:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPassword.Hint = "Password";
            this.TxtPassword.Location = new System.Drawing.Point(398, 147);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(198, 50);
            this.TxtPassword.TabIndex = 564;
            this.TxtPassword.Text = "";
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserName.Depth = 0;
            this.TxtUserName.Enabled = false;
            this.TxtUserName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtUserName.Hint = "UserName";
            this.TxtUserName.Location = new System.Drawing.Point(176, 148);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(1);
            this.TxtUserName.MaxLength = 50;
            this.TxtUserName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUserName.Multiline = false;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(179, 50);
            this.TxtUserName.TabIndex = 563;
            this.TxtUserName.Text = "";
            this.TxtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(647, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 562;
            this.label13.Text = "User Rights:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(647, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 561;
            this.label12.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(396, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 556;
            this.label1.Text = "SubUnit:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLastName.Depth = 0;
            this.TxtLastName.Enabled = false;
            this.TxtLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtLastName.Hint = "Last Name";
            this.TxtLastName.Location = new System.Drawing.Point(398, 18);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(1);
            this.TxtLastName.MaxLength = 50;
            this.TxtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtLastName.Multiline = false;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(198, 50);
            this.TxtLastName.TabIndex = 1;
            this.TxtLastName.Text = "";
            this.TxtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFirstName.Depth = 0;
            this.TxtFirstName.Enabled = false;
            this.TxtFirstName.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtFirstName.Hint = "First Name";
            this.TxtFirstName.Location = new System.Drawing.Point(176, 18);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.TxtFirstName.MaxLength = 50;
            this.TxtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtFirstName.Multiline = false;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(179, 50);
            this.TxtFirstName.TabIndex = 0;
            this.TxtFirstName.Text = "";
            this.TxtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(174, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 554;
            this.label9.Text = "Department:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(707, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 561;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // matChkQAUserAccount
            // 
            this.matChkQAUserAccount.AutoSize = true;
            this.matChkQAUserAccount.Depth = 0;
            this.matChkQAUserAccount.Location = new System.Drawing.Point(30, 377);
            this.matChkQAUserAccount.Margin = new System.Windows.Forms.Padding(0);
            this.matChkQAUserAccount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matChkQAUserAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.matChkQAUserAccount.Name = "matChkQAUserAccount";
            this.matChkQAUserAccount.Ripple = true;
            this.matChkQAUserAccount.Size = new System.Drawing.Size(153, 37);
            this.matChkQAUserAccount.TabIndex = 574;
            this.matChkQAUserAccount.Text = "QA User Account";
            this.matChkQAUserAccount.UseVisualStyleBackColor = true;
            this.matChkQAUserAccount.Visible = false;
            this.matChkQAUserAccount.CheckedChanged += new System.EventHandler(this.matChkQAUserAccount_CheckedChanged);
            // 
            // lblgenderLabel
            // 
            this.lblgenderLabel.AutoSize = true;
            this.lblgenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblgenderLabel.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.lblgenderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgenderLabel.Location = new System.Drawing.Point(613, 251);
            this.lblgenderLabel.Name = "lblgenderLabel";
            this.lblgenderLabel.Size = new System.Drawing.Size(0, 13);
            this.lblgenderLabel.TabIndex = 579;
            // 
            // odbEmployeeImage
            // 
            this.odbEmployeeImage.Title = "Select Image";
            // 
            // frmAddnewUserModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.matChkQAUserAccount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblGenderSelected);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddnewUserModal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddnewUserModal_FormClosing);
            this.Load += new System.EventHandler(this.frmAddnewUserModal_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MetroFramework.Controls.MetroComboBox Cbodepartment;
        private MetroFramework.Controls.MetroComboBox CboUnit;
        private MetroFramework.Controls.MetroComboBox cboPosition;
        private MetroFramework.Controls.MetroComboBox CmBLocation;
        private MetroFramework.Controls.MetroComboBox cmbNotif;
        private System.Windows.Forms.Label lblGenderSelected;
        private MaterialSkin.Controls.MaterialRadioButton matRadioFemale;
        private MaterialSkin.Controls.MaterialRadioButton matRadioMale;
        private MetroFramework.Controls.MetroComboBox CboUserType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialTextBox TxtPassword;
        private MaterialSkin.Controls.MaterialTextBox TxtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox TxtLastName;
        private MaterialSkin.Controls.MaterialTextBox TxtFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton btnUpdateTool;
        private MaterialSkin.Controls.MaterialCheckbox matChkQAUserAccount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblgenderLabel;
        private System.Windows.Forms.OpenFileDialog odbEmployeeImage;
    }
}