using COMPLETE_FLAT_UI.Models;
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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Preparation
{
    public partial class frmViewStoreItemPrepared : MaterialForm
    {
        frmDryPreparationStore ths;

        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public frmViewStoreItemPrepared(frmDryPreparationStore frm,
            string Dry_Order_GUID,
            string Barcode_id,
            string Item_Description,
            string Unit_Of_Measure,
            string Converted_Qty,
            string Preparation_Date,
            string Qty_Served,
            string Fox,
            string Route,
            string Area
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            Sp_Material_Id = Dry_Order_GUID;
            Sp_Barcode_Id = Barcode_id;
            Sp_Item_Desc = Item_Description;
            Sp_Unit_Of_Measure = Unit_Of_Measure;
            Sp_Converted_Qty = Converted_Qty;
            Sp_Preparation_Date = Preparation_Date;
            Sp_Qty_Served = Qty_Served;
            sp_fox = Fox;
            sp_route = Route;
            sp_area = Area;
        }

        public string Sp_Qty_Served { get; set; }
        public string Sp_Converted_Qty { get; set; }
        public string Sp_Item_Desc { get; set; }
        public string Sp_Barcode_Id { get; set; }
        public string Sp_Material_Id { get; set; }
        public string Sp_Unit_Of_Measure { get; set; }
        public string Sp_Preparation_Date { get; set; }
        public string sp_fox { get; set; }
        public string sp_route { get; set; }
        public string sp_area { get; set; }
        public int Sp_User_ID { get; set; }
        public string sp_approved_preparation_date { get; set; }
        public string Sp_Primary_Key { get; set; }
        public string Is_Active { get; set; }

        private void frmViewStoreItemPrepared_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.StaticWindowState();
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
            this.MaterialDatagridColumnVisibilittyFalse();
        }

        private void MaterialDatagridColumnVisibilittyFalse()
        {
            this.guna2DgvMaterialPreparation.Columns["date_ordered_materials"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["is_approved_preparation_date"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["fox"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["area"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["store_name"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["route"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["primary_id"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["primary_id1"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["converted_qty_original"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["AllocatedQTY"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["conversion"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["prepa_id"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["is_prepared"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["is_wh_checker_cancel"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["Remaining_Qty"].Visible = false;
            //this.guna2DgvMaterialPreparation.Columns["converted_qty"].Visible = false;
        }

        private void StaticWindowState()
        {
            this.Sp_Material_Id = Sp_Material_Id;
        
            this.Sp_Preparation_Date = this.Sp_Preparation_Date;
            this.Sp_User_ID = userinfo.user_id;
    
            this.sp_fox = sp_fox;
            this.sp_route = sp_route;
            this.sp_area = sp_area;
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation_PerItems_Partial_Cancel");

        }

      
      
        private void doSearchInTextBoxCmb()
        {
            this.Is_Active = "1";
            //MessageBox.Show(this.Sp_Preparation_Date);
            //MessageBox.Show(this.sp_fox);
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);

                 
     
                        dv.RowFilter = "fox = '" + this.sp_fox + "' and route = '" + this.sp_route + "' and area = '" + this.sp_area + "' and is_approved_preparation_date = '" + this.Sp_Preparation_Date + "'   ";

                    //dv.RowFilter = "fox = '" + this.sp_fox + "' and route = '" + this.sp_route + "' and area = '" + this.sp_area + "' and is_approved_preparation_date = '" + this.Sp_Preparation_Date + "' and is_wh_checker_cancel= '0'  ";
                    //dv.RowFilter = "fox = '" + this.sp_fox + "' and route = '" + this.sp_route + "' and area = '" + this.sp_area + "' and is_approved_preparation_date = '" + this.Sp_Preparation_Date + "' and is_wh_checker_cancel= '0' or is_prepared = '" + this.Is_Active + "'   ";


                    this.guna2DgvMaterialPreparation.DataSource = dv;
                    this.lbltotaldata.Text = this.guna2DgvMaterialPreparation.RowCount.ToString();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void guna2DgvMaterialPreparation_DoubleClick(object sender, EventArgs e)
        {
            //if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to cancel? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    //Start
             
            //        dset3.Clear();
            //        dset3 = objStorProc.sp_Store_Preparation_Logs(0,
            //       this.Sp_Primary_Key,
            //        this.sp_approved_preparation_date,
            //        "ItemCode", "ItemDesc", "OrderQty", "Allocated QTY", "PrepaDate Added", "PrepaAdded By", 0,
            //          this.sp_fox, this.sp_route, this.sp_area,
            //        "cancel_preparation_individual");


            //        this.UpdatedSuccessfully();
        
            //            this.Close();
             

            //}
            //else
            //{
            //    return;
            //}

            }


      

        private void guna2DgvMaterialPreparation_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CurrentCellChangeofRawMaterials();
        }

        private void CurrentCellChangeofRawMaterials()
        {

            if (this.guna2DgvMaterialPreparation.Rows.Count > 0)
            {
                if (this.guna2DgvMaterialPreparation.CurrentRow != null)
                {
                    if (this.guna2DgvMaterialPreparation.CurrentRow.Cells["store_name"].Value != null)
                    {

                        this.Sp_Primary_Key = this.guna2DgvMaterialPreparation.CurrentRow.Cells["prepa_id"].Value.ToString();

                    }
                }
            }
        }

        private void frmViewStoreItemPrepared_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "ItemServe";
        }

        private void guna2DgvMaterialPreparation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(guna2DgvMaterialPreparation.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to cancel? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                  

                    dset3.Clear();
                    dset3 = objStorProc.sp_Store_Preparation_Logs(0,
                   this.Sp_Primary_Key,
                    this.sp_approved_preparation_date,
                    "ItemCode", "ItemDesc", "OrderQty", "Allocated QTY", "PrepaDate Added", "PrepaAdded By", 0,
                      this.sp_fox, this.sp_route, this.sp_area,
                    "cancel_preparation_individual");


                    this.GlobalStatePopup.UpdatedSuccessfully();

                    this.Close();


                }
                else
                {
                    return;
                }
            }
        }
    }
}
