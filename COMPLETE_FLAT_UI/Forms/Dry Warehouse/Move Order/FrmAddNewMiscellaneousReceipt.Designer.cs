
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    partial class FrmAddNewMiscellaneousReceipt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MatCmbItemCode = new MetroFramework.Controls.MetroComboBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox10 = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            this.materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtItemDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.MatBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox9 = new MaterialSkin.Controls.MaterialTextBox();
            this.MatBtnCommit = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.MatBtnCommit);
            this.groupBox1.Controls.Add(this.materialTextBox9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MatCmbItemCode);
            this.groupBox1.Controls.Add(this.materialTextBox5);
            this.groupBox1.Controls.Add(this.materialTextBox6);
            this.groupBox1.Controls.Add(this.materialTextBox10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.bunifuPrepaDate);
            this.groupBox1.Controls.Add(this.materialTextBox7);
            this.groupBox1.Controls.Add(this.MatTxtItemDescription);
            this.groupBox1.Controls.Add(this.materialTextBox4);
            this.groupBox1.Controls.Add(this.materialTextBox3);
            this.groupBox1.Controls.Add(this.materialTextBox2);
            this.groupBox1.Controls.Add(this.materialTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Material Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 583;
            this.label3.Text = "Item Code";
            // 
            // MatCmbItemCode
            // 
            this.MatCmbItemCode.FormattingEnabled = true;
            this.MatCmbItemCode.ItemHeight = 23;
            this.MatCmbItemCode.Location = new System.Drawing.Point(26, 222);
            this.MatCmbItemCode.Name = "MatCmbItemCode";
            this.MatCmbItemCode.Size = new System.Drawing.Size(270, 29);
            this.MatCmbItemCode.TabIndex = 582;
            this.MatCmbItemCode.UseSelectable = true;
            this.MatCmbItemCode.SelectionChangeCommitted += new System.EventHandler(this.MatCmbItemCode_SelectionChangeCommitted);
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox5.Hint = "Remarks";
            this.materialTextBox5.Location = new System.Drawing.Point(704, 260);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox5.TabIndex = 581;
            this.materialTextBox5.Text = "";
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox6.Hint = "Quantity";
            this.materialTextBox6.Location = new System.Drawing.Point(365, 260);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox6.TabIndex = 580;
            this.materialTextBox6.Text = "";
            // 
            // materialTextBox10
            // 
            this.materialTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox10.Depth = 0;
            this.materialTextBox10.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox10.Hint = "Supplier";
            this.materialTextBox10.Location = new System.Drawing.Point(26, 259);
            this.materialTextBox10.MaxLength = 50;
            this.materialTextBox10.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox10.Multiline = false;
            this.materialTextBox10.Name = "materialTextBox10";
            this.materialTextBox10.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox10.TabIndex = 579;
            this.materialTextBox10.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 578;
            this.label2.Text = "Exp. Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 577;
            this.label1.Text = "Mftg. Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 30);
            this.dateTimePicker1.TabIndex = 576;
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(26, 166);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(270, 30);
            this.bunifuPrepaDate.TabIndex = 575;
            // 
            // materialTextBox7
            // 
            this.materialTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox7.Depth = 0;
            this.materialTextBox7.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox7.Hint = "Category";
            this.materialTextBox7.Location = new System.Drawing.Point(704, 204);
            this.materialTextBox7.MaxLength = 50;
            this.materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox7.Multiline = false;
            this.materialTextBox7.Name = "materialTextBox7";
            this.materialTextBox7.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox7.TabIndex = 9;
            this.materialTextBox7.Text = "";
            // 
            // MatTxtItemDescription
            // 
            this.MatTxtItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtItemDescription.Depth = 0;
            this.MatTxtItemDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtItemDescription.Hint = "Item Description";
            this.MatTxtItemDescription.Location = new System.Drawing.Point(365, 204);
            this.MatTxtItemDescription.MaxLength = 50;
            this.MatTxtItemDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtItemDescription.Multiline = false;
            this.MatTxtItemDescription.Name = "MatTxtItemDescription";
            this.MatTxtItemDescription.Size = new System.Drawing.Size(270, 50);
            this.MatTxtItemDescription.TabIndex = 8;
            this.MatTxtItemDescription.Text = "";
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox4.Hint = "Expiry Days";
            this.materialTextBox4.Location = new System.Drawing.Point(704, 148);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox4.TabIndex = 6;
            this.materialTextBox4.Text = "";
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox3.Hint = "Lot Description";
            this.materialTextBox3.Location = new System.Drawing.Point(704, 92);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox3.TabIndex = 3;
            this.materialTextBox3.Text = "";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox2.Hint = "Lot No.";
            this.materialTextBox2.Location = new System.Drawing.Point(365, 92);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Hint = "Transaction No.";
            this.materialTextBox1.Location = new System.Drawing.Point(26, 91);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(270, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            // 
            // MatBtnSave
            // 
            this.MatBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnSave.Depth = 0;
            this.MatBtnSave.DrawShadows = true;
            this.MatBtnSave.HighEmphasis = true;
            this.MatBtnSave.Icon = null;
            this.MatBtnSave.Location = new System.Drawing.Point(30, 439);
            this.MatBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnSave.Name = "MatBtnSave";
            this.MatBtnSave.Size = new System.Drawing.Size(58, 36);
            this.MatBtnSave.TabIndex = 3;
            this.MatBtnSave.Text = "Save";
            this.MatBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnSave.UseAccentColor = false;
            this.MatBtnSave.UseVisualStyleBackColor = true;
            // 
            // materialTextBox9
            // 
            this.materialTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox9.Depth = 0;
            this.materialTextBox9.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox9.Hint = "Transaction No.";
            this.materialTextBox9.Location = new System.Drawing.Point(27, 34);
            this.materialTextBox9.MaxLength = 50;
            this.materialTextBox9.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox9.Multiline = false;
            this.materialTextBox9.Name = "materialTextBox9";
            this.materialTextBox9.Size = new System.Drawing.Size(838, 50);
            this.materialTextBox9.TabIndex = 584;
            this.materialTextBox9.Text = "";
            // 
            // MatBtnCommit
            // 
            this.MatBtnCommit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnCommit.Depth = 0;
            this.MatBtnCommit.DrawShadows = true;
            this.MatBtnCommit.HighEmphasis = true;
            this.MatBtnCommit.Icon = null;
            this.MatBtnCommit.Location = new System.Drawing.Point(878, 40);
            this.MatBtnCommit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnCommit.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnCommit.Name = "MatBtnCommit";
            this.MatBtnCommit.Size = new System.Drawing.Size(80, 36);
            this.MatBtnCommit.TabIndex = 4;
            this.MatBtnCommit.Text = "COMMIT";
            this.MatBtnCommit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnCommit.UseAccentColor = false;
            this.MatBtnCommit.UseVisualStyleBackColor = true;
            // 
            // FrmAddNewMiscellaneousReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 490);
            this.Controls.Add(this.MatBtnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddNewMiscellaneousReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Receipt";
            this.Load += new System.EventHandler(this.AddNewMiscellaneousReceipt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox MatCmbItemCode;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialTextBox MatTxtItemDescription;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton MatBtnSave;
        private MaterialSkin.Controls.MaterialButton MatBtnCommit;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox9;
    }
}