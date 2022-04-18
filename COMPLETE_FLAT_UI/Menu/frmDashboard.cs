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



        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();
        public FormLogo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            //pictureBox1.Padding = new Padding(0);
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.showReceivingData();
            dataGridView1.Visible = false;


            this.GetStoreOrder();
            this.GetLabTestTransactions();
        }
        private void GetStoreOrder()
        {
            //double StoreOrder;
            //double StoreOrderApproval;
            double Preparation;
            double MoveOrder;
            double MoveOrderApproval;
            double Dispatching;

            //StoreOrder = double.Parse("10");
            //StoreOrderApproval = double.Parse("10");
            Preparation = double.Parse("10");
            MoveOrder = double.Parse("4");
            MoveOrderApproval = double.Parse("3");
            Dispatching = double.Parse("1");

            chart4.Series["Series1"].Points.Clear();


            //chart4.Series["Series1"].Points.AddXY("Store Order", StoreOrder);

            //chart4.Series["Series1"].Points.AddXY("Store Order Approval", StoreOrderApproval);

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
    }
}
