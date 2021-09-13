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

        private void frmLocation_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            myglobal.global_module = "Active"; // Mode for Searching
            showLocationData();
            SearchMethodJarVarCallingSP();
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
     
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("LocationMajor");

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
                    dgvLocation.DataSource = dv;
                    lbltotalrecords.Text = dgvLocation.RowCount.ToString();
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
                ready = false;
                xClass.fillDataGridView(dgvLocation, "Location", dSet);
                ready = true;
                lbltotalrecords.Text = dgvLocation.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dgvItemType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;
            txtmatLocation.Enabled = true;
            matBtnNew.Visible = false;
            txtmatLocation.Text = String.Empty;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;

            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmatLocation.Select();
            txtmatLocation.Focus();
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
            txtCreatedAt.Text = String.Empty;
            txtCreatedBy.Text = String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmatLocation.Enabled = false;
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
            popup.ContentText = "Location Already Exist!";
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

                    dSet.Clear();
                    dSet = objStorProc.sp_Location(0,
                        txtmatLocation.Text.Trim(),

                        txtCreatedAt.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(), "add");

                    showLocationData();


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

                            txtCreatedAt.Text.Trim(),
                            txtCreatedBy.Text.Trim(),
                            txtModifiedAt.Text.Trim(),
                            txtModifiedBy.Text.Trim(), "edit");
                        UpdateNotifications();
                        showLocationData();
                        mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {

                        txtmatLocation.Text = String.Empty;
                        txtmatLocation.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_Location(p_id,
                        txtmatLocation.Text.Trim(),

                          txtCreatedAt.Text.Trim(),
                          txtCreatedBy.Text.Trim(),
                          txtModifiedAt.Text.Trim(),
                          txtModifiedBy.Text.Trim(), "edit");
                    UpdateNotifications();
                    showLocationData();
                    mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Location(p_id,
                   txtmatLocation.Text, "", "", "", "", "delete");

                return true;
            }
            return false;
        }


        private void matBtnDelete_Click(object sender, EventArgs e)
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

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmatLocation.Enabled = true;
            txtmatLocation.Focus();
        }

        private void matBtnSave_Click(object sender, EventArgs e)
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



                if (txtmatLocation.Text.Trim() == string.Empty)
                {

                    FillRequiredFields();
                    txtmatLocation.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvLocation.CurrentCell = dgvLocation[0, dgvLocation.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                            dgvLocation.CurrentCell = dgvLocation[0, temp_hid];

                        }
                        matBtnCancel_Click(sender, e);
                        UpdateNotifications();
                    }
                    else

                        metroFinalSaving_Click(sender, e);
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
            if (txtmatLocation.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtmatLocation.Focus();
            }
            else
            {
                if (saveMode())
                {
                    LocationAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvLocation.CurrentCell = dgvLocation[0, dgvLocation.Rows.Count - 1];

                    }
                    else
                    {
                        dgvLocation.CurrentCell = dgvLocation[0, temp_hid];
                    }
                    matBtnCancel_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void dgvLocation_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }


        private void showValueCell()
        {
            if (dgvLocation.Rows.Count > 0)
            {
                if (dgvLocation.CurrentRow != null)
                {
                    if (dgvLocation.CurrentRow.Cells["location_name"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvLocation.CurrentRow.Cells["location_id"].Value);
                        txtmatLocation.Text = dgvLocation.CurrentRow.Cells["location_name"].Value.ToString();
                        txtCreatedBy.Text = dgvLocation.CurrentRow.Cells["created_by"].Value.ToString();
                        txtCreatedAt.Text = dgvLocation.CurrentRow.Cells["created_at"].Value.ToString();
                        txtModifiedAt.Text = dgvLocation.CurrentRow.Cells["updated_at"].Value.ToString();
                        txtModifiedBy.Text = dgvLocation.CurrentRow.Cells["updated_by"].Value.ToString();
                    }
                }
            }
        }

        private void neww_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;
            txtmatLocation.Enabled = true;
            matBtnNew.Visible = false;
            txtmatLocation.Text = String.Empty;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;

            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmatLocation.Select();
            txtmatLocation.Focus();
        }

        private void editt_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmatLocation.Enabled = true;
            txtmatLocation.Focus();
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
            matBtnCancel.Visible = false;
            mode = "";
            txtCreatedAt.Text = String.Empty;
            txtCreatedBy.Text = String.Empty;
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
