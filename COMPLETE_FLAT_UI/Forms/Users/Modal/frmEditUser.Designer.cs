
namespace ULTRAMAVERICK.Forms.Users.Modal
{
    partial class frmEditUser
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
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.lblGenderSelected = new System.Windows.Forms.Label();
            this.matRadioFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdateTool = new MaterialSkin.Controls.MaterialButton();
            this.cmbNotif = new System.Windows.Forms.ComboBox();
            this.CmbLocation = new System.Windows.Forms.ComboBox();
            this.cbousertype = new System.Windows.Forms.ComboBox();
            this.cbodepartment = new System.Windows.Forms.ComboBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.odbEmployeeImage = new System.Windows.Forms.OpenFileDialog();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtuser = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtname = new MaterialSkin.Controls.MaterialTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(842, 212);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(1);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(68, 20);
            this.metroButtonSave.TabIndex = 577;
            this.metroButtonSave.Text = "Add";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Visible = false;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // lblGenderSelected
            // 
            this.lblGenderSelected.AutoSize = true;
            this.lblGenderSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenderSelected.Location = new System.Drawing.Point(651, 212);
            this.lblGenderSelected.Name = "lblGenderSelected";
            this.lblGenderSelected.Size = new System.Drawing.Size(72, 13);
            this.lblGenderSelected.TabIndex = 579;
            this.lblGenderSelected.Text = "Gender Value";
            this.lblGenderSelected.Visible = false;
            // 
            // matRadioFemale
            // 
            this.matRadioFemale.AutoSize = true;
            this.matRadioFemale.Depth = 0;
            this.matRadioFemale.Location = new System.Drawing.Point(771, 158);
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
            this.matRadioMale.Location = new System.Drawing.Point(675, 159);
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(652, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 575;
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
            this.btnUpdateTool.Location = new System.Drawing.Point(888, 371);
            this.btnUpdateTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateTool.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(58, 36);
            this.btnUpdateTool.TabIndex = 576;
            this.btnUpdateTool.Text = "SAVE";
            this.btnUpdateTool.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateTool.UseAccentColor = false;
            this.btnUpdateTool.UseVisualStyleBackColor = true;
            this.btnUpdateTool.Click += new System.EventHandler(this.btnUpdateTool_Click);
            // 
            // cmbNotif
            // 
            this.cmbNotif.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNotif.FormattingEnabled = true;
            this.cmbNotif.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cmbNotif.Location = new System.Drawing.Point(213, 384);
            this.cmbNotif.Margin = new System.Windows.Forms.Padding(1);
            this.cmbNotif.Name = "cmbNotif";
            this.cmbNotif.Size = new System.Drawing.Size(180, 31);
            this.cmbNotif.TabIndex = 591;
            this.cmbNotif.Visible = false;
            // 
            // CmbLocation
            // 
            this.CmbLocation.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbLocation.FormattingEnabled = true;
            this.CmbLocation.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.CmbLocation.Location = new System.Drawing.Point(429, 381);
            this.CmbLocation.Margin = new System.Windows.Forms.Padding(1);
            this.CmbLocation.Name = "CmbLocation";
            this.CmbLocation.Size = new System.Drawing.Size(238, 31);
            this.CmbLocation.TabIndex = 589;
            this.CmbLocation.Visible = false;
            // 
            // cbousertype
            // 
            this.cbousertype.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbousertype.FormattingEnabled = true;
            this.cbousertype.Location = new System.Drawing.Point(672, 34);
            this.cbousertype.Margin = new System.Windows.Forms.Padding(1);
            this.cbousertype.Name = "cbousertype";
            this.cbousertype.Size = new System.Drawing.Size(238, 31);
            this.cbousertype.TabIndex = 578;
            this.cbousertype.SelectionChangeCommitted += new System.EventHandler(this.cbousertype_SelectionChangeCommitted);
            // 
            // cbodepartment
            // 
            this.cbodepartment.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodepartment.FormattingEnabled = true;
            this.cbodepartment.Location = new System.Drawing.Point(200, 100);
            this.cbodepartment.Margin = new System.Windows.Forms.Padding(1);
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Size = new System.Drawing.Size(180, 31);
            this.cbodepartment.TabIndex = 586;
            this.cbodepartment.SelectedValueChanged += new System.EventHandler(this.cbodepartment_SelectedValueChanged);
            // 
            // cboUnit
            // 
            this.cboUnit.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(424, 100);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(1);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(197, 31);
            this.cboUnit.TabIndex = 587;
            this.cboUnit.SelectionChangeCommitted += new System.EventHandler(this.cboUnit_SelectionChangeCommitted);
            // 
            // cboPosition
            // 
            this.cboPosition.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(672, 99);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(1);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(238, 31);
            this.cboPosition.TabIndex = 588;
            this.cboPosition.SelectionChangeCommitted += new System.EventHandler(this.cboPosition_SelectionChangeCommitted);
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
            this.btnImage.Location = new System.Drawing.Point(18, 234);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(60, 27);
            this.btnImage.TabIndex = 593;
            this.btnImage.Text = "Select";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
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
            this.btnRemove.Location = new System.Drawing.Point(96, 234);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 27);
            this.btnRemove.TabIndex = 594;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // odbEmployeeImage
            // 
            this.odbEmployeeImage.Title = "Select Image";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.textBox1);
            this.materialCard2.Controls.Add(this.metroButtonSave);
            this.materialCard2.Controls.Add(this.lblGenderSelected);
            this.materialCard2.Controls.Add(this.matRadioFemale);
            this.materialCard2.Controls.Add(this.matRadioMale);
            this.materialCard2.Controls.Add(this.btnRemove);
            this.materialCard2.Controls.Add(this.cbousertype);
            this.materialCard2.Controls.Add(this.btnImage);
            this.materialCard2.Controls.Add(this.pbImage);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.cbodepartment);
            this.materialCard2.Controls.Add(this.cboUnit);
            this.materialCard2.Controls.Add(this.cboPosition);
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Controls.Add(this.txtpassword);
            this.materialCard2.Controls.Add(this.txtuser);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Controls.Add(this.label7);
            this.materialCard2.Controls.Add(this.label8);
            this.materialCard2.Controls.Add(this.txtLastName);
            this.materialCard2.Controls.Add(this.txtname);
            this.materialCard2.Controls.Add(this.label10);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 74);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(932, 282);
            this.materialCard2.TabIndex = 580;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Image = global::ULTRAMAVERICK.Properties.Resources.Buddy;
            this.pbImage.Location = new System.Drawing.Point(19, 19);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(158, 180);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 592;
            this.pbImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(776, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 579;
            this.label2.Text = "Gender:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(687, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 578;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(429, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 566;
            this.label4.Text = "System Type:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(214, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 565;
            this.label5.Text = "Notification:";
            this.label5.Visible = false;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Depth = 0;
            this.txtpassword.Enabled = false;
            this.txtpassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtpassword.Hint = "Password";
            this.txtpassword.Location = new System.Drawing.Point(423, 148);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(198, 50);
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
            this.txtuser.Location = new System.Drawing.Point(201, 149);
            this.txtuser.Margin = new System.Windows.Forms.Padding(1);
            this.txtuser.MaxLength = 50;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(179, 50);
            this.txtuser.TabIndex = 563;
            this.txtuser.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(672, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 562;
            this.label6.Text = "User Rights:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(672, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 561;
            this.label7.Text = "Position:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(421, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 556;
            this.label8.Text = "SubUnit:";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLastName.Hint = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(423, 19);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(1);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(198, 50);
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
            this.txtname.Location = new System.Drawing.Point(201, 19);
            this.txtname.Margin = new System.Windows.Forms.Padding(1);
            this.txtname.MaxLength = 50;
            this.txtname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtname.Multiline = false;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 50);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(199, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 554;
            this.label10.Text = "Department:";
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.cmbNotif);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbLocation);
            this.Controls.Add(this.btnUpdateTool);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditUser";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditUser_FormClosing_1);
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonSave;
        private System.Windows.Forms.Label lblGenderSelected;
        private MaterialSkin.Controls.MaterialRadioButton matRadioFemale;
        private MaterialSkin.Controls.MaterialRadioButton matRadioMale;
        private MaterialSkin.Controls.MaterialButton btnUpdateTool;
        private System.Windows.Forms.ComboBox cbousertype;
        private System.Windows.Forms.ComboBox cbodepartment;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.ComboBox CmbLocation;
        private System.Windows.Forms.ComboBox cmbNotif;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.OpenFileDialog odbEmployeeImage;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtpassword;
        private MaterialSkin.Controls.MaterialTextBox txtuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbImage;
        public System.Windows.Forms.TextBox textBox1;
    }
}