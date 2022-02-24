
namespace ULTRAMAVERICK.Forms.Lab_Test
{
    partial class frmLabTestModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.matTxtDateAdded = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtExpiryDays = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtExpiryDate = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtMftgDate = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtQty = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtLotNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvRawMats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.matBtnNew = new MaterialSkin.Controls.MaterialButton();
            this.matViewLabRecords = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAYSTOEXPIRED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STANDARDEXPIRYDAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.matBtnNew);
            this.materialCard1.Controls.Add(this.matTxtDateAdded);
            this.materialCard1.Controls.Add(this.matTxtExpiryDays);
            this.materialCard1.Controls.Add(this.materialTextBox8);
            this.materialCard1.Controls.Add(this.matTxtExpiryDate);
            this.materialCard1.Controls.Add(this.matTxtMftgDate);
            this.materialCard1.Controls.Add(this.matTxtQty);
            this.materialCard1.Controls.Add(this.mattxtLotNumber);
            this.materialCard1.Controls.Add(this.matTxtCategory);
            this.materialCard1.Controls.Add(this.matTxtItemCode);
            this.materialCard1.Controls.Add(this.pbImage);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(28, 76);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1279, 148);
            this.materialCard1.TabIndex = 148;
            // 
            // matTxtDateAdded
            // 
            this.matTxtDateAdded.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtDateAdded.Depth = 0;
            this.matTxtDateAdded.Enabled = false;
            this.matTxtDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matTxtDateAdded.Hint = "Received Date";
            this.matTxtDateAdded.Location = new System.Drawing.Point(1056, 88);
            this.matTxtDateAdded.MaxLength = 50;
            this.matTxtDateAdded.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtDateAdded.Multiline = false;
            this.matTxtDateAdded.Name = "matTxtDateAdded";
            this.matTxtDateAdded.Size = new System.Drawing.Size(185, 50);
            this.matTxtDateAdded.TabIndex = 156;
            this.matTxtDateAdded.Text = "";
            // 
            // matTxtExpiryDays
            // 
            this.matTxtExpiryDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtExpiryDays.Depth = 0;
            this.matTxtExpiryDays.Enabled = false;
            this.matTxtExpiryDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matTxtExpiryDays.Hint = "Expiry Days";
            this.matTxtExpiryDays.Location = new System.Drawing.Point(843, 88);
            this.matTxtExpiryDays.MaxLength = 50;
            this.matTxtExpiryDays.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtExpiryDays.Multiline = false;
            this.matTxtExpiryDays.Name = "matTxtExpiryDays";
            this.matTxtExpiryDays.Size = new System.Drawing.Size(185, 50);
            this.matTxtExpiryDays.TabIndex = 155;
            this.matTxtExpiryDays.Text = "";
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Enabled = false;
            this.materialTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox8.Hint = "Date of Last Used";
            this.materialTextBox8.Location = new System.Drawing.Point(843, 23);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(185, 50);
            this.materialTextBox8.TabIndex = 154;
            this.materialTextBox8.Text = "";
            // 
            // matTxtExpiryDate
            // 
            this.matTxtExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtExpiryDate.Depth = 0;
            this.matTxtExpiryDate.Enabled = false;
            this.matTxtExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matTxtExpiryDate.Hint = "Expiry Date";
            this.matTxtExpiryDate.Location = new System.Drawing.Point(630, 88);
            this.matTxtExpiryDate.MaxLength = 50;
            this.matTxtExpiryDate.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtExpiryDate.Multiline = false;
            this.matTxtExpiryDate.Name = "matTxtExpiryDate";
            this.matTxtExpiryDate.Size = new System.Drawing.Size(185, 50);
            this.matTxtExpiryDate.TabIndex = 153;
            this.matTxtExpiryDate.Text = "";
            // 
            // matTxtMftgDate
            // 
            this.matTxtMftgDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtMftgDate.Depth = 0;
            this.matTxtMftgDate.Enabled = false;
            this.matTxtMftgDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matTxtMftgDate.Hint = "Mftg. Date";
            this.matTxtMftgDate.Location = new System.Drawing.Point(630, 23);
            this.matTxtMftgDate.MaxLength = 50;
            this.matTxtMftgDate.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtMftgDate.Multiline = false;
            this.matTxtMftgDate.Name = "matTxtMftgDate";
            this.matTxtMftgDate.Size = new System.Drawing.Size(185, 50);
            this.matTxtMftgDate.TabIndex = 152;
            this.matTxtMftgDate.Text = "";
            // 
            // matTxtQty
            // 
            this.matTxtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtQty.Depth = 0;
            this.matTxtQty.Enabled = false;
            this.matTxtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matTxtQty.Hint = "Quantity";
            this.matTxtQty.Location = new System.Drawing.Point(419, 88);
            this.matTxtQty.MaxLength = 50;
            this.matTxtQty.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtQty.Multiline = false;
            this.matTxtQty.Name = "matTxtQty";
            this.matTxtQty.Size = new System.Drawing.Size(185, 50);
            this.matTxtQty.TabIndex = 151;
            this.matTxtQty.Text = "";
            // 
            // mattxtLotNumber
            // 
            this.mattxtLotNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtLotNumber.Depth = 0;
            this.mattxtLotNumber.Enabled = false;
            this.mattxtLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtLotNumber.Hint = "Lot Number";
            this.mattxtLotNumber.Location = new System.Drawing.Point(419, 23);
            this.mattxtLotNumber.MaxLength = 50;
            this.mattxtLotNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtLotNumber.Multiline = false;
            this.mattxtLotNumber.Name = "mattxtLotNumber";
            this.mattxtLotNumber.Size = new System.Drawing.Size(185, 50);
            this.mattxtLotNumber.TabIndex = 150;
            this.mattxtLotNumber.Text = "";
            // 
            // matTxtCategory
            // 
            this.matTxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtCategory.Depth = 0;
            this.matTxtCategory.Enabled = false;
            this.matTxtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matTxtCategory.Hint = "Category";
            this.matTxtCategory.Location = new System.Drawing.Point(204, 89);
            this.matTxtCategory.MaxLength = 50;
            this.matTxtCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtCategory.Multiline = false;
            this.matTxtCategory.Name = "matTxtCategory";
            this.matTxtCategory.Size = new System.Drawing.Size(185, 50);
            this.matTxtCategory.TabIndex = 149;
            this.matTxtCategory.Text = "";
            // 
            // matTxtItemCode
            // 
            this.matTxtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtItemCode.Depth = 0;
            this.matTxtItemCode.Enabled = false;
            this.matTxtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matTxtItemCode.Hint = "Item Code";
            this.matTxtItemCode.Location = new System.Drawing.Point(204, 24);
            this.matTxtItemCode.MaxLength = 50;
            this.matTxtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtItemCode.Multiline = false;
            this.matTxtItemCode.Name = "matTxtItemCode";
            this.matTxtItemCode.Size = new System.Drawing.Size(185, 50);
            this.matTxtItemCode.TabIndex = 148;
            this.matTxtItemCode.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvRawMats);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(30, 297);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(1279, 420);
            this.materialCard2.TabIndex = 584;
            // 
            // dgvRawMats
            // 
            this.dgvRawMats.AllowUserToAddRows = false;
            this.dgvRawMats.AllowUserToDeleteRows = false;
            this.dgvRawMats.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRawMats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRawMats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRawMats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRawMats.ColumnHeadersHeight = 40;
            this.dgvRawMats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.item_code,
            this.item_description,
            this.category,
            this.qty_received,
            this.remaining_qty,
            this.exp_date,
            this.DAYSTOEXPIRED,
            this.STANDARDEXPIRYDAYS,
            this.lab_status,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvRawMats.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMats.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRawMats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMats.EnableHeadersVisualStyles = false;
            this.dgvRawMats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.Location = new System.Drawing.Point(5, 6);
            this.dgvRawMats.MultiSelect = false;
            this.dgvRawMats.Name = "dgvRawMats";
            this.dgvRawMats.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMats.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRawMats.RowHeadersVisible = false;
            this.dgvRawMats.RowHeadersWidth = 102;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRawMats.RowTemplate.DividerHeight = 5;
            this.dgvRawMats.RowTemplate.Height = 40;
            this.dgvRawMats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMats.Size = new System.Drawing.Size(1269, 408);
            this.dgvRawMats.TabIndex = 5;
            this.dgvRawMats.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRawMats.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvRawMats.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvRawMats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRawMats.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.ReadOnly = true;
            this.dgvRawMats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRawMats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRawMats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRawMats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvRawMats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRawMats.CurrentCellChanged += new System.EventHandler(this.dgvRawMats_CurrentCellChanged);
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(1224, 723);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(32, 40);
            this.lbltotalrecords.TabIndex = 586;
            this.lbltotalrecords.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(1270, 738);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 587;
            this.label2.Text = "Items";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Hint = "Search";
            this.txtSearch.Location = new System.Drawing.Point(1101, 240);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(1);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 50);
            this.txtSearch.TabIndex = 588;
            this.txtSearch.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(34, 274);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 19);
            this.materialLabel1.TabIndex = 589;
            this.materialLabel1.Text = "Raw Materials";
            // 
            // matBtnNew
            // 
            this.matBtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnNew.Depth = 0;
            this.matBtnNew.DrawShadows = true;
            this.matBtnNew.HighEmphasis = true;
            this.matBtnNew.Icon = null;
            this.matBtnNew.Location = new System.Drawing.Point(1071, 24);
            this.matBtnNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(156, 36);
            this.matBtnNew.TabIndex = 581;
            this.matBtnNew.Text = "VIEW RECENT LOGS";
            this.matBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnNew.UseAccentColor = false;
            this.matBtnNew.UseVisualStyleBackColor = true;
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
            // 
            // matViewLabRecords
            // 
            this.matViewLabRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matViewLabRecords.Depth = 0;
            this.matViewLabRecords.DrawShadows = true;
            this.matViewLabRecords.HighEmphasis = true;
            this.matViewLabRecords.Icon = null;
            this.matViewLabRecords.Location = new System.Drawing.Point(210, 723);
            this.matViewLabRecords.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matViewLabRecords.MouseState = MaterialSkin.MouseState.HOVER;
            this.matViewLabRecords.Name = "matViewLabRecords";
            this.matViewLabRecords.Size = new System.Drawing.Size(115, 36);
            this.matViewLabRecords.TabIndex = 590;
            this.matViewLabRecords.Text = "LAB REQUEST";
            this.matViewLabRecords.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matViewLabRecords.UseAccentColor = false;
            this.matViewLabRecords.UseVisualStyleBackColor = true;
            this.matViewLabRecords.Click += new System.EventHandler(this.matViewLabRecords_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(30, 723);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(156, 36);
            this.materialButton2.TabIndex = 591;
            this.materialButton2.Text = "VIEW LAB RECORDS";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Image = global::ULTRAMAVERICK.Properties.Resources.gceERxXri;
            this.pbImage.Location = new System.Drawing.Point(13, 34);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(165, 103);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 147;
            this.pbImage.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 40.60914F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.FillWeight = 59.93546F;
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 113;
            // 
            // item_description
            // 
            this.item_description.DataPropertyName = "item_description";
            this.item_description.FillWeight = 97.00433F;
            this.item_description.HeaderText = "ITEM DESCRIPTION";
            this.item_description.MinimumWidth = 12;
            this.item_description.Name = "item_description";
            this.item_description.ReadOnly = true;
            this.item_description.Width = 166;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 110;
            // 
            // qty_received
            // 
            this.qty_received.DataPropertyName = "qty_received";
            this.qty_received.FillWeight = 77.07378F;
            this.qty_received.HeaderText = "QTY RECEIVED";
            this.qty_received.MinimumWidth = 12;
            this.qty_received.Name = "qty_received";
            this.qty_received.ReadOnly = true;
            this.qty_received.Width = 135;
            // 
            // remaining_qty
            // 
            this.remaining_qty.DataPropertyName = "remaining_qty";
            this.remaining_qty.HeaderText = "REMAINING QTY";
            this.remaining_qty.Name = "remaining_qty";
            this.remaining_qty.ReadOnly = true;
            this.remaining_qty.Width = 148;
            // 
            // exp_date
            // 
            this.exp_date.DataPropertyName = "exp_date";
            this.exp_date.HeaderText = "EXPIRATION DATE";
            this.exp_date.Name = "exp_date";
            this.exp_date.ReadOnly = true;
            this.exp_date.Width = 156;
            // 
            // DAYSTOEXPIRED
            // 
            this.DAYSTOEXPIRED.DataPropertyName = "DAYSTOEXPIRED";
            this.DAYSTOEXPIRED.HeaderText = "DAYS TO EXPIRED";
            this.DAYSTOEXPIRED.Name = "DAYSTOEXPIRED";
            this.DAYSTOEXPIRED.ReadOnly = true;
            this.DAYSTOEXPIRED.Width = 156;
            // 
            // STANDARDEXPIRYDAYS
            // 
            this.STANDARDEXPIRYDAYS.DataPropertyName = "STANDARDEXPIRYDAYS";
            this.STANDARDEXPIRYDAYS.HeaderText = "STANDARD EXPIRY DAY";
            this.STANDARDEXPIRYDAYS.Name = "STANDARDEXPIRYDAYS";
            this.STANDARDEXPIRYDAYS.ReadOnly = true;
            this.STANDARDEXPIRYDAYS.Width = 195;
            // 
            // lab_status
            // 
            this.lab_status.DataPropertyName = "lab_status";
            this.lab_status.HeaderText = "STATUS";
            this.lab_status.Name = "lab_status";
            this.lab_status.ReadOnly = true;
            this.lab_status.Width = 83;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HISTORY";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "AGING";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 82;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "REMARKS";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmLabTestModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 768);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.matViewLabRecords);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmLabTestModule";
            this.Text = "Dry Warehouse Lab Test";
            this.Load += new System.EventHandler(this.frmLabTestModule_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRawMats;
        private System.Windows.Forms.Label lbltotalrecords;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox matTxtExpiryDate;
        private MaterialSkin.Controls.MaterialTextBox matTxtMftgDate;
        private MaterialSkin.Controls.MaterialTextBox matTxtQty;
        private MaterialSkin.Controls.MaterialTextBox mattxtLotNumber;
        private MaterialSkin.Controls.MaterialTextBox matTxtCategory;
        private MaterialSkin.Controls.MaterialTextBox matTxtItemCode;
        private MaterialSkin.Controls.MaterialTextBox matTxtExpiryDays;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialTextBox matTxtDateAdded;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton matBtnNew;
        private MaterialSkin.Controls.MaterialButton matViewLabRecords;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYSTOEXPIRED;
        private System.Windows.Forms.DataGridViewTextBoxColumn STANDARDEXPIRYDAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}