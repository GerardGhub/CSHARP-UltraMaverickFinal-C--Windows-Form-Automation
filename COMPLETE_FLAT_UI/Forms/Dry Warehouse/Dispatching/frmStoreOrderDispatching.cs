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
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

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
                

                myClass.fillComboBoxStoreOrderApprovalSync(this.matCmbPreparationDate, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown", 
                    this.dSet, "BunifuPrepaDate", "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

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

        private void CountAllQtyOrder()
        {
            int sum = 0;
            for (int i = 0; i < this.dgvGunaMoveItems.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(this.dgvGunaMoveItems.Rows[i].Cells["prepared_allocated_qty"].Value);
            }
            this.lbltotalOrderQty.Text = sum.ToString();
        }

        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {


            if (this.materialCheckboxSelectAll.Checked == true)
            {
                this.labelSelectedSum.Visible = true;
                this.materialCheckboxSelectAll.Text = "UnSelect ALL";
                for (int i = 0; i < this.dgvGunaMoveItems.RowCount; i++) { this.dgvGunaMoveItems.Rows[i].Cells[0].Value = true; }
                //MessageBox.Show(dgvReprinting.SelectedRows.Count.ToString());

                this.labelSelectedSum.Text = "Selected Items: " + this.dgvGunaMoveItems.RowCount.ToString();
                this.num = this.dgvGunaMoveItems.RowCount;
                this.SaveButtonManipulator();
                this.CountAllQtyOrder();
            }
            else
            {
                this.materialCheckboxSelectAll.Text = "Select ALL";
                //this.labelSelectedSum.Visible = false;
                for (int i = 0; i < dgvGunaMoveItems.RowCount; i++) { dgvGunaMoveItems.Rows[i].Cells[0].Value = false; }
                this.labelSelectedSum.Text = "Selected Items: " + 0;
                this.num = 0;
                this.SaveButtonManipulator();
                this.lbltotalOrderQty.Text = "0";
            }
        }


        private void SaveButtonManipulator()
        {
            if (this.labelSelectedSum.Text == "0")
            {
                this.matbtnCancel.Visible = false;
            }
            else if (num == 0)
            {
                this.matbtnCancel.Visible = false;
            }
            else
            {
                this.matbtnCancel.Visible = true;
            }
        }

        double num = 0;
        double num_static_value = 0;
        private void dgvGunaMoveItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dgvGunaMoveItems.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
        }

        private void CheckCount(bool isChecked)
        {
            if (isChecked)
            {
                double totalRecords = Convert.ToInt32(this.lbltotaldata.Text.ToString());
                if (num == totalRecords)
                {

                }
                else
                {
                    num++;
                    num_static_value = num;
                }
            }
            else
            {
                num--;

            }
            //Store in Static Value Integer Type of Variable

            this.labelSelectedSum.Text = "Selected Items: " + num;
            this.labelSelectedSum.Visible = true;
            this.SaveButtonManipulator();
            this.EditManipulator();

        }

        private void EditManipulator()
        {
            if (this.num == 1)
            {
                this.matbtnCancel.Visible = true;
                this.matbtnEdit.Visible = true;
            }
            else
            {
                //this.matbtnEdit.Visible = false;

            }
        }

        private void lbltotaldata_TextChanged(object sender, EventArgs e)
        {
            if(this.lbltotaldata.Text != "0")
            {
                this.dgvGunaMoveItems.Enabled = true;
            }
            else
            {
                this.dgvGunaMoveItems.Enabled = false;
            }
        }


        public void NoOfPagesforPrinting()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Select number of pages for printing set-up";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.DarkSlateBlue;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void matbtnEdit_Click(object sender, EventArgs e)
        {
            if(this.metroCMbFilterPrintPages.Text == String.Empty)
            {
                this.NoOfPagesforPrinting();
                return;
            }
        }
    }
}
