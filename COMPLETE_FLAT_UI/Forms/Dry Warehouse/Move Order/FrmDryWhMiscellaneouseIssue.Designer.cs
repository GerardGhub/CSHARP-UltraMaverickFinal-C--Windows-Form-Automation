
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    partial class FrmDryWhMiscellaneouseIssue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.MatTxTTransactNo = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matCmbRemarks = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MatCmbSupplierCode = new MetroFramework.Controls.MetroComboBox();
            this.MatTxtSupploer = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MatTxtParentDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtQty = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtLotDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.LblTotalRecords = new System.Windows.Forms.Label();
            this.MatTxtExpiryDays = new MaterialSkin.Controls.MaterialTextBox();
            this.MatBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.MatTxtLotNo = new MaterialSkin.Controls.MaterialTextBox();
            this.guna2DgvMaterialPreparation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GpInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatBtnNew = new MaterialSkin.Controls.MaterialButton();
            this.ManufacturingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANCEL = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvMaterialPreparation)).BeginInit();
            this.GpInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 592;
            this.label3.Text = "Transaction No";
            // 
            // MatTxTTransactNo
            // 
            this.MatTxTTransactNo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MatTxTTransactNo.Enabled = false;
            this.MatTxTTransactNo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MatTxTTransactNo.FormattingEnabled = true;
            this.MatTxTTransactNo.ItemHeight = 23;
            this.MatTxTTransactNo.Items.AddRange(new object[] {
            "Delivery",
            "Adjustment",
            "Production"});
            this.MatTxTTransactNo.Location = new System.Drawing.Point(26, 57);
            this.MatTxTTransactNo.Name = "MatTxTTransactNo";
            this.MatTxTTransactNo.Size = new System.Drawing.Size(270, 29);
            this.MatTxTTransactNo.TabIndex = 591;
            this.MatTxTTransactNo.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 590;
            this.label1.Text = "Remarks";
            // 
            // matCmbRemarks
            // 
            this.matCmbRemarks.FormattingEnabled = true;
            this.matCmbRemarks.ItemHeight = 23;
            this.matCmbRemarks.Items.AddRange(new object[] {
            "Delivery",
            "Adjustment",
            "Production"});
            this.matCmbRemarks.Location = new System.Drawing.Point(708, 225);
            this.matCmbRemarks.Name = "matCmbRemarks";
            this.matCmbRemarks.Size = new System.Drawing.Size(270, 29);
            this.matCmbRemarks.TabIndex = 589;
            this.matCmbRemarks.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 588;
            this.label4.Text = "Supplier Code";
            // 
            // MatCmbSupplierCode
            // 
            this.MatCmbSupplierCode.FormattingEnabled = true;
            this.MatCmbSupplierCode.ItemHeight = 23;
            this.MatCmbSupplierCode.Items.AddRange(new object[] {
            "Delivery",
            "Adjustment",
            "Production"});
            this.MatCmbSupplierCode.Location = new System.Drawing.Point(28, 168);
            this.MatCmbSupplierCode.Name = "MatCmbSupplierCode";
            this.MatCmbSupplierCode.Size = new System.Drawing.Size(270, 29);
            this.MatCmbSupplierCode.TabIndex = 587;
            this.MatCmbSupplierCode.UseSelectable = true;
            // 
            // MatTxtSupploer
            // 
            this.MatTxtSupploer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtSupploer.Depth = 0;
            this.MatTxtSupploer.Enabled = false;
            this.MatTxtSupploer.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtSupploer.Hint = "Supplier Name";
            this.MatTxtSupploer.Location = new System.Drawing.Point(365, 149);
            this.MatTxtSupploer.MaxLength = 50;
            this.MatTxtSupploer.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtSupploer.Multiline = false;
            this.MatTxtSupploer.Name = "MatTxtSupploer";
            this.MatTxtSupploer.Size = new System.Drawing.Size(608, 50);
            this.MatTxtSupploer.TabIndex = 586;
            this.MatTxtSupploer.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(556, 701);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 660;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // MatTxtParentDescription
            // 
            this.MatTxtParentDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtParentDescription.Depth = 0;
            this.MatTxtParentDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtParentDescription.Hint = "Description";
            this.MatTxtParentDescription.Location = new System.Drawing.Point(26, 207);
            this.MatTxtParentDescription.MaxLength = 50;
            this.MatTxtParentDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtParentDescription.Multiline = false;
            this.MatTxtParentDescription.Name = "MatTxtParentDescription";
            this.MatTxtParentDescription.Size = new System.Drawing.Size(609, 50);
            this.MatTxtParentDescription.TabIndex = 585;
            this.MatTxtParentDescription.Text = "";
            // 
            // MatTxtCategory
            // 
            this.MatTxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtCategory.Depth = 0;
            this.MatTxtCategory.Enabled = false;
            this.MatTxtCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtCategory.Hint = "Category";
            this.MatTxtCategory.Location = new System.Drawing.Point(365, 93);
            this.MatTxtCategory.MaxLength = 50;
            this.MatTxtCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtCategory.Multiline = false;
            this.MatTxtCategory.Name = "MatTxtCategory";
            this.MatTxtCategory.Size = new System.Drawing.Size(270, 50);
            this.MatTxtCategory.TabIndex = 581;
            this.MatTxtCategory.Text = "";
            // 
            // MatTxtQty
            // 
            this.MatTxtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtQty.Depth = 0;
            this.MatTxtQty.Enabled = false;
            this.MatTxtQty.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtQty.Hint = "Quantity";
            this.MatTxtQty.Location = new System.Drawing.Point(26, 93);
            this.MatTxtQty.MaxLength = 50;
            this.MatTxtQty.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtQty.Multiline = false;
            this.MatTxtQty.Name = "MatTxtQty";
            this.MatTxtQty.Size = new System.Drawing.Size(270, 50);
            this.MatTxtQty.TabIndex = 580;
            this.MatTxtQty.Text = "";
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
            // LblTotalRecords
            // 
            this.LblTotalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalRecords.AutoSize = true;
            this.LblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalRecords.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.LblTotalRecords.Location = new System.Drawing.Point(918, 690);
            this.LblTotalRecords.Name = "LblTotalRecords";
            this.LblTotalRecords.Size = new System.Drawing.Size(31, 35);
            this.LblTotalRecords.TabIndex = 661;
            this.LblTotalRecords.Text = "0";
            // 
            // MatTxtExpiryDays
            // 
            this.MatTxtExpiryDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtExpiryDays.Depth = 0;
            this.MatTxtExpiryDays.Enabled = false;
            this.MatTxtExpiryDays.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtExpiryDays.Hint = "Expiry Days";
            this.MatTxtExpiryDays.Location = new System.Drawing.Point(704, 93);
            this.MatTxtExpiryDays.MaxLength = 50;
            this.MatTxtExpiryDays.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtExpiryDays.Multiline = false;
            this.MatTxtExpiryDays.Name = "MatTxtExpiryDays";
            this.MatTxtExpiryDays.Size = new System.Drawing.Size(270, 50);
            this.MatTxtExpiryDays.TabIndex = 6;
            this.MatTxtExpiryDays.Text = "";
            // 
            // MatBtnSave
            // 
            this.MatBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnSave.Depth = 0;
            this.MatBtnSave.DrawShadows = true;
            this.MatBtnSave.HighEmphasis = true;
            this.MatBtnSave.Icon = null;
            this.MatBtnSave.Location = new System.Drawing.Point(86, 687);
            this.MatBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnSave.Name = "MatBtnSave";
            this.MatBtnSave.Size = new System.Drawing.Size(58, 36);
            this.MatBtnSave.TabIndex = 663;
            this.MatBtnSave.Text = "SAVE";
            this.MatBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnSave.UseAccentColor = false;
            this.MatBtnSave.UseVisualStyleBackColor = true;
            this.MatBtnSave.Visible = false;
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
            this.ManufacturingDate,
            this.ExpirationDate,
            this.ExpiryDays,
            this.ItemCode,
            this.ItemDescription,
            this.category,
            this.LotDescription,
            this.Supplier,
            this.Quantity,
            this.LotNumber,
            this.CANCEL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DgvMaterialPreparation.DefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DgvMaterialPreparation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DgvMaterialPreparation.Enabled = false;
            this.guna2DgvMaterialPreparation.EnableHeadersVisualStyles = false;
            this.guna2DgvMaterialPreparation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DgvMaterialPreparation.Location = new System.Drawing.Point(3, 23);
            this.guna2DgvMaterialPreparation.MultiSelect = false;
            this.guna2DgvMaterialPreparation.Name = "guna2DgvMaterialPreparation";
            this.guna2DgvMaterialPreparation.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DgvMaterialPreparation.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            // GpInfo
            // 
            this.GpInfo.Controls.Add(this.guna2DgvMaterialPreparation);
            this.GpInfo.Location = new System.Drawing.Point(26, 261);
            this.GpInfo.Name = "GpInfo";
            this.GpInfo.Size = new System.Drawing.Size(955, 329);
            this.GpInfo.TabIndex = 1;
            this.GpInfo.TabStop = false;
            this.GpInfo.Text = "Transaction\'s";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(955, 706);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 662;
            this.label2.Text = "Items";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MatTxTTransactNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.matCmbRemarks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MatCmbSupplierCode);
            this.groupBox1.Controls.Add(this.MatTxtSupploer);
            this.groupBox1.Controls.Add(this.MatTxtParentDescription);
            this.groupBox1.Controls.Add(this.MatTxtCategory);
            this.groupBox1.Controls.Add(this.MatTxtQty);
            this.groupBox1.Controls.Add(this.MatTxtExpiryDays);
            this.groupBox1.Controls.Add(this.MatTxtLotDescription);
            this.groupBox1.Controls.Add(this.MatTxtLotNo);
            this.groupBox1.Controls.Add(this.GpInfo);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 603);
            this.groupBox1.TabIndex = 659;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Material Information";
            // 
            // MatBtnNew
            // 
            this.MatBtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnNew.Depth = 0;
            this.MatBtnNew.DrawShadows = true;
            this.MatBtnNew.HighEmphasis = true;
            this.MatBtnNew.Icon = null;
            this.MatBtnNew.Location = new System.Drawing.Point(22, 687);
            this.MatBtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnNew.Name = "MatBtnNew";
            this.MatBtnNew.Size = new System.Drawing.Size(53, 36);
            this.MatBtnNew.TabIndex = 658;
            this.MatBtnNew.Text = "NEW";
            this.MatBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnNew.UseAccentColor = false;
            this.MatBtnNew.UseVisualStyleBackColor = true;
            // 
            // ManufacturingDate
            // 
            this.ManufacturingDate.DataPropertyName = "ManufacturingDate";
            this.ManufacturingDate.HeaderText = "MFG DATE";
            this.ManufacturingDate.MinimumWidth = 6;
            this.ManufacturingDate.Name = "ManufacturingDate";
            this.ManufacturingDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.FillWeight = 66.91177F;
            this.ExpirationDate.HeaderText = "EXPIRY DATE";
            this.ExpirationDate.MinimumWidth = 12;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // ExpiryDays
            // 
            this.ExpiryDays.DataPropertyName = "ExpiryDays";
            this.ExpiryDays.HeaderText = "EXPIRY DAYS";
            this.ExpiryDays.Name = "ExpiryDays";
            this.ExpiryDays.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.FillWeight = 66.91177F;
            this.ItemCode.HeaderText = "CODE";
            this.ItemCode.MinimumWidth = 12;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DataPropertyName = "ItemDescription";
            this.ItemDescription.FillWeight = 66.57212F;
            this.ItemDescription.HeaderText = "DESCRIPTION";
            this.ItemDescription.MinimumWidth = 12;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // LotDescription
            // 
            this.LotDescription.DataPropertyName = "LotDescription";
            this.LotDescription.HeaderText = "LOT DESCRIPTION";
            this.LotDescription.Name = "LotDescription";
            this.LotDescription.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.FillWeight = 66.57212F;
            this.Supplier.HeaderText = "SUPPLIER";
            this.Supplier.MinimumWidth = 12;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 66.57212F;
            this.Quantity.HeaderText = "QTY";
            this.Quantity.MinimumWidth = 12;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // LotNumber
            // 
            this.LotNumber.DataPropertyName = "LotNumber";
            this.LotNumber.HeaderText = "LOTNO";
            this.LotNumber.Name = "LotNumber";
            this.LotNumber.ReadOnly = true;
            // 
            // CANCEL
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CANCEL.DefaultCellStyle = dataGridViewCellStyle3;
            this.CANCEL.HeaderText = "ACTION";
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.ReadOnly = true;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseColumnTextForButtonValue = true;
            // 
            // FrmDryWhMiscellaneouseIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblTotalRecords);
            this.Controls.Add(this.MatBtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MatBtnNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDryWhMiscellaneouseIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDryWhMiscellaneouseIssue";
            this.Load += new System.EventHandler(this.FrmDryWhMiscellaneouseIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DgvMaterialPreparation)).EndInit();
            this.GpInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroComboBox MatTxTTransactNo;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroComboBox matCmbRemarks;
        private System.Windows.Forms.Label label4;
        public MetroFramework.Controls.MetroComboBox MatCmbSupplierCode;
        private MaterialSkin.Controls.MaterialTextBox MatTxtSupploer;
        public System.Windows.Forms.TextBox textBox1;
        public MaterialSkin.Controls.MaterialTextBox MatTxtParentDescription;
        private MaterialSkin.Controls.MaterialTextBox MatTxtCategory;
        private MaterialSkin.Controls.MaterialTextBox MatTxtQty;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotDescription;
        private System.Windows.Forms.Label LblTotalRecords;
        private MaterialSkin.Controls.MaterialTextBox MatTxtExpiryDays;
        public MaterialSkin.Controls.MaterialButton MatBtnSave;
        public MaterialSkin.Controls.MaterialTextBox MatTxtLotNo;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DgvMaterialPreparation;
        public System.Windows.Forms.GroupBox GpInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public MaterialSkin.Controls.MaterialButton MatBtnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotNumber;
        private System.Windows.Forms.DataGridViewButtonColumn CANCEL;
    }
}