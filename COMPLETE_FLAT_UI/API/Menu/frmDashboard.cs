using System;
using System.Data;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.Menu.View_Models;
using ULTRAMAVERICK.Models;

namespace COMPLETE_FLAT_UI
{
    public partial class FormLogo : MaterialForm
    {
      
        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        string mode = "";
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly DashboardClasses Menu = new DashboardClasses();
        DateTime dNow = DateTime.Now;
        readonly myglobal GlobalVariable = new myglobal();
        DataSet dset_rights = new DataSet();
        int rights_id = 0;
        DataSet dSet_temp = new DataSet();
        ParentFormsRepository ParentFormsRepository = new ParentFormsRepository(); 
        public FormLogo()
        {
            InitializeComponent();
        }
     
      

        private void FormLogo_Load(object sender, EventArgs e)
        {
            //pictureBox1.Padding = new Padding(0);
            this.ConnectionInit();
            this.showReceivingData();
            this.dataGridView1.Visible = false;
            this.GetLabTestTransactions();       
            this.load_search();
            this.LoadMenuMajorValidation();
        }

        private void LoadMenuMajorValidation()
        {
            this.rights_id = userinfo.user_rights_id;

            dset_rights.Clear();
            dset_rights = g_objStoredProcCollection.sp_getFilterTables("get_accessible_menu_parents", "", rights_id);

            if (dset_rights.Tables.Count > 0)
            {
                for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
                {
                    string parent_form_name = dset_rights.Tables[0].Rows[x][1].ToString();



                 
                   if (parent_form_name == "DASHBOARD")
                    {
                    this.MatCardDashboard.Visible = true;

                        /*  MostrarFormLogo()*/
                        
                    }


              
                }
            }
        }

        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {      
            this.dset_emp1.Clear();

            this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("StoreOrderDashboard");
            this.mode = "Search1";
            this.doSearch();
            if(this.Menu.SPRowCountOfStoreDatagrid != "0")
            {
                this.GetStoreOrder();
            }       
        }

        private void doSearch()
        {
            try
            {
                if (this.dset_emp1.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp1.Tables[0]);
                   
                        if (this.mode == "Search1")
                        {
                            dv.RowFilter = "is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'  ";
                        }
                                      
                    this.dataGridView1.DataSource = dv;

                    this.Menu.SPRowCountOfStoreDatagrid = dataGridView1.RowCount.ToString();
                
                    if (this.Menu.SPRowCountOfStoreDatagrid == "0")
                    {
                        this.GlobalStatePopup.NoDataFound();


                        return;
                    }
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //END
        }




        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

        private void GetStoreOrder()
        {     
            double Preparation;
            double MoveOrder;
            double MoveOrderApproval;
            double Dispatching;

      
            Preparation = double.Parse(this.Menu.SpCategoryPreparation);
            MoveOrder = double.Parse(this.Menu.SpMoveOrder);
            MoveOrderApproval = double.Parse(this.Menu.SpMoveOrderApproved);
            Dispatching = double.Parse(this.Menu.SpMoveOrderSlipDispatch);

            chart4.Series["Series1"].Points.Clear();
            //Initialization of the fucking system
            chart4.Series["Series1"].Points.AddXY("Preparation ("+Preparation+")", Preparation);
            chart4.Series["Series1"].Points.AddXY("Move Order (" + MoveOrder + ")", MoveOrder);
            chart4.Series["Series1"].Points.AddXY("Move Order Approval (" + MoveOrderApproval + ")", MoveOrderApproval);
            chart4.Series["Series1"].Points.AddXY("Dispatching (" + Dispatching + ")", Dispatching);

        }

        private void GetLabTestTransactions()
        {
            double StoreOrder;
            double StoreOrderApproval;
            double Preparation;
            double MoveOrder;
            double MoveOrderApproval;
            double Dispatching;

            StoreOrder = double.Parse("10");
            StoreOrderApproval = double.Parse("7");
            Preparation = double.Parse("5");
            MoveOrder = double.Parse("4");
            MoveOrderApproval = double.Parse("3");
            Dispatching = double.Parse("1");

            this.chartTopLabTransaction.Series["Series1"].Points.Clear();
            this.chartTopLabTransaction.Series["Series1"].Points.AddXY("Nearly Expiry", StoreOrder);
            this.chartTopLabTransaction.Series["Series1"].Points.AddXY("Lab Request", StoreOrderApproval);
            this.chartTopLabTransaction.Series["Series1"].Points.AddXY("Lab Approved", Preparation);
            this.chartTopLabTransaction.Series["Series1"].Points.AddXY("Lab Result", MoveOrder);
            this.chartTopLabTransaction.Series["Series1"].Points.AddXY("Lab Result Approval", MoveOrderApproval);
            this.chartTopLabTransaction.Series["Series1"].Points.AddXY("Lab Result Received", Dispatching);
        }

        private void showReceivingData()      
        {
            try
            {    
                this.myClass.fillDataGridView(this.dataGridView1, "Po_Receiving_Warehouse", dSet);
                int totalGoodItems = 0;
                totalGoodItems = this.dataGridView1.RowCount;
                this.ParentFormsRepository.GetReceivingDataDryReject(this.dataGridView1);
                this.lbltotalReceiving.Text = (totalGoodItems + this.ParentFormsRepository.TotalRecords).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chartGrossRevenue_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbltotalReceiving_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.load_search();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.Menu.SPRowCountOfStoreDatagrid != "0")
            {
                if (this.mode == "Search1")
                {
                    if (this.dataGridView1.Rows.Count > 0)
                    {
                        if (this.dataGridView1.CurrentRow != null)
                        {
                            if (this.dataGridView1.CurrentRow.Cells["is_approved_prepa_date"].Value != null)
                            {
                                this.Menu.SpCategoryPreparation = this.dataGridView1.CurrentRow.Cells["Preparation"].Value.ToString();
                                this.Menu.SpMoveOrder = this.dataGridView1.CurrentRow.Cells["MoveOrder"].Value.ToString();
                                this.Menu.SpMoveOrderApproved = this.dataGridView1.CurrentRow.Cells["MoveOrderSlipCheckerApproved"].Value.ToString();
                                this.Menu.SpMoveOrderSlipDispatch = this.dataGridView1.CurrentRow.Cells["MoveOrderSlipDispatch"].Value.ToString();
                            }
                        }
                    }
                }
            }
            
        }
    }
}
