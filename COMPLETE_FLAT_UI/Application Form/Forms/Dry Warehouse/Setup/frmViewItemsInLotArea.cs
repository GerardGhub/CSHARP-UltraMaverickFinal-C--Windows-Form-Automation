using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Setup
{
    public partial class frmViewItemsInLotArea : MaterialForm
    {
        private IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();

        frmLotManagement ths;
        public frmViewItemsInLotArea(frmLotManagement frm, string Lot_Number, string Item_Description, string Item_Category)
        {
            InitializeComponent();

            ths = frm;
            //textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            LotNumber = Lot_Number;
            Description = Item_Description;
            Category = Item_Category;
        }
        public string LotNumber { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        private void frmViewItemsInLotArea_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.StaticWindowState();
            this.SearchMethodJarVarCallingSP();
            this.matxtLotNo_TextChanged(sender, e);
        }
        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

 
        private void StaticWindowState()
        {
           this.matxtLotNo.Text = this.LotNumber;
            this.matTxtLotDescription.Text = this.Description;
            this.Category = Category;
        }

        private void matxtLotNo_TextChanged(object sender, EventArgs e)
        {
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.doSearchInTextBoxCmb();
            }
            if (this.matxtLotNo.Text == "")
            {
                this.doSearchInTextBoxCmb();
            }
        }


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("LotCollectionofData");

        }


        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {


                        //Gerard Singian Developer Man




                        dv.RowFilter = "lot_no = '" + matxtLotNo.Text + "'";

                    }
               
                    this.dgvLotData.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvLotData.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }




        }





    }
}
