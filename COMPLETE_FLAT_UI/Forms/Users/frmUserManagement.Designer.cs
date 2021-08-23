
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboRequestorType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbodepartment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.cmbNotif = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbousertype = new System.Windows.Forms.ComboBox();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.lblrecords = new System.Windows.Forms.Label();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new System.Windows.Forms.Button();
            this.metroButtonUpdate = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.lblPositionId = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.lblRequestorTypeID = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTool = new System.Windows.Forms.ToolStripButton();
            this.btnEditTool = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateTool = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTool = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTool = new System.Windows.Forms.ToolStripButton();
            this.lblrecordDesc = new System.Windows.Forms.Label();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Management";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::ULTRAMAVERICK.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(28, 29);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(115, 103);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUsers.BackColor = System.Drawing.SystemColors.Control;
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsers.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 50;
            this.lstUsers.Location = new System.Drawing.Point(34, 73);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(1451, 450);
            this.lstUsers.TabIndex = 152;
            this.lstUsers.Click += new System.EventHandler(this.lstUsers_Click);
            this.lstUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstUsers_MouseClick);
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            this.lstUsers.SelectedValueChanged += new System.EventHandler(this.lstUsers_SelectedValueChanged);
            this.lstUsers.CursorChanged += new System.EventHandler(this.lstUsers_CursorChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbltotalrecords);
            this.groupBox1.Controls.Add(this.lblrecordDesc);
            this.groupBox1.Controls.Add(this.lstUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(59, 922);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1527, 595);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.cboRequestorType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbodepartment);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbLocation);
            this.groupBox2.Controls.Add(this.cmbNotif);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtuser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboPosition);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cbousertype);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(59, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1527, 556);
            this.groupBox2.TabIndex = 154;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cboRequestorType
            // 
            this.cboRequestorType.Enabled = false;
            this.cboRequestorType.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRequestorType.FormattingEnabled = true;
            this.cboRequestorType.Location = new System.Drawing.Point(1040, 296);
            this.cboRequestorType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboRequestorType.Name = "cboRequestorType";
            this.cboRequestorType.Size = new System.Drawing.Size(445, 45);
            this.cboRequestorType.TabIndex = 557;
            this.cboRequestorType.SelectedValueChanged += new System.EventHandler(this.cboRequestorType_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(804, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 39);
            this.label10.TabIndex = 556;
            this.label10.Text = "User Type :";
            // 
            // cbodepartment
            // 
            this.cbodepartment.Enabled = false;
            this.cbodepartment.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodepartment.FormattingEnabled = true;
            this.cbodepartment.Location = new System.Drawing.Point(264, 296);
            this.cbodepartment.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Size = new System.Drawing.Size(445, 45);
            this.cbodepartment.TabIndex = 555;
            this.cbodepartment.SelectedValueChanged += new System.EventHandler(this.cbodepartment_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(7, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 39);
            this.label9.TabIndex = 554;
            this.label9.Text = "Department :";
            // 
            // cmbLocation
            // 
            this.cmbLocation.Enabled = false;
            this.cmbLocation.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Office",
            "Production"});
            this.cmbLocation.Location = new System.Drawing.Point(264, 368);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(445, 45);
            this.cmbLocation.TabIndex = 551;
            // 
            // cmbNotif
            // 
            this.cmbNotif.Enabled = false;
            this.cmbNotif.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNotif.FormattingEnabled = true;
            this.cmbNotif.Items.AddRange(new object[] {
            "FG On",
            "FGPENDING On",
            "RM On",
            "Off"});
            this.cmbNotif.Location = new System.Drawing.Point(1040, 365);
            this.cmbNotif.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbNotif.Name = "cmbNotif";
            this.cmbNotif.Size = new System.Drawing.Size(445, 45);
            this.cmbNotif.TabIndex = 553;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(792, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 39);
            this.label8.TabIndex = 180;
            this.label8.Text = "Notification :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(68, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 39);
            this.label7.TabIndex = 179;
            this.label7.Text = "Section :";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Enabled = false;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(1040, 232);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtpassword.MaxLength = 100;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(445, 36);
            this.txtpassword.TabIndex = 178;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(811, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 39);
            this.label6.TabIndex = 177;
            this.label6.Text = "Password :";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Enabled = false;
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(264, 229);
            this.txtuser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtuser.MaxLength = 100;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(445, 36);
            this.txtuser.TabIndex = 176;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 39);
            this.label5.TabIndex = 175;
            this.label5.Text = "Username :";
            // 
            // cboPosition
            // 
            this.cboPosition.Enabled = false;
            this.cboPosition.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(1040, 148);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(445, 45);
            this.cboPosition.TabIndex = 174;
            this.cboPosition.SelectedValueChanged += new System.EventHandler(this.cboPosition_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(842, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 39);
            this.label4.TabIndex = 173;
            this.label4.Text = "Position :";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(1040, 79);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLastName.MaxLength = 100;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(445, 36);
            this.txtLastName.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(801, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 39);
            this.label3.TabIndex = 171;
            this.label3.Text = "Last Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Enabled = false;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(264, 76);
            this.txtname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtname.MaxLength = 100;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(445, 36);
            this.txtname.TabIndex = 155;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(92, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 39);
            this.label2.TabIndex = 170;
            this.label2.Text = "Name :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(8, 144);
            this.label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(213, 39);
            this.label19.TabIndex = 168;
            this.label19.Text = "User Rights :";
            // 
            // cbousertype
            // 
            this.cbousertype.Enabled = false;
            this.cbousertype.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbousertype.FormattingEnabled = true;
            this.cbousertype.Location = new System.Drawing.Point(264, 142);
            this.cbousertype.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbousertype.Name = "cbousertype";
            this.cbousertype.Size = new System.Drawing.Size(445, 45);
            this.cbousertype.TabIndex = 169;
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.AllowUserToResizeColumns = false;
            this.dgv_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_table.ColumnHeadersHeight = 45;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_table.EnableHeadersVisualStyles = false;
            this.dgv_table.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_table.Location = new System.Drawing.Point(1629, 229);
            this.dgv_table.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgv_table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(267, 469);
            this.dgv_table.TabIndex = 415;
            this.dgv_table.CurrentCellChanged += new System.EventHandler(this.dgv_table_CurrentCellChanged);
            // 
            // lblrecords
            // 
            this.lblrecords.AutoSize = true;
            this.lblrecords.BackColor = System.Drawing.Color.Transparent;
            this.lblrecords.Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecords.ForeColor = System.Drawing.Color.Black;
            this.lblrecords.Location = new System.Drawing.Point(1636, 98);
            this.lblrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblrecords.Name = "lblrecords";
            this.lblrecords.Size = new System.Drawing.Size(197, 34);
            this.lblrecords.TabIndex = 416;
            this.lblrecords.Text = "SearchCount";
            this.lblrecords.Visible = false;
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(1629, 747);
            this.metroButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(181, 48);
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
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
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
            this.button1.Location = new System.Drawing.Point(1187, 821);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 72);
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
            this.btnCancel.Location = new System.Drawing.Point(1629, 875);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 55);
            this.btnCancel.TabIndex = 425;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            // 
            // metroButtonUpdate
            // 
            this.metroButtonUpdate.Location = new System.Drawing.Point(1614, 1020);
            this.metroButtonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonUpdate.Name = "metroButtonUpdate";
            this.metroButtonUpdate.Size = new System.Drawing.Size(181, 48);
            this.metroButtonUpdate.TabIndex = 426;
            this.metroButtonUpdate.Text = "Update";
            this.metroButtonUpdate.UseSelectable = true;
            this.metroButtonUpdate.Visible = false;
            this.metroButtonUpdate.Click += new System.EventHandler(this.metroButtonUpdate_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(1679, 1107);
            this.metroButtonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(181, 48);
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
            this.lblPositionId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPositionId.Location = new System.Drawing.Point(1054, 78);
            this.lblPositionId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPositionId.Name = "lblPositionId";
            this.lblPositionId.Size = new System.Drawing.Size(183, 39);
            this.lblPositionId.TabIndex = 554;
            this.lblPositionId.Text = "Position ID";
            this.lblPositionId.Visible = false;
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDepartmentID.Location = new System.Drawing.Point(1253, 64);
            this.lblDepartmentID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(238, 39);
            this.lblDepartmentID.TabIndex = 556;
            this.lblDepartmentID.Text = "Deparmtent ID";
            this.lblDepartmentID.Visible = false;
            // 
            // lblRequestorTypeID
            // 
            this.lblRequestorTypeID.AutoSize = true;
            this.lblRequestorTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestorTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestorTypeID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRequestorTypeID.Location = new System.Drawing.Point(767, 93);
            this.lblRequestorTypeID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRequestorTypeID.Name = "lblRequestorTypeID";
            this.lblRequestorTypeID.Size = new System.Drawing.Size(218, 39);
            this.lblRequestorTypeID.TabIndex = 557;
            this.lblRequestorTypeID.Text = "Requestor ID";
            this.lblRequestorTypeID.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTool,
            this.btnEditTool,
            this.btnDeleteTool,
            this.btnUpdateTool,
            this.btnCancelTool});
            this.toolStrip1.Location = new System.Drawing.Point(3, 501);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1521, 52);
            this.toolStrip1.TabIndex = 558;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Image = global::ULTRAMAVERICK.Properties.Resources.Dashboard;
            this.btnAddTool.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(122, 45);
            this.btnAddTool.Text = "&New";
            this.btnAddTool.Click += new System.EventHandler(this.btnAddTool_Click);
            // 
            // btnEditTool
            // 
            this.btnEditTool.Image = global::ULTRAMAVERICK.Properties.Resources.Dashboard;
            this.btnEditTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(112, 45);
            this.btnEditTool.Text = "&Edit";
            this.btnEditTool.Click += new System.EventHandler(this.btnEditTool_Click);
            // 
            // btnUpdateTool
            // 
            this.btnUpdateTool.Image = global::ULTRAMAVERICK.Properties.Resources.Dashboard;
            this.btnUpdateTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateTool.Name = "btnUpdateTool";
            this.btnUpdateTool.Size = new System.Drawing.Size(123, 45);
            this.btnUpdateTool.Text = "&Save";
            this.btnUpdateTool.Visible = false;
            this.btnUpdateTool.Click += new System.EventHandler(this.btnUpdateTool_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Image = global::ULTRAMAVERICK.Properties.Resources.Dashboard;
            this.btnDeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteTool.Text = "&Delete";
            this.btnDeleteTool.Click += new System.EventHandler(this.btnDeleteTool_Click);
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.Image = global::ULTRAMAVERICK.Properties.Resources.Dashboard;
            this.btnCancelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(150, 45);
            this.btnCancelTool.Text = "&Cancel";
            this.btnCancelTool.Visible = false;
            this.btnCancelTool.Click += new System.EventHandler(this.btnCancelTool_Click);
            // 
            // lblrecordDesc
            // 
            this.lblrecordDesc.AutoSize = true;
            this.lblrecordDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblrecordDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecordDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblrecordDesc.Location = new System.Drawing.Point(41, 544);
            this.lblrecordDesc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblrecordDesc.Name = "lblrecordDesc";
            this.lblrecordDesc.Size = new System.Drawing.Size(247, 39);
            this.lblrecordDesc.TabIndex = 558;
            this.lblrecordDesc.Text = "Total Records :";
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltotalrecords.Location = new System.Drawing.Point(305, 544);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(92, 39);
            this.lbltotalrecords.TabIndex = 558;
            this.lbltotalrecords.Text = "CCC";
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1977, 1529);
            this.Controls.Add(this.lblRequestorTypeID);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.lblPositionId);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.lblrecords);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "frmUserManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbousertype;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.ComboBox cmbNotif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Label lblrecords;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private System.Windows.Forms.Button btnCancel;
        private MetroFramework.Controls.MetroButton metroButtonUpdate;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private System.Windows.Forms.Label lblPositionId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbodepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboRequestorType;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblRequestorTypeID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddTool;
        private System.Windows.Forms.ToolStripButton btnEditTool;
        private System.Windows.Forms.ToolStripButton btnUpdateTool;
        private System.Windows.Forms.ToolStripButton btnDeleteTool;
        private System.Windows.Forms.ToolStripButton btnCancelTool;
        private System.Windows.Forms.Label lblrecordDesc;
        private System.Windows.Forms.Label lbltotalrecords;
    }
}