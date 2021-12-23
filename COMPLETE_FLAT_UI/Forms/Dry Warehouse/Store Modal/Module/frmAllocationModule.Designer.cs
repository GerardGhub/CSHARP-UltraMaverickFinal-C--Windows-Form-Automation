
namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    partial class frmAllocationModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtSoh = new MaterialSkin.Controls.MaterialTextBox();
            this.txtQtyOrder = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTotalStore = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.txtitemDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.txtItemCode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgvStoreOrderApproval = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allocation_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matCardFindAllocation = new MaterialSkin.Controls.MaterialCard();
            this.dgvFindStoreOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.selected2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.primary_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code_find = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description_find = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALLOCATION_QTY_FIND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area_find = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotaldata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalStoreOrder = new System.Windows.Forms.Label();
            this.lblshowItemsFinder = new System.Windows.Forms.Label();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.lblAllocatedQty = new System.Windows.Forms.Label();
            this.lblqtyAllocatedFinal = new System.Windows.Forms.Label();
            this.lbldataLabel = new System.Windows.Forms.Label();
            this.groupBox1AdditionlOrderUI = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).BeginInit();
            this.matCardFindAllocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindStoreOrders)).BeginInit();
            this.groupBox1AdditionlOrderUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtSoh);
            this.materialCard1.Controls.Add(this.txtQtyOrder);
            this.materialCard1.Controls.Add(this.txtTotalStore);
            this.materialCard1.Controls.Add(this.txtCategory);
            this.materialCard1.Controls.Add(this.txtitemDescription);
            this.materialCard1.Controls.Add(this.txtItemCode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 82);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(629, 194);
            this.materialCard1.TabIndex = 0;
            // 
            // txtSoh
            // 
            this.txtSoh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoh.Depth = 0;
            this.txtSoh.Enabled = false;
            this.txtSoh.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSoh.Hint = "Stock On Hand";
            this.txtSoh.Location = new System.Drawing.Point(283, 139);
            this.txtSoh.MaxLength = 50;
            this.txtSoh.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoh.Multiline = false;
            this.txtSoh.Name = "txtSoh";
            this.txtSoh.Size = new System.Drawing.Size(324, 50);
            this.txtSoh.TabIndex = 6;
            this.txtSoh.Text = "";
            this.txtSoh.TextChanged += new System.EventHandler(this.txtSoh_TextChanged);
            // 
            // txtQtyOrder
            // 
            this.txtQtyOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtyOrder.Depth = 0;
            this.txtQtyOrder.Enabled = false;
            this.txtQtyOrder.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtQtyOrder.Hint = "Quantity Order";
            this.txtQtyOrder.Location = new System.Drawing.Point(20, 139);
            this.txtQtyOrder.MaxLength = 50;
            this.txtQtyOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtyOrder.Multiline = false;
            this.txtQtyOrder.Name = "txtQtyOrder";
            this.txtQtyOrder.Size = new System.Drawing.Size(237, 50);
            this.txtQtyOrder.TabIndex = 5;
            this.txtQtyOrder.Text = "";
            // 
            // txtTotalStore
            // 
            this.txtTotalStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalStore.Depth = 0;
            this.txtTotalStore.Enabled = false;
            this.txtTotalStore.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTotalStore.Hint = "Total Store";
            this.txtTotalStore.Location = new System.Drawing.Point(283, 83);
            this.txtTotalStore.MaxLength = 50;
            this.txtTotalStore.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalStore.Multiline = false;
            this.txtTotalStore.Name = "txtTotalStore";
            this.txtTotalStore.Size = new System.Drawing.Size(324, 50);
            this.txtTotalStore.TabIndex = 4;
            this.txtTotalStore.Text = "";
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Depth = 0;
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCategory.Hint = "Category";
            this.txtCategory.Location = new System.Drawing.Point(20, 83);
            this.txtCategory.MaxLength = 50;
            this.txtCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(237, 50);
            this.txtCategory.TabIndex = 3;
            this.txtCategory.Text = "";
            // 
            // txtitemDescription
            // 
            this.txtitemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemDescription.Depth = 0;
            this.txtitemDescription.Enabled = false;
            this.txtitemDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtitemDescription.Hint = "Item Description";
            this.txtitemDescription.Location = new System.Drawing.Point(283, 17);
            this.txtitemDescription.MaxLength = 50;
            this.txtitemDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtitemDescription.Multiline = false;
            this.txtitemDescription.Name = "txtitemDescription";
            this.txtitemDescription.Size = new System.Drawing.Size(324, 50);
            this.txtitemDescription.TabIndex = 2;
            this.txtitemDescription.Text = "";
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemCode.Depth = 0;
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtItemCode.Hint = "Item Code";
            this.txtItemCode.Location = new System.Drawing.Point(20, 17);
            this.txtItemCode.MaxLength = 50;
            this.txtItemCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtItemCode.Multiline = false;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(237, 50);
            this.txtItemCode.TabIndex = 1;
            this.txtItemCode.Text = "";
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvStoreOrderApproval);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(13, 290);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(629, 404);
            this.materialCard2.TabIndex = 3;
            // 
            // dgvStoreOrderApproval
            // 
            this.dgvStoreOrderApproval.AllowUserToAddRows = false;
            this.dgvStoreOrderApproval.AllowUserToDeleteRows = false;
            this.dgvStoreOrderApproval.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoreOrderApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStoreOrderApproval.BackgroundColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStoreOrderApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStoreOrderApproval.ColumnHeadersHeight = 45;
            this.dgvStoreOrderApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.item_code,
            this.description,
            this.sub_category,
            this.StockOnHand,
            this.ORDERS,
            this.Allocation_qty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoreOrderApproval.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStoreOrderApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoreOrderApproval.EnableHeadersVisualStyles = false;
            this.dgvStoreOrderApproval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.Location = new System.Drawing.Point(14, 14);
            this.dgvStoreOrderApproval.MultiSelect = false;
            this.dgvStoreOrderApproval.Name = "dgvStoreOrderApproval";
            this.dgvStoreOrderApproval.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreOrderApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStoreOrderApproval.RowHeadersVisible = false;
            this.dgvStoreOrderApproval.RowHeadersWidth = 102;
            this.dgvStoreOrderApproval.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.RowTemplate.DividerHeight = 5;
            this.dgvStoreOrderApproval.RowTemplate.Height = 40;
            this.dgvStoreOrderApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreOrderApproval.Size = new System.Drawing.Size(601, 376);
            this.dgvStoreOrderApproval.TabIndex = 595;
            this.dgvStoreOrderApproval.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStoreOrderApproval.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreOrderApproval.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStoreOrderApproval.ThemeStyle.ReadOnly = true;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.Height = 40;
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvStoreOrderApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStoreOrderApproval.CurrentCellChanged += new System.EventHandler(this.dgvStoreOrderApproval_CurrentCellChanged);
            // 
            // selected
            // 
            this.selected.DataPropertyName = "selected";
            this.selected.FalseValue = "FALSE";
            this.selected.HeaderText = "SELECTED";
            this.selected.MinimumWidth = 12;
            this.selected.Name = "selected";
            this.selected.ReadOnly = true;
            this.selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selected.TrueValue = "TRUE";
            this.selected.Width = 84;
            // 
            // item_code
            // 
            this.item_code.DataPropertyName = "item_code";
            this.item_code.FillWeight = 66.57212F;
            this.item_code.HeaderText = "ITEM CODE";
            this.item_code.MinimumWidth = 12;
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.Width = 113;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 66.57212F;
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 12;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 129;
            // 
            // sub_category
            // 
            this.sub_category.DataPropertyName = "sub_category";
            this.sub_category.FillWeight = 66.57212F;
            this.sub_category.HeaderText = "CATEGORY";
            this.sub_category.MinimumWidth = 12;
            this.sub_category.Name = "sub_category";
            this.sub_category.ReadOnly = true;
            this.sub_category.Width = 110;
            // 
            // StockOnHand
            // 
            this.StockOnHand.DataPropertyName = "StockOnHand";
            this.StockOnHand.HeaderText = "SOH";
            this.StockOnHand.Name = "StockOnHand";
            this.StockOnHand.ReadOnly = true;
            this.StockOnHand.Width = 66;
            // 
            // ORDERS
            // 
            this.ORDERS.DataPropertyName = "ORDERS";
            this.ORDERS.HeaderText = "ORDER";
            this.ORDERS.Name = "ORDERS";
            this.ORDERS.ReadOnly = true;
            this.ORDERS.Width = 84;
            // 
            // Allocation_qty
            // 
            this.Allocation_qty.DataPropertyName = "Allocation_qty";
            this.Allocation_qty.HeaderText = "ALLOCATED QTY";
            this.Allocation_qty.Name = "Allocation_qty";
            this.Allocation_qty.ReadOnly = true;
            this.Allocation_qty.Width = 147;
            // 
            // matCardFindAllocation
            // 
            this.matCardFindAllocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCardFindAllocation.Controls.Add(this.dgvFindStoreOrders);
            this.matCardFindAllocation.Depth = 0;
            this.matCardFindAllocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCardFindAllocation.Location = new System.Drawing.Point(670, 81);
            this.matCardFindAllocation.Margin = new System.Windows.Forms.Padding(14);
            this.matCardFindAllocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.matCardFindAllocation.Name = "matCardFindAllocation";
            this.matCardFindAllocation.Padding = new System.Windows.Forms.Padding(14);
            this.matCardFindAllocation.Size = new System.Drawing.Size(570, 627);
            this.matCardFindAllocation.TabIndex = 3;
            // 
            // dgvFindStoreOrders
            // 
            this.dgvFindStoreOrders.AllowUserToAddRows = false;
            this.dgvFindStoreOrders.AllowUserToDeleteRows = false;
            this.dgvFindStoreOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvFindStoreOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFindStoreOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFindStoreOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvFindStoreOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFindStoreOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindStoreOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFindStoreOrders.ColumnHeadersHeight = 45;
            this.dgvFindStoreOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFindStoreOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected2,
            this.primary_id,
            this.store_name,
            this.item_code_find,
            this.description_find,
            this.uom,
            this.qty,
            this.ALLOCATION_QTY_FIND,
            this.order_id,
            this.fox,
            this.area_find,
            this.date_ordered});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFindStoreOrders.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFindStoreOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFindStoreOrders.EnableHeadersVisualStyles = false;
            this.dgvFindStoreOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindStoreOrders.Location = new System.Drawing.Point(14, 14);
            this.dgvFindStoreOrders.MultiSelect = false;
            this.dgvFindStoreOrders.Name = "dgvFindStoreOrders";
            this.dgvFindStoreOrders.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFindStoreOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFindStoreOrders.RowHeadersVisible = false;
            this.dgvFindStoreOrders.RowHeadersWidth = 102;
            this.dgvFindStoreOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFindStoreOrders.RowTemplate.DividerHeight = 5;
            this.dgvFindStoreOrders.RowTemplate.Height = 40;
            this.dgvFindStoreOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFindStoreOrders.Size = new System.Drawing.Size(542, 599);
            this.dgvFindStoreOrders.TabIndex = 596;
            this.dgvFindStoreOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvFindStoreOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFindStoreOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFindStoreOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFindStoreOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFindStoreOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFindStoreOrders.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvFindStoreOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindStoreOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvFindStoreOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvFindStoreOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFindStoreOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFindStoreOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFindStoreOrders.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvFindStoreOrders.ThemeStyle.ReadOnly = true;
            this.dgvFindStoreOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFindStoreOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvFindStoreOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFindStoreOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvFindStoreOrders.ThemeStyle.RowsStyle.Height = 40;
            this.dgvFindStoreOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvFindStoreOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFindStoreOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFindStoreOrders_CellFormatting);
            this.dgvFindStoreOrders.CurrentCellChanged += new System.EventHandler(this.dgvFindStoreOrders_CurrentCellChanged);
            this.dgvFindStoreOrders.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvFindStoreOrders_RowPostPaint);
            // 
            // selected2
            // 
            this.selected2.DataPropertyName = "selected2";
            this.selected2.HeaderText = "*";
            this.selected2.Name = "selected2";
            this.selected2.ReadOnly = true;
            this.selected2.Width = 22;
            // 
            // primary_id
            // 
            this.primary_id.DataPropertyName = "primary_id";
            this.primary_id.FillWeight = 66.91177F;
            this.primary_id.HeaderText = "ID";
            this.primary_id.MinimumWidth = 12;
            this.primary_id.Name = "primary_id";
            this.primary_id.ReadOnly = true;
            this.primary_id.Width = 50;
            // 
            // store_name
            // 
            this.store_name.DataPropertyName = "store_name";
            this.store_name.FillWeight = 66.57212F;
            this.store_name.HeaderText = "STORE";
            this.store_name.MinimumWidth = 12;
            this.store_name.Name = "store_name";
            this.store_name.ReadOnly = true;
            this.store_name.Width = 79;
            // 
            // item_code_find
            // 
            this.item_code_find.DataPropertyName = "item_code";
            this.item_code_find.FillWeight = 66.57212F;
            this.item_code_find.HeaderText = "ITEM CODE";
            this.item_code_find.MinimumWidth = 12;
            this.item_code_find.Name = "item_code_find";
            this.item_code_find.ReadOnly = true;
            this.item_code_find.Width = 113;
            // 
            // description_find
            // 
            this.description_find.DataPropertyName = "description";
            this.description_find.FillWeight = 66.57212F;
            this.description_find.HeaderText = "DESCRIPTION";
            this.description_find.MinimumWidth = 12;
            this.description_find.Name = "description_find";
            this.description_find.ReadOnly = true;
            this.description_find.Width = 129;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UOM";
            this.uom.MinimumWidth = 6;
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            this.uom.Width = 70;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.FillWeight = 66.91177F;
            this.qty.HeaderText = "ORDER";
            this.qty.MinimumWidth = 12;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 84;
            // 
            // ALLOCATION_QTY_FIND
            // 
            this.ALLOCATION_QTY_FIND.DataPropertyName = "ALLOCATION_QTY";
            this.ALLOCATION_QTY_FIND.FillWeight = 66.91177F;
            this.ALLOCATION_QTY_FIND.HeaderText = "ALLOCATED QTY";
            this.ALLOCATION_QTY_FIND.MinimumWidth = 12;
            this.ALLOCATION_QTY_FIND.Name = "ALLOCATION_QTY_FIND";
            this.ALLOCATION_QTY_FIND.ReadOnly = true;
            this.ALLOCATION_QTY_FIND.Width = 147;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "Order ID";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Width = 93;
            // 
            // fox
            // 
            this.fox.DataPropertyName = "fox";
            this.fox.HeaderText = "FOX";
            this.fox.Name = "fox";
            this.fox.ReadOnly = true;
            this.fox.Width = 63;
            // 
            // area_find
            // 
            this.area_find.DataPropertyName = "area";
            this.area_find.HeaderText = "Area";
            this.area_find.Name = "area_find";
            this.area_find.ReadOnly = true;
            this.area_find.Width = 66;
            // 
            // date_ordered
            // 
            this.date_ordered.DataPropertyName = "date_ordered";
            this.date_ordered.HeaderText = "DATE ORDERED";
            this.date_ordered.Name = "date_ordered";
            this.date_ordered.ReadOnly = true;
            this.date_ordered.Width = 142;
            // 
            // lbltotaldata
            // 
            this.lbltotaldata.AutoSize = true;
            this.lbltotaldata.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldata.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotaldata.Location = new System.Drawing.Point(13, 719);
            this.lbltotaldata.Name = "lbltotaldata";
            this.lbltotaldata.Size = new System.Drawing.Size(32, 40);
            this.lbltotaldata.TabIndex = 641;
            this.lbltotaldata.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(58, 733);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 642;
            this.label4.Text = "Items";
            // 
            // lbltotalStoreOrder
            // 
            this.lbltotalStoreOrder.AutoSize = true;
            this.lbltotalStoreOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalStoreOrder.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalStoreOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbltotalStoreOrder.Location = new System.Drawing.Point(1118, 722);
            this.lbltotalStoreOrder.Name = "lbltotalStoreOrder";
            this.lbltotalStoreOrder.Size = new System.Drawing.Size(32, 40);
            this.lbltotalStoreOrder.TabIndex = 643;
            this.lbltotalStoreOrder.Text = "0";
            this.lbltotalStoreOrder.TextChanged += new System.EventHandler(this.lbltotalStoreOrder_TextChanged);
            // 
            // lblshowItemsFinder
            // 
            this.lblshowItemsFinder.AutoSize = true;
            this.lblshowItemsFinder.BackColor = System.Drawing.Color.Transparent;
            this.lblshowItemsFinder.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowItemsFinder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lblshowItemsFinder.Location = new System.Drawing.Point(1163, 736);
            this.lblshowItemsFinder.Name = "lblshowItemsFinder";
            this.lblshowItemsFinder.Size = new System.Drawing.Size(38, 17);
            this.lblshowItemsFinder.TabIndex = 644;
            this.lblshowItemsFinder.Text = "Items";
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(670, 723);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(94, 36);
            this.matBtnSave.TabIndex = 645;
            this.matBtnSave.Text = "Allocate";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // lblAllocatedQty
            // 
            this.lblAllocatedQty.AutoSize = true;
            this.lblAllocatedQty.BackColor = System.Drawing.Color.Transparent;
            this.lblAllocatedQty.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocatedQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lblAllocatedQty.Location = new System.Drawing.Point(1019, 722);
            this.lblAllocatedQty.Name = "lblAllocatedQty";
            this.lblAllocatedQty.Size = new System.Drawing.Size(32, 40);
            this.lblAllocatedQty.TabIndex = 646;
            this.lblAllocatedQty.Text = "0";
            this.lblAllocatedQty.Visible = false;
            // 
            // lblqtyAllocatedFinal
            // 
            this.lblqtyAllocatedFinal.AutoSize = true;
            this.lblqtyAllocatedFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblqtyAllocatedFinal.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtyAllocatedFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lblqtyAllocatedFinal.Location = new System.Drawing.Point(778, 719);
            this.lblqtyAllocatedFinal.Name = "lblqtyAllocatedFinal";
            this.lblqtyAllocatedFinal.Size = new System.Drawing.Size(32, 40);
            this.lblqtyAllocatedFinal.TabIndex = 647;
            this.lblqtyAllocatedFinal.Text = "0";
            // 
            // lbldataLabel
            // 
            this.lbldataLabel.AutoSize = true;
            this.lbldataLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbldataLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.lbldataLabel.Location = new System.Drawing.Point(823, 733);
            this.lbldataLabel.Name = "lbldataLabel";
            this.lbldataLabel.Size = new System.Drawing.Size(139, 17);
            this.lbldataLabel.TabIndex = 648;
            this.lbldataLabel.Text = "Total Allocated Quantity";
            // 
            // groupBox1AdditionlOrderUI
            // 
            this.groupBox1AdditionlOrderUI.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1AdditionlOrderUI.Controls.Add(this.materialLabel4);
            this.groupBox1AdditionlOrderUI.Controls.Add(this.panel1);
            this.groupBox1AdditionlOrderUI.Location = new System.Drawing.Point(445, 697);
            this.groupBox1AdditionlOrderUI.Name = "groupBox1AdditionlOrderUI";
            this.groupBox1AdditionlOrderUI.Size = new System.Drawing.Size(197, 62);
            this.groupBox1AdditionlOrderUI.TabIndex = 649;
            this.groupBox1AdditionlOrderUI.TabStop = false;
            this.groupBox1AdditionlOrderUI.Text = "Color Coding Guide :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(13, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(106, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Aditional Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(131, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 29);
            this.panel1.TabIndex = 0;
            // 
            // frmAllocationModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 768);
            this.Controls.Add(this.groupBox1AdditionlOrderUI);
            this.Controls.Add(this.lblqtyAllocatedFinal);
            this.Controls.Add(this.lbldataLabel);
            this.Controls.Add(this.lblAllocatedQty);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.lbltotalStoreOrder);
            this.Controls.Add(this.lbltotaldata);
            this.Controls.Add(this.lblshowItemsFinder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matCardFindAllocation);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmAllocationModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Order Allocation";
            this.Load += new System.EventHandler(this.frmAllocationModule_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreOrderApproval)).EndInit();
            this.matCardFindAllocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindStoreOrders)).EndInit();
            this.groupBox1AdditionlOrderUI.ResumeLayout(false);
            this.groupBox1AdditionlOrderUI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtitemDescription;
        private MaterialSkin.Controls.MaterialTextBox txtItemCode;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard matCardFindAllocation;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStoreOrderApproval;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFindStoreOrders;
        private System.Windows.Forms.Label lbltotaldata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotalStoreOrder;
        private System.Windows.Forms.Label lblshowItemsFinder;
        private MaterialSkin.Controls.MaterialTextBox txtSoh;
        private MaterialSkin.Controls.MaterialTextBox txtQtyOrder;
        private MaterialSkin.Controls.MaterialTextBox txtTotalStore;
        private MaterialSkin.Controls.MaterialTextBox txtCategory;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private System.Windows.Forms.Label lblAllocatedQty;
        private System.Windows.Forms.Label lblqtyAllocatedFinal;
        private System.Windows.Forms.Label lbldataLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allocation_qty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected2;
        private System.Windows.Forms.DataGridViewTextBoxColumn primary_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_code_find;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_find;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALLOCATION_QTY_FIND;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fox;
        private System.Windows.Forms.DataGridViewTextBoxColumn area_find;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordered;
        private System.Windows.Forms.GroupBox groupBox1AdditionlOrderUI;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel1;
    }
}