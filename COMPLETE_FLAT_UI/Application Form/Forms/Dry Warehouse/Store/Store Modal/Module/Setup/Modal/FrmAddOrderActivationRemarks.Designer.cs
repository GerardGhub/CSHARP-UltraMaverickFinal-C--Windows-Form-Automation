﻿
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
            this.MatcmbType = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtmatRemarks = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.MatBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.MatBtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.MatcmbType);
            this.materialCard1.Controls.Add(this.TxtmatRemarks);
            this.materialCard1.Controls.Add(this.TextBox1);
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
            // MatcmbType
            // 
            this.MatcmbType.AutoResize = false;
            this.MatcmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MatcmbType.Depth = 0;
            this.MatcmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MatcmbType.DropDownHeight = 174;
            this.MatcmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatcmbType.DropDownWidth = 121;
            this.MatcmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MatcmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MatcmbType.FormattingEnabled = true;
            this.MatcmbType.Hint = "Type";
            this.MatcmbType.IntegralHeight = false;
            this.MatcmbType.ItemHeight = 43;
            this.MatcmbType.Items.AddRange(new object[] {
            "CANCEL",
            "RETURN"});
            this.MatcmbType.Location = new System.Drawing.Point(53, 32);
            this.MatcmbType.MaxDropDownItems = 4;
            this.MatcmbType.MouseState = MaterialSkin.MouseState.OUT;
            this.MatcmbType.Name = "MatcmbType";
            this.MatcmbType.Size = new System.Drawing.Size(386, 49);
            this.MatcmbType.TabIndex = 602;
            this.MatcmbType.SelectionChangeCommitted += new System.EventHandler(this.MatcmbType_SelectionChangeCommitted);
            // 
            // TxtmatRemarks
            // 
            this.TxtmatRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtmatRemarks.Depth = 0;
            this.TxtmatRemarks.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtmatRemarks.Hint = "Remarks";
            this.TxtmatRemarks.Location = new System.Drawing.Point(53, 119);
            this.TxtmatRemarks.Margin = new System.Windows.Forms.Padding(1);
            this.TxtmatRemarks.MaxLength = 50;
            this.TxtmatRemarks.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtmatRemarks.Multiline = false;
            this.TxtmatRemarks.Name = "TxtmatRemarks";
            this.TxtmatRemarks.Size = new System.Drawing.Size(386, 50);
            this.TxtmatRemarks.TabIndex = 1;
            this.TxtmatRemarks.Text = "";
            this.TxtmatRemarks.TextChanged += new System.EventHandler(this.TxtmatRemarks_TextChanged);
            this.TxtmatRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatRemarks_KeyPress);
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(219, 6);
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
            this.MatBtnSave.Enabled = false;
            this.MatBtnSave.HighEmphasis = true;
            this.MatBtnSave.Icon = null;
            this.MatBtnSave.Location = new System.Drawing.Point(4, 6);
            this.MatBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnSave.Name = "MatBtnSave";
            this.MatBtnSave.Size = new System.Drawing.Size(58, 35);
            this.MatBtnSave.TabIndex = 483;
            this.MatBtnSave.Text = "Save";
            this.MatBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnSave.UseAccentColor = false;
            this.MatBtnSave.UseVisualStyleBackColor = true;
            this.MatBtnSave.Click += new System.EventHandler(this.MatBtnSave_Click);
            // 
            // MatBtnCancel
            // 
            this.MatBtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnCancel.Depth = 0;
            this.MatBtnCancel.DrawShadows = true;
            this.MatBtnCancel.HighEmphasis = true;
            this.MatBtnCancel.Icon = null;
            this.MatBtnCancel.Location = new System.Drawing.Point(70, 6);
            this.MatBtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnCancel.Name = "MatBtnCancel";
            this.MatBtnCancel.Size = new System.Drawing.Size(77, 35);
            this.MatBtnCancel.TabIndex = 485;
            this.MatBtnCancel.Text = "CANCEL";
            this.MatBtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnCancel.UseAccentColor = false;
            this.MatBtnCancel.UseVisualStyleBackColor = true;
            this.MatBtnCancel.Click += new System.EventHandler(this.MatBtnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.MatBtnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MatBtnSave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(375, 299);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 47);
            this.tableLayoutPanel1.TabIndex = 486;
            // 
            // FrmOrderActivationRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderActivationRemarks";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderActivationRemarks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrderActivationRemarks_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrderActivationRemarks_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox TextBox1;
        private MaterialSkin.Controls.MaterialButton MatBtnSave;
        private MaterialSkin.Controls.MaterialTextBox TxtmatRemarks;
        private MaterialSkin.Controls.MaterialComboBox MatcmbType;
        private MaterialSkin.Controls.MaterialButton MatBtnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}