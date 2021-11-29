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

namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    public partial class frmMajorCategory : MaterialForm
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

        public frmMajorCategory()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }

        private void frmMajorCategory_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
           
            this.showMajorCategoryData();
            this.SearchMethodJarVarCallingSP();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Major_CategoryMajor");

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




                        dv.RowFilter = "major_category_desc like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvMajorCategory.DataSource = dv;
                    lbltotalrecords.Text = dgvMajorCategory.RowCount.ToString();
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


        private void showMajorCategoryData()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvMajorCategory, "Major_Category", dSet);
                ready = true;
                lbltotalrecords.Text = dgvMajorCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.txtmajorCategory.Enabled = true;
           this.matBtnNew.Visible = false;
            this.txtmajorCategory.Text = String.Empty;
            this.sp_modified_at = String.Empty;
            this.sp_modified_by = String.Empty;

            this.sp_created_at = (dNow.ToString("M/d/yyyy"));
            this.sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            this.matBtnSave.Visible = true;
            this.txtmajorCategory.Select();
            this.txtmajorCategory.Focus();
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
            this.txtmajorCategory.Enabled = false;
        }

        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }

        private void showValueCell()
        {
            if (dgvMajorCategory.Rows.Count > 0)
            {
                if (dgvMajorCategory.CurrentRow != null)
                {
                    if (dgvMajorCategory.CurrentRow.Cells["major_category_desc"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(dgvMajorCategory.CurrentRow.Cells["major_category_id"].Value);
                        this.txtmajorCategory.Text = dgvMajorCategory.CurrentRow.Cells["major_category_desc"].Value.ToString();
                        this.sp_created_by = dgvMajorCategory.CurrentRow.Cells["mc_added_by"].Value.ToString();
                        this.sp_created_at = dgvMajorCategory.CurrentRow.Cells["mc_added_at"].Value.ToString();
                        this.sp_modified_at = dgvMajorCategory.CurrentRow.Cells["mc_updated_at"].Value.ToString();
                        this.sp_modified_by = dgvMajorCategory.CurrentRow.Cells["mc_updated_by"].Value.ToString();
                    }
                }
            }
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.mode = "edit";
            this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
            this.sp_modified_by = userinfo.emp_name.ToUpper();
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;
            this.txtmajorCategory.Enabled = true;
            this.txtmajorCategory.Focus();
        }

        public void MajorCategoryAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Major Category Already Exist!";
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
            dSet.Clear();
            dSet = objStorProc.sp_Major_Category(0, 
                txtmajorCategory.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.MajorCategoryAlreadyExist();


                this.txtmajorCategory.Focus();
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
        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the  Major Category Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {



                if (txtmajorCategory.Text.Trim() == string.Empty)
                {

                    FillRequiredFields();
                    txtmajorCategory.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvMajorCategory.CurrentCell = dgvMajorCategory[0, dgvMajorCategory.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                            dgvMajorCategory.CurrentCell = dgvMajorCategory[0, temp_hid];

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

        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Major_Category(0, txtmajorCategory.Text, "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    MajorCategoryAlreadyExist();

                    this.txtmajorCategory.Text = string.Empty;
                    this.txtmajorCategory.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_Major_Category(0, txtmajorCategory.Text.Trim(),

                        this.sp_created_by,
                        this.sp_created_at,
                        this.sp_modified_at,
                        this.sp_modified_by, "add");

                    showMajorCategoryData();
               

                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Major_Category(0, 
                    txtmajorCategory.Text, 
                    "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Major_Category(p_id, 
                    txtmajorCategory.Text, "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Major_Category(p_id, 
                            txtmajorCategory.Text.Trim(),

                            this.sp_created_by,
                            this.sp_created_at,
                           this.sp_modified_at,
                            this.sp_modified_by, "edit");
                        UpdateNotifications();
                        showMajorCategoryData();
                        mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {
                      
                        txtmajorCategory.Text = String.Empty;
                        txtmajorCategory.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_Major_Category(p_id, 
                        txtmajorCategory.Text.Trim(),

                         this.sp_created_by,
                          this.sp_created_at,
                          this.sp_modified_at,
                          this.sp_modified_by, "edit");
                    UpdateNotifications();
                    showMajorCategoryData();
                    mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Major_Category(p_id, 
                    txtmajorCategory.Text, "", "", "", "", "delete");

                return true;
            }
            return false;
        }


        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (this.txtmajorCategory.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                this.txtmajorCategory.Focus();
            }
            else
            {
                if (this.saveMode())
                {
                    this.MajorCategoryAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        this.dgvMajorCategory.CurrentCell = dgvMajorCategory[0, dgvMajorCategory.Rows.Count - 1];

                    }
                    else
                    {
                        this.dgvMajorCategory.CurrentCell = dgvMajorCategory[0, temp_hid];
                    }
                    this.matBtnCancel_Click(sender, e);
                }
                else

                    return;
            }
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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.txtmajorCategory.Enabled = true;
            this.matBtnNew.Visible = false;
            this.txtmajorCategory.Text = String.Empty;
            this.sp_modified_at = String.Empty;
           this.sp_modified_by = String.Empty;
            this.matBtnDelete.Visible = false;
           this.sp_created_at = (dNow.ToString("M/d/yyyy"));
         this.sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            this.matBtnSave.Visible = true;
            this.txtmajorCategory.Select();
            this.txtmajorCategory.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.sp_created_at = String.Empty;
            this.sp_created_by = String.Empty;
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.txtmajorCategory.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvMajorCategory.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (this.saveMode())
                    {
                        this.DeletedSuccessfully();
                        this.showMajorCategoryData();

                        this.matBtnCancel_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.mode = "edit";
           this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
            this.sp_modified_by = userinfo.emp_name.ToUpper();
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;
            this.txtmajorCategory.Enabled = true;
            this.txtmajorCategory.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_Major_Category(0,
                txtmajorCategory.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.MajorCategoryAlreadyExist();


                this.txtmajorCategory.Focus();
                return;
            }
            else
            {
                this.metroSave_Click(sender, e);
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mattxtSearch.Text == String.Empty)
            {
                this.showMajorCategoryData();
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
                    this.doSearchInTextBoxCmb();
                }

            }
        }

        private void lbltotalrecords_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
