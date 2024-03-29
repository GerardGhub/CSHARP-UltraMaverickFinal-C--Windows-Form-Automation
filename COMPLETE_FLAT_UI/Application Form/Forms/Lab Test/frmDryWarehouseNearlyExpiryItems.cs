﻿using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Lab_Test
{
    public partial class frmDryWarehouseNearlyExpiryItems : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        DataSet dSet = new DataSet();
        int p_id = 0;

        DateTime dNow = DateTime.Now;

        DataSet dSet_temp = new DataSet();
        public frmDryWarehouseNearlyExpiryItems()
        {
            InitializeComponent();
        }

        private void frmDryWarehouseNearlyExpiryItems_Load(object sender, EventArgs e)
        {
            this.ConnectionInitialization();
            this.showRawMaterialsNearlyExpiry();
            this.WindowLoadState();
        }

        private void WindowLoadState()
        {
            if(this.lbltotalrecords.Text != "0")
            {
                this.SearchMethodJarVarCallingSP();
                this.matRadioLaboratory.Checked = true;
            }
        }

        private void ConnectionInitialization ()
        {
            this.g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections(); 
        }


        private void showRawMaterialsNearlyExpiry() 
        {
            try
            {
                xClass.fillDataGridView(this.dgvRawMats, "DryWarehouseNearlyExpiry", dSet);
                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showRawMaterialsNearlyExpiryOnLaboratory() 
        {
            try
            {
                xClass.fillDataGridView(this.dgvRawMats, "DryWarehouseNearlyExpiry_OnLaboratory", dSet);
                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.matRadioLaboratory.Checked == true)
            {
                this.ConnectionInitialization();
                this.SearchMethodJarVarCallingSP();
                this.doSearchInTextBoxCmb();
                if (this.txtSearch.Text == String.Empty)
                {
                    this.showRawMaterialsNearlyExpiry();
                }
            }

            if (this.matRadioNearlyExpiry.Checked == true)
            {
                this.ConnectionInitialization();
                this.SearchMethodJarVarCallingSP();
                this.doSearchInTextBoxCmb();

                if (this.txtSearch.Text == String.Empty)
                {
                    this.showRawMaterialsNearlyExpiryOnLaboratory();
                }
            }
        }



        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            if (this.matRadioLaboratory.Checked == true)
            {
                this.dset_emp_SearchEngines.Clear();
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("DryWarehouseNearlyExpiryMajor");
            }
            if (this.matRadioNearlyExpiry.Checked == true)
            {
                this.dset_emp_SearchEngines.Clear();
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("DryWarehouseNearlyExpiryMajor_OnLaboratory");
            }
        }

        private void doSearchInTextBoxCmb()
        {
            try
            {
                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);
                        dv.RowFilter = "item_code like '%" + this.txtSearch.Text + "%' or item_description like '%" + this.txtSearch.Text + "%'   ";                 
                    this.dgvRawMats.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found Syntax Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found Evaluation Exception!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            this.ConnectionInitialization();
            this.showRawMaterialsNearlyExpiry();
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            this.ConnectionInitialization();
            this.showRawMaterialsNearlyExpiryOnLaboratory();
        }
    }
}
