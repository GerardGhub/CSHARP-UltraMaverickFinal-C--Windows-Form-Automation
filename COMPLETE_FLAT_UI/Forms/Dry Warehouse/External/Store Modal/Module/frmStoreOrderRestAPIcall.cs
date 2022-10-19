using COMPLETE_FLAT_UI.Models;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Class;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreOrderRestAPIcall : MaterialForm
    {
    
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        private IStoredProcedures objStorProc = null;
        readonly TabControlBagde BadgeUtil = new TabControlBagde();
        readonly myclasses myClass = new myclasses();
        string mode = "";
        int total = 0;
        int haserror = 0;
        int StoreOrderReset = 0;
        int SubMode = 0;
        public frmStoreOrderRestAPIcall()
        {
            InitializeComponent();
        }

        public string From { get; set; }
        public string sp_fox2 { get; set; }
        public string sp_route2 { get; set; }
        public string sp_area2 { get; set; }
        public string To { get; set; }
        public int RowCountAPiOrder { get; set; }
        public int TotalValidData { get; set; }
        public int InvalidInformation { get; set; }
        public int ReceivedInformation { get; set; }
        public string item_id_main { get; set; }
        public string item_code_main { get; set; }
        public string item_description_main { get; set; }
        public string item_type_main { get; set; }
        public string item_class_main { get; set; }
        public string major_category_main { get; set; }
        public string sub_category_main { get; set; }
        public string primary_unit_main { get; set; }
        public string conversion_main { get; set; }
        public string mat_row_number { get; set; }
        public int user_id { get; set; }
        public string SpdateNeeded { get; set; }
        public int PrimaryIdentity { get; set; }

        //Storer
        public string sp_order_id { get; set; }
        public string sp_date_ordered { get; set; }
        public string sp_fox { get; set; }
        public string sp_store_name { get; set; }
        public string sp_route { get; set; }
        public string sp_area { get; set; }
        public string sp_category { get; set; }
        public string sp_item_code { get; set; }
        public string sp_description { get; set; }
        public string sp_uom { get; set; }
        public string sp_qty { get; set; }
        public string Sp_total_count_of_RestData { get; set; }


        public string DateFrom { get; set; }
        public string DateTo { get; set; }

  

        private JArray GetRESTData(string uri)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);

   
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            var reader = new StreamReader(webResponse.GetResponseStream());
            string s = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<JArray>(s);
        }


        private void frmStoreOrderRestAPIcall_Load(object sender, EventArgs e)
        {
            this.dtpfrom.MinDate = dtpfrom.Value.AddDays(-5);
            this.dtpfrom.MaxDate = DateTime.Now;
            this.ConnectionInit();
            //this.GetStoreOrders();
            this.MainLoader();
           

            this.user_id = userinfo.user_id;
            this.matRadio0.Checked = true;

     
            this.matlblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            this.matlblTime.Visible = false;
            this.ValidateTheFuckingCutOfftimeWithButtonControlls();
            this.SubOrdersMenu();
            //this.LoadFilterAlreadySync();

            circularProgressBar1.Value = 0;
            //circularProgressBar1.Minimum = 0;
            //circularProgressBar1.Maximum = 100;
        }

        private void  SubOrdersMenu()
        {
            this.showDryWhPendingOrders();
            this.showDryWhPendingReceived();
        }
        private void ConnectionInit()
        {
            this.objStorProc = myClass.g_objStoredProc.GetCollections();
        }

        private void showDryWhPendingReceived()      //method for loading available_menus
        {
            try
            {

                //myClass.fillDataGridView(this.DgvReceivedOrder, "dry_wh_orders_received", dSet);
                myClass.fillDataGridView(this.DgvReceivedOrder, "dry_wh_orders_duplicate_entry", dSet);
                this.ReceivedInformation = this.DgvReceivedOrder.RowCount;
                this.MatRadio2.Text = "Duplicated Lists" + ":" + (this.ReceivedInformation);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.DgvReceivedOrder.Columns["is_active"].Visible = false;
            this.DgvReceivedOrder.Columns["added_by"].Visible = false;
            this.DgvReceivedOrder.Columns["primary_id"].Visible = false;
            this.DgvReceivedOrder.Columns["is_for_validation"].Visible = false;
            this.DgvReceivedOrder.Columns["is_approved"].Visible = false;
            this.DgvReceivedOrder.Columns["is_approved_by"].Visible = false;
            this.DgvReceivedOrder.Columns["is_approved_date"].Visible = false;
            this.DgvReceivedOrder.Columns["is_approved_prepa_date"].Visible = false;
            this.DgvReceivedOrder.Columns["is_cancelled"].Visible = false;
            this.DgvReceivedOrder.Columns["is_cancelled_by"].Visible = false;
            this.DgvReceivedOrder.Columns["is_returned"].Visible = false;
            this.DgvReceivedOrder.Columns["is_returned_by"].Visible = false;
            this.DgvReceivedOrder.Columns["date_added"].Visible = false;
            this.DgvReceivedOrder.Columns["is_cancelled_date"].Visible = false;
            this.DgvReceivedOrder.Columns["is_cancelled_reason"].Visible = false;
            this.DgvReceivedOrder.Columns["updated_by"].Visible = false;
            this.DgvReceivedOrder.Columns["updated_date"].Visible = false;
            this.DgvReceivedOrder.Columns["is_prepared"].Visible = false;
            this.DgvReceivedOrder.Columns["is_prepared_by"].Visible = false;
            this.DgvReceivedOrder.Columns["is_prepared_date"].Visible = false;
            this.DgvReceivedOrder.Columns["start_time_stamp"].Visible = false;

            this.DgvReceivedOrder.Columns["is_returned_date"].Visible = false;
            this.DgvReceivedOrder.Columns["is_returned_reason"].Visible = false;

            this.DgvReceivedOrder.Columns["start_by_user_id"].Visible = false;
            this.DgvReceivedOrder.Columns["end_time_stamp_per_items"].Visible = false;
            this.DgvReceivedOrder.Columns["force_prepared_status"].Visible = false;
            this.DgvReceivedOrder.Columns["total_state_repack"].Visible = false;
            this.DgvReceivedOrder.Columns["prepared_allocated_qty"].Visible = false;
            this.DgvReceivedOrder.Columns["is_wh_approved"].Visible = false;
            this.DgvReceivedOrder.Columns["is_wh_approved_by"].Visible = false;
            this.DgvReceivedOrder.Columns["is_wh_approved_date"].Visible = false;
            this.DgvReceivedOrder.Columns["is_wh_checker_cancel"].Visible = false;
            this.DgvReceivedOrder.Columns["is_wh_checker_cancel_by"].Visible = false;

            this.DgvReceivedOrder.Columns["is_wh_checker_cancel_date"].Visible = false;
            this.DgvReceivedOrder.Columns["is_wh_checker_cancel_reason"].Visible = false;
            this.DgvReceivedOrder.Columns["dispossal_status"].Visible = false;
            this.DgvReceivedOrder.Columns["is_selected"].Visible = false;


            this.DgvReceivedOrder.Columns["is_selected_move_order_by"].Visible = false;
            this.DgvReceivedOrder.Columns["is_selected_move_order_date"].Visible = false;
            this.DgvReceivedOrder.Columns["wh_checker_move_order_no"].Visible = false;
            this.DgvReceivedOrder.Columns["total_state_repack_cancelled_qty"].Visible = false;
            this.DgvReceivedOrder.Columns["logic_return_by"].Visible = false;

            this.DgvReceivedOrder.Columns["logic_return_by"].Visible = false;
            this.DgvReceivedOrder.Columns["logic_return_date"].Visible = false;
            this.DgvReceivedOrder.Columns["logic_return_reason"].Visible = false;
            this.DgvReceivedOrder.Columns["time_stamp_update"].Visible = false;
            this.DgvReceivedOrder.Columns["Fk_dry_wh_orders_parent_id"].Visible = false;
  
        }



        private void showDryWhForSyncing()      //method for loading available_menus
        {
            try
            {

      
                myClass.fillDataGridView(this.DgvForSync, "dry_wh_orders_entry_for_syncing", dSet);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.DgvForSync.Columns["is_active"].Visible = false;
            this.DgvForSync.Columns["added_by"].Visible = false;
            this.DgvForSync.Columns["primary_id"].Visible = false;
            this.DgvForSync.Columns["is_for_validation"].Visible = false;
            this.DgvForSync.Columns["is_approved"].Visible = false;
            this.DgvForSync.Columns["is_approved_by"].Visible = false;
            this.DgvForSync.Columns["is_approved_date"].Visible = false;
            this.DgvForSync.Columns["is_approved_prepa_date"].Visible = false;
            this.DgvForSync.Columns["is_cancelled"].Visible = false;
            this.DgvForSync.Columns["is_cancelled_by"].Visible = false;
            this.DgvForSync.Columns["is_returned"].Visible = false;
            this.DgvForSync.Columns["is_returned_by"].Visible = false;
            this.DgvForSync.Columns["date_added"].Visible = false;
            this.DgvForSync.Columns["is_cancelled_date"].Visible = false;
            this.DgvForSync.Columns["is_cancelled_reason"].Visible = false;
            this.DgvForSync.Columns["updated_by"].Visible = false;
            this.DgvForSync.Columns["updated_date"].Visible = false;
            this.DgvForSync.Columns["is_prepared"].Visible = false;
            this.DgvForSync.Columns["is_prepared_by"].Visible = false;
            this.DgvForSync.Columns["is_prepared_date"].Visible = false;
            this.DgvForSync.Columns["start_time_stamp"].Visible = false;

            this.DgvForSync.Columns["is_returned_date"].Visible = false;
            this.DgvForSync.Columns["is_returned_reason"].Visible = false;

            this.DgvForSync.Columns["start_by_user_id"].Visible = false;
            this.DgvForSync.Columns["end_time_stamp_per_items"].Visible = false;
            this.DgvForSync.Columns["force_prepared_status"].Visible = false;
            this.DgvForSync.Columns["total_state_repack"].Visible = false;
            this.DgvForSync.Columns["prepared_allocated_qty"].Visible = false;
            this.DgvForSync.Columns["is_wh_approved"].Visible = false;
            this.DgvForSync.Columns["is_wh_approved_by"].Visible = false;
            this.DgvForSync.Columns["is_wh_approved_date"].Visible = false;
            this.DgvForSync.Columns["is_wh_checker_cancel"].Visible = false;
            this.DgvForSync.Columns["is_wh_checker_cancel_by"].Visible = false;

            this.DgvForSync.Columns["is_wh_checker_cancel_date"].Visible = false;
            this.DgvForSync.Columns["is_wh_checker_cancel_reason"].Visible = false;
            this.DgvForSync.Columns["dispossal_status"].Visible = false;
            this.DgvForSync.Columns["is_selected"].Visible = false;


            this.DgvForSync.Columns["is_selected_move_order_by"].Visible = false;
            this.DgvForSync.Columns["is_selected_move_order_date"].Visible = false;
            this.DgvForSync.Columns["wh_checker_move_order_no"].Visible = false;
            this.DgvForSync.Columns["total_state_repack_cancelled_qty"].Visible = false;
            this.DgvForSync.Columns["logic_return_by"].Visible = false;

            this.DgvForSync.Columns["logic_return_by"].Visible = false;
            this.DgvForSync.Columns["logic_return_date"].Visible = false;
            this.DgvForSync.Columns["logic_return_reason"].Visible = false;
            this.DgvForSync.Columns["time_stamp_update"].Visible = false;
            this.DgvForSync.Columns["Fk_dry_wh_orders_parent_id"].Visible = false;

        }



        private void ValidateTheFuckingCutOfftimeWithButtonControlls()
        {

            try
            {
                TimeSpan start;
                TimeSpan now;
                TimeSpan end;
                start = DateTime.ParseExact(DateFrom, "h:mm:ss tt", CultureInfo.InvariantCulture).TimeOfDay;
                end = DateTime.ParseExact(DateTo, "hh:mm:ss tt", CultureInfo.InvariantCulture).TimeOfDay;
                now = DateTime.ParseExact(this.matlblTime.Text, "hh:mm:ss tt", CultureInfo.InvariantCulture).TimeOfDay;


                if ((now > start) && (now < end))
                {
                    //match found
                    //MessageBox.Show("Pukenism");
                    this.matbtnUpload.Enabled = true;
                }
                else

                {
                    //MessageBox.Show("Bilatnism");
                    this.matbtnUpload.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

         
        }


        private void showCutOffStoreOrders()    //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(this.dgvStoreOrdersCutOff, "TblStoreOrderManageSyncingSpMinor", dSet);

                this.lbltotalrecords.Text = this.dgvStoreOrder.RowCount.ToString();
                //this.MatRadio1.Text = "Available for syncing" + ":" + (lbltotalrecords.Text);

           
                //this.lbltotalrecords.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.dgvStoreOrdersCutOff.Columns["is_active"].Visible = false;
            this.dgvStoreOrdersCutOff.Columns["added_by"].Visible = false;
            this.dgvStoreOrdersCutOff.Columns["date_added"].Visible = false;
        }



        private void  MainLoader()
        {
            this.lbltotalrecords.Text = this.dgvStoreOrder.RowCount.ToString();
        }
        private void GetStoreOrders()
        {
            try
            {
                this.dgvStoreOrder.DataSource = GetRESTData("https://genus.rdfmis.ph/StoreAPI/api/orders.php?token=8AFASbzK5OH0E9OuZF5LlI9qZo8fqr1X&from=" + dtpfrom.Text + "&to=" + dtpto.Text + "");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

    
   

       

        }

        private void LoadFilterAlreadySync()
        {
            //this.RowCountAPiOrder = Convert.ToInt32(this.lbltotalrecords.Text);

            //for (int i = 0; i < RowCountAPiOrder; i++)
            //{

            //    textBox1.Text = i.ToString();
            //    this.RemoveAlreadyUpload();
            //}
            this.RemoveRowLoop();
        }


        void InsertDuplicateEntry()
        {
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                Convert.ToInt32(sp_order_id),
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",

                 Convert.ToInt32(user_id).ToString(),
                 SpdateNeeded,
                "add-duplicate-entry");
        }
        private void RemoveRowLoop()
        {
            try
            {
                dSet.Clear();
                dSet = objStorProc.sp_dry_wh_orders(0,
                    Convert.ToInt32(sp_order_id),
                    sp_date_ordered,
                    sp_fox,
                    sp_store_name,
                    sp_route,
                    sp_area,
                    sp_category,
                    sp_item_code,
                    sp_description,
                    sp_uom,
                    sp_qty,
                    "1",
                    "",
                    "",
                    "",
                    "getbyorderid_api");

                if (dSet.Tables[0].Rows.Count > 0)
                {

                    if(dgvStoreOrder.Rows.Count > 0) { this.CallChange(); }
         
                    else
                    {
                        return;
                    }

                    //MessageBox.Show("Ax" + sp_order_id);
                    this.InsertDuplicateEntry();
                    dgvStoreOrder.Rows.RemoveAt(this.dgvStoreOrder.SelectedRows[0].Index);

                }
                else
                {
                    if (this.dgvStoreOrder.Rows.Count >= 1)
                    {
                        int i = this.dgvStoreOrder.CurrentRow.Index + 1;
                        if (i >= -1 && i < this.dgvStoreOrder.Rows.Count)
                            this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[i].Cells[0];
                        else
                        {

              
                            this.lbltotalrecords.Text = this.dgvStoreOrder.RowCount.ToString();
                            //this.MatRadio1.Text = "Available for syncing" + ":" + (lbltotalrecords.Text);
                    
                            this.matRadio0.Text = "API" + ":" + (lbltotalrecords.Text);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


    
       
         
            this.RemoveRowLoop();
        }
        void CallChange()
        {
            this.lbltotalrecords.Text = (this.dgvStoreOrder.RowCount - 1).ToString();
            this.MatRadio1.Text = "Available for syncing" + ":" + (lbltotalrecords.Text);
        }
        private void dgvStoreOrder_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvStoreOrder.CurrentRow != null)
            {
                if (this.dgvStoreOrder.CurrentRow.Cells["store_name"].Value != null)
                {
                    this.sp_order_id = this.dgvStoreOrder.CurrentRow.Cells["id"].Value.ToString();
                    this.sp_date_ordered = this.dgvStoreOrder.CurrentRow.Cells["date_ordered"].Value.ToString();
                    this.sp_fox = this.dgvStoreOrder.CurrentRow.Cells["store_code"].Value.ToString();
                    this.sp_store_name = this.dgvStoreOrder.CurrentRow.Cells["store_name"].Value.ToString();
                    this.sp_route = this.dgvStoreOrder.CurrentRow.Cells["route"].Value.ToString();
                    this.sp_area = this.dgvStoreOrder.CurrentRow.Cells["area"].Value.ToString();
                    this.sp_category = this.dgvStoreOrder.CurrentRow.Cells["category"].Value.ToString();
                    this.sp_item_code = this.dgvStoreOrder.CurrentRow.Cells["item_code"].Value.ToString();
                    this.sp_description = this.dgvStoreOrder.CurrentRow.Cells["description"].Value.ToString();
                    this.sp_uom = this.dgvStoreOrder.CurrentRow.Cells["uom"].Value.ToString();
                    this.sp_qty = this.dgvStoreOrder.CurrentRow.Cells["qty"].Value.ToString();
                    this.SpdateNeeded = this.dgvStoreOrder.CurrentRow.Cells["dateNeeded"].Value.ToString();
                    this.sp_fox2 = this.dgvStoreOrder.CurrentRow.Cells["store_code"].Value.ToString();
                    this.sp_route2 = this.dgvStoreOrder.CurrentRow.Cells["route"].Value.ToString();
                    this.sp_area2 = this.dgvStoreOrder.CurrentRow.Cells["area"].Value.ToString();
                    if (this.lbltotalrecords.Text == "0")
                    {

                    }
                    else
                    {
                        this.mat_row_number = Convert.ToInt32(this.dgvStoreOrder.CurrentCell.RowIndex).ToString();
                    }
           


                }
            }
        }



        private void matbtnUpload_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sp_order_id.ToString());
            if (this.lbltotalrecords.Text == "0") { }
            else {
                this.SubMode = 0;
          

            }
            //this.SubMode = 0;
            if (this.lbltotalrecords.Text == "0") { return; }
            if (this.matRadio0.Checked == true || this.MatRadio1.Checked == true)
            {
                this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to sync the data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.dgvStoreOrder_CurrentCellChanged(sender, e);
                        this.SaveMethod1();
           
                }
                else
                {
                    return;
                }
                //End
            }
            //else if (this.MatRadio3.Checked == true)
            //{
            //    this.dgvSubCategory.CurrentCell = this.dgvSubCategory.Rows[0].Cells[this.dgvSubCategory.CurrentCell.ColumnIndex];
            //    //Start
            //    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to sync the data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
           
            //            this.SaveMethodPendingInformations();
               
            //    }
            //    else
            //    {
            //        return;
            //    }
            
            //}


        }


        //private void InsertDataPerRow()
        //{

        //    dSet.Clear();
        //    dSet = objStorProc.sp_dry_wh_orders(0,
        //        0,
        //        sp_date_ordered,
        //        sp_fox,
        //        sp_store_name,
        //        sp_route,
        //        sp_area,
        //        sp_category,
        //        sp_item_code,
        //        sp_description,
        //        sp_uom,
        //        sp_qty,
        //        "1",
        //        "",
     
        //         Convert.ToInt32(user_id).ToString(),
        //        this.SpdateNeeded,
        //        "add");



        //    if (this.dgvStoreOrder.Rows.Count >= 1)
        //    {
        //        int i = this.dgvStoreOrder.CurrentRow.Index + 1;
        //        if (i >= -1 && i < this.dgvStoreOrder.Rows.Count)
        //            this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[i].Cells[0];
        //        else
        //        {


        //            if (mode == "error")
        //            {
        //                this.GlobalStatePopup.ErrorNotify("");
        //            }
        //            else
        //            {

        //                this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];

        //                this.GlobalStatePopup.ImportSuccessFully();

        //            }


        //            this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
        //            return;
        //        }
        //    }

        //    this.InsertDataPerRow();
        //}

        private void SaveMethod1()
        {
            this.circularProgressBar1.Visible = true;

            //Check The store Code Area and Route if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox2,
                sp_store_name,
                sp_route2,
                sp_area2,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "getbystore_code_store_are_store_route");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
            }
            else
            {
                this.haserror = 1;
                mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["store_code"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["store_code"].Style.BackColor = Color.DarkOrange;
            }



            //Check The Item Code if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "getby_item_code");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
            }
            else
            {
                this.haserror = 2;
                mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["item_code"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["item_code"].Style.BackColor = Color.DarkOrange;

            }

            //Check The Area if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_area_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
            }
            else
            {
                this.haserror = 3;
                mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["area"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["area"].Style.BackColor = Color.DarkOrange;

            }

            //Check The Route if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_route_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
            }
            else
            {
                this.haserror = 4;
                this.mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["route"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["route"].Style.BackColor = Color.DarkOrange;
            }

            //Check The Sub Category if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_sub_category");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
            }
            else
            {
                this.haserror = 5;
                this.mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["category"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["category"].Style.BackColor = Color.DarkOrange;

            }

            //Check The Primary Unit if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_Primary_Unit");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
          
            }
            else
            {
                this.haserror = 6;
                mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["uom"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["uom"].Style.BackColor = Color.DarkOrange;


            }

            //Validate Quantity if Number Gago!
            decimal d2;
            if (decimal.TryParse(sp_qty, out d2))
            {


            }
            else
            {
                this.haserror = 7;
                mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["qty"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["qty"].Style.BackColor = Color.DarkOrange;
            }
            //MessageBox.Show(sp_order_id.ToString());

            //Check The if store order already created at the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                Convert.ToInt32(sp_order_id),
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "getbyorderid_api");

            if (dSet.Tables[0].Rows.Count > 0)
            {

                this.haserror = 8;
                mode = "error";
                this.SubMode = 1;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["id"].Style.SelectionBackColor = Color.DarkOrange;
                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].Cells["id"].Style.BackColor = Color.DarkOrange;
            }
            else
            {
                //if (mode == "error")

                if (this.MatRadio1.Checked == true)
                {
                    //MessageBox.Show(sp_order_id.ToString() + "Save");
                    dSet.Clear();
                    dSet = objStorProc.sp_dry_wh_orders(0,
                    Convert.ToInt32(sp_order_id),
                    sp_date_ordered,
                    sp_fox,
                    sp_store_name,
                    sp_route,
                    sp_area,
                    sp_category,
                    sp_item_code,
                    sp_description,
                    sp_uom,
                    sp_qty,
                    "1",
                    "",
                    Convert.ToInt32(user_id).ToString(),
                    SpdateNeeded,
                    "add");
                }


                if (this.haserror == 0)
                    {
      
                    //if (this.MatRadio1.Checked == true)
                    //{
                    //    MessageBox.Show(sp_order_id.ToString() + "Save");
                    //    dSet.Clear();
                    //        dSet = objStorProc.sp_dry_wh_orders(0,
                    //        Convert.ToInt32(sp_order_id),
                    //        sp_date_ordered,
                    //        sp_fox,
                    //        sp_store_name,
                    //        sp_route,
                    //        sp_area,
                    //        sp_category,
                    //        sp_item_code,
                    //        sp_description,
                    //        sp_uom,
                    //        sp_qty,
                    //        "1",
                    //        "",
                    //        Convert.ToInt32(user_id).ToString(),
                    //        SpdateNeeded,
                    //        "add");
                    //    }

                    if (this.matRadio0.Checked == true)
                    {

                        //Check The if store order already created at the system
                        dSet.Clear();
                        dSet = objStorProc.sp_dry_wh_orders(0,
                            Convert.ToInt32(sp_order_id),
                            sp_date_ordered,
                            sp_fox,
                            sp_store_name,
                            sp_route,
                            sp_area,
                            sp_category,
                            sp_item_code,
                            sp_description,
                            sp_uom,
                            sp_qty,
                            "1",
                            "",
                            "",
                            "",
                            "getbyorderid_api");

                        if (dSet.Tables[0].Rows.Count > 0)
                        {
                        }
                        else
                        {

                            dSet.Clear();
                            dSet = objStorProc.sp_dry_wh_orders(0,
                            Convert.ToInt32(sp_order_id),
                            sp_date_ordered,
                            sp_fox,
                            sp_store_name,
                            sp_route,
                            sp_area,
                            sp_category,
                            sp_item_code,
                            sp_description,
                            sp_uom,
                            sp_qty,
                            "1",
                            "",
                            Convert.ToInt32(user_id).ToString(),
                            SpdateNeeded,
                            "add-good-entry");
                        }
                    }

                    }

                    //}
                    else
                    {
                    if (this.SubMode == 0)
                    {
       
                    }
                    else if (this.matRadio0.Checked == true)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_dry_wh_orders(0,
                           Convert.ToInt32(sp_order_id),
                            sp_date_ordered,
                            sp_fox,
                            sp_store_name,
                            sp_route,
                            sp_area,
                            sp_category,
                            sp_item_code,
                            sp_description,
                            sp_uom,
                            sp_qty,
                            "1",
                            "",
                             Convert.ToInt32(user_id).ToString(),
                                     SpdateNeeded,
                            "add_validation");
                    }
                        //MessageBox.Show("B");



                    }
                
            }



            if (this.dgvStoreOrder.Rows.Count >= 1)
            {
    

                int i = this.dgvStoreOrder.CurrentRow.Index + 1;



                //Start Condition percentage is: (value/total value)×100%.
                //Thread.Sleep(5);

                if (this.matRadio0.Checked == true)
                {
                    double Index;

                    double b;
                    double answer;
                    double devide_answer;

                    Index = double.Parse(i.ToString());

                    b = double.Parse(dgvStoreOrder.RowCount.ToString());
                    answer = Index / b;
                    devide_answer = answer * 100;

                    this.circularProgressBar1.Text = devide_answer.ToString("N0");
                    circularProgressBar1.Value = Convert.ToInt32(devide_answer);
                    circularProgressBar1.Update();
                }
                //End
                if (i >= -1 && i < this.dgvStoreOrder.Rows.Count)
                    this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[i].Cells[0];

                else
                {
                    this.StoreOrderReset = 1;
                    if (mode == "error")
                    {
                        if (this.MatRadio1.Checked == true)
                        {
                            this.GlobalStatePopup.SuccessFullySave();
                        }
                        else
                        {
                            this.GlobalStatePopup.ErrorNotify("");
                        }
                        this.ConnectionInit();
                        this. showDryWhPendingOrders();
                        this.showDryWhPendingReceived();
                        this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
  
                    }
                    else
                    {


                        this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
                        //this.SaveMethodPendingInformations();

                        frmStoreOrderRestAPIcall_Load(new object(), new System.EventArgs());
                    }
         
                    this.ConnectionInit();

                    //Available For Syncing Method();
                   this.showDryWhForSyncing();
                    this.MatRadio1.Text = "Available for syncing" + ":" + (DgvForSync.RowCount.ToString());
                    //Duplicate Data
                    this.ReceivedInformation = this.DgvReceivedOrder.RowCount;
                    this.MatRadio2.Text = "Duplicated Lists" + ":" + (this.ReceivedInformation);
                    this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
                    //Reset the API
                    this.lbltotalrecords.Text = "0";
                    this.matRadio0.Text = "API" + ":" + (lbltotalrecords.Text);
                    this.circularProgressBar1.Visible = false;

                    if (this.MatRadio1.Checked == true)
                    {
                        this.RemoveItemForValidation();
                        this.showDryWhPendingOrders();
                    }


                    return;
                }
            }
            //MessageBox.Show(this.haserror.ToString());
            this.haserror = 0;
            this.SaveMethod1();
        }

        private void RemoveItemForValidation()
        {
        
                dSet.Clear();
                dSet = objStorProc.sp_dry_wh_orders(0,
                   Convert.ToInt32(sp_order_id),
                    sp_date_ordered,
                    sp_fox,
                    sp_store_name,
                    sp_route,
                    sp_area,
                    sp_category,
                    sp_item_code,
                    sp_description,
                    sp_uom,
                    sp_qty,
                    "1",
                    "",
                     Convert.ToInt32(user_id).ToString(),
                             SpdateNeeded,
                    "dry_wh_orders_unset");
            
        }

        private void LoadTotalRecords()
        {
            var answer = Convert.ToInt32(this.lbltotalrecords.Text) - this.InvalidInformation;
            this.lbltotalrecords.Text = answer.ToString();
            this.MatRadio1.Text = "Available for syncing" + ":" + (lbltotalrecords.Text);
        }


        private void SaveMethodPendingInformations()
        {
            //Check The store if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                mode = "error";

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The store Code Area and Route if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "getbystore_code_store_are_store_route");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                mode = "error";

               this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }

            //Check The Item Code if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "getby_item_code");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                mode = "error";

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Area if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_area_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;

            }
            else
            {
                mode = "error";

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Route if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_route_name");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();
                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                this.mode = "error";

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Sub Category if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_sub_category");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                //RawMatsAlreadyExist();

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;


            }
            else
            {
                this.mode = "error";

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Check The Primary Unit if existg on the system
            dSet.Clear();
            dSet = objStorProc.sp_dry_wh_orders(0,
                0,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                "",
                "",
                "get_Primary_Unit");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                mode = "error";

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Validate Quantity if Number Gago!
            decimal d2;
            if (decimal.TryParse(sp_qty, out d2))
            {

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            }
            else
            {

                mode = "error";

                this.dgvSubCategory.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }


         
                if (this.TotalValidData == 4)
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_dry_wh_orders(this.PrimaryIdentity,
                        Convert.ToInt32(sp_order_id),
                        sp_date_ordered,
                        sp_fox,
                        sp_store_name,
                        sp_route,
                        sp_area,
                        sp_category,
                        sp_item_code,
                        sp_description,
                        sp_uom,
                        sp_qty,
                        "1",
                        "",

                         Convert.ToInt32(user_id).ToString(),
                         SpdateNeeded,
                        "update_activation_pending_info");
                }
          


            if (this.dgvSubCategory.Rows.Count >= 1)
            {
                int i = this.dgvSubCategory.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvSubCategory.Rows.Count)
                    this.dgvSubCategory.CurrentCell = this.dgvSubCategory.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.GlobalStatePopup.UpdatedSuccessfully();
                        this.ConnectionInit();
                        this.SubOrdersMenu();
                    }
                    else
                    {
                        this.dgvSubCategory.CurrentCell = this.dgvSubCategory.Rows[0].Cells[this.dgvSubCategory.CurrentCell.ColumnIndex];
                        frmStoreOrderRestAPIcall_Load(new object(), new System.EventArgs());
                    }

                    this.dgvSubCategory.CurrentCell = this.dgvSubCategory.Rows[0].Cells[this.dgvSubCategory.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.SaveMethodPendingInformations();
        }


        private void dgvStoreOrdersCutOff_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvStoreOrdersCutOff.Rows.Count > 0)
            {
                if (this.dgvStoreOrdersCutOff.CurrentRow != null)
                {
                    if (this.dgvStoreOrdersCutOff.CurrentRow.Cells["time_from_desc"].Value != null)
                    {
                       
                        this.DateFrom = this.dgvStoreOrdersCutOff.CurrentRow.Cells["time_from_desc"].Value.ToString();
                        this.DateTo = this.dgvStoreOrdersCutOff.CurrentRow.Cells["time_from_to"].Value.ToString();


                    }
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages["tabPage1"])//your specific tabname
            {
                // your stuff
                //MessageBox.Show("A");
            }
            else if (materialTabControl1.SelectedTab == materialTabControl1.TabPages["tabPage2"])//your specific tabname
            {

                //MessageBox.Show("B");
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages["tabPage1"])//your specific tabname
            {
                this.matbtnUpload.Visible = true;
                this.matRadio0.Checked = true;
               this.matRadio0_CheckedChanged(sender, e);
          
            }
            else if (materialTabControl1.SelectedTab == materialTabControl1.TabPages["tabPage2"])//your specific tabname
            {
                this.matbtnUpload.Visible = false;
                this.MatRadio2.Checked = true;
                MatRadio2_CheckedChanged(sender, e);
    
            }
            else if (materialTabControl1.SelectedTab == materialTabControl1.TabPages["tabPage3"])//your specific tabname
            {
                this.matbtnUpload.Visible = true;
                this.MatRadio3.Checked = true;
                MatRadio3_CheckedChanged(sender, e);
             
            }
            else if (materialTabControl1.SelectedTab == materialTabControl1.TabPages["tabPage4"])//your specific tabname
            {
                this.matbtnUpload.Visible = true;
                this.MatRadio1.Checked = true;
                this.MatRadio1_CheckedChanged(sender, e);

            }
        }

        private void MatRadio1_CheckedChanged(object sender, EventArgs e)
        {
            this.matbtnUpload.Visible = true;
            materialTabControl1.SelectedTab = materialTabControl1.TabPages["tabPage4"];

          
            showDryWhForSyncing();

            this.MatRadio1.Text = "Available for syncing" + ":" + (DgvForSync.RowCount.ToString());
            //if (this.lbltotalrecords.Text == "0")
            //{

            //}else { showDryWhForSyncing(); }
        }

        private void MatRadio3_CheckedChanged(object sender, EventArgs e)
        {
            this.matbtnUpload.Visible = true;
            materialTabControl1.SelectedTab = materialTabControl1.TabPages["tabPage3"];
            this.showDryWhPendingOrders();
            //this.LoadTotalRecords();
        }

        private void showDryWhPendingOrders()      //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(this.dgvSubCategory, "dry_wh_orders_pending", dSet);

                this.InvalidInformation = this.dgvSubCategory.RowCount;
                this.MatRadio3.Text = "Invalid Information" + ":" + (this.InvalidInformation);
            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.dgvSubCategory.Columns["StoreCodeCount"].Visible = false;
            this.dgvSubCategory.Columns["CategoryCount"].Visible = false;
            this.dgvSubCategory.Columns["ItemCodeCount"].Visible = false;
            this.dgvSubCategory.Columns["UOMCount"].Visible = false;
            this.dgvSubCategory.Columns["TOTALVALIDDATA"].Visible = false;

            total = 0;
            total = dgvSubCategory.Rows.Cast<DataGridViewRow>()
            .Where(t => Convert.ToInt32(t.Cells["TOTALVALIDDATA"].Value) == 4)
            .Sum(t2 => Convert.ToInt32(t2.Cells["TOTALVALIDDATA"].Value) / 4);
                   
            this.lblCountPendingForSyncing.Text = total.ToString();

            this.MakeLabelRounded();
        }

        private void MakeLabelRounded()
        {

            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(0, 0, lblCountPendingForSyncing.Width, lblCountPendingForSyncing.Height);

            lblCountPendingForSyncing.Region = new Region(gp);

            lblCountPendingForSyncing.Invalidate();

        }



        private void MatRadio2_CheckedChanged(object sender, EventArgs e)
        {
            this.matbtnUpload.Visible = false;
            this.showDryWhPendingReceived();
            materialTabControl1.SelectedTab = materialTabControl1.TabPages["tabPage2"];
        }

        private void dgvSubCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvSubCategory.CurrentRow != null)
            {
                if (this.dgvSubCategory.CurrentRow.Cells["store_name_invalid"].Value != null)
                {
                    this.sp_order_id = this.dgvSubCategory.CurrentRow.Cells["order_id_invalid"].Value.ToString();
                    this.sp_date_ordered = this.dgvSubCategory.CurrentRow.Cells["date_ordered_invalid"].Value.ToString();
                    this.sp_fox = this.dgvSubCategory.CurrentRow.Cells["fox_invalid"].Value.ToString();
                    this.sp_store_name = this.dgvSubCategory.CurrentRow.Cells["store_name_invalid"].Value.ToString();
                    this.sp_route = this.dgvSubCategory.CurrentRow.Cells["route_invalid"].Value.ToString();
                    this.sp_area = this.dgvSubCategory.CurrentRow.Cells["area_invalid"].Value.ToString();
                    this.sp_category = this.dgvSubCategory.CurrentRow.Cells["category_invalid"].Value.ToString();
                    this.sp_item_code = this.dgvSubCategory.CurrentRow.Cells["item_code_invalid"].Value.ToString();
                    this.sp_description = this.dgvSubCategory.CurrentRow.Cells["description_invalid"].Value.ToString();
                    this.sp_uom = this.dgvSubCategory.CurrentRow.Cells["uom_invalid"].Value.ToString();
                    this.sp_qty = this.dgvSubCategory.CurrentRow.Cells["qty_invalid"].Value.ToString();
                    this.SpdateNeeded = this.dgvSubCategory.CurrentRow.Cells["dateNeeded_invalid"].Value.ToString();
                    this.PrimaryIdentity = Convert.ToInt32(this.dgvSubCategory.CurrentRow.Cells["primary_id"].Value);
                    this.TotalValidData = Convert.ToInt32(this.dgvSubCategory.CurrentRow.Cells["TOTALVALIDDATA"].Value);
                        
                    if (this.lbltotalrecords.Text == "0")
                    {

                    }
                    else
                    {
                        this.mat_row_number = Convert.ToInt32(this.dgvSubCategory.CurrentCell.RowIndex).ToString();
                    }

                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.matbtnUpload.Enabled = true;
        }

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("A");
            this.dtpto.MinDate = Convert.ToDateTime(dtpfrom.Text);
            this.dtpto.Text = dtpfrom.Text;
  
            this.GetStoreOrders();

         
            this.LoadFilterAlreadySync();
            //this.lbltotalrecords.Text = "0";
            //this.MatRadio1.Text = "Available for syncing" + ":" + (lbltotalrecords.Text);
            //this.StoreOrderReset = 0;
            //this.MatRadio1.Text = "Available for syncing" + ":" + 0;

            //this.MatRadio1.Text = "Available for syncing" + ":" + (DgvForSync.RowCount.ToString());
            this.matRadio0.Text = "API" + ":" + (this.dgvStoreOrder.RowCount.ToString());
            this.dtpto.Enabled = true;
            this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
        }

        private void dtpto_ValueChanged(object sender, EventArgs e)
        {
            this.GetStoreOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new row first as it will include the columns you've created at design-time.

            int rowId = DgvReceivedOrder.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = DgvReceivedOrder.Rows[rowId];

            // Add the data
            row.Cells["Column1"].Value = "Value1";
            row.Cells["Column2"].Value = "Value2";
        }

        private void frmStoreOrderRestAPIcall_FormClosing(object sender, FormClosingEventArgs e)
        {
          
                dSet.Clear();
                dSet = objStorProc.sp_dry_wh_orders(0,
                Convert.ToInt32(sp_order_id),
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                "1",
                "",
                Convert.ToInt32(user_id).ToString(),
                SpdateNeeded,
                "dry_wh_orders_unset");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDryWhForSyncing();
        }

        private void matRadio0_CheckedChanged(object sender, EventArgs e)
        {
            this.matbtnUpload.Visible = true;
            materialTabControl1.SelectedTab = materialTabControl1.TabPages["tabPage1"];

            this.showCutOffStoreOrders();

     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {

                Thread.Sleep(5);
                this.circularProgressBar1.Text = i.ToString();
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }

        }
    }
}
