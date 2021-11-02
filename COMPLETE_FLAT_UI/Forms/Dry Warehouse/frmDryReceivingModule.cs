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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmDryReceivingModule : MaterialForm
    {
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        public frmDryReceivingModule()
        {
            InitializeComponent();
        }

        public string totalRecords { get; set; }
        public int p_id { get; set; }
        public string sp_item_code { get; set; }
        public string sp_item_description { get; set; }
        private void frmDryReceivingModule_Load(object sender, EventArgs e)
        {
            this.firstLoad();
            this.mattxtbarcode.Focus();
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void firstLoad()
        {
            DateTime dNow = DateTime.Now;

            mattxtreceivingdate.Text = (dNow.ToString("M/d/yyyy"));
            this.dgvMajorCategory.Visible = false;
        }

        private void mattxtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.scanBarcode();
            }
        }

        private void RMNotExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Item Not Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void RMNotExistReceiving()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "No Item for Receiving";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Po_Receiving_Warehouse_CheckingBinding");

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




                        dv.RowFilter = "item_code like '%" + mattxtbarcode.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.dgvMajorCategory.DataSource = dv;
                    totalRecords = dgvMajorCategory.RowCount.ToString();
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

        private void scanBarcode()
        {

            dSet.Clear();
            dSet = objStorProc.sp_Raw_Materials_Dry(0,
                mattxtbarcode.Text, "", "", "", "", "", "", "", "", "", "", "", "getdetailsforBulkInsertItemCode");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
                dSet.Clear();
                dSet = objStorProc.sp_Raw_Materials_Dry(0,
                    mattxtbarcode.Text, "", "", "", "", "", "", "", "", "", "", "", "getRMforReceivingDryWH");
                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.SearchMethodJarVarCallingSP();
                    this.doSearchInTextBoxCmb();

                    if(totalRecords == "0")
                    {

                    }
                    else
                    {
                        this.mattxtbarcode.Text = String.Empty;
                        this.ItemFoundforReceiving();
                        materialCard2.Visible = true;
                        materialCard3.Visible = true;

                    }
                }
                else
                {
                    this.RMNotExistReceiving();
                    this.mattxtbarcode.Text = String.Empty;
                    this.mattxtbarcode.Focus();
                    return;
                }


                }
            else
            {
                this.RMNotExist();
                this.mattxtbarcode.Text = String.Empty;
                this.mattxtbarcode.Focus();
                return;

            }


        }

        private void ItemFoundforReceiving()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "For Receiving '"+mattxtitemdesc.Text+"'";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (dgvMajorCategory.Rows.Count > 0)
            {
                if (dgvMajorCategory.CurrentRow != null)
                {
                    if (dgvMajorCategory.CurrentRow.Cells["item_code"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvMajorCategory.CurrentRow.Cells["PrimaryID"].Value);
                  mattxtitemcode.Text = dgvMajorCategory.CurrentRow.Cells["item_code"].Value.ToString();
                        mattxtitemdesc.Text = dgvMajorCategory.CurrentRow.Cells["item_description"].Value.ToString();
                        mattxtSupplier.Text = dgvMajorCategory.CurrentRow.Cells["Supplier"].Value.ToString();
                        mattxtmfgdate.Text = dgvMajorCategory.CurrentRow.Cells["mfg_date"].Value.ToString();
                       mattxtexpirydate.Text = dgvMajorCategory.CurrentRow.Cells["expiration_date"].Value.ToString();
                        matdaysExpiry.Text = dgvMajorCategory.CurrentRow.Cells["DaysToExpired"].Value.ToString();
                      mattxtcategory.Text = dgvMajorCategory.CurrentRow.Cells["major_category"].Value.ToString();
                       mattxtqtyuom.Text = dgvMajorCategory.CurrentRow.Cells["qty_uom"].Value.ToString();
                      mattxtponumber.Text = dgvMajorCategory.CurrentRow.Cells["po_number"].Value.ToString();
                       mattxtactualdelivery.Text = dgvMajorCategory.CurrentRow.Cells["actual_delivery"].Value.ToString();
                    }
                }
            }
        }

        private void mattxtqtyReceived_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectLot_Click(object sender, EventArgs e)
        {
            frmChooseLotNumber asd = new frmChooseLotNumber();
            asd.ShowDialog();
        }

        private void mattxtqtyReceived_TextChanged(object sender, EventArgs e)
        {
            //Removing an Entry 
            try
            {


                mattxtsoh.Text = (float.Parse(mattxtqtyReceived.Text) - float.Parse(mattxtsoh.Text)).ToString();
            }
            catch (Exception)
            {


            }

            if (mattxtqtyReceived.Text == String.Empty)
            {
              
            }
            else
            {
                try
                {


                    mattxtsoh.Text = (float.Parse(mattxtqtyReceived.Text) + float.Parse(mattxtsoh.Text)).ToString();
                }
                catch (Exception)
                {


                }
            }
        }

        private void mattxtactualdelivery_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
