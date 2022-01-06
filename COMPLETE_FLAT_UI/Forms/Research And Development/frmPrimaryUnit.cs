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
    public partial class frmPrimaryUnit : MaterialForm
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



        DataSet dSet_temp = new DataSet();
        public frmPrimaryUnit()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }
        private void frmPrimaryUnit_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            showPrimaryUnitData();
        }
        private void showPrimaryUnitData()      //method for loading available_menus
        {
            try
            {
             
                xClass.fillDataGridView(dgvPrimaryUnit, "Primary_Unit", dSet);
      
                lbltotalrecords.Text = dgvPrimaryUnit.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;
            txtmatPrimaryUnit.Enabled = true;
            matBtnNew.Visible = false;
            txtmatPrimaryUnit.Text = String.Empty;
            this.sp_modified_at = String.Empty;
            this.sp_modified_by = String.Empty;
            matBtnDelete.Visible = false;
            sp_created_at = (dNow.ToString("M/d/yyyy"));
            sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmatPrimaryUnit.Select();
            txtmatPrimaryUnit.Focus();
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
            sp_created_at = String.Empty;
            sp_created_by = String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmatPrimaryUnit.Enabled = false;
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
        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPrimaryUnit.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Primary Unit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        showPrimaryUnitData();

                        matBtnCancel_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }
        }

        public void PrimaryUnitAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Primary Unit Already Exist!";
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
            dSet = objStorProc.sp_Primary_Unit(0,
                txtmatPrimaryUnit.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                PrimaryUnitAlreadyExist();


                txtmatPrimaryUnit.Focus();
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
        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Primary_Unit(0,
                    txtmatPrimaryUnit.Text, "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    PrimaryUnitAlreadyExist();

                    txtmatPrimaryUnit.Text = string.Empty;
                    txtmatPrimaryUnit.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_Primary_Unit(0,
                        txtmatPrimaryUnit.Text.Trim(),

                        sp_created_by,
                        sp_created_at,
                       this.sp_modified_at,
                        this.sp_modified_by, "add");

                    showPrimaryUnitData();


                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Primary_Unit(0,
                    txtmatPrimaryUnit.Text,
                    "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Primary_Unit(p_id,
                    txtmatPrimaryUnit.Text, "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Primary_Unit(p_id,
                            txtmatPrimaryUnit.Text.Trim(),

                            sp_created_by,
                            sp_created_at,
                            this.sp_modified_at,
                            this.sp_modified_by, "edit");
                        UpdateNotifications();
                        showPrimaryUnitData();
                        mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {

                        txtmatPrimaryUnit.Text = String.Empty;
                        txtmatPrimaryUnit.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_Primary_Unit(p_id,
                        txtmatPrimaryUnit.Text.Trim(),

                         sp_created_by,
                         sp_created_at,
                         this.sp_modified_at,
                         this.sp_modified_by, "edit");
                    UpdateNotifications();
                    showPrimaryUnitData();
                    mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Primary_Unit(p_id,
                    txtmatPrimaryUnit.Text, "", "", "", "", "delete");

                return true;
            }
            return false;
        }


        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the  Primary Unit Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {



                if (txtmatPrimaryUnit.Text.Trim() == string.Empty)
                {

                    FillRequiredFields();
                    txtmatPrimaryUnit.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvPrimaryUnit.CurrentCell = dgvPrimaryUnit[0, dgvPrimaryUnit.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                           dgvPrimaryUnit.CurrentCell = dgvPrimaryUnit[0, temp_hid];

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
            if (txtmatPrimaryUnit.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtmatPrimaryUnit.Focus();
            }
            else
            {
                if (saveMode())
                {
                    PrimaryUnitAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvPrimaryUnit.CurrentCell = dgvPrimaryUnit[0, dgvPrimaryUnit.Rows.Count - 1];

                    }
                    else
                    {
                        dgvPrimaryUnit.CurrentCell = dgvPrimaryUnit[0, temp_hid];
                    }
                    matBtnCancel_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
           this.sp_modified_by= userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmatPrimaryUnit.Enabled = true;
            txtmatPrimaryUnit.Focus();
        }

        private void dgvPrimaryUnit_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }

        private void showValueCell()
        {
            if (dgvPrimaryUnit.Rows.Count > 0)
            {
                if (dgvPrimaryUnit.CurrentRow != null)
                {
                    if (dgvPrimaryUnit.CurrentRow.Cells["unit_desc"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvPrimaryUnit.CurrentRow.Cells["unit_id"].Value);
                        txtmatPrimaryUnit.Text = dgvPrimaryUnit.CurrentRow.Cells["unit_desc"].Value.ToString();
                        sp_created_by = dgvPrimaryUnit.CurrentRow.Cells["pm_added_by"].Value.ToString();
                        sp_created_at = dgvPrimaryUnit.CurrentRow.Cells["pm_added_at"].Value.ToString();
                       this.sp_modified_at = dgvPrimaryUnit.CurrentRow.Cells["pm_updated_at"].Value.ToString();
                       this.sp_modified_by = dgvPrimaryUnit.CurrentRow.Cells["pm_updated_by"].Value.ToString();
                    }
                }
            }
        }

        private void neww_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;
            txtmatPrimaryUnit.Enabled = true;
            matBtnNew.Visible = false;
            txtmatPrimaryUnit.Text = String.Empty;
           this.sp_modified_at = String.Empty;
           this.sp_modified_by = String.Empty;
            matBtnDelete.Visible = false;
            sp_created_at = (dNow.ToString("M/d/yyyy"));
            sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmatPrimaryUnit.Select();
            txtmatPrimaryUnit.Focus();
        }

        private void editt_Click(object sender, EventArgs e)
        {
            mode = "edit";
            this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
          this.sp_modified_by = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmatPrimaryUnit.Enabled = true;
            txtmatPrimaryUnit.Focus();
        }

        private void removee_Click(object sender, EventArgs e)
        {
            if (dgvPrimaryUnit.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Primary Unit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        showPrimaryUnitData();

                        matBtnCancel_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }
        }

        private void canceel_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
            sp_created_at = String.Empty;
            sp_created_by = String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmatPrimaryUnit.Enabled = false;
        }

        private void savee_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_Primary_Unit(0,
                txtmatPrimaryUnit.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                PrimaryUnitAlreadyExist();


                txtmatPrimaryUnit.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
        }

        private void txtmatPrimaryUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
