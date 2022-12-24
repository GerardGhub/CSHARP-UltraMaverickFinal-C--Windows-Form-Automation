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
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Users.Modal
{
    public partial class FrmAddNewUnit : MaterialForm
    {
        readonly frmDepartmentUnit ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly DepartmentUnit DeptUnit = new DepartmentUnit();
        readonly DepartmentUnitRepository DepartmentUnitRepositorys = new DepartmentUnitRepository();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int touch = 0;
        public FrmAddNewUnit(
            frmDepartmentUnit frm, 
            int UserId, 
            string Mode, 
            int UnitId, 
            string Department, 
            string UnitDescription,
            int DepartmentId)
        {
            InitializeComponent();
            ths = frm;
            this.DeptUnit.Mode = Mode;
            this.DeptUnit.Unit_Id = UnitId;
            this.DeptUnit.Created_By = UserId.ToString();
            this.DeptUnit.Department = Department;
            this.DeptUnit.Unit_Description = UnitDescription;
            this.DeptUnit.Department_Id = DepartmentId;
        }

        private void AddNewDepartmentUnit_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();


            if (this.DeptUnit.Mode == "ADD")
            {
                this.Text = "Add New Unit";
            }
            else
            {
                this.Text = "Update Unit Information";
                this.TxtDepartmentUnit.Text = this.DeptUnit.Unit_Description;
                this.DeptUnit.Unit_Id = DeptUnit.Unit_Id;
                //this.DeptUnit.Department = this.DeptUnit.Department;
                this.CbDepartment.Text = this.DeptUnit.Department;
                this.DeptUnit.Department_Id = DeptUnit.Department_Id;
                
            }
       
        }
        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        public void LoadDepartment()
        {

            myClass.fillComboBox(CbDepartment, "department_dropdown", dSet );

            //myClass.fillCmbTransactionNo(CbDepartment, "department_dropdown", dSet, );
            //this.DeptUnit.Department = CbDepartment.SelectedValue.ToString();
        }
        public void LoadCurrentDepartment()
        {

            myClass.fillCmbTransactionNo(CbDepartment, "department_dropdown_params", dSet, this.DeptUnit.Department_Id);


            this.DeptUnit.Department = CbDepartment.SelectedValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void AddNewDepartmentUnit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
                if (this.touch == 1)
                {
               
                }
                else
                {
                if (this.DeptUnit.Mode == "ADD") { }
                else { this.LoadCurrentDepartment(); }
            
                }

            if (CbDepartment.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                CbDepartment.Focus();
                return;
            }

            if (TxtDepartmentUnit.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtDepartmentUnit.Focus();
            }

            if (this.DeptUnit.Mode == "ADD")
            {
                this.DeptUnit.Department = String.Empty;
                this.DeptUnit.Unit_Description = String.Empty;
            }

 

            if (this.DeptUnit.Department == this.DeptUnit.Department_Id.ToString() 
                && this.TxtDepartmentUnit.Text == this.DeptUnit.Unit_Description)
            {
                this.SaveFunctionality();
            }
            else
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection
                    .sp_DepartmentUnit(0, TxtDepartmentUnit.Text, 
                    this.DeptUnit.Department_Id.ToString(),
                   "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();

                    TxtDepartmentUnit.Text = string.Empty;
                    TxtDepartmentUnit.Focus();
                    return;
                }
                else
                {
                    this.SaveFunctionality();
                }
            }

            }

        private void SaveFunctionality()
        {
            if (this.DeptUnit.Mode == "ADD")
            {

                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_DepartmentUnit(0, TxtDepartmentUnit.Text, this.DeptUnit.Department,
                   "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();

                    TxtDepartmentUnit.Text = string.Empty;
                    TxtDepartmentUnit.Focus();
                    return;
                }

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                        .sp_DepartmentUnit(0,
                        this.TxtDepartmentUnit.Text.Trim(),
                        this.DeptUnit.Department_Id.ToString(),
                        this.DeptUnit.Created_By,
                        this.DeptUnit.Created_By,
                       this.DeptUnit.Created_By,
                        this.DeptUnit.Created_By,
                        "add");

                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();





                }
                else
                {
                    return;
                }

            }

            else
            {

             

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .sp_DepartmentUnit(this.DeptUnit.Unit_Id,
                    this.TxtDepartmentUnit.Text.Trim(),
                    this.DeptUnit.Department_Id.ToString(),
                    this.DeptUnit.Created_By,
                    this.DeptUnit.Created_By,
                    this.DeptUnit.Created_By,
                    this.DeptUnit.Created_By,
                    "edit");

                    this.GlobalStatePopup.SuccessFullySave();
                    this.Close();
                }
                else
                {
                    return;
                }


            }
            //END OF FUCKING CONTRACT
        }



        private void TxtDepartmentUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void MatbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialCard1_Click(object sender, EventArgs e)
        {

        }

        private void CbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CbDepartment_Click(object sender, EventArgs e)
        {
            this.LoadDepartment();
            this.touch = 1;
        }

        private void CbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DeptUnit.Department_Id = Convert.ToInt32(CbDepartment.SelectedValue);

        }
    }
}
