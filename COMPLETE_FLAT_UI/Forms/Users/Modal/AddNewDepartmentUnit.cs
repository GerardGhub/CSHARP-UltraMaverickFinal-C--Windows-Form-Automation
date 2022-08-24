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
    public partial class AddNewDepartmentUnit : MaterialForm
    {
        frmDepartmentUnit ths;
        DataSet dSet = new DataSet();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        DepartmentUnit DeptUnit = new DepartmentUnit();
        DepartmentUnitRepository DepartmentUnitRepositorys = new DepartmentUnitRepository();


        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        public AddNewDepartmentUnit(
            frmDepartmentUnit frm, 
            int UserId, 
            string Mode, 
            int UnitId, 
            string Department, 
            string UnitDescription)
        {
            InitializeComponent();
            ths = frm;
            this.DeptUnit.Mode = Mode;
            this.DeptUnit.Unit_Id = UnitId;
            this.DeptUnit.Created_By = UserId.ToString();
            this.DeptUnit.Department = Department;
            this.DeptUnit.Unit_Description = UnitDescription;
        }

        private void AddNewDepartmentUnit_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.LoadDepartment();

            if (this.DeptUnit.Mode == "Add")
            {
                this.Text = "Add New Unit";
            }
            else
            {
                this.Text = "Update Unit Information";
                this.TxtDepartmentUnit.Text = this.DeptUnit.Unit_Description;
                this.DeptUnit.Unit_Id = DeptUnit.Unit_Id;
                this.DeptUnit.Department = this.DeptUnit.Department;
            }
       
        }
        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        public void LoadDepartment()
        {

            myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
   

            this.DeptUnit.Department = cbodepartment.SelectedValue.ToString();
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
            this.DeptUnit.Department = cbodepartment.SelectedValue.ToString(); //Binding First Meet
            if (cbodepartment.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                cbodepartment.Focus();
                return;
            }

            if (TxtDepartmentUnit.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtDepartmentUnit.Focus();
            }
            else
            {
                if (this.DeptUnit.Mode == "Add")
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_DepartmentUnit(0, TxtDepartmentUnit.Text, "", "", "", "", "", "getbyname");

                    if (dSet.Tables[0].Rows.Count > 0)
                    {
                        this.GlobalStatePopup.DataAlreadyExist();

                        TxtDepartmentUnit.Text = string.Empty;
                        TxtDepartmentUnit.Focus();
                        return;
                    }

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                    
                       
                            dSet.Clear();
                            dSet = g_objStoredProcCollection
                                .sp_DepartmentUnit(0,
                                this.TxtDepartmentUnit.Text.Trim(),
                                this.DeptUnit.Department,
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

                    if (this.DeptUnit.Unit_Description == this.TxtDepartmentUnit.Text)
                    { }
                    else
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_DepartmentUnit(0, TxtDepartmentUnit.Text, "", "", "", "", "", "getbyname");

                        if (dSet.Tables[0].Rows.Count > 0)
                        {
                            this.GlobalStatePopup.DataAlreadyExist();

                            TxtDepartmentUnit.Text = string.Empty;
                            TxtDepartmentUnit.Focus();
                            return;
                        }

                    }

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                      

                        dSet.Clear();
                        dSet = g_objStoredProcCollection
                            .sp_DepartmentUnit(this.DeptUnit.Unit_Id,
                            this.TxtDepartmentUnit.Text.Trim(),
                            this.DeptUnit.Department,
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




        }

        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            this.DeptUnit.Department = cbodepartment.SelectedValue.ToString();
        }
    }
}
