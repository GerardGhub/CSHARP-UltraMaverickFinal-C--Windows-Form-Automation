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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Research_And_Development.Modal;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    public partial class frmPrimaryUnit : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        Primary_Unit PrimaryUnitEntity = new Primary_Unit();
        string mode = "";
        DateTime dNow = DateTime.Now;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        DataSet dSet_temp = new DataSet();
        public frmPrimaryUnit()
        {
            InitializeComponent();
        }

        private void frmPrimaryUnit_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.ShowPrimaryUnitData();
            this.ShowDataRadioButtonActivated();
            this.textBox1.Text = String.Empty;
        }
        private void ShowDataRadioButtonActivated()
        {
            this.matRadioActive.Checked = true;
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void ShowPrimaryUnitData()      //method for loading available_menus
        {
            try
            {
             
                this.myClass.fillDataGridView(dgvPrimaryUnit, "Primary_Unit", dSet);

           this.lbltotalrecords.Text = this.dgvPrimaryUnit.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void ShowPrimaryUnitDataInActive()      //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(dgvPrimaryUnit, "Primary_UnitInActive", dSet);

                lbltotalrecords.Text = dgvPrimaryUnit.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }




 
  

        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
    
        }

        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
           
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
                        this.PrimaryUnitEntity.Unit_Id = Convert.ToInt32(dgvPrimaryUnit.CurrentRow.Cells["unit_id"].Value);
                       this.PrimaryUnitEntity.Unit_Desc = dgvPrimaryUnit.CurrentRow.Cells["unit_desc"].Value.ToString();
                       this.PrimaryUnitEntity.Pm_Added_By = dgvPrimaryUnit.CurrentRow.Cells["pm_added_by"].Value.ToString();
                       this.PrimaryUnitEntity.Pm_Added_At = dgvPrimaryUnit.CurrentRow.Cells["pm_added_at"].Value.ToString();
                       this.PrimaryUnitEntity.Pm_Updated_At = dgvPrimaryUnit.CurrentRow.Cells["pm_updated_at"].Value.ToString();
                       this.PrimaryUnitEntity.Pm_Updated_By = dgvPrimaryUnit.CurrentRow.Cells["pm_updated_by"].Value.ToString();
                    }
                }
            }
        }

        private void neww_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false; 
            this.matBtnDelete.Visible = false;
     

            this.PrimaryUnitEntity.Mode = "ADD";
            AddPrimaryUnit addNew =
            new AddPrimaryUnit(this,
            userinfo.user_id,
            this.PrimaryUnitEntity.Unit_Desc,
            this.PrimaryUnitEntity.Mode,
            this.PrimaryUnitEntity.Unit_Id);
            addNew.ShowDialog();

        }

        private void editt_Click(object sender, EventArgs e)
        {
            this.mode = "edit";
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;


            this.PrimaryUnitEntity.Mode = "EDIT";
            AddPrimaryUnit addNew =
            new AddPrimaryUnit(this,
            userinfo.user_id,
            this.PrimaryUnitEntity.Unit_Desc,
            this.PrimaryUnitEntity.Mode,
            this.PrimaryUnitEntity.Unit_Id);
            addNew.ShowDialog();
        }

        private void removee_Click(object sender, EventArgs e)
        {
            if (dgvPrimaryUnit.Rows.Count > 0)
            {
                if (this.matRadioActive.Checked == true)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {


                        mode = "delete";

                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection
                            .sp_Primary_Unit(this.PrimaryUnitEntity.Unit_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "delete");

                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmPrimaryUnit_Load(sender, e);
                    }

                    else
                    {
                        return;
                    }
                }
                else

                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {


                        mode = "activate";

                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection
                            .sp_Primary_Unit(this.PrimaryUnitEntity.Unit_Id,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "activate");

                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmPrimaryUnit_Load(sender, e);
                    }

                    else
                    {
                        return;
                    }

                }





            }
        }

        private void canceel_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";

            matBtnEdit.Visible = true;
   
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
       
        }

        private void savee_Click(object sender, EventArgs e)
        {
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.canceel_Click(sender, e);
            this.frmPrimaryUnit_Load(sender, e);
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.ShowPrimaryUnitData();
     
            }
            else if (matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.ShowPrimaryUnitDataInActive();
            }
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.ShowPrimaryUnitData();

            }
            else if (matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.ShowPrimaryUnitDataInActive();
            }
        }


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {

            dset_emp_SearchEngines.Clear();

            if (this.matRadioActive.Checked == true)
            {

                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("Primary_Unit_Major");
            }
            else
            {

                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("Primary_Unit_MajorInActive");
            }


        }


        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBox();
        }

        private void doSearchInTextBox()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                 


                        dv.RowFilter = "unit_desc like '%" + this.mattxtSearch.Text + "%'";

                 
                    this.dgvPrimaryUnit.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvPrimaryUnit.RowCount.ToString();
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

        private void mattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
