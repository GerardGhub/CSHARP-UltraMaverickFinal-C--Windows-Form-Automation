namespace COMPLETE_FLAT_UI
{
    partial class FormLogo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartTopLabTransaction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltotalReceiving = new System.Windows.Forms.Label();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuPrepaDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopLabTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTopLabTransaction
            // 
            this.chartTopLabTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartTopLabTransaction.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartTopLabTransaction.Legends.Add(legend3);
            this.chartTopLabTransaction.Location = new System.Drawing.Point(661, 259);
            this.chartTopLabTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopLabTransaction.Name = "chartTopLabTransaction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTopLabTransaction.Series.Add(series3);
            this.chartTopLabTransaction.Size = new System.Drawing.Size(320, 495);
            this.chartTopLabTransaction.TabIndex = 598;
            this.chartTopLabTransaction.Text = "chartTopProducts";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Lab Test Transactions";
            this.chartTopLabTransaction.Titles.Add(title3);
            this.chartTopLabTransaction.Visible = false;
            // 
            // chart4
            // 
            this.chart4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(51, 260);
            this.chart4.Margin = new System.Windows.Forms.Padding(5);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 6;
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(600, 494);
            this.chart4.TabIndex = 599;
            this.chart4.Text = "chartGrossRevenue";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Store Order";
            this.chart4.Titles.Add(title4);
            this.chart4.Visible = false;
            this.chart4.Click += new System.EventHandler(this.chartGrossRevenue_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialCard2.Controls.Add(this.tableLayoutPanel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(51, 109);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(930, 125);
            this.materialCard2.TabIndex = 597;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel7, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(916, 109);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel4.Controls.Add(this.label1);
            this.metroPanel4.Controls.Add(this.label4);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 4;
            this.metroPanel4.Location = new System.Drawing.Point(1, 1);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(227, 107);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 4;
            this.metroPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel4_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "STORE ORDERS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 58);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // metroPanel5
            // 
            this.metroPanel5.AutoSize = true;
            this.metroPanel5.BackColor = System.Drawing.SystemColors.Window;
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel5.Controls.Add(this.label9);
            this.metroPanel5.Controls.Add(this.label5);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 4;
            this.metroPanel5.Location = new System.Drawing.Point(688, 1);
            this.metroPanel5.Margin = new System.Windows.Forms.Padding(1);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(227, 107);
            this.metroPanel5.TabIndex = 5;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 4;
            this.metroPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel5_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label9.Location = new System.Drawing.Point(2, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "ALERTS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 58);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // metroPanel6
            // 
            this.metroPanel6.BackColor = System.Drawing.SystemColors.Window;
            this.metroPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel6.Controls.Add(this.label10);
            this.metroPanel6.Controls.Add(this.lbltotalReceiving);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 4;
            this.metroPanel6.Location = new System.Drawing.Point(230, 1);
            this.metroPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(227, 107);
            this.metroPanel6.TabIndex = 4;
            this.metroPanel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel6.UseCustomBackColor = true;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 4;
            this.metroPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel6_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label10.Location = new System.Drawing.Point(2, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "RECEIVING";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbltotalReceiving
            // 
            this.lbltotalReceiving.AutoSize = true;
            this.lbltotalReceiving.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalReceiving.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbltotalReceiving.Location = new System.Drawing.Point(7, 42);
            this.lbltotalReceiving.Name = "lbltotalReceiving";
            this.lbltotalReceiving.Size = new System.Drawing.Size(53, 58);
            this.lbltotalReceiving.TabIndex = 9;
            this.lbltotalReceiving.Text = "0";
            this.lbltotalReceiving.Click += new System.EventHandler(this.lbltotalReceiving_Click);
            // 
            // metroPanel7
            // 
            this.metroPanel7.BackColor = System.Drawing.SystemColors.Window;
            this.metroPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel7.Controls.Add(this.label12);
            this.metroPanel7.Controls.Add(this.label13);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 4;
            this.metroPanel7.Location = new System.Drawing.Point(459, 1);
            this.metroPanel7.Margin = new System.Windows.Forms.Padding(1);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(227, 107);
            this.metroPanel7.TabIndex = 3;
            this.metroPanel7.UseCustomBackColor = true;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 4;
            this.metroPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel7_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label12.Location = new System.Drawing.Point(2, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "INTERNAL";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label13.Location = new System.Drawing.Point(8, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 58);
            this.label13.TabIndex = 8;
            this.label13.Text = "0";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 40.60914F;
            this.id.HeaderText = "IDd";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dataGridView1.Location = new System.Drawing.Point(54, 230);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DividerHeight = 5;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 22);
            this.dataGridView1.TabIndex = 596;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // bunifuPrepaDate
            // 
            this.bunifuPrepaDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPrepaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.bunifuPrepaDate.CustomFormat = "yyyy-MM-dd";
            this.bunifuPrepaDate.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPrepaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuPrepaDate.Location = new System.Drawing.Point(482, 261);
            this.bunifuPrepaDate.Name = "bunifuPrepaDate";
            this.bunifuPrepaDate.Size = new System.Drawing.Size(170, 33);
            this.bunifuPrepaDate.TabIndex = 601;
            this.bunifuPrepaDate.Visible = false;
            this.bunifuPrepaDate.ValueChanged += new System.EventHandler(this.bunifuPrepaDate_ValueChanged);
            // 
            // FormLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuPrepaDate);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chartTopLabTransaction);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FormLogo";
            this.Sizable = false;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.FormLogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopLabTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopLabTransaction;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltotalReceiving;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker bunifuPrepaDate;
    }
}