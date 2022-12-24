
namespace ULTRAMAVERICK.Report
{
    partial class frmReport
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
            this.crV1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crV1
            // 
            this.crV1.ActiveViewIndex = -1;
            this.crV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crV1.Location = new System.Drawing.Point(14, 14);
            this.crV1.Name = "crV1";
            this.crV1.Size = new System.Drawing.Size(2072, 1047);
            this.crV1.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.crV1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 216);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(2100, 1075);
            this.materialCard1.TabIndex = 2;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2340, 1334);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal MIS Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReport_FormClosing);
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crV1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}