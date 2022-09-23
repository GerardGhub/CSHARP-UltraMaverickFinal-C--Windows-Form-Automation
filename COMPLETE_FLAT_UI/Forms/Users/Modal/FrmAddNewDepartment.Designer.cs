
namespace ULTRAMAVERICK.Forms.Users.Modal
{
    partial class FrmAddNewDepartment
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtDepartment = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnExecute = new MaterialSkin.Controls.MaterialButton();
            this.MatbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Controls.Add(this.TxtDepartment);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(37, 79);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(542, 226);
            this.materialCard1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(236, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 574;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDepartment.Depth = 0;
            this.TxtDepartment.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtDepartment.Hint = "Department";
            this.TxtDepartment.Location = new System.Drawing.Point(39, 57);
            this.TxtDepartment.Margin = new System.Windows.Forms.Padding(1);
            this.TxtDepartment.MaxLength = 50;
            this.TxtDepartment.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDepartment.Multiline = false;
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(465, 50);
            this.TxtDepartment.TabIndex = 1;
            this.TxtDepartment.Text = "";
            this.TxtDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDepartment_KeyPress);
            // 
            // BtnExecute
            // 
            this.BtnExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExecute.Depth = 0;
            this.BtnExecute.DrawShadows = true;
            this.BtnExecute.HighEmphasis = true;
            this.BtnExecute.Icon = null;
            this.BtnExecute.Location = new System.Drawing.Point(2, 3);
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
            this.MatbtnCancel.Location = new System.Drawing.Point(64, 3);
            this.MatbtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MatbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatbtnCancel.Name = "MatbtnCancel";
            this.MatbtnCancel.Size = new System.Drawing.Size(77, 36);
            this.MatbtnCancel.TabIndex = 574;
            this.MatbtnCancel.Text = "CANCEL";
            this.MatbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatbtnCancel.UseAccentColor = false;
            this.MatbtnCancel.UseVisualStyleBackColor = true;
            this.MatbtnCancel.Click += new System.EventHandler(this.MatbtnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.MatbtnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnExecute, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(435, 316);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 45);
            this.tableLayoutPanel1.TabIndex = 575;
            // 
            // FrmAddNewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewDepartment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewDepartment_FormClosing);
            this.Load += new System.EventHandler(this.AddNewDepartment_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton BtnExecute;
        private MaterialSkin.Controls.MaterialTextBox TxtDepartment;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton MatbtnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}