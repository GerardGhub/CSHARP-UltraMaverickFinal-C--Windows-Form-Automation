
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    partial class frmInternalApprovedOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.matRadioActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioNotActive = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBoxColorGuide = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lbltotalOrderQty = new System.Windows.Forms.Label();
            this.materialCheckboxSelectAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.matbtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mrs_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_req_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_requested_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_ITEMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_requested_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_wh_preparation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialCard3.SuspendLayout();
            this.groupBoxColorGuide.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(69, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 29);
            this.panel1.TabIndex = 0;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.matRadioActive);
            this.materialCard3.Controls.Add(this.matRadioNotActive);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(747, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(221, 59);
            this.materialCard3.TabIndex = 655;
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
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(8, 12);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(124, 19);
            this.materialLabel5.TabIndex = 584;
            this.materialLabel5.Text = "Preparation Date:";
            // 
            // groupBoxColorGuide
            // 
            this.groupBoxColorGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColorGuide.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxColorGuide.Controls.Add(this.panel3);
            this.groupBoxColorGuide.Controls.Add(this.materialLabel7);
            this.groupBoxColorGuide.Controls.Add(this.panel2);
            this.groupBoxColorGuide.Controls.Add(this.materialLabel4);
            this.groupBoxColorGuide.Controls.Add(this.panel1);
            this.groupBoxColorGuide.Controls.Add(this.materialLabel6);
            this.groupBoxColorGuide.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColorGuide.Location = new System.Drawing.Point(261, 699);
            this.groupBoxColorGuide.Name = "groupBoxColorGuide";
            this.groupBoxColorGuide.Size = new System.Drawing.Size(441, 62);
            this.groupBoxColorGuide.TabIndex = 671;
            this.groupBoxColorGuide.TabStop = false;
            this.groupBoxColorGuide.Text = "Preparation Ledger :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(195, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 29);
            this.panel3.TabIndex = 2;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel7.Location = new System.Drawing.Point(153, 27);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(24, 14);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "2 - 5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Location = new System.Drawing.Point(383, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 29);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel4.Location = new System.Drawing.Point(33, 27);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(18, 14);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "0-1";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.Location = new System.Drawing.Point(291, 28);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(51, 14);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "6 - Above";
            // 
            // lbltotalOrderQty
            // 
            this.lbltotalOrderQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalOrderQty.AutoSize = true;
            this.lbltotalOrderQty.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalOrderQty.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalOrderQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalOrderQty.Location = new System.Drawing.Point(839, 710);
            this.lbltotalOrderQty.Name = "lbltotalOrderQty";
            this.lbltotalOrderQty.Size = new System.Drawing.Size(31, 35);
            this.lbltotalOrderQty.TabIndex = 669;
            this.lbltotalOrderQty.Text = "0";
            // 
            // materialCheckboxSelectAll
            // 
            this.materialCheckboxSelectAll.AutoSize = true;
            this.materialCheckboxSelectAll.Depth = 0;
            this.materialCheckboxSelectAll.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCheckboxSelectAll.Location = new System.Drawing.Point(28, 177);
            this.materialCheckboxSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxSelectAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxSelectAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxSelectAll.Name = "materialCheckboxSelectAll";
            this.materialCheckboxSelectAll.Ripple = true;
            this.materialCheckboxSelectAll.Size = new System.Drawing.Size(100, 37);
            this.materialCheckboxSelectAll.TabIndex = 658;
            this.materialCheckboxSelectAll.Text = "Select All";
            this.materialCheckboxSelectAll.UseVisualStyleBackColor = true;
            this.materialCheckboxSelectAll.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(708, 724);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 670;
            this.label2.Text = "Total Order Quantity:";
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(8, 39);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(170, 33);
            this.bunifuPrepaDate.TabIndex = 574;
            this.bunifuPrepaDate.ValueChanged += new System.EventHandler(this.bunifuPrepaDate_ValueChanged);
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(920, 710);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(31, 35);
            this.lbltotaldata.TabIndex = 664;
            this.lbltotaldata.Text = "0";
            this.lbltotaldata.TextChanged += new System.EventHandler(this.lbltotaldata_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(965, 724);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 665;
            this.label4.Text = "Items";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvStoreOrderApproval);
            this.materialCard2.Controls.Add(this.textBox2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(23, 216);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(980, 479);
            this.materialCard2.TabIndex = 659;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(83, 442);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 657;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(869, 720);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 668;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(800, 812);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(51, 36);
            this.lbltotalrecords.TabIndex = 660;
            this.lbltotalrecords.Text = "76";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(842, 828);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 661;
            this.label3.Text = "Items";
            // 
            // matbtnCancel
            // 
            this.matbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnCancel.Depth = 0;
            this.matbtnCancel.DrawShadows = true;
            this.matbtnCancel.HighEmphasis = true;
            this.matbtnCancel.Icon = null;
            this.matbtnCancel.Location = new System.Drawing.Point(92, 720);
            this.matbtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnCancel.Name = "matbtnCancel";
            this.matbtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matbtnCancel.TabIndex = 663;
            this.matbtnCancel.Text = "CANCEL";
            this.matbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnCancel.UseAccentColor = false;
            this.matbtnCancel.UseVisualStyleBackColor = true;
            // 
            // matbtnEdit
            // 
            this.matbtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnEdit.Depth = 0;
            this.matbtnEdit.DrawShadows = true;
            this.matbtnEdit.HighEmphasis = true;
            this.matbtnEdit.Icon = null;
            this.matbtnEdit.Location = new System.Drawing.Point(23, 720);
            this.matbtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnEdit.Name = "matbtnEdit";
            this.matbtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matbtnEdit.TabIndex = 667;
            this.matbtnEdit.Text = "EDIT";
            this.matbtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnEdit.UseAccentColor = false;
            this.matbtnEdit.UseVisualStyleBackColor = true;
            this.matbtnEdit.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.bunifuPrepaDate);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(980, 90);
            this.materialCard1.TabIndex = 662;
            // 
            // dgvStoreOrderApproval
            // 
            this.dgvStoreOrderApproval.AllowUserToAddRows = false;
            this.dgvStoreOrderApproval.AllowUserToDeleteRows = false;
            this.dgvStoreOrderApproval.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoreOrderApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreOrderApproval.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrderApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStoreOrderApproval.ColumnHeadersHeight = 45;
            this.dgvStoreOrderApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.mrs_id,
            this.department_id,
            this.mrs_req_desc,
            this.mrs_requested_by,
            this.TOTAL_ITEMS,
            this.mrs_requested_date,
            this.is_wh_preparation_date,
            this.is_active});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrderApproval.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStoreOrderApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreOrderApproval.EnableHeadersVisualStyles = false;
            this.dgvStoreOrderApproval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.Location = new System.Drawing.Point(5, 6);
            this.dgvStoreOrderApproval.MultiSelect = false;
            this.dgvStoreOrderApproval.Name = "dgvStoreOrderApproval";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStoreOrderApproval.RowHeadersVisible = false;
            this.dgvStoreOrderApproval.RowHeadersWidth = 102;
            this.dgvStoreOrderApproval.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.RowTemplate.DividerHeight = 5;
            this.dgvStoreOrderApproval.RowTemplate.Height = 40;
            this.dgvStoreOrderApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreOrderApproval.Size = new System.Drawing.Size(970, 467);
            this.dgvStoreOrderApproval.TabIndex = 658;
            this.dgvStoreOrderApproval.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStoreOrderApproval.ThemeStyle.ReadOnly = false;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvStoreOrderApproval.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStoreOrderApproval_CellFormatting);
            this.dgvStoreOrderApproval.CurrentCellChanged += new System.EventHandler(this.dgvStoreOrderApproval_CurrentCellChanged);
            // 
            // selected
            // 
            this.selected.DataPropertyName = "selected";
            this.selected.FalseValue = "FALSE";
            this.selected.HeaderText = "*";
            this.selected.MinimumWidth = 12;
            this.selected.Name = "selected";
            this.selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selected.TrueValue = "TRUE";
            this.selected.Visible = false;
            // 
            // mrs_id
            // 
            this.mrs_id.DataPropertyName = "mrs_id";
            this.mrs_id.FillWeight = 66.91177F;
            this.mrs_id.HeaderText = "MRS ID";
            this.mrs_id.MinimumWidth = 12;
            this.mrs_id.Name = "mrs_id";
            this.mrs_id.ReadOnly = true;
            // 
            // department_id
            // 
            this.department_id.DataPropertyName = "department_id";
            this.department_id.FillWeight = 66.57212F;
            this.department_id.HeaderText = "DEPARTMENT";
            this.department_id.MinimumWidth = 12;
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            // 
            // mrs_req_desc
            // 
            this.mrs_req_desc.DataPropertyName = "mrs_req_desc";
            this.mrs_req_desc.HeaderText = "DESCRIPTION";
            this.mrs_req_desc.Name = "mrs_req_desc";
            this.mrs_req_desc.ReadOnly = true;
            // 
            // mrs_requested_by
            // 
            this.mrs_requested_by.DataPropertyName = "mrs_requested_by";
            this.mrs_requested_by.FillWeight = 66.57212F;
            this.mrs_requested_by.HeaderText = "REQUESTED BY";
            this.mrs_requested_by.MinimumWidth = 12;
            this.mrs_requested_by.Name = "mrs_requested_by";
            this.mrs_requested_by.ReadOnly = true;
            // 
            // TOTAL_ITEMS
            // 
            this.TOTAL_ITEMS.DataPropertyName = "TOTAL_ITEMS";
            this.TOTAL_ITEMS.FillWeight = 66.57212F;
            this.TOTAL_ITEMS.HeaderText = "TOTAL ITEM";
            this.TOTAL_ITEMS.MinimumWidth = 12;
            this.TOTAL_ITEMS.Name = "TOTAL_ITEMS";
            this.TOTAL_ITEMS.ReadOnly = true;
            // 
            // mrs_requested_date
            // 
            this.mrs_requested_date.DataPropertyName = "mrs_requested_date";
            this.mrs_requested_date.HeaderText = "REQUESTED DATE";
            this.mrs_requested_date.Name = "mrs_requested_date";
            this.mrs_requested_date.ReadOnly = true;
            // 
            // is_wh_preparation_date
            // 
            this.is_wh_preparation_date.DataPropertyName = "is_wh_preparation_date";
            this.is_wh_preparation_date.HeaderText = "PREPARATION DATE";
            this.is_wh_preparation_date.Name = "is_wh_preparation_date";
            this.is_wh_preparation_date.ReadOnly = true;
            // 
            // is_active
            // 
            this.is_active.DataPropertyName = "is_active";
            this.is_active.HeaderText = "VIEW ITEMS";
            this.is_active.Name = "is_active";
            this.is_active.Text = "VIEW";
            this.is_active.UseColumnTextForButtonValue = true;
            // 
            // frmInternalApprovedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.groupBoxColorGuide);
            this.Controls.Add(this.lbltotalOrderQty);
            this.Controls.Add(this.materialCheckboxSelectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matbtnCancel);
            this.Controls.Add(this.matbtnEdit);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.Name = "frmInternalApprovedOrder";
            this.Text = "Internal Approved Order";
            this.Load += new System.EventHandler(this.frmInternalApprovedOrder_Load);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.groupBoxColorGuide.ResumeLayout(false);
            this.groupBoxColorGuide.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton matRadioActive;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotActive;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.GroupBox groupBoxColorGuide;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Label lbltotalOrderQty;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxSelectAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton matbtnCancel;
        private MaterialSkin.Controls.MaterialButton matbtnEdit;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_req_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_requested_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_ITEMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_requested_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_wh_preparation_date;
        private System.Windows.Forms.DataGridViewButtonColumn is_active;
    }
}