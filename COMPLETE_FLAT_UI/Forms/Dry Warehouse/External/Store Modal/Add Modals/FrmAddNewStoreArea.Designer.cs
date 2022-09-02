
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmAddNewArea
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbStoreArea = new MetroFramework.Controls.MetroComboBox();
            this.cmbStoreRoute = new MetroFramework.Controls.MetroComboBox();
            this.MattxtStoreArea = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtStoreCode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.cmbStoreArea);
            this.materialCard1.Controls.Add(this.cmbStoreRoute);
            this.materialCard1.Controls.Add(this.MattxtStoreArea);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(33, 92);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(495, 152);
            this.materialCard1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(51, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Store Route";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(51, 229);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Store Area";
            // 
            // cmbStoreArea
            // 
            this.cmbStoreArea.FormattingEnabled = true;
            this.cmbStoreArea.ItemHeight = 23;
            this.cmbStoreArea.Location = new System.Drawing.Point(49, 251);
            this.cmbStoreArea.Name = "cmbStoreArea";
            this.cmbStoreArea.Size = new System.Drawing.Size(401, 29);
            this.cmbStoreArea.TabIndex = 3;
            this.cmbStoreArea.UseSelectable = true;
            // 
            // cmbStoreRoute
            // 
            this.cmbStoreRoute.FormattingEnabled = true;
            this.cmbStoreRoute.ItemHeight = 23;
            this.cmbStoreRoute.Location = new System.Drawing.Point(49, 175);
            this.cmbStoreRoute.Name = "cmbStoreRoute";
            this.cmbStoreRoute.Size = new System.Drawing.Size(401, 29);
            this.cmbStoreRoute.TabIndex = 2;
            this.cmbStoreRoute.UseSelectable = true;
            // 
            // MattxtStoreArea
            // 
            this.MattxtStoreArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MattxtStoreArea.Depth = 0;
            this.MattxtStoreArea.Font = new System.Drawing.Font("Roboto", 12F);
            this.MattxtStoreArea.Hint = "Store Area";
            this.MattxtStoreArea.Location = new System.Drawing.Point(49, 56);
            this.MattxtStoreArea.MaxLength = 50;
            this.MattxtStoreArea.MouseState = MaterialSkin.MouseState.OUT;
            this.MattxtStoreArea.Multiline = false;
            this.MattxtStoreArea.Name = "MattxtStoreArea";
            this.MattxtStoreArea.Size = new System.Drawing.Size(401, 50);
            this.MattxtStoreArea.TabIndex = 0;
            this.MattxtStoreArea.Text = "";
            this.MattxtStoreArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtStoreName_KeyPress);
            // 
            // mattxtStoreCode
            // 
            this.mattxtStoreCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtStoreCode.Depth = 0;
            this.mattxtStoreCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtStoreCode.Hint = "Store Code";
            this.mattxtStoreCode.Location = new System.Drawing.Point(561, 39);
            this.mattxtStoreCode.MaxLength = 50;
            this.mattxtStoreCode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtStoreCode.Multiline = false;
            this.mattxtStoreCode.Name = "mattxtStoreCode";
            this.mattxtStoreCode.Size = new System.Drawing.Size(97, 50);
            this.mattxtStoreCode.TabIndex = 1;
            this.mattxtStoreCode.Text = "";
            this.mattxtStoreCode.Visible = false;
            this.mattxtStoreCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtStoreCode_KeyPress);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(470, 264);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(58, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Save";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(209, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 472;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmAddNewArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 313);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.mattxtStoreCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewArea";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Area";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewArea_FormClosed);
            this.Load += new System.EventHandler(this.frmAddNewArea_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox MattxtStoreArea;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox cmbStoreArea;
        private MetroFramework.Controls.MetroComboBox cmbStoreRoute;
        private MaterialSkin.Controls.MaterialTextBox mattxtStoreCode;
    }
}