
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdateTool = new MaterialSkin.Controls.MaterialButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
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
            this.materialCard1.Location = new System.Drawing.Point(73, 191);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1624, 554);
            this.materialCard1.TabIndex = 560;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // cbodepartment
            // 
            this.cbodepartment.Enabled = false;
            this.cbodepartment.FormattingEnabled = true;
            this.cbodepartment.ItemHeight = 24;
            this.cbodepartment.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cbodepartment.Location = new System.Drawing.Point(77, 197);
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Size = new System.Drawing.Size(353, 30);
            this.cbodepartment.TabIndex = 585;
            this.cbodepartment.UseSelectable = true;
            this.cbodepartment.SelectedValueChanged += new System.EventHandler(this.cbodepartment_SelectedValueChanged);
            // 
            // cboUnit
            // 
            this.cboUnit.Enabled = false;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.ItemHeight = 24;
            this.cboUnit.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cboUnit.Location = new System.Drawing.Point(572, 197);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(387, 30);
            this.cboUnit.TabIndex = 584;
            this.cboUnit.UseSelectable = true;
            this.cboUnit.SelectionChangeCommitted += new System.EventHandler(this.cboUnit_SelectionChangeCommitted);
            // 
            // cboPosition
            // 
            this.cboPosition.Enabled = false;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.ItemHeight = 24;
            this.cboPosition.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cboPosition.Location = new System.Drawing.Point(1093, 195);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(420, 30);
            this.cboPosition.TabIndex = 583;
            this.cboPosition.UseSelectable = true;
            this.cboPosition.SelectionChangeCommitted += new System.EventHandler(this.cboPosition_SelectionChangeCommitted);
            // 
            // cmbLocation
            // 
            this.cmbLocation.Enabled = false;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.ItemHeight = 24;
            this.cmbLocation.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cmbLocation.Location = new System.Drawing.Point(1093, 302);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(420, 30);
            this.cmbLocation.TabIndex = 582;
            this.cmbLocation.UseSelectable = true;
            // 
            // cboRequestorType
            // 
            this.cboRequestorType.Enabled = false;
            this.cboRequestorType.FormattingEnabled = true;
            this.cboRequestorType.ItemHeight = 24;
            this.cboRequestorType.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cboRequestorType.Location = new System.Drawing.Point(77, 438);
            this.cboRequestorType.Name = "cboRequestorType";
            this.cboRequestorType.Size = new System.Drawing.Size(353, 30);
            this.cboRequestorType.TabIndex = 581;
            this.cboRequestorType.UseSelectable = true;
            this.cboRequestorType.SelectionChangeCommitted += new System.EventHandler(this.cboRequestorType_SelectionChangeCommitted);
            // 
            // cmbNotif
            // 
            this.cmbNotif.Enabled = false;
            this.cmbNotif.FormattingEnabled = true;
            this.cmbNotif.ItemHeight = 24;
            this.cmbNotif.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cmbNotif.Location = new System.Drawing.Point(572, 438);
            this.cmbNotif.Name = "cmbNotif";
            this.cmbNotif.Size = new System.Drawing.Size(387, 30);
            this.cmbNotif.TabIndex = 580;
            this.cmbNotif.UseSelectable = true;
            // 
            // lblGenderSelected
            // 
            this.lblGenderSelected.AutoSize = true;
            this.lblGenderSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenderSelected.Location = new System.Drawing.Point(1325, 393);
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
            this.lblgenderLabel.Location = new System.Drawing.Point(1087, 393);
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
            this.matRadioFemale.Location = new System.Drawing.Point(1299, 431);
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
            this.matRadioMale.Location = new System.Drawing.Point(1096, 434);
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
            this.cbousertype.ItemHeight = 24;
            this.cbousertype.Location = new System.Drawing.Point(1093, 65);
            this.cbousertype.Name = "cbousertype";
            this.cbousertype.Size = new System.Drawing.Size(420, 30);
            this.cbousertype.TabIndex = 575;
            this.cbousertype.UseSelectable = true;
            this.cbousertype.SelectionChangeCommitted += new System.EventHandler(this.cbousertype_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(73, 395);
            this.label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 32);
            this.label16.TabIndex = 567;
            this.label16.Text = "User Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(1092, 267);
            this.label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 32);
            this.label15.TabIndex = 566;
            this.label15.Text = "System Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(566, 396);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 32);
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
            this.txtpassword.Location = new System.Drawing.Point(572, 275);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(387, 50);
            this.txtpassword.TabIndex = 564;
            this.txtpassword.Text = "";
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Depth = 0;
            this.txtuser.Enabled = false;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtuser.Hint = "UserName";
            this.txtuser.Location = new System.Drawing.Point(77, 277);
            this.txtuser.MaxLength = 50;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(349, 50);
            this.txtuser.TabIndex = 563;
            this.txtuser.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(1092, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 32);
            this.label13.TabIndex = 562;
            this.label13.Text = "User Rights:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(1092, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 32);
            this.label12.TabIndex = 561;
            this.label12.Text = "Position:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(566, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
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
            this.txtLastName.Location = new System.Drawing.Point(572, 32);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(387, 50);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Depth = 0;
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtname.Hint = "First Name";
            this.txtname.Location = new System.Drawing.Point(78, 31);
            this.txtname.MaxLength = 50;
            this.txtname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtname.Multiline = false;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(349, 50);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(73, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 32);
            this.label9.TabIndex = 554;
            this.label9.Text = "Department:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(797, 787);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 39);
            this.textBox1.TabIndex = 561;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateTool.Depth = 0;
            this.btnUpdateTool.DrawShadows = true;
            this.btnUpdateTool.HighEmphasis = true;
            this.btnUpdateTool.Icon = null;
            this.btnUpdateTool.Location = new System.Drawing.Point(73, 813);
            this.btnUpdateTool.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(512, 761);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(181, 48);
            this.metroButtonSave.TabIndex = 573;
            this.metroButtonSave.Text = "Add";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Visible = false;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // frmAddnewUserModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 933);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.btnUpdateTool);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmAddnewUserModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddnewUserModal_FormClosing);
            this.Load += new System.EventHandler(this.frmAddnewUserModal_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MetroFramework.Controls.MetroComboBox cbodepartment;
        private MetroFramework.Controls.MetroComboBox cboUnit;
        private MetroFramework.Controls.MetroComboBox cboPosition;
        private MetroFramework.Controls.MetroComboBox cmbLocation;
        private MetroFramework.Controls.MetroComboBox cboRequestorType;
        private MetroFramework.Controls.MetroComboBox cmbNotif;
        private System.Windows.Forms.Label lblGenderSelected;
        private System.Windows.Forms.Label lblgenderLabel;
        private MaterialSkin.Controls.MaterialRadioButton matRadioFemale;
        private MaterialSkin.Controls.MaterialRadioButton matRadioMale;
        private MetroFramework.Controls.MetroComboBox cbousertype;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialTextBox txtpassword;
        private MaterialSkin.Controls.MaterialTextBox txtuser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton btnUpdateTool;
        private MetroFramework.Controls.MetroButton metroButtonSave;
    }
}