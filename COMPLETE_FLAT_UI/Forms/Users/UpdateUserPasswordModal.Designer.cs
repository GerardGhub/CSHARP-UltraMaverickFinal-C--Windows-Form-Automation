
namespace ULTRAMAVERICK.Forms.Users
{
    partial class UpdateUserPasswordModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserPasswordModal));
            this.PcUser = new System.Windows.Forms.PictureBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.PcUser)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PcUser
            // 
            this.PcUser.Image = ((System.Drawing.Image)(resources.GetObject("PcUser.Image")));
            this.PcUser.Location = new System.Drawing.Point(177, 51);
            this.PcUser.Name = "PcUser";
            this.PcUser.Size = new System.Drawing.Size(388, 308);
            this.PcUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcUser.TabIndex = 0;
            this.PcUser.TabStop = false;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Hint = "Name";
            this.materialTextBox1.Location = new System.Drawing.Point(77, 474);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(580, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "Gerard Singian";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.PcUser);
            this.materialCard1.Controls.Add(this.materialTextBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(58, 236);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(735, 777);
            this.materialCard1.TabIndex = 2;
            // 
            // UpdateUserPasswordModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 1471);
            this.Controls.Add(this.materialCard1);
            this.Name = "UpdateUserPasswordModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Set Up";
            this.Load += new System.EventHandler(this.UpdateUserPasswordModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcUser)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PcUser;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}