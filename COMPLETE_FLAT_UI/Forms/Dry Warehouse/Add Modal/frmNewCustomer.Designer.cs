
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Add_Modal
{
    partial class frmNewCustomer
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
            this.metroCmbCompany = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroCmbType = new MetroFramework.Controls.MetroComboBox();
            this.txtMatAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.matTxtLeadMan = new MaterialSkin.Controls.MaterialTextBox();
            this.txtmatMobile = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatName = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.metroCmbCompany);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.metroCmbType);
            this.materialCard1.Controls.Add(this.txtMatAddress);
            this.materialCard1.Controls.Add(this.matTxtLeadMan);
            this.materialCard1.Controls.Add(this.txtmatMobile);
            this.materialCard1.Controls.Add(this.txtMatName);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 93);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(721, 275);
            this.materialCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 596;
            this.label1.Text = "Company:";
            // 
            // metroCmbCompany
            // 
            this.metroCmbCompany.FormattingEnabled = true;
            this.metroCmbCompany.ItemHeight = 23;
            this.metroCmbCompany.Items.AddRange(new object[] {
            "Red Dragon Farm",
            "Pink Dragon Farm"});
            this.metroCmbCompany.Location = new System.Drawing.Point(34, 125);
            this.metroCmbCompany.Name = "metroCmbCompany";
            this.metroCmbCompany.Size = new System.Drawing.Size(297, 29);
            this.metroCmbCompany.TabIndex = 595;
            this.metroCmbCompany.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(391, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 594;
            this.label2.Text = "Type:";
            // 
            // metroCmbType
            // 
            this.metroCmbType.FormattingEnabled = true;
            this.metroCmbType.ItemHeight = 23;
            this.metroCmbType.Items.AddRange(new object[] {
            "Poultry",
            "Swine"});
            this.metroCmbType.Location = new System.Drawing.Point(391, 51);
            this.metroCmbType.Name = "metroCmbType";
            this.metroCmbType.Size = new System.Drawing.Size(297, 29);
            this.metroCmbType.TabIndex = 7;
            this.metroCmbType.UseSelectable = true;
            // 
            // txtMatAddress
            // 
            this.txtMatAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatAddress.Depth = 0;
            this.txtMatAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatAddress.Hint = "Address";
            this.txtMatAddress.Location = new System.Drawing.Point(391, 180);
            this.txtMatAddress.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatAddress.MaxLength = 50;
            this.txtMatAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatAddress.Multiline = false;
            this.txtMatAddress.Name = "txtMatAddress";
            this.txtMatAddress.Size = new System.Drawing.Size(297, 50);
            this.txtMatAddress.TabIndex = 6;
            this.txtMatAddress.Text = "";
            // 
            // matTxtLeadMan
            // 
            this.matTxtLeadMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matTxtLeadMan.Depth = 0;
            this.matTxtLeadMan.Font = new System.Drawing.Font("Roboto", 12F);
            this.matTxtLeadMan.Hint = "Lead Man";
            this.matTxtLeadMan.Location = new System.Drawing.Point(34, 180);
            this.matTxtLeadMan.Margin = new System.Windows.Forms.Padding(1);
            this.matTxtLeadMan.MaxLength = 50;
            this.matTxtLeadMan.MouseState = MaterialSkin.MouseState.OUT;
            this.matTxtLeadMan.Multiline = false;
            this.matTxtLeadMan.Name = "matTxtLeadMan";
            this.matTxtLeadMan.Size = new System.Drawing.Size(297, 50);
            this.matTxtLeadMan.TabIndex = 5;
            this.matTxtLeadMan.Text = "";
            // 
            // txtmatMobile
            // 
            this.txtmatMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatMobile.Depth = 0;
            this.txtmatMobile.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatMobile.Hint = "Mobile";
            this.txtmatMobile.Location = new System.Drawing.Point(389, 106);
            this.txtmatMobile.Margin = new System.Windows.Forms.Padding(1);
            this.txtmatMobile.MaxLength = 50;
            this.txtmatMobile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatMobile.Multiline = false;
            this.txtmatMobile.Name = "txtmatMobile";
            this.txtmatMobile.Size = new System.Drawing.Size(297, 50);
            this.txtmatMobile.TabIndex = 4;
            this.txtmatMobile.Text = "";
            // 
            // txtMatName
            // 
            this.txtMatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatName.Depth = 0;
            this.txtMatName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMatName.Hint = "Name";
            this.txtMatName.Location = new System.Drawing.Point(32, 33);
            this.txtMatName.Margin = new System.Windows.Forms.Padding(1);
            this.txtMatName.MaxLength = 50;
            this.txtMatName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatName.Multiline = false;
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.Size = new System.Drawing.Size(297, 50);
            this.txtMatName.TabIndex = 1;
            this.txtMatName.Text = "";
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(703, 387);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 475;
            this.matBtnSave.Text = "Save";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(363, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 477;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmNewCustomer_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MaterialSkin.Controls.MaterialTextBox txtMatName;
        private MaterialSkin.Controls.MaterialTextBox txtMatAddress;
        private MaterialSkin.Controls.MaterialTextBox matTxtLeadMan;
        private MaterialSkin.Controls.MaterialTextBox txtmatMobile;
        private MetroFramework.Controls.MetroComboBox metroCmbType;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroCmbCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}