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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Dispatching
{
    public partial class frmStoreOrderDispatching : MaterialForm
    {
        //Main Classs
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        //Variable Declaration
        int p_id = 0;

   

        public frmStoreOrderDispatching()
        {
            InitializeComponent();
        }

        private void frmStoreOrderDispatching_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.loadPreparationDateDropdown();
            this.useStateWindowLoad();
        }

        public void useStateWindowLoad()
        {
            if (this.matCmbPreparationDate.Text == String.Empty)
            {
                this.materialCheckboxSelectAll.Visible = false;
            }
            else
            {
                this.materialCheckboxSelectAll.Visible = true;
                this.loadCategoryDropdown();

                if(this.matcmbCategory.Text != String.Empty)
                {
                    this.loadStoreNameDropdown();
                }

                if(this.metroCmbStoreName.Text != String.Empty)
                {
                    this.loadPrepaDate_Category_StoreName_Dropdown();
                }
            }
        }

        public void loadPreparationDateDropdown()
        {
            try
            {
                

                myClass.fillComboBoxStoreOrderApprovalSync(this.matCmbPreparationDate, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown", this.dSet, this.bunifuPrepaDate.Text, "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void loadCategoryDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApprovalSync(this.matcmbCategory, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Category", this.dSet, this.matCmbPreparationDate.Text, "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        public void loadStoreNameDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApprovalSync(this.metroCmbStoreName, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_StoreName", this.dSet, this.matCmbPreparationDate.Text, this.matcmbCategory.Text, this.matcmbCategory.Text, this.metroCmbStoreName.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadPrepaDate_Category_StoreName_Dropdown()
        {
            try
            {



                this.dset.Clear();

                this.dset = objStorProc.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major");
                //DataView dv = new DataView(this.dset.Tables[0]);
                this.doSearch();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        private void doSearch()
        {
            try
            {
                if (this.dset.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset.Tables[0]);
                   
                            dv.RowFilter = " is_approved_prepa_date = '" + this.matCmbPreparationDate.Text + "' and   category = '" + this.matcmbCategory.Text + "' and store_name ='" + this.metroCmbStoreName.Text + "'  ";
              
                    this.dgvGunaMoveItems.DataSource = dv;
                    this.lbltotaldata.Text = dgvGunaMoveItems.RowCount.ToString();

                    //gerard
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

        private void matCmbPreparationDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.loadCategoryDropdown();
        }

        private void matcmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.loadStoreNameDropdown();
        }
    }
}
