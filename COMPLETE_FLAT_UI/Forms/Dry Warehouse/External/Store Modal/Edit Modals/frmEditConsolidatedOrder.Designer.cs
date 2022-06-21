
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmEditConsolidatedOrder
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
            this.mattxtUpdatedQty = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtQtyOrder = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mattxtUOm = new MaterialSkin.Controls.MaterialTextBox();
            this.matxtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mattxtArea = new MaterialSkin.Controls.MaterialTextBox();
            this.matxtxRoute = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtStore = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatStoreCode = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mattxtUpdatedQty);
            this.materialCard1.Controls.Add(this.mattxtQtyOrder);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.mattxtUOm);
            this.materialCard1.Controls.Add(this.matxtDescription);
            this.materialCard1.Controls.Add(this.mattxtItemCode);
            this.materialCard1.Controls.Add(this.mattxtCategory);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.mattxtArea);
            this.materialCard1.Controls.Add(this.matxtxRoute);
            this.materialCard1.Controls.Add(this.mattxtStore);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.txtMatStoreCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 88);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(1000, 269);
            this.materialCard1.TabIndex = 481;
            // 
            // mattxtUpdatedQty
            // 
            this.mattxtUpdatedQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtUpdatedQty.Depth = 0;
            this.mattxtUpdatedQty.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtUpdatedQty.Hint = "New Quantity";
            this.mattxtUpdatedQty.Location = new System.Drawing.Point(285, 204);
            this.mattxtUpdatedQty.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtUpdatedQty.MaxLength = 50;
            this.mattxtUpdatedQty.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtUpdatedQty.Multiline = false;
            this.mattxtUpdatedQty.Name = "mattxtUpdatedQty";
            this.mattxtUpdatedQty.Size = new System.Drawing.Size(234, 50);
            this.mattxtUpdatedQty.TabIndex = 613;
            this.mattxtUpdatedQty.Text = "";
            this.mattxtUpdatedQty.TextChanged += new System.EventHandler(this.mattxtUpdatedQty_TextChanged);
            this.mattxtUpdatedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtUpdatedQty_KeyPress);
            // 
            // mattxtQtyOrder
            // 
            this.mattxtQtyOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtQtyOrder.Depth = 0;
            this.mattxtQtyOrder.Enabled = false;
            this.mattxtQtyOrder.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtQtyOrder.Hint = "Quantity Order";
            this.mattxtQtyOrder.Location = new System.Drawing.Point(27, 203);
            this.mattxtQtyOrder.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtQtyOrder.MaxLength = 50;
            this.mattxtQtyOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtQtyOrder.Multiline = false;
            this.mattxtQtyOrder.Name = "mattxtQtyOrder";
            this.mattxtQtyOrder.Size = new System.Drawing.Size(234, 50);
            this.mattxtQtyOrder.TabIndex = 612;
            this.mattxtQtyOrder.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 611;
            this.label2.Text = "Quantity Adjustment";
            // 
            // mattxtUOm
            // 
            this.mattxtUOm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtUOm.Depth = 0;
            this.mattxtUOm.Enabled = false;
            this.mattxtUOm.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtUOm.Hint = "UOM";
            this.mattxtUOm.Location = new System.Drawing.Point(808, 119);
            this.mattxtUOm.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtUOm.MaxLength = 50;
            this.mattxtUOm.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtUOm.Multiline = false;
            this.mattxtUOm.Name = "mattxtUOm";
            this.mattxtUOm.Size = new System.Drawing.Size(171, 50);
            this.mattxtUOm.TabIndex = 610;
            this.mattxtUOm.Text = "";
            // 
            // matxtDescription
            // 
            this.matxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matxtDescription.Depth = 0;
            this.matxtDescription.Enabled = false;
            this.matxtDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.matxtDescription.Hint = "Description";
            this.matxtDescription.Location = new System.Drawing.Point(548, 118);
            this.matxtDescription.Margin = new System.Windows.Forms.Padding(1);
            this.matxtDescription.MaxLength = 50;
            this.matxtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.matxtDescription.Multiline = false;
            this.matxtDescription.Name = "matxtDescription";
            this.matxtDescription.Size = new System.Drawing.Size(234, 50);
            this.matxtDescription.TabIndex = 609;
            this.matxtDescription.Text = "";
            // 
            // mattxtItemCode
            // 
            this.mattxtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtItemCode.Depth = 0;
            this.mattxtItemCode.Enabled = false;
            this.mattxtItemCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtItemCode.Hint = "Item Code";
            this.mattxtItemCode.Location = new System.Drawing.Point(280, 119);
            this.mattxtItemCode.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtItemCode.MaxLength = 50;
            this.mattxtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtItemCode.Multiline = false;
            this.mattxtItemCode.Name = "mattxtItemCode";
            this.mattxtItemCode.Size = new System.Drawing.Size(234, 50);
            this.mattxtItemCode.TabIndex = 608;
            this.mattxtItemCode.Text = "";
            // 
            // mattxtCategory
            // 
            this.mattxtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtCategory.Depth = 0;
            this.mattxtCategory.Enabled = false;
            this.mattxtCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtCategory.Hint = "Category";
            this.mattxtCategory.Location = new System.Drawing.Point(22, 118);
            this.mattxtCategory.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtCategory.MaxLength = 50;
            this.mattxtCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtCategory.Multiline = false;
            this.mattxtCategory.Name = "mattxtCategory";
            this.mattxtCategory.Size = new System.Drawing.Size(234, 50);
            this.mattxtCategory.TabIndex = 607;
            this.mattxtCategory.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 606;
            this.label1.Text = "Item Information";
            // 
            // mattxtArea
            // 
            this.mattxtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtArea.Depth = 0;
            this.mattxtArea.Enabled = false;
            this.mattxtArea.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtArea.Hint = "Area";
            this.mattxtArea.Location = new System.Drawing.Point(808, 30);
            this.mattxtArea.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtArea.MaxLength = 50;
            this.mattxtArea.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtArea.Multiline = false;
            this.mattxtArea.Name = "mattxtArea";
            this.mattxtArea.Size = new System.Drawing.Size(171, 50);
            this.mattxtArea.TabIndex = 605;
            this.mattxtArea.Text = "";
            // 
            // matxtxRoute
            // 
            this.matxtxRoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matxtxRoute.Depth = 0;
            this.matxtxRoute.Enabled = false;
            this.matxtxRoute.Font = new System.Drawing.Font("Roboto", 12F);
            this.matxtxRoute.Hint = "Route";
            this.matxtxRoute.Location = new System.Drawing.Point(548, 29);
            this.matxtxRoute.Margin = new System.Windows.Forms.Padding(1);
            this.matxtxRoute.MaxLength = 50;
            this.matxtxRoute.MouseState = MaterialSkin.MouseState.OUT;
            this.matxtxRoute.Multiline = false;
            this.matxtxRoute.Name = "matxtxRoute";
            this.matxtxRoute.Size = new System.Drawing.Size(234, 50);
            this.matxtxRoute.TabIndex = 604;
            this.matxtxRoute.Text = "";
            // 
            // mattxtStore
            // 
            this.mattxtStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtStore.Depth = 0;
            this.mattxtStore.Enabled = false;
            this.mattxtStore.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtStore.Hint = "Store";
            this.mattxtStore.Location = new System.Drawing.Point(280, 30);
            this.mattxtStore.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtStore.MaxLength = 50;
            this.mattxtStore.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtStore.Multiline = false;
            this.mattxtStore.Name = "mattxtStore";
            this.mattxtStore.Size = new System.Drawing.Size(234, 50);
            this.mattxtStore.TabIndex = 603;
            this.mattxtStore.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(24, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 602;
            this.label6.Text = "Store Information";
            // 
            // txtMatStoreCode
            // 
            this.txtMatStoreCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatStoreCode.Depth = 0;
            this.txtMatStoreCode.Enabled = false;
            this.txtMatStoreCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatStoreCode.Hint = "Store Code";
            this.txtMatStoreCode.Location = new System.Drawing.Point(22, 29);
            this.txtMatStoreCode.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatStoreCode.MaxLength = 50;
            this.txtMatStoreCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatStoreCode.Multiline = false;
            this.txtMatStoreCode.Name = "txtMatStoreCode";
            this.txtMatStoreCode.Size = new System.Drawing.Size(234, 50);
            this.txtMatStoreCode.TabIndex = 0;
            this.txtMatStoreCode.Text = "";
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(31, 366);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(77, 36);
            this.matBtnSave.TabIndex = 482;
            this.matBtnSave.Text = "UPDATE";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(543, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 480;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmEditConsolidatedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 422);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditConsolidatedOrder";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Consolidated Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditConsolidatedOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmEditConsolidatedOrder_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox mattxtArea;
        private MaterialSkin.Controls.MaterialTextBox matxtxRoute;
        private MaterialSkin.Controls.MaterialTextBox mattxtStore;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtMatStoreCode;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox mattxtUOm;
        private MaterialSkin.Controls.MaterialTextBox matxtDescription;
        private MaterialSkin.Controls.MaterialTextBox mattxtItemCode;
        private MaterialSkin.Controls.MaterialTextBox mattxtCategory;
        private MaterialSkin.Controls.MaterialTextBox mattxtUpdatedQty;
        private MaterialSkin.Controls.MaterialTextBox mattxtQtyOrder;
        private System.Windows.Forms.Label label2;
    }
}