
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    partial class frmManualAllocationController
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.matTxtUpdatedBalance = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtBalance = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtTotalAllocatedQty = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtAllocatedQty = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtQtyOrder = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtUom = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtItemDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtStoreName = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtStockOnHand = new MaterialSkin.Controls.MaterialTextBox();
            this.matTransactionID = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.matbtnManualAllocation = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.matTxtUpdatedBalance);
            this.materialCard1.Controls.Add(this.mattxtBalance);
            this.materialCard1.Controls.Add(this.matTxtTotalAllocatedQty);
            this.materialCard1.Controls.Add(this.mattxtAllocatedQty);
            this.materialCard1.Controls.Add(this.matTxtQtyOrder);
            this.materialCard1.Controls.Add(this.matTxtUom);
            this.materialCard1.Controls.Add(this.mattxtItemDesc);
            this.materialCard1.Controls.Add(this.matTxtItemCode);
            this.materialCard1.Controls.Add(this.matTxtStoreName);
            this.materialCard1.Controls.Add(this.matTxtStockOnHand);
            this.materialCard1.Controls.Add(this.matTransactionID);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(555, 428);
            this.materialCard1.TabIndex = 0;
            // 
            // matTxtUpdatedBalance
            // 
            this.matTxtUpdatedBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtUpdatedBalance.Depth = 0;
            this.matTxtUpdatedBalance.Enabled = false;
            this.matTxtUpdatedBalance.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtUpdatedBalance.Hint = "Updated Balance";
            this.matTxtUpdatedBalance.Location = new System.Drawing.Point(294, 366);
            this.matTxtUpdatedBalance.MaxLength = 50;
            this.matTxtUpdatedBalance.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtUpdatedBalance.Multiline = false;
            this.matTxtUpdatedBalance.Name = "matTxtUpdatedBalance";
            this.matTxtUpdatedBalance.Size = new System.Drawing.Size(240, 50);
            this.matTxtUpdatedBalance.TabIndex = 10;
            this.matTxtUpdatedBalance.Text = "";
            // 
            // mattxtBalance
            // 
            this.mattxtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtBalance.Depth = 0;
            this.mattxtBalance.Enabled = false;
            this.mattxtBalance.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtBalance.Hint = "Balance";
            this.mattxtBalance.Location = new System.Drawing.Point(22, 366);
            this.mattxtBalance.MaxLength = 50;
            this.mattxtBalance.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtBalance.Multiline = false;
            this.mattxtBalance.Name = "mattxtBalance";
            this.mattxtBalance.Size = new System.Drawing.Size(240, 50);
            this.mattxtBalance.TabIndex = 9;
            this.mattxtBalance.Text = "";
            this.mattxtBalance.TextChanged += new System.EventHandler(this.mattxtBalance_TextChanged);
            // 
            // matTxtTotalAllocatedQty
            // 
            this.matTxtTotalAllocatedQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtTotalAllocatedQty.Depth = 0;
            this.matTxtTotalAllocatedQty.Enabled = false;
            this.matTxtTotalAllocatedQty.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtTotalAllocatedQty.Hint = "Total Allocated Quantity";
            this.matTxtTotalAllocatedQty.Location = new System.Drawing.Point(294, 303);
            this.matTxtTotalAllocatedQty.MaxLength = 50;
            this.matTxtTotalAllocatedQty.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtTotalAllocatedQty.Multiline = false;
            this.matTxtTotalAllocatedQty.Name = "matTxtTotalAllocatedQty";
            this.matTxtTotalAllocatedQty.Size = new System.Drawing.Size(240, 50);
            this.matTxtTotalAllocatedQty.TabIndex = 8;
            this.matTxtTotalAllocatedQty.Text = "";
            // 
            // mattxtAllocatedQty
            // 
            this.mattxtAllocatedQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtAllocatedQty.Depth = 0;
            this.mattxtAllocatedQty.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtAllocatedQty.Hint = "Allocated Quantity";
            this.mattxtAllocatedQty.Location = new System.Drawing.Point(23, 303);
            this.mattxtAllocatedQty.MaxLength = 50;
            this.mattxtAllocatedQty.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtAllocatedQty.Multiline = false;
            this.mattxtAllocatedQty.Name = "mattxtAllocatedQty";
            this.mattxtAllocatedQty.Size = new System.Drawing.Size(240, 50);
            this.mattxtAllocatedQty.TabIndex = 7;
            this.mattxtAllocatedQty.Text = "";
            this.mattxtAllocatedQty.TextChanged += new System.EventHandler(this.mattxtAllocatedQty_TextChanged);
            // 
            // matTxtQtyOrder
            // 
            this.matTxtQtyOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtQtyOrder.Depth = 0;
            this.matTxtQtyOrder.Enabled = false;
            this.matTxtQtyOrder.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtQtyOrder.Hint = "Quantity Order";
            this.matTxtQtyOrder.Location = new System.Drawing.Point(294, 235);
            this.matTxtQtyOrder.MaxLength = 50;
            this.matTxtQtyOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtQtyOrder.Multiline = false;
            this.matTxtQtyOrder.Name = "matTxtQtyOrder";
            this.matTxtQtyOrder.Size = new System.Drawing.Size(240, 50);
            this.matTxtQtyOrder.TabIndex = 6;
            this.matTxtQtyOrder.Text = "";
            // 
            // matTxtUom
            // 
            this.matTxtUom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtUom.Depth = 0;
            this.matTxtUom.Enabled = false;
            this.matTxtUom.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtUom.Hint = "Unit Of Measure";
            this.matTxtUom.Location = new System.Drawing.Point(23, 235);
            this.matTxtUom.MaxLength = 50;
            this.matTxtUom.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtUom.Multiline = false;
            this.matTxtUom.Name = "matTxtUom";
            this.matTxtUom.Size = new System.Drawing.Size(240, 50);
            this.matTxtUom.TabIndex = 5;
            this.matTxtUom.Text = "";
            // 
            // mattxtItemDesc
            // 
            this.mattxtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtItemDesc.Depth = 0;
            this.mattxtItemDesc.Enabled = false;
            this.mattxtItemDesc.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtItemDesc.Hint = "Item Description";
            this.mattxtItemDesc.Location = new System.Drawing.Point(294, 168);
            this.mattxtItemDesc.MaxLength = 50;
            this.mattxtItemDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtItemDesc.Multiline = false;
            this.mattxtItemDesc.Name = "mattxtItemDesc";
            this.mattxtItemDesc.Size = new System.Drawing.Size(240, 50);
            this.mattxtItemDesc.TabIndex = 4;
            this.mattxtItemDesc.Text = "";
            // 
            // matTxtItemCode
            // 
            this.matTxtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtItemCode.Depth = 0;
            this.matTxtItemCode.Enabled = false;
            this.matTxtItemCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtItemCode.Hint = "Item Code";
            this.matTxtItemCode.Location = new System.Drawing.Point(23, 168);
            this.matTxtItemCode.MaxLength = 50;
            this.matTxtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtItemCode.Multiline = false;
            this.matTxtItemCode.Name = "matTxtItemCode";
            this.matTxtItemCode.Size = new System.Drawing.Size(240, 50);
            this.matTxtItemCode.TabIndex = 3;
            this.matTxtItemCode.Text = "";
            // 
            // matTxtStoreName
            // 
            this.matTxtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtStoreName.Depth = 0;
            this.matTxtStoreName.Enabled = false;
            this.matTxtStoreName.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtStoreName.Hint = "Store Name";
            this.matTxtStoreName.Location = new System.Drawing.Point(23, 98);
            this.matTxtStoreName.MaxLength = 50;
            this.matTxtStoreName.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtStoreName.Multiline = false;
            this.matTxtStoreName.Name = "matTxtStoreName";
            this.matTxtStoreName.Size = new System.Drawing.Size(511, 50);
            this.matTxtStoreName.TabIndex = 2;
            this.matTxtStoreName.Text = "";
            // 
            // matTxtStockOnHand
            // 
            this.matTxtStockOnHand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtStockOnHand.Depth = 0;
            this.matTxtStockOnHand.Enabled = false;
            this.matTxtStockOnHand.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtStockOnHand.Hint = "Stock On Hand";
            this.matTxtStockOnHand.Location = new System.Drawing.Point(294, 27);
            this.matTxtStockOnHand.MaxLength = 50;
            this.matTxtStockOnHand.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtStockOnHand.Multiline = false;
            this.matTxtStockOnHand.Name = "matTxtStockOnHand";
            this.matTxtStockOnHand.Size = new System.Drawing.Size(240, 50);
            this.matTxtStockOnHand.TabIndex = 1;
            this.matTxtStockOnHand.Text = "";
            // 
            // matTransactionID
            // 
            this.matTransactionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTransactionID.Depth = 0;
            this.matTransactionID.Enabled = false;
            this.matTransactionID.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTransactionID.Hint = "Transaction ID";
            this.matTransactionID.Location = new System.Drawing.Point(23, 28);
            this.matTransactionID.MaxLength = 50;
            this.matTransactionID.MouseState = MaterialSkin.MouseState.OUT;
            this.matTransactionID.Multiline = false;
            this.matTransactionID.Name = "matTransactionID";
            this.matTransactionID.Size = new System.Drawing.Size(240, 50);
            this.matTransactionID.TabIndex = 0;
            this.matTransactionID.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(382, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 604;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // matbtnManualAllocation
            // 
            this.matbtnManualAllocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnManualAllocation.Depth = 0;
            this.matbtnManualAllocation.DrawShadows = true;
            this.matbtnManualAllocation.HighEmphasis = true;
            this.matbtnManualAllocation.Icon = null;
            this.matbtnManualAllocation.Location = new System.Drawing.Point(420, 521);
            this.matbtnManualAllocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnManualAllocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnManualAllocation.Name = "matbtnManualAllocation";
            this.matbtnManualAllocation.Size = new System.Drawing.Size(158, 36);
            this.matbtnManualAllocation.TabIndex = 651;
            this.matbtnManualAllocation.Text = "Manual Allocate";
            this.matbtnManualAllocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnManualAllocation.UseAccentColor = false;
            this.matbtnManualAllocation.UseVisualStyleBackColor = true;
            this.matbtnManualAllocation.Click += new System.EventHandler(this.matbtnManualAllocation_Click);
            // 
            // frmManualAllocationController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 571);
            this.Controls.Add(this.matbtnManualAllocation);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManualAllocationController";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANUAL ALLOCATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManualAllocationController_FormClosing);
            this.Load += new System.EventHandler(this.frmManualAllocationController_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox matTransactionID;
        private MaterialSkin.Controls.MaterialTextBox matTxtStoreName;
        private MaterialSkin.Controls.MaterialTextBox matTxtStockOnHand;
        private System.Windows.Forms.TextBox textBox2;
        private MaterialSkin.Controls.MaterialButton matbtnManualAllocation;
        private MaterialSkin.Controls.MaterialTextBox matTxtTotalAllocatedQty;
        private MaterialSkin.Controls.MaterialTextBox mattxtAllocatedQty;
        private MaterialSkin.Controls.MaterialTextBox matTxtQtyOrder;
        private MaterialSkin.Controls.MaterialTextBox matTxtUom;
        private MaterialSkin.Controls.MaterialTextBox mattxtItemDesc;
        private MaterialSkin.Controls.MaterialTextBox matTxtItemCode;
        private MaterialSkin.Controls.MaterialTextBox mattxtBalance;
        private MaterialSkin.Controls.MaterialTextBox matTxtUpdatedBalance;
    }
}