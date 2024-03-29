﻿using System;
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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmManageActivePrimaryUnit : MaterialForm
    {
       
        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        private DataSet dSet = new DataSet();
        DataSet dSet_temp = new DataSet();
        int p_id2 = 0;
        int p_id = 0;
        Raw_Materials_Dry RawMaterialsDryEntity = new Raw_Materials_Dry();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public frmManageActivePrimaryUnit()
        {
            InitializeComponent();
        }


        public string sp_active_pu_primary_id { get; set; }

        public string sp_item_primary_unit { get; set; }

        public string sp_user_id { get; set; }
             
        public string sp_item_primary_id { get; set; }
        public string IsActivated { get; set; }

        private void frmManageActivePrimaryUnit_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.sp_user_id = userinfo.user_id.ToString();
            this.showRawMaterialsInDryWH();
            this.SearchMethodJarVarCallingSP();
            this.SearchMethodJarVarCallingSPUnits();
            myglobal.global_module = "Active"; // Mode for Searching
            this.HideControls();
            this.textBox1.Text = String.Empty;
        }


        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void HideControls()
        {
            this.txtmatid.Visible = false;
        }

        DataSet dset_emp_SearchEnginesonUnit = new DataSet();
        private void SearchMethodJarVarCallingSPUnits()
        {
            this.dset_emp_SearchEnginesonUnit.Clear();


            this.dset_emp_SearchEnginesonUnit = g_objStoredProcCollection.sp_getMajorTables("PrimaryUnitManagementMajor");

        }



        private void doSearchInTextBoxPrimaryUnit()
        {
            try
            {


                if (dset_emp_SearchEnginesonUnit.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEnginesonUnit.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "item_item_code = '" + RawMaterialsDryEntity.Item_Code + "' ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvActiveUnits.DataSource = dv;
                    DataGridColumnHideUnit();
                    lbltotalRecordsActiveUnits.Text = dgvActiveUnits.RowCount.ToString();
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


        private void DataGridColumnHideUnit()
        {

            this.dgvActiveUnits.Columns["created_at_units"].Visible = false;
            this.dgvActiveUnits.Columns["created_by_units"].Visible = false;
            this.dgvActiveUnits.Columns["modified_at_units"].Visible = false;
            this.dgvActiveUnits.Columns["modified_by_units"].Visible = false;
            this.dgvActiveUnits.Columns["item_primary_id"].Visible = false;
            this.dgvActiveUnits.Columns["active_pu_primary_id"].Visible = false;
            this.dgvActiveUnits.Columns["item_item_code"].Visible = false;
            this.dgvActiveUnits.Columns["item_description_units"].Visible = false;
        }


        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(dgvRawMats, "Raw_Materials_Dry_IngredientsOnly", dSet);
                DataGridColumnHide();
                lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void DataGridColumnHide()
        {
            this.dgvRawMats.Columns["item_class"].Visible = false;
            this.dgvRawMats.Columns["major_category"].Visible = false;
            this.dgvRawMats.Columns["sub_category"].Visible = false;
            this.dgvRawMats.Columns["conversion"].Visible = false;
            this.dgvRawMats.Columns["item_type"].Visible = false;
            this.dgvRawMats.Columns["created_at"].Visible = false;
            this.dgvRawMats.Columns["created_by"].Visible = false;
            this.dgvRawMats.Columns["updated_at"].Visible = false;
            this.dgvRawMats.Columns["updated_by"].Visible = false;
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection
                .sp_getMajorTables("Raw_Materials_Dry_Major");

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




                        dv.RowFilter = "item_description like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvRawMats.DataSource = dv;
                    DataGridColumnHide();
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


        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
            this.LbltotalConversion.Text = this.dgvActiveUnits.RowCount.ToString();
        }

        private void showValueCell()
        {
            if (this.dgvRawMats.Rows.Count > 0)
            {
                if (this.dgvRawMats.CurrentRow != null)
                {
                    if (this.dgvRawMats.CurrentRow.Cells["item_description"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(dgvRawMats.CurrentRow.Cells["item_id"].Value);

                       this.RawMaterialsDryEntity.Item_Description = dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                        this.RawMaterialsDryEntity.Item_Code = dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                        this.txtmatid.Text = dgvRawMats.CurrentRow.Cells["item_id"].Value.ToString();
                        this.sp_item_primary_unit = dgvRawMats.CurrentRow.Cells["primary_unit"].Value.ToString();
                        this.lblItemDescription.Text = dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                    }
                }
            }
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                doSearchInTextBoxCmb();

            }
            if (mattxtSearch.Text == "")
            {
                showRawMaterialsInDryWH();
            }



        }

        private void txtmatid_TextChanged(object sender, EventArgs e)
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                SearchMethodJarVarCallingSPUnits();
                doSearchInTextBoxPrimaryUnit();
            }
        }



        private void txtmatSearchUnit_TextChanged(object sender, EventArgs e)
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                doSearchInTextBoxPrimaryUnit();
            }
                
        }

        private void dgvActiveUnits_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvActiveUnits.Rows.Count > 0)
            {
                if (dgvActiveUnits.CurrentRow != null)
                {
                    if (dgvActiveUnits.CurrentRow.Cells["active_pu_description"].Value != null)
                    {
                        p_id2 = Convert.ToInt32(dgvActiveUnits.CurrentRow.Cells["id"].Value);

                       RawMaterialsDryEntity.Conversion = dgvActiveUnits.CurrentRow.Cells["active_pu_conversion"].Value.ToString();

                        mattxtPrimaryUnit.Text = dgvActiveUnits.CurrentRow.Cells["active_pu_description"].Value.ToString();
          
                        sp_active_pu_primary_id = dgvActiveUnits.CurrentRow.Cells["active_pu_primary_id"].Value.ToString();
                        sp_item_primary_id = dgvActiveUnits.CurrentRow.Cells["item_primary_id"].Value.ToString();
                        this.IsActivated = this.dgvActiveUnits.CurrentRow.Cells["is_active"].Value.ToString();

                  

                        if (this.IsActivated == "1")
                        {
                            this.BtnDeactivateTool.Visible = true;
                            this.BtnActivateTool.Visible = false;
                        }
                        else
                        {
                            this.BtnDeactivateTool.Visible = false;
                            this.BtnActivateTool.Visible = true;
                        }
                    }
                }
            }
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            this.toolStrip2.Visible = false;
            frmAddNewUomConversion addNew = new frmAddNewUomConversion(this, 
                this.RawMaterialsDryEntity.Conversion, 
                this.mattxtPrimaryUnit.Text, 
                this.RawMaterialsDryEntity.Item_Code, 
                this.RawMaterialsDryEntity.Item_Description, 
                this.sp_active_pu_primary_id, 
                this.txtmatid.Text, 
                this.sp_item_primary_unit);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Gerard Singian")
            {
                this.toolStrip2.Visible = true;
            }
            else if (this.textBox1.Text == "data Already Save!")
            {

                this.SearchMethodJarVarCallingSPUnits();

                this.doSearchInTextBoxPrimaryUnit();
            }
            else
            {

            }
        }


        private void btnDeleteTool_Click(object sender, EventArgs e)
        {

            if (dgvActiveUnits.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to inactive the primary unit conversion?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    dSet_temp.Clear();
                    dSet_temp = this.g_objStoredProcCollection.sp_PrimaryUnitManagement(p_id2, "", "", "", "", "", "", "", "", "", "", "", "delete");

                    this.GlobalStatePopup.InactiveSuccessfully();

                    this.SearchMethodJarVarCallingSPUnits();

                    this.doSearchInTextBoxPrimaryUnit();
                }
                else
                {
                    return;
                }


            }
        }






        private void btnEditTool_Click(object sender, EventArgs e)
        {

          

            if (dgvActiveUnits.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dSet_temp.Clear();
                    dSet_temp = g_objStoredProcCollection.sp_PrimaryUnitManagement(Convert.ToInt32(txtmatid.Text), "", "", "", "", "", "", "", "", "", "", "", "inactiveall");

                    dSet_temp.Clear();
                    dSet_temp = g_objStoredProcCollection.sp_PrimaryUnitManagement(p_id2, "", "", "", "", "", "", "", "", "", "", "", "activate_conversion");

                    this.GlobalStatePopup.ActivatedSuccessfully();

                    this.SearchMethodJarVarCallingSPUnits();

                    this.doSearchInTextBoxPrimaryUnit();
                }
                else
                {
                    return;
                }


            }


            //frmActivationofPrimaryUnit addNew = new frmActivationofPrimaryUnit(this);
            //addNew.ShowDialog();
        }

        private void dgvRawMats_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //var grid = sender as DataGridView;
            //var rowIdx = (e.RowIndex + 1).ToString();

            //var centerFormat = new StringFormat()
            //{
            //    // right alignment might actually make more sense for numbers
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //};

            //var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            //e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);





        }

        private void LbltotalConversion_TextChanged(object sender, EventArgs e)
        {
            //if (this.LbltotalConversion.Text  =="0")
            //{
            //    BtnDeactivateTool.Enabled = false;
            //    BtnActivateTool.Enabled = false;
            //}
            //else
            //{
            //    BtnActivateTool.Enabled = true;
            //    BtnDeactivateTool.Enabled = true;
            //}


            //if (this.LbltotalConversion.Text == "1")
            //{
            //    this.BtnActivateTool.Visible = false;
            //}
            //else
            //{
            //    this.BtnActivateTool.Visible = true;
            //}
        }
    }
}
