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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmAVGOrderTrendSetup : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();

        public frmAVGOrderTrendSetup()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_updated_date { get; set; }
        public string sp_updated_by { get; set; }
        public string sp_bind_selected { get; set; }
        public string sp_added_by { get; set; }
        public string sp_date_added { get; set; }
        private void frmAVGOrderTrendSetup_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.showItemClassData();
            this.SearchMethodJarVarCallingSP();
        }
        private void showItemClassData()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvitemClass, "avg_order_trend", dSet);
                ready = true;
                lbltotalrecords.Text = dgvitemClass.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Item_Class_Major");
            //this.dgvitemClass.Columns["item_class_id"].Visible = false;
        }

        private void SearchMethodJarVarCallingSPInactive()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Item_Class_Major_Inactive");
            //this.dgvitemClass.Columns["item_class_id"].Visible = false;
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            //Mode
            this.mode = "add";
            //Edit
            this.matBtnEdit.Visible = false;
            //Cancel
            this.matBtnCancel.Visible = true;
            //TextBVox Enabled True
            this.txtmatavgdescription.Enabled = true;
            this.txtmatAverageqty.Enabled = true;
            //Button Visibility
            this.matBtnNew.Visible = false;
            this.matBtnDelete.Visible = false;
            this.matBtnSave.Visible = true;
            //String Textbox Empty
            this.txtmatavgdescription.Text = String.Empty;
            this.sp_updated_date = String.Empty;
            this.sp_updated_by = String.Empty;
           //Binding User Session Date ETC
            this.sp_date_added = (dNow.ToString("M/d/yyyy"));
            this.sp_added_by = userinfo.emp_name.ToUpper();
        
           //Focus Events 
            this.txtmatavgdescription.Select();
            this.txtmatavgdescription.Focus();
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            
            //Mode of System
            this.mode = "";

            //String Empty
            this.sp_created_at = String.Empty;
            this.sp_created_by = String.Empty;

            //Button Visibility
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.matBtnCancel.Visible = false;

            //Textbox Enabled Conditional Statement
            this.txtmatavgdescription.Enabled = false;
            this.txtmatAverageqty.Enabled = false;
        }

        public void DataAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Data Already Exist!";
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

  

        private void matBtnSave_Click(object sender, EventArgs e)
        {

            if (this.txtmatavgdescription.Text == String.Empty)
            {
                this.FillRequiredFields();
                this.txtmatavgdescription.Focus();
                return;
            }
            else if (this.txtmatAverageqty.Text == String.Empty)
            {
                this.FillRequiredFields();
                this.txtmatAverageqty.Focus();
                return;
            }

            dSet.Clear();
            dSet = objStorProc.sp_avg_order_trend(0, txtmatavgdescription.Text, 0, "", "","","", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.DataAlreadyExist();

                this.txtmatavgdescription.Text = String.Empty;
                this.txtmatavgdescription.Focus();
                return;
            }
            else
            {
                this.SaveProcessClicker();
            }
        }

        public void FillRequiredFields()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Fill up the required fields!";
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

        private void UpdateNotifications()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Save";
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
        private void SaveProcessClicker()
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the  Average Order Trend Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {



                if (txtmatavgdescription.Text.Trim() == string.Empty)
                {

                    this.FillRequiredFields();
                    this.txtmatavgdescription.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvitemClass.CurrentCell = dgvitemClass[0, dgvitemClass.Rows.Count - 1];
                            this.UpdateNotifications();
                        }
                        else
                        {
                            dgvitemClass.CurrentCell = dgvitemClass[0, temp_hid];

                        }
                        this.matBtnCancel_Click(new object(), new System.EventArgs());
                        this.UpdateNotifications();
                    }
                    else

                        this.MetroFinalSavingEntry();
                    return;
                }
            }

            else
            {
                return;
            }
        }

        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_avg_order_trend(0, txtmatavgdescription.Text.Trim(), Convert.ToInt32(txtmatAverageqty.Text), "", "", "","", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.DataAlreadyExist();

                    this.txtmatavgdescription.Text = string.Empty;
                    this.txtmatavgdescription.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_avg_order_trend(0, 
                        this.txtmatavgdescription.Text,
                        Convert.ToInt32(this.txtmatAverageqty.Text),
                        this.sp_added_by,
                        this.sp_date_added,
                        "", 
                        "",
                        "add");

                    this.showItemClassData();


                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_avg_order_trend(0, this.txtmatavgdescription.Text.Trim(), 
                    Convert.ToInt32(this.txtmatAverageqty.Text.Trim()), 
                    this.sp_added_by, 
                    this.sp_date_added, 
                    this.sp_updated_by, 
                    this.sp_updated_date, "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_avg_order_trend(p_id, 
                    this.txtmatavgdescription.Text.Trim(), 
                    Convert.ToInt32(this.txtmatAverageqty.Text.Trim()), "", "", "","", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_avg_order_trend(p_id, 
                            this.txtmatavgdescription.Text.Trim(),
                            Convert.ToInt32(this.txtmatAverageqty.Text.Trim()),
                            this.sp_added_by,
                            this.sp_date_added,
                           this.sp_updated_by,
                            this.sp_updated_date, "edit");
                        UpdateNotifications();
                        showItemClassData();
                        this.mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {
                      
                        this.txtmatavgdescription.Text = String.Empty;
                        this.txtmatavgdescription.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_avg_order_trend(p_id, this.txtmatavgdescription.Text.Trim(),
                        Convert.ToInt32(this.txtmatAverageqty.Text.Trim()),
                          this.sp_added_by,
                          this.sp_date_added,
                         this.sp_updated_by,
                          this.sp_updated_date, "edit");
                    UpdateNotifications();
                    showItemClassData();
                    mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (mode == "delete")
            {

                if (this.sp_bind_selected == "1")
                {

                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_avg_order_trend(p_id, this.txtmatavgdescription.Text, 
                        Convert.ToInt32(this.txtmatAverageqty.Text.Trim()), "", "", "","", "delete");

                    return true;
                }
                else
                {
                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_avg_order_trend(p_id, this.txtmatavgdescription.Text.Trim(),
                        Convert.ToInt32(this.txtmatAverageqty.Text.Trim()), "", "", "","", "delete_activation");
                    this.matRadioActive.Checked = true;
                    return true;
                }
            }
            return false;
        }


        private void MetroFinalSavingEntry()
        {
            if (this.txtmatavgdescription.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                this.txtmatavgdescription.Focus();
            }
            else
            {
                if (saveMode())
                {
                    this.DataAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvitemClass.CurrentCell = this.dgvitemClass[0, this.dgvitemClass.Rows.Count - 1];

                    }
                    else
                    {
                        this.dgvitemClass.CurrentCell = this.dgvitemClass[0, temp_hid];
                    }
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
                else

                    return;
            }
        }

        private void txtmatAverageqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
