using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ULTRAMAVERICK.Models;

namespace COMPLETE_FLAT_UI
{
    public partial class FormLogo : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        string mode = "";
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();
        public FormLogo()
        {
            InitializeComponent();
        }
        public string SpCategoryPreparation { get; set; }
        public string SpMoveOrder { get; set; }

        public string SpMoveOrderApproved { get; set; }
        public string SpMoveOrderSlipDispatch { get; set; }
        public string SPRowCountOfStoreDatagrid { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            //pictureBox1.Padding = new Padding(0);
            this.ConnectionInit();
            this.showReceivingData();
            dataGridView1.Visible = false;





            this.GetLabTestTransactions();
            //Hello
        
            //this.load_search();
    
        }
        
        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {
         
            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("StoreOrderDashboard");
            this.mode = "Search1";
            this.doSearch();
            this.GetStoreOrder();

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
                    //this.lbltotaldata.Text = dataGridView1.RowCount.ToString();
                    this.SPRowCountOfStoreDatagrid = dataGridView1.RowCount.ToString();
                    if (this.SPRowCountOfStoreDatagrid == "0")
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
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void GetStoreOrder()
        {
         
            double Preparation;
            double MoveOrder;
            double MoveOrderApproval;
            double Dispatching;

      
            Preparation = double.Parse(this.SpCategoryPreparation);
            MoveOrder = double.Parse(this.SpMoveOrder);
            MoveOrderApproval = double.Parse(this.SpMoveOrderApproved);
            Dispatching = double.Parse(this.SpMoveOrderSlipDispatch);

            chart4.Series["Series1"].Points.Clear();


            chart4.Series["Series1"].Points.AddXY("Preparation", Preparation);

            chart4.Series["Series1"].Points.AddXY("Move Order", MoveOrder);
            chart4.Series["Series1"].Points.AddXY("Move Order Approval", MoveOrderApproval);
            chart4.Series["Series1"].Points.AddXY("Dispatching", Dispatching);

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

        private void showReceivingData()      //method for loading available_menus
        {
            try
            {
           
                this.xClass.fillDataGridView(dataGridView1, "Po_Receiving_Warehouse", dSet);
          
                this.lbltotalReceiving.Text = dataGridView1.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            this.load_search();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.mode == "Search1")
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    if (this.dataGridView1.CurrentRow != null)
                    {
                        if (this.dataGridView1.CurrentRow.Cells["is_approved_prepa_date"].Value != null)
                        {

                            this.SpCategoryPreparation = this.dataGridView1.CurrentRow.Cells["Preparation"].Value.ToString();
                            this.SpMoveOrder = this.dataGridView1.CurrentRow.Cells["MoveOrder"].Value.ToString();
                            this.SpMoveOrderApproved = this.dataGridView1.CurrentRow.Cells["MoveOrderSlipCheckerApproved"].Value.ToString();
                            this.SpMoveOrderSlipDispatch = this.dataGridView1.CurrentRow.Cells["MoveOrderSlipDispatch"].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
