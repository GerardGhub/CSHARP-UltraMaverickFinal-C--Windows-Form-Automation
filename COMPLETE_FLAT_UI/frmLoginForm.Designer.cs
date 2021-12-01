
namespace COMPLETE_FLAT_UI
{
    partial class frmLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtMaterialUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.txtMaterialPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.MaterialLogin = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(174, 94);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 19);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(176, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 19);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(51, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 486;
            this.btnLogin.Text = "&Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMaterialUsername
            // 
            this.txtMaterialUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterialUsername.Depth = 0;
            this.txtMaterialUsername.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialUsername.Hint = "Username";
            this.txtMaterialUsername.Location = new System.Drawing.Point(203, 48);
            this.txtMaterialUsername.MaxLength = 50;
            this.txtMaterialUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaterialUsername.Multiline = false;
            this.txtMaterialUsername.Name = "txtMaterialUsername";
            this.txtMaterialUsername.Size = new System.Drawing.Size(246, 50);
            this.txtMaterialUsername.TabIndex = 487;
            this.txtMaterialUsername.Text = "";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.txtMaterialPassword);
            this.materialCard3.Controls.Add(this.MaterialLogin);
            this.materialCard3.Controls.Add(this.txtMaterialUsername);
            this.materialCard3.Controls.Add(this.pictureBox1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(10, 89);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(486, 241);
            this.materialCard3.TabIndex = 488;
            // 
            // txtMaterialPassword
            // 
            this.txtMaterialPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterialPassword.Depth = 0;
            this.txtMaterialPassword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialPassword.Hint = "Password";
            this.txtMaterialPassword.Location = new System.Drawing.Point(203, 120);
            this.txtMaterialPassword.MaxLength = 50;
            this.txtMaterialPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaterialPassword.Multiline = false;
            this.txtMaterialPassword.Name = "txtMaterialPassword";
            this.txtMaterialPassword.Password = true;
            this.txtMaterialPassword.Size = new System.Drawing.Size(246, 50);
            this.txtMaterialPassword.TabIndex = 488;
            this.txtMaterialPassword.Text = "";
            this.txtMaterialPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaterialPassword_KeyDown);
            // 
            // MaterialLogin
            // 
            this.MaterialLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialLogin.Depth = 0;
            this.MaterialLogin.DrawShadows = true;
            this.MaterialLogin.HighEmphasis = true;
            this.MaterialLogin.Icon = null;
            this.MaterialLogin.Location = new System.Drawing.Point(388, 197);
            this.MaterialLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialLogin.Name = "MaterialLogin";
            this.MaterialLogin.Size = new System.Drawing.Size(68, 36);
            this.MaterialLogin.TabIndex = 2;
            this.MaterialLogin.Text = "LOG IN";
            this.MaterialLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MaterialLogin.UseAccentColor = false;
            this.MaterialLogin.UseVisualStyleBackColor = true;
            this.MaterialLogin.Click += new System.EventHandler(this.MaterialLogin_Click);
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 360);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frmLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.Button btnLogin;
        private MaterialSkin.Controls.MaterialTextBox txtMaterialUsername;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton MaterialLogin;
        private MaterialSkin.Controls.MaterialTextBox txtMaterialPassword;
    }
}