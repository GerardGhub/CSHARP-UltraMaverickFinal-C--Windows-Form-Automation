﻿using MaterialSkin.Controls;
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
    public partial class FrmAddNewPosition : MaterialForm
    {
        frmPosition ths;
        DataSet dSet = new DataSet();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly Position PositionEntity = new Position();
        int currentUnitId = 0;
        readonly TblCustomersRepository TblCustomersRepositorys = new TblCustomersRepository();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int touch = 0;
        public FrmAddNewPosition(
            frmPosition frm,
            int UserId, 
            string Mode,
            int Department_Id,
            string Department_Name,
            string Position_Name,
            int Position_Id)
        {
            InitializeComponent();
            ths = frm;
            this.PositionEntity.Created_By = UserId.ToString();
            this.PositionEntity.Mode = Mode;
            this.PositionEntity.Department_Id = Department_Id.ToString();
            this.PositionEntity.Department_Name = Department_Name;
            this.PositionEntity.Position_Name = Position_Name;
            this.PositionEntity.Position_Id = Position_Id;
            this.currentUnitId = Department_Id;
        }

        private void FrmAddNewPosition_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            if (this.PositionEntity.Mode == "ADD")
            {
                this.Text = "Add New Position";
            }
            else
            {
                this.Text = "Update Position Information";
                this.PositionEntity.Department_Id = this.PositionEntity.Department_Id;
                this.CboUnit.Text = this.PositionEntity.Department_Name;
                this.TxtPosition.Text = this.PositionEntity.Position_Name;
                this.PositionEntity.Created_By = this.PositionEntity.Created_By;
            }

        }

        public void LoadUnit()
        {
            this.myClass.fillComboBoxDepartment(CboUnit, "department_unit_dropdown", dSet);
            this.PositionEntity.Department_Id = CboUnit.SelectedValue.ToString();
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = this.myClass.g_objStoredProc.GetCollections();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void FrmAddNewPosition_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "FormClosed";
        }


        public void LoadCurrentUnit()
        {
     

            myClass.fillCmbTransactionNo(CboUnit, "department_unit_dropdown_params", dSet, Convert.ToInt32(this.PositionEntity.Department_Id));


            this.PositionEntity.Department_Id = CboUnit.SelectedValue.ToString();
        }


        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (this.CboUnit.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.CboUnit.Focus();
                return;
            }

            if(this.TxtPosition.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.TxtPosition.Focus();
                return;
            }


            if (this.touch == 1)
            {

            }
            else
            {
                this.LoadCurrentUnit();
            }

            if (this.PositionEntity.Mode == "ADD")
            {
                this.PositionEntity.Position_Name = String.Empty;
                //this.PositionEntity.Department_Id = String.Empty;
            }

            if (this.PositionEntity.Position_Name == TxtPosition.Text
             && this.PositionEntity.Department_Id == this.currentUnitId.ToString())
            {
                this.SaveFunctionality();
            }
            else
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(0,
                    this.TxtPosition.Text,
                    this.PositionEntity.Department_Id,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    this.TxtPosition.Focus();
                    return;
                }
                else
                {
                    SaveFunctionality();
                }
            }

        }

       private void SaveFunctionality()
        {
            if (this.PositionEntity.Mode == "ADD")
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_position(0,
                    this.TxtPosition.Text.Trim(),
                    this.PositionEntity.Department_Id,
                    this.PositionEntity.Created_By,
                    this.PositionEntity.Created_At,
                    this.PositionEntity.Modified_Date,
                    this.PositionEntity.Modified_By,
                    this.PositionEntity.Created_By,
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

                this.dSet.Clear();
                this.dSet = g_objStoredProcCollection.sp_position(this.PositionEntity.Position_Id,
                    this.TxtPosition.Text.Trim(),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "getbyname");


                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    string PostName = this.dSet.Tables[0].Rows[0][1].ToString();

                    if (PostName == this.PositionEntity.Position_Name)
                    {

                    }
                    else
                    {
                        this.GlobalStatePopup.DataAlreadyExist();
                        this.TxtPosition.Text = String.Empty;
                        this.TxtPosition.Focus();
                        return;
                    }

                }


                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection
                    .sp_position(
                    this.PositionEntity.Position_Id,
                    this.TxtPosition.Text.Trim(),
                    this.PositionEntity.Department_Id,
                    this.PositionEntity.Created_By,
                    this.PositionEntity.Created_At,
                    this.PositionEntity.Created_By,
                    this.PositionEntity.Created_By,
                    this.PositionEntity.Created_By,
                    "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.Close();



                }


                else
                {

                    return;
                }

            }
        }

        private void TxtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void CboDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.PositionEntity.Department_Id = this.CboUnit.SelectedValue.ToString();
            touch = 1;
        }

        private void MatbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboDepartment_Click(object sender, EventArgs e)
        {
            this.LoadUnit();
        }

        private void CbDepartment_Click(object sender, EventArgs e)
        {
            this.LoadUnit();
            this.touch = 1;
        }

        private void CbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.PositionEntity.Department_Id = this.CboUnit.SelectedValue.ToString();
  
        }
    }
}
