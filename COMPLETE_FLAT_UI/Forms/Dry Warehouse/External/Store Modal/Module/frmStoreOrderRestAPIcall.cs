using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreOrderRestAPIcall : MaterialForm
    {
        myclasses xClass = new myclasses();
        DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        IStoredProcedures objStorProc = null;

        myclasses myClass = new myclasses();
        string mode = "";
        public frmStoreOrderRestAPIcall()
        {
            InitializeComponent();
        }
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

        public string sp_user_id { get; set; }


        //Expirable
        public string sp_is_expirable { get; set; }
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
            this.GetStoreOrders();
            this.MainLoader();
           
            this.objStorProc = xClass.g_objStoredProc.GetCollections();
            this.user_id = userinfo.user_id;
            this.showCutOffStoreOrders();
            this.matlblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            this.matlblTime.Visible = false;
            this.ValidateTheFuckingCutOfftimeWithButtonControlls();
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

                xClass.fillDataGridView(this.dgvStoreOrdersCutOff, "TblStoreOrderManageSyncingSpMinor", dSet);

                this.lbltotalrecords.Text = this.dgvStoreOrder.RowCount.ToString();
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
            this.dgvStoreOrder.DataSource = GetRESTData("https://genus.rdfmis.ph/StoreAPI/api/orders.php?token=8AFASbzK5OH0E9OuZF5LlI9qZo8fqr1X");
      
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
                    if (this.lbltotalrecords.Text == "0")
                    {

                    }
                    else
                    {
                        this.mat_row_number = Convert.ToInt32(this.dgvStoreOrder.CurrentCell.RowIndex).ToString();
                    }
                    //mattxtSearch_TextChanged(sender, e);


                }
            }
        }

        private void ErrorNotify()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Uploading Interupt Check the data to proceed";
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


        private void matbtnUpload_Click(object sender, EventArgs e)
        {
  
           
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to sync? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.SaveMethod1();
            }
            else
            {
                return;
            }
            //End

        }
        private void SavedNotify()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Uploaded Successfully";
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

        private void InsertDataPerRow()
        {










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
                 Convert.ToInt32(user_id).ToString(),
                "add");



            if (this.dgvStoreOrder.Rows.Count >= 1)
            {
                int i = this.dgvStoreOrder.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvStoreOrder.Rows.Count)
                    this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.ErrorNotify();
                    }
                    else
                    {

                        this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
                        //this.saveMode();  //Update All Data here
                        this.SavedNotify();
                        //frmImportConsolidatedOrder_Load(new object(), new System.EventArgs());
                    }


                    this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.InsertDataPerRow();
        }

        private void SaveMethod1()
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
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";

                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

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
                //RawMatsAlreadyExist();




            }
            else
            {
                mode = "error";

                dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

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
                mode = "error";

                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

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
                mode = "error";

                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

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
                this.mode = "error";

                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

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
                this.mode = "error";

                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

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
                mode = "error";

                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;

            }

            //Validate Quantity if Number Gago!
            decimal d2;
            if (decimal.TryParse(sp_qty, out d2))
            {


            }
            else
            {

                mode = "error";

                this.dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;
            }


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
                //RawMatsAlreadyExist();

                mode = "error";

                dgvStoreOrder.Rows[Convert.ToInt32(mat_row_number)].DefaultCellStyle.BackColor = Color.DarkOrange;



            }
            else
            {
                if (mode == "error")
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_dry_wh_orders(0,
                       Convert.ToInt32( sp_order_id),
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
                         "",
                        "add_validation");
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
                        "",
                         Convert.ToInt32(user_id).ToString(),
                        "add");
                }
            }



            if (this.dgvStoreOrder.Rows.Count >= 1)
            {
                int i = this.dgvStoreOrder.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvStoreOrder.Rows.Count)
                    this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[i].Cells[0];
                else
                {


                    if (mode == "error")
                    {
                        this.ErrorNotify();
                    }
                    else
                    {


                        this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
                        //this.InsertDataPerRow();
                        //MessageBox.Show("OK");
                        frmStoreOrderRestAPIcall_Load(new object(), new System.EventArgs());
                    }


                    this.dgvStoreOrder.CurrentCell = this.dgvStoreOrder.Rows[0].Cells[this.dgvStoreOrder.CurrentCell.ColumnIndex];
                    return;
                }
            }

            this.SaveMethod1();
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
    }
}
