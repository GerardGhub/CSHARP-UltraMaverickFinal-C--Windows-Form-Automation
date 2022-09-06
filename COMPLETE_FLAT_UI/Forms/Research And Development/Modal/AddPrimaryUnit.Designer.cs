
namespace ULTRAMAVERICK.Forms.Research_And_Development.Modal
{
    partial class AddPrimaryUnit
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
            this.TxtMatPrimaryUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.TxtMatPrimaryUnit);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(33, 87);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(495, 200);
            this.materialCard1.TabIndex = 479;
            // 
            // TxtMatPrimaryUnit
            // 
            this.TxtMatPrimaryUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMatPrimaryUnit.Depth = 0;
            this.TxtMatPrimaryUnit.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtMatPrimaryUnit.Hint = "Primary Unit";
            this.TxtMatPrimaryUnit.Location = new System.Drawing.Point(42, 72);
            this.TxtMatPrimaryUnit.MaxLength = 50;
            this.TxtMatPrimaryUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtMatPrimaryUnit.Multiline = false;
            this.TxtMatPrimaryUnit.Name = "TxtMatPrimaryUnit";
            this.TxtMatPrimaryUnit.Size = new System.Drawing.Size(401, 50);
            this.TxtMatPrimaryUnit.TabIndex = 0;
            this.TxtMatPrimaryUnit.Text = "";
            this.TxtMatPrimaryUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMatPrimaryUnit_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 481;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(469, 304);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(58, 36);
            this.materialButton1.TabIndex = 480;
            this.materialButton1.Text = "Save";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // AddPrimaryUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPrimaryUnit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPrimaryUnit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPrimaryUnit_FormClosed);
            this.Load += new System.EventHandler(this.AddPrimaryUnit_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox TxtMatPrimaryUnit;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}