
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Setup
{
    partial class frmViewItemsInLotArea
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
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvLotData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.matTxtLotDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.matxtLotNo = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotData)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvLotData);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(18, 149);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(970, 407);
            this.materialCard2.TabIndex = 612;
            // 
            // dgvLotData
            // 
            this.dgvLotData.AllowUserToAddRows = false;
            this.dgvLotData.AllowUserToDeleteRows = false;
            this.dgvLotData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLotData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLotData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLotData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLotData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLotData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLotData.ColumnHeadersHeight = 35;
            this.dgvLotData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLotData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_code,
            this.item_description,
            this.qty_received,
            this.lot_no,
            this.lot_description,
            this.date_added});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLotData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLotData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLotData.EnableHeadersVisualStyles = false;
            this.dgvLotData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvLotData.Location = new System.Drawing.Point(5, 6);
            this.dgvLotData.MultiSelect = false;
            this.dgvLotData.Name = "dgvLotData";
            this.dgvLotData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLotData.RowHeadersVisible = false;
            this.dgvLotData.RowHeadersWidth = 102;
            this.dgvLotData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLotData.RowTemplate.DividerHeight = 5;
            this.dgvLotData.RowTemplate.Height = 40;
            this.dgvLotData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotData.Size = new System.Drawing.Size(960, 395);
            this.dgvLotData.TabIndex = 593;
            this.dgvLotData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLotData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvLotData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvLotData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvLotData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLotData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLotData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLotData.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvLotData.ThemeStyle.ReadOnly = true;
            this.dgvLotData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLotData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvLotData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLotData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvLotData.ThemeStyle.RowsStyle.Height = 40;
            this.dgvLotData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvLotData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.FillWeight = 99.49239F;
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            // 
            // item_description
            // 
            this.item_description.DataPropertyName = "item_description";
            this.item_description.FillWeight = 99.49239F;
            this.item_description.HeaderText = "ITEM DESCRIPTION";
            this.item_description.MinimumWidth = 12;
            this.item_description.Name = "item_description";
            this.item_description.ReadOnly = true;
            // 
            // qty_received
            // 
            this.qty_received.DataPropertyName = "qty_received";
            this.qty_received.FillWeight = 99.49239F;
            this.qty_received.HeaderText = "QTY RECEIVED";
            this.qty_received.MinimumWidth = 12;
            this.qty_received.Name = "qty_received";
            this.qty_received.ReadOnly = true;
            // 
            // lot_no
            // 
            this.lot_no.DataPropertyName = "lot_no";
            this.lot_no.HeaderText = "LOT NO";
            this.lot_no.MinimumWidth = 12;
            this.lot_no.Name = "lot_no";
            this.lot_no.ReadOnly = true;
            // 
            // lot_description
            // 
            this.lot_description.DataPropertyName = "lot_description";
            this.lot_description.FillWeight = 99.49239F;
            this.lot_description.HeaderText = "LOT DESCRIPTION";
            this.lot_description.MinimumWidth = 12;
            this.lot_description.Name = "lot_description";
            this.lot_description.ReadOnly = true;
            // 
            // date_added
            // 
            this.date_added.DataPropertyName = "date_added";
            this.date_added.HeaderText = "DATE ADDED";
            this.date_added.MinimumWidth = 12;
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.matTxtLotDescription);
            this.materialCard1.Controls.Add(this.matxtLotNo);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(18, 74);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(473, 64);
            this.materialCard1.TabIndex = 613;
            // 
            // matTxtLotDescription
            // 
            this.matTxtLotDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matTxtLotDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtLotDescription.Depth = 0;
            this.matTxtLotDescription.Enabled = false;
            this.matTxtLotDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtLotDescription.Hint = "Description";
            this.matTxtLotDescription.Location = new System.Drawing.Point(248, 8);
            this.matTxtLotDescription.Margin = new System.Windows.Forms.Padding(1);
            this.matTxtLotDescription.MaxLength = 50;
            this.matTxtLotDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtLotDescription.Multiline = false;
            this.matTxtLotDescription.Name = "matTxtLotDescription";
            this.matTxtLotDescription.Size = new System.Drawing.Size(205, 50);
            this.matTxtLotDescription.TabIndex = 9;
            this.matTxtLotDescription.Text = "";
            // 
            // matxtLotNo
            // 
            this.matxtLotNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matxtLotNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matxtLotNo.Depth = 0;
            this.matxtLotNo.Enabled = false;
            this.matxtLotNo.Font = new System.Drawing.Font("Roboto", 12F);
            this.matxtLotNo.Hint = "Lot No";
            this.matxtLotNo.Location = new System.Drawing.Point(18, 8);
            this.matxtLotNo.Margin = new System.Windows.Forms.Padding(1);
            this.matxtLotNo.MaxLength = 50;
            this.matxtLotNo.MouseState = MaterialSkin.MouseState.OUT;
            this.matxtLotNo.Multiline = false;
            this.matxtLotNo.Name = "matxtLotNo";
            this.matxtLotNo.Size = new System.Drawing.Size(205, 50);
            this.matxtLotNo.TabIndex = 8;
            this.matxtLotNo.Text = "";
            this.matxtLotNo.TextChanged += new System.EventHandler(this.matxtLotNo_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(948, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 616;
            this.label2.Text = "Items";
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalrecords.Location = new System.Drawing.Point(897, 560);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(46, 40);
            this.lbltotalrecords.TabIndex = 615;
            this.lbltotalrecords.Text = "76";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(301, 565);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 614;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // frmViewItemsInLotArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lbltotalrecords);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewItemsInLotArea";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Items on  Lot Area";
            this.Load += new System.EventHandler(this.frmViewItemsInLotArea_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotData)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLotData;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox matxtLotNo;
        private MaterialSkin.Controls.MaterialTextBox matTxtLotDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalrecords;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
    }
}