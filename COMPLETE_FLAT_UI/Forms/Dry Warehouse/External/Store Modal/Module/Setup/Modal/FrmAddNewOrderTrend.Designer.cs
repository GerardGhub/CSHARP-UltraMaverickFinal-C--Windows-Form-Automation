
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Setup.Modal
{
    partial class FrmAddNewOrderTrend
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
            this.TxtmatAverageqty = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtmatavgdescription = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.MatBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.TxtmatAverageqty);
            this.materialCard1.Controls.Add(this.Txtmatavgdescription);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(34, 87);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(495, 200);
            this.materialCard1.TabIndex = 479;
            // 
            // TxtmatAverageqty
            // 
            this.TxtmatAverageqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtmatAverageqty.Depth = 0;
            this.TxtmatAverageqty.Font = new System.Drawing.Font("Roboto", 12F);
            this.TxtmatAverageqty.Hint = "Average Quantity";
            this.TxtmatAverageqty.Location = new System.Drawing.Point(42, 112);
            this.TxtmatAverageqty.MaxLength = 50;
            this.TxtmatAverageqty.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtmatAverageqty.Multiline = false;
            this.TxtmatAverageqty.Name = "TxtmatAverageqty";
            this.TxtmatAverageqty.Size = new System.Drawing.Size(401, 50);
            this.TxtmatAverageqty.TabIndex = 1;
            this.TxtmatAverageqty.Text = "";
            this.TxtmatAverageqty.TextChanged += new System.EventHandler(this.TxtmatAverageqty_TextChanged);
            this.TxtmatAverageqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtmatAverageqty_KeyPress);
            // 
            // Txtmatavgdescription
            // 
            this.Txtmatavgdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtmatavgdescription.Depth = 0;
            this.Txtmatavgdescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.Txtmatavgdescription.Hint = "Average Description";
            this.Txtmatavgdescription.Location = new System.Drawing.Point(42, 28);
            this.Txtmatavgdescription.MaxLength = 50;
            this.Txtmatavgdescription.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtmatavgdescription.Multiline = false;
            this.Txtmatavgdescription.Name = "Txtmatavgdescription";
            this.Txtmatavgdescription.Size = new System.Drawing.Size(401, 50);
            this.Txtmatavgdescription.TabIndex = 0;
            this.Txtmatavgdescription.Text = "";
            this.Txtmatavgdescription.TextChanged += new System.EventHandler(this.Txtmatavgdescription_TextChanged_1);
            this.Txtmatavgdescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmatavgdescription_KeyPress);
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(96, 304);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(145, 20);
            this.TextBox1.TabIndex = 481;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.Visible = false;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // MatBtnSave
            // 
            this.MatBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnSave.Depth = 0;
            this.MatBtnSave.DrawShadows = true;
            this.MatBtnSave.HighEmphasis = true;
            this.MatBtnSave.Icon = null;
            this.MatBtnSave.Location = new System.Drawing.Point(4, 6);
            this.MatBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnSave.Name = "MatBtnSave";
            this.MatBtnSave.Size = new System.Drawing.Size(58, 36);
            this.MatBtnSave.TabIndex = 480;
            this.MatBtnSave.Text = "Save";
            this.MatBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnSave.UseAccentColor = false;
            this.MatBtnSave.UseVisualStyleBackColor = true;
            this.MatBtnSave.Visible = false;
            this.MatBtnSave.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.DrawShadows = true;
            this.BtnCancel.HighEmphasis = true;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(70, 6);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(77, 36);
            this.BtnCancel.TabIndex = 481;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnCancel.UseAccentColor = false;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.BtnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MatBtnSave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(378, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 49);
            this.tableLayoutPanel1.TabIndex = 482;
            // 
            // FrmAddNewOrderTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.TextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewOrderTrend";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddNewOrderTrend";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddNewOrderTrend_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddNewOrderTrend_Load);
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox Txtmatavgdescription;
        private System.Windows.Forms.TextBox TextBox1;
        private MaterialSkin.Controls.MaterialButton MatBtnSave;
        private MaterialSkin.Controls.MaterialTextBox TxtmatAverageqty;
        private MaterialSkin.Controls.MaterialButton BtnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}