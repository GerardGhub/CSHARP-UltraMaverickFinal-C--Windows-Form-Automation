
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
            this.TxtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtLeadMan = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtMobile = new MaterialSkin.Controls.MaterialTextBox();
            this.MatTxtName = new MaterialSkin.Controls.MaterialTextBox();
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
            this.materialCard1.Controls.Add(this.TxtAddress);
            this.materialCard1.Controls.Add(this.TxtLeadMan);
            this.materialCard1.Controls.Add(this.TxtMobile);
            this.materialCard1.Controls.Add(this.MatTxtName);
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
            // TxtAddress
            // 
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAddress.Depth = 0;
            this.TxtAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtAddress.Hint = "Address";
            this.TxtAddress.Location = new System.Drawing.Point(391, 180);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(1);
            this.TxtAddress.MaxLength = 50;
            this.TxtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtAddress.Multiline = false;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(297, 50);
            this.TxtAddress.TabIndex = 6;
            this.TxtAddress.Text = "";
            this.TxtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatAddress_KeyPress);
            // 
            // TxtLeadMan
            // 
            this.TxtLeadMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLeadMan.Depth = 0;
            this.TxtLeadMan.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtLeadMan.Hint = "Lead Man";
            this.TxtLeadMan.Location = new System.Drawing.Point(37, 180);
            this.TxtLeadMan.Margin = new System.Windows.Forms.Padding(1);
            this.TxtLeadMan.MaxLength = 50;
            this.TxtLeadMan.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtLeadMan.Multiline = false;
            this.TxtLeadMan.Name = "TxtLeadMan";
            this.TxtLeadMan.Size = new System.Drawing.Size(297, 50);
            this.TxtLeadMan.TabIndex = 5;
            this.TxtLeadMan.Text = "";
            this.TxtLeadMan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matTxtLeadMan_KeyPress);
            // 
            // TxtMobile
            // 
            this.TxtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMobile.Depth = 0;
            this.TxtMobile.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtMobile.Hint = "Mobile";
            this.TxtMobile.Location = new System.Drawing.Point(389, 106);
            this.TxtMobile.Margin = new System.Windows.Forms.Padding(1);
            this.TxtMobile.MaxLength = 50;
            this.TxtMobile.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtMobile.Multiline = false;
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(297, 50);
            this.TxtMobile.TabIndex = 4;
            this.TxtMobile.Text = "";
            // 
            // MatTxtName
            // 
            this.MatTxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtName.Depth = 0;
            this.MatTxtName.Font = new System.Drawing.Font("Roboto", 12F);
            this.MatTxtName.Hint = "Name";
            this.MatTxtName.Location = new System.Drawing.Point(32, 33);
            this.MatTxtName.Margin = new System.Windows.Forms.Padding(1);
            this.MatTxtName.MaxLength = 50;
            this.MatTxtName.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtName.Multiline = false;
            this.MatTxtName.Name = "MatTxtName";
            this.MatTxtName.Size = new System.Drawing.Size(297, 50);
            this.MatTxtName.TabIndex = 1;
            this.MatTxtName.Text = "";
            this.MatTxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatTxtName_KeyPress);
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
        private MaterialSkin.Controls.MaterialTextBox MatTxtName;
        private MaterialSkin.Controls.MaterialTextBox TxtAddress;
        private MaterialSkin.Controls.MaterialTextBox TxtLeadMan;
        private MaterialSkin.Controls.MaterialTextBox TxtMobile;
        private MetroFramework.Controls.MetroComboBox metroCmbType;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroCmbCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}