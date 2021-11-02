
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmDryReceivingModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDryReceivingModule));
            this.mattxtbarcode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.mattxtcategory = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtexpirydate = new MaterialSkin.Controls.MaterialTextBox();
            this.matdaysExpiry = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtmfgdate = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtSupplier = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtitemdesc = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtreceivingdate = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtitemcode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.metroCmbRejectRemarks = new MetroFramework.Controls.MetroComboBox();
            this.mattxtupdatedstocks = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtponumber = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtqtyreject = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtqtyReceived = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtsoh = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtlotno = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtactualdelivery = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtqtyuom = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mattxtReceived = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dgvMajorCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.major_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_category_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectLot = new System.Windows.Forms.Button();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // mattxtbarcode
            // 
            this.mattxtbarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtbarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtbarcode.Depth = 0;
            this.mattxtbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtbarcode.Hint = "Scan the Barcode";
            this.mattxtbarcode.Location = new System.Drawing.Point(68, 44);
            this.mattxtbarcode.MaxLength = 50;
            this.mattxtbarcode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtbarcode.Multiline = false;
            this.mattxtbarcode.Name = "mattxtbarcode";
            this.mattxtbarcode.Size = new System.Drawing.Size(1820, 36);
            this.mattxtbarcode.TabIndex = 0;
            this.mattxtbarcode.Text = "";
            this.mattxtbarcode.UseTallSize = false;
            this.mattxtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mattxtbarcode_KeyDown);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mattxtbarcode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(61, 186);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1937, 155);
            this.materialCard1.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.mattxtcategory);
            this.materialCard2.Controls.Add(this.mattxtexpirydate);
            this.materialCard2.Controls.Add(this.matdaysExpiry);
            this.materialCard2.Controls.Add(this.mattxtmfgdate);
            this.materialCard2.Controls.Add(this.mattxtSupplier);
            this.materialCard2.Controls.Add(this.mattxtitemdesc);
            this.materialCard2.Controls.Add(this.mattxtreceivingdate);
            this.materialCard2.Controls.Add(this.mattxtitemcode);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(61, 399);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1937, 630);
            this.materialCard2.TabIndex = 1;
            this.materialCard2.Visible = false;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // mattxtcategory
            // 
            this.mattxtcategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtcategory.Depth = 0;
            this.mattxtcategory.Enabled = false;
            this.mattxtcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtcategory.Hint = "Category";
            this.mattxtcategory.Location = new System.Drawing.Point(684, 88);
            this.mattxtcategory.MaxLength = 50;
            this.mattxtcategory.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtcategory.Multiline = false;
            this.mattxtcategory.Name = "mattxtcategory";
            this.mattxtcategory.Size = new System.Drawing.Size(574, 50);
            this.mattxtcategory.TabIndex = 26;
            this.mattxtcategory.Text = "";
            // 
            // mattxtexpirydate
            // 
            this.mattxtexpirydate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtexpirydate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtexpirydate.Depth = 0;
            this.mattxtexpirydate.Enabled = false;
            this.mattxtexpirydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtexpirydate.Hint = "Expiration Date";
            this.mattxtexpirydate.Location = new System.Drawing.Point(684, 485);
            this.mattxtexpirydate.MaxLength = 50;
            this.mattxtexpirydate.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtexpirydate.Multiline = false;
            this.mattxtexpirydate.Name = "mattxtexpirydate";
            this.mattxtexpirydate.Size = new System.Drawing.Size(574, 50);
            this.mattxtexpirydate.TabIndex = 9;
            this.mattxtexpirydate.Text = "";
            // 
            // matdaysExpiry
            // 
            this.matdaysExpiry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.matdaysExpiry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matdaysExpiry.Depth = 0;
            this.matdaysExpiry.Enabled = false;
            this.matdaysExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.matdaysExpiry.Hint = "Expiry Days";
            this.matdaysExpiry.Location = new System.Drawing.Point(1335, 485);
            this.matdaysExpiry.MaxLength = 50;
            this.matdaysExpiry.MouseState = MaterialSkin.MouseState.OUT;
            this.matdaysExpiry.Multiline = false;
            this.matdaysExpiry.Name = "matdaysExpiry";
            this.matdaysExpiry.Size = new System.Drawing.Size(574, 50);
            this.matdaysExpiry.TabIndex = 7;
            this.matdaysExpiry.Text = "";
            // 
            // mattxtmfgdate
            // 
            this.mattxtmfgdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtmfgdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtmfgdate.Depth = 0;
            this.mattxtmfgdate.Enabled = false;
            this.mattxtmfgdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtmfgdate.Hint = "Mftg. Date";
            this.mattxtmfgdate.Location = new System.Drawing.Point(20, 484);
            this.mattxtmfgdate.MaxLength = 50;
            this.mattxtmfgdate.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtmfgdate.Multiline = false;
            this.mattxtmfgdate.Name = "mattxtmfgdate";
            this.mattxtmfgdate.Size = new System.Drawing.Size(574, 50);
            this.mattxtmfgdate.TabIndex = 6;
            this.mattxtmfgdate.Text = "";
            // 
            // mattxtSupplier
            // 
            this.mattxtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSupplier.Depth = 0;
            this.mattxtSupplier.Enabled = false;
            this.mattxtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtSupplier.Hint = "Suppliers";
            this.mattxtSupplier.Location = new System.Drawing.Point(20, 344);
            this.mattxtSupplier.MaxLength = 50;
            this.mattxtSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSupplier.Multiline = false;
            this.mattxtSupplier.Name = "mattxtSupplier";
            this.mattxtSupplier.Size = new System.Drawing.Size(1889, 50);
            this.mattxtSupplier.TabIndex = 5;
            this.mattxtSupplier.Text = "";
            // 
            // mattxtitemdesc
            // 
            this.mattxtitemdesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtitemdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtitemdesc.Depth = 0;
            this.mattxtitemdesc.Enabled = false;
            this.mattxtitemdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtitemdesc.Hint = "Description";
            this.mattxtitemdesc.Location = new System.Drawing.Point(20, 216);
            this.mattxtitemdesc.MaxLength = 50;
            this.mattxtitemdesc.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtitemdesc.Multiline = false;
            this.mattxtitemdesc.Name = "mattxtitemdesc";
            this.mattxtitemdesc.Size = new System.Drawing.Size(1889, 50);
            this.mattxtitemdesc.TabIndex = 4;
            this.mattxtitemdesc.Text = "";
            // 
            // mattxtreceivingdate
            // 
            this.mattxtreceivingdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtreceivingdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtreceivingdate.Depth = 0;
            this.mattxtreceivingdate.Enabled = false;
            this.mattxtreceivingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtreceivingdate.Hint = "Receiving Date";
            this.mattxtreceivingdate.Location = new System.Drawing.Point(1335, 89);
            this.mattxtreceivingdate.MaxLength = 50;
            this.mattxtreceivingdate.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtreceivingdate.Multiline = false;
            this.mattxtreceivingdate.Name = "mattxtreceivingdate";
            this.mattxtreceivingdate.Size = new System.Drawing.Size(574, 50);
            this.mattxtreceivingdate.TabIndex = 3;
            this.mattxtreceivingdate.Text = "";
            // 
            // mattxtitemcode
            // 
            this.mattxtitemcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtitemcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtitemcode.Depth = 0;
            this.mattxtitemcode.Enabled = false;
            this.mattxtitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtitemcode.Hint = "Item Code";
            this.mattxtitemcode.Location = new System.Drawing.Point(20, 88);
            this.mattxtitemcode.MaxLength = 50;
            this.mattxtitemcode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtitemcode.Multiline = false;
            this.mattxtitemcode.Name = "mattxtitemcode";
            this.mattxtitemcode.Size = new System.Drawing.Size(574, 50);
            this.mattxtitemcode.TabIndex = 1;
            this.mattxtitemcode.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(181, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Raw Material Information";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnSelectLot);
            this.materialCard3.Controls.Add(this.metroCmbRejectRemarks);
            this.materialCard3.Controls.Add(this.mattxtupdatedstocks);
            this.materialCard3.Controls.Add(this.mattxtponumber);
            this.materialCard3.Controls.Add(this.mattxtqtyreject);
            this.materialCard3.Controls.Add(this.mattxtqtyReceived);
            this.materialCard3.Controls.Add(this.mattxtsoh);
            this.materialCard3.Controls.Add(this.mattxtlotno);
            this.materialCard3.Controls.Add(this.mattxtactualdelivery);
            this.materialCard3.Controls.Add(this.mattxtqtyuom);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(61, 1103);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1937, 571);
            this.materialCard3.TabIndex = 10;
            this.materialCard3.Visible = false;
            // 
            // metroCmbRejectRemarks
            // 
            this.metroCmbRejectRemarks.FormattingEnabled = true;
            this.metroCmbRejectRemarks.ItemHeight = 24;
            this.metroCmbRejectRemarks.Location = new System.Drawing.Point(1340, 424);
            this.metroCmbRejectRemarks.Name = "metroCmbRejectRemarks";
            this.metroCmbRejectRemarks.Size = new System.Drawing.Size(574, 30);
            this.metroCmbRejectRemarks.TabIndex = 24;
            this.metroCmbRejectRemarks.UseSelectable = true;
            // 
            // mattxtupdatedstocks
            // 
            this.mattxtupdatedstocks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtupdatedstocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtupdatedstocks.Depth = 0;
            this.mattxtupdatedstocks.Enabled = false;
            this.mattxtupdatedstocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtupdatedstocks.Hint = "Updated Stocks";
            this.mattxtupdatedstocks.Location = new System.Drawing.Point(684, 256);
            this.mattxtupdatedstocks.MaxLength = 50;
            this.mattxtupdatedstocks.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtupdatedstocks.Multiline = false;
            this.mattxtupdatedstocks.Name = "mattxtupdatedstocks";
            this.mattxtupdatedstocks.Size = new System.Drawing.Size(574, 50);
            this.mattxtupdatedstocks.TabIndex = 23;
            this.mattxtupdatedstocks.Text = "";
            // 
            // mattxtponumber
            // 
            this.mattxtponumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtponumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtponumber.Depth = 0;
            this.mattxtponumber.Enabled = false;
            this.mattxtponumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtponumber.Hint = "PO Number";
            this.mattxtponumber.Location = new System.Drawing.Point(684, 116);
            this.mattxtponumber.MaxLength = 50;
            this.mattxtponumber.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtponumber.Multiline = false;
            this.mattxtponumber.Name = "mattxtponumber";
            this.mattxtponumber.Size = new System.Drawing.Size(574, 50);
            this.mattxtponumber.TabIndex = 22;
            this.mattxtponumber.Text = "";
            // 
            // mattxtqtyreject
            // 
            this.mattxtqtyreject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtqtyreject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtqtyreject.Depth = 0;
            this.mattxtqtyreject.Enabled = false;
            this.mattxtqtyreject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtqtyreject.Hint = "QTY. Reject";
            this.mattxtqtyreject.Location = new System.Drawing.Point(25, 408);
            this.mattxtqtyreject.MaxLength = 50;
            this.mattxtqtyreject.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtqtyreject.Multiline = false;
            this.mattxtqtyreject.Name = "mattxtqtyreject";
            this.mattxtqtyreject.Size = new System.Drawing.Size(574, 50);
            this.mattxtqtyreject.TabIndex = 21;
            this.mattxtqtyreject.Text = "";
            // 
            // mattxtqtyReceived
            // 
            this.mattxtqtyReceived.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtqtyReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtqtyReceived.Depth = 0;
            this.mattxtqtyReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtqtyReceived.ForeColor = System.Drawing.Color.Yellow;
            this.mattxtqtyReceived.Hint = "QTY. Received";
            this.mattxtqtyReceived.Location = new System.Drawing.Point(1340, 256);
            this.mattxtqtyReceived.MaxLength = 50;
            this.mattxtqtyReceived.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtqtyReceived.Multiline = false;
            this.mattxtqtyReceived.Name = "mattxtqtyReceived";
            this.mattxtqtyReceived.Size = new System.Drawing.Size(574, 50);
            this.mattxtqtyReceived.TabIndex = 20;
            this.mattxtqtyReceived.Text = "";
            this.mattxtqtyReceived.TextChanged += new System.EventHandler(this.mattxtqtyReceived_TextChanged);
            this.mattxtqtyReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtqtyReceived_KeyPress);
            // 
            // mattxtsoh
            // 
            this.mattxtsoh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtsoh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtsoh.Depth = 0;
            this.mattxtsoh.Enabled = false;
            this.mattxtsoh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtsoh.Hint = "Stock on Hand";
            this.mattxtsoh.Location = new System.Drawing.Point(25, 256);
            this.mattxtsoh.MaxLength = 50;
            this.mattxtsoh.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtsoh.Multiline = false;
            this.mattxtsoh.Name = "mattxtsoh";
            this.mattxtsoh.Size = new System.Drawing.Size(574, 50);
            this.mattxtsoh.TabIndex = 19;
            this.mattxtsoh.Text = "0";
            // 
            // mattxtlotno
            // 
            this.mattxtlotno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtlotno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtlotno.Depth = 0;
            this.mattxtlotno.Enabled = false;
            this.mattxtlotno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtlotno.Hint = "Lot No.";
            this.mattxtlotno.Location = new System.Drawing.Point(684, 408);
            this.mattxtlotno.MaxLength = 50;
            this.mattxtlotno.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtlotno.Multiline = false;
            this.mattxtlotno.Name = "mattxtlotno";
            this.mattxtlotno.Size = new System.Drawing.Size(449, 50);
            this.mattxtlotno.TabIndex = 18;
            this.mattxtlotno.Text = "";
            // 
            // mattxtactualdelivery
            // 
            this.mattxtactualdelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtactualdelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtactualdelivery.Depth = 0;
            this.mattxtactualdelivery.Enabled = false;
            this.mattxtactualdelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtactualdelivery.Hint = "Actual Delivery";
            this.mattxtactualdelivery.Location = new System.Drawing.Point(1340, 117);
            this.mattxtactualdelivery.MaxLength = 50;
            this.mattxtactualdelivery.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtactualdelivery.Multiline = false;
            this.mattxtactualdelivery.Name = "mattxtactualdelivery";
            this.mattxtactualdelivery.Size = new System.Drawing.Size(574, 50);
            this.mattxtactualdelivery.TabIndex = 17;
            this.mattxtactualdelivery.Text = "";
            this.mattxtactualdelivery.TextChanged += new System.EventHandler(this.mattxtactualdelivery_TextChanged);
            // 
            // mattxtqtyuom
            // 
            this.mattxtqtyuom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtqtyuom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtqtyuom.Depth = 0;
            this.mattxtqtyuom.Enabled = false;
            this.mattxtqtyuom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mattxtqtyuom.Hint = "Unit of Measure";
            this.mattxtqtyuom.Location = new System.Drawing.Point(25, 116);
            this.mattxtqtyuom.MaxLength = 50;
            this.mattxtqtyuom.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtqtyuom.Multiline = false;
            this.mattxtqtyuom.Name = "mattxtqtyuom";
            this.mattxtqtyuom.Size = new System.Drawing.Size(574, 50);
            this.mattxtqtyuom.TabIndex = 15;
            this.mattxtqtyuom.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 34);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(267, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Warehouse Dry Receiving Information";
            // 
            // mattxtReceived
            // 
            this.mattxtReceived.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mattxtReceived.Depth = 0;
            this.mattxtReceived.DrawShadows = true;
            this.mattxtReceived.HighEmphasis = true;
            this.mattxtReceived.Icon = null;
            this.mattxtReceived.Location = new System.Drawing.Point(1534, 1694);
            this.mattxtReceived.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mattxtReceived.MouseState = MaterialSkin.MouseState.HOVER;
            this.mattxtReceived.Name = "mattxtReceived";
            this.mattxtReceived.Size = new System.Drawing.Size(89, 36);
            this.mattxtReceived.TabIndex = 11;
            this.mattxtReceived.Text = "Received";
            this.mattxtReceived.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mattxtReceived.UseAccentColor = false;
            this.mattxtReceived.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1776, 1694);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Cancel";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // dgvMajorCategory
            // 
            this.dgvMajorCategory.AllowUserToAddRows = false;
            this.dgvMajorCategory.AllowUserToDeleteRows = false;
            this.dgvMajorCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMajorCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMajorCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMajorCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMajorCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMajorCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMajorCategory.ColumnHeadersHeight = 35;
            this.dgvMajorCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMajorCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.major_category_id,
            this.major_category_desc,
            this.mc_added_at,
            this.mc_added_by,
            this.mc_updated_at,
            this.mc_updated_by});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMajorCategory.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvMajorCategory.EnableHeadersVisualStyles = false;
            this.dgvMajorCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.Location = new System.Drawing.Point(229, 1046);
            this.dgvMajorCategory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvMajorCategory.MultiSelect = false;
            this.dgvMajorCategory.Name = "dgvMajorCategory";
            this.dgvMajorCategory.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMajorCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMajorCategory.RowHeadersVisible = false;
            this.dgvMajorCategory.RowHeadersWidth = 102;
            this.dgvMajorCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMajorCategory.RowTemplate.DividerHeight = 5;
            this.dgvMajorCategory.RowTemplate.Height = 40;
            this.dgvMajorCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMajorCategory.Size = new System.Drawing.Size(1741, 51);
            this.dgvMajorCategory.TabIndex = 594;
            this.dgvMajorCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMajorCategory.ThemeStyle.ReadOnly = true;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMajorCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvMajorCategory.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvMajorCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMajorCategory.CurrentCellChanged += new System.EventHandler(this.dgvMajorCategory_CurrentCellChanged);
            // 
            // major_category_id
            // 
            this.major_category_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.major_category_id.DataPropertyName = "major_category_id";
            this.major_category_id.FillWeight = 40.60914F;
            this.major_category_id.HeaderText = "ID";
            this.major_category_id.MinimumWidth = 12;
            this.major_category_id.Name = "major_category_id";
            this.major_category_id.ReadOnly = true;
            this.major_category_id.Width = 12;
            // 
            // major_category_desc
            // 
            this.major_category_desc.DataPropertyName = "major_category_desc";
            this.major_category_desc.FillWeight = 99.49239F;
            this.major_category_desc.HeaderText = "ITEM CLASS";
            this.major_category_desc.MinimumWidth = 12;
            this.major_category_desc.Name = "major_category_desc";
            this.major_category_desc.ReadOnly = true;
            // 
            // mc_added_at
            // 
            this.mc_added_at.DataPropertyName = "mc_added_at";
            this.mc_added_at.FillWeight = 99.49239F;
            this.mc_added_at.HeaderText = "CREATED DATE";
            this.mc_added_at.MinimumWidth = 12;
            this.mc_added_at.Name = "mc_added_at";
            this.mc_added_at.ReadOnly = true;
            // 
            // mc_added_by
            // 
            this.mc_added_by.DataPropertyName = "mc_added_by";
            this.mc_added_by.FillWeight = 99.49239F;
            this.mc_added_by.HeaderText = "CREATED BY";
            this.mc_added_by.MinimumWidth = 12;
            this.mc_added_by.Name = "mc_added_by";
            this.mc_added_by.ReadOnly = true;
            // 
            // mc_updated_at
            // 
            this.mc_updated_at.DataPropertyName = "mc_updated_at";
            this.mc_updated_at.FillWeight = 99.49239F;
            this.mc_updated_at.HeaderText = "UPDATED DATE";
            this.mc_updated_at.MinimumWidth = 12;
            this.mc_updated_at.Name = "mc_updated_at";
            this.mc_updated_at.ReadOnly = true;
            // 
            // mc_updated_by
            // 
            this.mc_updated_by.DataPropertyName = "mc_updated_by";
            this.mc_updated_by.HeaderText = "UPDATED BY";
            this.mc_updated_by.MinimumWidth = 12;
            this.mc_updated_by.Name = "mc_updated_by";
            this.mc_updated_by.ReadOnly = true;
            // 
            // btnSelectLot
            // 
            this.btnSelectLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectLot.FlatAppearance.BorderSize = 0;
            this.btnSelectLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLot.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectLot.Image")));
            this.btnSelectLot.Location = new System.Drawing.Point(1142, 387);
            this.btnSelectLot.Name = "btnSelectLot";
            this.btnSelectLot.Size = new System.Drawing.Size(109, 75);
            this.btnSelectLot.TabIndex = 25;
            this.btnSelectLot.UseVisualStyleBackColor = true;
            this.btnSelectLot.Click += new System.EventHandler(this.btnSelectLot_Click);
            // 
            // frmDryReceivingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2063, 1754);
            this.Controls.Add(this.dgvMajorCategory);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.mattxtReceived);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmDryReceivingModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dry RM  Receiving Module";
            this.Load += new System.EventHandler(this.frmDryReceivingModule_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox mattxtbarcode;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox mattxtSupplier;
        private MaterialSkin.Controls.MaterialTextBox mattxtitemdesc;
        private MaterialSkin.Controls.MaterialTextBox mattxtreceivingdate;
        private MaterialSkin.Controls.MaterialTextBox mattxtitemcode;
        private MaterialSkin.Controls.MaterialTextBox mattxtexpirydate;
        private MaterialSkin.Controls.MaterialTextBox matdaysExpiry;
        private MaterialSkin.Controls.MaterialTextBox mattxtmfgdate;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MetroFramework.Controls.MetroComboBox metroCmbRejectRemarks;
        private MaterialSkin.Controls.MaterialTextBox mattxtupdatedstocks;
        private MaterialSkin.Controls.MaterialTextBox mattxtponumber;
        private MaterialSkin.Controls.MaterialTextBox mattxtqtyreject;
        private MaterialSkin.Controls.MaterialTextBox mattxtqtyReceived;
        private MaterialSkin.Controls.MaterialTextBox mattxtsoh;
        private MaterialSkin.Controls.MaterialTextBox mattxtlotno;
        private MaterialSkin.Controls.MaterialTextBox mattxtactualdelivery;
        private MaterialSkin.Controls.MaterialTextBox mattxtqtyuom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnSelectLot;
        private MaterialSkin.Controls.MaterialButton mattxtReceived;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox mattxtcategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMajorCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_category_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_updated_by;
    }
}