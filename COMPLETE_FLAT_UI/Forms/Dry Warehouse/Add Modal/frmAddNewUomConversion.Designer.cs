
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmAddNewUomConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUomConversion));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtMatConversion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatPrimaryUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatItemDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddTool = new System.Windows.Forms.ToolStripButton();
            this.btnEditTool = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTool = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveTool = new System.Windows.Forms.ToolStripButton();
            this.btnCancelTool = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtMatConversion);
            this.materialCard1.Controls.Add(this.txtMatPrimaryUnit);
            this.materialCard1.Controls.Add(this.txtMatItemDesc);
            this.materialCard1.Controls.Add(this.txtMatItemCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(679, 192);
            this.materialCard1.TabIndex = 473;
            // 
            // txtMatConversion
            // 
            this.txtMatConversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatConversion.Depth = 0;
            this.txtMatConversion.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatConversion.Hint = "Conversion";
            this.txtMatConversion.Location = new System.Drawing.Point(377, 103);
            this.txtMatConversion.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatConversion.MaxLength = 50;
            this.txtMatConversion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatConversion.Multiline = false;
            this.txtMatConversion.Name = "txtMatConversion";
            this.txtMatConversion.Size = new System.Drawing.Size(257, 50);
            this.txtMatConversion.TabIndex = 3;
            this.txtMatConversion.Text = "";
            this.txtMatConversion.TextChanged += new System.EventHandler(this.txtMatConversion_TextChanged);
            this.txtMatConversion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatConversion_KeyPress);
            // 
            // txtMatPrimaryUnit
            // 
            this.txtMatPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatPrimaryUnit.Depth = 0;
            this.txtMatPrimaryUnit.Enabled = false;
            this.txtMatPrimaryUnit.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatPrimaryUnit.Hint = "Primary Unit";
            this.txtMatPrimaryUnit.Location = new System.Drawing.Point(43, 103);
            this.txtMatPrimaryUnit.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatPrimaryUnit.MaxLength = 50;
            this.txtMatPrimaryUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatPrimaryUnit.Multiline = false;
            this.txtMatPrimaryUnit.Name = "txtMatPrimaryUnit";
            this.txtMatPrimaryUnit.Size = new System.Drawing.Size(257, 50);
            this.txtMatPrimaryUnit.TabIndex = 2;
            this.txtMatPrimaryUnit.Text = "";
            // 
            // txtMatItemDesc
            // 
            this.txtMatItemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatItemDesc.Depth = 0;
            this.txtMatItemDesc.Enabled = false;
            this.txtMatItemDesc.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatItemDesc.Hint = "Item Description";
            this.txtMatItemDesc.Location = new System.Drawing.Point(377, 29);
            this.txtMatItemDesc.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatItemDesc.MaxLength = 50;
            this.txtMatItemDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatItemDesc.Multiline = false;
            this.txtMatItemDesc.Name = "txtMatItemDesc";
            this.txtMatItemDesc.Size = new System.Drawing.Size(257, 50);
            this.txtMatItemDesc.TabIndex = 1;
            this.txtMatItemDesc.Text = "";
            // 
            // txtMatItemCode
            // 
            this.txtMatItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatItemCode.Depth = 0;
            this.txtMatItemCode.Enabled = false;
            this.txtMatItemCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatItemCode.Hint = "Item Code";
            this.txtMatItemCode.Location = new System.Drawing.Point(43, 29);
            this.txtMatItemCode.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatItemCode.MaxLength = 50;
            this.txtMatItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatItemCode.Multiline = false;
            this.txtMatItemCode.Name = "txtMatItemCode";
            this.txtMatItemCode.Size = new System.Drawing.Size(257, 50);
            this.txtMatItemCode.TabIndex = 0;
            this.txtMatItemCode.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(19, 279);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 40);
            this.panel1.TabIndex = 567;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTool,
            this.btnEditTool,
            this.btnDeleteTool,
            this.BtnSaveTool,
            this.btnCancelTool});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(321, 40);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTool.Image")));
            this.btnAddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(77, 37);
            this.btnAddTool.Text = "&New";
            this.btnAddTool.Visible = false;
            // 
            // btnEditTool
            // 
            this.btnEditTool.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTool.Image")));
            this.btnEditTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTool.Name = "btnEditTool";
            this.btnEditTool.Size = new System.Drawing.Size(72, 37);
            this.btnEditTool.Text = "&Edit";
            this.btnEditTool.Visible = false;
            this.btnEditTool.Click += new System.EventHandler(this.btnEditTool_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTool.Image")));
            this.btnDeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(94, 37);
            this.btnDeleteTool.Text = "&Remove";
            this.btnDeleteTool.Visible = false;
            // 
            // BtnSaveTool
            // 
            this.BtnSaveTool.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveTool.Image")));
            this.BtnSaveTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveTool.Name = "BtnSaveTool";
            this.BtnSaveTool.Size = new System.Drawing.Size(77, 37);
            this.BtnSaveTool.Text = "&Save";
            this.BtnSaveTool.Visible = false;
            this.BtnSaveTool.Click += new System.EventHandler(this.btnUpdateTool_Click);
            // 
            // btnCancelTool
            // 
            this.btnCancelTool.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTool.Image")));
            this.btnCancelTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTool.Name = "btnCancelTool";
            this.btnCancelTool.Size = new System.Drawing.Size(88, 37);
            this.btnCancelTool.Text = "&Cancel";
            this.btnCancelTool.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(498, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 568;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbluserid
            // 
            this.lbluserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbluserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(278, 341);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(145, 20);
            this.lbluserid.TabIndex = 569;
            this.lbluserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbluserid.Visible = false;
            // 
            // frmAddNewUomConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 339);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewUomConversion";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New  Conversion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewUomConversion_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNewUomConversion_Load);
            this.materialCard1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemDesc;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddTool;
        private System.Windows.Forms.ToolStripButton btnEditTool;
        private System.Windows.Forms.ToolStripButton btnDeleteTool;
        private System.Windows.Forms.ToolStripButton BtnSaveTool;
        private System.Windows.Forms.ToolStripButton btnCancelTool;
        private MaterialSkin.Controls.MaterialTextBox txtMatConversion;
        private MaterialSkin.Controls.MaterialTextBox txtMatPrimaryUnit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox lbluserid;
    }
}