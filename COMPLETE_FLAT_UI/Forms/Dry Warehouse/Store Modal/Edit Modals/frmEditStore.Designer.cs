
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    partial class frmEditStore
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
            this.mattxtStoreName = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtStoreCode = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cmbStoreRoute = new System.Windows.Forms.ComboBox();
            this.cmbStoreArea = new System.Windows.Forms.ComboBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cmbStoreArea);
            this.materialCard1.Controls.Add(this.cmbStoreRoute);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.mattxtStoreName);
            this.materialCard1.Controls.Add(this.mattxtStoreCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(34, 75);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(495, 488);
            this.materialCard1.TabIndex = 480;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(43, 352);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Store Area";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(42, 255);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Store Route";
            // 
            // mattxtStoreName
            // 
            this.mattxtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtStoreName.Depth = 0;
            this.mattxtStoreName.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtStoreName.Hint = "Store Name";
            this.mattxtStoreName.Location = new System.Drawing.Point(40, 163);
            this.mattxtStoreName.MaxLength = 50;
            this.mattxtStoreName.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtStoreName.Multiline = false;
            this.mattxtStoreName.Name = "mattxtStoreName";
            this.mattxtStoreName.Size = new System.Drawing.Size(401, 50);
            this.mattxtStoreName.TabIndex = 1;
            this.mattxtStoreName.Text = "";
            // 
            // mattxtStoreCode
            // 
            this.mattxtStoreCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtStoreCode.Depth = 0;
            this.mattxtStoreCode.Enabled = false;
            this.mattxtStoreCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtStoreCode.Hint = "Store Code";
            this.mattxtStoreCode.Location = new System.Drawing.Point(40, 60);
            this.mattxtStoreCode.MaxLength = 50;
            this.mattxtStoreCode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtStoreCode.Multiline = false;
            this.mattxtStoreCode.Name = "mattxtStoreCode";
            this.mattxtStoreCode.Size = new System.Drawing.Size(401, 50);
            this.mattxtStoreCode.TabIndex = 0;
            this.mattxtStoreCode.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 483;
            this.label1.Text = "Label for Two way Binding Only : Dont remove Fucker";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Crimson;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 598);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 482;
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
            this.materialButton1.Location = new System.Drawing.Point(461, 580);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(58, 36);
            this.materialButton1.TabIndex = 481;
            this.materialButton1.Text = "Save";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // cmbStoreRoute
            // 
            this.cmbStoreRoute.FormattingEnabled = true;
            this.cmbStoreRoute.Location = new System.Drawing.Point(40, 277);
            this.cmbStoreRoute.Name = "cmbStoreRoute";
            this.cmbStoreRoute.Size = new System.Drawing.Size(401, 21);
            this.cmbStoreRoute.TabIndex = 6;
            this.cmbStoreRoute.Click += new System.EventHandler(this.cmbStoreRoute_Click);
            // 
            // cmbStoreArea
            // 
            this.cmbStoreArea.FormattingEnabled = true;
            this.cmbStoreArea.Location = new System.Drawing.Point(40, 374);
            this.cmbStoreArea.Name = "cmbStoreArea";
            this.cmbStoreArea.Size = new System.Drawing.Size(401, 21);
            this.cmbStoreArea.TabIndex = 7;
            this.cmbStoreArea.Click += new System.EventHandler(this.cmbStoreArea_Click);
            // 
            // frmEditStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 642);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditStore";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Store Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditStore_FormClosed);
            this.Load += new System.EventHandler(this.frmEditStore_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox mattxtStoreName;
        private MaterialSkin.Controls.MaterialTextBox mattxtStoreCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ComboBox cmbStoreRoute;
        private System.Windows.Forms.ComboBox cmbStoreArea;
    }
}