
namespace ULTRAMAVERICK.Forms.Users.Modal
{
    partial class AddNewUnit
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
            this.CbDepartment = new System.Windows.Forms.ComboBox();
            this.TxtDepartmentUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.materialCard1.Controls.Add(this.CbDepartment);
            this.materialCard1.Controls.Add(this.TxtDepartmentUnit);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 80);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(542, 210);
            this.materialCard1.TabIndex = 1;
            this.materialCard1.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // CbDepartment
            // 
            this.CbDepartment.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDepartment.FormattingEnabled = true;
            this.CbDepartment.Location = new System.Drawing.Point(58, 38);
            this.CbDepartment.Name = "CbDepartment";
            this.CbDepartment.Size = new System.Drawing.Size(424, 31);
            this.CbDepartment.TabIndex = 602;
            this.CbDepartment.SelectionChangeCommitted += new System.EventHandler(this.CbDepartment_SelectionChangeCommitted);
            this.CbDepartment.SelectedValueChanged += new System.EventHandler(this.CbDepartment_SelectedValueChanged);
            this.CbDepartment.Click += new System.EventHandler(this.CbDepartment_Click);
            // 
            // TxtDepartmentUnit
            // 
            this.TxtDepartmentUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDepartmentUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDepartmentUnit.Depth = 0;
            this.TxtDepartmentUnit.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtDepartmentUnit.Hint = "Department Unit";
            this.TxtDepartmentUnit.Location = new System.Drawing.Point(58, 99);
            this.TxtDepartmentUnit.Margin = new System.Windows.Forms.Padding(1);
            this.TxtDepartmentUnit.MaxLength = 50;
            this.TxtDepartmentUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDepartmentUnit.Multiline = false;
            this.TxtDepartmentUnit.Name = "TxtDepartmentUnit";
            this.TxtDepartmentUnit.Size = new System.Drawing.Size(424, 50);
            this.TxtDepartmentUnit.TabIndex = 601;
            this.TxtDepartmentUnit.Text = "";
            this.TxtDepartmentUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDepartmentUnit_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 599;
            this.label1.Text = "Department:";
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
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.BtnExecute.Size = new System.Drawing.Size(58, 28);
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
            this.MatbtnCancel.Size = new System.Drawing.Size(77, 28);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(436, 307);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 34);
            this.tableLayoutPanel1.TabIndex = 575;
            // 
            // AddNewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewUnit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewDepartmentUnit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewDepartmentUnit_FormClosing);
            this.Load += new System.EventHandler(this.AddNewDepartmentUnit_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton BtnExecute;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox TxtDepartmentUnit;
        private MaterialSkin.Controls.MaterialButton MatbtnCancel;
        private System.Windows.Forms.ComboBox CbDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}