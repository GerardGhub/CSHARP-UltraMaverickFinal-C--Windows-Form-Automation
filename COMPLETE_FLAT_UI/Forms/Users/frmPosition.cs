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
  
        DataSet dSet_temp = new DataSet();
        Position PositionEntity = new Position();
        public frmPosition()
        {
            InitializeComponent();
        }


        private void frmPosition_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();

            this.GetAllPosition();
            myglobal.global_module = "Active";
            this.textBox1.Text = String.Empty;
            this.HideDataGridColumn();
            this.GetRadionDataChanged();
        }

        private void GetRadionDataChanged()
        {
            this.matRadioActive.Checked = true;

        }
        public void HideDataGridColumn()
        {
            this.DgvPosition.Columns["department_id"].Visible = false;
            this.DgvPosition.Columns["primary_user_id"].Visible = false;
            this.DgvPosition.Columns["is_active"].Visible = false;
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); 
        }


    
        DataSet dset_emp = new DataSet();
        void doSearch()
        {
            try
            {
                if (this.dset_emp.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp.Tables[0]);
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
            this.dset_emp.Clear();
            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp = this.g_objStoredProcCollection.sp_getMajorTables("positioncurrentcellchanged");
            }

            else
            {
                this.dset_emp = this.g_objStoredProcCollection.sp_getMajorTables("positioncurrentcellchangedinactive");
            }

            this.doSearch();

        }

   
        private void GetAllPosition()
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

        private void GetAllPositionInActive()
        {
            try
            {
                this.myClass.fillDataGridView(this.DgvPosition, "position_Inactive", this.dSet);
                this.lbltotalrecords.Text = this.DgvPosition.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void lstPosition_Click(object sender, EventArgs e)
        {
            this.doSearch(); 
        }



        private void cancel_Click(object sender, EventArgs e)
        {
           
            this.btnCancelTool.Visible = false;
            this.btnAddTool.Visible = true;
            this.btnUpdateTool.Visible = false;
            this.btnEditTool.Visible = true;
            this.btnDeleteTool.Visible = true;

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
            this.mode = "add";
            this.btnUpdateTool.Visible = true;
            this.btnAddTool.Visible = false;

            this.btnCancelTool.Visible = true;
       
            this.PositionEntity.Position_Id = userinfo.user_id;
            this.btnUpdateTool.Visible = true;
            this.btnEditTool.Visible = false;


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
                this.mode = "edit";
                this.btnEditTool.Visible = false;
                this.btnAddTool.Visible = false;
                this.btnCancelTool.Visible = true;
                this. btnDeleteTool.Visible = false;
                this.btnUpdateTool.Visible = true;

                FrmAddNewPosition addNew = new FrmAddNewPosition(
                this,
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

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.btnDeleteTool.Text = "&InActive";
                this.ConnectionInit();
                this.GetAllPosition();
            }
            else
            {
                this.ConnectionInit();
                this.GetAllPositionInActive();
            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.GetAllPosition();
            }
            else
            {
                this.btnDeleteTool.Text = "&Activate";
                this.ConnectionInit();
                this.GetAllPositionInActive();
            }
        }
    }
}
