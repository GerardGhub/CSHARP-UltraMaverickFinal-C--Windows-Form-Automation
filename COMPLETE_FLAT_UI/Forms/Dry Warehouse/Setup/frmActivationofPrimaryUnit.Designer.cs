
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmActivationofPrimaryUnit
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroStatus = new MetroFramework.Controls.MetroComboBox();
            this.txtMatConversion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatPrimaryUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatItemDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.metroStatus);
            this.materialCard1.Controls.Add(this.txtMatConversion);
            this.materialCard1.Controls.Add(this.txtMatPrimaryUnit);
            this.materialCard1.Controls.Add(this.txtMatItemDesc);
            this.materialCard1.Controls.Add(this.txtMatItemCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(21, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(679, 178);
            this.materialCard1.TabIndex = 474;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status";
            // 
            // metroStatus
            // 
            this.metroStatus.FormattingEnabled = true;
            this.metroStatus.ItemHeight = 23;
            this.metroStatus.Location = new System.Drawing.Point(30, 130);
            this.metroStatus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.metroStatus.Name = "metroStatus";
            this.metroStatus.Size = new System.Drawing.Size(161, 29);
            this.metroStatus.TabIndex = 4;
            this.metroStatus.UseSelectable = true;
            // 
            // txtMatConversion
            // 
            this.txtMatConversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatConversion.Depth = 0;
            this.txtMatConversion.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatConversion.Hint = "Conversion";
            this.txtMatConversion.Location = new System.Drawing.Point(473, 79);
            this.txtMatConversion.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtMatConversion.MaxLength = 50;
            this.txtMatConversion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatConversion.Multiline = false;
            this.txtMatConversion.Name = "txtMatConversion";
            this.txtMatConversion.Size = new System.Drawing.Size(155, 50);
            this.txtMatConversion.TabIndex = 3;
            this.txtMatConversion.Text = "";
            // 
            // txtMatPrimaryUnit
            // 
            this.txtMatPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatPrimaryUnit.Depth = 0;
            this.txtMatPrimaryUnit.Enabled = false;
            this.txtMatPrimaryUnit.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatPrimaryUnit.Hint = "Primary Unit";
            this.txtMatPrimaryUnit.Location = new System.Drawing.Point(33, 79);
            this.txtMatPrimaryUnit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtMatPrimaryUnit.MaxLength = 50;
            this.txtMatPrimaryUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatPrimaryUnit.Multiline = false;
            this.txtMatPrimaryUnit.Name = "txtMatPrimaryUnit";
            this.txtMatPrimaryUnit.Size = new System.Drawing.Size(155, 50);
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
            this.txtMatItemDesc.Location = new System.Drawing.Point(473, 24);
            this.txtMatItemDesc.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtMatItemDesc.MaxLength = 50;
            this.txtMatItemDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatItemDesc.Multiline = false;
            this.txtMatItemDesc.Name = "txtMatItemDesc";
            this.txtMatItemDesc.Size = new System.Drawing.Size(155, 50);
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
            this.txtMatItemCode.Location = new System.Drawing.Point(33, 24);
            this.txtMatItemCode.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtMatItemCode.MaxLength = 50;
            this.txtMatItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatItemCode.Multiline = false;
            this.txtMatItemCode.Name = "txtMatItemCode";
            this.txtMatItemCode.Size = new System.Drawing.Size(155, 50);
            this.txtMatItemCode.TabIndex = 0;
            this.txtMatItemCode.Text = "";
            // 
            // frmActivationofPrimaryUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 294);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmActivationofPrimaryUnit";
            this.Text = "Activation of Primary Unit";
            this.Load += new System.EventHandler(this.frmActivationofPrimaryUnit_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtMatConversion;
        private MaterialSkin.Controls.MaterialTextBox txtMatPrimaryUnit;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemDesc;
        private MaterialSkin.Controls.MaterialTextBox txtMatItemCode;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroStatus;
    }
}