
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmAddNewPartialRejectReceiving
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_reject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reject_remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mattxtQtyReceived = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtItemDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.metroCmbRejectRemarks = new MetroFramework.Controls.MetroComboBox();
            this.mattxtqtyreject = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnAdd = new MaterialSkin.Controls.MaterialButton();
            this.lbltotalReject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotData)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvLotData);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(89, 556);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1134, 934);
            this.materialCard2.TabIndex = 5;
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
            this.dgvLotData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLotData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLotData.ColumnHeadersHeight = 35;
            this.dgvLotData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLotData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.index_id,
            this.qty_reject,
            this.reject_remarks});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLotData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLotData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLotData.EnableHeadersVisualStyles = false;
            this.dgvLotData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLotData.Location = new System.Drawing.Point(14, 14);
            this.dgvLotData.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
            this.dgvLotData.Size = new System.Drawing.Size(1106, 906);
            this.dgvLotData.TabIndex = 594;
            this.dgvLotData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLotData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLotData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLotData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvLotData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLotData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvLotData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvLotData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLotData.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvLotData.ThemeStyle.ReadOnly = true;
            this.dgvLotData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLotData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLotData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLotData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvLotData.ThemeStyle.RowsStyle.Height = 40;
            this.dgvLotData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvLotData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLotData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLotData_CellContentClick);
            this.dgvLotData.CurrentCellChanged += new System.EventHandler(this.dgvLotData_CurrentCellChanged);
            this.dgvLotData.DoubleClick += new System.EventHandler(this.dgvLotData_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 40.60914F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 12;
            // 
            // index_id
            // 
            this.index_id.DataPropertyName = "index_id";
            this.index_id.FillWeight = 99.49239F;
            this.index_id.HeaderText = "INDEX ID";
            this.index_id.MinimumWidth = 12;
            this.index_id.Name = "index_id";
            this.index_id.ReadOnly = true;
            // 
            // qty_reject
            // 
            this.qty_reject.DataPropertyName = "qty_reject";
            this.qty_reject.FillWeight = 99.49239F;
            this.qty_reject.HeaderText = "QTY REJECT";
            this.qty_reject.MinimumWidth = 12;
            this.qty_reject.Name = "qty_reject";
            this.qty_reject.ReadOnly = true;
            // 
            // reject_remarks
            // 
            this.reject_remarks.DataPropertyName = "reject_remarks";
            this.reject_remarks.FillWeight = 99.49239F;
            this.reject_remarks.HeaderText = "REMARKS";
            this.reject_remarks.MinimumWidth = 12;
            this.reject_remarks.Name = "reject_remarks";
            this.reject_remarks.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.metroLabel1);
            this.materialCard1.Controls.Add(this.mattxtQtyReceived);
            this.materialCard1.Controls.Add(this.mattxtItemDesc);
            this.materialCard1.Controls.Add(this.metroCmbRejectRemarks);
            this.materialCard1.Controls.Add(this.mattxtqtyreject);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(89, 189);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1134, 299);
            this.materialCard1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 169);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 20);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Remarks";
            // 
            // mattxtQtyReceived
            // 
            this.mattxtQtyReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtQtyReceived.Depth = 0;
            this.mattxtQtyReceived.Enabled = false;
            this.mattxtQtyReceived.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtQtyReceived.Hint = "Qty.";
            this.mattxtQtyReceived.Location = new System.Drawing.Point(822, 47);
            this.mattxtQtyReceived.MaxLength = 50;
            this.mattxtQtyReceived.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtQtyReceived.Multiline = false;
            this.mattxtQtyReceived.Name = "mattxtQtyReceived";
            this.mattxtQtyReceived.Size = new System.Drawing.Size(272, 50);
            this.mattxtQtyReceived.TabIndex = 27;
            this.mattxtQtyReceived.Text = "";
            // 
            // mattxtItemDesc
            // 
            this.mattxtItemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtItemDesc.Depth = 0;
            this.mattxtItemDesc.Enabled = false;
            this.mattxtItemDesc.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtItemDesc.Hint = "Item Description";
            this.mattxtItemDesc.Location = new System.Drawing.Point(57, 47);
            this.mattxtItemDesc.MaxLength = 50;
            this.mattxtItemDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtItemDesc.Multiline = false;
            this.mattxtItemDesc.Name = "mattxtItemDesc";
            this.mattxtItemDesc.Size = new System.Drawing.Size(685, 50);
            this.mattxtItemDesc.TabIndex = 26;
            this.mattxtItemDesc.Text = "";
            // 
            // metroCmbRejectRemarks
            // 
            this.metroCmbRejectRemarks.FormattingEnabled = true;
            this.metroCmbRejectRemarks.ItemHeight = 24;
            this.metroCmbRejectRemarks.Location = new System.Drawing.Point(57, 217);
            this.metroCmbRejectRemarks.Name = "metroCmbRejectRemarks";
            this.metroCmbRejectRemarks.Size = new System.Drawing.Size(685, 30);
            this.metroCmbRejectRemarks.TabIndex = 25;
            this.metroCmbRejectRemarks.UseSelectable = true;
            // 
            // mattxtqtyreject
            // 
            this.mattxtqtyreject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtqtyreject.Depth = 0;
            this.mattxtqtyreject.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtqtyreject.Hint = "Qty. Reject";
            this.mattxtqtyreject.Location = new System.Drawing.Point(822, 177);
            this.mattxtqtyreject.MaxLength = 50;
            this.mattxtqtyreject.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtqtyreject.Multiline = false;
            this.mattxtqtyreject.Name = "mattxtqtyreject";
            this.mattxtqtyreject.Size = new System.Drawing.Size(272, 50);
            this.mattxtqtyreject.TabIndex = 3;
            this.mattxtqtyreject.Text = "";
            this.mattxtqtyreject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtqtyreject_KeyPress);
            // 
            // matBtnAdd
            // 
            this.matBtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnAdd.Depth = 0;
            this.matBtnAdd.DrawShadows = true;
            this.matBtnAdd.HighEmphasis = true;
            this.matBtnAdd.Icon = null;
            this.matBtnAdd.Location = new System.Drawing.Point(1089, 1568);
            this.matBtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnAdd.Name = "matBtnAdd";
            this.matBtnAdd.Size = new System.Drawing.Size(58, 36);
            this.matBtnAdd.TabIndex = 475;
            this.matBtnAdd.Text = "SAVE";
            this.matBtnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnAdd.UseAccentColor = false;
            this.matBtnAdd.UseVisualStyleBackColor = true;
            this.matBtnAdd.Click += new System.EventHandler(this.matBtnAdd_Click);
            // 
            // lbltotalReject
            // 
            this.lbltotalReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotalReject.AutoSize = true;
            this.lbltotalReject.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalReject.Location = new System.Drawing.Point(88, 1519);
            this.lbltotalReject.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalReject.Name = "lbltotalReject";
            this.lbltotalReject.Size = new System.Drawing.Size(121, 85);
            this.lbltotalReject.TabIndex = 612;
            this.lbltotalReject.Text = "76";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(96, 1604);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 39);
            this.label2.TabIndex = 613;
            this.label2.Text = "Total Reject";
            // 
            // frmAddNewPartialRejectReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 1678);
            this.Controls.Add(this.lbltotalReject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matBtnAdd);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmAddNewPartialRejectReceiving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Receiving Rejection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddNewPartialRejectReceiving_FormClosing);
            this.Load += new System.EventHandler(this.frmAddNewPartialRejectReceiving_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotData)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLotData;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox mattxtqtyreject;
        private MetroFramework.Controls.MetroComboBox metroCmbRejectRemarks;
        private MaterialSkin.Controls.MaterialTextBox mattxtItemDesc;
        private MaterialSkin.Controls.MaterialTextBox mattxtQtyReceived;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialButton matBtnAdd;
        private System.Windows.Forms.Label lbltotalReject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn index_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_reject;
        private System.Windows.Forms.DataGridViewTextBoxColumn reject_remarks;
    }
}