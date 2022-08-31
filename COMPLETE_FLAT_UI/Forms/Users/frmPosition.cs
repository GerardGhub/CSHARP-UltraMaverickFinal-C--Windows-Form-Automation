using COMPLETE_FLAT_UI.Models;
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
using MaterialSkin;
using MaterialSkin.Controls;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Users.Modal;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmPosition : MaterialForm
    {

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myglobal pointer_module = new myglobal();
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet = new DataSet();
        Boolean ready = false;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int temp_id = 0;
        DataSet dSet_temp = new DataSet();
        Position PositionEntity = new Position();
        public frmPosition()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();

            getAllPosition(); // all UserFile Management
            lstPosition_Click(sender, e); // Click Thge ListView
            myglobal.global_module = "Active"; // Mode for Searching
            //load_search(); //Bind the Information


            this.textBox1.Text = String.Empty;
            this.HideDataGridColumn();
        }
        public void HideDataGridColumn()
        {
            this.DgvPosition.Columns["department_id"].Visible = false;
            this.DgvPosition.Columns["primary_user_id"].Visible = false;
            this.DgvPosition.Columns["is_active"].Visible = false;
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }


    
        DataSet dset_emp = new DataSet();
        void doSearch()
        {
            try
            {
                if (dset_emp.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "position_name like '%" + this.mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    this.DgvPosition.DataSource = dv;
                    this.lbltotalrecords.Text = this.DgvPosition.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mattxtSearch.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mattxtSearch.Focus();
                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("employee"); }
            else if (myglobal.global_module == "MICRO")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("micro_raw_materialsnew"); }
            else if (myglobal.global_module == "Active")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("positioncurrentcellchanged"); }
            else if (myglobal.global_module == "InActive")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("InactiveFeedCode"); }
            else if (myglobal.global_module == "MACRO")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("macro_raw_materialsnew"); }
            else if (myglobal.global_module == "RESIGNED EMPLOYEE")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("employee_B"); }
            else if (myglobal.global_module == "PHONEBOOK")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("phonebook"); }
            else if (myglobal.global_module == "DA")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("get_da"); }
            else if (myglobal.global_module == "ATTENDANCE")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("attendance_monitoring"); }
            else if (myglobal.global_module == "VISITORS")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("visitors"); }

            doSearch();

        }

   
        private void getAllPosition()
        {

            try
            {

                this.myClass.fillDataGridView(this.DgvPosition, "position", this.dSet);

                this.lbltotalrecords.Text = this.DgvPosition.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



  

        private void lstPosition_Click(object sender, EventArgs e)
        {
            doSearch();
  
        }




        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to inactive data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                {



                        mode = "";

                    this.dSet_temp.Clear();
                    this.dSet_temp = g_objStoredProcCollection.sp_position(this.PositionEntity.Position_Id,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "delete");
                    this.GlobalStatePopup.InactiveSuccessfully();

                    this.frmPosition_Load(sender, e);
                        btnEditTool.Visible = true;

                    
                }
                

            }
            else
            {

                btnEditTool.Visible = true;
                return;
            }
        }
  

        private void cancel_Click(object sender, EventArgs e)
        {
           
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;

        }

        private void removee_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to inactive data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                {



                    mode = "";

                    this.dSet_temp.Clear();
                    this.dSet_temp = g_objStoredProcCollection.sp_position(this.PositionEntity.Position_Id,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "delete");
                    this.GlobalStatePopup.InactiveSuccessfully();

                    this.frmPosition_Load(sender, e);
                    btnEditTool.Visible = true;


                }


            }
            else
            {

                btnEditTool.Visible = true;
                return;
            }
        }

        private void neww_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;

            btnCancelTool.Visible = true;
       
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;


            FrmAddNewPosition addNew = new FrmAddNewPosition(this,
            userinfo.user_id,
            "Add", 
            Convert.ToInt32(this.PositionEntity.Department_Id),
            this.PositionEntity.Department_Name,
            this.PositionEntity.Position_Name,
            this.PositionEntity.Position_Id
            );
            addNew.ShowDialog();


        }

        private void editt_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
            {
                mode = "edit";
                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;

                FrmAddNewPosition addNew = new FrmAddNewPosition(this,
                userinfo.user_id,
                "Edit",
                Convert.ToInt32(this.PositionEntity.Department_Id),
                this.PositionEntity.Department_Name,
                this.PositionEntity.Position_Name,
                this.PositionEntity.Position_Id
                );
                addNew.ShowDialog();

            }
        }

        private void savee_Click(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
          this.cancel_Click(sender, e);
          this.frmPosition_Load(sender, e);
        }

        private void DgvPosition_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowPositionDgvBindDetails();
        }

        private void ShowPositionDgvBindDetails()
        {
            if (this.DgvPosition.RowCount > 0)
            {
                if (this.DgvPosition.CurrentRow != null)
                {
                    if (this.DgvPosition.CurrentRow.Cells["position_name"].Value != null)
                    {
                        this.PositionEntity.Position_Id = Convert.ToInt32(this.DgvPosition.CurrentRow.Cells["position_id"].Value);
                        this.PositionEntity.Position_Name = this.DgvPosition.CurrentRow.Cells["position_name"].Value.ToString();
                        this.PositionEntity.Department_Id = this.DgvPosition.CurrentRow.Cells["department_id"].Value.ToString();
                        this.PositionEntity.Department_Name = this.DgvPosition.CurrentRow.Cells["department_name"].Value.ToString();
                    }

                }
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {

            this.load_search();
        }
    }
}
