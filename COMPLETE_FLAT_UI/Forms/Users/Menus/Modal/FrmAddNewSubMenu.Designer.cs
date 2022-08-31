
namespace ULTRAMAVERICK.Forms.Users.Menus.Modal
{
    partial class FrmAddNewSubMenu
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
            this.txtMaterialMenu = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnExecute = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtMaterialMenu);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Controls.Add(this.BtnExecute);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 82);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(542, 229);
            this.materialCard1.TabIndex = 3;
            // 
            // txtMaterialMenu
            // 
            this.txtMaterialMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterialMenu.Depth = 0;
            this.txtMaterialMenu.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaterialMenu.Hint = "Menu";
            this.txtMaterialMenu.Location = new System.Drawing.Point(58, 58);
            this.txtMaterialMenu.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaterialMenu.MaxLength = 50;
            this.txtMaterialMenu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaterialMenu.Multiline = false;
            this.txtMaterialMenu.Name = "txtMaterialMenu";
            this.txtMaterialMenu.Size = new System.Drawing.Size(424, 50);
            this.txtMaterialMenu.TabIndex = 601;
            this.txtMaterialMenu.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(157, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 574;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // BtnExecute
            // 
            this.BtnExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExecute.Depth = 0;
            this.BtnExecute.DrawShadows = true;
            this.BtnExecute.HighEmphasis = true;
            this.BtnExecute.Icon = null;
            this.BtnExecute.Location = new System.Drawing.Point(424, 134);
            this.BtnExecute.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnExecute.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(58, 36);
            this.BtnExecute.TabIndex = 573;
            this.BtnExecute.Text = "SAVE";
            this.BtnExecute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnExecute.UseAccentColor = false;
            this.BtnExecute.UseVisualStyleBackColor = true;
            // 
            // FrmAddNewSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 331);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewSubMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNewSubMenu";
            this.Load += new System.EventHandler(this.FrmAddNewSubMenu_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtMaterialMenu;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton BtnExecute;
    }
}