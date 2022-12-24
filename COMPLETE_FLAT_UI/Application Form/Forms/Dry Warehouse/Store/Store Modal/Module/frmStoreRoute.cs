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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class FrmStoreRoute : MaterialForm
    {
        private IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly TblRoute TblRouteEntity = new TblRoute();
 
        public FrmStoreRoute()
        {
            InitializeComponent();
        }

        public string Sp_user_id { get; set; }

        private void FrmStoreRoute_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.Sp_user_id = userinfo.user_id.ToString();
            this.ShowStoreRoute();
            this.LoadRecordsProperties();
            this.LoadingrefresherOrb();
            this.GetRadionDataChanged();
            this.textBox1.Text = String.Empty;

        }

        public void ConnectionInit()
        {
            this.g_objStoredProcCollection = 
                this.myClass.g_objStoredProc.GetCollections(); 

        }

        private void GetRadionDataChanged()
        {
            this.matRadioActive.Checked = true;

        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();
            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblRouteSpMajor");
            }
            else
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblRouteSpMajorInActive");
            }


        }

        private void ShowStoreRoute()    //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(dgvRawMats, "tblRouteSpMinor", dSet);

                lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["route_id"].Visible = false;
            this.dgvRawMats.Columns["is_active"].Visible = false;
          
        }


        private void ShowStoreRouteInActive()    //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(dgvRawMats, "tblRouteSpMinorInActive", dSet);

                this.lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["route_id"].Visible = false;
            this.dgvRawMats.Columns["is_active"].Visible = false;

        }

        private void LoadingrefresherOrb()
        {
            this.TblRouteEntity.Mode = "";
            if (textBox1.Text == "data Already Save!")
            {
                this.toolStripbtnEdit.Visible = false;
            }
            else if (textBox1.Text == "Gerard Singian")
            {
                this.textBox1.Text = string.Empty;
                this.materialBtnNew.Visible = true;
                this.toolStripbtnEdit.Visible = true;
            }
            else
            {


            }

            myglobal.global_module = "Active"; // Mode for Searching

        }


        private void LoadRecordsProperties()
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.toolStripbtnEdit.Visible = true;
            }
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FrmStoreRoute_Load(sender, e);
        }

        private void DoSearchInTextBoxCmb()
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

                        dv.RowFilter = "route_name like '%" + txtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvRawMats.DataSource = dv;
                    lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
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




        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();

            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.DoSearchInTextBoxCmb();
            }
            if (this.txtSearch.Text == "")
            {
                this.DoSearchInTextBoxCmb();
            }
        }

        private void MatBtnEdit_Click(object sender, EventArgs e)
        {
            this.TblRouteEntity.Mode = "edit";
            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            FrmAddNewRoute addNew = new FrmAddNewRoute(this, 
                Sp_user_id,
                TblRouteEntity.Route_Name,
                TblRouteEntity.Mode,
                this.TblRouteEntity.Route_Id);
            addNew.ShowDialog();
        }

        private void DgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowValueCell();
        }
        private void ShowValueCell()
        {
            if (this.dgvRawMats.Rows.Count > 0)
            {
                if (this.dgvRawMats.CurrentRow != null)
                {
                    if (this.dgvRawMats.CurrentRow.Cells["route_name"].Value != null)
                    {
                        this.TblRouteEntity.Route_Id = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["route_id"].Value);
                        this.TblRouteEntity.Route_Name  = this.dgvRawMats.CurrentRow.Cells["route_name"].Value.ToString();


                    }
                }
            }
        }

        private void MatRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.ShowStoreRoute();
            }
            else
            {
                this.matBtnDelete.Text = "&Activate";
                this.ConnectionInit();
                this.ShowStoreRouteInActive();
            }
        }

        private void MatRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.matBtnDelete.Text = "&InActive";
                this.ConnectionInit();
                this.ShowStoreRoute();
            }
            else
            {
                this.ConnectionInit();
                this.ShowStoreRouteInActive();
            }
        }

        private void MatBtnDelete_Click(object sender, EventArgs e)
        {
            this.PutInactiveData();
        }
        private void PutInactiveData()
        {
            if (this.matRadioActive.Checked == true)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {
                 
                        this.dSet.Clear();
                        this.dSet = g_objStoredProcCollection
                            .sp_tblRoute(
                            this.TblRouteEntity.Route_Id,
                            this.TblRouteEntity.Route_Name,
                            userinfo.user_id.ToString(),
                            "",
                            userinfo.user_id.ToString(),
                            "",
                            "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.FrmStoreRoute_Load(new object(), new System.EventArgs());

                    }


                }
                else
                {

                    this.toolStripbtnEdit.Visible = true;
                    return;
                }

            }

            else
            {
                //
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {

               
                        this.dSet.Clear();
                        this.dSet = g_objStoredProcCollection
                            .sp_tblRoute(
                            this.TblRouteEntity.Route_Id,
                            this.TblRouteEntity.Route_Name,
                            userinfo.user_id.ToString(),
                            "",
                            userinfo.user_id.ToString(),
                            "",
                            "activate");

                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.FrmStoreRoute_Load(new object(), new System.EventArgs());

                    }


                }
                else
                {

                    this.toolStripbtnEdit.Visible = true;
                    return;
                }

            }

        }

        private void MaterialBtnNew_Click(object sender, EventArgs e)
        {

            this.TblRouteEntity.Mode = "ADD";

            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            FrmAddNewRoute addNew = new FrmAddNewRoute(this,
                Sp_user_id,
                TblRouteEntity.Route_Name,
                TblRouteEntity.Mode,
                this.TblRouteEntity.Route_Id);
            addNew.ShowDialog();

        }

        private void ToolStripbtnEdit_Click(object sender, EventArgs e)
        {
                this.TblRouteEntity.Mode = "edit";
                this.materialBtnNew.Visible = false;
                this.toolStripbtnEdit.Visible = false;
                FrmAddNewRoute addNew = new FrmAddNewRoute(this,
                Sp_user_id,
                TblRouteEntity.Route_Name,
                TblRouteEntity.Mode,
                this.TblRouteEntity.Route_Id);
                addNew.ShowDialog();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
