
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    partial class frmDryWhMiscellaneousReceipts
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
            this.MatBtnNew = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox10 = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            this.materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtLotDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtLotNo = new MaterialSkin.Controls.MaterialTextBox();
            this.GpInfo = new System.Windows.Forms.GroupBox();
            this.guna2DgvMaterialPreparation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mrs_item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.converted_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serve_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatTxTTransactNo = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.GpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvMaterialPreparation)).BeginInit();
            this.SuspendLayout();
            // 
            // MatBtnNew
            // 
            this.MatBtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnNew.Depth = 0;
            this.MatBtnNew.DrawShadows = true;
            this.MatBtnNew.HighEmphasis = true;
            this.MatBtnNew.Icon = null;
            this.MatBtnNew.Location = new System.Drawing.Point(23, 691);
            this.MatBtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnNew.Name = "MatBtnNew";
            this.MatBtnNew.Size = new System.Drawing.Size(53, 36);
            this.MatBtnNew.TabIndex = 0;
            this.MatBtnNew.Text = "NEW";
            this.MatBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnNew.UseAccentColor = false;
            this.MatBtnNew.UseVisualStyleBackColor = true;
            this.MatBtnNew.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.MatTxtItemCode);
            this.groupBox1.Controls.Add(this.materialTextBox5);
            this.groupBox1.Controls.Add(this.materialTextBox6);
            this.groupBox1.Controls.Add(this.materialTextBox10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.bunifuPrepaDate);
            this.groupBox1.Controls.Add(this.materialTextBox7);
            this.groupBox1.Controls.Add(this.materialTextBox8);
            this.groupBox1.Controls.Add(this.materialTextBox4);
            this.groupBox1.Controls.Add(this.MatTxtLotDescription);
            this.groupBox1.Controls.Add(this.MatTxtLotNo);
            this.groupBox1.Controls.Add(this.GpInfo);
            this.groupBox1.Controls.Add(this.MatTxTTransactNo);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 603);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Material Information";
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Enabled = false;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox5.Hint = "Remarks";
            this.materialTextBox5.Location = new System.Drawing.Point(704, 205);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox5.TabIndex = 581;
            this.materialTextBox5.Text = "";
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Enabled = false;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox6.Hint = "Quantity";
            this.materialTextBox6.Location = new System.Drawing.Point(365, 205);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox6.TabIndex = 580;
            this.materialTextBox6.Text = "";
            // 
            // materialTextBox10
            // 
            this.materialTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox10.Depth = 0;
            this.materialTextBox10.Enabled = false;
            this.materialTextBox10.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox10.Hint = "Supplier";
            this.materialTextBox10.Location = new System.Drawing.Point(26, 204);
            this.materialTextBox10.MaxLength = 50;
            this.materialTextBox10.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox10.Multiline = false;
            this.materialTextBox10.Name = "materialTextBox10";
            this.materialTextBox10.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox10.TabIndex = 579;
            this.materialTextBox10.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 578;
            this.label2.Text = "Exp. Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 577;
            this.label1.Text = "Mftg. Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 30);
            this.dateTimePicker1.TabIndex = 576;
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDate.Enabled = false;
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(26, 111);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(270, 30);
            this.bunifuPrepaDate.TabIndex = 575;
            // 
            // materialTextBox7
            // 
            this.materialTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox7.Depth = 0;
            this.materialTextBox7.Enabled = false;
            this.materialTextBox7.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox7.Hint = "Category";
            this.materialTextBox7.Location = new System.Drawing.Point(704, 149);
            this.materialTextBox7.MaxLength = 50;
            this.materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox7.Multiline = false;
            this.materialTextBox7.Name = "materialTextBox7";
            this.materialTextBox7.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox7.TabIndex = 9;
            this.materialTextBox7.Text = "";
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Enabled = false;
            this.materialTextBox8.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox8.Hint = "Item Description";
            this.materialTextBox8.Location = new System.Drawing.Point(365, 149);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox8.TabIndex = 8;
            this.materialTextBox8.Text = "";
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Enabled = false;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox4.Hint = "Expiry Days";
            this.materialTextBox4.Location = new System.Drawing.Point(704, 93);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox4.TabIndex = 6;
            this.materialTextBox4.Text = "";
            // 
            // MatTxtLotDescription
            // 
            this.MatTxtLotDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtLotDescription.Depth = 0;
            this.MatTxtLotDescription.Enabled = false;
            this.MatTxtLotDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtLotDescription.Hint = "Lot Description";
            this.MatTxtLotDescription.Location = new System.Drawing.Point(704, 37);
            this.MatTxtLotDescription.MaxLength = 50;
            this.MatTxtLotDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtLotDescription.Multiline = false;
            this.MatTxtLotDescription.Name = "MatTxtLotDescription";
            this.MatTxtLotDescription.Size = new System.Drawing.Size(270, 50);
            this.MatTxtLotDescription.TabIndex = 3;
            this.MatTxtLotDescription.Text = "";
            // 
            // MatTxtLotNo
            // 
            this.MatTxtLotNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtLotNo.Depth = 0;
            this.MatTxtLotNo.Enabled = false;
            this.MatTxtLotNo.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtLotNo.Hint = "Lot No.";
            this.MatTxtLotNo.Location = new System.Drawing.Point(365, 37);
            this.MatTxtLotNo.MaxLength = 50;
            this.MatTxtLotNo.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtLotNo.Multiline = false;
            this.MatTxtLotNo.Name = "MatTxtLotNo";
            this.MatTxtLotNo.Size = new System.Drawing.Size(270, 50);
            this.MatTxtLotNo.TabIndex = 2;
            this.MatTxtLotNo.Text = "";
            // 
            // GpInfo
            // 
            this.GpInfo.Controls.Add(this.guna2DgvMaterialPreparation);
            this.GpInfo.Location = new System.Drawing.Point(26, 261);
            this.GpInfo.Name = "GpInfo";
            this.GpInfo.Size = new System.Drawing.Size(955, 329);
            this.GpInfo.TabIndex = 1;
            this.GpInfo.TabStop = false;
            this.GpInfo.Text = "Transaction";
            // 
            // guna2DgvMaterialPreparation
            // 
            this.guna2DgvMaterialPreparation.AllowUserToAddRows = false;
            this.guna2DgvMaterialPreparation.AllowUserToDeleteRows = false;
            this.guna2DgvMaterialPreparation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DgvMaterialPreparation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DgvMaterialPreparation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DgvMaterialPreparation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DgvMaterialPreparation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DgvMaterialPreparation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DgvMaterialPreparation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DgvMaterialPreparation.ColumnHeadersHeight = 45;
            this.guna2DgvMaterialPreparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DgvMaterialPreparation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mrs_item_code,
            this.description,
            this.category,
            this.uom,
            this.qty,
            this.converted_qty,
            this.Serve_Qty,
            this.Remaining_Qty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DgvMaterialPreparation.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DgvMaterialPreparation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DgvMaterialPreparation.Enabled = false;
            this.guna2DgvMaterialPreparation.EnableHeadersVisualStyles = false;
            this.guna2DgvMaterialPreparation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DgvMaterialPreparation.Location = new System.Drawing.Point(3, 23);
            this.guna2DgvMaterialPreparation.MultiSelect = false;
            this.guna2DgvMaterialPreparation.Name = "guna2DgvMaterialPreparation";
            this.guna2DgvMaterialPreparation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DgvMaterialPreparation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DgvMaterialPreparation.RowHeadersVisible = false;
            this.guna2DgvMaterialPreparation.RowHeadersWidth = 102;
            this.guna2DgvMaterialPreparation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DgvMaterialPreparation.RowTemplate.DividerHeight = 5;
            this.guna2DgvMaterialPreparation.RowTemplate.Height = 40;
            this.guna2DgvMaterialPreparation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DgvMaterialPreparation.Size = new System.Drawing.Size(949, 303);
            this.guna2DgvMaterialPreparation.TabIndex = 596;
            this.guna2DgvMaterialPreparation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DgvMaterialPreparation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DgvMaterialPreparation.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DgvMaterialPreparation.ThemeStyle.HeaderStyle.Height = 45;
            this.guna2DgvMaterialPreparation.ThemeStyle.ReadOnly = true;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2DgvMaterialPreparation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // mrs_item_code
            // 
            this.mrs_item_code.DataPropertyName = "mrs_item_code";
            this.mrs_item_code.FillWeight = 66.91177F;
            this.mrs_item_code.HeaderText = "CODE";
            this.mrs_item_code.MinimumWidth = 12;
            this.mrs_item_code.Name = "mrs_item_code";
            this.mrs_item_code.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 66.57212F;
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 12;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.FillWeight = 66.57212F;
            this.uom.HeaderText = "SUPPLIER";
            this.uom.MinimumWidth = 12;
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.FillWeight = 66.57212F;
            this.qty.HeaderText = "QTY";
            this.qty.MinimumWidth = 12;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // converted_qty
            // 
            this.converted_qty.DataPropertyName = "converted_qty";
            this.converted_qty.HeaderText = "MFG DATE";
            this.converted_qty.MinimumWidth = 6;
            this.converted_qty.Name = "converted_qty";
            this.converted_qty.ReadOnly = true;
            // 
            // Serve_Qty
            // 
            this.Serve_Qty.DataPropertyName = "Serve_Qty";
            this.Serve_Qty.FillWeight = 66.91177F;
            this.Serve_Qty.HeaderText = "EXPIRY DATE";
            this.Serve_Qty.MinimumWidth = 12;
            this.Serve_Qty.Name = "Serve_Qty";
            this.Serve_Qty.ReadOnly = true;
            // 
            // Remaining_Qty
            // 
            this.Remaining_Qty.DataPropertyName = "Remaining_Qty";
            this.Remaining_Qty.HeaderText = "EXPIRY DAYS";
            this.Remaining_Qty.Name = "Remaining_Qty";
            this.Remaining_Qty.ReadOnly = true;
            // 
            // MatTxTTransactNo
            // 
            this.MatTxTTransactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxTTransactNo.Depth = 0;
            this.MatTxTTransactNo.Enabled = false;
            this.MatTxTTransactNo.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxTTransactNo.Hint = "Transaction No.";
            this.MatTxTTransactNo.Location = new System.Drawing.Point(26, 36);
            this.MatTxTTransactNo.MaxLength = 50;
            this.MatTxTTransactNo.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxTTransactNo.Multiline = false;
            this.MatTxTTransactNo.Name = "MatTxTTransactNo";
            this.MatTxTTransactNo.Size = new System.Drawing.Size(270, 50);
            this.MatTxTTransactNo.TabIndex = 0;
            this.MatTxTTransactNo.Text = "";
            // 
            // MatTxtItemCode
            // 
            this.MatTxtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtItemCode.Depth = 0;
            this.MatTxtItemCode.Enabled = false;
            this.MatTxtItemCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtItemCode.Hint = "Item Code";
            this.MatTxtItemCode.Location = new System.Drawing.Point(26, 149);
            this.MatTxtItemCode.MaxLength = 50;
            this.MatTxtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtItemCode.Multiline = false;
            this.MatTxtItemCode.Name = "MatTxtItemCode";
            this.MatTxtItemCode.Size = new System.Drawing.Size(270, 50);
            this.MatTxtItemCode.TabIndex = 582;
            this.MatTxtItemCode.Text = "";
            // 
            // frmDryWhMiscellaneousReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 737);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MatBtnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDryWhMiscellaneousReceipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miscellaneous Receipt";
            this.Load += new System.EventHandler(this.frmDryWhMiscellaneousReceipts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvMaterialPreparation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox10;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DgvMaterialPreparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn converted_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serve_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaining_Qty;
        private MaterialSkin.Controls.MaterialTextBox MatTxtItemCode;
        public System.Windows.Forms.GroupBox GpInfo;
        public MaterialSkin.Controls.MaterialButton MatBtnNew;
        public MaterialSkin.Controls.MaterialTextBox MatTxTTransactNo;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotDescription;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotNo;
    }
}