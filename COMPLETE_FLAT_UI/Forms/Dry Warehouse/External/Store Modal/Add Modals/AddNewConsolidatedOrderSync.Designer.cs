
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Add_Modals
{
    partial class AddNewConsolidatedOrderSync
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
            this.bunifuTimeFromTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.matbtnSave = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MatBtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.bunifuTimeFromTo);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.bunifuTimeFrom);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.textBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(32, 90);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(495, 200);
            this.materialCard1.TabIndex = 478;
            // 
            // bunifuTimeFromTo
            // 
            this.bunifuTimeFromTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTimeFromTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuTimeFromTo.Checked = false;
            this.bunifuTimeFromTo.CustomFormat = "hh:mm:ss";
            this.bunifuTimeFromTo.Enabled = false;
            this.bunifuTimeFromTo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTimeFromTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.bunifuTimeFromTo.Location = new System.Drawing.Point(256, 77);
            this.bunifuTimeFromTo.Name = "bunifuTimeFromTo";
            this.bunifuTimeFromTo.ShowUpDown = true;
            this.bunifuTimeFromTo.Size = new System.Drawing.Size(222, 46);
            this.bunifuTimeFromTo.TabIndex = 608;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(256, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 607;
            this.label2.Text = "TO :";
            // 
            // bunifuTimeFrom
            // 
            this.bunifuTimeFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTimeFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuTimeFrom.CustomFormat = "yyyy-MM-dd";
            this.bunifuTimeFrom.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuTimeFrom.Location = new System.Drawing.Point(17, 77);
            this.bunifuTimeFrom.Name = "bunifuTimeFrom";
            this.bunifuTimeFrom.ShowUpDown = true;
            this.bunifuTimeFrom.Size = new System.Drawing.Size(222, 46);
            this.bunifuTimeFrom.TabIndex = 606;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 605;
            this.label1.Text = "FROM :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 13);
            this.textBox1.TabIndex = 478;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // matbtnSave
            // 
            this.matbtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnSave.Depth = 0;
            this.matbtnSave.DrawShadows = true;
            this.matbtnSave.HighEmphasis = true;
            this.matbtnSave.Icon = null;
            this.matbtnSave.Location = new System.Drawing.Point(4, 6);
            this.matbtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnSave.Name = "matbtnSave";
            this.matbtnSave.Size = new System.Drawing.Size(58, 34);
            this.matbtnSave.TabIndex = 479;
            this.matbtnSave.Text = "Save";
            this.matbtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnSave.UseAccentColor = false;
            this.matbtnSave.UseVisualStyleBackColor = true;
            this.matbtnSave.Click += new System.EventHandler(this.matbtnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.MatBtnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.matbtnSave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(373, 299);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(154, 46);
            this.tableLayoutPanel1.TabIndex = 480;
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
            this.MatBtnCancel.Size = new System.Drawing.Size(77, 34);
            this.MatBtnCancel.TabIndex = 480;
            this.MatBtnCancel.Text = "CANCEL";
            this.MatBtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnCancel.UseAccentColor = false;
            this.MatBtnCancel.UseVisualStyleBackColor = true;
            this.MatBtnCancel.Click += new System.EventHandler(this.MatBtnCancel_Click);
            // 
            // AddNewConsolidatedOrderSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewConsolidatedOrderSync";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Consolidated Order Sync";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewConsolidatedOrderSync_FormClosed);
            this.Load += new System.EventHandler(this.AddNewConsolidatedOrderSync_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton matbtnSave;
        private System.Windows.Forms.DateTimePicker bunifuTimeFromTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker bunifuTimeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton MatBtnCancel;
    }
}