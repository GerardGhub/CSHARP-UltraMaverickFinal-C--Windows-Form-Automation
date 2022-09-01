
namespace ULTRAMAVERICK.Forms.Users.Menus.Modal
{
    partial class FrmAddNewSubMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnExecute = new MaterialSkin.Controls.MaterialButton();
            this.cboParentMenu = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmname = new MaterialSkin.Controls.MaterialTextBox();
            this.txtfname = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvUserRights = new Guna.UI2.WinForms.Guna2DataGridView();
            this.user_rights_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_rights_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtfname);
            this.materialCard1.Controls.Add(this.txtmname);
            this.materialCard1.Controls.Add(this.cboParentMenu);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Controls.Add(this.BtnExecute);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(542, 338);
            this.materialCard1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(155, 301);
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
            this.BtnExecute.Location = new System.Drawing.Point(434, 274);
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
            // cboParentMenu
            // 
            this.cboParentMenu.FormattingEnabled = true;
            this.cboParentMenu.ItemHeight = 23;
            this.cboParentMenu.Location = new System.Drawing.Point(51, 64);
            this.cboParentMenu.Margin = new System.Windows.Forms.Padding(1);
            this.cboParentMenu.Name = "cboParentMenu";
            this.cboParentMenu.Size = new System.Drawing.Size(442, 29);
            this.cboParentMenu.TabIndex = 576;
            this.cboParentMenu.UseSelectable = true;
            this.cboParentMenu.SelectionChangeCommitted += new System.EventHandler(this.cboParentMenu_SelectionChangeCommitted);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(64, 40);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 19);
            this.materialLabel1.TabIndex = 575;
            this.materialLabel1.Text = "Major Menu";
            // 
            // txtmname
            // 
            this.txtmname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmname.Depth = 0;
            this.txtmname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmname.Hint = "Sub Menu";
            this.txtmname.Location = new System.Drawing.Point(51, 120);
            this.txtmname.Margin = new System.Windows.Forms.Padding(1);
            this.txtmname.MaxLength = 50;
            this.txtmname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmname.Multiline = false;
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(442, 50);
            this.txtmname.TabIndex = 577;
            this.txtmname.Text = "";
            this.txtmname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmname_KeyPress);
            // 
            // txtfname
            // 
            this.txtfname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfname.Depth = 0;
            this.txtfname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtfname.Hint = "Developer Form Name";
            this.txtfname.Location = new System.Drawing.Point(51, 197);
            this.txtfname.Margin = new System.Windows.Forms.Padding(1);
            this.txtfname.MaxLength = 50;
            this.txtfname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfname.Multiline = false;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(442, 50);
            this.txtfname.TabIndex = 578;
            this.txtfname.Text = "";
            this.txtfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfname_KeyPress);
            // 
            // dgvUserRights
            // 
            this.dgvUserRights.AllowUserToAddRows = false;
            this.dgvUserRights.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvUserRights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvUserRights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUserRights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserRights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserRights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvUserRights.ColumnHeadersHeight = 35;
            this.dgvUserRights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_rights_id,
            this.user_rights_name});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserRights.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvUserRights.EnableHeadersVisualStyles = false;
            this.dgvUserRights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.Location = new System.Drawing.Point(642, 106);
            this.dgvUserRights.Name = "dgvUserRights";
            this.dgvUserRights.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserRights.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvUserRights.RowHeadersVisible = false;
            this.dgvUserRights.RowHeadersWidth = 102;
            this.dgvUserRights.RowTemplate.DividerHeight = 5;
            this.dgvUserRights.RowTemplate.Height = 40;
            this.dgvUserRights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserRights.Size = new System.Drawing.Size(327, 316);
            this.dgvUserRights.TabIndex = 580;
            this.dgvUserRights.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUserRights.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUserRights.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvUserRights.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUserRights.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvUserRights.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvUserRights.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUserRights.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvUserRights.ThemeStyle.ReadOnly = true;
            this.dgvUserRights.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserRights.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserRights.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUserRights.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvUserRights.ThemeStyle.RowsStyle.Height = 40;
            this.dgvUserRights.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvUserRights.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserRights.CurrentCellChanged += new System.EventHandler(this.dgvUserRights_CurrentCellChanged);
            // 
            // user_rights_id
            // 
            this.user_rights_id.DataPropertyName = "user_rights_id";
            this.user_rights_id.FillWeight = 99.49239F;
            this.user_rights_id.HeaderText = "ID";
            this.user_rights_id.MinimumWidth = 12;
            this.user_rights_id.Name = "user_rights_id";
            this.user_rights_id.ReadOnly = true;
            this.user_rights_id.Width = 41;
            // 
            // user_rights_name
            // 
            this.user_rights_name.DataPropertyName = "user_rights_name";
            this.user_rights_name.FillWeight = 99.49239F;
            this.user_rights_name.HeaderText = "User Rights";
            this.user_rights_name.MinimumWidth = 12;
            this.user_rights_name.Name = "user_rights_name";
            this.user_rights_name.ReadOnly = true;
            this.user_rights_name.Width = 82;
            // 
            // FrmAddNewSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 443);
            this.Controls.Add(this.dgvUserRights);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewSubMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNewSubMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddNewSubMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddNewSubMenu_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton BtnExecute;
        private MetroFramework.Controls.MetroComboBox cboParentMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtmname;
        private MaterialSkin.Controls.MaterialTextBox txtfname;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_rights_name;
    }
}