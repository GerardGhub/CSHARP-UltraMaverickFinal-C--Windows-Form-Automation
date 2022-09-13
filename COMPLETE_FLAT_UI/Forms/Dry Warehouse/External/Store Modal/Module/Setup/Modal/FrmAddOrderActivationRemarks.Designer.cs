
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Setup.Modal
{
    partial class FrmOrderActivationRemarks
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
            this.matcmbType = new MaterialSkin.Controls.MaterialComboBox();
            this.txtmatRemarks = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.MatBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.matcmbType);
            this.materialCard1.Controls.Add(this.txtmatRemarks);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(32, 90);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(495, 200);
            this.materialCard1.TabIndex = 482;
            // 
            // matcmbType
            // 
            this.matcmbType.AutoResize = false;
            this.matcmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matcmbType.Depth = 0;
            this.matcmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matcmbType.DropDownHeight = 174;
            this.matcmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matcmbType.DropDownWidth = 121;
            this.matcmbType.Enabled = false;
            this.matcmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.matcmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matcmbType.FormattingEnabled = true;
            this.matcmbType.Hint = "Type";
            this.matcmbType.IntegralHeight = false;
            this.matcmbType.ItemHeight = 43;
            this.matcmbType.Items.AddRange(new object[] {
            "Cancel",
            "Return"});
            this.matcmbType.Location = new System.Drawing.Point(53, 32);
            this.matcmbType.MaxDropDownItems = 4;
            this.matcmbType.MouseState = MaterialSkin.MouseState.OUT;
            this.matcmbType.Name = "matcmbType";
            this.matcmbType.Size = new System.Drawing.Size(386, 49);
            this.matcmbType.TabIndex = 602;
            // 
            // txtmatRemarks
            // 
            this.txtmatRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatRemarks.Depth = 0;
            this.txtmatRemarks.Enabled = false;
            this.txtmatRemarks.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatRemarks.Hint = "Remarks";
            this.txtmatRemarks.Location = new System.Drawing.Point(53, 119);
            this.txtmatRemarks.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatRemarks.MaxLength = 50;
            this.txtmatRemarks.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatRemarks.Multiline = false;
            this.txtmatRemarks.Name = "txtmatRemarks";
            this.txtmatRemarks.Size = new System.Drawing.Size(386, 50);
            this.txtmatRemarks.TabIndex = 1;
            this.txtmatRemarks.Text = "";
            this.txtmatRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatRemarks_KeyPress);
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(207, 307);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(145, 20);
            this.TextBox1.TabIndex = 484;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.Visible = false;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // MatBtnSave
            // 
            this.MatBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnSave.Depth = 0;
            this.MatBtnSave.DrawShadows = true;
            this.MatBtnSave.HighEmphasis = true;
            this.MatBtnSave.Icon = null;
            this.MatBtnSave.Location = new System.Drawing.Point(468, 307);
            this.MatBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnSave.Name = "MatBtnSave";
            this.MatBtnSave.Size = new System.Drawing.Size(58, 36);
            this.MatBtnSave.TabIndex = 483;
            this.MatBtnSave.Text = "Save";
            this.MatBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnSave.UseAccentColor = false;
            this.MatBtnSave.UseVisualStyleBackColor = true;
            this.MatBtnSave.Visible = false;
            this.MatBtnSave.Click += new System.EventHandler(this.MatBtnSave_Click);
            // 
            // FrmOrderActivationRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.MatBtnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderActivationRemarks";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderActivationRemarks";
            this.Load += new System.EventHandler(this.FrmOrderActivationRemarks_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox TextBox1;
        private MaterialSkin.Controls.MaterialButton MatBtnSave;
        private MaterialSkin.Controls.MaterialTextBox txtmatRemarks;
        private MaterialSkin.Controls.MaterialComboBox matcmbType;
    }
}