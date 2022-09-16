
namespace ULTRAMAVERICK.Forms.Users.Modal
{
    partial class FrmAddNewPosition
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
            this.CboUnit = new System.Windows.Forms.ComboBox();
            this.TxtPosition = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnExecute = new MaterialSkin.Controls.MaterialButton();
            this.MatbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CboUnit);
            this.materialCard1.Controls.Add(this.TxtPosition);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(542, 215);
            this.materialCard1.TabIndex = 2;
            // 
            // CboUnit
            // 
            this.CboUnit.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboUnit.FormattingEnabled = true;
            this.CboUnit.Location = new System.Drawing.Point(58, 39);
            this.CboUnit.Name = "CboUnit";
            this.CboUnit.Size = new System.Drawing.Size(424, 31);
            this.CboUnit.TabIndex = 603;
            this.CboUnit.SelectionChangeCommitted += new System.EventHandler(this.CbDepartment_SelectionChangeCommitted);
            this.CboUnit.Click += new System.EventHandler(this.CbDepartment_Click);
            // 
            // TxtPosition
            // 
            this.TxtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPosition.Depth = 0;
            this.TxtPosition.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtPosition.Hint = "Position";
            this.TxtPosition.Location = new System.Drawing.Point(58, 99);
            this.TxtPosition.Margin = new System.Windows.Forms.Padding(1);
            this.TxtPosition.MaxLength = 50;
            this.TxtPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPosition.Multiline = false;
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(424, 50);
            this.TxtPosition.TabIndex = 601;
            this.TxtPosition.Text = "";
            this.TxtPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPosition_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 599;
            this.label1.Text = "Unit:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 574;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExecute.Depth = 0;
            this.BtnExecute.DrawShadows = true;
            this.BtnExecute.HighEmphasis = true;
            this.BtnExecute.Icon = null;
            this.BtnExecute.Location = new System.Drawing.Point(40, 307);
            this.BtnExecute.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnExecute.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(58, 36);
            this.BtnExecute.TabIndex = 573;
            this.BtnExecute.Text = "SAVE";
            this.BtnExecute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnExecute.UseAccentColor = false;
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // MatbtnCancel
            // 
            this.MatbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatbtnCancel.Depth = 0;
            this.MatbtnCancel.DrawShadows = true;
            this.MatbtnCancel.HighEmphasis = true;
            this.MatbtnCancel.Icon = null;
            this.MatbtnCancel.Location = new System.Drawing.Point(505, 307);
            this.MatbtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MatbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatbtnCancel.Name = "MatbtnCancel";
            this.MatbtnCancel.Size = new System.Drawing.Size(77, 36);
            this.MatbtnCancel.TabIndex = 575;
            this.MatbtnCancel.Text = "CANCEL";
            this.MatbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatbtnCancel.UseAccentColor = false;
            this.MatbtnCancel.UseVisualStyleBackColor = true;
            this.MatbtnCancel.Click += new System.EventHandler(this.MatbtnCancel_Click);
            // 
            // FrmAddNewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 355);
            this.Controls.Add(this.MatbtnCancel);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.BtnExecute);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewPosition";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNewPosition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddNewPosition_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddNewPosition_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox TxtPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton BtnExecute;
        private MaterialSkin.Controls.MaterialButton MatbtnCancel;
        private System.Windows.Forms.ComboBox CboUnit;
    }
}