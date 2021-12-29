
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Preparation
{
    partial class frmServeStorePreparation
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matTxtUOM = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtOrderQty = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtReceivingbarcodeID = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtQtyServe = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Controls.Add(this.matTxtUOM);
            this.materialCard1.Controls.Add(this.matTxtOrderQty);
            this.materialCard1.Controls.Add(this.matTxtReceivingbarcodeID);
            this.materialCard1.Controls.Add(this.mattxtQtyServe);
            this.materialCard1.Controls.Add(this.matTxtDescription);
            this.materialCard1.Controls.Add(this.mattxtItemCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(28, 86);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(747, 297);
            this.materialCard1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(31, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 10);
            this.panel1.TabIndex = 6;
            // 
            // matTxtUOM
            // 
            this.matTxtUOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtUOM.Depth = 0;
            this.matTxtUOM.Enabled = false;
            this.matTxtUOM.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtUOM.Hint = "UOM";
            this.matTxtUOM.Location = new System.Drawing.Point(511, 162);
            this.matTxtUOM.MaxLength = 50;
            this.matTxtUOM.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtUOM.Multiline = false;
            this.matTxtUOM.Name = "matTxtUOM";
            this.matTxtUOM.Size = new System.Drawing.Size(202, 50);
            this.matTxtUOM.TabIndex = 5;
            this.matTxtUOM.Text = "";
            // 
            // matTxtOrderQty
            // 
            this.matTxtOrderQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtOrderQty.Depth = 0;
            this.matTxtOrderQty.Enabled = false;
            this.matTxtOrderQty.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtOrderQty.Hint = "Order";
            this.matTxtOrderQty.Location = new System.Drawing.Point(266, 162);
            this.matTxtOrderQty.MaxLength = 50;
            this.matTxtOrderQty.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtOrderQty.Multiline = false;
            this.matTxtOrderQty.Name = "matTxtOrderQty";
            this.matTxtOrderQty.Size = new System.Drawing.Size(202, 50);
            this.matTxtOrderQty.TabIndex = 4;
            this.matTxtOrderQty.Text = "";
            // 
            // matTxtReceivingbarcodeID
            // 
            this.matTxtReceivingbarcodeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtReceivingbarcodeID.Depth = 0;
            this.matTxtReceivingbarcodeID.Enabled = false;
            this.matTxtReceivingbarcodeID.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtReceivingbarcodeID.Hint = "Receiving ID";
            this.matTxtReceivingbarcodeID.Location = new System.Drawing.Point(31, 162);
            this.matTxtReceivingbarcodeID.MaxLength = 50;
            this.matTxtReceivingbarcodeID.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtReceivingbarcodeID.Multiline = false;
            this.matTxtReceivingbarcodeID.Name = "matTxtReceivingbarcodeID";
            this.matTxtReceivingbarcodeID.Size = new System.Drawing.Size(202, 50);
            this.matTxtReceivingbarcodeID.TabIndex = 3;
            this.matTxtReceivingbarcodeID.Text = "";
            // 
            // mattxtQtyServe
            // 
            this.mattxtQtyServe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtQtyServe.Depth = 0;
            this.mattxtQtyServe.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtQtyServe.Hint = "Quantity Serve";
            this.mattxtQtyServe.Location = new System.Drawing.Point(31, 90);
            this.mattxtQtyServe.MaxLength = 50;
            this.mattxtQtyServe.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtQtyServe.Multiline = false;
            this.mattxtQtyServe.Name = "mattxtQtyServe";
            this.mattxtQtyServe.Size = new System.Drawing.Size(682, 50);
            this.mattxtQtyServe.TabIndex = 2;
            this.mattxtQtyServe.Text = "";
            // 
            // matTxtDescription
            // 
            this.matTxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtDescription.Depth = 0;
            this.matTxtDescription.Enabled = false;
            this.matTxtDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtDescription.Hint = "Description";
            this.matTxtDescription.Location = new System.Drawing.Point(388, 17);
            this.matTxtDescription.MaxLength = 50;
            this.matTxtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtDescription.Multiline = false;
            this.matTxtDescription.Name = "matTxtDescription";
            this.matTxtDescription.Size = new System.Drawing.Size(325, 50);
            this.matTxtDescription.TabIndex = 1;
            this.matTxtDescription.Text = "";
            // 
            // mattxtItemCode
            // 
            this.mattxtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtItemCode.Depth = 0;
            this.mattxtItemCode.Enabled = false;
            this.mattxtItemCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtItemCode.Hint = "Item Code";
            this.mattxtItemCode.Location = new System.Drawing.Point(31, 17);
            this.mattxtItemCode.MaxLength = 50;
            this.mattxtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtItemCode.Multiline = false;
            this.mattxtItemCode.Name = "mattxtItemCode";
            this.mattxtItemCode.Size = new System.Drawing.Size(325, 50);
            this.mattxtItemCode.TabIndex = 0;
            this.mattxtItemCode.Text = "";
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(717, 396);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 646;
            this.matBtnSave.Text = "Save";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // dgvStoreOrderApproval
            // 
            this.dgvStoreOrderApproval.AllowUserToAddRows = false;
            this.dgvStoreOrderApproval.AllowUserToDeleteRows = false;
            this.dgvStoreOrderApproval.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvStoreOrderApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreOrderApproval.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvStoreOrderApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrderApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvStoreOrderApproval.ColumnHeadersHeight = 45;
            this.dgvStoreOrderApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrderApproval.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvStoreOrderApproval.EnableHeadersVisualStyles = false;
            this.dgvStoreOrderApproval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.Location = new System.Drawing.Point(59, 456);
            this.dgvStoreOrderApproval.MultiSelect = false;
            this.dgvStoreOrderApproval.Name = "dgvStoreOrderApproval";
            this.dgvStoreOrderApproval.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvStoreOrderApproval.RowHeadersVisible = false;
            this.dgvStoreOrderApproval.RowHeadersWidth = 102;
            this.dgvStoreOrderApproval.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.RowTemplate.DividerHeight = 5;
            this.dgvStoreOrderApproval.RowTemplate.Height = 40;
            this.dgvStoreOrderApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreOrderApproval.Size = new System.Drawing.Size(713, 49);
            this.dgvStoreOrderApproval.TabIndex = 647;
            this.dgvStoreOrderApproval.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.BackColor = System.Drawing.Color.Pink;
            this.dgvStoreOrderApproval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStoreOrderApproval.ThemeStyle.ReadOnly = true;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.CurrentCellChanged += new System.EventHandler(this.dgvStoreOrderApproval_CurrentCellChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(443, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 648;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmServeStorePreparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvStoreOrderApproval);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmServeStorePreparation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serve Quantity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServeStorePreparation_FormClosing);
            this.Load += new System.EventHandler(this.frmServeStorePreparation_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox mattxtItemCode;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MaterialSkin.Controls.MaterialTextBox matTxtUOM;
        private MaterialSkin.Controls.MaterialTextBox matTxtOrderQty;
        private MaterialSkin.Controls.MaterialTextBox matTxtReceivingbarcodeID;
        private MaterialSkin.Controls.MaterialTextBox mattxtQtyServe;
        private MaterialSkin.Controls.MaterialTextBox matTxtDescription;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        public System.Windows.Forms.TextBox textBox1;
    }
}