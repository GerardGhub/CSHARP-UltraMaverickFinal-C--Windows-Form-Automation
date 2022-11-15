
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    partial class ViewApprovedItemsInternalOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalItems = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRequestedDate = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnAction = new MaterialSkin.Controls.MaterialButton();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mrs_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESERVED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Allocated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblcanceltitle = new System.Windows.Forms.Label();
            this.lblcancelby = new System.Windows.Forms.Label();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 667;
            this.label1.Text = "Preparation Date:";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalItems.Depth = 0;
            this.txtTotalItems.Enabled = false;
            this.txtTotalItems.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTotalItems.Hint = "TOTAL ITEMS";
            this.txtTotalItems.Location = new System.Drawing.Point(485, 2);
            this.txtTotalItems.MaxLength = 50;
            this.txtTotalItems.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalItems.Multiline = false;
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(215, 50);
            this.txtTotalItems.TabIndex = 666;
            this.txtTotalItems.Text = "";
            // 
            // txtRequestedDate
            // 
            this.txtRequestedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRequestedDate.Depth = 0;
            this.txtRequestedDate.Enabled = false;
            this.txtRequestedDate.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRequestedDate.Hint = "REQUESTED DATE";
            this.txtRequestedDate.Location = new System.Drawing.Point(255, 2);
            this.txtRequestedDate.MaxLength = 50;
            this.txtRequestedDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRequestedDate.Multiline = false;
            this.txtRequestedDate.Name = "txtRequestedDate";
            this.txtRequestedDate.Size = new System.Drawing.Size(215, 50);
            this.txtRequestedDate.TabIndex = 665;
            this.txtRequestedDate.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 664;
            this.label3.Text = "TextBox for Two Way Binding";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 663;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Depth = 0;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDescription.Hint = "DESCRIPTION";
            this.txtDescription.Location = new System.Drawing.Point(26, 2);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 50);
            this.txtDescription.TabIndex = 651;
            this.txtDescription.Text = "";
            // 
            // matBtnAction
            // 
            this.matBtnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnAction.Depth = 0;
            this.matBtnAction.DrawShadows = true;
            this.matBtnAction.HighEmphasis = true;
            this.matBtnAction.Icon = null;
            this.matBtnAction.Location = new System.Drawing.Point(856, 494);
            this.matBtnAction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnAction.Name = "matBtnAction";
            this.matBtnAction.Size = new System.Drawing.Size(77, 36);
            this.matBtnAction.TabIndex = 650;
            this.matBtnAction.Text = "CANCEL";
            this.matBtnAction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnAction.UseAccentColor = false;
            this.matBtnAction.UseVisualStyleBackColor = true;
            this.matBtnAction.Click += new System.EventHandler(this.matBtnAction_Click);
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(735, 16);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(170, 33);
            this.bunifuPrepaDate.TabIndex = 647;
            this.bunifuPrepaDate.ValueChanged += new System.EventHandler(this.bunifuPrepaDate_ValueChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvStoreOrderApproval);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(21, 55);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(913, 434);
            this.materialCard2.TabIndex = 646;
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
            this.mrs_item_code,
            this.mrs_item_description,
            this.mrs_uom,
            this.mrs_order_qty,
            this.StockOnHand,
            this.RESERVED,
            this.Total_Allocated});
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
            this.dgvStoreOrderApproval.Size = new System.Drawing.Size(903, 422);
            this.dgvStoreOrderApproval.TabIndex = 594;
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
            this.mrs_id.HeaderText = "MRS ID";
            this.mrs_id.MinimumWidth = 6;
            this.mrs_id.Name = "mrs_id";
            // 
            // mrs_item_code
            // 
            this.mrs_item_code.DataPropertyName = "mrs_item_code";
            this.mrs_item_code.FillWeight = 66.57212F;
            this.mrs_item_code.HeaderText = "ITEM CODE";
            this.mrs_item_code.MinimumWidth = 12;
            this.mrs_item_code.Name = "mrs_item_code";
            // 
            // mrs_item_description
            // 
            this.mrs_item_description.DataPropertyName = "mrs_item_description";
            this.mrs_item_description.HeaderText = "DESCRIPTION";
            this.mrs_item_description.MinimumWidth = 6;
            this.mrs_item_description.Name = "mrs_item_description";
            // 
            // mrs_uom
            // 
            this.mrs_uom.DataPropertyName = "mrs_uom";
            this.mrs_uom.FillWeight = 66.57212F;
            this.mrs_uom.HeaderText = "UOM";
            this.mrs_uom.MinimumWidth = 12;
            this.mrs_uom.Name = "mrs_uom";
            // 
            // mrs_order_qty
            // 
            this.mrs_order_qty.DataPropertyName = "mrs_order_qty";
            this.mrs_order_qty.FillWeight = 66.57212F;
            this.mrs_order_qty.HeaderText = "QTY";
            this.mrs_order_qty.MinimumWidth = 12;
            this.mrs_order_qty.Name = "mrs_order_qty";
            // 
            // StockOnHand
            // 
            this.StockOnHand.DataPropertyName = "StockOnHand";
            this.StockOnHand.HeaderText = "SOH";
            this.StockOnHand.MinimumWidth = 6;
            this.StockOnHand.Name = "StockOnHand";
            // 
            // RESERVED
            // 
            this.RESERVED.DataPropertyName = "RESERVED";
            this.RESERVED.HeaderText = "RESERVED";
            this.RESERVED.Name = "RESERVED";
            // 
            // Total_Allocated
            // 
            this.Total_Allocated.DataPropertyName = "Total_Allocated";
            this.Total_Allocated.HeaderText = "ALLOCATED";
            this.Total_Allocated.Name = "Total_Allocated";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.textBox2);
            this.materialCard1.Controls.Add(this.lblcanceltitle);
            this.materialCard1.Controls.Add(this.lblcancelby);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.txtTotalItems);
            this.materialCard1.Controls.Add(this.txtRequestedDate);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Controls.Add(this.txtDescription);
            this.materialCard1.Controls.Add(this.matBtnAction);
            this.materialCard1.Controls.Add(this.bunifuPrepaDate);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(22, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(953, 536);
            this.materialCard1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(184, 507);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 675;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblcanceltitle
            // 
            this.lblcanceltitle.AutoSize = true;
            this.lblcanceltitle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcanceltitle.Location = new System.Drawing.Point(18, 490);
            this.lblcanceltitle.Name = "lblcanceltitle";
            this.lblcanceltitle.Size = new System.Drawing.Size(66, 15);
            this.lblcanceltitle.TabIndex = 674;
            this.lblcanceltitle.Text = "Cancel By:";
            this.lblcanceltitle.Visible = false;
            // 
            // lblcancelby
            // 
            this.lblcancelby.AutoSize = true;
            this.lblcancelby.BackColor = System.Drawing.Color.MintCream;
            this.lblcancelby.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcancelby.Location = new System.Drawing.Point(18, 507);
            this.lblcancelby.Name = "lblcancelby";
            this.lblcancelby.Size = new System.Drawing.Size(15, 23);
            this.lblcancelby.TabIndex = 673;
            this.lblcancelby.Text = ".";
            this.lblcancelby.Visible = false;
            // 
            // ViewApprovedItemsInternalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 630);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.Name = "ViewApprovedItemsInternalOrder";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Approved Items Internal Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewApprovedItemsInternalOrder_FormClosing);
            this.Load += new System.EventHandler(this.ViewApprovedItemsInternalOrder_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtTotalItems;
        private MaterialSkin.Controls.MaterialTextBox txtRequestedDate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private MaterialSkin.Controls.MaterialButton matBtnAction;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblcancelby;
        private System.Windows.Forms.Label lblcanceltitle;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVED;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Allocated;
    }
}