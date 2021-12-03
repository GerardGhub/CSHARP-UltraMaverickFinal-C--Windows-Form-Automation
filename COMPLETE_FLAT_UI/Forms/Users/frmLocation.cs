using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmLocation : MaterialForm
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
        public frmLocation()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_by { get; set; }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            myglobal.global_module = "Active"; // Mode for Searching
            this.showLocationData();
            this.SearchMethodJarVarCallingSP();
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
     
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("LocationMajor");

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




                        dv.RowFilter = "location_name like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.dgvLocation.DataSource = dv;
                    this.lbltotalrecords.Text = dgvLocation.RowCount.ToString();
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

        private void showLocationData()     //method for loading available_menus
        {
            try
            {
                this.ready = false;
                this.xClass.fillDataGridView(this.dgvLocation, "Location", dSet);
                this.ready = true;
                this.lbltotalrecords.Text = this.dgvLocation.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dgvItemType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.sp_created_at = String.Empty;
           this.sp_created_by = String.Empty;
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.txtmatLocation.Enabled = false;
        }
        public void DeletedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Deleted Successfully";
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
        public void LocationAlreadyExist()
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

        private void UpdateNotifications()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "SUCCESSFULLY UPDATE FORM INFORMATION";
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
        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Location(0,
                    txtmatLocation.Text, "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    LocationAlreadyExist();

                    txtmatLocation.Text = string.Empty;
                    txtmatLocation.Focus();
                    return false;
                }
                else
                {

                    this.dSet.Clear();
                    this.dSet = objStorProc.sp_Location(0,
                        this.txtmatLocation.Text.Trim(),

                        this.sp_created_at,
                        this.sp_created_by,
                        this.sp_modified_at,
                        this.sp_modified_by,
                        "add");

                    this.showLocationData();


                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Location(0,
                txtmatLocation.Text,
                "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Location(p_id,
                txtmatLocation.Text, "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Location(p_id,
                        txtmatLocation.Text.Trim(),

                        this.sp_created_at,
                        this.sp_created_by,
                        this.sp_modified_at,
                        this.sp_modified_by,
                        "edit");
                        this.UpdateNotifications();
                        this.showLocationData();
                        this.mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {

                        this.txtmatLocation.Text = String.Empty;
                        this.txtmatLocation.Focus();
                        return false;
                    }
                }
                else
                {
                this.dSet.Clear();
                this.dSet = objStorProc.sp_Location(p_id,
                this.txtmatLocation.Text.Trim(),

                this.sp_created_at,
                this.sp_created_by,
                this.sp_modified_at,
                this.sp_modified_by,
                "edit");
                this.UpdateNotifications();
                this.showLocationData();
                this.mode = "";
                this.matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (this.mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Location(this.p_id,
                   this.txtmatLocation.Text, "", "", "", "", "delete");

                return true;
            }
            return false;
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
        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the  Location Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {



                if (this.txtmatLocation.Text.Trim() == string.Empty)
                {

                    this.FillRequiredFields();
                    this.txtmatLocation.Focus();
                    return;
                }

                else
                {
                    if (this.saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            this.dgvLocation.CurrentCell = this.dgvLocation[0, dgvLocation.Rows.Count - 1];
                            this.UpdateNotifications();
                        }
                        else
                        {
                            this.dgvLocation.CurrentCell = this.dgvLocation[0, temp_hid];

                        }
                        this.matBtnCancel_Click(sender, e);
                        this.UpdateNotifications();
                    }
                    else

                        this.metroFinalSaving_Click(sender, e);
                    return;
                }
            }

            else
            {
                return;
            }
        }

        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (this.txtmatLocation.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                this.txtmatLocation.Focus();
            }
            else
            {
                if (this.saveMode())
                {
                    this.LocationAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        this.dgvLocation.CurrentCell = dgvLocation[0, dgvLocation.Rows.Count - 1];

                    }
                    else
                    {
                        this.dgvLocation.CurrentCell = dgvLocation[0, temp_hid];
                    }
                    this.matBtnCancel_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void dgvLocation_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }


        private void showValueCell()
        {
            if (this.dgvLocation.Rows.Count > 0)
            {
                if (this.dgvLocation.CurrentRow != null)
                {
                    if (this.dgvLocation.CurrentRow.Cells["location_name"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvLocation.CurrentRow.Cells["location_id"].Value);
                        this.txtmatLocation.Text = this.dgvLocation.CurrentRow.Cells["location_name"].Value.ToString();
                        this.sp_created_by = this.dgvLocation.CurrentRow.Cells["created_by"].Value.ToString();
                        this.sp_created_at = this.dgvLocation.CurrentRow.Cells["created_at"].Value.ToString();
                        this.sp_modified_at = this.dgvLocation.CurrentRow.Cells["updated_at"].Value.ToString();
                        this.sp_modified_by = this.dgvLocation.CurrentRow.Cells["updated_by"].Value.ToString();
                    }
                }
            }
        }

        private void neww_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.txtmatLocation.Enabled = true;
            this.matBtnNew.Visible = false;
            this.txtmatLocation.Text = String.Empty;
            this.sp_modified_at = String.Empty;
            this.sp_modified_by = String.Empty;

            this.sp_created_at = (dNow.ToString("M/d/yyyy"));
          this.sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            this.matBtnSave.Visible = true;
            this.txtmatLocation.Select();
            this.txtmatLocation.Focus();
        }

        private void editt_Click(object sender, EventArgs e)
        {
            this.mode = "edit";
            this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
            this.sp_modified_by= userinfo.emp_name.ToUpper();
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;
            this.txtmatLocation.Enabled = true;
            this.txtmatLocation.Focus();
        }

        private void removee_Click(object sender, EventArgs e)
        {
            if (dgvLocation.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Location", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        showLocationData();

                        matBtnCancel_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }
        }

        private void cancells_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.sp_created_at = String.Empty;
            this.sp_created_by = String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmatLocation.Enabled = false;
        }

        private void savee_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_Location(0,
                txtmatLocation.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                LocationAlreadyExist();


                txtmatLocation.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {

            if (mattxtSearch.Text == "")
            {
                showLocationData();
            }
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                if (mode == "add")
                {

                }
                else
                {
                    doSearchInTextBoxCmb();
                }

            }
        }
    }
}
