
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Dispatching
{
    partial class frmStoreOrderDispatching
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabelRecentLogs = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.metroCmbStoreName = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.matcmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.groupBoxColorGuide = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.lbltotalOrderQty = new System.Windows.Forms.Label();
            this.materialCheckboxSelectAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSelectedSum = new System.Windows.Forms.Label();
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.crV1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvGunaMoveItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wh_checker_move_order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_approved_prepa_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_state_repack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabelTo = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuDateTo = new System.Windows.Forms.DateTimePicker();
            this.materialLabelFrom = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuPrepaDateFrom = new System.Windows.Forms.DateTimePicker();
            this.matCmbPreparationDate = new MetroFramework.Controls.MetroComboBox();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matbtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroCMbFilterPrintPages = new MetroFramework.Controls.MetroComboBox();
            this.materialLabelNoPrintPages = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonPrintPreview = new MaterialSkin.Controls.MaterialButton();
            this.lblTextTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3.SuspendLayout();
            this.groupBoxColorGuide.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunaMoveItems)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabelRecentLogs);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(881, 5);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(178, 28);
            this.materialCard3.TabIndex = 655;
            this.materialCard3.Click += new System.EventHandler(this.materialCard3_Click);
            this.materialCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard3_Paint);
            // 
            // materialLabelRecentLogs
            // 
            this.materialLabelRecentLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelRecentLogs.AutoSize = true;
            this.materialLabelRecentLogs.Depth = 0;
            this.materialLabelRecentLogs.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelRecentLogs.Location = new System.Drawing.Point(24, 5);
            this.materialLabelRecentLogs.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelRecentLogs.Name = "materialLabelRecentLogs";
            this.materialLabelRecentLogs.Size = new System.Drawing.Size(137, 19);
            this.materialLabelRecentLogs.TabIndex = 657;
            this.materialLabelRecentLogs.Text = "View Recent Log(s)";
            this.materialLabelRecentLogs.Click += new System.EventHandler(this.materialLabelRecentLogs_Click);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(440, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(38, 19);
            this.materialLabel3.TabIndex = 580;
            this.materialLabel3.Text = "Store";
            // 
            // metroCmbStoreName
            // 
            this.metroCmbStoreName.FormattingEnabled = true;
            this.metroCmbStoreName.ItemHeight = 23;
            this.metroCmbStoreName.Location = new System.Drawing.Point(439, 39);
            this.metroCmbStoreName.Name = "metroCmbStoreName";
            this.metroCmbStoreName.Size = new System.Drawing.Size(224, 29);
            this.metroCmbStoreName.TabIndex = 579;
            this.metroCmbStoreName.UseSelectable = true;
            this.metroCmbStoreName.SelectionChangeCommitted += new System.EventHandler(this.metroCmbStoreName_SelectionChangeCommitted);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(233, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 578;
            this.materialLabel2.Text = "Category:";
            // 
            // matcmbCategory
            // 
            this.matcmbCategory.FormattingEnabled = true;
            this.matcmbCategory.ItemHeight = 23;
            this.matcmbCategory.Location = new System.Drawing.Point(232, 39);
            this.matcmbCategory.Name = "matcmbCategory";
            this.matcmbCategory.Size = new System.Drawing.Size(182, 29);
            this.matcmbCategory.TabIndex = 577;
            this.matcmbCategory.UseSelectable = true;
            this.matcmbCategory.SelectionChangeCommitted += new System.EventHandler(this.matcmbCategory_SelectionChangeCommitted);
            // 
            // groupBoxColorGuide
            // 
            this.groupBoxColorGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColorGuide.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxColorGuide.Controls.Add(this.panel3);
            this.groupBoxColorGuide.Controls.Add(this.materialLabel7);
            this.groupBoxColorGuide.Controls.Add(this.panel2);
            this.groupBoxColorGuide.Controls.Add(this.materialLabel6);
            this.groupBoxColorGuide.Controls.Add(this.materialLabel4);
            this.groupBoxColorGuide.Controls.Add(this.panel1);
            this.groupBoxColorGuide.Controls.Add(this.matbtnCancel);
            this.groupBoxColorGuide.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColorGuide.Location = new System.Drawing.Point(405, 697);
            this.groupBoxColorGuide.Name = "groupBoxColorGuide";
            this.groupBoxColorGuide.Size = new System.Drawing.Size(394, 62);
            this.groupBoxColorGuide.TabIndex = 671;
            this.groupBoxColorGuide.TabStop = false;
            this.groupBoxColorGuide.Text = "Color Coding Guide :";
            this.groupBoxColorGuide.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(468, 20);
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
            this.materialLabel7.Location = new System.Drawing.Point(360, 27);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(90, 14);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "2 - 5 to Prepared";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Location = new System.Drawing.Point(299, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 29);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.Location = new System.Drawing.Point(175, 27);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(111, 14);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "2-Above to Prepared";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel4.Location = new System.Drawing.Point(13, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(87, 14);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "0-1 To Prepared";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(117, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 29);
            this.panel1.TabIndex = 0;
            // 
            // matbtnCancel
            // 
            this.matbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnCancel.Depth = 0;
            this.matbtnCancel.DrawShadows = true;
            this.matbtnCancel.HighEmphasis = true;
            this.matbtnCancel.Icon = null;
            this.matbtnCancel.Location = new System.Drawing.Point(23, 20);
            this.matbtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnCancel.Name = "matbtnCancel";
            this.matbtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matbtnCancel.TabIndex = 663;
            this.matbtnCancel.Text = "CANCEL";
            this.matbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnCancel.UseAccentColor = false;
            this.matbtnCancel.UseVisualStyleBackColor = true;
            this.matbtnCancel.Visible = false;
            // 
            // lbltotalOrderQty
            // 
            this.lbltotalOrderQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalOrderQty.AutoSize = true;
            this.lbltotalOrderQty.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalOrderQty.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalOrderQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalOrderQty.Location = new System.Drawing.Point(936, 708);
            this.lbltotalOrderQty.Name = "lbltotalOrderQty";
            this.lbltotalOrderQty.Size = new System.Drawing.Size(32, 40);
            this.lbltotalOrderQty.TabIndex = 669;
            this.lbltotalOrderQty.Text = "0";
            this.lbltotalOrderQty.Visible = false;
            // 
            // materialCheckboxSelectAll
            // 
            this.materialCheckboxSelectAll.AutoSize = true;
            this.materialCheckboxSelectAll.Depth = 0;
            this.materialCheckboxSelectAll.Location = new System.Drawing.Point(428, 173);
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
            this.materialCheckboxSelectAll.CheckedChanged += new System.EventHandler(this.materialCheckboxSelectAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(805, 722);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 670;
            this.label2.Text = "Total Order Quantity:";
            this.label2.Visible = false;
            // 
            // labelSelectedSum
            // 
            this.labelSelectedSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedSum.AutoSize = true;
            this.labelSelectedSum.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedSum.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.labelSelectedSum.Location = new System.Drawing.Point(881, 168);
            this.labelSelectedSum.Name = "labelSelectedSum";
            this.labelSelectedSum.Size = new System.Drawing.Size(32, 40);
            this.labelSelectedSum.TabIndex = 666;
            this.labelSelectedSum.Text = "0";
            this.labelSelectedSum.Visible = false;
            this.labelSelectedSum.TextChanged += new System.EventHandler(this.labelSelectedSum_TextChanged);
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(1017, 708);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(32, 40);
            this.lbltotaldata.TabIndex = 664;
            this.lbltotaldata.Text = "0";
            this.lbltotaldata.TextChanged += new System.EventHandler(this.lbltotaldata_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(1062, 722);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 665;
            this.label4.Text = "Items";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.crV1);
            this.materialCard2.Controls.Add(this.textBox2);
            this.materialCard2.Controls.Add(this.dgvGunaMoveItems);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(23, 214);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(1077, 479);
            this.materialCard2.TabIndex = 659;
            // 
            // crV1
            // 
            this.crV1.ActiveViewIndex = -1;
            this.crV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crV1.Location = new System.Drawing.Point(11, 330);
            this.crV1.Margin = new System.Windows.Forms.Padding(1);
            this.crV1.Name = "crV1";
            this.crV1.Size = new System.Drawing.Size(84, 84);
            this.crV1.TabIndex = 673;
            this.crV1.ToolPanelWidth = 1;
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
            // dgvGunaMoveItems
            // 
            this.dgvGunaMoveItems.AllowUserToAddRows = false;
            this.dgvGunaMoveItems.AllowUserToDeleteRows = false;
            this.dgvGunaMoveItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvGunaMoveItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvGunaMoveItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGunaMoveItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvGunaMoveItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGunaMoveItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGunaMoveItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvGunaMoveItems.ColumnHeadersHeight = 45;
            this.dgvGunaMoveItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGunaMoveItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.wh_checker_move_order_no,
            this.is_approved_prepa_date,
            this.fox,
            this.store_name,
            this.route,
            this.category,
            this.area,
            this.total_state_repack});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGunaMoveItems.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvGunaMoveItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGunaMoveItems.Enabled = false;
            this.dgvGunaMoveItems.EnableHeadersVisualStyles = false;
            this.dgvGunaMoveItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGunaMoveItems.Location = new System.Drawing.Point(5, 6);
            this.dgvGunaMoveItems.MultiSelect = false;
            this.dgvGunaMoveItems.Name = "dgvGunaMoveItems";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGunaMoveItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvGunaMoveItems.RowHeadersVisible = false;
            this.dgvGunaMoveItems.RowHeadersWidth = 102;
            this.dgvGunaMoveItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGunaMoveItems.RowTemplate.DividerHeight = 5;
            this.dgvGunaMoveItems.RowTemplate.Height = 40;
            this.dgvGunaMoveItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGunaMoveItems.Size = new System.Drawing.Size(1067, 467);
            this.dgvGunaMoveItems.TabIndex = 594;
            this.dgvGunaMoveItems.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvGunaMoveItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGunaMoveItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGunaMoveItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGunaMoveItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGunaMoveItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGunaMoveItems.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvGunaMoveItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGunaMoveItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvGunaMoveItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvGunaMoveItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGunaMoveItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGunaMoveItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGunaMoveItems.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGunaMoveItems.ThemeStyle.ReadOnly = false;
            this.dgvGunaMoveItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGunaMoveItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvGunaMoveItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGunaMoveItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvGunaMoveItems.ThemeStyle.RowsStyle.Height = 40;
            this.dgvGunaMoveItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvGunaMoveItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGunaMoveItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGunaMoveItems_CellContentClick);
            this.dgvGunaMoveItems.CurrentCellChanged += new System.EventHandler(this.dgvGunaMoveItems_CurrentCellChanged);
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
            // 
            // wh_checker_move_order_no
            // 
            this.wh_checker_move_order_no.DataPropertyName = "wh_checker_move_order_no";
            this.wh_checker_move_order_no.HeaderText = "ORDER NO.";
            this.wh_checker_move_order_no.Name = "wh_checker_move_order_no";
            // 
            // is_approved_prepa_date
            // 
            this.is_approved_prepa_date.DataPropertyName = "is_approved_prepa_date";
            this.is_approved_prepa_date.FillWeight = 66.57212F;
            this.is_approved_prepa_date.HeaderText = "PREPARATION DATE";
            this.is_approved_prepa_date.MinimumWidth = 12;
            this.is_approved_prepa_date.Name = "is_approved_prepa_date";
            // 
            // fox
            // 
            this.fox.DataPropertyName = "fox";
            this.fox.HeaderText = "FOX";
            this.fox.MinimumWidth = 6;
            this.fox.Name = "fox";
            // 
            // store_name
            // 
            this.store_name.DataPropertyName = "store_name";
            this.store_name.HeaderText = "STORE";
            this.store_name.MinimumWidth = 6;
            this.store_name.Name = "store_name";
            // 
            // route
            // 
            this.route.DataPropertyName = "route";
            this.route.FillWeight = 66.91177F;
            this.route.HeaderText = "ROUTE";
            this.route.MinimumWidth = 12;
            this.route.Name = "route";
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 66.91177F;
            this.category.HeaderText = "CATEGORY";
            this.category.MinimumWidth = 12;
            this.category.Name = "category";
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.FillWeight = 66.91177F;
            this.area.HeaderText = "AREA";
            this.area.MinimumWidth = 12;
            this.area.Name = "area";
            // 
            // total_state_repack
            // 
            this.total_state_repack.DataPropertyName = "total_state_repack";
            this.total_state_repack.HeaderText = "TOTAL ITEMS";
            this.total_state_repack.MinimumWidth = 6;
            this.total_state_repack.Name = "total_state_repack";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabelTo);
            this.materialCard1.Controls.Add(this.bunifuDateTo);
            this.materialCard1.Controls.Add(this.materialLabelFrom);
            this.materialCard1.Controls.Add(this.bunifuPrepaDateFrom);
            this.materialCard1.Controls.Add(this.matCmbPreparationDate);
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.metroCmbStoreName);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.matcmbCategory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 79);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(1077, 90);
            this.materialCard1.TabIndex = 662;
            // 
            // materialLabelTo
            // 
            this.materialLabelTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelTo.AutoSize = true;
            this.materialLabelTo.Depth = 0;
            this.materialLabelTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTo.Location = new System.Drawing.Point(884, 60);
            this.materialLabelTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTo.Name = "materialLabelTo";
            this.materialLabelTo.Size = new System.Drawing.Size(24, 19);
            this.materialLabelTo.TabIndex = 660;
            this.materialLabelTo.Text = "To:";
            this.materialLabelTo.Visible = false;
            // 
            // bunifuDateTo
            // 
            this.bunifuDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDateTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuDateTo.CustomFormat = "yyyy-MM-dd";
            this.bunifuDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDateTo.Location = new System.Drawing.Point(917, 53);
            this.bunifuDateTo.Name = "bunifuDateTo";
            this.bunifuDateTo.Size = new System.Drawing.Size(153, 31);
            this.bunifuDateTo.TabIndex = 659;
            this.bunifuDateTo.Visible = false;
            this.bunifuDateTo.ValueChanged += new System.EventHandler(this.bunifuDateTo_ValueChanged);
            // 
            // materialLabelFrom
            // 
            this.materialLabelFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelFrom.AutoSize = true;
            this.materialLabelFrom.Depth = 0;
            this.materialLabelFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelFrom.Location = new System.Drawing.Point(674, 59);
            this.materialLabelFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelFrom.Name = "materialLabelFrom";
            this.materialLabelFrom.Size = new System.Drawing.Size(42, 19);
            this.materialLabelFrom.TabIndex = 658;
            this.materialLabelFrom.Text = "From:";
            this.materialLabelFrom.Visible = false;
            // 
            // bunifuPrepaDateFrom
            // 
            this.bunifuPrepaDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPrepaDateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDateFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDateFrom.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDateFrom.Location = new System.Drawing.Point(723, 52);
            this.bunifuPrepaDateFrom.Name = "bunifuPrepaDateFrom";
            this.bunifuPrepaDateFrom.Size = new System.Drawing.Size(153, 31);
            this.bunifuPrepaDateFrom.TabIndex = 657;
            this.bunifuPrepaDateFrom.Visible = false;
            this.bunifuPrepaDateFrom.ValueChanged += new System.EventHandler(this.bunifuPrepaDateFrom_ValueChanged);
            // 
            // matCmbPreparationDate
            // 
            this.matCmbPreparationDate.FormattingEnabled = true;
            this.matCmbPreparationDate.ItemHeight = 23;
            this.matCmbPreparationDate.Location = new System.Drawing.Point(11, 39);
            this.matCmbPreparationDate.Name = "matCmbPreparationDate";
            this.matCmbPreparationDate.Size = new System.Drawing.Size(182, 29);
            this.matCmbPreparationDate.TabIndex = 656;
            this.matCmbPreparationDate.UseSelectable = true;
            this.matCmbPreparationDate.SelectionChangeCommitted += new System.EventHandler(this.matCmbPreparationDate_SelectionChangeCommitted);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(897, 810);
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
            this.label3.Location = new System.Drawing.Point(939, 826);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 661;
            this.label3.Text = "Items";
            // 
            // matbtnEdit
            // 
            this.matbtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnEdit.Depth = 0;
            this.matbtnEdit.DrawShadows = true;
            this.matbtnEdit.HighEmphasis = true;
            this.matbtnEdit.Icon = null;
            this.matbtnEdit.Location = new System.Drawing.Point(23, 718);
            this.matbtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnEdit.Name = "matbtnEdit";
            this.matbtnEdit.Size = new System.Drawing.Size(63, 36);
            this.matbtnEdit.TabIndex = 667;
            this.matbtnEdit.Text = "PRINT";
            this.matbtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnEdit.UseAccentColor = false;
            this.matbtnEdit.UseVisualStyleBackColor = true;
            this.matbtnEdit.Visible = false;
            this.matbtnEdit.Click += new System.EventHandler(this.matbtnEdit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(869, 718);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 668;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // metroCMbFilterPrintPages
            // 
            this.metroCMbFilterPrintPages.FormattingEnabled = true;
            this.metroCMbFilterPrintPages.ItemHeight = 23;
            this.metroCMbFilterPrintPages.Items.AddRange(new object[] {
            "1",
            "2"});
            this.metroCMbFilterPrintPages.Location = new System.Drawing.Point(552, 176);
            this.metroCMbFilterPrintPages.Name = "metroCMbFilterPrintPages";
            this.metroCMbFilterPrintPages.Size = new System.Drawing.Size(65, 29);
            this.metroCMbFilterPrintPages.TabIndex = 657;
            this.metroCMbFilterPrintPages.UseSelectable = true;
            this.metroCMbFilterPrintPages.Visible = false;
            // 
            // materialLabelNoPrintPages
            // 
            this.materialLabelNoPrintPages.AutoSize = true;
            this.materialLabelNoPrintPages.Depth = 0;
            this.materialLabelNoPrintPages.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelNoPrintPages.Location = new System.Drawing.Point(625, 182);
            this.materialLabelNoPrintPages.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNoPrintPages.Name = "materialLabelNoPrintPages";
            this.materialLabelNoPrintPages.Size = new System.Drawing.Size(114, 19);
            this.materialLabelNoPrintPages.TabIndex = 657;
            this.materialLabelNoPrintPages.Text = "No. Print Pages:";
            this.materialLabelNoPrintPages.Visible = false;
            // 
            // materialButtonPrintPreview
            // 
            this.materialButtonPrintPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintPreview.Depth = 0;
            this.materialButtonPrintPreview.DrawShadows = true;
            this.materialButtonPrintPreview.HighEmphasis = true;
            this.materialButtonPrintPreview.Icon = null;
            this.materialButtonPrintPreview.Location = new System.Drawing.Point(100, 718);
            this.materialButtonPrintPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.materialButtonPrintPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintPreview.Name = "materialButtonPrintPreview";
            this.materialButtonPrintPreview.Size = new System.Drawing.Size(129, 36);
            this.materialButtonPrintPreview.TabIndex = 668;
            this.materialButtonPrintPreview.Text = "PRINT PREVIEW";
            this.materialButtonPrintPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintPreview.UseAccentColor = false;
            this.materialButtonPrintPreview.UseVisualStyleBackColor = true;
            this.materialButtonPrintPreview.Visible = false;
            this.materialButtonPrintPreview.Click += new System.EventHandler(this.materialButtonPrintPreview_Click);
            // 
            // lblTextTitle
            // 
            this.lblTextTitle.AutoSize = true;
            this.lblTextTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTextTitle.Depth = 0;
            this.lblTextTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTextTitle.Location = new System.Drawing.Point(27, 183);
            this.lblTextTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTextTitle.Name = "lblTextTitle";
            this.lblTextTitle.Size = new System.Drawing.Size(127, 19);
            this.lblTextTitle.TabIndex = 672;
            this.lblTextTitle.Text = "Store  Move Order";
            // 
            // frmStoreOrderDispatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 768);
            this.Controls.Add(this.lblTextTitle);
            this.Controls.Add(this.materialButtonPrintPreview);
            this.Controls.Add(this.materialLabelNoPrintPages);
            this.Controls.Add(this.metroCMbFilterPrintPages);
            this.Controls.Add(this.groupBoxColorGuide);
            this.Controls.Add(this.lbltotalOrderQty);
            this.Controls.Add(this.materialCheckboxSelectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSelectedSum);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matbtnEdit);
            this.Controls.Add(this.textBox1);
            this.Name = "frmStoreOrderDispatching";
            this.Text = "Store  Move Order";
            this.Load += new System.EventHandler(this.frmStoreOrderDispatching_Load);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.groupBoxColorGuide.ResumeLayout(false);
            this.groupBoxColorGuide.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunaMoveItems)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroComboBox metroCmbStoreName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox matcmbCategory;
        private System.Windows.Forms.GroupBox groupBoxColorGuide;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltotalOrderQty;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxSelectAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSelectedSum;
        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        public System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGunaMoveItems;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton matbtnCancel;
        private MaterialSkin.Controls.MaterialButton matbtnEdit;
        public System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroComboBox matCmbPreparationDate;
        private MetroFramework.Controls.MetroComboBox metroCMbFilterPrintPages;
        private MaterialSkin.Controls.MaterialLabel materialLabelNoPrintPages;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crV1;
        private MaterialSkin.Controls.MaterialLabel materialLabelRecentLogs;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabelFrom;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDateFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabelTo;
        private System.Windows.Forms.DateTimePicker bunifuDateTo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn wh_checker_move_order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_approved_prepa_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fox;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn route;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_state_repack;
        private MaterialSkin.Controls.MaterialLabel lblTextTitle;
    }
}