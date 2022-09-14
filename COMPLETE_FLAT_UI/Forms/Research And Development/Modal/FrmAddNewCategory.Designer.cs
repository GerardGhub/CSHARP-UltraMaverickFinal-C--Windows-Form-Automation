
namespace ULTRAMAVERICK.Forms.Research_And_Development.Modal
{
    partial class FrmAddNewCategory
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
            this.matRadioNotExpirable = new MaterialSkin.Controls.MaterialRadioButton();
            this.matRadioExpirable = new MaterialSkin.Controls.MaterialRadioButton();
            this.TxtSubCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.matRadioNotExpirable);
            this.materialCard1.Controls.Add(this.matRadioExpirable);
            this.materialCard1.Controls.Add(this.TxtSubCategory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(33, 92);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(495, 200);
            this.materialCard1.TabIndex = 482;
            // 
            // matRadioNotExpirable
            // 
            this.matRadioNotExpirable.AutoSize = true;
            this.matRadioNotExpirable.Depth = 0;
            this.matRadioNotExpirable.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRadioNotExpirable.Location = new System.Drawing.Point(302, 109);
            this.matRadioNotExpirable.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioNotExpirable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioNotExpirable.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioNotExpirable.Name = "matRadioNotExpirable";
            this.matRadioNotExpirable.Ripple = true;
            this.matRadioNotExpirable.Size = new System.Drawing.Size(141, 37);
            this.matRadioNotExpirable.TabIndex = 582;
            this.matRadioNotExpirable.TabStop = true;
            this.matRadioNotExpirable.Text = "Non - Expirable";
            this.matRadioNotExpirable.UseVisualStyleBackColor = true;
            this.matRadioNotExpirable.CheckedChanged += new System.EventHandler(this.matRadioNotExpirable_CheckedChanged);
            // 
            // matRadioExpirable
            // 
            this.matRadioExpirable.AutoSize = true;
            this.matRadioExpirable.Depth = 0;
            this.matRadioExpirable.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matRadioExpirable.Location = new System.Drawing.Point(42, 109);
            this.matRadioExpirable.Margin = new System.Windows.Forms.Padding(0);
            this.matRadioExpirable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matRadioExpirable.MouseState = MaterialSkin.MouseState.HOVER;
            this.matRadioExpirable.Name = "matRadioExpirable";
            this.matRadioExpirable.Ripple = true;
            this.matRadioExpirable.Size = new System.Drawing.Size(100, 37);
            this.matRadioExpirable.TabIndex = 581;
            this.matRadioExpirable.TabStop = true;
            this.matRadioExpirable.Text = "Expirable";
            this.matRadioExpirable.UseVisualStyleBackColor = true;
            this.matRadioExpirable.CheckedChanged += new System.EventHandler(this.matRadioExpirable_CheckedChanged);
            // 
            // TxtSubCategory
            // 
            this.TxtSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSubCategory.Depth = 0;
            this.TxtSubCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtSubCategory.Hint = "Category";
            this.TxtSubCategory.Location = new System.Drawing.Point(42, 39);
            this.TxtSubCategory.MaxLength = 50;
            this.TxtSubCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtSubCategory.Multiline = false;
            this.TxtSubCategory.Name = "TxtSubCategory";
            this.TxtSubCategory.Size = new System.Drawing.Size(401, 50);
            this.TxtSubCategory.TabIndex = 0;
            this.TxtSubCategory.Text = "";
            this.TxtSubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSubCategory_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 484;
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
            this.materialButton1.Location = new System.Drawing.Point(469, 309);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(58, 36);
            this.materialButton1.TabIndex = 483;
            this.materialButton1.Text = "Save";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // AddNewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewCategory";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewCategory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewCategory_FormClosed);
            this.Load += new System.EventHandler(this.AddNewCategory_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox TxtSubCategory;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialRadioButton matRadioNotExpirable;
        private MaterialSkin.Controls.MaterialRadioButton matRadioExpirable;
    }
}