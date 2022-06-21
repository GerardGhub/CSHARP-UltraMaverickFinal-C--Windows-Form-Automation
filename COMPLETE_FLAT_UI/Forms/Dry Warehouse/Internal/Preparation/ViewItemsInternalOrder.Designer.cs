
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    partial class ViewItemsInternalOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            this.matbtnPrint = new MaterialSkin.Controls.MaterialButton();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mrs_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_transact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrs_requested_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRequestedDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTotalItems = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtTotalItems);
            this.materialCard1.Controls.Add(this.txtRequestedDate);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Controls.Add(this.txtDescription);
            this.materialCard1.Controls.Add(this.matbtnPrint);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.bunifuPrepaDate);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(22, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(953, 536);
            this.materialCard1.TabIndex = 0;
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStoreOrderApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreOrderApproval.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvStoreOrderApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrderApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStoreOrderApproval.ColumnHeadersHeight = 45;
            this.dgvStoreOrderApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.mrs_id,
            this.mrs_transact_no,
            this.mrs_item_code,
            this.mrs_item_description,
            this.mrs_uom,
            this.mrs_order_qty,
            this.mrs_requested_date});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrderApproval.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStoreOrderApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreOrderApproval.EnableHeadersVisualStyles = false;
            this.dgvStoreOrderApproval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.Location = new System.Drawing.Point(5, 6);
            this.dgvStoreOrderApproval.MultiSelect = false;
            this.dgvStoreOrderApproval.Name = "dgvStoreOrderApproval";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(22, 503);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(124, 19);
            this.materialLabel5.TabIndex = 648;
            this.materialLabel5.Text = "Preparation Date:";
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(159, 496);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(170, 33);
            this.bunifuPrepaDate.TabIndex = 647;
            // 
            // matbtnPrint
            // 
            this.matbtnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnPrint.Depth = 0;
            this.matbtnPrint.DrawShadows = true;
            this.matbtnPrint.HighEmphasis = true;
            this.matbtnPrint.Icon = null;
            this.matbtnPrint.Location = new System.Drawing.Point(847, 494);
            this.matbtnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnPrint.Name = "matbtnPrint";
            this.matbtnPrint.Size = new System.Drawing.Size(87, 36);
            this.matbtnPrint.TabIndex = 650;
            this.matbtnPrint.Text = "APPROVE";
            this.matbtnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnPrint.UseAccentColor = false;
            this.matbtnPrint.UseVisualStyleBackColor = true;
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
            // mrs_id
            // 
            this.mrs_id.DataPropertyName = "mrs_id";
            this.mrs_id.FillWeight = 66.91177F;
            this.mrs_id.HeaderText = "ID";
            this.mrs_id.MinimumWidth = 12;
            this.mrs_id.Name = "mrs_id";
            // 
            // mrs_transact_no
            // 
            this.mrs_transact_no.DataPropertyName = "mrs_transact_no";
            this.mrs_transact_no.HeaderText = "MRS ID";
            this.mrs_transact_no.Name = "mrs_transact_no";
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
            // mrs_requested_date
            // 
            this.mrs_requested_date.DataPropertyName = "mrs_requested_date";
            this.mrs_requested_date.HeaderText = "SOH";
            this.mrs_requested_date.MinimumWidth = 6;
            this.mrs_requested_date.Name = "mrs_requested_date";
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
            this.txtDescription.Size = new System.Drawing.Size(293, 50);
            this.txtDescription.TabIndex = 651;
            this.txtDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 502);
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
            this.textBox1.Location = new System.Drawing.Point(577, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 663;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRequestedDate
            // 
            this.txtRequestedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRequestedDate.Depth = 0;
            this.txtRequestedDate.Enabled = false;
            this.txtRequestedDate.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRequestedDate.Hint = "REQUESTED DATE";
            this.txtRequestedDate.Location = new System.Drawing.Point(331, 2);
            this.txtRequestedDate.MaxLength = 50;
            this.txtRequestedDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRequestedDate.Multiline = false;
            this.txtRequestedDate.Name = "txtRequestedDate";
            this.txtRequestedDate.Size = new System.Drawing.Size(293, 50);
            this.txtRequestedDate.TabIndex = 665;
            this.txtRequestedDate.Text = "";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalItems.Depth = 0;
            this.txtTotalItems.Enabled = false;
            this.txtTotalItems.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTotalItems.Hint = "TOTAL ITEMS";
            this.txtTotalItems.Location = new System.Drawing.Point(636, 2);
            this.txtTotalItems.MaxLength = 50;
            this.txtTotalItems.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalItems.Multiline = false;
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(293, 50);
            this.txtTotalItems.TabIndex = 666;
            this.txtTotalItems.Text = "";
            // 
            // ViewItemsInternalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 630);
            this.Controls.Add(this.materialCard1);
            this.Name = "ViewItemsInternalOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Items Internal Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewItemsInternalOrder_FormClosing);
            this.Load += new System.EventHandler(this.ViewItemsInternalOrder_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
        private MaterialSkin.Controls.MaterialButton matbtnPrint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_transact_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrs_requested_date;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox txtTotalItems;
        private MaterialSkin.Controls.MaterialTextBox txtRequestedDate;
    }
}